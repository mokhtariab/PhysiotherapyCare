using System.Linq;
using System.Collections.Generic;
using PhysiotherapyCare.Model;
using PhysiotherapyCare.ViewModel;

namespace PhysiotherapyCare.View.MainForms.PatientStatusCare
{
    public partial class PatientStatusCare_UC : System.Windows.Forms.UserControl
    {
        int _visitPatientCare_Id = 0;
        public PatientStatusCare_UC()
        {
            InitializeComponent();
        }
       

        public void BindData(int VisitPatientCare_Id)
        {
            string str = "";
            GridViewPatientStatusCare.DataSource = new PhysiotherapyCare.ViewModel.PatientStatusCares.PatientStatusCare().GetAllListByVPId(VisitPatientCare_Id, ref str);
            _visitPatientCare_Id = VisitPatientCare_Id;
        }

        
        #region All UI Button

        private void headerGridPatientStatusCare_btnInsertClick(object sender, System.EventArgs e)
        {
            PatientStatusCareAdd_Frm PatientStatusCareAdd = new PatientStatusCareAdd_Frm(_visitPatientCare_Id);
            if (PatientStatusCareAdd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                BindData(_visitPatientCare_Id);

                try { GridViewPatientStatusCare.Row = GridViewPatientStatusCare.RowCount; }
                catch { }
            }
        }

        private void headerGridPatientStatusCare_btnEditClick(object sender, System.EventArgs e)
        {
            try
            {
                PatientStatusCareAdd_Frm PatientStatusCareAdd = new PatientStatusCareAdd_Frm(_visitPatientCare_Id, int.Parse(GridViewPatientStatusCare.CurrentRow.Cells["Id"].Value.ToString()));
                PatientStatusCareAdd.ShowDialog();

                int i = GridViewPatientStatusCare.Row;
                BindData(_visitPatientCare_Id);

                try { GridViewPatientStatusCare.Row = i; }
                catch { }
            }
            catch { }
        }

        private void headerGridPatientStatusCare_btnDeleteClick(object sender, System.EventArgs e)
        {
            if (MKH.Library.Clasess.MSSMessage.MSSMessage_View(0,MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation,true, "آیا به حذف این مورد اطمینان دارید؟"))
            {
                try
                {
                    List<TBL_PatientStatusCare> Ls = new List<TBL_PatientStatusCare>();
                    TBL_PatientStatusCare PatientStatusCare = new TBL_PatientStatusCare();
                    PatientStatusCare.Id = int.Parse(GridViewPatientStatusCare.CurrentRow.Cells["Id"].Value.ToString());
                    Ls.Add(PatientStatusCare);


                    string str = "";
                    new ViewModel.PatientStatusCares.PatientStatusCare().DeleteEntity(Ls, ref str);

                    if (str != "") MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "امکان حذف این مورد در سیستم وجود ندارد", str);
                    else
                    {
                        int i = GridViewPatientStatusCare.Row;
                        BindData(_visitPatientCare_Id);
                        try { GridViewPatientStatusCare.Row = i - 1; }
                        catch { }
                    }
                }
                catch (System.Exception ex)
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "امکان حذف این مورد در سیستم وجود ندارد", ex.Message);
                }
            }
        }

        private void headerGridPatientStatusCare_btnRefreshClick(object sender, System.EventArgs e)
        {
            int i = GridViewPatientStatusCare.Row;
            BindData(_visitPatientCare_Id);

            try { GridViewPatientStatusCare.Row = i; }
            catch { }
        }

        #endregion

        private void PatientStatusCare_UC_Load(object sender, System.EventArgs e)
        {
            new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionControl(this);
            BindData(_visitPatientCare_Id);

            try { GridViewPatientStatusCare.Row = 0; }
            catch { }
        }



    }
}
