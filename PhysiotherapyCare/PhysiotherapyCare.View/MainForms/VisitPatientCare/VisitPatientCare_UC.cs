using System.Linq;
using System.Collections.Generic;
using PhysiotherapyCare.Model.Basic;
using PhysiotherapyCare.Model;
using MKH.Library.Clasess.FilterClass;
using System.Windows.Forms;
using PhysiotherapyCare.Model.VisitPatientCare;
using System;
using PhysiotherapyCare.View.MainForms.VisitPatientCare;

namespace PhysiotherapyCare.View.MainForms.VisitPatientCare
{
    public partial class VisitPatientCare_UC : UserControl
    {
        int _patientId = 0;
        public VisitPatientCare_UC()
        {
            InitializeComponent();
        }

        public VisitPatientCare_UC(int PatientId)
        {
            InitializeComponent();
            _patientId = PatientId;
        }

        public void BindData(int RowNumberSet)
        {
            string str = "";

            List<VW_VisitPatientCare> LSQ = new List<VW_VisitPatientCare>();

            if (_patientId == 0)
                LSQ = new ViewModel.VisitPatientCare.VisitPatientCare().GetAllList(ref str);
            else
                LSQ = new ViewModel.VisitPatientCare.VisitPatientCare().GetAllList(ref str).Where(pp => pp.Patient_Id == _patientId).ToList();


            //if (_patientId == 0)
            //{
            //    if (GridViewVisitPatientCare.FilterList.Count() == 0)
            //        LSQ = new ViewModel.VisitPatientCare.VisitPatientCare().GetAllList(ref str);
            //    else
            //        LSQ = new ViewModel.VisitPatientCare.VisitPatientCare().GetAllListByFilter(GridViewVisitPatientCare.FilterList, ref str);
            //}
            //else
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
            //    LSQ = new ViewModel.VisitPatientCare.VisitPatientCare().GetAllListByFilter(filter, ref str);
            //}

            if (RadioBoxOnlineContract.Checked)
                LSQ = LSQ.Where(ei => KagNetComponents2.KagPersianDate.Parse(ei.EndDate).MiladiDate >= KagNetComponents2.KagPersianDate.Now.MiladiDate).ToList();
            if (RadioBoxVisitStatus1.Checked)
                LSQ = LSQ.Where(ei => ei.VisitStatus_Id == 1).ToList();
            if (RadioBoxVisitStatus2.Checked)
                LSQ = LSQ.Where(ei => ei.VisitStatus_Id == 2).ToList();
            if (RadioBoxContractWithTime.Checked)
            {
                if (ComboBoxSerach.SelectedIndex == 0)
                    LSQ = LSQ.Where(d => MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.LetterDate ?? "") >= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerStart.Value.ToString())
                        && MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.LetterDate ?? "") <= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerEnd.Value.ToString())).ToList();
                else if (ComboBoxSerach.SelectedIndex == 1)
                    LSQ = LSQ.Where(d => MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.ContractDate ?? "") >= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerStart.Value.ToString())
                        && MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.ContractDate ?? "") <= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerEnd.Value.ToString())).ToList();
                else if (ComboBoxSerach.SelectedIndex == 2)
                    LSQ = LSQ.Where(d => MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.BeginDate ?? "") >= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerStart.Value.ToString())
                        && MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.BeginDate ?? "") <= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerEnd.Value.ToString())).ToList();
                else if (ComboBoxSerach.SelectedIndex == 3)
                    LSQ = LSQ.Where(d => MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.EndDate ?? "") >= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerStart.Value.ToString())
                        && MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.EndDate ?? "") <= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerEnd.Value.ToString())).ToList();
            }
            
            GridViewVisitPatientCare.DataSource = LSQ;
            
            try { GridViewVisitPatientCare.Row = RowNumberSet; }
            catch { }
        }

        
        #region All UI Button

        private void headerGridVisitPatientCare_btnInsertClick(object sender, System.EventArgs e)
        {

            VisitPatientCareAdd_Frm VisitPatientCareAdd = null;
            if (_patientId != 0)
                VisitPatientCareAdd = new VisitPatientCareAdd_Frm(_patientId, "");
            else
                VisitPatientCareAdd = new VisitPatientCareAdd_Frm();

            if (VisitPatientCareAdd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                BindData(GridViewVisitPatientCare.RowCount);
        }
        private void headerGridVisitPatientCare_btnEditClick(object sender, System.EventArgs e)
        {
            try
            {

                //if (!(HeaderGridVisitPatientCare as MKH.Library.Control.MSSHeaderGrid).Items["buttonItemEdit"].Visible || !(HeaderGridVisitPatientCare as MKH.Library.Control.MSSHeaderGrid).Items["buttonItemEdit"].Enabled) return;

                if (short.Parse(GridViewVisitPatientCare.CurrentRow.Cells["VisitStatus_Id"].Value.ToString()) == 2)
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View("امکان ویرایش به دلیل ارسال به بیمه وجود ندارد", MKH.Library.Clasess.MSSMessage.MessageType.SWarning);
                   // return;
                }

                VisitPatientCareAdd_Frm VisitPatientCareAdd = new VisitPatientCareAdd_Frm(
                    int.Parse(GridViewVisitPatientCare.CurrentRow.Cells["Id"].Value.ToString()),
                    short.Parse(GridViewVisitPatientCare.CurrentRow.Cells["VisitStatus_Id"].Value.ToString()));
                if (VisitPatientCareAdd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    BindData(GridViewVisitPatientCare.Row);
            }
            catch { }
        }

        private void headerGridVisitPatientCare_btnDeleteClick(object sender, System.EventArgs e)
        {
            if (short.Parse(GridViewVisitPatientCare.CurrentRow.Cells["VisitStatus_Id"].Value.ToString()) == 2)
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("امکان حذف به دلیل ارسال به بیمه وجود ندارد", MKH.Library.Clasess.MSSMessage.MessageType.SWarning);
                return;
            }
            string str = "";

            if (new ViewModel.Basic.NODuplicateForm().CheckNODuplicateForm("TBL_VisitPatientCare", GridViewVisitPatientCare.CurrentRow.Cells["Id"].Value.ToString(), ref str))
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("امکان حذف به علت انجام عملیات توسط کاربر دیگر امکان پذیر نمی باشد", MKH.Library.Clasess.MSSMessage.MessageType.SWarning);
                return;
            }
            
            if (MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation, true, "آیا به حذف این مورد اطمینان دارید؟"))
            {
                try
                {
                    //int i = GridViewVisitPatientCare.Row; 
                    //List<TBL_VisitPatientCare> Ls = new List<TBL_VisitPatientCare>();
                    //TBL_VisitPatientCare VisitPatientCare = new TBL_VisitPatientCare();
                    //VisitPatientCare.Id = int.Parse(GridViewVisitPatientCare.CurrentRow.Cells["Id"].Value.ToString());
                    
                    //VisitPatientCare.Patient_Id = int.Parse(GridViewVisitPatientCare.CurrentRow.Cells["Patient_Id"].Value.ToString());
                    //VisitPatientCare.Bank_Id = short.Parse(GridViewVisitPatientCare.CurrentRow.Cells["Bank_Id"].Value.ToString());
                    //VisitPatientCare.KinShip_Id = short.Parse(GridViewVisitPatientCare.CurrentRow.Cells["KinShip_Id"].Value.ToString());
                    //VisitPatientCare.VisitStatus_Id = short.Parse(GridViewVisitPatientCare.CurrentRow.Cells["VisitStatus_Id"].Value.ToString());
                    
                    //Ls.Add(VisitPatientCare);


                    ViewModel.VisitPatientCare.VisitPatientCare RN = new ViewModel.VisitPatientCare.VisitPatientCare();
                    List<TBL_VisitPatientCare> VWP = RN.GetAllListByTblID(int.Parse(GridViewVisitPatientCare.CurrentRow.Cells["Id"].Value.ToString()), ref str);
                    
                    new ViewModel.VisitPatientCare.VisitPatientCare().DeleteEntity(VWP, ref str);
                    if (str != "") MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "امکان حذف مورد انتخابی به علت داشتن عملکرد در نرم افزار وجود ندارد", str);
                    else
                        BindData(GridViewVisitPatientCare.Row - 1);
                }
                catch (Exception ex)
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View(0,MKH.Library.Clasess.MSSMessage.MessageType.SError,false,"اشکال",ex.Message);
                }
            }
        }

        private void headerGridVisitPatientCare_btnRefreshClick(object sender, System.EventArgs e)
        {
            BindData(GridViewVisitPatientCare.Row);
        }

        #endregion

        private void VisitPatientCare_UC_Load(object sender, System.EventArgs e)
        {
            buttonItemFiling.Enabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(73);
            ToolStripMenuItemStatusCare.Enabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(74);
            buttonItemSendCarePayment.Enabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(128);
            ButtonReciveFileDate.Enabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(199);
            buttonItemSendSMS.Enabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(207);

            ToolStripMenuItemVisitPatientCareCurrentRow.Enabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(270);
            ToolStripMenuItemVisitPatientCareAllList.Enabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(271);

            new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionControl(this);

            try
            {
                DatePickerStart.Value = DatePickerEnd.Value = KagNetComponents2.KagPersianDate.Now;
            }
            catch { }
            //BindData(0);
        }

        
        private void buttonItemFiling_Click(object sender, EventArgs e)
        {
            try
            {
                string str = "";
                MKH.Library.Forms.MSSImageSelectorFiling_frm img = new MKH.Library.Forms.MSSImageSelectorFiling_frm(
                    System.Convert.ToInt32(GridViewVisitPatientCare.CurrentRow.Cells["Id"].Value),
                    new ViewModel.Setting.Setting().GetAllValue("FileSavingCare", ref str)
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
                    //BindData(GridViewVisitPatientCare.Row);
                }
            }
            catch { }

        }

        private void GridViewVisitPatientCare_BindingDataSourceSet(object sender, EventArgs e)
        {
            BindData(GridViewVisitPatientCare.Row);
        }

        private void ComboBoxSerach_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindData(GridViewVisitPatientCare.Row);
        }

        private void DatePickerStart_ValueChanged(object sender, KagNetComponents2.PersianMonthCalendarEventArgs e)
        {
            BindData(GridViewVisitPatientCare.Row);
        }

        private void buttonItemSendCarePayment_Click(object sender, EventArgs e)
        {
            SendCarePayment_Frm fd = new SendCarePayment_Frm(System.Convert.ToInt32(GridViewVisitPatientCare.CurrentRow.Cells["Id"].Value));
            fd.ShowDialog();
            BindData(GridViewVisitPatientCare.Row);
        }

        private void RadioBoxOnlineContract_CheckedChanged(object sender, EventArgs e)
        {
            BindData(GridViewVisitPatientCare.Row);
        }

        private void ToolStripMenuItemStatus_Click(object sender, EventArgs e)
        {
            PhysiotherapyCare.View.MainForms.AllStatus.AllStatusAdd_Frm asf = new
                PhysiotherapyCare.View.MainForms.AllStatus.AllStatusAdd_Frm(System.Convert.ToInt64(GridViewVisitPatientCare.CurrentRow.Cells["Id"].Value));
            asf._systemTypeSet = PhysiotherapyCare.View.MainForms.AllStatus.AllStatusAdd_Frm.SystemType.Care;
            asf.ShowDialog();
        }

       

        private void buttonItemSendSMS_Click(object sender, EventArgs e)
        {
            List<MKH.Library.Clasess.PublicClass.AllPersonForSMS> ListForSelectPerson = new List<MKH.Library.Clasess.PublicClass.AllPersonForSMS>();
            for (int i = 0; i < GridViewVisitPatientCare.SelectedItems.Count; i++)
            {
                if (((GridViewVisitPatientCare.SelectedItems[i].GetRow().Cells["CarrierMobile"].Value ?? "").ToString().StartsWith("09") && (GridViewVisitPatientCare.SelectedItems[i].GetRow().Cells["CarrierMobile"].Value ?? "").ToString().Length == 11))
                {
                    try
                    {
                        MKH.Library.Clasess.PublicClass.AllPersonForSMS ssss = new MKH.Library.Clasess.PublicClass.AllPersonForSMS();
                        ssss.PersonNameFamily = (GridViewVisitPatientCare.SelectedItems[i].GetRow().Cells["CarrierName"].Value ?? "").ToString() + " " +
                                                (GridViewVisitPatientCare.SelectedItems[i].GetRow().Cells["CarrierFamily"].Value ?? "").ToString();
                        ssss.JobType = "مرافب";
                        ssss.MobileNo1 = (GridViewVisitPatientCare.SelectedItems[i].GetRow().Cells["CarrierMobile"].Value ?? "").ToString();
                        ssss.MobileNo2 = (GridViewVisitPatientCare.SelectedItems[i].GetRow().Cells["CarrierTelHome"].Value ?? "").ToString();

                        ListForSelectPerson.Add(ssss);
                    }
                    catch { }
                }
            }
            ViewModel.PublicClass.FillForSMS();

            MKH.SMS.View.Forms.SendSMSAdd_Frm SSA = new MKH.SMS.View.Forms.SendSMSAdd_Frm(ListForSelectPerson, "");
            SSA.ShowDialog();
        }

        private void ButtonReciveFileDate_Click(object sender, EventArgs e)
        {
            string str = "";
            long IDSet = 0;

            for (int i = 0; i < GridViewVisitPatientCare.SelectedItems.Count; i++)
                if (new ViewModel.Basic.NODuplicateForm().CheckNODuplicateForm("TBL_VisitPatientCare", GridViewVisitPatientCare.SelectedItems[i].GetRow().Cells["Id"].Value.ToString(), ref str))
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View("امکان تغییرات به علت انجام عملیات توسط کاربر دیگر امکان پذیر نمی باشد. لطفا کمی بعد سعی کنید", MKH.Library.Clasess.MSSMessage.MessageType.SWarning);
                    return;
                }

            if (MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation, true, "تاریخ دریافت فایل جهت ردیف های انتخابی مشخص شود؟"))
            {
                try
                {
                    for (int i = 0; i < GridViewVisitPatientCare.SelectedItems.Count; i++)
                    {

                        IDSet = long.Parse(GridViewVisitPatientCare.SelectedItems[i].GetRow().Cells["Id"].Value.ToString());

                        new ViewModel.VisitPatientCare.VisitPatientCare().UpdateEntityWithFieldValue(
                        IDSet, "ReciveFileDate", DatePickerReciveFileDate.Value.ToString().Substring(0, 10),
                        MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                        MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(System.DateTime.Now), ref str);
                    }
                    BindData(GridViewVisitPatientCare.Row);
                }
                catch (System.Exception ex)
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View(ex.Message, MKH.Library.Clasess.MSSMessage.MessageType.SError);
                }
            }
        }

        private void ToolStripMenuItemVisitPatientCareCurrentRow_Click(object sender, EventArgs e)
        {
            try
            {
                string Str = "";
                int J = 0;

                MKH.Library.Forms.MSSLogViewer_frm ctrl = new MKH.Library.Forms.MSSLogViewer_frm();
                ctrl.GridexViewSelector.DataSource = new MKH.Permission.ViewModel.Log.Log().GetAllListVisitPatientCareByID(System.Convert.ToInt64(GridViewVisitPatientCare.CurrentRow.Cells["Id"].Value), ref Str).ToList();
                ctrl.ColumnList = new System.Data.DataTable();
                for (int i = 0; i < GridViewVisitPatientCare.RootTable.Columns.Count; i++)
                    if (GridViewVisitPatientCare.RootTable.Columns[i].Tag == "" || GridViewVisitPatientCare.RootTable.Columns[i].Tag == null)
                    {
                        ctrl.ColumnList.Columns.Add(GridViewVisitPatientCare.RootTable.Columns[i].Key);
                        ctrl.ColumnList.Columns[J].Caption = GridViewVisitPatientCare.RootTable.Columns[i].Caption;
                        J++;
                    }
                ctrl.ShowDialog();
            }
            catch { }
        }

        private void ToolStripMenuItemVisitPatientCareAllList_Click(object sender, EventArgs e)
        {
            try
            {
                string Str = "";
                int J = 0;

                MKH.Library.Forms.MSSLogViewer_frm ctrl = new MKH.Library.Forms.MSSLogViewer_frm();
                ctrl.GridexViewSelector.DataSource = new MKH.Permission.ViewModel.Log.Log().GetAllListVisitPatientCare(ref Str).ToList();
                ctrl.ColumnList = new System.Data.DataTable();
                for (int i = 0; i < GridViewVisitPatientCare.RootTable.Columns.Count; i++)
                    if (GridViewVisitPatientCare.RootTable.Columns[i].Visible)
                    {
                        ctrl.ColumnList.Columns.Add(GridViewVisitPatientCare.RootTable.Columns[i].Key);
                        ctrl.ColumnList.Columns[J].Caption = GridViewVisitPatientCare.RootTable.Columns[i].Caption;
                        J++;
                    }
                ctrl.ShowDialog();
            }
            catch { }
        }





       
    }
}
