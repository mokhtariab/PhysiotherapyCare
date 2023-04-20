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
    public partial class PatientStatusTypeAdd_Frm : MKH.Library.Forms.MSSBaseNew_frm
    {
        private byte _PatientStatusTypeCode = 0;
        private bool _editIns = false;

        public PatientStatusTypeAdd_Frm()
        {
            InitializeComponent();
        }

        public PatientStatusTypeAdd_Frm(byte PatientStatusTypeCode)
        {
            InitializeComponent();
            _PatientStatusTypeCode = PatientStatusTypeCode;
            string str = "";
            textBoxTitleName.Text = new ViewModel.Basic.PatientStatusType().GetAllListByID(PatientStatusTypeCode, ref str)[0].TitleName;
            _editIns = true;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckValidation())
                return;
            try
            {
                string str = ""; short? idSet = 0;
                List<TBL_PatientStatusType> Ls = new List<TBL_PatientStatusType>(1);
                TBL_PatientStatusType PatientStatusType = new TBL_PatientStatusType();
                PatientStatusType.Id = _PatientStatusTypeCode;
                PatientStatusType.TitleName = textBoxTitleName.Text;
                Ls.Add(PatientStatusType);

                if (!_editIns)
                {
                    new ViewModel.Basic.PatientStatusType().InsertEntity(Ls, ref str, ref idSet);
                }
                else
                {
                    new ViewModel.Basic.PatientStatusType().UpdateEntity(Ls, ref str);
                }

                MKH.Library.Clasess.MSSMessage.MSSMessage_View("اطلاعات ذخیره شد", MKH.Library.Clasess.MSSMessage.MessageType.SInformation);
                DialogResult = System.Windows.Forms.DialogResult.OK;
                Close();
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
