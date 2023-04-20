using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using PhysiotherapyCare.ViewModel.Doctors;
using PhysiotherapyCare.Model.Doctors;
using PhysiotherapyCare.ViewModel.Basic;
using MKH.Library.Clasess.Filing;


namespace PhysiotherapyCare.View.MainForms.Doctors
{
    public partial class DoctorsAdd_Frm : MKH.Library.Forms.MSSBaseNew_frm
    {
        private int _id = 0;
        private bool _editIns = false;
        string str = "";


         public DoctorsAdd_Frm()
        {
            InitializeComponent();
        }


        public DoctorsAdd_Frm(int Id)
        {
            InitializeComponent();

            buttonItemOK.Enabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(34);
            if (buttonItemOK.Enabled)
            {
                string str = "";
                if (new ViewModel.Basic.NODuplicateForm().CheckNODuplicateForm("TBL_Doctors", Id.ToString(), ref str))
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View("امکان ویرایش به علت انجام عملیات توسط کاربر دیگر امکان پذیر نمی باشد", MKH.Library.Clasess.MSSMessage.MessageType.SWarning);
                    Close();
                }
                else
                    new ViewModel.Basic.NODuplicateForm().InsertEntity("TBL_Doctors", Id.ToString(), ref str);
            }
            
            _id = Id;
            _editIns = true;
        }

        private void DoctorsAdd_Frm_Load(object sender, EventArgs e)
        {
            DatePickerBrithDate.Value = KagNetComponents2.KagPersianDate.Parse(DateTime.Now);
            
            SetComboBox();

            if (_editIns) fillControl();
        }

        private void SetComboBox()
        {
            if (itemPanelLocationPart.Items.Count == 0)
                foreach (var item in new LocationPart().GetAllList(ref str))
                {
                    DevComponents.DotNetBar.CheckBoxItem Ch = new DevComponents.DotNetBar.CheckBoxItem();
                    Ch.Name = item.Id.ToString();
                    Ch.Text = item.TitleName;
                    Ch.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.CheckBox;
                    itemPanelLocationPart.Items.Add(Ch);
                    itemPanelLocationPart.Refresh();
                }

            ComboBoxDoctorType_Id.ValueMember = "Id";
            ComboBoxDoctorType_Id.DisplayMember = "TitleName";
            ComboBoxDoctorType_Id.DataSource = new DoctorType().GetAllList(ref str);

            ComboBoxBankName.ValueMember = "Id";
            ComboBoxBankName.DisplayMember = "TitleName";
            ComboBoxBankName.DataSource = new Bank().GetAllList(ref str);
        }

