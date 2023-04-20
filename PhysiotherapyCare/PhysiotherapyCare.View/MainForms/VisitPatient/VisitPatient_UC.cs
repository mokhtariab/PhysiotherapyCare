using System.Linq;
using System.Collections.Generic;
using PhysiotherapyCare.Model.Basic;
using PhysiotherapyCare.Model;
using MKH.Library.Clasess.FilterClass;
using System.Windows.Forms;
using PhysiotherapyCare.Model.VisitPatient;
using PhysiotherapyCare.View.MainForms.VisitPatient;

namespace PhysiotherapyCare.View.MainForms.VisitPatient
{
    public partial class VisitPatient_UC : UserControl
    {
        int _patientId = 0;
        public VisitPatient_UC()
        {
            InitializeComponent();
        }
        //for show 1 patient
        public VisitPatient_UC(int PatientId)
        {
            InitializeComponent();
            _patientId = PatientId;
        }
        //
        public void BindData(int RowNumberSet)
        {


            string str = "";

            List<SP_VisitPatientSelectResult> LSQ = new List<SP_VisitPatientSelectResult>();
            short statusset = RadioBoxVisitStatus1.Checked?System.Convert.ToInt16(1):RadioBoxVisitStatus2.Checked?System.Convert.ToInt16(2):System.Convert.ToInt16(0);
            if (_patientId == 0)
                LSQ = new ViewModel.VisitPatient.VisitPatient().GetAllListSet(DatePickerStart.Value.ToString().Substring(0, 10), DatePickerEnd.Value.ToString().Substring(0, 10), statusset, ref str);
            else
                LSQ = new ViewModel.VisitPatient.VisitPatient().GetAllListSet(DatePickerStart.Value.ToString().Substring(0, 10), DatePickerEnd.Value.ToString().Substring(0, 10), statusset, ref str).Where(pp => pp.Patient_Id == _patientId).ToList();
            
            GridViewVisitPatietSet.DataSource = LSQ;

            try { GridViewVisitPatietSet.Row = RowNumberSet; }
            catch { }



            //string str = "";

            //List<VW_VisitPatient> LSQ = new List<VW_VisitPatient>();

            //if (_patientId == 0)
            //    LSQ = new ViewModel.VisitPatient.VisitPatient().GetAllList(ref str);
            //else
            //    LSQ = new ViewModel.VisitPatient.VisitPatient().GetAllList(ref str).Where(pp => pp.Patient_Id == _patientId).ToList();

            //if (RadioBoxVisitStatus1.Checked)
            //    LSQ = LSQ.Where(ei => ei.VisitStatus_Id == 1).ToList();
            //if (RadioBoxVisitStatus2.Checked)
            //    LSQ = LSQ.Where(ei => ei.VisitStatus_Id == 2).ToList();
            //if (RadioBoxContractWithTime.Checked)
            //{
            //    try
            //    {
            //        if (ComboBoxSerach.SelectedIndex == 0)
            //            LSQ = LSQ.Where(d => MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.LetterDate ?? "") >= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerStart.Value.ToString())
            //                && MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.LetterDate ?? "") <= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerEnd.Value.ToString())).ToList();
            //        else if (ComboBoxSerach.SelectedIndex == 1)
            //            LSQ = LSQ.Where(d => MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.ContractDate ?? "") >= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerStart.Value.ToString())
            //                && MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.ContractDate ?? "") <= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerEnd.Value.ToString())).ToList();
            //        else if (ComboBoxSerach.SelectedIndex == 2)
            //            LSQ = LSQ.Where(d => MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.VisitDate ?? "") >= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerStart.Value.ToString())
            //                && MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.VisitDate ?? "") <= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerEnd.Value.ToString())).ToList();
            //    }
            //    catch { }
            //}

            //GridViewVisitPatietSet.DataSource = LSQ;

            //try { GridViewVisitPatietSet.Row = RowNumberSet; }
            //catch { }


        }

        
        #region All UI Button

