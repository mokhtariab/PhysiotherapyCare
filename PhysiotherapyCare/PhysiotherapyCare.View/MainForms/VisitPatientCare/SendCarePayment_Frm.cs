using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using MKH.Library.Clasess;
using PhysiotherapyCare.Model.VisitPatientCare;


namespace PhysiotherapyCare.View.MainForms.VisitPatientCare
{
    public partial class SendCarePayment_Frm : MKH.Library.Forms.MSSBaseNew_frm
    {
        private int _VisitPatientCare_Id = 0;
        private bool _editIns = false;
        string str = "";

        public SendCarePayment_Frm()
        {
            InitializeComponent();
        }


        public SendCarePayment_Frm(int VisitPatientCare_Id)
        {
            InitializeComponent();
            _VisitPatientCare_Id = VisitPatientCare_Id;

            string str = "";
            if (new ViewModel.Basic.NODuplicateForm().CheckNODuplicateForm("TBL_VisitPatientCare", _VisitPatientCare_Id.ToString(), ref str))
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("امکان ویرایش به علت انجام عملیات توسط کاربر دیگر امکان پذیر نمی باشد", MKH.Library.Clasess.MSSMessage.MessageType.SWarning);
                Close();
            }
            else
                new ViewModel.Basic.NODuplicateForm().InsertEntity("TBL_VisitPatientCare", _VisitPatientCare_Id.ToString(), ref str);



            //_editIns = ((new ViewModel.VisitPatientCare.VisitPatientCarePayment().GetAllListByDetailRow(_VisitPatientCare_Id, 0, ref str).Count()) > 0);
        }

