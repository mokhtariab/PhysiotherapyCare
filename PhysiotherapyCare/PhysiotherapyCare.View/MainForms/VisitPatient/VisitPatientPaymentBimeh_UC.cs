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
    public partial class VisitPatientPaymentBimeh_UC : UserControl
    {
        public VisitPatientPaymentBimeh_UC()
        {
            InitializeComponent();
        }


        public void BindData(int RowNumberSet)
        {

            string str = "", WhereStr = "";

            if (RadioBoxPaymentStatus1.Checked)
                WhereStr = " PaymentStatus_Id = 8 and ";
            if (RadioBoxPaymentStatusNot1.Checked)
                WhereStr = " PaymentStatus_Id <> 8 and ";
            
            if (ComboBoxSerach.SelectedIndex == 0)
                WhereStr += " PaymentDate >= '" + DatePickerStart.Value.ToString().Substring(0, 10) + "' and PaymentDate <= '" + DatePickerEnd.Value.ToString().Substring(0, 10) + "' and ";
            else if (ComboBoxSerach.SelectedIndex == 1)
                WhereStr = " LetterDate >= '" + DatePickerStart.Value.ToString().Substring(0, 10) + "' and LetterDate <= '" + DatePickerEnd.Value.ToString().Substring(0, 10) + "' and ";
            else if (ComboBoxSerach.SelectedIndex == 2)
                WhereStr += " ContractDate >= '" + DatePickerStart.Value.ToString().Substring(0, 10) + "' and ContractDate <= '" + DatePickerEnd.Value.ToString().Substring(0, 10) + "' and ";
            else if (ComboBoxSerach.SelectedIndex == 3)
                WhereStr += " VisitDate >= '" + DatePickerStart.Value.ToString().Substring(0, 10) + "' and VisitDate <= '" + DatePickerEnd.Value.ToString().Substring(0, 10) + "' and ";
            else if (ComboBoxSerach.SelectedIndex == 4)
                WhereStr += " InsuLetterDate >= '" + DatePickerStart.Value.ToString().Substring(0, 10) + "' and InsuLetterDate <= '" + DatePickerEnd.Value.ToString().Substring(0, 10) + "' and ";
            else if (ComboBoxSerach.SelectedIndex == 5)
                WhereStr += " SecretiatDate >= '" + DatePickerStart.Value.ToString().Substring(0, 10) + "' and SecretiatDate <= '" + DatePickerEnd.Value.ToString().Substring(0, 10) + "' and ";
            else if (ComboBoxSerach.SelectedIndex == 6)
                WhereStr = " BonyadConfirmDate >= '" + DatePickerStart.Value.ToString().Substring(0, 10) + "' and BonyadConfirmDate <= '" + DatePickerEnd.Value.ToString().Substring(0, 10) + "' and ";
            WhereStr += " 1=1 ";

            GridViewVisitPatientPaymentBimeh.DataSource = new ViewModel.VisitPatient.VisitPatientPayment().GetAllListSet(WhereStr, ref str).ToList();

            try { GridViewVisitPatientPaymentBimeh.Row = RowNumberSet; }
            catch { }

             
            //List<VW_VisitPatientPayment> LSQ = new List<VW_VisitPatientPayment>();

            //LSQ = new ViewModel.VisitPatient.VisitPatientPayment().GetAllList(ref str).ToList();



            //if (RadioBoxPaymentStatus1.Checked)
            //    LSQ = LSQ.Where(ei => ei.PaymentStatus_Id == 8).ToList();
            //if (RadioBoxPaymentStatusNot1.Checked)
            //    LSQ = LSQ.Where(ei => ei.PaymentStatus_Id != 8).ToList();
            //if (RadioBoxContractWithTime.Checked)
            //{
            //    try
            //    {
            //        if (ComboBoxSerach.SelectedIndex == 0)
            //            LSQ = LSQ.Where(d => MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.PaymentDate ?? "") >= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerStart.Value.ToString())
            //                && MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.PaymentDate ?? "") <= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerEnd.Value.ToString())).ToList();
            //        else if (ComboBoxSerach.SelectedIndex == 1)
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
            //            LSQ = LSQ.Where(d => MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.BonyadConfirmDate ?? "") >= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerStart.Value.ToString())
            //                && MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.BonyadConfirmDate ?? "") <= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerEnd.Value.ToString())).ToList();
            //    }
            //    catch { }
            //}
            
            //GridViewVisitPatientPaymentBimeh.DataSource = LSQ;

            //try { GridViewVisitPatientPaymentBimeh.Row = RowNumberSet; }
            //catch { }
        }


        #region All UI Button



        private void headerGridVisitPatientPaymentBimeh_btnEditClick(object sender, System.EventArgs e)
        {
            try
            {
                //if (!(HeaderGridVisitPatientPaymentBimeh as MKH.Library.Control.MSSHeaderGrid).Items["buttonItemEdit"].Visible || !(HeaderGridVisitPatientPaymentBimeh as MKH.Library.Control.MSSHeaderGrid).Items["buttonItemEdit"].Enabled) return;

                if (short.Parse(GridViewVisitPatientPaymentBimeh.CurrentRow.Cells["PaymentStatus_Id"].Value.ToString()) != 8)
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View("امکان ویرایش به دلیل ارسال به مالی وجود ندارد", MKH.Library.Clasess.MSSMessage.MessageType.SWarning);
                    return;
                }

                VisitPatientPaymentBimehAdd_Frm VisitPatientPaymentBimehAdd = new VisitPatientPaymentBimehAdd_Frm(
                        int.Parse(GridViewVisitPatientPaymentBimeh.CurrentRow.Cells["Id"].Value.ToString()));
                if (VisitPatientPaymentBimehAdd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    BindData(GridViewVisitPatientPaymentBimeh.Row);
            }
            catch { }
        }

        private void headerGridVisitPatientPaymentBimeh_btnDeleteClick(object sender, System.EventArgs e)
        {
            for (int i = 0; i < GridViewVisitPatientPaymentBimeh.SelectedItems.Count; i++)
                if (short.Parse(GridViewVisitPatientPaymentBimeh.SelectedItems[i].GetRow().Cells["PaymentStatus_Id"].Value.ToString()) != 8)
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View("امکان حذف به دلیل وجود ردیف (های) ارسال به مالی وجود ندارد", MKH.Library.Clasess.MSSMessage.MessageType.SWarning);
                    return;
                }

            string str = "";
            for (int i = 0; i < GridViewVisitPatientPaymentBimeh.SelectedItems.Count; i++)
                if (new ViewModel.Basic.NODuplicateForm().CheckNODuplicateForm("TBL_VisitPatientPayment", GridViewVisitPatientPaymentBimeh.SelectedItems[i].GetRow().Cells["Id"].Value.ToString(), ref str))
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View("امکان حذف به علت انجام عملیات توسط کاربر دیگر بر روی ردیف (هایی) امکان پذیر نمی باشد", MKH.Library.Clasess.MSSMessage.MessageType.SWarning);
                    return;
                }

            if (MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation, true, "آیا به حذف موارد انتخابی اطمینان دارید؟"))
            {
                try
                {
                    //List<TBL_VisitPatientPayment> Ls = new List<TBL_VisitPatientPayment>();
                    //for (int i = 0; i < GridViewVisitPatientPaymentBimeh.SelectedItems.Count; i++)
                    //{
                    //    TBL_VisitPatientPayment VisitPatientPaymentBimeh = new TBL_VisitPatientPayment();
                    //    VisitPatientPaymentBimeh.Id = long.Parse(GridViewVisitPatientPaymentBimeh.SelectedItems[i].GetRow().Cells["Id"].Value.ToString());
                    //    VisitPatientPaymentBimeh.VisitPatient_Id = long.Parse(GridViewVisitPatientPaymentBimeh.SelectedItems[i].GetRow().Cells["VisitPatient_Id"].Value.ToString());
                    //    VisitPatientPaymentBimeh.PaymentType_Id = short.Parse(GridViewVisitPatientPaymentBimeh.SelectedItems[i].GetRow().Cells["PaymentType_Id"].Value.ToString());
                    //    VisitPatientPaymentBimeh.PaymentStatus_Id = short.Parse(GridViewVisitPatientPaymentBimeh.SelectedItems[i].GetRow().Cells["PaymentStatus_Id"].Value.ToString());
                    //    Ls.Add(VisitPatientPaymentBimeh);
                    //}

                    //string str = "";
                    //new ViewModel.VisitPatient.VisitPatientPayment().DeleteEntity(Ls, ref str);


                    List<TBL_VisitPatientPayment> Ls = new List<TBL_VisitPatientPayment>();
                    ViewModel.VisitPatient.VisitPatientPayment RN = new ViewModel.VisitPatient.VisitPatientPayment();
                    for (int i = 0; i < GridViewVisitPatientPaymentBimeh.SelectedItems.Count; i++)
                        Ls.Add(RN.GetAllListByTblID(long.Parse(GridViewVisitPatientPaymentBimeh.SelectedItems[i].GetRow().Cells["Id"].Value.ToString()), ref str)[0]);

                    new ViewModel.VisitPatient.VisitPatientPayment().DeleteEntity(Ls, ref str);


                    if (str != "") MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "امکان حذف مورد(های) انتخابی به علت داشتن عملکرد در نرم افزار وجود ندارد", str);
                    else
                    {
                        //for (int i = 0; i < GridViewVisitPatientPaymentBimeh.SelectedItems.Count; i++)
                        //{
                        //    try
                        //    {
                        //        long VisitPatient_Id = long.Parse(GridViewVisitPatientPaymentBimeh.SelectedItems[i].GetRow().Cells["VisitPatient_Id"].Value.ToString());
                        //        new ViewModel.VisitPatient.VisitPatient().UpdateVisitStatus(VisitPatient_Id, 1,
                        //              MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                        //              MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(System.DateTime.Now),
                        //              ref str);
                        //        if (str != "") MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "امکان بروز رسانی کد " + VisitPatient_Id.ToString() + " در ویزیت وجود ندارد", str);
                        //        str = "";
                        //    }
                        //    catch { }
                        //}
                        BindData(GridViewVisitPatientPaymentBimeh.Row - 1);
                    }
                }
                catch (System.Exception ex)
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "اشکال", ex.Message);
                }
            }
        }

        private void headerGridVisitPatientPaymentBimeh_btnRefreshClick(object sender, System.EventArgs e)
        {
            BindData(GridViewVisitPatientPaymentBimeh.Row);
        }

        #endregion

        bool SetDate = false;
        private void VisitPatientPaymentBimeh_UC_Load(object sender, System.EventArgs e)
        {
            new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionControl(this);

            SetComboBox();
            btnSetValueVisit.Enabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(229);
            buttonItemSendVisitPayment.Enabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(228);
            ToolStripMenuItemVisitPatientPaymentBimehCurrentRow.Enabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(262);
            ToolStripMenuItemVisitPatientPaymentBimehAllList.Enabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(263);


            try
            {
                SetDate = false;
                DatePickerSet.Value = KagNetComponents2.KagPersianDate.Now;
                DatePickerStart.Value = KagNetComponents2.KagPersianDate.Now;
                SetDate = true;
                DatePickerEnd.Value = KagNetComponents2.KagPersianDate.Now;
                ComboBoxSerach.SelectedIndex = 3;
            }
            catch { }
        }

        private void SetComboBox()
        {
            string str = "";

            comboBoxPaymentStatus.ValueMember = "Id";
            comboBoxPaymentStatus.DisplayMember = "TitleName";
            comboBoxPaymentStatus.DataSource = new PhysiotherapyCare.ViewModel.Basic.PaymentStatus().GetAllList(ref str);
        }
        private void ComboBoxSerach_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (SetDate) BindData(GridViewVisitPatientPaymentBimeh.Row);
        }

        private void DatePickerStart_ValueChanged(object sender, KagNetComponents2.PersianMonthCalendarEventArgs e)
        {
            if (SetDate) BindData(GridViewVisitPatientPaymentBimeh.Row);
        }

        private void comboBoxSetValue_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            textBoxSetValue.Visible = comboBoxSetValue.SelectedIndex == 0 ;
            nUpDownSetValue.Visible = comboBoxSetValue.SelectedIndex == 1;
        }

        private void btnSetValue_Click(object sender, System.EventArgs e)
        {
            string str = "";

            for (int i = 0; i < GridViewVisitPatientPaymentBimeh.SelectedItems.Count; i++)
                if (new ViewModel.Basic.NODuplicateForm().CheckNODuplicateForm("TBL_VisitPatientPayment", GridViewVisitPatientPaymentBimeh.SelectedItems[i].GetRow().Cells["Id"].Value.ToString(), ref str))
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View("امکان تغییرات به علت انجام عملیات توسط کاربر دیگر امکان پذیر نمی باشد. لطفا کمی بعد سعی کنید", MKH.Library.Clasess.MSSMessage.MessageType.SWarning);
                    return;
                }
            long IDSet = 0;

            if (MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation, true, "آیا مقدار درخواستی جهت ردیف های انتخابی ثبت شود؟"))
            {
                try
                {
                    int CostCompanyPhysiotherapyPercent = new ViewModel.Setting.Setting().GetAllValue("CostCompanyPhsiotraphyPercent", ref str).ToString().ToInt();

                    for (int i = 0; i < GridViewVisitPatientPaymentBimeh.SelectedItems.Count; i++)
                    {
                        IDSet = long.Parse(GridViewVisitPatientPaymentBimeh.SelectedItems[i].GetRow().Cells["Id"].Value.ToString());


                        if (comboBoxSetValue.SelectedIndex == 0)
                        {
                            new ViewModel.VisitPatient.VisitPatientPayment().UpdateEntityWithFieldValue(
                                IDSet, "InsuLetterNo", textBoxSetValue.Text,
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                            new ViewModel.VisitPatient.VisitPatientPayment().UpdateEntityWithFieldValue(
                                IDSet, "InsuLetterDate", textBoxSetValue.Text == "" ? "" : DatePickerSet.Value.ToString().Substring(0, 10),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);
                        }
                        else if (comboBoxSetValue.SelectedIndex == 1)
                        {
                            new ViewModel.VisitPatient.VisitPatientPayment().UpdateEntityWithFieldValue(
                                IDSet, "CostReqInsu", nUpDownSetValue.Value.ToString(),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);
                        }

                    }

                }
                catch (Exception ex)
                {
                }
                BindData(GridViewVisitPatientPaymentBimeh.Row);
            }
        }

        private void buttonItemSendPhysioterapyPayment_Click(object sender, EventArgs e)
        {
            string str = "";

            for (int i = 0; i < GridViewVisitPatientPaymentBimeh.SelectedItems.Count; i++)
                if (new ViewModel.Basic.NODuplicateForm().CheckNODuplicateForm("TBL_VisitPatientPayment", GridViewVisitPatientPaymentBimeh.SelectedItems[i].GetRow().Cells["Id"].Value.ToString(), ref str))
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View("امکان تغییرات به علت انجام عملیات توسط کاربر دیگر امکان پذیر نمی باشد. لطفا کمی بعد سعی کنید", MKH.Library.Clasess.MSSMessage.MessageType.SWarning);
                    return;
                }

            if (MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation, true, "آیا ردیف های انتخابی جهت مالی ارسال شوند؟"))
            {
                try
                {
                    List<TBL_VisitPatientPayment> Ls = new List<TBL_VisitPatientPayment>(1);
                    for (int i = 0; i < GridViewVisitPatientPaymentBimeh.SelectedItems.Count; i++)
                        if (short.Parse(GridViewVisitPatientPaymentBimeh.SelectedItems[i].GetRow().Cells["PaymentStatus_Id"].Value.ToString()) == 8)
                        {
                            new ViewModel.VisitPatient.VisitPatientPayment().UpdateEntityWithFieldValue(
                                long.Parse(GridViewVisitPatientPaymentBimeh.SelectedItems[i].GetRow().Cells["Id"].Value.ToString()), "PaymentStatus_Id", "1",
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                            new ViewModel.VisitPatient.VisitPatientPayment().UpdateEntityWithFieldValue(
                                long.Parse(GridViewVisitPatientPaymentBimeh.SelectedItems[i].GetRow().Cells["Id"].Value.ToString()), "PaymentStatusDate", KagNetComponents2.KagPersianDate.Now.ToString(),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);
                        }
                    BindData(GridViewVisitPatientPaymentBimeh.Row);
                }
                catch (System.Exception ex)
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "اشکال ارسال", ex.Message);
                }
            }

        }

        private void ToolStripMenuItemVisitPatientPaymentBimehAllList_Click(object sender, EventArgs e)
        {
            try
            {
                string Str = "";
                int J = 0;

                MKH.Library.Forms.MSSLogViewer_frm ctrl = new MKH.Library.Forms.MSSLogViewer_frm();
                ctrl.GridexViewSelector.DataSource = new MKH.Permission.ViewModel.Log.Log().GetAllListVisitPatientPayment(ref Str).ToList();
                ctrl.ColumnList = new System.Data.DataTable();
                for (int i = 0; i < GridViewVisitPatientPaymentBimeh.RootTable.Columns.Count; i++)
                    if (GridViewVisitPatientPaymentBimeh.RootTable.Columns[i].Visible)
                    {
                        ctrl.ColumnList.Columns.Add(GridViewVisitPatientPaymentBimeh.RootTable.Columns[i].Key);
                        ctrl.ColumnList.Columns[J].Caption = GridViewVisitPatientPaymentBimeh.RootTable.Columns[i].Caption;
                        J++;
                    }
                ctrl.ShowDialog();
            }
            catch { }
        }

        private void ToolStripMenuItemVisitPatientPaymentBimehCurrentRow_Click(object sender, EventArgs e)
        {
            try
            {
                string Str = "";
                int J = 0;

                MKH.Library.Forms.MSSLogViewer_frm ctrl = new MKH.Library.Forms.MSSLogViewer_frm();
                ctrl.GridexViewSelector.DataSource = new MKH.Permission.ViewModel.Log.Log().GetAllListVisitPatientPaymentByID(System.Convert.ToInt64(GridViewVisitPatientPaymentBimeh.CurrentRow.Cells["Id"].Value), ref Str).ToList();
                ctrl.ColumnList = new System.Data.DataTable();
                for (int i = 0; i < GridViewVisitPatientPaymentBimeh.RootTable.Columns.Count; i++)
                    if (GridViewVisitPatientPaymentBimeh.RootTable.Columns[i].Tag == "" || GridViewVisitPatientPaymentBimeh.RootTable.Columns[i].Tag == null)
                    {
                        ctrl.ColumnList.Columns.Add(GridViewVisitPatientPaymentBimeh.RootTable.Columns[i].Key);
                        ctrl.ColumnList.Columns[J].Caption = GridViewVisitPatientPaymentBimeh.RootTable.Columns[i].Caption;
                        J++;
                    }
                ctrl.ShowDialog();
            }
            catch { }
        }

        private void GridViewVisitPatientPaymentBimeh_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                btnSetValueVisit.Enabled = short.Parse(GridViewVisitPatientPaymentBimeh.CurrentRow.Cells["PaymentStatus_Id"].Value.ToString()) == 8;
            }
            catch { }
        }

        private void RadioBoxAllContract_CheckedChanged(object sender, EventArgs e)
        {
            if (SetDate && (sender as MKH.Library.Control.MSSCheckBox).Checked) BindData(GridViewVisitPatientPaymentBimeh.Row);
        }

      


    }
}
