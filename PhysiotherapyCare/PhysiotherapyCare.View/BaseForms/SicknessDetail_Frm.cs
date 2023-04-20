using System.Linq;
using System.Collections.Generic;
using PhysiotherapyCare.Model.VisitPatient;
using PhysiotherapyCare.ViewModel.VisitPatient;

namespace PhysiotherapyCare.View.BaseForms
{
    public partial class SicknessDetail_Frm : System.Windows.Forms.Form
    {
        public SicknessDetail_Frm()
        {
            InitializeComponent();
        }

        public void BindData(int RowNumberSet)
        {
            string str = "";
            GridViewSicknessDetail.DataSource = new PhysiotherapyCare.ViewModel.VisitPatient.SicknessDetail().GetAllList(ref str);

            try { GridViewSicknessDetail.Row = RowNumberSet; }
            catch { }
        }

        
        #region All UI Button

        private void headerGridSicknessDetail_btnInsertClick(object sender, System.EventArgs e)
        {
            SicknessDetailAdd_Frm SicknessDetailAdd = new SicknessDetailAdd_Frm();
            if (SicknessDetailAdd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                BindData(GridViewSicknessDetail.RowCount);
        }

        private void headerGridSicknessDetail_btnEditClick(object sender, System.EventArgs e)
        {
            try
            {
                if (!(HeaderGridSicknessDetail as MKH.Library.Control.MSSHeaderGrid).Items["buttonItemEdit"].Visible || !(HeaderGridSicknessDetail as MKH.Library.Control.MSSHeaderGrid).Items["buttonItemEdit"].Enabled) return;
                SicknessDetailAdd_Frm SicknessDetailAdd = new SicknessDetailAdd_Frm(byte.Parse(GridViewSicknessDetail.CurrentRow.Cells["Id"].Value.ToString()));
                if (SicknessDetailAdd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    BindData(GridViewSicknessDetail.Row);
            }
            catch { }
        }

        private void headerGridSicknessDetail_btnDeleteClick(object sender, System.EventArgs e)
        {
            if (MKH.Library.Clasess.MSSMessage.MSSMessage_View(0,MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation,true, "آیا به حذف این مورد اطمینان دارید؟"))
            {
                try
                {
                    List<TBL_SicknessDetail> Ls = new List<TBL_SicknessDetail>();
                    TBL_SicknessDetail SicknessDetail = new TBL_SicknessDetail();
                    SicknessDetail.Id = short.Parse(GridViewSicknessDetail.CurrentRow.Cells["Id"].Value.ToString());
                    SicknessDetail.TitleName = GridViewSicknessDetail.CurrentRow.Cells["TitleName"].Value.ToString();
                    Ls.Add(SicknessDetail);


                    string str = "";
                    new ViewModel.VisitPatient.SicknessDetail().DeleteEntity(Ls, ref str);
                    if (str != "") MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "امکان حذف این مورد در سیستم وجود ندارد", str);
                    else
                        BindData(GridViewSicknessDetail.Row);
                }
                catch (System.Exception ex)
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "امکان حذف این مورد در سیستم وجود ندارد", ex.Message);
                }
            }
            
        }

        private void headerGridSicknessDetail_btnRefreshClick(object sender, System.EventArgs e)
        {
            BindData(GridViewSicknessDetail.Row);
        }

        #endregion

        private void SicknessDetail_Frm_Load(object sender, System.EventArgs e)
        {
            new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionControl(this);
            BindData(0);
        }


    }
}
