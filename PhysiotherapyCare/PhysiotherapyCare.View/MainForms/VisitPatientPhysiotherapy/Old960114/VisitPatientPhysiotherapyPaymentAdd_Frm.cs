using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using PhysiotherapyCare.ViewModel.VisitPatientPhysiotherapy;
using PhysiotherapyCare.Model.VisitPatientPhysiotherapy;
using PhysiotherapyCare.ViewModel.Basic;


namespace PhysiotherapyCare.View.MainForms.VisitPatientPhysiotherapyPayment
{
    public partial class VisitPatientPhysiotherapyPaymentAdd_Frm : MKH.Library.Forms.MSSBaseNew_frm
    {
        private int _id = 0, _VisitPatientPhysiotherapy_Id = 0;
        private bool _editIns = false;


        public VisitPatientPhysiotherapyPaymentAdd_Frm(long VisitPatientPhysiotherapy_Id)
        {
            InitializeComponent();
            _VisitPatientPhysiotherapy_Id = VisitPatientPhysiotherapy_Id.ToString().ToInt();
        }


        public VisitPatientPhysiotherapyPaymentAdd_Frm(long Id, long VisitPatientPhysiotherapy_Id)
        {
            InitializeComponent();
            _id = Id.ToString().ToInt();
            _VisitPatientPhysiotherapy_Id = VisitPatientPhysiotherapy_Id.ToString().ToInt();
            _editIns = true;
        }

        private void VisitPatientPhysiotherapyPaymentAdd_Frm_Load(object sender, EventArgs e)
        {
            DatePickerPaymentDate.Value = KagNetComponents2.KagPersianDate.Now;

            string str = "";
            ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapy RN = new ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapy();

            TextBoxPatient.Tag = RN.GetAllListByID(_VisitPatientPhysiotherapy_Id, ref str)[0].Patient_Id;
            TextBoxPatient.Text = RN.GetAllListByID(_VisitPatientPhysiotherapy_Id, ref str)[0].PatientName + "" + RN.GetAllListByID(_VisitPatientPhysiotherapy_Id, ref str)[0].PatientFamily;

            TextBoxLetterNo.Text = RN.GetAllListByID(_VisitPatientPhysiotherapy_Id, ref str)[0].LetterNo;
            DatePickerLetterDate.Value = KagNetComponents2.KagPersianDate.Parse(RN.GetAllListByID(_VisitPatientPhysiotherapy_Id, ref str)[0].LetterDate.Substring(0, 10));

            TextBoxDoctor.Text = RN.GetAllListByID(_VisitPatientPhysiotherapy_Id, ref str)[0].DoctorName + "" + RN.GetAllListByID(_VisitPatientPhysiotherapy_Id, ref str)[0].DoctorFamily;


            if (_editIns) fillControl();
            else
            {
                DatePickerBiginDate.Value = KagNetComponents2.KagPersianDate.Parse(RN.GetAllListByID(_VisitPatientPhysiotherapy_Id, ref str)[0].BeginDate);
                DatePickerEndDate.Value = KagNetComponents2.KagPersianDate.Parse(RN.GetAllListByID(_VisitPatientPhysiotherapy_Id, ref str)[0].EndDate);

                //IntBoxPriceFix.Value = 0;
                IntBoxPriceFix.Value = new ViewModel.Setting.Setting().GetAllValue("PhysiotherapyPriceVisit", ref str);
                IntBoxTaxPercent.Value = new ViewModel.Setting.Setting().GetAllValue("PhysiotherapyTaxPercent", ref str);
            }
        }

