using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessClub.Assets
{
    public partial class LessonItem : UserControl
    {
        #region Properties
        string _name, _day, _status, _time, _master;


        [Category("AMy prop")]
        public string LesName
        {
            get { return _name; }
            set { _name = value; lblName.Text = value; }
        }
        [Category("AMy prop")]
        public string LesDay
        {
            get { return _day; }
            set { _day = value; lblDay.Text = value; }
        }
        [Category("AMy prop")]
        public string LesStatus
        {
            get { return _status; }
            set { _status = value; lblStatus.Text = value; }
        }
        [Category("AMy prop")]
        public string LesTime
        {
            get { return _time; }
            set { _time = value; lblTime.Text = value; }
        }
        [Category("AMy prop")]
        public string LesMaster
        {
            get { return _master; }
            set { _master = value; lblMaster.Text = value; }
        }

        #endregion
        public LessonItem()
        {
            InitializeComponent();
        }
    }
}
