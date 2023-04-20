using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using PhysiotherapyCare.ViewModel.VisitPatientCare;
using PhysiotherapyCare.Model.VisitPatientCare;
using PhysiotherapyCare.ViewModel.Basic;



namespace PhysiotherapyCare.View.MainForms.VisitPatientCare
{
    public partial class VisitPatientCareAdd_Frm : MKH.Library.Forms.MSSBaseNew_frm
    {
        private int _id = 0, _patient_Id = 0;
        private bool _editIns = false;


        public VisitPatientCareAdd_Frm()
        {
            InitializeComponent();
        }

        public VisitPatientCareAdd_Frm(int Patient_Id, string EmptyStr)
        {
            InitializeComponent();
            _patient_Id = Patient_Id;
            ButtonPatient.Visible = false;
            string str = "";
            TextBoxPatient.Tag = new ViewModel.Patient.Patient().GetAllListByID(_patient_Id,ref str).Single().Id;
            TextBoxPatient.Text = new ViewModel.Patient.Patient().GetAllListByID(_patient_Id, ref str).Single().PatientName + " " + new ViewModel.Patient.Patient().GetAllListByID(_patient_Id, ref str).Single().PatientFamily;
        }


        public VisitPatientCareAdd_Frm(int Id, short VisitStatus_Id)
        {
            InitializeComponent();

            buttonItemOK.Enabled = VisitStatus_Id == 1 && new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(69);
            if (buttonItemOK.Enabled)
            {
                string str = "";
                if (new ViewModel.Basic.NODuplicateForm().CheckNODuplicateForm("TBL_VisitPatientCare", Id.ToString(), ref str))
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View("امکان ویرایش به علت انجام عملیات توسط کاربر دیگر امکان پذیر نمی باشد", MKH.Library.Clasess.MSSMessage.MessageType.SWarning);
                    Close();
                }
                else
                    new ViewModel.Basic.NODuplicateForm().InsertEntity("TBL_VisitPatientCare", Id.ToString(), ref str);
            }

            _id = Id;
            _editIns = true;
            ButtonPatient.Visible = false;
        }

        string str = "";
        private void VisitPatientCareAdd_Frm_Load(object sender, EventArgs e)
        {
            DatePickerCarrierBrithDate.Value = DatePickerContractDate.Value = DatePickerLetterDate.Value =
                DatePickerBeginDate.Value = DatePickerEndDate.Value = KagNetComponents2.KagPersianDate.Parse(DateTime.Now);

            SetComboBox();
            if (_editIns) fillControl();
            else
                if (_patient_Id != 0) SetLastVisitCare(_patient_Id);
        }

        private void SetLastVisitCare(int PatientId)
        {
            string str = "";
            if (new ViewModel.VisitPatientCare.VisitPatientCare().GetAllList(ref str).Where(ei => ei.Patient_Id == PatientId).Count() > 0)
            {
                ViewModel.VisitPatientCare.VisitPatientCare RN = new ViewModel.VisitPatientCare.VisitPatientCare();
                List<VW_VisitPatientCare> VPC = RN.GetAllListByLastPatientID(PatientId, ref str);

                TextBoxPatient.Tag = VPC[0].Patient_Id;
                TextBoxPatient.Text = VPC[0].PatientName + " " + VPC[0].PatientFamily;

                TextBoxIssueArchive.Text = VPC[0].IssueArchive;

                TextBoxLetterNo.Text = VPC[0].LetterNo;
                DatePickerLetterDate.Value = KagNetComponents2.KagPersianDate.Parse(VPC[0].LetterDate.Substring(0, 10));
                TextBoxContractNo.Text = VPC[0].ContractNo;
                try
                {
                    DatePickerContractDate.Value = KagNetComponents2.KagPersianDate.Parse(VPC[0].ContractDate);
                }
                catch { }

                TextBoxDoctor.Tag = VPC[0].Doctor_Id;
                TextBoxDoctor.Text = VPC[0].DoctorName + " " + VPC[0].DoctorFamily;

                TextBoxCarrierName.Text = VPC[0].CarrierName;
                TextBoxCarrierFamily.Text = VPC[0].CarrierFamily;
                TextBoxCarrierNationalCode.Text = VPC[0].CarrierNationalCode;
                ComboBoxCarrierSex.SelectedIndex = VPC[0].CarrierSex.Value;
                try { DatePickerCarrierBrithDate.Value = KagNetComponents2.KagPersianDate.Parse(VPC[0].CarrierBrithDate); }
                catch { }
                TextBoxCarrierAddress.Text = VPC[0].CarrierAddress;
                TextBoxCarrierTelHome.Text = VPC[0].CarrierTelHome;
                TextBoxCarrierMobile.Text = VPC[0].CarrierMobile;
                try { ComboBoxKinShip.SelectedValue = VPC[0].KinShip_Id.Value; }
                catch { }

                ComboBoxShiftFew.SelectedIndex = ((VPC[0].ShiftFew) - 1).Value;
                DatePickerBeginDate.Value = KagNetComponents2.KagPersianDate.Parse(VPC[0].BeginDate);
                DatePickerEndDate.Value = KagNetComponents2.KagPersianDate.Parse(VPC[0].EndDate);


                TextBoxCardBankNo1.Text = VPC[0].CardBankNo1;
                TextBoxCardBankNo2.Text = VPC[0].CardBankNo2;
                comboBoxBank.SelectedValue = VPC[0].CarrierBank_Id.Value;
                try { CheckBoxPatientFillAccount.Checked = VPC[0].PatientFillAccount.Value; }
                catch { }
                TextBoxDescription.Text = VPC[0].Description;
            
            }
        }

