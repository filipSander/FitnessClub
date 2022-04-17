using FitnessClub.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                    scheduleView1.AddLesson(table.Rows[i].Field<string>("Name"), table.Rows[i].Field<string>("TimeSpending"), table.Rows[i].Field<int>("DayWeek"));
            }
        }
    }
}