        private void headerGridVisitPatientPhysiotherapy_btnInsertClick(object sender, System.EventArgs e)
        {
            VisitPatientAdd_Frm VisitPatientAdd = null;
            if (_patientId != 0)
                VisitPatientAdd = new VisitPatientAdd_Frm(_patientId, "");
            else
                VisitPatientAdd = new VisitPatientAdd_Frm();

            if (VisitPatientAdd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                BindData(GridViewVisitPatietSet.RowCount);
        }

        private void headerGridVisitPatient_btnEditClick(object sender, System.EventArgs e)
        {
            try
            {
               // if (!(HeaderGridVisitPatient as MKH.Library.Control.MSSHeaderGrid).Items["buttonItemEdit"].Visible || !(HeaderGridVisitPatient as MKH.Library.Control.MSSHeaderGrid).Items["buttonItemEdit"].Enabled) return;

                if (short.Parse(GridViewVisitPatietSet.CurrentRow.Cells["VisitStatus_Id"].Value.ToString()) == 2)
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View("امکان ویرایش به دلیل ارسال به بیمه وجود ندارد", MKH.Library.Clasess.MSSMessage.MessageType.SWarning);
                    //return;
                }
                
                VisitPatientAdd_Frm VisitPatientPhysiotherapyAdd = new VisitPatientAdd_Frm(
                    int.Parse(GridViewVisitPatietSet.CurrentRow.Cells["Id"].Value.ToString()),
                    short.Parse(GridViewVisitPatietSet.CurrentRow.Cells["VisitStatus_Id"].Value.ToString()));
                if (VisitPatientPhysiotherapyAdd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    BindData(GridViewVisitPatietSet.Row);
            }
            catch { }
        }

        private void headerGridVisitPatientPhysiotherapy_btnDeleteClick(object sender, System.EventArgs e)
        {
            if (short.Parse(GridViewVisitPatietSet.CurrentRow.Cells["VisitStatus_Id"].Value.ToString()) == 2)
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("امکان حذف به دلیل ارسال به بیمه وجود ندارد", MKH.Library.Clasess.MSSMessage.MessageType.SWarning);
                return;
            }

            string str = "";
            if (new ViewModel.Basic.NODuplicateForm().CheckNODuplicateForm("TBL_VisitPatient", GridViewVisitPatietSet.CurrentRow.Cells["Id"].Value.ToString(), ref str))
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("امکان حذف به علت انجام عملیات توسط کاربر دیگر امکان پذیر نمی باشد", MKH.Library.Clasess.MSSMessage.MessageType.SWarning);
                return;
            }
            
