using FitnessClub.Data;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FitnessClub.Pages
{
    public partial class Schedule : UserControl
    {
        public Schedule()
        {
            InitializeComponent();
            act();
        }

        #region -- client part --
        string nameUser;
        public Schedule(string userName)
        {
            InitializeComponent();
            nameUser = userName;
            actUser();
        }

        List<int> subID;
        List<int> lessID;
        int couterpatyID;
        private void actUser()
        {
            couterpatyID = getcouterpatyID(nameUser);
            lessID = new List<int>();
            subID = new List<int>();

            getSubID();
            getLessID();
            checkUserLesson();
        }

        private void checkUserLesson()
        {
            scheduleView1.Clear();
            SqlOperation operation = new SqlOperation();
            if(lessID.Count > 0)
                for(int i = 0; i < lessID.Count; i++)
                {
                    SqlCommand command = new SqlCommand("select * from [Lesson] where [LessonID] = " + lessID[i], operation.DBcontext.GetConnection());
                    DataTable table = operation.RequestTable(command);
                    if(table.Rows.Count > 0)
                        scheduleView1.AddLesson(table.Rows[0].Field<string>("Name"), table.Rows[0].Field<string>("TimeSpending"), table.Rows[0].Field<int>("DayWeek"));
                }
        }

        private void getLessID()
        {
            SqlOperation operation = new SqlOperation();
            for (int i = 0; i < subID.Count; i++)
            {
                SqlCommand command = new SqlCommand("Select [LessonID] from [SubLesson] where [SubID] = " + subID[i], operation.DBcontext.GetConnection());
                DataTable table = operation.RequestTable(command);
                if (table.Rows.Count > 0)
                    for (int j = 0; j < table.Rows.Count; j++)
                        lessID.Add(table.Rows[j].Field<int>("LessonID"));
            }
        }
        private void getSubID()
        {
            SqlOperation operation = new SqlOperation();
            SqlCommand command = new SqlCommand("Select [SubID] from [CaSub] where [CounterpartyID] = " + couterpatyID, operation.DBcontext.GetConnection());
            DataTable table = operation.RequestTable(command);
            if (table.Rows.Count > 0)
                for (int i = 0; i < table.Rows.Count; i++)
                    subID.Add(table.Rows[i].Field<int>("SubID"));
        }
        private int getcouterpatyID(string _login)
        {
            SqlOperation operation = new SqlOperation();
            SqlCommand command = new SqlCommand("Select [CounterpartyID] from [User] where [Login] = @lg", operation.DBcontext.GetConnection());
            command.Parameters.Add("lg", SqlDbType.NVarChar).Value = _login;
            DataTable table = operation.RequestTable(command);
            if (table.Rows.Count > 0)
                return table.Rows[0].Field<int>("CounterpartyID");
            return 0;
        }
        #endregion

        private void act()
        {
            checkLesson();
        }

        private void checkLesson()
        {
            scheduleView1.Clear();
            SqlOperation operation = new SqlOperation();
            SqlCommand command = new SqlCommand("select * from [Lesson] order by [LessonID] desc ", operation.DBcontext.GetConnection());
            DataTable table = operation.RequestTable(command);
            if (table.Rows.Count > 0)
            {
                for (int i = 0; i < table.Rows.Count; i++)
                    scheduleView1.AddLesson(
                        table.Rows[i].Field<string>("Name"), 
                        table.Rows[i].Field<string>("TimeSpending"), 
                        table.Rows[i].Field<int>("DayWeek"),
                        table.Rows[i].Field<int>("LessonID"), 
                        table.Rows[i].Field<int>("Status")
                    );
            }
        }
    }
}
