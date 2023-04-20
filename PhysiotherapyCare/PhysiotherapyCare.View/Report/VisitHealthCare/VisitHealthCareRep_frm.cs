using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace PhysiotherapyCare.Report.VisitHealthCare
{
    public partial class VisitHealthCareRep_frm : MKH.Library.Forms.MSSBaseNew_frm
    {
        public VisitHealthCareRep_frm()
        {
            InitializeComponent();
        }

        private void VisitHealthCareRep_frm_Load(object sender, EventArgs e)
        {
            DatePickerHealthCareDateAz.Value = KagNetComponents2.KagPersianDate.Parse(DateTime.Now);
            DatePickerHealthCareDateTa.Value = DatePickerAnalyzeDateAz.Value = DatePickerAnalyzeDateTa.Value = DatePickerInsuLetterDateAZ.Value = DatePickerInsuLetterDateTa.Value = DatePickerSecretiatDateAz.Value = DatePickerSecretiatDateTa.Value = DatePickerAccountingDocumentDateAz.Value = DatePickerAccountingDocumentDateTa.Value = DatePickerBursaryDateAz.Value = DatePickerBursaryDateTa.Value = DatePickerHealthCareDateAz.Value;

            tabItemPayment.Visible = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(308);
            tabItemFew.Visible = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(309);
        }




        #region Preview Chart

        private void buttonItemOK_Click(object sender, EventArgs e)
        {
            string str = "", WhereStr = "", FieldGroup = "", FieldDateGroup = "";



            if (RadioButtonFunctionalityDoctorPrice.Checked && TabControlHealthCareRep.SelectedTabIndex == 0)
            {

                if (!CheckBoxHealthCareDate.Checked && !CheckBoxSecretiatDate.Checked && !CheckBoxInsuLetterDate.Checked && !CheckBoxAnalyzeDate.Checked)
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View("لطفا فیلد تاریخ را مشخص نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SWarning);
                    return;
                }

                if (ComboBoxGroupBy.SelectedIndex == -1 && ComboBoxDateGroup.SelectedIndex == -1)
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View("لطفا یکی از ستون های تفکیک را مشخص نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SWarning);
                    return;
                }

                if (CheckBoxHealthCareDate.Checked)
                    WhereStr = " HealthCareDate >= '" + DatePickerHealthCareDateAz.Value.ToString().Substring(0, 10) + "' and HealthCareDate <= '" + DatePickerHealthCareDateTa.Value.ToString().Substring(0, 10) + "' and ";
                if (CheckBoxInsuLetterDate.Checked)
                    WhereStr += " InsuLetterDate >= '" + DatePickerInsuLetterDateAZ.Value.ToString().Substring(0, 10) + "' and InsuLetterDate <= '" + DatePickerInsuLetterDateTa.Value.ToString().Substring(0, 10) + "' and ";
                if (CheckBoxSecretiatDate.Checked)
                    WhereStr += " SecretiatDate >= '" + DatePickerSecretiatDateAz.Value.ToString().Substring(0, 10) + "' and SecretiatDate <= '" + DatePickerSecretiatDateTa.Value.ToString().Substring(0, 10) + "' and ";
                if (CheckBoxAnalyzeDate.Checked)
                    WhereStr += " AnalyzeDate >= '" + DatePickerAnalyzeDateAz.Value.ToString().Substring(0, 10) + "' and AnalyzeDate <= '" + DatePickerAnalyzeDateTa.Value.ToString().Substring(0, 10) + "' and ";
                if (CheckBoxAccountingDocumentDate.Checked)
                    WhereStr += " AccountingDocumentDate >= '" + DatePickerAccountingDocumentDateAz.Value.ToString().Substring(0, 10) + "' and AccountingDocumentDate <= '" + DatePickerAccountingDocumentDateTa.Value.ToString().Substring(0, 10) + "' and ";
                if (CheckBoxBursaryDate.Checked)
                    WhereStr += " BursaryDate >= '" + DatePickerBursaryDateAz.Value.ToString().Substring(0, 10) + "' and BursaryDate <= '" + DatePickerBursaryDateTa.Value.ToString().Substring(0, 10) + "' and ";
                WhereStr += " 1=1 ";

                if (CheckBoxDoctor.Checked)
                {
                    if (ListViewDoctorName.Items.Count == 0)
                    {
                        MKH.Library.Clasess.MSSMessage.MSSMessage_View("لطفا نام بهیار را مشخص نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SWarning);
                        return;
                    }

                    WhereStr += " and (";
                    for (int i = 0; i < ListViewDoctorName.Items.Count; i++)
                        WhereStr += " Doctor_Id = " + ListViewDoctorName.Items[i].Tag.ToString() + " Or ";
                    WhereStr += " 1<>1 )";
                }

                if (CheckBoxIf.Checked)
                {
                    if (ComboBoxFieldIf.SelectedIndex != -1)
                        if (TextBoxIf.Text != "")
                        {
                            WhereStr += " and (";
                            for (int i = 0; i < TextBoxIf.Lines.Count(); i++)
                                if (TextBoxIf.Lines[i] != "")
                                {
                                    if (ComboBoxFieldIf.SelectedIndex == 0)
                                        WhereStr += " InsuLetterNo = '" + TextBoxIf.Lines[i] + "' Or ";
                                    else if (ComboBoxFieldIf.SelectedIndex == 1)
                                        WhereStr += " SecretiatNo = '" + TextBoxIf.Lines[i] + "' Or ";
                                    else if (ComboBoxFieldIf.SelectedIndex == 2)
                                        WhereStr += " AnalyzeNo = '" + TextBoxIf.Lines[i] + "' Or ";
                                    else if (ComboBoxFieldIf.SelectedIndex == 3)
                                        WhereStr += " AccountingDocumentNumber = '" + TextBoxIf.Lines[i] + "'  Or ";
                                    else if (ComboBoxFieldIf.SelectedIndex == 4)
                                        WhereStr += " BursaryNumber = '" + TextBoxIf.Lines[i] + "'  Or ";

                                }
                            WhereStr += " 1<>1 )";
                        }
                }

                if (ComboBoxGroupBy.SelectedIndex != -1)
                {
                    if (ComboBoxGroupBy.SelectedIndex == 0)
                        FieldGroup = "Doctor_Id";
                    else if (ComboBoxGroupBy.SelectedIndex == 1)
                        FieldGroup = "InsuLetterNo";
                    else if (ComboBoxGroupBy.SelectedIndex == 2)
                        FieldGroup = "SecretiatNo";
                    else if (ComboBoxGroupBy.SelectedIndex == 3)
                        FieldGroup = "AnalyzeNo";
                    else if (ComboBoxGroupBy.SelectedIndex == 4)
                        FieldGroup = "AccountingDocumentNumber";
                    else if (ComboBoxGroupBy.SelectedIndex == 5)
                        FieldGroup = "InstitutePart";
                    else if (ComboBoxGroupBy.SelectedIndex == 6)
                        FieldGroup = "ReportCode";
                    else if (ComboBoxGroupBy.SelectedIndex == 7)
                        FieldGroup = "BonyadConfirmNo";
                    else if (ComboBoxGroupBy.SelectedIndex == 8)
                        FieldGroup = "AnalyzePage";
                    else if (ComboBoxGroupBy.SelectedIndex == 9)
                        FieldGroup = "BursaryNumber";
                    else if (ComboBoxGroupBy.SelectedIndex == 10)
                        FieldGroup = "Patient_Id";
                }
                if (ComboBoxGroupBy1.SelectedIndex != -1)
                {
                    if (ComboBoxGroupBy.SelectedIndex != -1) FieldGroup += ',';
                    if (ComboBoxGroupBy1.SelectedIndex == 0)
                        FieldGroup += "Doctor_Id";
                    else if (ComboBoxGroupBy1.SelectedIndex == 1)
                        FieldGroup += "InsuLetterNo";
                    else if (ComboBoxGroupBy1.SelectedIndex == 2)
                        FieldGroup += "SecretiatNo";
                    else if (ComboBoxGroupBy1.SelectedIndex == 3)
                        FieldGroup += "AnalyzeNo";
                    else if (ComboBoxGroupBy1.SelectedIndex == 4)
                        FieldGroup += "AccountingDocumentNumber";
                    else if (ComboBoxGroupBy1.SelectedIndex == 5)
                        FieldGroup += "InstitutePart";
                    else if (ComboBoxGroupBy1.SelectedIndex == 6)
                        FieldGroup += "ReportCode";
                    else if (ComboBoxGroupBy1.SelectedIndex == 7)
                        FieldGroup += "BonyadConfirmNo";
                    else if (ComboBoxGroupBy1.SelectedIndex == 8)
                        FieldGroup += "AnalyzePage";
                    else if (ComboBoxGroupBy1.SelectedIndex == 9)
                        FieldGroup += "BursaryNumber";
                    else if (ComboBoxGroupBy1.SelectedIndex == 10)
                        FieldGroup += "Patient_Id";
                }

                if (ComboBoxDateGroup.SelectedIndex != -1)
                {
                    if (ComboBoxDateGroup.SelectedIndex == 0)
                        FieldDateGroup = "HealthCareDate";
                    else if (ComboBoxDateGroup.SelectedIndex == 1)
                        FieldDateGroup = "InsuLetterDate";
                    else if (ComboBoxDateGroup.SelectedIndex == 2)
                        FieldDateGroup = "SecretiatDate";
                    else if (ComboBoxDateGroup.SelectedIndex == 3)
                        FieldDateGroup = "AnalyzeDate";
                    else if (ComboBoxDateGroup.SelectedIndex == 4)
                        FieldDateGroup = "BonyadConfirmDate";
                    else if (ComboBoxDateGroup.SelectedIndex == 5)
                        FieldDateGroup = "AccountingDocumentDate";
                    else if (ComboBoxDateGroup.SelectedIndex == 6)
                        FieldDateGroup = "BursaryDate";
                }

                
                
                MKH.Library.Forms.MSSReportDesignList_frm ctrl = new MKH.Library.Forms.MSSReportDesignList_frm(RadioButtonFunctionalityDoctorPrice.Name+this.Name);
                try
                {
                    ctrl.DataRelationNew = MKH.Library.Clasess.PublicClass.ToDataTable<Model.VisitHealthCare.SP_VisitHealthCarePaymentReportResult>(new ViewModel.VisitHealthCare.VisitHealthCarePayment().GetReport(FieldGroup, FieldDateGroup, WhereStr, ref str).ToList());

                    //ctrl.DataRelationNewSlave = MKH.Library.Clasess.PublicClass.ToDataTable<Model.VisitHealthCare.SP_ServiceHealthCareReportForDetailWithGroupResult>(new ViewModel.VisitHealthCare.ServiceHealthCare().GetReportForDetailWithGroup(ref str));

                    //ctrl.NameForDBSlave = "لیست جزییات خدمات";
                    ctrl.NameForDB = "مالی بهیاری";
                    ctrl.ShowDialog();
                }
                catch (Exception ex)
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "اشکال اطلاعات", ex.Message);
                }
            }


            if (RadioButtonFunctionalityDoctorHealthPriceWithServiceDsc.Checked && TabControlHealthCareRep.SelectedTabIndex == 0)
            {

                if (!CheckBoxHealthCareDate.Checked && !CheckBoxSecretiatDate.Checked && !CheckBoxInsuLetterDate.Checked && !CheckBoxAnalyzeDate.Checked)
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View("لطفا فیلد تاریخ را مشخص نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SWarning);
                    return;
                }

                if (ComboBoxGroupBy.SelectedIndex == -1 && ComboBoxDateGroup.SelectedIndex == -1)
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View("لطفا یکی از ستون های تفکیک را مشخص نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SWarning);
                    return;
                }

                if (CheckBoxHealthCareDate.Checked)
                    WhereStr = " HealthCareDate >= '" + DatePickerHealthCareDateAz.Value.ToString().Substring(0, 10) + "' and HealthCareDate <= '" + DatePickerHealthCareDateTa.Value.ToString().Substring(0, 10) + "' and ";
                if (CheckBoxInsuLetterDate.Checked)
                    WhereStr += " InsuLetterDate >= '" + DatePickerInsuLetterDateAZ.Value.ToString().Substring(0, 10) + "' and InsuLetterDate <= '" + DatePickerInsuLetterDateTa.Value.ToString().Substring(0, 10) + "' and ";
                if (CheckBoxSecretiatDate.Checked)
                    WhereStr += " SecretiatDate >= '" + DatePickerSecretiatDateAz.Value.ToString().Substring(0, 10) + "' and SecretiatDate <= '" + DatePickerSecretiatDateTa.Value.ToString().Substring(0, 10) + "' and ";
                if (CheckBoxAnalyzeDate.Checked)
                    WhereStr += " AnalyzeDate >= '" + DatePickerAnalyzeDateAz.Value.ToString().Substring(0, 10) + "' and AnalyzeDate <= '" + DatePickerAnalyzeDateTa.Value.ToString().Substring(0, 10) + "' and ";
                if (CheckBoxAccountingDocumentDate.Checked)
                    WhereStr += " AccountingDocumentDate >= '" + DatePickerAccountingDocumentDateAz.Value.ToString().Substring(0, 10) + "' and AccountingDocumentDate <= '" + DatePickerAccountingDocumentDateTa.Value.ToString().Substring(0, 10) + "' and ";
                if (CheckBoxBursaryDate.Checked)
                    WhereStr += " BursaryDate >= '" + DatePickerBursaryDateAz.Value.ToString().Substring(0, 10) + "' and BursaryDate <= '" + DatePickerBursaryDateTa.Value.ToString().Substring(0, 10) + "' and ";
                WhereStr += " 1=1 ";

                if (CheckBoxDoctor.Checked)
                {
                    if (ListViewDoctorName.Items.Count == 0)
                    {
                        MKH.Library.Clasess.MSSMessage.MSSMessage_View("لطفا نام بهیار را مشخص نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SWarning);
                        return;
                    }

                    WhereStr += " and (";
                    for (int i = 0; i < ListViewDoctorName.Items.Count; i++)
                        WhereStr += " Doctor_Id = " + ListViewDoctorName.Items[i].Tag.ToString() + " Or ";
                    WhereStr += " 1<>1 )";
                }

                if (CheckBoxIf.Checked)
                {
                    if (ComboBoxFieldIf.SelectedIndex != -1)
                        if (TextBoxIf.Text != "")
                        {
                            WhereStr += " and (";
                            for (int i = 0; i < TextBoxIf.Lines.Count(); i++)
                                if (TextBoxIf.Lines[i] != "")
                                {
                                    if (ComboBoxFieldIf.SelectedIndex == 0)
                                        WhereStr += " InsuLetterNo = '" + TextBoxIf.Lines[i] + "' Or ";
                                    else if (ComboBoxFieldIf.SelectedIndex == 1)
                                        WhereStr += " SecretiatNo = '" + TextBoxIf.Lines[i] + "' Or ";
                                    else if (ComboBoxFieldIf.SelectedIndex == 2)
                                        WhereStr += " AnalyzeNo = '" + TextBoxIf.Lines[i] + "' Or ";
                                    else if (ComboBoxFieldIf.SelectedIndex == 3)
                                        WhereStr += " AccountingDocumentNumber = '" + TextBoxIf.Lines[i] + "'  Or ";
                                    else if (ComboBoxFieldIf.SelectedIndex == 4)
                                        WhereStr += " BursaryNumber = '" + TextBoxIf.Lines[i] + "'  Or ";

                                }
                            WhereStr += " 1<>1 )";
                        }
                }

                if (ComboBoxGroupBy.SelectedIndex != -1)
                {
                    if (ComboBoxGroupBy.SelectedIndex == 0)
                        FieldGroup = "Doctor_Id";
                    else if (ComboBoxGroupBy.SelectedIndex == 1)
                        FieldGroup = "InsuLetterNo";
                    else if (ComboBoxGroupBy.SelectedIndex == 2)
                        FieldGroup = "SecretiatNo";
                    else if (ComboBoxGroupBy.SelectedIndex == 3)
                        FieldGroup = "AnalyzeNo";
                    else if (ComboBoxGroupBy.SelectedIndex == 4)
                        FieldGroup = "AccountingDocumentNumber";
                    else if (ComboBoxGroupBy.SelectedIndex == 5)
                        FieldGroup = "InstitutePart";
                    else if (ComboBoxGroupBy.SelectedIndex == 6)
                        FieldGroup = "ReportCode";
                    else if (ComboBoxGroupBy.SelectedIndex == 7)
                        FieldGroup = "BonyadConfirmNo";
                    else if (ComboBoxGroupBy.SelectedIndex == 8)
                        FieldGroup = "AnalyzePage";
                    else if (ComboBoxGroupBy.SelectedIndex == 9)
                        FieldGroup = "BursaryNumber";
                    else if (ComboBoxGroupBy.SelectedIndex == 10)
                        FieldGroup = "Patient_Id";
                }
                if (ComboBoxGroupBy1.SelectedIndex != -1)
                {
                    if (ComboBoxGroupBy.SelectedIndex != -1) FieldGroup += ',';
                    if (ComboBoxGroupBy1.SelectedIndex == 0)
                        FieldGroup += "Doctor_Id";
                    else if (ComboBoxGroupBy1.SelectedIndex == 1)
                        FieldGroup += "InsuLetterNo";
                    else if (ComboBoxGroupBy1.SelectedIndex == 2)
                        FieldGroup += "SecretiatNo";
                    else if (ComboBoxGroupBy1.SelectedIndex == 3)
                        FieldGroup += "AnalyzeNo";
                    else if (ComboBoxGroupBy1.SelectedIndex == 4)
                        FieldGroup += "AccountingDocumentNumber";
                    else if (ComboBoxGroupBy1.SelectedIndex == 5)
                        FieldGroup += "InstitutePart";
                    else if (ComboBoxGroupBy1.SelectedIndex == 6)
                        FieldGroup += "ReportCode";
                    else if (ComboBoxGroupBy1.SelectedIndex == 7)
                        FieldGroup += "BonyadConfirmNo";
                    else if (ComboBoxGroupBy1.SelectedIndex == 8)
                        FieldGroup += "AnalyzePage";
                    else if (ComboBoxGroupBy1.SelectedIndex == 9)
                        FieldGroup += "BursaryNumber";
                    else if (ComboBoxGroupBy1.SelectedIndex == 10)
                        FieldGroup += "Patient_Id";
                }

                if (ComboBoxDateGroup.SelectedIndex != -1)
                {
                    if (ComboBoxDateGroup.SelectedIndex == 0)
                        FieldDateGroup = "HealthCareDate";
                    else if (ComboBoxDateGroup.SelectedIndex == 1)
                        FieldDateGroup = "InsuLetterDate";
                    else if (ComboBoxDateGroup.SelectedIndex == 2)
                        FieldDateGroup = "SecretiatDate";
                    else if (ComboBoxDateGroup.SelectedIndex == 3)
                        FieldDateGroup = "AnalyzeDate";
                    else if (ComboBoxDateGroup.SelectedIndex == 4)
                        FieldDateGroup = "BonyadConfirmDate";
                    else if (ComboBoxDateGroup.SelectedIndex == 5)
                        FieldDateGroup = "AccountingDocumentDate";
                    else if (ComboBoxDateGroup.SelectedIndex == 6)
                        FieldDateGroup = "BursaryDate";
                }



                MKH.Library.Forms.MSSReportDesignList_frm ctrl = new MKH.Library.Forms.MSSReportDesignList_frm(RadioButtonFunctionalityDoctorHealthPriceWithServiceDsc.Name + this.Name);
                try
                {
                    ctrl.DataRelationNew = MKH.Library.Clasess.PublicClass.ToDataTable<Model.VisitHealthCare.SP_VisitHealthCarePaymentWithServiceHealthCareReportResult>(new ViewModel.VisitHealthCare.VisitHealthCarePayment().GetReportWithService(FieldGroup, FieldDateGroup, WhereStr, ref str).ToList());

                    ctrl.NameForDB = "مالی بهیاری";
                    ctrl.ShowDialog();
                }
                catch (Exception ex)
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "اشکال اطلاعات", ex.Message);
                }
            }

          
            
            if (RadioButtonFunctionalityAllHealthWithServiceDsc.Checked && TabControlHealthCareRep.SelectedTabIndex == 0)
            {

                if (!CheckBoxHealthCareDate.Checked)
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View("لطفا تاریخ بهیاری را مشخص نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SWarning);
                    return;
                }


                if (CheckBoxHealthCareDate.Checked)
                    WhereStr = " HealthCareDate >= '" + DatePickerHealthCareDateAz.Value.ToString().Substring(0, 10) + "' and HealthCareDate <= '" + DatePickerHealthCareDateTa.Value.ToString().Substring(0, 10) + "' and ";
                WhereStr += " 1=1 ";

                if (CheckBoxDoctor.Checked)
                {
                    if (ListViewDoctorName.Items.Count == 0)
                    {
                        MKH.Library.Clasess.MSSMessage.MSSMessage_View("لطفا نام بهیار را مشخص نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SWarning);
                        return;
                    }

                    WhereStr += " and (";
                    for (int i = 0; i < ListViewDoctorName.Items.Count; i++)
                        WhereStr += " Doctor_Id = " + ListViewDoctorName.Items[i].Tag.ToString() + " Or ";
                    WhereStr += " 1<>1 )";
                }




                MKH.Library.Forms.MSSReportDesignList_frm ctrl = new MKH.Library.Forms.MSSReportDesignList_frm(RadioButtonFunctionalityAllHealthWithServiceDsc.Name + this.Name);
                try
                {
                    ctrl.DataRelationNew = MKH.Library.Clasess.PublicClass.ToDataTable<Model.VisitHealthCare.SP_VisitHealthCareWithServiceHealthCareReportResult>(new ViewModel.VisitHealthCare.VisitHealthCare().GetReportWithService(WhereStr, ref str).ToList());
                    
                    ctrl.NameForDB = "ریز خدمات بهیاری";
                    ctrl.ShowDialog();
                }
                catch (Exception ex)
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "اشکال اطلاعات", ex.Message);
                }
            }

            
            else if (RadioButtonFunctionalityVisitHealthCare.Checked && TabControlHealthCareRep.SelectedTabIndex == 1)
            {
                try
                {
                    MKH.Library.Forms.MSSReportDesignList_frm ctrl = new MKH.Library.Forms.MSSReportDesignList_frm(RadioButtonFunctionalityVisitHealthCare.Name + this.Name);
                    if (CheckBoxDoctor.Checked)
                        try { ctrl.DataRelationNew = MKH.Library.Clasess.PublicClass.ToDataTable<Model.VisitHealthCare.SP_VisitHealthCareReportResult>((new ViewModel.VisitHealthCare.VisitHealthCare().GetReport(DatePickerHealthCareDateAz.Value.ToString().Substring(0, 10), DatePickerHealthCareDateTa.Value.ToString().Substring(0, 10), checkBoxVisitHealthCareSeparateDate.Checked, ref str).Where(g => g.کد_بهیار == ListViewDoctorName.Items[0].Tag.ToString().ToInt())).ToList()); }
                        catch { }
                    else
                        ctrl.DataRelationNew = MKH.Library.Clasess.PublicClass.ToDataTable<Model.VisitHealthCare.SP_VisitHealthCareReportResult>(new ViewModel.VisitHealthCare.VisitHealthCare().GetReport(DatePickerHealthCareDateAz.Value.ToString().Substring(0, 10), DatePickerHealthCareDateTa.Value.ToString().Substring(0, 10), checkBoxVisitHealthCareSeparateDate.Checked, ref str));


                    ctrl.NameForDB = "تعدادی بهیاری";
                    ctrl.ShowDialog();
                }
                catch (Exception ex)
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "اشکال اطلاعات", ex.Message);
                }
            }

            else if (RadioButtonFunctionalityVisitHealthCareDetail.Checked && TabControlHealthCareRep.SelectedTabIndex == 1)
            {
                MKH.Library.Forms.MSSReportDesignList_frm ctrl = new MKH.Library.Forms.MSSReportDesignList_frm(RadioButtonFunctionalityVisitHealthCareDetail.Name + this.Name);
                try
                {
                    if (CheckBoxDoctor.Checked)
                        ctrl.DataRelationNew = MKH.Library.Clasess.PublicClass.ToDataTable<Model.VisitHealthCare.SP_VisitHealthCareReportForDetailResult>(new ViewModel.VisitHealthCare.VisitHealthCare().GetReportForDetail(DatePickerHealthCareDateAz.Value.ToString().Substring(0, 10), DatePickerHealthCareDateTa.Value.ToString().Substring(0, 10), ref str).Where(u => u.کد_بهیار == ListViewDoctorName.Items[0].Tag.ToString().ToInt()).ToList());
                    else
                        ctrl.DataRelationNew = MKH.Library.Clasess.PublicClass.ToDataTable<Model.VisitHealthCare.SP_VisitHealthCareReportForDetailResult>(new ViewModel.VisitHealthCare.VisitHealthCare().GetReportForDetail(DatePickerHealthCareDateAz.Value.ToString().Substring(0, 10), DatePickerHealthCareDateTa.Value.ToString().Substring(0, 10), ref str));

                    ctrl.NameForDB = "لیست جزییات بهیاری";

                    ctrl.DataRelationNewSlave = MKH.Library.Clasess.PublicClass.ToDataTable<Model.VisitHealthCare.SP_ServiceHealthCareReportForDetailResult>(new ViewModel.VisitHealthCare.ServiceHealthCare().GetReportForDetail(DatePickerHealthCareDateAz.Value.ToString().Substring(0, 10), DatePickerHealthCareDateTa.Value.ToString().Substring(0, 10), ref str));
                    ctrl.NameForDBSlave = "لیست جزییات خدمات";

                    ctrl.ShowDialog();
                }
                catch (Exception ex)
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "اشکال اطلاعات", ex.Message);
                }
            }
            else if (RadioButtonFunctionalityVisitHealthCareDoctorPatientOptional.Checked && TabControlHealthCareRep.SelectedTabIndex == 1)
            {
                MKH.Library.Forms.MSSReportDesignList_frm ctrl = new MKH.Library.Forms.MSSReportDesignList_frm(RadioButtonFunctionalityVisitHealthCareDoctorPatientOptional.Name + this.Name);
                try
                {
                    if (CheckBoxDoctor.Checked)
                        ctrl.DataRelationNew = MKH.Library.Clasess.PublicClass.ToDataTable<Model.VisitHealthCare.SP_VisitHealthCareReportForDetailSumResult>(new ViewModel.VisitHealthCare.VisitHealthCare().GetReportForDetailSum(DatePickerHealthCareDateAz.Value.ToString().Substring(0, 10), DatePickerHealthCareDateTa.Value.ToString().Substring(0, 10), ref str).Where(u => u.کد_بهیار == ListViewDoctorName.Items[0].Tag.ToString().ToInt()).ToList());
                    else
                        ctrl.DataRelationNew = MKH.Library.Clasess.PublicClass.ToDataTable<Model.VisitHealthCare.SP_VisitHealthCareReportForDetailSumResult>(new ViewModel.VisitHealthCare.VisitHealthCare().GetReportForDetailSum(DatePickerHealthCareDateAz.Value.ToString().Substring(0, 10), DatePickerHealthCareDateTa.Value.ToString().Substring(0, 10), ref str));

                    ctrl.NameForDB = "لیست کلی بهیاری";

                    ctrl.DataRelationNewSlave = MKH.Library.Clasess.PublicClass.ToDataTable<Model.VisitHealthCare.SP_ServiceHealthCareReportForDetailSumResult>(new ViewModel.VisitHealthCare.ServiceHealthCare().GetReportForDetailSum(DatePickerHealthCareDateAz.Value.ToString().Substring(0, 10), DatePickerHealthCareDateTa.Value.ToString().Substring(0, 10), ref str));
                    ctrl.NameForDBSlave = "لیست کلی خدمات";

                    ctrl.ShowDialog();
                }
                catch (Exception ex)
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "اشکال اطلاعات", ex.Message);
                }
            }

        }
          

        #endregion


        
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
                //textBoxDoctorName.Tag = SD1.Keys.ToList()[0];
                //textBoxDoctorName.Text = SD1.Values.ToList()[0];
                ListViewDoctorName.Items.Add(SD1.Keys.ToList()[0], SD1.Values.ToList()[0], 0);
                ListViewDoctorName.Items[SD1.Keys.ToList()[0]].Tag = SD1.Keys.ToList()[0];

            }
            catch { }
        
        }

        private void ButtonDel_Click(object sender, EventArgs e)
        {
            int gh = ListViewDoctorName.SelectedItems.Count;
            for (int i = 0; i < gh; i++)
                ListViewDoctorName.SelectedItems[0].Remove();
        }

        private void ComboBoxDateGroup_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                (sender as MKH.Library.Control.MSSComboBox).SelectedIndex = -1;
        }

    }
}
