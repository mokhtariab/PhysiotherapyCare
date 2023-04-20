using System.Linq;
using System.Collections.Generic;
using PhysiotherapyCare.Model.Doctors;
using PhysiotherapyCare.ViewModel.DoctorsContracts;

namespace PhysiotherapyCare.View.MainForms.Doctors
{
    public partial class DoctorsContract_Frm : System.Windows.Forms.Form
    {
        int _doctor_Id = 0;
        public DoctorsContract_Frm(int Doctor_Id)
        {
            InitializeComponent();
            _doctor_Id = Doctor_Id;
        }

        public void BindData(int RowNumberSet)
        {
            string str = "";
            GridViewDoctorsContract.DataSource = new PhysiotherapyCare.ViewModel.DoctorsContracts.DoctorsContract().GetAllListByDoctorID(_doctor_Id, ref str);
            try { GridViewDoctorsContract.Row = RowNumberSet; }
            catch { }
        }

        
        #region All UI Button

        private void headerGridDoctorsContract_btnInsertClick(object sender, System.EventArgs e)
        {
            DoctorsContractAdd_Frm DoctorsContractAdd = new DoctorsContractAdd_Frm(_doctor_Id);
            if (DoctorsContractAdd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                BindData(GridViewDoctorsContract.RowCount);
                DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }

        private void headerGridDoctorsContract_btnEditClick(object sender, System.EventArgs e)
        {
            try
            {
                //if (!(HeaderGridDoctorsContract as MKH.Library.Control.MSSHeaderGrid).Items["buttonItemEdit"].Visible || !(HeaderGridDoctorsContract as MKH.Library.Control.MSSHeaderGrid).Items["buttonItemEdit"].Enabled) return;

                DoctorsContractAdd_Frm DoctorsContractAdd = new DoctorsContractAdd_Frm(_doctor_Id, 
                                        int.Parse(GridViewDoctorsContract.CurrentRow.Cells["Id"].Value.ToString()));
                if (DoctorsContractAdd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    BindData(GridViewDoctorsContract.Row);
                    DialogResult = System.Windows.Forms.DialogResult.OK;
                }

            }
            catch { }
        }

        private void headerGridDoctorsContract_btnDeleteClick(object sender, System.EventArgs e)
        {
            if (MKH.Library.Clasess.MSSMessage.MSSMessage_View(0,MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation,true, "آیا به حذف این مورد اطمینان دارید؟"))
            {
                try
                {
                    List<TBL_DoctorsContract> Ls = new List<TBL_DoctorsContract>();
                    TBL_DoctorsContract DoctorsContract = new TBL_DoctorsContract();
                    DoctorsContract.Id = int.Parse(GridViewDoctorsContract.CurrentRow.Cells["Id"].Value.ToString());
                    DoctorsContract.Doctor_Id = int.Parse(GridViewDoctorsContract.CurrentRow.Cells["Doctor_Id"].Value.ToString());
                    DoctorsContract.ContractDate = GridViewDoctorsContract.CurrentRow.Cells["ContractDate"].Value.ToString();
                    DoctorsContract.ContractEndDate = GridViewDoctorsContract.CurrentRow.Cells["ContractEndDate"].Value.ToString();
                    DoctorsContract.ContractNo = GridViewDoctorsContract.CurrentRow.Cells["ContractNo"].Value.ToString();
                    DoctorsContract.ContractPercent = int.Parse(GridViewDoctorsContract.CurrentRow.Cells["ContractPercent"].Value.ToString());
                    Ls.Add(DoctorsContract);


                    string str = "";
                    new ViewModel.DoctorsContracts.DoctorsContract().DeleteEntity(Ls, ref str);
                    if (str != "") MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "امکان حذف این مورد در سیستم وجود ندارد", str);
                    else
                    {
                        BindData(GridViewDoctorsContract.Row - 1);
                        DialogResult = System.Windows.Forms.DialogResult.OK;
                    }
                }
                catch (System.Exception ex)
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "امکان حذف این مورد در سیستم وجود ندارد", ex.Message);
                }
            }

        }

        private void headerGridDoctorsContract_btnRefreshClick(object sender, System.EventArgs e)
        {
            BindData(GridViewDoctorsContract.Row);
        }

        #endregion

        private void DoctorsContract_Frm_Load(object sender, System.EventArgs e)
        {
            new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionControl(this);
            
            ToolStripMenuItemDoctorsContractCurrentRow.Enabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(289);
            ToolStripMenuItemDoctorsContractAllList.Enabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(290);

            BindData(0);
        }

        private void ToolStripMenuItemDoctorsContractAllList_Click(object sender, System.EventArgs e)
        {
            try
            {
                string Str = "";
                int J = 0;

                MKH.Library.Forms.MSSLogViewer_frm ctrl = new MKH.Library.Forms.MSSLogViewer_frm();
                ctrl.GridexViewSelector.DataSource = new MKH.Permission.ViewModel.Log.Log().GetAllListDoctorsContract(ref Str).ToList();
                ctrl.ColumnList = new System.Data.DataTable();
                for (int i = 0; i < GridViewDoctorsContract.RootTable.Columns.Count; i++)
                    if (GridViewDoctorsContract.RootTable.Columns[i].Visible)
                    {
                        ctrl.ColumnList.Columns.Add(GridViewDoctorsContract.RootTable.Columns[i].Key);
                        ctrl.ColumnList.Columns[J].Caption = GridViewDoctorsContract.RootTable.Columns[i].Caption;
                        J++;
                    }
                ctrl.ShowDialog();
            }
            catch { }
        }

        private void ToolStripMenuItemDoctorsContractCurrentRow_Click(object sender, System.EventArgs e)
        {
            try
            {
                string Str = "";
                int J = 0;

                MKH.Library.Forms.MSSLogViewer_frm ctrl = new MKH.Library.Forms.MSSLogViewer_frm();
                ctrl.GridexViewSelector.DataSource = new MKH.Permission.ViewModel.Log.Log().GetAllListDoctorsContractByID(System.Convert.ToInt32(GridViewDoctorsContract.CurrentRow.Cells["Id"].Value), ref Str).ToList();
                ctrl.ColumnList = new System.Data.DataTable();
                for (int i = 0; i < GridViewDoctorsContract.RootTable.Columns.Count; i++)
                    if (GridViewDoctorsContract.RootTable.Columns[i].Tag == "" || GridViewDoctorsContract.RootTable.Columns[i].Tag == null)
                    {
                        ctrl.ColumnList.Columns.Add(GridViewDoctorsContract.RootTable.Columns[i].Key);
                        ctrl.ColumnList.Columns[J].Caption = GridViewDoctorsContract.RootTable.Columns[i].Caption;
                        J++;
                    }
                ctrl.ShowDialog();
            }
            catch { }
        }



    }
}
