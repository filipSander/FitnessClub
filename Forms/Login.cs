using System;
using FitnessClub.Assets;
using FitnessClub.Data;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace FitnessClub.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            act();
        }

        private void act()
        {
            new FormStyle(this);
            loginCtl.Input.TextChanged += InputTextChanged;
            passCtl.Input.TextChanged += InputTextChanged;
            apply.Butt.Click += applyClick;

            WindowState = FormWindowState.Minimized;
            new Main("Admin", 0).Show();
        }


        private bool markInvalid(Label desc)
        {
            desc.ForeColor = Color.Maroon;
            return false;
        }

        private bool validation(TextBox input, Label desc)
        {
            if (input.Text == string.Empty)
                return markInvalid(desc);
            return true;
        }


        private void applyClick(object sender, EventArgs e)
        {
            if(validation(loginCtl.Input, loginLable) && validation(passCtl.Input, passLable))
            {
                SqlOperation operation = new SqlOperation();
                SqlCommand command = new SqlCommand("Select * from [User] where [Login] = @login", operation.DBcontext.GetConnection());
                command.Parameters.Add("login", SqlDbType.NVarChar).Value = loginCtl.Input.Text;
                DataTable table = operation.RequestTable(command);

                if(table.Rows.Count > 0)
                {
                    if (table.Rows[0].Field<string>("Password") == passCtl.Input.Text)
                    {   
                        
                        new Main(table.Rows[0].Field<string>("Login"), table.Rows[0].Field<int>("Type")).Show();
                        Hide();
                    }
                        
                }
                markInvalid(loginLable);
            }
        }

        private void InputTextChanged(object sender, EventArgs e)
        {
            loginLable.ForeColor = passLable.ForeColor = Color.Snow;
            apply.Butt.Enabled = true;
        }
        private void showPassIconClick(object sender, EventArgs e)
            => passCtl.PasswordChar = !passCtl.PasswordChar;
    }
}
