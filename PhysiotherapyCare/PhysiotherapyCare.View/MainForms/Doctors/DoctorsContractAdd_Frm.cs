using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using PhysiotherapyCare.ViewModel.DoctorsContracts;
using PhysiotherapyCare.Model.Doctors;
using MKH.Library.Clasess.Filing;


namespace PhysiotherapyCare.View.MainForms.Doctors
{
    public partial class DoctorsContractAdd_Frm : MKH.Library.Forms.MSSBaseNew_frm
    {
        private int _id = 0, _doctor_Id = 0;
        private bool _editIns = false;


        public DoctorsContractAdd_Frm(int Doctor_Id)
        {
            InitializeComponent();
            _doctor_Id = Doctor_Id;
        }


        public DoctorsContractAdd_Frm(int Doctor_Id, int Id)
        {
            InitializeComponent();

            buttonItemOK.Enabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(40);
            if (buttonItemOK.Enabled)
            {
                string str = "";
                if (new ViewModel.Basic.NODuplicateForm().CheckNODuplicateForm(this.Name, Id.ToString() + "_" + Doctor_Id.ToString(), ref str))
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View("امکان ویرایش به علت انجام عملیات توسط کاربر دیگر امکان پذیر نمی باشد", MKH.Library.Clasess.MSSMessage.MessageType.SWarning);
                    Close();
                }
                else
                    new ViewModel.Basic.NODuplicateForm().InsertEntity(this.Name, Id.ToString() + "_" + Doctor_Id.ToString(), ref str);
            }

            _id = Id;
            _doctor_Id = Doctor_Id;
            _editIns = true;

        }

        private void DoctorsContractAdd_Frm_Load(object sender, EventArgs e)
        {

            DatePickerContractDate.Value = KagNetComponents2.KagPersianDate.Parse(DateTime.Now);
            DatePickerContractEndDate.Value = KagNetComponents2.KagPersianDate.Parse(DateTime.Now);
            if (_editIns) fillControl();
        }

        private void fillControl()
        {
            string str = "";
            DoctorsContract RN = new DoctorsContract();

            TextBoxContractNo.Text = RN.GetAllListByID(_id, ref str)[0].ContractNo;
            TextBoxContractNo.Tag = RN.GetAllListByID(_id, ref str)[0].ContractNo;//----ForCheck ReUse

            DatePickerContractDate.Value = KagNetComponents2.KagPersianDate.Parse(RN.GetAllListByID(_id, ref str)[0].ContractDate);
            DatePickerContractEndDate.Value = KagNetComponents2.KagPersianDate.Parse(RN.GetAllListByID(_id, ref str)[0].ContractEndDate);
            DatePickerContractDate.Tag = KagNetComponents2.KagPersianDate.Parse(RN.GetAllListByID(_id, ref str)[0].ContractDate);//----ForCheck ReUse
            DatePickerContractEndDate.Tag = KagNetComponents2.KagPersianDate.Parse(RN.GetAllListByID(_id, ref str)[0].ContractEndDate);//----ForCheck ReUse
            
            IntBoxContractPercent.Value = RN.GetAllListByID(_id, ref str)[0].ContractPercent;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckValidation())
                return;
            try
            {
                string str = ""; int? idSet = 0;
                List<TBL_DoctorsContract> Ls = new List<TBL_DoctorsContract>(1);
                TBL_DoctorsContract DoctorsContract = new TBL_DoctorsContract();

                DoctorsContract.Id = _id;
                DoctorsContract.Doctor_Id = _doctor_Id;
                DoctorsContract.ContractNo = TextBoxContractNo.Text;
                DoctorsContract.ContractDate = DatePickerContractDate.Value.ToString().Substring(0, 10);
                DoctorsContract.ContractEndDate = DatePickerContractEndDate.Value.ToString().Substring(0, 10);
                DoctorsContract.ContractPercent = Convert.ToInt32(IntBoxContractPercent.Value.ToString());
                DoctorsContract.Active = DatePickerContractEndDate.Value >= KagNetComponents2.KagPersianDate.Now;
                DoctorsContract.User_Id = MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID;
                DoctorsContract.ChangeDateTime = MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now);


                Ls.Add(DoctorsContract);

                if (!_editIns)
                {
                    new DoctorsContract().InsertEntity(Ls, ref str, ref idSet);
                }
                else
                {
                    new DoctorsContract().UpdateEntity(Ls, ref str);
                }