        private void SetComboBox()
        {
            string str = "";
            ComboBoxCarrierSex.SelectedIndex = 0;

            ComboBoxKinShip.ValueMember = "Id";
            ComboBoxKinShip.DisplayMember = "TitleName";
            ComboBoxKinShip.DataSource = new KinShip().GetAllList(ref str);
            
            comboBoxBank.ValueMember = "Id";
            comboBoxBank.DisplayMember = "TitleName";
            comboBoxBank.DataSource = new Bank().GetAllList(ref str);
        }

        private void fillControl()
        {
            string str = "";
            ViewModel.VisitPatientCare.VisitPatientCare RN = new ViewModel.VisitPatientCare.VisitPatientCare();
            List<VW_VisitPatientCare> VPC = RN.GetAllListByID(_id, ref str);

            TextBoxPatient.Tag = VPC[0].Patient_Id;
            TextBoxPatient.Text = VPC[0].PatientName + " " + VPC[0].PatientFamily;

            TextBoxIssueArchive.Text = VPC[0].IssueArchive;

            TextBoxLetterNo.Text = VPC[0].LetterNo;
            TextBoxLetterNo.Tag = VPC[0].LetterNo;//----ForCheck ReUse

            DatePickerLetterDate.Value = KagNetComponents2.KagPersianDate.Parse(VPC[0].LetterDate.Substring(0, 10));
            TextBoxContractNo.Text = VPC[0].ContractNo;
            try
            {
                DatePickerContractDate.Value = KagNetComponents2.KagPersianDate.Parse(VPC[0].ContractDate);
            }
            catch { }

            TextBoxDoctor.Tag = VPC[0].Doctor_Id;
            TextBoxDoctor.Text = VPC[0].DoctorName + "" + VPC[0].DoctorFamily;

            TextBoxCarrierName.Text = VPC[0].CarrierName;
            TextBoxCarrierFamily.Text = VPC[0].CarrierFamily;
            TextBoxCarrierNationalCode.Text = VPC[0].CarrierNationalCode;
            ComboBoxCarrierSex.SelectedIndex = VPC[0].CarrierSex.Value;
            try{DatePickerCarrierBrithDate.Value = KagNetComponents2.KagPersianDate.Parse(VPC[0].CarrierBrithDate);}catch{}
            TextBoxCarrierAddress.Text = VPC[0].CarrierAddress;
            TextBoxCarrierTelHome.Text = VPC[0].CarrierTelHome;
            TextBoxCarrierMobile.Text = VPC[0].CarrierMobile;
            try { ComboBoxKinShip.SelectedValue = VPC[0].KinShip_Id.Value; }
            catch { }

            ComboBoxShiftFew.SelectedIndex = ((VPC[0].ShiftFew)-1).Value;
            DatePickerBeginDate.Value = KagNetComponents2.KagPersianDate.Parse(VPC[0].BeginDate);
            DatePickerEndDate.Value = KagNetComponents2.KagPersianDate.Parse(VPC[0].EndDate);

            DatePickerBeginDate.Tag = KagNetComponents2.KagPersianDate.Parse(VPC[0].BeginDate);//----ForCheck ReUse
            DatePickerEndDate.Tag = KagNetComponents2.KagPersianDate.Parse(VPC[0].EndDate);//----ForCheck ReUse
            
            
            TextBoxCardBankNo1.Text = VPC[0].CardBankNo1;
            TextBoxCardBankNo2.Text = VPC[0].CardBankNo2;
            comboBoxBank.SelectedValue = VPC[0].CarrierBank_Id.Value;
            try { CheckBoxPatientFillAccount.Checked = VPC[0].PatientFillAccount.Value; }
            catch { }
            TextBoxDescription.Text = VPC[0].Description;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckValidation())
                return;
            try
            {
                string str = ""; long? idSet = 0;
                List<TBL_VisitPatientCare> Ls = new List<TBL_VisitPatientCare>(1);
                TBL_VisitPatientCare VisitPatientCare = new TBL_VisitPatientCare();
                VisitPatientCare.Id = _id;
                VisitPatientCare.Patient_Id = Convert.ToInt32(TextBoxPatient.Tag ?? "0");

                VisitPatientCare.IssueArchive = TextBoxIssueArchive.Text;
                VisitPatientCare.LetterNo = TextBoxLetterNo.Text;
                VisitPatientCare.LetterDate = DatePickerLetterDate.Value.ToString().Substring(0, 10);
                VisitPatientCare.ContractNo = TextBoxContractNo.Text;
                VisitPatientCare.ContractDate = DatePickerContractDate.Value.ToString();
                VisitPatientCare.Doctor_Id = Convert.ToInt32(TextBoxDoctor.Tag ?? "0");

                VisitPatientCare.CarrierName = TextBoxCarrierName.Text;
                VisitPatientCare.CarrierFamily = TextBoxCarrierFamily.Text;
                VisitPatientCare.CarrierNationalCode = TextBoxCarrierNationalCode.Text;
                VisitPatientCare.CarrierSex = Convert.ToByte(ComboBoxCarrierSex.SelectedIndex);
                VisitPatientCare.CarrierBrithDate = DatePickerCarrierBrithDate.Value.ToString();
                VisitPatientCare.CarrierAddress = TextBoxCarrierAddress.Text;
                VisitPatientCare.CarrierTelHome = TextBoxCarrierTelHome.Text;
                VisitPatientCare.CarrierMobile = TextBoxCarrierMobile.Text;
                VisitPatientCare.KinShip_Id = Convert.ToByte(ComboBoxKinShip.SelectedValue);

                VisitPatientCare.ShiftFew = Convert.ToInt16(ComboBoxShiftFew.SelectedIndex+1);
                VisitPatientCare.BeginDate = DatePickerBeginDate.Value.ToString().Substring(0,10);
                VisitPatientCare.EndDate = DatePickerEndDate.Value.ToString().Substring(0,10);


                VisitPatientCare.Bank_Id = Convert.ToByte(comboBoxBank.SelectedValue);
                VisitPatientCare.CardBankNo1 = TextBoxCardBankNo1.Text;
                VisitPatientCare.CardBankNo2 = TextBoxCardBankNo2.Text;
                VisitPatientCare.CarrierMobile = TextBoxCarrierMobile.Text;
                VisitPatientCare.PatientFillAccount = CheckBoxPatientFillAccount.Checked;
                VisitPatientCare.Description = TextBoxDescription.Text;
                
                VisitPatientCare.VisitStatus_Id = 1;

                VisitPatientCare.User_Id = MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID;
                VisitPatientCare.ChangeDateTime = MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now);

