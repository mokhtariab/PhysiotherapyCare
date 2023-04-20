using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using PhysiotherapyCare.ViewModel.Patient;
using PhysiotherapyCare.Model.Patient;
using PhysiotherapyCare.ViewModel.Basic;
using PhysiotherapyCare.ViewModel.Martyrs;
using PhysiotherapyCare.ViewModel.Doctors;
using PhysiotherapyCare.Model.Basic;


namespace PhysiotherapyCare.View.MainForms.Patient
{
    public partial class PatientAdd_Frm : MKH.Library.Forms.MSSBaseNew_frm
    {
        private int _id = 0;
        private bool _editIns = false;


        public PatientAdd_Frm()
        {
            InitializeComponent();
        }


        public PatientAdd_Frm(int Id)
        {
            InitializeComponent();

            buttonItemOK.Enabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(28);
            if (buttonItemOK.Enabled)
            {
                string str = "";
                if (new ViewModel.Basic.NODuplicateForm().CheckNODuplicateForm("TBL_Patient", Id.ToString(), ref str))
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View("امکان ویرایش به علت انجام عملیات توسط کاربر دیگر امکان پذیر نمی باشد", MKH.Library.Clasess.MSSMessage.MessageType.SWarning);
                    Close();
                }
                else
                    new ViewModel.Basic.NODuplicateForm().InsertEntity("TBL_Patient", Id.ToString(), ref str);
            }

            _id = Id;
            _editIns = true;

        }

        private void PatientAdd_Frm_Load(object sender, EventArgs e)
        {
            DatePickerCreateDate.Value = KagNetComponents2.KagPersianDate.Parse(DateTime.Now);
            DatePickerBrithDate.Value = KagNetComponents2.KagPersianDate.Parse(DateTime.Now);


            SetComboBox();

            if (_editIns) fillControl();
        }

        private void SetComboBox()
        {
            string str = "";
            if (itemPanelPatientType.Items.Count == 0)
                foreach (var item in new ViewModel.Basic.PatientType().GetAllList(ref str))
                {
                    DevComponents.DotNetBar.CheckBoxItem Ch = new DevComponents.DotNetBar.CheckBoxItem();
                    Ch.Name = item.Id.ToString();
                    Ch.Text = item.TitleName;
                    Ch.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.CheckBox;
                    itemPanelPatientType.Items.Add(Ch);
                    itemPanelPatientType.Refresh();
                }

            if (itemPanelInjuryType.Items.Count == 0)
                foreach (var item in new ViewModel.Basic.InjuryType().GetAllList(ref str))
                {
                    DevComponents.DotNetBar.CheckBoxItem Ch = new DevComponents.DotNetBar.CheckBoxItem();
                    Ch.Name = item.Id.ToString();
                    Ch.Text = item.TitleName;
                    Ch.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.CheckBox;
                    itemPanelInjuryType.Items.Add(Ch);
                    itemPanelInjuryType.Refresh();
                }
            ComboBoxSex.SelectedIndex = 0;

            comboBoxBank.ValueMember = "Id";
            comboBoxBank.DisplayMember = "TitleName";
            comboBoxBank.DataSource = new Bank().GetAllList(ref str);

            ComboBoxStatePart.DataSource = new ViewModel.Patient.Patient().GetAllList(ref str).Select(h => new { h.StatePart }.StatePart).Distinct().ToList();
            ComboBoxCityPart.DataSource = new ViewModel.Patient.Patient().GetAllList(ref str).Select(h => new { h.CityPart }.CityPart).Distinct().ToList();
            ComboBoxCityState.DataSource = new ViewModel.Patient.Patient().GetAllList(ref str).Select(h => new { h.CityState }.CityState).Distinct().ToList();
        }

