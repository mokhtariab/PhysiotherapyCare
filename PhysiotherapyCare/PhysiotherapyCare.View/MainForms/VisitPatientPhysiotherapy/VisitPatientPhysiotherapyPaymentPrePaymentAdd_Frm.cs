using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PhysiotherapyCare.ViewModel.VisitPatientPhysiotherapy;
using PhysiotherapyCare.Model.VisitPatientPhysiotherapy;
using PhysiotherapyCare.Model.Basic;


namespace PhysiotherapyCare.View.MainForms.VisitPatientPhysiotherapy
{
    public partial class VisitPatientPhysiotherapyPaymentPrePaymentAdd_Frm : MKH.Library.Forms.MSSBaseNew_frm
    {
        private int _id = 0;
        private bool _editIns = false;
        int FixedCostVisit = 0;
        string MonthForPayment = "";
        public VisitPatientPhysiotherapyPaymentPrePaymentAdd_Frm()
        {
            InitializeComponent();
        }

        public VisitPatientPhysiotherapyPaymentPrePaymentAdd_Frm(int Id)
        {
            InitializeComponent();

            buttonItemOK.Enabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(64);
            if (buttonItemOK.Enabled)
            {
                string str = "";
                if (new ViewModel.Basic.NODuplicateForm().CheckNODuplicateForm("TBL_VisitPatientPhysiotherapyPayment", Id.ToString(), ref str))
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View("امکان ویرایش به علت انجام عملیات توسط کاربر دیگر امکان پذیر نمی باشد", MKH.Library.Clasess.MSSMessage.MessageType.SWarning);
                    Close();
                }
                else
                    new ViewModel.Basic.NODuplicateForm().InsertEntity("TBL_VisitPatientPhysiotherapyPayment", Id.ToString(), ref str);
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
            ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapyPayment RN = new ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapyPayment();
            List<VW_VisitPatientPhysiotherapyPayment> VPC = RN.GetAllListByID(_id, ref str);

            TextBoxDoctor.Tag = VPC[0].Doctor_Id;
            TextBoxDoctor.Text = VPC[0].DoctorName + " " + VPC[0].DoctorFamily;

            comboBoxPaymentType.SelectedValue = VPC[0].PaymentType_Id.Value;

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
                List<TBL_VisitPatientPhysiotherapyPayment> Ls = new List<TBL_VisitPatientPhysiotherapyPayment>(1);
                TBL_VisitPatientPhysiotherapyPayment VisitPatientPhysiotherapyPayment = new TBL_VisitPatientPhysiotherapyPayment();
                VisitPatientPhysiotherapyPayment.Id = _id;
                
                VisitPatientPhysiotherapyPayment.Doctor_Id = Convert.ToInt16(TextBoxDoctor.Tag ?? "0");
                VisitPatientPhysiotherapyPayment.PaymentType_Id = Convert.ToInt16(comboBoxPaymentType.SelectedValue);
                VisitPatientPhysiotherapyPayment.PaymentStatus_Id = Convert.ToInt16(6);
                VisitPatientPhysiotherapyPayment.PaymentStatusDate = MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsi(DateTime.Now);

                VisitPatientPhysiotherapyPayment.BeginDate = MonthForPayment;
                VisitPatientPhysiotherapyPayment.InsuLetterDate = textBoxDescription.Tag.ToString();

                VisitPatientPhysiotherapyPayment.AccountingDocumentNumber = textBoxAccountingDocumentNumber.Text;
                VisitPatientPhysiotherapyPayment.AccountingDocumentDate = (textBoxAccountingDocumentNumber.Tag ?? "").ToString();

                VisitPatientPhysiotherapyPayment.CostVisitDoctorBes = comboBoxPaymentType.SelectedIndex == 2 ? Convert.ToInt32(IntBoxCostVisitDoctorBes.Value) * -1 : Convert.ToInt32(IntBoxCostVisitDoctorBes.Value);
                VisitPatientPhysiotherapyPayment.CostDoctor = 0;
                
                VisitPatientPhysiotherapyPayment.PaymentDate = DatePickerPaymentDate.Value.ToString().Substring(0, 10);

                VisitPatientPhysiotherapyPayment.Description = textBoxDescription.Text;

                VisitPatientPhysiotherapyPayment.User_Id = MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID;
                VisitPatientPhysiotherapyPayment.ChangeDateTime = MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now);

