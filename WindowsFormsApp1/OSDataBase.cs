using System.Data.SqlClient;

namespace Coursework
{
	internal class OSDataBase
	{
		static SqlConnection sqlconnection = new SqlConnection(@"Data Source=DESKTOP-DC4VJD6;Initial Catalog=""OpticalStore"";Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

		public static void openConnection()
		{
			if (sqlconnection.State == System.Data.ConnectionState.Closed)
			{
				sqlconnection.Open();
			}
		}

		public static void closeConnection()
		{
			if (sqlconnection.State == System.Data.ConnectionState.Open)
			{
				sqlconnection.Close();
			}
		}

		public static SqlConnection getConnection()
		{
			return sqlconnection;
		}
	}
}
