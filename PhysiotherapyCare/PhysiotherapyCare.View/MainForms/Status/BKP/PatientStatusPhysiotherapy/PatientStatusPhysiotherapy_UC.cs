using System.Linq;
using System.Collections.Generic;
using PhysiotherapyCare.Model.PatientStatusPhysiotherapy;
using PhysiotherapyCare.ViewModel.PatientStatusPhysiotherapys;
using System.Windows.Forms;

namespace PhysiotherapyCare.View.MainForms.PatientStatusPhysiotherapy
{
    public partial class PatientStatusPhysiotherapy_UC : UserControl
    {
        public int _visitPatientPhysiotherapy_Id = 0;
        public PatientStatusPhysiotherapy_UC()
        {
            InitializeComponent();
        }
        public PatientStatusPhysiotherapy_UC(int visitPatientPhysiotherapy_Id)
        {
            InitializeComponent();
            _visitPatientPhysiotherapy_Id = visitPatientPhysiotherapy_Id;
        }

        public void BindData(int RowNumberSet)
        {
            string str = "";
            GridViewPatientStatusPhysiotherapy.DataSource = new PhysiotherapyCare.ViewModel.PatientStatusPhysiotherapys.PatientStatusPhysiotherapy().GetAllListByVPId(_visitPatientPhysiotherapy_Id, ref str);

            try { GridViewPatientStatusPhysiotherapy.Row = RowNumberSet; }
            catch { }
        }

        
        #region All UI Button

        private void headerGridPatientStatusPhysiotherapy_btnInsertClick(object sender, System.EventArgs e)
        {
            PatientStatusPhysiotherapyAdd_Frm PatientStatusPhysiotherapyAdd = new PatientStatusPhysiotherapyAdd_Frm(_visitPatientPhysiotherapy_Id);
            if (PatientStatusPhysiotherapyAdd.ShowDialog() == DialogResult.OK)
                BindData(GridViewPatientStatusPhysiotherapy.RowCount);
        }

        private void headerGridPatientStatusPhysiotherapy_btnEditClick(object sender, System.EventArgs e)
        {
            try
            {
                PatientStatusPhysiotherapyAdd_Frm PatientStatusPhysiotherapyAdd = new PatientStatusPhysiotherapyAdd_Frm(_visitPatientPhysiotherapy_Id, int.Parse(GridViewPatientStatusPhysiotherapy.CurrentRow.Cells["Id"].Value.ToString()));
                PatientStatusPhysiotherapyAdd.ShowDialog();
                BindData(GridViewPatientStatusPhysiotherapy.Row);
            }
            catch { }
        }

        private void headerGridPatientStatusPhysiotherapy_btnDeleteClick(object sender, System.EventArgs e)
        {
            if (MKH.Library.Clasess.MSSMessage.MSSMessage_View(0,MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation,true, "آیا به حذف این مورد اطمینان دارید؟"))
            {
                try
                {
                    List<TBL_PatientStatusPhysiotherapy> Ls = new List<TBL_PatientStatusPhysiotherapy>();
                    TBL_PatientStatusPhysiotherapy PatientStatusPhysiotherapy = new TBL_PatientStatusPhysiotherapy();
                    PatientStatusPhysiotherapy.Id = int.Parse(GridViewPatientStatusPhysiotherapy.CurrentRow.Cells["Id"].Value.ToString());
                    Ls.Add(PatientStatusPhysiotherapy);


                    string str = "";
                    new ViewModel.PatientStatusPhysiotherapys.PatientStatusPhysiotherapy().DeleteEntity(Ls, ref str);
                    if (str != "") MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "امکان حذف این مورد در سیستم وجود ندارد", str);
                    else
                        BindData(GridViewPatientStatusPhysiotherapy.Row - 1);
                }
                catch (System.Exception ex)
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "امکان حذف این مورد در سیستم وجود ندارد", ex.Message);
                }
            }
        }

        private void headerGridPatientStatusPhysiotherapy_btnRefreshClick(object sender, System.EventArgs e)
        {
            BindData(GridViewPatientStatusPhysiotherapy.Row);
        }

        #endregion

        private void PatientStatusPhysiotherapy_UC_Load(object sender, System.EventArgs e)
        {
            new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionControl(this);
            BindData(0);
        }



    }
}
