using System.Linq;
using System.Collections.Generic;
using PhysiotherapyCare.Model.Status;
using PhysiotherapyCare.ViewModel;

namespace PhysiotherapyCare.View.MainForms.Status
{
    public partial class StatusTypeDetail_Frm : System.Windows.Forms.Form
    {
        public StatusTypeDetail_Frm()
        {
            InitializeComponent();
        }

        public void BindData(int RowNumberSet)
        {
            string str = "";
            GridViewStatusTypeDetail.DataSource = new PhysiotherapyCare.ViewModel.Status.StatusTypeDetail().GetAllList(ref str);

            try { GridViewStatusTypeDetail.Row = RowNumberSet; }
            catch { }
        }

        
        #region All UI Button

        private void headerGridStatusTypeDetail_btnInsertClick(object sender, System.EventArgs e)
        {
            StatusTypeDetailAdd_Frm StatusTypeDetailAdd = new StatusTypeDetailAdd_Frm();
            if (StatusTypeDetailAdd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                BindData(GridViewStatusTypeDetail.RowCount);
        }

        private void headerGridStatusTypeDetail_btnEditClick(object sender, System.EventArgs e)
        {
            try
            {
                if (!(HeaderGridStatusTypeDetail as MKH.Library.Control.MSSHeaderGrid).Items["buttonItemEdit"].Visible || !(HeaderGridStatusTypeDetail as MKH.Library.Control.MSSHeaderGrid).Items["buttonItemEdit"].Enabled) return;
                StatusTypeDetailAdd_Frm StatusTypeDetailAdd = new StatusTypeDetailAdd_Frm(byte.Parse(GridViewStatusTypeDetail.CurrentRow.Cells["Id"].Value.ToString()));
                if (StatusTypeDetailAdd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    BindData(GridViewStatusTypeDetail.Row);
            }
            catch { }
        }

        private void headerGridStatusTypeDetail_btnDeleteClick(object sender, System.EventArgs e)
        {
            if (MKH.Library.Clasess.MSSMessage.MSSMessage_View(0,MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation,true, "آیا به حذف این مورد اطمینان دارید؟"))
            {
                try
                {
                    List<TBL_StatusTypeDetail> Ls = new List<TBL_StatusTypeDetail>();
                    TBL_StatusTypeDetail StatusTypeDetail = new TBL_StatusTypeDetail();
                    StatusTypeDetail.Id = short.Parse(GridViewStatusTypeDetail.CurrentRow.Cells["Id"].Value.ToString());
                    StatusTypeDetail.TitleName = GridViewStatusTypeDetail.CurrentRow.Cells["TitleName"].Value.ToString();
                    Ls.Add(StatusTypeDetail);


                    string str = "";
                    new ViewModel.Status.StatusTypeDetail().DeleteEntity(Ls, ref str);
                    if (str != "") MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "امکان حذف این مورد در سیستم وجود ندارد", str);
                    else
                        BindData(GridViewStatusTypeDetail.Row);
                }
                catch (System.Exception ex)
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "امکان حذف این مورد در سیستم وجود ندارد", ex.Message);
                }
            }
            
        }

        private void headerGridStatusTypeDetail_btnRefreshClick(object sender, System.EventArgs e)
        {
            BindData(GridViewStatusTypeDetail.Row);
        }

        #endregion

        private void StatusTypeDetail_Frm_Load(object sender, System.EventArgs e)
        {
            new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionControl(this);
            BindData(0);
        }


    }
}
