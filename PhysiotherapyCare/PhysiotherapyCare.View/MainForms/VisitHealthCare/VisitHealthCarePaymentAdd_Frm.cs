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
    public partial class VisitHealthCarePaymentAdd_Frm : MKH.Library.Forms.MSSBaseNew_frm
    {
        private int _id = 0;
        private bool _editIns = false;
        public VisitHealthCarePaymentAdd_Frm()
        {
            InitializeComponent();
        }

        public VisitHealthCarePaymentAdd_Frm(int Id)
        {
            InitializeComponent();

            buttonItemOK.Enabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(166);
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
            DatePickerPaymentDate.Value = DatePickerAnalyzeDate.Value =
                DatePickerAccountingDocumentDate.Value = DatePickerBursaryDate.Value =
                DatePickerCostIncreaseDate.Value = DatePickerBonyadConfirmDate.Value = DatePickerSecretiatDate.Value =
                DatePickerPaymentDoctorDate.Value = KagNetComponents2.KagPersianDate.Now;
            
            SetComboBox();

            if (_editIns) fillControl();
        }

        private void SetComboBox()
        {
            string str = "";

            comboBoxPaymentStatus.ValueMember = "Id";
            comboBoxPaymentStatus.DisplayMember = "TitleName";
            comboBoxPaymentStatus.DataSource = new PhysiotherapyCare.ViewModel.Basic.PaymentStatus().GetAllList(ref str);
        }

        double DoctorTaxPercent = 0;
        double CostInsurancePercent = 0;
        double CostCompanyPercent = 0;
        private void fillControl()
        {
            string str = "";
            ViewModel.VisitHealthCare.VisitHealthCarePayment RN = new ViewModel.VisitHealthCare.VisitHealthCarePayment();
            List<VW_VisitHealthCarePayment> VPC = RN.GetAllListByID(_id, ref str);

            TextBoxDoctor.Tag = VPC[0].Doctor_Id;
            TextBoxDoctor.Text = VPC[0].DoctorName + " " + VPC[0].DoctorFamily;

            comboBoxPaymentStatus.SelectedValue = VPC[0].PaymentStatus_Id.Value;

            DatePickerPaymentDate.Value = KagNetComponents2.KagPersianDate.Parse(VPC[0].PaymentDate.Substring(0, 10));
            try { DatePickerAnalyzeDate.Value = KagNetComponents2.KagPersianDate.Parse(VPC[0].AnalyzeDate.Substring(0, 10)); }
            catch { CheckBoxAnalyzeDate.Checked = false; }
            try { DatePickerAccountingDocumentDate.Value = KagNetComponents2.KagPersianDate.Parse(VPC[0].AccountingDocumentDate.Substring(0, 10));}
            catch { CheckBoxAccountingDocumentDate.Checked = false; }
            try { DatePickerBursaryDate.Value = KagNetComponents2.KagPersianDate.Parse(VPC[0].BursaryDate.Substring(0, 10));}
            catch { CheckBoxBursaryDate.Checked = false; }
            try { DatePickerCostIncreaseDate.Value = KagNetComponents2.KagPersianDate.Parse(VPC[0].CostIncreaseDate.Substring(0, 10));}
            catch { CheckBoxCostIncreaseDate.Checked = false; }
            try { DatePickerPaymentDoctorDate.Value = KagNetComponents2.KagPersianDate.Parse(VPC[0].PaymentDoctorDate.Substring(0, 10)); }
            catch { CheckBoxPaymentDoctorDate.Checked = false; }

            textBoxAccountingDocumentNumber.Text = VPC[0].AccountingDocumentNumber;
            TextBoxBursaryNumber.Text = VPC[0].BursaryNumber;
            TextBoxAnalyzeNo.Text = VPC[0].AnalyzeNo;

            IntBoxCostCachInsu.Value = Math.Abs(VPC[0].CostCachInsu ?? 0);
            IntBoxAnalyzePage.Value = VPC[0].AnalyzePage??0;
            IntBoxCostCompany.Value = Math.Abs(VPC[0].CostCompany ?? 0);
            IntBoxCostIncrease.Value = Math.Abs(VPC[0].CostIncrease ?? 0);
            IntBoxCostDoctor.Value = Math.Abs(VPC[0].CostDoctor ?? 0);
            IntBoxCostDoctorTax.Value = Math.Abs(VPC[0].CostDoctorTax);
            IntBoxCostDoctorInsurance.Value = Math.Abs(VPC[0].CostDoctorInsurance);
            IntBoxCostDoctorPrePayment.Value = Math.Abs(VPC[0].CostDoctorPrePayment);

            textBoxDescription.Text = VPC[0].Description;

            try { DatePickerBonyadConfirmDate.Value = KagNetComponents2.KagPersianDate.Parse(VPC[0].BonyadConfirmDate.Substring(0, 10)); }
            catch { CheckBoxBonyadConfirmDate.Checked = false; }
            try { DatePickerSecretiatDate.Value = KagNetComponents2.KagPersianDate.Parse(VPC[0].SecretiatDate.Substring(0, 10)); }
            catch { CheckBoxSecretiatDate.Checked = false; }

            textBoxBonyadConfirmNo.Text = VPC[0].BonyadConfirmNo;
            TextBoxSecretiatNo.Text = VPC[0].SecretiatNo;


            CostCompanyPercent = (double.Parse((IntBoxCostCompany.Value ?? 0).ToString()) * 100 / double.Parse((IntBoxCostCachInsu.Value ?? 1).ToString()));
            DoctorTaxPercent = double.Parse((IntBoxCostDoctorTax.Value ?? 0).ToString()) * 100 / (double.Parse((IntBoxCostCachInsu.Value ?? 1).ToString()) - double.Parse((IntBoxCostCompany.Value ?? 0).ToString()));
            CostInsurancePercent = double.Parse((IntBoxCostDoctorInsurance.Value ?? 0).ToString()) * 100 / (double.Parse((IntBoxCostCachInsu.Value ?? 1).ToString()) - double.Parse((IntBoxCostCompany.Value ?? 0).ToString()));
            if (double.IsNaN(CostCompanyPercent) || CostCompanyPercent == 0)
            {
                CostCompanyPercent = double.Parse(new ViewModel.Setting.Setting().GetAllValue("CostCompanyHealthPercent", ref str).ToString());

                try { DoctorTaxPercent = new ViewModel.Doctors.Doctor().GetAllListByID(VPC[0].Doctor_Id.Value, ref str).Last().DoctorTaxPercent.Value; }
                catch { }
                CostInsurancePercent = double.Parse(new ViewModel.Setting.Setting().GetAllValue("CostInsurancePercent", ref str).ToString());
            }

            _setvalueChange = false;

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

                VisitHealthCarePayment.PaymentStatus_Id = Convert.ToInt16(comboBoxPaymentStatus.SelectedValue);
                VisitHealthCarePayment.PaymentStatusDate = MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsi(DateTime.Now);

                VisitHealthCarePayment.AccountingDocumentNumber = textBoxAccountingDocumentNumber.Text;
                VisitHealthCarePayment.BursaryNumber = TextBoxBursaryNumber.Text;
                VisitHealthCarePayment.AnalyzeNo = TextBoxAnalyzeNo.Text;

                VisitHealthCarePayment.CostVisitDoctorBes = 0;
                VisitHealthCarePayment.CostDoctor = Convert.ToInt32(IntBoxCostDoctor.Value);
                VisitHealthCarePayment.CostDoctorTax = Convert.ToInt32(IntBoxCostDoctorTax.Value);
                VisitHealthCarePayment.CostDoctorInsurance = Convert.ToInt32(IntBoxCostDoctorInsurance.Value);
                VisitHealthCarePayment.CostDoctorPrePayment = Convert.ToInt32(IntBoxCostDoctorPrePayment.Value);
                VisitHealthCarePayment.CostCachInsu = Convert.ToInt32(IntBoxCostCachInsu.Value);
                VisitHealthCarePayment.AnalyzePage = Convert.ToInt32(IntBoxAnalyzePage.Value);
                VisitHealthCarePayment.CostCompany = Convert.ToInt32(IntBoxCostCompany.Value);
                VisitHealthCarePayment.CostIncrease = Convert.ToInt32(IntBoxCostIncrease.Value);

                VisitHealthCarePayment.PaymentDate = DatePickerPaymentDate.Value.ToString().Substring(0, 10);
                VisitHealthCarePayment.AccountingDocumentDate = CheckBoxAccountingDocumentDate.Checked ? DatePickerAccountingDocumentDate.Value.ToString().Substring(0, 10) : "";
                VisitHealthCarePayment.AnalyzeDate = CheckBoxAnalyzeDate.Checked ? DatePickerAnalyzeDate.Value.ToString().Substring(0, 10) : "";
                VisitHealthCarePayment.BursaryDate = CheckBoxBursaryDate.Checked ? DatePickerBursaryDate.Value.ToString().Substring(0, 10) : "";
                VisitHealthCarePayment.CostIncreaseDate = CheckBoxCostIncreaseDate.Checked ? DatePickerCostIncreaseDate.Value.ToString().Substring(0, 10) : "";
                VisitHealthCarePayment.PaymentDoctorDate = CheckBoxPaymentDoctorDate.Checked ? DatePickerPaymentDoctorDate.Value.ToString().Substring(0, 10) : "";

                VisitHealthCarePayment.BonyadConfirmNo = textBoxBonyadConfirmNo.Text;
                VisitHealthCarePayment.SecretiatNo = TextBoxSecretiatNo.Text;
                
                VisitHealthCarePayment.BonyadConfirmDate = CheckBoxBonyadConfirmDate.Checked ? DatePickerBonyadConfirmDate.Value.ToString().Substring(0, 10) : "";
                VisitHealthCarePayment.SecretiatDate = CheckBoxSecretiatDate.Checked ? DatePickerSecretiatDate.Value.ToString().Substring(0, 10) : "";

                VisitHealthCarePayment.Description = textBoxDescription.Text;

                VisitHealthCarePayment.User_Id = MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID;
                VisitHealthCarePayment.ChangeDateTime = MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now);

                Ls.Add(VisitHealthCarePayment);

                if (!_editIns)
                {
                    new ViewModel.VisitHealthCare.VisitHealthCarePayment().InsertEntity(Ls, ref str, ref idSet);
                }
                else
                {
                    new ViewModel.VisitHealthCare.VisitHealthCarePayment().UpdateEntityForDetail(Ls, ref str);
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
            //if (TextBoxDoctor.Text.Trim() == "")
            //{
            //    MKH.Library.Clasess.MSSMessage.MSSMessage_View("لطفا نام پزشک را پر نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation);
            //    return false;
            //}
            
            //if (IntBoxCostDoctor.Text.Trim() == "0")
            //{
            //    MKH.Library.Clasess.MSSMessage.MSSMessage_View("لطفا مبلغ را پر نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation);
            //    return false;
            //}
            
            return true;
        }


        private void buttonItem_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        
        private void VisitHealthCarePaymentAdd_Frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            string str = "";
            if (buttonItemOK.Enabled)
                new ViewModel.Basic.NODuplicateForm().DeleteEntity("TBL_VisitHealthCarePayment", _id.ToString(), ref str);
        }

        private void CheckBoxAnalyzeDate_CheckedChanged(object sender, EventArgs e)
        {
            DatePickerAnalyzeDate.Enabled = CheckBoxAnalyzeDate.Checked;
        }

        private void CheckBoxAccountingDocumentDate_CheckedChanged(object sender, EventArgs e)
        {
            DatePickerAccountingDocumentDate.Enabled = CheckBoxAccountingDocumentDate.Checked;
        }

        private void CheckBoxBursaryDate_CheckedChanged(object sender, EventArgs e)
        {
            DatePickerBursaryDate.Enabled = CheckBoxBursaryDate.Checked;
        }

        private void CheckBoxCostIncreaseDate_CheckedChanged(object sender, EventArgs e)
        {
            DatePickerCostIncreaseDate.Enabled = CheckBoxCostIncreaseDate.Checked;
        }

        private void CheckBoxPaymentDoctorDate_CheckedChanged(object sender, EventArgs e)
        {
            DatePickerPaymentDoctorDate.Enabled = CheckBoxPaymentDoctorDate.Checked;
        }

        bool _setvalueChange = false;
        private void IntBoxCostCachInsu_ValueChanged(object sender, EventArgs e)
        {
            if (_setvalueChange) return;
            if ((sender as MKH.Library.Control.MSSIntBox) == IntBoxCostCachInsu)
            {
                int CostCachInsuIran = int.Parse(IntBoxCostCachInsu.Value.ToString());
                int CostCompany = Other.Class.Function_Cls.CalculateCostCompany(CostCachInsuIran, CostCompanyPercent);
                int CostDoctorTax = Other.Class.Function_Cls.CalculateTax(CostCachInsuIran, CostCompany, DoctorTaxPercent);
                int CostDoctorInsurance = Other.Class.Function_Cls.CalculateInsurance(CostCachInsuIran, CostCompany, CostInsurancePercent);
                int CostDoctor = Other.Class.Function_Cls.CalculateCostDoctor(CostCachInsuIran, CostCompany,
                    int.Parse((IntBoxCostIncrease.Value ?? 0).ToString()),
                    CostDoctorTax, CostDoctorInsurance,
                    int.Parse((IntBoxCostDoctorPrePayment.Value ?? 0).ToString()));

                IntBoxCostCompany.Value = CostCompany;
                IntBoxCostDoctorTax.Value = CostDoctorTax;
                IntBoxCostDoctorInsurance.Value = CostDoctorInsurance;
                IntBoxCostDoctor.Value = CostDoctor;
            }

            if ((sender as MKH.Library.Control.MSSIntBox) == IntBoxCostCompany)
            {
                int CostCachInsuIran = int.Parse(IntBoxCostCachInsu.Value.ToString());
                int CostCompany = int.Parse(IntBoxCostCompany.Value.ToString());
                int CostDoctorTax = Other.Class.Function_Cls.CalculateTax(CostCachInsuIran, CostCompany, DoctorTaxPercent);
                int CostDoctorInsurance = Other.Class.Function_Cls.CalculateInsurance(CostCachInsuIran, CostCompany, CostInsurancePercent);
                int CostDoctor = Other.Class.Function_Cls.CalculateCostDoctor(CostCachInsuIran, CostCompany,
                    int.Parse((IntBoxCostIncrease.Value ?? 0).ToString()),
                    CostDoctorTax, CostDoctorInsurance,
                    int.Parse((IntBoxCostDoctorPrePayment.Value ?? 0).ToString()));

                IntBoxCostCompany.Value = CostCompany;
                IntBoxCostDoctorTax.Value = CostDoctorTax;
                IntBoxCostDoctorInsurance.Value = CostDoctorInsurance;
                IntBoxCostDoctor.Value = CostDoctor;
            }

            if ((sender as MKH.Library.Control.MSSIntBox) == IntBoxCostDoctorTax || (sender as MKH.Library.Control.MSSIntBox) == IntBoxCostDoctorInsurance || (sender as MKH.Library.Control.MSSIntBox) == IntBoxCostIncrease)
            {
                int CostCachInsuIran = int.Parse(IntBoxCostCachInsu.Value.ToString());
                int CostCompany = int.Parse(IntBoxCostCompany.Value.ToString());
                int CostDoctorTax = int.Parse(IntBoxCostDoctorTax.Value.ToString());
                int CostDoctorInsurance = int.Parse(IntBoxCostDoctorInsurance.Value.ToString());
                int CostDoctor = Other.Class.Function_Cls.CalculateCostDoctor(CostCachInsuIran, CostCompany,
                    int.Parse((IntBoxCostIncrease.Value ?? 0).ToString()),
                    CostDoctorTax, CostDoctorInsurance,
                    int.Parse((IntBoxCostDoctorPrePayment.Value ?? 0).ToString()));

                IntBoxCostCompany.Value = CostCompany;
                IntBoxCostDoctorTax.Value = CostDoctorTax;
                IntBoxCostDoctorInsurance.Value = CostDoctorInsurance;
                IntBoxCostDoctor.Value = CostDoctor;
            }
        }

        private void CheckBoxBonyadConfirmDate_CheckedChanged(object sender, EventArgs e)
        {
            DatePickerBonyadConfirmDate.Enabled = CheckBoxBonyadConfirmDate.Checked;
        }

        private void CheckBoxSecretiatDate_CheckedChanged(object sender, EventArgs e)
        {
            DatePickerSecretiatDate.Enabled = CheckBoxSecretiatDate.Checked;
        }
       
    }
}
