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
    public partial class MSSMessage_frm : Form
    {
        public MSSMessage_frm()
        {
            InitializeComponent();
        }

        private void MSSMessage_Frm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Escape))
                this.Close();
        }

        private void button_Details_Click(object sender, EventArgs e)
        {
            if (Height == 237) Height = 147;
            else Height = 237;
        }



    }
}
