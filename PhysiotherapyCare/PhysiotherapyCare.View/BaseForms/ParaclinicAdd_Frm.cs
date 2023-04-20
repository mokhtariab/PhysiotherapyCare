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
    public partial class ParaclinicAdd_Frm : MKH.Library.Forms.MSSBaseNew_frm
    {
        private int _paraclinicCode = 0;
        private bool _editIns = false;

        public ParaclinicAdd_Frm()
        {
            InitializeComponent();
        }

        public ParaclinicAdd_Frm(int ParaclinicCode)
        {
            InitializeComponent();
            _paraclinicCode = ParaclinicCode;
            string str = "";
            textBoxTitleName.Text = new ViewModel.VisitPatient.Paraclinic().GetAllListByID(ParaclinicCode, ref str)[0].TitleName;
            _editIns = true;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckValidation())
                return;
            try
            {
                string str = ""; int? idSet = 0;
                List<TBL_Paraclinic> Ls = new List<TBL_Paraclinic>(1);
                TBL_Paraclinic Paraclinic = new TBL_Paraclinic();
                Paraclinic.Id = _paraclinicCode;
                Paraclinic.TitleName = textBoxTitleName.Text;
                Ls.Add(Paraclinic);

                if (!_editIns)
                {
                    new ViewModel.VisitPatient.Paraclinic().InsertEntity(Ls, ref str, ref idSet);
                }
                else
                {
                    new ViewModel.VisitPatient.Paraclinic().UpdateEntity(Ls, ref str);
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