        private void fillControl()
        {
            string str = "";
            Doctor RN = new Doctor();
            List<VW_Doctor> DT = RN.GetAllListByID(_id, ref str);


            textBoxMedicalCode.Text = DT[0].MedicalCode;



            byte[] b = null;
            if (RN.GetAllListByIDPic(_id, ref str)[0].DoctorPic != null)
            {
                b = RN.GetAllListByIDPic(_id, ref str)[0].DoctorPic.ToArray();
            }

            try { PictureBoxDoctorPic.Image = MSSImageConvert.byteArrayToImage(b); }
            catch { }

            TextBoxDoctorName.Text = DT[0].DoctorName;
            TextBoxDoctorFamily.Text = DT[0].DoctorFamily;
            TextBoxParentName.Text = DT[0].ParentName;
            TextBoxIDNO.Text = DT[0].IDNO;
            TextBoxNationalCode.Text = DT[0].NationalCode;
            DatePickerBrithDate.Value = KagNetComponents2.KagPersianDate.Parse(DT[0].BrithDate);
            TextBoxBrithCityName.Text = DT[0].BrithCityName;
            ComboBoxDoctorType_Id.SelectedValue = DT[0].DoctorType_Id;
            IntBoxAddressPart.Value = DT[0].AddressPart;
            TextBoxAddress.Text = DT[0].Address;
            TextBoxTelHome.Text = DT[0].TelHome;
            TextBoxTelBusiness.Text = DT[0].TelBusiness;
            TextBoxMobile.Text = DT[0].Mobile;
            TextBoxEmail.Text = DT[0].Email;
            TextBoxCardBankNo1.Text = DT[0].CardBankNo1;
            TextBoxCardBankNo2.Text = DT[0].CardBankNo2;
            IntBoxDoctorPrice.Value = DT[0].DoctorPrice;
            checkBoxActive.Checked = DT[0].Active.Value;

            CheckBoxDoctorParent.Checked = false;
            if (DT[0].DoctorParent_Id != null && DT[0].DoctorParent_Id != 0)
            {
                CheckBoxDoctorParent.Checked = true;
                TextBoxDoctorParent.Tag = DT[0].DoctorParent_Id;
                TextBoxDoctorParent.Text = DT[0].DoctorParentsNameFamily;
            }
            IntBoxDoctorTaxPercent.Value = DT[0].DoctorTaxPercent ?? 0;
            
            try { ComboBoxBankName.SelectedValue = DT[0].Bank_Id; }
            catch { }


            foreach (var item in new LocationPartDoctors().GetAllListByDoctorID(DT[0].Id, ref str))
                (itemPanelLocationPart.Items[item.LocationPart_Id.ToString()] as DevComponents.DotNetBar.CheckBoxItem).Checked = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckValidation())
                return;
            try
            {
                string str = ""; int? idSet = 0;
                byte[] b = null;
                if (PictureBoxDoctorPic.Image != null)
                    b = MSSImageConvert.imageToByteArray(PictureBoxDoctorPic.Image);

                List<TBL_Doctor> Ls = new List<TBL_Doctor>(1);
                TBL_Doctor Doctors = new TBL_Doctor();
                
                Doctors.Id = _id;
                Doctors.DoctorType_Id = Convert.ToInt16(ComboBoxDoctorType_Id.SelectedValue);
                Doctors.CreateDate =
                    KagNetComponents2.KagPersianDate.Now.ShamsiYear.ToString() + "/" +
                    KagNetComponents2.KagPersianDate.Now.ShamsiMonth.ToString("00") + "/" +
                    KagNetComponents2.KagPersianDate.Now.ShamsiDay.ToString("00");

                Doctors.MedicalCode =  textBoxMedicalCode.Text;
                Doctors.DoctorPic = b;
                Doctors.DoctorName = TextBoxDoctorName.Text;
                Doctors.DoctorFamily = TextBoxDoctorFamily.Text;
                Doctors.ParentName = TextBoxParentName.Text;
                Doctors.IDNO = TextBoxIDNO.Text;
                Doctors.NationalCode = TextBoxNationalCode.Text;
                Doctors.BrithDate = DatePickerBrithDate.Value.ToString().Substring(0,10);
                Doctors.BrithCityName = TextBoxBrithCityName.Text;
                Doctors.Address = TextBoxAddress.Text;
                Doctors.AddressPart = Convert.ToInt16(IntBoxAddressPart.Value);
                Doctors.TelHome = TextBoxTelHome.Text;
                Doctors.TelBusiness = TextBoxTelBusiness.Text;
                Doctors.Mobile = TextBoxMobile.Text;
                Doctors.Email = TextBoxEmail.Text;
                Doctors.CardBankNo1 = TextBoxCardBankNo1.Text;
                Doctors.CardBankNo2 = TextBoxCardBankNo2.Text;
                Doctors.DoctorPrice = Convert.ToInt64(IntBoxDoctorPrice.Value);
                Doctors.Active = checkBoxActive.Checked;

                Doctors.Bank_Id = Convert.ToInt16(ComboBoxBankName.SelectedValue);

                Doctors.DoctorTaxPercent = Convert.ToInt16(IntBoxDoctorTaxPercent.Value);
                
                if(CheckBoxDoctorParent.Checked) Doctors.DoctorParent_Id = Convert.ToInt16(TextBoxDoctorParent.Tag);

                Doctors.User_Id = MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID;
                Doctors.ChangeDateTime = MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now);
                
                Ls.Add(Doctors);



