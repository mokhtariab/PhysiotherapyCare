using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using MKH.Library.Clasess;
using PhysiotherapyCare.Model.Status;


namespace PhysiotherapyCare.View.MainForms.AllStatus
{
    public partial class AllStatusAdd_Frm : MKH.Library.Forms.MSSBaseNew_frm
    {
        private long _defId = 0;
        private long? _statusPCPHId = 0;
        private string str = "";
        internal SystemType _systemTypeSet;

        
        internal enum SystemType
        {
            Patient,
            Care,
            Physiotherapy,
            Health
        }

        public AllStatusAdd_Frm()
        {
            InitializeComponent();
        }



        public AllStatusAdd_Frm(long DefaultId)
        {
            InitializeComponent();
            _defId = DefaultId;
        }

        
        private void AllStatusAdd_Frm_Load(object sender, EventArgs e)
        {
            DatePickerStartDateAlarm.Value = KagNetComponents2.KagPersianDate.Now;
            
            if(_systemTypeSet == SystemType.Patient)
            {
                if(new ViewModel.Status.StatusPatient().GetAllListByDetailRow(_defId,0,ref str).Count()>0)
                {
                    ViewModel.Status.StatusPatient RN = new ViewModel.Status.StatusPatient();
                    List<VW_StatusPatient> U = RN.GetAllListByDetailRow(_defId, 0, ref str);
                    _statusPCPHId = U[0].Id;
                    TextBoxStatusType.Tag = U[0].StatusType_Id;
                    TextBoxStatusType.Text = U[0].StatusTypeName;

                    TextBoxComment.Text = U[0].StatusPatientComment;
                    DatePickerStartDateAlarm.Value = KagNetComponents2.KagPersianDate.Parse(U[0].StartDateAlarm);
                    FillTableLayoutPanel(U[0].Id.ToString().ToInt());
                }
            }

            if (_systemTypeSet == SystemType.Care)
            {
                if (new ViewModel.Status.StatusCare().GetAllListByDetailRow(_defId, 0, ref str).Count() > 0)
                {
                    ViewModel.Status.StatusCare RN = new ViewModel.Status.StatusCare();
                    List<VW_StatusCare> U = RN.GetAllListByDetailRow(_defId, 0, ref str);
                    _statusPCPHId = U[0].Id;
                    TextBoxStatusType.Tag = U[0].StatusType_Id;
                    TextBoxStatusType.Text = U[0].StatusTypeName;

                    TextBoxComment.Text = U[0].VisitPatientCareComment;
                    DatePickerStartDateAlarm.Value = KagNetComponents2.KagPersianDate.Parse(U[0].StartDateAlarm);
                    FillTableLayoutPanel(U[0].Id.ToString().ToInt());
                }
            }

            if (_systemTypeSet == SystemType.Health)
            {
                if (new ViewModel.Status.StatusVisitHealthCare().GetAllListByDetailRow(_defId, 0, ref str).Count() > 0)
                {
                    ViewModel.Status.StatusVisitHealthCare RN = new ViewModel.Status.StatusVisitHealthCare();
                    List<VW_StatusVisitHealthCare> U = RN.GetAllListByDetailRow(_defId, 0, ref str);
                    _statusPCPHId = U[0].Id;
                    TextBoxStatusType.Tag = U[0].StatusType_Id;
                    TextBoxStatusType.Text = U[0].StatusTypeName;

                    TextBoxComment.Text = U[0].VisitHealthCareComment;
                    DatePickerStartDateAlarm.Value = KagNetComponents2.KagPersianDate.Parse(U[0].StartDateAlarm);
                    FillTableLayoutPanel(U[0].Id.ToString().ToInt());
                }
            }

            if (_systemTypeSet == SystemType.Physiotherapy)
            {
                if (new ViewModel.Status.StatusPhysiotherapy().GetAllListByDetailRow(_defId, 0, ref str).Count() > 0)
                {
                    ViewModel.Status.StatusPhysiotherapy RN = new ViewModel.Status.StatusPhysiotherapy();
                    List<VW_StatusPhysiotherapy> U = RN.GetAllListByDetailRow(_defId, 0, ref str);
                    _statusPCPHId = U[0].Id;
                    TextBoxStatusType.Tag = U[0].StatusType_Id;
                    TextBoxStatusType.Text = U[0].StatusTypeName;

                    TextBoxComment.Text = U[0].VisitPatientPhysiotherapyComment;
                    DatePickerStartDateAlarm.Value = KagNetComponents2.KagPersianDate.Parse(U[0].StartDateAlarm);
                    FillTableLayoutPanel(U[0].Id.ToString().ToInt());
                }
            }
        }