                if (str != "")
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "اشکال اطلاعات", str);
                else
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View("اطلاعات ذخیره شد", MKH.Library.Clasess.MSSMessage.MessageType.SInformation);

                    new ViewModel.DoctorsContracts.DoctorsContract().GetAllUpdateContract(ref str);
                    if (str != "")
                        MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "قراردادهای پزشکان به روز آوری نشد", str);

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
            if (TextBoxContractNo.Text.Trim() == "")
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("لطفا شماره قرارداد را پر نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SWarning);
                return false;
            }
            if (DatePickerContractDate.Value > DatePickerContractEndDate.Value)
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("تاریخ شروع نبایستی از تاریخ پایان بزرگتر باشد", MKH.Library.Clasess.MSSMessage.MessageType.SWarning);
                return false;
            }

            if (!_editIns)
            {
                string str = "";
                if (new ViewModel.DoctorsContracts.DoctorsContract().GetAllListByDoctorID(_doctor_Id, ref str).Where(ei =>
                    ei.ContractNo == TextBoxContractNo.Text).Count() > 0)
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View("شماره قرارداد تکراری می باشد", MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                    return false;
                }

                if (
                    new ViewModel.DoctorsContracts.DoctorsContract().GetAllListByDoctorID(_doctor_Id, ref str).Where(ei =>
                    KagNetComponents2.KagPersianDate.Parse(ei.ContractDate).MiladiDate > DatePickerContractDate.Value.MiladiDate &&
                    KagNetComponents2.KagPersianDate.Parse(ei.ContractDate).MiladiDate < DatePickerContractEndDate.Value.MiladiDate).Count() > 0 ||
                    new ViewModel.DoctorsContracts.DoctorsContract().GetAllListByDoctorID(_doctor_Id, ref str).Where(ei =>
                    KagNetComponents2.KagPersianDate.Parse(ei.ContractEndDate).MiladiDate > DatePickerContractDate.Value.MiladiDate &&
                    KagNetComponents2.KagPersianDate.Parse(ei.ContractEndDate).MiladiDate < DatePickerContractEndDate.Value.MiladiDate).Count() > 0 ||
                    new ViewModel.DoctorsContracts.DoctorsContract().GetAllListByDoctorID(_doctor_Id, ref str).Where(ei =>
                    KagNetComponents2.KagPersianDate.Parse(ei.ContractDate).MiladiDate < DatePickerContractDate.Value.MiladiDate &&
                    KagNetComponents2.KagPersianDate.Parse(ei.ContractEndDate).MiladiDate > DatePickerContractEndDate.Value.MiladiDate).Count() > 0)
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View("قرارداد فوق با تاریخ های مشابه جهت پزشک مذکور قبلا ثبت شده است", MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                    return false;
                }
            }

            if (_editIns)
            {
                string str = "";
                if (TextBoxContractNo.Text != TextBoxContractNo.Tag.ToString())
                    if (new ViewModel.DoctorsContracts.DoctorsContract().GetAllListByDoctorID(_doctor_Id, ref str).Where(ei =>
                        ei.ContractNo == TextBoxContractNo.Text).Count() > 0)
                    {
                        MKH.Library.Clasess.MSSMessage.MSSMessage_View("شماره قرارداد تکراری می باشد", MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                        return false;
                    }
                if (DatePickerContractDate.Value.ToString() != DatePickerContractDate.Tag.ToString())
                    if (DatePickerContractDate.Value.MiladiDate < KagNetComponents2.KagPersianDate.Parse(DatePickerContractDate.Tag.ToString()).MiladiDate ||
                        DatePickerContractDate.Value.MiladiDate > KagNetComponents2.KagPersianDate.Parse(DatePickerContractEndDate.Tag.ToString()).MiladiDate)
                        if (
                        new ViewModel.DoctorsContracts.DoctorsContract().GetAllListByDoctorID(_doctor_Id, ref str).Where(ei =>
                        KagNetComponents2.KagPersianDate.Parse(ei.ContractDate).MiladiDate < DatePickerContractDate.Value.MiladiDate &&
                        KagNetComponents2.KagPersianDate.Parse(ei.ContractEndDate).MiladiDate > DatePickerContractDate.Value.MiladiDate).Count() > 0)
                        {
                            MKH.Library.Clasess.MSSMessage.MSSMessage_View("قرارداد فوق با تاریخ های مشابه جهت پزشک مذکور قبلا ثبت شده است", MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                            return false;
                        }

                if (DatePickerContractEndDate.Value.ToString() != DatePickerContractEndDate.Tag.ToString())
                    if (DatePickerContractEndDate.Value.MiladiDate < KagNetComponents2.KagPersianDate.Parse(DatePickerContractDate.Tag.ToString()).MiladiDate ||
                        DatePickerContractEndDate.Value.MiladiDate > KagNetComponents2.KagPersianDate.Parse(DatePickerContractEndDate.Tag.ToString()).MiladiDate)
                        if (
                        new ViewModel.DoctorsContracts.DoctorsContract().GetAllListByDoctorID(_doctor_Id, ref str).Where(ei =>
                        KagNetComponents2.KagPersianDate.Parse(ei.ContractDate).MiladiDate < DatePickerContractEndDate.Value.MiladiDate &&
                        KagNetComponents2.KagPersianDate.Parse(ei.ContractEndDate).MiladiDate > DatePickerContractEndDate.Value.MiladiDate).Count() > 0)
                        {
                            MKH.Library.Clasess.MSSMessage.MSSMessage_View("قرارداد فوق با تاریخ های مشابه جهت پزشک مذکور قبلا ثبت شده است", MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                            return false;
                        }
            }

            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DoctorsContractAdd_Frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            string str = "";
            if (buttonItemOK.Enabled)
                new ViewModel.Basic.NODuplicateForm().DeleteEntity(this.Name, _id.ToString() + "_" + _doctor_Id.ToString(), ref str);
        }


    }
}
