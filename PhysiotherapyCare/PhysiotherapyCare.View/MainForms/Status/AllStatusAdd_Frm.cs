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
        private bool ButtonDelEnabled = false;
        
        internal enum SystemType
        {
            Patient,
            Care,
            Physiotherapy,
            Health,
            VisitPatient
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
            if(_systemTypeSet == SystemType.Patient)
            {
                buttonAddState.Enabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(60);
                checkBoxItemResid.Enabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(276);
                ButtonDelEnabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(76);

                if (new ViewModel.Status.StatusTypeDetailPatient().GetAllListByDetailRow(_defId, 0, ref str).Count() > 0)
                {
                    foreach (var item in new ViewModel.Status.StatusTypeDetailPatient().GetAllListByDetailRow(_defId, 0, ref str))
                        FillTableLayoutPanelSet(item.Id, item.StatusTypeDetail_Id.Value, item.StatusTypeName + "-" + item.StatusTypeDetailName, item.ConfirmSet.Value, item.Description);

                    //ViewModel.Status.StatusTypeDetailPatient RN = new ViewModel.Status.StatusTypeDetailPatient();
                    //List<VW_StatusTypeDetailPatient> U = RN.GetAllListByDetailRow(_defId, 0, ref str);
                    //_statusPCPHId = U[0].Id;
                    //TextBoxStatusType.Tag = U[0].StatusType_Id;
                    //TextBoxStatusType.Text = U[0].StatusTypeName;

                    //TextBoxComment.Text = U[0].StatusPatientComment;
                    //DatePickerStartDateAlarm.Value = KagNetComponents2.KagPersianDate.Parse(U[0].StartDateAlarm);
                    //FillTableLayoutPanel(U[0].Id.ToString().ToInt());
                }
            }

            if (_systemTypeSet == SystemType.Care)
            {
                buttonAddState.Enabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(75);
                checkBoxItemResid.Enabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(78);
                ButtonDelEnabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(77);

                if (new ViewModel.Status.StatusTypeDetailCare().GetAllListByDetailRow(_defId, 0, ref str).Count() > 0)
                {
                    foreach (var item in new ViewModel.Status.StatusTypeDetailCare().GetAllListByDetailRow(_defId, 0, ref str))
                        FillTableLayoutPanelSet(item.Id, item.StatusTypeDetail_Id.Value, item.StatusTypeName + "-" + item.StatusTypeDetailName, item.ConfirmSet.Value, item.Description);

                    //ViewModel.Status.StatusTypeDetailCare RN = new ViewModel.Status.StatusTypeDetailCare();
                    //List<VW_StatusCare> U = RN.GetAllListByDetailRow(_defId, 0, ref str);
                    //_statusPCPHId = U[0].Id;
                    //TextBoxStatusType.Tag = U[0].StatusType_Id;
                    //TextBoxStatusType.Text = U[0].StatusTypeName;

                    //TextBoxComment.Text = U[0].VisitPatientCareComment;
                    //DatePickerStartDateAlarm.Value = KagNetComponents2.KagPersianDate.Parse(U[0].StartDateAlarm);
                    //FillTableLayoutPanel(U[0].Id.ToString().ToInt());
                }
            }

            if (_systemTypeSet == SystemType.Health)
            {
                buttonAddState.Enabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(312);
                checkBoxItemResid.Enabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(314);
                ButtonDelEnabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(313);

                if (new ViewModel.Status.StatusTypeDetailVisitHealthCare().GetAllListByDetailRow(_defId, 0, ref str).Count() > 0)
                {
                    foreach (var item in new ViewModel.Status.StatusTypeDetailVisitHealthCare().GetAllListByDetailRow(_defId, 0, ref str))
                        FillTableLayoutPanelSet(item.Id, item.StatusTypeDetail_Id.Value, item.StatusTypeName + "-" + item.StatusTypeDetailName, item.ConfirmSet.Value, item.Description);

                    //ViewModel.Status.StatusTypeDetailVisitHealthCare RN = new ViewModel.Status.StatusTypeDetailVisitHealthCare();
                    //List<VW_StatusVisitHealthCare> U = RN.GetAllListByDetailRow(_defId, 0, ref str);
                    //_statusPCPHId = U[0].Id;
                    //TextBoxStatusType.Tag = U[0].StatusType_Id;
                    //TextBoxStatusType.Text = U[0].StatusTypeName;

                    //TextBoxComment.Text = U[0].VisitHealthCareComment;
                    //DatePickerStartDateAlarm.Value = KagNetComponents2.KagPersianDate.Parse(U[0].StartDateAlarm);
                    //FillTableLayoutPanel(U[0].Id.ToString().ToInt());
                }
            }

            if (_systemTypeSet == SystemType.Physiotherapy)
            {
                buttonAddState.Enabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(59);
                checkBoxItemResid.Enabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(62);
                ButtonDelEnabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(61);

                if (new ViewModel.Status.StatusTypeDetailPhysiotherapy().GetAllListByDetailRow(_defId, 0, ref str).Count() > 0)
                {
                    foreach (var item in new ViewModel.Status.StatusTypeDetailPhysiotherapy().GetAllListByDetailRow(_defId, 0, ref str))
                        FillTableLayoutPanelSet(item.Id, item.StatusTypeDetail_Id.Value, item.StatusTypeName + "-" + item.StatusTypeDetailName, item.ConfirmSet.Value, item.Description);

                    //ViewModel.Status.StatusTypeDetailPhysiotherapy RN = new ViewModel.Status.StatusTypeDetailPhysiotherapy();
                    //List<VW_StatusPhysiotherapy> U = RN.GetAllListByDetailRow(_defId, 0, ref str);
                    //_statusPCPHId = U[0].Id;
                    //TextBoxStatusType.Tag = U[0].StatusType_Id;
                    //TextBoxStatusType.Text = U[0].StatusTypeName;

                    //TextBoxComment.Text = U[0].VisitPatientPhysiotherapyComment;
                    //DatePickerStartDateAlarm.Value = KagNetComponents2.KagPersianDate.Parse(U[0].StartDateAlarm);
                    //FillTableLayoutPanel(U[0].Id.ToString().ToInt());
                }
            }

            if (_systemTypeSet == SystemType.VisitPatient)
            {
                buttonAddState.Enabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(315);
                checkBoxItemResid.Enabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(317);
                ButtonDelEnabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(316);

                if (new ViewModel.Status.StatusTypeDetailVisitPatient().GetAllListByDetailRow(_defId, 0, ref str).Count() > 0)
                    foreach (var item in new ViewModel.Status.StatusTypeDetailVisitPatient().GetAllListByDetailRow(_defId, 0, ref str))
                        FillTableLayoutPanelSet(item.Id, item.StatusTypeDetail_Id.Value, item.StatusTypeName + "-" + item.StatusTypeDetailName, item.ConfirmSet.Value, item.Description);
            }
        }


        //private void FillTableLayoutPanel(int AllStatus_Id)
        //{
        //    try
        //    {
        //        tableLayoutPanelNews.Controls.Clear();
        //        int i = 0;
        //        if (_systemTypeSet == SystemType.Patient)
        //        {
        //            var collation = new ViewModel.Status.StatusTypeDetailVisitPatient().GetAllListByID(AllStatus_Id, ref str);
        //            foreach (var item in collation)
        //            {
        //                AllStatusDetail_UC smsp = new AllStatusDetail_UC();
        //                smsp.Tag = item.StatusPatient_Id;
        //                smsp.CheckBoxStatusTypeDetail.Text = item.StatusTypeDetailName;
        //                smsp.CheckBoxStatusTypeDetail.Tag = item.StatusTypeDetail_Id.ToString();
        //                smsp.CheckBoxStatusTypeDetail.Checked = item.ConfirmSet.Value;
        //                smsp.TextBoxDescription.Text = item.Description;
        //                smsp.Controls.Owner.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
        //                tableLayoutPanelNews.Controls.Add(smsp, 1, ++i);
        //            }
        //        }

        //        if (_systemTypeSet == SystemType.Care)
        //        {
        //            var collation = new ViewModel.Status.StatusCareTypeDetail().GetAllListByID(AllStatus_Id, ref str);
        //            foreach (var item in collation)
        //            {
        //                AllStatusDetail_UC smsp = new AllStatusDetail_UC();
        //                smsp.Tag = item.StatusCare_Id;
        //                smsp.CheckBoxStatusTypeDetail.Text = item.StatusTypeDetailName;
        //                smsp.CheckBoxStatusTypeDetail.Tag = item.StatusTypeDetail_Id.ToString();
        //                smsp.CheckBoxStatusTypeDetail.Checked = item.ConfirmSet.Value;
        //                smsp.TextBoxDescription.Text = item.Description;
        //                smsp.Controls.Owner.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
        //                tableLayoutPanelNews.Controls.Add(smsp, 1, ++i);
        //            }
        //        }

        //        if (_systemTypeSet == SystemType.Health)
        //        {
        //            var collation = new ViewModel.Status.StatusVisitHealthCareTypeDetail().GetAllListByID(AllStatus_Id, ref str);
        //            foreach (var item in collation)
        //            {
        //                AllStatusDetail_UC smsp = new AllStatusDetail_UC();
        //                smsp.Tag = item.StatusVisitHealthCare_Id;
        //                smsp.CheckBoxStatusTypeDetail.Text = item.StatusTypeDetailName;
        //                smsp.CheckBoxStatusTypeDetail.Tag = item.StatusTypeDetail_Id.ToString();
        //                smsp.CheckBoxStatusTypeDetail.Checked = item.ConfirmSet.Value;
        //                smsp.TextBoxDescription.Text = item.Description;
        //                smsp.Controls.Owner.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
        //                tableLayoutPanelNews.Controls.Add(smsp, 1, ++i);
        //            }
        //        }

        //        if (_systemTypeSet == SystemType.Physiotherapy)
        //        {
        //            var collation = new ViewModel.Status.StatusPhysiotherapyTypeDetail().GetAllListByID(AllStatus_Id, ref str);
        //            foreach (var item in collation)
        //            {
        //                AllStatusDetail_UC smsp = new AllStatusDetail_UC();
        //                smsp.Tag = item.StatusPhysiotherapy_Id;
        //                smsp.CheckBoxStatusTypeDetail.Text = item.StatusTypeDetailName;
        //                smsp.CheckBoxStatusTypeDetail.Tag = item.StatusTypeDetail_Id.ToString();
        //                smsp.CheckBoxStatusTypeDetail.Checked = item.ConfirmSet.Value;
        //                smsp.TextBoxDescription.Text = item.Description;
        //                smsp.Controls.Owner.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
        //                tableLayoutPanelNews.Controls.Add(smsp, 1, ++i);
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, ex.Message);
        //    }
        //    SetRowTableSet();
        //}

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
                 str = SaveDetail();

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
            catch (Exception ex)
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "اشکال در ذخیره اطلاعات", ex.Message);
            }

            
            
            //if (_systemTypeSet == SystemType.Patient)
                //{
                    //List<TBL_StatusTypeDetailPatient> Ls = new List<TBL_StatusTypeDetailPatient>(1);
                    //TBL_StatusTypeDetailPatient StatusPatient = new TBL_StatusTypeDetailPatient();
                    //StatusPatient.Id = _statusPCPHId.Value;

                    //StatusPatient.Patient_Id = Convert.ToInt32(_defId);
                    //StatusPatient.StatusType_Id = Convert.ToInt16(TextBoxStatusType.Tag ?? "0");
                    //StatusPatient.StatusPatientComment = TextBoxComment.Text;
                    //StatusPatient.StartDateAlarm = DatePickerStartDateAlarm.Value.ToString().Substring(0, 10);
                    //StatusPatient.User_Id = MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID;
                    //StatusPatient.ChangeDateTime = MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now);


                    //Ls.Add(StatusPatient);

                    //if (_statusPCPHId == 0)
                    //{
                        //new ViewModel.Status.StatusTypeDetailPatient().InsertEntity(Ls, ref str, ref _statusPCPHId);
                    //    SaveDetail();
                    //}
                    //else
                    //{
                        //new ViewModel.Status.StatusTypeDetailPatient().UpdateEntity(Ls, ref str);
                //        SaveDetail();
                //    }

                //    if (str != "")
                //        MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MSSMessage.MessageType.SError, false, "اشکال اطلاعات", str);
                //    else
                //    {
                //        MKH.Library.Clasess.MSSMessage.MSSMessage_View("اطلاعات ذخیره شد", MKH.Library.Clasess.MSSMessage.MessageType.SInformation);
                //        DialogResult = System.Windows.Forms.DialogResult.OK;

                //        if (checkBoxItemResid.Checked)
                //            ShowReport(_defId);
                //        Close();
                //    }
                //}


                //if (_systemTypeSet == SystemType.Care)
                //{
                //    List<TBL_StatusCare> Ls = new List<TBL_StatusCare>(1);
                //    TBL_StatusCare StatusCare = new TBL_StatusCare();
                //    StatusCare.Id = _statusPCPHId.Value;

                //    StatusCare.VisitPatientCare_Id = Convert.ToInt32(_defId);
                //    StatusCare.StatusType_Id = Convert.ToInt16(TextBoxStatusType.Tag ?? "0");
                //    StatusCare.VisitPatientCareComment = TextBoxComment.Text;
                //    StatusCare.StartDateAlarm = DatePickerStartDateAlarm.Value.ToString().Substring(0, 10);
                //    StatusCare.User_Id = MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID;
                //    StatusCare.ChangeDateTime = MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now);


                //    Ls.Add(StatusCare);

                //    if (_statusPCPHId == 0)
                //    {
                //        new ViewModel.Status.StatusTypeDetailCare().InsertEntity(Ls, ref str, ref _statusPCPHId);
                //        SaveDetail();
                //    }
                //    else
                //    {
                //        new ViewModel.Status.StatusTypeDetailCare().UpdateEntity(Ls, ref str);
                //        SaveDetail();
                //    }

                //    if (str != "")
                //        MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MSSMessage.MessageType.SError, false, "اشکال اطلاعات", str);
                //    else
                //    {
                //        MKH.Library.Clasess.MSSMessage.MSSMessage_View("اطلاعات ذخیره شد", MKH.Library.Clasess.MSSMessage.MessageType.SInformation);
                //        DialogResult = System.Windows.Forms.DialogResult.OK;

                //        if (checkBoxItemResid.Checked)
                //            ShowReport(_defId);
                //        Close();
                //    }
                //}



                //if (_systemTypeSet == SystemType.Physiotherapy)
                //{
                //    List<TBL_StatusPhysiotherapy> Ls = new List<TBL_StatusPhysiotherapy>(1);
                //    TBL_StatusPhysiotherapy StatusPhysiotherapy = new TBL_StatusPhysiotherapy();
                //    StatusPhysiotherapy.Id = _statusPCPHId.Value;

                //    StatusPhysiotherapy.VisitPatientPhysiotherapy_Id = Convert.ToInt32(_defId);
                //    StatusPhysiotherapy.StatusType_Id = Convert.ToInt16(TextBoxStatusType.Tag ?? "0");
                //    StatusPhysiotherapy.VisitPatientPhysiotherapyComment = TextBoxComment.Text;
                //    StatusPhysiotherapy.StartDateAlarm = DatePickerStartDateAlarm.Value.ToString().Substring(0, 10);
                //    StatusPhysiotherapy.User_Id = MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID;
                //    StatusPhysiotherapy.ChangeDateTime = MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now);


                //    Ls.Add(StatusPhysiotherapy);

                //    if (_statusPCPHId == 0)
                //    {
                //        new ViewModel.Status.StatusTypeDetailPhysiotherapy().InsertEntity(Ls, ref str, ref _statusPCPHId);
                //        SaveDetail();
                //    }
                //    else
                //    {
                //        new ViewModel.Status.StatusTypeDetailPhysiotherapy().UpdateEntity(Ls, ref str);
                //        SaveDetail();
                //    }

                //    if (str != "")
                //        MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MSSMessage.MessageType.SError, false, "اشکال اطلاعات", str);
                //    else
                //    {
                //        MKH.Library.Clasess.MSSMessage.MSSMessage_View("اطلاعات ذخیره شد", MKH.Library.Clasess.MSSMessage.MessageType.SInformation);
                //        DialogResult = System.Windows.Forms.DialogResult.OK;

                //        if (checkBoxItemResid.Checked)
                //            ShowReport(_defId);
                //        Close();
                //    }
                //}


                //if (_systemTypeSet == SystemType.Health)
                //{
                //    List<TBL_StatusVisitHealthCare> Ls = new List<TBL_StatusVisitHealthCare>(1);
                //    TBL_StatusVisitHealthCare StatusHealth = new TBL_StatusVisitHealthCare();
                //    StatusHealth.Id = _statusPCPHId.Value;

                //    StatusHealth.VisitHealthCare_Id = Convert.ToInt32(_defId);
                //    StatusHealth.StatusType_Id = Convert.ToInt16(TextBoxStatusType.Tag ?? "0");
                //    StatusHealth.VisitHealthCareComment = TextBoxComment.Text;
                //    StatusHealth.StartDateAlarm = DatePickerStartDateAlarm.Value.ToString().Substring(0, 10);
                //    StatusHealth.User_Id = MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID;
                //    StatusHealth.ChangeDateTime = MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now);


                //    Ls.Add(StatusHealth);

                //    if (_statusPCPHId == 0)
                //    {
                //        new ViewModel.Status.StatusTypeDetailVisitHealthCare().InsertEntity(Ls, ref str, ref _statusPCPHId);
                //        SaveDetail();
                //    }
                //    else
                //    {
                //        new ViewModel.Status.StatusTypeDetailVisitHealthCare().UpdateEntity(Ls, ref str);
                //        SaveDetail();
                //    }

                //    if (str != "")
                //        MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MSSMessage.MessageType.SError, false, "اشکال اطلاعات", str);
                //    else
                //    {
                //        MKH.Library.Clasess.MSSMessage.MSSMessage_View("اطلاعات ذخیره شد", MKH.Library.Clasess.MSSMessage.MessageType.SInformation);
                //        DialogResult = System.Windows.Forms.DialogResult.OK;

                //        if (checkBoxItemResid.Checked)
                //            ShowReport(_defId);
                //        Close();
                //    }
                //}

           
        }

        private string SaveDetail()
        {
            long? idSet = 0;
            string str = "";
            
            if (_systemTypeSet == SystemType.Patient)
            {
                new ViewModel.Status.StatusTypeDetailPatient().DeleteWithPatientId(Convert.ToInt32(_defId), ref str);
                List<TBL_StatusTypeDetailPatient> Ls = new List<TBL_StatusTypeDetailPatient>();
                foreach (Control fg in tableLayoutPanelNews.Controls)
                    if (fg.Visible)
                    {
                        TBL_StatusTypeDetailPatient StatusPatientTypeDetail = new TBL_StatusTypeDetailPatient();
                        StatusPatientTypeDetail.Patient_Id = Convert.ToInt32(_defId);
                        StatusPatientTypeDetail.StatusTypeDetail_Id = (fg as AllStatusDetail_UC).CheckBoxStatusTypeDetail.Tag.ToString().ToInt();

                        StatusPatientTypeDetail.ConfirmSet = (fg as AllStatusDetail_UC).CheckBoxStatusTypeDetail.Checked;
                        StatusPatientTypeDetail.Description = (fg as AllStatusDetail_UC).TextBoxDescription.Text;
                        StatusPatientTypeDetail.User_Id = MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID;
                        StatusPatientTypeDetail.ChangeDateTime = MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now);

                        Ls.Add(StatusPatientTypeDetail);
                    }

                new ViewModel.Status.StatusTypeDetailPatient().InsertEntity(Ls, ref str, ref idSet);

            }

            if (_systemTypeSet == SystemType.Care)
            {
                new ViewModel.Status.StatusTypeDetailCare().DeleteWithCareId(_defId, ref str);
                List<TBL_StatusTypeDetailCare> Ls = new List<TBL_StatusTypeDetailCare>();
                foreach (Control fg in tableLayoutPanelNews.Controls)
                    if (fg.Visible)
                    {
                        TBL_StatusTypeDetailCare StatusCareTypeDetail = new TBL_StatusTypeDetailCare();
                        StatusCareTypeDetail.VisitPatientCare_Id = _defId;
                        StatusCareTypeDetail.StatusTypeDetail_Id = (fg as AllStatusDetail_UC).CheckBoxStatusTypeDetail.Tag.ToString().ToInt();

                        StatusCareTypeDetail.ConfirmSet = (fg as AllStatusDetail_UC).CheckBoxStatusTypeDetail.Checked;
                        StatusCareTypeDetail.Description = (fg as AllStatusDetail_UC).TextBoxDescription.Text;
                        StatusCareTypeDetail.User_Id = MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID;
                        StatusCareTypeDetail.ChangeDateTime = MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now);

                        Ls.Add(StatusCareTypeDetail);
                    }

                new ViewModel.Status.StatusTypeDetailCare().InsertEntity(Ls, ref str, ref idSet);

            }


            if (_systemTypeSet == SystemType.Health)
            {
                new ViewModel.Status.StatusTypeDetailVisitHealthCare().DeleteWithHealthCareId(_defId, ref str);
                List<TBL_StatusTypeDetailVisitHealthCare> Ls = new List<TBL_StatusTypeDetailVisitHealthCare>();
                foreach (Control fg in tableLayoutPanelNews.Controls)
                    if (fg.Visible)
                    {
                        TBL_StatusTypeDetailVisitHealthCare StatusHealthTypeDetail = new TBL_StatusTypeDetailVisitHealthCare();
                        StatusHealthTypeDetail.VisitHealthCare_Id = _defId;
                        StatusHealthTypeDetail.StatusTypeDetail_Id = (fg as AllStatusDetail_UC).CheckBoxStatusTypeDetail.Tag.ToString().ToInt();

                        StatusHealthTypeDetail.ConfirmSet = (fg as AllStatusDetail_UC).CheckBoxStatusTypeDetail.Checked;
                        StatusHealthTypeDetail.Description = (fg as AllStatusDetail_UC).TextBoxDescription.Text;
                        StatusHealthTypeDetail.User_Id = MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID;
                        StatusHealthTypeDetail.ChangeDateTime = MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now);

                        Ls.Add(StatusHealthTypeDetail);
                    }

                new ViewModel.Status.StatusTypeDetailVisitHealthCare().InsertEntity(Ls, ref str, ref idSet);

            }


            if (_systemTypeSet == SystemType.Physiotherapy)
            {
                new ViewModel.Status.StatusTypeDetailPhysiotherapy().DeleteWithPhysiotherapyId(_defId, ref str);
                List<TBL_StatusTypeDetailPhysiotherapy> Ls = new List<TBL_StatusTypeDetailPhysiotherapy>();
                foreach (Control fg in tableLayoutPanelNews.Controls)
                    if (fg.Visible)
                    {
                        TBL_StatusTypeDetailPhysiotherapy StatusPhysiotherapyTypeDetail = new TBL_StatusTypeDetailPhysiotherapy();
                        StatusPhysiotherapyTypeDetail.VisitPatientPhysiotherapy_Id = _defId;
                        StatusPhysiotherapyTypeDetail.StatusTypeDetail_Id = (fg as AllStatusDetail_UC).CheckBoxStatusTypeDetail.Tag.ToString().ToInt();

                        StatusPhysiotherapyTypeDetail.ConfirmSet = (fg as AllStatusDetail_UC).CheckBoxStatusTypeDetail.Checked;
                        StatusPhysiotherapyTypeDetail.Description = (fg as AllStatusDetail_UC).TextBoxDescription.Text;
                        StatusPhysiotherapyTypeDetail.User_Id = MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID;
                        StatusPhysiotherapyTypeDetail.ChangeDateTime = MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now);

                        Ls.Add(StatusPhysiotherapyTypeDetail);
                    }

                new ViewModel.Status.StatusTypeDetailPhysiotherapy().InsertEntity(Ls, ref str, ref idSet);

            }

            if (_systemTypeSet == SystemType.VisitPatient)
            {
                new ViewModel.Status.StatusTypeDetailVisitPatient().DeleteWithVisitPatientId(_defId, ref str);
                List<TBL_StatusTypeDetailVisitPatient> Ls = new List<TBL_StatusTypeDetailVisitPatient>();
                foreach (Control fg in tableLayoutPanelNews.Controls)
                    if (fg.Visible)
                    {
                        TBL_StatusTypeDetailVisitPatient StatusTypeDetailVisitPatient = new TBL_StatusTypeDetailVisitPatient();
                        StatusTypeDetailVisitPatient.VisitPatient_Id = _defId;
                        StatusTypeDetailVisitPatient.StatusTypeDetail_Id = (fg as AllStatusDetail_UC).CheckBoxStatusTypeDetail.Tag.ToString().ToInt();

                        StatusTypeDetailVisitPatient.ConfirmSet = (fg as AllStatusDetail_UC).CheckBoxStatusTypeDetail.Checked;
                        StatusTypeDetailVisitPatient.Description = (fg as AllStatusDetail_UC).TextBoxDescription.Text;
                        StatusTypeDetailVisitPatient.User_Id = MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID;
                        StatusTypeDetailVisitPatient.ChangeDateTime = MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now);

                        Ls.Add(StatusTypeDetailVisitPatient);
                    }

                new ViewModel.Status.StatusTypeDetailVisitPatient().InsertEntity(Ls, ref str, ref idSet);

            }

            return str;
        }

        private bool CheckValidation()
        {
            //if (TextBoxStatusType.Text.Trim() == "")
            //{
            //    MKH.Library.Clasess.MSSMessage.MSSMessage_View("لطفا نوع وضعیت را پر نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation);
            //    return false;
            //}
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
                    ctrl.DataRelationNew = MKH.Library.Clasess.PublicClass.ToDataTable<Model.Status.VW_StatusTypeDetailPatientReport>(new ViewModel.Status.StatusTypeDetailPatient().GetResid(Id, ref str));
                    ctrl.DataRelationNew.Columns["PatientName"].ColumnName = "نام بیمار";
                    ctrl.DataRelationNew.Columns["PatientFamily"].ColumnName = "نام خانوادگی بیمار";
                    ctrl.DataRelationNew.Columns["NationalCode"].ColumnName = "کدملی بیمار";
                    ctrl.DataRelationNew.Columns["Description"].ColumnName = "توضیحات";
                    ctrl.DataRelationNew.Columns["ConfirmSet"].ColumnName = "مدرک دارد";
                    ctrl.DataRelationNew.Columns["StatusTypeDetailName"].ColumnName = "جزییات نوع وضعیت";
                    ctrl.DataRelationNew.Columns["StatusTypeName"].ColumnName = "نوع وضعیت";
                    ctrl.DataRelationNew.Columns["UsersNameFamily"].ColumnName = "نام و نام خانوادگی کاربر";
                    ctrl.DataRelationNew.Columns["ChangeDateTime"].ColumnName = "تاریخ و ساعت رسید";
                    ctrl.DataRelationNew.Columns.Remove("Id");
                    ctrl.DataRelationNew.Columns.Remove("Patient_Id");
                    ctrl.DataRelationNew.Columns.Remove("StartDateAlarm");
                    ctrl.DataRelationNew.Columns.Remove("StatusTypeDetail_Id");
                    ctrl.DataRelationNew.Columns.Remove("FReserve1");
                    ctrl.DataRelationNew.Columns.Remove("User_Id");
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
                    ctrl.DataRelationNew = MKH.Library.Clasess.PublicClass.ToDataTable<Model.Status.VW_StatusTypeDetailCareReport>(new ViewModel.Status.StatusTypeDetailCare().GetResid(Id, ref str));
                    ctrl.DataRelationNew.Columns["PatientName"].ColumnName = "نام بیمار";
                    ctrl.DataRelationNew.Columns["PatientFamily"].ColumnName = "نام خانوادگی بیمار";
                    ctrl.DataRelationNew.Columns["NationalCode"].ColumnName = "کدملی بیمار";
                    ctrl.DataRelationNew.Columns["Description"].ColumnName = "توضیحات";
                    ctrl.DataRelationNew.Columns["ConfirmSet"].ColumnName = "مدرک دارد";
                    ctrl.DataRelationNew.Columns["StatusTypeDetailName"].ColumnName = "جزییات نوع وضعیت";
                    ctrl.DataRelationNew.Columns["StatusTypeName"].ColumnName = "نوع وضعیت";
                    ctrl.DataRelationNew.Columns["UsersNameFamily"].ColumnName = "نام و نام خانوادگی کاربر";
                    ctrl.DataRelationNew.Columns["ChangeDateTime"].ColumnName = "تاریخ و ساعت رسید";
                    ctrl.DataRelationNew.Columns["CarrierName"].ColumnName = "نام مراقب";
                    ctrl.DataRelationNew.Columns["CarrierFamily"].ColumnName = "نام خانوادگی مراقب";
                    ctrl.DataRelationNew.Columns["CarrierNationalCode"].ColumnName = "کدملی مراقب";

                    ctrl.DataRelationNew.Columns.Remove("Id");
                    ctrl.DataRelationNew.Columns.Remove("VisitPatientCare_Id");
                    ctrl.DataRelationNew.Columns.Remove("StartDateAlarm");
                    ctrl.DataRelationNew.Columns.Remove("StatusTypeDetail_Id");
                    ctrl.DataRelationNew.Columns.Remove("FReserve1");
                    ctrl.DataRelationNew.Columns.Remove("User_Id");
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
                    ctrl.DataRelationNew = MKH.Library.Clasess.PublicClass.ToDataTable<Model.Status.VW_StatusTypeDetailVisitHealthCareReport>(new ViewModel.Status.StatusTypeDetailVisitHealthCare().GetResid(Id, ref str));

                    ctrl.DataRelationNew.Columns["PatientName"].ColumnName = "نام بیمار";
                    ctrl.DataRelationNew.Columns["PatientFamily"].ColumnName = "نام خانوادگی بیمار";
                    ctrl.DataRelationNew.Columns["NationalCode"].ColumnName = "کدملی بیمار";
                    ctrl.DataRelationNew.Columns["Description"].ColumnName = "توضیحات";
                    ctrl.DataRelationNew.Columns["ConfirmSet"].ColumnName = "مدرک دارد";
                    ctrl.DataRelationNew.Columns["StatusTypeDetailName"].ColumnName = "جزییات نوع وضعیت";
                    ctrl.DataRelationNew.Columns["StatusTypeName"].ColumnName = "نوع وضعیت";
                    ctrl.DataRelationNew.Columns["UsersNameFamily"].ColumnName = "نام و نام خانوادگی کاربر";
                    ctrl.DataRelationNew.Columns["ChangeDateTime"].ColumnName = "تاریخ و ساعت رسید";
                    ctrl.DataRelationNew.Columns["DoctorName"].ColumnName = "نام پزشک";
                    ctrl.DataRelationNew.Columns["DoctorFamily"].ColumnName = "نام خانوادگی پزشک";

                    ctrl.DataRelationNew.Columns.Remove("Id");
                    ctrl.DataRelationNew.Columns.Remove("VisitHealthCare_Id");
                    ctrl.DataRelationNew.Columns.Remove("StartDateAlarm");
                    ctrl.DataRelationNew.Columns.Remove("StatusTypeDetail_Id");
                    ctrl.DataRelationNew.Columns.Remove("FReserve1");
                    ctrl.DataRelationNew.Columns.Remove("User_Id");
                    
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
                    ctrl.DataRelationNew = MKH.Library.Clasess.PublicClass.ToDataTable<Model.Status.VW_StatusTypeDetailPhysiotherapyReport>(new ViewModel.Status.StatusTypeDetailPhysiotherapy().GetResid(Id, ref str));

                    ctrl.DataRelationNew.Columns["PatientName"].ColumnName = "نام بیمار";
                    ctrl.DataRelationNew.Columns["PatientFamily"].ColumnName = "نام خانوادگی بیمار";
                    ctrl.DataRelationNew.Columns["NationalCode"].ColumnName = "کدملی بیمار";
                    ctrl.DataRelationNew.Columns["Description"].ColumnName = "توضیحات";
                    ctrl.DataRelationNew.Columns["ConfirmSet"].ColumnName = "مدرک دارد";
                    ctrl.DataRelationNew.Columns["StatusTypeDetailName"].ColumnName = "جزییات نوع وضعیت";
                    ctrl.DataRelationNew.Columns["StatusTypeName"].ColumnName = "نوع وضعیت";
                    ctrl.DataRelationNew.Columns["UsersNameFamily"].ColumnName = "نام و نام خانوادگی کاربر";
                    ctrl.DataRelationNew.Columns["ChangeDateTime"].ColumnName = "تاریخ و ساعت رسید";
                    ctrl.DataRelationNew.Columns["DoctorName"].ColumnName = "نام پزشک";
                    ctrl.DataRelationNew.Columns["DoctorFamily"].ColumnName = "نام خانوادگی پزشک";

                    ctrl.DataRelationNew.Columns.Remove("Id");
                    ctrl.DataRelationNew.Columns.Remove("VisitPatientPhysiotherapy_Id");
                    ctrl.DataRelationNew.Columns.Remove("StartDateAlarm");
                    ctrl.DataRelationNew.Columns.Remove("StatusTypeDetail_Id");
                    ctrl.DataRelationNew.Columns.Remove("FReserve1");
                    ctrl.DataRelationNew.Columns.Remove("User_Id");
                    
                    ctrl.NameForDB = "رسید فیزیوتراپی";
                    ctrl.ShowDialog();
                }
                catch { }
            }
            if (_systemTypeSet == SystemType.VisitPatient)
            {
                MKH.Library.Forms.MSSReportDesignList_frm ctrl = new MKH.Library.Forms.MSSReportDesignList_frm(this.Name + "VisitPatient");
                try
                {
                    ctrl.DataRelationNew = MKH.Library.Clasess.PublicClass.ToDataTable<Model.Status.VW_StatusTypeDetailVisitPatientReport>(new ViewModel.Status.StatusTypeDetailVisitPatient().GetResid(Id, ref str));

                    ctrl.DataRelationNew.Columns["PatientName"].ColumnName = "نام بیمار";
                    ctrl.DataRelationNew.Columns["PatientFamily"].ColumnName = "نام خانوادگی بیمار";
                    ctrl.DataRelationNew.Columns["NationalCode"].ColumnName = "کدملی بیمار";
                    ctrl.DataRelationNew.Columns["Description"].ColumnName = "توضیحات";
                    ctrl.DataRelationNew.Columns["ConfirmSet"].ColumnName = "مدرک دارد";
                    ctrl.DataRelationNew.Columns["StatusTypeDetailName"].ColumnName = "جزییات نوع وضعیت";
                    ctrl.DataRelationNew.Columns["StatusTypeName"].ColumnName = "نوع وضعیت";
                    ctrl.DataRelationNew.Columns["UsersNameFamily"].ColumnName = "نام و نام خانوادگی کاربر";
                    ctrl.DataRelationNew.Columns["ChangeDateTime"].ColumnName = "تاریخ و ساعت رسید";
                    ctrl.DataRelationNew.Columns["DoctorName"].ColumnName = "نام پزشک";
                    ctrl.DataRelationNew.Columns["DoctorFamily"].ColumnName = "نام خانوادگی پزشک";

                    ctrl.DataRelationNew.Columns.Remove("Id");
                    ctrl.DataRelationNew.Columns.Remove("VisitPatient_Id");
                    ctrl.DataRelationNew.Columns.Remove("StartDateAlarm");
                    ctrl.DataRelationNew.Columns.Remove("StatusTypeDetail_Id");
                    ctrl.DataRelationNew.Columns.Remove("FReserve1");
                    ctrl.DataRelationNew.Columns.Remove("User_Id");

                    ctrl.NameForDB = "رسید ویزیت";
                    ctrl.ShowDialog();
                }
                catch { }
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void buttonAddState_Click(object sender, EventArgs e)
        {
            try
            {
                string StrSet = "";
                Dictionary<string, string> SD = new Dictionary<string, string>();
                Dictionary<string, string> SD1 = new Dictionary<string, string>();

                foreach (var item in new ViewModel.Status.StatusTypeDetail().GetAllList(ref StrSet))
                    SD.Add(item.Id.ToString(), item.StatusTypeName + "-" + item.TitleName);

                SD1 = MKH.Library.Forms.MSSSelector_frm.SetDataSelect(SD);

                if (SD1 != null)
                    FillTableLayoutPanelSet(Convert.ToInt64(0), SD1.Keys.ToList()[0].ToString().ToInt(), SD1.Values.ToList()[0].ToString(), false, "");

            }
            catch (Exception ex)
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "اشکال", ex.Message);
            }

        }

        private void FillTableLayoutPanelSet(long AllStatus_Id, int StatusTypeDetail_Id, string StatusTypeDetailName, bool ConfirmSet, string Description)
        {
            try
            {
                AllStatusDetail_UC smsp = new AllStatusDetail_UC();
                smsp.Tag = AllStatus_Id;
                smsp.CheckBoxStatusTypeDetail.Text = StatusTypeDetailName;
                smsp.CheckBoxStatusTypeDetail.Tag = StatusTypeDetail_Id.ToString();
                smsp.CheckBoxStatusTypeDetail.Checked = ConfirmSet;
                smsp.TextBoxDescription.Text = Description;

                smsp.buttonDelete.Enabled = ButtonDelEnabled;

                smsp.Controls.Owner.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                tableLayoutPanelNews.Controls.Add(smsp, 1, tableLayoutPanelNews.Controls.Count + 1);

            }
            catch (Exception ex)
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, ex.Message);
            }
            SetRowTableSet();
        }

       


    }
}
