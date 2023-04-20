using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using MKH.Library.Clasess;
using PhysiotherapyCare.Model.VisitHealthCare;


namespace PhysiotherapyCare.View.MainForms.VisitHealthCare
{
    public partial class VisitHealthCareAdd_Frm : MKH.Library.Forms.MSSBaseNew_frm
    {
        private long _id = 0;
        private int _patient_Id = 0;
        private bool _editIns = false;
        private string str = "";
        public VisitHealthCareAdd_Frm()
        {
            InitializeComponent();
        }


        public VisitHealthCareAdd_Frm(int Patient_Id, string EmptyStr)
        {
            InitializeComponent();
            _patient_Id = Patient_Id;
            ButtonPatient.Visible = false;
            string str = "";
            TextBoxPatient.Tag = new ViewModel.Patient.Patient().GetAllListByID(_patient_Id,ref str).Single().Id;
            TextBoxPatient.Text = new ViewModel.Patient.Patient().GetAllListByID(_patient_Id, ref str).Single().PatientName + " " + new ViewModel.Patient.Patient().GetAllListByID(_patient_Id, ref str).Single().PatientFamily;
        }

        public VisitHealthCareAdd_Frm(int Id, short VisitStatus_Id)
        {
            InitializeComponent();

            buttonItemOK.Enabled = (VisitStatus_Id == 1 || VisitStatus_Id == 4) && new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(130);
            if (buttonItemOK.Enabled)
            {
                string str = "";
                if (new ViewModel.Basic.NODuplicateForm().CheckNODuplicateForm("TBL_VisitHealthCare", Id.ToString(), ref str))
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View("امکان ویرایش به علت انجام عملیات توسط کاربر دیگر امکان پذیر نمی باشد", MKH.Library.Clasess.MSSMessage.MessageType.SWarning);
                    Close();
                }
                else
                    new ViewModel.Basic.NODuplicateForm().InsertEntity("TBL_VisitHealthCare", Id.ToString(), ref str);
            }

            _id = Id;
            _editIns = true;
            ButtonPatient.Visible = false;
        }

        private void VisitHealthCareAdd_Frm_Load(object sender, EventArgs e)
        {
            DatePickerLetterDate.Value = DatePickerRequestDate.Value = DatePickerHealthCareDate.Value = KagNetComponents2.KagPersianDate.Parse(DateTime.Now);

            if (_editIns) fillControl();
            else
                if (_patient_Id != 0) SetLastVisitHealth(_patient_Id);
        }


        private void SetLastVisitHealth(int PatientId)
        {
            string str = "";
            if (new ViewModel.VisitHealthCare.VisitHealthCare().GetAllList(ref str).Where(ei => ei.Patient_Id == PatientId).Count() > 0)
            {
                ViewModel.VisitHealthCare.VisitHealthCare RN = new ViewModel.VisitHealthCare.VisitHealthCare();
                List<VW_VisitHealthCare> VPC = RN.GetAllListByLastPatientID(PatientId, ref str);

                TextBoxPatient.Tag = VPC[0].Patient_Id;
                TextBoxPatient.Text = VPC[0].PatientName + " " + VPC[0].PatientFamily;

                TextBoxIssueArchive.Text = VPC[0].IssueArchive;

                TextBoxLetterNo.Text = VPC[0].LetterNo;
                DatePickerLetterDate.Value = KagNetComponents2.KagPersianDate.Parse(VPC[0].LetterDate.Substring(0, 10));

                TextBoxDoctor.Tag = VPC[0].Doctor_Id;
                TextBoxDoctor.Text = VPC[0].DoctorName + " " + VPC[0].DoctorFamily;

                try { DatePickerHealthCareDate.Value = KagNetComponents2.KagPersianDate.Parse(VPC[0].HealthCareDate); }
                catch { }
                try { DatePickerRequestDate.Value = KagNetComponents2.KagPersianDate.Parse(VPC[0].RequestDate); }
                catch { }
                TextBoxPatientProblem.Text = VPC[0].PatientProblem;
                TextBoxDescription.Text = VPC[0].Description;

                CheckBoxVisitStatus.Checked = VPC[0].VisitStatus_Id == 4;
            }
        }
        private void fillControl()
        {
            ViewModel.VisitHealthCare.VisitHealthCare RN = new ViewModel.VisitHealthCare.VisitHealthCare();
            List<VW_VisitHealthCare> U = RN.GetAllListByID(_id, ref str);

            TextBoxIssueArchive.Text = U[0].IssueArchive;

            TextBoxPatient.Tag = U[0].Patient_Id;
            TextBoxPatient.Text = U[0].PatientName + " " + U[0].PatientFamily;

            TextBoxLetterNo.Text = U[0].LetterNo;
            DatePickerLetterDate.Value = KagNetComponents2.KagPersianDate.Parse(U[0].LetterDate);

            TextBoxDoctor.Tag = U[0].Doctor_Id;
            TextBoxDoctor.Text = U[0].DoctorName + " " + U[0].DoctorFamily;

            TextBoxPatientProblem.Text = U[0].PatientProblem;
            DatePickerRequestDate.Value = KagNetComponents2.KagPersianDate.Parse(U[0].RequestDate);

            DatePickerHealthCareDate.Value = KagNetComponents2.KagPersianDate.Parse(U[0].HealthCareDate);
            TextBoxDescription.Text = U[0].Description;

            IntBoxSumServiceHealthCare.Value = U[0].SumServiceHealthCare;

            CheckBoxVisitStatus.Checked = U[0].VisitStatus_Id == 4;

            FillTableLayoutPanel(_id);
        }