        private void FillTableLayoutPanel(int AllStatus_Id)
        {
            try
            {
                tableLayoutPanelNews.Controls.Clear();
                int i = 0;
                if (_systemTypeSet == SystemType.Patient)
                {
                    var collation = new ViewModel.Status.StatusPatientTypeDetail().GetAllListByID(AllStatus_Id, ref str);
                    foreach (var item in collation)
                    {
                        AllStatusDetail_UC smsp = new AllStatusDetail_UC();
                        smsp.Tag = item.StatusPatient_Id;
                        smsp.CheckBoxStatusTypeDetail.Text = item.StatusTypeDetailName;
                        smsp.CheckBoxStatusTypeDetail.Tag = item.StatusTypeDetail_Id.ToString();
                        smsp.CheckBoxStatusTypeDetail.Checked = item.ConfirmSet.Value;
                        smsp.TextBoxDescription.Text = item.Description;
                        smsp.Controls.Owner.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                        tableLayoutPanelNews.Controls.Add(smsp, 1, ++i);
                    }
                }

                if (_systemTypeSet == SystemType.Care)
                {
                    var collation = new ViewModel.Status.StatusCareTypeDetail().GetAllListByID(AllStatus_Id, ref str);
                    foreach (var item in collation)
                    {
                        AllStatusDetail_UC smsp = new AllStatusDetail_UC();
                        smsp.Tag = item.StatusCare_Id;
                        smsp.CheckBoxStatusTypeDetail.Text = item.StatusTypeDetailName;
                        smsp.CheckBoxStatusTypeDetail.Tag = item.StatusTypeDetail_Id.ToString();
                        smsp.CheckBoxStatusTypeDetail.Checked = item.ConfirmSet.Value;
                        smsp.TextBoxDescription.Text = item.Description;
                        smsp.Controls.Owner.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                        tableLayoutPanelNews.Controls.Add(smsp, 1, ++i);
                    }
                }

                if (_systemTypeSet == SystemType.Health)
                {
                    var collation = new ViewModel.Status.StatusVisitHealthCareTypeDetail().GetAllListByID(AllStatus_Id, ref str);
                    foreach (var item in collation)
                    {
                        AllStatusDetail_UC smsp = new AllStatusDetail_UC();
                        smsp.Tag = item.StatusVisitHealthCare_Id;
                        smsp.CheckBoxStatusTypeDetail.Text = item.StatusTypeDetailName;
                        smsp.CheckBoxStatusTypeDetail.Tag = item.StatusTypeDetail_Id.ToString();
                        smsp.CheckBoxStatusTypeDetail.Checked = item.ConfirmSet.Value;
                        smsp.TextBoxDescription.Text = item.Description;
                        smsp.Controls.Owner.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                        tableLayoutPanelNews.Controls.Add(smsp, 1, ++i);
                    }
                }

                if (_systemTypeSet == SystemType.Physiotherapy)
                {
                    var collation = new ViewModel.Status.StatusPhysiotherapyTypeDetail().GetAllListByID(AllStatus_Id, ref str);
                    foreach (var item in collation)
                    {
                        AllStatusDetail_UC smsp = new AllStatusDetail_UC();
                        smsp.Tag = item.StatusPhysiotherapy_Id;
                        smsp.CheckBoxStatusTypeDetail.Text = item.StatusTypeDetailName;
                        smsp.CheckBoxStatusTypeDetail.Tag = item.StatusTypeDetail_Id.ToString();
                        smsp.CheckBoxStatusTypeDetail.Checked = item.ConfirmSet.Value;
                        smsp.TextBoxDescription.Text = item.Description;
                        smsp.Controls.Owner.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                        tableLayoutPanelNews.Controls.Add(smsp, 1, ++i);
                    }
                }
            }
            catch (Exception ex)
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, ex.Message);
            }
            SetRowTableSet();
        }

        public void SetRowTableSet()
        {
            int tableLayoutPanelRowCnt = 0;
            string FinalStatus = "تکمیل مدارک";

            foreach (Control fg in tableLayoutPanelNews.Controls)
                if ((fg as AllStatusDetail_UC).Visible)
                {
                    (fg as AllStatusDetail_UC).setRowNo(++tableLayoutPanelRowCnt);
                    if (!(fg as AllStatusDetail_UC).CheckBoxStatusTypeDetail.Checked)
                        FinalStatus = "مدارک ناقص";
                }
            LabelFinalStatus.Text = FinalStatus;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SetRowTableSet();

            if (!CheckValidation())
                return;
            try
            {
                if (_systemTypeSet == SystemType.Patient)
                {
                    List<TBL_StatusPatient> Ls = new List<TBL_StatusPatient>(1);
                    TBL_StatusPatient StatusPatient = new TBL_StatusPatient();
                    StatusPatient.Id = _statusPCPHId.Value;

                    StatusPatient.Patient_Id = Convert.ToInt32(_defId);
                    StatusPatient.StatusType_Id = Convert.ToInt16(TextBoxStatusType.Tag ?? "0");
                    StatusPatient.StatusPatientComment = TextBoxComment.Text;
                    StatusPatient.StartDateAlarm = DatePickerStartDateAlarm.Value.ToString().Substring(0, 10);
                    StatusPatient.User_Id = MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID;
                    StatusPatient.ChangeDateTime = MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now);


                    Ls.Add(StatusPatient);

                    if (_statusPCPHId == 0)
                    {
                        new ViewModel.Status.StatusPatient().InsertEntity(Ls, ref str, ref _statusPCPHId);
                        SaveDetail();
                    }
                    else
                    {
                        new ViewModel.Status.StatusPatient().UpdateEntity(Ls, ref str);
                        SaveDetail();
                    }

                    if (str != "")
                        MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MSSMessage.MessageType.SError, false, "اشکال اطلاعات", str);
                    else
                    {
                        MKH.Library.Clasess.MSSMessage.MSSMessage_View("اطلاعات ذخیره شد", MKH.Library.Clasess.MSSMessage.MessageType.SInformation);
                        DialogResult = System.Windows.Forms.DialogResult.OK;

                        if (checkBoxItemResid.Checked)
                            ShowReport(_defId);
                        Close();
                    }
                }


                if (_systemTypeSet == SystemType.Care)
                {
                    List<TBL_StatusCare> Ls = new List<TBL_StatusCare>(1);
                    TBL_StatusCare StatusCare = new TBL_StatusCare();
                    StatusCare.Id = _statusPCPHId.Value;

                    StatusCare.VisitPatientCare_Id = Convert.ToInt32(_defId);
                    StatusCare.StatusType_Id = Convert.ToInt16(TextBoxStatusType.Tag ?? "0");
                    StatusCare.VisitPatientCareComment = TextBoxComment.Text;
                    StatusCare.StartDateAlarm = DatePickerStartDateAlarm.Value.ToString().Substring(0, 10);
                    StatusCare.User_Id = MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID;
                    StatusCare.ChangeDateTime = MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now);


                    Ls.Add(StatusCare);

                    if (_statusPCPHId == 0)
                    {
                        new ViewModel.Status.StatusCare().InsertEntity(Ls, ref str, ref _statusPCPHId);
                        SaveDetail();
                    }
                    else
                    {
                        new ViewModel.Status.StatusCare().UpdateEntity(Ls, ref str);
                        SaveDetail();
                    }

                    if (str != "")
                        MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MSSMessage.MessageType.SError, false, "اشکال اطلاعات", str);
                    else
                    {
                        MKH.Library.Clasess.MSSMessage.MSSMessage_View("اطلاعات ذخیره شد", MKH.Library.Clasess.MSSMessage.MessageType.SInformation);
                        DialogResult = System.Windows.Forms.DialogResult.OK;

                        if (checkBoxItemResid.Checked)
                            ShowReport(_defId);
                        Close();
                    }
                }



                if (_systemTypeSet == SystemType.Physiotherapy)
                {
                    List<TBL_StatusPhysiotherapy> Ls = new List<TBL_StatusPhysiotherapy>(1);
                    TBL_StatusPhysiotherapy StatusPhysiotherapy = new TBL_StatusPhysiotherapy();
                    StatusPhysiotherapy.Id = _statusPCPHId.Value;

                    StatusPhysiotherapy.VisitPatientPhysiotherapy_Id = Convert.ToInt32(_defId);
                    StatusPhysiotherapy.StatusType_Id = Convert.ToInt16(TextBoxStatusType.Tag ?? "0");
                    StatusPhysiotherapy.VisitPatientPhysiotherapyComment = TextBoxComment.Text;
                    StatusPhysiotherapy.StartDateAlarm = DatePickerStartDateAlarm.Value.ToString().Substring(0, 10);
                    StatusPhysiotherapy.User_Id = MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID;
                    StatusPhysiotherapy.ChangeDateTime = MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now);


                    Ls.Add(StatusPhysiotherapy);

                    if (_statusPCPHId == 0)
                    {
                        new ViewModel.Status.StatusPhysiotherapy().InsertEntity(Ls, ref str, ref _statusPCPHId);
                        SaveDetail();
                    }
                    else
                    {
                        new ViewModel.Status.StatusPhysiotherapy().UpdateEntity(Ls, ref str);
                        SaveDetail();
                    }

                    if (str != "")
                        MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MSSMessage.MessageType.SError, false, "اشکال اطلاعات", str);
                    else
                    {
                        MKH.Library.Clasess.MSSMessage.MSSMessage_View("اطلاعات ذخیره شد", MKH.Library.Clasess.MSSMessage.MessageType.SInformation);
                        DialogResult = System.Windows.Forms.DialogResult.OK;

                        if (checkBoxItemResid.Checked)
                            ShowReport(_defId);
                        Close();
                    }
                }


                if (_systemTypeSet == SystemType.Health)
                {
                    List<TBL_StatusVisitHealthCare> Ls = new List<TBL_StatusVisitHealthCare>(1);
                    TBL_StatusVisitHealthCare StatusHealth = new TBL_StatusVisitHealthCare();
                    StatusHealth.Id = _statusPCPHId.Value;

                    StatusHealth.VisitHealthCare_Id = Convert.ToInt32(_defId);
                    StatusHealth.StatusType_Id = Convert.ToInt16(TextBoxStatusType.Tag ?? "0");
                    StatusHealth.VisitHealthCareComment = TextBoxComment.Text;
                    StatusHealth.StartDateAlarm = DatePickerStartDateAlarm.Value.ToString().Substring(0, 10);
                    StatusHealth.User_Id = MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID;
                    StatusHealth.ChangeDateTime = MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now);


                    Ls.Add(StatusHealth);

                    if (_statusPCPHId == 0)
                    {
                        new ViewModel.Status.StatusVisitHealthCare().InsertEntity(Ls, ref str, ref _statusPCPHId);
                        SaveDetail();
                    }
                    else
                    {
                        new ViewModel.Status.StatusVisitHealthCare().UpdateEntity(Ls, ref str);
                        SaveDetail();
                    }

                    if (str != "")
                        MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MSSMessage.MessageType.SError, false, "اشکال اطلاعات", str);
                    else
                    {
                        MKH.Library.Clasess.MSSMessage.MSSMessage_View("اطلاعات ذخیره شد", MKH.Library.Clasess.MSSMessage.MessageType.SInformation);
                        DialogResult = System.Windows.Forms.DialogResult.OK;

                        if (checkBoxItemResid.Checked)
                            ShowReport(_defId);
                        Close();
                    }
                }

            }
            catch (Exception ex)
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "اشکال در ذخیره اطلاعات", ex.Message);
            }
        }

        private void SaveDetail()
        {
            long? idSet = 0;
            if (_systemTypeSet == SystemType.Patient)
            {
                new ViewModel.Status.StatusPatientTypeDetail().StatusPatientTypeDetailDeleteWithId(_statusPCPHId.Value, ref str);
                List<TBL_StatusPatientTypeDetail> Ls = new List<TBL_StatusPatientTypeDetail>(1);
                foreach (Control fg in tableLayoutPanelNews.Controls)
                {
                    TBL_StatusPatientTypeDetail StatusPatientTypeDetail = new TBL_StatusPatientTypeDetail();
                    StatusPatientTypeDetail.StatusPatient_Id = _statusPCPHId.Value;
                    StatusPatientTypeDetail.StatusTypeDetail_Id = (fg as AllStatusDetail_UC).CheckBoxStatusTypeDetail.Tag.ToString().ToInt();

                    StatusPatientTypeDetail.ConfirmSet = (fg as AllStatusDetail_UC).CheckBoxStatusTypeDetail.Checked;
                    StatusPatientTypeDetail.Description = (fg as AllStatusDetail_UC).TextBoxDescription.Text;
                    StatusPatientTypeDetail.User_Id = MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID;
                    StatusPatientTypeDetail.ChangeDateTime = MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now);

                    Ls.Add(StatusPatientTypeDetail);
                }

                new ViewModel.Status.StatusPatientTypeDetail().InsertEntity(Ls, ref str, ref idSet);

            }

            if (_systemTypeSet == SystemType.Care)
            {
                new ViewModel.Status.StatusCareTypeDetail().StatusCareTypeDetailDeleteWithId(_statusPCPHId.Value, ref str);
                List<TBL_StatusCareTypeDetail> Ls = new List<TBL_StatusCareTypeDetail>(1);
                foreach (Control fg in tableLayoutPanelNews.Controls)
                {
                    TBL_StatusCareTypeDetail StatusCareTypeDetail = new TBL_StatusCareTypeDetail();
                    StatusCareTypeDetail.StatusCare_Id = _statusPCPHId.Value;
                    StatusCareTypeDetail.StatusTypeDetail_Id = (fg as AllStatusDetail_UC).CheckBoxStatusTypeDetail.Tag.ToString().ToInt();

                    StatusCareTypeDetail.ConfirmSet = (fg as AllStatusDetail_UC).CheckBoxStatusTypeDetail.Checked;
                    StatusCareTypeDetail.Description = (fg as AllStatusDetail_UC).TextBoxDescription.Text;
                    StatusCareTypeDetail.User_Id = MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID;
                    StatusCareTypeDetail.ChangeDateTime = MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now);

                    Ls.Add(StatusCareTypeDetail);
                }

                new ViewModel.Status.StatusCareTypeDetail().InsertEntity(Ls, ref str, ref idSet);

            }


            if (_systemTypeSet == SystemType.Health)
            {
                new ViewModel.Status.StatusVisitHealthCareTypeDetail().StatusVisitHealthCareTypeDetailDeleteWithId(_statusPCPHId.Value, ref str);
                List<TBL_StatusVisitHealthCareTypeDetail> Ls = new List<TBL_StatusVisitHealthCareTypeDetail>(1);
                foreach (Control fg in tableLayoutPanelNews.Controls)
                {
                    TBL_StatusVisitHealthCareTypeDetail StatusHealthTypeDetail = new TBL_StatusVisitHealthCareTypeDetail();
                    StatusHealthTypeDetail.StatusVisitHealthCare_Id = _statusPCPHId.Value;
                    StatusHealthTypeDetail.StatusTypeDetail_Id = (fg as AllStatusDetail_UC).CheckBoxStatusTypeDetail.Tag.ToString().ToInt();

                    StatusHealthTypeDetail.ConfirmSet = (fg as AllStatusDetail_UC).CheckBoxStatusTypeDetail.Checked;
                    StatusHealthTypeDetail.Description = (fg as AllStatusDetail_UC).TextBoxDescription.Text;
                    StatusHealthTypeDetail.User_Id = MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID;
                    StatusHealthTypeDetail.ChangeDateTime = MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now);

                    Ls.Add(StatusHealthTypeDetail);
                }

                new ViewModel.Status.StatusVisitHealthCareTypeDetail().InsertEntity(Ls, ref str, ref idSet);

            }


            if (_systemTypeSet == SystemType.Physiotherapy)
            {
                new ViewModel.Status.StatusPhysiotherapyTypeDetail().StatusPhysiotherapyTypeDetailDeleteWithId(_statusPCPHId.Value, ref str);
                List<TBL_StatusPhysiotherapyTypeDetail> Ls = new List<TBL_StatusPhysiotherapyTypeDetail>(1);
                foreach (Control fg in tableLayoutPanelNews.Controls)
                {
                    TBL_StatusPhysiotherapyTypeDetail StatusPhysiotherapyTypeDetail = new TBL_StatusPhysiotherapyTypeDetail();
                    StatusPhysiotherapyTypeDetail.StatusPhysiotherapy_Id = _statusPCPHId.Value;
                    StatusPhysiotherapyTypeDetail.StatusTypeDetail_Id = (fg as AllStatusDetail_UC).CheckBoxStatusTypeDetail.Tag.ToString().ToInt();

                    StatusPhysiotherapyTypeDetail.ConfirmSet = (fg as AllStatusDetail_UC).CheckBoxStatusTypeDetail.Checked;
                    StatusPhysiotherapyTypeDetail.Description = (fg as AllStatusDetail_UC).TextBoxDescription.Text;
                    StatusPhysiotherapyTypeDetail.User_Id = MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID;
                    StatusPhysiotherapyTypeDetail.ChangeDateTime = MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now);

                    Ls.Add(StatusPhysiotherapyTypeDetail);
                }

                new ViewModel.Status.StatusPhysiotherapyTypeDetail().InsertEntity(Ls, ref str, ref idSet);

            }
        }

        private bool CheckValidation()
        {
            if (TextBoxStatusType.Text.Trim() == "")
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("لطفا نوع وضعیت را پر نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                return false;
            }
            return true;
        }


        private void ShowReport(long Id)
        {
            string str = "";
            if (_systemTypeSet == SystemType.Patient)
            {
                MKH.Library.Forms.MSSReportDesignList_frm ctrl = new MKH.Library.Forms.MSSReportDesignList_frm(this.Name + "Patient");
                try
                {
                    ctrl.DataRelationNew = MKH.Library.Clasess.PublicClass.ToDataTable<Model.Status.VW_StatusPatientReport>(new ViewModel.Status.StatusPatient().GetResid(Id, ref str));
                    ctrl.DataRelationNew.Columns["PatientName"].ColumnName = "نام بیمار";
                    ctrl.DataRelationNew.Columns["PatientFamily"].ColumnName = "نام خانوادگی بیمار";
                    ctrl.DataRelationNew.Columns["Description"].ColumnName = "توضیحات";
                    ctrl.DataRelationNew.Columns["ConfirmSet"].ColumnName = "مدرک دارد";
                    ctrl.DataRelationNew.Columns["StatusTypeDetailName"].ColumnName = "جزییات نوع وضعیت";
                    ctrl.DataRelationNew.Columns["StatusTypeName"].ColumnName = "نوع وضعیت";
                    ctrl.DataRelationNew.Columns["UsersNameFamily"].ColumnName = "نام و نام خانوادگی کاربر";
                    ctrl.DataRelationNew.Columns["ChangeDateTime"].ColumnName = "تاریخ و ساعت رسید";
                    ctrl.DataRelationNew.Columns["StatusPatientComment"].ColumnName = "شرح";
                    ctrl.DataRelationNew.Columns.Remove("Id");
                    ctrl.DataRelationNew.Columns.Remove("Patient_Id");
                    ctrl.DataRelationNew.Columns.Remove("StartDateAlarm");
                    ctrl.DataRelationNew.Columns.Remove("StatusPatient_Id");
                    ctrl.NameForDB = "رسید بیمار";
                    ctrl.ShowDialog();
                }
                catch { }
            }
            if (_systemTypeSet == SystemType.Care)
            {
                MKH.Library.Forms.MSSReportDesignList_frm ctrl = new MKH.Library.Forms.MSSReportDesignList_frm(this.Name + "Care");
                try
                {
                    ctrl.DataRelationNew = MKH.Library.Clasess.PublicClass.ToDataTable<Model.Status.VW_StatusCareReport>(new ViewModel.Status.StatusCare().GetResid(Id, ref str));
                    ctrl.DataRelationNew.Columns["PatientName"].ColumnName = "نام بیمار";
                    ctrl.DataRelationNew.Columns["PatientFamily"].ColumnName = "نام خانوادگی بیمار";
                    ctrl.DataRelationNew.Columns["NationalCode"].ColumnName = "کدملی بیمار";
                    ctrl.DataRelationNew.Columns["Description"].ColumnName = "توضیحات";
                    ctrl.DataRelationNew.Columns["ConfirmSet"].ColumnName = "مدرک دارد";
                    ctrl.DataRelationNew.Columns["StatusTypeDetailName"].ColumnName = "جزییات نوع وضعیت";
                    ctrl.DataRelationNew.Columns["StatusTypeName"].ColumnName = "نوع وضعیت";
                    ctrl.DataRelationNew.Columns["UsersNameFamily"].ColumnName = "نام و نام خانوادگی کاربر";
                    ctrl.DataRelationNew.Columns["ChangeDateTime"].ColumnName = "تاریخ و ساعت رسید";
                    ctrl.DataRelationNew.Columns["VisitPatientCareComment"].ColumnName = "شرح";
                    ctrl.DataRelationNew.Columns["CarrierName"].ColumnName = "نام مراقب";
                    ctrl.DataRelationNew.Columns["CarrierFamily"].ColumnName = "نام خانوادگی مراقب";
                    ctrl.DataRelationNew.Columns["CarrierNationalCode"].ColumnName = "کدملی مراقب";
                    ctrl.DataRelationNew.Columns.Remove("Id");
                    ctrl.DataRelationNew.Columns.Remove("VisitPatientCare_Id");
                    ctrl.DataRelationNew.Columns.Remove("StartDateAlarm");
                    ctrl.DataRelationNew.Columns.Remove("StatusCare_Id");
                    ctrl.NameForDB = "رسید مراقبت";
                    ctrl.ShowDialog();
                }
                catch { }
            }
            if (_systemTypeSet == SystemType.Health)
            {
                MKH.Library.Forms.MSSReportDesignList_frm ctrl = new MKH.Library.Forms.MSSReportDesignList_frm(this.Name + "Health");
                try
                {
                    ctrl.DataRelationNew = MKH.Library.Clasess.PublicClass.ToDataTable<Model.Status.VW_StatusVisitHealthCareReport>(new ViewModel.Status.StatusVisitHealthCare().GetResid(Id, ref str));

                    ctrl.DataRelationNew.Columns["PatientName"].ColumnName = "نام بیمار";
                    ctrl.DataRelationNew.Columns["PatientFamily"].ColumnName = "نام خانوادگی بیمار";
                    ctrl.DataRelationNew.Columns["NationalCode"].ColumnName = "کدملی بیمار";
                    ctrl.DataRelationNew.Columns["Description"].ColumnName = "توضیحات";
                    ctrl.DataRelationNew.Columns["ConfirmSet"].ColumnName = "مدرک دارد";
                    ctrl.DataRelationNew.Columns["StatusTypeDetailName"].ColumnName = "جزییات نوع وضعیت";
                    ctrl.DataRelationNew.Columns["StatusTypeName"].ColumnName = "نوع وضعیت";
                    ctrl.DataRelationNew.Columns["UsersNameFamily"].ColumnName = "نام و نام خانوادگی کاربر";
                    ctrl.DataRelationNew.Columns["ChangeDateTime"].ColumnName = "تاریخ و ساعت رسید";
                    ctrl.DataRelationNew.Columns["VisitHealthCareComment"].ColumnName = "شرح";
                    ctrl.DataRelationNew.Columns["DoctorName"].ColumnName = "نام بهیار";
                    ctrl.DataRelationNew.Columns["DoctorFamily"].ColumnName = "نام خانوادگی بهیار";
                    ctrl.DataRelationNew.Columns.Remove("DoctorsAddress");
                    ctrl.DataRelationNew.Columns.Remove("Id");
                    ctrl.DataRelationNew.Columns.Remove("VisitHealthCare_Id");
                    ctrl.DataRelationNew.Columns.Remove("StartDateAlarm");
                    ctrl.DataRelationNew.Columns.Remove("StatusVisitHealthCare_Id");
                    
                    ctrl.NameForDB = "رسید بهیاری";
                    ctrl.ShowDialog();
                }
                catch { }
            }
            if (_systemTypeSet == SystemType.Physiotherapy)
            {
                MKH.Library.Forms.MSSReportDesignList_frm ctrl = new MKH.Library.Forms.MSSReportDesignList_frm(this.Name + "Physiotherapy");
                try
                {
                    ctrl.DataRelationNew = MKH.Library.Clasess.PublicClass.ToDataTable<Model.Status.VW_StatusPhysiotherapyReport>(new ViewModel.Status.StatusPhysiotherapy().GetResid(Id, ref str));

                    ctrl.DataRelationNew.Columns["PatientName"].ColumnName = "نام بیمار";
                    ctrl.DataRelationNew.Columns["PatientFamily"].ColumnName = "نام خانوادگی بیمار";
                    ctrl.DataRelationNew.Columns["NationalCode"].ColumnName = "کدملی بیمار";
                    ctrl.DataRelationNew.Columns["Description"].ColumnName = "توضیحات";
                    ctrl.DataRelationNew.Columns["ConfirmSet"].ColumnName = "مدرک دارد";
                    ctrl.DataRelationNew.Columns["StatusTypeDetailName"].ColumnName = "جزییات نوع وضعیت";
                    ctrl.DataRelationNew.Columns["StatusTypeName"].ColumnName = "نوع وضعیت";
                    ctrl.DataRelationNew.Columns["UsersNameFamily"].ColumnName = "نام و نام خانوادگی کاربر";
                    ctrl.DataRelationNew.Columns["ChangeDateTime"].ColumnName = "تاریخ و ساعت رسید";
                    ctrl.DataRelationNew.Columns["VisitPatientPhysiotherapyComment"].ColumnName = "شرح";
                    ctrl.DataRelationNew.Columns["DoctorName"].ColumnName = "نام پزشک";
                    ctrl.DataRelationNew.Columns["DoctorFamily"].ColumnName = "نام خانوادگی پزشک";
                    ctrl.DataRelationNew.Columns.Remove("DoctorsAddress");
                    ctrl.DataRelationNew.Columns.Remove("Id");
                    ctrl.DataRelationNew.Columns.Remove("VisitPatientPhysiotherapy_Id");
                    ctrl.DataRelationNew.Columns.Remove("StartDateAlarm");
                    ctrl.DataRelationNew.Columns.Remove("StatusPhysiotherapy_Id");
                    
                    ctrl.NameForDB = "رسید فیزیوتراپی";
                    ctrl.ShowDialog();
                }
                catch { }
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void ButtonStatusType_Click(object sender, EventArgs e)
        {
            try
            {
                string StrSet = "";
                Dictionary<string, string> SD = new Dictionary<string, string>();
                Dictionary<string, string> SD1 = new Dictionary<string, string>();

                foreach (var item in new ViewModel.Status.StatusType().GetAllList(ref StrSet))
                    SD.Add(item.Id.ToString(), item.TitleName);

                SD1 = MKH.Library.Forms.MSSSelector_frm.SetDataSelect(SD);
                TextBoxStatusType.Tag = SD1.Keys.ToList()[0];
                TextBoxStatusType.Text = SD1.Values.ToList()[0];
                FillTableLayoutPanelDefault(TextBoxStatusType.Tag.ToString().ToInt());
            }
            catch { }
        }

        private void FillTableLayoutPanelDefault(int AllStatus_Id)
        {
            try
            {
                tableLayoutPanelNews.Controls.Clear();
                int i = 0;
                var collation = new ViewModel.Status.StatusTypeDetail().GetAllListByDetailRow(AllStatus_Id, 0, ref str);
                foreach (var item in collation)
                {
                    AllStatusDetail_UC smsp = new AllStatusDetail_UC();
                    smsp.Tag = item.Id;
                    smsp.CheckBoxStatusTypeDetail.Text = item.TitleName.ToString();
                    smsp.CheckBoxStatusTypeDetail.Tag = item.Id.ToString();
                    smsp.Controls.Owner.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                    tableLayoutPanelNews.Controls.Add(smsp, 1, ++i);
                }
            }
            catch (Exception ex)
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, ex.Message);
            }
            SetRowTableSet();
        }



    }
}
