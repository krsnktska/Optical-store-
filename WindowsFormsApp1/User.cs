using Coursework;
using System;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
	internal class User
	{
		public string Surname { get; set; }
		public string Name { get; set; }
		public string Patronymic { get; set; }
		public string PhoneNumber { get; set; }
		public string Email { get; set; }
		public string Sex { get; set; }

		public static User GetUserData(int userId)
		{
			User user = null;
			try
			{
				OSDataBase.openConnection();

				string query = "SELECT surname, name, patronymic, phone_number, email, sex FROM [User] WHERE number_of_the_client_card = @userId";
				SqlCommand command = new SqlCommand(query, OSDataBase.getConnection());
				command.Parameters.AddWithValue("@userId", userId);

				SqlDataReader reader = command.ExecuteReader();
				if (reader.Read())
				{
					user = new User
					{
						Surname = reader["surname"].ToString(),
						Name = reader["name"].ToString(),
						Patronymic = reader["patronymic"].ToString(),
						PhoneNumber = reader["phone_number"].ToString(),
						Email = reader["email"].ToString(),
						Sex = reader["sex"].ToString()
					};
				}
				reader.Close();
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error retrieving user data: " + ex.Message);
			}
			finally
			{
				OSDataBase.closeConnection();
			}

			return user;
		}

		public static bool UpdateUserData(int userId, string surname, string name, string patronymic, string phoneNumber, string email, string sex)
		{
			try
			{
				OSDataBase.openConnection();

				string query = "UPDATE [User] SET surname = @surname, name = @name, patronymic = @patronymic, phone_number = @phoneNumber, email = @email, sex = @sex WHERE number_of_the_client_card = @userId";
				SqlCommand command = new SqlCommand(query, OSDataBase.getConnection());
				command.Parameters.AddWithValue("@userId", userId);
				command.Parameters.AddWithValue("@surname", surname);
				command.Parameters.AddWithValue("@name", name);
				command.Parameters.AddWithValue("@patronymic", patronymic);
				command.Parameters.AddWithValue("@phoneNumber", phoneNumber);
				command.Parameters.AddWithValue("@email", email);
				command.Parameters.AddWithValue("@sex", sex);

				int rowsAffected = command.ExecuteNonQuery();
				return rowsAffected > 0;
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error updating user data: " + ex.Message);
				return false;
			}
			finally
			{
				OSDataBase.closeConnection();

			}
		}
	}
}
