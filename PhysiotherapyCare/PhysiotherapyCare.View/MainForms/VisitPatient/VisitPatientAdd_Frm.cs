using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using PhysiotherapyCare.ViewModel.Basic;
using PhysiotherapyCare.Model.VisitPatient;
using MKH.Library.Clasess.FilterClass;

namespace PhysiotherapyCare.View.MainForms.VisitPatient
{
    public partial class VisitPatientAdd_Frm : MKH.Library.Forms.MSSBaseNew_frm
    {
        private long _id = 0;
        private long _visitpatient_Id = 0;
        private int _patient_Id = 0;
        private bool _editIns = false;

        public VisitPatientAdd_Frm()
        {
            InitializeComponent();
            mssGroupPanel3.Enabled = false;
        }
        //for Create with patientId(pation is valid)

        public VisitPatientAdd_Frm(int Patient_Id, string EmptyStr)
        {
            InitializeComponent();

            mssGroupPanel3.Enabled = false;
            _patient_Id = Patient_Id;
            ButtonPatient.Visible = false;
            string str = "";



            TextBoxPatient.Tag = _patient_Id;
            TextBoxPatient.Text = new ViewModel.Patient.Patient().GetAllListByID(_patient_Id, ref str).Single().PatientName + " " + new ViewModel.Patient.Patient().GetAllListByID(_patient_Id, ref str).Single().PatientFamily;
        }
        //Edit
        public VisitPatientAdd_Frm(long Id, short VisitStatus_Id)
        {
            InitializeComponent();

            buttonItemOK.Enabled = VisitStatus_Id == 1 && new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(213);
            ButtonDrug.Enabled = ButtonBedsore.Enabled = ButtonEquipmentUse.Enabled = ButtonParaclinic.Enabled = ButtonSickness.Enabled = ButtonVaccination.Enabled = buttonItemOK.Enabled;
            if (buttonItemOK.Enabled)
            {
                string str = "";
                if (new ViewModel.Basic.NODuplicateForm().CheckNODuplicateForm("TBL_VisitPatient", Id.ToString(), ref str))
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View("امکان ویرایش به علت انجام عملیات توسط کاربر دیگر امکان پذیر نمی باشد", MKH.Library.Clasess.MSSMessage.MessageType.SWarning);
                    Close();
                }
                else
                    new ViewModel.Basic.NODuplicateForm().InsertEntity("TBL_VisitPatient", Id.ToString(), ref str);
            }


            _id = Id;
            _editIns = true;
            ButtonPatient.Visible = false;
        }
        //load
        private void VisitPatientAdd_Frm_Load(object sender, EventArgs e)
        {
            DatePickerLetterDate.Value = DatePickerVisitDate.Value = KagNetComponents2.KagPersianDate.Parse(DateTime.Now);
            if (_editIns)
            {
                mssGroupPanel3.Enabled = true;
                fillControl();

            }
        }

        //read of DB to Ui
        private void fillControl()
        {
            string str = "";
            ViewModel.VisitPatient.VisitPatient RN = new ViewModel.VisitPatient.VisitPatient();
            List<VW_VisitPatient> U = RN.GetAllListByID(_id, ref str);

            TextBoxIssueArchive.Text = U[0].IssueArchive;

            TextBoxPatient.Tag = U[0].Patient_Id;
            TextBoxPatient.Text = U[0].PatientName + " " + U[0].PatientFamily;

            TextBoxLetterNo.Text = U[0].LetterNo;
            TextBoxLetterNo.Tag = U[0].LetterNo;//----ForCheck ReUse
            DatePickerLetterDate.Value = KagNetComponents2.KagPersianDate.Parse(U[0].LetterDate);
            DatePickerVisitDate.Value = KagNetComponents2.KagPersianDate.Parse(U[0].VisitDate);

            TextBoxDoctor.Tag = U[0].Doctor_Id;
            TextBoxDoctor.Text = U[0].DoctorName + " " + U[0].DoctorFamily;

            TextBoxStateSicknessDsc.Text = U[0].StateSicknessDsc;
            TextBoxParaclinicDsc.Text = U[0].ParaclinicDsc;
            TextBoxDrugsDsc.Text = U[0].DrugsDsc;
            TextBoxBedsoreDsc.Text = U[0].BedsoreDsc;
            TextBoxVaccinationDsc.Text = U[0].VaccinationDsc;
            TextBoxEquipmentUseDsc.Text = U[0].EquipmentUseDsc;
            //توضیحات مربوط به این ای دی را می آوریم


            TextBoxDescription.Text = U[0].Description;
            ComboBoxBonyadAddEven.SelectedIndex = U[0].BonyadAddEven.Value;


            //setSicknessDesc();
            //setParaclinicDesc();
            //setDrugDesc();
            //setVaccinationDesc();
            //setEquipmentUseDesc();
            //setBedsoreDesc();
        }
        //To DB


