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
    public partial class VisitHealthCarePaymentPrePaymentAdd_Frm : MKH.Library.Forms.MSSBaseNew_frm
    {
        private int _id = 0;
        private bool _editIns = false;
        int FixedCostVisit = 0;
        string MonthForPayment = "";
        public VisitHealthCarePaymentPrePaymentAdd_Frm()
        {
            InitializeComponent();
        }

        public VisitHealthCarePaymentPrePaymentAdd_Frm(int Id)
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
            DatePickerPaymentDate.Value = KagNetComponents2.KagPersianDate.Parse(DateTime.Now);
            
            SetComboBox();

            if (_editIns) fillControl();
        }

        private void SetComboBox()
        {
            string str = "";

            comboBoxPaymentType.ValueMember = "Id";
            comboBoxPaymentType.DisplayMember = "TitleName";
            comboBoxPaymentType.DataSource = new PhysiotherapyCare.ViewModel.Basic.PaymentType().GetAllList(ref str);
        }

        private void fillControl()
        {
            string str = "";
            ViewModel.VisitHealthCare.VisitHealthCarePayment RN = new ViewModel.VisitHealthCare.VisitHealthCarePayment();
            List<VW_VisitHealthCarePayment> VPC = RN.GetAllListByID(_id, ref str);

            TextBoxDoctor.Tag = VPC[0].Doctor_Id;
            TextBoxDoctor.Text = VPC[0].DoctorName + " " + VPC[0].DoctorFamily;

            comboBoxPaymentType.SelectedValue = VPC[0].PaymentType_Id.Value;

            DatePickerPaymentDate.Value = KagNetComponents2.KagPersianDate.Parse(VPC[0].PaymentDate.Substring(0, 10));
            textBoxAccountingDocumentNumber.Text = VPC[0].AccountingDocumentNumber;
            textBoxAccountingDocumentNumber.Tag = VPC[0].AccountingDocumentDate ?? "";
            IntBoxCostVisitDoctorBes.Value = Math.Abs(VPC[0].CostVisitDoctorBes.Value);
            textBoxDescription.Text = VPC[0].Description;

            FixedCostVisit = Math.Abs(VPC[0].CostVisitDoctorBes.Value);
            MonthForPayment = VPC[0].HealthCareDate;
            textBoxDescription.Tag = VPC[0].InsuLetterDate;
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
                
                VisitHealthCarePayment.Doctor_Id = Convert.ToInt16(TextBoxDoctor.Tag ?? "0");
                VisitHealthCarePayment.PaymentType_Id = Convert.ToInt16(comboBoxPaymentType.SelectedValue);
                VisitHealthCarePayment.PaymentStatus_Id = Convert.ToInt16(6);
                VisitHealthCarePayment.PaymentStatusDate = MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsi(DateTime.Now);

                VisitHealthCarePayment.AccountingDocumentNumber = textBoxAccountingDocumentNumber.Text;
                VisitHealthCarePayment.AccountingDocumentDate = (textBoxAccountingDocumentNumber.Tag ?? "").ToString();

                VisitHealthCarePayment.HealthCareDate = MonthForPayment;
                VisitHealthCarePayment.InsuLetterDate = textBoxDescription.Tag.ToString();

                VisitHealthCarePayment.CostVisitDoctorBes = comboBoxPaymentType.SelectedIndex == 2 ? Convert.ToInt32(IntBoxCostVisitDoctorBes.Value) * -1 : Convert.ToInt32(IntBoxCostVisitDoctorBes.Value);
                VisitHealthCarePayment.CostDoctor = 0;
                
                VisitHealthCarePayment.PaymentDate = DatePickerPaymentDate.Value.ToString().Substring(0, 10);

                VisitHealthCarePayment.Description = textBoxDescription.Text;

                VisitHealthCarePayment.User_Id = MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID;
                VisitHealthCarePayment.ChangeDateTime = MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now);


                ViewModel.Doctors.Doctor RN = new ViewModel.Doctors.Doctor();
                List<Model.Doctors.VW_Doctor> VPC = RN.GetAllListByID(VisitHealthCarePayment.Doctor_Id.Value, ref str);
                VisitHealthCarePayment.DoctorName = VPC[0].DoctorName;
                VisitHealthCarePayment.DoctorFamily = VPC[0].DoctorFamily;
                VisitHealthCarePayment.DoctorNationalCode = VPC[0].NationalCode;
                VisitHealthCarePayment.DoctorAddress = VPC[0].Address;
                VisitHealthCarePayment.DoctorBrithDate = VPC[0].BrithDate;
                VisitHealthCarePayment.DoctorMobile = VPC[0].Mobile;
                VisitHealthCarePayment.DoctorTelBusiness = VPC[0].TelBusiness;
                VisitHealthCarePayment.MedicalCode = VPC[0].MedicalCode;
                VisitHealthCarePayment.ContractDate = VPC[0].ContractEndDate;
                VisitHealthCarePayment.ContractNo = VPC[0].ContractNo;
                VisitHealthCarePayment.LocationPart = VPC[0].LocationPart;
                VisitHealthCarePayment.BankName = VPC[0].BankName;
                VisitHealthCarePayment.CardBankNo1 = VPC[0].CardBankNo1;
                VisitHealthCarePayment.CardBankNo2 = VPC[0].CardBankNo2;

                VisitHealthCarePayment.CostDoctorTax = 0;
                VisitHealthCarePayment.CostDoctorInsurance = 0;
                VisitHealthCarePayment.CostDoctorPrePayment = 0;
                VisitHealthCarePayment.CostReqInsu = 0;
                VisitHealthCarePayment.CostCachInsu = 0;
                VisitHealthCarePayment.AnalyzePage = 0;
                VisitHealthCarePayment.CostCompany = 0;
                VisitHealthCarePayment.CostIncrease = 0;



                Ls.Add(VisitHealthCarePayment);

                if (!_editIns)
                {
                    new ViewModel.VisitHealthCare.VisitHealthCarePayment().InsertEntity(Ls, ref str, ref idSet);
                }
                else
                {
                    new ViewModel.VisitHealthCare.VisitHealthCarePayment().UpdateEntity(Ls, ref str);
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
            if (TextBoxDoctor.Text.Trim() == "")
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("لطفا نام پزشک را پر نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                return false;
            }
            
            if (IntBoxCostVisitDoctorBes.Text.Trim() == "0")
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("لطفا مبلغ را پر نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                return false;
            }
            
            if (IntBoxCostVisitDoctorBes.Value.ToString().ToInt() > FixedCostVisit)
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("لطفا سقف مبلغ سند را رعایت نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                return false;
            }
            return true;
        }


        private void buttonItem_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void buttonDoctor_Click(object sender, EventArgs e)
        {
            try
            {
                string StrSet = "";
                Dictionary<string, string> SD = new Dictionary<string, string>();
                Dictionary<string, string> SD1 = new Dictionary<string, string>();

                foreach (var item in new ViewModel.Doctors.Doctor().GetAllList(ref StrSet))
                    SD.Add(item.Id.ToString(), item.DoctorName + " " + item.DoctorFamily);

                SD1 = MKH.Library.Forms.MSSSelector_frm.SetDataSelect(SD);
                TextBoxDoctor.Tag = SD1.Keys.ToList()[0];
                TextBoxDoctor.Text = SD1.Values.ToList()[0];
            }
            catch { }
        }

        private void VisitHealthCarePaymentPrePaymentAdd_Frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            string str = "";
            if (buttonItemOK.Enabled)
                new ViewModel.Basic.NODuplicateForm().DeleteEntity("TBL_VisitHealthCarePayment", _id.ToString(), ref str);
        }

        private void ButtonStatusPayment_Click(object sender, EventArgs e)
        {
            if (TextBoxDoctor.Text == "") return;
            try
            {
                string Str = "";

                MKH.Library.Forms.MSSSelectorList_frm ctrl = new MKH.Library.Forms.MSSSelectorList_frm();
                ctrl.DataListPrePayment = MKH.Library.Clasess.PublicClass.ToDataTable<Model.VisitHealthCare.SP_VisitHealthCarePaymentForPrePaymentResult>(new ViewModel.VisitHealthCare.VisitHealthCarePayment().GetAllListForPrePayment(TextBoxDoctor.Tag.ToString().ToInt(), ref Str));
                if (ctrl.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    foreach (DataRow row in ctrl.DataListPrePaymentOut.Rows)
                    {
                        textBoxAccountingDocumentNumber.Text = row[0].ToString();
                        textBoxAccountingDocumentNumber.Tag = row[1].ToString();
                        IntBoxCostVisitDoctorBes.Value = Convert.ToInt32(row[3]) - Convert.ToInt32(row[4]);
                        FixedCostVisit = Convert.ToInt32(row[3]) - Convert.ToInt32(row[4]);
                        MonthForPayment = row[2].ToString() + "/01";
                        textBoxDescription.Tag = row[5].ToString() + "/01";
                    }
                }
            }
            catch { }
        }


       
       
    }
}
