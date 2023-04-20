using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;


namespace MKH.SMS.View.Forms
{
    public partial class SMSSetting_Frm : MKH.Library.Forms.MSSBaseNew_frm
    {


        public SMSSetting_Frm()
        {
            InitializeComponent();
        }

        private void SMSSetting_Frm_Load(object sender, EventArgs e)
        {
            fillControl();
        }

        private void fillControl()
        {
            string str = "";
            textBoxUserName.Text = new ViewModel.SettingSMS.SettingSMS().GetAllValue("InternetUserName", ref str);
            textBoxPassword.Text = MKH.Library.Clasess.Security.MSSFunction_Cls.DecriptionText( new ViewModel.SettingSMS.SettingSMS().GetAllValue("InternetPassword", ref str),Library.Clasess.Security.MSSFunction_Cls.EncDecryption.PrivateEncDec);
            textBoxTelNumber.Text = new ViewModel.SettingSMS.SettingSMS().GetAllValue("InternetTelNumber", ref str);
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckValidation())
                return;
            try
            {
                string str = "";


                MKH.SMS.Model.SettingSMS.TBL_SettingSM setting = null;
                List<MKH.SMS.Model.SettingSMS.TBL_SettingSM> ls = new List<Model.SettingSMS.TBL_SettingSM>();

                setting = new Model.SettingSMS.TBL_SettingSM();
                setting.Name = "InternetUserName";
                setting.value = textBoxUserName.Text;
                ls.Add(setting);

                setting = new Model.SettingSMS.TBL_SettingSM();
                setting.Name = "InternetPassword";
                setting.value = MKH.Library.Clasess.Security.MSSFunction_Cls.EncriptionText(textBoxPassword.Text,Library.Clasess.Security.MSSFunction_Cls.EncDecryption.PublicEncDec);
                ls.Add(setting);

                setting = new Model.SettingSMS.TBL_SettingSM();
                setting.Name = "InternetTelNumber";
                setting.value = textBoxTelNumber.Text;
                ls.Add(setting);


                new ViewModel.SettingSMS.SettingSMS().UpdateEntity(ls, ref str);

                Close();
            }
            catch (Exception ex)
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, ex.Message);
            }

        }



        private bool CheckValidation()
        {
            if (textBoxUserName.Text.Trim() == "")
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("لطفا نام کاربری را پر نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                return false;
            }
            if (textBoxPassword.Text.Trim() == "")
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("لطفا پسورد را پر نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                return false;
            }
            if (textBoxTelNumber.Text.Trim() == "")
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("لطفا شماره پیامکی را پر نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                return false;
            }
            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void buttonTestCredit_Click(object sender, EventArgs e)
        {
            double DCredit = MKH.SMS.View.Class.SMSClass.GetCreditSMS(textBoxUserName.Text, textBoxPassword.Text);
            if (DCredit >= 1 && DCredit <= 10)
                MKH.Library.Clasess.MSSMessage.MSSMessage_View(" کد اشکال : " + DCredit.ToString(),Library.Clasess.MSSMessage.MessageType.SError);
            else
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("مبلغ باقیمانده شارژ " + DCredit.ToString() + "ریال می باشد", Library.Clasess.MSSMessage.MessageType.SInformation);
        }


    }
}
