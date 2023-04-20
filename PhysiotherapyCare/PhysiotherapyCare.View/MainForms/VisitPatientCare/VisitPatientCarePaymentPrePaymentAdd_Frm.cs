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
    public partial class VisitPatientCarePaymentPrePaymentAdd_Frm : MKH.Library.Forms.MSSBaseNew_frm
    {
        private int _id = 0;
        private bool _editIns = false;
        int FixedCostVisit = 0;
        string MonthForPayment = "";

        public VisitPatientCarePaymentPrePaymentAdd_Frm()
        {
            InitializeComponent();
        }

        public VisitPatientCarePaymentPrePaymentAdd_Frm(int Id)
        {
            InitializeComponent();

            buttonItemOK.Enabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(80);
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

            comboBoxBank.ValueMember = "Id";
            comboBoxBank.DisplayMember = "TitleName";
            comboBoxBank.DataSource = new PhysiotherapyCare.ViewModel.Basic.Bank().GetAllList(ref str);
        }

        private void fillControl()
        {
            string str = "";
            ViewModel.VisitPatientCare.VisitPatientCarePayment RN = new ViewModel.VisitPatientCare.VisitPatientCarePayment();
            List<VW_VisitPatientCarePayment> VPC = RN.GetAllListByID(_id, ref str);
            
            FixedCostVisit = Math.Abs(VPC[0].CostVisitDoctorBes.Value);
            MonthForPayment = VPC[0].BeginDate;

            //textBoxCasherName.Tag = VPC[0].CasherName;
            textBoxCasherName.Text = VPC[0].CasherName;
            textBoxCasherName.Tag = VPC[0].CasherKinship_Id;

            TextBoxCasherNationalCode.Text = VPC[0].CasherNationalCode;

            comboBoxPaymentType.SelectedValue = VPC[0].PaymentType_Id.Value;

            TextBoxCardBankNo1.Text = VPC[0].CardBankNo1;
            try { comboBoxBank.SelectedValue = VPC[0].Bank_Id.Value; }
            catch { }

            DatePickerPaymentDate.Value = KagNetComponents2.KagPersianDate.Parse(VPC[0].PaymentDate.Substring(0, 10));
            textBoxAccountingDocumentNumber.Text = VPC[0].AccountingDocumentNumber;
            textBoxAccountingDocumentNumber.Tag = VPC[0].AccountingDocumentDate ?? "";
            IntBoxCostVisitDoctorBes.Value = Math.Abs(VPC[0].CostVisitDoctorBes.Value);
            textBoxDescription.Text = VPC[0].Description;

            FixedCostVisit = Math.Abs(VPC[0].CostVisitDoctorBes.Value);
            MonthForPayment = VPC[0].BeginDate;
        
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
                List<TBL_VisitPatientCarePayment> Ls = new List<TBL_VisitPatientCarePayment>(1);
                TBL_VisitPatientCarePayment VisitPatientCarePayment = new TBL_VisitPatientCarePayment();
                VisitPatientCarePayment.Id = _id;
                VisitPatientCarePayment.CasherName = textBoxCasherName.Text;
                VisitPatientCarePayment.CasherNationalCode = TextBoxCasherNationalCode.Text;
                VisitPatientCarePayment.CasherKinship_Id = Convert.ToInt16((textBoxCasherName.Tag ?? 0).ToString());
                VisitPatientCarePayment.PaymentType_Id = Convert.ToInt16(comboBoxPaymentType.SelectedValue);
                VisitPatientCarePayment.PaymentStatus_Id = Convert.ToInt16(6);
                VisitPatientCarePayment.PaymentStatusDate = MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsi(DateTime.Now);

                VisitPatientCarePayment.AccountingDocumentNumber = textBoxAccountingDocumentNumber.Text;
                VisitPatientCarePayment.AccountingDocumentDate = (textBoxAccountingDocumentNumber.Tag ?? "").ToString();
                VisitPatientCarePayment.CardBankNo1 = TextBoxCardBankNo1.Text;
                VisitPatientCarePayment.Bank_Id = Convert.ToInt16(comboBoxBank.SelectedValue);
                VisitPatientCarePayment.BeginDate = MonthForPayment;
                VisitPatientCarePayment.InsuLetterDate = textBoxDescription.Tag.ToString();

                
                VisitPatientCarePayment.CostVisitDoctorBes = comboBoxPaymentType.SelectedIndex == 2 ? Convert.ToInt32(IntBoxCostVisitDoctorBes.Value) * -1 : Convert.ToInt32(IntBoxCostVisitDoctorBes.Value);
                VisitPatientCarePayment.CostDoctor = 0;
                
                VisitPatientCarePayment.PaymentDate = DatePickerPaymentDate.Value.ToString().Substring(0, 10);

                VisitPatientCarePayment.Description = textBoxDescription.Text;

                VisitPatientCarePayment.User_Id = MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID;
                VisitPatientCarePayment.ChangeDateTime = MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now);


                //ViewModel.Doctors.Doctor RN = new ViewModel.Doctors.Doctor();
                //List<Model.Doctors.VW_Doctor> VPC = RN.GetAllListByID(VisitPatientCarePayment.Doctor_Id.Value, ref str);
                //VisitPatientCarePayment.DoctorName = VPC[0].DoctorName;
                //VisitPatientCarePayment.DoctorFamily = VPC[0].DoctorFamily;
                //VisitPatientCarePayment.DoctorNationalCode = VPC[0].NationalCode;
                //VisitPatientCarePayment.DoctorAddress = VPC[0].Address;
                //VisitPatientCarePayment.DoctorBrithDate = VPC[0].BrithDate;
                //VisitPatientCarePayment.DoctorMobile = VPC[0].Mobile;
                //VisitPatientCarePayment.DoctorTelBusiness = VPC[0].TelBusiness;
                //VisitPatientCarePayment.MedicalCode = VPC[0].MedicalCode;
                //VisitPatientCarePayment.ContractDate = VPC[0].ContractEndDate;
                //VisitPatientCarePayment.ContractNo = VPC[0].ContractNo;
                //VisitPatientCarePayment.LocationPart = VPC[0].LocationPart;
                //VisitPatientCarePayment.BankName = VPC[0].BankName;
                //VisitPatientCarePayment.CardBankNo1 = VPC[0].CardBankNo1;
                //VisitPatientCarePayment.CardBankNo2 = VPC[0].CardBankNo2;

                VisitPatientCarePayment.ShiftFew = 0;
                VisitPatientCarePayment.DurationDays = 0;

                VisitPatientCarePayment.CostDoctorTax = 0;
                VisitPatientCarePayment.CostDoctorInsurance = 0;
                VisitPatientCarePayment.CostDoctorPrePayment = 0;
                VisitPatientCarePayment.CostReqInsu = 0;
                VisitPatientCarePayment.CostCachInsu = 0;
                VisitPatientCarePayment.AnalyzePage = 0;
                VisitPatientCarePayment.CostCompany = 0;
                VisitPatientCarePayment.CostIncrease = 0;

                Ls.Add(VisitPatientCarePayment);

                if (!_editIns)
                {
                    new ViewModel.VisitPatientCare.VisitPatientCarePayment().InsertEntity(Ls, ref str, ref idSet);
                }
                else
                {
                    new ViewModel.VisitPatientCare.VisitPatientCarePayment().UpdateEntity(Ls, ref str);
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
            if (textBoxCasherName.Text.Trim() == "")
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("لطفا نام و فامیل پرداخت شونده را پر نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                return false;
            }

            if (TextBoxCasherNationalCode.Text.Trim() == "")
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("لطفا کد ملی پرداخت شونده را پر نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                return false;
            }

            if (TextBoxCasherNationalCode.Text.Length != 10)
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("کدملی بایستی 10 رقم باشد", MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation);
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

        private void VisitPatientCarePaymentPrePaymentAdd_Frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            string str = "";
            if (buttonItemOK.Enabled)
                new ViewModel.Basic.NODuplicateForm().DeleteEntity("TBL_VisitPatientCarePayment", _id.ToString(), ref str);
        }

        private void ButtonCasherName_Click(object sender, EventArgs e)
        {
            try
            {
                string StrSet = "";
                Dictionary<string, string> SD = new Dictionary<string, string>();
                Dictionary<string, string> SD1 = new Dictionary<string, string>();

                var A = new ViewModel.VisitPatientCare.VisitPatientCarePayment().GetAllList(ref StrSet).Select(h => new { h.CasherNationalCode, h.CasherName }).Distinct();

                foreach (var item in A)
                    try { SD.Add(item.CasherNationalCode, item.CasherName); }
                    catch { }
                    //SD.Add(item.CasherNationalCode, new ViewModel.VisitPatientCare.VisitPatientCarePayment().GetAllList(ref StrSet).Where(j=>j.CasherNationalCode == item.CasherNationalCode).Last().CasherName);

                SD1 = MKH.Library.Forms.MSSSelector_frm.SetDataSelect(SD);
                TextBoxCasherNationalCode.Text = SD1.Keys.ToList()[0];
                textBoxCasherName.Text = SD1.Values.ToList()[0];
                textBoxCasherName.Tag =
                    new ViewModel.VisitPatientCare.VisitPatientCarePayment().GetAllList(ref StrSet).Where(j => j.CasherNationalCode == SD1.Keys.ToList()[0]).Last().CasherKinship_Id;
                comboBoxBank.SelectedValue =
                    new ViewModel.VisitPatientCare.VisitPatientCarePayment().GetAllList(ref StrSet).Where(j => j.CasherNationalCode == SD1.Keys.ToList()[0]).Last().Bank_Id;
                TextBoxCardBankNo1.Text =
                    new ViewModel.VisitPatientCare.VisitPatientCarePayment().GetAllList(ref StrSet).Where(j => j.CasherNationalCode == SD1.Keys.ToList()[0]).Last().CardBankNo1;
            }
            catch { }
        }


        private void ButtonStatusPayment_Click(object sender, EventArgs e)
        {
            if (TextBoxCasherNationalCode.Text == "") return;
            try
            {
                string Str = "";

                MKH.Library.Forms.MSSSelectorList_frm ctrl = new MKH.Library.Forms.MSSSelectorList_frm();
                ctrl.DataListPrePayment = MKH.Library.Clasess.PublicClass.ToDataTable<Model.VisitPatientCare.SP_VisitPatientCarePaymentForPrePaymentResult>(new ViewModel.VisitPatientCare.VisitPatientCarePayment().GetAllListForPrePayment(TextBoxCasherNationalCode.Text, ref Str));
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
