using MKH.Contacts.Model.GroupTelMob;
using MKH.Contacts.ViewModel.GroupTelMob;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace MKH.Contacts.View.Forms
{
    public partial class GroupTelMobAdd_Frm: MKH.Library.Forms.MSSBaseNew_frm
    {
        private int _id = 0;
        private bool _editIns = false;


        public GroupTelMobAdd_Frm()
        {
            InitializeComponent();
        }


        public GroupTelMobAdd_Frm(int Id)
        {
            InitializeComponent();
            _id = Id;
            _editIns = true;
        }

        private void GroupTelMobAdd_Frm_Load(object sender, EventArgs e)
        {
            if (_editIns) fillControl();
        }

        private void fillControl()
        {
            string str = "";
            GroupTelMob RN = new GroupTelMob();
            List<VW_GroupTelMob> LS = RN.GetAllListByID(_id, ref str);

            TextBoxGroupName.Text = LS[0].GroupName;
            CheckBoxActive.Checked = LS[0].Active.Value;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckValidation())
                return;
            try
            {
                string str = ""; int? idSet = 0;
                List<TBL_GroupTelMob> Ls = new List<TBL_GroupTelMob>(1);
                TBL_GroupTelMob GroupTelMob = new TBL_GroupTelMob();

                GroupTelMob.Id = _id;
                GroupTelMob.GroupName = TextBoxGroupName.Text;
                GroupTelMob.Active = CheckBoxActive.Checked;
                Ls.Add(GroupTelMob);

                if (!_editIns)
                {
                    new GroupTelMob().InsertEntity(Ls, ref str, ref idSet);
                }
                else
                {
                    new GroupTelMob().UpdateEntity(Ls, ref str);
                }
                if (str != "")
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "اشکال اطلاعات", str);
                else
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View("اطلاعات ذخیره شد", MKH.Library.Clasess.MSSMessage.MessageType.SInformation);
                    DialogResult = System.Windows.Forms.DialogResult.OK;
                    Close();
                }
            }
            catch (Exception ex)
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, ex.Message);
            }

        }



        private bool CheckValidation()
        {
            if (TextBoxGroupName.Text.Trim() == "")
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("لطفا نام گروه را پر نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                return false;
            }
            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
