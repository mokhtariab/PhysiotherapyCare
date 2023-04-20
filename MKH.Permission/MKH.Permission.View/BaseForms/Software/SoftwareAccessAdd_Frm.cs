using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using MKH.Permission.Model.SoftwareAccess;


namespace MKH.Permission.View.BaseForms
{
    public partial class SoftwareAccessAdd_Frm : MKH.Library.Forms.MSSBaseNew_frm
    {
        private int _id = 0, _software_Id = 0, _parentId = 0, _resourceLevel = 0;
        private bool _editIns = false;

        public SoftwareAccessAdd_Frm(int Software_Id, int ParentId, int ResourceLevel)
        {
            InitializeComponent();
            _software_Id = Software_Id;
            _parentId = ParentId;
            _resourceLevel = ResourceLevel;
        }

        public SoftwareAccessAdd_Frm(int Id, int Software_Id, int ParentId, int ResourceLevel)
        {
            InitializeComponent();
            _id = Id;
            _software_Id = Software_Id;
            _parentId = ParentId;
            _resourceLevel = ResourceLevel;

            string str = "";
            _editIns = true;
            textBoxResourceNameFarsi.Text = new ViewModel.SoftwareAccess.SoftwareAccess().GetAllListByID(Id, ref str)[0].ResourceNameFarsi;
            TextBoxResourceName.Text = new ViewModel.SoftwareAccess.SoftwareAccess().GetAllListByID(Id, ref str)[0].ResourceName;
            checkBoxIsActive.Checked = new ViewModel.SoftwareAccess.SoftwareAccess().GetAllListByID(Id, ref str)[0].IsActive.Value;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckValidation())
                return;
            try
            {
                string str = ""; int? idSet = 0;
                List<TBL_SoftwareAccess> Ls = new List<TBL_SoftwareAccess>(1);
                TBL_SoftwareAccess SoftwareAccess = new TBL_SoftwareAccess();
                SoftwareAccess.Id = _id;
                SoftwareAccess.ParentId = _parentId;
                SoftwareAccess.ResourceLevel = _resourceLevel;
                SoftwareAccess.ResourceNameFarsi = textBoxResourceNameFarsi.Text;
                SoftwareAccess.ResourceName = TextBoxResourceName.Text;
                SoftwareAccess.IsActive = checkBoxIsActive.Checked;
                Ls.Add(SoftwareAccess);

                if (!_editIns)
                {
                    new ViewModel.SoftwareAccess.SoftwareAccess().InsertEntity(Ls, ref str, ref idSet);
                }
                else
                {
                    new ViewModel.SoftwareAccess.SoftwareAccess().UpdateEntity(Ls, ref str);
                }

                if (str != "")
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "اشکال اطلاعات", str);
                else
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View("اطلاعات ذخیره شد", MKH.Library.Clasess.MSSMessage.MessageType.SInformation);

                    Close();
                }
            }
            catch (Exception ex)
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "اشکال در ذخیره اطلاعات", ex.Message);
            }
        }


        private bool CheckValidation()
        {
            if (textBoxResourceNameFarsi.Text.Trim() == "")
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("جای خالی را پر نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SInformation);
                return false;
            }
            if (TextBoxResourceName.Text.Trim() == "")
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("جای خالی را پر نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SInformation);
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
