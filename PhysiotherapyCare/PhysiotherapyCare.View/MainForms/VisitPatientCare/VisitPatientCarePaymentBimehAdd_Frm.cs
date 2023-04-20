using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PhysiotherapyCare.ViewModel.VisitPatientCare;
using PhysiotherapyCare.Model.VisitPatientCare;
using PhysiotherapyCare.Model.Basic;


namespace PhysiotherapyCare.View.MainForms.VisitPatientCare
{
    public partial class VisitPatientCarePaymentBimehAdd_Frm : MKH.Library.Forms.MSSBaseNew_frm
    {
        private int _id = 0;
        private bool _editIns = false;
        public VisitPatientCarePaymentBimehAdd_Frm()
        {
            InitializeComponent();
        }

        public VisitPatientCarePaymentBimehAdd_Frm(int Id)
        {
            InitializeComponent();

            buttonItemOK.Enabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(175);
            if (buttonItemOK.Enabled)
            {
                string str = "";
                if (new ViewModel.Basic.NODuplicateForm().CheckNODuplicateForm("TBL_VisitPatientCarePayment", Id.ToString(), ref str))
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View("امکان ویرایش به علت انجام عملیات توسط کاربر دیگر امکان پذیر نمی باشد", MKH.Library.Clasess.MSSMessage.MessageType.SWarning);
                    Close();
                }
                else
                    new ViewModel.Basic.NODuplicateForm().InsertEntity("TBL_VisitPatientCarePayment", Id.ToString(), ref str);
            }

            _id = Id;
            _editIns = true;
        }

        #region Load
        private void DoctorPaymentNE_frm_Load(object sender, EventArgs e)
        {
            DatePickerInsuLetterDate.Value = KagNetComponents2.KagPersianDate.Now;

            SetComboBox();

            if (_editIns) fillControl();
        }

        private void SetComboBox()
        {
            string str = "";

            comboBoxBank.ValueMember = "Id";
            comboBoxBank.DisplayMember = "TitleName";
            comboBoxBank.DataSource = new PhysiotherapyCare.ViewModel.Basic.Bank().GetAllList(ref str);
        }


        private void fillControl()
        {
            string str = "";
            ViewModel.VisitPatientCare.VisitPatientCarePayment RN = new ViewModel.VisitPatientCare.VisitPatientCarePayment();
            List<VW_VisitPatientCarePayment> VPC = RN.GetAllListByID(_id, ref str);

            textBoxCasherName.Text = VPC[0].CasherName;
            TextBoxCasherNationalCode.Text = VPC[0].CasherNationalCode;

            TextBoxCardBankNo1.Text = VPC[0].CardBankNo1;
            try { comboBoxBank.SelectedValue = VPC[0].Bank_Id.Value; }
            catch { }

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
                List<TBL_VisitPatientCarePayment> Ls = new List<TBL_VisitPatientCarePayment>(1);
                TBL_VisitPatientCarePayment VisitPatientCarePayment = new TBL_VisitPatientCarePayment();
                VisitPatientCarePayment.Id = _id;

                VisitPatientCarePayment.InsuLetterNo = TextBoxInsuLetterNo.Text;

                VisitPatientCarePayment.CasherName = textBoxCasherName.Text;
                VisitPatientCarePayment.CasherNationalCode = TextBoxCasherNationalCode.Text;
                VisitPatientCarePayment.Bank_Id = Convert.ToInt16(comboBoxBank.SelectedValue);
                VisitPatientCarePayment.CardBankNo1 = TextBoxCardBankNo1.Text;

                VisitPatientCarePayment.CostReqInsu = Convert.ToInt32(IntBoxCostReqInsu.Value);
                VisitPatientCarePayment.ReportCode = Convert.ToInt32(IntBoxReportCode.Value);
                VisitPatientCarePayment.InsuLetterDate = CheckBoxInsuLetterDate.Checked ? DatePickerInsuLetterDate.Value.ToString().Substring(0, 10) : "";

                VisitPatientCarePayment.User_Id = MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID;
                VisitPatientCarePayment.ChangeDateTime = MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now);

                Ls.Add(VisitPatientCarePayment);

                if (!_editIns)
                {
                }
                else
                {
                    new ViewModel.VisitPatientCare.VisitPatientCarePayment().UpdateEntityForDetailBimeh(Ls, ref str);
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

        
        private void VisitPatientCarePaymentBimehAdd_Frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            string str = "";
            if (buttonItemOK.Enabled)
                new ViewModel.Basic.NODuplicateForm().DeleteEntity("TBL_VisitPatientCarePayment", _id.ToString(), ref str);
        }

        private void CheckBoxAnalyzeDate_CheckedChanged(object sender, EventArgs e)
        {
            DatePickerInsuLetterDate.Enabled = CheckBoxInsuLetterDate.Checked;
        }

       
       
    }
}
