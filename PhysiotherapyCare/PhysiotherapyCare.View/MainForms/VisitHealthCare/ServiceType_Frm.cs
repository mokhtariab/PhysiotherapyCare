using System.Linq;
using System.Collections.Generic;
using PhysiotherapyCare.Model.VisitHealthCare;
using PhysiotherapyCare.ViewModel;

namespace PhysiotherapyCare.View.MainForms.VisitHealthCare
{
    public partial class ServiceType_Frm : System.Windows.Forms.Form
    {
        public ServiceType_Frm()
        {
            InitializeComponent();
        }

        public void BindData(int RowNumberSet)
        {
            string str = "";
            GridViewServiceType.DataSource = new PhysiotherapyCare.ViewModel.VisitHealthCare.ServiceType().GetAllList(ref str);

            try { GridViewServiceType.Row = RowNumberSet; }
            catch { }
        }

        
        #region All UI Button

        private void headerGridServiceType_btnInsertClick(object sender, System.EventArgs e)
        {
            ServiceTypeAdd_Frm ServiceTypeAdd = new ServiceTypeAdd_Frm();
            if (ServiceTypeAdd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                BindData(GridViewServiceType.RowCount);
        }

        private void headerGridServiceType_btnEditClick(object sender, System.EventArgs e)
        {
            try
            {
                if (!(HeaderGridServiceType as MKH.Library.Control.MSSHeaderGrid).Items["buttonItemEdit"].Visible || !(HeaderGridServiceType as MKH.Library.Control.MSSHeaderGrid).Items["buttonItemEdit"].Enabled) return;
                ServiceTypeAdd_Frm ServiceTypeAdd = new ServiceTypeAdd_Frm(byte.Parse(GridViewServiceType.CurrentRow.Cells["Id"].Value.ToString()));
                if (ServiceTypeAdd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    BindData(GridViewServiceType.Row);
            }
            catch { }
        }

        private void headerGridServiceType_btnDeleteClick(object sender, System.EventArgs e)
        {
            if (MKH.Library.Clasess.MSSMessage.MSSMessage_View(0,MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation,true, "آیا به حذف این مورد اطمینان دارید؟"))
            {
                try
                {
                    List<TBL_ServiceType> Ls = new List<TBL_ServiceType>();
                    TBL_ServiceType ServiceType = new TBL_ServiceType();
                    ServiceType.Id = short.Parse(GridViewServiceType.CurrentRow.Cells["Id"].Value.ToString());
                    ServiceType.TitleName = GridViewServiceType.CurrentRow.Cells["TitleName"].Value.ToString();
                    Ls.Add(ServiceType);


                    string str = "";
                    new ViewModel.VisitHealthCare.ServiceType().DeleteEntity(Ls, ref str);
                    if (str != "") MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "امکان حذف این مورد در سیستم وجود ندارد", str);
                    else
                        BindData(GridViewServiceType.Row);
                }
                catch (System.Exception ex)
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "امکان حذف این مورد در سیستم وجود ندارد", ex.Message);
                }
            }
            
        }

        private void headerGridServiceType_btnRefreshClick(object sender, System.EventArgs e)
        {
            BindData(GridViewServiceType.Row);
        }

        #endregion

        private void ServiceType_Frm_Load(object sender, System.EventArgs e)
        {
            new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionControl(this);
            BindData(0);
        }


    }
}
