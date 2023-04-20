using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace PhysiotherapyCare.Report.VisitPatientCare
{
    public partial class VisitPatientCareRep_frm : MKH.Library.Forms.MSSBaseNew_frm
    {
        public VisitPatientCareRep_frm()
        {
            InitializeComponent();
        }

        private void VisitPatientCareRep_frm_Load(object sender, EventArgs e)
        {
            DatePickerBeginDateAz.Value = KagNetComponents2.KagPersianDate.Parse(DateTime.Now);
            DatePickerBeginDateTa.Value = DatePickerAnalyzeDateAz.Value = DatePickerAnalyzeDateTa.Value = DatePickerInsuLetterDateAZ.Value = DatePickerInsuLetterDateTa.Value = DatePickerSecretiatDateAz.Value = DatePickerSecretiatDateTa.Value =
                DatePickerAccountingDocumentDateAz.Value = DatePickerAccountingDocumentDateTa.Value = DatePickerBursaryDateAz.Value = DatePickerBursaryDateTa.Value = DatePickerBeginDateAz.Value;
        }




        #region Preview Chart

        private void buttonItemOK_Click(object sender, EventArgs e)
        {
            string str = "", WhereStr = "", FieldGroup = "", FieldDateGroup = "";

            


            if (RadioButtonFunctionalityDoctorPrice.Checked)
            {
                if (!CheckBoxBeginDate.Checked && !CheckBoxSecretiatDate.Checked && !CheckBoxInsuLetterDate.Checked && !CheckBoxAnalyzeDate.Checked)
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View("لطفا فیلد تاریخ را مشخص نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SWarning);
                    return;
                }

                if (ComboBoxGroupBy.SelectedIndex == -1 && ComboBoxDateGroup.SelectedIndex == -1)
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View("لطفا یکی از ستون های تفکیک را مشخص نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SWarning);
                    return;
                }

                if (CheckBoxBeginDate.Checked)
                    WhereStr = " BeginDate >= '" + DatePickerBeginDateAz.Value.ToString().Substring(0, 10) + "' and BeginDate <= '" + DatePickerBeginDateTa.Value.ToString().Substring(0, 10) + "' and ";
                if (CheckBoxInsuLetterDate.Checked)
                    WhereStr += " InsuLetterDate >= '" + DatePickerInsuLetterDateAZ.Value.ToString().Substring(0, 10) + "' and InsuLetterDate <= '" + DatePickerInsuLetterDateTa.Value.ToString().Substring(0, 10) + "' and ";
                if (CheckBoxSecretiatDate.Checked)
                    WhereStr += " SecretiatDate >= '" + DatePickerSecretiatDateAz.Value.ToString().Substring(0, 10) + "' and SecretiatDate <= '" + DatePickerSecretiatDateTa.Value.ToString().Substring(0, 10) + "' and ";
                if (CheckBoxAnalyzeDate.Checked)
                    WhereStr += " isnull(AnalyzeDate,'') >= '" + DatePickerAnalyzeDateAz.Value.ToString().Substring(0, 10) + "' and isnull(AnalyzeDate,'') <= '" + DatePickerAnalyzeDateTa.Value.ToString().Substring(0, 10) + "' and ";
                if (CheckBoxAccountingDocumentDate.Checked)
                    WhereStr += " AccountingDocumentDate >= '" + DatePickerAccountingDocumentDateAz.Value.ToString().Substring(0, 10) + "' and AccountingDocumentDate <= '" + DatePickerAccountingDocumentDateTa.Value.ToString().Substring(0, 10) + "' and ";
                if (CheckBoxBursaryDate.Checked)
                    WhereStr += " BursaryDate >= '" + DatePickerBursaryDateAz.Value.ToString().Substring(0, 10) + "' and BursaryDate <= '" + DatePickerBursaryDateTa.Value.ToString().Substring(0, 10) + "' and ";
                WhereStr += " 1=1 ";



                if (CheckBoxPatient.Checked)
                {
                    if (ListViewPatientName.Items.Count == 0)
                    {
                        MKH.Library.Clasess.MSSMessage.MSSMessage_View("لطفا نام بیمار را مشخص نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SWarning);
                        return;
                    }

                    WhereStr += " and (";
                    for (int i = 0; i < ListViewPatientName.Items.Count; i++)
                        WhereStr += " Patient_Id = " + ListViewPatientName.Items[i].Tag.ToString() + " Or ";
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
                                        WhereStr += " CasherNationalCode = '" + TextBoxIf.Lines[i] + "'  Or ";
                                    else if (ComboBoxFieldIf.SelectedIndex == 5)
                                        WhereStr += " BursaryNumber = '" + TextBoxIf.Lines[i] + "'  Or ";
                                    else if (ComboBoxFieldIf.SelectedIndex == 6)
                                        WhereStr += " InstitutePart = '" + TextBoxIf.Lines[i] + "'  Or ";

                                }
                            WhereStr += " 1<>1 )";
                        }
                }

                if (ComboBoxGroupBy.SelectedIndex != -1)
                {
                    if (ComboBoxGroupBy.SelectedIndex == 0)
                        FieldGroup = "Patient_Id";
                    else if (ComboBoxGroupBy.SelectedIndex == 1)
                        FieldGroup = "CasherNationalCode";
                    else if (ComboBoxGroupBy.SelectedIndex == 2)
                        FieldGroup = "InsuLetterNo";
                    else if (ComboBoxGroupBy.SelectedIndex == 3)
                        FieldGroup = "SecretiatNo";
                    else if (ComboBoxGroupBy.SelectedIndex == 4)
                        FieldGroup = "AnalyzeNo";
                    else if (ComboBoxGroupBy.SelectedIndex == 5)
                        FieldGroup = "AccountingDocumentNumber";
                    else if (ComboBoxGroupBy.SelectedIndex == 6)
                        FieldGroup = "InstitutePart";
                    else if (ComboBoxGroupBy.SelectedIndex == 7)
                        FieldGroup = "ReportCode";
                    else if (ComboBoxGroupBy.SelectedIndex == 8)
                        FieldGroup = "BonyadConfirmNo";
                    else if (ComboBoxGroupBy.SelectedIndex == 9)
                        FieldGroup = "AnalyzePage";
                    else if (ComboBoxGroupBy.SelectedIndex == 10)
                        FieldGroup = "BursaryNumber";
                    else if (ComboBoxGroupBy.SelectedIndex == 11)
                        FieldGroup = "CityPart";
                }
                 if (ComboBoxGroupBy1.SelectedIndex != -1)
                {
                    if (ComboBoxGroupBy.SelectedIndex != -1) FieldGroup += ',';
                    if (ComboBoxGroupBy1.SelectedIndex == 0)
                        FieldGroup += "Patient_Id";
                    else if (ComboBoxGroupBy1.SelectedIndex == 1)
                        FieldGroup += "CasherNationalCode";
                    else if (ComboBoxGroupBy1.SelectedIndex == 2)
                        FieldGroup += "InsuLetterNo";
                    else if (ComboBoxGroupBy1.SelectedIndex == 3)
                        FieldGroup += "SecretiatNo";
                    else if (ComboBoxGroupBy1.SelectedIndex == 4)
                        FieldGroup += "AnalyzeNo";
                    else if (ComboBoxGroupBy1.SelectedIndex == 5)
                        FieldGroup += "AccountingDocumentNumber";
                    else if (ComboBoxGroupBy1.SelectedIndex == 6)
                        FieldGroup += "InstitutePart";
                    else if (ComboBoxGroupBy1.SelectedIndex == 7)
                        FieldGroup += "ReportCode";
                    else if (ComboBoxGroupBy1.SelectedIndex == 8)
                        FieldGroup += "BonyadConfirmNo";
                    else if (ComboBoxGroupBy1.SelectedIndex == 9)
                        FieldGroup += "AnalyzePage";
                    else if (ComboBoxGroupBy1.SelectedIndex == 10)
                        FieldGroup += "BursaryNumber";
                    else if (ComboBoxGroupBy1.SelectedIndex == 11)
                        FieldGroup += "CityPart";
                }


                if (ComboBoxDateGroup.SelectedIndex != -1)
                {
                    if (ComboBoxDateGroup.SelectedIndex == 0)
                        FieldDateGroup = "BeginDate";
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
                    ctrl.DataRelationNew = MKH.Library.Clasess.PublicClass.ToDataTable<Model.VisitPatientCare.SP_VisitPatientCarePaymentReportResult>(new ViewModel.VisitPatientCare.VisitPatientCarePayment().GetReport(FieldGroup, FieldDateGroup, WhereStr, ref str));

                    //if (CheckBoxPatient.Checked)
                    //    try { ctrl.DataRelationNew = MKH.Library.Clasess.PublicClass.ToDataTable<Model.VisitPatientCare.SP_VisitPatientCarePaymentReportResult>(new ViewModel.VisitPatientCare.VisitPatientCarePayment().GetReport(DatePickerAz.Value.ToString().Substring(0, 10), DatePickerTa.Value.ToString().Substring(0, 10), checkBoxSeparateDate.Checked, ref str).Where(g => g.کد_بیمار == textBoxPatientName.Tag.ToString().ToInt()).ToList()); }
                    //    catch { }
                    //else
                    //    ctrl.DataRelationNew = MKH.Library.Clasess.PublicClass.ToDataTable<Model.VisitPatientCare.SP_VisitPatientCarePaymentReportResult>(new ViewModel.VisitPatientCare.VisitPatientCarePayment().GetReport(DatePickerAz.Value.ToString().Substring(0, 10), DatePickerTa.Value.ToString().Substring(0, 10), checkBoxSeparateDate.Checked, ref str));


                    //try { ctrl.DataRelationNew.Columns["PatientName"].ColumnName = "نام بیمار"; } catch { }
                    //try { ctrl.DataRelationNew.Columns["PatientFamily"].ColumnName = "نام خانوادگی بیمار"; } catch { }
                    //try { ctrl.DataRelationNew.Columns["NationalCode"].ColumnName = "کدملی بیمار"; } catch { }
                    //try { ctrl.DataRelationNew.Columns["ParentName"].ColumnName = "نام پدر"; } catch { }
                    //try { ctrl.DataRelationNew.Columns["TelBusiness"].ColumnName = "تلفن محل کار"; } catch { }
                    //try { ctrl.DataRelationNew.Columns["Mobile"].ColumnName = "موبایل"; } catch { }
                    //try { ctrl.DataRelationNew.Columns["TelHome"].ColumnName = "تلفن منزل"; } catch { }
                    //try { ctrl.DataRelationNew.Columns["CardBankNo1"].ColumnName = "شماره حساب بیمار"; } catch { }
                    //try { ctrl.DataRelationNew.Columns["CardBankNo2"].ColumnName = "شماره کارت بیمار"; } catch { }
                    //try { ctrl.DataRelationNew.Columns["BankName"].ColumnName = "نام بانک"; } catch { }
                    //try { ctrl.DataRelationNew.Columns["MonthSet"].ColumnName = "ماه مربوطه"; } catch { }
                    //try { ctrl.DataRelationNew.Columns["CountAll"].ColumnName = "تعداد کل"; } catch { }
                    //try { ctrl.DataRelationNew.Columns["CountAdd"].ColumnName = "تعداد فرد"; } catch { }
                    //try { ctrl.DataRelationNew.Columns["CountEven"].ColumnName = "تعداد زوج"; } catch { }
                    //try { ctrl.DataRelationNew.Columns["SumReqInsuAdd"].ColumnName = "مبلغ درخواستی از بیمه فرد"; } catch { }
                    //try { ctrl.DataRelationNew.Columns["SumReqInsuEven"].ColumnName = "مبلغ درخواستی از بیمه زوج"; } catch { }
                    //try { ctrl.DataRelationNew.Columns["SUMCostCachInsuIran"].ColumnName = "مبلغ دریافتی از بیمه"; } catch { }
                    //try { ctrl.DataRelationNew.Columns["SUMVisitCoAdd"].ColumnName = "مبلغ سهم سازمان فرد"; } catch { }
                    //try { ctrl.DataRelationNew.Columns["SUMVisitCoEven"].ColumnName = "مبلغ سهم سازمان زوج"; } catch { }
                    //try { ctrl.DataRelationNew.Columns["sumCostVisitCo"].ColumnName = "مبلغ سهم سازمان"; } catch { }
                    //try { ctrl.DataRelationNew.Columns["SumCostVisitDoctor"].ColumnName = "بدهی"; } catch { }
                    //try { ctrl.DataRelationNew.Columns["SumCostVisitDoctorBes"].ColumnName = "پرداختی"; } catch { }
                    //try { ctrl.DataRelationNew.Columns["RemindCost"].ColumnName = "مانده"; } catch { }

                    //try { ctrl.DataRelationNew.Columns.Remove("CountAll1"); }
                    //catch { }
                    //try { ctrl.DataRelationNew.Columns.Remove("Patient_Id"); }
                    //catch { }

                    ctrl.NameForDB = "مالی بیماران";
                    ctrl.ShowDialog();
                }
                catch (Exception ex)
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "اشکال اطلاعات", ex.Message);
                }
            }
            else if (RadioButtonFunctionalityVisitPatientCare.Checked)
            {
                try
                {
                    MKH.Library.Forms.MSSReportDesignList_frm ctrl = new MKH.Library.Forms.MSSReportDesignList_frm(RadioButtonFunctionalityVisitPatientCare.Name + this.Name);
                    if (CheckBoxPatient.Checked)
                        try { ctrl.DataRelationNew = MKH.Library.Clasess.PublicClass.ToDataTable<Model.VisitPatientCare.SP_VisitPatientCareReportResult>((new ViewModel.VisitPatientCare.VisitPatientCare().GetReport(DatePickerBeginDateAz.Value.ToString().Substring(0, 10), DatePickerBeginDateTa.Value.ToString().Substring(0, 10), checkBoxSeparateDate.Checked, ref str).Where(g => g.کد_بیمار == ListViewPatientName.Items[0].Tag.ToString().ToInt())).ToList()); }
                        catch { }
                    else
                        ctrl.DataRelationNew = MKH.Library.Clasess.PublicClass.ToDataTable<Model.VisitPatientCare.SP_VisitPatientCareReportResult>(new ViewModel.VisitPatientCare.VisitPatientCare().GetReport(DatePickerBeginDateAz.Value.ToString().Substring(0, 10), DatePickerBeginDateTa.Value.ToString().Substring(0, 10), checkBoxSeparateDate.Checked, ref str));


                    //try { ctrl.DataRelationNew.Columns["PatientName"].ColumnName = "نام بیمار"; }
                    //catch { }
                    //try { ctrl.DataRelationNew.Columns["PatientFamily"].ColumnName = "نام خانوادگی بیمار"; }
                    //catch { }
                    //try { ctrl.DataRelationNew.Columns["NationalCode"].ColumnName = "کدملی بیمار"; }
                    //catch { }
                    //try { ctrl.DataRelationNew.Columns["ParentName"].ColumnName = "نام پدر"; }
                    //catch { }
                    //try { ctrl.DataRelationNew.Columns["TelBusiness"].ColumnName = "تلفن محل کار"; }
                    //catch { }
                    //try { ctrl.DataRelationNew.Columns["Mobile"].ColumnName = "موبایل"; }
                    //catch { }
                    //try { ctrl.DataRelationNew.Columns["TelHome"].ColumnName = "تلفن منزل"; }
                    //catch { }
                    //try { ctrl.DataRelationNew.Columns["CountAll"].ColumnName = "تعداد کل"; }
                    //catch { }
                    //try { ctrl.DataRelationNew.Columns["CountAdd"].ColumnName = "تعداد فرد"; }
                    //catch { }
                    //try { ctrl.DataRelationNew.Columns["CountEven"].ColumnName = "تعداد زوج"; }
                    //catch { }
                    //try { ctrl.DataRelationNew.Columns["CountVisitStatusNoOdati"].ColumnName = "تعداد بدون عودتی"; }
                    //catch { }
                    //try { ctrl.DataRelationNew.Columns["CountVisitStatusOdati"].ColumnName = "تعداد عودتی"; }
                    //catch { }

                    //try { ctrl.DataRelationNew.Columns.Remove("Patient_Id"); }
                    //catch { }

                    ctrl.NameForDB = "تعدادی بیماران";
                    ctrl.ShowDialog();
                }
                catch (Exception ex)
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "اشکال اطلاعات", ex.Message);
                }
            }



        }
          

        #endregion


        
        
        private void buttonPatient_Click(object sender, EventArgs e)
        {
            try
            {
                string StrSet = "";
                Dictionary<string, string> SD = new Dictionary<string, string>();
                Dictionary<string, string> SD1 = new Dictionary<string, string>();

                foreach (var item in new ViewModel.Patient.Patient().GetAllList(ref StrSet))
                    SD.Add(item.Id.ToString(), item.PatientName + " " + item.PatientFamily);

                SD1 = MKH.Library.Forms.MSSSelector_frm.SetDataSelect(SD);
                ListViewPatientName.Items.Add(SD1.Keys.ToList()[0], SD1.Values.ToList()[0], 0);
                ListViewPatientName.Items[SD1.Keys.ToList()[0]].Tag = SD1.Keys.ToList()[0];
            }
            catch { }
        }

        private void ButtonDel_Click(object sender, EventArgs e)
        {
            int gh = ListViewPatientName.SelectedItems.Count;
            for (int i = 0; i < gh; i++)
                ListViewPatientName.SelectedItems[0].Remove();
        }

        private void ComboBoxGroupBy_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                (sender as MKH.Library.Control.MSSComboBox).SelectedIndex = -1;
        }

    }
}