        #region setDetailDesc
        //private void setSicknessDesc()
        //{
            
        //    string str = string.Empty;
            
        //    List<QueryFilter.ExpressionBuilder.Filter> filter = new List<QueryFilter.ExpressionBuilder.Filter>();

        //    filter.Add(new QueryFilter.ExpressionBuilder.Filter
        //    {
        //        PropertyName = "VisitPatient_Id",
        //        Operation = QueryFilter.ExpressionBuilder.Op.Equals,
        //        Value = _id,
        //        OperationFilter = QueryFilter.ExpressionBuilder.OpFilter.And
        //    }

        //    );

        //    var lSQ = new ViewModel.VisitPatient.SicknessVisitPatient().GetAllListByFilter(filter, ref str);

        //    if (lSQ.Count != 0)
        //    {
        //        foreach (var item in lSQ)
        //        {
        //            TextBoxStateSicknessDsc.Text += item.SicknessName + " " + item.SicknessDetailName+ " , " ;

        //        }
        //    }
        //}
        //private void setParaclinicDesc()
        //{
           
        //    string str = string.Empty;
           
        //    List<QueryFilter.ExpressionBuilder.Filter> filter = new List<QueryFilter.ExpressionBuilder.Filter>();

        //    filter.Add(new QueryFilter.ExpressionBuilder.Filter
        //    {
        //        PropertyName = "VisitPatient_Id",
        //        Operation = QueryFilter.ExpressionBuilder.Op.Equals,
        //        Value = _id,
        //        OperationFilter = QueryFilter.ExpressionBuilder.OpFilter.And
        //    }

        //    );

        //    var lSQ = new ViewModel.VisitPatient.ParaclinicVisitPatient().GetAllListByFilter(filter, ref str);

        //    if (lSQ.Count != 0)
        //    {
        //        foreach (var item in lSQ)
        //        {
        //            TextBoxParaclinicDsc.Text += item.ParaclinicName + "  " + item.Description + " , ";

        //        }
        //    }
        //}
        //private void setDrugDesc()
        //{
           
        //    string str = string.Empty;
           
        //    List<QueryFilter.ExpressionBuilder.Filter> filter = new List<QueryFilter.ExpressionBuilder.Filter>();

        //    filter.Add(new QueryFilter.ExpressionBuilder.Filter
        //    {
        //        PropertyName = "VisitPatient_Id",
        //        Operation = QueryFilter.ExpressionBuilder.Op.Equals,
        //        Value = _id,
        //        OperationFilter = QueryFilter.ExpressionBuilder.OpFilter.And
        //    }

        //    );

        //    var lSQ = new ViewModel.VisitPatient.DrugVisitPatient().GetAllListByFilter(filter, ref str);

        //    if (lSQ.Count != 0)
        //    {
        //        foreach (var item in lSQ)
        //        {
        //            TextBoxDrugsDsc.Text += item.DrugName + "  " + item.UseAmount + " , ";

        //        }
        //    }
        //}
        //private void setVaccinationDesc()
        //{
          
        //    string str = string.Empty;
          
        //    List<QueryFilter.ExpressionBuilder.Filter> filter = new List<QueryFilter.ExpressionBuilder.Filter>();

        //    filter.Add(new QueryFilter.ExpressionBuilder.Filter
        //    {
        //        PropertyName = "VisitPatient_Id",
        //        Operation = QueryFilter.ExpressionBuilder.Op.Equals,
        //        Value = _id,
        //        OperationFilter = QueryFilter.ExpressionBuilder.OpFilter.And
        //    }

        //    );

        //    var lSQ = new ViewModel.VisitPatient.VaccinationVisitPatient().GetAllListByFilter(filter, ref str);

