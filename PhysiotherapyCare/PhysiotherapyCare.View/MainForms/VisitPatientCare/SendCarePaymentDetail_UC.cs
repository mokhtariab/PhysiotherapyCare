using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MKH.Library.Clasess.FilterClass;
using PhysiotherapyCare.Model.VisitPatientCare;

namespace PhysiotherapyCare.View.MainForms.VisitPatientCare
{
    public partial class SendCarePaymentDetail_UC: UserControl
    {
        public bool SaveResult = true;
        public string MessageResultSendCarePaymentDetailDetail = "";

        int _patient_Id = 0; string str = "";
        long _VisitPatientCare_Id = 0, _id = 0;

        bool _editIns = false;
        public SendCarePaymentDetail_UC(long Id)
        {
            InitializeComponent();

            _editIns = true;
            this.BackColor = Color.LightGray;
            LabelStatus.Text = " ارسال شده جهت بیمه ";
            //buttonSendCarePaymentDetail.Enabled = false;
            //buttonCarePaymentDelete.Enabled = false;

            SetComboBox();

            _id = Id;

            ViewModel.VisitPatientCare.VisitPatientCarePayment RN = new ViewModel.VisitPatientCare.VisitPatientCarePayment();
            List<VW_VisitPatientCarePayment> VPC = RN.GetAllListByID(Id, ref str);

            _patient_Id = VPC[0].Patient_Id.Value;
            _VisitPatientCare_Id = VPC[0].VisitPatientCare_Id.Value;
            DatePickerPaymentDate.Value = KagNetComponents2.KagPersianDate.Parse(VPC[0].PaymentDate);

            DatePickerBeginDate.Value = KagNetComponents2.KagPersianDate.Parse(VPC[0].BeginDate);
            DatePickerEndDate.Value = KagNetComponents2.KagPersianDate.Parse(VPC[0].EndDate);
            IntBoxDurationDays.Value = (DatePickerEndDate.ValueEn - DatePickerBeginDate.ValueEn).Days + 1;

            IntBoxShiftFew.Value = VPC[0].ShiftFew;

            TextBoxCasherName.Text = VPC[0].CasherName;
            ComboBoxKinShip.SelectedValue = VPC[0].CasherKinship_Id.Value;
            TextBoxCasherNationalCode.Text = VPC[0].CasherNationalCode;

            TextBoxCardBankNo1.Text = VPC[0].CardBankNo1;
            TextBoxCardBankNo2.Text = VPC[0].CardBankNo2;
            comboBoxBank.SelectedValue = VPC[0].Bank_Id.Value;

            IntBoxCostReqInsu.Text = VPC[0].CostReqInsu.ToString();

            TextBoxInsuLetterNo.Text = VPC[0].InsuLetterNo;
            DatePickerInsuLetterDate.Value = KagNetComponents2.KagPersianDate.Parse(VPC[0].InsuLetterDate);
        }