        private void FillTableLayoutPanel(long VisitHealthCare_Id)
        {
            try
            {
                tableLayoutPanelNews.Controls.Clear();
                int i = 0;
                var collation = new ViewModel.VisitHealthCare.ServiceHealthCare().GetAllList(ref str).Where(d => d.VisitHealthCare_Id == VisitHealthCare_Id);
                foreach (var item in collation)
                {
                    VisitHealthCareDetail_UC smsp = new VisitHealthCareDetail_UC(VisitHealthCare_Id, item.ServiceTypeDsc_Id);
                    smsp.Tag = item.ServiceTypeDsc_Id;
                    smsp.Controls.Owner.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                    tableLayoutPanelNews.Controls.Add(smsp, 1, ++i);
                    //smsp.Enabled = !_outUse;
                }
            }
            catch (Exception ex)
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, ex.Message);
            }
            SetRowTableSet();
        }

        public int SetRowTableSet()
        {        
            int tableLayoutPanelRowCnt = 0;
            int SumServiceHealthCare = 0;

            foreach (Control fg in tableLayoutPanelNews.Controls)
                if ((fg as VisitHealthCareDetail_UC).Visible)
                {
                    (fg as VisitHealthCareDetail_UC).setRowNo(++tableLayoutPanelRowCnt);
                    SumServiceHealthCare += (fg as VisitHealthCareDetail_UC).getTotalPriceType();
                }
            IntBoxSumServiceHealthCare.Value = SumServiceHealthCare;
            return SumServiceHealthCare;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckValidation())
                return;
            try
            {
                long? idSet = 0;
                List<TBL_VisitHealthCare> Ls = new List<TBL_VisitHealthCare>(1);
                TBL_VisitHealthCare VisitHealthCare = new TBL_VisitHealthCare();
                VisitHealthCare.Id = _id;

                VisitHealthCare.Id = _id;
                VisitHealthCare.Patient_Id = Convert.ToInt32(TextBoxPatient.Tag ?? "0");
                VisitHealthCare.IssueArchive = TextBoxIssueArchive.Text;
                VisitHealthCare.LetterNo = TextBoxLetterNo.Text;
                VisitHealthCare.LetterDate = DatePickerLetterDate.Value.ToString().Substring(0, 10);
                VisitHealthCare.Doctor_Id = Convert.ToInt32(TextBoxDoctor.Tag ?? "0");

                VisitHealthCare.PatientProblem = TextBoxPatientProblem.Text;
               VisitHealthCare.RequestDate = DatePickerRequestDate.Value.ToString().Substring(0, 10);

                VisitHealthCare.HealthCareDate = DatePickerHealthCareDate.Value.ToString().Substring(0, 10);
                VisitHealthCare.Description = TextBoxDescription.Text;

                VisitHealthCare.VisitStatus_Id = 1;

                VisitHealthCare.User_Id = MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID;
                VisitHealthCare.ChangeDateTime = MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now);

                VisitHealthCare.VisitStatus_Id = Convert.ToInt16(CheckBoxVisitStatus.Checked == true ? 4 : 1);

                //VisitHealthCare.VisitHealthCareFew = 0;
                //foreach (Control fg in tableLayoutPanelNews.Controls)
                  //  if ((fg as PhysiotherapyCare.View.UserControls.VisitHealthCareDetail_UC).Visible)
                    //    VisitHealthCare.VisitHealthCareFew += 1;

                Ls.Add(VisitHealthCare);

                if (!_editIns)
                {
                    new ViewModel.VisitHealthCare.VisitHealthCare().InsertEntity(Ls, ref str, ref idSet);
                    SaveParametersUsercontrols(idSet.Value);
                }
                else
                {
                    new ViewModel.VisitHealthCare.VisitHealthCare().UpdateEntity(Ls, ref str);
                    SaveParametersUsercontrols(_id);
                }

                if (str != "")
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MSSMessage.MessageType.SError, false, "اشکال اطلاعات", str);
                else
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View("اطلاعات ذخیره شد", MKH.Library.Clasess.MSSMessage.MessageType.SInformation);
                    DialogResult = System.Windows.Forms.DialogResult.OK;
                    //ShowReport(_id);
                    Close();
                }
            }
            catch (Exception ex)
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "اشکال در ذخیره اطلاعات", ex.Message);
            }
        }

        private bool CheckParametersUsercontrols()
        {
            foreach (Control fg in tableLayoutPanelNews.Controls)
            {
                if ((fg as VisitHealthCareDetail_UC).Visible)
                    if (!(fg as VisitHealthCareDetail_UC).CheckvalidationUC())
                        return false;
            }
            return true;

        }

        private void SaveParametersUsercontrols(long VisitHealthCare_Id)
        {
            string str = "";
            new ViewModel.VisitHealthCare.ServiceHealthCare().ServiceHealthCareWithVisitHealthCareDelete(VisitHealthCare_Id, ref str);
            foreach (Control fg in tableLayoutPanelNews.Controls)
            {
                if ((fg as VisitHealthCareDetail_UC).Visible)
                    (fg as VisitHealthCareDetail_UC).save(VisitHealthCare_Id);
            }
        }



        private bool CheckValidation()
        {
            if (TextBoxPatient.Text.Trim() == "")
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("لطفا نام بیمار را پر نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                return false;
            }
            if (!CheckBoxVisitStatus.Checked)
            {
                if (TextBoxDoctor.Text.Trim() == "")
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View("لطفا نام بهیار را پر نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                    return false;
                }

                //if (!_editIns)
                //{
                //    if (new ViewModel.VisitHealthCare.VisitHealthCare().GetAllListByLastPatientID(TextBoxPatient.Tag.ToString().ToInt(), ref str).Where(ei =>
                //        ei.LetterNo == TextBoxLetterNo.Text).Count() > 0)
                //    {
                //        MKH.Library.Clasess.MSSMessage.MSSMessage_View("شماره نامه بنیاد تکراری می باشد", MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                //        return false;
                //    }
                //}
                if (SetRowTableSet() == 0)
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View("لطفا خدمات را پر نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                    return false;
                }
                else
                    if (!CheckParametersUsercontrols())
                    {
                        return false;
                    }
            }
            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAddNews_Click(object sender, EventArgs e)
        {
            VisitHealthCareDetail_UC SSUC = new VisitHealthCareDetail_UC();
            SSUC.Controls.Owner.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            tableLayoutPanelNews.Controls.Add(SSUC, 1, tableLayoutPanelNews.Controls.Count+1);
            SetRowTableSet();
        }

        private void ButtonPatient_Click(object sender, EventArgs e)
        {
            try
            {
                string StrSet = "";
                Dictionary<string, string> SD = new Dictionary<string, string>();
                Dictionary<string, string> SD1 = new Dictionary<string, string>();

                foreach (var item in new ViewModel.Patient.Patient().GetAllList(ref StrSet))
                    SD.Add(item.Id.ToString(), item.PatientName + " " + item.PatientFamily);

                SD1 = MKH.Library.Forms.MSSSelector_frm.SetDataSelect(SD);
                TextBoxPatient.Tag = SD1.Keys.ToList()[0];
                TextBoxPatient.Text = SD1.Values.ToList()[0];
                if (SD1 != null)
                    SetLastVisitHealth(SD1.Keys.ToList()[0].ToInt());
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

                foreach (var item in new ViewModel.Doctors.Doctor().GetAllList(ref StrSet))
                    SD.Add(item.Id.ToString(), item.DoctorName + " " + item.DoctorFamily);

                SD1 = MKH.Library.Forms.MSSSelector_frm.SetDataSelect(SD);
                TextBoxDoctor.Tag = SD1.Keys.ToList()[0];
                TextBoxDoctor.Text = SD1.Values.ToList()[0];
            }
            catch { }
        }

        private void VisitHealthCareAdd_Frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            string str = "";
            if (buttonItemOK.Enabled)
                new ViewModel.Basic.NODuplicateForm().DeleteEntity("TBL_VisitHealthCare", _id.ToString(), ref str);
        }



    }
}
