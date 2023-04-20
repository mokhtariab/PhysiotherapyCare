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
    public partial class InjuryTypeAdd_Frm : MKH.Library.Forms.MSSBaseNew_frm
    {
        private byte _InjuryTypeCode = 0;
        private bool _editIns = false;

        public InjuryTypeAdd_Frm()
        {
            InitializeComponent();
        }

        public InjuryTypeAdd_Frm(byte InjuryTypeCode)
        {
            InitializeComponent();
            _InjuryTypeCode = InjuryTypeCode;
            string str = "";
            textBoxTitleName.Text = new ViewModel.Basic.InjuryType().GetAllListByID(InjuryTypeCode, ref str)[0].TitleName;
            _editIns = true;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckValidation())
                return;
            try
            {
                string str = ""; short? idSet = 0;
                List<TBL_InjuryType> Ls = new List<TBL_InjuryType>(1);
                TBL_InjuryType InjuryType = new TBL_InjuryType();
                InjuryType.Id = _InjuryTypeCode;
                InjuryType.TitleName = textBoxTitleName.Text;
                Ls.Add(InjuryType);

                if (!_editIns)
                {
                    new ViewModel.Basic.InjuryType().InsertEntity(Ls, ref str, ref idSet);
                }
                else
                {
                    new ViewModel.Basic.InjuryType().UpdateEntity(Ls, ref str);
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