        public SendCarePaymentDetail_UC(int VisitPatientCare_Id, string BeginDateStr, string EndDateStr)
        {
            InitializeComponent();

            this.BackColor = Color.LightGreen;
            LabelStatus.Text = " آماده ارسال به بیمه ";

            SetComboBox();

            DatePickerPaymentDate.Value = KagNetComponents2.KagPersianDate.Parse(DateTime.Now);


            ViewModel.VisitPatientCare.VisitPatientCare RN = new ViewModel.VisitPatientCare.VisitPatientCare();
            List<VW_VisitPatientCare> VPC = RN.GetAllListByID(VisitPatientCare_Id, ref str);

            _patient_Id = VPC[0].Patient_Id.Value;
            _VisitPatientCare_Id = VisitPatientCare_Id;


            DatePickerBeginDate.Value = KagNetComponents2.KagPersianDate.Parse(BeginDateStr);

            DatePickerEndDate.Value = KagNetComponents2.KagPersianDate.Parse(EndDateStr);

            IntBoxDurationDays.Value = (DatePickerEndDate.ValueEn - DatePickerBeginDate.ValueEn).Days + 1;

            IntBoxShiftFew.Value = VPC[0].ShiftFew;

            DatePickerPaymentDate.Value = KagNetComponents2.KagPersianDate.Now;
            DatePickerInsuLetterDate.Value = KagNetComponents2.KagPersianDate.Now;

            if (VPC[0].PatientFillAccount.Value == false)
            {
                TextBoxCasherName.Text = VPC[0].CarrierName + " " + VPC[0].CarrierFamily;
                ComboBoxKinShip.SelectedValue = VPC[0].KinShip_Id.Value;
                TextBoxCasherNationalCode.Text = VPC[0].CarrierNationalCode;

                TextBoxCardBankNo1.Text = VPC[0].CardBankNo1;
                TextBoxCardBankNo2.Text = VPC[0].CardBankNo2;
                comboBoxBank.SelectedValue = VPC[0].CarrierBank_Id.Value;
            }
            else
            {
                TextBoxCasherName.Text = VPC[0].PatientName + " " + VPC[0].PatientFamily;
                ComboBoxKinShip.SelectedIndex = -1;
                TextBoxCasherNationalCode.Text = VPC[0].NationalCode;

                TextBoxCardBankNo1.Text = VPC[0].AccountNo1 ?? "";
                TextBoxCardBankNo2.Text = VPC[0].AccountNo2 ?? "";
                comboBoxBank.SelectedValue = VPC[0].Bank_Id ?? 0;

            }

            int CareShiftPrice = VPC[0].ShiftFew == 1 ? new ViewModel.Setting.Setting().GetAllValue("CareShift1", ref str).ToString().ToInt() :
                                 VPC[0].ShiftFew == 2 ? new ViewModel.Setting.Setting().GetAllValue("CareShift2", ref str).ToString().ToInt() :
                                 VPC[0].ShiftFew == 3 ? new ViewModel.Setting.Setting().GetAllValue("CareShift3", ref str).ToString().ToInt() : 0;


            int CareDaysDefault = new ViewModel.Setting.Setting().GetAllValue("CareDaysDefault", ref str).ToString().ToInt();
            IntBoxCostReqInsu.Text = IntBoxDurationDays.Value.ToString().ToInt() == 30 ? CareShiftPrice.ToString() : ((CareShiftPrice / CareDaysDefault) * IntBoxDurationDays.Value.ToString().ToInt()).ToString();

            this.Tag = "";

        }


        private void SetComboBox()
        {
            string str = "";
            comboBoxBank.ValueMember = "Id";
            comboBoxBank.DisplayMember = "TitleName";
            comboBoxBank.DataSource = new PhysiotherapyCare.ViewModel.Basic.Bank().GetAllList(ref str);


            ComboBoxKinShip.ValueMember = "Id";
            ComboBoxKinShip.DisplayMember = "TitleName";
            ComboBoxKinShip.DataSource = new PhysiotherapyCare.ViewModel.Basic.KinShip().GetAllList(ref str);
        }

        public bool CheckvalidationUC()
        {
            if (TextBoxCasherName.Text == "")
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("ردیف ( " + LabelRow.Text + ") نام پرداخت شونده را وارد نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SError);
                return false;
            }
            if (TextBoxCasherNationalCode.Text == "")
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("ردیف ( " + LabelRow.Text + ") کد ملی را وارد نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SError);
                return false;
            }
            if (TextBoxCasherNationalCode.Text.Length != 10)
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("ردیف ( " + LabelRow.Text + ") کدملی بایستی 10 رقم باشد", MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                return false;
            }


            if (comboBoxBank.SelectedIndex == -1)
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("ردیف ( " + LabelRow.Text + ") نام بانک را وارد نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SError);
                return false;
            }

            if (TextBoxCardBankNo1.Text == "")
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("ردیف ( " + LabelRow.Text + ") شماره حساب را وارد نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SError);
                return false;
            }
            if (IntBoxCostReqInsu.Text == "0")
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("ردیف ( " + LabelRow.Text + ") مبلغ درخواستی از بیمه را وارد نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SError);
                return false;
            }

            if (DatePickerBeginDate.Value.ShamsiMonth != DatePickerEndDate.Value.ShamsiMonth)
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("ردیف ( " + LabelRow.Text + ") ماه شروع و پایان یکسان نمی باشد", MKH.Library.Clasess.MSSMessage.MessageType.SError);
                return false;
            }

