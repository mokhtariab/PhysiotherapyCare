using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using MKH.Contacts.ViewModel.PersonTelMob;
using MKH.Contacts.Model.PersonTelMob;
using MKH.Library.Clasess.Filing;
using MKH.Contacts.Model.GroupPerson;
using MKH.Contacts.ViewModel.GroupPerson;


namespace MKH.Contacts.View.Forms
{
    public partial class PersonTelMobAdd_Frm : MKH.Library.Forms.MSSBaseNew_frm
    {
        private int _id = 0;
        private bool _editIns = false;


        public PersonTelMobAdd_Frm()
        {
            InitializeComponent();
        }


        public PersonTelMobAdd_Frm(int Id)
        {
            InitializeComponent();
            _id = Id;
            _editIns = true;
        }

        private void PersonTelMobAdd_Frm_Load(object sender, EventArgs e)
        {
            DatePickerBrithDate.Value = KagNetComponents2.KagPersianDate.Now;

            string str = "";
            if (itemPanelGroup.Items.Count == 0)
                foreach (var item in new ViewModel.GroupTelMob.GroupTelMob().GetAllList(ref str))
                {
                    if (item.Id == 0) continue;
                    DevComponents.DotNetBar.CheckBoxItem Ch = new DevComponents.DotNetBar.CheckBoxItem();
                    Ch.Name = item.Id.ToString();
                    Ch.Text = item.GroupName;
                    Ch.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.CheckBox;
                    itemPanelGroup.Items.Add(Ch);
                    itemPanelGroup.Refresh();
                }


            if (_editIns) fillControl();
        }

        private void fillControl()
        {
            string str = "";
            PersonTelMob RN = new PersonTelMob();
            List<VW_PersonTelMob> LS = RN.GetAllListByID(_id, ref str);

            try {
                PictureBoxPersonTelMobPic.Image = Image.FromStream(
                    new System.IO.MemoryStream(((byte[])(RN.GetAllListByIDPic(_id, ref str)[0].PersonPic))));
            }
            catch { }

            TextBoxPersonTelMobName.Text = LS[0].FirstName;
            TextBoxPersonTelMobFamily.Text = LS[0].LastName;
            TextBoxParentName.Text = LS[0].ParentName;
            TextBoxIDNO.Text = LS[0].IDNO;
            TextBoxNationalCode.Text = LS[0].NationalCode;
            try { DatePickerBrithDate.Value = KagNetComponents2.KagPersianDate.Parse(LS[0].BrithDate); }
            catch { }
            TextBoxBrithCityName.Text = LS[0].BrithCityName;
            TextBoxTelHome.Text = LS[0].TelHome;
            TextBoxTelBusiness.Text = LS[0].TelBusiness;
            TextBoxMobile.Text = LS[0].Mobile;
            TextBoxMobile2.Text = LS[0].Mobile2;
            TextBoxEmail.Text = LS[0].Email;
            TextBoxAddress.Text = LS[0].Address;
            TextBoxAddressBusiness.Text = LS[0].AddressBusiness;
            TextBoxDescription.Text = LS[0].Description;
            checkBoxActive.Checked = LS[0].Active.Value;
            GetGroupPerson(_id);
        }