                Ls.Add(VisitPatientCare);

                if (!_editIns)
                {
                    new ViewModel.VisitPatientCare.VisitPatientCare().InsertEntity(Ls, ref str, ref idSet);
                }
                else
                {
                    new ViewModel.VisitPatientCare.VisitPatientCare().UpdateEntity(Ls, ref str);
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

            if (DatePickerBeginDate.ValueEn > DatePickerEndDate.ValueEn)
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("تاریخ شروع قرارداد از تاریخ پایان آن نبایستی بزرگتر باشد", MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                return false;
            }

            if (TextBoxPatient.Text.Trim() == "")
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("لطفا نام بیمار را پر نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                return false;
            }

            if (!_editIns)
            {
                if (new ViewModel.VisitPatientCare.VisitPatientCare().GetAllListByLastPatientID(TextBoxPatient.Tag.ToString().ToInt(), ref str).Where(ei =>
                    ei.LetterNo == TextBoxLetterNo.Text).Count() > 0)
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View("شماره نامه بنیاد تکراری می باشد", MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                    return false;
                }

                if (
                new ViewModel.VisitPatientCare.VisitPatientCare().GetAllListByLastPatientID(TextBoxPatient.Tag.ToString().ToInt(), ref str).Where(ei =>
                KagNetComponents2.KagPersianDate.Parse(ei.BeginDate).MiladiDate > DatePickerBeginDate.Value.MiladiDate &&
                KagNetComponents2.KagPersianDate.Parse(ei.BeginDate).MiladiDate < DatePickerEndDate.Value.MiladiDate).Count() > 0 ||
                new ViewModel.VisitPatientCare.VisitPatientCare().GetAllListByLastPatientID(TextBoxPatient.Tag.ToString().ToInt(), ref str).Where(ei =>
                KagNetComponents2.KagPersianDate.Parse(ei.EndDate).MiladiDate > DatePickerBeginDate.Value.MiladiDate &&
                KagNetComponents2.KagPersianDate.Parse(ei.EndDate).MiladiDate < DatePickerEndDate.Value.MiladiDate).Count() > 0 ||
                new ViewModel.VisitPatientCare.VisitPatientCare().GetAllListByLastPatientID(TextBoxPatient.Tag.ToString().ToInt(), ref str).Where(ei =>
                KagNetComponents2.KagPersianDate.Parse(ei.BeginDate).MiladiDate < DatePickerBeginDate.Value.MiladiDate &&
                KagNetComponents2.KagPersianDate.Parse(ei.EndDate).MiladiDate > DatePickerEndDate.Value.MiladiDate).Count() > 0)
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View("قرارداد فوق با تاریخ های مشابه جهت بیمار مذکور قبلا ثبت شده است", MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                    return false;
                }
            }
            if (_editIns)
            {
                if (TextBoxLetterNo.Text != TextBoxLetterNo.Tag.ToString())
                    if (new ViewModel.VisitPatientCare.VisitPatientCare().GetAllListByLastPatientID(TextBoxPatient.Tag.ToString().ToInt(), ref str).Where(ei =>
                        ei.LetterNo == TextBoxLetterNo.Text).Count() > 0)
                    {
                        MKH.Library.Clasess.MSSMessage.MSSMessage_View("شماره نامه بنیاد تکراری می باشد", MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                        return false;
                    }
                if (DatePickerBeginDate.Value.ToString() != DatePickerBeginDate.Tag.ToString())
                    if (DatePickerBeginDate.Value.MiladiDate < KagNetComponents2.KagPersianDate.Parse(DatePickerBeginDate.Tag.ToString()).MiladiDate ||
                        DatePickerBeginDate.Value.MiladiDate > KagNetComponents2.KagPersianDate.Parse(DatePickerEndDate.Tag.ToString()).MiladiDate)
                        if (
                        new ViewModel.VisitPatientCare.VisitPatientCare().GetAllListByLastPatientID(TextBoxPatient.Tag.ToString().ToInt(), ref str).Where(ei =>
                        KagNetComponents2.KagPersianDate.Parse(ei.BeginDate).MiladiDate < DatePickerBeginDate.Value.MiladiDate &&
                        KagNetComponents2.KagPersianDate.Parse(ei.EndDate).MiladiDate > DatePickerBeginDate.Value.MiladiDate).Count() > 0)
                        {
                            MKH.Library.Clasess.MSSMessage.MSSMessage_View("قرارداد فوق با تاریخ های مشابه جهت بیمار مذکور قبلا ثبت شده است", MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                            return false;
                        }
                
                if (DatePickerEndDate.Value.ToString() != DatePickerEndDate.Tag.ToString())
                    if (DatePickerEndDate.Value.MiladiDate < KagNetComponents2.KagPersianDate.Parse(DatePickerBeginDate.Tag.ToString()).MiladiDate ||
                        DatePickerEndDate.Value.MiladiDate > KagNetComponents2.KagPersianDate.Parse(DatePickerEndDate.Tag.ToString()).MiladiDate)
                        if (
                        new ViewModel.VisitPatientCare.VisitPatientCare().GetAllListByLastPatientID(TextBoxPatient.Tag.ToString().ToInt(), ref str).Where(ei =>
                        KagNetComponents2.KagPersianDate.Parse(ei.BeginDate).MiladiDate < DatePickerEndDate.Value.MiladiDate &&
                        KagNetComponents2.KagPersianDate.Parse(ei.EndDate).MiladiDate > DatePickerEndDate.Value.MiladiDate).Count() > 0)
                        {
                            MKH.Library.Clasess.MSSMessage.MSSMessage_View("قرارداد فوق با تاریخ های مشابه جهت بیمار مذکور قبلا ثبت شده است", MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                            return false;
                        }
            }

            if (TextBoxCarrierName.Text.Trim() == "")
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("لطفا نام مراقب را پر نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                return false;
            }
            if (TextBoxCarrierFamily.Text.Trim() == "")
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("لطفا نام فامیل مراقب را پر نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                return false;
            }
            if (TextBoxCarrierMobile.Text.Trim() == "")
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("لطفا شماره موبایل مراقب را پر نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                return false;
            }

            if (TextBoxCarrierNationalCode.Text.Trim() == "")
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("لطفا کدملی مراقب را پر نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                return false;
            }
            if (TextBoxCarrierNationalCode.Text.Length != 10)
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("کدملی بایستی 10 رقم باشد", MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                return false;
            }

            if (!CheckBoxPatientFillAccount.Checked && TextBoxCardBankNo1.Text.Trim() == "")
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("لطفا شماره حساب مراقب را پر نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                return false;
            }

            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonPatient_Click(object sender, EventArgs e)
        {
            try
            {
                string StrSet = "";
                Dictionary<string, string> SD = new Dictionary<string, string>();
                Dictionary<string, string> SD1 = new Dictionary<string, string>();

                foreach (var item in new ViewModel.Patient.Patient().GetAllList(ref StrSet))
                    SD.Add(item.Id.ToString(), item.PatientName + " " + item.PatientFamily);

                SD1 = MKH.Library.Forms.MSSSelector_frm.SetDataSelect(SD);
                TextBoxPatient.Tag = SD1.Keys.ToList()[0];
                TextBoxPatient.Text = SD1.Values.ToList()[0];
                if (SD1 != null)
                    SetLastVisitCare(SD1.Keys.ToList()[0].ToInt());
            }
            catch { }
        }

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

        private void DatePickerLetterDate_ValueChanged(object sender, KagNetComponents2.PersianMonthCalendarEventArgs e)
        {
            DatePickerBeginDate.Value = e.CurrentValue.AddDays(1);
        }
        
        private void DatePickerBiginDate_ValueChanged(object sender, KagNetComponents2.PersianMonthCalendarEventArgs e)
        {
            IntBoxDurationDays.Value = (DatePickerEndDate.ValueEn - DatePickerBeginDate.ValueEn).Days;
            IntBoxDurationMonth.Value = (DatePickerEndDate.ValueEn.Month - DatePickerBeginDate.ValueEn.Month) < 0 ? (DatePickerEndDate.ValueEn.Month - DatePickerBeginDate.ValueEn.Month) + 12 : (DatePickerEndDate.ValueEn.Month - DatePickerBeginDate.ValueEn.Month);
        }

        private void ComboBoxShiftFew_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = "";

            LabelCareShift.Text = ComboBoxShiftFew.SelectedIndex == 0 ? new ViewModel.Setting.Setting().GetAllValue("CareShift1", ref str).ToString() :
                                  ComboBoxShiftFew.SelectedIndex == 1 ? new ViewModel.Setting.Setting().GetAllValue("CareShift2", ref str).ToString() :
                                  new ViewModel.Setting.Setting().GetAllValue("CareShift3", ref str).ToString();
        }

        private void VisitPatientCareAdd_Frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            string str = "";
            if (buttonItemOK.Enabled)
                new ViewModel.Basic.NODuplicateForm().DeleteEntity("TBL_VisitPatientCare", _id.ToString(), ref str);
        }

    }
}
