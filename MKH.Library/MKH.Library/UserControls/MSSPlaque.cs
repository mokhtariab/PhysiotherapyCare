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
    public partial class MSSPlaque : UserControl
    {
        public MSSPlaque()
        {
            InitializeComponent();
        }

        public void SetPlaqueEnter(string PlaqueStr)
        {
            try
            {
                IntBoxPlaqueCarNoPart1.Text = Convert.ToInt16(PlaqueStr.Substring(0, 2)).ToString();
                comboBoxPlaqueCarNoPart2.Text = PlaqueStr.Substring(2, 1);
                IntBoxPlaqueCarNoPart3.Text = Convert.ToInt32(PlaqueStr.Substring(3, 3)).ToString();
                IntBoxPlaqueCarNoPart4.Text = Convert.ToInt16(PlaqueStr.Substring(11, 2)).ToString();
            }
            catch 
            {
                try
                {
                    IntBoxPlaqueCarNoPart1.Text = Convert.ToInt16(PlaqueStr.Substring(0, 2)).ToString();
                    comboBoxPlaqueCarNoPart2.Text = PlaqueStr.Substring(2, 3);
                    IntBoxPlaqueCarNoPart3.Text = Convert.ToInt32(PlaqueStr.Substring(5, 3)).ToString();
                    IntBoxPlaqueCarNoPart4.Text = Convert.ToInt16(PlaqueStr.Substring(13, 2)).ToString();
                }
                catch { }
            }
        }

        public bool CheckPlaqueEnter()
        {
            if (IntBoxPlaqueCarNoPart1.Text.Length < 2 || IntBoxPlaqueCarNoPart3.Text.Length < 3 || IntBoxPlaqueCarNoPart4.Text.Length < 2 || comboBoxPlaqueCarNoPart2.Text == "")
                return false;
            return true;
        }

        public string GetPlaqueStr()
        {
            //22ل849ايران99
            if (CheckPlaqueEnter())
                return IntBoxPlaqueCarNoPart1.Text + comboBoxPlaqueCarNoPart2.Text + IntBoxPlaqueCarNoPart3.Text + "ایران" + IntBoxPlaqueCarNoPart4.Text;
            else
                return "";
        }

        private void IntBoxPlaqueCarNoPart1_KeyUp(object sender, KeyEventArgs e)
        {
            if ((sender as MKH.Library.Control.MSSIntBox).Value.ToString().Length == (sender as MKH.Library.Control.MSSIntBox).MaxLength)
                SendKeys.Send("{TAB}");
        }
        private void comboBoxPlaqueCarNoPart3_Enter(object sender, EventArgs e)
        {
            comboBoxPlaqueCarNoPart2.DroppedDown = true;
        }

        private void comboBoxPlaqueCarNoPart3_DropDownClosed(object sender, EventArgs e)
        {
            SendKeys.Send("{TAB}");
        }

        private void MSSPlaque_Enter(object sender, EventArgs e)
        {
            IntBoxPlaqueCarNoPart1.Focus();
        }

        private void IntBoxPlaqueCarNoPart1_Leave(object sender, EventArgs e)
        {
            if ((sender as MKH.Library.Control.MSSIntBox).Value.ToString().Length != (sender as MKH.Library.Control.MSSIntBox).MaxLength)
                (sender as MKH.Library.Control.MSSIntBox).Focus();
        }

        private void IntBoxPlaqueCarNoPart1_Enter(object sender, EventArgs e)
        {
            (sender as MKH.Library.Control.MSSIntBox).Value = 0;
        }
    }
}
