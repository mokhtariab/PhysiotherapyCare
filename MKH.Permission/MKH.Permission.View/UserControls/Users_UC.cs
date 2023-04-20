using System.Linq;
using System.Collections.Generic;
using MKH.Permission.Model.Users;
using System;
using MKH.Library.Clasess;

namespace MKH.Permission.View.UserControls
{
    public partial class Users_UC : System.Windows.Forms.UserControl
    {
        public Users_UC()
        {
            InitializeComponent();
        }

        public void BindData(int RowNumberSet)
        {
            string str = "";

            GridViewUsers.DataSource = new ViewModel.Users.Users().GetAllList(ref str);

            try { GridViewUsers.Row = RowNumberSet; }
            catch { }
        }

        
        #region All UI Button

        private void headerGridUsers_btnInsertClick(object sender, System.EventArgs e)
        {
            Forms.UsersAdd_Frm FFA = new Forms.UsersAdd_Frm();
            if (FFA.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                BindData(GridViewUsers.RowCount);
        }
        private void headerGridUsers_btnEditClick(object sender, System.EventArgs e)
        {
            try
            {
                if (!(HeaderGridUsers as MKH.Library.Control.MSSHeaderGrid).Items["buttonItemEdit"].Visible || !(HeaderGridUsers as MKH.Library.Control.MSSHeaderGrid).Items["buttonItemEdit"].Enabled) return;
                
                Forms.UsersAdd_Frm FFA = new Forms.UsersAdd_Frm(int.Parse(GridViewUsers.CurrentRow.Cells["Id"].Value.ToString()));
                if (FFA.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    BindData(GridViewUsers.Row);
            }
            catch { }
        }

        private void headerGridUsers_btnDeleteClick(object sender, System.EventArgs e)
        {
            if (bool.Parse((GridViewUsers.CurrentRow.Cells["IsAdmin"].Value ?? 0).ToString()))
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("امکان حذف مدیر در سیستم وجود ندارد", MKH.Library.Clasess.MSSMessage.MessageType.SWarning);
                return;
            }
            if (MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation, true, "آیا به حذف این مورد اطمینان دارید؟"))
            {

                try
                {
                    List<TBL_User> Ls = new List<TBL_User>();
                    TBL_User Users = new TBL_User();
                    Users.Id = int.Parse(GridViewUsers.CurrentRow.Cells["Id"].Value.ToString());
                    Ls.Add(Users);

                    string str = "";
                    new ViewModel.Users.Users().DeleteEntity(Ls, ref str);
                    if (str != "")
                        MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "امکان حذف این مورد در سیستم وجود ندارد", str);
                    else
                        BindData(GridViewUsers.Row - 1);
                }
                catch (System.Exception ex)
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "امکان حذف این مورد در سیستم وجود ندارد", ex.Message);
                }
            }

        }

        private void headerGridUsers_btnRefreshClick(object sender, System.EventArgs e)
        {
            BindData(GridViewUsers.Row);
        }

        #endregion

        private void Users_UC_Load(object sender, System.EventArgs e)
        {
            BindData(0);
        }

        private void buttonItemResetPassword_Click(object sender, EventArgs e)
        {
            if (MSSMessage.MSSMessage_View(0, MSSMessage.MessageType.SConfirmation, true, "آیا پسورد شخص مورد نظر ریست شود؟"))
            {
                try
                {
                    string str = "";
                    new ViewModel.Users.Users().UpdatePass(int.Parse(GridViewUsers.CurrentRow.Cells["Id"].Value.ToString()), ref str);

                    if (str != "")
                        MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MSSMessage.MessageType.SError, false, "اشکال", str);
                }
                catch (Exception ex)
                {
                    MSSMessage.MSSMessage_View(0, MSSMessage.MessageType.SError, false, "اشکال در ذخیره اطلاعات", ex.Message);
                }
            }
        }

        private void buttonItemSoftwareUser_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    BaseForms.SoftwareUser_Frm FFA = new BaseForms.SoftwareUser_Frm(
            //        int.Parse(GridViewUsers.CurrentRow.Cells["UserId"].Value.ToString()),
            //        GridViewUsers.CurrentRow.Cells["FullName"].Value.ToString()
            //    );
            //    FFA.ShowDialog();
            //}
            //catch { }
            //BindData();
        }

        private void buttonItemSoftwareAccessUser_Click(object sender, EventArgs e)
        {
            if (bool.Parse((GridViewUsers.CurrentRow.Cells["IsAdmin"].Value ?? 0).ToString()))
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("امکان دسترسی جهت مدیر وجود ندارد", MKH.Library.Clasess.MSSMessage.MessageType.SWarning);
                return;
            }

            try
            {
                BaseForms.SoftwareAccessUser_Frm FFA = new BaseForms.SoftwareAccessUser_Frm(
                    0,
                    int.Parse(GridViewUsers.CurrentRow.Cells["Id"].Value.ToString()),
                    GridViewUsers.CurrentRow.Cells["Name"].Value.ToString() + " " + GridViewUsers.CurrentRow.Cells["Family"].Value.ToString()
                    );
                if (FFA.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    BindData(GridViewUsers.Row);
            }
            catch { }
        }

        private void buttonItemSoftwareRoleUser_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    BaseForms.SoftwareRoleUser_Frm FFA = new BaseForms.SoftwareRoleUser_Frm(
            //        int.Parse(GridViewUsers.CurrentRow.Cells["Software_Id"].Value.ToString()),
            //        int.Parse(GridViewUsers.CurrentRow.Cells["UserId"].Value.ToString()),
            //        GridViewUsers.CurrentRow.Cells["FullName"].Value.ToString()
            //        );

            //    FFA.ShowDialog();
            //}
            //catch { }
            //BindData();
        }

        private void GridViewUsers_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                string str = "";
                PictureBoxUserPic.Image = System.Drawing.Image.FromStream(new System.IO.MemoryStream(((byte[])(new ViewModel.Users.Users().GetAllListByIDPic(int.Parse(GridViewUsers.CurrentRow.Cells["Id"].Value.ToString()), ref str).Single().UserPic.ToArray()))));
            }
            catch
            {
                PictureBoxUserPic.Image = null;
            }
        }

    }
}
