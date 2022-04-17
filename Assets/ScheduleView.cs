﻿using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;


namespace FitnessClub.Assets
{
    public partial class ScheduleView : UserControl
    {
        public ScheduleView()
        {
            InitializeComponent();
            act();
        }
        
        List<Panel> days;
        List<int> heightColumn;

        private void act()
        {
            days = new List<Panel>() { panel1, panel2, panel3, panel4, panel5, panel6, panel7 };
            heightColumn = new List<int>() { 0, 0, 0, 0, 0, 0, 0 };
            int day = 0;
            switch (DateTime.Today.DayOfWeek)
            {                
                case DayOfWeek.Monday:    day = 0;break;
                case DayOfWeek.Tuesday:   day = 1;break;
                case DayOfWeek.Wednesday: day = 2;break;
                case DayOfWeek.Thursday:  day = 3;break; 
                case DayOfWeek.Friday:    day = 4;break;
                case DayOfWeek.Saturday:  day = 5;break;
                case DayOfWeek.Sunday:    day = 6;break;
            }

            days[day].BackColor = Color.FromArgb(46, 50, 58);
            container.Height = Height - 15;
            container.Width = Width - 15;
            container.AutoScrollMinSize = new Size(0, Height);
            foreach (Panel p in days)
                p.Height = Height - 25;
        }

        public void AddLesson(string LessonName, string LessonDate, int day)
        {
            SchenduleItem temp = new SchenduleItem();
            temp.LessDateEx = LessonDate;
            temp.LessName = LessonName;
            temp.Location = new Point(0, days[day - 1].Controls.Count == 0 ? heightColumn[day - 1] :  heightColumn[day - 1] + 5);

            days[day - 1].Controls.Add(temp);
            heightColumn[day - 1] += temp.Height + 5;

            if (heightColumn[day - 1] > container.Height)
                resizeView(heightColumn[day - 1]);
        }

        public void Clear()
        {
            foreach (Panel p in days)
                p.Controls.Clear();
            heightColumn = new List<int>() { 0, 0, 0, 0, 0, 0, 0 };
        }

        private void resizeView(int newHeight)
        {
            //container.Height = newHeight;
            foreach (Panel p in days)
                p.Height = newHeight - 10;
        }
    }
}
