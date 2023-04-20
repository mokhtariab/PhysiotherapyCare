using System.Linq;
using System.Collections.Generic;
using PhysiotherapyCare.Model.Basic;
using PhysiotherapyCare.ViewModel;

namespace PhysiotherapyCare.View.BaseForms
{
    public partial class Bank_Frm : System.Windows.Forms.Form
    {
        public Bank_Frm()
        {
            InitializeComponent();
        }

        public void BindData(int RowNumberSet)
        {
            string str = "";
            GridViewBank.DataSource = new PhysiotherapyCare.ViewModel.Basic.Bank().GetAllList(ref str);

            try { GridViewBank.Row = RowNumberSet; }
            catch { }
        }

        
        #region All UI Button

        private void headerGridBank_btnInsertClick(object sender, System.EventArgs e)
        {
            BankAdd_Frm BankAdd = new BankAdd_Frm();
            if (BankAdd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                BindData(GridViewBank.RowCount);
        }

        private void headerGridBank_btnEditClick(object sender, System.EventArgs e)
        {
            try
            {
                if (!(HeaderGridBank as MKH.Library.Control.MSSHeaderGrid).Items["buttonItemEdit"].Visible || !(HeaderGridBank as MKH.Library.Control.MSSHeaderGrid).Items["buttonItemEdit"].Enabled) return;
                BankAdd_Frm BankAdd = new BankAdd_Frm(byte.Parse(GridViewBank.CurrentRow.Cells["Id"].Value.ToString()));
                if (BankAdd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    BindData(GridViewBank.Row);
            }
            catch { }
        }

        private void headerGridBank_btnDeleteClick(object sender, System.EventArgs e)
        {
            if (MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation, true, "آیا به حذف این مورد اطمینان دارید؟"))
            {
                try
                {
                    List<TBL_Bank> Ls = new List<TBL_Bank>();
                    TBL_Bank Bank = new TBL_Bank();
                    Bank.Id = short.Parse(GridViewBank.CurrentRow.Cells["Id"].Value.ToString());
                    Bank.TitleName = GridViewBank.CurrentRow.Cells["TitleName"].Value.ToString();
                    Ls.Add(Bank);


                    string str = "";
                    new ViewModel.Basic.Bank().DeleteEntity(Ls, ref str);
                    if (str != "") MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "امکان حذف این مورد در سیستم وجود ندارد", str);
                    else
                        BindData(GridViewBank.Row - 1);
                }
                catch (System.Exception ex)
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "امکان حذف این مورد در سیستم وجود ندارد", ex.Message);
                }
            }
        }

        private void headerGridBank_btnRefreshClick(object sender, System.EventArgs e)
        {
            BindData(GridViewBank.Row);
        }

        #endregion

        private void Bank_Frm_Load(object sender, System.EventArgs e)
        {
            new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionControl(this);
            BindData(0);
        }


    }
}
