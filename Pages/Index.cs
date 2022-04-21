﻿using FitnessClub.Data;
using System.Data;
using System.Data.SqlClient;
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
        private string nameUser = "Не найденно";
        public Index(string _nameUser)
        {
            InitializeComponent();
            nameUser = _nameUser;
            actUser();
        }

        int couterpatyID;
        private void actUser()
        {
            userContent.Visible = true;
            adminContent.Visible = false;
            lblNameUser.Text = nameUser;
            couterpatyID = getCaID(nameUser);
            checkUserSub();
        }

        private int getCaID(string _login)
        {

            SqlOperation operation = new SqlOperation();
            SqlCommand command = new SqlCommand("Select [CounterpartyID] from [User] where [Login] = @lg", operation.DBcontext.GetConnection());
            command.Parameters.Add("lg", SqlDbType.NVarChar).Value = _login;
            DataTable table = operation.RequestTable(command);
            if (table.Rows.Count > 0)
                return table.Rows[0].Field<int>("CounterpartyID");
            return 0;
        }

        private void checkUserSub()
        {
            SqlOperation operation = new SqlOperation();
            SqlCommand command = new SqlCommand("Select [SubID] from [CaSub] where [CounterpartyID] = " + couterpatyID, operation.DBcontext.GetConnection());
            DataTable table = operation.RequestTable(command);
            if (table.Rows.Count > 0)
            {
                fillSubName(table.Rows[0].Field<int>("SubID"));
                fillInput(table.Rows[0].Field<int>("SubID"));
            }
        }

        private void fillInput(int _SubID)
        {
            SqlOperation operation = new SqlOperation();
            SqlCommand command = new SqlCommand("Select [LessonID] from [SubLesson] where [subID] = " + _SubID, operation.DBcontext.GetConnection());
            DataTable table = operation.RequestTable(command);
            if (table.Rows.Count > 0)
            {
                input.Text = "Переподователь \t\t\t Занятие\n\n";
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    input.Text += checkLessonMaster(table.Rows[0].Field<int>("LessonID")) + "\t\t\t " + checkLessonName(table.Rows[0].Field<int>("LessonID")) + "\n";
                }
            }
        }

        private string checkLessonMaster(int _lessID)
        {
            SqlOperation operation = new SqlOperation();
            SqlCommand command = new SqlCommand("Select [CounterpartyID] from [Lesson] where [LessonID] = " + _lessID, operation.DBcontext.GetConnection());
            DataTable table = operation.RequestTable(command);
            if (table.Rows.Count > 0)
                return checkMasterName(table.Rows[0].Field<int>("CounterpartyID"));
            return string.Empty;
        }

        private string checkMasterName(int _CaID)
        {
            SqlOperation operation = new SqlOperation();
            SqlCommand command = new SqlCommand("Select [FIO] from [Counterparty] where [CounterpartyID] = " + _CaID, operation.DBcontext.GetConnection());
            DataTable table = operation.RequestTable(command);
            if (table.Rows.Count > 0)
                return table.Rows[0].Field<string>("FIO");
            return string.Empty;
        }

        private string checkLessonName(int _lessID)
        {
            SqlOperation operation = new SqlOperation();
            SqlCommand command = new SqlCommand("Select [Name] from [Lesson] where [LessonID] = " + _lessID, operation.DBcontext.GetConnection());
            DataTable table = operation.RequestTable(command);
            if (table.Rows.Count > 0)
                return table.Rows[0].Field<string>("Name");
            return string.Empty;
        }

        private void fillSubName(int _SubID)
        {
            SqlOperation operation = new SqlOperation();
            SqlCommand command = new SqlCommand("Select [Name] from [Subscription] where [SubID] = " + _SubID, operation.DBcontext.GetConnection());
            DataTable table = operation.RequestTable(command);
            if (table.Rows.Count > 0)
            {
                lblSub.Text = string.Empty;
                for (int i = 0; i < table.Rows.Count; i++)
                    lblSub.Text += table.Rows[i].Field<string>("Name");
            }
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
                for (int i = 0; i < table.Rows.Count; i++)
                    if (table.Rows[i].Field<int>("Type") == 0) workerCount++;
                    else userCount++;

                lblCountUser.Text = userCount.ToString();
                lblCountWorker.Text = workerCount.ToString();
            }
        }
    }
}
