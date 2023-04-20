using System.Linq;
using System.Collections.Generic;
using PhysiotherapyCare.Model.Basic;
using PhysiotherapyCare.ViewModel;

namespace PhysiotherapyCare.View.BaseForms
{
    public partial class InjuryType_Frm : System.Windows.Forms.Form
    {
        public InjuryType_Frm()
        {
            InitializeComponent();
        }

        public void BindData(int RowNumberSet)
        {
            string str = "";
            GridViewInjuryType.DataSource = new PhysiotherapyCare.ViewModel.Basic.InjuryType().GetAllList(ref str);

            try { GridViewInjuryType.Row = RowNumberSet; }
            catch { }
        }

        
        #region All UI Button

        private void headerGridInjuryType_btnInsertClick(object sender, System.EventArgs e)
        {
            InjuryTypeAdd_Frm InjuryTypeAdd = new InjuryTypeAdd_Frm();
            if (InjuryTypeAdd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                BindData(GridViewInjuryType.RowCount);
        }

        private void headerGridInjuryType_btnEditClick(object sender, System.EventArgs e)
        {
            try
            {
                if (!(HeaderGridInjuryType as MKH.Library.Control.MSSHeaderGrid).Items["buttonItemEdit"].Visible || !(HeaderGridInjuryType as MKH.Library.Control.MSSHeaderGrid).Items["buttonItemEdit"].Enabled) return;
                InjuryTypeAdd_Frm InjuryTypeAdd = new InjuryTypeAdd_Frm(byte.Parse(GridViewInjuryType.CurrentRow.Cells["Id"].Value.ToString()));
                if (InjuryTypeAdd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    BindData(GridViewInjuryType.Row);
            }
            catch { }
        }

        private void headerGridInjuryType_btnDeleteClick(object sender, System.EventArgs e)
        {
            if (MKH.Library.Clasess.MSSMessage.MSSMessage_View(0,MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation,true, "آیا به حذف این مورد اطمینان دارید؟"))
            {
                try
                {
                    List<TBL_InjuryType> Ls = new List<TBL_InjuryType>();
                    TBL_InjuryType InjuryType = new TBL_InjuryType();
                    InjuryType.Id = short.Parse(GridViewInjuryType.CurrentRow.Cells["Id"].Value.ToString());
                    InjuryType.TitleName = GridViewInjuryType.CurrentRow.Cells["TitleName"].Value.ToString();
                    Ls.Add(InjuryType);


                    string str = "";
                    new ViewModel.Basic.InjuryType().DeleteEntity(Ls, ref str);
                    if (str != "") MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "امکان حذف این مورد در سیستم وجود ندارد", str);
                    else
                        BindData(GridViewInjuryType.Row - 1);
                }
                catch (System.Exception ex)
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "امکان حذف این مورد در سیستم وجود ندارد", ex.Message);
                }
            }
        }

        private void headerGridInjuryType_btnRefreshClick(object sender, System.EventArgs e)
        {
            BindData(GridViewInjuryType.Row);
        }

        #endregion

        private void InjuryType_Frm_Load(object sender, System.EventArgs e)
        {
            new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionControl(this);
            BindData(0);
        }


    }
}
