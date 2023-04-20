using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MKH.Contacts.Model.GroupTelMob;

namespace MKH.Contacts.View.UserControls
{
    public partial class PersonGroupList_UC: UserControl
    {
        public PersonGroupList_UC()
        {
            InitializeComponent();
        }

        public void BindData(int RowNumberSet)
        {
            string str = "";
            GridViewGroupTelMob.DataSource = new ViewModel.GroupTelMob.GroupTelMob().GetAllList(ref str);
            try { GridViewGroupTelMob.Row = RowNumberSet == -3 ? 1 : RowNumberSet; }
            catch { }
        }


        #region All UI Button

        private void headerGridGroupTelMob_btnInsertClick(object sender, System.EventArgs e)
        {
            try
            {
                Forms.GroupTelMobAdd_Frm FFA = new Forms.GroupTelMobAdd_Frm();
                if (FFA.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    BindData(GridViewGroupTelMob.RowCount);
            }
            catch { }
        }

        private void headerGridGroupTelMob_btnEditClick(object sender, System.EventArgs e)
        {
            try
            {
                if (!(HeaderGridGroupTelMob as MKH.Library.Control.MSSHeaderGrid).Items["buttonItemEdit"].Visible || !(HeaderGridGroupTelMob as MKH.Library.Control.MSSHeaderGrid).Items["buttonItemEdit"].Enabled) return;
                
                Forms.GroupTelMobAdd_Frm FFA = new Forms.GroupTelMobAdd_Frm(int.Parse(GridViewGroupTelMob.CurrentRow.Cells["Id"].Value.ToString()));
                if (FFA.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    BindData(GridViewGroupTelMob.Row);
            }
            catch { }
        }

        private void headerGridGroupTelMob_btnDeleteClick(object sender, System.EventArgs e)
        {
            if (MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation, true, "آیا به حذف این مورد اطمینان دارید؟"))
            {
                try
                {
                    List<TBL_GroupTelMob> Ls = new List<TBL_GroupTelMob>();
                    TBL_GroupTelMob GroupTelMob = new TBL_GroupTelMob();
                    GroupTelMob.Id = int.Parse(GridViewGroupTelMob.CurrentRow.Cells["Id"].Value.ToString());
                    Ls.Add(GroupTelMob);

                    string str = "";
                    new ViewModel.GroupTelMob.GroupTelMob().DeleteEntity(Ls, ref str);
                    if (str != "")
                        MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "امکان حذف این مورد در سیستم وجود ندارد", str);
                    else
                        BindData(GridViewGroupTelMob.Row - 1);

                }
                catch (Exception ex)
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "امکان حذف این مورد در سیستم وجود ندارد", ex.Message);
                }
            }
        }

        private void headerGridGroupTelMob_btnRefreshClick(object sender, System.EventArgs e)
        {
            int i = GridViewGroupTelMob.Row;
            BindData(i);
        }

        #endregion

        private void PersonGroupList_UC_Load(object sender, System.EventArgs e)
        {
            BindData(-3);
        }

        private void GridViewGroupTelMob_SelectionChanged(object sender, System.EventArgs e)
        {
            personTelMob_UC1.BindData(int.Parse(GridViewGroupTelMob.CurrentRow.Cells["Id"].Value.ToString()),-3);
        }
    }
}
