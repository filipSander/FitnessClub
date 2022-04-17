using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace FitnessClub.Data
{
    public class DBContext
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlServerConnection"].ConnectionString);

        public bool ValidConection()
        {
            try
            {
                connection.Open();
                connection.Close();
                return true;
            }
            catch { return false; }
        }

        public void OpenConnection()
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
        }

        public void CloseConnection()
        {
            if (connection.State == ConnectionState.Open)
                connection.Close();
        }

        public SqlConnection GetConnection()
        {
            return connection;
        }


    }
}
