using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using PhysiotherapyCare.Model.VisitPatient;


namespace PhysiotherapyCare.View.BaseForms
{
    public partial class DrugAdd_Frm : MKH.Library.Forms.MSSBaseNew_frm
    {
        private int _DrugCode = 0;
        private bool _editIns = false;

        public DrugAdd_Frm()
        {
            InitializeComponent();
        }

        public DrugAdd_Frm(int DrugCode)
        {
            InitializeComponent();
            _DrugCode = DrugCode;
            string str = "";
            textBoxTitleName.Text = new ViewModel.VisitPatient.Drug().GetAllListByID(DrugCode, ref str)[0].TitleName;
            _editIns = true;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckValidation())
                return;
            try
            {
                string str = ""; int? idSet = 0;
                List<TBL_Drug> Ls = new List<TBL_Drug>(1);
                TBL_Drug Drug = new TBL_Drug();
                Drug.Id = _DrugCode;
                Drug.TitleName = textBoxTitleName.Text;
                Ls.Add(Drug);

                if (!_editIns)
                {
                    new ViewModel.VisitPatient.Drug().InsertEntity(Ls, ref str, ref idSet);
                }
                else
                {
                    new ViewModel.VisitPatient.Drug().UpdateEntity(Ls, ref str);
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