        private void fillControl()
        {
            string str = "";
            ViewModel.Patient.Patient RN = new ViewModel.Patient.Patient();
            List<VW_Patient> VWP = RN.GetAllListByID(_id, ref str);

            DatePickerCreateDate.Value = KagNetComponents2.KagPersianDate.Parse(VWP[0].CreateDate);
            TextBoxDosiersNo.Text = VWP[0].DosiersNo;
            TextBoxPatientName.Text = VWP[0].PatientName;
            textBoxPatientFamily.Text = VWP[0].PatientFamily;
            TextBoxParentName.Text = VWP[0].ParentName;
            ComboBoxSex.SelectedIndex = VWP[0].Sex.Value;
            TextBoxIDNO.Text = VWP[0].IDNO;
            TextBoxNationalCode.Text = VWP[0].NationalCode;
            DatePickerBrithDate.Value = KagNetComponents2.KagPersianDate.Parse(VWP[0].BrithDate);
            TextBoxBrithCityName.Text = VWP[0].BrithCityName;
            IntBoxPercentState.Value = VWP[0].PercentState;
            ComboBoxBonyadAddEven.SelectedIndex = VWP[0].BonyadAddEven.Value;
            ComboBoxSingleOrNo.Text = VWP[0].SingleOrNo;
            textBoxMartyrPatient.Tag = VWP[0].Martyr_Id;
            textBoxMartyrPatient.Text = VWP[0].MartyrNameFamily;


            ComboBoxBonyadDosier.Text = VWP[0].BonyadDosier;
            ComboBoxStatePart.Text = VWP[0].StatePart;
            ComboBoxCityState.Text = VWP[0].CityState;


            ComboBoxCityPart.Text = VWP[0].CityPart;
            IntBoxInstitutePart.Value = VWP[0].InstitutePart;
            IntBoxAddressPart.Value = VWP[0].AddressPart;
            TextBoxAddress.Text = VWP[0].Address;
            TextBoxPostalCode.Text = VWP[0].PostalCode;
            TextBoxTelHome.Text = VWP[0].TelHome;
            TextBoxTelBusiness.Text = VWP[0].TelBusiness;
            TextBoxMobile.Text = VWP[0].Mobile;
            TextBoxMobile2.Text = VWP[0].Mobile2;
            TextBoxEmail.Text = VWP[0].Email;
            comboBoxBasicInsurance.Text = VWP[0].BasicInsurance;
            comboBoxCompletionInsurance.Text = VWP[0].CompletionInsurance;

            try { comboBoxBank.SelectedValue = VWP[0].Bank_Id; }
            catch { }

            TextBoxAccountNo1.Text = VWP[0].AccountNo1;
            TextBoxAccountNo2.Text = VWP[0].AccountNo2;
            TextBoxAccountNo3.Text = VWP[0].AccountNo3;
            TextBoxDescription.Text = VWP[0].Description;


            foreach (var item in new PatientTypeGroup().GetAllListByPatientId(_id, ref str))
                (itemPanelPatientType.Items[item.PatientType_Id.ToString()] as DevComponents.DotNetBar.CheckBoxItem).Checked = true;

            foreach (var item in new InjuryTypePatient().GetAllListByPatientId(_id, ref str))
                (itemPanelInjuryType.Items[item.InjuryType_Id.ToString()] as DevComponents.DotNetBar.CheckBoxItem).Checked = true;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckValidation())
                return;
            try
            {
                string str = ""; int? idSet = 0;
                List<TBL_Patient> Ls = new List<TBL_Patient>(1);
                TBL_Patient Patient = new TBL_Patient();
                Patient.Id = _id;
                Patient.CreateDate = DatePickerCreateDate.Value.ToString().Substring(0,10);
                Patient.DosiersNo = TextBoxDosiersNo.Text;
                Patient.Martyr_Id = Convert.ToInt32(textBoxMartyrPatient.Tag ?? "1");

                Patient.PatientName = TextBoxPatientName.Text;
                Patient.PatientFamily = textBoxPatientFamily.Text;
                Patient.Sex = Convert.ToByte(ComboBoxSex.SelectedIndex);
                Patient.BonyadAddEven = Convert.ToByte(ComboBoxBonyadAddEven.SelectedIndex == -1 ? 0 : ComboBoxBonyadAddEven.SelectedIndex);
                Patient.SingleOrNo = ComboBoxSingleOrNo.Text;
                Patient.ParentName = TextBoxParentName.Text;
                Patient.IDNO = TextBoxIDNO.Text;
                Patient.NationalCode = TextBoxNationalCode.Text;

                Patient.BrithDate = DatePickerBrithDate.Value.ToString();
                Patient.BrithCityName = TextBoxBrithCityName.Text;
                Patient.PercentState = Convert.ToInt16(IntBoxPercentState.Value ?? "0");

                Patient.BonyadDosier = ComboBoxBonyadDosier.Text;
                Patient.StatePart = ComboBoxStatePart.Text;
                Patient.CityState = ComboBoxCityState.Text;
                Patient.CityPart = ComboBoxCityPart.Text;
                Patient.InstitutePart = Convert.ToInt16(IntBoxInstitutePart.Value);
                Patient.AddressPart = Convert.ToInt16(IntBoxAddressPart.Value);
                Patient.Address = TextBoxAddress.Text;
                Patient.PostalCode = TextBoxPostalCode.Text;
                Patient.TelHome = TextBoxTelHome.Text;
                Patient.TelBusiness = TextBoxTelBusiness.Text;
                Patient.Mobile = TextBoxMobile.Text;
                Patient.Mobile2 = TextBoxMobile2.Text;
                Patient.Email = TextBoxEmail.Text;
                Patient.BasicInsurance = comboBoxBasicInsurance.Text;
                Patient.CompletionInsurance = comboBoxCompletionInsurance.Text;

                Patient.Bank_Id = Convert.ToInt16(comboBoxBank.SelectedValue);

                Patient.AccountNo1 = TextBoxAccountNo1.Text;
                Patient.AccountNo2 = TextBoxAccountNo2.Text;
                Patient.AccountNo3 = TextBoxAccountNo3.Text;
                Patient.Description = TextBoxDescription.Text;
                //Patient.DeActiveDsc= "";
                //Patient.Active = true;

                Patient.User_Id = MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID;
                Patient.ChangeDateTime = MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now);


