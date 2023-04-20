using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PhysiotherapyCare.ViewModel.VisitHealthCare;
using PhysiotherapyCare.Model.VisitHealthCare;
using PhysiotherapyCare.Model.Basic;


namespace PhysiotherapyCare.View.MainForms.VisitHealthCare
{
    public partial class VisitHealthCarePaymentBimehAdd_Frm : MKH.Library.Forms.MSSBaseNew_frm
    {
        private int _id = 0;
        private bool _editIns = false;
        public VisitHealthCarePaymentBimehAdd_Frm()
        {
            InitializeComponent();
        }

        public VisitHealthCarePaymentBimehAdd_Frm(int Id)
        {
            InitializeComponent();

            buttonItemOK.Enabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(191);
            if (buttonItemOK.Enabled)
            {
                string str = "";
                if (new ViewModel.Basic.NODuplicateForm().CheckNODuplicateForm("TBL_VisitHealthCarePayment", Id.ToString(), ref str))
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View("امکان ویرایش به علت انجام عملیات توسط کاربر دیگر امکان پذیر نمی باشد", MKH.Library.Clasess.MSSMessage.MessageType.SWarning);
                    Close();
                }
                else
                    new ViewModel.Basic.NODuplicateForm().InsertEntity("TBL_VisitHealthCarePayment", Id.ToString(), ref str);
            }

            _id = Id;
            _editIns = true;
        }

        #region Load
        private void DoctorPaymentNE_frm_Load(object sender, EventArgs e)
        {
            DatePickerInsuLetterDate.Value = KagNetComponents2.KagPersianDate.Now;
            
            if (_editIns) fillControl();
        }

        private void fillControl()
        {
            string str = "";
            ViewModel.VisitHealthCare.VisitHealthCarePayment RN = new ViewModel.VisitHealthCare.VisitHealthCarePayment();
            List<VW_VisitHealthCarePayment> VPC = RN.GetAllListByID(_id, ref str);

            TextBoxDoctor.Tag = VPC[0].Doctor_Id;
            TextBoxDoctor.Text = VPC[0].DoctorName + " " + VPC[0].DoctorFamily;

            try { DatePickerInsuLetterDate.Value = KagNetComponents2.KagPersianDate.Parse(VPC[0].InsuLetterDate.Substring(0, 10)); }
            catch { CheckBoxInsuLetterDate.Checked = false; }
            TextBoxInsuLetterNo.Text = VPC[0].InsuLetterNo;

            IntBoxCostReqInsu.Value = Math.Abs(VPC[0].CostReqInsu.Value);
            IntBoxReportCode.Value = VPC[0].ReportCode ?? 0;

        }

        #endregion


        #region Save
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckValidation())
                return;
            try
            {
                string str = ""; long? idSet = 0;
                List<TBL_VisitHealthCarePayment> Ls = new List<TBL_VisitHealthCarePayment>(1);
                TBL_VisitHealthCarePayment VisitHealthCarePayment = new TBL_VisitHealthCarePayment();
                VisitHealthCarePayment.Id = _id;
                
                VisitHealthCarePayment.InsuLetterNo = TextBoxInsuLetterNo.Text;

                VisitHealthCarePayment.CostReqInsu = Convert.ToInt32(IntBoxCostReqInsu.Value);
                VisitHealthCarePayment.ReportCode = Convert.ToInt32(IntBoxReportCode.Value);

                VisitHealthCarePayment.InsuLetterDate = CheckBoxInsuLetterDate.Checked ? DatePickerInsuLetterDate.Value.ToString().Substring(0, 10) : "";

                VisitHealthCarePayment.User_Id = MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID;
                VisitHealthCarePayment.ChangeDateTime = MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now);

                Ls.Add(VisitHealthCarePayment);

                if (!_editIns)
                {
                }
                else
                {
                    new ViewModel.VisitHealthCare.VisitHealthCarePayment().UpdateEntityForDetailBimeh(Ls, ref str);
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
            catch (Exception ex)
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, ex.Message);
            }

        }



        private bool CheckValidation()
        {
            
            
            if (IntBoxCostReqInsu.Text.Trim() == "0")
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("لطفا مبلغ را پر نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                return false;
            }
            
            return true;
        }


        private void buttonItem_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        
        private void VisitHealthCarePaymentBimehAdd_Frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            string str = "";
            if (buttonItemOK.Enabled)
                new ViewModel.Basic.NODuplicateForm().DeleteEntity("TBL_VisitHealthCarePayment", _id.ToString(), ref str);
        }

        private void CheckBoxAnalyzeDate_CheckedChanged(object sender, EventArgs e)
        {
            DatePickerInsuLetterDate.Enabled = CheckBoxInsuLetterDate.Checked;
        }

       
       
    }
}
