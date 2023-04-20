using System.Linq;
using System.Collections.Generic;
using PhysiotherapyCare.Model.Basic;
using PhysiotherapyCare.Model;
using MKH.Library.Clasess.FilterClass;
using System.Windows.Forms;
using PhysiotherapyCare.Model.VisitPatientPhysiotherapy;
using PhysiotherapyCare.View.MainForms.VisitPatientPhysiotherapy;

namespace PhysiotherapyCare.View.MainForms.VisitPatientPhysiotherapy
{
    public partial class VisitPatientPhysiotherapy_UC : UserControl
    {
        int _patientId = 0;
        public VisitPatientPhysiotherapy_UC()
        {
            InitializeComponent();
        }

        public VisitPatientPhysiotherapy_UC(int PatientId)
        {
            InitializeComponent();
            _patientId = PatientId;
        }

        public void BindData(int RowNumberSet)
        {
            string str = "";

            List<VW_VisitPatientPhysiotherapy> LSQ = new List<VW_VisitPatientPhysiotherapy>();

            if (_patientId == 0)
                LSQ = new ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapy().GetAllList(ref str);
            else
                LSQ = new ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapy().GetAllList(ref str).Where(pp => pp.Patient_Id == _patientId).ToList();

            //{
            //    List<QueryFilter.ExpressionBuilder.Filter> filter = new List<QueryFilter.ExpressionBuilder.Filter>();
            //    filter.Add(
            //    new QueryFilter.ExpressionBuilder.Filter
            //    {
            //        PropertyName = "Patient_Id",
            //        Operation = QueryFilter.ExpressionBuilder.Op.Equals,
            //        Value = _patientId,
            //        OperationFilter = QueryFilter.ExpressionBuilder.OpFilter.And
            //    }
            //    );
            //    LSQ = new ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapy().GetAllListByFilter(filter, ref str);
            //}

            if (RadioBoxVisitStatus1.Checked)
                LSQ = LSQ.Where(ei => ei.VisitStatus_Id == 1).ToList();
            if (RadioBoxVisitStatus2.Checked)
                LSQ = LSQ.Where(ei => ei.VisitStatus_Id == 2).ToList();
            if (RadioBoxVisitStatus4.Checked)
                LSQ = LSQ.Where(ei => ei.VisitStatus_Id == 4).ToList();
            if (RadioBoxContractWithTime.Checked)
            {
                try
                {
                    if (ComboBoxSerach.SelectedIndex == 0)
                        LSQ = LSQ.Where(d => MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.LetterDate ?? "") >= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerStart.Value.ToString())
                            && MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.LetterDate ?? "") <= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerEnd.Value.ToString())).ToList();
                    else if (ComboBoxSerach.SelectedIndex == 1)
                        LSQ = LSQ.Where(d => MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.ContractDate ?? "") >= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerStart.Value.ToString())
                            && MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.ContractDate ?? "") <= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerEnd.Value.ToString())).ToList();
                    else if (ComboBoxSerach.SelectedIndex == 2)
                        LSQ = LSQ.Where(d => MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.CordinateDate ?? "") >= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerStart.Value.ToString())
                            && MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.CordinateDate ?? "") <= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerEnd.Value.ToString())).ToList();
                    else if (ComboBoxSerach.SelectedIndex == 3)
                        LSQ = LSQ.Where(d => MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.BeginDate ?? "") >= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerStart.Value.ToString())
                            && MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.BeginDate ?? "") <= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerEnd.Value.ToString())).ToList();
                    else if (ComboBoxSerach.SelectedIndex == 4)
                        LSQ = LSQ.Where(d => MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.EndDate ?? "") >= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerStart.Value.ToString())
                            && MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.EndDate ?? "") <= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerEnd.Value.ToString())).ToList();
                }
                catch { }
            }

            GridViewVisitPatientPhysiotherapy.DataSource = LSQ;

            try { GridViewVisitPatientPhysiotherapy.Row = RowNumberSet; }
            catch { }

        }

        
        #region All UI Button

        private void headerGridVisitPatientPhysiotherapy_btnInsertClick(object sender, System.EventArgs e)
        {
            VisitPatientPhysiotherapyAdd_Frm VisitPatientPhysiotherapyAdd = null;
            if (_patientId != 0)
                VisitPatientPhysiotherapyAdd = new VisitPatientPhysiotherapyAdd_Frm(_patientId, "");
            else
                VisitPatientPhysiotherapyAdd = new VisitPatientPhysiotherapyAdd_Frm();

            if (VisitPatientPhysiotherapyAdd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                BindData(GridViewVisitPatientPhysiotherapy.RowCount);
        }

        private void headerGridVisitPatientPhysiotherapy_btnEditClick(object sender, System.EventArgs e)
        {
            try
            {
                //if (!(HeaderGridVisitPatientPhysiotherapy as MKH.Library.Control.MSSHeaderGrid).Items["buttonItemEdit"].Visible || !(HeaderGridVisitPatientPhysiotherapy as MKH.Library.Control.MSSHeaderGrid).Items["buttonItemEdit"].Enabled) return;

                if (short.Parse(GridViewVisitPatientPhysiotherapy.CurrentRow.Cells["VisitStatus_Id"].Value.ToString()) == 2)
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View("امکان ویرایش به دلیل ارسال به بیمه وجود ندارد", MKH.Library.Clasess.MSSMessage.MessageType.SWarning);
                   // return;
                }
                
                VisitPatientPhysiotherapyAdd_Frm VisitPatientPhysiotherapyAdd = new VisitPatientPhysiotherapyAdd_Frm(
                    int.Parse(GridViewVisitPatientPhysiotherapy.CurrentRow.Cells["Id"].Value.ToString()),
                    short.Parse(GridViewVisitPatientPhysiotherapy.CurrentRow.Cells["VisitStatus_Id"].Value.ToString()));
                if (VisitPatientPhysiotherapyAdd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    BindData(GridViewVisitPatientPhysiotherapy.Row);
            }
            catch { }
        }

        private void headerGridVisitPatientPhysiotherapy_btnDeleteClick(object sender, System.EventArgs e)
        {
            if (short.Parse(GridViewVisitPatientPhysiotherapy.CurrentRow.Cells["VisitStatus_Id"].Value.ToString()) == 2)
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("امکان حذف به دلیل ارسال به بیمه وجود ندارد", MKH.Library.Clasess.MSSMessage.MessageType.SWarning);
                return;
            }

            string str = "";

            if (new ViewModel.Basic.NODuplicateForm().CheckNODuplicateForm("TBL_VisitPatientPhysiotherapy", GridViewVisitPatientPhysiotherapy.CurrentRow.Cells["Id"].Value.ToString(), ref str))
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("امکان حذف به علت انجام عملیات توسط کاربر دیگر امکان پذیر نمی باشد", MKH.Library.Clasess.MSSMessage.MessageType.SWarning);
                return;
            }
            
            if (MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation, true, "آیا به حذف این مورد اطمینان دارید؟"))
            {
                try
                {
                    //List<TBL_VisitPatientPhysiotherapy> Ls = new List<TBL_VisitPatientPhysiotherapy>();
                    //TBL_VisitPatientPhysiotherapy VisitPatientPhysiotherapy = new TBL_VisitPatientPhysiotherapy();
                    //VisitPatientPhysiotherapy.Id = int.Parse(GridViewVisitPatientPhysiotherapy.CurrentRow.Cells["Id"].Value.ToString());
                    
                    //VisitPatientPhysiotherapy.Patient_Id = int.Parse(GridViewVisitPatientPhysiotherapy.CurrentRow.Cells["Patient_Id"].Value.ToString());
                    //VisitPatientPhysiotherapy.Doctor_Id = int.Parse(GridViewVisitPatientPhysiotherapy.CurrentRow.Cells["Doctor_Id"].Value.ToString());
                    //VisitPatientPhysiotherapy.DoctorPhysio_Id = int.Parse(GridViewVisitPatientPhysiotherapy.CurrentRow.Cells["DoctorPhysio_Id"].Value.ToString());
                    //VisitPatientPhysiotherapy.VisitStatus_Id = short.Parse(GridViewVisitPatientPhysiotherapy.CurrentRow.Cells["VisitStatus_Id"].Value.ToString());
                    
                    //Ls.Add(VisitPatientPhysiotherapy);



                    ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapy RN = new ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapy();
                    List<TBL_VisitPatientPhysiotherapy> VWP = RN.GetAllListByTblID(int.Parse(GridViewVisitPatientPhysiotherapy.CurrentRow.Cells["Id"].Value.ToString()), ref str);
                    
                    new ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapy().DeleteEntity(VWP, ref str);
                    if (str != "") MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "امکان حذف مورد(های) انتخابی به علت داشتن عملکرد در نرم افزار وجود ندارد", str);
                    else
                        BindData(GridViewVisitPatientPhysiotherapy.Row - 1);
                }
                catch (System.Exception ex)
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "اشکال", ex.Message);
                }
            }
        }

        private void headerGridVisitPatientPhysiotherapy_btnRefreshClick(object sender, System.EventArgs e)
        {
            BindData(GridViewVisitPatientPhysiotherapy.Row);
        }

        #endregion
        
        bool SetDate = false;
        private void VisitPatientPhysiotherapy_UC_Load(object sender, System.EventArgs e)
        {
            buttonItemFiling.Enabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(57);
            ToolStripMenuItemStatusPhysioterapy.Enabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(58);
            buttonItemSendPhysioterapyPayment.Enabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(127);
            ButtonReciveFileDate.Enabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(198);
            buttonItemSendSMS.Enabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(208);
            ToolStripMenuItemVisitPatientPhysiotherapyCurrentRow.Enabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(277);
            ToolStripMenuItemVisitPatientPhysiotherapyAllList.Enabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(278);

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
                    System.Convert.ToInt32(GridViewVisitPatientPhysiotherapy.CurrentRow.Cells["Id"].Value),
                    new ViewModel.Setting.Setting().GetAllValue("FileSavingPhysiotherapy", ref str)
                    );
                if (img.ShowDialog() == DialogResult.OK)
                {
                    //if (MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation, true, "آیا فایل ها برای ماه جدید ثبت شود؟"))
                    //{
                    //    new ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapy().UpdateLastReciveReport(
                    //        System.Convert.ToInt64(GridViewVisitPatientPhysiotherapy.CurrentRow.Cells["Id"].Value),
                    //        KagNetComponents2.KagPersianDate.Parse(GridViewVisitPatientPhysiotherapy.CurrentRow.Cells["LastReciveReportDate"].Value.ToString()).AddMonths(1).ToString(),
                    //        ref str);
                    //}

                    BindData(GridViewVisitPatientPhysiotherapy.Row);
                }
            }
            catch { }
        }


        private void buttonItemSendPhysioterapyPayment_Click(object sender, System.EventArgs e)
        {

            string str = "";
            long IDSet = 0;
            for (int i = 0; i < GridViewVisitPatientPhysiotherapy.SelectedItems.Count; i++)
                if (new ViewModel.Basic.NODuplicateForm().CheckNODuplicateForm("TBL_VisitPatientPhysiotherapy", GridViewVisitPatientPhysiotherapy.SelectedItems[i].GetRow().Cells["Id"].Value.ToString(), ref str))
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View("امکان تغییرات به علت انجام عملیات توسط کاربر دیگر امکان پذیر نمی باشد. لطفا کمی بعد سعی کنید", MKH.Library.Clasess.MSSMessage.MessageType.SWarning);
                    return;
                }

            if (MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation, true, "آیا ردیف های انتخابی جهت بیمه ارسال شوند؟"))
            {
                try
                {
                    //int CostCompanyPhsiotraphyPercent = new ViewModel.Setting.Setting().GetAllValue("CostCompanyPhsiotraphyPercent", ref str).ToString().ToInt();
                    int CostReqInsuPhsiotraphy = new ViewModel.Setting.Setting().GetAllValue("CostReqInsuPhsiotraphy", ref str).ToString().ToInt();
                    double CostCompanyPhsiotraphyPercent = System.Convert.ToDouble(new ViewModel.Setting.Setting().GetAllValue("CostCompanyPhsiotraphyPercent", ref str));
                    double CostInsurancePercent = System.Convert.ToDouble(new ViewModel.Setting.Setting().GetAllValue("CostInsurancePercent", ref str));


                    List<TBL_VisitPatientPhysiotherapyPayment> Ls = new List<TBL_VisitPatientPhysiotherapyPayment>(1);
                    for (int i = 0; i < GridViewVisitPatientPhysiotherapy.SelectedItems.Count; i++)
                    {
                        if (short.Parse(GridViewVisitPatientPhysiotherapy.SelectedItems[i].GetRow().Cells["VisitStatus_Id"].Value.ToString()) == 2 || short.Parse(GridViewVisitPatientPhysiotherapy.SelectedItems[i].GetRow().Cells["VisitStatus_Id"].Value.ToString()) == 4) continue;
                        TBL_VisitPatientPhysiotherapyPayment VisitPatientPhysiotherapyPayment = new TBL_VisitPatientPhysiotherapyPayment();
                        VisitPatientPhysiotherapyPayment.Id = 0;
                        VisitPatientPhysiotherapyPayment.VisitPatientPhysiotherapy_Id = long.Parse(GridViewVisitPatientPhysiotherapy.SelectedItems[i].GetRow().Cells["Id"].Value.ToString());
                        VisitPatientPhysiotherapyPayment.VisitFew = short.Parse(GridViewVisitPatientPhysiotherapy.SelectedItems[i].GetRow().Cells["VisitFewDoing"].Value.ToString());

                        VisitPatientPhysiotherapyPayment.BeginDate = GridViewVisitPatientPhysiotherapy.SelectedItems[i].GetRow().Cells["BeginDate"].Value.ToString();
                        VisitPatientPhysiotherapyPayment.EndDate = GridViewVisitPatientPhysiotherapy.SelectedItems[i].GetRow().Cells["EndDate"].Value.ToString();
                        VisitPatientPhysiotherapyPayment.Doctor_Id = int.Parse(GridViewVisitPatientPhysiotherapy.SelectedItems[i].GetRow().Cells["Doctor_Id"].Value.ToString());

                        VisitPatientPhysiotherapyPayment.PaymentDate = MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsi(System.DateTime.Now).Substring(0,10);
                        VisitPatientPhysiotherapyPayment.PaymentType_Id = 1;
                        VisitPatientPhysiotherapyPayment.PaymentStatus_Id = 8;
                        VisitPatientPhysiotherapyPayment.PaymentStatusDate = MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsi(System.DateTime.Now).Substring(0, 10);

                        VisitPatientPhysiotherapyPayment.ReportCode = 0;
                        VisitPatientPhysiotherapyPayment.AnalyzePage = 0;

                        VisitPatientPhysiotherapyPayment.CostReqInsu = VisitPatientPhysiotherapyPayment.VisitFew * CostReqInsuPhsiotraphy;
                        VisitPatientPhysiotherapyPayment.CostCachInsu = VisitPatientPhysiotherapyPayment.CostReqInsu;

                        short DoctorTaxPercent = 0;
                        try { DoctorTaxPercent = new ViewModel.Doctors.Doctor().GetAllListByID(VisitPatientPhysiotherapyPayment.Doctor_Id.Value, ref str).Last().DoctorTaxPercent.Value; }
                        catch { }

                        //VisitPatientPhysiotherapyPayment.CostDoctorTax = DoctorTaxPercent != 0 ? VisitPatientPhysiotherapyPayment.CostCachInsu * DoctorTaxPercent / 100 : 0;

                        //VisitPatientPhysiotherapyPayment.CostCompany = VisitPatientPhysiotherapyPayment.CostCachInsu * CostCompanyPhsiotraphyPercent / 100;
                        //VisitPatientPhysiotherapyPayment.CostDoctor = VisitPatientPhysiotherapyPayment.CostCachInsu - VisitPatientPhysiotherapyPayment.CostCompany - VisitPatientPhysiotherapyPayment.CostDoctorTax;

                        VisitPatientPhysiotherapyPayment.CostCompany = Other.Class.Function_Cls.CalculateCostCompany(VisitPatientPhysiotherapyPayment.CostCachInsu.Value, CostCompanyPhsiotraphyPercent);
                        VisitPatientPhysiotherapyPayment.CostDoctorTax = Other.Class.Function_Cls.CalculateTax(VisitPatientPhysiotherapyPayment.CostCachInsu.Value, VisitPatientPhysiotherapyPayment.CostCompany.Value, DoctorTaxPercent);
                        VisitPatientPhysiotherapyPayment.CostDoctorInsurance = Other.Class.Function_Cls.CalculateInsurance(VisitPatientPhysiotherapyPayment.CostCachInsu.Value, VisitPatientPhysiotherapyPayment.CostCompany.Value, CostInsurancePercent);
                        VisitPatientPhysiotherapyPayment.CostDoctorPrePayment = 0;
                        VisitPatientPhysiotherapyPayment.CostIncrease = 0;

                        VisitPatientPhysiotherapyPayment.CostDoctor = Other.Class.Function_Cls.CalculateCostDoctor(VisitPatientPhysiotherapyPayment.CostCachInsu.Value, VisitPatientPhysiotherapyPayment.CostCompany.Value, VisitPatientPhysiotherapyPayment.CostIncrease.Value, VisitPatientPhysiotherapyPayment.CostDoctorTax.Value, VisitPatientPhysiotherapyPayment.CostDoctorInsurance.Value, VisitPatientPhysiotherapyPayment.CostDoctorPrePayment.Value);


                        VisitPatientPhysiotherapyPayment.CostVisitDoctorBes = 0;
                        VisitPatientPhysiotherapyPayment.CostVisitDoctorRemind = 0;

                        VisitPatientPhysiotherapyPayment.User_Id = MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID;
                        VisitPatientPhysiotherapyPayment.ChangeDateTime = MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(System.DateTime.Now);

                        ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapy RN = new ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapy();
                        List<VW_VisitPatientPhysiotherapy> VPC = RN.GetAllListByID(long.Parse(GridViewVisitPatientPhysiotherapy.SelectedItems[i].GetRow().Cells["Id"].Value.ToString()), ref str);

                        VisitPatientPhysiotherapyPayment.Patient_Id = VPC[0].Patient_Id;
                        VisitPatientPhysiotherapyPayment.DosiersNo = VPC[0].DosiersNo ?? "";
                        VisitPatientPhysiotherapyPayment.PatientName = VPC[0].PatientName ?? "";
                        VisitPatientPhysiotherapyPayment.PatientFamily = VPC[0].PatientFamily ?? "";
                        VisitPatientPhysiotherapyPayment.ParentName = VPC[0].ParentName ?? "";
                        VisitPatientPhysiotherapyPayment.SexStr = VPC[0].SexStr ?? "";
                        VisitPatientPhysiotherapyPayment.IDNO = VPC[0].IDNO ?? "";
                        VisitPatientPhysiotherapyPayment.NationalCode = VPC[0].NationalCode ?? "";
                        VisitPatientPhysiotherapyPayment.PatientTypeStr = VPC[0].PatientTypeStr ?? "";
                        VisitPatientPhysiotherapyPayment.InjuryTypeStr = VPC[0].InjuryTypeStr ?? "";
                        VisitPatientPhysiotherapyPayment.BrithDate = VPC[0].BrithDate ?? "";
                        VisitPatientPhysiotherapyPayment.BrithCityName = VPC[0].BrithCityName ?? "";
                        VisitPatientPhysiotherapyPayment.PercentState = VPC[0].PercentState ?? 0;
                        VisitPatientPhysiotherapyPayment.SingleOrNo = VPC[0].SingleOrNo ?? "";
                        VisitPatientPhysiotherapyPayment.BonyadAddEvenStr = VPC[0].BonyadAddEvenStr ?? "";

                        VisitPatientPhysiotherapyPayment.BonyadDosier = VPC[0].BonyadDosier ?? "";
                        VisitPatientPhysiotherapyPayment.StatePart = VPC[0].StatePart ?? "";
                        VisitPatientPhysiotherapyPayment.CityState = VPC[0].CityState ?? "";
                        
                        VisitPatientPhysiotherapyPayment.CityPart = VPC[0].CityPart ?? "";
                        VisitPatientPhysiotherapyPayment.InstitutePart = VPC[0].InstitutePart ?? 0;
                        VisitPatientPhysiotherapyPayment.AddressPart = VPC[0].AddressPart ?? 0;
                        VisitPatientPhysiotherapyPayment.Address = VPC[0].Address ?? "";
                        VisitPatientPhysiotherapyPayment.PostalCode = VPC[0].PostalCode ?? "";
                        VisitPatientPhysiotherapyPayment.TelHome = VPC[0].TelHome ?? "";
                        VisitPatientPhysiotherapyPayment.TelBusiness = VPC[0].TelBusiness ?? "";
                        VisitPatientPhysiotherapyPayment.Mobile = VPC[0].Mobile ?? "";
                        VisitPatientPhysiotherapyPayment.Mobile2 = VPC[0].Mobile2 ?? "";
                        VisitPatientPhysiotherapyPayment.Email = VPC[0].Email ?? "";
                        VisitPatientPhysiotherapyPayment.BasicInsurance = VPC[0].BasicInsurance ?? "";
                        VisitPatientPhysiotherapyPayment.CompletionInsurance = VPC[0].CompletionInsurance ?? "";
                        VisitPatientPhysiotherapyPayment.IssueArchive = VPC[0].IssueArchive ?? "";
                        VisitPatientPhysiotherapyPayment.LetterNo = VPC[0].LetterNo ?? "";
                        VisitPatientPhysiotherapyPayment.LetterDate = VPC[0].LetterDate ?? "";
                        
                        VisitPatientPhysiotherapyPayment.PatientProblem = VPC[0].PatientProblem ?? "";
                        VisitPatientPhysiotherapyPayment.PhysiotherapyType = VPC[0].PhysiotherapyType ?? "";
                        VisitPatientPhysiotherapyPayment.CordinateDate = VPC[0].CordinateDate ?? "";
                        VisitPatientPhysiotherapyPayment.MonthPhysiotherapy = VPC[0].MonthPhysiotherapy ?? "";

                        VisitPatientPhysiotherapyPayment.ContractNo = VPC[0].ContractNo ?? "";
                        VisitPatientPhysiotherapyPayment.ContractDate = VPC[0].ContractDate ?? "";
                        VisitPatientPhysiotherapyPayment.MedicalCode = VPC[0].MedicalCode ?? "";
                        VisitPatientPhysiotherapyPayment.DoctorName = VPC[0].DoctorName ?? "";
                        VisitPatientPhysiotherapyPayment.DoctorFamily = VPC[0].DoctorFamily ?? "";
                        VisitPatientPhysiotherapyPayment.DoctorNationalCode = VPC[0].DoctorsNationalCode ?? "";
                        VisitPatientPhysiotherapyPayment.DoctorBrithDate = VPC[0].DoctorBrithDate ?? "";
                        VisitPatientPhysiotherapyPayment.LocationPart = VPC[0].LocationPart ?? "";
                        VisitPatientPhysiotherapyPayment.DoctorAddress = VPC[0].DoctorsAddress ?? "";
                        VisitPatientPhysiotherapyPayment.DoctorTelBusiness = VPC[0].DoctorsTelBusiness ?? "";
                        VisitPatientPhysiotherapyPayment.DoctorMobile = VPC[0].DoctorsMobile ?? "";
                        VisitPatientPhysiotherapyPayment.BankName = VPC[0].BankName ?? "";
                        VisitPatientPhysiotherapyPayment.CardBankNo1 = VPC[0].CardBankNo1 ?? "";
                        VisitPatientPhysiotherapyPayment.CardBankNo2 = VPC[0].CardBankNo2 ?? "";

                        VisitPatientPhysiotherapyPayment.DoctorPhysioMedicalCode = VPC[0].DoctorPhysioMedicalCode ?? "";
                        VisitPatientPhysiotherapyPayment.DoctorPhysioName = VPC[0].DoctorPhysioName ?? "";
                        VisitPatientPhysiotherapyPayment.DoctorPhysioFamily = VPC[0].DoctorPhysioFamily ?? "";
                        VisitPatientPhysiotherapyPayment.DoctorPhysioNationalCode = VPC[0].DoctorPhysioNationalCode ?? "";
                        VisitPatientPhysiotherapyPayment.DoctorPhysioLocationPart = VPC[0].DoctorPhysioLocationPart ?? "";
                        VisitPatientPhysiotherapyPayment.DoctorPhysioAddress = VPC[0].DoctorPhysioAddress ?? "";
                        VisitPatientPhysiotherapyPayment.DoctorPhysioTelBusiness = VPC[0].DoctorPhysioTelBusiness ?? "";
                        VisitPatientPhysiotherapyPayment.DoctorPhysioMobile = VPC[0].DoctorPhysioMobile ?? "";



                        Ls.Add(VisitPatientPhysiotherapyPayment);

                        //new ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapy().UpdateVisitStatus(long.Parse(GridViewVisitPatientPhysiotherapy.SelectedItems[i].GetRow().Cells["Id"].Value.ToString()), 2,
                        //    MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                        //    MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(System.DateTime.Now),
                        //    ref str);
                    }
                    long? f = 0;
                    new ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapyPayment().InsertEntity(Ls, ref str, ref f);
                    BindData(GridViewVisitPatientPhysiotherapy.Row);
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
                    PhysiotherapyCare.View.MainForms.AllStatus.AllStatusAdd_Frm(System.Convert.ToInt64(GridViewVisitPatientPhysiotherapy.CurrentRow.Cells["Id"].Value));
            asf._systemTypeSet = PhysiotherapyCare.View.MainForms.AllStatus.AllStatusAdd_Frm.SystemType.Physiotherapy;
            asf.ShowDialog();
        }

       
        private void ComboBoxSerach_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            BindData(GridViewVisitPatientPhysiotherapy.Row);
        }

        private void DatePickerStart_ValueChanged(object sender, KagNetComponents2.PersianMonthCalendarEventArgs e)
        {
            if (SetDate) BindData(GridViewVisitPatientPhysiotherapy.Row);
        }

        private void buttonItemSendSMS_Click(object sender, System.EventArgs e)
        {
            List<MKH.Library.Clasess.PublicClass.AllPersonForSMS> ListForSelectPerson = new List<MKH.Library.Clasess.PublicClass.AllPersonForSMS>();
            for (int i = 0; i < GridViewVisitPatientPhysiotherapy.SelectedItems.Count; i++)
            {
                if (((GridViewVisitPatientPhysiotherapy.SelectedItems[i].GetRow().Cells["DoctorsMobile"].Value ?? "").ToString().StartsWith("09") && (GridViewVisitPatientPhysiotherapy.SelectedItems[i].GetRow().Cells["DoctorsMobile"].Value ?? "").ToString().Length == 11))
                {
                    try
                    {
                        MKH.Library.Clasess.PublicClass.AllPersonForSMS ssss = new MKH.Library.Clasess.PublicClass.AllPersonForSMS();
                        ssss.PersonNameFamily = (GridViewVisitPatientPhysiotherapy.SelectedItems[i].GetRow().Cells["DoctorName"].Value ?? "").ToString() + " " +
                                                (GridViewVisitPatientPhysiotherapy.SelectedItems[i].GetRow().Cells["DoctorFamily"].Value ?? "").ToString();
                        ssss.JobType = "فیزیوتراپ";
                        ssss.MobileNo1 = (GridViewVisitPatientPhysiotherapy.SelectedItems[i].GetRow().Cells["DoctorsMobile"].Value ?? "").ToString();
                        ssss.MobileNo2 = (GridViewVisitPatientPhysiotherapy.SelectedItems[i].GetRow().Cells["DoctorsTelHome"].Value ?? "").ToString() + " " + (GridViewVisitPatientPhysiotherapy.SelectedItems[i].GetRow().Cells["DoctorsTelBusiness"].Value ?? "").ToString();

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
            long IDSet = 0;

            for (int i = 0; i < GridViewVisitPatientPhysiotherapy.SelectedItems.Count; i++)
                if (new ViewModel.Basic.NODuplicateForm().CheckNODuplicateForm("TBL_VisitPatientPhysiotherapy", GridViewVisitPatientPhysiotherapy.SelectedItems[i].GetRow().Cells["Id"].Value.ToString(), ref str))
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View("امکان تغییرات به علت انجام عملیات توسط کاربر دیگر امکان پذیر نمی باشد. لطفا کمی بعد سعی کنید", MKH.Library.Clasess.MSSMessage.MessageType.SWarning);
                    return;
                }

            if (MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation, true, "تاریخ دریافت فایل جهت ردیف های انتخابی مشخص شود؟"))
            {
                try
                {
                    for (int i = 0; i < GridViewVisitPatientPhysiotherapy.SelectedItems.Count; i++)
                    {

                        IDSet = long.Parse(GridViewVisitPatientPhysiotherapy.SelectedItems[i].GetRow().Cells["Id"].Value.ToString());

                        new ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapy().UpdateEntityWithFieldValue(
                        IDSet, "ReciveFileDate", DatePickerReciveFileDate.Value.ToString().Substring(0, 10),
                        MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                        MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(System.DateTime.Now), ref str);
                    }
                    BindData(GridViewVisitPatientPhysiotherapy.Row);
                }
                catch (System.Exception ex)
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View(ex.Message, MKH.Library.Clasess.MSSMessage.MessageType.SError);
                }
            }
        }

        private void ToolStripMenuItemVisitPatientPhysiotherapyCurrentRow_Click(object sender, System.EventArgs e)
        {
            try
            {
                string Str = "";
                int J = 0;

                MKH.Library.Forms.MSSLogViewer_frm ctrl = new MKH.Library.Forms.MSSLogViewer_frm();
                ctrl.GridexViewSelector.DataSource = new MKH.Permission.ViewModel.Log.Log().GetAllListVisitPatientPhysiotherapyByID(System.Convert.ToInt64(GridViewVisitPatientPhysiotherapy.CurrentRow.Cells["Id"].Value), ref Str).ToList();
                ctrl.ColumnList = new System.Data.DataTable();
                for (int i = 0; i < GridViewVisitPatientPhysiotherapy.RootTable.Columns.Count; i++)
                    if (GridViewVisitPatientPhysiotherapy.RootTable.Columns[i].Tag == "" || GridViewVisitPatientPhysiotherapy.RootTable.Columns[i].Tag == null)
                    {
                        ctrl.ColumnList.Columns.Add(GridViewVisitPatientPhysiotherapy.RootTable.Columns[i].Key);
                        ctrl.ColumnList.Columns[J].Caption = GridViewVisitPatientPhysiotherapy.RootTable.Columns[i].Caption;
                        J++;
                    }
                ctrl.ShowDialog();
            }
            catch { }
        }

        private void ToolStripMenuItemVisitPatientPhysiotherapyAllList_Click(object sender, System.EventArgs e)
        {
            try
            {
                string Str = "";
                int J = 0;

                MKH.Library.Forms.MSSLogViewer_frm ctrl = new MKH.Library.Forms.MSSLogViewer_frm();
                ctrl.GridexViewSelector.DataSource = new MKH.Permission.ViewModel.Log.Log().GetAllListVisitPatientPhysiotherapy(ref Str).ToList();
                ctrl.ColumnList = new System.Data.DataTable();
                for (int i = 0; i < GridViewVisitPatientPhysiotherapy.RootTable.Columns.Count; i++)
                    if (GridViewVisitPatientPhysiotherapy.RootTable.Columns[i].Visible)
                    {
                        ctrl.ColumnList.Columns.Add(GridViewVisitPatientPhysiotherapy.RootTable.Columns[i].Key);
                        ctrl.ColumnList.Columns[J].Caption = GridViewVisitPatientPhysiotherapy.RootTable.Columns[i].Caption;
                        J++;
                    }
                ctrl.ShowDialog();
            }
            catch { }
        }
       
    }
}
