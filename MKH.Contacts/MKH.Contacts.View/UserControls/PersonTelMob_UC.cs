using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using MKH.Contacts.Model.PersonTelMob;
using MKH.Library.Clasess.FilterClass;



namespace MKH.Contacts.View.UserControls
{
    public partial class PersonTelMob_UC : System.Windows.Forms.UserControl
    {
        public PersonTelMob_UC()
        {
            InitializeComponent();
        }
        
        int _group_ID = 0;

        public void BindData(int Group_ID, int RowNumberSet)
        {
            string str = "";

            GridexViewPersonTelMob.DataSource = new ViewModel.PersonTelMob.PersonTelMob().GetAllListByGroupID(Group_ID, ref str);
            _group_ID = Group_ID;

            try { GridexViewPersonTelMob.Row = RowNumberSet == -3 ? 1 : RowNumberSet; }
            catch { }
        }


        #region All UI Button

        private void headerGridPersonTelMob_btnInsertClick(object sender, System.EventArgs e)
        {
            try
            {
                Forms.PersonTelMobAdd_Frm FFA = new Forms.PersonTelMobAdd_Frm();
                if (FFA.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    BindData(_group_ID, GridexViewPersonTelMob.RowCount);
            }
            catch { }
        }

        private void headerGridPersonTelMob_btnEditClick(object sender, System.EventArgs e)
        {
            try
            {
                if (!(HeaderGridPersonTelMob as MKH.Library.Control.MSSHeaderGrid).Items["buttonItemEdit"].Visible || !(HeaderGridPersonTelMob as MKH.Library.Control.MSSHeaderGrid).Items["buttonItemEdit"].Enabled) return;
                
                Forms.PersonTelMobAdd_Frm FFA = new Forms.PersonTelMobAdd_Frm(int.Parse(GridexViewPersonTelMob.CurrentRow.Cells["Id"].Value.ToString()));
                if (FFA.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    BindData(_group_ID, GridexViewPersonTelMob.Row);
            }
            catch { }
        }

        private void headerGridPersonTelMob_btnDeleteClick(object sender, System.EventArgs e)
        {
            if (MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation, true, "آیا به حذف این مورد اطمینان دارید؟"))
            {
                try
                {
                    List<TBL_PersonTelMob> Ls = new List<TBL_PersonTelMob>();
                    TBL_PersonTelMob PersonTelMob = new TBL_PersonTelMob();
                    PersonTelMob.Id = int.Parse(GridexViewPersonTelMob.CurrentRow.Cells["Id"].Value.ToString());
                    Ls.Add(PersonTelMob);

                    string str = "";
                    new ViewModel.PersonTelMob.PersonTelMob().DeleteEntity(Ls, ref str);

                    if (str != "")
                        MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "امکان حذف این مورد در سیستم وجود ندارد", str);
                    else
                        BindData(_group_ID, GridexViewPersonTelMob.Row - 1);
                }
                catch
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View("امکان حذف این مورد در سیستم وجود ندارد", MKH.Library.Clasess.MSSMessage.MessageType.SError);
                }
            }
        }

        private void headerGridPersonTelMob_btnRefreshClick(object sender, System.EventArgs e)
        {
            int i = GridexViewPersonTelMob.Row;
            BindData(_group_ID, i);
        }

        #endregion

        private void PersonTelMobList_UC_Load(object sender, System.EventArgs e)
        {
            try { BindData(_group_ID, -3); }
            catch { }
        }

        private void GridexViewPersonTelMob_SelectionChanged(object sender, System.EventArgs e)
        {
            try
            {
                string str = "";
                PictureBoxPic.Image = System.Drawing.Image.FromStream(new System.IO.MemoryStream(((byte[])(new ViewModel.PersonTelMob.PersonTelMob().GetAllListByIDPic(int.Parse(GridexViewPersonTelMob.CurrentRow.Cells["Id"].Value.ToString()), ref str).Single().PersonPic.ToArray()))));
            }
            catch
            {
                PictureBoxPic.Image = null;
            }

        }

        private void buttonItemSendSMS_Click(object sender, EventArgs e)
        {
            List<MKH.Library.Clasess.PublicClass.AllPersonForSMS> ListForSelectPerson = new List<MKH.Library.Clasess.PublicClass.AllPersonForSMS>();
            for (int i = 0; i < GridexViewPersonTelMob.SelectedItems.Count; i++)
            {
                if (((GridexViewPersonTelMob.SelectedItems[i].GetRow().Cells["Mobile"].Value ?? "").ToString().StartsWith("09") && (GridexViewPersonTelMob.SelectedItems[i].GetRow().Cells["Mobile"].Value ?? "").ToString().Length == 11) ||
                   ((GridexViewPersonTelMob.SelectedItems[i].GetRow().Cells["Mobile2"].Value ?? "").ToString().StartsWith("09") && (GridexViewPersonTelMob.SelectedItems[i].GetRow().Cells["Mobile2"].Value ?? "").ToString().Length == 11))
                {
                    try
                    {
                        MKH.Library.Clasess.PublicClass.AllPersonForSMS ssss = new MKH.Library.Clasess.PublicClass.AllPersonForSMS();
                        ssss.PersonNameFamily = (GridexViewPersonTelMob.SelectedItems[i].GetRow().Cells["FirstName"].Value ?? "").ToString() + " " +
                                                (GridexViewPersonTelMob.SelectedItems[i].GetRow().Cells["LastName"].Value ?? "").ToString();
                        ssss.JobType = (GridexViewPersonTelMob.SelectedItems[i].GetRow().Cells["GroupName"].Value ?? "").ToString();
                        ssss.MobileNo1 = (GridexViewPersonTelMob.SelectedItems[i].GetRow().Cells["Mobile"].Value ?? "").ToString() == "" ? (GridexViewPersonTelMob.SelectedItems[i].GetRow().Cells["Mobile2"].Value ?? "").ToString() : (GridexViewPersonTelMob.SelectedItems[i].GetRow().Cells["Mobile"].Value ?? "").ToString();
                        ssss.MobileNo2 = (GridexViewPersonTelMob.SelectedItems[i].GetRow().Cells["Mobile2"].Value ?? "").ToString();
                        ListForSelectPerson.Add(ssss);
                    }
                    catch { }
                }
            }

            MKH.SMS.View.Forms.SendSMSAdd_Frm SSA = new MKH.SMS.View.Forms.SendSMSAdd_Frm(ListForSelectPerson);
            SSA.ShowDialog();
        }

    }
}
