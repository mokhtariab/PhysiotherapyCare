using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using PhysiotherapyCare.ViewModel.VisitPatientPhysiotherapy;
using PhysiotherapyCare.Model.VisitPatientPhysiotherapy;
using PhysiotherapyCare.ViewModel.Basic;


namespace PhysiotherapyCare.View.MainForms.VisitPatientPhysiotherapy
{
    public partial class VisitPatientPhysiotherapyAdd_Frm : MKH.Library.Forms.MSSBaseNew_frm
    {
        private long _id = 0;
        private int _patient_Id = 0;
        private bool _editIns = false;


         public VisitPatientPhysiotherapyAdd_Frm()
        {
            InitializeComponent();
        }


         public VisitPatientPhysiotherapyAdd_Frm(int Patient_Id, string EmptyStr)
        {
            InitializeComponent();
            _patient_Id = Patient_Id;
            ButtonPatient.Visible = false;
            string str = "";
            TextBoxPatient.Tag = new ViewModel.Patient.Patient().GetAllListByID(_patient_Id,ref str).Single().Id;
            TextBoxPatient.Text = new ViewModel.Patient.Patient().GetAllListByID(_patient_Id, ref str).Single().PatientName + " " + new ViewModel.Patient.Patient().GetAllListByID(_patient_Id, ref str).Single().PatientFamily;
        }

         public VisitPatientPhysiotherapyAdd_Frm(int Id, short VisitStatus_Id)
         {
             InitializeComponent();

             buttonItemOK.Enabled = VisitStatus_Id == 1 && new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(53);
             if (buttonItemOK.Enabled)
             {
                 string str = "";
                 if (new ViewModel.Basic.NODuplicateForm().CheckNODuplicateForm("TBL_VisitPatientPhysiotherapy", Id.ToString(), ref str))
                 {
                     MKH.Library.Clasess.MSSMessage.MSSMessage_View("امکان ویرایش به علت انجام عملیات توسط کاربر دیگر امکان پذیر نمی باشد", MKH.Library.Clasess.MSSMessage.MessageType.SWarning);
                     Close();
                 }
                 else
                     new ViewModel.Basic.NODuplicateForm().InsertEntity("TBL_VisitPatientPhysiotherapy", Id.ToString(), ref str);
             }

             _id = Id;
             _editIns = true;
             ButtonPatient.Visible = false;
         }

        private void VisitPatientPhysiotherapyAdd_Frm_Load(object sender, EventArgs e)
        {
            DatePickerLetterDate.Value = DatePickerCordinateDate.Value = DatePickerBeginDate.Value = DatePickerEndDate.Value = KagNetComponents2.KagPersianDate.Parse(DateTime.Now);
            if (_editIns) fillControl();
            else
                if (_patient_Id != 0) SetLastVisitPhysiotherapy(_patient_Id);
        }


        private void SetLastVisitPhysiotherapy(int PatientId)
        {
            string str = "";
            if (new ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapy().GetAllList(ref str).Where(ei => ei.Patient_Id == PatientId).Count() > 0)
            {
                ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapy RN = new ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapy();
                List<VW_VisitPatientPhysiotherapy> VPC = RN.GetAllListByLastPatientID(PatientId, ref str);

                TextBoxPatient.Tag = VPC[0].Patient_Id;
                TextBoxPatient.Text = VPC[0].PatientName + " " + VPC[0].PatientFamily;

                TextBoxIssueArchive.Text = VPC[0].IssueArchive;

                TextBoxDoctor.Tag = VPC[0].Doctor_Id;
                TextBoxDoctor.Text = VPC[0].DoctorName + " " + VPC[0].DoctorFamily;

                TextBoxLetterNo.Text = VPC[0].LetterNo;
                DatePickerLetterDate.Value = KagNetComponents2.KagPersianDate.Parse(VPC[0].LetterDate.Substring(0, 10));


                DatePickerBeginDate.Value = KagNetComponents2.KagPersianDate.Parse(VPC[0].BeginDate);
                DatePickerEndDate.Value = KagNetComponents2.KagPersianDate.Parse(VPC[0].EndDate);

                try
                {
                    DatePickerCordinateDate.Value = KagNetComponents2.KagPersianDate.Parse(VPC[0].CordinateDate);
                }
                catch { }

                IntBoxVisitFew.Value = VPC[0].VisitFew;
                IntBoxVisitFewDoing.Value = VPC[0].VisitFewDoing;


                TextBoxPatientProblem.Text = VPC[0].PatientProblem;
                TextBoxPhysiotherapyType.Text = VPC[0].PhysiotherapyType;
                TextBoxDescription.Text = VPC[0].Description;

                CheckBoxVisitStatus.Checked = VPC[0].VisitStatus_Id == 4;

            }
        }

