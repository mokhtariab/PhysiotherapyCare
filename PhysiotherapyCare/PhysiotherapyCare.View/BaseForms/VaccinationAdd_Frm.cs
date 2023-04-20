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
    public partial class VaccinationAdd_Frm : MKH.Library.Forms.MSSBaseNew_frm
    {
        private int _VaccinationCode = 0;
        private bool _editIns = false;

        public VaccinationAdd_Frm()
        {
            InitializeComponent();
        }

        public VaccinationAdd_Frm(int Vaccination)
        {
            InitializeComponent();
            _VaccinationCode = Vaccination;
            string str = "";
            textBoxTitleName.Text = new ViewModel.VisitPatient.Vaccination().GetAllListByID(Vaccination, ref str)[0].TitleName;
            _editIns = true;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckValidation())
                return;
            try
            {
                string str = ""; int? idSet = 0;
                List<TBL_Vaccination> Ls = new List<TBL_Vaccination>(1);
                TBL_Vaccination Vaccination = new TBL_Vaccination();
                Vaccination.Id = _VaccinationCode;
                Vaccination.TitleName = textBoxTitleName.Text;
                Ls.Add(Vaccination);

                if (!_editIns)
                {
                    new ViewModel.VisitPatient.Vaccination().InsertEntity(Ls, ref str, ref idSet);
                }
                else
                {
                    new ViewModel.VisitPatient.Vaccination().UpdateEntity(Ls, ref str);
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