                ViewModel.Doctors.Doctor RN = new ViewModel.Doctors.Doctor();
                List<Model.Doctors.VW_Doctor> VPC = RN.GetAllListByID(VisitPatientPhysiotherapyPayment.Doctor_Id.Value, ref str);
                VisitPatientPhysiotherapyPayment.DoctorName = VPC[0].DoctorName;
                VisitPatientPhysiotherapyPayment.DoctorFamily = VPC[0].DoctorFamily;
                VisitPatientPhysiotherapyPayment.DoctorNationalCode = VPC[0].NationalCode;
                VisitPatientPhysiotherapyPayment.DoctorAddress = VPC[0].Address;
                VisitPatientPhysiotherapyPayment.DoctorBrithDate = VPC[0].BrithDate;
                VisitPatientPhysiotherapyPayment.DoctorMobile = VPC[0].Mobile;
                VisitPatientPhysiotherapyPayment.DoctorTelBusiness = VPC[0].TelBusiness;
                VisitPatientPhysiotherapyPayment.MedicalCode = VPC[0].MedicalCode;
                VisitPatientPhysiotherapyPayment.ContractDate = VPC[0].ContractEndDate;
                VisitPatientPhysiotherapyPayment.ContractNo = VPC[0].ContractNo;
                VisitPatientPhysiotherapyPayment.LocationPart = VPC[0].LocationPart;
                VisitPatientPhysiotherapyPayment.BankName = VPC[0].BankName;
                VisitPatientPhysiotherapyPayment.CardBankNo1 = VPC[0].CardBankNo1;
                VisitPatientPhysiotherapyPayment.CardBankNo2 = VPC[0].CardBankNo2;

                VisitPatientPhysiotherapyPayment.CostDoctorTax = 0;
                VisitPatientPhysiotherapyPayment.CostDoctorInsurance = 0;
                VisitPatientPhysiotherapyPayment.CostDoctorPrePayment = 0;
                VisitPatientPhysiotherapyPayment.CostReqInsu = 0;
                VisitPatientPhysiotherapyPayment.CostCachInsu = 0;
                VisitPatientPhysiotherapyPayment.AnalyzePage = 0;
                VisitPatientPhysiotherapyPayment.CostCompany = 0;
                VisitPatientPhysiotherapyPayment.CostIncrease = 0;


                Ls.Add(VisitPatientPhysiotherapyPayment);

                if (!_editIns)
                {
                    new ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapyPayment().InsertEntity(Ls, ref str, ref idSet);
                }
                else
                {
                    new ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapyPayment().UpdateEntity(Ls, ref str);
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

        private void VisitPatientPhysiotherapyPaymentPrePaymentAdd_Frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            string str = "";
            if (buttonItemOK.Enabled)
                new ViewModel.Basic.NODuplicateForm().DeleteEntity("TBL_VisitPatientPhysiotherapyPayment", _id.ToString(), ref str);
        }

        private void ButtonStatusPayment_Click(object sender, EventArgs e)
        {
            if (TextBoxDoctor.Text == "") return;
            try
            {
                string Str = "";

                MKH.Library.Forms.MSSSelectorList_frm ctrl = new MKH.Library.Forms.MSSSelectorList_frm();
                ctrl.DataListPrePayment = MKH.Library.Clasess.PublicClass.ToDataTable<Model.VisitPatientPhysiotherapy.SP_VisitPatientPhysiotherapyPaymentForPrePaymentResult>(new ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapyPayment().GetAllListForPrePayment(TextBoxDoctor.Tag.ToString().ToInt(), ref Str));
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
