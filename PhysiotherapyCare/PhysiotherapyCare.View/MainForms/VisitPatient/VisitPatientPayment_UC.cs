using System.Linq;
using System.Collections.Generic;
using PhysiotherapyCare.Model.Basic;
using PhysiotherapyCare.Model;
using MKH.Library.Clasess.FilterClass;
using System.Windows.Forms;
using PhysiotherapyCare.Model.VisitPatient;
using System;

namespace PhysiotherapyCare.View.MainForms.VisitPatient
{
    public partial class VisitPatientPayment_UC : UserControl
    {
        public VisitPatientPayment_UC()
        {
            InitializeComponent();
        }


        public void BindData(int RowNumberSet)
        {
            string str = "", WhereStr = "";

            WhereStr = " PaymentStatus_Id <> 8 and ";
            if (ComboBoxSerach.SelectedIndex == 0)
                WhereStr += " PaymentDate >= '" + DatePickerStart.Value.ToString().Substring(0, 10) + "' and PaymentDate <= '" + DatePickerEnd.Value.ToString().Substring(0, 10) + "' and ";
            else if (ComboBoxSerach.SelectedIndex == 1)
                WhereStr = " LetterDate >= '" + DatePickerStart.Value.ToString().Substring(0, 10) + "' and LetterDate <= '" + DatePickerEnd.Value.ToString().Substring(0, 10) + "' and ";
            else if (ComboBoxSerach.SelectedIndex == 2)
                WhereStr = " ContractDate >= '" + DatePickerStart.Value.ToString().Substring(0, 10) + "' and ContractDate <= '" + DatePickerEnd.Value.ToString().Substring(0, 10) + "' and ";
            else if (ComboBoxSerach.SelectedIndex == 3)
                WhereStr = " VisitDate >= '" + DatePickerStart.Value.ToString().Substring(0, 10) + "' and VisitDate <= '" + DatePickerEnd.Value.ToString().Substring(0, 10) + "' and ";
            else if (ComboBoxSerach.SelectedIndex == 4)
                WhereStr = " InsuLetterDate >= '" + DatePickerStart.Value.ToString().Substring(0, 10) + "' and InsuLetterDate <= '" + DatePickerEnd.Value.ToString().Substring(0, 10) + "' and ";
            else if (ComboBoxSerach.SelectedIndex == 5)
                WhereStr += " SecretiatDate >= '" + DatePickerStart.Value.ToString().Substring(0, 10) + "' and SecretiatDate <= '" + DatePickerEnd.Value.ToString().Substring(0, 10) + "' and ";
            else if (ComboBoxSerach.SelectedIndex == 6)
                WhereStr += " AnalyzeDate >= '" + DatePickerStart.Value.ToString().Substring(0, 10) + "' and AnalyzeDate <= '" + DatePickerEnd.Value.ToString().Substring(0, 10) + "' and ";
            else if (ComboBoxSerach.SelectedIndex == 7)
                WhereStr = " CostIncreaseDate >= '" + DatePickerStart.Value.ToString().Substring(0, 10) + "' and CostIncreaseDate <= '" + DatePickerEnd.Value.ToString().Substring(0, 10) + "' and ";
            else if (ComboBoxSerach.SelectedIndex == 8)
                WhereStr = " PaymentDoctorDate >= '" + DatePickerStart.Value.ToString().Substring(0, 10) + "' and PaymentDoctorDate <= '" + DatePickerEnd.Value.ToString().Substring(0, 10) + "' and ";
            else if (ComboBoxSerach.SelectedIndex == 9)
                WhereStr = " BonyadConfirmDate >= '" + DatePickerStart.Value.ToString().Substring(0, 10) + "' and BonyadConfirmDate <= '" + DatePickerEnd.Value.ToString().Substring(0, 10) + "' and ";
            else if (ComboBoxSerach.SelectedIndex ==10)
                WhereStr += " AccountingDocumentDate >= '" + DatePickerStart.Value.ToString().Substring(0, 10) + "' and AccountingDocumentDate <= '" + DatePickerEnd.Value.ToString().Substring(0, 10) + "' and ";
            else if (ComboBoxSerach.SelectedIndex ==11)
                WhereStr += " BursaryDate >= '" + DatePickerStart.Value.ToString().Substring(0, 10) + "' and BursaryDate <= '" + DatePickerEnd.Value.ToString().Substring(0, 10) + "' and ";
            WhereStr += " 1=1 ";

            GridViewVisitPatientPayment.DataSource = new ViewModel.VisitPatient.VisitPatientPayment().GetAllListSet(WhereStr, ref str).ToList();

            try { GridViewVisitPatientPayment.Row = RowNumberSet; }
            catch { }

            //List<VW_VisitPatientPayment> LSQ = new List<VW_VisitPatientPayment>();

            //LSQ = new ViewModel.VisitPatient.VisitPatientPayment().GetAllList(ref str).Where(f => f.PaymentStatus_Id != 8).ToList();
            
            //try
            //{
            //    if (RadioBoxContractWithTime.Checked)
            //    {
            //        if (ComboBoxSerach.SelectedIndex == 0)
            //            LSQ = LSQ.Where(d => MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.PaymentDate ?? "") >= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerStart.Value.ToString())
            //                && MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.PaymentDate ?? "") <= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerEnd.Value.ToString())).ToList();
            //        if (ComboBoxSerach.SelectedIndex == 1)
            //            LSQ = LSQ.Where(d => MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.LetterDate ?? "") >= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerStart.Value.ToString())
            //                && MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.LetterDate ?? "") <= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerEnd.Value.ToString())).ToList();
            //        else if (ComboBoxSerach.SelectedIndex == 2)
            //            LSQ = LSQ.Where(d => MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.ContractDate ?? "") >= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerStart.Value.ToString())
            //                && MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.ContractDate ?? "") <= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerEnd.Value.ToString())).ToList();
            //        else if (ComboBoxSerach.SelectedIndex == 3)
            //            LSQ = LSQ.Where(d => MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.VisitDate ?? "") >= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerStart.Value.ToString())
            //                && MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.VisitDate ?? "") <= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerEnd.Value.ToString())).ToList();
            //        else if (ComboBoxSerach.SelectedIndex == 4)
            //            LSQ = LSQ.Where(d => MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.InsuLetterDate ?? "") >= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerStart.Value.ToString())
            //                && MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.InsuLetterDate ?? "") <= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerEnd.Value.ToString())).ToList();
            //        else if (ComboBoxSerach.SelectedIndex == 5)
            //            LSQ = LSQ.Where(d => MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.SecretiatDate ?? "") >= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerStart.Value.ToString())
            //                && MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.SecretiatDate ?? "") <= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerEnd.Value.ToString())).ToList();
            //        else if (ComboBoxSerach.SelectedIndex == 6)
            //            LSQ = LSQ.Where(d => MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.AnalyzeDate ?? "") >= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerStart.Value.ToString())
            //                && MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.AnalyzeDate ?? "") <= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerEnd.Value.ToString())).ToList();
            //        else if (ComboBoxSerach.SelectedIndex == 7)
            //            LSQ = LSQ.Where(d => MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.CostIncreaseDate ?? "") >= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerStart.Value.ToString())
            //                && MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.CostIncreaseDate ?? "") <= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerEnd.Value.ToString())).ToList();
            //        else if (ComboBoxSerach.SelectedIndex == 8)
            //            LSQ = LSQ.Where(d => MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.PaymentDoctorDate ?? "") >= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerStart.Value.ToString())
            //                && MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.PaymentDoctorDate ?? "") <= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerEnd.Value.ToString())).ToList();
            //        else if (ComboBoxSerach.SelectedIndex == 9)
            //            LSQ = LSQ.Where(d => MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.BonyadConfirmDate ?? "") >= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerStart.Value.ToString())
            //                && MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.BonyadConfirmDate ?? "") <= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerEnd.Value.ToString())).ToList();
            //        else if (ComboBoxSerach.SelectedIndex == 10)
            //            LSQ = LSQ.Where(d => MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.AccountingDocumentDate ?? "") >= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerStart.Value.ToString())
            //                && MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.AccountingDocumentDate ?? "") <= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerEnd.Value.ToString())).ToList();
            //        else if (ComboBoxSerach.SelectedIndex == 11)
            //            LSQ = LSQ.Where(d => MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.BursaryDate ?? "") >= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerStart.Value.ToString())
            //                && MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.BursaryDate ?? "") <= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerEnd.Value.ToString())).ToList();

            //    }
            //    //else
            //    GridViewVisitPatientPayment.DataSource = LSQ;

            //}
            //catch { }

            //try { GridViewVisitPatientPayment.Row = RowNumberSet; }
            //catch { }
        }