        private void fillControl()
        {
            string str = "";
            ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapyPayment RN = new ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapyPayment();
            
            DatePickerPaymentDate.Value = KagNetComponents2.KagPersianDate.Parse(RN.GetAllListByID(_id, ref str)[0].PaymentDate);

            DatePickerBiginDate.Value = KagNetComponents2.KagPersianDate.Parse(RN.GetAllListByID(_id, ref str)[0].BeginDate);
            DatePickerEndDate.Value = KagNetComponents2.KagPersianDate.Parse(RN.GetAllListByID(_id, ref str)[0].EndDate);

            IntBoxVisitFew.Value = RN.GetAllListByID(_id, ref str)[0].VisitFew;

            TextBoxDescription.Text = RN.GetAllListByID(_id, ref str)[0].Description;
            //IntBoxOtherDetract.Value = RN.GetAllListByID(_id, ref str)[0].OtherDetract;
            //IntBoxPriceFix.Value = RN.GetAllListByID(_id, ref str)[0].PriceVisit;
            //IntBoxPriceVisitAll.Value = RN.GetAllListByID(_id, ref str)[0].PriceVisitAll;
            //IntBoxTaxPercent.Value = RN.GetAllListByID(_id, ref str)[0].TaxPercent;

            //IntBoxDetractCo.Value = RN.GetAllListByID(_id, ref str)[0].DetractCo;
        }

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
                VisitPatientPhysiotherapyPayment.VisitPatientPhysiotherapy_Id = _VisitPatientPhysiotherapy_Id;

                VisitPatientPhysiotherapyPayment.PaymentDate = DatePickerPaymentDate.Value.ToString();
                VisitPatientPhysiotherapyPayment.BeginDate = DatePickerBiginDate.Value.ToString();
                VisitPatientPhysiotherapyPayment.EndDate = DatePickerEndDate.Value.ToString();

                VisitPatientPhysiotherapyPayment.VisitFew = Convert.ToInt16(IntBoxVisitFew.Value);

                //VisitPatientPhysiotherapyPayment.PriceFix = 0;
                //VisitPatientPhysiotherapyPayment.OtherDetract = Convert.ToInt32(IntBoxOtherDetract.Value);
                //VisitPatientPhysiotherapyPayment.PriceVisit = Convert.ToInt32(IntBoxPriceFix.Value);
                //VisitPatientPhysiotherapyPayment.PriceVisitAll = Convert.ToInt64(IntBoxPriceVisitAll.Value);
                //VisitPatientPhysiotherapyPayment.TaxPercent = Convert.ToDouble(IntBoxTaxPercent.Value);

                //VisitPatientPhysiotherapyPayment.DetractCo = Convert.ToInt32(IntBoxDetractCo.Value);

                VisitPatientPhysiotherapyPayment.Description = TextBoxDescription.Text;
                
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

                    new ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapy().UpdateFinancialSettlement(_VisitPatientPhysiotherapy_Id, checkBoxFinancialSettlement.Checked, ref str);
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

            //if (TextBoxPatient.Text.Trim() == "")
            //{
            //    MKH.Library.Clasess.MSSMessage.MSSMessage_View("لطفا نام بیمار را پر نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation);
            //    return false;
            //}
            //if (TextBoxVisitPatientPhysiotherapyFamily.Text.Trim() == "")
            //{
            //    MKH.Library.Clasess.MSSMessage.MSSMessage_View("لطفا فامیل پزشک  را پر نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation);
            //    return false;
            //}
            //if (TextBoxMobile.Text.Trim() == "")
            //{
            //    MKH.Library.Clasess.MSSMessage.MSSMessage_View("لطفا موبایل را پر نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation);
            //    return false;
            //}
            //if (ComboBoxVisitPatientPhysiotherapyType_Id.Text.Trim() == "")
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
            IntBoxPriceVisitAll.Value = (IntBoxPriceFix.Value.ToString().ToInt() * IntBoxVisitFew.Value.ToString().ToInt()) -
                (IntBoxPriceFix.Value.ToString().ToInt() * IntBoxVisitFew.Value.ToString().ToInt()) * Convert.ToDouble(IntBoxTaxPercent.Value.ToString()) -
                IntBoxOtherDetract.Value.ToString().ToInt() - IntBoxDetractCo.Value.ToString().ToInt();
        }

        private void DatePickerBiginDate_ValueChanged(object sender, KagNetComponents2.PersianMonthCalendarEventArgs e)
        {
            IntBoxVisitFew.Value = (DatePickerEndDate.ValueEn - DatePickerBiginDate.ValueEn).Days;
        }


      


    }
}
