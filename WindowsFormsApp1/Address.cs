using Coursework;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
	public class Address
	{
		public int AddressID { get; set; } = -1;
		public int UserID { get; set; } = -1;
		public string Country { get; set; } = "";
		public string Region { get; set; } = "";
		public string City { get; set; } = "";
		public string Street { get; set; } = "";
		public int House { get; set; } = 0;
		public int Apartment { get; set; } = 0;
		public string PostalIndex { get; set; } = "";
		public bool IsPreferred { get; set; } = false;

		public static List<Address> GetAddressesForUser(int userId)
		{
			List<Address> addresses = new List<Address>();
			try
			{
				OSDataBase.openConnection();

				string query = $@"SELECT 
									Address.address_id,	Address.postal_index, Address.country, 
									Address.region,	Address.city, Address.street, Address.house, 
									Address.apartment, [User].number_of_the_client_card, User_Address.is_preferred
								FROM 
									[User], Address, User_Address
								WHERE 
									User_Address.number_of_the_client_card = [User].number_of_the_client_card
									AND User_Address.address_id = Address.address_id
									AND [User].number_of_the_client_card = @userId
								ORDER BY User_Address.is_preferred DESC;";

				SqlCommand command = new SqlCommand(query, OSDataBase.getConnection());
				command.Parameters.AddWithValue(@"userId", userId);

				SqlDataReader reader = command.ExecuteReader();
				while (reader.Read())
				{
					Address address = new Address();
					address.AddressID = (int)reader["address_id"];
					address.UserID = (int)reader["number_of_the_client_card"];
					address.Apartment = (int)reader["apartment"];
					address.House = (int)reader["house"];
					address.Street = (string)reader["street"];
					address.City = (string)reader["city"];
					address.Country = (string)reader["country"];
					address.Region = (string)reader["region"];
					address.PostalIndex = (string)reader["postal_index"];
					address.IsPreferred = (bool)reader["is_preferred"];

					addresses.Add(address);
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

			return addresses;
		}

		public static void SetAddressPreferred(int addressId, int userId)
		{
			try
			{
				OSDataBase.openConnection();

				string query = $@"UPDATE User_Address
									SET is_preferred = CASE 
										WHEN address_id = @addressId THEN 1
										ELSE 0
									END
									WHERE number_of_the_client_card = @userId;";

				SqlCommand command = new SqlCommand(query, OSDataBase.getConnection());
				command.Parameters.AddWithValue(@"addressId", addressId);
				command.Parameters.AddWithValue(@"userId", userId);

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

		public void Update()
		{
			try
			{
				OSDataBase.openConnection();
				SqlConnection connection = OSDataBase.getConnection();
				string query;
				SqlCommand command;

				// Add new Address
				query = $@"INSERT INTO Address (postal_index, country, region, city, street, house, apartment)
									VALUES (@postal_index, @country, @region, @city, @street, @house, @apartment)
									SELECT SCOPE_IDENTITY()";

				command = new SqlCommand(query, connection);
				command.Parameters.AddWithValue(@"postal_index", PostalIndex);
				command.Parameters.AddWithValue(@"country", Country);
				command.Parameters.AddWithValue(@"region", Region);
				command.Parameters.AddWithValue(@"city", City);
				command.Parameters.AddWithValue(@"street", Street);
				command.Parameters.AddWithValue(@"house", House);
				command.Parameters.AddWithValue(@"apartment", Apartment);

				object result = command.ExecuteScalar();
				Decimal insertedAddressId = (Decimal)result;

				// Delete last connection
				query = $@"DELETE User_Address WHERE address_id = @address_id AND number_of_the_client_card = @userId";
				command = new SqlCommand(query, connection);
				command.Parameters.AddWithValue(@"address_id", AddressID);
				command.Parameters.AddWithValue(@"userId", UserID);

				command.ExecuteScalar();

				// Add new connection
				query = $@"INSERT INTO User_Address (is_preferred, address_id, number_of_the_client_card)
							VALUES (@is_preferred, @address_id, @userId)";
				command = new SqlCommand(query, connection);
				command.Parameters.AddWithValue(@"address_id", insertedAddressId);
				command.Parameters.AddWithValue(@"userId", UserID);
				command.Parameters.AddWithValue(@"is_preferred", IsPreferred);

				command.ExecuteScalar();
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

		public void Create()
		{
			try
			{
				OSDataBase.openConnection();
				SqlConnection connection = OSDataBase.getConnection();
				string query;
				SqlCommand command;

				// Add new Address
				query = $@"INSERT INTO Address (postal_index, country, region, city, street, house, apartment)
									VALUES (@postal_index, @country, @region, @city, @street, @house, @apartment)
									SELECT SCOPE_IDENTITY()";

				command = new SqlCommand(query, connection);
				command.Parameters.AddWithValue(@"postal_index", PostalIndex);
				command.Parameters.AddWithValue(@"country", Country);
				command.Parameters.AddWithValue(@"region", Region);
				command.Parameters.AddWithValue(@"city", City);
				command.Parameters.AddWithValue(@"street", Street);
				command.Parameters.AddWithValue(@"house", House);
				command.Parameters.AddWithValue(@"apartment", Apartment);

				object result = command.ExecuteScalar();
				Decimal insertedAddressId = (Decimal)result;
				AddressID = (int)insertedAddressId;

				// Add new connection
				query = $@"INSERT INTO User_Address (is_preferred, address_id, number_of_the_client_card)
							VALUES (0, @address_id, @userId)";
				command = new SqlCommand(query, connection);
				command.Parameters.AddWithValue(@"address_id", insertedAddressId);
				command.Parameters.AddWithValue(@"userId", UserID);

				command.ExecuteScalar();
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

		public void Delete()
		{
			try
			{
				OSDataBase.openConnection();
				SqlConnection connection = OSDataBase.getConnection();
				string query;
				SqlCommand command;

				// Delete last connection
				query = $@"DELETE User_Address WHERE address_id = @address_id AND number_of_the_client_card = @userId";
				command = new SqlCommand(query, connection);
				command.Parameters.AddWithValue(@"address_id", AddressID);
				command.Parameters.AddWithValue(@"userId", UserID);

				command.ExecuteScalar();
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

		public override string ToString()
		{
			return $@"{Country}, {PostalIndex}, {Region}, {City}, {Street} {House}, кв. {Apartment}";
		}
	}
}
