using FitnessClub.Assets;
using FitnessClub.Data;
using FitnessClub.Forms;
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
    public partial class Lesson : UserControl
    {
        public Lesson()
        {
            InitializeComponent();
            act();
        }

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
                    temp.Delete.Tag = table.Rows[i].Field<int>("LessonID");
                    temp.Delete.Click += DeleteClick;
                    
                    offset += temp.Width;
                    container.Controls.Add(temp);
                }
            }
        }


        private void DeleteClick(object sender, EventArgs e)
        {
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

        private void applayClick(object sender, EventArgs e)
        {
            if (validation())
            {
                SqlOperation operation = new SqlOperation();
                SqlCommand command = new SqlCommand("Insert into [Lesson] (Name, DayWeek, TimeSpending, CounterpartyID, Status) " +
                    " Values (@name, @day, @time, @ca, @status)", operation.DBcontext.GetConnection());
                command.Parameters.Add("name", SqlDbType.NVarChar).Value = tbName.Text;
                command.Parameters.Add("day", SqlDbType.Int).Value = numberOfDay;
                command.Parameters.Add("time", SqlDbType.VarChar).Value = dateTimePicker1.Value.ToString().Substring(dateTimePicker1.Value.ToString().IndexOf(' '));
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
        private void day1_Click(object sender, EventArgs e)
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
