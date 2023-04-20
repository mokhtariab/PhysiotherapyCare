using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using PhysiotherapyCare.Model.Patient;
using PhysiotherapyCare.Model.VisitPatient;

namespace PhysiotherapyCare.View.MainForms.Patient
{
    public partial class VisitPatientWithGroupAdd_Frm : MKH.Library.Forms.MSSBaseNew_frm
    {



        private List<PhysiotherapyCare.Other.Class.PatientListDefine> _patientListDefine;

        public VisitPatientWithGroupAdd_Frm()
        {
            InitializeComponent();
        }

        public VisitPatientWithGroupAdd_Frm(List<PhysiotherapyCare.Other.Class.PatientListDefine> PatientListDefine)
        {
            InitializeComponent();
            string str = "";
            _patientListDefine = PatientListDefine;
            TextBoxDoctor.Tag = _patientListDefine[0].Doctor_Id;
            TextBoxDoctor.Text = _patientListDefine[0].DoctorNameFamily;
        }
       
        private void VisitPatientWithGroupAdd_Frm_Load(object sender, EventArgs e)
        {
           DatePickerLetterDate.Value = DatePickerVisitDate.Value = KagNetComponents2.KagPersianDate.Parse(DateTime.Now);
        }

  
        



        #region ButtonMaster_Click
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckValidation())
                return;
            try
            {
                string str = ""; long? idSet = 0;
                
                List<TBL_VisitPatient> Ls = new List<TBL_VisitPatient>(1);

                for (int i = 0; i < _patientListDefine.Count; i++)
                {
                    TBL_VisitPatient VisitPatient = new TBL_VisitPatient();
                    VisitPatient.Id = 0;
                    VisitPatient.Patient_Id = _patientListDefine[i].PatientId;
                    VisitPatient.IssueArchive = TextBoxIssueArchive.Text;
                    VisitPatient.LetterNo = TextBoxLetterNo.Text;
                    VisitPatient.LetterDate = DatePickerLetterDate.Value.ToString().Substring(0, 10);
                    VisitPatient.VisitDate = DatePickerVisitDate.Value.ToString().Substring(0, 10);
                    if (!CheckBoxDoctor.Checked)
                        VisitPatient.Doctor_Id = _patientListDefine[i].Doctor_Id;
                    else
                        VisitPatient.Doctor_Id = Convert.ToInt32(TextBoxDoctor.Tag ?? "0");
                    

                    if (!CheckBoxBonyadAddEven.Checked)
                        VisitPatient.BonyadAddEven = _patientListDefine[i].BonyadAddEven;
                    else
                        VisitPatient.BonyadAddEven = Convert.ToInt16(ComboBoxBonyadAddEven.SelectedIndex);

                    VisitPatient.Description = TextBoxDescription.Text;
                    VisitPatient.VisitStatus_Id = 1;
                    VisitPatient.User_Id = MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID;
                    VisitPatient.ChangeDateTime = MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now);

                    Ls.Add(VisitPatient);
                }


                new ViewModel.VisitPatient.VisitPatient().InsertEntityGrouping(Ls, ref str, ref idSet);
                if (str != "")
                {
                    if (str.Contains("کدبیمار"))
                        MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, str + " تاریخ ویزیت تکراری دارند ");
                    else
                        MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "اشکال اطلاعات", str);
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

        private bool CheckValidation()
        {
            //string str = "";
            //if (TextBoxPatient.Text.Trim().Length == 0)
            //{
            //    MKH.Library.Clasess.MSSMessage.MSSMessage_View("لطفا نام بیمار را پر نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation);
            //    return false;
            //}

            if (CheckBoxDoctor.Checked)
                if (TextBoxDoctor.Text.Trim() == "")
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View("لطفا نام پزشک را پر نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                    return false;
                }
            if (CheckBoxBonyadAddEven.Checked && ComboBoxBonyadAddEven.SelectedIndex == -1)
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("لطفا زوج/فرد را پر نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                return false;
            }


            return true;
        }


        private void buttonDoctor_Click(object sender, EventArgs e)
        {
            
            try
            {
                string StrSet = "";
                Dictionary<string, string> SD = new Dictionary<string, string>();
                Dictionary<string, string> SD1 = new Dictionary<string, string>();

                foreach (var item in new ViewModel.Doctors.Doctor().GetAllList(ref StrSet))
                    SD.Add(item.Id.ToString(), item.DoctorName + " " + item.DoctorFamily);

                SD1 = MKH.Library.Forms.MSSSelector_frm.SetDataSelect(SD);
                TextBoxDoctor.Tag = SD1.Keys.ToList()[0];
                TextBoxDoctor.Text = SD1.Values.ToList()[0];
            }
            catch { }
        }
        #endregion

       private void CheckBoxBonyadAddEven_CheckedChanged(object sender, EventArgs e)
        {
            ComboBoxBonyadAddEven.Enabled = CheckBoxBonyadAddEven.Checked;
        }

       private void CheckBoxLetterDate_CheckedChanged(object sender, EventArgs e)
       {
           DatePickerLetterDate.Enabled = CheckBoxLetterDate.Checked;
       }

       private void CheckBoxLetterNo_CheckedChanged(object sender, EventArgs e)
       {
           TextBoxLetterNo.Enabled = CheckBoxLetterNo.Checked;
       }

       private void CheckBoxIssueArchive_CheckedChanged(object sender, EventArgs e)
       {
           TextBoxIssueArchive.Enabled = CheckBoxIssueArchive.Checked;
       }

       private void CheckBoxDoctor_CheckedChanged(object sender, EventArgs e)
       {
           buttonDoctor.Enabled = CheckBoxDoctor.Checked;

       }
    }
}
