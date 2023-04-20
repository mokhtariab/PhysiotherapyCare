using System.Windows.Forms;
using MKH.Library.Control;

namespace PhysiotherapyCare.View.MainForms.VisitPatientCare
{
    partial class VisitPatientCarePayment_UC
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisitPatientCarePayment_UC));
            Janus.Windows.GridEX.GridEXLayout GridViewVisitPatientCarePayment_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.GridViewVisitPatientCarePayment = new MKH.Library.Control.MSSGridexView();
            this.ContextMenuStripStatus = new MKH.Library.Control.MSSContextMenuStrip(this.components);
            this.ToolStripMenuItemVisitPatientCarePaymentLog = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemVisitPatientCarePaymentCurrentRow = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemVisitPatientCarePaymentAllList = new System.Windows.Forms.ToolStripMenuItem();
            this.vWVisitPatientCarePaymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mssPanel2 = new MKH.Library.Control.MSSPanel(this.components);
            this.RadioBoxAllContract = new MKH.Library.Control.MSSCheckBox(this.components);
            this.RadioBoxContractWithTime = new MKH.Library.Control.MSSCheckBox(this.components);
            this.DatePickerEnd = new MKH.Library.Control.MSSDatePicker(this.components);
            this.ComboBoxSerach = new MKH.Library.Control.MSSComboBox();
            this.comboItemPaymentDate = new DevComponents.Editors.ComboItem();
            this.comboItemLetterDate = new DevComponents.Editors.ComboItem();
            this.comboItemContractDate = new DevComponents.Editors.ComboItem();
            this.comboItemBeginDate = new DevComponents.Editors.ComboItem();
            this.comboItemEndDate = new DevComponents.Editors.ComboItem();
            this.comboItemInsuLetterDate = new DevComponents.Editors.ComboItem();
            this.comboItemSecretiatDate = new DevComponents.Editors.ComboItem();
            this.comboItemAnalyzeDate = new DevComponents.Editors.ComboItem();
            this.comboItemCostIncreaseDate = new DevComponents.Editors.ComboItem();
            this.comboItemPaymentDoctorDate = new DevComponents.Editors.ComboItem();
            this.comboItemBonyadConfirmDate = new DevComponents.Editors.ComboItem();
            this.comboItemAccountingDocumentDate = new DevComponents.Editors.ComboItem();
            this.comboItemBursaryDate = new DevComponents.Editors.ComboItem();
            this.DatePickerStart = new MKH.Library.Control.MSSDatePicker(this.components);
            this.mssLabel1 = new MKH.Library.Control.MSSLabel(this.components);
            this.mssLabel2 = new MKH.Library.Control.MSSLabel(this.components);
            this.mssLabel3 = new MKH.Library.Control.MSSLabel(this.components);
            this.mssPanel1 = new MKH.Library.Control.MSSPanel(this.components);
            this.comboBoxBank = new MKH.Library.Control.MSSComboBox();
            this.label6 = new MKH.Library.Control.MSSLabel(this.components);
            this.btnSetValueCare = new MKH.Library.Control.MSSButton(this.components);
            this.DatePickerSet = new MKH.Library.Control.MSSDatePicker(this.components);
            this.comboBoxSetValue = new MKH.Library.Control.MSSComboBox();
            this.comboItemPaymentStatus = new DevComponents.Editors.ComboItem();
            this.comboItemCostCachInsuIran = new DevComponents.Editors.ComboItem();
            this.comboItemAnalyzePage = new DevComponents.Editors.ComboItem();
            this.comboItemAnalyzeNo = new DevComponents.Editors.ComboItem();
            this.comboItemAccountingDocumentNumber = new DevComponents.Editors.ComboItem();
            this.comboItemBursaryNumber = new DevComponents.Editors.ComboItem();
            this.comboItemCostVisitCo = new DevComponents.Editors.ComboItem();
            this.comboItemCostVisitCoPercent = new DevComponents.Editors.ComboItem();
            this.comboItemCostIncrease = new DevComponents.Editors.ComboItem();
            this.comboItemCostIncreasePercent = new DevComponents.Editors.ComboItem();
            this.comboItemPaymentDoctor = new DevComponents.Editors.ComboItem();
            this.comboItemDescription = new DevComponents.Editors.ComboItem();
            this.comboItemCasherName = new DevComponents.Editors.ComboItem();
            this.comboItemCasherNationalCode = new DevComponents.Editors.ComboItem();
            this.comboItemBank_Id = new DevComponents.Editors.ComboItem();
            this.comboItemCardBankNo1 = new DevComponents.Editors.ComboItem();
            this.comboItemBonyadConfirmNo = new DevComponents.Editors.ComboItem();
            this.comboItemSecretiatNo = new DevComponents.Editors.ComboItem();
            this.comboItemCityPart = new DevComponents.Editors.ComboItem();
            this.comboItemShiftFew = new DevComponents.Editors.ComboItem();
            this.comboItemReportCode = new DevComponents.Editors.ComboItem();
            this.comboItemCostDoctorTax = new DevComponents.Editors.ComboItem();
            this.comboItemCostDoctorTaxPercent = new DevComponents.Editors.ComboItem();
            this.comboItemCostDoctorInsurance = new DevComponents.Editors.ComboItem();
            this.comboItemCostDoctorInsurancePercent = new DevComponents.Editors.ComboItem();
            this.mssLabel4 = new MKH.Library.Control.MSSLabel(this.components);
            this.comboBoxPaymentStatus = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.textBoxSetValue = new MKH.Library.Control.MSSTextBox(this.components);
            this.nUpDownSetValue = new MKH.Library.Control.MSSIntBox(this.components);
            this.HeaderGridVisitPatientCarePayment = new MKH.Library.Control.MSSHeaderGrid();
            this.buttonItemCarePaymentCalculateRimindAll = new DevComponents.DotNetBar.ButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewVisitPatientCarePayment)).BeginInit();
            this.ContextMenuStripStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vWVisitPatientCarePaymentBindingSource)).BeginInit();
            this.mssPanel2.SuspendLayout();
            this.mssPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridViewVisitPatientCarePayment
            // 
            this.GridViewVisitPatientCarePayment.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.GridViewVisitPatientCarePayment.AlternatingColors = true;
            this.GridViewVisitPatientCarePayment.AlternatingRowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewVisitPatientCarePayment.BuiltInTextsData = resources.GetString("GridViewVisitPatientCarePayment.BuiltInTextsData");
            this.GridViewVisitPatientCarePayment.CardViewGridlines = Janus.Windows.GridEX.CardViewGridlines.Both;
            this.GridViewVisitPatientCarePayment.ContextMenuStrip = this.ContextMenuStripStatus;
            this.GridViewVisitPatientCarePayment.DataSource = this.vWVisitPatientCarePaymentBindingSource;
            this.GridViewVisitPatientCarePayment.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            GridViewVisitPatientCarePayment_DesignTimeLayout.LayoutString = resources.GetString("GridViewVisitPatientCarePayment_DesignTimeLayout.LayoutString");
            this.GridViewVisitPatientCarePayment.DesignTimeLayout = GridViewVisitPatientCarePayment_DesignTimeLayout;
            this.GridViewVisitPatientCarePayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewVisitPatientCarePayment.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.GridViewVisitPatientCarePayment.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.GridViewVisitPatientCarePayment.Font = new System.Drawing.Font("Tahoma", 8.150944F);
            this.GridViewVisitPatientCarePayment.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewVisitPatientCarePayment.HideSelection = Janus.Windows.GridEX.HideSelection.Highlight;
            this.GridViewVisitPatientCarePayment.Location = new System.Drawing.Point(0, 56);
            this.GridViewVisitPatientCarePayment.Name = "GridViewVisitPatientCarePayment";
            this.GridViewVisitPatientCarePayment.RecordNavigator = true;
            this.GridViewVisitPatientCarePayment.RowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewVisitPatientCarePayment.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition;
            this.GridViewVisitPatientCarePayment.RowHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewVisitPatientCarePayment.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.GridViewVisitPatientCarePayment.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelection;
            this.GridViewVisitPatientCarePayment.SettingsKey = "GridViewVisitPatientCarePayment";
            this.GridViewVisitPatientCarePayment.Size = new System.Drawing.Size(907, 329);
            this.GridViewVisitPatientCarePayment.TabIndex = 34;
            this.GridViewVisitPatientCarePayment.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.GridViewVisitPatientCarePayment.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.GridViewVisitPatientCarePayment.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010;
            this.GridViewVisitPatientCarePayment.DoubleClick += new System.EventHandler(this.headerGridVisitPatientCarePayment_btnEditClick);
            // 
            // ContextMenuStripStatus
            // 
            this.ContextMenuStripStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemVisitPatientCarePaymentLog});
            this.ContextMenuStripStatus.Name = "ContextMenuStripStatus";
            this.ContextMenuStripStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ContextMenuStripStatus.Size = new System.Drawing.Size(95, 26);
            // 
            // ToolStripMenuItemVisitPatientCarePaymentLog
            // 
            this.ToolStripMenuItemVisitPatientCarePaymentLog.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemVisitPatientCarePaymentCurrentRow,
            this.ToolStripMenuItemVisitPatientCarePaymentAllList});
            this.ToolStripMenuItemVisitPatientCarePaymentLog.Name = "ToolStripMenuItemVisitPatientCarePaymentLog";
            this.ToolStripMenuItemVisitPatientCarePaymentLog.Size = new System.Drawing.Size(94, 22);
            this.ToolStripMenuItemVisitPatientCarePaymentLog.Text = "Log";
            // 
            // ToolStripMenuItemVisitPatientCarePaymentCurrentRow
            // 
            this.ToolStripMenuItemVisitPatientCarePaymentCurrentRow.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripMenuItemVisitPatientCarePaymentCurrentRow.Name = "ToolStripMenuItemVisitPatientCarePaymentCurrentRow";
            this.ToolStripMenuItemVisitPatientCarePaymentCurrentRow.Size = new System.Drawing.Size(140, 22);
            this.ToolStripMenuItemVisitPatientCarePaymentCurrentRow.Tag = "272";
            this.ToolStripMenuItemVisitPatientCarePaymentCurrentRow.Text = "سطر انتخابی";
            this.ToolStripMenuItemVisitPatientCarePaymentCurrentRow.Click += new System.EventHandler(this.ToolStripMenuItemVisitPatientCarePaymentCurrentRow_Click);
            // 
            // ToolStripMenuItemVisitPatientCarePaymentAllList
            // 
            this.ToolStripMenuItemVisitPatientCarePaymentAllList.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripMenuItemVisitPatientCarePaymentAllList.Name = "ToolStripMenuItemVisitPatientCarePaymentAllList";
            this.ToolStripMenuItemVisitPatientCarePaymentAllList.Size = new System.Drawing.Size(140, 22);
            this.ToolStripMenuItemVisitPatientCarePaymentAllList.Tag = "273";
            this.ToolStripMenuItemVisitPatientCarePaymentAllList.Text = "کل لیست";
            this.ToolStripMenuItemVisitPatientCarePaymentAllList.Click += new System.EventHandler(this.ToolStripMenuItemVisitPatientCarePaymentAllList_Click);
            // 
            // vWVisitPatientCarePaymentBindingSource
            // 
            this.vWVisitPatientCarePaymentBindingSource.DataSource = typeof(PhysiotherapyCare.Model.VisitPatientCare.VW_VisitPatientCarePayment);
            // 
            // mssPanel2
            // 
            this.mssPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.mssPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.mssPanel2.Controls.Add(this.RadioBoxAllContract);
            this.mssPanel2.Controls.Add(this.RadioBoxContractWithTime);
            this.mssPanel2.Controls.Add(this.DatePickerEnd);
            this.mssPanel2.Controls.Add(this.ComboBoxSerach);
            this.mssPanel2.Controls.Add(this.DatePickerStart);
            this.mssPanel2.Controls.Add(this.mssLabel1);
            this.mssPanel2.Controls.Add(this.mssLabel2);
            this.mssPanel2.Controls.Add(this.mssLabel3);
            this.mssPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mssPanel2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.mssPanel2.Location = new System.Drawing.Point(0, 423);
            this.mssPanel2.Name = "mssPanel2";
            this.mssPanel2.Size = new System.Drawing.Size(907, 44);
            this.mssPanel2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.mssPanel2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.mssPanel2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.mssPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.mssPanel2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.mssPanel2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.mssPanel2.Style.GradientAngle = 90;
            this.mssPanel2.TabIndex = 2;
            // 
            // RadioBoxAllContract
            // 
            this.RadioBoxAllContract.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RadioBoxAllContract.AutoSize = true;
            // 
            // 
            // 
            this.RadioBoxAllContract.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.RadioBoxAllContract.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.RadioBoxAllContract.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.RadioBoxAllContract.Location = new System.Drawing.Point(810, 12);
            this.RadioBoxAllContract.Name = "RadioBoxAllContract";
            this.RadioBoxAllContract.Size = new System.Drawing.Size(72, 17);
            this.RadioBoxAllContract.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.RadioBoxAllContract.TabIndex = 1;
            this.RadioBoxAllContract.TabStop = false;
            this.RadioBoxAllContract.Text = "کل لیست";
            this.RadioBoxAllContract.TextColor = System.Drawing.Color.Black;
            this.RadioBoxAllContract.CheckedChanged += new System.EventHandler(this.ComboBoxSerach_SelectedIndexChanged);
            // 
            // RadioBoxContractWithTime
            // 
            this.RadioBoxContractWithTime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RadioBoxContractWithTime.AutoSize = true;
            // 
            // 
            // 
            this.RadioBoxContractWithTime.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.RadioBoxContractWithTime.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.RadioBoxContractWithTime.Checked = true;
            this.RadioBoxContractWithTime.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RadioBoxContractWithTime.CheckValue = "Y";
            this.RadioBoxContractWithTime.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.RadioBoxContractWithTime.Location = new System.Drawing.Point(565, 12);
            this.RadioBoxContractWithTime.Name = "RadioBoxContractWithTime";
            this.RadioBoxContractWithTime.Size = new System.Drawing.Size(162, 17);
            this.RadioBoxContractWithTime.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.RadioBoxContractWithTime.TabIndex = 2;
            this.RadioBoxContractWithTime.Text = "پرداختی براساس بازه زمانی";
            this.RadioBoxContractWithTime.TextColor = System.Drawing.Color.Black;
            this.RadioBoxContractWithTime.CheckedChanged += new System.EventHandler(this.ComboBoxSerach_SelectedIndexChanged);
            // 
            // DatePickerEnd
            // 
            this.DatePickerEnd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DatePickerEnd.BackColor = System.Drawing.Color.White;
            this.DatePickerEnd.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.DatePickerEnd.Location = new System.Drawing.Point(37, 12);
            this.DatePickerEnd.Name = "DatePickerEnd";
            this.DatePickerEnd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DatePickerEnd.ShowTime = false;
            this.DatePickerEnd.Size = new System.Drawing.Size(103, 18);
            this.DatePickerEnd.TabIndex = 5;
            this.DatePickerEnd.Text = "mssDatePicker1";
            this.DatePickerEnd.UseFarsiDigits = true;
            this.DatePickerEnd.Value = ((KagNetComponents2.KagPersianDate)(resources.GetObject("DatePickerEnd.Value")));
            this.DatePickerEnd.ValueEn = new System.DateTime(2017, 3, 6, 18, 57, 29, 0);
            this.DatePickerEnd.ValueChanged += new KagNetComponents2.KagPersianDatePicker.onValueChanged(this.DatePickerStart_ValueChanged);
            // 
            // ComboBoxSerach
            // 
            this.ComboBoxSerach.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ComboBoxSerach.DisplayMember = "Text";
            this.ComboBoxSerach.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxSerach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxSerach.FormattingEnabled = true;
            this.ComboBoxSerach.ItemHeight = 15;
            this.ComboBoxSerach.Items.AddRange(new object[] {
            this.comboItemPaymentDate,
            this.comboItemLetterDate,
            this.comboItemContractDate,
            this.comboItemBeginDate,
            this.comboItemEndDate,
            this.comboItemInsuLetterDate,
            this.comboItemSecretiatDate,
            this.comboItemAnalyzeDate,
            this.comboItemCostIncreaseDate,
            this.comboItemPaymentDoctorDate,
            this.comboItemBonyadConfirmDate,
            this.comboItemAccountingDocumentDate,
            this.comboItemBursaryDate});
            this.ComboBoxSerach.Location = new System.Drawing.Point(379, 12);
            this.ComboBoxSerach.Name = "ComboBoxSerach";
            this.ComboBoxSerach.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ComboBoxSerach.Size = new System.Drawing.Size(107, 21);
            this.ComboBoxSerach.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ComboBoxSerach.TabIndex = 3;
            this.ComboBoxSerach.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSerach_SelectedIndexChanged);
            // 
            // comboItemPaymentDate
            // 
            this.comboItemPaymentDate.Text = "تاریخ ثبت در مالی";
            // 
            // comboItemLetterDate
            // 
            this.comboItemLetterDate.Text = "تاریخ نامه بنیاد";
            // 
            // comboItemContractDate
            // 
            this.comboItemContractDate.Text = "تاریخ قرارداد";
            // 
            // comboItemBeginDate
            // 
            this.comboItemBeginDate.Text = "تاریخ شروع مراقبت";
            // 
            // comboItemEndDate
            // 
            this.comboItemEndDate.Text = "تاریح پایان مراقبت";
            // 
            // comboItemInsuLetterDate
            // 
            this.comboItemInsuLetterDate.Text = "تاریخ ثبت هزینه بیمه";
            // 
            // comboItemSecretiatDate
            // 
            this.comboItemSecretiatDate.Text = "تاریخ دبیرخانه";
            // 
            // comboItemAnalyzeDate
            // 
            this.comboItemAnalyzeDate.Text = "تاریخ آنالیز";
            // 
            // comboItemCostIncreaseDate
            // 
            this.comboItemCostIncreaseDate.Text = "تاریخ ثبت کسورات";
            // 
            // comboItemPaymentDoctorDate
            // 
            this.comboItemPaymentDoctorDate.Text = "تاریخ پرداخت نهایی";
            // 
            // comboItemBonyadConfirmDate
            // 
            this.comboItemBonyadConfirmDate.Text = "تاریخ نامه تایید بنیاد";
            // 
            // comboItemAccountingDocumentDate
            // 
            this.comboItemAccountingDocumentDate.Text = "تاریخ سند حسابداری";
            // 
            // comboItemBursaryDate
            // 
            this.comboItemBursaryDate.Text = "تاریخ سند خزانه داری";
            // 
            // DatePickerStart
            // 
            this.DatePickerStart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DatePickerStart.BackColor = System.Drawing.Color.White;
            this.DatePickerStart.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.DatePickerStart.Location = new System.Drawing.Point(214, 12);
            this.DatePickerStart.Name = "DatePickerStart";
            this.DatePickerStart.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DatePickerStart.ShowTime = false;
            this.DatePickerStart.Size = new System.Drawing.Size(101, 18);
            this.DatePickerStart.TabIndex = 4;
            this.DatePickerStart.Text = "mssDatePicker1";
            this.DatePickerStart.UseFarsiDigits = true;
            this.DatePickerStart.Value = ((KagNetComponents2.KagPersianDate)(resources.GetObject("DatePickerStart.Value")));
            this.DatePickerStart.ValueEn = new System.DateTime(2017, 3, 6, 18, 57, 29, 0);
            this.DatePickerStart.ValueChanged += new KagNetComponents2.KagPersianDatePicker.onValueChanged(this.DatePickerStart_ValueChanged);
            // 
            // mssLabel1
            // 
            this.mssLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mssLabel1.AutoSize = true;
            // 
            // 
            // 
            this.mssLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mssLabel1.ForeColor = System.Drawing.Color.Black;
            this.mssLabel1.Location = new System.Drawing.Point(492, 14);
            this.mssLabel1.Name = "mssLabel1";
            this.mssLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mssLabel1.Size = new System.Drawing.Size(33, 16);
            this.mssLabel1.TabIndex = 0;
            this.mssLabel1.Text = "ستون:";
            // 
            // mssLabel2
            // 
            this.mssLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mssLabel2.AutoSize = true;
            // 
            // 
            // 
            this.mssLabel2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mssLabel2.ForeColor = System.Drawing.Color.Black;
            this.mssLabel2.Location = new System.Drawing.Point(318, 12);
            this.mssLabel2.Name = "mssLabel2";
            this.mssLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mssLabel2.Size = new System.Drawing.Size(38, 16);
            this.mssLabel2.TabIndex = 0;
            this.mssLabel2.Text = "از تاریخ:";
            // 
            // mssLabel3
            // 
            this.mssLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mssLabel3.AutoSize = true;
            // 
            // 
            // 
            this.mssLabel3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mssLabel3.ForeColor = System.Drawing.Color.Black;
            this.mssLabel3.Location = new System.Drawing.Point(145, 12);
            this.mssLabel3.Name = "mssLabel3";
            this.mssLabel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mssLabel3.Size = new System.Drawing.Size(37, 16);
            this.mssLabel3.TabIndex = 0;
            this.mssLabel3.Text = "تا تاریخ:";
            // 
            // mssPanel1
            // 
            this.mssPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.mssPanel1.Controls.Add(this.comboBoxBank);
            this.mssPanel1.Controls.Add(this.label6);
            this.mssPanel1.Controls.Add(this.btnSetValueCare);
            this.mssPanel1.Controls.Add(this.DatePickerSet);
            this.mssPanel1.Controls.Add(this.comboBoxSetValue);
            this.mssPanel1.Controls.Add(this.mssLabel4);
            this.mssPanel1.Controls.Add(this.comboBoxPaymentStatus);
            this.mssPanel1.Controls.Add(this.textBoxSetValue);
            this.mssPanel1.Controls.Add(this.nUpDownSetValue);
            this.mssPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mssPanel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.mssPanel1.Location = new System.Drawing.Point(0, 385);
            this.mssPanel1.Name = "mssPanel1";
            this.mssPanel1.Size = new System.Drawing.Size(907, 38);
            this.mssPanel1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.mssPanel1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.mssPanel1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.mssPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.mssPanel1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.mssPanel1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.mssPanel1.Style.GradientAngle = 90;
            this.mssPanel1.TabIndex = 1;
            // 
            // comboBoxBank
            // 
            this.comboBoxBank.DisplayMember = "Text";
            this.comboBoxBank.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBank.ItemHeight = 15;
            this.comboBoxBank.Location = new System.Drawing.Point(154, 9);
            this.comboBoxBank.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxBank.Name = "comboBoxBank";
            this.comboBoxBank.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBoxBank.Size = new System.Drawing.Size(115, 21);
            this.comboBoxBank.TabIndex = 3;
            this.comboBoxBank.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.label6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(479, 11);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(38, 16);
            this.label6.TabIndex = 84;
            this.label6.Text = "ستون:";
            // 
            // btnSetValueCare
            // 
            this.btnSetValueCare.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSetValueCare.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnSetValueCare.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSetValueCare.Location = new System.Drawing.Point(14, 4);
            this.btnSetValueCare.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSetValueCare.Name = "btnSetValueCare";
            this.btnSetValueCare.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSetValueCare.Size = new System.Drawing.Size(94, 31);
            this.btnSetValueCare.TabIndex = 4;
            this.btnSetValueCare.Tag = "161";
            this.btnSetValueCare.Text = "ثبت مقدار جدید\r\nردیفهای انتخابی";
            this.btnSetValueCare.Click += new System.EventHandler(this.btnSetValue_Click);
            // 
            // DatePickerSet
            // 
            this.DatePickerSet.BackColor = System.Drawing.Color.White;
            this.DatePickerSet.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.DatePickerSet.Location = new System.Drawing.Point(540, 11);
            this.DatePickerSet.Name = "DatePickerSet";
            this.DatePickerSet.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DatePickerSet.ShowTime = false;
            this.DatePickerSet.Size = new System.Drawing.Size(115, 18);
            this.DatePickerSet.TabIndex = 1;
            this.DatePickerSet.Text = "mssDatePicker1";
            this.DatePickerSet.UseFarsiDigits = true;
            this.DatePickerSet.Value = ((KagNetComponents2.KagPersianDate)(resources.GetObject("DatePickerSet.Value")));
            this.DatePickerSet.ValueEn = new System.DateTime(2017, 3, 6, 18, 57, 29, 0);
            this.DatePickerSet.ValueChanged += new KagNetComponents2.KagPersianDatePicker.onValueChanged(this.DatePickerStart_ValueChanged);
            // 
            // comboBoxSetValue
            // 
            this.comboBoxSetValue.DisplayMember = "Text";
            this.comboBoxSetValue.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxSetValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSetValue.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.comboBoxSetValue.ItemHeight = 16;
            this.comboBoxSetValue.Items.AddRange(new object[] {
            this.comboItemPaymentStatus,
            this.comboItemCostCachInsuIran,
            this.comboItemAnalyzePage,
            this.comboItemAnalyzeNo,
            this.comboItemAccountingDocumentNumber,
            this.comboItemBursaryNumber,
            this.comboItemCostVisitCo,
            this.comboItemCostVisitCoPercent,
            this.comboItemCostIncrease,
            this.comboItemCostIncreasePercent,
            this.comboItemPaymentDoctor,
            this.comboItemDescription,
            this.comboItemCasherName,
            this.comboItemCasherNationalCode,
            this.comboItemBank_Id,
            this.comboItemCardBankNo1,
            this.comboItemBonyadConfirmNo,
            this.comboItemSecretiatNo,
            this.comboItemCityPart,
            this.comboItemShiftFew,
            this.comboItemReportCode,
            this.comboItemCostDoctorTax,
            this.comboItemCostDoctorTaxPercent,
            this.comboItemCostDoctorInsurance,
            this.comboItemCostDoctorInsurancePercent});
            this.comboBoxSetValue.Location = new System.Drawing.Point(326, 8);
            this.comboBoxSetValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxSetValue.Name = "comboBoxSetValue";
            this.comboBoxSetValue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBoxSetValue.Size = new System.Drawing.Size(147, 22);
            this.comboBoxSetValue.TabIndex = 2;
            this.comboBoxSetValue.SelectedIndexChanged += new System.EventHandler(this.comboBoxSetValue_SelectedIndexChanged);
            // 
            // comboItemPaymentStatus
            // 
            this.comboItemPaymentStatus.Text = "وضعیت پرداخت";
            // 
            // comboItemCostCachInsuIran
            // 
            this.comboItemCostCachInsuIran.Text = "مبلغ دریافتی از بیمه";
            // 
            // comboItemAnalyzePage
            // 
            this.comboItemAnalyzePage.Text = "شماره صفحه آنالیز ";
            // 
            // comboItemAnalyzeNo
            // 
            this.comboItemAnalyzeNo.Text = "شماره آنالیز";
            // 
            // comboItemAccountingDocumentNumber
            // 
            this.comboItemAccountingDocumentNumber.Text = "سند حسابداری";
            // 
            // comboItemBursaryNumber
            // 
            this.comboItemBursaryNumber.Text = "شماره سند خزانه داری";
            // 
            // comboItemCostVisitCo
            // 
            this.comboItemCostVisitCo.Text = "سهم سازمان";
            // 
            // comboItemCostVisitCoPercent
            // 
            this.comboItemCostVisitCoPercent.Text = "سهم سازمان درصدی";
            // 
            // comboItemCostIncrease
            // 
            this.comboItemCostIncrease.Text = "کسورات";
            // 
            // comboItemCostIncreasePercent
            // 
            this.comboItemCostIncreasePercent.Text = "کسورات درصدی";
            // 
            // comboItemPaymentDoctor
            // 
            this.comboItemPaymentDoctor.Text = "ثبت تاریخ پرداخت نهایی";
            // 
            // comboItemDescription
            // 
            this.comboItemDescription.Text = "توضیحات";
            // 
            // comboItemCasherName
            // 
            this.comboItemCasherName.Text = "نام و فامیل پرداخت شونده";
            // 
            // comboItemCasherNationalCode
            // 
            this.comboItemCasherNationalCode.Text = "کد ملی پرداخت شونده";
            // 
            // comboItemBank_Id
            // 
            this.comboItemBank_Id.Text = "بانک عامل پرداخت شونده";
            // 
            // comboItemCardBankNo1
            // 
            this.comboItemCardBankNo1.Text = "شماره حساب پرداخت شونده";
            // 
            // comboItemBonyadConfirmNo
            // 
            this.comboItemBonyadConfirmNo.Text = "شماره نامه تایید بنیاد";
            // 
            // comboItemSecretiatNo
            // 
            this.comboItemSecretiatNo.Text = "شماره دبیرخانه";
            // 
            // comboItemCityPart
            // 
            this.comboItemCityPart.Text = "شهر / محله";
            // 
            // comboItemShiftFew
            // 
            this.comboItemShiftFew.Text = "تعداد شیفت";
            // 
            // comboItemReportCode
            // 
            this.comboItemReportCode.Text = "کد گزارش";
            // 
            // comboItemCostDoctorTax
            // 
            this.comboItemCostDoctorTax.Text = "مالیات خدمات";
            // 
            // comboItemCostDoctorTaxPercent
            // 
            this.comboItemCostDoctorTaxPercent.Text = "مالیات خدمات درصدی";
            // 
            // comboItemCostDoctorInsurance
            // 
            this.comboItemCostDoctorInsurance.Text = "بیمه خدمات";
            // 
            // comboItemCostDoctorInsurancePercent
            // 
            this.comboItemCostDoctorInsurancePercent.Text = "بیمه خدمات درصدی";
            // 
            // mssLabel4
            // 
            this.mssLabel4.AutoSize = true;
            // 
            // 
            // 
            this.mssLabel4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mssLabel4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.mssLabel4.ForeColor = System.Drawing.Color.White;
            this.mssLabel4.Location = new System.Drawing.Point(658, 11);
            this.mssLabel4.Name = "mssLabel4";
            this.mssLabel4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mssLabel4.Size = new System.Drawing.Size(32, 16);
            this.mssLabel4.TabIndex = 0;
            this.mssLabel4.Text = "تاریخ:";
            // 
            // comboBoxPaymentStatus
            // 
            this.comboBoxPaymentStatus.DisplayMember = "Text";
            this.comboBoxPaymentStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxPaymentStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPaymentStatus.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.comboBoxPaymentStatus.ItemHeight = 16;
            this.comboBoxPaymentStatus.Location = new System.Drawing.Point(154, 8);
            this.comboBoxPaymentStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxPaymentStatus.Name = "comboBoxPaymentStatus";
            this.comboBoxPaymentStatus.Size = new System.Drawing.Size(124, 22);
            this.comboBoxPaymentStatus.TabIndex = 3;
            this.comboBoxPaymentStatus.Visible = false;
            // 
            // textBoxSetValue
            // 
            // 
            // 
            // 
            this.textBoxSetValue.Border.Class = "TextBoxBorder";
            this.textBoxSetValue.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxSetValue.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBoxSetValue.ForeColor = System.Drawing.Color.Black;
            this.textBoxSetValue.Location = new System.Drawing.Point(128, 8);
            this.textBoxSetValue.MaxLength = 0;
            this.textBoxSetValue.Name = "textBoxSetValue";
            this.textBoxSetValue.Size = new System.Drawing.Size(173, 21);
            this.textBoxSetValue.TabIndex = 3;
            // 
            // nUpDownSetValue
            // 
            this.nUpDownSetValue.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.nUpDownSetValue.ForeColor = System.Drawing.Color.Black;
            this.nUpDownSetValue.Location = new System.Drawing.Point(158, 7);
            this.nUpDownSetValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nUpDownSetValue.Name = "nUpDownSetValue";
            this.nUpDownSetValue.Size = new System.Drawing.Size(120, 22);
            this.nUpDownSetValue.TabIndex = 3;
            this.nUpDownSetValue.Text = "0";
            this.nUpDownSetValue.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
            this.nUpDownSetValue.Value = 0;
            this.nUpDownSetValue.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int32;
            this.nUpDownSetValue.Visible = false;
            // 
            // HeaderGridVisitPatientCarePayment
            // 
            // 
            // 
            // 
            this.HeaderGridVisitPatientCarePayment.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridVisitPatientCarePayment.BackgroundStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridVisitPatientCarePayment.BackgroundStyle.BorderBottomWidth = 1;
            this.HeaderGridVisitPatientCarePayment.BackgroundStyle.BorderLeftWidth = 1;
            this.HeaderGridVisitPatientCarePayment.BackgroundStyle.BorderRightWidth = 1;
            this.HeaderGridVisitPatientCarePayment.BackgroundStyle.BorderTopWidth = 1;
            this.HeaderGridVisitPatientCarePayment.BackgroundStyle.Class = "ItemPanel";
            this.HeaderGridVisitPatientCarePayment.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.HeaderGridVisitPatientCarePayment.BackgroundStyle.PaddingBottom = 1;
            this.HeaderGridVisitPatientCarePayment.BackgroundStyle.PaddingLeft = 1;
            this.HeaderGridVisitPatientCarePayment.BackgroundStyle.PaddingRight = 1;
            this.HeaderGridVisitPatientCarePayment.BackgroundStyle.PaddingTop = 1;
            this.HeaderGridVisitPatientCarePayment.ButtonDeletePermissionCode = 81;
            this.HeaderGridVisitPatientCarePayment.ButtonDeleteVisible = true;
            this.HeaderGridVisitPatientCarePayment.ButtonEditPermissionCode = 80;
            this.HeaderGridVisitPatientCarePayment.ButtonEditVisible = true;
            this.HeaderGridVisitPatientCarePayment.ButtonExcelExportVisible = true;
            this.HeaderGridVisitPatientCarePayment.ButtonExcelPermissionCode = 83;
            this.HeaderGridVisitPatientCarePayment.ButtonInsertPermissionCode = 79;
            this.HeaderGridVisitPatientCarePayment.ButtonInsertVisible = true;
            this.HeaderGridVisitPatientCarePayment.ButtonPrintExpertPermissionCode = 0;
            this.HeaderGridVisitPatientCarePayment.ButtonPrintExpertVisible = false;
            this.HeaderGridVisitPatientCarePayment.ButtonPrintPermissionCode = 82;
            this.HeaderGridVisitPatientCarePayment.ButtonPrintVisible = true;
            this.HeaderGridVisitPatientCarePayment.ButtonPrintWithDesignPermissionCode = 159;
            this.HeaderGridVisitPatientCarePayment.ButtonPrintWithDesignVisible = true;
            this.HeaderGridVisitPatientCarePayment.ButtonRefreshVisible = true;
            this.HeaderGridVisitPatientCarePayment.ButtonSearchExpertVisible = false;
            this.HeaderGridVisitPatientCarePayment.ButtonSearchVisible = true;
            this.HeaderGridVisitPatientCarePayment.ButtonSelectorVisible = true;
            this.HeaderGridVisitPatientCarePayment.ContainerControlProcessDialogKey = true;
            this.HeaderGridVisitPatientCarePayment.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderGridVisitPatientCarePayment.FitButtonsToContainerWidth = true;
            this.HeaderGridVisitPatientCarePayment.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.HeaderGridVisitPatientCarePayment.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.HeaderGridVisitPatientCarePayment.GridViewSet = this.GridViewVisitPatientCarePayment;
            this.HeaderGridVisitPatientCarePayment.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItemCarePaymentCalculateRimindAll});
            this.HeaderGridVisitPatientCarePayment.Location = new System.Drawing.Point(0, 0);
            this.HeaderGridVisitPatientCarePayment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HeaderGridVisitPatientCarePayment.Name = "HeaderGridVisitPatientCarePayment";
            this.HeaderGridVisitPatientCarePayment.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HeaderGridVisitPatientCarePayment.Size = new System.Drawing.Size(907, 56);
            this.HeaderGridVisitPatientCarePayment.TabIndex = 33;
            this.HeaderGridVisitPatientCarePayment.Tag = "";
            this.HeaderGridVisitPatientCarePayment.ThemeAware = true;
            this.HeaderGridVisitPatientCarePayment.buttonItemInsertClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemInsertClickEventHandler(this.headerGridVisitPatientCarePayment_btnInsertClick);
            this.HeaderGridVisitPatientCarePayment.buttonItemEditClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemEditClickEventHandler(this.headerGridVisitPatientCarePayment_btnEditClick);
            this.HeaderGridVisitPatientCarePayment.buttonItemDeleteClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemDeleteClickEventHandler(this.headerGridVisitPatientCarePayment_btnDeleteClick);
            this.HeaderGridVisitPatientCarePayment.buttonItemRefreshClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemRefreshClickEventHandler(this.headerGridVisitPatientCarePayment_btnRefreshClick);
            // 
            // buttonItemCarePaymentCalculateRimindAll
            // 
            this.buttonItemCarePaymentCalculateRimindAll.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemCarePaymentCalculateRimindAll.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemCarePaymentCalculateRimindAll.Icon = ((System.Drawing.Icon)(resources.GetObject("buttonItemCarePaymentCalculateRimindAll.Icon")));
            this.buttonItemCarePaymentCalculateRimindAll.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium;
            this.buttonItemCarePaymentCalculateRimindAll.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemCarePaymentCalculateRimindAll.Name = "buttonItemCarePaymentCalculateRimindAll";
            this.buttonItemCarePaymentCalculateRimindAll.Tag = "160";
            this.buttonItemCarePaymentCalculateRimindAll.Text = "محاسبه مانده";
            this.buttonItemCarePaymentCalculateRimindAll.ThemeAware = true;
            this.buttonItemCarePaymentCalculateRimindAll.Click += new System.EventHandler(this.buttonItemCarePaymentCalculateRimindAll_Click);
            // 
            // VisitPatientCarePayment_UC
            // 
            this.Controls.Add(this.GridViewVisitPatientCarePayment);
            this.Controls.Add(this.mssPanel1);
            this.Controls.Add(this.HeaderGridVisitPatientCarePayment);
            this.Controls.Add(this.mssPanel2);
            this.Name = "VisitPatientCarePayment_UC";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(907, 467);
            this.Tag = "لیست پرداختی مراقبت";
            this.Load += new System.EventHandler(this.VisitPatientCarePayment_UC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewVisitPatientCarePayment)).EndInit();
            this.ContextMenuStripStatus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vWVisitPatientCarePaymentBindingSource)).EndInit();
            this.mssPanel2.ResumeLayout(false);
            this.mssPanel2.PerformLayout();
            this.mssPanel1.ResumeLayout(false);
            this.mssPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource vWVisitPatientCarePaymentBindingSource;
        private MSSGridexView GridViewVisitPatientCarePayment;
        private MSSHeaderGrid HeaderGridVisitPatientCarePayment;
        private MSSPanel mssPanel1;
        private MSSComboBox ComboBoxSerach;
        private MSSLabel mssLabel1;
        private MSSDatePicker DatePickerEnd;
        private MSSDatePicker DatePickerStart;
        private MSSLabel mssLabel3;
        private MSSLabel mssLabel2;
        private DevComponents.Editors.ComboItem comboItemLetterDate;
        private DevComponents.Editors.ComboItem comboItemContractDate;
        private DevComponents.Editors.ComboItem comboItemBeginDate;
        private DevComponents.Editors.ComboItem comboItemEndDate;
        private MSSPanel mssPanel2;
        private MSSLabel label6;
        private MSSButton btnSetValueCare;
        private MSSComboBox comboBoxSetValue;
        private DevComponents.Editors.ComboItem comboItemCostCachInsuIran;
        private DevComponents.Editors.ComboItem comboItemAnalyzeNo;
        private DevComponents.Editors.ComboItem comboItemAccountingDocumentNumber;
        private DevComponents.Editors.ComboItem comboItemCostVisitCo;
        private DevComponents.Editors.ComboItem comboItemCostIncrease;
        private DevComponents.Editors.ComboItem comboItemCostIncreasePercent;
        private DevComponents.Editors.ComboItem comboItemPaymentDoctor;
        private DevComponents.Editors.ComboItem comboItemPaymentStatus;
        private DevComponents.Editors.ComboItem comboItemDescription;
        private MSSIntBox nUpDownSetValue;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxPaymentStatus;
        private MSSDatePicker DatePickerSet;
        private MSSLabel mssLabel4;
        private DevComponents.DotNetBar.ButtonItem buttonItemCarePaymentCalculateRimindAll;
        private MSSTextBox textBoxSetValue;
        private DevComponents.Editors.ComboItem comboItemPaymentDate;
        private DevComponents.Editors.ComboItem comboItemInsuLetterDate;
        private DevComponents.Editors.ComboItem comboItemSecretiatDate;
        private DevComponents.Editors.ComboItem comboItemAnalyzeDate;
        private DevComponents.Editors.ComboItem comboItemCostIncreaseDate;
        private DevComponents.Editors.ComboItem comboItemPaymentDoctorDate;
        private MSSCheckBox RadioBoxAllContract;
        private MSSCheckBox RadioBoxContractWithTime;
        private DevComponents.Editors.ComboItem comboItemCasherName;
        private DevComponents.Editors.ComboItem comboItemCasherNationalCode;
        private DevComponents.Editors.ComboItem comboItemBank_Id;
        private DevComponents.Editors.ComboItem comboItemCardBankNo1;
        private MSSComboBox comboBoxBank;
        private DevComponents.Editors.ComboItem comboItemAnalyzePage;
        private DevComponents.Editors.ComboItem comboItemBursaryNumber;
        private DevComponents.Editors.ComboItem comboItemBonyadConfirmDate;
        private DevComponents.Editors.ComboItem comboItemAccountingDocumentDate;
        private DevComponents.Editors.ComboItem comboItemBursaryDate;
        private DevComponents.Editors.ComboItem comboItemCostVisitCoPercent;
        private DevComponents.Editors.ComboItem comboItemBonyadConfirmNo;
        private DevComponents.Editors.ComboItem comboItemSecretiatNo;
        private DevComponents.Editors.ComboItem comboItemCityPart;
        private DevComponents.Editors.ComboItem comboItemShiftFew;
        private DevComponents.Editors.ComboItem comboItemReportCode;
        private MSSContextMenuStrip ContextMenuStripStatus;
        private ToolStripMenuItem ToolStripMenuItemVisitPatientCarePaymentLog;
        private ToolStripMenuItem ToolStripMenuItemVisitPatientCarePaymentCurrentRow;
        private ToolStripMenuItem ToolStripMenuItemVisitPatientCarePaymentAllList;
        private DevComponents.Editors.ComboItem comboItemCostDoctorInsurance;
        private DevComponents.Editors.ComboItem comboItemCostDoctorInsurancePercent;
        private DevComponents.Editors.ComboItem comboItemCostDoctorTax;
        private DevComponents.Editors.ComboItem comboItemCostDoctorTaxPercent;
    }
}
