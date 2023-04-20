using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MKH.Permission.View
{
    public partial class MainStart_Frm : MKH.Library.Forms.MSSMainForm
    {
        public MainStart_Frm()
        {
            InitializeComponent();
            MKH.Library.Clasess.PublicParam.MainForm = this;
        }

        #region  
        
        private void buttonItemSoftwareList_Click(object sender, EventArgs e)
        {
            //UserControls.Software_UC SPU = new UserControls.Software_UC();
            //TabControlMain.AddTabToTabControl(SPU.Name, SPU.Tag.ToString(), SPU);
        }
        
        private void buttonItemUsersList_Click(object sender, EventArgs e)
        {
            UserControls.Users_UC SPU = new UserControls.Users_UC();
            TabControlMain.AddTabToTabControl(SPU.Name, SPU.Tag.ToString(), SPU);
        }

        private void buttonItemSetDefCon_Click(object sender, EventArgs e)
        {
            //UserControls.SetDefCon_UC SPU = new UserControls.SetDefCon_UC();
            //TabControlMain.AddTabToTabControl(SPU.Name, SPU.Tag.ToString(), SPU);
        }
       
        #endregion


    }
}
