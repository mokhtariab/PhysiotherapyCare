using System.Windows.Forms;
using MKH.Library.Control;

namespace PhysiotherapyCare.View.MainForms.VisitPatientCare
{
    partial class VisitPatientCarePaymentBimeh_UC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisitPatientCarePaymentBimeh_UC));
            Janus.Windows.GridEX.GridEXLayout GridViewVisitPatientCarePaymentBimeh_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.GridViewVisitPatientCarePaymentBimeh = new MKH.Library.Control.MSSGridexView();
            this.ContextMenuStripStatus = new MKH.Library.Control.MSSContextMenuStrip(this.components);
            this.ToolStripMenuItemVisitPatientCarePaymentBimehLog = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemVisitPatientCarePaymentBimehCurrentRow = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemVisitPatientCarePaymentBimehAllList = new System.Windows.Forms.ToolStripMenuItem();
            this.vWVisitPatientCarePaymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mssPanel2 = new MKH.Library.Control.MSSPanel(this.components);
            this.RadioBoxContractWithTime = new MKH.Library.Control.MSSCheckBox(this.components);
            this.RadioBoxPaymentStatus1 = new MKH.Library.Control.MSSCheckBox(this.components);
            this.RadioBoxPaymentStatusNot1 = new MKH.Library.Control.MSSCheckBox(this.components);
            this.RadioBoxAllContract = new MKH.Library.Control.MSSCheckBox(this.components);
            this.DatePickerEnd = new MKH.Library.Control.MSSDatePicker(this.components);
            this.ComboBoxSerach = new MKH.Library.Control.MSSComboBox();
            this.comboItemPaymentDate = new DevComponents.Editors.ComboItem();
            this.comboItemLetterDate = new DevComponents.Editors.ComboItem();
            this.comboItemContractDate = new DevComponents.Editors.ComboItem();
            this.comboItemBeginDate = new DevComponents.Editors.ComboItem();
            this.comboItemEndDate = new DevComponents.Editors.ComboItem();
            this.comboItemInsuLetterDate = new DevComponents.Editors.ComboItem();
            this.comboItemSecretiatDate = new DevComponents.Editors.ComboItem();
            this.comboItemBonyadConfirmDate = new DevComponents.Editors.ComboItem();
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
            this.comboItemInsuLetterNo = new DevComponents.Editors.ComboItem();
            this.comboItemCostReqInsuIran = new DevComponents.Editors.ComboItem();
            this.comboItemCasherName = new DevComponents.Editors.ComboItem();
            this.comboItemCasherNationalCode = new DevComponents.Editors.ComboItem();
            this.comboItemBank_Id = new DevComponents.Editors.ComboItem();
            this.comboItemCardBankNo1 = new DevComponents.Editors.ComboItem();
            this.mssLabel4 = new MKH.Library.Control.MSSLabel(this.components);
            this.textBoxSetValue = new MKH.Library.Control.MSSTextBox(this.components);
            this.nUpDownSetValue = new MKH.Library.Control.MSSIntBox(this.components);
            this.HeaderGridVisitPatientCarePaymentBimeh = new MKH.Library.Control.MSSHeaderGrid();
            this.buttonItemSendCarePayment = new DevComponents.DotNetBar.ButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewVisitPatientCarePaymentBimeh)).BeginInit();
            this.ContextMenuStripStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vWVisitPatientCarePaymentBindingSource)).BeginInit();
            this.mssPanel2.SuspendLayout();
            this.mssPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridViewVisitPatientCarePaymentBimeh
            // 
            this.GridViewVisitPatientCarePaymentBimeh.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.GridViewVisitPatientCarePaymentBimeh.AlternatingColors = true;
            this.GridViewVisitPatientCarePaymentBimeh.AlternatingRowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewVisitPatientCarePaymentBimeh.BuiltInTextsData = resources.GetString("GridViewVisitPatientCarePaymentBimeh.BuiltInTextsData");
            this.GridViewVisitPatientCarePaymentBimeh.CardViewGridlines = Janus.Windows.GridEX.CardViewGridlines.Both;
            this.GridViewVisitPatientCarePaymentBimeh.ContextMenuStrip = this.ContextMenuStripStatus;
            this.GridViewVisitPatientCarePaymentBimeh.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            GridViewVisitPatientCarePaymentBimeh_DesignTimeLayout.LayoutString = resources.GetString("GridViewVisitPatientCarePaymentBimeh_DesignTimeLayout.LayoutString");
            this.GridViewVisitPatientCarePaymentBimeh.DesignTimeLayout = GridViewVisitPatientCarePaymentBimeh_DesignTimeLayout;
            this.GridViewVisitPatientCarePaymentBimeh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewVisitPatientCarePaymentBimeh.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.GridViewVisitPatientCarePaymentBimeh.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.GridViewVisitPatientCarePaymentBimeh.Font = new System.Drawing.Font("Tahoma", 8.150944F);
            this.GridViewVisitPatientCarePaymentBimeh.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewVisitPatientCarePaymentBimeh.HideSelection = Janus.Windows.GridEX.HideSelection.Highlight;
            this.GridViewVisitPatientCarePaymentBimeh.Location = new System.Drawing.Point(0, 56);
            this.GridViewVisitPatientCarePaymentBimeh.Name = "GridViewVisitPatientCarePaymentBimeh";
            this.GridViewVisitPatientCarePaymentBimeh.RecordNavigator = true;
            this.GridViewVisitPatientCarePaymentBimeh.RowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewVisitPatientCarePaymentBimeh.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition;
            this.GridViewVisitPatientCarePaymentBimeh.RowHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewVisitPatientCarePaymentBimeh.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.GridViewVisitPatientCarePaymentBimeh.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelection;
            this.GridViewVisitPatientCarePaymentBimeh.SettingsKey = "GridViewVisitPatientCarePayment";
            this.GridViewVisitPatientCarePaymentBimeh.Size = new System.Drawing.Size(908, 310);
            this.GridViewVisitPatientCarePaymentBimeh.TabIndex = 34;
            this.GridViewVisitPatientCarePaymentBimeh.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.GridViewVisitPatientCarePaymentBimeh.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.GridViewVisitPatientCarePaymentBimeh.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010;
            this.GridViewVisitPatientCarePaymentBimeh.SelectionChanged += new System.EventHandler(this.GridViewVisitPatientCarePaymentBimeh_SelectionChanged);
            this.GridViewVisitPatientCarePaymentBimeh.DoubleClick += new System.EventHandler(this.headerGridVisitPatientCarePayment_btnEditClick);
            // 
            // ContextMenuStripStatus
            // 
            this.ContextMenuStripStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemVisitPatientCarePaymentBimehLog});
            this.ContextMenuStripStatus.Name = "ContextMenuStripStatus";
            this.ContextMenuStripStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ContextMenuStripStatus.Size = new System.Drawing.Size(95, 26);
            // 
            // ToolStripMenuItemVisitPatientCarePaymentBimehLog
            // 
            this.ToolStripMenuItemVisitPatientCarePaymentBimehLog.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemVisitPatientCarePaymentBimehCurrentRow,
            this.ToolStripMenuItemVisitPatientCarePaymentBimehAllList});
            this.ToolStripMenuItemVisitPatientCarePaymentBimehLog.Name = "ToolStripMenuItemVisitPatientCarePaymentBimehLog";
            this.ToolStripMenuItemVisitPatientCarePaymentBimehLog.Size = new System.Drawing.Size(94, 22);
            this.ToolStripMenuItemVisitPatientCarePaymentBimehLog.Text = "Log";
            // 
            // ToolStripMenuItemVisitPatientCarePaymentBimehCurrentRow
            // 
            this.ToolStripMenuItemVisitPatientCarePaymentBimehCurrentRow.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripMenuItemVisitPatientCarePaymentBimehCurrentRow.Name = "ToolStripMenuItemVisitPatientCarePaymentBimehCurrentRow";
            this.ToolStripMenuItemVisitPatientCarePaymentBimehCurrentRow.Size = new System.Drawing.Size(140, 22);
            this.ToolStripMenuItemVisitPatientCarePaymentBimehCurrentRow.Tag = "274";
            this.ToolStripMenuItemVisitPatientCarePaymentBimehCurrentRow.Text = "سطر انتخابی";
            this.ToolStripMenuItemVisitPatientCarePaymentBimehCurrentRow.Click += new System.EventHandler(this.ToolStripMenuItemVisitPatientCarePaymentBimehCurrentRow_Click);
            // 
            // ToolStripMenuItemVisitPatientCarePaymentBimehAllList
            // 
            this.ToolStripMenuItemVisitPatientCarePaymentBimehAllList.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripMenuItemVisitPatientCarePaymentBimehAllList.Name = "ToolStripMenuItemVisitPatientCarePaymentBimehAllList";
            this.ToolStripMenuItemVisitPatientCarePaymentBimehAllList.Size = new System.Drawing.Size(140, 22);
            this.ToolStripMenuItemVisitPatientCarePaymentBimehAllList.Tag = "275";
            this.ToolStripMenuItemVisitPatientCarePaymentBimehAllList.Text = "کل لیست";
            this.ToolStripMenuItemVisitPatientCarePaymentBimehAllList.Click += new System.EventHandler(this.ToolStripMenuItemVisitPatientCarePaymentBimehAllList_Click);
            // 
            // vWVisitPatientCarePaymentBindingSource
            // 
            this.vWVisitPatientCarePaymentBindingSource.DataSource = typeof(PhysiotherapyCare.Model.VisitPatientCare.VW_VisitPatientCarePayment);
            // 
            // mssPanel2
            // 
            this.mssPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.mssPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.mssPanel2.Controls.Add(this.RadioBoxContractWithTime);
            this.mssPanel2.Controls.Add(this.RadioBoxPaymentStatus1);
            this.mssPanel2.Controls.Add(this.RadioBoxPaymentStatusNot1);
            this.mssPanel2.Controls.Add(this.RadioBoxAllContract);
            this.mssPanel2.Controls.Add(this.DatePickerEnd);
            this.mssPanel2.Controls.Add(this.ComboBoxSerach);
            this.mssPanel2.Controls.Add(this.DatePickerStart);
            this.mssPanel2.Controls.Add(this.mssLabel1);
            this.mssPanel2.Controls.Add(this.mssLabel2);
            this.mssPanel2.Controls.Add(this.mssLabel3);
            this.mssPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mssPanel2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.mssPanel2.Location = new System.Drawing.Point(0, 404);
            this.mssPanel2.Name = "mssPanel2";
            this.mssPanel2.Size = new System.Drawing.Size(908, 63);
            this.mssPanel2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.mssPanel2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.mssPanel2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.mssPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.mssPanel2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.mssPanel2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.mssPanel2.Style.GradientAngle = 90;
            this.mssPanel2.TabIndex = 2;
            // 
            // RadioBoxContractWithTime
            // 
            this.RadioBoxContractWithTime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.RadioBoxContractWithTime.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.RadioBoxContractWithTime.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.RadioBoxContractWithTime.Location = new System.Drawing.Point(714, 35);
            this.RadioBoxContractWithTime.Name = "RadioBoxContractWithTime";
            this.RadioBoxContractWithTime.Size = new System.Drawing.Size(169, 23);
            this.RadioBoxContractWithTime.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.RadioBoxContractWithTime.TabIndex = 4;
            this.RadioBoxContractWithTime.TabStop = false;
            this.RadioBoxContractWithTime.Text = "قرادادها براساس بازه زمانی";
            this.RadioBoxContractWithTime.TextColor = System.Drawing.Color.Black;
            this.RadioBoxContractWithTime.CheckedChanged += new System.EventHandler(this.ComboBoxSerach_SelectedIndexChanged);
            // 
            // RadioBoxPaymentStatus1
            // 
            this.RadioBoxPaymentStatus1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RadioBoxPaymentStatus1.AutoSize = true;
            this.RadioBoxPaymentStatus1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.RadioBoxPaymentStatus1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.RadioBoxPaymentStatus1.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.RadioBoxPaymentStatus1.Checked = true;
            this.RadioBoxPaymentStatus1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RadioBoxPaymentStatus1.CheckValue = "Y";
            this.RadioBoxPaymentStatus1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.RadioBoxPaymentStatus1.Location = new System.Drawing.Point(691, 12);
            this.RadioBoxPaymentStatus1.Name = "RadioBoxPaymentStatus1";
            this.RadioBoxPaymentStatus1.Size = new System.Drawing.Size(92, 17);
            this.RadioBoxPaymentStatus1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.RadioBoxPaymentStatus1.TabIndex = 2;
            this.RadioBoxPaymentStatus1.Text = "ارسال به بیمه";
            this.RadioBoxPaymentStatus1.TextColor = System.Drawing.Color.Black;
            this.RadioBoxPaymentStatus1.CheckedChanged += new System.EventHandler(this.ComboBoxSerach_SelectedIndexChanged);
            // 
            // RadioBoxPaymentStatusNot1
            // 
            this.RadioBoxPaymentStatusNot1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RadioBoxPaymentStatusNot1.AutoSize = true;
            this.RadioBoxPaymentStatusNot1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            // 
            // 
            // 
            this.RadioBoxPaymentStatusNot1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.RadioBoxPaymentStatusNot1.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.RadioBoxPaymentStatusNot1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.RadioBoxPaymentStatusNot1.Location = new System.Drawing.Point(520, 12);
            this.RadioBoxPaymentStatusNot1.Name = "RadioBoxPaymentStatusNot1";
            this.RadioBoxPaymentStatusNot1.Size = new System.Drawing.Size(129, 17);
            this.RadioBoxPaymentStatusNot1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.RadioBoxPaymentStatusNot1.TabIndex = 3;
            this.RadioBoxPaymentStatusNot1.Text = "تایید و ارسال به مالی";
            this.RadioBoxPaymentStatusNot1.TextColor = System.Drawing.Color.Black;
            this.RadioBoxPaymentStatusNot1.CheckedChanged += new System.EventHandler(this.ComboBoxSerach_SelectedIndexChanged);
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
            this.RadioBoxAllContract.Location = new System.Drawing.Point(811, 12);
            this.RadioBoxAllContract.Name = "RadioBoxAllContract";
            this.RadioBoxAllContract.Size = new System.Drawing.Size(72, 17);
            this.RadioBoxAllContract.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.RadioBoxAllContract.TabIndex = 1;
            this.RadioBoxAllContract.TabStop = false;
            this.RadioBoxAllContract.Text = "کل لیست";
            this.RadioBoxAllContract.TextColor = System.Drawing.Color.Black;
            this.RadioBoxAllContract.CheckedChanged += new System.EventHandler(this.ComboBoxSerach_SelectedIndexChanged);
            // 
            // DatePickerEnd
            // 
            this.DatePickerEnd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DatePickerEnd.BackColor = System.Drawing.Color.White;
            this.DatePickerEnd.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.DatePickerEnd.Location = new System.Drawing.Point(193, 35);
            this.DatePickerEnd.Name = "DatePickerEnd";
            this.DatePickerEnd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DatePickerEnd.ShowTime = false;
            this.DatePickerEnd.Size = new System.Drawing.Size(103, 18);
            this.DatePickerEnd.TabIndex = 7;
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
            this.comboItemBonyadConfirmDate});
            this.ComboBoxSerach.Location = new System.Drawing.Point(535, 35);
            this.ComboBoxSerach.Name = "ComboBoxSerach";
            this.ComboBoxSerach.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ComboBoxSerach.Size = new System.Drawing.Size(107, 21);
            this.ComboBoxSerach.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ComboBoxSerach.TabIndex = 5;
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
            // comboItemBonyadConfirmDate
            // 
            this.comboItemBonyadConfirmDate.Text = "تاریخ نامه تایید بنیاد";
            // 
            // DatePickerStart
            // 
            this.DatePickerStart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DatePickerStart.BackColor = System.Drawing.Color.White;
            this.DatePickerStart.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.DatePickerStart.Location = new System.Drawing.Point(370, 35);
            this.DatePickerStart.Name = "DatePickerStart";
            this.DatePickerStart.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DatePickerStart.ShowTime = false;
            this.DatePickerStart.Size = new System.Drawing.Size(101, 18);
            this.DatePickerStart.TabIndex = 6;
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
            this.mssLabel1.Location = new System.Drawing.Point(648, 37);
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
            this.mssLabel2.Location = new System.Drawing.Point(474, 35);
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
            this.mssLabel3.Location = new System.Drawing.Point(301, 35);
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
            this.mssPanel1.Controls.Add(this.textBoxSetValue);
            this.mssPanel1.Controls.Add(this.nUpDownSetValue);
            this.mssPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mssPanel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.mssPanel1.Location = new System.Drawing.Point(0, 366);
            this.mssPanel1.Name = "mssPanel1";
            this.mssPanel1.Size = new System.Drawing.Size(908, 38);
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
            this.btnSetValueCare.Tag = "181";
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
            this.comboItemInsuLetterNo,
            this.comboItemCostReqInsuIran,
            this.comboItemCasherName,
            this.comboItemCasherNationalCode,
            this.comboItemBank_Id,
            this.comboItemCardBankNo1});
            this.comboBoxSetValue.Location = new System.Drawing.Point(326, 8);
            this.comboBoxSetValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxSetValue.Name = "comboBoxSetValue";
            this.comboBoxSetValue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBoxSetValue.Size = new System.Drawing.Size(147, 22);
            this.comboBoxSetValue.TabIndex = 2;
            this.comboBoxSetValue.SelectedIndexChanged += new System.EventHandler(this.comboBoxSetValue_SelectedIndexChanged);
            // 
            // comboItemInsuLetterNo
            // 
            this.comboItemInsuLetterNo.Text = "شماره معرفی نامه بیمه";
            // 
            // comboItemCostReqInsuIran
            // 
            this.comboItemCostReqInsuIran.Text = "مبلغ درخواستی بیمه";
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
            // HeaderGridVisitPatientCarePaymentBimeh
            // 
            // 
            // 
            // 
            this.HeaderGridVisitPatientCarePaymentBimeh.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridVisitPatientCarePaymentBimeh.BackgroundStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridVisitPatientCarePaymentBimeh.BackgroundStyle.BorderBottomWidth = 1;
            this.HeaderGridVisitPatientCarePaymentBimeh.BackgroundStyle.BorderLeftWidth = 1;
            this.HeaderGridVisitPatientCarePaymentBimeh.BackgroundStyle.BorderRightWidth = 1;
            this.HeaderGridVisitPatientCarePaymentBimeh.BackgroundStyle.BorderTopWidth = 1;
            this.HeaderGridVisitPatientCarePaymentBimeh.BackgroundStyle.Class = "ItemPanel";
            this.HeaderGridVisitPatientCarePaymentBimeh.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.HeaderGridVisitPatientCarePaymentBimeh.BackgroundStyle.PaddingBottom = 1;
            this.HeaderGridVisitPatientCarePaymentBimeh.BackgroundStyle.PaddingLeft = 1;
            this.HeaderGridVisitPatientCarePaymentBimeh.BackgroundStyle.PaddingRight = 1;
            this.HeaderGridVisitPatientCarePaymentBimeh.BackgroundStyle.PaddingTop = 1;
            this.HeaderGridVisitPatientCarePaymentBimeh.ButtonDeletePermissionCode = 176;
            this.HeaderGridVisitPatientCarePaymentBimeh.ButtonDeleteVisible = true;
            this.HeaderGridVisitPatientCarePaymentBimeh.ButtonEditPermissionCode = 175;
            this.HeaderGridVisitPatientCarePaymentBimeh.ButtonEditVisible = true;
            this.HeaderGridVisitPatientCarePaymentBimeh.ButtonExcelExportVisible = true;
            this.HeaderGridVisitPatientCarePaymentBimeh.ButtonExcelPermissionCode = 178;
            this.HeaderGridVisitPatientCarePaymentBimeh.ButtonInsertPermissionCode = 0;
            this.HeaderGridVisitPatientCarePaymentBimeh.ButtonInsertVisible = false;
            this.HeaderGridVisitPatientCarePaymentBimeh.ButtonPrintExpertPermissionCode = 0;
            this.HeaderGridVisitPatientCarePaymentBimeh.ButtonPrintExpertVisible = false;
            this.HeaderGridVisitPatientCarePaymentBimeh.ButtonPrintPermissionCode = 177;
            this.HeaderGridVisitPatientCarePaymentBimeh.ButtonPrintVisible = true;
            this.HeaderGridVisitPatientCarePaymentBimeh.ButtonPrintWithDesignPermissionCode = 179;
            this.HeaderGridVisitPatientCarePaymentBimeh.ButtonPrintWithDesignVisible = true;
            this.HeaderGridVisitPatientCarePaymentBimeh.ButtonRefreshVisible = true;
            this.HeaderGridVisitPatientCarePaymentBimeh.ButtonSearchExpertVisible = false;
            this.HeaderGridVisitPatientCarePaymentBimeh.ButtonSearchVisible = true;
            this.HeaderGridVisitPatientCarePaymentBimeh.ButtonSelectorVisible = true;
            this.HeaderGridVisitPatientCarePaymentBimeh.ContainerControlProcessDialogKey = true;
            this.HeaderGridVisitPatientCarePaymentBimeh.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderGridVisitPatientCarePaymentBimeh.FitButtonsToContainerWidth = true;
            this.HeaderGridVisitPatientCarePaymentBimeh.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.HeaderGridVisitPatientCarePaymentBimeh.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.HeaderGridVisitPatientCarePaymentBimeh.GridViewSet = this.GridViewVisitPatientCarePaymentBimeh;
            this.HeaderGridVisitPatientCarePaymentBimeh.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItemSendCarePayment});
            this.HeaderGridVisitPatientCarePaymentBimeh.Location = new System.Drawing.Point(0, 0);
            this.HeaderGridVisitPatientCarePaymentBimeh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HeaderGridVisitPatientCarePaymentBimeh.Name = "HeaderGridVisitPatientCarePaymentBimeh";
            this.HeaderGridVisitPatientCarePaymentBimeh.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HeaderGridVisitPatientCarePaymentBimeh.Size = new System.Drawing.Size(908, 56);
            this.HeaderGridVisitPatientCarePaymentBimeh.TabIndex = 33;
            this.HeaderGridVisitPatientCarePaymentBimeh.Tag = "";
            this.HeaderGridVisitPatientCarePaymentBimeh.ThemeAware = true;
            this.HeaderGridVisitPatientCarePaymentBimeh.buttonItemInsertClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemInsertClickEventHandler(this.headerGridVisitPatientCarePayment_btnInsertClick);
            this.HeaderGridVisitPatientCarePaymentBimeh.buttonItemEditClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemEditClickEventHandler(this.headerGridVisitPatientCarePayment_btnEditClick);
            this.HeaderGridVisitPatientCarePaymentBimeh.buttonItemDeleteClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemDeleteClickEventHandler(this.headerGridVisitPatientCarePayment_btnDeleteClick);
            this.HeaderGridVisitPatientCarePaymentBimeh.buttonItemRefreshClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemRefreshClickEventHandler(this.headerGridVisitPatientCarePayment_btnRefreshClick);
            // 
            // buttonItemSendCarePayment
            // 
            this.buttonItemSendCarePayment.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemSendCarePayment.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemSendCarePayment.Icon = ((System.Drawing.Icon)(resources.GetObject("buttonItemSendCarePayment.Icon")));
            this.buttonItemSendCarePayment.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium;
            this.buttonItemSendCarePayment.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemSendCarePayment.Name = "buttonItemSendCarePayment";
            this.buttonItemSendCarePayment.Tag = "180";
            this.buttonItemSendCarePayment.Text = "تایید و ارسال جهت مالی";
            this.buttonItemSendCarePayment.ThemeAware = true;
            this.buttonItemSendCarePayment.Click += new System.EventHandler(this.buttonItemSendCarePayment_Click);
            // 
            // VisitPatientCarePaymentBimeh_UC
            // 
            this.Controls.Add(this.GridViewVisitPatientCarePaymentBimeh);
            this.Controls.Add(this.mssPanel1);
            this.Controls.Add(this.HeaderGridVisitPatientCarePaymentBimeh);
            this.Controls.Add(this.mssPanel2);
            this.Name = "VisitPatientCarePaymentBimeh_UC";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(908, 467);
            this.Tag = "لیست ارسال به بیمه مراقبت";
            this.Load += new System.EventHandler(this.VisitPatientCarePaymentBimeh_UC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewVisitPatientCarePaymentBimeh)).EndInit();
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
        private MSSGridexView GridViewVisitPatientCarePaymentBimeh;
        private MSSHeaderGrid HeaderGridVisitPatientCarePaymentBimeh;
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
        private DevComponents.Editors.ComboItem comboItemInsuLetterNo;
        private DevComponents.Editors.ComboItem comboItemCostReqInsuIran;
        private MSSIntBox nUpDownSetValue;
        private MSSDatePicker DatePickerSet;
        private MSSLabel mssLabel4;
        private MSSTextBox textBoxSetValue;
        private DevComponents.Editors.ComboItem comboItemPaymentDate;
        private DevComponents.Editors.ComboItem comboItemInsuLetterDate;
        private DevComponents.Editors.ComboItem comboItemSecretiatDate;
        private MSSCheckBox RadioBoxAllContract;
        private DevComponents.Editors.ComboItem comboItemCasherName;
        private DevComponents.Editors.ComboItem comboItemCasherNationalCode;
        private DevComponents.Editors.ComboItem comboItemBank_Id;
        private DevComponents.Editors.ComboItem comboItemCardBankNo1;
        private MSSComboBox comboBoxBank;
        private DevComponents.Editors.ComboItem comboItemBonyadConfirmDate;
        private DevComponents.DotNetBar.ButtonItem buttonItemSendCarePayment;
        private MSSCheckBox RadioBoxContractWithTime;
        private MSSCheckBox RadioBoxPaymentStatus1;
        private MSSCheckBox RadioBoxPaymentStatusNot1;
        private MSSContextMenuStrip ContextMenuStripStatus;
        private ToolStripMenuItem ToolStripMenuItemVisitPatientCarePaymentBimehLog;
        private ToolStripMenuItem ToolStripMenuItemVisitPatientCarePaymentBimehCurrentRow;
        private ToolStripMenuItem ToolStripMenuItemVisitPatientCarePaymentBimehAllList;
    }
}
