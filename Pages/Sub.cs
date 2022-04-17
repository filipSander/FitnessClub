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
    public partial class Sub : UserControl
    {
        public Sub()
        {
            InitializeComponent();
            act();
        }

        List<CheckBox> lesson;
        private void act()
        {
            lesson = new List<CheckBox>();
            checkLesson();
            checkSub();
        }

        private void applayClick(object sender, EventArgs e)
        {
            if (validation())
            {
                SqlOperation operation = new SqlOperation();
                SqlCommand command = new SqlCommand("Insert into [Subscription] (Price, DateExpiration, Description, Name) " +
                    " Values (@price, @dateEx, @desc, @name)", operation.DBcontext.GetConnection());
                command.Parameters.Add("price", SqlDbType.NVarChar).Value = tbPrice.Text;
                command.Parameters.Add("dateEx", SqlDbType.NVarChar).Value = tbDateEx.Text;
                command.Parameters.Add("desc", SqlDbType.NVarChar).Value = rcDesc.Text;
                command.Parameters.Add("name", SqlDbType.NVarChar).Value = tbName.Text;
                
                if (operation.Request(command))
                {
                    int lastID = getLastSubID();
                    foreach (CheckBox check in lesson)
                        if (check.Checked)
                            if(!createRelation(lastID, (int)check.Tag))
                            {
                                new Error("Что-то пошло не так!").Show();
                                return;
                            }
                    MessageBox.Show("Запись добавлена");
                    checkSub();
                }
                else new Error("Что-то пошло не так!").Show();
            }
        }

        private int getLastSubID()
        {
            SqlOperation operation = new SqlOperation();
            SqlCommand command = new SqlCommand("SELECT MAX([SubID]) as [Max] from [Subscription]", operation.DBcontext.GetConnection());
            DataTable table = operation.RequestTable(command);
            int _id = 0;
            if (!table.Rows[0].IsNull(0))
                _id = table.Rows[0].Field<int>("Max");
            return _id;
        }

        private bool createRelation(int _SubID , int _LessID)
        {
            SqlOperation operation = new SqlOperation();
            SqlCommand command = new SqlCommand("Insert into [SubLesson] (LessonID, SubID) " +
                " Values (@lessonID, @subID)", operation.DBcontext.GetConnection());
            command.Parameters.Add("lessonID", SqlDbType.Int).Value = _LessID;
            command.Parameters.Add("subID", SqlDbType.Int).Value = _SubID;
            if (operation.Request(command)) return true;
            return false;
        }

        private bool markInvalid(Label desc)
        {
            desc.ForeColor = Color.Maroon;
            return false;
        }

        private bool validation()
        {
            if (tbName.Text == String.Empty)
                return markInvalid(lblName);

            if (tbDateEx.Text == String.Empty)
                return markInvalid(lblDateEx);

            if (tbPrice.Text == String.Empty)
                return markInvalid(lblPrice);

            if (lesson.Count == 0)
                return markInvalid(lblLessons);

            foreach (CheckBox check in lesson)
                if (check.Checked) return true;

            return markInvalid(lblLessons);
        }




        private void checkLesson()
        {
            lessonContainer.Controls.Clear();
            SqlOperation operation = new SqlOperation();
            SqlCommand command = new SqlCommand("select [LessonID], [Name] from [Lesson] order by [LessonID] desc ", operation.DBcontext.GetConnection());
            DataTable table = operation.RequestTable(command);
            if (table.Rows.Count > 0)
            {
                int offset = 0;
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    CheckBox temp = new CheckBox();
                    temp.AutoSize = true;
                    temp.Tag = table.Rows[i].Field<int>("LessonID");
                    temp.Text = table.Rows[i].Field<string>("Name");
                    temp.Location = new Point(0, offset);
                    temp.Margin = new Padding(0);
                    temp.Padding = new Padding(0);

                    offset += temp.Height;
                    lessonContainer.Controls.Add(temp);
                    lesson.Add(temp);
                }
            }
        }


        private void checkSub()
        {
            container.Controls.Clear();
            SqlOperation operation = new SqlOperation();
            SqlCommand command = new SqlCommand("select * from [Subscription] order by [SubID] desc ", operation.DBcontext.GetConnection());
            DataTable table = operation.RequestTable(command);
            if (table.Rows.Count > 0)
            {
                int offset = 0;
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    SubItem temp = new SubItem();
                    temp.CaName = table.Rows[i].Field<string>("Name");
                    temp.CaDateEx = table.Rows[i].Field<string>("DateExpiration");
                    temp.CaPrice = table.Rows[i].Field<string>("Price");

                    temp.CaLesson = checkCaLesson(table.Rows[i].Field<int>("SubID"));


                    temp.Location = new Point(0, offset);
                    temp.Delete.Tag = table.Rows[i].Field<int>("SubID");
                    temp.Delete.Click += DeleteSub; 

                    offset += temp.Width;
                    container.Controls.Add(temp);
                }
            }
        }

        private string checkCaLesson(int _id)
        {
            string lessons = string.Empty;
            SqlOperation operation = new SqlOperation();
            SqlCommand command = new SqlCommand("select * from [SubLesson]  where [SubID] = @id;", operation.DBcontext.GetConnection());
            command.Parameters.Add("id", SqlDbType.Int).Value = _id;
            DataTable table = operation.RequestTable(command);
            if (table.Rows.Count > 0)
            {
                for (int i = 0; i < table.Rows.Count; i++)
                    lessons += checkLessonByID(table.Rows[i].Field<int>("LessonID")) + "\n";
            }
            return lessons;
        }

        private string checkLessonByID(int _id)
        {
            SqlOperation operation = new SqlOperation();
            SqlCommand command = new SqlCommand("select [Name] from [Lesson]  where [LessonID] = @id;", operation.DBcontext.GetConnection());
            command.Parameters.Add("id", SqlDbType.Int).Value = _id;
            DataTable table = operation.RequestTable(command);

            if (table.Rows.Count > 0)
                return table.Rows[0].Field<string>("Name");
            return "";

        }

        private void DeleteSub(object sender, EventArgs e)
        {
            if(deleteRelation( (int)(sender as Label).Tag) )
            {
                SqlOperation operation = new SqlOperation();
                SqlCommand command = new SqlCommand("Delete from [Subscription] where [SubID] = @id; ", operation.DBcontext.GetConnection());
                command.Parameters.Add("id", SqlDbType.Int).Value = (int)(sender as Label).Tag;
                if (operation.Request(command))
                    MessageBox.Show("Запись удалена");
                else new Error("Что-то пошло не так!").Show();
                checkSub();

            }
            else new Error("Что-то пошло не так!").Show();
        }

        private bool deleteRelation(int _subID)
        {
            SqlOperation operation = new SqlOperation();
            SqlCommand command = new SqlCommand("Delete from [SubLesson] where [SubID] = @id; ", operation.DBcontext.GetConnection());
            command.Parameters.Add("id", SqlDbType.Int).Value = _subID;
            if(operation.Request(command)) return true;
            return false;
        }
    }
}