        //    if (lSQ.Count != 0)
        //    {
        //        foreach (var item in lSQ)
        //        {
        //            TextBoxVaccinationDsc.Text += item.VaccinationName + "  " + item.Few + " , ";

        //        }
        //    }
        //}
        //private void setEquipmentUseDesc()
        //{
            
        //    string str = string.Empty;
            
        //    List<QueryFilter.ExpressionBuilder.Filter> filter = new List<QueryFilter.ExpressionBuilder.Filter>();

        //    filter.Add(new QueryFilter.ExpressionBuilder.Filter
        //    {
        //        PropertyName = "VisitPatient_Id",
        //        Operation = QueryFilter.ExpressionBuilder.Op.Equals,
        //        Value = _id,
        //        OperationFilter = QueryFilter.ExpressionBuilder.OpFilter.And
        //    }

        //    );

        //    var lSQ = new ViewModel.VisitPatient.EquipmentUseVisitPatient().GetAllListByFilter(filter, ref str);

        //    if (lSQ.Count != 0)
        //    {
        //        foreach (var item in lSQ)
        //        {
        //            TextBoxEquipmentUseDsc.Text += item.EquipmentUseName + "  " + item.Few + " , ";

        //        }
        //    }
        //}

        //private void setBedsoreDesc()
        //{

        //    string str = string.Empty;

        //    List<QueryFilter.ExpressionBuilder.Filter> filter = new List<QueryFilter.ExpressionBuilder.Filter>();

        //    filter.Add(new QueryFilter.ExpressionBuilder.Filter
        //    {
        //        PropertyName = "VisitPatient_Id",
        //        Operation = QueryFilter.ExpressionBuilder.Op.Equals,
        //        Value = _id,
        //        OperationFilter = QueryFilter.ExpressionBuilder.OpFilter.And
        //    }

        //    );

        //    var lSQ = new ViewModel.VisitPatient.BedsoreVisitPatient().GetAllListByFilter(filter, ref str);

        //    if (lSQ.Count != 0)
        //    {
        //        foreach (var item in lSQ)
        //        {
        //            TextBoxBedsoreDsc.Text += item.BedsoreDeep + "  " + item.BedsoreGrade + " , ";

        //        }
        //    }
        //}
        #endregion





