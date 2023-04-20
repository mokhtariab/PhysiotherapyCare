using System.Linq;
using System.Collections.Generic;
using PhysiotherapyCare.Model.Basic;
using PhysiotherapyCare.Model;
using MKH.Library.Clasess.FilterClass;
using System.Windows.Forms;
using PhysiotherapyCare.Model.VisitHealthCare;
using PhysiotherapyCare.View.MainForms.VisitHealthCare;

namespace PhysiotherapyCare.View.MainForms.VisitHealthCare
{
    public partial class VisitHealthCare_UC : UserControl
    {
        int _patientId = 0;
        public VisitHealthCare_UC()
        {
            InitializeComponent();
        }

        public VisitHealthCare_UC(int PatientId)
        {
            InitializeComponent();
            _patientId = PatientId;
        }

        public void BindData(int RowNumberSet)
        {
            string str = "";

            List<VW_VisitHealthCare> LSQ = new List<VW_VisitHealthCare>();

            if (_patientId == 0)
            {
                LSQ = new ViewModel.VisitHealthCare.VisitHealthCare().GetAllList(ref str);
            }
            else
            {
                //List<QueryFilter.ExpressionBuilder.Filter> filter = new List<QueryFilter.ExpressionBuilder.Filter>();
                //filter.Add(
                //new QueryFilter.ExpressionBuilder.Filter
                //{
                //    PropertyName = "Patient_Id",
                //    Operation = QueryFilter.ExpressionBuilder.Op.Equals,
                //    Value = _patientId,
                //    OperationFilter = QueryFilter.ExpressionBuilder.OpFilter.And
                //}
                //);
                //LSQ = new ViewModel.VisitHealthCare.VisitHealthCare().GetAllListByFilter(filter, ref str);
                LSQ = new ViewModel.VisitHealthCare.VisitHealthCare().GetAllList(ref str).Where(pp => pp.Patient_Id == _patientId).ToList();

            }

            if (RadioBoxVisitStatus1.Checked)
                LSQ = LSQ.Where(ei => ei.VisitStatus_Id == 1).ToList();
            if (RadioBoxVisitStatus2.Checked)
                LSQ = LSQ.Where(ei => ei.VisitStatus_Id == 2).ToList();
            if (RadioBoxVisitStatus4.Checked)
                LSQ = LSQ.Where(ei => ei.VisitStatus_Id == 4).ToList();

            if (RadioBoxContractWithTime.Checked)
            {
                if (ComboBoxSerach.SelectedIndex == 0)
                    LSQ = LSQ.Where(d => MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.LetterDate ?? "") >= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerStart.Value.ToString())
                        && MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.LetterDate ?? "") <= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerEnd.Value.ToString())).ToList();
                else if (ComboBoxSerach.SelectedIndex == 1)
                    LSQ = LSQ.Where(d => MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.ContractDate ?? "") >= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerStart.Value.ToString())
                        && MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.ContractDate ?? "") <= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerEnd.Value.ToString())).ToList();
                else if (ComboBoxSerach.SelectedIndex == 2)
                    LSQ = LSQ.Where(d => MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.RequestDate ?? "") >= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerStart.Value.ToString())
                        && MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.RequestDate ?? "") <= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerEnd.Value.ToString())).ToList();
                else if (ComboBoxSerach.SelectedIndex == 3)
                    LSQ = LSQ.Where(d => MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.HealthCareDate ?? "") >= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerStart.Value.ToString())
                        && MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.HealthCareDate ?? "") <= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerEnd.Value.ToString())).ToList();
            }

            GridViewVisitHealthCare.DataSource = LSQ;

            try { GridViewVisitHealthCare.Row = RowNumberSet; }
            catch { }
        }

        
        #region All UI Button

        private void headerGridVisitHealthCare_btnInsertClick(object sender, System.EventArgs e)
        {
            VisitHealthCareAdd_Frm VisitHealthCareAdd = null;
            if (_patientId != 0)
                VisitHealthCareAdd = new VisitHealthCareAdd_Frm(_patientId, "");
            else
                VisitHealthCareAdd = new VisitHealthCareAdd_Frm();

            if (VisitHealthCareAdd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                BindData(GridViewVisitHealthCare.RowCount);
        }

        private void headerGridVisitHealthCare_btnEditClick(object sender, System.EventArgs e)
        {
            try
            {
                //if (!(HeaderGridVisitHealthCare as MKH.Library.Control.MSSHeaderGrid).Items["buttonItemEdit"].Visible || !(HeaderGridVisitHealthCare as MKH.Library.Control.MSSHeaderGrid).Items["buttonItemEdit"].Enabled) return;

                if (short.Parse(GridViewVisitHealthCare.CurrentRow.Cells["VisitStatus_Id"].Value.ToString()) == 2)
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View("امکان ویرایش به دلیل ارسال به بیمه وجود ندارد", MKH.Library.Clasess.MSSMessage.MessageType.SWarning);
                    //return;
                }
                
                VisitHealthCareAdd_Frm VisitHealthCareAdd = new VisitHealthCareAdd_Frm(
                    int.Parse(GridViewVisitHealthCare.CurrentRow.Cells["Id"].Value.ToString()),
                    short.Parse(GridViewVisitHealthCare.CurrentRow.Cells["VisitStatus_Id"].Value.ToString()));
                if (VisitHealthCareAdd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    BindData(GridViewVisitHealthCare.Row);
            }
            catch { }
        }

        private void headerGridVisitHealthCare_btnDeleteClick(object sender, System.EventArgs e)
        {
            if (short.Parse(GridViewVisitHealthCare.CurrentRow.Cells["VisitStatus_Id"].Value.ToString()) == 2)
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("امکان حذف به دلیل ارسال به بیمه وجود ندارد", MKH.Library.Clasess.MSSMessage.MessageType.SWarning);
                return;
            }
            
            string str = "";
            if (new ViewModel.Basic.NODuplicateForm().CheckNODuplicateForm("TBL_VisitHealthCare", GridViewVisitHealthCare.CurrentRow.Cells["Id"].Value.ToString(), ref str))
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("امکان حذف به علت انجام عملیات توسط کاربر دیگر امکان پذیر نمی باشد", MKH.Library.Clasess.MSSMessage.MessageType.SWarning);
                return;
            }
            
            
            if (MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation, true, "آیا به حذف این مورد اطمینان دارید؟"))
            {
                try
                {
                    //List<TBL_VisitHealthCare> Ls = new List<TBL_VisitHealthCare>();
                    //TBL_VisitHealthCare VisitHealthCare = new TBL_VisitHealthCare();
                    //VisitHealthCare.Id = int.Parse(GridViewVisitHealthCare.CurrentRow.Cells["Id"].Value.ToString());
                    //VisitHealthCare.Patient_Id = int.Parse(GridViewVisitHealthCare.CurrentRow.Cells["Patient_Id"].Value.ToString());
                    //VisitHealthCare.Doctor_Id = int.Parse(GridViewVisitHealthCare.CurrentRow.Cells["Doctor_Id"].Value.ToString());
                    //VisitHealthCare.VisitStatus_Id = short.Parse(GridViewVisitHealthCare.CurrentRow.Cells["VisitStatus_Id"].Value.ToString());
                    //Ls.Add(VisitHealthCare);


                    ViewModel.VisitHealthCare.VisitHealthCare RN = new ViewModel.VisitHealthCare.VisitHealthCare();
                    List<TBL_VisitHealthCare> VWP = RN.GetAllListByTblID(int.Parse(GridViewVisitHealthCare.CurrentRow.Cells["Id"].Value.ToString()), ref str);

                    new ViewModel.VisitHealthCare.VisitHealthCare().DeleteEntity(VWP, ref str);
                    if (str != "") MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "امکان حذف مورد(های) انتخابی به علت داشتن عملکرد در نرم افزار وجود ندارد", str);
                    else
                        BindData(GridViewVisitHealthCare.Row - 1);
                }
                catch (System.Exception ex)
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "اشکال", ex.Message);
                }
            }
        }

        private void headerGridVisitHealthCare_btnRefreshClick(object sender, System.EventArgs e)
        {
            BindData(GridViewVisitHealthCare.Row);
        }

        #endregion

        bool SetDate = false;
        private void VisitHealthCare_UC_Load(object sender, System.EventArgs e)
        {
            buttonItemFiling.Enabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(134);
            ToolStripMenuItemStatusHealth.Enabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(135);
            buttonItemSendHealthPayment.Enabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(137);
            ButtonReciveFileDate.Enabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(200);
            buttonItemSendSMS.Enabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(206);

            ToolStripMenuItemVisitHealthCareCurrentRow.Enabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(264);
            ToolStripMenuItemVisitHealthCareAllList.Enabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(265);

            new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionControl(this);

            try
            {
                SetDate = false;
                DatePickerStart.Value = DatePickerEnd.Value = DatePickerReciveFileDate.Value = KagNetComponents2.KagPersianDate.Parse(System.DateTime.Now);
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
                    System.Convert.ToInt32(GridViewVisitHealthCare.CurrentRow.Cells["Id"].Value),
                    new ViewModel.Setting.Setting().GetAllValue("FileSavingHealth", ref str)
                    );
                if (img.ShowDialog() == DialogResult.OK)
                {
                    //if (MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation, true, "آیا فایل ها برای ماه جدید ثبت شود؟"))
                    //{
                    //    new ViewModel.VisitPatientCare.VisitPatientCare().UpdateLastReciveReport(
                    //        System.Convert.ToInt64(GridViewVisitPatientCare.CurrentRow.Cells["Id"].Value),
                    //        KagNetComponents2.KagPersianDate.Parse(GridViewVisitPatientCare.CurrentRow.Cells["LastReciveReportDate"].Value.ToString()).AddMonths(1).ToString(),
                    //        ref str);
                    //}

                    BindData(GridViewVisitHealthCare.Row);
                }
            }
            catch { }
        }

        //private void GridViewVisitHealthCare_BindingDataSourceSet(object sender, System.EventArgs e)
        //{
        //    BindData(GridViewVisitHealthCare.Row);
        //}

        private void buttonItemSendPhysioterapyPayment_Click(object sender, System.EventArgs e)
        {

            string str = "";

            for (int i = 0; i < GridViewVisitHealthCare.SelectedItems.Count; i++)
                if (new ViewModel.Basic.NODuplicateForm().CheckNODuplicateForm("TBL_VisitHealthCare", GridViewVisitHealthCare.SelectedItems[i].GetRow().Cells["Id"].Value.ToString(), ref str))
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View("امکان تغییرات به علت انجام عملیات توسط کاربر دیگر امکان پذیر نمی باشد. لطفا کمی بعد سعی کنید", MKH.Library.Clasess.MSSMessage.MessageType.SWarning);
                    return;
                }

            long IDSet = 0;

            if (MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation, true, "آیا ردیف های انتخابی جهت بیمه ارسال شوند؟"))
            {
                try
                {
                    double CostCompanyHealthPercent = System.Convert.ToDouble(new ViewModel.Setting.Setting().GetAllValue("CostCompanyHealthPercent", ref str));
                    double CostInsurancePercent = System.Convert.ToDouble(new ViewModel.Setting.Setting().GetAllValue("CostInsurancePercent", ref str));


                    List<TBL_VisitHealthCarePayment> Ls = new List<TBL_VisitHealthCarePayment>(1);
                    for (int i = 0; i < GridViewVisitHealthCare.SelectedItems.Count; i++)
                    {
                        if (short.Parse(GridViewVisitHealthCare.SelectedItems[i].GetRow().Cells["VisitStatus_Id"].Value.ToString()) == 2 ||
                            short.Parse(GridViewVisitHealthCare.SelectedItems[i].GetRow().Cells["VisitStatus_Id"].Value.ToString()) == 4) continue;
                        TBL_VisitHealthCarePayment VisitHealthCarePayment = new TBL_VisitHealthCarePayment();
                        VisitHealthCarePayment.Id = 0;
                        VisitHealthCarePayment.VisitHealthCare_Id = long.Parse(GridViewVisitHealthCare.SelectedItems[i].GetRow().Cells["Id"].Value.ToString());

                        VisitHealthCarePayment.Doctor_Id = int.Parse(GridViewVisitHealthCare.SelectedItems[i].GetRow().Cells["Doctor_Id"].Value.ToString());

                        VisitHealthCarePayment.PaymentDate = MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsi(System.DateTime.Now).Substring(0, 10);
                        VisitHealthCarePayment.PaymentType_Id = 1;
                        VisitHealthCarePayment.PaymentStatus_Id = 8;
                        VisitHealthCarePayment.PaymentStatusDate = MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsi(System.DateTime.Now).Substring(0, 10);

                        VisitHealthCarePayment.CostReqInsu = new ViewModel.VisitHealthCare.ServiceHealthCare().SumServiceHealthCare(VisitHealthCarePayment.VisitHealthCare_Id.Value);
                        VisitHealthCarePayment.CostCachInsu = VisitHealthCarePayment.CostReqInsu;


                        double DoctorTaxPercent = 0;
                        try { DoctorTaxPercent = new ViewModel.Doctors.Doctor().GetAllListByID(VisitHealthCarePayment.Doctor_Id.Value, ref str).Last().DoctorTaxPercent.Value; }
                        catch { }

                        
                        VisitHealthCarePayment.CostCompany = Other.Class.Function_Cls.CalculateCostCompany(VisitHealthCarePayment.CostCachInsu.Value, CostCompanyHealthPercent);
                        VisitHealthCarePayment.CostDoctorTax = Other.Class.Function_Cls.CalculateTax(VisitHealthCarePayment.CostCachInsu.Value, VisitHealthCarePayment.CostCompany.Value, DoctorTaxPercent);
                            //DoctorTaxPercent != 0 ? VisitHealthCarePayment.CostCachInsu * DoctorTaxPercent / 100 : 0;
                        VisitHealthCarePayment.CostDoctorInsurance = Other.Class.Function_Cls.CalculateInsurance(VisitHealthCarePayment.CostCachInsu.Value, VisitHealthCarePayment.CostCompany.Value, CostInsurancePercent);
                        VisitHealthCarePayment.CostDoctorPrePayment = 0;
                        VisitHealthCarePayment.CostIncrease = 0;

                        VisitHealthCarePayment.CostDoctor = Other.Class.Function_Cls.CalculateCostDoctor(VisitHealthCarePayment.CostCachInsu.Value, VisitHealthCarePayment.CostCompany.Value, VisitHealthCarePayment.CostIncrease.Value, VisitHealthCarePayment.CostDoctorTax.Value, VisitHealthCarePayment.CostDoctorInsurance.Value, VisitHealthCarePayment.CostDoctorPrePayment.Value);
                            //VisitHealthCarePayment.CostCachInsu - VisitHealthCarePayment.CostCompany - VisitHealthCarePayment.CostDoctorTax;

                        VisitHealthCarePayment.CostVisitDoctorBes = 0;
                        VisitHealthCarePayment.CostVisitDoctorRemind = 0;

                        VisitHealthCarePayment.User_Id = MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID;
                        VisitHealthCarePayment.ChangeDateTime = MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(System.DateTime.Now);


                        ViewModel.VisitHealthCare.VisitHealthCare RN = new ViewModel.VisitHealthCare.VisitHealthCare();
                        List<VW_VisitHealthCare> VPC = RN.GetAllListByID(long.Parse(GridViewVisitHealthCare.SelectedItems[i].GetRow().Cells["Id"].Value.ToString()), ref str);

                        VisitHealthCarePayment.Patient_Id = VPC[0].Patient_Id;
                        VisitHealthCarePayment.DosiersNo = VPC[0].DosiersNo ?? "";
                        VisitHealthCarePayment.PatientName = VPC[0].PatientName ?? "";
                        VisitHealthCarePayment.PatientFamily = VPC[0].PatientFamily ?? "";
                        VisitHealthCarePayment.ParentName = VPC[0].ParentName ?? "";
                        VisitHealthCarePayment.SexStr = VPC[0].SexStr ?? "";
                        VisitHealthCarePayment.IDNO = VPC[0].IDNO ?? "";
                        VisitHealthCarePayment.NationalCode = VPC[0].NationalCode ?? "";
                        VisitHealthCarePayment.PatientTypeStr = VPC[0].PatientTypeStr ?? "";
                        VisitHealthCarePayment.InjuryTypeStr = VPC[0].InjuryTypeStr ?? "";
                        VisitHealthCarePayment.BrithDate = VPC[0].BrithDate ?? "";
                        VisitHealthCarePayment.BrithCityName = VPC[0].BrithCityName ?? "";
                        VisitHealthCarePayment.PercentState = VPC[0].PercentState ?? 0;
                        VisitHealthCarePayment.SingleOrNo = VPC[0].SingleOrNo ?? "";
                        VisitHealthCarePayment.BonyadAddEvenStr = VPC[0].BonyadAddEvenStr ?? "";
                        
                        VisitHealthCarePayment.BonyadDosier = VPC[0].BonyadDosier ?? "";
                        VisitHealthCarePayment.StatePart = VPC[0].StatePart ?? "";
                        VisitHealthCarePayment.CityState = VPC[0].CityState ?? "";
                        
                        VisitHealthCarePayment.CityPart = VPC[0].CityPart ?? "";
                        VisitHealthCarePayment.InstitutePart = VPC[0].InstitutePart ?? 0;
                        VisitHealthCarePayment.AddressPart = VPC[0].AddressPart ?? 0;
                        VisitHealthCarePayment.Address = VPC[0].Address ?? "";
                        VisitHealthCarePayment.PostalCode = VPC[0].PostalCode ?? "";
                        VisitHealthCarePayment.TelHome = VPC[0].TelHome ?? "";
                        VisitHealthCarePayment.TelBusiness = VPC[0].TelBusiness ?? "";
                        VisitHealthCarePayment.Mobile = VPC[0].Mobile ?? "";
                        VisitHealthCarePayment.Mobile2 = VPC[0].Mobile2 ?? "";
                        VisitHealthCarePayment.Email = VPC[0].Email ?? "";
                        VisitHealthCarePayment.BasicInsurance = VPC[0].BasicInsurance ?? "";
                        VisitHealthCarePayment.CompletionInsurance = VPC[0].CompletionInsurance ?? "";
                        VisitHealthCarePayment.IssueArchive = VPC[0].IssueArchive ?? "";
                        VisitHealthCarePayment.LetterNo = VPC[0].LetterNo ?? "";
                        VisitHealthCarePayment.LetterDate = VPC[0].LetterDate ?? "";
                        VisitHealthCarePayment.RequestDate = VPC[0].RequestDate ?? "";
                        VisitHealthCarePayment.PatientProblem = VPC[0].PatientProblem ?? "";
                        VisitHealthCarePayment.HealthCareDate = VPC[0].HealthCareDate ?? "";
                        VisitHealthCarePayment.SumServiceHealthCare = VPC[0].SumServiceHealthCare ?? 0;
                        VisitHealthCarePayment.SumServiceTypeDscFewHealthCare = VPC[0].SumServiceTypeDscFewHealthCare ?? 0;
                        VisitHealthCarePayment.ContractNo = VPC[0].ContractNo ?? "";
                        VisitHealthCarePayment.ContractDate = VPC[0].ContractDate ?? "";
                        VisitHealthCarePayment.MedicalCode = VPC[0].MedicalCode ?? "";
                        VisitHealthCarePayment.DoctorName = VPC[0].DoctorName ?? "";
                        VisitHealthCarePayment.DoctorFamily = VPC[0].DoctorFamily ?? "";
                        VisitHealthCarePayment.DoctorNationalCode = VPC[0].DoctorsNationalCode ?? "";
                        VisitHealthCarePayment.DoctorBrithDate = VPC[0].DoctorsBrithDate ?? "";
                        VisitHealthCarePayment.LocationPart = VPC[0].LocationPart ?? "";
                        VisitHealthCarePayment.DoctorAddress = VPC[0].DoctorsAddress ?? "";
                        VisitHealthCarePayment.DoctorTelBusiness = VPC[0].DoctorsTelBusiness ?? "";
                        VisitHealthCarePayment.DoctorMobile = VPC[0].DoctorsMobile ?? "";
                        VisitHealthCarePayment.BankName = VPC[0].BankName ?? "";
                        VisitHealthCarePayment.CardBankNo1 = VPC[0].CardBankNo1 ?? "";
                        VisitHealthCarePayment.CardBankNo2 = VPC[0].CardBankNo2 ?? "";



                        Ls.Add(VisitHealthCarePayment);

                        //new ViewModel.VisitHealthCare.VisitHealthCare().UpdateVisitStatus(long.Parse(GridViewVisitHealthCare.SelectedItems[i].GetRow().Cells["Id"].Value.ToString()), 2,
                        //    MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                        //    MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(System.DateTime.Now),
                        //    ref str);
                    }
                    long? f = 0;
                    new ViewModel.VisitHealthCare.VisitHealthCarePayment().InsertEntity(Ls, ref str, ref f);
                    BindData(GridViewVisitHealthCare.Row);
                }
                catch (System.Exception ex)
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View(ex.Message, MKH.Library.Clasess.MSSMessage.MessageType.SError);
                }
            }
        }

        private void ToolStripMenuItemStatus_Click(object sender, System.EventArgs e)
        {
            PhysiotherapyCare.View.MainForms.AllStatus.AllStatusAdd_Frm asf = new
                    PhysiotherapyCare.View.MainForms.AllStatus.AllStatusAdd_Frm(System.Convert.ToInt64(GridViewVisitHealthCare.CurrentRow.Cells["Id"].Value));
            asf._systemTypeSet = PhysiotherapyCare.View.MainForms.AllStatus.AllStatusAdd_Frm.SystemType.Health;
            asf.ShowDialog();
        }

       

        private void ComboBoxSerach_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            BindData(GridViewVisitHealthCare.Row);
        }

        private void DatePickerStart_ValueChanged(object sender, KagNetComponents2.PersianMonthCalendarEventArgs e)
        {
            if (SetDate) BindData(GridViewVisitHealthCare.Row);
        }

        private void buttonItemSendSMS_Click(object sender, System.EventArgs e)
        {
            List<MKH.Library.Clasess.PublicClass.AllPersonForSMS> ListForSelectPerson = new List<MKH.Library.Clasess.PublicClass.AllPersonForSMS>();
            for (int i = 0; i < GridViewVisitHealthCare.SelectedItems.Count; i++)
            {
                if (((GridViewVisitHealthCare.SelectedItems[i].GetRow().Cells["DoctorsMobile"].Value ?? "").ToString().StartsWith("09") && (GridViewVisitHealthCare.SelectedItems[i].GetRow().Cells["DoctorsMobile"].Value ?? "").ToString().Length == 11))
                {
                    try
                    {
                        MKH.Library.Clasess.PublicClass.AllPersonForSMS ssss = new MKH.Library.Clasess.PublicClass.AllPersonForSMS();
                        ssss.PersonNameFamily = (GridViewVisitHealthCare.SelectedItems[i].GetRow().Cells["DoctorName"].Value ?? "").ToString() + " " +
                                                (GridViewVisitHealthCare.SelectedItems[i].GetRow().Cells["DoctorFamily"].Value ?? "").ToString();
                        ssss.JobType = "بهیار";
                        ssss.MobileNo1 = (GridViewVisitHealthCare.SelectedItems[i].GetRow().Cells["DoctorsMobile"].Value ?? "").ToString();
                        ssss.MobileNo2 = (GridViewVisitHealthCare.SelectedItems[i].GetRow().Cells["DoctorsTelHome"].Value ?? "").ToString() + " " + (GridViewVisitHealthCare.SelectedItems[i].GetRow().Cells["DoctorsTelBusiness"].Value ?? "").ToString();

                        ListForSelectPerson.Add(ssss);
                    }
                    catch { }
                }
            }
            ViewModel.PublicClass.FillForSMS();

            MKH.SMS.View.Forms.SendSMSAdd_Frm SSA = new MKH.SMS.View.Forms.SendSMSAdd_Frm(ListForSelectPerson);
            SSA.ShowDialog();
        }

        private void GridViewVisitHealthCare_SelectionChanged(object sender, System.EventArgs e)
        {
            try { serviceHealthCare_UC1.BindData(System.Convert.ToInt32(GridViewVisitHealthCare.CurrentRow.Cells["Id"].Value)); }
            catch { }
        }

        private void ButtonDateReciveFile_Click(object sender, System.EventArgs e)
        {
            string str = "";

            for (int i = 0; i < GridViewVisitHealthCare.SelectedItems.Count; i++)
                if (new ViewModel.Basic.NODuplicateForm().CheckNODuplicateForm("TBL_VisitHealthCare", GridViewVisitHealthCare.SelectedItems[i].GetRow().Cells["Id"].Value.ToString(), ref str))
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View("امکان تغییرات به علت انجام عملیات توسط کاربر دیگر امکان پذیر نمی باشد. لطفا کمی بعد سعی کنید", MKH.Library.Clasess.MSSMessage.MessageType.SWarning);
                    return;
                }

            long IDSet = 0;

            if (MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation, true, "تاریخ دریافت فایل جهت ردیف های انتخابی مشخص شود؟"))
            {
                try
                {
                    for (int i = 0; i < GridViewVisitHealthCare.SelectedItems.Count; i++)
                    {

                        IDSet = long.Parse(GridViewVisitHealthCare.SelectedItems[i].GetRow().Cells["Id"].Value.ToString());

                        new ViewModel.VisitHealthCare.VisitHealthCare().UpdateEntityWithFieldValue(
                        IDSet, "ReciveFileDate", DatePickerReciveFileDate.Value.ToString().Substring(0, 10),
                        MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                        MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(System.DateTime.Now), ref str);
                    }
                    BindData(GridViewVisitHealthCare.Row);
                }
                catch (System.Exception ex)
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View(ex.Message, MKH.Library.Clasess.MSSMessage.MessageType.SError);
                }
            }
        }

        private void ToolStripMenuItemVisitHealthCareCurrentRow_Click(object sender, System.EventArgs e)
        {
            try
            {
                string Str = "";
                int J = 0;

                MKH.Library.Forms.MSSLogViewer_frm ctrl = new MKH.Library.Forms.MSSLogViewer_frm();
                ctrl.GridexViewSelector.DataSource = new MKH.Permission.ViewModel.Log.Log().GetAllListVisitHealthCareByID(System.Convert.ToInt64(GridViewVisitHealthCare.CurrentRow.Cells["Id"].Value), ref Str).ToList();
                ctrl.ColumnList = new System.Data.DataTable();
                for (int i = 0; i < GridViewVisitHealthCare.RootTable.Columns.Count; i++)
                    if (GridViewVisitHealthCare.RootTable.Columns[i].Tag == "" || GridViewVisitHealthCare.RootTable.Columns[i].Tag == null)
                    {
                        ctrl.ColumnList.Columns.Add(GridViewVisitHealthCare.RootTable.Columns[i].Key);
                        ctrl.ColumnList.Columns[J].Caption = GridViewVisitHealthCare.RootTable.Columns[i].Caption;
                        J++;
                    }
                ctrl.ShowDialog();
            }
            catch { }
        }

        private void ToolStripMenuItemVisitHealthCareAllList_Click(object sender, System.EventArgs e)
        {
            try
            {
                string Str = "";
                int J = 0;

                MKH.Library.Forms.MSSLogViewer_frm ctrl = new MKH.Library.Forms.MSSLogViewer_frm();
                ctrl.GridexViewSelector.DataSource = new MKH.Permission.ViewModel.Log.Log().GetAllListVisitHealthCare(ref Str).ToList();
                ctrl.ColumnList = new System.Data.DataTable();
                for (int i = 0; i < GridViewVisitHealthCare.RootTable.Columns.Count; i++)
                    if (GridViewVisitHealthCare.RootTable.Columns[i].Visible)
                    {
                        ctrl.ColumnList.Columns.Add(GridViewVisitHealthCare.RootTable.Columns[i].Key);
                        ctrl.ColumnList.Columns[J].Caption = GridViewVisitHealthCare.RootTable.Columns[i].Caption;
                        J++;
                    }
                ctrl.ShowDialog();
            }
            catch { }
        }
       
    }
}
