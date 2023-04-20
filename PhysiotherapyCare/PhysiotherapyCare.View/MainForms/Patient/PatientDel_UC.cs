using System.Linq;
using System.Collections.Generic;
using PhysiotherapyCare.Model.Basic;
using PhysiotherapyCare.Model;
using MKH.Library.Clasess.FilterClass;
using System.Windows.Forms;
using PhysiotherapyCare.Model.Patient;

namespace PhysiotherapyCare.View.MainForms.Patient
{
    public partial class PatientDel_UC : UserControl
    {
        public PatientDel_UC()
        {
            InitializeComponent();
        }

        public void BindData(int RowNumberSet)
        {
            string str = "";

            List<QueryFilter.ExpressionBuilder.Filter> filter = new List<QueryFilter.ExpressionBuilder.Filter>();
            filter.Add(
            new QueryFilter.ExpressionBuilder.Filter
            {
                PropertyName = "Active",
                Operation = QueryFilter.ExpressionBuilder.Op.Equals,
                Value = false,
                OperationFilter = QueryFilter.ExpressionBuilder.OpFilter.And
            }
            );
            GridViewPatientDel.DataSource = new ViewModel.Patient.Patient().GetAllListByFilter(filter, ref str);

            try { GridViewPatientDel.Row = RowNumberSet; }
            catch { }
        }

        
        #region All UI Button

