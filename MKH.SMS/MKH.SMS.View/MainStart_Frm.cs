using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MKH.SMS.View
{
    public partial class MainStart_Frm : MKH.Library.Forms.MSSMainForm
    {
        public MainStart_Frm()
        {
            InitializeComponent();
        }

        private void buttonItemSendSMS_Click(object sender, EventArgs e)
        {
            Forms.SendSMSAdd_Frm SSAF = new Forms.SendSMSAdd_Frm();
            SSAF.ShowDialog();
        }

        private void buttonItemSendSMSList_Click(object sender, EventArgs e)
        {
            UserControls.SendSMSList_UC SPU = new UserControls.SendSMSList_UC();
            TabControlMain.AddTabToTabControl(SPU.Name, SPU.Tag.ToString(), SPU);
        }

        private void buttonItemReciveSMS_Click(object sender, EventArgs e)
        {
            UserControls.ReciveSMSList_UC SPU = new UserControls.ReciveSMSList_UC();
            TabControlMain.AddTabToTabControl(SPU.Name, SPU.Tag.ToString(), SPU);
        }

    }
}
