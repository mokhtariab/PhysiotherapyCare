using System.Linq;
using System.Collections.Generic;
using PhysiotherapyCare.Model.Basic;
using PhysiotherapyCare.Model;
using MKH.Library.Clasess.FilterClass;
using System.Windows.Forms;
using PhysiotherapyCare.Model.VisitPatientCare;
using System;

namespace PhysiotherapyCare.View.MainForms.VisitPatientCare
{
    public partial class VisitPatientCarePayment_UC : UserControl
    {
        public VisitPatientCarePayment_UC()
        {
            InitializeComponent();
        }


        public void BindData(int RowNumberSet)
        {
            string str = "";

            List<VW_VisitPatientCarePayment> LSQ = new List<VW_VisitPatientCarePayment>();

            LSQ = new ViewModel.VisitPatientCare.VisitPatientCarePayment().GetAllList(ref str).Where(f => f.PaymentStatus_Id != 8).ToList();

            
            try
            {
                if (RadioBoxContractWithTime.Checked)
                {
                    if (ComboBoxSerach.SelectedIndex == 0)
                        LSQ = LSQ.Where(d => MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.PaymentDate ?? "") >= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerStart.Value.ToString())
                            && MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.PaymentDate ?? "") <= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerEnd.Value.ToString())).ToList();
                    if (ComboBoxSerach.SelectedIndex == 1)
                        LSQ = LSQ.Where(d => MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.LetterDate ?? "") >= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerStart.Value.ToString())
                            && MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.LetterDate ?? "") <= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerEnd.Value.ToString())).ToList();
                    else if (ComboBoxSerach.SelectedIndex == 2)
                        LSQ = LSQ.Where(d => MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.ContractDate ?? "") >= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerStart.Value.ToString())
                            && MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.ContractDate ?? "") <= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerEnd.Value.ToString())).ToList();
                    else if (ComboBoxSerach.SelectedIndex == 3)
                        LSQ = LSQ.Where(d => MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.BeginDate ?? "") >= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerStart.Value.ToString())
                            && MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.BeginDate ?? "") <= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerEnd.Value.ToString())).ToList();
                    else if (ComboBoxSerach.SelectedIndex == 4)
                        LSQ = LSQ.Where(d => MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.EndDate ?? "") >= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerStart.Value.ToString())
                            && MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.EndDate ?? "") <= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerEnd.Value.ToString())).ToList();
                    else if (ComboBoxSerach.SelectedIndex == 5)
                        LSQ = LSQ.Where(d => MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.InsuLetterDate ?? "") >= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerStart.Value.ToString())
                            && MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.InsuLetterDate ?? "") <= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerEnd.Value.ToString())).ToList();
                    else if (ComboBoxSerach.SelectedIndex == 6)
                        LSQ = LSQ.Where(d => MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.SecretiatDate ?? "") >= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerStart.Value.ToString())
                            && MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.SecretiatDate ?? "") <= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerEnd.Value.ToString())).ToList();
                    else if (ComboBoxSerach.SelectedIndex == 7)
                        LSQ = LSQ.Where(d => MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.AnalyzeDate ?? "") >= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerStart.Value.ToString())
                            && MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.AnalyzeDate ?? "") <= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerEnd.Value.ToString())).ToList();
                    else if (ComboBoxSerach.SelectedIndex == 8)
                        LSQ = LSQ.Where(d => MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.CostIncreaseDate ?? "") >= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerStart.Value.ToString())
                            && MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.CostIncreaseDate ?? "") <= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerEnd.Value.ToString())).ToList();
                    else if (ComboBoxSerach.SelectedIndex == 9)
                        LSQ = LSQ.Where(d => MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.PaymentDoctorDate ?? "") >= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerStart.Value.ToString())
                            && MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.PaymentDoctorDate ?? "") <= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerEnd.Value.ToString())).ToList();
                    else if (ComboBoxSerach.SelectedIndex == 10)
                        LSQ = LSQ.Where(d => MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.BonyadConfirmDate ?? "") >= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerStart.Value.ToString())
                            && MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.BonyadConfirmDate ?? "") <= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerEnd.Value.ToString())).ToList();
                    else if (ComboBoxSerach.SelectedIndex == 11)
                        LSQ = LSQ.Where(d => MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.AccountingDocumentDate ?? "") >= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerStart.Value.ToString())
                            && MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.AccountingDocumentDate ?? "") <= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerEnd.Value.ToString())).ToList();
                    else if (ComboBoxSerach.SelectedIndex == 12)
                        LSQ = LSQ.Where(d => MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.BursaryDate ?? "") >= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerStart.Value.ToString())
                            && MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.BursaryDate ?? "") <= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerEnd.Value.ToString())).ToList();

                }
                //else
                GridViewVisitPatientCarePayment.DataSource = LSQ;

            }
            catch { }

            try { GridViewVisitPatientCarePayment.Row = RowNumberSet; }
            catch { }
        }


        #region All UI Button

        private void headerGridVisitPatientCarePayment_btnInsertClick(object sender, System.EventArgs e)
        {
            VisitPatientCarePaymentPrePaymentAdd_Frm VisitPatientCarePaymentAdd = new VisitPatientCarePaymentPrePaymentAdd_Frm();

            if (VisitPatientCarePaymentAdd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                BindData(GridViewVisitPatientCarePayment.RowCount);
        }

        private void headerGridVisitPatientCarePayment_btnEditClick(object sender, System.EventArgs e)
        {
            try
            {

                //if (!(HeaderGridVisitPatientCarePayment as MKH.Library.Control.MSSHeaderGrid).Items["buttonItemEdit"].Visible || !(HeaderGridVisitPatientCarePayment as MKH.Library.Control.MSSHeaderGrid).Items["buttonItemEdit"].Enabled) return;
                if (Convert.ToInt32(GridViewVisitPatientCarePayment.CurrentRow.Cells["CostVisitDoctorBes"].Value) == 0)
                {
                    VisitPatientCarePaymentAdd_Frm VisitPatientCarePaymentAdd = new VisitPatientCarePaymentAdd_Frm(
                            int.Parse(GridViewVisitPatientCarePayment.CurrentRow.Cells["Id"].Value.ToString()));
                    if (VisitPatientCarePaymentAdd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        BindData(GridViewVisitPatientCarePayment.Row);
                }
                else
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View("امکان ویرایش پیش پرداخت وجود ندارد. ابتدا حذف و سپس پیش پرداخت را ثبت نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SWarning);

                    //VisitPatientCarePaymentPrePaymentAdd_Frm VisitPatientCarePaymentAdd = new VisitPatientCarePaymentPrePaymentAdd_Frm(
                    //        int.Parse(GridViewVisitPatientCarePayment.CurrentRow.Cells["Id"].Value.ToString()));
                    //if (VisitPatientCarePaymentAdd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    //    BindData(GridViewVisitPatientCarePayment.Row);
                }
            }
            catch { }
        }

        private void headerGridVisitPatientCarePayment_btnDeleteClick(object sender, System.EventArgs e)
        {
            string str = "";

            for (int i = 0; i < GridViewVisitPatientCarePayment.SelectedItems.Count; i++)
                if (new ViewModel.Basic.NODuplicateForm().CheckNODuplicateForm("TBL_VisitPatientCarePayment", GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["Id"].Value.ToString(), ref str))
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View("امکان حذف به علت انجام عملیات توسط کاربر دیگر بر روی ردیف (هایی) امکان پذیر نمی باشد", MKH.Library.Clasess.MSSMessage.MessageType.SWarning);
                    return;
                }

            if (MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation, true, "آیا به حذف موارد انتخابی اطمینان دارید؟"))
            {
                try
                {
                    //List<TBL_VisitPatientCarePayment> Ls = new List<TBL_VisitPatientCarePayment>();
                    //for (int i = 0; i < GridViewVisitPatientCarePayment.SelectedItems.Count; i++)
                    //{
                    //    TBL_VisitPatientCarePayment VisitPatientCarePayment = new TBL_VisitPatientCarePayment();
                    //    VisitPatientCarePayment.Id = long.Parse(GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["Id"].Value.ToString());

                    //    VisitPatientCarePayment.VisitPatientCare_Id = long.Parse(GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["VisitPatientCare_Id"].Value.ToString());
                    //    VisitPatientCarePayment.PaymentType_Id = short.Parse(GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["PaymentType_Id"].Value.ToString());
                    //    VisitPatientCarePayment.PaymentStatus_Id = short.Parse(GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["PaymentStatus_Id"].Value.ToString());

                    //    Ls.Add(VisitPatientCarePayment);
                    //}

                    //string str = "";
                    //new ViewModel.VisitPatientCare.VisitPatientCarePayment().DeleteEntity(Ls, ref str);


                    List<TBL_VisitPatientCarePayment> Ls = new List<TBL_VisitPatientCarePayment>();
                    ViewModel.VisitPatientCare.VisitPatientCarePayment RN = new ViewModel.VisitPatientCare.VisitPatientCarePayment();
                    for (int i = 0; i < GridViewVisitPatientCarePayment.SelectedItems.Count; i++)
                        Ls.Add(RN.GetAllListByTblID(long.Parse(GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["Id"].Value.ToString()), ref str)[0]);

                    new ViewModel.VisitPatientCare.VisitPatientCarePayment().DeleteEntity(Ls, ref str);



                    if (str != "") MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "امکان حذف مورد انتخابی به علت داشتن عملکرد در نرم افزار وجود ندارد", str);
                    else
                        BindData(GridViewVisitPatientCarePayment.Row - 1);
                }
                catch (System.Exception ex)
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "اشکال", ex.Message);
                }
            }
        }

        private void headerGridVisitPatientCarePayment_btnRefreshClick(object sender, System.EventArgs e)
        {
            BindData(GridViewVisitPatientCarePayment.Row);
        }

        #endregion

        bool SetDate = false;
        private void VisitPatientCarePayment_UC_Load(object sender, System.EventArgs e)
        {
            new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionControl(this);

            SetComboBox();
            buttonItemCarePaymentCalculateRimindAll.Enabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(160);
            btnSetValueCare.Enabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(161);

            ToolStripMenuItemVisitPatientCarePaymentCurrentRow.Enabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(272);
            ToolStripMenuItemVisitPatientCarePaymentAllList.Enabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(273);

            try
            {
                SetDate = false;
                DatePickerSet.Value = KagNetComponents2.KagPersianDate.Now;
                DatePickerStart.Value = KagNetComponents2.KagPersianDate.Now;
                SetDate = true;
                DatePickerEnd.Value = KagNetComponents2.KagPersianDate.Now;
                ComboBoxSerach.SelectedIndex = 5;
            }
            catch { }
        }

        private void SetComboBox()
        {
            string str = "";

            comboBoxPaymentStatus.ValueMember = "Id";
            comboBoxPaymentStatus.DisplayMember = "TitleName";
            comboBoxPaymentStatus.DataSource = new PhysiotherapyCare.ViewModel.Basic.PaymentStatus().GetAllList(ref str);

            comboBoxBank.ValueMember = "Id";
            comboBoxBank.DisplayMember = "TitleName";
            comboBoxBank.DataSource = new PhysiotherapyCare.ViewModel.Basic.Bank().GetAllList(ref str);

        }
        private void ComboBoxSerach_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            BindData(GridViewVisitPatientCarePayment.Row);
        }

        private void DatePickerStart_ValueChanged(object sender, KagNetComponents2.PersianMonthCalendarEventArgs e)
        {
            if (SetDate) BindData(GridViewVisitPatientCarePayment.Row);
        }

        private void comboBoxSetValue_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            textBoxSetValue.Visible = comboBoxSetValue.SelectedIndex == 3 || comboBoxSetValue.SelectedIndex == 4 || comboBoxSetValue.SelectedIndex == 5 || comboBoxSetValue.SelectedIndex == 10 || comboBoxSetValue.SelectedIndex == 11 || comboBoxSetValue.SelectedIndex == 12 || comboBoxSetValue.SelectedIndex == 13 || comboBoxSetValue.SelectedIndex == 15 || comboBoxSetValue.SelectedIndex == 16 || comboBoxSetValue.SelectedIndex == 17 || comboBoxSetValue.SelectedIndex == 18;
            nUpDownSetValue.Visible = comboBoxSetValue.SelectedIndex == 1 || comboBoxSetValue.SelectedIndex == 2 || comboBoxSetValue.SelectedIndex == 6 || comboBoxSetValue.SelectedIndex == 7 || comboBoxSetValue.SelectedIndex == 8 || comboBoxSetValue.SelectedIndex == 9 || comboBoxSetValue.SelectedIndex == 19 || comboBoxSetValue.SelectedIndex == 20 || comboBoxSetValue.SelectedIndex == 21 || comboBoxSetValue.SelectedIndex == 22 || comboBoxSetValue.SelectedIndex == 23 || comboBoxSetValue.SelectedIndex == 24;
            comboBoxPaymentStatus.Visible = comboBoxSetValue.SelectedIndex == 0;
            comboBoxBank.Visible = comboBoxSetValue.SelectedIndex == 14;
        }

        private void btnSetValue_Click(object sender, System.EventArgs e)
        {
            string str = "";
            for (int i = 0; i < GridViewVisitPatientCarePayment.SelectedItems.Count; i++)
                if (new ViewModel.Basic.NODuplicateForm().CheckNODuplicateForm("TBL_VisitPatientCarePayment", GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["Id"].Value.ToString(), ref str))
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View("امکان تغییرات به علت انجام عملیات توسط کاربر دیگر امکان پذیر نمی باشد. لطفا کمی بعد سعی کنید", MKH.Library.Clasess.MSSMessage.MessageType.SWarning);
                    return;
                }

            long IDSet = 0;

            if (MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation, true, "آیا مقدار درخواستی جهت ردیف های انتخابی ثبت شود؟"))
            {
                try
                {
                    //int DefCostCo = new ViewModel.Setting.Setting().GetAllValue("CostCompanyCarePercent", ref str).ToString().ToInt();

                    for (int i = 0; i < GridViewVisitPatientCarePayment.SelectedItems.Count; i++)
                    {
                        IDSet = long.Parse(GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["Id"].Value.ToString());

                        //if (GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["PaymentTypeName"].Value.ToString() == "پیش پرداخت" ||
                        //    GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["PaymentTypeName"].Value.ToString() == "کسورات")
                        if (Convert.ToInt32(GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["CostVisitDoctorBes"].Value) != 0
                            && comboBoxSetValue.SelectedIndex != 0
                            && comboBoxSetValue.SelectedIndex != 5
                            && comboBoxSetValue.SelectedIndex != 10
                            && comboBoxSetValue.SelectedIndex != 11)
                            continue;


                        if (comboBoxSetValue.SelectedIndex == 0)
                        {
                            if (comboBoxPaymentStatus.SelectedIndex == -1) comboBoxPaymentStatus.SelectedIndex = 0;

                            new ViewModel.VisitPatientCare.VisitPatientCarePayment().UpdateEntityWithFieldValue(
                                IDSet, "PaymentStatus_Id", (comboBoxPaymentStatus.SelectedIndex + 1).ToString(),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                            new ViewModel.VisitPatientCare.VisitPatientCarePayment().UpdateEntityWithFieldValue(
                                IDSet, "PaymentStatusDate", DatePickerSet.Value.ToString().Substring(0, 10),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);
                        }
                        else if (comboBoxSetValue.SelectedIndex == 1)//CostCachInsu
                        {
                            double DoctorTaxPercent = double.Parse((GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["CostDoctorTax"].Value ?? 0).ToString()) * 100 / (double.Parse((GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["CostCachInsu"].Value ?? 1).ToString()) - double.Parse((GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["CostCompany"].Value ?? 0).ToString()));
                            double CostInsurancePercent = double.Parse((GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["CostDoctorInsurance"].Value ?? 0).ToString()) * 100 / (double.Parse((GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["CostCachInsu"].Value ?? 1).ToString()) - double.Parse((GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["CostCompany"].Value ?? 0).ToString()));
                            double CostCompanyCarePercent = double.Parse((GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["CostCompany"].Value ?? 0).ToString()) * 100 / double.Parse((GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["CostCachInsu"].Value ?? 1).ToString());
                            if (double.IsNaN(CostCompanyCarePercent) || CostCompanyCarePercent == 0)
                            {
                                CostCompanyCarePercent = double.Parse(new ViewModel.Setting.Setting().GetAllValue("CostCompanyCarePercent", ref str).ToString());
                                DoctorTaxPercent = 0;
                                CostInsurancePercent = double.Parse(new ViewModel.Setting.Setting().GetAllValue("CostInsurancePercent", ref str).ToString());
                            }

                            int CostCachInsuIran = int.Parse(nUpDownSetValue.Value.ToString());
                            int CostCompany = Other.Class.Function_Cls.CalculateCostCompany(CostCachInsuIran, CostCompanyCarePercent);
                            int CostDoctorTax = Other.Class.Function_Cls.CalculateTax(CostCachInsuIran, CostCompany, DoctorTaxPercent);
                            int CostDoctorInsurance = Other.Class.Function_Cls.CalculateInsurance(CostCachInsuIran, CostCompany, CostInsurancePercent);
                            int CostDoctor = Other.Class.Function_Cls.CalculateCostDoctor(CostCachInsuIran, CostCompany,
                                int.Parse((GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["CostIncrease"].Value ?? 0).ToString()),
                                CostDoctorTax, CostDoctorInsurance,
                                int.Parse((GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["CostDoctorPrePayment"].Value ?? 0).ToString()));

                            new ViewModel.VisitPatientCare.VisitPatientCarePayment().UpdateEntityWithFieldValue(
                                IDSet, "CostCachInsu", CostCachInsuIran.ToString(),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                            new ViewModel.VisitPatientCare.VisitPatientCarePayment().UpdateEntityWithFieldValue(
                                IDSet, "CostCompany", CostCompany.ToString(),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                            new ViewModel.VisitPatientCare.VisitPatientCarePayment().UpdateEntityWithFieldValue(
                                IDSet, "CostDoctorTax", CostDoctorTax.ToString(),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                            new ViewModel.VisitPatientCare.VisitPatientCarePayment().UpdateEntityWithFieldValue(
                                IDSet, "CostDoctorInsurance", CostDoctorInsurance.ToString(),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                            new ViewModel.VisitPatientCare.VisitPatientCarePayment().UpdateEntityWithFieldValue(
                                IDSet, "CostDoctor", CostDoctor.ToString(),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);
                        }
                        else if (comboBoxSetValue.SelectedIndex == 2)
                        {
                             new ViewModel.VisitPatientCare.VisitPatientCarePayment().UpdateEntityWithFieldValue(
                                IDSet, "AnalyzePage", nUpDownSetValue.Value.ToString(),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);
                        }
                        else if (comboBoxSetValue.SelectedIndex == 3)
                        {
                            new ViewModel.VisitPatientCare.VisitPatientCarePayment().UpdateEntityWithFieldValue(
                                IDSet, "AnalyzeNo", textBoxSetValue.Text,
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                            new ViewModel.VisitPatientCare.VisitPatientCarePayment().UpdateEntityWithFieldValue(
                                IDSet, "AnalyzeDate", textBoxSetValue.Text == "" ? "" : DatePickerSet.Value.ToString().Substring(0, 10),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);
                        }
                        else if (comboBoxSetValue.SelectedIndex == 4)
                        {
                            new ViewModel.VisitPatientCare.VisitPatientCarePayment().UpdateEntityWithFieldValue(
                                IDSet, "AccountingDocumentNumber", textBoxSetValue.Text,
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);
                            
                            new ViewModel.VisitPatientCare.VisitPatientCarePayment().UpdateEntityWithFieldValue(
                                IDSet, "AccountingDocumentDate", textBoxSetValue.Text == "" ? "" : DatePickerSet.Value.ToString().Substring(0, 10),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                        }
                        else if (comboBoxSetValue.SelectedIndex == 5)
                        {
                            new ViewModel.VisitPatientCare.VisitPatientCarePayment().UpdateEntityWithFieldValue(
                                   IDSet, "BursaryNumber", textBoxSetValue.Text,
                                   MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                   MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                            new ViewModel.VisitPatientCare.VisitPatientCarePayment().UpdateEntityWithFieldValue(
                                IDSet, "BursaryDate", textBoxSetValue.Text == "" ? "" : DatePickerSet.Value.ToString().Substring(0, 10),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                        }
                        else if (comboBoxSetValue.SelectedIndex == 6)//CostCompany
                        {
                            double DoctorTaxPercent = double.Parse((GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["CostDoctorTax"].Value ?? 0).ToString()) * 100 / (double.Parse((GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["CostCachInsu"].Value ?? 1).ToString()) - double.Parse((GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["CostCompany"].Value ?? 0).ToString()));
                            double CostInsurancePercent = double.Parse((GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["CostDoctorInsurance"].Value ?? 0).ToString()) * 100 / (double.Parse((GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["CostCachInsu"].Value ?? 1).ToString()) - double.Parse((GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["CostCompany"].Value ?? 0).ToString()));
                            double CostCompanyCarePercent = double.Parse((GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["CostCompany"].Value ?? 0).ToString()) * 100 / double.Parse((GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["CostCachInsu"].Value ?? 1).ToString());
                            if (double.IsNaN(CostCompanyCarePercent) || CostCompanyCarePercent == 0)
                            {
                                CostCompanyCarePercent = double.Parse(new ViewModel.Setting.Setting().GetAllValue("CostCompanyCarePercent", ref str).ToString());
                                DoctorTaxPercent = 0;
                                CostInsurancePercent = double.Parse(new ViewModel.Setting.Setting().GetAllValue("CostInsurancePercent", ref str).ToString());
                            }

                            int CostCachInsu = int.Parse((GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["CostCachInsu"].Value ?? 0).ToString());
                            int CostCompany = int.Parse(nUpDownSetValue.Value.ToString());
                            int CostDoctorTax = Other.Class.Function_Cls.CalculateTax(CostCachInsu, CostCompany, DoctorTaxPercent);
                            int CostDoctorInsurance = Other.Class.Function_Cls.CalculateInsurance(CostCachInsu, CostCompany, CostInsurancePercent);
                            int CostDoctor = Other.Class.Function_Cls.CalculateCostDoctor(CostCachInsu, CostCompany,
                                int.Parse((GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["CostIncrease"].Value ?? 0).ToString()),
                                CostDoctorTax, CostDoctorInsurance,
                                int.Parse((GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["CostDoctorPrePayment"].Value ?? 0).ToString()));
                            

                            new ViewModel.VisitPatientCare.VisitPatientCarePayment().UpdateEntityWithFieldValue(
                                IDSet, "CostCompany", CostCompany.ToString(),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                            new ViewModel.VisitPatientCare.VisitPatientCarePayment().UpdateEntityWithFieldValue(
                                IDSet, "CostDoctorTax", CostDoctorTax.ToString(),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                            new ViewModel.VisitPatientCare.VisitPatientCarePayment().UpdateEntityWithFieldValue(
                                IDSet, "CostDoctorInsurance", CostDoctorInsurance.ToString(),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                            new ViewModel.VisitPatientCare.VisitPatientCarePayment().UpdateEntityWithFieldValue(
                                IDSet, "CostDoctor", CostDoctor.ToString(),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);


                        }
                        else if (comboBoxSetValue.SelectedIndex == 7)//CostCompany Percent
                        {
                            double DoctorTaxPercent = double.Parse((GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["CostDoctorTax"].Value ?? 0).ToString()) * 100 / (double.Parse((GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["CostCachInsu"].Value ?? 1).ToString()) - double.Parse((GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["CostCompany"].Value ?? 0).ToString()));
                            double CostInsurancePercent = double.Parse((GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["CostDoctorInsurance"].Value ?? 0).ToString()) * 100 / (double.Parse((GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["CostCachInsu"].Value ??1).ToString()) - double.Parse((GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["CostCompany"].Value ?? 0).ToString()));
                            double CostCompanyCarePercent = double.Parse((GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["CostCompany"].Value ?? 0).ToString()) * 100 / double.Parse((GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["CostCachInsu"].Value ?? 1).ToString());
                            if (double.IsNaN(CostCompanyCarePercent) || CostCompanyCarePercent == 0)
                            {
                                CostCompanyCarePercent = double.Parse(new ViewModel.Setting.Setting().GetAllValue("CostCompanyCarePercent", ref str).ToString());
                                DoctorTaxPercent = 0;
                                CostInsurancePercent = double.Parse(new ViewModel.Setting.Setting().GetAllValue("CostInsurancePercent", ref str).ToString());
                            }

                            int CostCachInsu = int.Parse((GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["CostCachInsu"].Value ?? 0).ToString());
                            int CostCompany = int.Parse(nUpDownSetValue.Value.ToString()) * int.Parse((GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["CostCachInsu"].Value ?? 0).ToString()) / 100;
                            int CostDoctorTax = Other.Class.Function_Cls.CalculateTax(CostCachInsu, CostCompany, DoctorTaxPercent);
                            int CostDoctorInsurance = Other.Class.Function_Cls.CalculateInsurance(CostCachInsu, CostCompany, CostInsurancePercent);
                            int CostDoctor = Other.Class.Function_Cls.CalculateCostDoctor(CostCachInsu, CostCompany,
                                int.Parse((GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["CostIncrease"].Value ?? 0).ToString()),
                                CostDoctorTax, CostDoctorInsurance,
                                int.Parse((GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["CostDoctorPrePayment"].Value ?? 0).ToString()));

                            new ViewModel.VisitPatientCare.VisitPatientCarePayment().UpdateEntityWithFieldValue(
                                IDSet, "CostCompany", CostCompany.ToString(),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                            new ViewModel.VisitPatientCare.VisitPatientCarePayment().UpdateEntityWithFieldValue(
                                IDSet, "CostDoctorTax", CostDoctorTax.ToString(),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                            new ViewModel.VisitPatientCare.VisitPatientCarePayment().UpdateEntityWithFieldValue(
                                IDSet, "CostDoctorInsurance", CostDoctorInsurance.ToString(),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                            new ViewModel.VisitPatientCare.VisitPatientCarePayment().UpdateEntityWithFieldValue(
                                IDSet, "CostDoctor", CostDoctor.ToString(),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                        }
                        else if (comboBoxSetValue.SelectedIndex == 8) //CostIncrease
                        {

                            int CostDoctor = Other.Class.Function_Cls.CalculateCostDoctor(
                                int.Parse((GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["CostCachInsu"].Value ?? 0).ToString()),
                                int.Parse((GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["CostCompany"].Value ?? 0).ToString()),
                                int.Parse(nUpDownSetValue.Value.ToString()),
                                int.Parse((GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["CostDoctorTax"].Value ?? 0).ToString()),
                                int.Parse((GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["CostDoctorInsurance"].Value ?? 0).ToString()),
                                int.Parse((GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["CostDoctorPrePayment"].Value ?? 0).ToString()));

                            new ViewModel.VisitPatientCare.VisitPatientCarePayment().UpdateEntityWithFieldValue(
                               IDSet, "CostIncrease", int.Parse(nUpDownSetValue.Value.ToString()).ToString(),
                               MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                               MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                            new ViewModel.VisitPatientCare.VisitPatientCarePayment().UpdateEntityWithFieldValue(
                                IDSet, "CostIncreaseDate", textBoxSetValue.Text == "" ? "" : DatePickerSet.Value.ToString().Substring(0, 10),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                            new ViewModel.VisitPatientCare.VisitPatientCarePayment().UpdateEntityWithFieldValue(
                                IDSet, "CostDoctor", CostDoctor.ToString(),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);
                        }
                        else if (comboBoxSetValue.SelectedIndex == 9) //CostIncrease Percent
                        {
                            int CostIncrease = int.Parse(nUpDownSetValue.Value.ToString()) *
                                Other.Class.Function_Cls.CalculateCostDoctor(
                                int.Parse((GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["CostCachInsu"].Value ?? 0).ToString()),
                                int.Parse((GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["CostCompany"].Value ?? 0).ToString()),
                                0,
                                int.Parse((GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["CostDoctorTax"].Value ?? 0).ToString()),
                                int.Parse((GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["CostDoctorInsurance"].Value ?? 0).ToString()),
                                int.Parse((GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["CostDoctorPrePayment"].Value ?? 0).ToString()))
                                / 100;

                            int CostDoctor = Other.Class.Function_Cls.CalculateCostDoctor(
                                int.Parse((GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["CostCachInsu"].Value ?? 0).ToString()),
                                int.Parse((GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["CostCompany"].Value ?? 0).ToString()),
                                CostIncrease,
                                int.Parse((GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["CostDoctorTax"].Value ?? 0).ToString()),
                                int.Parse((GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["CostDoctorInsurance"].Value ?? 0).ToString()),
                                int.Parse((GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["CostDoctorPrePayment"].Value ?? 0).ToString()));

                            new ViewModel.VisitPatientCare.VisitPatientCarePayment().UpdateEntityWithFieldValue(
                               IDSet, "CostIncrease", CostIncrease.ToString(),
                               MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                               MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                            new ViewModel.VisitPatientCare.VisitPatientCarePayment().UpdateEntityWithFieldValue(
                                IDSet, "CostIncreaseDate", textBoxSetValue.Text == "" ? "" : DatePickerSet.Value.ToString().Substring(0, 10),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                            new ViewModel.VisitPatientCare.VisitPatientCarePayment().UpdateEntityWithFieldValue(
                                IDSet, "CostDoctor", CostDoctor.ToString(),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                        }
                        else if (comboBoxSetValue.SelectedIndex == 10)
                            new ViewModel.VisitPatientCare.VisitPatientCarePayment().UpdateEntityWithFieldValue(
                                IDSet, "PaymentDoctorDate", DatePickerSet.Value.ToString().Substring(0, 10),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                        else if (comboBoxSetValue.SelectedIndex == 11)
                            new ViewModel.VisitPatientCare.VisitPatientCarePayment().UpdateEntityWithFieldValue(
                                IDSet, "Description", textBoxSetValue.Text,
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);
                        
                        else if (comboBoxSetValue.SelectedIndex == 12)
                            new ViewModel.VisitPatientCare.VisitPatientCarePayment().UpdateEntityWithFieldValue(
                                IDSet, "CasherName", textBoxSetValue.Text,
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);
                        
                        else if (comboBoxSetValue.SelectedIndex == 13)
                            new ViewModel.VisitPatientCare.VisitPatientCarePayment().UpdateEntityWithFieldValue(
                                IDSet, "CasherNationalCode", textBoxSetValue.Text,
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                        else if (comboBoxSetValue.SelectedIndex == 14)
                        {
                            if (comboBoxBank.SelectedIndex == -1) comboBoxBank.SelectedIndex = 0;

                            new ViewModel.VisitPatientCare.VisitPatientCarePayment().UpdateEntityWithFieldValue(
                                IDSet, "Bank_Id", comboBoxBank.SelectedValue.ToString(),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);
                        }

                        else if (comboBoxSetValue.SelectedIndex == 15)
                            new ViewModel.VisitPatientCare.VisitPatientCarePayment().UpdateEntityWithFieldValue(
                                IDSet, "CardBankNo1", textBoxSetValue.Text,
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                        else if (comboBoxSetValue.SelectedIndex == 16)
                        {
                            new ViewModel.VisitPatientCare.VisitPatientCarePayment().UpdateEntityWithFieldValue(
                                IDSet, "BonyadConfirmNo", textBoxSetValue.Text,
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                            new ViewModel.VisitPatientCare.VisitPatientCarePayment().UpdateEntityWithFieldValue(
                                IDSet, "BonyadConfirmDate", textBoxSetValue.Text == "" ? "" : DatePickerSet.Value.ToString().Substring(0, 10),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);


                        }
                        else if (comboBoxSetValue.SelectedIndex == 17)
                        {
                            new ViewModel.VisitPatientCare.VisitPatientCarePayment().UpdateEntityWithFieldValue(
                                IDSet, "SecretiatNo", textBoxSetValue.Text,
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                            new ViewModel.VisitPatientCare.VisitPatientCarePayment().UpdateEntityWithFieldValue(
                                IDSet, "SecretiatDate", textBoxSetValue.Text == "" ? "" : DatePickerSet.Value.ToString().Substring(0, 10),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                        }
                        else if (comboBoxSetValue.SelectedIndex == 18)
                            new ViewModel.VisitPatientCare.VisitPatientCarePayment().UpdateEntityWithFieldValue(
                                IDSet, "CityPart", textBoxSetValue.Text,
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);
                        else if (comboBoxSetValue.SelectedIndex == 19)
                            new ViewModel.VisitPatientCare.VisitPatientCarePayment().UpdateEntityWithFieldValue(
                                IDSet, "ShiftFew", nUpDownSetValue.Value.ToString(),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);
                        else if (comboBoxSetValue.SelectedIndex == 20)
                            new ViewModel.VisitPatientCare.VisitPatientCarePayment().UpdateEntityWithFieldValue(
                                IDSet, "ReportCode", nUpDownSetValue.Value.ToString(),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);


                        
                        else if (comboBoxSetValue.SelectedIndex == 21) //CostDoctorTax
                        {
                            //double DoctorTaxPercent = double.Parse((GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["CostDoctorTax"].Value ?? 0).ToString()) * 100 / (double.Parse((GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["CostCachInsu"].Value ?? 0).ToString()) - double.Parse((GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["CostCompany"].Value ?? 0).ToString()));
                            //double CostInsurancePercent = double.Parse((GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["CostDoctorInsurance"].Value ?? 0).ToString()) * 100 / (double.Parse((GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["CostCachInsu"].Value ?? 0).ToString()) - double.Parse((GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["CostCompany"].Value ?? 0).ToString()));
                            //double CostCompanyVisitPercent = double.Parse((GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["CostCachInsu"].Value ?? 0).ToString()) * 100 / double.Parse((GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["CostCompany"].Value ?? 0).ToString());

                            int CostCachInsu = int.Parse((GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["CostCachInsu"].Value ?? 0).ToString());
                            int CostCompany = int.Parse((GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["CostCompany"].Value ?? 0).ToString());
                            int CostDoctorTax = int.Parse(nUpDownSetValue.Value.ToString());
                            int CostDoctorInsurance = int.Parse((GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["CostDoctorInsurance"].Value ?? 0).ToString());
                            int CostDoctor = Other.Class.Function_Cls.CalculateCostDoctor(
                                CostCachInsu,
                                CostCompany,
                                int.Parse((GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["CostIncrease"].Value ?? 0).ToString()),
                                CostDoctorTax,
                                CostDoctorInsurance,
                                int.Parse((GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["CostDoctorPrePayment"].Value ?? 0).ToString()));

                            new ViewModel.VisitPatientCare.VisitPatientCarePayment().UpdateEntityWithFieldValue(
                                IDSet, "CostDoctorTax", nUpDownSetValue.Value.ToString(),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                            new ViewModel.VisitPatientCare.VisitPatientCarePayment().UpdateEntityWithFieldValue(
                                IDSet, "CostDoctor", CostDoctor.ToString(),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                        }

                        else if (comboBoxSetValue.SelectedIndex == 22)//CostDoctorTax Percent
                        {
                            //double DoctorTaxPercent = double.Parse((GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["CostDoctorTax"].Value ?? 0).ToString()) * 100 / (double.Parse((GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["CostCachInsu"].Value ?? 0).ToString()) - double.Parse((GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["CostCompany"].Value ?? 0).ToString()));
                            //double CostInsurancePercent = double.Parse((GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["CostDoctorInsurance"].Value ?? 0).ToString()) * 100 / (double.Parse((GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["CostCachInsu"].Value ?? 0).ToString()) - double.Parse((GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["CostCompany"].Value ?? 0).ToString()));
                            //double CostCompanyVisitPercent = double.Parse((GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["CostCachInsu"].Value ?? 0).ToString()) * 100 / double.Parse((GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["CostCompany"].Value ?? 0).ToString());

                            int CostCachInsu = int.Parse((GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["CostCachInsu"].Value ?? 0).ToString());
                            int CostCompany = int.Parse((GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["CostCompany"].Value ?? 0).ToString());
                            int CostDoctorTax = Other.Class.Function_Cls.CalculateTax(CostCachInsu, CostCompany, int.Parse(nUpDownSetValue.Value.ToString()));
                            int CostDoctorInsurance = int.Parse((GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["CostDoctorInsurance"].Value ?? 0).ToString());
                            int CostDoctor = Other.Class.Function_Cls.CalculateCostDoctor(
                                CostCachInsu,
                                CostCompany,
                                int.Parse((GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["CostIncrease"].Value ?? 0).ToString()),
                                CostDoctorTax,
                                CostDoctorInsurance,
                                int.Parse((GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["CostDoctorPrePayment"].Value ?? 0).ToString()));

                            new ViewModel.VisitPatientCare.VisitPatientCarePayment().UpdateEntityWithFieldValue(
                                IDSet, "CostDoctorTax", CostDoctorTax.ToString(),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                            new ViewModel.VisitPatientCare.VisitPatientCarePayment().UpdateEntityWithFieldValue(
                                IDSet, "CostDoctor", CostDoctor.ToString(),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                        }

                        else if (comboBoxSetValue.SelectedIndex == 23)//CostDoctorInsurance
                        {
                            double DoctorTaxPercent = double.Parse((GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["CostDoctorTax"].Value ?? 0).ToString()) * 100 / (double.Parse((GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["CostCachInsu"].Value ?? 1).ToString()) - double.Parse((GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["CostCompany"].Value ?? 0).ToString()));
                            double CostInsurancePercent = double.Parse((GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["CostDoctorInsurance"].Value ?? 0).ToString()) * 100 / (double.Parse((GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["CostCachInsu"].Value ?? 1).ToString()) - double.Parse((GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["CostCompany"].Value ?? 0).ToString()));
                            double CostCompanyCarePercent = double.Parse((GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["CostCompany"].Value ?? 0).ToString()) * 100 / double.Parse((GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["CostCachInsu"].Value ?? 1).ToString());
                            if (double.IsNaN(CostCompanyCarePercent) || CostCompanyCarePercent == 0)
                            {
                                CostCompanyCarePercent = double.Parse(new ViewModel.Setting.Setting().GetAllValue("CostCompanyCarePercent", ref str).ToString());
                                DoctorTaxPercent = 0;
                                CostInsurancePercent = double.Parse(new ViewModel.Setting.Setting().GetAllValue("CostInsurancePercent", ref str).ToString());
                            }

                            int CostCachInsu = int.Parse((GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["CostCachInsu"].Value ?? 0).ToString());
                            int CostCompany = int.Parse((GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["CostCompany"].Value ?? 0).ToString());
                            int CostDoctorTax = int.Parse((GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["CostDoctorTax"].Value ?? 0).ToString());
                            int CostDoctorInsurance = int.Parse(nUpDownSetValue.Value.ToString());

                            int CostDoctor = Other.Class.Function_Cls.CalculateCostDoctor(
                                CostCachInsu,
                                CostCompany,
                                int.Parse((GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["CostIncrease"].Value ?? 0).ToString()),
                                CostDoctorTax,
                                CostDoctorInsurance,
                                int.Parse((GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["CostDoctorPrePayment"].Value ?? 0).ToString()));


                            new ViewModel.VisitPatientCare.VisitPatientCarePayment().UpdateEntityWithFieldValue(
                                IDSet, "CostDoctorInsurance", CostDoctorInsurance.ToString(),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                            new ViewModel.VisitPatientCare.VisitPatientCarePayment().UpdateEntityWithFieldValue(
                                IDSet, "CostDoctor", CostDoctor.ToString(),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                        }

                        else if (comboBoxSetValue.SelectedIndex == 24)//CostDoctorInsurance Percent
                        {
                            //double DoctorTaxPercent = double.Parse(nUpDownSetValue.Value.ToString());//double.Parse((GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["CostDoctorTax"].Value ?? 0).ToString()) * 100 / (double.Parse((GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["CostCachInsu"].Value ?? 1).ToString()) - double.Parse((GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["CostCompany"].Value ?? 0).ToString()));
                            //double CostInsurancePercent = double.Parse((GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["CostDoctorInsurance"].Value ?? 0).ToString()) * 100 / (double.Parse((GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["CostCachInsu"].Value ?? 1).ToString()) - double.Parse((GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["CostCompany"].Value ?? 0).ToString()));
                            //double CostCompanyVisitPercent = double.Parse((GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["CostCachInsu"].Value ?? 0).ToString()) * 100 / double.Parse((GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["CostCompany"].Value ?? 1).ToString());

                            int CostCachInsu = int.Parse((GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["CostCachInsu"].Value ?? 0).ToString());
                            int CostCompany = int.Parse((GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["CostCompany"].Value ?? 0).ToString());
                            int CostDoctorTax = int.Parse((GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["CostDoctorTax"].Value ?? 0).ToString());
                            int CostDoctorInsurance = Other.Class.Function_Cls.CalculateInsurance(CostCachInsu, CostCompany, int.Parse(nUpDownSetValue.Value.ToString()));
                            int CostDoctor = Other.Class.Function_Cls.CalculateCostDoctor(
                                CostCachInsu,
                                CostCompany,
                                int.Parse((GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["CostIncrease"].Value ?? 0).ToString()),
                                CostDoctorTax,
                                CostDoctorInsurance,
                                int.Parse((GridViewVisitPatientCarePayment.SelectedItems[i].GetRow().Cells["CostDoctorPrePayment"].Value ?? 0).ToString()));


                            new ViewModel.VisitPatientCare.VisitPatientCarePayment().UpdateEntityWithFieldValue(
                                IDSet, "CostDoctorInsurance", CostDoctorInsurance.ToString(),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                            new ViewModel.VisitPatientCare.VisitPatientCarePayment().UpdateEntityWithFieldValue(
                                IDSet, "CostDoctor", CostDoctor.ToString(),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                        }
                        
                    }

                }
                catch (Exception ex)
                {
                }
                BindData(GridViewVisitPatientCarePayment.Row);
            }

        }

        private void buttonItemCarePaymentCalculateRimindAll_Click(object sender, EventArgs e)
        {
            string str = "";
            if (MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation, true, "آیا مایلید مانده دریافتی ها محاسبه شوند؟"))
            {
                new ViewModel.VisitPatientCare.VisitPatientCarePayment().VisitPatientCarePaymentCalculateRemindAllPayment(ref str);
                BindData(GridViewVisitPatientCarePayment.Row);
            }
        }

        private void ToolStripMenuItemVisitPatientCarePaymentCurrentRow_Click(object sender, EventArgs e)
        {
            try
            {
                string Str = "";
                int J = 0;

                MKH.Library.Forms.MSSLogViewer_frm ctrl = new MKH.Library.Forms.MSSLogViewer_frm();
                ctrl.GridexViewSelector.DataSource = new MKH.Permission.ViewModel.Log.Log().GetAllListVisitPatientCarePaymentByID(System.Convert.ToInt64(GridViewVisitPatientCarePayment.CurrentRow.Cells["Id"].Value), ref Str).ToList();
                ctrl.ColumnList = new System.Data.DataTable();
                for (int i = 0; i < GridViewVisitPatientCarePayment.RootTable.Columns.Count; i++)
                    if (GridViewVisitPatientCarePayment.RootTable.Columns[i].Tag == "" || GridViewVisitPatientCarePayment.RootTable.Columns[i].Tag == null)
                    {
                        ctrl.ColumnList.Columns.Add(GridViewVisitPatientCarePayment.RootTable.Columns[i].Key);
                        ctrl.ColumnList.Columns[J].Caption = GridViewVisitPatientCarePayment.RootTable.Columns[i].Caption;
                        J++;
                    }
                ctrl.ShowDialog();
            }
            catch { }
        }

        private void ToolStripMenuItemVisitPatientCarePaymentAllList_Click(object sender, EventArgs e)
        {
            try
            {
                string Str = "";
                int J = 0;

                MKH.Library.Forms.MSSLogViewer_frm ctrl = new MKH.Library.Forms.MSSLogViewer_frm();
                ctrl.GridexViewSelector.DataSource = new MKH.Permission.ViewModel.Log.Log().GetAllListVisitPatientCarePayment(ref Str).ToList();
                ctrl.ColumnList = new System.Data.DataTable();
                for (int i = 0; i < GridViewVisitPatientCarePayment.RootTable.Columns.Count; i++)
                    if (GridViewVisitPatientCarePayment.RootTable.Columns[i].Visible)
                    {
                        ctrl.ColumnList.Columns.Add(GridViewVisitPatientCarePayment.RootTable.Columns[i].Key);
                        ctrl.ColumnList.Columns[J].Caption = GridViewVisitPatientCarePayment.RootTable.Columns[i].Caption;
                        J++;
                    }
                ctrl.ShowDialog();
            }
            catch { }
        }

       

    }
}
