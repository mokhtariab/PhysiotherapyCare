using System.Linq;
using System.Collections.Generic;
using PhysiotherapyCare.Model.Basic;
using PhysiotherapyCare.Model;
using MKH.Library.Clasess.FilterClass;
using System.Windows.Forms;
using PhysiotherapyCare.Model.VisitHealthCare;
using System;

namespace PhysiotherapyCare.View.MainForms.VisitHealthCare
{
    public partial class VisitHealthCarePaymentBimeh_UC : UserControl
    {
        public VisitHealthCarePaymentBimeh_UC()
        {
            InitializeComponent();
        }


        public void BindData(int RowNumberSet)
        {
            string str = "";

            List<VW_VisitHealthCarePayment> LSQ = new List<VW_VisitHealthCarePayment>();

            LSQ = new ViewModel.VisitHealthCare.VisitHealthCarePayment().GetAllList(ref str).ToList();


            if (RadioBoxPaymentStatus1.Checked)
                LSQ = LSQ.Where(ei => ei.PaymentStatus_Id == 8).ToList();
            if (RadioBoxPaymentStatusNot1.Checked)
                LSQ = LSQ.Where(ei => ei.PaymentStatus_Id != 8).ToList();

            try
            {
                if (RadioBoxContractWithTime.Checked)
                {
                    if (ComboBoxSerach.SelectedIndex == 0)
                        LSQ = LSQ.Where(d => MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.HealthCareDate ?? "") >= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerStart.Value.ToString())
                            && MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.HealthCareDate ?? "") <= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerEnd.Value.ToString())).ToList();
                    else if (ComboBoxSerach.SelectedIndex == 1)
                        LSQ = LSQ.Where(d => MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.ContractDate ?? "") >= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerStart.Value.ToString())
                                && MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.ContractDate ?? "") <= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerEnd.Value.ToString())).ToList();
                    else if (ComboBoxSerach.SelectedIndex == 2)
                        LSQ = LSQ.Where(d => MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.PaymentDate ?? "") >= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerStart.Value.ToString())
                                && MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.PaymentDate ?? "") <= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerEnd.Value.ToString())).ToList();
                    else if (ComboBoxSerach.SelectedIndex == 3)
                        LSQ = LSQ.Where(d => MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.LetterDate ?? "") >= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerStart.Value.ToString())
                            && MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.LetterDate ?? "") <= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerEnd.Value.ToString())).ToList();
                    else if (ComboBoxSerach.SelectedIndex == 4)
                        LSQ = LSQ.Where(d => MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.InsuLetterDate ?? "") >= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerStart.Value.ToString())
                            && MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.InsuLetterDate ?? "") <= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerEnd.Value.ToString())).ToList();
                    else if (ComboBoxSerach.SelectedIndex == 5)
                        LSQ = LSQ.Where(d => MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.SecretiatDate ?? "") >= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerStart.Value.ToString())
                            && MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.SecretiatDate ?? "") <= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerEnd.Value.ToString())).ToList();
                    else if (ComboBoxSerach.SelectedIndex == 6)
                        LSQ = LSQ.Where(d => MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.BonyadConfirmDate ?? "") >= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerStart.Value.ToString())
                            && MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.BonyadConfirmDate ?? "") <= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerEnd.Value.ToString())).ToList();
                }

            }
            catch { }

            GridViewVisitHealthCarePaymentBimeh.DataSource = LSQ;

            try { GridViewVisitHealthCarePaymentBimeh.Row = RowNumberSet; }
            catch { }
        }


        #region All UI Button

        private void headerGridVisitHealthCarePaymentBimeh_btnInsertClick(object sender, System.EventArgs e)
        {

            //VisitHealthCarePaymentPrePaymentAdd_Frm VisitHealthCarePaymentBimehPrePaymentAdd = new VisitHealthCarePaymentPrePaymentAdd_Frm();

            //if (VisitHealthCarePaymentBimehPrePaymentAdd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //    BindData(GridViewVisitHealthCarePaymentBimeh.RowCount);
        }

        private void headerGridVisitHealthCarePaymentBimeh_btnEditClick(object sender, System.EventArgs e)
        {
            try
            {
                //if (!(HeaderGridVisitHealthCarePaymentBimeh as MKH.Library.Control.MSSHeaderGrid).Items["buttonItemEdit"].Visible || !(HeaderGridVisitHealthCarePaymentBimeh as MKH.Library.Control.MSSHeaderGrid).Items["buttonItemEdit"].Enabled) return;

                if (short.Parse(GridViewVisitHealthCarePaymentBimeh.CurrentRow.Cells["PaymentStatus_Id"].Value.ToString()) != 8)
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View("امکان ویرایش به دلیل ارسال به مالی وجود ندارد", MKH.Library.Clasess.MSSMessage.MessageType.SWarning);
                    return;
                }
                

                VisitHealthCarePaymentBimehAdd_Frm VisitHealthCarePaymentBimehAdd = new VisitHealthCarePaymentBimehAdd_Frm(
                        int.Parse(GridViewVisitHealthCarePaymentBimeh.CurrentRow.Cells["Id"].Value.ToString()));
                if (VisitHealthCarePaymentBimehAdd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    BindData(GridViewVisitHealthCarePaymentBimeh.Row);

            }
            catch { }
        }

        private void headerGridVisitHealthCarePaymentBimeh_btnDeleteClick(object sender, System.EventArgs e)
        {
            for (int i = 0; i < GridViewVisitHealthCarePaymentBimeh.SelectedItems.Count; i++)
                if (short.Parse(GridViewVisitHealthCarePaymentBimeh.SelectedItems[i].GetRow().Cells["PaymentStatus_Id"].Value.ToString()) != 8)
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View("امکان حذف به دلیل وجود ردیف (های) ارسال به مالی وجود ندارد", MKH.Library.Clasess.MSSMessage.MessageType.SWarning);
                    return;
                }

            string str = "";
            for (int i = 0; i < GridViewVisitHealthCarePaymentBimeh.SelectedItems.Count; i++)
                if (new ViewModel.Basic.NODuplicateForm().CheckNODuplicateForm("TBL_VisitHealthCarePayment", GridViewVisitHealthCarePaymentBimeh.SelectedItems[i].GetRow().Cells["Id"].Value.ToString(), ref str))
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View("امکان حذف به علت انجام عملیات توسط کاربر دیگر بر روی ردیف (هایی) امکان پذیر نمی باشد", MKH.Library.Clasess.MSSMessage.MessageType.SWarning);
                    return;
                }


            if (MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation, true, "آیا به حذف موارد انتخابی اطمینان دارید؟"))
            {
                try
                {
                    //List<TBL_VisitHealthCarePayment> Ls = new List<TBL_VisitHealthCarePayment>();
                    //for (int i = 0; i < GridViewVisitHealthCarePaymentBimeh.SelectedItems.Count; i++)
                    //{
                    //    TBL_VisitHealthCarePayment VisitHealthCarePaymentBimeh = new TBL_VisitHealthCarePayment();
                    //    VisitHealthCarePaymentBimeh.Id = long.Parse(GridViewVisitHealthCarePaymentBimeh.SelectedItems[i].GetRow().Cells["Id"].Value.ToString());
                    //    VisitHealthCarePaymentBimeh.VisitHealthCare_Id = long.Parse(GridViewVisitHealthCarePaymentBimeh.SelectedItems[i].GetRow().Cells["VisitHealthCare_Id"].Value.ToString());
                    //    VisitHealthCarePaymentBimeh.PaymentType_Id = short.Parse(GridViewVisitHealthCarePaymentBimeh.SelectedItems[i].GetRow().Cells["PaymentType_Id"].Value.ToString());
                    //    VisitHealthCarePaymentBimeh.PaymentStatus_Id = short.Parse(GridViewVisitHealthCarePaymentBimeh.SelectedItems[i].GetRow().Cells["PaymentStatus_Id"].Value.ToString());
                    //    Ls.Add(VisitHealthCarePaymentBimeh);
                    //}
                    //string str = "";
                    //new ViewModel.VisitHealthCare.VisitHealthCarePayment().DeleteEntity(Ls, ref str);


                    List<TBL_VisitHealthCarePayment> Ls = new List<TBL_VisitHealthCarePayment>();
                    ViewModel.VisitHealthCare.VisitHealthCarePayment RN = new ViewModel.VisitHealthCare.VisitHealthCarePayment();
                    for (int i = 0; i < GridViewVisitHealthCarePaymentBimeh.SelectedItems.Count; i++)
                        Ls.Add(RN.GetAllListByTblID(long.Parse(GridViewVisitHealthCarePaymentBimeh.SelectedItems[i].GetRow().Cells["Id"].Value.ToString()), ref str)[0]);

                    new ViewModel.VisitHealthCare.VisitHealthCarePayment().DeleteEntity(Ls, ref str);


                    if (str != "") MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "امکان حذف مورد(های) انتخابی به علت داشتن عملکرد در نرم افزار وجود ندارد", str);
                    else
                    {
                        //for (int i = 0; i < GridViewVisitHealthCarePaymentBimeh.SelectedItems.Count; i++)
                        //    try
                        //    {
                        //        new ViewModel.VisitHealthCare.VisitHealthCare().UpdateVisitStatus(long.Parse(GridViewVisitHealthCarePaymentBimeh.SelectedItems[i].GetRow().Cells["VisitHealthCare_Id"].Value.ToString()), 1,
                        //        MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                        //        MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(System.DateTime.Now),
                        //        ref str);
                        //    }
                        //    catch { }
                        BindData(GridViewVisitHealthCarePaymentBimeh.Row - 1);
                    }
                }
                catch (System.Exception ex)
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "اشکال", ex.Message);
                }
            }
        }

        private void headerGridVisitHealthCarePaymentBimeh_btnRefreshClick(object sender, System.EventArgs e)
        {
            BindData(GridViewVisitHealthCarePaymentBimeh.Row);
        }

        #endregion

        bool SetDate = false;
        private void VisitHealthCarePaymentBimeh_UC_Load(object sender, System.EventArgs e)
        {
            new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionControl(this);
            
            SetComboBox();

            btnSetValueHealth.Enabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(197);
            buttonItemSendHealthCarePayment.Enabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(196);

            ToolStripMenuItemVisitHealthCarePaymentBimehCurrentRow.Enabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(268);
            ToolStripMenuItemVisitHealthCarePaymentBimehAllList.Enabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(269);

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
            //BindData(0);
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
            BindData(GridViewVisitHealthCarePaymentBimeh.Row);
        }

        private void DatePickerStart_ValueChanged(object sender, KagNetComponents2.PersianMonthCalendarEventArgs e)
        {
            if (SetDate) BindData(GridViewVisitHealthCarePaymentBimeh.Row);
        }

        private void comboBoxSetValue_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            textBoxSetValue.Visible = comboBoxSetValue.SelectedIndex == 0;
            nUpDownSetValue.Visible = comboBoxSetValue.SelectedIndex == 1;
        }

        private void btnSetValue_Click(object sender, System.EventArgs e)
        {
            string str = "";

            for (int i = 0; i < GridViewVisitHealthCarePaymentBimeh.SelectedItems.Count; i++)
                if (new ViewModel.Basic.NODuplicateForm().CheckNODuplicateForm("TBL_VisitHealthCarePayment", GridViewVisitHealthCarePaymentBimeh.SelectedItems[i].GetRow().Cells["Id"].Value.ToString(), ref str))
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View("امکان تغییرات به علت انجام عملیات توسط کاربر دیگر امکان پذیر نمی باشد. لطفا کمی بعد سعی کنید", MKH.Library.Clasess.MSSMessage.MessageType.SWarning);
                    return;
                }

            long IDSet = 0;

            if (MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation, true, "آیا مقدار درخواستی جهت ردیف های انتخابی ثبت شود؟"))
            {
                try
                {
                    //int CostCompanyPhysiotherapyPercent = new ViewModel.Setting.Setting().GetAllValue("CostCompanyPhsiotraphyPercent", ref str).ToString().ToInt();

                    for (int i = 0; i < GridViewVisitHealthCarePaymentBimeh.SelectedItems.Count; i++)
                    {
                        IDSet = long.Parse(GridViewVisitHealthCarePaymentBimeh.SelectedItems[i].GetRow().Cells["Id"].Value.ToString());

                        //if (GridViewVisitHealthCarePaymentBimeh.SelectedItems[i].GetRow().Cells["PaymentTypeName"].Value.ToString() == "پیش پرداخت" ||
                        //    GridViewVisitHealthCarePaymentBimeh.SelectedItems[i].GetRow().Cells["PaymentTypeName"].Value.ToString() == "کسورات")
                        //    return;


                        if (comboBoxSetValue.SelectedIndex == 0)
                        {
                            new ViewModel.VisitHealthCare.VisitHealthCarePayment().UpdateEntityWithFieldValue(
                                IDSet, "InsuLetterNo", textBoxSetValue.Text,
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                            new ViewModel.VisitHealthCare.VisitHealthCarePayment().UpdateEntityWithFieldValue(
                                IDSet, "InsuLetterDate", textBoxSetValue.Text == "" ? "" : DatePickerSet.Value.ToString().Substring(0, 10),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);
                        }
                        else if (comboBoxSetValue.SelectedIndex == 1)
                        {
                            new ViewModel.VisitHealthCare.VisitHealthCarePayment().UpdateEntityWithFieldValue(
                                IDSet, "CostReqInsu", nUpDownSetValue.Value.ToString(),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);
                        }

                    }

                }
                catch (Exception ex)
                {
                }
                BindData(GridViewVisitHealthCarePaymentBimeh.Row);
            }
        }

       

        private void GridViewVisitHealthCarePaymentBimeh_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                serviceHealthCare_UC1.BindData(System.Convert.ToInt32(GridViewVisitHealthCarePaymentBimeh.CurrentRow.Cells["VisitHealthCare_Id"].Value));
            }
            catch { }
            try
            {
                btnSetValueHealth.Enabled = short.Parse(GridViewVisitHealthCarePaymentBimeh.CurrentRow.Cells["PaymentStatus_Id"].Value.ToString()) == 8;
            }
            catch { }
        }

        private void buttonItemSendHealthCarePayment_Click(object sender, EventArgs e)
        {
            string str = "";

            for (int i = 0; i < GridViewVisitHealthCarePaymentBimeh.SelectedItems.Count; i++)
                if (new ViewModel.Basic.NODuplicateForm().CheckNODuplicateForm("TBL_VisitHealthCarePayment", GridViewVisitHealthCarePaymentBimeh.SelectedItems[i].GetRow().Cells["Id"].Value.ToString(), ref str))
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View("امکان تغییرات به علت انجام عملیات توسط کاربر دیگر امکان پذیر نمی باشد. لطفا کمی بعد سعی کنید", MKH.Library.Clasess.MSSMessage.MessageType.SWarning);
                    return;
                }

            if (MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation, true, "آیا ردیف های انتخابی جهت مالی ارسال شوند؟"))
            {
                try
                {
                    List<TBL_VisitHealthCarePayment> Ls = new List<TBL_VisitHealthCarePayment>(1);
                    for (int i = 0; i < GridViewVisitHealthCarePaymentBimeh.SelectedItems.Count; i++)
                        if (short.Parse(GridViewVisitHealthCarePaymentBimeh.SelectedItems[i].GetRow().Cells["PaymentStatus_Id"].Value.ToString()) == 8)
                        {
                            new ViewModel.VisitHealthCare.VisitHealthCarePayment().UpdateEntityWithFieldValue(
                                long.Parse(GridViewVisitHealthCarePaymentBimeh.SelectedItems[i].GetRow().Cells["Id"].Value.ToString()), "PaymentStatus_Id", "1",
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                            new ViewModel.VisitHealthCare.VisitHealthCarePayment().UpdateEntityWithFieldValue(
                                long.Parse(GridViewVisitHealthCarePaymentBimeh.SelectedItems[i].GetRow().Cells["Id"].Value.ToString()), "PaymentStatusDate", KagNetComponents2.KagPersianDate.Now.ToString(),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);
                        }
                    BindData(GridViewVisitHealthCarePaymentBimeh.Row);
                }
                catch (System.Exception ex)
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "اشکال ارسال", ex.Message);
                }
            }
        }

        private void ToolStripMenuItemVisitHealthCarePaymentBimehCurrentRow_Click(object sender, EventArgs e)
        {
            try
            {
                string Str = "";
                int J = 0;

                MKH.Library.Forms.MSSLogViewer_frm ctrl = new MKH.Library.Forms.MSSLogViewer_frm();
                ctrl.GridexViewSelector.DataSource = new MKH.Permission.ViewModel.Log.Log().GetAllListVisitHealthCarePaymentByID(System.Convert.ToInt64(GridViewVisitHealthCarePaymentBimeh.CurrentRow.Cells["Id"].Value), ref Str).ToList();
                ctrl.ColumnList = new System.Data.DataTable();
                for (int i = 0; i < GridViewVisitHealthCarePaymentBimeh.RootTable.Columns.Count; i++)
                    if (GridViewVisitHealthCarePaymentBimeh.RootTable.Columns[i].Tag == "" || GridViewVisitHealthCarePaymentBimeh.RootTable.Columns[i].Tag == null)
                    {
                        ctrl.ColumnList.Columns.Add(GridViewVisitHealthCarePaymentBimeh.RootTable.Columns[i].Key);
                        ctrl.ColumnList.Columns[J].Caption = GridViewVisitHealthCarePaymentBimeh.RootTable.Columns[i].Caption;
                        J++;
                    }
                ctrl.ShowDialog();
            }
            catch { }
        }

        private void ToolStripMenuItemVisitHealthCarePaymentBimehAllList_Click(object sender, EventArgs e)
        {
            try
            {
                string Str = "";
                int J = 0;

                MKH.Library.Forms.MSSLogViewer_frm ctrl = new MKH.Library.Forms.MSSLogViewer_frm();
                ctrl.GridexViewSelector.DataSource = new MKH.Permission.ViewModel.Log.Log().GetAllListVisitHealthCarePayment(ref Str).ToList();
                ctrl.ColumnList = new System.Data.DataTable();
                for (int i = 0; i < GridViewVisitHealthCarePaymentBimeh.RootTable.Columns.Count; i++)
                    if (GridViewVisitHealthCarePaymentBimeh.RootTable.Columns[i].Visible)
                    {
                        ctrl.ColumnList.Columns.Add(GridViewVisitHealthCarePaymentBimeh.RootTable.Columns[i].Key);
                        ctrl.ColumnList.Columns[J].Caption = GridViewVisitHealthCarePaymentBimeh.RootTable.Columns[i].Caption;
                        J++;
                    }
                ctrl.ShowDialog();
            }
            catch { }
        }


    }
}
