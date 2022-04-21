using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace FitnessClub.Assets
{
    public partial class Sidebar : UserControl
    {

        #region Properties
        int _selectedIndex;

        [Category("AMy prop")]
        public int SelectedIndex
        {
            get { return _selectedIndex; }
            set { _selectedIndex = value; }
        }
        #endregion
        public Sidebar()
        {
            InitializeComponent();
            act();
        }

        int itemsCount = 0;
        public List<Panel> MenuItemsBg;
        public List<Label> MenuItemsTitle;

        private void act()
        {
            MenuItemsBg = new List<Panel>();
            MenuItemsTitle = new List<Label>();
            Resize += SidebarResize;
        }

        private void SidebarResize(object sender, EventArgs e)
        {
            foreach (Panel p in MenuItemsBg)
                p.Width = Width;
        }

        public void AddItem(string itemTitle)
        {
            Panel panel = new Panel();
            panel.Width = Width;
            panel.Height = 80;
            panel.Dock = DockStyle.Top;
            panel.Tag = itemsCount;
            panel.BackgroundImageLayout = ImageLayout.Zoom;
            panel.BackColor = Color.Transparent;
            panel.MouseClick += menuItemClick;


            Label label = new Label();
            label.Text = itemTitle;
            label.Anchor = AnchorStyles.None;
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Dock = DockStyle.Fill;
            label.MouseClick += menuItemClick;

            label.Tag = itemsCount;
            panel.Controls.Add(label);
            MenuItemsBg.Add(panel);
            MenuItemsTitle.Add(label);
            Controls.Add(panel);
            itemsCount++;
        }


        int _sender = 0;
        private void menuItemClick(object sender, MouseEventArgs e)
        {

            switch (sender.GetType().ToString())
            {
                case "System.Windows.Forms.Panel":
                    _sender = Convert.ToInt32((sender as Panel).Tag);
                    break;
                case "System.Windows.Forms.Label":
                    _sender = Convert.ToInt32((sender as Label).Tag);
                    break;
            }


            foreach (Panel p in MenuItemsBg)
                p.BackgroundImage = null;
            MenuItemsBg[_sender].BackgroundImage = Properties.Resources.BG_2;
            foreach (Panel p in MenuItemsBg)
                p.Refresh();

            _selectedIndex = _sender;
        }
    }
}
