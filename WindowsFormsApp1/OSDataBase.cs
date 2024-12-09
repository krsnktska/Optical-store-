using System.Data.SqlClient;

namespace Coursework
{
	internal class OSDataBase
	{
		SqlConnection sqlconnection = new SqlConnection(@"Data Source=DESKTOP-DC4VJD6;Initial Catalog=""OpticalStore"";Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

		public void openConnection()
		{
			if (sqlconnection.State == System.Data.ConnectionState.Closed)
			{
				sqlconnection.Open();
			}

		}

		public void closeConnection()
		{
			if (sqlconnection.State == System.Data.ConnectionState.Open)
			{
				sqlconnection.Close();
			}
		}

		public SqlConnection getConnection()
		{
			return sqlconnection;
		}
	}
}