            if (MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation, true, "آیا به حذف این مورد اطمینان دارید؟"))
            {
                try
                {
                    //List<TBL_VisitPatient> Ls = new List<TBL_VisitPatient>();
                    //TBL_VisitPatient VisitPatient = new TBL_VisitPatient();
                    
                    //VisitPatient.Id = int.Parse(GridViewVisitPatietSet.CurrentRow.Cells["Id"].Value.ToString());
                    //VisitPatient.Patient_Id = int.Parse(GridViewVisitPatietSet.CurrentRow.Cells["Patient_Id"].Value.ToString());
                    //VisitPatient.Doctor_Id = int.Parse(GridViewVisitPatietSet.CurrentRow.Cells["Doctor_Id"].Value.ToString());
                    //VisitPatient.VisitDate = GridViewVisitPatietSet.CurrentRow.Cells["VisitDate"].Value.ToString();
                    //VisitPatient.BonyadAddEven = short.Parse(GridViewVisitPatietSet.CurrentRow.Cells["BonyadAddEven"].Value.ToString());
                    //VisitPatient.VisitStatus_Id = short.Parse(GridViewVisitPatietSet.CurrentRow.Cells["VisitStatus_Id"].Value.ToString());

                    //Ls.Add(VisitPatient);


                    ViewModel.VisitPatient.VisitPatient RN = new ViewModel.VisitPatient.VisitPatient();
                    List<TBL_VisitPatient> VWP = RN.GetAllListByTblID(long.Parse(GridViewVisitPatietSet.CurrentRow.Cells["Id"].Value.ToString()), ref str);

                    new ViewModel.VisitPatient.VisitPatient().DeleteEntity(VWP, ref str);
                    if (str != "") MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "امکان حذف مورد(های) انتخابی به علت داشتن عملکرد در نرم افزار وجود ندارد", str);
                    else
                        BindData(GridViewVisitPatietSet.Row - 1);
                }
                catch (System.Exception ex)
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "اشکال", ex.Message);
                }
            }
        }

        private void headerGridVisitPatient_btnRefreshClick(object sender, System.EventArgs e)
        {
            BindData(GridViewVisitPatietSet.Row);
        }

        #endregion

        bool SetDate = false;
        private void VisitPatient_UC_Load(object sender, System.EventArgs e)
        {
            buttonItemFiling.Enabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(221);
            ToolStripMenuItemStatusVisit.Enabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(218);
            buttonItemSendVisitPayment.Enabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(220);
            buttonItemSendSMS.Enabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(222);

            buttonItemVisitPatientPrintList.Enabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(305);

            ToolStripMenuItemVisitPatientCurrentRow.Enabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(258);
            ToolStripMenuItemVisitPatientAllList.Enabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(259);

            new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionControl(this);

            try
            {
                SetDate = false;
                DatePickerStart.Value = KagNetComponents2.KagPersianDate.Parse(System.DateTime.Now).AddDays(-30);
                DatePickerEnd.Value = DatePickerReciveFileDate.Value = KagNetComponents2.KagPersianDate.Parse(System.DateTime.Now);
                //ComboBoxSerach.SelectedIndex = 2;
                SetDate = true;
            }
            catch { }
            
            BindData(0);
        }


        private void buttonItemFiling_Click(object sender, System.EventArgs e)
        {
            try
            {
                string str = "";
                MKH.Library.Forms.MSSImageSelectorFiling_frm img = new MKH.Library.Forms.MSSImageSelectorFiling_frm(
                    System.Convert.ToInt32(GridViewVisitPatietSet.CurrentRow.Cells["Id"].Value),
                    new ViewModel.Setting.Setting().GetAllValue("FileSavingVisit", ref str)
                    );
                if (img.ShowDialog() == DialogResult.OK)
                {
                    //if (MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation, true, "آیا فایل ها برای ماه جدید ثبت شود؟"))
                    //{
                    //    //new ViewModel.VisitPatient.VisitPatient().UpdateLastReciveReport(
                    //    //    System.Convert.ToInt64(GridViewVisitPatient.CurrentRow.Cells["Id"].Value),
                    //    //    KagNetComponents2.KagPersianDate.Parse(GridViewVisitPatient.CurrentRow.Cells["LastReciveReportDate"].Value.ToString()).AddMonths(1).ToString(),
                    //    //    ref str);
                    //}

                    BindData(GridViewVisitPatietSet.Row);
                }
            }
            catch { }
        }

       
        

        private void buttonItemSendVisitPayment_Click(object sender, System.EventArgs e)
        {
            string str = "";

            for (int i = 0; i < GridViewVisitPatietSet.SelectedItems.Count; i++)
                if (new ViewModel.Basic.NODuplicateForm().CheckNODuplicateForm("TBL_VisitPatient", GridViewVisitPatietSet.SelectedItems[i].GetRow().Cells["Id"].Value.ToString(), ref str))
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View("امکان تغییرات به علت انجام عملیات توسط کاربر دیگر امکان پذیر نمی باشد. لطفا کمی بعد سعی کنید", MKH.Library.Clasess.MSSMessage.MessageType.SWarning);
                    return;
                }

            long IDSet = 0;

            if (MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation, true, "آیا ردیف های انتخابی جهت بیمه ارسال شوند؟"))
            {
                try
                {
                    double CostCompanyVisitPercent = System.Convert.ToDouble(new ViewModel.Setting.Setting().GetAllValue("CostCompanyVisitPercent", ref str).ToString());
                    int CostReqInsuVisitAdd = new ViewModel.Setting.Setting().GetAllValue("CostReqInsuVisitAdd", ref str).ToString().ToInt();
                    int CostReqInsuVisitEven = new ViewModel.Setting.Setting().GetAllValue("CostReqInsuVisitEven", ref str).ToString().ToInt();
                    double CostInsurancePercent = System.Convert.ToDouble(new ViewModel.Setting.Setting().GetAllValue("CostInsurancePercent", ref str));

                    List<TBL_VisitPatientPayment> Ls = new List<TBL_VisitPatientPayment>(1);
                    for (int i = 0; i < GridViewVisitPatietSet.SelectedItems.Count; i++)
                    {
                        if (short.Parse(GridViewVisitPatietSet.SelectedItems[i].GetRow().Cells["VisitStatus_Id"].Value.ToString()) == 2 || short.Parse(GridViewVisitPatietSet.SelectedItems[i].GetRow().Cells["VisitStatus_Id"].Value.ToString()) == 4) continue;
                        TBL_VisitPatientPayment VisitPatientPayment = new TBL_VisitPatientPayment();
                        VisitPatientPayment.Id = 0;
                        VisitPatientPayment.VisitPatient_Id = long.Parse(GridViewVisitPatietSet.SelectedItems[i].GetRow().Cells["Id"].Value.ToString());
                        VisitPatientPayment.Doctor_Id = int.Parse(GridViewVisitPatietSet.SelectedItems[i].GetRow().Cells["Doctor_Id"].Value.ToString());

                        VisitPatientPayment.PaymentDate = MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsi(System.DateTime.Now).Substring(0, 10);
                        VisitPatientPayment.PaymentType_Id = 1;
                        VisitPatientPayment.PaymentStatus_Id = 8;
                        VisitPatientPayment.PaymentStatusDate = MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsi(System.DateTime.Now).Substring(0, 10);

                        VisitPatientPayment.ReportCode = 0;
                        VisitPatientPayment.AnalyzePage = 0;

                        VisitPatientPayment.CostReqInsu = int.Parse(GridViewVisitPatietSet.SelectedItems[i].GetRow().Cells["BonyadAddEven"].Value.ToString()) == 0 ? CostReqInsuVisitAdd : CostReqInsuVisitEven;
                        VisitPatientPayment.CostCachInsu = VisitPatientPayment.CostReqInsu;

                        short DoctorTaxPercent = 0;
                        try { DoctorTaxPercent = new ViewModel.Doctors.Doctor().GetAllListByID(VisitPatientPayment.Doctor_Id.Value, ref str).Last().DoctorTaxPercent.Value; }
                        catch { }
                        // VisitPatientPayment.CostDoctorTax = DoctorTaxPercent != 0 ? VisitPatientPayment.CostCachInsu * DoctorTaxPercent / 100 : 0;

                        //VisitPatientPayment.CostCompany = (VisitPatientPayment.CostCachInsu * CostCompanyVisitPercent / 100).Value.ToString().ToInt();
                        //VisitPatientPayment.CostDoctor = VisitPatientPayment.CostCachInsu - VisitPatientPayment.CostCompany - VisitPatientPayment.CostDoctorTax;

                        VisitPatientPayment.CostCompany = Other.Class.Function_Cls.CalculateCostCompany(VisitPatientPayment.CostCachInsu.Value, CostCompanyVisitPercent);
                        VisitPatientPayment.CostDoctorTax = Other.Class.Function_Cls.CalculateTax(VisitPatientPayment.CostCachInsu.Value, VisitPatientPayment.CostCompany.Value, DoctorTaxPercent);
                        VisitPatientPayment.CostDoctorInsurance = Other.Class.Function_Cls.CalculateInsurance(VisitPatientPayment.CostCachInsu.Value, VisitPatientPayment.CostCompany.Value, CostInsurancePercent);
                        VisitPatientPayment.CostDoctorPrePayment = 0;
                        VisitPatientPayment.CostIncrease = 0;

                        VisitPatientPayment.CostDoctor = Other.Class.Function_Cls.CalculateCostDoctor(VisitPatientPayment.CostCachInsu.Value, VisitPatientPayment.CostCompany.Value, VisitPatientPayment.CostIncrease.Value, VisitPatientPayment.CostDoctorTax.Value, VisitPatientPayment.CostDoctorInsurance.Value, VisitPatientPayment.CostDoctorPrePayment.Value);

                        VisitPatientPayment.CostVisitDoctorBes = 0;
                        VisitPatientPayment.CostVisitDoctorRemind = 0;

                        VisitPatientPayment.User_Id = MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID;
                        VisitPatientPayment.ChangeDateTime = MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(System.DateTime.Now);

                        ViewModel.VisitPatient.VisitPatient RN = new ViewModel.VisitPatient.VisitPatient();
                        List<VW_VisitPatient> VPC = RN.GetAllListByID(long.Parse(GridViewVisitPatietSet.SelectedItems[i].GetRow().Cells["Id"].Value.ToString()), ref str);

                        VisitPatientPayment.Patient_Id = VPC[0].Patient_Id;
                        VisitPatientPayment.DosiersNo = VPC[0].DosiersNo ?? "";
                        VisitPatientPayment.PatientName = VPC[0].PatientName ?? "";
                        VisitPatientPayment.PatientFamily = VPC[0].PatientFamily ?? "";
                        VisitPatientPayment.ParentName = VPC[0].ParentName ?? "";
                        VisitPatientPayment.SexStr = VPC[0].SexStr ?? "";
                        VisitPatientPayment.IDNO = VPC[0].IDNO ?? "";
                        VisitPatientPayment.NationalCode = VPC[0].NationalCode ?? "";
                        VisitPatientPayment.PatientTypeStr = VPC[0].PatientTypeStr ?? "";
                        VisitPatientPayment.InjuryTypeStr = VPC[0].InjuryTypeStr ?? "";
                        VisitPatientPayment.BrithDate = VPC[0].BrithDate ?? "";
                        VisitPatientPayment.BrithCityName = VPC[0].BrithCityName ?? "";
                        VisitPatientPayment.PercentState = VPC[0].PercentState ?? 0;
                        VisitPatientPayment.SingleOrNo = VPC[0].SingleOrNo ?? "";
                        VisitPatientPayment.BonyadAddEvenStr = VPC[0].BonyadAddEvenStr ?? "";

                        VisitPatientPayment.BonyadDosier = VPC[0].BonyadDosier ?? "";
                        VisitPatientPayment.StatePart = VPC[0].StatePart ?? "";
                        VisitPatientPayment.CityState = VPC[0].CityState ?? "";

                        VisitPatientPayment.CityPart = VPC[0].CityPart ?? "";
                        VisitPatientPayment.InstitutePart = VPC[0].InstitutePart ?? 0;
                        VisitPatientPayment.AddressPart = VPC[0].AddressPart ?? 0;
                        VisitPatientPayment.Address = VPC[0].Address ?? "";
                        VisitPatientPayment.PostalCode = VPC[0].PostalCode ?? "";
                        VisitPatientPayment.TelHome = VPC[0].TelHome ?? "";
                        VisitPatientPayment.TelBusiness = VPC[0].TelBusiness ?? "";
                        VisitPatientPayment.Mobile = VPC[0].Mobile ?? "";
                        VisitPatientPayment.Mobile2 = VPC[0].Mobile2 ?? "";
                        VisitPatientPayment.Email = VPC[0].Email ?? "";
                        VisitPatientPayment.BasicInsurance = VPC[0].BasicInsurance ?? "";
                        VisitPatientPayment.CompletionInsurance = VPC[0].CompletionInsurance ?? "";
                        VisitPatientPayment.IssueArchive = VPC[0].IssueArchive ?? "";
                        VisitPatientPayment.LetterNo = VPC[0].LetterNo ?? "";
                        VisitPatientPayment.LetterDate = VPC[0].LetterDate ?? "";

                        VisitPatientPayment.VisitDate = VPC[0].VisitDate ?? "";
                        VisitPatientPayment.StateSicknessDsc = VPC[0].StateSicknessDsc ?? "";
                        VisitPatientPayment.ParaclinicDsc = VPC[0].ParaclinicDsc ?? "";
                        VisitPatientPayment.DrugsDsc = VPC[0].DrugsDsc ?? "";
                        VisitPatientPayment.BedsoreDsc = VPC[0].BedsoreDsc ?? "";
                        VisitPatientPayment.VaccinationDsc = VPC[0].VaccinationDsc ?? "";
                        VisitPatientPayment.EquipmentUseDsc = VPC[0].EquipmentUseDsc ?? "";

                        VisitPatientPayment.ContractNo = VPC[0].ContractNo ?? "";
                        VisitPatientPayment.ContractDate = VPC[0].ContractDate ?? "";
                        VisitPatientPayment.MedicalCode = VPC[0].MedicalCode ?? "";
                        VisitPatientPayment.DoctorName = VPC[0].DoctorName ?? "";
                        VisitPatientPayment.DoctorFamily = VPC[0].DoctorFamily ?? "";
                        VisitPatientPayment.DoctorNationalCode = VPC[0].DoctorsNationalCode ?? "";
                        VisitPatientPayment.DoctorBrithDate = VPC[0].DoctorsBrithDate ?? "";
                        VisitPatientPayment.LocationPart = VPC[0].LocationPart ?? "";
                        VisitPatientPayment.DoctorAddress = VPC[0].DoctorsAddress ?? "";
                        VisitPatientPayment.DoctorTelBusiness = VPC[0].DoctorsTelBusiness ?? "";
                        VisitPatientPayment.DoctorMobile = VPC[0].DoctorsMobile ?? "";
                        VisitPatientPayment.BankName = VPC[0].BankName ?? "";
                        VisitPatientPayment.CardBankNo1 = VPC[0].CardBankNo1 ?? "";
                        VisitPatientPayment.CardBankNo2 = VPC[0].CardBankNo2 ?? "";

                        Ls.Add(VisitPatientPayment);

                        //if (str == "")
                        //    new ViewModel.VisitPatient.VisitPatient().UpdateVisitStatus(long.Parse(GridViewVisitPatietSet.SelectedItems[i].GetRow().Cells["Id"].Value.ToString()), 2,
                        //        MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                        //        MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(System.DateTime.Now),
                        //        ref str);
                    }
                    long? f = 0;
                    new ViewModel.VisitPatient.VisitPatientPayment().InsertEntity(Ls, ref str, ref f);
                    BindData(GridViewVisitPatietSet.Row);
                }
                catch (System.Exception ex)
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "اشکال ارسال", ex.Message);
                }
            }
        }
        
        private void ToolStripMenuItemStatus_Click(object sender, System.EventArgs e)
        {
            PhysiotherapyCare.View.MainForms.AllStatus.AllStatusAdd_Frm asf = new
                    PhysiotherapyCare.View.MainForms.AllStatus.AllStatusAdd_Frm(System.Convert.ToInt64(GridViewVisitPatietSet.CurrentRow.Cells["Id"].Value));
            asf._systemTypeSet = PhysiotherapyCare.View.MainForms.AllStatus.AllStatusAdd_Frm.SystemType.VisitPatient;
            asf.ShowDialog();
        }



        private void RadioBoxAllContract_CheckValueChanged(object sender, System.EventArgs e)
        {
            if (SetDate && (sender as MKH.Library.Control.MSSCheckBox).Checked) BindData(GridViewVisitPatietSet.Row);
        }

        private void DatePickerStart_ValueChanged(object sender, KagNetComponents2.PersianMonthCalendarEventArgs e)
        {
            if (SetDate) BindData(GridViewVisitPatietSet.Row);
        }
        private void buttonItemSendSMS_Click(object sender, System.EventArgs e)
        {
            List<MKH.Library.Clasess.PublicClass.AllPersonForSMS> ListForSelectPerson = new List<MKH.Library.Clasess.PublicClass.AllPersonForSMS>();
            for (int i = 0; i < GridViewVisitPatietSet.SelectedItems.Count; i++)
            {
                if (((GridViewVisitPatietSet.SelectedItems[i].GetRow().Cells["DoctorsMobile"].Value ?? "").ToString().StartsWith("09") && (GridViewVisitPatietSet.SelectedItems[i].GetRow().Cells["DoctorsMobile"].Value ?? "").ToString().Length == 11))
                {
                    try
                    {
                        MKH.Library.Clasess.PublicClass.AllPersonForSMS ssss = new MKH.Library.Clasess.PublicClass.AllPersonForSMS();
                        ssss.PersonNameFamily = (GridViewVisitPatietSet.SelectedItems[i].GetRow().Cells["DoctorName"].Value ?? "").ToString() + " " +
                                                (GridViewVisitPatietSet.SelectedItems[i].GetRow().Cells["DoctorFamily"].Value ?? "").ToString();
                        ssss.JobType = "پزشک";
                        ssss.MobileNo1 = (GridViewVisitPatietSet.SelectedItems[i].GetRow().Cells["DoctorsMobile"].Value ?? "").ToString();
                        ssss.MobileNo2 = (GridViewVisitPatietSet.SelectedItems[i].GetRow().Cells["DoctorsTelHome"].Value ?? "").ToString() + " " + (GridViewVisitPatietSet.SelectedItems[i].GetRow().Cells["DoctorsTelBusiness"].Value ?? "").ToString();

                        ListForSelectPerson.Add(ssss);
                    }
                    catch { }
                }
            }
            ViewModel.PublicClass.FillForSMS();

            MKH.SMS.View.Forms.SendSMSAdd_Frm SSA = new MKH.SMS.View.Forms.SendSMSAdd_Frm(ListForSelectPerson);
            SSA.ShowDialog();
        }

        private void ButtonReciveFileDate_Click(object sender, System.EventArgs e)
        {
            string str = "";

            for (int i = 0; i < GridViewVisitPatietSet.SelectedItems.Count; i++)
                if (new ViewModel.Basic.NODuplicateForm().CheckNODuplicateForm("TBL_VisitPatient", GridViewVisitPatietSet.SelectedItems[i].GetRow().Cells["Id"].Value.ToString(), ref str))
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View("امکان تغییرات به علت انجام عملیات توسط کاربر دیگر امکان پذیر نمی باشد. لطفا کمی بعد سعی کنید", MKH.Library.Clasess.MSSMessage.MessageType.SWarning);
                    return;
                }
            long IDSet = 0;

            if (MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation, true, "تاریخ دریافت فایل جهت ردیف های انتخابی مشخص شود؟"))
            {
                try
                {
                    for (int i = 0; i < GridViewVisitPatietSet.SelectedItems.Count; i++)
                    {

                        IDSet = long.Parse(GridViewVisitPatietSet.SelectedItems[i].GetRow().Cells["Id"].Value.ToString());

                        new ViewModel.VisitPatient.VisitPatient().UpdateEntityWithFieldValue(
                        IDSet, "ReciveFileDate", DatePickerReciveFileDate.Value.ToString().Substring(0, 10),
                        MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                        MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(System.DateTime.Now), ref str);
                    }
                    BindData(GridViewVisitPatietSet.Row);
                }
                catch (System.Exception ex)
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View(ex.Message, MKH.Library.Clasess.MSSMessage.MessageType.SError);
                }
            }
        }

        private void ToolStripMenuItemVisitPatientCurrentRow_Click(object sender, System.EventArgs e)
        {
            try
            {
                string Str = "";
                int J = 0;

                MKH.Library.Forms.MSSLogViewer_frm ctrl = new MKH.Library.Forms.MSSLogViewer_frm();
                ctrl.GridexViewSelector.DataSource = new MKH.Permission.ViewModel.Log.Log().GetAllListVisitPatientByID(System.Convert.ToInt64(GridViewVisitPatietSet.CurrentRow.Cells["Id"].Value), ref Str).ToList();
                ctrl.ColumnList = new System.Data.DataTable();
                for (int i = 0; i < GridViewVisitPatietSet.RootTable.Columns.Count; i++)
                    if (GridViewVisitPatietSet.RootTable.Columns[i].Tag == "" || GridViewVisitPatietSet.RootTable.Columns[i].Tag == null)
                    {
                        ctrl.ColumnList.Columns.Add(GridViewVisitPatietSet.RootTable.Columns[i].Key);
                        ctrl.ColumnList.Columns[J].Caption = GridViewVisitPatietSet.RootTable.Columns[i].Caption;
                        J++;
                    }
                ctrl.ShowDialog();
            }
            catch { }
        }

        private void ToolStripMenuItemVisitPatientAllList_Click(object sender, System.EventArgs e)
        {
            try
            {
                string Str = "";
                int J = 0;

                MKH.Library.Forms.MSSLogViewer_frm ctrl = new MKH.Library.Forms.MSSLogViewer_frm();
                ctrl.GridexViewSelector.DataSource = new MKH.Permission.ViewModel.Log.Log().GetAllListVisitPatient(ref Str).ToList();
                ctrl.ColumnList = new System.Data.DataTable();
                for (int i = 0; i < GridViewVisitPatietSet.RootTable.Columns.Count; i++)
                    if (GridViewVisitPatietSet.RootTable.Columns[i].Visible)
                    {
                        ctrl.ColumnList.Columns.Add(GridViewVisitPatietSet.RootTable.Columns[i].Key);
                        ctrl.ColumnList.Columns[J].Caption = GridViewVisitPatietSet.RootTable.Columns[i].Caption;
                        J++;
                    }
                ctrl.ShowDialog();
            }
            catch { }
        }

        private void buttonItemVisitPatientPrintList_Click(object sender, System.EventArgs e)
        {
            string str = "";
            long IDSet = 0;

            if (!System.IO.File.Exists(MKH.Library.Clasess.PublicParam.AddressReportDesign + "\\Report\\VisitPatientDoctors_Rep.frx"))
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("فایل یافت نشد", MKH.Library.Clasess.MSSMessage.MessageType.SError);
                return;
            }
            List<QueryFilter.ExpressionBuilder.Filter> filter = new List<QueryFilter.ExpressionBuilder.Filter>();
            for (int i = 0; i < GridViewVisitPatietSet.SelectedItems.Count; i++)
            {
                IDSet = long.Parse(GridViewVisitPatietSet.SelectedItems[i].GetRow().Cells["Id"].Value.ToString());

                filter.Add(
                new QueryFilter.ExpressionBuilder.Filter
                {
                    PropertyName = "Id",
                    Operation = QueryFilter.ExpressionBuilder.Op.Equals,
                    Value = IDSet,
                    OperationFilter = QueryFilter.ExpressionBuilder.OpFilter.Or
                }
                );
            }
            FastReport.Report rpt = new FastReport.Report();

            //var gg1 = new ViewModel.VisitPatient.VisitPatient().GetAllListByFilterForReport(filter, ref str);
            var gg1 = new ViewModel.VisitPatient.VisitPatient().GetAllListByFilter(filter, ref str);
            rpt.Load(MKH.Library.Clasess.PublicParam.AddressReportDesign + "\\Report\\VisitPatientDoctors_Rep.frx");
            rpt.RegisterData(gg1, "VST_VW_VisitPatient");
            rpt.GetDataSource("VST_VW_VisitPatient").Enabled = true;
            rpt.Show();
            //rpt.Design();
        }


       
    }
}
