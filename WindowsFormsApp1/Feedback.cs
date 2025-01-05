using Coursework;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
	internal class Feedback
	{
		public int FeedbackID { get; set; }

		public DateTime WritingDate { get; set; }

		public string Comment { get; set; }

		public int Rating { get; set; }

		public string Name { get; set; }
		public string Surname { get; set; }
		public string Patronymic { get; set; }

		public int UserID { get; set; }

		public int ItemID { get; set; }

		public static List<Feedback> GetFeedbackForItem(int itemId)
		{
			List<Feedback> feedbacks = new List<Feedback>();
			try
			{
				OSDataBase.openConnection();

				string query = $@"SELECT 
									Feedback.feedback_id,
									Feedback.number_of_the_client_card,
									Feedback.item_id,
									Feedback.writing_date,
									Feedback.comment,
									Feedback.rating,
									[User].name, 
									[User].patronymic, 
									[User].surname
								FROM Feedback, [User]
								WHERE 
									Feedback.number_of_the_client_card = [User].number_of_the_client_card 
									AND Feedback.item_id = @itemId;";

				SqlCommand command = new SqlCommand(query, OSDataBase.getConnection());
				command.Parameters.AddWithValue(@"itemId", itemId);

				SqlDataReader reader = command.ExecuteReader();
				while (reader.Read())
				{
					Feedback feedback = new Feedback();
					feedback.FeedbackID = (int)reader["feedback_id"];
					feedback.UserID = (int)reader["number_of_the_client_card"];
					feedback.ItemID = (int)reader["item_id"];
					feedback.WritingDate = (DateTime)reader["writing_date"];
					feedback.Rating = (int)reader["rating"];

					feedback.Comment = reader.IsDBNull(reader.GetOrdinal("comment")) ? "" : reader.GetString(reader.GetOrdinal("comment"));

					feedback.Name = reader.IsDBNull(reader.GetOrdinal("name")) ? "" : reader.GetString(reader.GetOrdinal("name"));
					feedback.Surname = reader.IsDBNull(reader.GetOrdinal("surname")) ? "" : reader.GetString(reader.GetOrdinal("surname"));
					feedback.Patronymic = reader.IsDBNull(reader.GetOrdinal("patronymic")) ? "" : reader.GetString(reader.GetOrdinal("patronymic"));

					feedbacks.Add(feedback);
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

			return feedbacks;
		}

		public static void AddFeedbackForItemByUser(int userId, int itemId, string review, int rating)
		{
			try
			{
				OSDataBase.openConnection();
				SqlConnection connection = OSDataBase.getConnection();
				string query;
				SqlCommand command;

				// Add new Address
				query = $@"INSERT INTO Feedback (number_of_the_client_card, item_id, writing_date, comment, rating)
									VALUES (@userId, @itemId, GETDATE(), @review, @rating)
									SELECT SCOPE_IDENTITY()";

				command = new SqlCommand(query, connection);
				command.Parameters.AddWithValue(@"userId", userId);
				command.Parameters.AddWithValue(@"itemId", itemId);
				command.Parameters.AddWithValue(@"review", review);
				command.Parameters.AddWithValue(@"rating", rating);

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
