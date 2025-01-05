using Coursework;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
	public class Order
	{
		public int OrderID { get; set; }
		public int UserID { get; set; }
		public DateTime FormationDate { get; set; }
		public TimeSpan FormationTime { get; set; }
		public int TotalQuantity { get; set; }
		public int TotalPrice { get; set; }
		public string Status { get; set; }
		public string Comment { get; set; }
		public Address Address { get; set; }

		public static List<Order> GetOrdersForUserWithFilters(int userId, string searchRequest, string orderBy, DateTime fromDate, DateTime toDate, string statuses)
		{
			List<Order> orders = new List<Order>();

			try
			{
				OSDataBase.openConnection();

				string query = $@"SELECT 
									DISTINCT o.order_number,
									o.formation_date,
									o.formation_time,
									o.quantity_of_goods,
									o.total_price_of_the_order,
									o.status,
									o.comment,
									a.address_id,
									a.postal_index,
									a.country,
									a.region,
									a.city,
									a.street,
									a.house,
									a.apartment
								FROM 
									[Order] o
								JOIN 
									Address a ON o.address_id = a.address_id
								JOIN 
									Item_Order io ON o.order_number = io.order_number
								JOIN 
									Item i ON io.item_id = i.item_id
								WHERE 
									o.number_of_the_client_card = @userId
									AND o.formation_date BETWEEN @fromDate AND @toDate
									AND o.status IN ({statuses})";
				if (!string.IsNullOrEmpty(searchRequest))
				{
					query += @" AND i.name_of_the_product LIKE @searchRequest";
				}

				query += " ORDER BY " + orderBy;

				SqlCommand command = new SqlCommand(query, OSDataBase.getConnection());
				command.Parameters.AddWithValue(@"userId", userId);
				command.Parameters.AddWithValue(@"fromDate", fromDate);
				command.Parameters.AddWithValue(@"toDate", toDate);
				command.Parameters.AddWithValue(@"statuses", statuses);

				if (!string.IsNullOrEmpty(searchRequest))
				{
					command.Parameters.AddWithValue("@searchRequest", "%" + searchRequest + "%");
				}
				else
				{
					command.Parameters.AddWithValue("@searchRequest", "%");
				}

				SqlDataReader reader = command.ExecuteReader();
				while (reader.Read())
				{
					Order order = new Order();
					order.OrderID = (int)reader["order_number"];
					order.UserID = userId;
					order.FormationDate = (DateTime)reader["formation_date"];
					order.FormationTime = (TimeSpan)reader["formation_time"];
					order.TotalQuantity = (int)reader["quantity_of_goods"];
					order.TotalPrice = (int)reader["total_price_of_the_order"];
					order.Status = (string)reader["status"];
					order.Comment = (string)reader["comment"];

					order.Address = new Address
					{
						AddressID = (int)reader["address_id"],
						UserID = userId,
						Country = (string)reader["country"],
						Region = (string)reader["region"],
						City = (string)reader["city"],
						Street = (string)reader["street"],
						House = (int)reader["house"],
						Apartment = (int)reader["apartment"],
						PostalIndex = (string)reader["postal_index"],
						IsPreferred = false,
					};

					orders.Add(order);
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error: " + ex.Message);
			}
			finally
			{
				OSDataBase.closeConnection();
			}

			return orders;
		}

		public static Order GetOrderById(int orderId)
		{
			Order order = new Order();

			try
			{
				OSDataBase.openConnection();

				string query = $@"SELECT DISTINCT 
									o.order_number,
									o.number_of_the_client_card,
									o.formation_date,
									o.formation_time,
									o.quantity_of_goods,
									o.total_price_of_the_order,
									o.status,
									o.comment,
									a.address_id,
									a.postal_index,
									a.country,
									a.region,
									a.city,
									a.street,
									a.house,
									a.apartment
								FROM 
									[Order] o
								JOIN 
									Address a ON o.address_id = a.address_id
								WHERE 
									o.order_number = @orderId";

				SqlCommand command = new SqlCommand(query, OSDataBase.getConnection());
				command.Parameters.AddWithValue(@"orderId", orderId);

				SqlDataReader reader = command.ExecuteReader();
				if (reader.Read())
				{
					order.OrderID = (int)reader["order_number"];
					order.UserID = (int)reader["number_of_the_client_card"];
					order.FormationDate = (DateTime)reader["formation_date"];
					order.FormationTime = (TimeSpan)reader["formation_time"];
					order.TotalQuantity = (int)reader["quantity_of_goods"];
					order.TotalPrice = (int)reader["total_price_of_the_order"];
					order.Status = (string)reader["status"];
					order.Comment = (string)reader["comment"];

					order.Address = new Address
					{
						AddressID = (int)reader["address_id"],
						UserID = (int)reader["number_of_the_client_card"],
						Country = (string)reader["country"],
						Region = (string)reader["region"],
						City = (string)reader["city"],
						Street = (string)reader["street"],
						House = (int)reader["house"],
						Apartment = (int)reader["apartment"],
						PostalIndex = (string)reader["postal_index"],
						IsPreferred = false,
					};
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error: " + ex.Message);
			}
			finally
			{
				OSDataBase.closeConnection();
			}

			return order;
		}

		public static void CreateOrder(int userId, int addressId, string comment)
		{
			OSDataBase.openConnection();
			SqlConnection connection = OSDataBase.getConnection();

			SqlTransaction transaction = connection.BeginTransaction();

			try
			{
				// SQL-запит для перенесення айтемів з кошика в замовлення
				string sqlQuery = @"BEGIN TRANSACTION;

									DECLARE @new_order_number INT;

									INSERT INTO [Order] (
										number_of_the_client_card, 
										formation_date, 
										formation_time, 
										quantity_of_goods, 
										total_price_of_the_order, 
										status, 
										address_id, 
										comment
									)
									SELECT 
										c.number_of_the_client_card,
										GETDATE(), 
										CAST(GETDATE() AS TIME),
										c.quantity_of_goods,
										c.total_price_of_the_cart,
										'Прийнято',
										@address_id,
										@comment
									FROM Cart c
									WHERE c.number_of_the_client_card = @number_of_the_client_card;

									SET @new_order_number = SCOPE_IDENTITY();

									INSERT INTO Item_Order (order_number, item_id, quantity_in_order)
									SELECT 
										@new_order_number,
										ic.item_id,
										ic.quantity_in_cart
									FROM Item_Cart ic
									JOIN Cart c ON ic.cart_id = c.cart_id
									WHERE c.number_of_the_client_card = @number_of_the_client_card;

									DELETE FROM Item_Cart
									WHERE cart_id = (SELECT cart_id FROM Cart WHERE number_of_the_client_card = @number_of_the_client_card);

									COMMIT TRANSACTION;";

				SqlCommand command = new SqlCommand(sqlQuery, connection, transaction);
				// Додаємо параметр
				command.Parameters.AddWithValue(@"number_of_the_client_card", userId);
				command.Parameters.AddWithValue(@"address_id", addressId);
				command.Parameters.AddWithValue(@"comment", comment);

				// Виконуємо запит
				command.ExecuteNonQuery();

				// Підтверджуємо транзакцію
				transaction.Commit();
			}
			catch (Exception ex)
			{
				// Відміняємо транзакцію у разі помилки
				transaction.Rollback();
				Console.WriteLine("Помилка: " + ex.Message);
			}
			finally
			{
				OSDataBase.closeConnection();
			}
		}

		public static List<Item> GetItemsInOrder(int orderId)
		{
			List<Item> items = new List<Item>();

			try
			{
				OSDataBase.openConnection();

				string query = $@"SELECT 
									i.item_id,
									i.name_of_the_product,
									i.cost,
									i.description,
									io.quantity_in_order,
									i.count_of,
									i.producer
								FROM 
									Item_Order io
								JOIN 
									Item i ON io.item_id = i.item_id
								WHERE 
									io.order_number = @orderId;";

				SqlCommand command = new SqlCommand(query, OSDataBase.getConnection());
				command.Parameters.AddWithValue(@"orderId", orderId);

				SqlDataReader reader = command.ExecuteReader();
				while (reader.Read())
				{
					Item item = new Item();
					item.ItemID = (int)reader["item_id"];
					item.NameOfTheProduct = (string)reader["name_of_the_product"];
					item.Cost = (int)reader["cost"];
					item.Description = (string)reader["description"];
					item.Producer = (string)reader["producer"];
					item.CountOfInOrder = (int)reader["quantity_in_order"];
					item.CountOf = (int)reader["count_of"];

					items.Add(item);
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error: " + ex.Message);
			}
			finally
			{
				OSDataBase.closeConnection();
			}

			return items;
		}

		public static void CancelOrder(int orderId)
		{
			try
			{
				OSDataBase.openConnection();

				string query = $@"UPDATE [Order]
									SET status = 'Скасовано'
									WHERE order_number = @orderId;";

				SqlCommand command = new SqlCommand(query, OSDataBase.getConnection());
				command.Parameters.AddWithValue(@"orderId", orderId);

				command.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error: " + ex.Message);
			}
			finally
			{
				OSDataBase.closeConnection();
			}
		}

		public static void UpdateOrderStatusesAndItemsCount()
		{
			OSDataBase.openConnection();
			SqlConnection connection = OSDataBase.getConnection();

			SqlTransaction transaction = connection.BeginTransaction();

			try
			{
				// SQL-запит для перенесення айтемів з кошика в замовлення
				string sqlQuery = @"BEGIN TRANSACTION;

									UPDATE [Order]
									SET status = CASE
													WHEN DATEDIFF(MINUTE, CAST(formation_time AS DATETIME) + CAST(formation_date AS DATETIME), GETDATE()) >= 4 AND status = 'В обробці' THEN 'Виконано'
													WHEN DATEDIFF(MINUTE, CAST(formation_time AS DATETIME) + CAST(formation_date AS DATETIME), GETDATE()) >= 2 AND status = 'Прийнято' THEN 'В обробці'
													ELSE status
												 END
									WHERE status IN ('Прийнято', 'В обробці');

									UPDATE Item
									SET count_of = count_of - io.quantity_in_order
									FROM Item i
									JOIN Item_Order io ON i.item_id = io.item_id
									JOIN [Order] o ON io.order_number = o.order_number
									WHERE o.status = 'В обробці';

									COMMIT TRANSACTION;";

				SqlCommand command = new SqlCommand(sqlQuery, connection, transaction);

				// Виконуємо запит
				command.ExecuteNonQuery();

				// Підтверджуємо транзакцію
				transaction.Commit();
			}
			catch (Exception ex)
			{
				// Відміняємо транзакцію у разі помилки
				transaction.Rollback();
				Console.WriteLine("Помилка: " + ex.Message);
			}
			finally
			{
				OSDataBase.closeConnection();
			}
		}

		public static Dictionary<string, int> GetOrdersStats(int userId)
		{
			Dictionary<string, int> stats = new Dictionary<string, int>();

			try
			{
				OSDataBase.openConnection();

				string query = $@"SELECT
									status,
									COUNT(*) AS s_count
								FROM [Order]
								WHERE number_of_the_client_card = @userId
								GROUP BY status;";

				SqlCommand command = new SqlCommand(query, OSDataBase.getConnection());
				command.Parameters.AddWithValue(@"userId", userId);

				SqlDataReader reader = command.ExecuteReader();
				while (reader.Read())
				{
					string status = (string)reader["status"];
					int count = (int)reader["s_count"];

					stats.Add(status, count);
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error: " + ex.Message);
			}
			finally
			{
				OSDataBase.closeConnection();
			}

			return stats;
		}
	}
}