        private void fillControl()
        {
            string str = "";
            ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapy RN = new ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapy();
            List<VW_VisitPatientPhysiotherapy> U = RN.GetAllListByID(_id, ref str);

            TextBoxIssueArchive.Text = U[0].IssueArchive;
            
            TextBoxPatient.Tag = U[0].Patient_Id;
            TextBoxPatient.Text = U[0].PatientName + " " + U[0].PatientFamily;

            TextBoxLetterNo.Text = U[0].LetterNo;
            TextBoxLetterNo.Tag = U[0].LetterNo;//----ForCheck ReUse
            DatePickerLetterDate.Value = KagNetComponents2.KagPersianDate.Parse(U[0].LetterDate);

            TextBoxDoctor.Tag = U[0].Doctor_Id;
            TextBoxDoctor.Text = U[0].DoctorName + " " + U[0].DoctorFamily;

            TextBoxDoctorPhysio.Tag = U[0].DoctorPhysio_Id;
            TextBoxDoctorPhysio.Text = U[0].DoctorPhysioName + " " + U[0].DoctorPhysioFamily;

            CheckBoxVisitStatus.Checked = U[0].VisitStatus_Id == 4;

            TextBoxPatientProblem.Text = U[0].PatientProblem;
            TextBoxPhysiotherapyType.Text = U[0].PhysiotherapyType;
            DatePickerCordinateDate.Value = KagNetComponents2.KagPersianDate.Parse(U[0].CordinateDate);

            
            IntBoxVisitFew.Value = U[0].VisitFew;

            DatePickerBeginDate.Value = KagNetComponents2.KagPersianDate.Parse(U[0].BeginDate);
            DatePickerEndDate.Value = KagNetComponents2.KagPersianDate.Parse(U[0].EndDate);
            DatePickerBeginDate.Tag = KagNetComponents2.KagPersianDate.Parse(U[0].BeginDate);//----ForCheck ReUse
            DatePickerEndDate.Tag = KagNetComponents2.KagPersianDate.Parse(U[0].EndDate);//----ForCheck ReUse
            
            IntBoxVisitFewDoing.Value = U[0].VisitFewDoing;
            TextBoxDescription.Text = U[0].Description;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckValidation())
                return;
            try
            {
                string str = ""; long? idSet = 0;
                List<TBL_VisitPatientPhysiotherapy> Ls = new List<TBL_VisitPatientPhysiotherapy>(1);
                TBL_VisitPatientPhysiotherapy VisitPatientPhysiotherapy = new TBL_VisitPatientPhysiotherapy();
                VisitPatientPhysiotherapy.Id = _id;
                VisitPatientPhysiotherapy.Patient_Id = Convert.ToInt32(TextBoxPatient.Tag ?? "0");
                VisitPatientPhysiotherapy.IssueArchive = TextBoxIssueArchive.Text;
                VisitPatientPhysiotherapy.LetterNo = TextBoxLetterNo.Text;
                VisitPatientPhysiotherapy.LetterDate = DatePickerLetterDate.Value.ToString().Substring(0, 10);
                VisitPatientPhysiotherapy.Doctor_Id = Convert.ToInt32(TextBoxDoctor.Tag ?? "0");

                VisitPatientPhysiotherapy.DoctorPhysio_Id = Convert.ToInt32(TextBoxDoctorPhysio.Tag ?? "0");

                VisitPatientPhysiotherapy.PatientProblem = TextBoxPatientProblem.Text;
                VisitPatientPhysiotherapy.PhysiotherapyType = TextBoxPhysiotherapyType.Text;
                VisitPatientPhysiotherapy.CordinateDate = DatePickerCordinateDate.Value.ToString().Substring(0, 10);
                
                VisitPatientPhysiotherapy.VisitFew = Convert.ToInt16(IntBoxVisitFew.Value);
                VisitPatientPhysiotherapy.BeginDate = DatePickerBeginDate.Value.ToString().Substring(0, 10);
                VisitPatientPhysiotherapy.EndDate = DatePickerEndDate.Value.ToString().Substring(0, 10);
                VisitPatientPhysiotherapy.VisitFewDoing = Convert.ToInt16(IntBoxVisitFewDoing.Value);
                VisitPatientPhysiotherapy.Description = TextBoxDescription.Text;

                VisitPatientPhysiotherapy.VisitStatus_Id = Convert.ToInt16(CheckBoxVisitStatus.Checked == true ? 4: 1);

                VisitPatientPhysiotherapy.User_Id = MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID;
                VisitPatientPhysiotherapy.ChangeDateTime = MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now);



