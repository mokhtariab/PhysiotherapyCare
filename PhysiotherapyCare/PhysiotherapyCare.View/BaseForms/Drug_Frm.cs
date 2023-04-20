using System.Linq;
using System.Collections.Generic;
using PhysiotherapyCare.Model.VisitPatient;
using PhysiotherapyCare.ViewModel;

namespace PhysiotherapyCare.View.BaseForms
{
    public partial class Drug_Frm : System.Windows.Forms.Form
    {
        public Drug_Frm()
        {
            InitializeComponent();
        }

        public void BindData(int RowNumberSet)
        {
            string str = "";
            GridViewKinShip.DataSource = new PhysiotherapyCare.ViewModel.VisitPatient.Drug().GetAllList(ref str);

            try { GridViewKinShip.Row = RowNumberSet; }
            catch { }
        }

        
        #region All UI Button

        private void headerGridKinShip_btnInsertClick(object sender, System.EventArgs e)
        {
            DrugAdd_Frm DrugAdd = new DrugAdd_Frm();
            if (DrugAdd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                BindData(GridViewKinShip.RowCount);
        }

        private void headerGridKinShip_btnEditClick(object sender, System.EventArgs e)
        {
            try
            {
                if (!(HeaderGridKinShip as MKH.Library.Control.MSSHeaderGrid).Items["buttonItemEdit"].Visible || !(HeaderGridKinShip as MKH.Library.Control.MSSHeaderGrid).Items["buttonItemEdit"].Enabled) return;
                DrugAdd_Frm DrugAdd = new DrugAdd_Frm(int.Parse(GridViewKinShip.CurrentRow.Cells["Id"].Value.ToString()));
                if (DrugAdd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    BindData(GridViewKinShip.Row);
            }
            catch { }
        }

        private void headerGridKinShip_btnDeleteClick(object sender, System.EventArgs e)
        {
            if (MKH.Library.Clasess.MSSMessage.MSSMessage_View(0,MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation,true, "آیا به حذف این مورد اطمینان دارید؟"))
            {
                try
                {
                    List<TBL_Drug> Ls = new List<TBL_Drug>();
                    TBL_Drug Drug = new TBL_Drug();
                    Drug.Id = int.Parse(GridViewKinShip.CurrentRow.Cells["Id"].Value.ToString());
                    Drug.TitleName = GridViewKinShip.CurrentRow.Cells["TitleName"].Value.ToString();
                    Ls.Add(Drug);


                    string str = "";
                    new ViewModel.VisitPatient.Drug().DeleteEntity(Ls, ref str);
                    if (str != "") MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "امکان حذف این مورد در سیستم وجود ندارد", str);
                    else
                        BindData(GridViewKinShip.Row);
                }
                catch (System.Exception ex)
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "امکان حذف این مورد در سیستم وجود ندارد", ex.Message);
                }
            }
            
        }

        private void headerGridKinShip_btnRefreshClick(object sender, System.EventArgs e)
        {
            BindData(GridViewKinShip.Row);
        }

        #endregion

        private void KinShip_Frm_Load(object sender, System.EventArgs e)
        {
            new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionControl(this);
            BindData(0);
        }


    }
}
