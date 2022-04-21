using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace FitnessClub.Assets
{
    public partial class SchenduleItem : UserControl
    {
        public SchenduleItem()
        {
            InitializeComponent();
        }
        #region -- Properties --

        string _name, _dateEx;
        [Category("AMy prop")]
        public string LessName
        {
            get { return _name; }
            set { _name = value; lblName.Text = value; }
        }

        [Category("AMy prop")]
        public string LessDateEx
        {
            get { return _dateEx; }
            set { _dateEx = value; lblTime.Text = value; }
        }

        #endregion

        private void StatusTabIndexChanged(object sender, EventArgs e)
        {
            if (Status.TabIndex == 0)
            {
                Status.Text = "+";
                BackColor = Color.Maroon;
                Status.BackColor = Color.SteelBlue;
            }
            else
            {
                Status.Text = "-";
                BackColor = Color.DarkSlateGray;
                Status.BackColor = Color.Maroon;
            }
        }

        private void lblNameTextChanged(object sender, EventArgs e)
        {
            if (lblName.Text.Length > 18)
                lblName.Text = lblName.Text.Substring(0, 15) + "..";
        }
    }
}
