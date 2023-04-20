using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MKH.Library.UserControls
{
    public partial class MSSTime_UC : UserControl
    {
        public MSSTime_UC()
        {
            InitializeComponent();
            SetTimeEnter();
        }

        public void SetTimeEnter()
        {
            integerUpDownTime.Value = 0;
            integerUpDownMinute.Value = 0;
        }

        public void SetTimeEnter(string TimeEnter = "00:00")
        {
            string TimeStr = TimeEnter;
            integerUpDownTime.Value = Convert.ToInt16(TimeStr.Substring(0, 2));
            integerUpDownMinute.Value = Convert.ToInt16(TimeStr.Substring(3, 2));
        }

        public string GetTimeEnter()
        {
            return integerUpDownTime.Value.ToString("00") + ":" + integerUpDownMinute.Value.ToString("00");
        }
    }
}
