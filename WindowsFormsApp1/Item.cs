﻿using Coursework;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace WindowsFormsApp1
{
	public class Item
	{
		public int ItemID { get; set; }
		public string NameOfTheProduct { get; set; }
		public int Cost { get; set; }
		public string Description { get; set; }
		public int CountOf { get; set; }
		public string Producer { get; set; }

		public static List<Item> GetItemsByFilters(string searchRequest, string orderBy, int fromQuantity, int forQuantity, int fromCost, int forCost)
		{
			List<Item> items = new List<Item>();

			try
			{
				OSDataBase.openConnection();

				string query = $@"SELECT I.item_id, I.name_of_the_product, I.cost, I.description, I.count_of, I.producer
								FROM Item I
								WHERE I.cost BETWEEN @fromCost AND @forCost
								AND I.count_of BETWEEN @fromQuantity AND @forQuantity";
				if (!string.IsNullOrEmpty(searchRequest))
				{
					query += @" AND I.name_of_the_product LIKE @searchRequest";
				}

				query += " ORDER BY " + orderBy;

				SqlCommand command = new SqlCommand(query, OSDataBase.getConnection());
				command.Parameters.AddWithValue(@"fromCost", fromCost);
				command.Parameters.AddWithValue(@"forCost", forCost);
				command.Parameters.AddWithValue("@fromQuantity", fromQuantity);
				command.Parameters.AddWithValue("@forQuantity", forQuantity);

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
					Item item = new Item();
					item.ItemID = (int)reader["item_id"];
					item.NameOfTheProduct = (string)reader["name_of_the_product"];
					item.Cost = (int)reader["cost"];
					item.Description = (string)reader["description"];
					item.CountOf = (int)reader["count_of"];
					item.Producer = (string)reader["producer"];

					items.Add(item);

					Console.Write(item.ItemID + "");
					Console.Write(item.NameOfTheProduct + "");
					Console.Write(item.Cost + "");
					Console.Write(item.Description + "");
					Console.Write(item.CountOf + "");
					Console.WriteLine(item.Producer);
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

		public static int[] MinMaxCost()
		{
			try
			{
				OSDataBase.openConnection();

				string query = @"SELECT MIN(cost) AS minCost, MAX(cost) AS maxCost FROM Item";
				int[] costs = new int[2];

				SqlCommand command = new SqlCommand(query, OSDataBase.getConnection());
				SqlDataReader reader = command.ExecuteReader();
				if (reader.Read())
				{
					costs[0] = reader.IsDBNull(reader.GetOrdinal("minCost")) ? 0 : reader.GetInt32(reader.GetOrdinal("minCost"));
					costs[1] = reader.IsDBNull(reader.GetOrdinal("maxCost")) ? 0 : reader.GetInt32(reader.GetOrdinal("maxCost"));
				}
				return costs;
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Помилка: {ex.Message}");
				return new int[] { 0, int.MaxValue };
			}
			finally
			{
				OSDataBase.closeConnection();
			}
		}

		public static int[] MinMaxQuantity()
		{
			try
			{
				OSDataBase.openConnection();

				string query = @"SELECT MIN(count_of) AS minQuantity, MAX(count_of) AS maxQuantity FROM Item";
				int[] quantities = new int[2];

				SqlCommand command = new SqlCommand(query, OSDataBase.getConnection());
				SqlDataReader reader = command.ExecuteReader();
				if (reader.Read())
				{
					quantities[0] = reader.IsDBNull(reader.GetOrdinal("minQuantity")) ? 0 : reader.GetInt32(reader.GetOrdinal("minQuantity"));
					quantities[1] = reader.IsDBNull(reader.GetOrdinal("maxQuantity")) ? 0 : reader.GetInt32(reader.GetOrdinal("maxQuantity"));
				}
				return quantities;
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Помилка: {ex.Message}");
				return new int[] { 0, int.MaxValue };
			}
			finally
			{
				OSDataBase.closeConnection();
			}
		}
	}
}