                Ls.Add(VisitPatientPhysiotherapy);

                if (!_editIns)
                {
                    new ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapy().InsertEntity(Ls, ref str, ref idSet);
                }
                else
                {
                    new ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapy().UpdateEntity(Ls, ref str);
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
            string str = "";
            if (TextBoxPatient.Text.Trim() == "")
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("لطفا نام بیمار را پر نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                return false;
            }
            if (!CheckBoxVisitStatus.Checked)
            {
                if (TextBoxDoctor.Text.Trim() == "")
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View("لطفا نام سرتیم فیزیوتراپ را پر نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                    return false;
                }
                if (IntBoxVisitFew.Text.Trim() == "0")
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View("لطفا تعداد جلسات را پر نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                    return false;
                }
            }

            if (!_editIns)
            {
                if (new ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapy().GetAllListByLastPatientID(TextBoxPatient.Tag.ToString().ToInt(), ref str).Where(ei =>
                    ei.LetterNo == TextBoxLetterNo.Text).Count() > 0)
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View("شماره نامه بنیاد تکراری می باشد", MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                    return false;
                }

                if (
                new ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapy().GetAllListByLastPatientID(TextBoxPatient.Tag.ToString().ToInt(), ref str).Where(ei =>
                KagNetComponents2.KagPersianDate.Parse(ei.BeginDate).MiladiDate > DatePickerBeginDate.Value.MiladiDate &&
                KagNetComponents2.KagPersianDate.Parse(ei.BeginDate).MiladiDate < DatePickerEndDate.Value.MiladiDate).Count() > 0 ||
                new ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapy().GetAllListByLastPatientID(TextBoxPatient.Tag.ToString().ToInt(), ref str).Where(ei =>
                KagNetComponents2.KagPersianDate.Parse(ei.EndDate).MiladiDate > DatePickerBeginDate.Value.MiladiDate &&
                KagNetComponents2.KagPersianDate.Parse(ei.EndDate).MiladiDate < DatePickerEndDate.Value.MiladiDate).Count() > 0 ||
                new ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapy().GetAllListByLastPatientID(TextBoxPatient.Tag.ToString().ToInt(), ref str).Where(ei =>
                KagNetComponents2.KagPersianDate.Parse(ei.BeginDate).MiladiDate < DatePickerBeginDate.Value.MiladiDate &&
                KagNetComponents2.KagPersianDate.Parse(ei.EndDate).MiladiDate > DatePickerEndDate.Value.MiladiDate).Count() > 0)
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View("قرارداد فوق با تاریخ های مشابه جهت بیمار مذکور قبلا ثبت شده است", MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                    return false;
                }
            }

            if (_editIns)
            {
                if (TextBoxLetterNo.Text != TextBoxLetterNo.Tag.ToString())
                    if (new ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapy().GetAllListByLastPatientID(TextBoxPatient.Tag.ToString().ToInt(), ref str).Where(ei =>
                        ei.LetterNo == TextBoxLetterNo.Text).Count() > 0)
                    {
                        MKH.Library.Clasess.MSSMessage.MSSMessage_View("شماره نامه بنیاد تکراری می باشد", MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                        return false;
                    }
                if (DatePickerBeginDate.Value.ToString() != DatePickerBeginDate.Tag.ToString())
                    if (DatePickerBeginDate.Value.MiladiDate < KagNetComponents2.KagPersianDate.Parse(DatePickerBeginDate.Tag.ToString()).MiladiDate ||
                        DatePickerBeginDate.Value.MiladiDate > KagNetComponents2.KagPersianDate.Parse(DatePickerEndDate.Tag.ToString()).MiladiDate)
                        if (
                        new ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapy().GetAllListByLastPatientID(TextBoxPatient.Tag.ToString().ToInt(), ref str).Where(ei =>
                        KagNetComponents2.KagPersianDate.Parse(ei.BeginDate).MiladiDate < DatePickerBeginDate.Value.MiladiDate &&
                        KagNetComponents2.KagPersianDate.Parse(ei.EndDate).MiladiDate > DatePickerBeginDate.Value.MiladiDate).Count() > 0)
                        {
                            MKH.Library.Clasess.MSSMessage.MSSMessage_View("قرارداد فوق با تاریخ های مشابه جهت بیمار مذکور قبلا ثبت شده است", MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                            return false;
                        }

                if (DatePickerEndDate.Value.ToString() != DatePickerEndDate.Tag.ToString())
                    if (DatePickerEndDate.Value.MiladiDate < KagNetComponents2.KagPersianDate.Parse(DatePickerBeginDate.Tag.ToString()).MiladiDate ||
                        DatePickerEndDate.Value.MiladiDate > KagNetComponents2.KagPersianDate.Parse(DatePickerEndDate.Tag.ToString()).MiladiDate)
                        if (
                        new ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapy().GetAllListByLastPatientID(TextBoxPatient.Tag.ToString().ToInt(), ref str).Where(ei =>
                        KagNetComponents2.KagPersianDate.Parse(ei.BeginDate).MiladiDate < DatePickerEndDate.Value.MiladiDate &&
                        KagNetComponents2.KagPersianDate.Parse(ei.EndDate).MiladiDate > DatePickerEndDate.Value.MiladiDate).Count() > 0)
                        {
                            MKH.Library.Clasess.MSSMessage.MSSMessage_View("قرارداد فوق با تاریخ های مشابه جهت بیمار مذکور قبلا ثبت شده است", MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                            return false;
                        }
            }

           


            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonPatient_Click(object sender, EventArgs e)
        {
            try
            {
                string StrSet = "";
                Dictionary<string, string> SD = new Dictionary<string, string>();
                Dictionary<string, string> SD1 = new Dictionary<string, string>();

                foreach (var item in new ViewModel.Patient.Patient().GetAllList(ref StrSet).Where(j => j.Active == true))
                    SD.Add(item.Id.ToString(), item.PatientName + " " + item.PatientFamily);

                SD1 = MKH.Library.Forms.MSSSelector_frm.SetDataSelect(SD);
                TextBoxPatient.Tag = SD1.Keys.ToList()[0];
                TextBoxPatient.Text = SD1.Values.ToList()[0];

                if (SD1 != null)
                    SetLastVisitPhysiotherapy(SD1.Keys.ToList()[0].ToInt());
            }
            catch { }
        }

        private void buttonDoctor_Click(object sender, EventArgs e)
        {
            try
            {
                string StrSet = "";
                Dictionary<string, string> SD = new Dictionary<string, string>();
                Dictionary<string, string> SD1 = new Dictionary<string, string>();

                foreach (var item in new ViewModel.Doctors.Doctor().GetAllList(ref StrSet).Where(j => j.Active == true))
                    SD.Add(item.Id.ToString(), item.DoctorName + " " + item.DoctorFamily);

                SD1 = MKH.Library.Forms.MSSSelector_frm.SetDataSelect(SD);
                TextBoxDoctor.Tag = SD1.Keys.ToList()[0];
                TextBoxDoctor.Text = SD1.Values.ToList()[0];
            }
            catch { }
        }

        private void IntBoxVisitFew_ValueChanged(object sender, EventArgs e)
        {
            //DatePickerBeginDate.Value = DatePickerLetterDate.Value.AddDays(1);
            DatePickerEndDate.Value = DatePickerBeginDate.Value.AddDays(IntBoxVisitFew.Value.ToString().ToInt());
        }

        private void DatePickerBeginDate_ValueChanged(object sender, KagNetComponents2.PersianMonthCalendarEventArgs e)
        {
            DatePickerEndDate.Value = DatePickerBeginDate.Value.AddDays(IntBoxVisitFew.Value.ToString().ToInt());
        }

        private void buttonDoctorPhysio_Click(object sender, EventArgs e)
        {
            try
            {
                string StrSet = "";
                Dictionary<string, string> SD = new Dictionary<string, string>();
                Dictionary<string, string> SD1 = new Dictionary<string, string>();

                foreach (var item in new ViewModel.Doctors.Doctor().GetAllList(ref StrSet).Where(j => j.Active == true))
                    SD.Add(item.Id.ToString(), item.DoctorName + " " + item.DoctorFamily);

                SD1 = MKH.Library.Forms.MSSSelector_frm.SetDataSelect(SD);
                TextBoxDoctorPhysio.Tag = SD1.Keys.ToList()[0];
                TextBoxDoctorPhysio.Text = SD1.Values.ToList()[0];
            }
            catch { }
        }

        private void VisitPatientPhysiotherapyAdd_Frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            string str = "";
            if (buttonItemOK.Enabled)
                new ViewModel.Basic.NODuplicateForm().DeleteEntity("TBL_VisitPatientPhysiotherapy", _id.ToString(), ref str);
        }



    }
}
