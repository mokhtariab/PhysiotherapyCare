using System.Linq;
using System.Collections.Generic;
using PhysiotherapyCare.Model.VisitPatient;
using PhysiotherapyCare.ViewModel;

namespace PhysiotherapyCare.View.BaseForms
{
    public partial class Paraclinic_Frm : System.Windows.Forms.Form
    {
        public Paraclinic_Frm()
        {
            InitializeComponent();
        }

        public void BindData(int RowNumberSet)
        {
            string str = "";
            GridViewLocationPart.DataSource = new PhysiotherapyCare.ViewModel.VisitPatient.Paraclinic().GetAllList(ref str);
            
            try { GridViewLocationPart.Row = RowNumberSet; }
            catch { }
        }

        
        #region All UI Button

        private void headerGridLocationPart_btnInsertClick(object sender, System.EventArgs e)
        {
            ParaclinicAdd_Frm ParaclinicAdd = new ParaclinicAdd_Frm();
            if (ParaclinicAdd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                BindData(GridViewLocationPart.RowCount);
        }

        private void headerGridLocationPart_btnEditClick(object sender, System.EventArgs e)
        {
            try
            {
                if (!(HeaderGridLocationPart as MKH.Library.Control.MSSHeaderGrid).Items["buttonItemEdit"].Visible || !(HeaderGridLocationPart as MKH.Library.Control.MSSHeaderGrid).Items["buttonItemEdit"].Enabled) return;
                ParaclinicAdd_Frm ParaclinicAdd = new ParaclinicAdd_Frm(
                    int.Parse(GridViewLocationPart.CurrentRow.Cells["Id"].Value.ToString()));
                if (ParaclinicAdd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    BindData(GridViewLocationPart.Row);
            }
            catch { }
        }

        private void headerGridLocationPart_btnDeleteClick(object sender, System.EventArgs e)
        {
            if (MKH.Library.Clasess.MSSMessage.MSSMessage_View(0,MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation,true, "آیا به حذف این مورد اطمینان دارید؟"))
            {
                try
                {
                    List<TBL_Paraclinic> Ls = new List<TBL_Paraclinic>();
                    TBL_Paraclinic Paraclinic = new TBL_Paraclinic();
                    Paraclinic.Id = int.Parse(GridViewLocationPart.CurrentRow.Cells["Id"].Value.ToString());
                    Paraclinic.TitleName = GridViewLocationPart.CurrentRow.Cells["TitleName"].Value.ToString();
                    Ls.Add(Paraclinic);


                    string str = "";
                    new ViewModel.VisitPatient.Paraclinic().DeleteEntity(Ls, ref str);

                    if (str != "") MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "امکان حذف این مورد در سیستم وجود ندارد", str);
                    else
                        BindData(GridViewLocationPart.Row - 1);
                }
                catch (System.Exception ex)
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "امکان حذف این مورد در سیستم وجود ندارد", ex.Message);
                }
            }
        }

        private void headerGridLocationPart_btnRefreshClick(object sender, System.EventArgs e)
        {
            BindData(GridViewLocationPart.Row);
        }

        #endregion

        private void LocationPart_Frm_Load(object sender, System.EventArgs e)
        {
            new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionControl(this);
            BindData(0);
        }


    }
}
