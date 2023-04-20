using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MKH.Library.Forms
{
    public partial class MSSMainForm : Form
    {
        public MSSMainForm()
        {
            InitializeComponent();
        }

        private void timerMain_Tick(object sender, EventArgs e)
        {
            int i = 0;
            label_main.Text =
                new MKH.Library.Clasess.Date.DateJalali().GetNameOfDay(DateTime.Now, out i) + " " +
                new MKH.Library.Clasess.Date.DateJalali().GetDayOfMonth(DateTime.Now).ToString() + " " +
                new MKH.Library.Clasess.Date.DateJalali().GetNameOfMounth(DateTime.Now) + " " +
                new MKH.Library.Clasess.Date.DateJalali().GetYear(DateTime.Now).ToString() + " " +
                "           ساعت: " + DateTime.Now.TimeOfDay.Hours.ToString() + ":" +
                DateTime.Now.TimeOfDay.Minutes.ToString() + ":" +
                DateTime.Now.TimeOfDay.Seconds.ToString() + "         کاربر: " +
                MKH.Library.Clasess.PublicParam.UserLoginCode + "  " + MKH.Library.Clasess.PublicParam.UserLoginName;
                

            label_main.Left = bar_MainView.Width / 2 - 250;
        }
    }
}
