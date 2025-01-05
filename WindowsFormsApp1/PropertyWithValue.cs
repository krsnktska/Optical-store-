using Coursework;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
	internal class PropertyWithValue
	{
		public int PropertyID { get; set; }

		public string Type { get; set; }

		public string Value { get; set; }

		public static List<PropertyWithValue> GetPropsForItem(int itemId)
		{
			List<PropertyWithValue> props = new List<PropertyWithValue>();
			try
			{
				OSDataBase.openConnection();

				string query = $@"SELECT Property.property_id, Property.type, Item_Property.value
								FROM Property, Item_Property, Item
								WHERE 
									Property.property_id = Item_Property.property_id
									AND Item.item_id = Item_Property.item_id
									AND Item.item_id = @itemId;";

				SqlCommand command = new SqlCommand(query, OSDataBase.getConnection());
				command.Parameters.AddWithValue(@"itemId", itemId);

				SqlDataReader reader = command.ExecuteReader();
				while (reader.Read())
				{
					PropertyWithValue prop = new PropertyWithValue();
					prop.PropertyID = (int)reader["property_id"];
					prop.Type = (string)reader["type"];
					prop.Value = (string)reader["value"];

					props.Add(prop);
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

			return props;
		}
	}
}
