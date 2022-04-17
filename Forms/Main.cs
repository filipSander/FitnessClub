using FitnessClub.Assets;
using FitnessClub.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessClub.Forms
{
    public partial class Main : Form
    {
        string userName;
        int typeUser;
        public Main(string login, int type)
        {
            InitializeComponent();
            userName = login;
            typeUser = type;
            act();
        }

        private void act()
        {
            new FormStyle(this);
            Text += $" ({userName})";


            sidebar.AddItem("Расписание"); // 0
            sidebar.AddItem("Абонименты"); // 1
            sidebar.AddItem("Занятия");    // 2
            sidebar.AddItem("Главная");    // 3

            sidebar.SelectedIndex = 3;
            sidebar.MenuItemsBg[sidebar.SelectedIndex].BackgroundImage = Properties.Resources.BG_2;
            sidebar.MenuItemsBg[sidebar.SelectedIndex].BackgroundImageLayout = ImageLayout.Zoom;
            pageInit(new Index(), container);

            for (int i = 0; i < sidebar.MenuItemsBg.Count; i++)
            {
                sidebar.MenuItemsBg[i].MouseClick += sidebarClick;
                sidebar.MenuItemsTitle[i].MouseClick += sidebarClick;
            }
        }

        private void sidebarClick(object sender, MouseEventArgs e)
        {

            foreach (Panel p in sidebar.MenuItemsBg)
                p.BackgroundImage = null;

            sidebar.MenuItemsBg[sidebar.SelectedIndex].BackgroundImage = Properties.Resources.BG_2;
            sidebar.MenuItemsBg[sidebar.SelectedIndex].BackgroundImageLayout = ImageLayout.Zoom;
            


            switch (sidebar.SelectedIndex)
            {
                case 0:
                    pageInit(new Schedule(), container);
                    break;
                case 1:
                    pageInit(new Sub(), container);
                    break;
                case 2:
                    pageInit(new Lesson(), container);
                    break;
                case 3:
                    pageInit(new Index(), container);
                break;                
            }
        }

        private void pageInit(UserControl tab, Panel container)
        {
            tab.Dock = DockStyle.Fill;
            container.Controls.Clear();
            container.Controls.Add(tab);
            tab.BringToFront();
        }

        private void MainFormClosed(object sender, FormClosedEventArgs e)
            => Application.Exit();
    }
}
