using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HealthMate_UI
{
    public class DatabaseManager
    {
        private SqlConnection sqlConnection;

        public DatabaseManager()
        {
            string connectionString = @"Data Source=DESKTOP-QUB8L8T\SQLEXPRESS;Initial Catalog=UserInfoDB;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
        }

        public void OpenConnection()
        {
            if (sqlConnection.State != System.Data.ConnectionState.Open)
            {
                sqlConnection.Open();
            }
        }

        public void CloseConnection()
        {
            if (sqlConnection.State != System.Data.ConnectionState.Closed)
            {
                sqlConnection.Close();
            }
        }

        public SqlConnection GetConnection()
        {
            return sqlConnection;
        }
    }
}