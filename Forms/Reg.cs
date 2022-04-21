using FitnessClub.Assets;
using FitnessClub.Data;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace FitnessClub.Forms
{


    public partial class Reg : Form
    {
        public Reg()
        {
            InitializeComponent();
            act();
        }

        private void act()
        {
            new FormStyle(this);
        }

        private void applyClick(object sender, EventArgs e)
        {
            if (tbFIO.Validation(lblFIO))
            {
                tbFIO.Select();
                return;
            }

            if (tbLogin.Validation(lblLogin))
            {
                tbLogin.Select();
                return;
            }
            if (tbPass.Validation(lblPass))
            {
                tbPass.Select();
                return;
            }
            if (tbRepeatPass.Validation(lblRepeatPass))
            {
                tbRepeatPass.Select();
                return;
            }
            if (tbPass.Text != tbRepeatPass.Text)
            {
                tbPass.Select();
                lblPass.MarkInvalid();
                lblRepeatPass.MarkInvalid();
                return;
            }

            if (userExist(tbLogin.Text))
            {
                tbLogin.Select();
                lblLogin.MarkInvalid();
                return;
            }

            SqlOperation operation = new SqlOperation();
            SqlCommand command = new SqlCommand("Insert into [Counterparty] ([FIO], [Type]) Values (@FIO, 1);", operation.DBcontext.GetConnection());
            command.Parameters.Add("FIO", SqlDbType.NVarChar).Value = tbFIO.Text;
            if (operation.Request(command))
                if (regUser())
                {
                    MessageBox.Show("Вы успешно зарегистрировались");
                    new Main(tbLogin.Text, 1).Show();
                    Hide();
                    return;
                }
            new Error("Что-то пошло не так").Show();

        }

        private bool regUser()
        {
            SqlOperation operation = new SqlOperation();
            SqlCommand command = new SqlCommand("Insert into [User] ([Login], [Type], [Password], [CounterpartyID]) Values (@lg, 1,@pass, @caID);", operation.DBcontext.GetConnection());
            command.Parameters.Add("lg", SqlDbType.NVarChar).Value = tbLogin.Text;
            command.Parameters.Add("pass", SqlDbType.NVarChar).Value = tbPass.Text;
            command.Parameters.Add("caID", SqlDbType.Int).Value = getLastID();
            if (operation.Request(command))
                return true;
            return false;
        }

        private int getLastID()
        {
            SqlOperation operation = new SqlOperation();
            SqlCommand command = new SqlCommand("Select Max([CounterpartyID]) as [Max] from [Counterparty]", operation.DBcontext.GetConnection());
            DataTable table = operation.RequestTable(command);
            return table.Rows[0].Field<int>("Max");
        }

        private bool userExist(string login)
        {
            SqlOperation operation = new SqlOperation();
            SqlCommand command = new SqlCommand("Select [UserID] from [User] where [Login] = @lg", operation.DBcontext.GetConnection());
            command.Parameters.Add("lg", SqlDbType.NVarChar).Value = login;
            DataTable table = operation.RequestTable(command);
            if (table.Rows.Count > 0)
                return true;
            return false;
        }

        private void AllinputTextChanged(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
                if ((string)c.Tag == "desc")
                    c.ForeColor = Color.Snow;
        }

        private void tbFIO_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                foreach (Control c in Controls)
                    if ((string)c.Tag == "input" && c.TabIndex > (sender as Control).TabIndex)
                        c.Select();
            }
        }

        private void tbFIO_KeyPress(object sender, KeyPressEventArgs e)
            => e.Handled = e.KeyChar == 13;
    }

    static class Extentions
    {
        public static bool MarkInvalid(this Label desc)
        {
            desc.ForeColor = Color.Maroon;
            return true;
        }

        public static bool Validation(this TextBox input, Label desc)
        {
            if (input.Text == String.Empty)
                return desc.MarkInvalid();
            return false;
        }
    }

}
