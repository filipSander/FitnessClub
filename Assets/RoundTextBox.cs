using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FitnessClub.Assets
{

    public partial class RoundTextBox : UserControl
    {
        #region API
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRect
        (int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        [DllImport("gdi32.dll", EntryPoint = "DeleteObject")]
        private static extern bool DeleteObject(IntPtr hObject);
        #endregion

        public RoundTextBox()
        {
            InitializeComponent();
        }
        #region Properties
        string _value;
        bool _usePasswordChar = false;

        [Category("AMy prop")]
        public string Value
        {
            get { return _value; }
            set { _value = value; Input.Text = value; }
        }
        [Category("AMy prop")]
        public bool PasswordChar
        {
            get { return _usePasswordChar; }
            set { _usePasswordChar = value; Input.UseSystemPasswordChar = value; }
        }
        #endregion


        private void RoundTextBoxPaint(object sender, PaintEventArgs e)
        {
            IntPtr ptr = CreateRoundRect(0, 0, Width, Height, 15, 15);
            Region = Region.FromHrgn(ptr);

        }

        private void RoundTextBox_Resize(object sender, EventArgs e)
            => Input.Width = Width - 10;

        private void inputTextChanged(object sender, EventArgs e)
            => _value = Input.Text;

        private void RoundTextBox_Enter(object sender, EventArgs e)
            => Input.Select();
    }
}
