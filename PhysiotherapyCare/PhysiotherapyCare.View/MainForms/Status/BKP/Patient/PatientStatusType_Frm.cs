using System.Linq;
using System.Collections.Generic;
using PhysiotherapyCare.Model.Basic;
using PhysiotherapyCare.ViewModel;

namespace PhysiotherapyCare.View.BaseForms
{
    public partial class PatientStatusType_Frm : System.Windows.Forms.Form
    {
        public PatientStatusType_Frm()
        {
            InitializeComponent();
        }

        public void BindData(int RowNumberSet)
        {
            string str = "";
            GridViewPatientStatusType.DataSource = new PhysiotherapyCare.ViewModel.Basic.PatientStatusType().GetAllList(ref str);

            try { GridViewPatientStatusType.Row = RowNumberSet; }
            catch { }
        }

        
        #region All UI Button

        private void headerGridPatientStatusType_btnInsertClick(object sender, System.EventArgs e)
        {
            PatientStatusTypeAdd_Frm PatientStatusTypeAdd = new PatientStatusTypeAdd_Frm();
            if (PatientStatusTypeAdd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                BindData(GridViewPatientStatusType.RowCount);
        }

        private void headerGridPatientStatusType_btnEditClick(object sender, System.EventArgs e)
        {
            try
            {
                PatientStatusTypeAdd_Frm PatientStatusTypeAdd = new PatientStatusTypeAdd_Frm(byte.Parse(GridViewPatientStatusType.CurrentRow.Cells["Id"].Value.ToString()));
                PatientStatusTypeAdd.ShowDialog();
                BindData(GridViewPatientStatusType.Row);
            }
            catch { }
        }

        private void headerGridPatientStatusType_btnDeleteClick(object sender, System.EventArgs e)
        {
            if (MKH.Library.Clasess.MSSMessage.MSSMessage_View(0,MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation,true, "آیا به حذف این مورد اطمینان دارید؟"))
            {
                try
                {
                    List<TBL_PatientStatusType> Ls = new List<TBL_PatientStatusType>();
                    TBL_PatientStatusType PatientStatusType = new TBL_PatientStatusType();
                    PatientStatusType.Id = short.Parse(GridViewPatientStatusType.CurrentRow.Cells["Id"].Value.ToString());
                    PatientStatusType.TitleName = GridViewPatientStatusType.CurrentRow.Cells["TitleName"].Value.ToString();
                    Ls.Add(PatientStatusType);


                    string str = "";
                    new ViewModel.Basic.PatientStatusType().DeleteEntity(Ls, ref str);
                    if (str != "") MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "امکان حذف این مورد در سیستم وجود ندارد", str);
                    else
                        BindData(GridViewPatientStatusType.Row - 1);
                }
                catch (System.Exception ex)
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "امکان حذف این مورد در سیستم وجود ندارد", ex.Message);
                }
            }
            
        }

        private void headerGridPatientStatusType_btnRefreshClick(object sender, System.EventArgs e)
        {
            BindData(GridViewPatientStatusType.Row);
        }

        #endregion

        private void PatientStatusType_Frm_Load(object sender, System.EventArgs e)
        {
            new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionControl(this);
            BindData(0);
        }


    }
}
