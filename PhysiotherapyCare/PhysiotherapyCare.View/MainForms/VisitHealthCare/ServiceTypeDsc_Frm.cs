using System.Linq;
using System.Collections.Generic;
using PhysiotherapyCare.Model.VisitHealthCare;
using PhysiotherapyCare.ViewModel;

namespace PhysiotherapyCare.View.MainForms.VisitHealthCare
{
    public partial class ServiceTypeDsc_Frm : System.Windows.Forms.Form
    {
        public ServiceTypeDsc_Frm()
        {
            InitializeComponent();
        }

        public void BindData(int RowNumberSet)
        {
            string str = "";
            GridViewServiceTypeDsc.DataSource = new PhysiotherapyCare.ViewModel.VisitHealthCare.ServiceTypeDsc().GetAllList(ref str);

            try { GridViewServiceTypeDsc.Row = RowNumberSet; }
            catch { }
        }

        
        #region All UI Button

        private void headerGridServiceTypeDsc_btnInsertClick(object sender, System.EventArgs e)
        {
            ServiceTypeDscAdd_Frm ServiceTypeDscAdd = new ServiceTypeDscAdd_Frm();
            if (ServiceTypeDscAdd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                BindData(GridViewServiceTypeDsc.RowCount);
        }

        private void headerGridServiceTypeDsc_btnEditClick(object sender, System.EventArgs e)
        {
            try
            {
                if (!(HeaderGridServiceTypeDsc as MKH.Library.Control.MSSHeaderGrid).Items["buttonItemEdit"].Visible || !(HeaderGridServiceTypeDsc as MKH.Library.Control.MSSHeaderGrid).Items["buttonItemEdit"].Enabled) return;
                ServiceTypeDscAdd_Frm ServiceTypeDscAdd = new ServiceTypeDscAdd_Frm(byte.Parse(GridViewServiceTypeDsc.CurrentRow.Cells["Id"].Value.ToString()));
                if (ServiceTypeDscAdd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    BindData(GridViewServiceTypeDsc.Row);
            }
            catch { }
        }

        private void headerGridServiceTypeDsc_btnDeleteClick(object sender, System.EventArgs e)
        {
            if (MKH.Library.Clasess.MSSMessage.MSSMessage_View(0,MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation,true, "آیا به حذف این مورد اطمینان دارید؟"))
            {
                try
                {
                    List<TBL_ServiceTypeDsc> Ls = new List<TBL_ServiceTypeDsc>();
                    TBL_ServiceTypeDsc ServiceTypeDsc = new TBL_ServiceTypeDsc();
                    ServiceTypeDsc.Id = short.Parse(GridViewServiceTypeDsc.CurrentRow.Cells["Id"].Value.ToString());
                    ServiceTypeDsc.TitleName = GridViewServiceTypeDsc.CurrentRow.Cells["TitleName"].Value.ToString();
                    Ls.Add(ServiceTypeDsc);


                    string str = "";
                    new ViewModel.VisitHealthCare.ServiceTypeDsc().DeleteEntity(Ls, ref str);
                    if (str != "") MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "امکان حذف این مورد در سیستم وجود ندارد", str);
                    else
                        BindData(GridViewServiceTypeDsc.Row);
                }
                catch (System.Exception ex)
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "امکان حذف این مورد در سیستم وجود ندارد", ex.Message);
                }
            }
            
        }

        private void headerGridServiceTypeDsc_btnRefreshClick(object sender, System.EventArgs e)
        {
            BindData(GridViewServiceTypeDsc.Row);
        }

        #endregion

        private void ServiceTypeDsc_Frm_Load(object sender, System.EventArgs e)
        {
            new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionControl(this);
            BindData(0);
        }


    }
}
