using System.Linq;
using System.Collections.Generic;
using PhysiotherapyCare.Model.Basic;
using PhysiotherapyCare.ViewModel;

namespace PhysiotherapyCare.View.BaseForms
{
    public partial class DoctorType_Frm : System.Windows.Forms.Form
    {
        public DoctorType_Frm()
        {
            InitializeComponent();
        }

        public void BindData(int RowNumberSet)
        {
            string str = "";
            GridViewDoctorType.DataSource = new PhysiotherapyCare.ViewModel.Basic.DoctorType().GetAllList(ref str);

            try { GridViewDoctorType.Row = RowNumberSet; }
            catch { }
        }

        
        #region All UI Button

        private void headerGridDoctorType_btnInsertClick(object sender, System.EventArgs e)
        {
            DoctorTypeAdd_Frm DoctorTypeAdd = new DoctorTypeAdd_Frm();
            if (DoctorTypeAdd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                BindData(GridViewDoctorType.RowCount);
        }

        private void headerGridDoctorType_btnEditClick(object sender, System.EventArgs e)
        {
            try
            {
                if (!(HeaderGridDoctorType as MKH.Library.Control.MSSHeaderGrid).Items["buttonItemEdit"].Visible || !(HeaderGridDoctorType as MKH.Library.Control.MSSHeaderGrid).Items["buttonItemEdit"].Enabled) return;
                DoctorTypeAdd_Frm DoctorTypeAdd = new DoctorTypeAdd_Frm(byte.Parse(GridViewDoctorType.CurrentRow.Cells["Id"].Value.ToString()));
                if (DoctorTypeAdd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    BindData(GridViewDoctorType.Row);
            }
            catch { }
        }

        private void headerGridDoctorType_btnDeleteClick(object sender, System.EventArgs e)
        {
            if (MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation, true, "آیا به حذف این مورد اطمینان دارید؟"))
            {
                try
                {
                    List<TBL_DoctorType> Ls = new List<TBL_DoctorType>();
                    TBL_DoctorType DoctorType = new TBL_DoctorType();
                    DoctorType.Id = short.Parse(GridViewDoctorType.CurrentRow.Cells["Id"].Value.ToString());
                    DoctorType.TitleName = GridViewDoctorType.CurrentRow.Cells["TitleName"].Value.ToString();
                    Ls.Add(DoctorType);


                    string str = "";
                    new ViewModel.Basic.DoctorType().DeleteEntity(Ls, ref str);
                    if (str != "") MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "امکان حذف این مورد در سیستم وجود ندارد", str);
                    else
                        BindData(GridViewDoctorType.Row - 1);
                }
                catch (System.Exception ex)
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "امکان حذف این مورد در سیستم وجود ندارد", ex.Message);
                }
            }
        }

        private void headerGridDoctorType_btnRefreshClick(object sender, System.EventArgs e)
        {
            BindData(GridViewDoctorType.Row);
        }

        #endregion

        private void DoctorType_Frm_Load(object sender, System.EventArgs e)
        {
            new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionControl(this);
            BindData(0);
        }


    }
}
