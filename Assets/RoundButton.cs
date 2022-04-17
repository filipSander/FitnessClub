using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FitnessClub.Assets
{
    public partial class RoundButton : UserControl
    {
        #region API
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRect
        (int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        [DllImport("gdi32.dll", EntryPoint = "DeleteObject")]
        private static extern bool DeleteObject(IntPtr hObject);
        #endregion

        #region Properties
        string _text = "butt";
        Color _onActionColor;

        [Category("AMy prop")]
        public string ButtText
        {
            get { return _text; }
            set { _text = value; Butt.Text = value; }
        }
        [Category("AMy prop")]
        public Color ButtActionColor
        {
            get { return _onActionColor; }
            set { _onActionColor = value; Butt.FlatAppearance.MouseDownBackColor = value; }
        }
        #endregion
        public RoundButton()
        {
            InitializeComponent();
        }

        private void RoundButtonResize(object sender, EventArgs e)
        {
            Butt.Width = Width - 10;
            Butt.Height = Height - 10;
        }

        private void RoundButtonPaint(object sender, PaintEventArgs e)
        {
            IntPtr ptr = CreateRoundRect(0, 0, Butt.Width, Butt.Height, 15, 15);
            Butt.Region = Region.FromHrgn(ptr);

            IntPtr ptrw = CreateRoundRect(0, 0, Width, Height, 15, 15);
            Region = Region.FromHrgn(ptrw);

        }

        private void RoundButton_Enter(object sender, EventArgs e)
            => Butt.Select();
    }
}