            return true;
        }

       
        public void setRowNo(int RowNo)
        {
            LabelRow.Text = RowNo.ToString();
        }

        public int GetRowNo()
        {
            return LabelRow.Text.ToInt();
        }

        private void DatePickerEndDate_ValueChanged(object sender, KagNetComponents2.PersianMonthCalendarEventArgs e)
        {
            int CareShiftPrice = IntBoxShiftFew.Value.ToString().ToInt() == 1 ? new ViewModel.Setting.Setting().GetAllValue("CareShift1", ref str).ToString().ToInt() :
                                 IntBoxShiftFew.Value.ToString().ToInt() == 2 ? new ViewModel.Setting.Setting().GetAllValue("CareShift2", ref str).ToString().ToInt() :
                                 IntBoxShiftFew.Value.ToString().ToInt() == 3 ? new ViewModel.Setting.Setting().GetAllValue("CareShift3", ref str).ToString().ToInt() : 0;

            int CareDaysDefault = new ViewModel.Setting.Setting().GetAllValue("CareDaysDefault", ref str).ToString().ToInt();

            IntBoxDurationDays.Value = DatePickerEndDate.Value.ToString().Substring(5) == "12/29" ? (DatePickerEndDate.ValueEn - DatePickerBeginDate.ValueEn).Days + 1 : (DatePickerEndDate.ValueEn - DatePickerBeginDate.ValueEn).Days + 1 == 31 ? 30 : (DatePickerEndDate.ValueEn - DatePickerBeginDate.ValueEn).Days + 1;
            IntBoxCostReqInsu.Text = IntBoxDurationDays.Value.ToString().ToInt() == 30 ? CareShiftPrice.ToString() : ((CareShiftPrice / CareDaysDefault) * IntBoxDurationDays.Value.ToString().ToInt()).ToString();
        }

