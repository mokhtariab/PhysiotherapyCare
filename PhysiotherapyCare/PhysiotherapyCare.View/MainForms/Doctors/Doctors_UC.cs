using System.Linq;
using System.Collections.Generic;
using PhysiotherapyCare.Model.Basic;
using PhysiotherapyCare.Model;
using MKH.Library.Clasess.FilterClass;
using System.Windows.Forms;
using PhysiotherapyCare.Model.Doctors;

namespace PhysiotherapyCare.View.MainForms.Doctors
{
    public partial class Doctors_UC : UserControl
    {
        public Doctors_UC()
        {
            InitializeComponent();
        }

        public void BindData(int RowNumberSet)
        {
            string str = "";

            GridViewDoctors.DataSource = new ViewModel.Doctors.Doctor().GetAllList(ref str);

            try { GridViewDoctors.Row = RowNumberSet; }
            catch { }
        }

        
        #region All UI Button

        private void headerGridDoctors_btnInsertClick(object sender, System.EventArgs e)
        {

            DoctorsAdd_Frm DoctorsAdd = new DoctorsAdd_Frm();

            if (DoctorsAdd.ShowDialog() == DialogResult.OK)
                BindData(GridViewDoctors.RowCount);
        }

        private void headerGridDoctors_btnEditClick(object sender, System.EventArgs e)
        {
            try
            {
               // if (!(HeaderGridDoctors as MKH.Library.Control.MSSHeaderGrid).Items["buttonItemEdit"].Visible || !(HeaderGridDoctors as MKH.Library.Control.MSSHeaderGrid).Items["buttonItemEdit"].Enabled) return;

                DoctorsAdd_Frm DoctorsAdd = new DoctorsAdd_Frm(
                    int.Parse(GridViewDoctors.CurrentRow.Cells["Id"].Value.ToString()));
                if (DoctorsAdd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    BindData(GridViewDoctors.Row);
            }
            catch { }
        }

        private void headerGridDoctors_btnDeleteClick(object sender, System.EventArgs e)
        {
            string str = "";
            if (new ViewModel.Basic.NODuplicateForm().CheckNODuplicateForm("TBL_Doctors", GridViewDoctors.CurrentRow.Cells["Id"].Value.ToString(), ref str))
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("امکان حذف به علت انجام عملیات توسط کاربر دیگر امکان پذیر نمی باشد", MKH.Library.Clasess.MSSMessage.MessageType.SWarning);
            else
                if (MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation, true, "آیا به حذف این مورد اطمینان دارید؟"))
                {
                    try
                    {
                        //List<TBL_Doctor> Ls = new List<TBL_Doctor>();
                        //TBL_Doctor Doctors = new TBL_Doctor();
                        //Doctors.DoctorParent_Id = int.Parse(GridViewDoctors.CurrentRow.Cells["DoctorParent_Id"].Value.ToString());
                        //Doctors.DoctorName = GridViewDoctors.CurrentRow.Cells["DoctorName"].Value.ToString();
                        //Doctors.DoctorFamily = GridViewDoctors.CurrentRow.Cells["Id"].Value.ToString();
                        //Doctors.DoctorType_Id = short.Parse(GridViewDoctors.CurrentRow.Cells["DoctorType_Id"].Value.ToString());
                        //Doctors.Bank_Id = short.Parse(GridViewDoctors.CurrentRow.Cells["Bank_Id"].Value.ToString());
                        //Ls.Add(Doctors);

                        ViewModel.Doctors.Doctor RN = new ViewModel.Doctors.Doctor();
                        List<TBL_Doctor> VWP = RN.GetAllListByTblID(int.Parse(GridViewDoctors.CurrentRow.Cells["Id"].Value.ToString()), ref str);

                        new ViewModel.Doctors.Doctor().DeleteEntity(VWP, ref str);
                        if (str != "") MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "امکان حذف پزشک مورد نظر به علت داشتن عملکرد در نرم افزار وجود ندارد", str);
                        else
                            BindData(GridViewDoctors.Row - 1);
                    }
                    catch (System.Exception ex)
                    {
                        MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "اشکال", ex.Message);
                    }
                }
        }

        private void headerGridDoctors_btnRefreshClick(object sender, System.EventArgs e)
        {
            BindData(GridViewDoctors.Row);
        }

        #endregion

        private void Doctors_UC_Load(object sender, System.EventArgs e)
        {
            new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionControl(this);
            buttonItemFiling.Enabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(38);
            buttonItemSendSMS.Enabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(203);

            ToolStripMenuItemDoctorsCurrentRow.Enabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(287);
            ToolStripMenuItemDoctorsAllList.Enabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(288);

            BindData(0);
        }

        private void GridViewDoctors_SelectionChanged(object sender, System.EventArgs e)
        {
            try
            {
                string str = "";
                PictureBoxDoctorPic.Image = System.Drawing.Image.FromStream(new System.IO.MemoryStream(((byte[])(new ViewModel.Doctors.Doctor().GetAllListByIDPic(int.Parse(GridViewDoctors.CurrentRow.Cells["Id"].Value.ToString()), ref str).Single().DoctorPic.ToArray()))));
            }
            catch
            {
                PictureBoxDoctorPic.Image = null;
            }

        }

        private void buttonItemDoctorContract_Click(object sender, System.EventArgs e)
        {
            string str = "";
            if (new ViewModel.Basic.NODuplicateForm().CheckNODuplicateForm("TBL_Doctors", GridViewDoctors.CurrentRow.Cells["Id"].Value.ToString(), ref str))
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("امکان حذف به علت انجام عملیات توسط کاربر دیگر امکان پذیر نمی باشد", MKH.Library.Clasess.MSSMessage.MessageType.SWarning);
            else
            {
                DoctorsContract_Frm dc = new DoctorsContract_Frm(int.Parse(GridViewDoctors.CurrentRow.Cells["Id"].Value.ToString()));
                if (dc.ShowDialog() == DialogResult.OK)
                    BindData(GridViewDoctors.Row);
            }
        }

        private void buttonItemSendSMS_Click(object sender, System.EventArgs e)
        {
            List<MKH.Library.Clasess.PublicClass.AllPersonForSMS> ListForSelectPerson = new List<MKH.Library.Clasess.PublicClass.AllPersonForSMS>();
            for (int i = 0; i < GridViewDoctors.SelectedItems.Count; i++)
            {
                try
                {
                    if (((GridViewDoctors.SelectedItems[i].GetRow().Cells["Mobile"].Value ?? "").ToString().StartsWith("09") && (GridViewDoctors.SelectedItems[i].GetRow().Cells["Mobile"].Value ?? "").ToString().Length == 11))
                    {
                        MKH.Library.Clasess.PublicClass.AllPersonForSMS ssss = new MKH.Library.Clasess.PublicClass.AllPersonForSMS();
                        ssss.PersonNameFamily = (GridViewDoctors.SelectedItems[i].GetRow().Cells["DoctorName"].Value ?? "").ToString() + " " +
                                                (GridViewDoctors.SelectedItems[i].GetRow().Cells["DoctorFamily"].Value ?? "").ToString();
                        ssss.JobType = "پزشک";
                        ssss.MobileNo1 = (GridViewDoctors.SelectedItems[i].GetRow().Cells["Mobile"].Value ?? "").ToString();
                        ssss.MobileNo2 = (GridViewDoctors.SelectedItems[i].GetRow().Cells["TelHome"].Value ?? "").ToString() + " " + (GridViewDoctors.SelectedItems[i].GetRow().Cells["TelBusiness"].Value ?? "").ToString();

                        ListForSelectPerson.Add(ssss);
                    }
                }
                catch
                {
                    continue;
                }
            }
            ViewModel.PublicClass.FillForSMS();

            MKH.SMS.View.Forms.SendSMSAdd_Frm SSA = new MKH.SMS.View.Forms.SendSMSAdd_Frm(ListForSelectPerson);
            SSA.ShowDialog();
        }

        private void buttonItemFiling_Click(object sender, System.EventArgs e)
        {
            string str = "";
            MKH.Library.Forms.MSSImageSelectorFiling_frm img = new MKH.Library.Forms.MSSImageSelectorFiling_frm(
                System.Convert.ToInt32(GridViewDoctors.CurrentRow.Cells["Id"].Value),
                new ViewModel.Setting.Setting().GetAllValue("FileSavingDoctor", ref str)
                );
            img.ShowDialog();
        }

        private void ToolStripMenuItemDoctorsAllList_Click(object sender, System.EventArgs e)
        {
            try
            {
                string Str = "";
                int J = 0;

                MKH.Library.Forms.MSSLogViewer_frm ctrl = new MKH.Library.Forms.MSSLogViewer_frm();
                ctrl.GridexViewSelector.DataSource = new MKH.Permission.ViewModel.Log.Log().GetAllListDoctor(ref Str).ToList();
                ctrl.ColumnList = new System.Data.DataTable();
                for (int i = 0; i < GridViewDoctors.RootTable.Columns.Count; i++)
                    if (GridViewDoctors.RootTable.Columns[i].Visible)
                    {
                        ctrl.ColumnList.Columns.Add(GridViewDoctors.RootTable.Columns[i].Key);
                        ctrl.ColumnList.Columns[J].Caption = GridViewDoctors.RootTable.Columns[i].Caption;
                        J++;
                    }
                ctrl.ShowDialog();
            }
            catch { }
        }

        private void ToolStripMenuItemDoctorsCurrentRow_Click(object sender, System.EventArgs e)
        {
            try
            {
                string Str = "";
                int J = 0;

                MKH.Library.Forms.MSSLogViewer_frm ctrl = new MKH.Library.Forms.MSSLogViewer_frm();
                ctrl.GridexViewSelector.DataSource = new MKH.Permission.ViewModel.Log.Log().GetAllListDoctorByID(System.Convert.ToInt32(GridViewDoctors.CurrentRow.Cells["Id"].Value), ref Str).ToList();
                ctrl.ColumnList = new System.Data.DataTable();
                for (int i = 0; i < GridViewDoctors.RootTable.Columns.Count; i++)
                    if (GridViewDoctors.RootTable.Columns[i].Tag == "" || GridViewDoctors.RootTable.Columns[i].Tag == null)
                    {
                        ctrl.ColumnList.Columns.Add(GridViewDoctors.RootTable.Columns[i].Key);
                        ctrl.ColumnList.Columns[J].Caption = GridViewDoctors.RootTable.Columns[i].Caption;
                        J++;
                    }
                ctrl.ShowDialog();
            }
            catch { }
        }

        //private void HeaderGridDoctors_buttonItemPrintClick(object sender, System.EventArgs e)
        //{
        //    MKH.Library.Forms.MSSReportDesignList_frm ctrl = new MKH.Library.Forms.MSSReportDesignList_frm(this.Name);
        //    System.Data.DataTable DataRel = new System.Data.DataTable();
        //    try
        //    {
        //        foreach (Janus.Windows.GridEX.GridEXColumn item in GridViewDoctors.RootTable.Columns)
        //            if (item.Tag == "" || item.Tag == null)
        //                DataRel.Columns.Add(item.Caption);

        //        for (int i = 0; i < GridViewDoctors.RowCount; i++)
        //        {
        //            System.Data.DataRow dr = DataRel.NewRow();
        //            GridViewDoctors.Row = i;
        //            foreach (Janus.Windows.GridEX.GridEXColumn item in GridViewDoctors.RootTable.Columns)
        //                if (item.Tag == "" || item.Tag == null)
        //                    dr[item.Caption] = (GridViewDoctors.CurrentRow.Cells[item.Key].Value ?? "").ToString();

        //            DataRel.Rows.Add(dr);
        //        }


        //        ctrl.DataRelationNew = DataRel;//((System.Collections.IList)DataRel).OfType<object>().ToList();
        //        ctrl.NameForDB = this.Tag.ToString();
        //        ctrl.ShowDialog();
        //    }
        //    catch { }
        //}

       
    }
}

