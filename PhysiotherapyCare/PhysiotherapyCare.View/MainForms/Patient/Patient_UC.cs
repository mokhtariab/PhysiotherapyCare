using System.Linq;
using System.Collections.Generic;
using PhysiotherapyCare.Model.Basic;
using PhysiotherapyCare.Model;
using MKH.Library.Clasess.FilterClass;
using System.Windows.Forms;
using PhysiotherapyCare.Model.Patient;
using System.Collections.ObjectModel;
using Microsoft.VisualBasic.FileIO;
using System.IO;
using System;

namespace PhysiotherapyCare.View.MainForms.Patient
{
    public partial class Patient_UC : UserControl
    {
        public Patient_UC()
        {
            InitializeComponent();
        }

        public void BindData(int RowNumberSet)
        {
            string str = "";

            List<VW_Patient> LSQ = new List<VW_Patient>();

            List<QueryFilter.ExpressionBuilder.Filter> filter = new List<QueryFilter.ExpressionBuilder.Filter>();
            filter.Add(
            new QueryFilter.ExpressionBuilder.Filter
            {
                PropertyName = "Active",
                Operation = QueryFilter.ExpressionBuilder.Op.Equals,
                Value = true,
                OperationFilter = QueryFilter.ExpressionBuilder.OpFilter.And
            }
            );
            LSQ = new ViewModel.Patient.Patient().GetAllListByFilter(filter,ref str);
            if (RadioBoxAllPatient.Checked)
                GridViewPatient.DataSource = LSQ;
            if (RadioBoxPatientCare.Checked)
                GridViewPatient.DataSource = LSQ.Where(ei => ei.LastVisitPatientCare_Id != null).ToList();
            if (RadioBoxPatientPhysioterapy.Checked)
                GridViewPatient.DataSource = LSQ.Where(ei => ei.LastDoctorPhysiotherapy_Id != null).ToList();
            if (RadioBoxPatientHealth.Checked)
                GridViewPatient.DataSource = LSQ.Where(ei => ei.LastDoctorHealthCare_Id != null).ToList();
            if (RadioBoxPatientVisit.Checked)
                GridViewPatient.DataSource = LSQ.Where(ei => ei.LastDoctorVisit_Id != null).ToList();
            if (RadioBoxNationalCodes.Checked)
            {
                List<QueryFilter.ExpressionBuilder.Filter> filter1 = new List<QueryFilter.ExpressionBuilder.Filter>();
                filter1.Add(
                new QueryFilter.ExpressionBuilder.Filter
                {
                    PropertyName = "Active",
                    Operation = QueryFilter.ExpressionBuilder.Op.Equals,
                    Value = true,
                    OperationFilter = QueryFilter.ExpressionBuilder.OpFilter.And
                }

                );
                for (int i = 0; i < TextBoxNationalCodeSearch.Lines.Count(); i++)
                    filter1.Add(
                    new QueryFilter.ExpressionBuilder.Filter
                    {
                        PropertyName = "NationalCode",
                        Operation = QueryFilter.ExpressionBuilder.Op.Equals,
                        Value = TextBoxNationalCodeSearch.Lines[i],
                        OperationFilter = QueryFilter.ExpressionBuilder.OpFilter.Or
                    }

                    );

                GridViewPatient.DataSource = new ViewModel.Patient.Patient().GetAllListByFilter(filter1, ref str);

                //List<VW_Patient> _lSQ = new ViewModel.Patient.Patient().GetAllListByFilter(filter, ref str);
                //LSQ = _lSQ.Where(ei => ei.NationalCode == TextBoxNationalCodeSearch.Lines[0]).ToList();
                //for (int i = 1; i < TextBoxNationalCodeSearch.Lines.Count(); i++)
                //    LSQ = LSQ.Union(
                //        _lSQ.Where(ei => ei.NationalCode == TextBoxNationalCodeSearch.Lines[i])).ToList();
                //GridViewPatient.DataSource = LSQ.Where(ei => ei.NationalCode.Contains(TextBoxNationalCodeSearch.Text)).ToList();
            } 
            
            if (RadioBoxDosiersNo.Checked)
            {


                List<QueryFilter.ExpressionBuilder.Filter> filter1 = new List<QueryFilter.ExpressionBuilder.Filter>();
                filter1.Add(
                new QueryFilter.ExpressionBuilder.Filter
                {
                    PropertyName = "Active",
                    Operation = QueryFilter.ExpressionBuilder.Op.Equals,
                    Value = true,
                    OperationFilter = QueryFilter.ExpressionBuilder.OpFilter.And
                }

                );
                for (int i = 0; i < TextBoxDosiersNoSearch.Lines.Count(); i++)
                    filter1.Add(
                    new QueryFilter.ExpressionBuilder.Filter
                    {
                        PropertyName = "DosiersNo",
                        Operation = QueryFilter.ExpressionBuilder.Op.Equals,
                        Value = TextBoxDosiersNoSearch.Lines[i],
                        OperationFilter = QueryFilter.ExpressionBuilder.OpFilter.Or
                    }

                    );

                GridViewPatient.DataSource = new ViewModel.Patient.Patient().GetAllListByFilter(filter1, ref str);
            }

            if (RadioBoxWithTime.Checked)
            {
                try
                {
                    if (ComboBoxSerach.SelectedIndex == 0)
                        LSQ = LSQ.Where(d => MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.LastCareDate ?? "") >= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerStart.Value.ToString())
                            && MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.LastCareDate ?? "") <= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerEnd.Value.ToString())).ToList();
                    else if (ComboBoxSerach.SelectedIndex == 1)
                        LSQ = LSQ.Where(d => MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.LastPhysiotherapyDate ?? "") >= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerStart.Value.ToString())
                            && MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.LastPhysiotherapyDate ?? "") <= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerEnd.Value.ToString())).ToList();
                    else if (ComboBoxSerach.SelectedIndex == 2)
                        LSQ = LSQ.Where(d => MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.LastHealthCareDate ?? "") >= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerStart.Value.ToString())
                            && MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.LastHealthCareDate ?? "") <= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerEnd.Value.ToString())).ToList();
                    else if (ComboBoxSerach.SelectedIndex == 3)
                        LSQ = LSQ.Where(d => MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.LastVisitDate ?? "") >= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerStart.Value.ToString())
                            && MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.LastVisitDate ?? "") <= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(DatePickerEnd.Value.ToString())).ToList();
                }
                catch { }
                GridViewPatient.DataSource = LSQ;
            }

            try { GridViewPatient.Row = RowNumberSet; }
            catch { }
        }

        
        #region All UI Button

        private void headerGridPatient_btnInsertClick(object sender, System.EventArgs e)
        {
            PatientAdd_Frm PatientAdd = new PatientAdd_Frm();
            if (PatientAdd.ShowDialog() == System.Windows.Forms.DialogResult.OK) 
                BindData(GridViewPatient.RowCount);
        }

        private void headerGridPatient_btnEditClick(object sender, System.EventArgs e)
        {
            try
            {
               // if (!(HeaderGridPatient as MKH.Library.Control.MSSHeaderGrid).Items["buttonItemEdit"].Visible || !(HeaderGridPatient as MKH.Library.Control.MSSHeaderGrid).Items["buttonItemEdit"].Enabled) return;

                PatientAdd_Frm PatientAdd = new PatientAdd_Frm(
                             int.Parse(GridViewPatient.CurrentRow.Cells["Id"].Value.ToString()));
                if (PatientAdd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    BindData(GridViewPatient.Row);
            }
            catch { }
        }

       
        private void headerGridPatient_btnRefreshClick(object sender, System.EventArgs e)
        {
            BindData(GridViewPatient.Row);
        }


        private void buttonItemDelPatientDead_Click(object sender, System.EventArgs e)
        {
            string str = "";
            if (new ViewModel.Basic.NODuplicateForm().CheckNODuplicateForm("TBL_Patient", GridViewPatient.CurrentRow.Cells["Id"].Value.ToString(), ref str))
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("امکان حذف به علت انجام عملیات توسط کاربر دیگر امکان پذیر نمی باشد", MKH.Library.Clasess.MSSMessage.MessageType.SWarning);
            else
                if (MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation, true, "آیا به حذف این بیمار اطمینان دارید؟"))
                {
                    try
                    {
                        new ViewModel.Patient.Patient().UpdatePatientDel(int.Parse(GridViewPatient.CurrentRow.Cells["Id"].Value.ToString()), false, (sender as DevComponents.DotNetBar.ButtonItem).Text, ref str);

                        BindData(GridViewPatient.Row - 1);
                    }
                    catch (System.Exception ex)
                    {
                        MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "اشکال", ex.Message);
                    }
                }
        }

        #endregion
        
        bool SetDate = false;
        private void Patient_UC_Load(object sender, System.EventArgs e)
        {
            buttonItemFiling.Enabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(32);
            buttonItemPatientCareList.Enabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(10);
            buttonItemPatientPhysiotherapy.Enabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(9);
            buttonItemVisitHealthCare.Enabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(114);
            ToolStripMenuItemStatusPatient.Enabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(123);
            buttonItemSendSMS.Enabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(204);
            buttonItemVisitPatient.Enabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(209);

            ToolStripMenuItemPatientCurrentRow.Enabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(283);
            ToolStripMenuItemPatientAllList.Enabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(284);

            ToolStripMenuItemVisitPatientInsert.Enabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(306);
            ToolStripMenuItemDoctorInsert.Enabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(307);
            
            new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionControl(this);
            try
            {
                SetDate = false;
                DatePickerStart.Value = DatePickerEnd.Value = KagNetComponents2.KagPersianDate.Parse(System.DateTime.Now);
                SetDate = true;
            }
            catch { }
            BindData(0);
        }

        private void buttonItemPatientPhysiotherapy_Click(object sender, System.EventArgs e)
        {
            
            MainForms.VisitPatientPhysiotherapy.VisitPatientPhysiotherapy_UC SPU = new MainForms.VisitPatientPhysiotherapy.VisitPatientPhysiotherapy_UC(int.Parse(GridViewPatient.CurrentRow.Cells["Id"].Value.ToString()));
            MKH.Library.Clasess.PublicParam.MainForm.TabControlMain.AddTabToTabControl(
                SPU.Name + GridViewPatient.CurrentRow.Cells["Id"].Value.ToString(),
                GridViewPatient.CurrentRow.Cells["PatientName"].Value.ToString() + " " + GridViewPatient.CurrentRow.Cells["PatientFamily"].Value.ToString() + " - فیزیوتراپی",
                SPU);
        }

        private void buttonItemPatientCareList_Click(object sender, System.EventArgs e)
        {
            MainForms.VisitPatientCare.VisitPatientCare_UC SPU = new MainForms.VisitPatientCare.VisitPatientCare_UC(int.Parse(GridViewPatient.CurrentRow.Cells["Id"].Value.ToString()));
            MKH.Library.Clasess.PublicParam.MainForm.TabControlMain.AddTabToTabControl(
                SPU.Name + GridViewPatient.CurrentRow.Cells["Id"].Value.ToString(),
                GridViewPatient.CurrentRow.Cells["PatientName"].Value.ToString() + " " + GridViewPatient.CurrentRow.Cells["PatientFamily"].Value.ToString() + " - مراقبت",
                SPU);
        }
        private void buttonItemVisitHealthCare_Click(object sender, System.EventArgs e)
        {
            MainForms.VisitHealthCare.VisitHealthCare_UC SPU = new MainForms.VisitHealthCare.VisitHealthCare_UC(int.Parse(GridViewPatient.CurrentRow.Cells["Id"].Value.ToString()));
            MKH.Library.Clasess.PublicParam.MainForm.TabControlMain.AddTabToTabControl(
                SPU.Name + GridViewPatient.CurrentRow.Cells["Id"].Value.ToString(),
                GridViewPatient.CurrentRow.Cells["PatientName"].Value.ToString() + " " + GridViewPatient.CurrentRow.Cells["PatientFamily"].Value.ToString() + " - بهیاری",
                SPU);
        }

        private void buttonItemVisitPatient_Click(object sender, EventArgs e)
        {
            MainForms.VisitPatient.VisitPatient_UC SPU = new MainForms.VisitPatient.VisitPatient_UC(int.Parse(GridViewPatient.CurrentRow.Cells["Id"].Value.ToString()));
            MKH.Library.Clasess.PublicParam.MainForm.TabControlMain.AddTabToTabControl(
                SPU.Name + GridViewPatient.CurrentRow.Cells["Id"].Value.ToString(),
                GridViewPatient.CurrentRow.Cells["PatientName"].Value.ToString() + " " + GridViewPatient.CurrentRow.Cells["PatientFamily"].Value.ToString() + " - ویزیت",
                SPU);
        }


       

        private void buttonItemFiling_Click(object sender, System.EventArgs e)
        {
            string str = "";
            MKH.Library.Forms.MSSImageSelectorFiling_frm img = new MKH.Library.Forms.MSSImageSelectorFiling_frm(
                System.Convert.ToInt32(GridViewPatient.CurrentRow.Cells["Id"].Value),
                new ViewModel.Setting.Setting().GetAllValue("FileSavingPatient", ref str)
                );
            img.ShowDialog();
        }


        private void ToolStripMenuItemStatus_Click(object sender, System.EventArgs e)
        {
            PhysiotherapyCare.View.MainForms.AllStatus.AllStatusAdd_Frm asf = new
                    PhysiotherapyCare.View.MainForms.AllStatus.AllStatusAdd_Frm(System.Convert.ToInt64(GridViewPatient.CurrentRow.Cells["Id"].Value));
            asf._systemTypeSet = PhysiotherapyCare.View.MainForms.AllStatus.AllStatusAdd_Frm.SystemType.Patient;
            asf.ShowDialog();
        }


        private void RadioBoxAllPatient_CheckedChanged(object sender, System.EventArgs e)
        {
            BindData(GridViewPatient.Row);
        }

        private void buttonItem1_Click(object sender, System.EventArgs e)
        {
            //int? id = 0; string msgRet = "", str = "";
            //string StrInsertFile = "اشکالات درج فایلها:    ", StrmsgRet = "اشکالات برگشته از دیتابیس:  ", StrFolderName = "اشکالات خواندن فولدر:   ";

            //FolderBrowserDialog ofd = new FolderBrowserDialog();

            //if (ofd.ShowDialog() == DialogResult.OK)
            //{
            //    ReadOnlyCollection<string> ROCFolder = new ReadOnlyCollection<string>(FileSystem.GetDirectories(ofd.SelectedPath));
            //    foreach (string FolderRoot in ROCFolder)
            //    {
            //        try
            //        {
            //            string NationalCode = FileSystem.GetDirectoryInfo(FolderRoot).Name.Substring(0, 10);
            //            ReadOnlyCollection<string> ROCPIC = new ReadOnlyCollection<string>(FileSystem.GetFiles(FolderRoot));
            //            foreach (string FileRoot in ROCPIC)
            //            {
            //                string FileNameExist = System.IO.Path.GetFileName(FileRoot);
            //                if (new FileInfo(FileNameExist).Extension == ".db") continue;
            //                int patientId = 0;
            //                try
            //                {
            //                    patientId = new ViewModel.Patient.Patient().GetAllList(ref str).Where(k => k.NationalCode == NationalCode).ToList().Single().Id;
            //                    FileSystem.CopyFile(FileRoot, new ViewModel.Setting.Setting().GetAllValue("FileSavingPatient", ref str) + patientId.ToString() + "\\Film\\" + FileNameExist);
            //                }
            //                catch (Exception ex)
            //                {
            //                    try
            //                    {
            //                        NationalCode = FileSystem.GetDirectoryInfo(FolderRoot).Name.Substring(FileSystem.GetDirectoryInfo(FolderRoot).Name.Length - 10, 10);
            //                        patientId = new ViewModel.Patient.Patient().GetAllList(ref str).Where(k => k.NationalCode == NationalCode).ToList().Single().Id;
            //                        FileSystem.CopyFile(FileRoot, new ViewModel.Setting.Setting().GetAllValue("FileSavingPatient", ref str) + patientId.ToString() + "\\Film\\" + FileNameExist);
            //                    }
            //                    catch
            //                    {
            //                        StrInsertFile += NationalCode + "////" + FileNameExist + "-----------------";
            //                        id++;
            //                    }
            //                }
            //            }
            //        }
            //        catch (Exception ex)
            //        {
            //            StrFolderName = "         ::: " + ex.Message;
            //            MessageBox.Show(StrFolderName);

            //        }

            //    }
            //    MessageBox.Show(id + "=======" + StrInsertFile);
            //}
        }

        private void buttonItem2_Click(object sender, EventArgs e)
        {
            //int? id = 0; string msgRet = "", str = "";
            //string StrInsertFile = "اشکالات درج فایلها:    ", StrmsgRet = "اشکالات برگشته از دیتابیس:  ", StrFolderName = "اشکالات خواندن فولدر:   ";

            //FolderBrowserDialog ofd = new FolderBrowserDialog();

            //if (ofd.ShowDialog() == DialogResult.OK)
            //{
            //    ReadOnlyCollection<string> ROCFolder = new ReadOnlyCollection<string>(FileSystem.GetDirectories(ofd.SelectedPath));
            //    foreach (string FolderRoot in ROCFolder)
            //    {
            //        try
            //        {
            //            string NationalCode = FileSystem.GetDirectoryInfo(FolderRoot).Name.Substring(0, 10);
            //            ReadOnlyCollection<string> ROCPIC = new ReadOnlyCollection<string>(FileSystem.GetDirectories(FolderRoot));
            //            foreach (string FileRoot in ROCPIC)
            //            {
            //                string FileNameExist = System.IO.Path.GetFileName(FileRoot);
            //                //if (new FileInfo(FileNameExist).Extension == ".db") continue;
            //                int patientId = 0;
            //                try
            //                {
            //                    patientId = new ViewModel.Patient.Patient().GetAllList(ref str).Where(k => k.NationalCode == NationalCode).ToList().Single().Id;
            //                    FileSystem.CopyDirectory(FileRoot, new ViewModel.Setting.Setting().GetAllValue("FileSavingPatient", ref str) + patientId.ToString() + "\\Folder\\" + FileNameExist);
            //                }
            //                catch (Exception ex)
            //                {
            //                    try
            //                    {
            //                        NationalCode = FileSystem.GetDirectoryInfo(FolderRoot).Name.Substring(FileSystem.GetDirectoryInfo(FolderRoot).Name.Length - 10, 10);
            //                        patientId = new ViewModel.Patient.Patient().GetAllList(ref str).Where(k => k.NationalCode == NationalCode).ToList().Single().Id;
            //                        FileSystem.CopyDirectory(FileRoot, new ViewModel.Setting.Setting().GetAllValue("FileSavingPatient", ref str) + patientId.ToString() + "\\Folder\\" + FileNameExist);
            //                    }
            //                    catch
            //                    {
            //                        StrInsertFile += NationalCode + "////" + FileNameExist + "-----------------";
            //                        id++;
            //                    }
            //                }
            //            }
            //        }
            //        catch (Exception ex)
            //        {
            //            StrFolderName = "         ::: " + ex.Message;
            //            MessageBox.Show(StrFolderName);

            //        }

            //    }
            //    MessageBox.Show(id + "=======" + StrInsertFile);
            //}
        }

        private void buttonItemSendSMS_Click(object sender, EventArgs e)
        {
            List<MKH.Library.Clasess.PublicClass.AllPersonForSMS> ListForSelectPerson = new List<MKH.Library.Clasess.PublicClass.AllPersonForSMS>();
            for (int i = 0; i < GridViewPatient.SelectedItems.Count; i++)
            {
                if (((GridViewPatient.SelectedItems[i].GetRow().Cells["Mobile"].Value ?? "").ToString().Replace("‍", "").Replace(" ", "").StartsWith("09") && (GridViewPatient.SelectedItems[i].GetRow().Cells["Mobile"].Value ?? "").ToString().Replace("‍", "").Replace(" ", "").Length == 11) ||
                   ((GridViewPatient.SelectedItems[i].GetRow().Cells["Mobile2"].Value ?? "").ToString().Replace("‍", "").Replace(" ", "").StartsWith("09") && (GridViewPatient.SelectedItems[i].GetRow().Cells["Mobile2"].Value ?? "").ToString().Replace("‍", "").Replace(" ", "").Length == 11))
                {
                    try
                    {
                        MKH.Library.Clasess.PublicClass.AllPersonForSMS ssss = new MKH.Library.Clasess.PublicClass.AllPersonForSMS();
                        ssss.PersonNameFamily = (GridViewPatient.SelectedItems[i].GetRow().Cells["PatientName"].Value ?? "").ToString() + " " +
                                                (GridViewPatient.SelectedItems[i].GetRow().Cells["PatientFamily"].Value ?? "").ToString();
                        ssss.JobType = "بیمار";
                        ssss.MobileNo1 = (GridViewPatient.SelectedItems[i].GetRow().Cells["Mobile"].Value ?? "").ToString().Replace("‍", "").Replace(" ", "") == "" ? (GridViewPatient.SelectedItems[i].GetRow().Cells["Mobile2"].Value ?? "").ToString().Replace("‍", "").Replace(" ", "") : (GridViewPatient.SelectedItems[i].GetRow().Cells["Mobile"].Value ?? "").ToString().Replace("‍", "").Replace(" ", "");
                        ssss.MobileNo2 = (GridViewPatient.SelectedItems[i].GetRow().Cells["Mobile2"].Value ?? "").ToString().Replace("‍", "").Replace(" ", "");
                        ListForSelectPerson.Add(ssss);
                    }
                    catch { }
                }
            }
            ViewModel.PublicClass.FillForSMS();

            string MsgSet = " با سلام و خسته نباشید " + "\r\n" +
                            "بیمار: " + GridViewPatient.CurrentRow.Cells["PatientName"].Value.ToString() + " " + GridViewPatient.CurrentRow.Cells["PatientFamily"].Value.ToString() +
                            ",  آدرس: " + (GridViewPatient.CurrentRow.Cells["StatePart"].Value ?? "").ToString() + " " + (GridViewPatient.CurrentRow.Cells["CityState"].Value ?? "").ToString() + " " + (GridViewPatient.CurrentRow.Cells["CityPart"].Value ?? "").ToString() + " " + (GridViewPatient.CurrentRow.Cells["Address"].Value ?? "").ToString() + " " +
                            "تلفن منزل:‍ " + (GridViewPatient.CurrentRow.Cells["TelHome"].Value ?? "").ToString() + ",   موبایل:‍ " + (GridViewPatient.CurrentRow.Cells["Mobile"].Value ?? "").ToString() + ",   درخواست:         " + "\r\n" +
                            " باتشکر شرکت شاهد ";
            MKH.SMS.View.Forms.SendSMSAdd_Frm SSA = new MKH.SMS.View.Forms.SendSMSAdd_Frm(ListForSelectPerson, MsgSet);
            SSA.ShowDialog();
        }

        private void ToolStripMenuItemPatientCurrentRow_Click(object sender, EventArgs e)
        {
            try
            {
                string Str = "";
                int J = 0;

                MKH.Library.Forms.MSSLogViewer_frm ctrl = new MKH.Library.Forms.MSSLogViewer_frm();
                ctrl.GridexViewSelector.DataSource = new MKH.Permission.ViewModel.Log.Log().GetAllListPatientByID(System.Convert.ToInt32(GridViewPatient.CurrentRow.Cells["Id"].Value), ref Str).ToList();
                ctrl.ColumnList = new System.Data.DataTable();
                for (int i = 0; i < GridViewPatient.RootTable.Columns.Count; i++)
                    if (GridViewPatient.RootTable.Columns[i].Tag == "" || GridViewPatient.RootTable.Columns[i].Tag == null)
                    {
                        ctrl.ColumnList.Columns.Add(GridViewPatient.RootTable.Columns[i].Key);
                        ctrl.ColumnList.Columns[J].Caption = GridViewPatient.RootTable.Columns[i].Caption;
                        J++;
                    }
                ctrl.ShowDialog();
            }
            catch { }
        }

        private void ToolStripMenuItemPatientAllList_Click(object sender, EventArgs e)
        {
            try
            {
                string Str = "";
                int J = 0;

                MKH.Library.Forms.MSSLogViewer_frm ctrl = new MKH.Library.Forms.MSSLogViewer_frm();
                ctrl.GridexViewSelector.DataSource = new MKH.Permission.ViewModel.Log.Log().GetAllListPatient(ref Str).ToList();
                ctrl.ColumnList = new System.Data.DataTable();
                for (int i = 0; i < GridViewPatient.RootTable.Columns.Count; i++)
                    if (GridViewPatient.RootTable.Columns[i].Visible)
                    {
                        ctrl.ColumnList.Columns.Add(GridViewPatient.RootTable.Columns[i].Key);
                        ctrl.ColumnList.Columns[J].Caption = GridViewPatient.RootTable.Columns[i].Caption;
                        J++;
                    }
                ctrl.ShowDialog();
            }
            catch { }
        }

        private void ToolStripMenuItemVisitPatientInsert_Click(object sender, EventArgs e)
        {
            string str = "";

            for (int i = 0; i < GridViewPatient.SelectedItems.Count; i++)
                if (new ViewModel.Basic.NODuplicateForm().CheckNODuplicateForm("TBL_Patient", GridViewPatient.SelectedItems[i].GetRow().Cells["Id"].Value.ToString(), ref str))
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View("امکان تغییرات به علت انجام عملیات توسط کاربر دیگر امکان پذیر نمی باشد. لطفا کمی بعد سعی کنید", MKH.Library.Clasess.MSSMessage.MessageType.SWarning);
                    return;
                }
            

            List<PhysiotherapyCare.Other.Class.PatientListDefine> ListPatientListDefine = new List<Other.Class.PatientListDefine>();
            for (int i = 0; i < GridViewPatient.SelectedItems.Count; i++)
            {
                Other.Class.PatientListDefine df = new Other.Class.PatientListDefine();
                df.PatientId = Convert.ToInt32(GridViewPatient.SelectedItems[i].GetRow().Cells["Id"].Value ?? "");
                df.Doctor_Id = Convert.ToInt32(GridViewPatient.SelectedItems[i].GetRow().Cells["LastDoctorVisit_Id"].Value ?? "0");
                df.DoctorNameFamily = (GridViewPatient.SelectedItems[i].GetRow().Cells["LastDoctorVisitNameF"].Value ?? "").ToString();
                df.BonyadAddEven = Convert.ToInt16(GridViewPatient.SelectedItems[i].GetRow().Cells["BonyadAddEven"].Value ?? "-1");
                ListPatientListDefine.Add(df);
            }
            VisitPatientWithGroupAdd_Frm ff = new VisitPatientWithGroupAdd_Frm(ListPatientListDefine);
            if (ff.ShowDialog() == DialogResult.OK)
                BindData(GridViewPatient.Row);
        }

        private void ToolStripMenuItemDoctorInsert_Click(object sender, EventArgs e)
        {
            string str = "";
            for (int i = 0; i < GridViewPatient.SelectedItems.Count; i++)
                if (new ViewModel.Basic.NODuplicateForm().CheckNODuplicateForm("TBL_Patient", GridViewPatient.SelectedItems[i].GetRow().Cells["Id"].Value.ToString(), ref str))
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View("امکان تغییرات به علت انجام عملیات توسط کاربر دیگر امکان پذیر نمی باشد. لطفا کمی بعد سعی کنید", MKH.Library.Clasess.MSSMessage.MessageType.SWarning);
                    return;
                }

            try
            {
                string StrSet = "";
                Dictionary<string, string> SD = new Dictionary<string, string>();
                Dictionary<string, string> SD1 = new Dictionary<string, string>();
                
                SD.Add("-1", "حذف پزشک");
                
                foreach (var item in new ViewModel.Doctors.Doctor().GetAllList(ref StrSet))
                    SD.Add(item.Id.ToString(), item.DoctorName + " " + item.DoctorFamily);

                SD1 = MKH.Library.Forms.MSSSelector_frm.SetDataSelect(SD);
                if (SD1 != null)
                {
                    int _doctor_Id = SD1.Keys.ToList()[0].ToInt();
                    int IDSet = 0;
                    string LastVisitDate = "";
                    for (int i = 0; i < GridViewPatient.SelectedItems.Count; i++)
                    {
                        IDSet = int.Parse(GridViewPatient.SelectedItems[i].GetRow().Cells["Id"].Value.ToString());

                        if (_doctor_Id == -1)
                        {
                            new ViewModel.Patient.Patient().UpdateTableNameWithNullValue(
                                IDSet, "LastDoctorVisit_Id",
                            MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                            MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(System.DateTime.Now), ref StrSet);

                            new ViewModel.Patient.Patient().UpdateEntityWithFieldValue(
                                IDSet, "LastVisitDate", "",
                            MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                            MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(System.DateTime.Now), ref StrSet);
                        }
                        else
                            new ViewModel.Patient.Patient().UpdateEntityWithFieldValue(
                                IDSet, "LastDoctorVisit_Id", _doctor_Id.ToString(),
                            MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                            MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(System.DateTime.Now), ref StrSet);

                    }
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View("پزشکان اختصاص داده شدند", MKH.Library.Clasess.MSSMessage.MessageType.SInformation);

                    BindData(GridViewPatient.Row);
                }
            }
            catch { }
        }

        private void DatePickerStart_ValueChanged(object sender, KagNetComponents2.PersianMonthCalendarEventArgs e)
        {
            if (SetDate) BindData(GridViewPatient.Row);
        }

       
        
       
    }
}
