using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using PhysiotherapyCare.Model.VisitPatient;
using PhysiotherapyCare.ViewModel.VisitPatient;


namespace PhysiotherapyCare.View.BaseForms
{
    public partial class SicknessAdd_Frm : MKH.Library.Forms.MSSBaseNew_frm
    {
        private byte _SicknessCode = 0;
        private bool _editIns = false;

        public SicknessAdd_Frm()
        {
            InitializeComponent();
        }

        public SicknessAdd_Frm(byte SicknessCode)
        {
            InitializeComponent();
            _SicknessCode = SicknessCode;
            string str = "";
            textBoxTitleName.Text = new ViewModel.VisitPatient.Sickness().GetAllListByID(SicknessCode, ref str)[0].TitleName;
            _editIns = true;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckValidation())
                return;
            try
            {
                string str = ""; int? idSet = 0;
                List<TBL_Sickness> Ls = new List<TBL_Sickness>(1);
                TBL_Sickness Sickness = new TBL_Sickness();
                Sickness.Id = _SicknessCode;
                Sickness.TitleName = textBoxTitleName.Text;
                Ls.Add(Sickness);

                if (!_editIns)
                {
                    new ViewModel.VisitPatient.Sickness().InsertEntity(Ls, ref str, ref idSet);
                }
                else
                {
                    new ViewModel.VisitPatient.Sickness().UpdateEntity(Ls, ref str);
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