        //check null
        private bool CheckValidation()
        {
            string str = "";
            if (TextBoxPatient.Text.Trim().Length == 0)
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("لطفا نام بیمار را پر نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                return false;
            }
            if (TextBoxDoctor.Text.Trim() == "")
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("لطفا نام پزشک را پر نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                return false;
            }

            if (!_editIns)
            {
                if (new ViewModel.VisitPatient.VisitPatient().GetAllListByLastPatientID(TextBoxPatient.Tag.ToString().ToInt(), ref str).Where(ei =>
                    ei.LetterNo == TextBoxLetterNo.Text).Count() > 0)
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View("شماره نامه بنیاد تکراری می باشد", MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                    return false;
                }

                //if
                //    (
                //new ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapy().GetAllListByLastPatientID(TextBoxPatient.Tag.ToString().ToInt(), ref str).Where(ei =>
                //KagNetComponents2.KagPersianDate.Parse(ei.BeginDate).MiladiDate > DatePickerBeginDate.Value.MiladiDate &&
                //KagNetComponents2.KagPersianDate.Parse(ei.BeginDate).MiladiDate < DatePickerEndDate.Value.MiladiDate).Count() > 0 ||
                //new ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapy().GetAllListByLastPatientID(TextBoxPatient.Tag.ToString().ToInt(), ref str).Where(ei =>
                //KagNetComponents2.KagPersianDate.Parse(ei.EndDate).MiladiDate > DatePickerBeginDate.Value.MiladiDate &&
                //KagNetComponents2.KagPersianDate.Parse(ei.EndDate).MiladiDate < DatePickerEndDate.Value.MiladiDate).Count() > 0 ||
                //new ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapy().GetAllListByLastPatientID(TextBoxPatient.Tag.ToString().ToInt(), ref str).Where(ei =>
                //KagNetComponents2.KagPersianDate.Parse(ei.BeginDate).MiladiDate < DatePickerBeginDate.Value.MiladiDate &&
                //KagNetComponents2.KagPersianDate.Parse(ei.EndDate).MiladiDate > DatePickerEndDate.Value.MiladiDate).Count() > 0)
                //{
                //    MKH.Library.Clasess.MSSMessage.MSSMessage_View("قرارداد فوق با تاریخ های مشابه جهت بیمار مذکور قبلا ثبت شده است", MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                //    return false;
                //}
            }

            if (_editIns)
            {
                if (TextBoxLetterNo.Text != TextBoxLetterNo.Tag.ToString())
                    if (new ViewModel.VisitPatient.VisitPatient().GetAllListByLastPatientID(TextBoxPatient.Tag.ToString().ToInt(), ref str).Where(ei =>
                        ei.LetterNo == TextBoxLetterNo.Text).Count() > 0)
                    {
                        MKH.Library.Clasess.MSSMessage.MSSMessage_View("شماره نامه بنیاد تکراری می باشد", MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                        return false;
                    }
                //if (DatePickerBeginDate.Value.ToString() != DatePickerBeginDate.Tag.ToString())
                //    if (DatePickerBeginDate.Value.MiladiDate < KagNetComponents2.KagPersianDate.Parse(DatePickerBeginDate.Tag.ToString()).MiladiDate ||
                //        DatePickerBeginDate.Value.MiladiDate > KagNetComponents2.KagPersianDate.Parse(DatePickerEndDate.Tag.ToString()).MiladiDate)
                //        if (
                //        new ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapy().GetAllListByLastPatientID(TextBoxPatient.Tag.ToString().ToInt(), ref str).Where(ei =>
                //        KagNetComponents2.KagPersianDate.Parse(ei.BeginDate).MiladiDate < DatePickerBeginDate.Value.MiladiDate &&
                //        KagNetComponents2.KagPersianDate.Parse(ei.EndDate).MiladiDate > DatePickerBeginDate.Value.MiladiDate).Count() > 0)
                //        {
                //            MKH.Library.Clasess.MSSMessage.MSSMessage_View("قرارداد فوق با تاریخ های مشابه جهت بیمار مذکور قبلا ثبت شده است", MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                //            return false;
                //        }

                //if (DatePickerEndDate.Value.ToString() != DatePickerEndDate.Tag.ToString())
                //    if (DatePickerEndDate.Value.MiladiDate < KagNetComponents2.KagPersianDate.Parse(DatePickerBeginDate.Tag.ToString()).MiladiDate ||
                //        DatePickerEndDate.Value.MiladiDate > KagNetComponents2.KagPersianDate.Parse(DatePickerEndDate.Tag.ToString()).MiladiDate)
                //        if (
                //        new ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapy().GetAllListByLastPatientID(TextBoxPatient.Tag.ToString().ToInt(), ref str).Where(ei =>
                //        KagNetComponents2.KagPersianDate.Parse(ei.BeginDate).MiladiDate < DatePickerEndDate.Value.MiladiDate &&
                //        KagNetComponents2.KagPersianDate.Parse(ei.EndDate).MiladiDate > DatePickerEndDate.Value.MiladiDate).Count() > 0)
                //        {
                //            MKH.Library.Clasess.MSSMessage.MSSMessage_View("قرارداد فوق با تاریخ های مشابه جهت بیمار مذکور قبلا ثبت شده است", MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                //            return false;
                //        }
            }

            //if (IntBoxVisitFew.Text.Trim() == "0")
            //{
            //    MKH.Library.Clasess.MSSMessage.MSSMessage_View("لطفا تعداد جلسات را پر نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation);
            //    return false;
            //}

            return true;
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
                TBL_VisitPatient VisitPatient = new TBL_VisitPatient();
                VisitPatient.Id = _id;
                VisitPatient.Patient_Id = Convert.ToInt32(TextBoxPatient.Tag ?? "0");
                VisitPatient.IssueArchive = TextBoxIssueArchive.Text;
                VisitPatient.LetterNo = TextBoxLetterNo.Text;
                VisitPatient.LetterDate = DatePickerLetterDate.Value.ToString().Substring(0, 10);
                VisitPatient.VisitDate = DatePickerVisitDate.Value.ToString().Substring(0, 10);
                VisitPatient.Doctor_Id = Convert.ToInt32(TextBoxDoctor.Tag ?? "0");

                VisitPatient.StateSicknessDsc = TextBoxStateSicknessDsc.Text;
                VisitPatient.ParaclinicDsc = TextBoxParaclinicDsc.Text;
                VisitPatient.DrugsDsc = TextBoxDrugsDsc.Text;
                VisitPatient.BedsoreDsc = TextBoxBedsoreDsc.Text;
                VisitPatient.VaccinationDsc = TextBoxVaccinationDsc.Text;
                VisitPatient.EquipmentUseDsc = TextBoxEquipmentUseDsc.Text;
                VisitPatient.BonyadAddEven = Convert.ToInt16(ComboBoxBonyadAddEven.SelectedIndex);

                VisitPatient.Description = TextBoxDescription.Text;
                VisitPatient.VisitStatus_Id = 1;
                VisitPatient.User_Id = MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID;
                VisitPatient.ChangeDateTime = MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now);



                Ls.Add(VisitPatient);

                if (!_editIns)
                {
                    new ViewModel.VisitPatient.VisitPatient().InsertEntity(Ls, ref str, ref idSet);
                }
                else
                {
                    new ViewModel.VisitPatient.VisitPatient().UpdateEntity(Ls, ref str);
                }
                if (str != "")
                {
                    if (str.Contains("Duplicated Row! VisitDate") || str.Contains("Duplicated Row!Update VisitDate"))
                        MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "تاریخ ویزیت تکراری است", str);
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
                MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "اشکال اطلاعات", ex.Message);
            }

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

                foreach (var item in new ViewModel.Patient.Patient().GetAllList(ref StrSet))
                    SD.Add(item.Id.ToString(), item.PatientName + " " + item.PatientFamily);

                SD1 = MKH.Library.Forms.MSSSelector_frm.SetDataSelect(SD);
                TextBoxPatient.Tag = SD1.Keys.ToList()[0];
                TextBoxPatient.Text = SD1.Values.ToList()[0];
            }
            catch
            {

            }
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

        #region ButtonDetial_Click
        private void ButtonSickness_Click(object sender, EventArgs e)
        {
            try
            {
                SicknessVisitPatientAdd_Frm frm_SicknessAdd = new SicknessVisitPatientAdd_Frm(_id, "");
                if (frm_SicknessAdd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    TextBoxStateSicknessDsc.ResetText();
                    string str = string.Empty;
                    var collation = new ViewModel.VisitPatient.SicknessVisitPatient().GetAllList(ref str).Where(d => d.VisitPatient_Id == _id);
                    foreach (var item in collation)
                        TextBoxStateSicknessDsc.Text += item.SicknessName + "-" + item.SicknessDetailName + (item.Description == "" ? "" : "-") + item.Description + ",       ";
                }
                string str1 = "";
                new ViewModel.VisitPatient.VisitPatient().UpdateEntityWithFieldValue(_id, "StateSicknessDsc", TextBoxStateSicknessDsc.Text, MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID, MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str1);
            }
            catch { }
        }

        private void ButtonParaclinic_Click(object sender, EventArgs e)
        {
            try
            {
                ParaclinicAdd_Frm frm_ParaclinicAdd = new ParaclinicAdd_Frm(_id, "");
                if (frm_ParaclinicAdd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    TextBoxParaclinicDsc.ResetText();
                    string str = string.Empty;
                    var collation = new ViewModel.VisitPatient.ParaclinicVisitPatient().GetAllList(ref str).Where(d => d.VisitPatient_Id == _id);
                    foreach (var item in collation)
                        TextBoxParaclinicDsc.Text += item.ParaclinicName + (item.ParaclinicsState == "" ? "" : "-") + item.ParaclinicsState + (item.Description == "" ? "" : "-") + item.Description + ",       ";
                }
                string str1 = "";
                new ViewModel.VisitPatient.VisitPatient().UpdateEntityWithFieldValue(_id, "ParaclinicDsc", TextBoxParaclinicDsc.Text, MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID, MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str1);

            }
            catch { }
        }

        private void ButtonDrug_Click(object sender, EventArgs e)
        {
            try
            {
                DrugAdd_Frm frm_DrugAdd = new DrugAdd_Frm(_id, "");
                if (frm_DrugAdd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    TextBoxDrugsDsc.ResetText();
                    string str = string.Empty;
                    var collation = new ViewModel.VisitPatient.DrugVisitPatient().GetAllList(ref str).Where(d => d.VisitPatient_Id == _id);
                    foreach (var item in collation)
                        TextBoxDrugsDsc.Text += item.DrugName + "-" + item.UseAmount + (item.Description == "" ? "" : "-") + item.Description + ",         ";
                }
                string str1 = "";
                new ViewModel.VisitPatient.VisitPatient().UpdateEntityWithFieldValue(_id, "DrugsDsc", TextBoxDrugsDsc.Text, MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID, MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str1);
            }
            catch { }
        }


        private void ButtonVaccination_Click(object sender, EventArgs e)
        {
            try
            {
                VaccinationAdd_Frm frm_DrugAdd = new VaccinationAdd_Frm(_id, "");
                if (frm_DrugAdd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    TextBoxVaccinationDsc.ResetText();
                    string str = string.Empty;
                    var collation = new ViewModel.VisitPatient.VaccinationVisitPatient().GetAllList(ref str).Where(d => d.VisitPatient_Id == _id);
                    foreach (var item in collation)
                        TextBoxVaccinationDsc.Text += item.VaccinationName + "-" + item.Few + (item.Description == "" ? "" : "-") + item.Description + ",     ";
                }
                string str1 = "";
                new ViewModel.VisitPatient.VisitPatient().UpdateEntityWithFieldValue(_id, "VaccinationDsc", TextBoxVaccinationDsc.Text, MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID, MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str1);
            }
            catch { }
        }

        private void ButtonEquipmentUse_Click(object sender, EventArgs e)
        {

            try
            {
                EquipmentUseAdd_Frm frm_DrugAdd = new EquipmentUseAdd_Frm(_id, "");
                if (frm_DrugAdd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    TextBoxEquipmentUseDsc.ResetText();
                    string str = string.Empty;
                    var collation = new ViewModel.VisitPatient.EquipmentUseVisitPatient().GetAllList(ref str).Where(d => d.VisitPatient_Id == _id);
                    foreach (var item in collation)
                        TextBoxEquipmentUseDsc.Text += item.EquipmentUseName + "-" + item.Few + (item.Description == "" ? "" : "-") + item.Description + ",       ";
                }
                string str1 = "";
                new ViewModel.VisitPatient.VisitPatient().UpdateEntityWithFieldValue(_id, "EquipmentUseDsc", TextBoxEquipmentUseDsc.Text, MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID, MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str1);
            }
            catch { }
        }

        

        private void ButtonBedsore_Click(object sender, EventArgs e)
        {
            try
            {
                BedsoreAdd_Frm frm_BedsoreAdd = new BedsoreAdd_Frm(_id, "");
                if (frm_BedsoreAdd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    TextBoxBedsoreDsc.ResetText();
                    string str = string.Empty;
                    var collation = new ViewModel.VisitPatient.BedsoreVisitPatient().GetAllList(ref str).Where(d => d.VisitPatient_Id == _id);
                    foreach (var item in collation)
                        TextBoxBedsoreDsc.Text += item.BedsorePosition + (item.BedsoreMeasurement == 0 ? "" : "-") + item.BedsoreMeasurement + (item.BedsoreDeep == "" ? "" : "-") + item.BedsoreDeep + (item.BedsoreGrade == "" ? "" : "-") + item.BedsoreGrade + (item.BedsoreStartTime == "" ? "" : "-") + item.BedsoreStartTime + (item.BedsoreRemain == "" ? "" : "-") + item.BedsoreRemain + (item.Description == "" ? "" : "-") + item.Description + ",     ";
                }
                string str1 = "";
                new ViewModel.VisitPatient.VisitPatient().UpdateEntityWithFieldValue(_id, "BedsoreDsc", TextBoxBedsoreDsc.Text, MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID, MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now), ref str1);
            }
            catch { }
        }

        #endregion

        private void VisitPatientAdd_Frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            string str = "";
            if (buttonItemOK.Enabled)
                new ViewModel.Basic.NODuplicateForm().DeleteEntity("TBL_VisitPatient", _id.ToString(), ref str);
        }
    }
}