                Ls.Add(Patient);

                if (!_editIns)
                {
                    new ViewModel.Patient.Patient().InsertEntity(Ls, ref str, ref idSet);
                    SetInjuryTypePatientType(idSet.Value);
                }
                else
                {
                    new ViewModel.Patient.Patient().UpdateEntity(Ls, ref str);
                    SetInjuryTypePatientType(_id);
                }
                if (str != "")
                {
                    if (str.Contains("Cannot insert duplicate key in object 'dbo.TBL_Patient'."))
                        MKH.Library.Clasess.MSSMessage.MSSMessage_View("کد ملی تکراری است", MKH.Library.Clasess.MSSMessage.MessageType.SError);
                    else
                        MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "اشکال ثبت اطلاعات", str);
                }
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

        private string SetInjuryTypePatientType(int NewPatientID)
        {

            string str = ""; int? idSet = 0; short? idSetShort = 0;
            try
            {
                new PatientTypeGroup().DeleteWithPatientID(NewPatientID, ref str);


                List<TBL_PatientTypeGroup> Ls = new List<TBL_PatientTypeGroup>();
                TBL_PatientTypeGroup PatientTypeGroup = null;

                foreach (var item in itemPanelPatientType.Items)
                {
                    if ((item as DevComponents.DotNetBar.CheckBoxItem).Checked)
                    {
                        PatientTypeGroup = new TBL_PatientTypeGroup();
                        PatientTypeGroup.Patient_Id = NewPatientID;
                        PatientTypeGroup.PatientType_Id = Convert.ToInt16((item as DevComponents.DotNetBar.CheckBoxItem).Name);
                        Ls.Add(PatientTypeGroup);
                    }
                }
                new ViewModel.Basic.PatientTypeGroup().InsertEntity(Ls, ref str, ref idSet);
                if (str != "") return str;
            }
            catch { }

            try
            {
                new InjuryTypePatient().DeleteWithPatientID(NewPatientID, ref str);

                List<TBL_InjuryTypePatient> Ls1 = new List<TBL_InjuryTypePatient>();
                TBL_InjuryTypePatient InjuryTypePatient = null;

                foreach (var item in itemPanelInjuryType.Items)
                {
                    if ((item as DevComponents.DotNetBar.CheckBoxItem).Checked)
                    {
                        InjuryTypePatient = new TBL_InjuryTypePatient();
                        InjuryTypePatient.Patient_Id = NewPatientID;
                        InjuryTypePatient.InjuryType_Id = Convert.ToInt16((item as DevComponents.DotNetBar.CheckBoxItem).Name);
                        Ls1.Add(InjuryTypePatient);
                    }
                }
                new ViewModel.Basic.InjuryTypePatient().InsertEntity(Ls1, ref str, ref idSetShort);
                if (str != "") return str;
            }
            catch { }

            new ViewModel.Patient.Patient().UpdatePatientInjuryStr(NewPatientID, ref str);
            if (str != "") return str;

            return "";
        }



        private bool CheckValidation()
        {
            if (TextBoxPatientName.Text.Trim() == "")
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("لطفا نام بیمار را پر نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                return false;
            }
            if (textBoxPatientFamily.Text.Trim() == "")
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("لطفا فامیل بیمار  را پر نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                return false;
            }
            if (TextBoxNationalCode.Text.Trim() == "")
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("لطفا کدملی بیمار  را پر نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                return false;
            }
            if (TextBoxNationalCode.Text.Length != 10)
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("کدملی بیمار بایستی 10 رقم باشد", MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                return false;
            }

            bool PatientTypeExist = false;
            foreach (var item in itemPanelPatientType.Items)
                if ((item as DevComponents.DotNetBar.CheckBoxItem).Checked)
                {
                    PatientTypeExist = true;
                    break;
                }
            if (!PatientTypeExist)
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("لطفا نسبت با شهید را پر نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                return false;
            }

            if (TextBoxMobile.Text.Trim() == "" && TextBoxTelHome.Text.Trim() == "")
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("لطفا موبایل یا تلفن را پر نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                return false;
            }
            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonMartyrPatient_Click(object sender, EventArgs e)
        {
            try
            {
                string StrSet = "";
                Dictionary<string, string> SD = new Dictionary<string, string>();
                Dictionary<string, string> SD1 = new Dictionary<string, string>();

                foreach (var item in new ViewModel.Martyrs.Martyr().GetAllList(ref StrSet))
                    SD.Add(item.MartyrId.ToString(), item.MartyrNameFamily);

                SD1 = MKH.Library.Forms.MSSSelector_frm.SetDataSelect(SD);
                textBoxMartyrPatient.Tag = SD1.Keys.ToList()[0];
                textBoxMartyrPatient.Text = SD1.Values.ToList()[0];
            }
            catch { }
        }

        MKH.Library.Control.MSSTextBox tx = new MKH.Library.Control.MSSTextBox();
        private void TextBoxNationalCode_TextChanged(object sender, EventArgs e)
        {
            //tx = (MKH.Library.Control.MSSTextBox)sender;
            //string str = tx.Text;
            //if (tx.Text != "")
            //{
            //    try
            //    {
            //        str = System.Int64.Parse(str, System.Globalization.NumberStyles.Number).ToString();
            //    }
            //    catch
            //    {
            //        str = "";
            //    }
            //    tx.Text = str;
            //}

        }

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

        private void PatientAdd_Frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            string str = "";
            if (buttonItemOK.Enabled)
                new ViewModel.Basic.NODuplicateForm().DeleteEntity("TBL_Patient", _id.ToString(), ref str);
        }


    }
}
