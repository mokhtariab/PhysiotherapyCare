using System.Linq;
using System.Collections.Generic;
using PhysiotherapyCare.Model.Status;
using PhysiotherapyCare.ViewModel;

namespace PhysiotherapyCare.View.MainForms.Status
{
    public partial class StatusType_Frm : System.Windows.Forms.Form
    {
        public StatusType_Frm()
        {
            InitializeComponent();
        }

        public void BindData(int RowNumberSet)
        {
            string str = "";
            GridViewStatusType.DataSource = new PhysiotherapyCare.ViewModel.Status.StatusType().GetAllList(ref str);

            try { GridViewStatusType.Row = RowNumberSet; }
            catch { }
        }

        
        #region All UI Button

        private void headerGridStatusType_btnInsertClick(object sender, System.EventArgs e)
        {
            StatusTypeAdd_Frm StatusTypeAdd = new StatusTypeAdd_Frm();
            if (StatusTypeAdd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                BindData(GridViewStatusType.RowCount);
        }

        private void headerGridStatusType_btnEditClick(object sender, System.EventArgs e)
        {
            try
            {
                if (!(HeaderGridStatusType as MKH.Library.Control.MSSHeaderGrid).Items["buttonItemEdit"].Visible || !(HeaderGridStatusType as MKH.Library.Control.MSSHeaderGrid).Items["buttonItemEdit"].Enabled) return;
                StatusTypeAdd_Frm StatusTypeAdd = new StatusTypeAdd_Frm(byte.Parse(GridViewStatusType.CurrentRow.Cells["Id"].Value.ToString()));
                if (StatusTypeAdd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    BindData(GridViewStatusType.Row);
            }
            catch { }
        }

        private void headerGridStatusType_btnDeleteClick(object sender, System.EventArgs e)
        {
            if (MKH.Library.Clasess.MSSMessage.MSSMessage_View(0,MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation,true, "آیا به حذف این مورد اطمینان دارید؟"))
            {
                try
                {
                    List<TBL_StatusType> Ls = new List<TBL_StatusType>();
                    TBL_StatusType StatusType = new TBL_StatusType();
                    StatusType.Id = short.Parse(GridViewStatusType.CurrentRow.Cells["Id"].Value.ToString());
                    StatusType.TitleName = GridViewStatusType.CurrentRow.Cells["TitleName"].Value.ToString();
                    Ls.Add(StatusType);


                    string str = "";
                    new ViewModel.Status.StatusType().DeleteEntity(Ls, ref str);
                    if (str != "") MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "امکان حذف این مورد در سیستم وجود ندارد", str);
                    else
                        BindData(GridViewStatusType.Row);
                }
                catch (System.Exception ex)
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "امکان حذف این مورد در سیستم وجود ندارد", ex.Message);
                }
            }
            
        }

        private void headerGridStatusType_btnRefreshClick(object sender, System.EventArgs e)
        {
            BindData(GridViewStatusType.Row);
        }

        #endregion

        private void StatusType_Frm_Load(object sender, System.EventArgs e)
        {
            new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionControl(this);
            BindData(0);
        }


    }
}
