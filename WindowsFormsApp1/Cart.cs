using Coursework;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
	internal class Cart
	{
		public int CartID { get; set; } = -1;
		public int UserID { get; set; }
		public int Quantity { get; set; }
		public int TotalPrice { get; set; }

		public static Cart GetCartForUser(int userId)
		{
			Cart cart = null;
			try
			{
				OSDataBase.openConnection();

				string query = "SELECT cart_id, number_of_the_client_card, quantity_of_goods, total_price_of_the_cart FROM Cart WHERE number_of_the_client_card = @userId";
				SqlCommand command = new SqlCommand(query, OSDataBase.getConnection());
				command.Parameters.AddWithValue("@userId", userId);

				SqlDataReader reader = command.ExecuteReader();
				if (reader.Read())
				{
					cart = new Cart
					{
						CartID = (int)reader["cart_id"],
						UserID = (int)reader["number_of_the_client_card"],
						Quantity = (int)reader["quantity_of_goods"],
						TotalPrice = (int)reader["total_price_of_the_cart"],
					};
				}
				reader.Close();
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error retrieving cart data: " + ex.Message);
			}
			finally
			{
				OSDataBase.closeConnection();
			}

			return cart;
		}

		public static void CreateCartForUser(int userId)
		{
			try
			{
				OSDataBase.openConnection();
				SqlConnection connection = OSDataBase.getConnection();
				string query;
				SqlCommand command;

				query = $@"INSERT INTO Cart (number_of_the_client_card, quantity_of_goods, total_price_of_the_cart)
									VALUES (@userId, 0, 0)
									SELECT SCOPE_IDENTITY()";

				command = new SqlCommand(query, connection);
				command.Parameters.AddWithValue(@"userId", userId);

				object result = command.ExecuteScalar();
				Decimal insertedAddressId = (Decimal)result;
				int cartId = (int)insertedAddressId;

				Cart cart = new Cart
				{
					CartID = cartId,
					UserID = userId,
					Quantity = 0,
					TotalPrice = 0,
				};
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

		public static void AddItemInCart(int userId, int itemId)
		{
			try
			{
				OSDataBase.openConnection();
				SqlConnection connection = OSDataBase.getConnection();
				string query;
				SqlCommand command;

				query = $@"INSERT INTO Item_Cart (cart_id, item_id, quantity_in_cart)
							VALUES (
								(SELECT cart_id FROM Cart WHERE number_of_the_client_card = @userId),
								@itemId,
								1
							)";

				command = new SqlCommand(query, connection);
				command.Parameters.AddWithValue(@"userId", userId);
				command.Parameters.AddWithValue(@"itemId", itemId);

				int rowsAffected = command.ExecuteNonQuery();
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

		public static bool CheckItemInCart(int userId, int itemId)
		{
			bool result = false;
			try
			{
				OSDataBase.openConnection();
				SqlConnection connection = OSDataBase.getConnection();
				string query;
				SqlCommand command;

				query = $@"SELECT 
							CASE 
								WHEN EXISTS (
									SELECT 1
									FROM Item_Cart ic
									INNER JOIN Cart c ON ic.cart_id = c.cart_id
									WHERE ic.item_id = @itemId AND c.number_of_the_client_card = @userId
								) THEN 1
								ELSE 0
							END AS IsItemInCart;";

				command = new SqlCommand(query, connection);
				command.Parameters.AddWithValue(@"userId", userId);
				command.Parameters.AddWithValue(@"itemId", itemId);

				int isExist = (int)command.ExecuteScalar();

				result = isExist == 1;
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error: " + ex.Message);
			}
			finally
			{
				OSDataBase.closeConnection();
			}

			return result;
		}

		public static List<Item> GetItemsInCart(int cartId)
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
									ic.quantity_in_cart,
									i.count_of,
									i.producer
								FROM 
									Item_Cart ic
								JOIN 
									Item i ON ic.item_id = i.item_id
								WHERE 
									ic.cart_id = @cartId;";

				SqlCommand command = new SqlCommand(query, OSDataBase.getConnection());
				command.Parameters.AddWithValue(@"cartId", cartId);

				SqlDataReader reader = command.ExecuteReader();
				while (reader.Read())
				{
					Item item = new Item();
					item.ItemID = (int)reader["item_id"];
					item.NameOfTheProduct = (string)reader["name_of_the_product"];
					item.Cost = (int)reader["cost"];
					item.Description = (string)reader["description"];
					item.Producer = (string)reader["producer"];
					item.CountOfInCart = (int)reader["quantity_in_cart"];
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

		public static void DeleteItemFromCart(int cartId, int itemId)
		{
			try
			{
				OSDataBase.openConnection();

				string query = $@"DELETE TOP(1) FROM Item_Cart WHERE cart_id = @cartId AND item_id = @itemId;";

				SqlCommand command = new SqlCommand(query, OSDataBase.getConnection());
				command.Parameters.AddWithValue(@"cartId", cartId);
				command.Parameters.AddWithValue(@"itemId", itemId);

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

		public static void IncreaseItemQuantity(int cartId, int itemId)
		{
			try
			{
				OSDataBase.openConnection();

				string query = $@"UPDATE Item_Cart
									SET quantity_in_cart = quantity_in_cart + 1
									WHERE item_id = @itemId 
									  AND cart_id = @cartId
									  AND quantity_in_cart + 1 <= (
										SELECT count_of
										FROM Item
										WHERE item_id = @itemId
									  );";

				SqlCommand command = new SqlCommand(query, OSDataBase.getConnection());
				command.Parameters.AddWithValue(@"cartId", cartId);
				command.Parameters.AddWithValue(@"itemId", itemId);

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

		public static void DecreaseItemQuantity(int cartId, int itemId)
		{
			try
			{
				OSDataBase.openConnection();

				string query = $@"UPDATE Item_Cart
									SET quantity_in_cart = quantity_in_cart - 1
									WHERE item_id = @itemId
									  AND cart_id = @cartId
									  AND quantity_in_cart - 1 >= 0;";

				SqlCommand command = new SqlCommand(query, OSDataBase.getConnection());
				command.Parameters.AddWithValue(@"cartId", cartId);
				command.Parameters.AddWithValue(@"itemId", itemId);

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
	}
}
