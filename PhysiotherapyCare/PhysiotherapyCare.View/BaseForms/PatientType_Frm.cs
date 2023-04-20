using System.Linq;
using System.Collections.Generic;
using PhysiotherapyCare.Model.Basic;
using PhysiotherapyCare.ViewModel;

namespace PhysiotherapyCare.View.BaseForms
{
    public partial class PatientType_Frm : System.Windows.Forms.Form
    {
        public PatientType_Frm()
        {
            InitializeComponent();
        }

        public void BindData(int RowNumberSet)
        {
            string str = "";
            GridViewPatientType.DataSource = new PhysiotherapyCare.ViewModel.Basic.PatientType().GetAllList(ref str);
            
            try { GridViewPatientType.Row = RowNumberSet; }
            catch { }
        }

        
        #region All UI Button

        private void headerGridPatientType_btnInsertClick(object sender, System.EventArgs e)
        {
            PatientTypeAdd_Frm PatientTypeAdd = new PatientTypeAdd_Frm();
            if (PatientTypeAdd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                BindData(GridViewPatientType.RowCount);
        }

        private void headerGridPatientType_btnEditClick(object sender, System.EventArgs e)
        {
            try
            {
                if (!(HeaderGridPatientType as MKH.Library.Control.MSSHeaderGrid).Items["buttonItemEdit"].Visible || !(HeaderGridPatientType as MKH.Library.Control.MSSHeaderGrid).Items["buttonItemEdit"].Enabled) return;
                PatientTypeAdd_Frm PatientTypeAdd = new PatientTypeAdd_Frm(
                       byte.Parse(GridViewPatientType.CurrentRow.Cells["Id"].Value.ToString()));
                if (PatientTypeAdd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    BindData(GridViewPatientType.Row);
            }
            catch { }
        }

        private void headerGridPatientType_btnDeleteClick(object sender, System.EventArgs e)
        {
            if (MKH.Library.Clasess.MSSMessage.MSSMessage_View(0,MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation,true, "آیا به حذف این مورد اطمینان دارید؟"))
            {
                try
                {
                    List<TBL_PatientType> Ls = new List<TBL_PatientType>();
                    TBL_PatientType PatientType = new TBL_PatientType();
                    PatientType.Id = short.Parse(GridViewPatientType.CurrentRow.Cells["Id"].Value.ToString());
                    PatientType.TitleName = GridViewPatientType.CurrentRow.Cells["TitleName"].Value.ToString();
                    Ls.Add(PatientType);


                    string str = "";
                    new ViewModel.Basic.PatientType().DeleteEntity(Ls, ref str);

                    if (str != "") MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "امکان حذف این مورد در سیستم وجود ندارد", str);
                    else
                        BindData(GridViewPatientType.Row - 1);
                }
                catch (System.Exception ex)
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "امکان حذف این مورد در سیستم وجود ندارد", ex.Message);
                }
            }
        }

        private void headerGridPatientType_btnRefreshClick(object sender, System.EventArgs e)
        {
            BindData(GridViewPatientType.Row);
        }

        #endregion

        private void PatientType_Frm_Load(object sender, System.EventArgs e)
        {
            new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionControl(this);
            BindData(0);
        }


    }
}
