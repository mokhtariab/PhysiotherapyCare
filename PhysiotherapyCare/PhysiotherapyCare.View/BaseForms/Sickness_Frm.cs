using System.Linq;
using System.Collections.Generic;
using PhysiotherapyCare.Model.VisitPatient;
using PhysiotherapyCare.ViewModel.VisitPatient;

namespace PhysiotherapyCare.View.BaseForms
{
    public partial class Sickness_Frm : System.Windows.Forms.Form
    {
        public Sickness_Frm()
        {
            InitializeComponent();
        }

        public void BindData(int RowNumberSet)
        {
            string str = "";
            GridViewSickness.DataSource = new PhysiotherapyCare.ViewModel.VisitPatient.Sickness().GetAllList(ref str);

            try { GridViewSickness.Row = RowNumberSet; }
            catch { }
        }

        
        #region All UI Button

        private void headerGridSickness_btnInsertClick(object sender, System.EventArgs e)
        {
            SicknessAdd_Frm SicknessAdd = new SicknessAdd_Frm();
            if (SicknessAdd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                BindData(GridViewSickness.RowCount);
        }

        private void headerGridSickness_btnEditClick(object sender, System.EventArgs e)
        {
            try
            {
                if (!(HeaderGridSickness as MKH.Library.Control.MSSHeaderGrid).Items["buttonItemEdit"].Visible || !(HeaderGridSickness as MKH.Library.Control.MSSHeaderGrid).Items["buttonItemEdit"].Enabled) return;
                SicknessAdd_Frm SicknessAdd = new SicknessAdd_Frm(byte.Parse(GridViewSickness.CurrentRow.Cells["Id"].Value.ToString()));
                if (SicknessAdd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    BindData(GridViewSickness.Row);
            }
            catch { }
        }

        private void headerGridSickness_btnDeleteClick(object sender, System.EventArgs e)
        {
            if (MKH.Library.Clasess.MSSMessage.MSSMessage_View(0,MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation,true, "آیا به حذف این مورد اطمینان دارید؟"))
            {
                try
                {
                    List<TBL_Sickness> Ls = new List<TBL_Sickness>();
                    TBL_Sickness Sickness = new TBL_Sickness();
                    Sickness.Id = short.Parse(GridViewSickness.CurrentRow.Cells["Id"].Value.ToString());
                    Sickness.TitleName = GridViewSickness.CurrentRow.Cells["TitleName"].Value.ToString();
                    Ls.Add(Sickness);


                    string str = "";
                    new ViewModel.VisitPatient.Sickness().DeleteEntity(Ls, ref str);
                    if (str != "") MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "امکان حذف این مورد در سیستم وجود ندارد", str);
                    else
                        BindData(GridViewSickness.Row);
                }
                catch (System.Exception ex)
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "امکان حذف این مورد در سیستم وجود ندارد", ex.Message);
                }
            }
            
        }

        private void headerGridSickness_btnRefreshClick(object sender, System.EventArgs e)
        {
            BindData(GridViewSickness.Row);
        }

        #endregion

        private void Sickness_Frm_Load(object sender, System.EventArgs e)
        {
            new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionControl(this);
            BindData(0);
        }


    }
}