        #region All UI Button

        private void headerGridVisitPatientPayment_btnInsertClick(object sender, System.EventArgs e)
        {
            VisitPatientPaymentPrePaymentAdd_Frm VisitPatientPaymentPrePaymentAdd = new VisitPatientPaymentPrePaymentAdd_Frm();

            if (VisitPatientPaymentPrePaymentAdd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                BindData(GridViewVisitPatientPayment.RowCount);
        }

        private void headerGridVisitPatientPayment_btnEditClick(object sender, System.EventArgs e)
        {
            try
            {
               // if (!(HeaderGridVisitPatientPayment as MKH.Library.Control.MSSHeaderGrid).Items["buttonItemEdit"].Visible || !(HeaderGridVisitPatientPayment as MKH.Library.Control.MSSHeaderGrid).Items["buttonItemEdit"].Enabled) return;
                if (Convert.ToInt32(GridViewVisitPatientPayment.CurrentRow.Cells["CostVisitDoctorBes"].Value) == 0)
                {
                    VisitPatientPaymentAdd_Frm VisitPatientPaymentAdd = new VisitPatientPaymentAdd_Frm(
                            int.Parse(GridViewVisitPatientPayment.CurrentRow.Cells["Id"].Value.ToString()));
                    if (VisitPatientPaymentAdd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        BindData(GridViewVisitPatientPayment.Row);
                }
                else
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View("امکان ویرایش پیش پرداخت وجود ندارد. ابتدا حذف و سپس پیش پرداخت را ثبت نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SWarning);

                    //VisitPatientPaymentPrePaymentAdd_Frm VisitPatientPaymentAdd = new VisitPatientPaymentPrePaymentAdd_Frm(
                    //        int.Parse(GridViewVisitPatientPayment.CurrentRow.Cells["Id"].Value.ToString()));
                    //if (VisitPatientPaymentAdd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    //    BindData(GridViewVisitPatientPayment.Row);
                }
            }
            catch { }
        }

        private void headerGridVisitPatientPayment_btnDeleteClick(object sender, System.EventArgs e)
        {
            string str = "";
            for (int i = 0; i < GridViewVisitPatientPayment.SelectedItems.Count; i++)
                if (new ViewModel.Basic.NODuplicateForm().CheckNODuplicateForm("TBL_VisitPatientPayment", GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["Id"].Value.ToString(), ref str))
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View("امکان حذف به علت انجام عملیات توسط کاربر دیگر بر روی ردیف (هایی) امکان پذیر نمی باشد", MKH.Library.Clasess.MSSMessage.MessageType.SWarning);
                    return;
                }
            if (MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation, true, "آیا به حذف موارد انتخابی اطمینان دارید؟"))
            {
                try
                {
                    //List<TBL_VisitPatientPayment> Ls = new List<TBL_VisitPatientPayment>();
                    //for (int i = 0; i < GridViewVisitPatientPayment.SelectedItems.Count; i++)
                    //{
                    //    TBL_VisitPatientPayment VisitPatientPayment = new TBL_VisitPatientPayment();
                    //    VisitPatientPayment.Id = long.Parse(GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["Id"].Value.ToString());
                    //    VisitPatientPayment.VisitPatient_Id = long.Parse(GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["VisitPatient_Id"].Value.ToString());
                    //    VisitPatientPayment.PaymentType_Id = short.Parse(GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["PaymentType_Id"].Value.ToString());
                    //    VisitPatientPayment.PaymentStatus_Id = short.Parse(GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["PaymentStatus_Id"].Value.ToString());
                    //    Ls.Add(VisitPatientPayment);
                    //}

                    //string str = "";
                    //new ViewModel.VisitPatient.VisitPatientPayment().DeleteEntity(Ls, ref str);


                    List<TBL_VisitPatientPayment> Ls = new List<TBL_VisitPatientPayment>();
                    ViewModel.VisitPatient.VisitPatientPayment RN = new ViewModel.VisitPatient.VisitPatientPayment();
                    for (int i = 0; i < GridViewVisitPatientPayment.SelectedItems.Count; i++)
                        Ls.Add(RN.GetAllListByTblID(long.Parse(GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["Id"].Value.ToString()), ref str)[0]);

                    new ViewModel.VisitPatient.VisitPatientPayment().DeleteEntity(Ls, ref str);



                    if (str != "") MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "امکان حذف مورد(های) انتخابی به علت داشتن عملکرد در نرم افزار وجود ندارد", str);
                    else
                    {
                        //for (int i = 0; i < GridViewVisitPatientPayment.SelectedItems.Count; i++)
                        //    try
                        //    {
                        //        new ViewModel.VisitPatient.VisitPatient().UpdateVisitStatus(long.Parse(GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["VisitPatient_Id"].Value.ToString()), 1,
                        //        MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                        //        MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(System.DateTime.Now),
                        //        ref str);
                        //    }
                        //    catch { }
                        BindData(GridViewVisitPatientPayment.Row - 1);
                    }
                }
                catch (System.Exception ex)
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "اشکال", ex.Message);
                }
            }
        }

        private void headerGridVisitPatientPayment_btnRefreshClick(object sender, System.EventArgs e)
        {
            BindData(GridViewVisitPatientPayment.Row);
        }

        #endregion

        bool SetDate = false;
        private void VisitPatientPayment_UC_Load(object sender, System.EventArgs e)
        {
            new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionControl(this);

            SetComboBox();
            buttonItemVisitPaymentCalculateRimindAll.Enabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(236);
            btnSetValueVisit.Enabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(237);
            ToolStripMenuItemVisitPatientPaymentCurrentRow.Enabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(260);
            ToolStripMenuItemVisitPatientPaymentAllList.Enabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(261);

            try
            {
                SetDate = false;
                DatePickerSet.Value = KagNetComponents2.KagPersianDate.Now;
                DatePickerStart.Value = KagNetComponents2.KagPersianDate.Now;
                ComboBoxSerach.SelectedIndex = 3;
                SetDate = true;
                DatePickerEnd.Value = KagNetComponents2.KagPersianDate.Now;
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
            if (SetDate) BindData(GridViewVisitPatientPayment.Row);
        }

        private void DatePickerStart_ValueChanged(object sender, KagNetComponents2.PersianMonthCalendarEventArgs e)
        {
            if (SetDate) BindData(GridViewVisitPatientPayment.Row);
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

            for (int i = 0; i < GridViewVisitPatientPayment.SelectedItems.Count; i++)
                if (new ViewModel.Basic.NODuplicateForm().CheckNODuplicateForm("TBL_VisitPatientPayment", GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["Id"].Value.ToString(), ref str))
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View("امکان تغییرات به علت انجام عملیات توسط کاربر دیگر امکان پذیر نمی باشد. لطفا کمی بعد سعی کنید", MKH.Library.Clasess.MSSMessage.MessageType.SWarning);
                    return;
                }

            long IDSet = 0;

            if (MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation, true, "آیا مقدار درخواستی جهت ردیف های انتخابی ثبت شود؟"))
            {
                try
                {
                    //int CostCompanyVisitPercent = new ViewModel.Setting.Setting().GetAllValue("CostCompanyVisitPercent", ref str).ToString().ToInt();

                    for (int i = 0; i < GridViewVisitPatientPayment.SelectedItems.Count; i++)
                    {
                        IDSet = long.Parse(GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["Id"].Value.ToString());
                        if (Convert.ToInt32(GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["CostVisitDoctorBes"].Value) != 0
                            && comboBoxSetValue.SelectedIndex != 0
                            && comboBoxSetValue.SelectedIndex != 5
                            && comboBoxSetValue.SelectedIndex != 10
                            && comboBoxSetValue.SelectedIndex != 12
                            )
                            //if (GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["PaymentTypeName"].Value.ToString() == "پیش پرداخت" ||
                            //    GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["PaymentTypeName"].Value.ToString() == "کسورات")
                            continue;


                        if (comboBoxSetValue.SelectedIndex == 0)
                        {
                            if (comboBoxPaymentStatus.SelectedIndex == -1) comboBoxPaymentStatus.SelectedIndex = 0;

                            new ViewModel.VisitPatient.VisitPatientPayment().UpdateEntityWithFieldValue(
                                IDSet, "PaymentStatus_Id", (comboBoxPaymentStatus.SelectedIndex + 1).ToString(),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                            new ViewModel.VisitPatient.VisitPatientPayment().UpdateEntityWithFieldValue(
                                IDSet, "PaymentStatusDate", DatePickerSet.Value.ToString().Substring(0, 10),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);
                        }
                        else if (comboBoxSetValue.SelectedIndex == 1)//CostCachInsu
                        {
                            double DoctorTaxPercent = double.Parse((GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["CostDoctorTax"].Value ?? 0).ToString()) * 100 / (double.Parse((GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["CostCachInsu"].Value ?? 1).ToString()) - double.Parse((GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["CostCompany"].Value ?? 0).ToString()));
                            double CostInsurancePercent = double.Parse((GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["CostDoctorInsurance"].Value ?? 0).ToString()) * 100 / (double.Parse((GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["CostCachInsu"].Value ?? 1).ToString()) - double.Parse((GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["CostCompany"].Value ?? 0).ToString()));
                            double CostCompanyVisitPercent = double.Parse((GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["CostCompany"].Value ?? 0).ToString()) * 100 / double.Parse((GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["CostCachInsu"].Value ?? 1).ToString());
                            if (double.IsNaN(CostCompanyVisitPercent) || CostCompanyVisitPercent == 0)
                            {
                                CostCompanyVisitPercent = double.Parse(new ViewModel.Setting.Setting().GetAllValue("CostCompanyVisitPercent", ref str).ToString());

                                try { DoctorTaxPercent = new ViewModel.Doctors.Doctor().GetAllListByID(int.Parse(GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["Doctor_Id"].Value.ToString()), ref str).Last().DoctorTaxPercent.Value; }
                                catch { }
                                CostInsurancePercent = double.Parse(new ViewModel.Setting.Setting().GetAllValue("CostInsurancePercent", ref str).ToString());
                            }

                            int CostCachInsuIran = int.Parse(nUpDownSetValue.Value.ToString());
                            int CostCompany = Other.Class.Function_Cls.CalculateCostCompany(CostCachInsuIran, CostCompanyVisitPercent);
                            int CostDoctorTax = Other.Class.Function_Cls.CalculateTax(CostCachInsuIran, CostCompany, DoctorTaxPercent);
                            int CostDoctorInsurance = Other.Class.Function_Cls.CalculateInsurance(CostCachInsuIran, CostCompany, CostInsurancePercent);
                            int CostDoctor = Other.Class.Function_Cls.CalculateCostDoctor(CostCachInsuIran, CostCompany,
                                int.Parse((GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["CostIncrease"].Value ?? 0).ToString()),
                                CostDoctorTax, CostDoctorInsurance,
                                int.Parse((GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["CostDoctorPrePayment"].Value ?? 0).ToString()));

                            new ViewModel.VisitPatient.VisitPatientPayment().UpdateEntityWithFieldValue(
                                IDSet, "CostCachInsu", CostCachInsuIran.ToString(),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                            new ViewModel.VisitPatient.VisitPatientPayment().UpdateEntityWithFieldValue(
                                IDSet, "CostCompany", CostCompany.ToString(),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                            new ViewModel.VisitPatient.VisitPatientPayment().UpdateEntityWithFieldValue(
                                IDSet, "CostDoctorTax", CostDoctorTax.ToString(),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                            new ViewModel.VisitPatient.VisitPatientPayment().UpdateEntityWithFieldValue(
                                IDSet, "CostDoctorInsurance", CostDoctorInsurance.ToString(),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                            new ViewModel.VisitPatient.VisitPatientPayment().UpdateEntityWithFieldValue(
                                IDSet, "CostDoctor", CostDoctor.ToString(),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);
                        }
                        else if (comboBoxSetValue.SelectedIndex == 2)
                            new ViewModel.VisitPatient.VisitPatientPayment().UpdateEntityWithFieldValue(
                                IDSet, "AnalyzePage", nUpDownSetValue.Value.ToString(),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                        else if (comboBoxSetValue.SelectedIndex == 3)
                        {
                            new ViewModel.VisitPatient.VisitPatientPayment().UpdateEntityWithFieldValue(
                                IDSet, "AnalyzeNo", textBoxSetValue.Text,
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                            new ViewModel.VisitPatient.VisitPatientPayment().UpdateEntityWithFieldValue(
                                IDSet, "AnalyzeDate", textBoxSetValue.Text == "" ? "" : DatePickerSet.Value.ToString().Substring(0, 10),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                        }
                        else if (comboBoxSetValue.SelectedIndex == 4)
                        {
                            new ViewModel.VisitPatient.VisitPatientPayment().UpdateEntityWithFieldValue(
                                   IDSet, "AccountingDocumentNumber", textBoxSetValue.Text,
                                   MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                   MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                            new ViewModel.VisitPatient.VisitPatientPayment().UpdateEntityWithFieldValue(
                                IDSet, "AccountingDocumentDate", textBoxSetValue.Text == "" ? "" : DatePickerSet.Value.ToString().Substring(0, 10),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                        }

                        else if (comboBoxSetValue.SelectedIndex == 5)
                        {
                            new ViewModel.VisitPatient.VisitPatientPayment().UpdateEntityWithFieldValue(
                                   IDSet, "BursaryNumber", textBoxSetValue.Text,
                                   MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                   MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                            new ViewModel.VisitPatient.VisitPatientPayment().UpdateEntityWithFieldValue(
                                IDSet, "BursaryDate", textBoxSetValue.Text == "" ? "" : DatePickerSet.Value.ToString().Substring(0, 10),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);
                        }
                        else if (comboBoxSetValue.SelectedIndex == 6)//CostCompany
                        {
                            double DoctorTaxPercent = double.Parse((GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["CostDoctorTax"].Value ?? 0).ToString()) * 100 / (double.Parse((GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["CostCachInsu"].Value ?? 1).ToString()) - double.Parse((GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["CostCompany"].Value ?? 0).ToString()));
                            double CostInsurancePercent = double.Parse((GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["CostDoctorInsurance"].Value ?? 0).ToString()) * 100 / (double.Parse((GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["CostCachInsu"].Value ?? 1).ToString()) - double.Parse((GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["CostCompany"].Value ?? 0).ToString()));
                            double CostCompanyVisitPercent = double.Parse((GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["CostCompany"].Value ?? 0).ToString()) * 100 / double.Parse((GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["CostCachInsu"].Value ?? 1).ToString());
                            if (double.IsNaN(CostCompanyVisitPercent) || CostCompanyVisitPercent == 0)
                            {
                                CostCompanyVisitPercent = double.Parse(new ViewModel.Setting.Setting().GetAllValue("CostCompanyVisitPercent", ref str).ToString());

                                try { DoctorTaxPercent = new ViewModel.Doctors.Doctor().GetAllListByID(int.Parse(GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["Doctor_Id"].Value.ToString()), ref str).Last().DoctorTaxPercent.Value; }
                                catch { }
                                CostInsurancePercent = double.Parse(new ViewModel.Setting.Setting().GetAllValue("CostInsurancePercent", ref str).ToString());
                            }

                            int CostCachInsu = int.Parse((GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["CostCachInsu"].Value ?? 0).ToString());
                            int CostCompany = int.Parse(nUpDownSetValue.Value.ToString());
                            int CostDoctorTax = Other.Class.Function_Cls.CalculateTax(CostCachInsu, CostCompany, DoctorTaxPercent);
                            int CostDoctorInsurance = Other.Class.Function_Cls.CalculateInsurance(CostCachInsu, CostCompany, CostInsurancePercent);
                            int CostDoctor = Other.Class.Function_Cls.CalculateCostDoctor(CostCachInsu, CostCompany,
                                int.Parse((GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["CostIncrease"].Value ?? 0).ToString()),
                                CostDoctorTax, CostDoctorInsurance,
                                int.Parse((GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["CostDoctorPrePayment"].Value ?? 0).ToString()));

                            new ViewModel.VisitPatient.VisitPatientPayment().UpdateEntityWithFieldValue(
                                IDSet, "CostCompany", CostCompany.ToString(),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                            new ViewModel.VisitPatient.VisitPatientPayment().UpdateEntityWithFieldValue(
                                IDSet, "CostDoctorTax", CostDoctorTax.ToString(),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                            new ViewModel.VisitPatient.VisitPatientPayment().UpdateEntityWithFieldValue(
                                IDSet, "CostDoctorInsurance", CostDoctorInsurance.ToString(),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                            new ViewModel.VisitPatient.VisitPatientPayment().UpdateEntityWithFieldValue(
                                IDSet, "CostDoctor", CostDoctor.ToString(),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);
                        }
                        else if (comboBoxSetValue.SelectedIndex == 7)//CostCompany Percent
                        {
                            double DoctorTaxPercent = double.Parse((GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["CostDoctorTax"].Value ?? 0).ToString()) * 100 / (double.Parse((GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["CostCachInsu"].Value ?? 1).ToString()) - double.Parse((GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["CostCompany"].Value ?? 0).ToString()));
                            double CostInsurancePercent = double.Parse((GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["CostDoctorInsurance"].Value ?? 0).ToString()) * 100 / (double.Parse((GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["CostCachInsu"].Value ?? 1).ToString()) - double.Parse((GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["CostCompany"].Value ?? 0).ToString()));
                            double CostCompanyVisitPercent = double.Parse((GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["CostCompany"].Value ?? 0).ToString()) * 100 / double.Parse((GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["CostCachInsu"].Value ?? 1).ToString());
                            if (double.IsNaN(CostCompanyVisitPercent) || CostCompanyVisitPercent == 0)
                            {
                                CostCompanyVisitPercent = double.Parse(new ViewModel.Setting.Setting().GetAllValue("CostCompanyVisitPercent", ref str).ToString());

                                try { DoctorTaxPercent = new ViewModel.Doctors.Doctor().GetAllListByID(int.Parse(GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["Doctor_Id"].Value.ToString()), ref str).Last().DoctorTaxPercent.Value; }
                                catch { }
                                CostInsurancePercent = double.Parse(new ViewModel.Setting.Setting().GetAllValue("CostInsurancePercent", ref str).ToString());
                            }

                            int CostCachInsu = int.Parse((GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["CostCachInsu"].Value ?? 0).ToString());
                            int CostCompany = int.Parse(nUpDownSetValue.Value.ToString()) * int.Parse((GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["CostCachInsu"].Value ?? 0).ToString()) / 100;
                            int CostDoctorTax = Other.Class.Function_Cls.CalculateTax(CostCachInsu, CostCompany, DoctorTaxPercent);
                            int CostDoctorInsurance = Other.Class.Function_Cls.CalculateInsurance(CostCachInsu, CostCompany, CostInsurancePercent);
                            int CostDoctor = Other.Class.Function_Cls.CalculateCostDoctor(CostCachInsu, CostCompany,
                                int.Parse((GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["CostIncrease"].Value ?? 0).ToString()),
                                CostDoctorTax, CostDoctorInsurance,
                                int.Parse((GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["CostDoctorPrePayment"].Value ?? 0).ToString()));

                            new ViewModel.VisitPatient.VisitPatientPayment().UpdateEntityWithFieldValue(
                                IDSet, "CostCompany", CostCompany.ToString(),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                            new ViewModel.VisitPatient.VisitPatientPayment().UpdateEntityWithFieldValue(
                                IDSet, "CostDoctorTax", CostDoctorTax.ToString(),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                            new ViewModel.VisitPatient.VisitPatientPayment().UpdateEntityWithFieldValue(
                                IDSet, "CostDoctorInsurance", CostDoctorInsurance.ToString(),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);
                            new ViewModel.VisitPatient.VisitPatientPayment().UpdateEntityWithFieldValue(
                                IDSet, "CostDoctor", CostDoctor.ToString(),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);
                        }
                        else if (comboBoxSetValue.SelectedIndex == 8) //CostIncrease
                        {

                            int CostDoctor = Other.Class.Function_Cls.CalculateCostDoctor(
                                int.Parse((GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["CostCachInsu"].Value ?? 0).ToString()),
                                int.Parse((GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["CostCompany"].Value ?? 0).ToString()),
                                int.Parse(nUpDownSetValue.Value.ToString()),
                                int.Parse((GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["CostDoctorTax"].Value ?? 0).ToString()),
                                int.Parse((GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["CostDoctorInsurance"].Value ?? 0).ToString()),
                                int.Parse((GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["CostDoctorPrePayment"].Value ?? 0).ToString()));

                            new ViewModel.VisitPatient.VisitPatientPayment().UpdateEntityWithFieldValue(
                               IDSet, "CostIncrease", int.Parse(nUpDownSetValue.Value.ToString()).ToString(),
                               MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                               MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                            new ViewModel.VisitPatient.VisitPatientPayment().UpdateEntityWithFieldValue(
                                IDSet, "CostIncreaseDate", textBoxSetValue.Text == "" ? "" : DatePickerSet.Value.ToString().Substring(0, 10),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                            new ViewModel.VisitPatient.VisitPatientPayment().UpdateEntityWithFieldValue(
                                IDSet, "CostDoctor", CostDoctor.ToString(),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);
                        }
                        else if (comboBoxSetValue.SelectedIndex == 9) //CostIncrease Percent
                        {
                            int CostIncrease = int.Parse(nUpDownSetValue.Value.ToString()) *
                                Other.Class.Function_Cls.CalculateCostDoctor(
                                int.Parse((GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["CostCachInsu"].Value ?? 0).ToString()),
                                int.Parse((GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["CostCompany"].Value ?? 0).ToString()),
                                0,
                                int.Parse((GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["CostDoctorTax"].Value ?? 0).ToString()),
                                int.Parse((GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["CostDoctorInsurance"].Value ?? 0).ToString()),
                                int.Parse((GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["CostDoctorPrePayment"].Value ?? 0).ToString()))
                                / 100;

                            int CostDoctor = Other.Class.Function_Cls.CalculateCostDoctor(
                                int.Parse((GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["CostCachInsu"].Value ?? 0).ToString()),
                                int.Parse((GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["CostCompany"].Value ?? 0).ToString()),
                                CostIncrease,
                                int.Parse((GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["CostDoctorTax"].Value ?? 0).ToString()),
                                int.Parse((GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["CostDoctorInsurance"].Value ?? 0).ToString()),
                                int.Parse((GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["CostDoctorPrePayment"].Value ?? 0).ToString()));

                            new ViewModel.VisitPatient.VisitPatientPayment().UpdateEntityWithFieldValue(
                               IDSet, "CostIncrease", CostIncrease.ToString(),
                               MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                               MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                            new ViewModel.VisitPatient.VisitPatientPayment().UpdateEntityWithFieldValue(
                                IDSet, "CostIncreaseDate", textBoxSetValue.Text == "" ? "" : DatePickerSet.Value.ToString().Substring(0, 10),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                            new ViewModel.VisitPatient.VisitPatientPayment().UpdateEntityWithFieldValue(
                                IDSet, "CostDoctor", CostDoctor.ToString(),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                        }
                        else if (comboBoxSetValue.SelectedIndex == 10)
                            new ViewModel.VisitPatient.VisitPatientPayment().UpdateEntityWithFieldValue(
                                IDSet, "PaymentDoctorDate", DatePickerSet.Value.ToString().Substring(0, 10),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                        else if (comboBoxSetValue.SelectedIndex == 11) //CostDoctorTax
                        {
                            //double DoctorTaxPercent = double.Parse((GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["CostDoctorTax"].Value ?? 0).ToString()) * 100 / (double.Parse((GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["CostCachInsu"].Value ?? 0).ToString()) - double.Parse((GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["CostCompany"].Value ?? 0).ToString()));
                            //double CostInsurancePercent = double.Parse((GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["CostDoctorInsurance"].Value ?? 0).ToString()) * 100 / (double.Parse((GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["CostCachInsu"].Value ?? 0).ToString()) - double.Parse((GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["CostCompany"].Value ?? 0).ToString()));
                            //double CostCompanyVisitPercent = double.Parse((GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["CostCompany"].Value ?? 0).ToString()) * 100 / double.Parse((GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["CostCachInsu"].Value ?? 0).ToString());

                            int CostCachInsu = int.Parse((GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["CostCachInsu"].Value ?? 0).ToString());
                            int CostCompany = int.Parse((GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["CostCompany"].Value ?? 0).ToString());
                            int CostDoctorTax = int.Parse(nUpDownSetValue.Value.ToString());
                            int CostDoctorInsurance = int.Parse((GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["CostDoctorInsurance"].Value ?? 0).ToString());
                            int CostDoctor = Other.Class.Function_Cls.CalculateCostDoctor(
                                CostCachInsu,
                                CostCompany,
                                int.Parse((GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["CostIncrease"].Value ?? 0).ToString()),
                                CostDoctorTax,
                                CostDoctorInsurance,
                                int.Parse((GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["CostDoctorPrePayment"].Value ?? 0).ToString()));

                            new ViewModel.VisitPatient.VisitPatientPayment().UpdateEntityWithFieldValue(
                                IDSet, "CostDoctorTax", nUpDownSetValue.Value.ToString(),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                            new ViewModel.VisitPatient.VisitPatientPayment().UpdateEntityWithFieldValue(
                                IDSet, "CostDoctor", CostDoctor.ToString(),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                        }
                        else if (comboBoxSetValue.SelectedIndex == 12)
                            new ViewModel.VisitPatient.VisitPatientPayment().UpdateEntityWithFieldValue(
                                IDSet, "Description", textBoxSetValue.Text,
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                        else if (comboBoxSetValue.SelectedIndex == 13)
                        {
                            new ViewModel.VisitPatient.VisitPatientPayment().UpdateEntityWithFieldValue(
                                   IDSet, "BonyadConfirmNo", textBoxSetValue.Text,
                                   MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                   MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                            new ViewModel.VisitPatient.VisitPatientPayment().UpdateEntityWithFieldValue(
                                IDSet, "BonyadConfirmDate", textBoxSetValue.Text == "" ? "" : DatePickerSet.Value.ToString().Substring(0, 10),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);
                        }
                        else if (comboBoxSetValue.SelectedIndex == 14)
                        {
                            new ViewModel.VisitPatient.VisitPatientPayment().UpdateEntityWithFieldValue(
                                IDSet, "SecretiatNo", textBoxSetValue.Text,
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                            new ViewModel.VisitPatient.VisitPatientPayment().UpdateEntityWithFieldValue(
                                IDSet, "SecretiatDate", textBoxSetValue.Text == "" ? "" : DatePickerSet.Value.ToString().Substring(0, 10),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                        }
                        else if (comboBoxSetValue.SelectedIndex == 15)//CostDoctorTax Percent
                        {
                            //double DoctorTaxPercent = double.Parse((GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["CostDoctorTax"].Value ?? 0).ToString()) * 100 / (double.Parse((GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["CostCachInsu"].Value ?? 0).ToString()) - double.Parse((GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["CostCompany"].Value ?? 0).ToString()));
                            //double CostInsurancePercent = double.Parse((GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["CostDoctorInsurance"].Value ?? 0).ToString()) * 100 / (double.Parse((GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["CostCachInsu"].Value ?? 0).ToString()) - double.Parse((GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["CostCompany"].Value ?? 0).ToString()));
                            //double CostCompanyVisitPercent = double.Parse((GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["CostCompany"].Value ?? 0).ToString()) * 100 / double.Parse((GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["CostCachInsu"].Value ?? 0).ToString());

                            int CostCachInsu = int.Parse((GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["CostCachInsu"].Value ?? 0).ToString());
                            int CostCompany = int.Parse((GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["CostCompany"].Value ?? 0).ToString());
                            int CostDoctorTax = Other.Class.Function_Cls.CalculateTax(CostCachInsu, CostCompany, int.Parse(nUpDownSetValue.Value.ToString()));
                            int CostDoctorInsurance = int.Parse((GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["CostDoctorInsurance"].Value ?? 0).ToString());
                            int CostDoctor = Other.Class.Function_Cls.CalculateCostDoctor(
                                CostCachInsu,
                                CostCompany,
                                int.Parse((GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["CostIncrease"].Value ?? 0).ToString()),
                                CostDoctorTax,
                                CostDoctorInsurance,
                                int.Parse((GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["CostDoctorPrePayment"].Value ?? 0).ToString()));

                            new ViewModel.VisitPatient.VisitPatientPayment().UpdateEntityWithFieldValue(
                                IDSet, "CostDoctorTax", CostDoctorTax.ToString(),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                            new ViewModel.VisitPatient.VisitPatientPayment().UpdateEntityWithFieldValue(
                                IDSet, "CostDoctor", CostDoctor.ToString(),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                        }
                        else if (comboBoxSetValue.SelectedIndex == 16)
                            new ViewModel.VisitPatient.VisitPatientPayment().UpdateEntityWithFieldValue(
                                IDSet, "ReportCode", nUpDownSetValue.Value.ToString(),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);


                        else if (comboBoxSetValue.SelectedIndex == 17)//CostDoctorInsurance
                        {
                            double DoctorTaxPercent = double.Parse((GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["CostDoctorTax"].Value ?? 0).ToString()) * 100 / (double.Parse((GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["CostCachInsu"].Value ?? 1).ToString()) - double.Parse((GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["CostCompany"].Value ?? 0).ToString()));
                            double CostInsurancePercent = double.Parse((GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["CostDoctorInsurance"].Value ?? 0).ToString()) * 100 / (double.Parse((GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["CostCachInsu"].Value ?? 1).ToString()) - double.Parse((GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["CostCompany"].Value ?? 0).ToString()));
                            double CostCompanyVisitPercent = double.Parse((GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["CostCompany"].Value ?? 0).ToString()) * 100 / double.Parse((GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["CostCachInsu"].Value ?? 1).ToString());
                            if (double.IsNaN(CostCompanyVisitPercent) || CostCompanyVisitPercent == 0)
                            {
                                CostCompanyVisitPercent = double.Parse(new ViewModel.Setting.Setting().GetAllValue("CostCompanyVisitPercent", ref str).ToString());

                                try { DoctorTaxPercent = new ViewModel.Doctors.Doctor().GetAllListByID(int.Parse(GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["Doctor_Id"].Value.ToString()), ref str).Last().DoctorTaxPercent.Value; }
                                catch { }
                                CostInsurancePercent = double.Parse(new ViewModel.Setting.Setting().GetAllValue("CostInsurancePercent", ref str).ToString());
                            }

                            int CostCachInsu = int.Parse((GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["CostCachInsu"].Value ?? 0).ToString());
                            int CostCompany = int.Parse((GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["CostCompany"].Value ?? 0).ToString());
                            int CostDoctorTax = int.Parse((GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["CostDoctorTax"].Value ?? 0).ToString());
                            int CostDoctorInsurance = int.Parse(nUpDownSetValue.Value.ToString());

                            int CostDoctor = Other.Class.Function_Cls.CalculateCostDoctor(
                                CostCachInsu,
                                CostCompany,
                                int.Parse((GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["CostIncrease"].Value ?? 0).ToString()),
                                CostDoctorTax,
                                CostDoctorInsurance,
                                int.Parse((GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["CostDoctorPrePayment"].Value ?? 0).ToString()));


                            new ViewModel.VisitPatient.VisitPatientPayment().UpdateEntityWithFieldValue(
                                IDSet, "CostDoctorInsurance", CostDoctorInsurance.ToString(),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                            new ViewModel.VisitPatient.VisitPatientPayment().UpdateEntityWithFieldValue(
                                IDSet, "CostDoctor", CostDoctor.ToString(),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                        }

                        else if (comboBoxSetValue.SelectedIndex == 18)//CostDoctorInsurance Percent
                        {
                            //double DoctorTaxPercent = double.Parse(nUpDownSetValue.Value.ToString());//double.Parse((GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["CostDoctorTax"].Value ?? 0).ToString()) * 100 / (double.Parse((GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["CostCachInsu"].Value ?? 0).ToString()) - double.Parse((GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["CostCompany"].Value ?? 0).ToString()));
                            //double CostInsurancePercent = double.Parse((GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["CostDoctorInsurance"].Value ?? 0).ToString()) * 100 / (double.Parse((GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["CostCachInsu"].Value ?? 0).ToString()) - double.Parse((GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["CostCompany"].Value ?? 0).ToString()));
                            //double CostCompanyVisitPercent = double.Parse((GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["CostCachInsu"].Value ?? 0).ToString()) * 100 / double.Parse((GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["CostCompany"].Value ?? 0).ToString());

                            int CostCachInsu = int.Parse((GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["CostCachInsu"].Value ?? 0).ToString());
                            int CostCompany = int.Parse((GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["CostCompany"].Value ?? 0).ToString());
                            int CostDoctorTax = int.Parse((GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["CostDoctorTax"].Value ?? 0).ToString());
                            int CostDoctorInsurance = Other.Class.Function_Cls.CalculateInsurance(CostCachInsu, CostCompany, int.Parse(nUpDownSetValue.Value.ToString()));
                            int CostDoctor = Other.Class.Function_Cls.CalculateCostDoctor(
                                CostCachInsu,
                                CostCompany,
                                int.Parse((GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["CostIncrease"].Value ?? 0).ToString()),
                                CostDoctorTax,
                                CostDoctorInsurance,
                                int.Parse((GridViewVisitPatientPayment.SelectedItems[i].GetRow().Cells["CostDoctorPrePayment"].Value ?? 0).ToString()));


                            new ViewModel.VisitPatient.VisitPatientPayment().UpdateEntityWithFieldValue(
                                IDSet, "CostDoctorInsurance", CostDoctorInsurance.ToString(),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                            new ViewModel.VisitPatient.VisitPatientPayment().UpdateEntityWithFieldValue(
                                IDSet, "CostDoctor", CostDoctor.ToString(),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                        }

                        else if (comboBoxSetValue.SelectedIndex == 19)
                            new ViewModel.VisitPatient.VisitPatientPayment().UpdateEntityWithFieldValue(
                                IDSet, "CardBankNo1", textBoxSetValue.Text,
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                        else if (comboBoxSetValue.SelectedIndex == 20)
                        {
                            if (comboBoxBank.SelectedIndex == -1) comboBoxBank.SelectedIndex = 0;

                            new ViewModel.VisitPatient.VisitPatientPayment().UpdateEntityWithFieldValue(
                                IDSet, "BankName", comboBoxBank.Text,
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);
                        }




                    }

                }
                catch (Exception ex)
                {
                }
                BindData(GridViewVisitPatientPayment.Row);
            }
        }

        private void buttonItemPhysioterapyPaymentCalculateRimindAll_Click(object sender, EventArgs e)
        {
            string str = "";
            if (MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation, true, "آیا مایلید مانده دریافتی ها محاسبه شوند؟"))
            {
                new ViewModel.VisitPatient.VisitPatientPayment().VisitPatientPaymentCalculateRemindAllPayment(ref str);
                BindData(GridViewVisitPatientPayment.Row);
            }
        }

        private void ToolStripMenuItemVisitPatientPaymentCurrentRow_Click(object sender, EventArgs e)
        {
            try
            {
                string Str = "";
                int J = 0;

                MKH.Library.Forms.MSSLogViewer_frm ctrl = new MKH.Library.Forms.MSSLogViewer_frm();
                ctrl.GridexViewSelector.DataSource = new MKH.Permission.ViewModel.Log.Log().GetAllListVisitPatientPaymentByID(System.Convert.ToInt64(GridViewVisitPatientPayment.CurrentRow.Cells["Id"].Value), ref Str).ToList();
                ctrl.ColumnList = new System.Data.DataTable();
                for (int i = 0; i < GridViewVisitPatientPayment.RootTable.Columns.Count; i++)
                    if (GridViewVisitPatientPayment.RootTable.Columns[i].Tag == "" || GridViewVisitPatientPayment.RootTable.Columns[i].Tag == null)
                    {
                        ctrl.ColumnList.Columns.Add(GridViewVisitPatientPayment.RootTable.Columns[i].Key);
                        ctrl.ColumnList.Columns[J].Caption = GridViewVisitPatientPayment.RootTable.Columns[i].Caption;
                        J++;
                    }
                ctrl.ShowDialog();
            }
            catch { }
        }

        private void ToolStripMenuItemVisitPatientPaymentAllList_Click(object sender, EventArgs e)
        {
            try
            {
                string Str = "";
                int J = 0;

                MKH.Library.Forms.MSSLogViewer_frm ctrl = new MKH.Library.Forms.MSSLogViewer_frm();
                ctrl.GridexViewSelector.DataSource = new MKH.Permission.ViewModel.Log.Log().GetAllListVisitPatientPayment(ref Str).ToList();
                ctrl.ColumnList = new System.Data.DataTable();
                for (int i = 0; i < GridViewVisitPatientPayment.RootTable.Columns.Count; i++)
                    if (GridViewVisitPatientPayment.RootTable.Columns[i].Visible)
                    {
                        ctrl.ColumnList.Columns.Add(GridViewVisitPatientPayment.RootTable.Columns[i].Key);
                        ctrl.ColumnList.Columns[J].Caption = GridViewVisitPatientPayment.RootTable.Columns[i].Caption;
                        J++;
                    }
                ctrl.ShowDialog();
            }
            catch { }
        }

       
    }
}