        private void SendCarePayment_Frm_Load(object sender, EventArgs e)
        {
            FillDefaultControl();
            
            tableLayoutPanelNews.Controls.Clear();

            ViewModel.VisitPatientCare.VisitPatientCare RN = new ViewModel.VisitPatientCare.VisitPatientCare();
            List<VW_VisitPatientCare> VPC = RN.GetAllListByID(_VisitPatientCare_Id, ref str);

            int DurationMonth = (KagNetComponents2.KagPersianDate.Parse(VPC[0].EndDate).ShamsiYear - KagNetComponents2.KagPersianDate.Parse(VPC[0].BeginDate).ShamsiYear) * 12 +
                (KagNetComponents2.KagPersianDate.Parse(VPC[0].EndDate).ShamsiMonth - KagNetComponents2.KagPersianDate.Parse(VPC[0].BeginDate).ShamsiMonth) + 1;


            //if (_editIns) FillTableLayoutPanelEdit();
            //else
            //{
                long _idSet = 0;
                if (DurationMonth == 1)
                {
                    _idSet = GetVisitCarePaymentId(VPC[0].BeginDate, VPC[0].EndDate);
                    if (_idSet == 0)
                        AddNewRecord(_VisitPatientCare_Id, VPC[0].BeginDate, VPC[0].EndDate);
                    else
                        FillTableLayoutPanelEdit(_idSet);
                }
                else
                    if (DurationMonth == 2)
                    {
                        _idSet = GetVisitCarePaymentId(VPC[0].BeginDate, MKH.Library.Clasess.Date.DateConvertor.CheckEndDate(VPC[0].BeginDate.Substring(0, 8) + "31"));// VPC[0].BeginDate.Substring(0, 8) + (KagNetComponents2.KagPersianDate.Parse(VPC[0].BeginDate).ShamsiMonth < 7 ? "31" : "30"));
                        if (_idSet == 0)
                            AddNewRecord(_VisitPatientCare_Id, VPC[0].BeginDate, MKH.Library.Clasess.Date.DateConvertor.CheckEndDate(VPC[0].BeginDate.Substring(0, 8) + "31"));//VPC[0].BeginDate.Substring(0, 8) + (KagNetComponents2.KagPersianDate.Parse(VPC[0].BeginDate).ShamsiMonth < 7 ? "31" : "30"));
                        else
                            FillTableLayoutPanelEdit(_idSet);

                        _idSet = GetVisitCarePaymentId(VPC[0].EndDate.Substring(0, 8) + "01", VPC[0].EndDate);
                        if (_idSet == 0)
                            AddNewRecord(_VisitPatientCare_Id, VPC[0].EndDate.Substring(0, 8) + "01", VPC[0].EndDate);
                        else
                            FillTableLayoutPanelEdit(_idSet);

                    }
                    else
                    {
                        _idSet = GetVisitCarePaymentId(VPC[0].BeginDate, MKH.Library.Clasess.Date.DateConvertor.CheckEndDate(VPC[0].BeginDate.Substring(0, 8) + "31"));
                        if (_idSet == 0)
                            AddNewRecord(_VisitPatientCare_Id, VPC[0].BeginDate, MKH.Library.Clasess.Date.DateConvertor.CheckEndDate(VPC[0].BeginDate.Substring(0, 8) + "31"));
                        else
                            FillTableLayoutPanelEdit(_idSet);


                        string BgDate, EnDate;
                        for (int i = 1; i < DurationMonth - 1; i++)
                        {
                            //BgDate = (KagNetComponents2.KagPersianDate.Parse(VPC[0].BeginDate).AddMonths(i).ShamsiMonth < 7 ?
                            //    KagNetComponents2.KagPersianDate.Parse(VPC[0].BeginDate).AddMonths(i+1).ToString().Substring(0, 8) + "01":
                            //    KagNetComponents2.KagPersianDate.Parse(VPC[0].BeginDate).AddMonths(i+1).ToString().Substring(0, 8) + "01");
                            //EnDate = (KagNetComponents2.KagPersianDate.Parse(VPC[0].BeginDate).AddMonths(i).ShamsiMonth < 7 ?
                            //                                KagNetComponents2.KagPersianDate.Parse(VPC[0].BeginDate).AddMonths(i + 1).ToString().Substring(0, 8) + (KagNetComponents2.KagPersianDate.Parse(VPC[0].BeginDate).AddMonths(i + 1).ShamsiMonth < 7 ? "31" : "30") :
                            //                                KagNetComponents2.KagPersianDate.Parse(VPC[0].BeginDate).AddMonths(i + 1).ToString().Substring(0, 8) + (KagNetComponents2.KagPersianDate.Parse(VPC[0].BeginDate).AddMonths(i + 1).ShamsiMonth < 7 ? "31" : "30"));

                            if (MKH.Library.Clasess.Date.DateConvertor.CheckShamsiDate((KagNetComponents2.KagPersianDate.Parse(VPC[0].BeginDate).ShamsiYear.ToString()) + "/" + ((KagNetComponents2.KagPersianDate.Parse(VPC[0].BeginDate).ShamsiMonth + i).ToString().Length == 1 ? ("0" + (KagNetComponents2.KagPersianDate.Parse(VPC[0].BeginDate).ShamsiMonth + i).ToString()) : (KagNetComponents2.KagPersianDate.Parse(VPC[0].BeginDate).ShamsiMonth + i).ToString()) + "/" + "01"))
                                BgDate = (KagNetComponents2.KagPersianDate.Parse(VPC[0].BeginDate).ShamsiYear.ToString()) + "/" + ((KagNetComponents2.KagPersianDate.Parse(VPC[0].BeginDate).ShamsiMonth + i).ToString().Length == 1 ? ("0" + (KagNetComponents2.KagPersianDate.Parse(VPC[0].BeginDate).ShamsiMonth + i).ToString()) : (KagNetComponents2.KagPersianDate.Parse(VPC[0].BeginDate).ShamsiMonth + i).ToString()) + "/" + "01";
                            else
                                BgDate = KagNetComponents2.KagPersianDate.Parse(VPC[0].BeginDate).AddMonths(i + 1).ToString().Substring(0, 8) + "01";
                            EnDate = MKH.Library.Clasess.Date.DateConvertor.CheckEndDate(BgDate.Substring(0, 8) + "31");// KagNetComponents2.KagPersianDate.Parse(VPC[0].BeginDate).AddMonths(i + 1).ToString().Substring(0, 8) + (KagNetComponents2.KagPersianDate.Parse(VPC[0].BeginDate).AddMonths(i + 1).ShamsiMonth < 7 ? "31" : "30");

                            _idSet = GetVisitCarePaymentId(BgDate, EnDate);
                            if (_idSet == 0)
                                AddNewRecord(_VisitPatientCare_Id, BgDate, EnDate);
                            else
                                FillTableLayoutPanelEdit(_idSet);

                        }

                        _idSet = GetVisitCarePaymentId(VPC[0].EndDate.Substring(0, 8) + "01", VPC[0].EndDate);
                        if (_idSet == 0)
                            AddNewRecord(_VisitPatientCare_Id, VPC[0].EndDate.Substring(0, 8) + "01", VPC[0].EndDate);
                        else
                            FillTableLayoutPanelEdit(_idSet);
                    }
            //}
        }

