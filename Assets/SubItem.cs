using System.ComponentModel;
using System.Windows.Forms;

namespace FitnessClub.Assets
{
    public partial class SubItem : UserControl
    {
        #region -- Properties --
        string _name, _dateEx, _price, _lesson;
        [Category("AMy prop")]
        public string CaName
        {
            get { return _name; }
            set { _name = value; lblName.Text = value; }
        }

        [Category("AMy prop")]
        public string CaDateEx
        {
            get { return _dateEx; }
            set { _dateEx = value; lblDateEx.Text = value; }
        }

        [Category("AMy prop")]
        public string CaPrice
        {
            get { return _price; }
            set { _price = value; lblPrice.Text = value; }
        }

        [Category("AMy prop")]
        public string CaLesson
        {
            get { return _lesson; }
            set { _lesson = value; richLesson.Text = value; }
        }
        #endregion
        public SubItem()
        {
            InitializeComponent();
        }
    }
}
