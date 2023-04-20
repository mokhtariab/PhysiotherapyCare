using System.Linq;
using System.Collections.Generic;
using PhysiotherapyCare.Model.Basic;
using PhysiotherapyCare.Model;
using MKH.Library.Clasess.FilterClass;
using System.Windows.Forms;
using PhysiotherapyCare.Model.VisitPatientPhysiotherapy;
using System;

namespace PhysiotherapyCare.View.MainForms.VisitPatientPhysiotherapy
{
    public partial class VisitPatientPhysiotherapyPayment_UC : UserControl
    {
        public VisitPatientPhysiotherapyPayment_UC()
        {
            InitializeComponent();
        }


        public void BindData(int RowNumberSet)
        {
            string str = "";


            List<VW_VisitPatientPhysiotherapyPayment> LSQ = new List<VW_VisitPatientPhysiotherapyPayment>();

            LSQ = new ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapyPayment().GetAllList(ref str).Where(f => f.PaymentStatus_Id != 8).ToList();
            
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
                GridViewVisitPatientPhysiotherapyPayment.DataSource = LSQ;

            }
            catch { }

            try { GridViewVisitPatientPhysiotherapyPayment.Row = RowNumberSet; }
            catch { }
        }


        #region All UI Button

        private void headerGridVisitPatientPhysiotherapyPayment_btnInsertClick(object sender, System.EventArgs e)
        {
            VisitPatientPhysiotherapyPaymentPrePaymentAdd_Frm VisitPatientPhysiotherapyPaymentPrePaymentAdd = new VisitPatientPhysiotherapyPaymentPrePaymentAdd_Frm();

            if (VisitPatientPhysiotherapyPaymentPrePaymentAdd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                BindData(GridViewVisitPatientPhysiotherapyPayment.RowCount);
        }

        private void headerGridVisitPatientPhysiotherapyPayment_btnEditClick(object sender, System.EventArgs e)
        {
            try
            {
                //if (!(HeaderGridVisitPatientPhysiotherapyPayment as MKH.Library.Control.MSSHeaderGrid).Items["buttonItemEdit"].Visible || !(HeaderGridVisitPatientPhysiotherapyPayment as MKH.Library.Control.MSSHeaderGrid).Items["buttonItemEdit"].Enabled) return;
                if (Convert.ToInt32(GridViewVisitPatientPhysiotherapyPayment.CurrentRow.Cells["CostVisitDoctorBes"].Value) == 0)
                {
                    VisitPatientPhysiotherapyPaymentAdd_Frm VisitPatientPhysiotherapyPaymentAdd = new VisitPatientPhysiotherapyPaymentAdd_Frm(
                            int.Parse(GridViewVisitPatientPhysiotherapyPayment.CurrentRow.Cells["Id"].Value.ToString()));
                    if (VisitPatientPhysiotherapyPaymentAdd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        BindData(GridViewVisitPatientPhysiotherapyPayment.Row);
                }
                else
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View("امکان ویرایش پیش پرداخت وجود ندارد. ابتدا حذف و سپس پیش پرداخت را ثبت نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SWarning);
                    //VisitPatientPhysiotherapyPaymentPrePaymentAdd_Frm VisitPatientPhysiotherapyPaymentAdd = new VisitPatientPhysiotherapyPaymentPrePaymentAdd_Frm(
                    //        int.Parse(GridViewVisitPatientPhysiotherapyPayment.CurrentRow.Cells["Id"].Value.ToString()));
                    //if (VisitPatientPhysiotherapyPaymentAdd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    //    BindData(GridViewVisitPatientPhysiotherapyPayment.Row);
                }
            }
            catch { }
        }

        private void headerGridVisitPatientPhysiotherapyPayment_btnDeleteClick(object sender, System.EventArgs e)
        {
            string str = "";

            for (int i = 0; i < GridViewVisitPatientPhysiotherapyPayment.SelectedItems.Count; i++)
                if (new ViewModel.Basic.NODuplicateForm().CheckNODuplicateForm("TBL_VisitPatientPhysiotherapyPayment", GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["Id"].Value.ToString(), ref str))
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View("امکان حذف به علت انجام عملیات توسط کاربر دیگر بر روی ردیف (هایی) امکان پذیر نمی باشد", MKH.Library.Clasess.MSSMessage.MessageType.SWarning);
                    return;
                }

            if (MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation, true, "آیا به حذف موارد انتخابی اطمینان دارید؟"))
            {
                try
                {
                    //List<TBL_VisitPatientPhysiotherapyPayment> Ls = new List<TBL_VisitPatientPhysiotherapyPayment>();
                    //for (int i = 0; i < GridViewVisitPatientPhysiotherapyPayment.SelectedItems.Count; i++)
                    //{
                    //    TBL_VisitPatientPhysiotherapyPayment VisitPatientPhysiotherapyPayment = new TBL_VisitPatientPhysiotherapyPayment();
                    //    VisitPatientPhysiotherapyPayment.Id = long.Parse(GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["Id"].Value.ToString());
                    //    VisitPatientPhysiotherapyPayment.VisitPatientPhysiotherapy_Id = long.Parse(GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["VisitPatientPhysiotherapy_Id"].Value.ToString());
                    //    VisitPatientPhysiotherapyPayment.PaymentType_Id = short.Parse(GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["PaymentType_Id"].Value.ToString());
                    //    VisitPatientPhysiotherapyPayment.PaymentStatus_Id = short.Parse(GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["PaymentStatus_Id"].Value.ToString());
                    //    Ls.Add(VisitPatientPhysiotherapyPayment);
                    //}

                    //string str = "";
                    //new ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapyPayment().DeleteEntity(Ls, ref str);

                    List<TBL_VisitPatientPhysiotherapyPayment> Ls = new List<TBL_VisitPatientPhysiotherapyPayment>();
                    ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapyPayment RN = new ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapyPayment();
                    for (int i = 0; i < GridViewVisitPatientPhysiotherapyPayment.SelectedItems.Count; i++)
                        Ls.Add(RN.GetAllListByTblID(long.Parse(GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["Id"].Value.ToString()), ref str)[0]);

                    new ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapyPayment().DeleteEntity(Ls, ref str);



                    if (str != "") MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "امکان حذف مورد(های) انتخابی به علت داشتن عملکرد در نرم افزار وجود ندارد", str);
                    else
                    {
                        //for (int i = 0; i < GridViewVisitPatientPhysiotherapyPayment.SelectedItems.Count; i++)
                        //    try
                        //    {
                        //        new ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapy().UpdateVisitStatus(long.Parse(GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["VisitPatientPhysiotherapy_Id"].Value.ToString()), 1,
                        //        MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                        //        MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(System.DateTime.Now),
                        //        ref str);
                        //    }
                        //    catch { }
                        BindData(GridViewVisitPatientPhysiotherapyPayment.Row - 1);
                    }
                }
                catch (System.Exception ex)
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "اشکال", ex.Message);
                }
            }
        }

        private void headerGridVisitPatientPhysiotherapyPayment_btnRefreshClick(object sender, System.EventArgs e)
        {
            BindData(GridViewVisitPatientPhysiotherapyPayment.Row);
        }

        #endregion

        bool SetDate = false;
        private void VisitPatientPhysiotherapyPayment_UC_Load(object sender, System.EventArgs e)
        {
            new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionControl(this);

            SetComboBox();
            buttonItemPhysioterapyPaymentCalculateRimindAll.Enabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(163);
            btnSetValuePhysioterapy.Enabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(164);
            ToolStripMenuItemVisitPatientPhysiotherapyPaymentCurrentRow.Enabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(279);
            ToolStripMenuItemVisitPatientPhysiotherapyPaymentAllList.Enabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(280);

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
            BindData(GridViewVisitPatientPhysiotherapyPayment.Row);
        }

        private void DatePickerStart_ValueChanged(object sender, KagNetComponents2.PersianMonthCalendarEventArgs e)
        {
            if (SetDate) BindData(GridViewVisitPatientPhysiotherapyPayment.Row);
        }

        private void comboBoxSetValue_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            textBoxSetValue.Visible = comboBoxSetValue.SelectedIndex == 3 || comboBoxSetValue.SelectedIndex == 4 || comboBoxSetValue.SelectedIndex == 5 || comboBoxSetValue.SelectedIndex == 10 || comboBoxSetValue.SelectedIndex == 12 || comboBoxSetValue.SelectedIndex == 13 || comboBoxSetValue.SelectedIndex == 14 || comboBoxSetValue.SelectedIndex == 19;
            nUpDownSetValue.Visible = comboBoxSetValue.SelectedIndex == 1 || comboBoxSetValue.SelectedIndex == 2 || comboBoxSetValue.SelectedIndex == 6 || comboBoxSetValue.SelectedIndex == 7 || comboBoxSetValue.SelectedIndex == 8 || comboBoxSetValue.SelectedIndex == 9 || comboBoxSetValue.SelectedIndex == 11 || comboBoxSetValue.SelectedIndex == 15 || comboBoxSetValue.SelectedIndex == 16 || comboBoxSetValue.SelectedIndex == 17 || comboBoxSetValue.SelectedIndex == 18;
            comboBoxPaymentStatus.Visible = comboBoxSetValue.SelectedIndex == 0;
            comboBoxBank.Visible = comboBoxSetValue.SelectedIndex == 20;
        }

        private void btnSetValue_Click(object sender, System.EventArgs e)
        {
            string str = "";
            long IDSet = 0;

            for (int i = 0; i < GridViewVisitPatientPhysiotherapyPayment.SelectedItems.Count; i++)
                if (new ViewModel.Basic.NODuplicateForm().CheckNODuplicateForm("TBL_VisitPatientPhysiotherapyPayment", GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["Id"].Value.ToString(), ref str))
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View("امکان تغییرات به علت انجام عملیات توسط کاربر دیگر امکان پذیر نمی باشد. لطفا کمی بعد سعی کنید", MKH.Library.Clasess.MSSMessage.MessageType.SWarning);
                    return;
                }

            if (MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation, true, "آیا مقدار درخواستی جهت ردیف های انتخابی ثبت شود؟"))
            {
                try
                {
                    //int CostCompanyPhysiotherapyPercent = new ViewModel.Setting.Setting().GetAllValue("CostCompanyPhsiotraphyPercent", ref str).ToString().ToInt();

                    for (int i = 0; i < GridViewVisitPatientPhysiotherapyPayment.SelectedItems.Count; i++)
                    {
                        IDSet = long.Parse(GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["Id"].Value.ToString());
                        if (Convert.ToInt32(GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["CostVisitDoctorBes"].Value) != 0
                            && comboBoxSetValue.SelectedIndex != 0
                            && comboBoxSetValue.SelectedIndex != 5
                            && comboBoxSetValue.SelectedIndex != 10
                            && comboBoxSetValue.SelectedIndex != 12
                            )
                            //if (GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["PaymentTypeName"].Value.ToString() == "پیش پرداخت" ||
                            //    GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["PaymentTypeName"].Value.ToString() == "کسورات")
                            continue;


                        if (comboBoxSetValue.SelectedIndex == 0)
                        {
                            if (comboBoxPaymentStatus.SelectedIndex == -1) comboBoxPaymentStatus.SelectedIndex = 0;

                            new ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapyPayment().UpdateEntityWithFieldValue(
                                IDSet, "PaymentStatus_Id", (comboBoxPaymentStatus.SelectedIndex + 1).ToString(),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                            new ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapyPayment().UpdateEntityWithFieldValue(
                                IDSet, "PaymentStatusDate", DatePickerSet.Value.ToString().Substring(0, 10),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);
                        }
                        else if (comboBoxSetValue.SelectedIndex == 1)//CostCachInsu
                        {
                            double DoctorTaxPercent = double.Parse((GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["CostDoctorTax"].Value ?? 0).ToString()) * 100 / (double.Parse((GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["CostCachInsu"].Value ?? 1).ToString()) - double.Parse((GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["CostCompany"].Value ?? 0).ToString()));
                            double CostInsurancePercent = double.Parse((GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["CostDoctorInsurance"].Value ?? 0).ToString()) * 100 / (double.Parse((GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["CostCachInsu"].Value ?? 1).ToString()) - double.Parse((GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["CostCompany"].Value ?? 0).ToString()));
                            double CostCompanyPhysiotherapyPercent = double.Parse((GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["CostCompany"].Value ?? 0).ToString()) * 100 / double.Parse((GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["CostCachInsu"].Value ?? 1).ToString());
                            if (double.IsNaN(CostCompanyPhysiotherapyPercent) || CostCompanyPhysiotherapyPercent == 0)
                            {
                                CostCompanyPhysiotherapyPercent = double.Parse(new ViewModel.Setting.Setting().GetAllValue("CostCompanyPhsiotraphyPercent", ref str).ToString());

                                try { DoctorTaxPercent = new ViewModel.Doctors.Doctor().GetAllListByID(int.Parse(GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["Doctor_Id"].Value.ToString()), ref str).Last().DoctorTaxPercent.Value; }
                                catch { }
                                CostInsurancePercent = double.Parse(new ViewModel.Setting.Setting().GetAllValue("CostInsurancePercent", ref str).ToString());
                            }

                            int CostCachInsuIran = int.Parse(nUpDownSetValue.Value.ToString());
                            int CostCompany = Other.Class.Function_Cls.CalculateCostCompany(CostCachInsuIran, CostCompanyPhysiotherapyPercent);
                            int CostDoctorTax = Other.Class.Function_Cls.CalculateTax(CostCachInsuIran, CostCompany, DoctorTaxPercent);
                            int CostDoctorInsurance = Other.Class.Function_Cls.CalculateInsurance(CostCachInsuIran, CostCompany, CostInsurancePercent);
                            int CostDoctor = Other.Class.Function_Cls.CalculateCostDoctor(CostCachInsuIran, CostCompany,
                                int.Parse((GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["CostIncrease"].Value ?? 0).ToString()),
                                CostDoctorTax, CostDoctorInsurance,
                                int.Parse((GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["CostDoctorPrePayment"].Value ?? 0).ToString()));


                            new ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapyPayment().UpdateEntityWithFieldValue(
                                IDSet, "CostCachInsu", CostCachInsuIran.ToString(),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                            new ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapyPayment().UpdateEntityWithFieldValue(
                                IDSet, "CostCompany", CostCompany.ToString(),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                            new ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapyPayment().UpdateEntityWithFieldValue(
                                IDSet, "CostDoctorTax", CostDoctorTax.ToString(),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                            new ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapyPayment().UpdateEntityWithFieldValue(
                                IDSet, "CostDoctorInsurance", CostDoctorInsurance.ToString(),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                            new ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapyPayment().UpdateEntityWithFieldValue(
                                IDSet, "CostDoctor", CostDoctor.ToString(),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);
                        }
                        else if (comboBoxSetValue.SelectedIndex == 2)
                            new ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapyPayment().UpdateEntityWithFieldValue(
                                IDSet, "AnalyzePage", nUpDownSetValue.Value.ToString(),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                        else if (comboBoxSetValue.SelectedIndex == 3)
                        {
                            new ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapyPayment().UpdateEntityWithFieldValue(
                                IDSet, "AnalyzeNo", textBoxSetValue.Text,
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                            new ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapyPayment().UpdateEntityWithFieldValue(
                                IDSet, "AnalyzeDate", textBoxSetValue.Text == "" ? "" : DatePickerSet.Value.ToString().Substring(0, 10),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                        }
                        else if (comboBoxSetValue.SelectedIndex == 4)
                        {
                            new ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapyPayment().UpdateEntityWithFieldValue(
                                   IDSet, "AccountingDocumentNumber", textBoxSetValue.Text,
                                   MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                   MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                            new ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapyPayment().UpdateEntityWithFieldValue(
                                IDSet, "AccountingDocumentDate", textBoxSetValue.Text == "" ? "" : DatePickerSet.Value.ToString().Substring(0, 10),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                        }

                        else if (comboBoxSetValue.SelectedIndex == 5)
                        {
                            new ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapyPayment().UpdateEntityWithFieldValue(
                                   IDSet, "BursaryNumber", textBoxSetValue.Text,
                                   MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                   MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                            new ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapyPayment().UpdateEntityWithFieldValue(
                                IDSet, "BursaryDate", textBoxSetValue.Text == "" ? "" : DatePickerSet.Value.ToString().Substring(0, 10),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);
                        }
                        else if (comboBoxSetValue.SelectedIndex == 6)//CostCompany
                        {
                            double DoctorTaxPercent = double.Parse((GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["CostDoctorTax"].Value ?? 0).ToString()) * 100 / (double.Parse((GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["CostCachInsu"].Value ?? 1).ToString()) - double.Parse((GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["CostCompany"].Value ?? 0).ToString()));
                            double CostInsurancePercent = double.Parse((GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["CostDoctorInsurance"].Value ?? 0).ToString()) * 100 / (double.Parse((GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["CostCachInsu"].Value ?? 1).ToString()) - double.Parse((GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["CostCompany"].Value ?? 0).ToString()));
                            double CostCompanyPhysiotherapyPercent = double.Parse((GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["CostCompany"].Value ?? 0).ToString()) * 100 / double.Parse((GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["CostCachInsu"].Value ?? 1).ToString());
                            if (double.IsNaN(CostCompanyPhysiotherapyPercent) || CostCompanyPhysiotherapyPercent == 0)
                            {
                                CostCompanyPhysiotherapyPercent = double.Parse(new ViewModel.Setting.Setting().GetAllValue("CostCompanyPhsiotraphyPercent", ref str).ToString());

                                try { DoctorTaxPercent = new ViewModel.Doctors.Doctor().GetAllListByID(int.Parse(GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["Doctor_Id"].Value.ToString()), ref str).Last().DoctorTaxPercent.Value; }
                                catch { }
                                CostInsurancePercent = double.Parse(new ViewModel.Setting.Setting().GetAllValue("CostInsurancePercent", ref str).ToString());
                            }

                            int CostCachInsu = int.Parse((GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["CostCachInsu"].Value ?? 0).ToString());
                            int CostCompany = int.Parse(nUpDownSetValue.Value.ToString());
                            int CostDoctorTax = Other.Class.Function_Cls.CalculateTax(CostCachInsu, CostCompany, DoctorTaxPercent);
                            int CostDoctorInsurance = Other.Class.Function_Cls.CalculateInsurance(CostCachInsu, CostCompany, CostInsurancePercent);
                            int CostDoctor = Other.Class.Function_Cls.CalculateCostDoctor(CostCachInsu, CostCompany,
                                int.Parse((GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["CostIncrease"].Value ?? 0).ToString()),
                                CostDoctorTax, CostDoctorInsurance,
                                int.Parse((GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["CostDoctorPrePayment"].Value ?? 0).ToString()));


                            new ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapyPayment().UpdateEntityWithFieldValue(
                                IDSet, "CostCompany", CostCompany.ToString(),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                            new ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapyPayment().UpdateEntityWithFieldValue(
                                IDSet, "CostDoctorTax", CostDoctorTax.ToString(),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                            new ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapyPayment().UpdateEntityWithFieldValue(
                                IDSet, "CostDoctorInsurance", CostDoctorInsurance.ToString(),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                            new ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapyPayment().UpdateEntityWithFieldValue(
                                IDSet, "CostDoctor", CostDoctor.ToString(),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);
                        }
                        else if (comboBoxSetValue.SelectedIndex == 7)//CostCompany Percent
                        {
                            double DoctorTaxPercent = double.Parse((GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["CostDoctorTax"].Value ?? 0).ToString()) * 100 / (double.Parse((GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["CostCachInsu"].Value ?? 1).ToString()) - double.Parse((GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["CostCompany"].Value ?? 0).ToString()));
                            double CostInsurancePercent = double.Parse((GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["CostDoctorInsurance"].Value ?? 0).ToString()) * 100 / (double.Parse((GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["CostCachInsu"].Value ?? 1).ToString()) - double.Parse((GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["CostCompany"].Value ?? 0).ToString()));
                            double CostCompanyPhysiotherapyPercent = double.Parse((GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["CostCompany"].Value ?? 0).ToString()) * 100 / double.Parse((GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["CostCachInsu"].Value ?? 1).ToString());
                            if (double.IsNaN(CostCompanyPhysiotherapyPercent) || CostCompanyPhysiotherapyPercent == 0)
                            {
                                CostCompanyPhysiotherapyPercent = double.Parse(new ViewModel.Setting.Setting().GetAllValue("CostCompanyPhsiotraphyPercent", ref str).ToString());

                                try { DoctorTaxPercent = new ViewModel.Doctors.Doctor().GetAllListByID(int.Parse(GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["Doctor_Id"].Value.ToString()), ref str).Last().DoctorTaxPercent.Value; }
                                catch { }
                                CostInsurancePercent = double.Parse(new ViewModel.Setting.Setting().GetAllValue("CostInsurancePercent", ref str).ToString());
                            }

                            int CostCachInsu = int.Parse((GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["CostCachInsu"].Value ?? 0).ToString());
                            int CostCompany = int.Parse(nUpDownSetValue.Value.ToString()) * int.Parse((GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["CostCachInsu"].Value ?? 0).ToString()) / 100;
                            int CostDoctorTax = Other.Class.Function_Cls.CalculateTax(CostCachInsu, CostCompany, DoctorTaxPercent);
                            int CostDoctorInsurance = Other.Class.Function_Cls.CalculateInsurance(CostCachInsu, CostCompany, CostInsurancePercent);
                            int CostDoctor = Other.Class.Function_Cls.CalculateCostDoctor(CostCachInsu, CostCompany,
                                int.Parse((GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["CostIncrease"].Value ?? 0).ToString()),
                                CostDoctorTax, CostDoctorInsurance,
                                int.Parse((GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["CostDoctorPrePayment"].Value ?? 0).ToString()));

                            new ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapyPayment().UpdateEntityWithFieldValue(
                                IDSet, "CostCompany", CostCompany.ToString(),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                            new ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapyPayment().UpdateEntityWithFieldValue(
                                IDSet, "CostDoctorTax", CostDoctorTax.ToString(),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                            new ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapyPayment().UpdateEntityWithFieldValue(
                                IDSet, "CostDoctorInsurance", CostDoctorInsurance.ToString(),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                            new ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapyPayment().UpdateEntityWithFieldValue(
                                IDSet, "CostDoctor", CostDoctor.ToString(),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);
                        }
                        else if (comboBoxSetValue.SelectedIndex == 8) //CostIncrease
                        {

                            int CostDoctor = Other.Class.Function_Cls.CalculateCostDoctor(
                                int.Parse((GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["CostCachInsu"].Value ?? 0).ToString()),
                                int.Parse((GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["CostCompany"].Value ?? 0).ToString()),
                                int.Parse(nUpDownSetValue.Value.ToString()),
                                int.Parse((GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["CostDoctorTax"].Value ?? 0).ToString()),
                                int.Parse((GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["CostDoctorInsurance"].Value ?? 0).ToString()),
                                int.Parse((GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["CostDoctorPrePayment"].Value ?? 0).ToString()));

                            new ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapyPayment().UpdateEntityWithFieldValue(
                               IDSet, "CostIncrease", nUpDownSetValue.Value.ToString(),
                               MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                               MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                            new ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapyPayment().UpdateEntityWithFieldValue(
                                IDSet, "CostIncreaseDate", textBoxSetValue.Text == "" ? "" : DatePickerSet.Value.ToString().Substring(0, 10),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                            new ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapyPayment().UpdateEntityWithFieldValue(
                                IDSet, "CostDoctor", CostDoctor.ToString(),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);
                        }
                        else if (comboBoxSetValue.SelectedIndex == 9) //CostIncrease Percent
                        {
                            int CostIncrease = int.Parse(nUpDownSetValue.Value.ToString()) *
                                Other.Class.Function_Cls.CalculateCostDoctor(
                                int.Parse((GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["CostCachInsu"].Value ?? 0).ToString()),
                                int.Parse((GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["CostCompany"].Value ?? 0).ToString()),
                                0,
                                int.Parse((GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["CostDoctorTax"].Value ?? 0).ToString()),
                                int.Parse((GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["CostDoctorInsurance"].Value ?? 0).ToString()),
                                int.Parse((GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["CostDoctorPrePayment"].Value ?? 0).ToString()))
                                / 100;

                            int CostDoctor = Other.Class.Function_Cls.CalculateCostDoctor(
                                int.Parse((GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["CostCachInsu"].Value ?? 0).ToString()),
                                int.Parse((GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["CostCompany"].Value ?? 0).ToString()),
                                CostIncrease,
                                int.Parse((GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["CostDoctorTax"].Value ?? 0).ToString()),
                                int.Parse((GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["CostDoctorInsurance"].Value ?? 0).ToString()),
                                int.Parse((GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["CostDoctorPrePayment"].Value ?? 0).ToString()));


                            new ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapyPayment().UpdateEntityWithFieldValue(
                               IDSet, "CostIncrease", CostIncrease.ToString(),
                               MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                               MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                            new ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapyPayment().UpdateEntityWithFieldValue(
                                IDSet, "CostIncreaseDate", textBoxSetValue.Text == "" ? "" : DatePickerSet.Value.ToString().Substring(0, 10),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                            new ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapyPayment().UpdateEntityWithFieldValue(
                                IDSet, "CostDoctor", CostDoctor.ToString(),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                        }
                        else if (comboBoxSetValue.SelectedIndex == 10)
                            new ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapyPayment().UpdateEntityWithFieldValue(
                                IDSet, "PaymentDoctorDate", DatePickerSet.Value.ToString().Substring(0, 10),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                        else if (comboBoxSetValue.SelectedIndex == 11) //CostDoctorTax
                        {
                            //double DoctorTaxPercent = double.Parse((GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["CostDoctorTax"].Value ?? 0).ToString()) * 100 / (double.Parse((GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["CostCachInsu"].Value ?? 0).ToString()) - double.Parse((GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["CostCompany"].Value ?? 0).ToString()));
                            //double CostInsurancePercent = double.Parse((GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["CostDoctorInsurance"].Value ?? 0).ToString()) * 100 / (double.Parse((GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["CostCachInsu"].Value ?? 0).ToString()) - double.Parse((GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["CostCompany"].Value ?? 0).ToString()));
                            //double CostCompanyHealthPercent = double.Parse((GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["CostCachInsu"].Value ?? 0).ToString()) * 100 / double.Parse((GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["CostCompany"].Value ?? 0).ToString());

                            int CostCachInsu = int.Parse((GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["CostCachInsu"].Value ?? 0).ToString());
                            int CostCompany = int.Parse((GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["CostCompany"].Value ?? 0).ToString());
                            int CostDoctorTax = int.Parse(nUpDownSetValue.Value.ToString());
                            int CostDoctorInsurance = int.Parse((GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["CostDoctorInsurance"].Value ?? 0).ToString());
                            int CostDoctor = Other.Class.Function_Cls.CalculateCostDoctor(
                                CostCachInsu,
                                CostCompany,
                                int.Parse((GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["CostIncrease"].Value ?? 0).ToString()),
                                CostDoctorTax,
                                CostDoctorInsurance,
                                int.Parse((GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["CostDoctorPrePayment"].Value ?? 0).ToString()));

                            
                            new ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapyPayment().UpdateEntityWithFieldValue(
                                IDSet, "CostDoctorTax", nUpDownSetValue.Value.ToString(),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                            new ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapyPayment().UpdateEntityWithFieldValue(
                                IDSet, "CostDoctor", CostDoctor.ToString(),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                        }
                        else if (comboBoxSetValue.SelectedIndex == 12)
                            new ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapyPayment().UpdateEntityWithFieldValue(
                                IDSet, "Description", textBoxSetValue.Text,
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                        else if (comboBoxSetValue.SelectedIndex == 13)
                        {
                            new ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapyPayment().UpdateEntityWithFieldValue(
                                   IDSet, "BonyadConfirmNo", textBoxSetValue.Text,
                                   MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                   MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                            new ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapyPayment().UpdateEntityWithFieldValue(
                                IDSet, "BonyadConfirmDate", textBoxSetValue.Text == "" ? "" : DatePickerSet.Value.ToString().Substring(0, 10),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);
                        }
                        else if (comboBoxSetValue.SelectedIndex == 14)
                        {
                            new ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapyPayment().UpdateEntityWithFieldValue(
                                IDSet, "SecretiatNo", textBoxSetValue.Text,
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                            new ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapyPayment().UpdateEntityWithFieldValue(
                                IDSet, "SecretiatDate", textBoxSetValue.Text == "" ? "" : DatePickerSet.Value.ToString().Substring(0, 10),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                        }
                        else if (comboBoxSetValue.SelectedIndex == 15)//CostDoctorTax Percent
                        {
                            //double DoctorTaxPercent = double.Parse((GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["CostDoctorTax"].Value ?? 0).ToString()) * 100 / (double.Parse((GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["CostCachInsu"].Value ?? 0).ToString()) - double.Parse((GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["CostCompany"].Value ?? 0).ToString()));
                            //double CostInsurancePercent = double.Parse((GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["CostDoctorInsurance"].Value ?? 0).ToString()) * 100 / (double.Parse((GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["CostCachInsu"].Value ?? 0).ToString()) - double.Parse((GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["CostCompany"].Value ?? 0).ToString()));
                            //double CostCompanyHealthPercent = double.Parse((GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["CostCachInsu"].Value ?? 0).ToString()) * 100 / double.Parse((GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["CostCompany"].Value ?? 0).ToString());

                            int CostCachInsu = int.Parse((GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["CostCachInsu"].Value ?? 0).ToString());
                            int CostCompany = int.Parse((GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["CostCompany"].Value ?? 0).ToString());
                            int CostDoctorTax = Other.Class.Function_Cls.CalculateTax(CostCachInsu, CostCompany, int.Parse(nUpDownSetValue.Value.ToString()));
                            int CostDoctorInsurance = int.Parse((GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["CostDoctorInsurance"].Value ?? 0).ToString());
                            int CostDoctor = Other.Class.Function_Cls.CalculateCostDoctor(
                                CostCachInsu,
                                CostCompany,
                                int.Parse((GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["CostIncrease"].Value ?? 0).ToString()),
                                CostDoctorTax,
                                CostDoctorInsurance,
                                int.Parse((GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["CostDoctorPrePayment"].Value ?? 0).ToString()));


                            new ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapyPayment().UpdateEntityWithFieldValue(
                                IDSet, "CostDoctorTax", CostDoctorTax.ToString(),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                            new ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapyPayment().UpdateEntityWithFieldValue(
                                IDSet, "CostDoctor", CostDoctor.ToString(),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                        }
                        else if (comboBoxSetValue.SelectedIndex == 16)
                            new ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapyPayment().UpdateEntityWithFieldValue(
                                IDSet, "ReportCode", nUpDownSetValue.Value.ToString(),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);
                    


                        else if (comboBoxSetValue.SelectedIndex == 17)//CostDoctorInsurance
                        {
                            double DoctorTaxPercent = double.Parse((GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["CostDoctorTax"].Value ?? 0).ToString()) * 100 / (double.Parse((GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["CostCachInsu"].Value ?? 1).ToString()) - double.Parse((GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["CostCompany"].Value ?? 0).ToString()));
                            double CostInsurancePercent = double.Parse((GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["CostDoctorInsurance"].Value ?? 0).ToString()) * 100 / (double.Parse((GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["CostCachInsu"].Value ?? 1).ToString()) - double.Parse((GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["CostCompany"].Value ?? 0).ToString()));
                            double CostCompanyPhysiotherapyPercent = double.Parse((GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["CostCompany"].Value ?? 0).ToString()) * 100 / double.Parse((GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["CostCachInsu"].Value ?? 1).ToString());
                            if (double.IsNaN(CostCompanyPhysiotherapyPercent) || CostCompanyPhysiotherapyPercent == 0)
                            {
                                CostCompanyPhysiotherapyPercent = double.Parse(new ViewModel.Setting.Setting().GetAllValue("CostCompanyPhsiotraphyPercent", ref str).ToString());

                                try { DoctorTaxPercent = new ViewModel.Doctors.Doctor().GetAllListByID(int.Parse(GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["Doctor_Id"].Value.ToString()), ref str).Last().DoctorTaxPercent.Value; }
                                catch { }
                                CostInsurancePercent = double.Parse(new ViewModel.Setting.Setting().GetAllValue("CostInsurancePercent", ref str).ToString());
                            }

                            int CostCachInsu = int.Parse((GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["CostCachInsu"].Value ?? 0).ToString());
                            int CostCompany = int.Parse((GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["CostCompany"].Value ?? 0).ToString());
                            int CostDoctorTax = int.Parse((GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["CostDoctorTax"].Value ?? 0).ToString());
                            int CostDoctorInsurance = int.Parse(nUpDownSetValue.Value.ToString());
                                
                            int CostDoctor = Other.Class.Function_Cls.CalculateCostDoctor(
                                CostCachInsu,
                                CostCompany,
                                int.Parse((GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["CostIncrease"].Value ?? 0).ToString()),
                                CostDoctorTax,
                                CostDoctorInsurance,
                                int.Parse((GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["CostDoctorPrePayment"].Value ?? 0).ToString()));


                            new ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapyPayment().UpdateEntityWithFieldValue(
                                IDSet, "CostDoctorInsurance", CostDoctorInsurance.ToString(),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                            new ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapyPayment().UpdateEntityWithFieldValue(
                                IDSet, "CostDoctor", CostDoctor.ToString(),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                        }

                        else if (comboBoxSetValue.SelectedIndex == 18)//CostDoctorInsurance Percent
                        {
                            //double DoctorTaxPercent = double.Parse(nUpDownSetValue.Value.ToString());//double.Parse((GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["CostDoctorTax"].Value ?? 0).ToString()) * 100 / (double.Parse((GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["CostCachInsu"].Value ?? 0).ToString()) - double.Parse((GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["CostCompany"].Value ?? 0).ToString()));
                            //double CostInsurancePercent = double.Parse((GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["CostDoctorInsurance"].Value ?? 0).ToString()) * 100 / (double.Parse((GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["CostCachInsu"].Value ?? 0).ToString()) - double.Parse((GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["CostCompany"].Value ?? 0).ToString()));
                            //double CostCompanyHealthPercent = double.Parse((GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["CostCachInsu"].Value ?? 0).ToString()) * 100 / double.Parse((GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["CostCompany"].Value ?? 0).ToString());

                            int CostCachInsu = int.Parse((GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["CostCachInsu"].Value ?? 0).ToString());
                            int CostCompany = int.Parse((GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["CostCompany"].Value ?? 0).ToString());
                            int CostDoctorTax = int.Parse((GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["CostDoctorTax"].Value ?? 0).ToString());
                            int CostDoctorInsurance = Other.Class.Function_Cls.CalculateInsurance(CostCachInsu, CostCompany, int.Parse(nUpDownSetValue.Value.ToString()));
                            int CostDoctor = Other.Class.Function_Cls.CalculateCostDoctor(
                                CostCachInsu,
                                CostCompany,
                                int.Parse((GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["CostIncrease"].Value ?? 0).ToString()),
                                CostDoctorTax,
                                CostDoctorInsurance,
                                int.Parse((GridViewVisitPatientPhysiotherapyPayment.SelectedItems[i].GetRow().Cells["CostDoctorPrePayment"].Value ?? 0).ToString()));


                            new ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapyPayment().UpdateEntityWithFieldValue(
                                IDSet, "CostDoctorInsurance", CostDoctorInsurance.ToString(),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                            new ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapyPayment().UpdateEntityWithFieldValue(
                                IDSet, "CostDoctor", CostDoctor.ToString(),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                        }

                        else if (comboBoxSetValue.SelectedIndex == 19)
                            new ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapyPayment().UpdateEntityWithFieldValue(
                                IDSet, "CardBankNo1", textBoxSetValue.Text,
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                        else if (comboBoxSetValue.SelectedIndex == 20)
                        {
                            if (comboBoxBank.SelectedIndex == -1) comboBoxBank.SelectedIndex = 0;

                            new ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapyPayment().UpdateEntityWithFieldValue(
                                IDSet, "BankName", comboBoxBank.Text,
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);
                        }



                    }
                }
                catch (Exception ex)
                {
                }
                BindData(GridViewVisitPatientPhysiotherapyPayment.Row);
            }
        }

        private void buttonItemPhysioterapyPaymentCalculateRimindAll_Click(object sender, EventArgs e)
        {
            string str = "";
            if (MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation, true, "آیا مایلید مانده دریافتی ها محاسبه شوند؟"))
            {
                new ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapyPayment().VisitPatientPhysiotherapyPaymentCalculateRemindAllPayment(ref str);
                BindData(GridViewVisitPatientPhysiotherapyPayment.Row);
            }
        }

        private void ToolStripMenuItemVisitPatientPhysiotherapyPaymentAllList_Click(object sender, EventArgs e)
        {
            try
            {
                string Str = "";
                int J = 0;

                MKH.Library.Forms.MSSLogViewer_frm ctrl = new MKH.Library.Forms.MSSLogViewer_frm();
                ctrl.GridexViewSelector.DataSource = new MKH.Permission.ViewModel.Log.Log().GetAllListVisitPatientPhysiotherapyPayment(ref Str).ToList();
                ctrl.ColumnList = new System.Data.DataTable();
                for (int i = 0; i < GridViewVisitPatientPhysiotherapyPayment.RootTable.Columns.Count; i++)
                    if (GridViewVisitPatientPhysiotherapyPayment.RootTable.Columns[i].Visible)
                    {
                        ctrl.ColumnList.Columns.Add(GridViewVisitPatientPhysiotherapyPayment.RootTable.Columns[i].Key);
                        ctrl.ColumnList.Columns[J].Caption = GridViewVisitPatientPhysiotherapyPayment.RootTable.Columns[i].Caption;
                        J++;
                    }
                ctrl.ShowDialog();
            }
            catch { }
        }

        private void ToolStripMenuItemVisitPatientPhysiotherapyPaymentCurrentRow_Click(object sender, EventArgs e)
        {
            try
            {
                string Str = "";
                int J = 0;

                MKH.Library.Forms.MSSLogViewer_frm ctrl = new MKH.Library.Forms.MSSLogViewer_frm();
                ctrl.GridexViewSelector.DataSource = new MKH.Permission.ViewModel.Log.Log().GetAllListVisitPatientPhysiotherapyPaymentByID(System.Convert.ToInt64(GridViewVisitPatientPhysiotherapyPayment.CurrentRow.Cells["Id"].Value), ref Str).ToList();
                ctrl.ColumnList = new System.Data.DataTable();
                for (int i = 0; i < GridViewVisitPatientPhysiotherapyPayment.RootTable.Columns.Count; i++)
                    if (GridViewVisitPatientPhysiotherapyPayment.RootTable.Columns[i].Tag == "" || GridViewVisitPatientPhysiotherapyPayment.RootTable.Columns[i].Tag == null)
                    {
                        ctrl.ColumnList.Columns.Add(GridViewVisitPatientPhysiotherapyPayment.RootTable.Columns[i].Key);
                        ctrl.ColumnList.Columns[J].Caption = GridViewVisitPatientPhysiotherapyPayment.RootTable.Columns[i].Caption;
                        J++;
                    }
                ctrl.ShowDialog();
            }
            catch { }
        }

       


    }
}
