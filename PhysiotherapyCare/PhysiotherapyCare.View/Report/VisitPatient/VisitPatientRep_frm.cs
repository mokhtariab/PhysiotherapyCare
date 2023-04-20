using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace PhysiotherapyCare.Report.VisitPatient
{
    public partial class VisitPatientRep_frm : MKH.Library.Forms.MSSBaseNew_frm
    {
        public VisitPatientRep_frm()
        {
            InitializeComponent();
        }

        private void VisitPatientRep_frm_Load(object sender, EventArgs e)
        {
            DatePickerVisitCreateDateAz.Value = KagNetComponents2.KagPersianDate.Parse(DateTime.Now);
            DatePickerVisitCreateDateAzFew.Value = DatePickerVisitCreateDateTaFew.Value = DatePickerVisitCreateDateTa.Value = DatePickerAnalyzeDateAz.Value = DatePickerAnalyzeDateTa.Value = DatePickerInsuLetterDateAZ.Value = DatePickerInsuLetterDateTa.Value = DatePickerSecretiatDateAz.Value = DatePickerSecretiatDateTa.Value = DatePickerVisitCreateDateAz.Value;

            tabItemMalli.Visible = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(310);
            tabItemFew.Visible = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(311);
        }


        #region Preview Chart

        private void buttonItemOK_Click(object sender, EventArgs e)
        {
            string str = "", WhereStr = "", FieldGroup = "", FieldDateGroup = "";




            if (RadioButtonFunctionalityDoctorPrice.Checked && TabControlVisitPatient.SelectedTabIndex == 0)
            {

                if (!CheckBoxVisitCreateDate.Checked && !CheckBoxSecretiatDate.Checked && !CheckBoxInsuLetterDate.Checked && !CheckBoxAnalyzeDate.Checked)
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View("لطفا فیلد تاریخ را مشخص نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SWarning);
                    return;
                }

                if (ComboBoxGroupBy.SelectedIndex == -1 && ComboBoxDateGroup.SelectedIndex == -1)
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View("لطفا یکی از ستون های تفکیک را مشخص نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SWarning);
                    return;
                }


                if (CheckBoxVisitCreateDate.Checked)
                    WhereStr = " VisitDate >= '" + DatePickerVisitCreateDateAz.Value.ToString().Substring(0, 10) + "' and VisitDate <= '" + DatePickerVisitCreateDateTa.Value.ToString().Substring(0, 10) + "' and ";
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
                        MKH.Library.Clasess.MSSMessage.MSSMessage_View("لطفا نام پزشک را مشخص نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SWarning);
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
                        FieldGroup = "Patient_Id";
                    else if (ComboBoxGroupBy.SelectedIndex == 2)
                        FieldGroup = "InsuLetterNo";
                    else if (ComboBoxGroupBy.SelectedIndex == 3)
                        FieldGroup = "SecretiatNo";
                    else if (ComboBoxGroupBy.SelectedIndex == 4)
                        FieldGroup = "AnalyzeNo";
                    else if (ComboBoxGroupBy.SelectedIndex == 5)
                        FieldGroup = "AccountingDocumentNumber";
                    else if (ComboBoxGroupBy.SelectedIndex == 6)
                        FieldGroup = "AddressPart";
                    else if (ComboBoxGroupBy.SelectedIndex == 7)
                        FieldGroup = "BonyadDosier";
                    else if (ComboBoxGroupBy.SelectedIndex == 8)
                        FieldGroup = "ReportCode";
                    else if (ComboBoxGroupBy.SelectedIndex == 9)
                        FieldGroup = "InstitutePart";
                    else if (ComboBoxGroupBy.SelectedIndex == 10)
                        FieldGroup = "BonyadConfirmNo";
                    else if (ComboBoxGroupBy.SelectedIndex == 11)
                        FieldGroup = "AnalyzePage";
                    else if (ComboBoxGroupBy.SelectedIndex == 12)
                        FieldGroup = "BursaryNumber";
                }
                
                if (ComboBoxGroupBy1.SelectedIndex != -1)
                {
                    if (ComboBoxGroupBy.SelectedIndex != -1) FieldGroup += ',';
                    if (ComboBoxGroupBy1.SelectedIndex == 0)
                        FieldGroup += "Doctor_Id";
                    else if (ComboBoxGroupBy1.SelectedIndex == 1)
                        FieldGroup += "Patient_Id";
                    else if (ComboBoxGroupBy1.SelectedIndex == 2)
                        FieldGroup += "InsuLetterNo";
                    else if (ComboBoxGroupBy1.SelectedIndex == 3)
                        FieldGroup += "SecretiatNo";
                    else if (ComboBoxGroupBy1.SelectedIndex == 4)
                        FieldGroup += "AnalyzeNo";
                    else if (ComboBoxGroupBy1.SelectedIndex == 5)
                        FieldGroup += "AccountingDocumentNumber";
                    else if (ComboBoxGroupBy1.SelectedIndex == 6)
                        FieldGroup += "AddressPart";
                    else if (ComboBoxGroupBy1.SelectedIndex == 7)
                        FieldGroup += "BonyadDosier";
                    else if (ComboBoxGroupBy1.SelectedIndex == 8)
                        FieldGroup += "ReportCode";
                    else if (ComboBoxGroupBy1.SelectedIndex == 9)
                        FieldGroup += "InstitutePart";
                    else if (ComboBoxGroupBy1.SelectedIndex == 10)
                        FieldGroup += "BonyadConfirmNo";
                    else if (ComboBoxGroupBy1.SelectedIndex == 11)
                        FieldGroup += "AnalyzePage";
                    else if (ComboBoxGroupBy1.SelectedIndex == 12)
                        FieldGroup += "BursaryNumber";
                }

                if (ComboBoxDateGroup.SelectedIndex != -1)
                {
                    if (ComboBoxDateGroup.SelectedIndex == 0)
                        FieldDateGroup = "VisitDate";
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
                
                MKH.Library.Forms.MSSReportDesignList_frm ctrl = new MKH.Library.Forms.MSSReportDesignList_frm(RadioButtonFunctionalityDoctorPrice.Name + this.Name);
                try
                {
                    ctrl.DataRelationNew = MKH.Library.Clasess.PublicClass.ToDataTable<Model.VisitPatient.SP_VisitPatientPaymentReportResult>(new ViewModel.VisitPatient.VisitPatientPayment().GetReport(FieldGroup, FieldDateGroup, WhereStr, ref str).ToList());

                    
                    ctrl.NameForDB = "مالی ویزیت در منزل";
                    ctrl.ShowDialog();
                }
                catch (Exception ex)
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "اشکال اطلاعات", ex.Message);
                }
            }

            
            
            
            else if (RadioButtonFunctionalityDetail.Checked && TabControlVisitPatient.SelectedTabIndex == 0)
            {

                if (!CheckBoxVisitCreateDate.Checked && !CheckBoxSecretiatDate.Checked && !CheckBoxInsuLetterDate.Checked && !CheckBoxAnalyzeDate.Checked)
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View("لطفا فیلد تاریخ را مشخص نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SWarning);
                    return;
                }

                if (CheckBoxVisitCreateDate.Checked)
                    WhereStr = " VisitDate >= '" + DatePickerVisitCreateDateAz.Value.ToString().Substring(0, 10) + "' and VisitDate <= '" + DatePickerVisitCreateDateTa.Value.ToString().Substring(0, 10) + "' and ";
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
                        MKH.Library.Clasess.MSSMessage.MSSMessage_View("لطفا نام پزشک را مشخص نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SWarning);
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


                MKH.Library.Forms.MSSReportDesignList_frm ctrl = new MKH.Library.Forms.MSSReportDesignList_frm(RadioButtonFunctionalityDetail.Name + this.Name);
                try
                {
                    ctrl.DataRelationNew = MKH.Library.Clasess.PublicClass.ToDataTable<Model.VisitPatient.SP_VisitPatientPaymentReportWithDetailResult>(new ViewModel.VisitPatient.VisitPatientPayment().GetReportWithDetail(WhereStr, ref str).ToList());


                    ctrl.NameForDB = "مالی جزییات ویزیت در منزل";
                    ctrl.ShowDialog();
                }
                catch (Exception ex)
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "اشکال اطلاعات", ex.Message);
                }
            }






            if (RadioButtonReportForDetailSicknessAndOther.Checked && TabControlVisitPatient.SelectedTabIndex == 1)
            {

                //if (!CheckBoxVisitCreateDate.Checked)
                //{
                //    MKH.Library.Clasess.MSSMessage.MSSMessage_View("لطفا فیلد تاریخ را مشخص نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SWarning);
                //    return;
                //}

                //if (CheckBoxVisitCreateDate.Checked)
                WhereStr = " VisitDate >= '" + DatePickerVisitCreateDateAzFew.Value.ToString().Substring(0, 10) + "' and VisitDate <= '" + DatePickerVisitCreateDateTaFew.Value.ToString().Substring(0, 10) + "' and ";
                WhereStr += " 1=1 ";



                //if (CheckBoxDoctor.Checked)
                //{
                //    if (ListViewDoctorName.Items.Count == 0)
                //    {
                //        MKH.Library.Clasess.MSSMessage.MSSMessage_View("لطفا نام پزشک را مشخص نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SWarning);
                //        return;
                //    }

                //    WhereStr += " and (";
                //    for (int i = 0; i < ListViewDoctorName.Items.Count; i++)
                //        WhereStr += " Doctor_Id = " + ListViewDoctorName.Items[i].Tag.ToString() + " Or ";
                //    WhereStr += " 1<>1 )";
                //}

                //if (CheckBoxIf.Checked)
                //{
                //    if (ComboBoxFieldIf.SelectedIndex != -1)
                //        if (TextBoxIf.Text != "")
                //        {
                //            WhereStr += " and (";
                //            for (int i = 0; i < TextBoxIf.Lines.Count(); i++)
                //                if (TextBoxIf.Lines[i] != "")
                //                {
                //                    if (ComboBoxFieldIf.SelectedIndex == 0)
                //                        WhereStr += " InsuLetterNo = '" + TextBoxIf.Lines[i] + "' Or ";
                //                    else if (ComboBoxFieldIf.SelectedIndex == 1)
                //                        WhereStr += " SecretiatNo = '" + TextBoxIf.Lines[i] + "' Or ";
                //                    else if (ComboBoxFieldIf.SelectedIndex == 2)
                //                        WhereStr += " AnalyzeNo = '" + TextBoxIf.Lines[i] + "' Or ";
                //                    else if (ComboBoxFieldIf.SelectedIndex == 3)
                //                        WhereStr += " AccountingDocumentNumber = '" + TextBoxIf.Lines[i] + "'  Or ";

                //                }
                //            WhereStr += " 1<>1 )";
                //        }
                //}

              

                MKH.Library.Forms.MSSReportDesignList_frm ctrl = new MKH.Library.Forms.MSSReportDesignList_frm(RadioButtonReportForDetailSicknessAndOther.Name + this.Name);
                try
                {
                    ctrl.DataRelationNew = MKH.Library.Clasess.PublicClass.ToDataTable<Model.VisitPatient.SP_VisitPatientReportResult>(new ViewModel.VisitPatient.VisitPatient().GetReport(WhereStr, ref str).ToList());


                    ctrl.NameForDB = "تعدادی ویزیت در منزل";
                    ctrl.ShowDialog();
                }
                catch (Exception ex)
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "اشکال اطلاعات", ex.Message);
                }
            }





            if (RadioButtonChartForDetailSicknessAndOther.Checked && TabControlVisitPatient.SelectedTabIndex == 1)
            {
                short EnterPatientType = 0;
                WhereStr = " VisitDate >= '" + DatePickerVisitCreateDateAzFew.Value.ToString().Substring(0, 10) + "' and VisitDate <= '" + DatePickerVisitCreateDateTaFew.Value.ToString().Substring(0, 10) + "' and (";
                if (RadioButtonSicknessVisitPatient.Checked)
                {
                    EnterPatientType = 0;
                    foreach (ListViewItem item in ListViewSicknessVisitPatient.Items)
                    {
                        WhereStr += " SVP.SicknessDetail_Id = " + item.Tag.ToString() + " Or ";
                    }
                    WhereStr += " 1<>1) and ";
                }

                if (RadioButtonParaclinicVisitPatient.Checked)
                {
                    EnterPatientType = 1;
                    foreach (ListViewItem item in ListViewParaclinicVisitPatient.Items)
                    {
                        WhereStr += " SVP.Paraclinic_Id = " + item.Tag.ToString() + " Or ";
                    }
                    WhereStr += " 1<>1) and ";
                }

                if (RadioButtonDrugVisitPatient.Checked)
                {
                    EnterPatientType = 2;
                    foreach (ListViewItem item in ListViewDrugVisitPatient.Items)
                    {
                        WhereStr += " SVP.Drug_Id = " + item.Tag.ToString() + " Or ";
                    }
                    WhereStr += " 1<>1) and ";
                }

                if (RadioButtonVaccinationVisitPatient.Checked)
                {
                    EnterPatientType = 3;
                    foreach (ListViewItem item in ListViewVaccinationVisitPatient.Items)
                    {
                        WhereStr += " SVP.Vaccination_Id = " + item.Tag.ToString() + " Or ";
                    }
                    WhereStr += " 1<>1) and ";
                }

                if (RadioButtonEquipmentUseVisitPatient.Checked)
                {
                    EnterPatientType = 4;
                    foreach (ListViewItem item in ListViewEquipmentUseVisitPatient.Items)
                    {
                        WhereStr += " SVP.EquipmentUse_Id = " + item.Tag.ToString() + " Or ";
                    }
                    WhereStr += " 1<>1) and ";
                }

                if (RadioButtonBedsoreVisitPatient.Checked)
                {
                    EnterPatientType = 5;
                    foreach (ListViewItem item in ListViewBedsoreVisitPatient.Items)
                    {
                        WhereStr += " SVP.BedsorePosition = '" + item.Text.ToString() + "' Or ";
                    }
                    WhereStr += " 1<>1 ) and ";
                }

                WhereStr += " 1=1 ";



              


                MKH.Library.Forms.MSSReportDesignList_frm ctrl = new MKH.Library.Forms.MSSReportDesignList_frm(RadioButtonChartForDetailSicknessAndOther.Name + this.Name);
                try
                {
                    ctrl.DataRelationNew = MKH.Library.Clasess.PublicClass.ToDataTable<Model.VisitPatient.SP_VisitPatientChartResult>(new ViewModel.VisitPatient.VisitPatient().GetChart(EnterPatientType, WhereStr, ref str).ToList());


                    ctrl.NameForDB = "چارت ویزیت در منزل";
                    ctrl.ShowDialog();
                }
                catch (Exception ex)
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "اشکال اطلاعات", ex.Message);
                }
            }
        
        
        
        }

        

        #endregion


        private void ComboBoxGroupBy_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                (sender as MKH.Library.Control.MSSComboBox).SelectedIndex = -1;
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



        private void ButtonSicknessVisitPatient_Click(object sender, EventArgs e)
        {
            try
            {
                string StrSet = "";
                Dictionary<string, string> SD = new Dictionary<string, string>();
                Dictionary<string, string> SD1 = new Dictionary<string, string>();

                foreach (var item in new ViewModel.VisitPatient.SicknessDetail().GetAllList(ref StrSet))
                    SD.Add(item.Id.ToString(), item.SicknessName + "-" + item.SicknessDetailName);

                SD1 = MKH.Library.Forms.MSSSelector_frm.SetDataSelect(SD);
                ListViewSicknessVisitPatient.Items.Add(SD1.Keys.ToList()[0], SD1.Values.ToList()[0], 0);
                ListViewSicknessVisitPatient.Items[SD1.Keys.ToList()[0]].Tag = SD1.Keys.ToList()[0];
            }
            catch { }
        }

        private void ButtonDelSicknessVisitPatient_Click(object sender, EventArgs e)
        {
            int gh = ListViewSicknessVisitPatient.SelectedItems.Count;
            for (int i = 0; i < gh; i++)
                ListViewSicknessVisitPatient.SelectedItems[0].Remove();
        }

        private void ButtonParaclinicVisitPatient_Click(object sender, EventArgs e)
        {
            try
            {
                string StrSet = "";
                Dictionary<string, string> SD = new Dictionary<string, string>();
                Dictionary<string, string> SD1 = new Dictionary<string, string>();

                foreach (var item in new ViewModel.VisitPatient.Paraclinic().GetAllList(ref StrSet))
                    SD.Add(item.Id.ToString(), item.TitleName);

                SD1 = MKH.Library.Forms.MSSSelector_frm.SetDataSelect(SD);
                ListViewParaclinicVisitPatient.Items.Add(SD1.Keys.ToList()[0], SD1.Values.ToList()[0], 0);
                ListViewParaclinicVisitPatient.Items[SD1.Keys.ToList()[0]].Tag = SD1.Keys.ToList()[0];
            }
            catch { }
        }

        private void ButtonDelParaclinicVisitPatient_Click(object sender, EventArgs e)
        {
            int gh = ListViewParaclinicVisitPatient.SelectedItems.Count;
            for (int i = 0; i < gh; i++)
                ListViewParaclinicVisitPatient.SelectedItems[0].Remove();
        }

        private void ButtonDrugVisitPatient_Click(object sender, EventArgs e)
        {
            try
            {
                string StrSet = "";
                Dictionary<string, string> SD = new Dictionary<string, string>();
                Dictionary<string, string> SD1 = new Dictionary<string, string>();

                foreach (var item in new ViewModel.VisitPatient.Drug().GetAllList(ref StrSet))
                    SD.Add(item.Id.ToString(), item.TitleName);

                SD1 = MKH.Library.Forms.MSSSelector_frm.SetDataSelect(SD);
                ListViewDrugVisitPatient.Items.Add(SD1.Keys.ToList()[0], SD1.Values.ToList()[0], 0);
                ListViewDrugVisitPatient.Items[SD1.Keys.ToList()[0]].Tag = SD1.Keys.ToList()[0];
            }
            catch { }
        }

        private void ButtonDelDrugVisitPatient_Click(object sender, EventArgs e)
        {
            int gh = ListViewDrugVisitPatient.SelectedItems.Count;
            for (int i = 0; i < gh; i++)
                ListViewDrugVisitPatient.SelectedItems[0].Remove();
        }

        private void ButtonVaccinationVisitPatient_Click(object sender, EventArgs e)
        {
            try
            {
                string StrSet = "";
                Dictionary<string, string> SD = new Dictionary<string, string>();
                Dictionary<string, string> SD1 = new Dictionary<string, string>();

                foreach (var item in new ViewModel.VisitPatient.Vaccination().GetAllList(ref StrSet))
                    SD.Add(item.Id.ToString(), item.TitleName);

                SD1 = MKH.Library.Forms.MSSSelector_frm.SetDataSelect(SD);
                ListViewVaccinationVisitPatient.Items.Add(SD1.Keys.ToList()[0], SD1.Values.ToList()[0], 0);
                ListViewVaccinationVisitPatient.Items[SD1.Keys.ToList()[0]].Tag = SD1.Keys.ToList()[0];
            }
            catch { }
        }

        private void ButtonDelVaccinationVisitPatient_Click(object sender, EventArgs e)
        {
            int gh = ListViewVaccinationVisitPatient.SelectedItems.Count;
            for (int i = 0; i < gh; i++)
                ListViewVaccinationVisitPatient.SelectedItems[0].Remove();
        }

        private void buttonEquipmentUseVisitPatient_Click(object sender, EventArgs e)
        {
            try
            {
                string StrSet = "";
                Dictionary<string, string> SD = new Dictionary<string, string>();
                Dictionary<string, string> SD1 = new Dictionary<string, string>();

                foreach (var item in new ViewModel.VisitPatient.EquipmentUse().GetAllList(ref StrSet))
                    SD.Add(item.Id.ToString(), item.TitleName);

                SD1 = MKH.Library.Forms.MSSSelector_frm.SetDataSelect(SD);
                ListViewEquipmentUseVisitPatient.Items.Add(SD1.Keys.ToList()[0], SD1.Values.ToList()[0], 0);
                ListViewEquipmentUseVisitPatient.Items[SD1.Keys.ToList()[0]].Tag = SD1.Keys.ToList()[0];
            }
            catch { }
        }

        private void buttonDelEquipmentUseVisitPatient_Click(object sender, EventArgs e)
        {
            int gh = ListViewEquipmentUseVisitPatient.SelectedItems.Count;
            for (int i = 0; i < gh; i++)
                ListViewEquipmentUseVisitPatient.SelectedItems[0].Remove();
        }

        private void ButtonBedsoreVisitPatient_Click(object sender, EventArgs e)
        {
            try
            {
                string StrSet = "";
                Dictionary<string, string> SD = new Dictionary<string, string>();
                Dictionary<string, string> SD1 = new Dictionary<string, string>();

                foreach (var item in new ViewModel.VisitPatient.BedsoreVisitPatient().GetAllList(ref StrSet))
                    SD.Add(item.Id.ToString(), item.BedsorePosition);

                SD1 = MKH.Library.Forms.MSSSelector_frm.SetDataSelect(SD);
                ListViewBedsoreVisitPatient.Items.Add(SD1.Keys.ToList()[0], SD1.Values.ToList()[0], 0);
                ListViewBedsoreVisitPatient.Items[SD1.Keys.ToList()[0]].Tag = SD1.Keys.ToList()[0];
            }
            catch { }
        }

        private void ButtonDelBedsoreVisitPatient_Click(object sender, EventArgs e)
        {
            int gh = ListViewBedsoreVisitPatient.SelectedItems.Count;
            for (int i = 0; i < gh; i++)
                ListViewBedsoreVisitPatient.SelectedItems[0].Remove();
        }

    }
}
