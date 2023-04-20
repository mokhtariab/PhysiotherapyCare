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
    public partial class MSSDate_UC : UserControl
    {
        public MSSDate_UC()
        {
            InitializeComponent();
            SetDateEnter(DateTime.Now);
        }

        public void SetDateEnter(DateTime DateEnter)
        {
            string DateStr = Clasess.Date.DateConvertor.MiladiDateToShamsi(DateEnter);
            comboBoxYear.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
            comboBoxMonth.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
            comboBoxDay.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();
        }

        public void SetDateEnter(string DateEnter = "1393/01/01")
        {
            string DateStr = DateEnter;
            comboBoxYear.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
            comboBoxMonth.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
            comboBoxDay.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();
        }

        public bool CheckDateEnter()
        {
            try
            {
                if (Convert.ToInt16(comboBoxMonth.Text) > 6 && Convert.ToInt16(comboBoxDay.Text) == 31) comboBoxDay.Text = "30";
                if (Convert.ToInt16(comboBoxMonth.Text) == 12 && (Convert.ToInt16(comboBoxDay.Text) == 31 || Convert.ToInt16(comboBoxDay.Text) == 30)) comboBoxDay.Text = "29";
                return true;
            }
            catch 
            {
                return false;
            }

        }
        public DateTime GetDateEnterDateTime()
        {
            if (CheckDateEnter())
                return Clasess.Date.DateConvertor.ShamsiDateToMiladi(comboBoxYear.Text, comboBoxMonth.Text, comboBoxDay.Text);
            else
                return DateTime.Now;
        }
        public string GetDateEnterStr()
        {
            if (CheckDateEnter())
                return comboBoxYear.Text + "/" + int.Parse(comboBoxMonth.Text).ToString("00") + "/" + int.Parse(comboBoxDay.Text).ToString("00");
            else
                return "";
        }
    }
}
