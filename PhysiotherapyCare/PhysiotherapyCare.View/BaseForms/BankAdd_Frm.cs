using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using PhysiotherapyCare.Model.Basic;


namespace PhysiotherapyCare.View.BaseForms
{
    public partial class BankAdd_Frm : MKH.Library.Forms.MSSBaseNew_frm
    {
        private byte _BankCode = 0;
        private bool _editIns = false;

        public BankAdd_Frm()
        {
            InitializeComponent();
        }

        public BankAdd_Frm(byte BankCode)
        {
            InitializeComponent();
            _BankCode = BankCode;
            string str = "";
            textBoxTitleName.Text = new ViewModel.Basic.Bank().GetAllListByID(BankCode, ref str)[0].TitleName;
            _editIns = true;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckValidation())
                return;
            try
            {
                string str = ""; short? idSet = 0;
                List<TBL_Bank> Ls = new List<TBL_Bank>(1);
                TBL_Bank Bank = new TBL_Bank();
                Bank.Id = _BankCode;
                Bank.TitleName = textBoxTitleName.Text;
                Ls.Add(Bank);

                if (!_editIns)
                {
                    new ViewModel.Basic.Bank().InsertEntity(Ls, ref str, ref idSet);
                }
                else
                {
                    new ViewModel.Basic.Bank().UpdateEntity(Ls, ref str);
                }

                if (str != "")
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "اشکال اطلاعات", str);
                else
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View("اطلاعات ذخیره شد", MKH.Library.Clasess.MSSMessage.MessageType.SInformation);
                    DialogResult = System.Windows.Forms.DialogResult.OK;
                    Close();
                }

            }
            catch(Exception ex)
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, ex.Message);
            }

        }


        private bool CheckValidation()
        {
            if (textBoxTitleName.Text.Trim() == "")
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("جای خالی را پر نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SInformation);
                return false;
            }
            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
