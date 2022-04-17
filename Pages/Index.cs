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
    public partial class Index : UserControl
    {
        public Index()
        {
            InitializeComponent();
            act();
        }


        private void act()
        {
            checkCouterpatyCount();
            lblCountLesson.Text = checkCount("Lesson");
            lblCountSub.Text = checkCount("Subscription");
        }

        private string checkCount(string _table)
        {
            SqlOperation operation = new SqlOperation();
            SqlCommand command = new SqlCommand($"Select Count(*) as [Count] from [{_table}]", operation.DBcontext.GetConnection());
            DataTable table = operation.RequestTable(command);
            return table.Rows[0].Field<int>("Count").ToString();
        }

        private void checkCouterpatyCount()
        {
            SqlOperation operation = new SqlOperation();
            SqlCommand command = new SqlCommand("Select [Type] from [Counterparty]", operation.DBcontext.GetConnection());
            DataTable table = operation.RequestTable(command);
            int userCount, workerCount;
            userCount = workerCount = 0;
            if (table.Rows.Count > 0)
            {
                for(int i = 0; i < table.Rows.Count; i++)
                    if (table.Rows[i].Field<int>("Type") == 0) workerCount++;
                    else userCount++;

                lblCountUser.Text = userCount.ToString();
                lblCountWorker.Text = workerCount.ToString();
            }
        }
    }
}
