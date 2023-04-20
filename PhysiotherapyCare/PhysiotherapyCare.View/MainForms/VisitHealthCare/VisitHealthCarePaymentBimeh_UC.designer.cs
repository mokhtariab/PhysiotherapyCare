using System.Windows.Forms;
using MKH.Library.Control;

namespace PhysiotherapyCare.View.MainForms.VisitHealthCare
{
    partial class VisitHealthCarePaymentBimeh_UC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisitHealthCarePaymentBimeh_UC));
            Janus.Windows.GridEX.GridEXLayout GridViewVisitHealthCarePaymentBimeh_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.serviceHealthCare_UC1 = new PhysiotherapyCare.View.MainForms.VisitHealthCare.ServiceHealthCare_UC();
            this.GridViewVisitHealthCarePaymentBimeh = new MKH.Library.Control.MSSGridexView();
            this.ContextMenuStripStatus = new MKH.Library.Control.MSSContextMenuStrip(this.components);
            this.ToolStripMenuItemVisitHealthCarePaymentBimehLog = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemVisitHealthCarePaymentBimehCurrentRow = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemVisitHealthCarePaymentBimehAllList = new System.Windows.Forms.ToolStripMenuItem();
            this.vWVisitHealthCarePaymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mssExpandableSplitter1 = new MKH.Library.Control.MSSExpandableSplitter(this.components);
            this.mssPanel1 = new MKH.Library.Control.MSSPanel(this.components);
            this.textBoxSetValue = new MKH.Library.Control.MSSTextBox(this.components);
            this.label6 = new MKH.Library.Control.MSSLabel(this.components);
            this.btnSetValueHealth = new MKH.Library.Control.MSSButton(this.components);
            this.DatePickerSet = new MKH.Library.Control.MSSDatePicker(this.components);
            this.comboBoxSetValue = new MKH.Library.Control.MSSComboBox();
            this.comboItemInsuLetterNo = new DevComponents.Editors.ComboItem();
            this.comboItemCostReqInsuIran = new DevComponents.Editors.ComboItem();
            this.nUpDownSetValue = new MKH.Library.Control.MSSIntBox(this.components);
            this.mssLabel4 = new MKH.Library.Control.MSSLabel(this.components);
            this.comboBoxPaymentStatus = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.HeaderGridVisitHealthCarePaymentBimeh = new MKH.Library.Control.MSSHeaderGrid();
            this.buttonItemSendHealthCarePayment = new DevComponents.DotNetBar.ButtonItem();
            this.mssPanel2 = new MKH.Library.Control.MSSPanel(this.components);
            this.RadioBoxContractWithTime = new MKH.Library.Control.MSSCheckBox(this.components);
            this.RadioBoxPaymentStatus1 = new MKH.Library.Control.MSSCheckBox(this.components);
            this.RadioBoxPaymentStatusNot1 = new MKH.Library.Control.MSSCheckBox(this.components);
            this.RadioBoxAllContract = new MKH.Library.Control.MSSCheckBox(this.components);
            this.DatePickerEnd = new MKH.Library.Control.MSSDatePicker(this.components);
            this.ComboBoxSerach = new MKH.Library.Control.MSSComboBox();
            this.comboItemHealthCareDate = new DevComponents.Editors.ComboItem();
            this.comboItemContractDate = new DevComponents.Editors.ComboItem();
            this.comboItemPaymentDate = new DevComponents.Editors.ComboItem();
            this.comboItemLetterDate = new DevComponents.Editors.ComboItem();
            this.comboItemInsuLetterDate = new DevComponents.Editors.ComboItem();
            this.comboItemSecretiatDate = new DevComponents.Editors.ComboItem();
            this.comboItemBonyadConfirmDate = new DevComponents.Editors.ComboItem();
            this.DatePickerStart = new MKH.Library.Control.MSSDatePicker(this.components);
            this.mssLabel1 = new MKH.Library.Control.MSSLabel(this.components);
            this.mssLabel2 = new MKH.Library.Control.MSSLabel(this.components);
            this.mssLabel3 = new MKH.Library.Control.MSSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewVisitHealthCarePaymentBimeh)).BeginInit();
            this.ContextMenuStripStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vWVisitHealthCarePaymentBindingSource)).BeginInit();
            this.mssPanel1.SuspendLayout();
            this.mssPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // serviceHealthCare_UC1
            // 
            this.serviceHealthCare_UC1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.serviceHealthCare_UC1.Location = new System.Drawing.Point(0, 365);
            this.serviceHealthCare_UC1.Name = "serviceHealthCare_UC1";
            this.serviceHealthCare_UC1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.serviceHealthCare_UC1.Size = new System.Drawing.Size(916, 118);
            this.serviceHealthCare_UC1.TabIndex = 40;
            this.serviceHealthCare_UC1.Tag = "لیست خدمات";
            // 
            // GridViewVisitHealthCarePaymentBimeh
            // 
            this.GridViewVisitHealthCarePaymentBimeh.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.GridViewVisitHealthCarePaymentBimeh.AlternatingColors = true;
            this.GridViewVisitHealthCarePaymentBimeh.AlternatingRowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewVisitHealthCarePaymentBimeh.BuiltInTextsData = resources.GetString("GridViewVisitHealthCarePaymentBimeh.BuiltInTextsData");
            this.GridViewVisitHealthCarePaymentBimeh.CardViewGridlines = Janus.Windows.GridEX.CardViewGridlines.Both;
            this.GridViewVisitHealthCarePaymentBimeh.ContextMenuStrip = this.ContextMenuStripStatus;
            this.GridViewVisitHealthCarePaymentBimeh.DataSource = this.vWVisitHealthCarePaymentBindingSource;
            this.GridViewVisitHealthCarePaymentBimeh.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            GridViewVisitHealthCarePaymentBimeh_DesignTimeLayout.LayoutString = resources.GetString("GridViewVisitHealthCarePaymentBimeh_DesignTimeLayout.LayoutString");
            this.GridViewVisitHealthCarePaymentBimeh.DesignTimeLayout = GridViewVisitHealthCarePaymentBimeh_DesignTimeLayout;
            this.GridViewVisitHealthCarePaymentBimeh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewVisitHealthCarePaymentBimeh.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.GridViewVisitHealthCarePaymentBimeh.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.GridViewVisitHealthCarePaymentBimeh.Font = new System.Drawing.Font("Tahoma", 8.150944F);
            this.GridViewVisitHealthCarePaymentBimeh.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewVisitHealthCarePaymentBimeh.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
            this.GridViewVisitHealthCarePaymentBimeh.Location = new System.Drawing.Point(0, 56);
            this.GridViewVisitHealthCarePaymentBimeh.Name = "GridViewVisitHealthCarePaymentBimeh";
            this.GridViewVisitHealthCarePaymentBimeh.RecordNavigator = true;
            this.GridViewVisitHealthCarePaymentBimeh.RowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewVisitHealthCarePaymentBimeh.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition;
            this.GridViewVisitHealthCarePaymentBimeh.RowHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewVisitHealthCarePaymentBimeh.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.GridViewVisitHealthCarePaymentBimeh.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelection;
            this.GridViewVisitHealthCarePaymentBimeh.Size = new System.Drawing.Size(916, 303);
            this.GridViewVisitHealthCarePaymentBimeh.TabIndex = 41;
            this.GridViewVisitHealthCarePaymentBimeh.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.GridViewVisitHealthCarePaymentBimeh.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.GridViewVisitHealthCarePaymentBimeh.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010;
            this.GridViewVisitHealthCarePaymentBimeh.SelectionChanged += new System.EventHandler(this.GridViewVisitHealthCarePaymentBimeh_SelectionChanged);
            this.GridViewVisitHealthCarePaymentBimeh.DoubleClick += new System.EventHandler(this.headerGridVisitHealthCarePaymentBimeh_btnEditClick);
            // 
            // ContextMenuStripStatus
            // 
            this.ContextMenuStripStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemVisitHealthCarePaymentBimehLog});
            this.ContextMenuStripStatus.Name = "ContextMenuStripStatus";
            this.ContextMenuStripStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ContextMenuStripStatus.Size = new System.Drawing.Size(95, 26);
            // 
            // ToolStripMenuItemVisitHealthCarePaymentBimehLog
            // 
            this.ToolStripMenuItemVisitHealthCarePaymentBimehLog.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemVisitHealthCarePaymentBimehCurrentRow,
            this.ToolStripMenuItemVisitHealthCarePaymentBimehAllList});
            this.ToolStripMenuItemVisitHealthCarePaymentBimehLog.Name = "ToolStripMenuItemVisitHealthCarePaymentBimehLog";
            this.ToolStripMenuItemVisitHealthCarePaymentBimehLog.Size = new System.Drawing.Size(94, 22);
            this.ToolStripMenuItemVisitHealthCarePaymentBimehLog.Text = "Log";
            // 
            // ToolStripMenuItemVisitHealthCarePaymentBimehCurrentRow
            // 
            this.ToolStripMenuItemVisitHealthCarePaymentBimehCurrentRow.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripMenuItemVisitHealthCarePaymentBimehCurrentRow.Name = "ToolStripMenuItemVisitHealthCarePaymentBimehCurrentRow";
            this.ToolStripMenuItemVisitHealthCarePaymentBimehCurrentRow.Size = new System.Drawing.Size(140, 22);
            this.ToolStripMenuItemVisitHealthCarePaymentBimehCurrentRow.Tag = "268";
            this.ToolStripMenuItemVisitHealthCarePaymentBimehCurrentRow.Text = "سطر انتخابی";
            this.ToolStripMenuItemVisitHealthCarePaymentBimehCurrentRow.Click += new System.EventHandler(this.ToolStripMenuItemVisitHealthCarePaymentBimehCurrentRow_Click);
            // 
            // ToolStripMenuItemVisitHealthCarePaymentBimehAllList
            // 
            this.ToolStripMenuItemVisitHealthCarePaymentBimehAllList.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripMenuItemVisitHealthCarePaymentBimehAllList.Name = "ToolStripMenuItemVisitHealthCarePaymentBimehAllList";
            this.ToolStripMenuItemVisitHealthCarePaymentBimehAllList.Size = new System.Drawing.Size(140, 22);
            this.ToolStripMenuItemVisitHealthCarePaymentBimehAllList.Tag = "269";
            this.ToolStripMenuItemVisitHealthCarePaymentBimehAllList.Text = "کل لیست";
            this.ToolStripMenuItemVisitHealthCarePaymentBimehAllList.Click += new System.EventHandler(this.ToolStripMenuItemVisitHealthCarePaymentBimehAllList_Click);
            // 
            // vWVisitHealthCarePaymentBindingSource
            // 
            this.vWVisitHealthCarePaymentBindingSource.DataSource = typeof(PhysiotherapyCare.Model.VisitHealthCare.VW_VisitHealthCarePayment);
            // 
            // mssExpandableSplitter1
            // 
            this.mssExpandableSplitter1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.mssExpandableSplitter1.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.mssExpandableSplitter1.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.mssExpandableSplitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mssExpandableSplitter1.ExpandFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.mssExpandableSplitter1.ExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.mssExpandableSplitter1.ExpandLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mssExpandableSplitter1.ExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.mssExpandableSplitter1.ForeColor = System.Drawing.Color.Black;
            this.mssExpandableSplitter1.GripDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mssExpandableSplitter1.GripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.mssExpandableSplitter1.GripLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.mssExpandableSplitter1.GripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.mssExpandableSplitter1.HotBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(151)))), ((int)(((byte)(61)))));
            this.mssExpandableSplitter1.HotBackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(94)))));
            this.mssExpandableSplitter1.HotBackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground2;
            this.mssExpandableSplitter1.HotBackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground;
            this.mssExpandableSplitter1.HotExpandFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.mssExpandableSplitter1.HotExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.mssExpandableSplitter1.HotExpandLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mssExpandableSplitter1.HotExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.mssExpandableSplitter1.HotGripDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.mssExpandableSplitter1.HotGripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.mssExpandableSplitter1.HotGripLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.mssExpandableSplitter1.HotGripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.mssExpandableSplitter1.Location = new System.Drawing.Point(0, 359);
            this.mssExpandableSplitter1.Name = "mssExpandableSplitter1";
            this.mssExpandableSplitter1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mssExpandableSplitter1.Size = new System.Drawing.Size(916, 6);
            this.mssExpandableSplitter1.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007;
            this.mssExpandableSplitter1.TabIndex = 39;
            this.mssExpandableSplitter1.TabStop = false;
            // 
            // mssPanel1
            // 
            this.mssPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.mssPanel1.Controls.Add(this.textBoxSetValue);
            this.mssPanel1.Controls.Add(this.label6);
            this.mssPanel1.Controls.Add(this.btnSetValueHealth);
            this.mssPanel1.Controls.Add(this.DatePickerSet);
            this.mssPanel1.Controls.Add(this.comboBoxSetValue);
            this.mssPanel1.Controls.Add(this.nUpDownSetValue);
            this.mssPanel1.Controls.Add(this.mssLabel4);
            this.mssPanel1.Controls.Add(this.comboBoxPaymentStatus);
            this.mssPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mssPanel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.mssPanel1.Location = new System.Drawing.Point(0, 483);
            this.mssPanel1.Name = "mssPanel1";
            this.mssPanel1.Size = new System.Drawing.Size(916, 38);
            this.mssPanel1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.mssPanel1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.mssPanel1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.mssPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.mssPanel1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.mssPanel1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.mssPanel1.Style.GradientAngle = 90;
            this.mssPanel1.TabIndex = 35;
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
            this.textBoxSetValue.Location = new System.Drawing.Point(131, 9);
            this.textBoxSetValue.MaxLength = 0;
            this.textBoxSetValue.Name = "textBoxSetValue";
            this.textBoxSetValue.Size = new System.Drawing.Size(173, 21);
            this.textBoxSetValue.TabIndex = 87;
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
            // btnSetValueHealth
            // 
            this.btnSetValueHealth.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSetValueHealth.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnSetValueHealth.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSetValueHealth.Location = new System.Drawing.Point(14, 4);
            this.btnSetValueHealth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSetValueHealth.Name = "btnSetValueHealth";
            this.btnSetValueHealth.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSetValueHealth.Size = new System.Drawing.Size(94, 31);
            this.btnSetValueHealth.TabIndex = 80;
            this.btnSetValueHealth.Tag = "197";
            this.btnSetValueHealth.Text = "ثبت مقدار جدید\r\nردیفهای انتخابی";
            this.btnSetValueHealth.Click += new System.EventHandler(this.btnSetValue_Click);
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
            this.DatePickerSet.TabIndex = 2;
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
            this.comboBoxSetValue.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.comboBoxSetValue.ItemHeight = 15;
            this.comboBoxSetValue.Items.AddRange(new object[] {
            this.comboItemInsuLetterNo,
            this.comboItemCostReqInsuIran});
            this.comboBoxSetValue.Location = new System.Drawing.Point(326, 8);
            this.comboBoxSetValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxSetValue.Name = "comboBoxSetValue";
            this.comboBoxSetValue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBoxSetValue.Size = new System.Drawing.Size(147, 21);
            this.comboBoxSetValue.TabIndex = 79;
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
            // nUpDownSetValue
            // 
            this.nUpDownSetValue.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.nUpDownSetValue.ForeColor = System.Drawing.Color.Black;
            this.nUpDownSetValue.Location = new System.Drawing.Point(158, 8);
            this.nUpDownSetValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nUpDownSetValue.Name = "nUpDownSetValue";
            this.nUpDownSetValue.Size = new System.Drawing.Size(120, 22);
            this.nUpDownSetValue.TabIndex = 82;
            this.nUpDownSetValue.Text = "0";
            this.nUpDownSetValue.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
            this.nUpDownSetValue.Value = 0;
            this.nUpDownSetValue.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int32;
            this.nUpDownSetValue.Visible = false;
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
            this.comboBoxPaymentStatus.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.comboBoxPaymentStatus.ItemHeight = 15;
            this.comboBoxPaymentStatus.Location = new System.Drawing.Point(154, 9);
            this.comboBoxPaymentStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxPaymentStatus.Name = "comboBoxPaymentStatus";
            this.comboBoxPaymentStatus.Size = new System.Drawing.Size(124, 21);
            this.comboBoxPaymentStatus.TabIndex = 83;
            this.comboBoxPaymentStatus.Visible = false;
            // 
            // HeaderGridVisitHealthCarePaymentBimeh
            // 
            // 
            // 
            // 
            this.HeaderGridVisitHealthCarePaymentBimeh.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridVisitHealthCarePaymentBimeh.BackgroundStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridVisitHealthCarePaymentBimeh.BackgroundStyle.BorderBottomWidth = 1;
            this.HeaderGridVisitHealthCarePaymentBimeh.BackgroundStyle.BorderLeftWidth = 1;
            this.HeaderGridVisitHealthCarePaymentBimeh.BackgroundStyle.BorderRightWidth = 1;
            this.HeaderGridVisitHealthCarePaymentBimeh.BackgroundStyle.BorderTopWidth = 1;
            this.HeaderGridVisitHealthCarePaymentBimeh.BackgroundStyle.Class = "ItemPanel";
            this.HeaderGridVisitHealthCarePaymentBimeh.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.HeaderGridVisitHealthCarePaymentBimeh.BackgroundStyle.PaddingBottom = 1;
            this.HeaderGridVisitHealthCarePaymentBimeh.BackgroundStyle.PaddingLeft = 1;
            this.HeaderGridVisitHealthCarePaymentBimeh.BackgroundStyle.PaddingRight = 1;
            this.HeaderGridVisitHealthCarePaymentBimeh.BackgroundStyle.PaddingTop = 1;
            this.HeaderGridVisitHealthCarePaymentBimeh.ButtonDeletePermissionCode = 192;
            this.HeaderGridVisitHealthCarePaymentBimeh.ButtonDeleteVisible = true;
            this.HeaderGridVisitHealthCarePaymentBimeh.ButtonEditPermissionCode = 191;
            this.HeaderGridVisitHealthCarePaymentBimeh.ButtonEditVisible = true;
            this.HeaderGridVisitHealthCarePaymentBimeh.ButtonExcelExportVisible = true;
            this.HeaderGridVisitHealthCarePaymentBimeh.ButtonExcelPermissionCode = 194;
            this.HeaderGridVisitHealthCarePaymentBimeh.ButtonInsertPermissionCode = 0;
            this.HeaderGridVisitHealthCarePaymentBimeh.ButtonInsertVisible = false;
            this.HeaderGridVisitHealthCarePaymentBimeh.ButtonPrintExpertPermissionCode = 0;
            this.HeaderGridVisitHealthCarePaymentBimeh.ButtonPrintExpertVisible = false;
            this.HeaderGridVisitHealthCarePaymentBimeh.ButtonPrintPermissionCode = 193;
            this.HeaderGridVisitHealthCarePaymentBimeh.ButtonPrintVisible = true;
            this.HeaderGridVisitHealthCarePaymentBimeh.ButtonPrintWithDesignPermissionCode = 195;
            this.HeaderGridVisitHealthCarePaymentBimeh.ButtonPrintWithDesignVisible = true;
            this.HeaderGridVisitHealthCarePaymentBimeh.ButtonRefreshVisible = true;
            this.HeaderGridVisitHealthCarePaymentBimeh.ButtonSearchExpertVisible = false;
            this.HeaderGridVisitHealthCarePaymentBimeh.ButtonSearchVisible = true;
            this.HeaderGridVisitHealthCarePaymentBimeh.ButtonSelectorVisible = true;
            this.HeaderGridVisitHealthCarePaymentBimeh.ContainerControlProcessDialogKey = true;
            this.HeaderGridVisitHealthCarePaymentBimeh.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderGridVisitHealthCarePaymentBimeh.FitButtonsToContainerWidth = true;
            this.HeaderGridVisitHealthCarePaymentBimeh.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.HeaderGridVisitHealthCarePaymentBimeh.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.HeaderGridVisitHealthCarePaymentBimeh.GridViewSet = this.GridViewVisitHealthCarePaymentBimeh;
            this.HeaderGridVisitHealthCarePaymentBimeh.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItemSendHealthCarePayment});
            this.HeaderGridVisitHealthCarePaymentBimeh.Location = new System.Drawing.Point(0, 0);
            this.HeaderGridVisitHealthCarePaymentBimeh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HeaderGridVisitHealthCarePaymentBimeh.Name = "HeaderGridVisitHealthCarePaymentBimeh";
            this.HeaderGridVisitHealthCarePaymentBimeh.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HeaderGridVisitHealthCarePaymentBimeh.Size = new System.Drawing.Size(916, 56);
            this.HeaderGridVisitHealthCarePaymentBimeh.TabIndex = 33;
            this.HeaderGridVisitHealthCarePaymentBimeh.Tag = "";
            this.HeaderGridVisitHealthCarePaymentBimeh.ThemeAware = true;
            this.HeaderGridVisitHealthCarePaymentBimeh.buttonItemInsertClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemInsertClickEventHandler(this.headerGridVisitHealthCarePaymentBimeh_btnInsertClick);
            this.HeaderGridVisitHealthCarePaymentBimeh.buttonItemEditClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemEditClickEventHandler(this.headerGridVisitHealthCarePaymentBimeh_btnEditClick);
            this.HeaderGridVisitHealthCarePaymentBimeh.buttonItemDeleteClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemDeleteClickEventHandler(this.headerGridVisitHealthCarePaymentBimeh_btnDeleteClick);
            this.HeaderGridVisitHealthCarePaymentBimeh.buttonItemRefreshClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemRefreshClickEventHandler(this.headerGridVisitHealthCarePaymentBimeh_btnRefreshClick);
            // 
            // buttonItemSendHealthCarePayment
            // 
            this.buttonItemSendHealthCarePayment.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemSendHealthCarePayment.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemSendHealthCarePayment.Icon = ((System.Drawing.Icon)(resources.GetObject("buttonItemSendHealthCarePayment.Icon")));
            this.buttonItemSendHealthCarePayment.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium;
            this.buttonItemSendHealthCarePayment.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemSendHealthCarePayment.Name = "buttonItemSendHealthCarePayment";
            this.buttonItemSendHealthCarePayment.Tag = "196";
            this.buttonItemSendHealthCarePayment.Text = "تایید و ارسال جهت مالی";
            this.buttonItemSendHealthCarePayment.ThemeAware = true;
            this.buttonItemSendHealthCarePayment.Click += new System.EventHandler(this.buttonItemSendHealthCarePayment_Click);
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
            this.mssPanel2.Location = new System.Drawing.Point(0, 521);
            this.mssPanel2.Name = "mssPanel2";
            this.mssPanel2.Size = new System.Drawing.Size(916, 58);
            this.mssPanel2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.mssPanel2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.mssPanel2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.mssPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.mssPanel2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.mssPanel2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.mssPanel2.Style.GradientAngle = 90;
            this.mssPanel2.TabIndex = 1;
            // 
            // RadioBoxContractWithTime
            // 
            this.RadioBoxContractWithTime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.RadioBoxContractWithTime.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.RadioBoxContractWithTime.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.RadioBoxContractWithTime.Location = new System.Drawing.Point(677, 29);
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
            this.RadioBoxPaymentStatus1.Location = new System.Drawing.Point(585, 6);
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
            this.RadioBoxPaymentStatusNot1.Location = new System.Drawing.Point(414, 6);
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
            this.RadioBoxAllContract.Location = new System.Drawing.Point(774, 6);
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
            this.DatePickerEnd.Location = new System.Drawing.Point(156, 29);
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
            this.comboItemHealthCareDate,
            this.comboItemContractDate,
            this.comboItemPaymentDate,
            this.comboItemLetterDate,
            this.comboItemInsuLetterDate,
            this.comboItemSecretiatDate,
            this.comboItemBonyadConfirmDate});
            this.ComboBoxSerach.Location = new System.Drawing.Point(498, 29);
            this.ComboBoxSerach.Name = "ComboBoxSerach";
            this.ComboBoxSerach.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ComboBoxSerach.Size = new System.Drawing.Size(135, 21);
            this.ComboBoxSerach.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ComboBoxSerach.TabIndex = 5;
            this.ComboBoxSerach.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSerach_SelectedIndexChanged);
            // 
            // comboItemHealthCareDate
            // 
            this.comboItemHealthCareDate.Text = "تاریح انجام بهیاری";
            // 
            // comboItemContractDate
            // 
            this.comboItemContractDate.Text = "تاریخ قرارداد";
            // 
            // comboItemPaymentDate
            // 
            this.comboItemPaymentDate.Text = "تاریخ ثبت در مالی";
            // 
            // comboItemLetterDate
            // 
            this.comboItemLetterDate.Text = "تاریخ نامه بنیاد";
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
            this.DatePickerStart.Location = new System.Drawing.Point(333, 29);
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
            this.mssLabel1.Location = new System.Drawing.Point(633, 31);
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
            this.mssLabel2.Location = new System.Drawing.Point(437, 29);
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
            this.mssLabel3.Location = new System.Drawing.Point(264, 29);
            this.mssLabel3.Name = "mssLabel3";
            this.mssLabel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mssLabel3.Size = new System.Drawing.Size(37, 16);
            this.mssLabel3.TabIndex = 0;
            this.mssLabel3.Text = "تا تاریخ:";
            // 
            // VisitHealthCarePaymentBimeh_UC
            // 
            this.Controls.Add(this.GridViewVisitHealthCarePaymentBimeh);
            this.Controls.Add(this.mssExpandableSplitter1);
            this.Controls.Add(this.serviceHealthCare_UC1);
            this.Controls.Add(this.mssPanel1);
            this.Controls.Add(this.HeaderGridVisitHealthCarePaymentBimeh);
            this.Controls.Add(this.mssPanel2);
            this.Name = "VisitHealthCarePaymentBimeh_UC";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(916, 579);
            this.Tag = "ارسال به بیمه بهیاری";
            this.Load += new System.EventHandler(this.VisitHealthCarePaymentBimeh_UC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewVisitHealthCarePaymentBimeh)).EndInit();
            this.ContextMenuStripStatus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vWVisitHealthCarePaymentBindingSource)).EndInit();
            this.mssPanel1.ResumeLayout(false);
            this.mssPanel1.PerformLayout();
            this.mssPanel2.ResumeLayout(false);
            this.mssPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource vWVisitHealthCarePaymentBindingSource;
        private MSSHeaderGrid HeaderGridVisitHealthCarePaymentBimeh;
        private MSSPanel mssPanel1;
        private MSSLabel label6;
        private MSSButton btnSetValueHealth;
        private MSSComboBox comboBoxSetValue;
        private DevComponents.Editors.ComboItem comboItemInsuLetterNo;
        private DevComponents.Editors.ComboItem comboItemCostReqInsuIran;
        private MSSIntBox nUpDownSetValue;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxPaymentStatus;
        private MSSDatePicker DatePickerSet;
        private MSSLabel mssLabel4;
        private MSSPanel mssPanel2;
        private MSSCheckBox RadioBoxAllContract;
        private MSSDatePicker DatePickerEnd;
        private MSSComboBox ComboBoxSerach;
        private DevComponents.Editors.ComboItem comboItemPaymentDate;
        private DevComponents.Editors.ComboItem comboItemLetterDate;
        private DevComponents.Editors.ComboItem comboItemContractDate;
        private DevComponents.Editors.ComboItem comboItemInsuLetterDate;
        private DevComponents.Editors.ComboItem comboItemSecretiatDate;
        private MSSDatePicker DatePickerStart;
        private MSSLabel mssLabel1;
        private MSSLabel mssLabel2;
        private MSSLabel mssLabel3;
        private MSSTextBox textBoxSetValue;
        private DevComponents.Editors.ComboItem comboItemHealthCareDate;
        private DevComponents.Editors.ComboItem comboItemBonyadConfirmDate;
        private MSSExpandableSplitter mssExpandableSplitter1;
        private ServiceHealthCare_UC serviceHealthCare_UC1;
        private MSSGridexView GridViewVisitHealthCarePaymentBimeh;
        private MSSCheckBox RadioBoxPaymentStatus1;
        private MSSCheckBox RadioBoxPaymentStatusNot1;
        private MSSCheckBox RadioBoxContractWithTime;
        private DevComponents.DotNetBar.ButtonItem buttonItemSendHealthCarePayment;
        private MSSContextMenuStrip ContextMenuStripStatus;
        private ToolStripMenuItem ToolStripMenuItemVisitHealthCarePaymentBimehLog;
        private ToolStripMenuItem ToolStripMenuItemVisitHealthCarePaymentBimehCurrentRow;
        private ToolStripMenuItem ToolStripMenuItemVisitHealthCarePaymentBimehAllList;
    }
}
