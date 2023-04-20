using System.Linq;
using System.Collections.Generic;
using PhysiotherapyCare.Model.VisitPatient;
using PhysiotherapyCare.ViewModel;

namespace PhysiotherapyCare.View.BaseForms
{
    public partial class EquipmentUse_Frm : System.Windows.Forms.Form
    {
        public EquipmentUse_Frm()
        {
            InitializeComponent();
        }

        public void BindData(int RowNumberSet)
        {
            string str = "";
            GridViewEquipmentUse.DataSource = new PhysiotherapyCare.ViewModel.VisitPatient.EquipmentUse().GetAllList(ref str);

            try { GridViewEquipmentUse.Row = RowNumberSet; }
            catch { }
        }

        
        #region All UI Button

        private void headerGridKinShip_btnInsertClick(object sender, System.EventArgs e)
        {
            EquipmentUseAdd_Frm EquipmentUseAdd = new EquipmentUseAdd_Frm();
            if (EquipmentUseAdd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                BindData(GridViewEquipmentUse.RowCount);
        }

        private void headerGridKinShip_btnEditClick(object sender, System.EventArgs e)
        {
            try
            {
                if (!(HeaderGridKinShip as MKH.Library.Control.MSSHeaderGrid).Items["buttonItemEdit"].Visible || !(HeaderGridKinShip as MKH.Library.Control.MSSHeaderGrid).Items["buttonItemEdit"].Enabled) return;
                EquipmentUseAdd_Frm EquipmentUseAdd = new EquipmentUseAdd_Frm(byte.Parse(GridViewEquipmentUse.CurrentRow.Cells["Id"].Value.ToString()));
                if (EquipmentUseAdd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    BindData(GridViewEquipmentUse.Row);
            }
            catch { }
        }

        private void headerGridKinShip_btnDeleteClick(object sender, System.EventArgs e)
        {
            if (MKH.Library.Clasess.MSSMessage.MSSMessage_View(0,MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation,true, "آیا به حذف این مورد اطمینان دارید؟"))
            {
                try
                {
                    List<TBL_EquipmentUse> Ls = new List<TBL_EquipmentUse>();
                    TBL_EquipmentUse EquipmentUse = new TBL_EquipmentUse();
                    EquipmentUse.Id = int.Parse(GridViewEquipmentUse.CurrentRow.Cells["Id"].Value.ToString());
                    EquipmentUse.TitleName = GridViewEquipmentUse.CurrentRow.Cells["TitleName"].Value.ToString();
                    Ls.Add(EquipmentUse);


                    string str = "";
                    new ViewModel.VisitPatient.EquipmentUse().DeleteEntity(Ls, ref str);
                    if (str != "") MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "امکان حذف این مورد در سیستم وجود ندارد", str);
                    else
                        BindData(GridViewEquipmentUse.Row);
                }
                catch (System.Exception ex)
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "امکان حذف این مورد در سیستم وجود ندارد", ex.Message);
                }
            }
            
        }

        private void headerGridKinShip_btnRefreshClick(object sender, System.EventArgs e)
        {
            BindData(GridViewEquipmentUse.Row);
        }

        #endregion

        private void KinShip_Frm_Load(object sender, System.EventArgs e)
        {
            new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionControl(this);
            BindData(0);
        }


    }
}
