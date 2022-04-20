using FitnessClub.Assets;
using System.Windows.Forms;

namespace FitnessClub.Forms
{
    public partial class Error : Form
    {
        string description;
        public Error(string _desc)
        {
            InitializeComponent();
            description = _desc;
            act();

        }
        
        private void act()
        {
            desc.Text = description;
            Text = "Ошибка ";
            new FormStyle(this);
            roundButton1.Butt.Click += roundButtonClick;
        }

        private void roundButtonClick(object sender, System.EventArgs e)
            => Hide();
    }
}
