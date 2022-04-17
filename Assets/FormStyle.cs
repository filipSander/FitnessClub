using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FitnessClub.Assets
{
    public class FormStyle
    {

        #region API
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRect
        (int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        [DllImport("gdi32.dll", EntryPoint = "DeleteObject")]
        private static extern bool DeleteObject(IntPtr hObject);
        #endregion

        #region constructor
        private Form _sender;
        public FormStyle(Form form)
        {
            _sender = form;
            stylization();
        }
        #endregion

        #region controls
        private Panel header;
        private int headerHeight = 40;
        private PictureBox closeIcon;
        private PictureBox hideIcon;
        #endregion


        private void stylization()
        {
            _sender.FormBorderStyle = FormBorderStyle.None;
            ofsetControls();
            createHeader();
            _sender.Paint += _senderPaint;
            header.MouseDown += headerMouseDown;
            header.MouseMove += headerMouseMove;
            closeIcon.Click += closeIconClick;
            hideIcon.Click += hideIconClick;
        }

        private void _senderPaint(object sender, PaintEventArgs e)
        {
            IntPtr ptr = CreateRoundRect(0, 0, _sender.Width, _sender.Height, 15, 15);
            _sender.Region = Region.FromHrgn(ptr);
        }

        private void createHeader()
        {
            header = new Panel();
            header.Height = headerHeight;
            header.Dock = DockStyle.Top;

            // title
            Label title = new Label();
            title.Text = _sender.Text;
            title.Font = _sender.Font;
            title.AutoSize = true;
            title.TextAlign = ContentAlignment.MiddleCenter;
            title.Top = (headerHeight / 2) - title.Height / 2;
            title.Left = 10;
            header.Controls.Add(title);

            // -
            hideIcon = new PictureBox();
            hideIcon.Width = 30;
            hideIcon.Height = 30;
            hideIcon.SizeMode = PictureBoxSizeMode.Zoom;
            hideIcon.Dock = DockStyle.Right;
            hideIcon.Image = Properties.Resources.hideIcon;
            header.Controls.Add(hideIcon);

            // x
            closeIcon = new PictureBox();
            closeIcon.Width = 30;
            closeIcon.Height = 30;
            closeIcon.SizeMode = PictureBoxSizeMode.Zoom;
            closeIcon.Dock = DockStyle.Right;
            closeIcon.Image = Properties.Resources.closeIcon;
            header.Controls.Add(closeIcon);

            // ?margin right
            Panel _margin = new Panel();
            _margin.Width = 5;
            _margin.Height = 30;
            _margin.Dock = DockStyle.Right;
            header.Controls.Add(_margin);

            Panel borderLine = new Panel();
            borderLine.Height = 1;
            borderLine.Dock = DockStyle.Bottom;
            borderLine.BackColor = Color.Green;
            header.Controls.Add(borderLine);
            _sender.Controls.Add(header);

        }

        private void ofsetControls()
        {
            _sender.Height += headerHeight + 5;
            foreach (Control c in _sender.Controls)
            {
                c.Location = new Point(c.Location.X, c.Location.Y + headerHeight + 5);
                c.Refresh();
            }
        }

        #region action method
        private void closeIconClick(object sender, EventArgs e)
            => Application.Exit();
        private void hideIconClick(object sender, EventArgs e)
            => _sender.WindowState = FormWindowState.Minimized;

        Point lastPoint;
        private void headerMouseDown(object sender, MouseEventArgs e)
            => lastPoint = new Point(e.X, e.Y);

        private void headerMouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _sender.Left += e.X - lastPoint.X;
                _sender.Top += e.Y - lastPoint.Y;
            }
        }
        #endregion
    }
}
