using FitnessClub.Assets;
using FitnessClub.Data;
using FitnessClub.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace FitnessClub.Pages
{
    public partial class Lesson : UserControl
    {
        public Lesson()
        {
            InitializeComponent();
            act();
        }

        #region -- Client part --
        string nameUser;
        public Lesson( string userName)
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
            aminContent.Visible = false;
            couterpatyID = getcouterpatyID(nameUser);
            lessID = new List<int>();
            subID = new List<int>();

            getSubID();
            getLessID();
            checkUserLesson();
            container.Location = new Point(container.Location.X, container.Location.Y + 10);
        }

        private void checkUserLesson()
        {
            SqlOperation operation = new SqlOperation();
            int offset = 0;
            for (int i = 0; i < lessID.Count; i++)
            {
                SqlCommand command = new SqlCommand("select * from [Lesson] where [LessonID] = " + lessID[i], operation.DBcontext.GetConnection());
                DataTable table = operation.RequestTable(command);
                if(table.Rows.Count > 0)
                {
                    LessonItem temp = new LessonItem();
                    temp.LesStatus = table.Rows[0].Field<int>("Status") == 0 ? "Не активна" : "Активна";
                    temp.LesName = table.Rows[0].Field<string>("Name");
                    temp.LesTime = table.Rows[0].Field<string>("TimeSpending");
                    string day = "Не установлен";
                    switch (table.Rows[0].Field<int>("DayWeek"))
                    {
                        case 1: day = "ПТ"; break;
                        case 2: day = "ВТ"; break;
                        case 3: day = "СР"; break;
                        case 4: day = "ЧТ"; break;
                        case 5: day = "ПТ"; break;
                        case 6: day = "СБ"; break;
                        case 7: day = "ВС"; break;
                    }
                    temp.LesDay = day;
                    temp.LesMaster = getCaName(table.Rows[0].Field<int>("CounterpartyID"));
                    temp.Location = new Point(0, offset);
                    temp.Butt.Visible = false;

                    offset += temp.Width;
                    container.Controls.Add(temp);
                }
            }
        }

        private void getLessID()
        {
            SqlOperation operation = new SqlOperation();
            for(int i = 0; i < subID.Count; i++)
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
                for(int i = 0; i < table.Rows.Count; i++)
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

        private List<Label> days;
        private void act()
        { 
            days = new List<Label>() { day1, day2, day3, day4, day5, day6, day7 };
            checkCtagent();
            checkLesson();
        }
        private void checkLesson()
        {
            container.Controls.Clear();
            SqlOperation operation = new SqlOperation();
            SqlCommand command = new SqlCommand("select * from [Lesson] order by [LessonID] desc ", operation.DBcontext.GetConnection());
            DataTable table = operation.RequestTable(command);
            if(table.Rows.Count > 0)
            {
                int offset = 0;
                for(int i = 0; i < table.Rows.Count; i++)
                {
                    LessonItem temp = new LessonItem();
                    temp.LesStatus = table.Rows[i].Field<int>("Status") == 0 ? "Не активна" : "Активна";
                    temp.LesName = table.Rows[i].Field<string>("Name");
                    temp.LesTime = table.Rows[i].Field<string>("TimeSpending");
                    string day = "Не установлен";
                    switch (table.Rows[i].Field<int>("DayWeek"))
                    {
                        case 1: day = "ПТ"; break;
                        case 2: day = "ВТ"; break;
                        case 3: day = "СР"; break;
                        case 4: day = "ЧТ"; break;
                        case 5: day = "ПТ"; break;
                        case 6: day = "СБ"; break;
                        case 7: day = "ВС"; break;
                    }
                    temp.LesDay = day;
                    temp.LesMaster = getCaName(table.Rows[i].Field<int>("CounterpartyID"));
                    temp.Location = new Point(0, offset);
                    temp.Butt.Tag = table.Rows[i].Field<int>("LessonID");
                    temp.Butt.Click += DeleteClick;
                    
                    offset += temp.Width;
                    container.Controls.Add(temp);
                }
            }
        }

        private bool checkDocOwned(int _id)
        {
            SqlOperation operation = new SqlOperation();
            SqlCommand command = new SqlCommand("Select * from [SubLesson] where [LessonID] = @id;", operation.DBcontext.GetConnection());
            command.Parameters.Add("id", SqlDbType.Int).Value = _id;
            DataTable table = operation.RequestTable(command);
            if (table.Rows.Count > 0)
                return true;
            else return false;
        }

        private bool deleteRelation(int _id)
        {
            SqlOperation operation = new SqlOperation();
            SqlCommand command = new SqlCommand("Delete from [SubLesson] where [LessonID] = @id;", operation.DBcontext.GetConnection());
            command.Parameters.Add("id", SqlDbType.Int).Value = _id;
            if (operation.Request(command))
                return true;
            return false;
        }

        private void DeleteClick(object sender, EventArgs e)
        {
            if (checkDocOwned((int)(sender as Label).Tag))
                deleteRelation((int)(sender as Label).Tag);

            SqlOperation operation = new SqlOperation();
            SqlCommand command = new SqlCommand("Delete from [Lesson] where [LessonID] = @id;", operation.DBcontext.GetConnection());
            command.Parameters.Add("id", SqlDbType.Int).Value = (int) (sender as Label).Tag;
            if (operation.Request(command))
                MessageBox.Show("Запись удалена.");
            else new Error("Что-то пошло не так!").Show();

            checkLesson();
        }

        private string getCaName(int _id)
        {
            string name = "Не найден";

            SqlOperation operation = new SqlOperation();
            SqlCommand command = new SqlCommand("select [FIO] from [Counterparty] where [CounterpartyID] = @id;", operation.DBcontext.GetConnection());
            command.Parameters.Add("id", SqlDbType.Int).Value = _id;
            DataTable table = operation.RequestTable(command);
            if (table.Rows.Count > 0)
                name = table.Rows[0].Field<string>("FIO");
            return name;

        }

        private string reverseString(string _str)
        {
            char[] sReverse = _str.ToCharArray();
            Array.Reverse(sReverse);
            return new string(sReverse);
        }

        private void applayClick(object sender, EventArgs e)
        {
            if (validation())
            {
                string _time = dateTimePicker1.Value.ToString().Substring(dateTimePicker1.Value.ToString().IndexOf(' ')); 
                _time = reverseString(reverseString(_time).Substring(reverseString(_time).IndexOf(':') + 1));
                SqlOperation operation = new SqlOperation();
                SqlCommand command = new SqlCommand("Insert into [Lesson] (Name, DayWeek, TimeSpending, CounterpartyID, Status) " +
                    " Values (@name, @day, @time, @ca, @status)", operation.DBcontext.GetConnection());
                command.Parameters.Add("name", SqlDbType.NVarChar).Value = tbName.Text;
                command.Parameters.Add("day", SqlDbType.Int).Value = numberOfDay;
                command.Parameters.Add("time", SqlDbType.VarChar).Value = _time;
                command.Parameters.Add("ca", SqlDbType.Int).Value = getCaID(Ctagent.Text);
                command.Parameters.Add("status", SqlDbType.Int).Value = status.Checked == true ? 1 : 0;
                if (operation.Request(command))
                    MessageBox.Show("Запись добавлена");
                else new Error("Что-то пошло не так!").Show();
                checkLesson();
            }
        }

        private int getCaID(string name)
        {
            SqlOperation operation = new SqlOperation();
            SqlCommand command = new SqlCommand("select [CounterpartyID] from [Counterparty] where [FIO] = @fio;", operation.DBcontext.GetConnection());
            command.Parameters.Add("fio", SqlDbType.NVarChar).Value = name;
            DataTable table = operation.RequestTable(command);
            if (table.Rows.Count > 0)
                return table.Rows[0].Field<int>("CounterpartyID");
            return 0;
        }

        private void checkCtagent()
        {
            Ctagent.Items.Clear();
            SqlOperation operation = new SqlOperation();
            SqlCommand command = new SqlCommand("select [FIO] from [Counterparty] where [Type] = 0;", operation.DBcontext.GetConnection());
            DataTable table = operation.RequestTable(command);

            if(table.Rows.Count > 0)
            {
                for(int i = 0; i < table.Rows.Count; i++)
                    Ctagent.Items.Add(table.Rows[i].Field<string>("FIO"));
            }
        }

        int numberOfDay = 0;
        private void dayLblClick(object sender, EventArgs e)
        {
            foreach (Label l in days)
                l.BorderStyle = BorderStyle.None;
            (sender as Label).BorderStyle = BorderStyle.FixedSingle;

            switch((sender as Label).Name.ToString())
            {
                case "day1":
                    numberOfDay= 1;
                    break;
                case "day2":
                    numberOfDay = 2;
                    break;
                case "day3":
                    numberOfDay = 3;
                    break;
                case "day4":
                    numberOfDay = 4;
                    break;
                case "day5":
                    numberOfDay = 5;
                    break;
                case "day6":
                    numberOfDay = 6;
                    break;
                case "day7":
                    numberOfDay = 7;
                    break;
            }
            unMarkInvalid();
        }

        private bool markInvalid(Label desc)
        {
            desc.ForeColor = Color.Maroon;
            return false;
        }

        private bool validation()
        {
            if (tbName.Text == String.Empty)
                return markInvalid(lblNameDesc);

            if (Ctagent.Text == String.Empty)
                return markInvalid(lblCaDesc);

            if(numberOfDay == 0)
                return markInvalid(lblDayDesc);

            return true;
        }

        private void unMarkInvalid()
            => lblCaDesc.ForeColor = lblNameDesc.ForeColor = lblDayDesc.ForeColor = lblTimeDesc.ForeColor = Color.Snow;



        private void inputControlClick(object sender, EventArgs e)
            => unMarkInvalid();
    }
}
