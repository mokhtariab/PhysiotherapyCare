using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using PhysiotherapyCare.Model.VisitHealthCare;


namespace PhysiotherapyCare.View.MainForms.VisitHealthCare
{
    public partial class ServiceTypeAdd_Frm : MKH.Library.Forms.MSSBaseNew_frm
    {
        private byte _ServiceTypeCode = 0;
        private bool _editIns = false;

        public ServiceTypeAdd_Frm()
        {
            InitializeComponent();
        }

        public ServiceTypeAdd_Frm(byte ServiceTypeCode)
        {
            InitializeComponent();
            _ServiceTypeCode = ServiceTypeCode;
            string str = "";
            textBoxTitleName.Text = new ViewModel.VisitHealthCare.ServiceType().GetAllListByID(ServiceTypeCode, ref str)[0].TitleName;
            _editIns = true;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckValidation())
                return;
            try
            {
                string str = ""; short? idSet = 0;
                List<TBL_ServiceType> Ls = new List<TBL_ServiceType>(1);
                TBL_ServiceType ServiceType = new TBL_ServiceType();
                ServiceType.Id = _ServiceTypeCode;
                ServiceType.TitleName = textBoxTitleName.Text;
                Ls.Add(ServiceType);

                if (!_editIns)
                {
                    new ViewModel.VisitHealthCare.ServiceType().InsertEntity(Ls, ref str, ref idSet);
                }
                else
                {
                    new ViewModel.VisitHealthCare.ServiceType().UpdateEntity(Ls, ref str);
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
