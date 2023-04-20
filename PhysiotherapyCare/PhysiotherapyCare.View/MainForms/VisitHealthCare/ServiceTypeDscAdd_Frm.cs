using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using PhysiotherapyCare.Model.VisitHealthCare;
using PhysiotherapyCare.ViewModel.VisitHealthCare;


namespace PhysiotherapyCare.View.MainForms.VisitHealthCare
{
    public partial class ServiceTypeDscAdd_Frm : MKH.Library.Forms.MSSBaseNew_frm
    {
        private int _id = 0;
        private bool _editIns = false;
        string str = "";

        public ServiceTypeDscAdd_Frm()
        {
            InitializeComponent();
        }

        public ServiceTypeDscAdd_Frm(int Id)
        {
            InitializeComponent();
            _id = Id;
            _editIns = true;
        }

        private void ServiceTypeDscAdd_Frm_Load(object sender, EventArgs e)
        {
            SetComboBox();

            if (_editIns) fillControl();
        }

        private void SetComboBox()
        {
            ComboBoxServiceType.ValueMember = "Id";
            ComboBoxServiceType.DisplayMember = "TitleName";
            ComboBoxServiceType.DataSource = new ServiceType().GetAllList(ref str);
        }


        private void fillControl()
        {
            string str = "";
            ServiceTypeDsc RN = new ServiceTypeDsc();
            List<VW_ServiceTypeDsc> DT = RN.GetAllListByID(_id, ref str);


            ComboBoxServiceType.SelectedValue = DT[0].ServiceType_Id;
            textBoxTitleName.Text = DT[0].TitleName;
            IntBoxPriceType.Value = DT[0].PriceType;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckValidation())
                return;
            try
            {
                string str = ""; int? idSet = 0;
                List<TBL_ServiceTypeDsc> Ls = new List<TBL_ServiceTypeDsc>(1);
                TBL_ServiceTypeDsc ServiceTypeDsc = new TBL_ServiceTypeDsc();
                ServiceTypeDsc.Id = _id;
                ServiceTypeDsc.ServiceType_Id = Convert.ToInt16(ComboBoxServiceType.SelectedValue);
                ServiceTypeDsc.TitleName = textBoxTitleName.Text;
                ServiceTypeDsc.PriceType = Convert.ToInt32(IntBoxPriceType.Value.ToString());
                Ls.Add(ServiceTypeDsc);

                if (!_editIns)
                {
                    new ViewModel.VisitHealthCare.ServiceTypeDsc().InsertEntity(Ls, ref str, ref idSet);
                }
                else
                {
                    new ViewModel.VisitHealthCare.ServiceTypeDsc().UpdateEntity(Ls, ref str);
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
            if (ComboBoxServiceType.Text.Trim() == "")
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("نوع خدمت را پر نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SInformation);
                return false;
            }
            if (textBoxTitleName.Text.Trim() == "")
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("شرح خدمت را پر نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SInformation);
                return false;
            }
            if (IntBoxPriceType.Text.Trim() == "0")
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("مبلغ خدمت را پر نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SInformation);
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