        private long GetVisitCarePaymentId(string BeginDate, string EndDate)
        {
            long ret = 0;
            try
            {
                ret = new ViewModel.VisitPatientCare.VisitPatientCarePayment().GetAllListByDetailRow(_VisitPatientCare_Id, 0, ref str).Where(ei =>
                            KagNetComponents2.KagPersianDate.Parse(ei.BeginDate).ShamsiYear == KagNetComponents2.KagPersianDate.Parse(BeginDate).ShamsiYear &&
                            KagNetComponents2.KagPersianDate.Parse(ei.BeginDate).ShamsiMonth == KagNetComponents2.KagPersianDate.Parse(BeginDate).ShamsiMonth &&
                            KagNetComponents2.KagPersianDate.Parse(ei.EndDate).ShamsiYear == KagNetComponents2.KagPersianDate.Parse(EndDate).ShamsiYear &&
                            KagNetComponents2.KagPersianDate.Parse(ei.EndDate).ShamsiMonth == KagNetComponents2.KagPersianDate.Parse(EndDate).ShamsiMonth).Single().Id;
            }
            catch
            {
                ret = 0;
            }
            return ret;
        }


        int CntCount = 0;
        private void FillTableLayoutPanelEdit(long Id)
        {
            //try
            //{
                SendCarePaymentDetail_UC smsp = new SendCarePaymentDetail_UC(Id);
                smsp.Tag = Id;
                smsp.Controls.Owner.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                tableLayoutPanelNews.Controls.Add(smsp, 1, tableLayoutPanelNews.Controls.Count + 1);

                smsp.Enabled = new ViewModel.VisitPatientCare.VisitPatientCarePayment().GetAllListByID(Id, ref str).Single().AccountingDocumentNumber == ""
                    || new ViewModel.VisitPatientCare.VisitPatientCarePayment().GetAllListByID(Id, ref str).Single().AccountingDocumentNumber == null;
            //}
            //catch (Exception ex)
            //{
            //    MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, ex.Message);
            //}
            SetRowTableSet();
        }



        
        private void FillDefaultControl()
        {
            string str = "";
            ViewModel.VisitPatientCare.VisitPatientCare RN = new ViewModel.VisitPatientCare.VisitPatientCare();
            List<VW_VisitPatientCare> VPC = RN.GetAllListByID(_VisitPatientCare_Id, ref str);

            TextBoxPatient.Tag = VPC[0].Patient_Id;
            TextBoxPatient.Text = VPC[0].PatientName + " " + VPC[0].PatientFamily;

            TextBoxLetterNo.Text = VPC[0].LetterNo;
            TextBoxLetterDate.Text = VPC[0].LetterDate;
            TextBoxContractNo.Text = VPC[0].ContractNo;
            TextBoxContractDate.Text = VPC[0].ContractDate;

            TextBoxBeginDate.Text = VPC[0].BeginDate;
            TextBoxEndDate.Text = VPC[0].EndDate;
            try { CheckBoxPatientFillAccount.Checked = VPC[0].PatientFillAccount.Value; }
            catch { }

            int DurationDays = (MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(VPC[0].EndDate) - MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(VPC[0].BeginDate)).Days;

            int CareShiftPrice = VPC[0].ShiftFew == 1 ? new ViewModel.Setting.Setting().GetAllValue("CareShift1", ref str).ToString().ToInt() :
                                 VPC[0].ShiftFew == 2 ? new ViewModel.Setting.Setting().GetAllValue("CareShift2", ref str).ToString().ToInt() :
                                 VPC[0].ShiftFew == 3 ? new ViewModel.Setting.Setting().GetAllValue("CareShift3", ref str).ToString().ToInt() : 0;

            int CareDaysDefault = new ViewModel.Setting.Setting().GetAllValue("CareDaysDefault", ref str).ToString().ToInt();
            IntBoxTotalPrice.Text = ((CareShiftPrice/CareDaysDefault)*DurationDays).ToString();

        }

        //private void FillTableLayoutPanelEdit()
        //{
        //    try
        //    {
        //        tableLayoutPanelNews.Controls.Clear();
        //        int i = 0;
        //        var collation = new ViewModel.VisitPatientCare.VisitPatientCarePayment().GetAllListByDetailRow(_VisitPatientCare_Id, 0, ref str);
        //        foreach (var item in collation)
        //        {
        //            SendCarePaymentDetail_UC smsp = new SendCarePaymentDetail_UC(item.Id);
        //            smsp.Tag = item.Id;
        //            smsp.Controls.Owner.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
        //            tableLayoutPanelNews.Controls.Add(smsp, 1, ++i);
        //            smsp.Enabled = item.AccountingDocumentNumber == "" || item.AccountingDocumentNumber == null;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, ex.Message);
        //    }
        //    SetRowTableSet();
        //}

