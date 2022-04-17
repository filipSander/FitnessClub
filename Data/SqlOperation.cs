using FitnessClub.Forms;
using System.Data;
using System.Data.SqlClient;

namespace FitnessClub.Data
{
    public class SqlOperation
    {
        #region constructor

        public DBContext DBcontext;
        public SqlOperation()
            => DBcontext = new DBContext();

        #endregion

        // select

        public DataTable RequestTable(SqlCommand command)
        {
            DataTable table = new DataTable();
            if (DBcontext.ValidConection())
            {
                DBcontext.OpenConnection();
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                adapter.Fill(table);
                DBcontext.CloseConnection();
            }
            else
                new Error("Ошибка соединения с бд.").Show();
            return table;
        }

        // grud 
        public bool Request(SqlCommand command)
        {
            if (DBcontext.ValidConection())
            {
                DBcontext.OpenConnection();
                if (command.ExecuteNonQuery() > 0)
                    return true;
                DBcontext.CloseConnection();
            }
            else new Error("Ошибка соединения с бд.").Show();
                
            return false;
        }


    }
}
