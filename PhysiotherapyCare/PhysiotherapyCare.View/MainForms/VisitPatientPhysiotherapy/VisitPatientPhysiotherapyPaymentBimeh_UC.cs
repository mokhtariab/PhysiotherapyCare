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
    public partial class VisitPatientPhysiotherapyPaymentBimeh_UC : UserControl
    {
        public VisitPatientPhysiotherapyPaymentBimeh_UC()
        {
            InitializeComponent();
        }


        public void BindData(int RowNumberSet)
        {
            string str = "";
             
            List<VW_VisitPatientPhysiotherapyPayment> LSQ = new List<VW_VisitPatientPhysiotherapyPayment>();

            LSQ = new ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapyPayment().GetAllList(ref str).ToList();



            if (RadioBoxPaymentStatus1.Checked)
                LSQ = LSQ.Where(ei => ei.PaymentStatus_Id == 8).ToList();
            if (RadioBoxPaymentStatusNot1.Checked)
                LSQ = LSQ.Where(ei => ei.PaymentStatus_Id != 8).ToList();
            if (RadioBoxContractWithTime.Checked)
            {
                try
                {
                    if (ComboBoxSerach.SelectedIndex == 0)
                        LSQ = LSQ.Where(d => MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.PaymentDate ?? "") >= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerStart.Value.ToString())
                            && MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.PaymentDate ?? "") <= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerEnd.Value.ToString())).ToList();
                    else if (ComboBoxSerach.SelectedIndex == 1)
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
                        LSQ = LSQ.Where(d => MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.BonyadConfirmDate ?? "") >= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerStart.Value.ToString())
                            && MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.BonyadConfirmDate ?? "") <= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerEnd.Value.ToString())).ToList();
                }
                catch { }
            }
            
            GridViewVisitPatientPhysiotherapyPaymentBimeh.DataSource = LSQ;

            try { GridViewVisitPatientPhysiotherapyPaymentBimeh.Row = RowNumberSet; }
            catch { }
        }


        #region All UI Button



        private void headerGridVisitPatientPhysiotherapyPaymentBimeh_btnEditClick(object sender, System.EventArgs e)
        {
            try
            {
                //if (!(HeaderGridVisitPatientPhysiotherapyPaymentBimeh as MKH.Library.Control.MSSHeaderGrid).Items["buttonItemEdit"].Visible || !(HeaderGridVisitPatientPhysiotherapyPaymentBimeh as MKH.Library.Control.MSSHeaderGrid).Items["buttonItemEdit"].Enabled) return;

                if (short.Parse(GridViewVisitPatientPhysiotherapyPaymentBimeh.CurrentRow.Cells["PaymentStatus_Id"].Value.ToString()) != 8)
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View("امکان ویرایش به دلیل ارسال به مالی وجود ندارد", MKH.Library.Clasess.MSSMessage.MessageType.SWarning);
                    return;
                }

                VisitPatientPhysiotherapyPaymentBimehAdd_Frm VisitPatientPhysiotherapyPaymentBimehAdd = new VisitPatientPhysiotherapyPaymentBimehAdd_Frm(
                        int.Parse(GridViewVisitPatientPhysiotherapyPaymentBimeh.CurrentRow.Cells["Id"].Value.ToString()));
                if (VisitPatientPhysiotherapyPaymentBimehAdd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    BindData(GridViewVisitPatientPhysiotherapyPaymentBimeh.Row);
            }
            catch { }
        }

        private void headerGridVisitPatientPhysiotherapyPaymentBimeh_btnDeleteClick(object sender, System.EventArgs e)
        {
            for (int i = 0; i < GridViewVisitPatientPhysiotherapyPaymentBimeh.SelectedItems.Count; i++)
                if (short.Parse(GridViewVisitPatientPhysiotherapyPaymentBimeh.SelectedItems[i].GetRow().Cells["PaymentStatus_Id"].Value.ToString()) != 8)
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View("امکان حذف به دلیل وجود ردیف (های) ارسال به مالی وجود ندارد", MKH.Library.Clasess.MSSMessage.MessageType.SWarning);
                    return;
                }

            string str = "";

            for (int i = 0; i < GridViewVisitPatientPhysiotherapyPaymentBimeh.SelectedItems.Count; i++)
                if (new ViewModel.Basic.NODuplicateForm().CheckNODuplicateForm("TBL_VisitPatientPhysiotherapyPayment", GridViewVisitPatientPhysiotherapyPaymentBimeh.SelectedItems[i].GetRow().Cells["Id"].Value.ToString(), ref str))
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View("امکان حذف به علت انجام عملیات توسط کاربر دیگر بر روی ردیف (هایی) امکان پذیر نمی باشد", MKH.Library.Clasess.MSSMessage.MessageType.SWarning);
                    return;
                }

            if (MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation, true, "آیا به حذف موارد انتخابی اطمینان دارید؟"))
            {
                try
                {
                    //List<TBL_VisitPatientPhysiotherapyPayment> Ls = new List<TBL_VisitPatientPhysiotherapyPayment>();
                    //for (int i = 0; i < GridViewVisitPatientPhysiotherapyPaymentBimeh.SelectedItems.Count; i++)
                    //{
                    //    TBL_VisitPatientPhysiotherapyPayment VisitPatientPhysiotherapyPaymentBimeh = new TBL_VisitPatientPhysiotherapyPayment();
                    //    VisitPatientPhysiotherapyPaymentBimeh.Id = long.Parse(GridViewVisitPatientPhysiotherapyPaymentBimeh.SelectedItems[i].GetRow().Cells["Id"].Value.ToString());

                    //    VisitPatientPhysiotherapyPaymentBimeh.VisitPatientPhysiotherapy_Id = long.Parse(GridViewVisitPatientPhysiotherapyPaymentBimeh.SelectedItems[i].GetRow().Cells["VisitPatientPhysiotherapy_Id"].Value.ToString());
                    //    VisitPatientPhysiotherapyPaymentBimeh.PaymentType_Id = short.Parse(GridViewVisitPatientPhysiotherapyPaymentBimeh.SelectedItems[i].GetRow().Cells["PaymentType_Id"].Value.ToString());
                    //    VisitPatientPhysiotherapyPaymentBimeh.PaymentStatus_Id = short.Parse(GridViewVisitPatientPhysiotherapyPaymentBimeh.SelectedItems[i].GetRow().Cells["PaymentStatus_Id"].Value.ToString());

                    //    Ls.Add(VisitPatientPhysiotherapyPaymentBimeh);
                    //}

                    //string str = "";
                    //new ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapyPayment().DeleteEntity(Ls, ref str);


                    List<TBL_VisitPatientPhysiotherapyPayment> Ls = new List<TBL_VisitPatientPhysiotherapyPayment>();
                    ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapyPayment RN = new ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapyPayment();
                    for (int i = 0; i < GridViewVisitPatientPhysiotherapyPaymentBimeh.SelectedItems.Count; i++)
                        Ls.Add(RN.GetAllListByTblID(long.Parse(GridViewVisitPatientPhysiotherapyPaymentBimeh.SelectedItems[i].GetRow().Cells["Id"].Value.ToString()), ref str)[0]);

                    new ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapyPayment().DeleteEntity(Ls, ref str);



                    if (str != "") MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "امکان حذف مورد(های) انتخابی به علت داشتن عملکرد در نرم افزار وجود ندارد", str);
                    else
                    {
                        //for (int i = 0; i < GridViewVisitPatientPhysiotherapyPaymentBimeh.SelectedItems.Count; i++)
                        //    new ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapy().UpdateVisitStatus(long.Parse(GridViewVisitPatientPhysiotherapyPaymentBimeh.SelectedItems[i].GetRow().Cells["VisitPatientPhysiotherapy_Id"].Value.ToString()), 1,
                        //        MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                        //        MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(System.DateTime.Now),
                        //        ref str);
                        BindData(GridViewVisitPatientPhysiotherapyPaymentBimeh.Row - 1);
                    }
                }
                catch (System.Exception ex)
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "امکان حذف این مورد در سیستم وجود ندارد", ex.Message);
                }
            }
        }

        private void headerGridVisitPatientPhysiotherapyPaymentBimeh_btnRefreshClick(object sender, System.EventArgs e)
        {
            BindData(GridViewVisitPatientPhysiotherapyPaymentBimeh.Row);
        }

        #endregion

        bool SetDate = false;
        private void VisitPatientPhysiotherapyPaymentBimeh_UC_Load(object sender, System.EventArgs e)
        {
            new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionControl(this);

            SetComboBox();
            btnSetValuePhysioterapy.Enabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(189);
            buttonItemSendPhysioterapyPayment.Enabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(188);
            ToolStripMenuItemVisitPatientPhysiotherapyPaymentBimehCurrentRow.Enabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(281);
            ToolStripMenuItemVisitPatientPhysiotherapyPaymentBimehAllList.Enabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(282);


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
        }
        private void ComboBoxSerach_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            BindData(GridViewVisitPatientPhysiotherapyPaymentBimeh.Row);
        }

        private void DatePickerStart_ValueChanged(object sender, KagNetComponents2.PersianMonthCalendarEventArgs e)
        {
            if (SetDate) BindData(GridViewVisitPatientPhysiotherapyPaymentBimeh.Row);
        }

        private void comboBoxSetValue_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            textBoxSetValue.Visible = comboBoxSetValue.SelectedIndex == 0;
            nUpDownSetValue.Visible = comboBoxSetValue.SelectedIndex == 1;
        }

        private void btnSetValue_Click(object sender, System.EventArgs e)
        {
            string str = "";
            long IDSet = 0;

            for (int i = 0; i < GridViewVisitPatientPhysiotherapyPaymentBimeh.SelectedItems.Count; i++)
                if (new ViewModel.Basic.NODuplicateForm().CheckNODuplicateForm("TBL_VisitPatientPhysiotherapyPayment", GridViewVisitPatientPhysiotherapyPaymentBimeh.SelectedItems[i].GetRow().Cells["Id"].Value.ToString(), ref str))
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View("امکان تغییرات به علت انجام عملیات توسط کاربر دیگر امکان پذیر نمی باشد. لطفا کمی بعد سعی کنید", MKH.Library.Clasess.MSSMessage.MessageType.SWarning);
                    return;
                }

            if (MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation, true, "آیا مقدار درخواستی جهت ردیف های انتخابی ثبت شود؟"))
            {
                try
                {
                    int CostCompanyPhysiotherapyPercent = new ViewModel.Setting.Setting().GetAllValue("CostCompanyPhsiotraphyPercent", ref str).ToString().ToInt();

                    for (int i = 0; i < GridViewVisitPatientPhysiotherapyPaymentBimeh.SelectedItems.Count; i++)
                    {
                        IDSet = long.Parse(GridViewVisitPatientPhysiotherapyPaymentBimeh.SelectedItems[i].GetRow().Cells["Id"].Value.ToString());


                        if (comboBoxSetValue.SelectedIndex == 0)
                        {
                            new ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapyPayment().UpdateEntityWithFieldValue(
                                IDSet, "InsuLetterNo", textBoxSetValue.Text,
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                            new ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapyPayment().UpdateEntityWithFieldValue(
                                IDSet, "InsuLetterDate", textBoxSetValue.Text == "" ? "" : DatePickerSet.Value.ToString().Substring(0, 10),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);
                        }
                        else if (comboBoxSetValue.SelectedIndex == 1)
                            new ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapyPayment().UpdateEntityWithFieldValue(
                                IDSet, "CostReqInsu", nUpDownSetValue.Value.ToString(),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);                       

                        
                    }

                }
                catch (Exception ex)
                {
                }
                BindData(GridViewVisitPatientPhysiotherapyPaymentBimeh.Row);
            }
        }

        private void buttonItemSendPhysioterapyPayment_Click(object sender, EventArgs e)
        {
            string str = "";

            for (int i = 0; i < GridViewVisitPatientPhysiotherapyPaymentBimeh.SelectedItems.Count; i++)
                if (new ViewModel.Basic.NODuplicateForm().CheckNODuplicateForm("TBL_VisitPatientPhysiotherapyPayment", GridViewVisitPatientPhysiotherapyPaymentBimeh.SelectedItems[i].GetRow().Cells["Id"].Value.ToString(), ref str))
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View("امکان تغییرات به علت انجام عملیات توسط کاربر دیگر امکان پذیر نمی باشد. لطفا کمی بعد سعی کنید", MKH.Library.Clasess.MSSMessage.MessageType.SWarning);
                    return;
                }

            if (MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation, true, "آیا ردیف های انتخابی جهت مالی ارسال شوند؟"))
            {
                try
                {
                    List<TBL_VisitPatientPhysiotherapyPayment> Ls = new List<TBL_VisitPatientPhysiotherapyPayment>(1);
                    for (int i = 0; i < GridViewVisitPatientPhysiotherapyPaymentBimeh.SelectedItems.Count; i++)
                        if (short.Parse(GridViewVisitPatientPhysiotherapyPaymentBimeh.SelectedItems[i].GetRow().Cells["PaymentStatus_Id"].Value.ToString()) == 8)
                        {
                            new ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapyPayment().UpdateEntityWithFieldValue(
                                long.Parse(GridViewVisitPatientPhysiotherapyPaymentBimeh.SelectedItems[i].GetRow().Cells["Id"].Value.ToString()), "PaymentStatus_Id", "1",
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                            new ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapyPayment().UpdateEntityWithFieldValue(
                                long.Parse(GridViewVisitPatientPhysiotherapyPaymentBimeh.SelectedItems[i].GetRow().Cells["Id"].Value.ToString()), "PaymentStatusDate", KagNetComponents2.KagPersianDate.Now.ToString(),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);
                        }
                    BindData(GridViewVisitPatientPhysiotherapyPaymentBimeh.Row);
                }
                catch (System.Exception ex)
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "اشکال ارسال", ex.Message);
                }
            }

        }

        private void ToolStripMenuItemVisitPatientPhysiotherapyPaymentBimehCurrentRow_Click(object sender, EventArgs e)
        {
            try
            {
                string Str = "";
                int J = 0;

                MKH.Library.Forms.MSSLogViewer_frm ctrl = new MKH.Library.Forms.MSSLogViewer_frm();
                ctrl.GridexViewSelector.DataSource = new MKH.Permission.ViewModel.Log.Log().GetAllListVisitPatientPhysiotherapyPaymentByID(System.Convert.ToInt64(GridViewVisitPatientPhysiotherapyPaymentBimeh.CurrentRow.Cells["Id"].Value), ref Str).ToList();
                ctrl.ColumnList = new System.Data.DataTable();
                for (int i = 0; i < GridViewVisitPatientPhysiotherapyPaymentBimeh.RootTable.Columns.Count; i++)
                    if (GridViewVisitPatientPhysiotherapyPaymentBimeh.RootTable.Columns[i].Tag == "" || GridViewVisitPatientPhysiotherapyPaymentBimeh.RootTable.Columns[i].Tag == null)
                    {
                        ctrl.ColumnList.Columns.Add(GridViewVisitPatientPhysiotherapyPaymentBimeh.RootTable.Columns[i].Key);
                        ctrl.ColumnList.Columns[J].Caption = GridViewVisitPatientPhysiotherapyPaymentBimeh.RootTable.Columns[i].Caption;
                        J++;
                    }
                ctrl.ShowDialog();
            }
            catch { }
        }

        private void ToolStripMenuItemVisitPatientPhysiotherapyPaymentBimehAllList_Click(object sender, EventArgs e)
        {
            try
            {
                string Str = "";
                int J = 0;

                MKH.Library.Forms.MSSLogViewer_frm ctrl = new MKH.Library.Forms.MSSLogViewer_frm();
                ctrl.GridexViewSelector.DataSource = new MKH.Permission.ViewModel.Log.Log().GetAllListVisitPatientPhysiotherapyPayment(ref Str).ToList();
                ctrl.ColumnList = new System.Data.DataTable();
                for (int i = 0; i < GridViewVisitPatientPhysiotherapyPaymentBimeh.RootTable.Columns.Count; i++)
                    if (GridViewVisitPatientPhysiotherapyPaymentBimeh.RootTable.Columns[i].Visible)
                    {
                        ctrl.ColumnList.Columns.Add(GridViewVisitPatientPhysiotherapyPaymentBimeh.RootTable.Columns[i].Key);
                        ctrl.ColumnList.Columns[J].Caption = GridViewVisitPatientPhysiotherapyPaymentBimeh.RootTable.Columns[i].Caption;
                        J++;
                    }
                ctrl.ShowDialog();
            }
            catch { }
        }

        private void GridViewVisitPatientPhysiotherapyPaymentBimeh_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                btnSetValuePhysioterapy.Enabled = short.Parse(GridViewVisitPatientPhysiotherapyPaymentBimeh.CurrentRow.Cells["PaymentStatus_Id"].Value.ToString()) == 8;
            }
            catch { }
        }

      


    }
}