        public void SetRowTableSet()
        {        
            int tableLayoutPanelRowCnt = 0;

            foreach (Control fg in tableLayoutPanelNews.Controls)
                if ((fg as SendCarePaymentDetail_UC).Visible)
                    (fg as SendCarePaymentDetail_UC).setRowNo(++tableLayoutPanelRowCnt);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //if (!CheckValidation())
            //    return;
            //try
            //{
            //     str = SaveParametersUsercontrols();
            //    if (str != "")
            //        MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MSSMessage.MessageType.SError, false, "اشکال اطلاعات", str);
            //    else
            //    {
            //        MKH.Library.Clasess.MSSMessage.MSSMessage_View("اطلاعات ذخیره شد", MKH.Library.Clasess.MSSMessage.MessageType.SInformation);
            DialogResult = System.Windows.Forms.DialogResult.OK;
            //ShowReport(_id);
            Close();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "اشکال در ذخیره اطلاعات", ex.Message);
            //}
        }

        //private bool CheckParametersUsercontrols()
        //{
        //    foreach (Control fg in tableLayoutPanelNews.Controls)
        //    {
        //        if ((fg as SendCarePaymentDetail_UC).Visible)
        //            if ((fg as SendCarePaymentDetail_UC).GetRowNo() == 1)
        //            {
        //                if ((fg as SendCarePaymentDetail_UC).DatePickerBeginDate.Value.ToString() != TextBoxBeginDate.Text)
        //                {
        //                    MKH.Library.Clasess.MSSMessage.MSSMessage_View("ردیف (1) تاریخ شروع قرارداد صحیح نمی باشد", MKH.Library.Clasess.MSSMessage.MessageType.SError);
        //                    return false;
        //                }
        //            }

        //        if (!(fg as SendCarePaymentDetail_UC).CheckvalidationUC())
        //            return false;
        //    }
        //    return true;
        //}
        
        //private string SaveParametersUsercontrols()
        //{
        //    string result = "";
        //    foreach (Control fg in tableLayoutPanelNews.Controls)
        //    {
        //        if ((fg as SendCarePaymentDetail_UC).Visible)
        //        {
        //            if ((fg as SendCarePaymentDetail_UC).Tag == null || (fg as SendCarePaymentDetail_UC).Tag == "")
        //                result = (fg as SendCarePaymentDetail_UC).save(0, 0);
        //            else
        //                result = (fg as SendCarePaymentDetail_UC).save((fg as SendCarePaymentDetail_UC).Tag.ToString().ToInt(), 1);
        //        }
        //        else
        //            result = (fg as SendCarePaymentDetail_UC).save((fg as SendCarePaymentDetail_UC).Tag.ToString().ToInt(), 2);
        //    }
        //    return result;
        //}



        //private bool CheckValidation()
        //{
        //    int i = 0;
        //    foreach (Control fg in tableLayoutPanelNews.Controls)
        //        if ((fg as SendCarePaymentDetail_UC).Visible)
        //            i += 1;
        //    if (i == 0)
        //    {
        //        MKH.Library.Clasess.MSSMessage.MSSMessage_View("هیچ رکوردی وارد نشده است", MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation);
        //        return false;
        //    }

        //    if (!CheckParametersUsercontrols())
        //    {
        //        return false;
        //    }

           
        //    return true;
        //}

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAddNews_Click(object sender, EventArgs e)
        {
            AddNewRecord(_VisitPatientCare_Id, TextBoxEndDate.Text,TextBoxEndDate.Text);
        }

        private void AddNewRecord(int VisitPatientCare_Id, string BeginDateStr, string EndDateStr)
        {
            SendCarePaymentDetail_UC SSUC = new SendCarePaymentDetail_UC(VisitPatientCare_Id, BeginDateStr, EndDateStr);
            SSUC.Controls.Owner.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            tableLayoutPanelNews.Controls.Add(SSUC, 1, tableLayoutPanelNews.Controls.Count + 1);
            SetRowTableSet();
        }

        private void SendCarePayment_Frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            string str = "";
            new ViewModel.Basic.NODuplicateForm().DeleteEntity("TBL_VisitPatientCare", _VisitPatientCare_Id.ToString(), ref str);
        }


    }
}
