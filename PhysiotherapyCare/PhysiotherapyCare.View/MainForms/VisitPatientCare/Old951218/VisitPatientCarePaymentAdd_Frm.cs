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
    public partial class VisitPatientCarePaymentAdd_Frm : MKH.Library.Forms.MSSBaseNew_frm
    {
        private int _id = 0, _visitPatientCare_Id = 0;
        private bool _editIns = false;
        string str = "";

        public VisitPatientCarePaymentAdd_Frm(long VisitPatientCare_Id)
        {
            InitializeComponent();
            _visitPatientCare_Id = VisitPatientCare_Id.ToString().ToInt();
        }


        public VisitPatientCarePaymentAdd_Frm(long Id, long VisitPatientCare_Id)
        {
            InitializeComponent();
            _id = Id.ToString().ToInt();
            _visitPatientCare_Id = VisitPatientCare_Id.ToString().ToInt();
            _editIns = true;
        }

        Int64 CareShift = 0;
        private void VisitPatientCarePaymentAdd_Frm_Load(object sender, EventArgs e)
        {
            DatePickerPaymentDate.Value = KagNetComponents2.KagPersianDate.Now;
            
           
            ViewModel.VisitPatientCare.VisitPatientCare RN = new ViewModel.VisitPatientCare.VisitPatientCare();
            TextBoxPatient.Tag = RN.GetAllListByID(_visitPatientCare_Id, ref str)[0].Patient_Id;
            TextBoxPatient.Text = RN.GetAllListByID(_visitPatientCare_Id, ref str)[0].PatientName + "" + RN.GetAllListByID(_visitPatientCare_Id, ref str)[0].PatientFamily;

            TextBoxLetterNo.Text = RN.GetAllListByID(_visitPatientCare_Id, ref str)[0].LetterNo;
            DatePickerLetterDate.Value = KagNetComponents2.KagPersianDate.Parse(RN.GetAllListByID(_visitPatientCare_Id, ref str)[0].LetterDate.Substring(0, 10));
            TextBoxContractNo.Text = RN.GetAllListByID(_visitPatientCare_Id, ref str)[0].ContractNo;
            try
            {
                DatePickerContractDate.Value = KagNetComponents2.KagPersianDate.Parse(RN.GetAllListByID(_visitPatientCare_Id, ref str)[0].ContractDate);
            }
            catch { }
            TextBoxDoctor.Text =
                RN.GetAllListByID(_visitPatientCare_Id, ref str)[0].Doctor_Id == 0 ?
                RN.GetAllListByID(_visitPatientCare_Id, ref str)[0].CarrierName + " " + RN.GetAllListByID(_visitPatientCare_Id, ref str)[0].CarrierFamily :
                RN.GetAllListByID(_visitPatientCare_Id, ref str)[0].DoctorName + " " + RN.GetAllListByID(_visitPatientCare_Id, ref str)[0].DoctorFamily;

            //LabelPrePayment.Text = RN.GetAllListByID(_visitPatientCare_Id, ref str)[0].PrePayment.Value.ToString();

            if (IntBoxShiftFew.Value.ToString() == "1")
                CareShift = new ViewModel.Setting.Setting().GetAllValue("CareShift1", ref str).ToString().ToInt();
            else if (IntBoxShiftFew.Value.ToString() == "2")
                CareShift = new ViewModel.Setting.Setting().GetAllValue("CareShift2", ref str).ToString().ToInt();
            else
                CareShift = new ViewModel.Setting.Setting().GetAllValue("CareShift3", ref str).ToString().ToInt();

            
            
            if (_editIns) fillControl();
            else
            {
                IntBoxShiftFew.Value = RN.GetAllListByID(_visitPatientCare_Id, ref str)[0].ShiftFew;
                DatePickerBiginDate.Value = KagNetComponents2.KagPersianDate.Parse(RN.GetAllListByID(_visitPatientCare_Id, ref str)[0].BeginDate);
                DatePickerEndDate.Value = KagNetComponents2.KagPersianDate.Parse(RN.GetAllListByID(_visitPatientCare_Id, ref str)[0].EndDate);

                IntBoxShiftHour.Value = new ViewModel.Setting.Setting().GetAllValue("CareShiftHour", ref str);

                IntBoxTaxPercent.Value = new ViewModel.Setting.Setting().GetAllValue("CareTaxPercent", ref str);
                IntBoxDetractPercent.Value = new ViewModel.Setting.Setting().GetAllValue("CareDetractPercent", ref str);
            }
        }

        private void fillControl()
        {
            string str = "";
            ViewModel.VisitPatientCare.VisitPatientCarePayment RN = new ViewModel.VisitPatientCare.VisitPatientCarePayment();
            
            DatePickerPaymentDate.Value = KagNetComponents2.KagPersianDate.Parse(RN.GetAllListByID(_id, ref str)[0].PaymentDate);

            IntBoxShiftFew.Value = RN.GetAllListByID(_id, ref str)[0].ShiftFew;
            DatePickerBiginDate.Value = KagNetComponents2.KagPersianDate.Parse(RN.GetAllListByID(_id, ref str)[0].BeginDate);
            DatePickerEndDate.Value = KagNetComponents2.KagPersianDate.Parse(RN.GetAllListByID(_id, ref str)[0].EndDate);
            IntBoxDurationDays.Value = RN.GetAllListByID(_id, ref str)[0].DurationDays;

            //IntBoxPriceFix.Value = RN.GetAllListByID(_id, ref str)[0].PriceVisit;

            //IntBoxTaxPercent.Value = RN.GetAllListByID(_id, ref str)[0].TaxPercent;
            //IntBoxDetractPercent.Value = RN.GetAllListByID(_id, ref str)[0].DetractPercent;

            //IntBoxOtherDetract.Value = RN.GetAllListByID(_id, ref str)[0].OtherDetract;
            //IntBoxDetractCo.Value = RN.GetAllListByID(_id, ref str)[0].DetractCo;

            //IntBoxPriceVisitAll.Value = RN.GetAllListByID(_id, ref str)[0].PriceVisitAll;
            
            TextBoxDescription.Text = RN.GetAllListByID(_id, ref str)[0].Description;

        }

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
                VisitPatientCarePayment.VisitPatientCare_Id = _visitPatientCare_Id;

                VisitPatientCarePayment.PaymentDate = DatePickerPaymentDate.Value.ToString();

                VisitPatientCarePayment.ShiftFew = Convert.ToInt16(IntBoxShiftFew.Value);
                //VisitPatientCarePayment.ShiftHour = Convert.ToInt16(IntBoxShiftHour.Value);
                
                VisitPatientCarePayment.BeginDate = DatePickerBiginDate.Value.ToString();
                VisitPatientCarePayment.EndDate = DatePickerEndDate.Value.ToString();
                VisitPatientCarePayment.DurationDays = Convert.ToInt16(IntBoxDurationDays.Value);

                //VisitPatientCarePayment.TaxPercent = Convert.ToDouble(IntBoxTaxPercent.Value);
                //VisitPatientCarePayment.DetractPercent = Convert.ToDouble(IntBoxDetractPercent.Value);

                //VisitPatientCarePayment.PriceVisit = Convert.ToInt32(IntBoxPriceFix.Value);
                //VisitPatientCarePayment.OtherDetract = Convert.ToInt32(IntBoxOtherDetract.Value);
                //VisitPatientCarePayment.PriceVisitAll = Convert.ToInt64(IntBoxPriceVisitAll.Value);

                VisitPatientCarePayment.Description = TextBoxDescription.Text;


                //VisitPatientCarePayment.DetractCo = Convert.ToInt32(IntBoxDetractCo.Value);


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

                    new ViewModel.VisitPatientCare.VisitPatientCare().UpdateFinancialSettlement(_visitPatientCare_Id, checkBoxFinancialSettlement.Checked, ref str);
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
            if (IntBoxPriceVisitAll.Value.ToString() == "0")
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("لطفا مبلغ پرداختی را مشخص نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                return false;
            }
            //if (TextBoxVisitPatientCareFamily.Text.Trim() == "")
            //{
            //    MKH.Library.Clasess.MSSMessage.MSSMessage_View("لطفا فامیل پزشک  را پر نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation);
            //    return false;
            //}
            //if (TextBoxMobile.Text.Trim() == "")
            //{
            //    MKH.Library.Clasess.MSSMessage.MSSMessage_View("لطفا موبایل را پر نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation);
            //    return false;
            //}
            //if (ComboBoxVisitPatientCareType_Id.Text.Trim() == "")
            //{
            //    MKH.Library.Clasess.MSSMessage.MSSMessage_View("لطفا نوع پزشک  را پر نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation);
            //    return false;
            //}
            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

      

        private void IntBoxPriceFix_ValueChanged(object sender, EventArgs e)
        {
            int i = (IntBoxPriceFix.Value.ToString().ToInt() - Convert.ToInt32(IntBoxPriceFix.Value.ToString().ToInt() * Convert.ToDouble(IntBoxTaxPercent.Value.ToString()))).ToString().ToInt();
            IntBoxPriceVisitAll.Value = i - i * Convert.ToDouble(IntBoxDetractPercent.Value.ToString()) -
                IntBoxOtherDetract.Value.ToString().ToInt() - IntBoxDetractCo.Value.ToString().ToInt();
        }

        private void DatePickerBiginDate_ValueChanged(object sender, KagNetComponents2.PersianMonthCalendarEventArgs e)
        {
            IntBoxDurationDays.Value = (DatePickerEndDate.ValueEn - DatePickerBiginDate.ValueEn).Days;
        }

        private void IntBoxDurationDays_ValueChanged(object sender, EventArgs e)
        {
            IntBoxPriceFix.Value = IntBoxDurationDays.Value.ToString().ToInt() * CareShift / (new ViewModel.Setting.Setting().GetAllValue("CareDaysDefault", ref str).ToInt());
        }


      


    }
}
