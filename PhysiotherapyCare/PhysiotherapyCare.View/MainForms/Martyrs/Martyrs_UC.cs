using System.Linq;
using System.Collections.Generic;
using PhysiotherapyCare.Model.Basic;
using PhysiotherapyCare.Model;
using MKH.Library.Clasess.FilterClass;
using System.Windows.Forms;
using PhysiotherapyCare.Model.Martyrs;

namespace PhysiotherapyCare.View.MainForms.Martyrs
{
    public partial class Martyrs_UC : UserControl
    {
        public Martyrs_UC()
        {
            InitializeComponent();
        }

        public void BindData(int RowNumberSet)
        {
            string str = "";

            GridViewMartyrs.DataSource = new ViewModel.Martyrs.Martyr().GetAllList(ref str);

            try { GridViewMartyrs.Row = RowNumberSet; }
            catch { } 
        }

        
        #region All UI Button

        private void headerGridMartyrs_btnInsertClick(object sender, System.EventArgs e)
        {
            MartyrsAdd_Frm MartyrsAdd = new MartyrsAdd_Frm();
            if (MartyrsAdd.ShowDialog() == System.Windows.Forms.DialogResult.OK) 
                BindData(GridViewMartyrs.RowCount);
        }

        private void headerGridMartyrs_btnEditClick(object sender, System.EventArgs e)
        {
            try
            {
                //if (!(HeaderGridMartyrs as MKH.Library.Control.MSSHeaderGrid).Items["buttonItemEdit"].Visible || !(HeaderGridMartyrs as MKH.Library.Control.MSSHeaderGrid).Items["buttonItemEdit"].Enabled) return;

                MartyrsAdd_Frm MartyrsAdd = new MartyrsAdd_Frm(
                    int.Parse(GridViewMartyrs.CurrentRow.Cells["MartyrId"].Value.ToString()));
                if (MartyrsAdd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    BindData(GridViewMartyrs.Row);
            }
            catch { }
        }

        private void headerGridMartyrs_btnDeleteClick(object sender, System.EventArgs e)
        {
            if (MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation, true, "آیا به حذف این مورد اطمینان دارید؟"))
            {
                try
                {
                    List<TBL_Martyr> Ls = new List<TBL_Martyr>();
                    TBL_Martyr Martyrs = new TBL_Martyr();
                    Martyrs.MartyrId = int.Parse(GridViewMartyrs.CurrentRow.Cells["MartyrId"].Value.ToString());
                    Ls.Add(Martyrs);


                    string str = "";
                    new ViewModel.Martyrs.Martyr().DeleteEntity(Ls, ref str);
                    if (str != "") MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "امکان حذف این مورد در سیستم وجود ندارد", str);
                    else
                        BindData(GridViewMartyrs.Row - 1);
                }
                catch (System.Exception ex)
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "امکان حذف این مورد در سیستم وجود ندارد", ex.Message);
                }
            }
        }

        private void headerGridMartyrs_btnRefreshClick(object sender, System.EventArgs e)
        {
            BindData(GridViewMartyrs.Row);
        }

        #endregion

        private void Martyrs_UC_Load(object sender, System.EventArgs e)
        {
            new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionControl(this);
            BindData(0);
        }

        private void HeaderGridMartyrs_buttonItemPrintClick(object sender, System.EventArgs e)
        {
            MKH.Library.Forms.MSSReportDesignList_frm ctrl = new MKH.Library.Forms.MSSReportDesignList_frm(this.Name);
            System.Data.DataTable DataRel = new System.Data.DataTable();
            try
            {
                foreach (Janus.Windows.GridEX.GridEXColumn item in GridViewMartyrs.RootTable.Columns)
                    if (item.Tag == "" || item.Tag == null)
                        DataRel.Columns.Add(item.Caption);

                for (int i = 0; i < GridViewMartyrs.RowCount; i++)
                {
                    System.Data.DataRow dr = DataRel.NewRow();
                    GridViewMartyrs.Row = i;
                    foreach (Janus.Windows.GridEX.GridEXColumn item in GridViewMartyrs.RootTable.Columns)
                        if (item.Tag == "" || item.Tag == null)
                            dr[item.Caption] = (GridViewMartyrs.CurrentRow.Cells[item.Key].Value ?? "").ToString();

                    DataRel.Rows.Add(dr);
                }


                ctrl.DataRelationNew = DataRel;//((System.Collections.IList)DataRel).OfType<object>().ToList();
                ctrl.NameForDB = this.Tag.ToString();
                ctrl.ShowDialog();
            }
            catch { }
        }

       
    }
}
