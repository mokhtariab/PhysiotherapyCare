using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PhysiotherapyCare.ViewModel.VisitPatient;
using PhysiotherapyCare.Model.VisitPatient;
using PhysiotherapyCare.Model.Basic;


namespace PhysiotherapyCare.View.MainForms.VisitPatient
{
    public partial class VisitPatientPaymentPrePaymentAdd_Frm : MKH.Library.Forms.MSSBaseNew_frm
    {
        private int _id = 0;
        private bool _editIns = false;
        int FixedCostVisit = 0;
        string MonthForPayment = "";
        public VisitPatientPaymentPrePaymentAdd_Frm()
        {
            InitializeComponent();
        }

        public VisitPatientPaymentPrePaymentAdd_Frm(int Id)
        {
            InitializeComponent();

            buttonItemOK.Enabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(213);
            if (buttonItemOK.Enabled)
            {
                string str = "";
                if (new ViewModel.Basic.NODuplicateForm().CheckNODuplicateForm("TBL_VisitPatientPayment", Id.ToString(), ref str))
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View("امکان ویرایش به علت انجام عملیات توسط کاربر دیگر امکان پذیر نمی باشد", MKH.Library.Clasess.MSSMessage.MessageType.SWarning);
                    Close();
                }
                else
                    new ViewModel.Basic.NODuplicateForm().InsertEntity("TBL_VisitPatientPayment", Id.ToString(), ref str);
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
            ViewModel.VisitPatient.VisitPatientPayment RN = new ViewModel.VisitPatient.VisitPatientPayment();
            List<VW_VisitPatientPayment> VPC = RN.GetAllListByID(_id, ref str);

            TextBoxDoctor.Tag = VPC[0].Doctor_Id;
            TextBoxDoctor.Text = VPC[0].DoctorName + " " + VPC[0].DoctorFamily;

            comboBoxPaymentType.SelectedValue = VPC[0].PaymentType_Id.Value;

            DatePickerPaymentDate.Value = KagNetComponents2.KagPersianDate.Parse(VPC[0].PaymentDate.Substring(0, 10));
            textBoxAccountingDocumentNumber.Text = VPC[0].AccountingDocumentNumber;
            textBoxAccountingDocumentNumber.Tag = VPC[0].AccountingDocumentDate ?? "";
            IntBoxCostVisitDoctorBes.Value = Math.Abs(VPC[0].CostVisitDoctorBes.Value);
            textBoxDescription.Text = VPC[0].Description;

            FixedCostVisit = Math.Abs(VPC[0].CostVisitDoctorBes.Value);
            MonthForPayment = VPC[0].VisitDate;
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
                List<TBL_VisitPatientPayment> Ls = new List<TBL_VisitPatientPayment>(1);
                TBL_VisitPatientPayment VisitPatientPayment = new TBL_VisitPatientPayment();
                VisitPatientPayment.Id = _id;

                VisitPatientPayment.Doctor_Id = Convert.ToInt16(TextBoxDoctor.Tag ?? "0");
                VisitPatientPayment.PaymentType_Id = Convert.ToInt16(comboBoxPaymentType.SelectedValue);
                VisitPatientPayment.PaymentStatus_Id = Convert.ToInt16(6);
                VisitPatientPayment.PaymentStatusDate = MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsi(DateTime.Now);

                VisitPatientPayment.VisitDate = MonthForPayment;
                VisitPatientPayment.InsuLetterDate = textBoxDescription.Tag.ToString();

                VisitPatientPayment.AccountingDocumentNumber = textBoxAccountingDocumentNumber.Text;
                VisitPatientPayment.AccountingDocumentDate = (textBoxAccountingDocumentNumber.Tag ?? "").ToString();

                VisitPatientPayment.CostVisitDoctorBes = comboBoxPaymentType.SelectedIndex == 2 ? Convert.ToInt32(IntBoxCostVisitDoctorBes.Value) * -1 : Convert.ToInt32(IntBoxCostVisitDoctorBes.Value);
                VisitPatientPayment.CostDoctor = 0;

                VisitPatientPayment.PaymentDate = DatePickerPaymentDate.Value.ToString().Substring(0, 10);

                VisitPatientPayment.Description = textBoxDescription.Text;

                VisitPatientPayment.User_Id = MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID;
                VisitPatientPayment.ChangeDateTime = MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now);

                ViewModel.Doctors.Doctor RN = new ViewModel.Doctors.Doctor();
                List<Model.Doctors.VW_Doctor> VPC = RN.GetAllListByID(VisitPatientPayment.Doctor_Id.Value, ref str);
                VisitPatientPayment.DoctorName = VPC[0].DoctorName;
                VisitPatientPayment.DoctorFamily = VPC[0].DoctorFamily;
                VisitPatientPayment.DoctorNationalCode = VPC[0].NationalCode;
                VisitPatientPayment.DoctorAddress = VPC[0].Address;
                VisitPatientPayment.DoctorBrithDate = VPC[0].BrithDate;
                VisitPatientPayment.DoctorMobile = VPC[0].Mobile;
                VisitPatientPayment.DoctorTelBusiness = VPC[0].TelBusiness;
                VisitPatientPayment.MedicalCode = VPC[0].MedicalCode;
                VisitPatientPayment.ContractDate = VPC[0].ContractEndDate;
                VisitPatientPayment.ContractNo = VPC[0].ContractNo;
                VisitPatientPayment.LocationPart = VPC[0].LocationPart;
                VisitPatientPayment.BankName = VPC[0].BankName;
                VisitPatientPayment.CardBankNo1 = VPC[0].CardBankNo1;
                VisitPatientPayment.CardBankNo2 = VPC[0].CardBankNo2;

              
                VisitPatientPayment.CostDoctorTax = 0;
                VisitPatientPayment.CostDoctorInsurance = 0;
                VisitPatientPayment.CostDoctorPrePayment = 0;
                VisitPatientPayment.CostReqInsu = 0;
                VisitPatientPayment.CostCachInsu = 0;
                VisitPatientPayment.AnalyzePage = 0;
                VisitPatientPayment.CostCompany = 0;
                VisitPatientPayment.CostIncrease = 0;

                
                Ls.Add(VisitPatientPayment);

                if (!_editIns)
                {
                    new ViewModel.VisitPatient.VisitPatientPayment().InsertEntity(Ls, ref str, ref idSet);
                }
                else
                {
                    new ViewModel.VisitPatient.VisitPatientPayment().UpdateEntity(Ls, ref str);
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

        private void VisitPatientPaymentPrePaymentAdd_Frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            string str = "";
            if (buttonItemOK.Enabled)
                new ViewModel.Basic.NODuplicateForm().DeleteEntity("TBL_VisitPatientPayment", _id.ToString(), ref str);
        }

        private void ButtonStatusPayment_Click(object sender, EventArgs e)
        {
            if (TextBoxDoctor.Text == "") return;
            try
            {
                string Str = "";

                MKH.Library.Forms.MSSSelectorList_frm ctrl = new MKH.Library.Forms.MSSSelectorList_frm();
                ctrl.DataListPrePayment = MKH.Library.Clasess.PublicClass.ToDataTable<Model.VisitPatient.SP_VisitPatientPaymentForPrePaymentResult>(new ViewModel.VisitPatient.VisitPatientPayment().GetAllListForPrePayment(TextBoxDoctor.Tag.ToString().ToInt(), ref Str));
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