                if (!_editIns)
                {
                    new Doctor().InsertEntity(Ls, ref str, ref idSet);
                    SaveLocationPart(idSet.Value);
                }
                else
                {
                    new Doctor().UpdateEntity(Ls, ref str);
                    SaveLocationPart(_id);
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

        private void SaveLocationPart(int Doctor_Id)
        {
            short? i = 0;
            try
            {
                new LocationPartDoctors().DeleteWithDoctor_Id(Doctor_Id, ref str);

                List<PhysiotherapyCare.Model.Basic.TBL_LocationPartDoctor> LPD = new List<PhysiotherapyCare.Model.Basic.TBL_LocationPartDoctor>(1);
                PhysiotherapyCare.Model.Basic.TBL_LocationPartDoctor LocationPartDoctor = null;
                foreach (var item in itemPanelLocationPart.Items)
                {
                    if ((item as DevComponents.DotNetBar.CheckBoxItem).Checked)
                    {
                        LocationPartDoctor = new PhysiotherapyCare.Model.Basic.TBL_LocationPartDoctor();
                        LocationPartDoctor.Doctors_Id = Doctor_Id;
                        LocationPartDoctor.LocationPart_Id = Convert.ToInt16((item as DevComponents.DotNetBar.CheckBoxItem).Name);
                        LPD.Add(LocationPartDoctor);
                    }
                }
                new LocationPartDoctors().InsertEntity(LPD, ref str, ref i);
            }
            catch { }
        }



        private bool CheckValidation()
        {
            if (TextBoxDoctorName.Text.Trim() == "")
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("لطفا نام پزشک را پر نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                return false;
            }
            if (TextBoxDoctorFamily.Text.Trim() == "")
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("لطفا فامیل پزشک  را پر نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                return false;
            }

            if (TextBoxNationalCode.Text.Trim() == "")
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("لطفا کدملی پزشک را پر نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                return false;
            }
            if (TextBoxNationalCode.Text.Length != 10)
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("کدملی پزشک بایستی 10 رقم باشد", MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                return false;
            }
            
            int CountNationalCode = new ViewModel.Doctors.Doctor().CheckExistNationalCode(TextBoxNationalCode.Text,ref str);
            if ((_editIns && CountNationalCode > 1) || (!_editIns && CountNationalCode > 0))
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("کدملی پزشک تکراری باشد", MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                return false;
            }

            if (TextBoxMobile.Text.Trim() == "")
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("لطفا موبایل را پر نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                return false;
            }
            if (ComboBoxDoctorType_Id.Text.Trim() == "")
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("لطفا نوع پزشک  را پر نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                return false;
            }
            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PictureBoxDoctorPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "All Image File|*.Jpg;*.Jpeg;*.bmp;*.png;*.tiff;*.tif;*.gif;*.ico";
            if (op.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    PictureBoxDoctorPic.Image = System.Drawing.Image.FromFile(op.FileName);
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
                PictureBoxDoctorPic.Image = null;
                PictureBoxDoctorPic.Load("");
            }
            catch { }
        }

        MKH.Library.Control.MSSTextBox tx = new MKH.Library.Control.MSSTextBox();
        private void TextBoxNationalCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Delete && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
            { e.KeyChar = '\0'; return; }

            if (e.KeyChar == (char)Keys.Space)
            {
                tx = (MKH.Library.Control.MSSTextBox)sender;
                if (tx.Text.Length < 18) tx.Text = tx.Text + "000";
                tx.SelectionStart = tx.Text.Length;
            }
        }

        private void DoctorsAdd_Frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            string str = "";
            if (buttonItemOK.Enabled)
                new ViewModel.Basic.NODuplicateForm().DeleteEntity("TBL_Doctors", _id.ToString(), ref str);
        }

        private void buttonDoctorParent_Click(object sender, EventArgs e)
        {
            try
            {
                string StrSet = "";
                Dictionary<string, string> SD = new Dictionary<string, string>();
                Dictionary<string, string> SD1 = new Dictionary<string, string>();

                foreach (var item in new ViewModel.Doctors.Doctor().GetAllList(ref StrSet))
                    SD.Add(item.Id.ToString(), item.DoctorName + " " + item.DoctorFamily);

                SD1 = MKH.Library.Forms.MSSSelector_frm.SetDataSelect(SD);
                TextBoxDoctorParent.Tag = SD1.Keys.ToList()[0];
                TextBoxDoctorParent.Text = SD1.Values.ToList()[0];
            }
            catch { }
        }

        private void CheckBoxDoctorParent_CheckedChanged(object sender, EventArgs e)
        {
            buttonDoctorParent.Enabled = CheckBoxDoctorParent.Checked;
        }


    }
}
