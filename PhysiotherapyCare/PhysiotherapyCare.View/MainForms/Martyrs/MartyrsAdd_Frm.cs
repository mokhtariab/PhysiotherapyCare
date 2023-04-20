using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using PhysiotherapyCare.ViewModel.Martyrs;
using PhysiotherapyCare.Model.Martyrs;
using PhysiotherapyCare.ViewModel.Basic;


namespace PhysiotherapyCare.View.MainForms.Martyrs
{
    public partial class MartyrsAdd_Frm : MKH.Library.Forms.MSSBaseNew_frm
    {
        private int _id = 0;
        private bool _editIns = false;


         public MartyrsAdd_Frm()
        {
            InitializeComponent();
        }


        public MartyrsAdd_Frm(int Id)
        {
            InitializeComponent();

            buttonItemOK.Enabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(48);
            if (buttonItemOK.Enabled)
            {
                string str = "";
                if (new ViewModel.Basic.NODuplicateForm().CheckNODuplicateForm(this.Name, Id.ToString(), ref str))
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View("امکان ویرایش به علت انجام عملیات توسط کاربر دیگر امکان پذیر نمی باشد", MKH.Library.Clasess.MSSMessage.MessageType.SWarning);
                    Close();
                }
                else
                    new ViewModel.Basic.NODuplicateForm().InsertEntity(this.Name, Id.ToString(), ref str);
            }

            _id = Id;
            _editIns = true;
            
        }

        private void MartyrsAdd_Frm_Load(object sender, EventArgs e)
        {
            DatePickerBrithDate3.Value = DatePickerBrithDate2.Value = DatePickerBrithDate1.Value =
                DatePickerMartyrDate3.Value = DatePickerMartyrDate2.Value = DatePickerMartyrDate1.Value =
                    KagNetComponents2.KagPersianDate.Parse(DateTime.Now);

            if (_editIns) fillControl();
        }

        
        private void fillControl()
        {
            string str = "";
            Martyr RN = new Martyr();
            List<VW_Martyr> LM = RN.GetAllListByID(_id, ref str);

            textBoxMartyrNameFamily.Text = LM[0].MartyrNameFamily;
            IntBoxMartyrFew.Value = LM[0].MartyrFew;
            TextBoxDosiersNo1.Text = LM[0].DosiersNo1;
            TextBoxDosiersNo2.Text = LM[0].DosiersNo2;
            TextBoxDosiersNo3.Text = LM[0].DosiersNo3;
            TextBoxNationalCode1.Text = LM[0].NationalCode1;
            TextBoxNationalCode2.Text = LM[0].NationalCode2;
            TextBoxNationalCode3.Text = LM[0].NationalCode3;
            TextBoxMartyrName1.Text = LM[0].MartyrName1;
            TextBoxMartyrName2.Text = LM[0].MartyrName2;
            TextBoxMartyrName3.Text = LM[0].MartyrName3;
            DatePickerBrithDate1.Value = KagNetComponents2.KagPersianDate.Parse(LM[0].BrithDate1);
            DatePickerBrithDate2.Value = KagNetComponents2.KagPersianDate.Parse(LM[0].BrithDate2);
            DatePickerBrithDate3.Value = KagNetComponents2.KagPersianDate.Parse(LM[0].BrithDate3);
            DatePickerMartyrDate1.Value = KagNetComponents2.KagPersianDate.Parse(LM[0].MartyrDate1);
            DatePickerMartyrDate2.Value = KagNetComponents2.KagPersianDate.Parse(LM[0].MartyrDate2);
            DatePickerMartyrDate3.Value = KagNetComponents2.KagPersianDate.Parse(LM[0].MartyrDate3);
            TextBoxMartyrLocation1.Text = LM[0].MartyrLocation1;
            TextBoxMartyrLocation2.Text = LM[0].MartyrLocation2;
            TextBoxMartyrLocation3.Text = LM[0].MartyrLocation3;
            TextBoxDescription.Text = LM[0].Description;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckValidation())
                return;
            try
            {
                string str = ""; int? idSet = 0;
                List<TBL_Martyr> Ls = new List<TBL_Martyr>(1);
                TBL_Martyr Martyrs = new TBL_Martyr();
                Martyrs.MartyrId = _id;

                Martyrs.MartyrNameFamily = textBoxMartyrNameFamily.Text;
                Martyrs.MartyrFew = Convert.ToInt16(IntBoxMartyrFew.Value);
                
                Martyrs.DosiersNo1 = TextBoxDosiersNo1.Text;
                Martyrs.DosiersNo2 = TextBoxDosiersNo2.Text;
                Martyrs.DosiersNo3 = TextBoxDosiersNo3.Text;

                Martyrs.NationalCode1 = TextBoxNationalCode1.Text;
                Martyrs.NationalCode2 = TextBoxNationalCode2.Text;
                Martyrs.NationalCode3 = TextBoxNationalCode3.Text;

                Martyrs.MartyrName1 = TextBoxMartyrName1.Text;
                Martyrs.MartyrName2 = TextBoxMartyrName2.Text;
                Martyrs.MartyrName3 = TextBoxMartyrName3.Text;

                Martyrs.BrithDate1 = DatePickerBrithDate1.Value.ToString();
                Martyrs.BrithDate2 = DatePickerBrithDate2.Value.ToString();
                Martyrs.BrithDate3 = DatePickerBrithDate3.Value.ToString();

                Martyrs.MartyrDate1 = DatePickerMartyrDate1.Value.ToString();
                Martyrs.MartyrDate2 = DatePickerMartyrDate2.Value.ToString();
                Martyrs.MartyrDate3 = DatePickerMartyrDate3.Value.ToString();

                Martyrs.MartyrLocation1 = TextBoxMartyrLocation1.Text;
                Martyrs.MartyrLocation2 = TextBoxMartyrLocation2.Text;
                Martyrs.MartyrLocation3 = TextBoxMartyrLocation3.Text;
                
                Martyrs.Description = TextBoxDescription.Text;
                Ls.Add(Martyrs);

                if (!_editIns)
                {
                    new Martyr().InsertEntity(Ls, ref str, ref idSet);
                }
                else
                {
                    new Martyr().UpdateEntity(Ls, ref str);
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
            //if (TextBoxMartyrName1.Text.Trim() == "")
            //{
            //    MKH.Library.Clasess.MSSMessage.MSSMessage_View("لطفا نام پزشک را پر نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation);
            //    return false;
            //}
            //if (TextBoxDoctorFamily.Text.Trim() == "")
            //{
            //    MKH.Library.Clasess.MSSMessage.MSSMessage_View("لطفا فامیل پزشک  را پر نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation);
            //    return false;
            //}
            //if (TextBoxMartyrLocation3.Text.Trim() == "")
            //{
            //    MKH.Library.Clasess.MSSMessage.MSSMessage_View("لطفا موبایل را پر نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation);
            //    return false;
            //}
            //if (ComboBoxDoctorType_Id.Text.Trim() == "")
            //{
            //    MKH.Library.Clasess.MSSMessage.MSSMessage_View("لطفا نوع پزشک  را پر نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation);
            //    return false;
            //}
            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MartyrsAdd_Frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            string str = "";
            if (buttonItemOK.Enabled)
                new ViewModel.Basic.NODuplicateForm().DeleteEntity(this.Name, _id.ToString(), ref str);
        }


    }
}
