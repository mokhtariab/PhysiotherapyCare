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
    public partial class VisitPatientCarePaymentBimeh_UC : UserControl
    {
        public VisitPatientCarePaymentBimeh_UC()
        {
            InitializeComponent();
        }


        public void BindData(int RowNumberSet)
        {
            string str = "";

            List<VW_VisitPatientCarePayment> LSQ = new List<VW_VisitPatientCarePayment>();

            LSQ = new ViewModel.VisitPatientCare.VisitPatientCarePayment().GetAllList(ref str).ToList();

            //if (str != "") 
            //    MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "اشکال", str);


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
                        LSQ = LSQ.Where(d => MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.InsuLetterDate ?? "") >= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerStart.Value.ToString().Substring(0, 10))
                            && MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.InsuLetterDate ?? "") <= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerEnd.Value.ToString().Substring(0, 10))).ToList();
                    else if (ComboBoxSerach.SelectedIndex == 6)
                        LSQ = LSQ.Where(d => MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.SecretiatDate ?? "") >= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerStart.Value.ToString())
                            && MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.SecretiatDate ?? "") <= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerEnd.Value.ToString())).ToList();
                    else if (ComboBoxSerach.SelectedIndex == 7)
                        LSQ = LSQ.Where(d => MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.BonyadConfirmDate ?? "") >= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerStart.Value.ToString())
                            && MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.BonyadConfirmDate ?? "") <= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerEnd.Value.ToString())).ToList();
                }
                catch (Exception ex)
                {
//                    MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "اشکال", ex.Message);
                }
            }
            GridViewVisitPatientCarePaymentBimeh.DataSource = LSQ;



            try { GridViewVisitPatientCarePaymentBimeh.Row = RowNumberSet; }
            catch { }
        }


        #region All UI Button

        private void headerGridVisitPatientCarePayment_btnInsertClick(object sender, System.EventArgs e)
        {
            //VisitPatientCarePaymentPrePaymentAdd_Frm VisitPatientCarePaymentAdd = new VisitPatientCarePaymentPrePaymentAdd_Frm();

            //if (VisitPatientCarePaymentAdd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //    BindData(GridViewVisitPatientCarePaymentBimeh.RowCount);
        }

        private void headerGridVisitPatientCarePayment_btnEditClick(object sender, System.EventArgs e)
        {
            try
            {
                //if (!(HeaderGridVisitPatientCarePaymentBimeh as MKH.Library.Control.MSSHeaderGrid).Items["buttonItemEdit"].Visible || !(HeaderGridVisitPatientCarePaymentBimeh as MKH.Library.Control.MSSHeaderGrid).Items["buttonItemEdit"].Enabled) return;
                
                if (short.Parse(GridViewVisitPatientCarePaymentBimeh.CurrentRow.Cells["PaymentStatus_Id"].Value.ToString()) != 8)
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View("امکان ویرایش به دلیل ارسال به مالی وجود ندارد", MKH.Library.Clasess.MSSMessage.MessageType.SWarning);
                    return;
                }
                VisitPatientCarePaymentBimehAdd_Frm VisitPatientCarePaymentBimehAdd = new VisitPatientCarePaymentBimehAdd_Frm(
                        int.Parse(GridViewVisitPatientCarePaymentBimeh.CurrentRow.Cells["Id"].Value.ToString()));
                if (VisitPatientCarePaymentBimehAdd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    BindData(GridViewVisitPatientCarePaymentBimeh.Row);
            }
            catch { }
        }

        private void headerGridVisitPatientCarePayment_btnDeleteClick(object sender, System.EventArgs e)
        {
            for (int i = 0; i < GridViewVisitPatientCarePaymentBimeh.SelectedItems.Count; i++)
                if (short.Parse(GridViewVisitPatientCarePaymentBimeh.SelectedItems[i].GetRow().Cells["PaymentStatus_Id"].Value.ToString()) != 8)
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View("امکان حذف به دلیل وجود ردیف (های) ارسال به مالی وجود ندارد", MKH.Library.Clasess.MSSMessage.MessageType.SWarning);
                    return;
                }

            string str = "";

            for (int i = 0; i < GridViewVisitPatientCarePaymentBimeh.SelectedItems.Count; i++)
                if (new ViewModel.Basic.NODuplicateForm().CheckNODuplicateForm("TBL_VisitPatientCarePayment", GridViewVisitPatientCarePaymentBimeh.SelectedItems[i].GetRow().Cells["Id"].Value.ToString(), ref str))
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View("امکان حذف به علت انجام عملیات توسط کاربر دیگر بر روی ردیف (هایی) امکان پذیر نمی باشد", MKH.Library.Clasess.MSSMessage.MessageType.SWarning);
                    return;
                }

            if (MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation, true, "آیا به حذف موارد انتخابی اطمینان دارید؟"))
            {
                try
                {
                    //List<TBL_VisitPatientCarePayment> Ls = new List<TBL_VisitPatientCarePayment>();
                    //for (int i = 0; i < GridViewVisitPatientCarePaymentBimeh.SelectedItems.Count; i++)
                    //{
                    //    TBL_VisitPatientCarePayment VisitPatientCarePaymentBimeh = new TBL_VisitPatientCarePayment();
                    //    VisitPatientCarePaymentBimeh.Id = long.Parse(GridViewVisitPatientCarePaymentBimeh.SelectedItems[i].GetRow().Cells["Id"].Value.ToString());

                    //    VisitPatientCarePaymentBimeh.VisitPatientCare_Id = long.Parse(GridViewVisitPatientCarePaymentBimeh.SelectedItems[i].GetRow().Cells["VisitPatientCare_Id"].Value.ToString());
                    //    VisitPatientCarePaymentBimeh.PaymentType_Id = short.Parse(GridViewVisitPatientCarePaymentBimeh.SelectedItems[i].GetRow().Cells["PaymentType_Id"].Value.ToString());
                    //    VisitPatientCarePaymentBimeh.PaymentStatus_Id = short.Parse(GridViewVisitPatientCarePaymentBimeh.SelectedItems[i].GetRow().Cells["PaymentStatus_Id"].Value.ToString());

                    //    Ls.Add(VisitPatientCarePaymentBimeh);
                    //}

                    //string str = "";
                    //new ViewModel.VisitPatientCare.VisitPatientCarePayment().DeleteEntity(Ls, ref str);


                    List<TBL_VisitPatientCarePayment> Ls = new List<TBL_VisitPatientCarePayment>();
                    ViewModel.VisitPatientCare.VisitPatientCarePayment RN = new ViewModel.VisitPatientCare.VisitPatientCarePayment();
                    for (int i = 0; i < GridViewVisitPatientCarePaymentBimeh.SelectedItems.Count; i++)
                        Ls.Add(RN.GetAllListByTblID(long.Parse(GridViewVisitPatientCarePaymentBimeh.SelectedItems[i].GetRow().Cells["Id"].Value.ToString()), ref str)[0]);

                    new ViewModel.VisitPatientCare.VisitPatientCarePayment().DeleteEntity(Ls, ref str);


                    if (str != "") MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "امکان حذف مورد(های) انتخابی به علت داشتن عملکرد در نرم افزار وجود ندارد", str);
                    else
                        BindData(GridViewVisitPatientCarePaymentBimeh.Row - 1);
                }
                catch (System.Exception ex)
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "اشکال", ex.Message);
                }
            }
        }

        private void headerGridVisitPatientCarePayment_btnRefreshClick(object sender, System.EventArgs e)
        {
            BindData(GridViewVisitPatientCarePaymentBimeh.Row);
        }

        #endregion

        bool SetDate = false;
        private void VisitPatientCarePaymentBimeh_UC_Load(object sender, System.EventArgs e)
        {
            new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionControl(this);

            SetComboBox();
            btnSetValueCare.Enabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(181);
            buttonItemSendCarePayment.Enabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(180);

            ToolStripMenuItemVisitPatientCarePaymentBimehCurrentRow.Enabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(274);
            ToolStripMenuItemVisitPatientCarePaymentBimehAllList.Enabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(275);

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

            comboBoxBank.ValueMember = "Id";
            comboBoxBank.DisplayMember = "TitleName";
            comboBoxBank.DataSource = new PhysiotherapyCare.ViewModel.Basic.Bank().GetAllList(ref str);

        }
        private void ComboBoxSerach_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            BindData(GridViewVisitPatientCarePaymentBimeh.Row);
        }

        private void DatePickerStart_ValueChanged(object sender, KagNetComponents2.PersianMonthCalendarEventArgs e)
        {
            if (SetDate) BindData(GridViewVisitPatientCarePaymentBimeh.Row);
        }

        private void comboBoxSetValue_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            textBoxSetValue.Visible = comboBoxSetValue.SelectedIndex == 0 || comboBoxSetValue.SelectedIndex == 2 || comboBoxSetValue.SelectedIndex == 3 || comboBoxSetValue.SelectedIndex == 5;
            nUpDownSetValue.Visible = comboBoxSetValue.SelectedIndex == 1;
            comboBoxBank.Visible = comboBoxSetValue.SelectedIndex == 4;
        }

        private void btnSetValue_Click(object sender, System.EventArgs e)
        {
            string str = "";
            for (int i = 0; i < GridViewVisitPatientCarePaymentBimeh.SelectedItems.Count; i++)
                if (new ViewModel.Basic.NODuplicateForm().CheckNODuplicateForm("TBL_VisitPatientCarePayment", GridViewVisitPatientCarePaymentBimeh.SelectedItems[i].GetRow().Cells["Id"].Value.ToString(), ref str))
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View("امکان تغییرات به علت انجام عملیات توسط کاربر دیگر امکان پذیر نمی باشد. لطفا کمی بعد سعی کنید", MKH.Library.Clasess.MSSMessage.MessageType.SWarning);
                    return;
                }
            
            long IDSet = 0;

            if (MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation, true, "آیا مقدار درخواستی جهت ردیف های انتخابی ثبت شود؟"))
            {
                try
                {
                    for (int i = 0; i < GridViewVisitPatientCarePaymentBimeh.SelectedItems.Count; i++)
                    {
                        IDSet = long.Parse(GridViewVisitPatientCarePaymentBimeh.SelectedItems[i].GetRow().Cells["Id"].Value.ToString());

                        if (comboBoxSetValue.SelectedIndex == 0)
                        {
                            new ViewModel.VisitPatientCare.VisitPatientCarePayment().UpdateEntityWithFieldValue(
                                IDSet, "InsuLetterNo", textBoxSetValue.Text,
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                            new ViewModel.VisitPatientCare.VisitPatientCarePayment().UpdateEntityWithFieldValue(
                                IDSet, "InsuLetterDate", textBoxSetValue.Text == "" ? "" : DatePickerSet.Value.ToString().Substring(0, 10),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);
                        }
                        else if (comboBoxSetValue.SelectedIndex == 1)
                        {
                            new ViewModel.VisitPatientCare.VisitPatientCarePayment().UpdateEntityWithFieldValue(
                                IDSet, "CostReqInsu", nUpDownSetValue.Value.ToString(),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);
                        }
                        else if (comboBoxSetValue.SelectedIndex == 2)
                            new ViewModel.VisitPatientCare.VisitPatientCarePayment().UpdateEntityWithFieldValue(
                                IDSet, "CasherName", textBoxSetValue.Text,
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);
                        else if (comboBoxSetValue.SelectedIndex == 3)
                            new ViewModel.VisitPatientCare.VisitPatientCarePayment().UpdateEntityWithFieldValue(
                                IDSet, "CasherNationalCode", textBoxSetValue.Text,
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                        else if (comboBoxSetValue.SelectedIndex == 4)
                        {
                            if (comboBoxBank.SelectedIndex == -1) comboBoxBank.SelectedIndex = 0;

                            new ViewModel.VisitPatientCare.VisitPatientCarePayment().UpdateEntityWithFieldValue(
                                IDSet, "Bank_Id", comboBoxBank.SelectedValue.ToString(),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);
                        }

                        else if (comboBoxSetValue.SelectedIndex == 5)
                            new ViewModel.VisitPatientCare.VisitPatientCarePayment().UpdateEntityWithFieldValue(
                                IDSet, "CardBankNo1", textBoxSetValue.Text,
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                    }

                }
                catch (Exception ex)
                {
                }
                BindData(GridViewVisitPatientCarePaymentBimeh.Row);
            }

        }

        private void buttonItemSendCarePayment_Click(object sender, EventArgs e)
        {
            string str = "";

            if (MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation, true, "آیا ردیف های انتخابی جهت مالی ارسال شوند؟"))
            {
                try
                {
                    List<TBL_VisitPatientCarePayment> Ls = new List<TBL_VisitPatientCarePayment>(1);
                    for (int i = 0; i < GridViewVisitPatientCarePaymentBimeh.SelectedItems.Count; i++)
                        if (short.Parse(GridViewVisitPatientCarePaymentBimeh.SelectedItems[i].GetRow().Cells["PaymentStatus_Id"].Value.ToString()) == 8)
                        {
                            new ViewModel.VisitPatientCare.VisitPatientCarePayment().UpdateEntityWithFieldValue(
                                long.Parse(GridViewVisitPatientCarePaymentBimeh.SelectedItems[i].GetRow().Cells["Id"].Value.ToString()), "PaymentStatus_Id", "1",
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);

                            new ViewModel.VisitPatientCare.VisitPatientCarePayment().UpdateEntityWithFieldValue(
                                long.Parse(GridViewVisitPatientCarePaymentBimeh.SelectedItems[i].GetRow().Cells["Id"].Value.ToString()), "PaymentStatusDate", KagNetComponents2.KagPersianDate.Now.ToString(),
                                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                                MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str);
                        }
                    BindData(GridViewVisitPatientCarePaymentBimeh.Row);
                }
                catch (System.Exception ex)
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "اشکال ارسال", ex.Message);
                }
            }
        }

        private void ToolStripMenuItemVisitPatientCarePaymentBimehAllList_Click(object sender, EventArgs e)
        {
            try
            {
                string Str = "";
                int J = 0;

                MKH.Library.Forms.MSSLogViewer_frm ctrl = new MKH.Library.Forms.MSSLogViewer_frm();
                ctrl.GridexViewSelector.DataSource = new MKH.Permission.ViewModel.Log.Log().GetAllListVisitPatientCarePayment(ref Str).ToList();
                ctrl.ColumnList = new System.Data.DataTable();
                for (int i = 0; i < GridViewVisitPatientCarePaymentBimeh.RootTable.Columns.Count; i++)
                    if (GridViewVisitPatientCarePaymentBimeh.RootTable.Columns[i].Visible)
                    {
                        ctrl.ColumnList.Columns.Add(GridViewVisitPatientCarePaymentBimeh.RootTable.Columns[i].Key);
                        ctrl.ColumnList.Columns[J].Caption = GridViewVisitPatientCarePaymentBimeh.RootTable.Columns[i].Caption;
                        J++;
                    }
                ctrl.ShowDialog();
            }
            catch { }
        }

        private void ToolStripMenuItemVisitPatientCarePaymentBimehCurrentRow_Click(object sender, EventArgs e)
        {
            try
            {
                string Str = "";
                int J = 0;

                MKH.Library.Forms.MSSLogViewer_frm ctrl = new MKH.Library.Forms.MSSLogViewer_frm();
                ctrl.GridexViewSelector.DataSource = new MKH.Permission.ViewModel.Log.Log().GetAllListVisitPatientCarePaymentByID(System.Convert.ToInt64(GridViewVisitPatientCarePaymentBimeh.CurrentRow.Cells["Id"].Value), ref Str).ToList();
                ctrl.ColumnList = new System.Data.DataTable();
                for (int i = 0; i < GridViewVisitPatientCarePaymentBimeh.RootTable.Columns.Count; i++)
                    if (GridViewVisitPatientCarePaymentBimeh.RootTable.Columns[i].Tag == "" || GridViewVisitPatientCarePaymentBimeh.RootTable.Columns[i].Tag == null)
                    {
                        ctrl.ColumnList.Columns.Add(GridViewVisitPatientCarePaymentBimeh.RootTable.Columns[i].Key);
                        ctrl.ColumnList.Columns[J].Caption = GridViewVisitPatientCarePaymentBimeh.RootTable.Columns[i].Caption;
                        J++;
                    }
                ctrl.ShowDialog();
            }
            catch { }
        }

        private void GridViewVisitPatientCarePaymentBimeh_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                btnSetValueCare.Enabled = short.Parse(GridViewVisitPatientCarePaymentBimeh.CurrentRow.Cells["PaymentStatus_Id"].Value.ToString()) == 8;
            }
            catch { }
        }

    }
}