        private string GetGroupPerson(int PersonId)
        {
            string str = "";
            GroupPerson RN = new GroupPerson();
            foreach (var item in itemPanelGroup.Items)
                try
                {
                    if (RN.GetAllListByIds(Convert.ToInt32((item as DevComponents.DotNetBar.CheckBoxItem).Name), PersonId, ref str)[0] != null)
                        (item as DevComponents.DotNetBar.CheckBoxItem).Checked = true;
                }
                catch { }

            return "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckValidation())
                return;
            try
            {
                string str = ""; int? idSet = 0;

                byte[] b = null;
                try
                {
                    System.IO.MemoryStream fs = new System.IO.MemoryStream();
                    PictureBoxPersonTelMobPic.Image.Save(fs, PictureBoxPersonTelMobPic.Image.RawFormat);
                    b = fs.ToArray();
                }
                catch { }

                List<TBL_PersonTelMob> Ls = new List<TBL_PersonTelMob>(1);
                TBL_PersonTelMob PersonTelMob = new TBL_PersonTelMob();

                PersonTelMob.Id = _id;
                PersonTelMob.PersonPic = b;
                PersonTelMob.FirstName = TextBoxPersonTelMobName.Text;
                PersonTelMob.LastName = TextBoxPersonTelMobFamily.Text;
                PersonTelMob.ParentName = TextBoxParentName.Text;
                PersonTelMob.IDNO = TextBoxIDNO.Text;
                PersonTelMob.NationalCode = TextBoxNationalCode.Text;
                PersonTelMob.BrithDate = DatePickerBrithDate.Value.ToString().Substring(0, 10);
                PersonTelMob.BrithCityName = TextBoxBrithCityName.Text;
                PersonTelMob.TelHome = TextBoxTelHome.Text;
                PersonTelMob.TelBusiness = TextBoxTelBusiness.Text;
                PersonTelMob.Mobile = TextBoxMobile.Text;
                PersonTelMob.Mobile2 = TextBoxMobile2.Text;
                PersonTelMob.Email = TextBoxEmail.Text;
                PersonTelMob.Address = TextBoxAddress.Text;
                PersonTelMob.AddressBusiness = TextBoxAddressBusiness.Text;
                PersonTelMob.Description = TextBoxDescription.Text;
                PersonTelMob.Active = checkBoxActive.Checked;
                Ls.Add(PersonTelMob);

                if (!_editIns)
                {
                    new PersonTelMob().InsertEntity(Ls, ref str, ref idSet);
                    SetGroupPerson(idSet.Value);
                }
                else
                {
                    new PersonTelMob().UpdateEntity(Ls, ref str);
                    SetGroupPerson(_id);
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

        private string SetGroupPerson(int PersonId)
        {
            string str = ""; int? idSet = 0;
            try
            {

                List<TBL_GroupPerson> Ls = new List<TBL_GroupPerson>();
                TBL_GroupPerson GroupPerson = null;

                foreach (var item in itemPanelGroup.Items)
                {
                    GroupPerson = new TBL_GroupPerson();
                    GroupPerson.Person_ID = PersonId;
                    GroupPerson.Group_ID = Convert.ToInt16((item as DevComponents.DotNetBar.CheckBoxItem).Name);
                    Ls.Add(GroupPerson);
                }
                new ViewModel.GroupPerson.GroupPerson().DeleteEntity(Ls, ref str);

                Ls = new List<TBL_GroupPerson>();
                foreach (var item in itemPanelGroup.Items)
                {
                    if ((item as DevComponents.DotNetBar.CheckBoxItem).Checked)
                    {
                        GroupPerson = new TBL_GroupPerson();
                        GroupPerson.Person_ID = PersonId;
                        GroupPerson.Group_ID = Convert.ToInt16((item as DevComponents.DotNetBar.CheckBoxItem).Name);
                        Ls.Add(GroupPerson);
                    }
                }
                new ViewModel.GroupPerson.GroupPerson().InsertEntity(Ls, ref str, ref idSet);
                if (str != "") return str;
            }
            catch { }

            return "";
        }


        private bool CheckValidation()
        {
            if (TextBoxPersonTelMobName.Text.Trim() == "")
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("لطفا نام شخص را پر نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                return false;
            }
            if (TextBoxPersonTelMobFamily.Text.Trim() == "")
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("لطفا نام خانوادگی شخص را پر نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                return false;
            }
            if (TextBoxMobile.Text.Trim() == "")
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("لطفا موبایل را پر نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                return false;
            }
            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PictureBoxPersonTelMobPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "All Image File|*.Jpg;*.Jpeg;*.bmp;*.png;*.tiff;*.tif;*.gif;*.ico";
            if (op.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    PictureBoxPersonTelMobPic.Image = System.Drawing.Image.FromFile(op.FileName);
                }
                catch
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View("مسیر فایل و یا سورس فایل نامعتبر است. دوباره سعی کنید ", MKH.Library.Clasess.MSSMessage.MessageType.SError);
                }
            }
        }

        private void ButtonDelPic_Click(object sender, EventArgs e)
        {
            try
            {
                PictureBoxPersonTelMobPic.Image = null;
                PictureBoxPersonTelMobPic.Load("");
            }
            catch { }
        }


    }
}