        private void buttonSendCarePaymentDetail_Click(object sender, EventArgs e)
        {
            if (!CheckvalidationUC())
                return;
            double CostCompanyCarePercent = System.Convert.ToDouble(new ViewModel.Setting.Setting().GetAllValue("CostCompanyCarePercent", ref str));
            double CostInsurancePercent = System.Convert.ToDouble(new ViewModel.Setting.Setting().GetAllValue("CostInsurancePercent", ref str));

            long? idSet = 0;
            try
            {
                List<TBL_VisitPatientCarePayment> Ls = new List<TBL_VisitPatientCarePayment>(1);
                TBL_VisitPatientCarePayment VisitPatientCarePayment = new TBL_VisitPatientCarePayment();
                VisitPatientCarePayment.Id = _id;
                VisitPatientCarePayment.VisitPatientCare_Id = _VisitPatientCare_Id;
                VisitPatientCarePayment.Patient_Id = _patient_Id;

                VisitPatientCarePayment.PaymentDate = DatePickerPaymentDate.Value.ToString();
                VisitPatientCarePayment.BeginDate = DatePickerBeginDate.Value.ToString();
                VisitPatientCarePayment.EndDate = DatePickerEndDate.Value.ToString();
                VisitPatientCarePayment.DurationDays = Convert.ToInt16(IntBoxDurationDays.Value);

                VisitPatientCarePayment.ShiftFew = Convert.ToInt16(IntBoxShiftFew.Value);

                VisitPatientCarePayment.CasherName = TextBoxCasherName.Text;
                VisitPatientCarePayment.CasherKinship_Id = Convert.ToInt16(ComboBoxKinShip.SelectedValue);
                VisitPatientCarePayment.CasherNationalCode = TextBoxCasherNationalCode.Text;
                VisitPatientCarePayment.CardBankNo1 = TextBoxCardBankNo1.Text;
                VisitPatientCarePayment.CardBankNo2 = TextBoxCardBankNo2.Text;
                VisitPatientCarePayment.Bank_Id = Convert.ToByte(comboBoxBank.SelectedValue);

                VisitPatientCarePayment.InsuLetterNo = TextBoxInsuLetterNo.Text;
                VisitPatientCarePayment.InsuLetterDate = DatePickerInsuLetterDate.Value.ToString();
                
                VisitPatientCarePayment.CostReqInsu = Convert.ToInt32(IntBoxCostReqInsu.Value);
                VisitPatientCarePayment.CostCachInsu = Convert.ToInt32(IntBoxCostReqInsu.Value);

                //////////-------------
                double DoctorTaxPercent = 0;
                VisitPatientCarePayment.CostCompany = Other.Class.Function_Cls.CalculateCostCompany(VisitPatientCarePayment.CostCachInsu.Value, CostCompanyCarePercent);
                VisitPatientCarePayment.CostDoctorTax = Other.Class.Function_Cls.CalculateTax(VisitPatientCarePayment.CostCachInsu.Value, VisitPatientCarePayment.CostCompany.Value, DoctorTaxPercent);
                //DoctorTaxPercent != 0 ? VisitPatientCarePayment.CostCachInsu * DoctorTaxPercent / 100 : 0;
                VisitPatientCarePayment.CostDoctorInsurance = Other.Class.Function_Cls.CalculateInsurance(VisitPatientCarePayment.CostCachInsu.Value, VisitPatientCarePayment.CostCompany.Value, CostInsurancePercent);
                VisitPatientCarePayment.CostDoctorPrePayment = 0;
                VisitPatientCarePayment.CostIncrease = 0;

                VisitPatientCarePayment.CostDoctor = Other.Class.Function_Cls.CalculateCostDoctor(VisitPatientCarePayment.CostCachInsu.Value, VisitPatientCarePayment.CostCompany.Value, VisitPatientCarePayment.CostIncrease.Value, VisitPatientCarePayment.CostDoctorTax.Value, VisitPatientCarePayment.CostDoctorInsurance.Value, VisitPatientCarePayment.CostDoctorPrePayment.Value);
                //VisitPatientCarePayment.CostCachInsu - VisitPatientCarePayment.CostCompany - VisitPatientCarePayment.CostDoctorTax;
                ///////////////---------------


                VisitPatientCarePayment.CostVisitDoctorBes = 0;
                VisitPatientCarePayment.CostVisitDoctorRemind = 0;

                VisitPatientCarePayment.User_Id = MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID;
                VisitPatientCarePayment.ChangeDateTime = MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now);
                if (_editIns == false)
                {
                    VisitPatientCarePayment.PaymentType_Id = 1;
                    VisitPatientCarePayment.PaymentStatus_Id = 8;
                }

                ViewModel.VisitPatientCare.VisitPatientCare RN = new ViewModel.VisitPatientCare.VisitPatientCare();
                List<VW_VisitPatientCare> VPC = RN.GetAllListByID(_VisitPatientCare_Id, ref str);

                VisitPatientCarePayment.DosiersNo = VPC[0].DosiersNo ?? "";
                VisitPatientCarePayment.PatientName = VPC[0].PatientName ?? "";
                VisitPatientCarePayment.PatientFamily = VPC[0].PatientFamily ?? "";
                VisitPatientCarePayment.ParentName = VPC[0].ParentName ?? "";
                VisitPatientCarePayment.SexStr = VPC[0].SexStr ?? "";
                VisitPatientCarePayment.IDNO = VPC[0].IDNO ?? "";
                VisitPatientCarePayment.NationalCode = VPC[0].NationalCode ?? "";
                VisitPatientCarePayment.PatientTypeStr = VPC[0].PatientTypeStr ?? "";
                VisitPatientCarePayment.InjuryTypeStr = VPC[0].InjuryTypeStr ?? "";
                VisitPatientCarePayment.BrithDate = VPC[0].BrithDate ?? "";
                VisitPatientCarePayment.BrithCityName = VPC[0].BrithCityName ?? "";
                VisitPatientCarePayment.PercentState = VPC[0].PercentState ?? 0;
                VisitPatientCarePayment.SingleOrNo = VPC[0].SingleOrNo ?? "";
                VisitPatientCarePayment.BonyadAddEvenStr = VPC[0].BonyadAddEvenStr ?? "";

                VisitPatientCarePayment.BonyadDosier = VPC[0].BonyadDosier ?? "";
                VisitPatientCarePayment.StatePart = VPC[0].StatePart ?? "";
                VisitPatientCarePayment.CityState = VPC[0].CityState ?? "";

                VisitPatientCarePayment.CityPart = VPC[0].CityPart ?? "";
                VisitPatientCarePayment.InstitutePart = VPC[0].InstitutePart ?? 0;
                VisitPatientCarePayment.AddressPart = VPC[0].AddressPart ?? 0;
                VisitPatientCarePayment.Address = VPC[0].Address ?? "";
                VisitPatientCarePayment.PostalCode = VPC[0].PostalCode ?? "";
                VisitPatientCarePayment.TelHome = VPC[0].TelHome ?? "";
                VisitPatientCarePayment.TelBusiness = VPC[0].TelBusiness ?? "";
                VisitPatientCarePayment.Mobile = VPC[0].Mobile ?? "";
                VisitPatientCarePayment.Mobile2 = VPC[0].Mobile2 ?? "";
                VisitPatientCarePayment.Email = VPC[0].Email ?? "";
                VisitPatientCarePayment.BasicInsurance = VPC[0].BasicInsurance ?? "";
                VisitPatientCarePayment.CompletionInsurance = VPC[0].CompletionInsurance ?? "";
                VisitPatientCarePayment.IssueArchive = VPC[0].IssueArchive ?? "";
                VisitPatientCarePayment.LetterNo = VPC[0].LetterNo ?? "";
                VisitPatientCarePayment.LetterDate = VPC[0].LetterDate ?? "";
                VisitPatientCarePayment.ContractNo = VPC[0].ContractNo ?? "";
                VisitPatientCarePayment.ContractDate = VPC[0].ContractDate ?? "";
                VisitPatientCarePayment.CarrierName = VPC[0].CarrierName ?? "";
                VisitPatientCarePayment.CarrierFamily = VPC[0].CarrierFamily ?? "";
                VisitPatientCarePayment.CarrierNationalCode = VPC[0].CarrierNationalCode ?? "";
                VisitPatientCarePayment.CarrierSexStr = VPC[0].CarrierSexStr ?? "";
                VisitPatientCarePayment.CarrierBrithDate = VPC[0].CarrierBrithDate ?? "";
                VisitPatientCarePayment.CarrierAddress = VPC[0].CarrierAddress ?? "";
                VisitPatientCarePayment.CarrierTelHome = VPC[0].CarrierTelHome ?? "";
                VisitPatientCarePayment.CarrierMobile = VPC[0].CarrierMobile ?? "";
                VisitPatientCarePayment.KinShipName = VPC[0].KinShipName ?? "";
                VisitPatientCarePayment.PatientFillAccount = VPC[0].PatientFillAccount ?? false;
                

                Ls.Add(VisitPatientCarePayment);


                if (!_editIns)
                {
                    new ViewModel.VisitPatientCare.VisitPatientCarePayment().InsertEntity(Ls, ref str, ref idSet);
                    
                    new ViewModel.VisitPatientCare.VisitPatientCare().UpdateVisitStatus(_VisitPatientCare_Id, 2,
                            MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                            MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(System.DateTime.Now),
                        ref str);
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
                    buttonSendCarePaymentDetail.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, ex.Message);
            }
        }


        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation, true, " آیا به حذف ردیف انتخاب شده تمایل دارید؟ درصورت حذف از لیست پرداختی ها خارج می شود!"))
            {
                this.Visible = false;
                if (_editIns)
                {
                    long? idSet = 0;
                    try
                    {
                        List<TBL_VisitPatientCarePayment> Ls = new List<TBL_VisitPatientCarePayment>(1);
                        TBL_VisitPatientCarePayment VisitPatientCarePayment = new TBL_VisitPatientCarePayment();
                        VisitPatientCarePayment.Id = _id;

                        Ls.Add(VisitPatientCarePayment);

                        new ViewModel.VisitPatientCare.VisitPatientCarePayment().DeleteEntity(Ls, ref str);
                        if (str != "")
                            MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "اشکال اطلاعات", str);
                        else
                            MKH.Library.Clasess.MSSMessage.MSSMessage_View("حذف با موفقیت انجام شد", MKH.Library.Clasess.MSSMessage.MessageType.SInformation);
                    }
                    catch (Exception ex)
                    {
                        MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, ex.Message);
                    }
                }
            }
        }
    }
}
