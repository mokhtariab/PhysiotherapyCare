using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MKH.Contacts.View
{
    public partial class MainStart_Frm : MKH.Library.Forms.MSSMainForm
    {
        public MainStart_Frm()
        {
            InitializeComponent();
        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {
            UserControls.PersonGroupList_UC SPU = new UserControls.PersonGroupList_UC();
            TabControlMain.AddTabToTabControl(SPU.Name, SPU.Tag.ToString(), SPU);

        }
    }
}