        private void headerGridPatient_btnDeleteClick(object sender, System.EventArgs e)
        {
            if (MKH.Library.Clasess.MSSMessage.MSSMessage_View(0,MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation,true, "آیا به حذف این بیمار از سیستم اطمینان دارید؟"))
            {
                try
                {
                    //List<TBL_Patient> Ls = new List<TBL_Patient>();
                    //TBL_Patient Patient = new TBL_Patient();

                    string str = "";

                    ViewModel.Patient.Patient RN = new ViewModel.Patient.Patient();
                    List<TBL_Patient> VWP = RN.GetAllListByTblID(int.Parse(GridViewPatientDel.CurrentRow.Cells["Id"].Value.ToString()), ref str);

                    //Patient = VWP[0];
                    //Patient.Id = VWP[0].Id;
                    //Patient.PatientName = GridViewPatientDel.CurrentRow.Cells["PatientName"].Value.ToString();
                    //Patient.PatientFamily = GridViewPatientDel.CurrentRow.Cells["PatientFamily"].Value.ToString();
                    //Patient.NationalCode = GridViewPatientDel.CurrentRow.Cells["NationalCode"].Value.ToString();
                    //Patient.LastDoctorVisit_Id = int.Parse((GridViewPatientDel.CurrentRow.Cells["LastDoctorVisit_Id"].Value ?? "0").ToString());
                    //Patient.LastVisitDate = (GridViewPatientDel.CurrentRow.Cells["LastVisitDate"].Value??"").ToString();
                    //Patient.LastDoctorPhysiotherapy_Id = int.Parse((GridViewPatientDel.CurrentRow.Cells["LastDoctorPhysiotherapy_Id"].Value ?? "0").ToString());
                    //Patient.LastPhysiotherapyDate = (GridViewPatientDel.CurrentRow.Cells["LastPhysiotherapyDate"].Value??"").ToString();
                    //Patient.LastDoctorHealthCare_Id = int.Parse((GridViewPatientDel.CurrentRow.Cells["LastDoctorHealthCare_Id"].Value ?? "0").ToString());
                    //Patient.LastHealthCareDate = (GridViewPatientDel.CurrentRow.Cells["LastHealthCareDate"].Value??"").ToString();
                    //Patient.LastVisitPatientCare_Id = int.Parse((GridViewPatientDel.CurrentRow.Cells["LastVisitPatientCare_Id"].Value ?? "0").ToString());
                    //Patient.LastCareDate = (GridViewPatientDel.CurrentRow.Cells["LastCareDate"].Value??"").ToString();
                    //Patient.Bank_Id = short.Parse((GridViewPatientDel.CurrentRow.Cells["Bank_Id"].Value ?? 0).ToString());
                    //Patient.Sex = byte.Parse((GridViewPatientDel.CurrentRow.Cells["Sex"].Value ?? 0).ToString());
                    //Patient.BonyadAddEven = byte.Parse((GridViewPatientDel.CurrentRow.Cells["BonyadAddEven"].Value ?? 0).ToString());


                    //Patient.DosiersNo = GridViewPatientDel.CurrentRow.Cells["DosiersNo"].Value.ToString();
                    //Patient.ParentName = GridViewPatientDel.CurrentRow.Cells["ParentName"].Value.ToString();
                    //Patient.IDNO = GridViewPatientDel.CurrentRow.Cells["IDNO"].Value.ToString();
                    //Patient.PatientTypeStr = GridViewPatientDel.CurrentRow.Cells["PatientTypeStr"].Value.ToString();
                    //Patient.InjuryTypeStr = GridViewPatientDel.CurrentRow.Cells["InjuryTypeStr"].Value.ToString();
                    //Patient.BrithDate = GridViewPatientDel.CurrentRow.Cells["BrithDate"].Value.ToString();
                    //Patient.BrithCityName = GridViewPatientDel.CurrentRow.Cells["BrithCityName"].Value.ToString();
                    //Patient.PercentState = short.Parse(GridViewPatientDel.CurrentRow.Cells["PercentState"].Value.ToString());
                    
                    //Patient.SingleOrNo = GridViewPatientDel.CurrentRow.Cells["SingleOrNo"].Value.ToString();
                    //Patient.CityPart = GridViewPatientDel.CurrentRow.Cells["CityPart"].Value.ToString();
                    //Patient.BrithCityName = GridViewPatientDel.CurrentRow.Cells["BrithCityName"].Value.ToString();
                    //Patient.BrithCityName = GridViewPatientDel.CurrentRow.Cells["BrithCityName"].Value.ToString();
                    //Patient.BrithCityName = GridViewPatientDel.CurrentRow.Cells["BrithCityName"].Value.ToString();






                    //Ls.Add(Patient);


                    new ViewModel.Patient.Patient().DeleteEntity(VWP, ref str);
                    if (str != "") MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "امکان حذف بیمار مورد نظر به علت داشتن عملکرد در نرم افزار وجود ندارد", str);
                    else
                        BindData(GridViewPatientDel.Row - 1);
                }
                catch (System.Exception ex)
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "اشکال", ex.Message);
                }
            }
        }

        private void headerGridPatient_btnRefreshClick(object sender, System.EventArgs e)
        {
            BindData(GridViewPatientDel.Row);
        }

        #endregion

        private void PatientDel_UC_Load(object sender, System.EventArgs e)
        {
            new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionControl(this);
            buttonItemBackToPatient.Enabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(46);
            buttonItemSendSMS.Enabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(205);
            ToolStripMenuItemPatientDelCurrentRow.Enabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(285);
            ToolStripMenuItemPatientDelAllList.Enabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(286);

            BindData(0);
        }

        private void buttonItemBackToPatient_Click(object sender, System.EventArgs e)
        {
            if (MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation, true, "آیا مایلید این بیمار به لیست اصلی بیماران منتقل شود؟"))
            {
                try
                {
                    string str = "";
                    new ViewModel.Patient.Patient().UpdatePatientDel(int.Parse(GridViewPatientDel.CurrentRow.Cells["Id"].Value.ToString()), true, "", ref str);
                    BindData(GridViewPatientDel.Row - 1);
                }
                catch (System.Exception ex)
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "اشکال", ex.Message);
                }
            }
        }

        //private void HeaderGridPatientDel_buttonItemPrintClick(object sender, System.EventArgs e)
        //{
        //    MKH.Library.Forms.MSSReportDesignList_frm ctrl = new MKH.Library.Forms.MSSReportDesignList_frm(this.Name);
        //    System.Data.DataTable DataRel = new System.Data.DataTable();
        //    try
        //    {
        //        foreach (Janus.Windows.GridEX.GridEXColumn item in GridViewPatientDel.RootTable.Columns)
        //            if (item.Tag == "" || item.Tag == null)
        //                DataRel.Columns.Add(item.Caption);

        //        for (int i = 0; i < GridViewPatientDel.RowCount; i++)
        //        {
        //            System.Data.DataRow dr = DataRel.NewRow();
        //            GridViewPatientDel.Row = i;
        //            foreach (Janus.Windows.GridEX.GridEXColumn item in GridViewPatientDel.RootTable.Columns)
        //                if (item.Tag == "" || item.Tag == null)
        //                    dr[item.Caption] = (GridViewPatientDel.CurrentRow.Cells[item.Key].Value ?? "").ToString();

        //            DataRel.Rows.Add(dr);
        //        }


        //        ctrl.DataRelationNew = DataRel;//((System.Collections.IList)DataRel).OfType<object>().ToList();
        //        ctrl.NameForDB = this.Tag.ToString();
        //        ctrl.ShowDialog();
        //    }
        //    catch { }
        //}

        private void buttonItemSendSMS_Click(object sender, System.EventArgs e)
        {
            List<MKH.Library.Clasess.PublicClass.AllPersonForSMS> ListForSelectPerson = new List<MKH.Library.Clasess.PublicClass.AllPersonForSMS>();
            for (int i = 0; i < GridViewPatientDel.SelectedItems.Count; i++)
            {
                if (((GridViewPatientDel.SelectedItems[i].GetRow().Cells["Mobile"].Value ?? "").ToString().StartsWith("09") && (GridViewPatientDel.SelectedItems[i].GetRow().Cells["Mobile"].Value ?? "").ToString().Length == 11) ||
                   ((GridViewPatientDel.SelectedItems[i].GetRow().Cells["Mobile2"].Value ?? "").ToString().StartsWith("09") && (GridViewPatientDel.SelectedItems[i].GetRow().Cells["Mobile2"].Value ?? "").ToString().Length == 11))
                {
                    try
                    {
                        MKH.Library.Clasess.PublicClass.AllPersonForSMS ssss = new MKH.Library.Clasess.PublicClass.AllPersonForSMS();
                        ssss.PersonNameFamily = (GridViewPatientDel.SelectedItems[i].GetRow().Cells["PatientName"].Value ?? "").ToString() + " " +
                                                (GridViewPatientDel.SelectedItems[i].GetRow().Cells["PatientFamily"].Value ?? "").ToString();
                        ssss.JobType = "بیمار";
                        ssss.MobileNo1 = (GridViewPatientDel.SelectedItems[i].GetRow().Cells["Mobile"].Value ?? "").ToString() == "" ? (GridViewPatientDel.SelectedItems[i].GetRow().Cells["Mobile2"].Value ?? "").ToString() : (GridViewPatientDel.SelectedItems[i].GetRow().Cells["Mobile"].Value ?? "").ToString();
                        ssss.MobileNo2 = (GridViewPatientDel.SelectedItems[i].GetRow().Cells["Mobile2"].Value ?? "").ToString();
                        ListForSelectPerson.Add(ssss);
                    }
                    catch { }
                }
            }
            ViewModel.PublicClass.FillForSMS();

            MKH.SMS.View.Forms.SendSMSAdd_Frm SSA = new MKH.SMS.View.Forms.SendSMSAdd_Frm(ListForSelectPerson);
            SSA.ShowDialog();

        }

        private void ToolStripMenuItemPatientDelAllList_Click(object sender, System.EventArgs e)
        {
            try
            {
                string Str = "";
                int J = 0;

                MKH.Library.Forms.MSSLogViewer_frm ctrl = new MKH.Library.Forms.MSSLogViewer_frm();
                ctrl.GridexViewSelector.DataSource = new MKH.Permission.ViewModel.Log.Log().GetAllListPatient(ref Str).ToList();
                ctrl.ColumnList = new System.Data.DataTable();
                for (int i = 0; i < GridViewPatientDel.RootTable.Columns.Count; i++)
                    if (GridViewPatientDel.RootTable.Columns[i].Visible)
                    {
                        ctrl.ColumnList.Columns.Add(GridViewPatientDel.RootTable.Columns[i].Key);
                        ctrl.ColumnList.Columns[J].Caption = GridViewPatientDel.RootTable.Columns[i].Caption;
                        J++;
                    }
                ctrl.ShowDialog();
            }
            catch { }
        }

        private void ToolStripMenuItemPatientDelCurrentRow_Click(object sender, System.EventArgs e)
        {
            try
            {
                string Str = "";
                int J = 0;

                MKH.Library.Forms.MSSLogViewer_frm ctrl = new MKH.Library.Forms.MSSLogViewer_frm();
                ctrl.GridexViewSelector.DataSource = new MKH.Permission.ViewModel.Log.Log().GetAllListPatientByID(System.Convert.ToInt32(GridViewPatientDel.CurrentRow.Cells["Id"].Value), ref Str).ToList();
                ctrl.ColumnList = new System.Data.DataTable();
                for (int i = 0; i < GridViewPatientDel.RootTable.Columns.Count; i++)
                    if (GridViewPatientDel.RootTable.Columns[i].Tag == "" || GridViewPatientDel.RootTable.Columns[i].Tag == null)
                    {
                        ctrl.ColumnList.Columns.Add(GridViewPatientDel.RootTable.Columns[i].Key);
                        ctrl.ColumnList.Columns[J].Caption = GridViewPatientDel.RootTable.Columns[i].Caption;
                        J++;
                    }
                ctrl.ShowDialog();
            }
            catch { }
        }

        private void GridViewPatientDel_KeyDown(object sender, KeyEventArgs e)
        {
            string str = "";
            if (e.Alt && e.Control && e.KeyCode == Keys.F)
                new ViewModel.Patient.Patient().PatientReIndexForAllAction(ref str);
        }

       
    }
}
