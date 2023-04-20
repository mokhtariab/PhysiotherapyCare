using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using PhysiotherapyCare.Model.Status;


namespace PhysiotherapyCare.View.MainForms.Status
{
    public partial class StatusTypeAdd_Frm : MKH.Library.Forms.MSSBaseNew_frm
    {
        private byte _StatusTypeCode = 0;
        private bool _editIns = false;

        public StatusTypeAdd_Frm()
        {
            InitializeComponent();
        }

        public StatusTypeAdd_Frm(byte StatusTypeCode)
        {
            InitializeComponent();
            _StatusTypeCode = StatusTypeCode;
            string str = "";
            textBoxTitleName.Text = new ViewModel.Status.StatusType().GetAllListByID(StatusTypeCode, ref str)[0].TitleName;
            _editIns = true;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckValidation())
                return;
            try
            {
                string str = ""; short? idSet = 0;
                List<TBL_StatusType> Ls = new List<TBL_StatusType>(1);
                TBL_StatusType StatusType = new TBL_StatusType();
                StatusType.Id = _StatusTypeCode;
                StatusType.TitleName = textBoxTitleName.Text;
                Ls.Add(StatusType);

                if (!_editIns)
                {
                    new ViewModel.Status.StatusType().InsertEntity(Ls, ref str, ref idSet);
                }
                else
                {
                    new ViewModel.Status.StatusType().UpdateEntity(Ls, ref str);
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
