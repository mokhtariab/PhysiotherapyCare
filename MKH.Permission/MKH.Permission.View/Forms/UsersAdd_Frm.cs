using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using MKH.Library.Clasess;
using MKH.Permission.Model.Users;
using FastReport;
using MKH.Library.Clasess.Filing;

namespace MKH.Permission.View.Forms
{
    public partial class UsersAdd_Frm : MKH.Library.Forms.MSSBaseNew_frm
    {
        private int _id = 0;
        private bool _editIns = false;

        public UsersAdd_Frm()
        {
            InitializeComponent();
        }


        public UsersAdd_Frm(int Id)
        {
            InitializeComponent();
            _id = Id;
            _editIns = true;
        }

        private void UsersAdd_Frm_Load(object sender, EventArgs e)
        {
            if (_editIns) fillControl();
        }


        private void fillControl()
        {
            string str = "";
            

            ViewModel.Users.Users RN = new ViewModel.Users.Users();

            byte[] b = null;
            if (RN.GetAllListByIDPic(_id, ref str)[0].UserPic != null)
            {
                b = RN.GetAllListByIDPic(_id, ref str)[0].UserPic.ToArray();
            }
            try { PictureBoxUserPic.Image = MSSImageConvert.byteArrayToImage(b); }
            catch { }

            TextBoxName.Text = RN.GetAllListByID(_id, ref str)[0].Name.ToString();
            TextBoxFamily.Text = RN.GetAllListByID(_id, ref str)[0].Family.ToString();
            TextBoxNationalCode.Text = RN.GetAllListByID(_id, ref str)[0].NationalCode;
            DatePickerBirthDate.Value = KagNetComponents2.KagPersianDate.Parse(RN.GetAllListByID(_id, ref str)[0].BirthDate);
            TextBoxTelNo.Text = RN.GetAllListByID(_id, ref str)[0].TelNo;
            TextBoxMobileNo.Text = RN.GetAllListByID(_id, ref str)[0].MobileNo;
            
            TextBoxUserName.Text = RN.GetAllListByID(_id, ref str)[0].UserName;
            try
            {
                DatePickerDateActive.Value = KagNetComponents2.KagPersianDate.Parse(RN.GetAllListByID(_id, ref str)[0].DateActive);
                DatePickerDateInActive.Value = KagNetComponents2.KagPersianDate.Parse(RN.GetAllListByID(_id, ref str)[0].DateInActive);
            }
            catch { }

            TextBoxDescription.Text = RN.GetAllListByID(_id, ref str)[0].Description;
            CheckBoxIsActive.Checked = RN.GetAllListByID(_id, ref str)[0].IsActive.Value;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckValidation())
                return;
            try
            {
                string str = ""; int? idSet = 0;
                byte[] b = null;
                if (PictureBoxUserPic.Image != null)
                    b = MSSImageConvert.imageToByteArray(PictureBoxUserPic.Image);

                List<TBL_User> Ls = new List<TBL_User>(1);
                TBL_User Users = new TBL_User();
                Users.Id = _id;
                
                Users.UserPic = b;

                Users.Name = TextBoxName.Text;
                Users.Family = TextBoxFamily.Text;
                Users.NationalCode = TextBoxNationalCode.Text;
                Users.TelNo = TextBoxTelNo.Text;
                Users.MobileNo = TextBoxMobileNo.Text;
                Users.BirthDate = DatePickerBirthDate.Value.ToString();

                Users.UserName = TextBoxUserName.Text;
                Users.Description = TextBoxDescription.Text;

                Users.DateActive = DatePickerDateActive.Value.ToString();
                Users.DateInActive = DatePickerDateInActive.Value.ToString();

                Users.IsActive = CheckBoxIsActive.Checked;


                Ls.Add(Users);

                if (!_editIns)
                {
                    new ViewModel.Users.Users().InsertEntity(Ls, ref str, ref idSet);
                }
                else
                {
                    new ViewModel.Users.Users().UpdateEntity(Ls, ref str);
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
                MSSMessage.MSSMessage_View(0, MSSMessage.MessageType.SError,false, "اشکال در ذخیره اطلاعات", ex.Message);
            }

        }

        private bool CheckValidation()
        {
            if (TextBoxName.Text.Trim() == "")
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("لطفا نام را درج نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                return false;
            }

            if (TextBoxFamily.Text.Trim() == "")
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("لطفا نام خانوادگی را درج نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                return false;
            }

            if (TextBoxUserName.Text.Trim() == "")
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("لطفا نام کاربری را درج نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                return false;
            }

            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CheckBoxIsActive_CheckedChanged(object sender, EventArgs e)
        {
            DatePickerDateInActive.Enabled = !CheckBoxIsActive.Checked;
        }

        private void PictureBoxUserPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "All Image File|*.Jpg;*.Jpeg;*.bmp;*.png;*.tiff;*.tif;*.gif;*.ico";
            if (op.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    PictureBoxUserPic.Image = System.Drawing.Image.FromFile(op.FileName);
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
                PictureBoxUserPic.Image = null;
                PictureBoxUserPic.Load("");
            }
            catch { }
        }

    }
}
