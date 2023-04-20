using System.Windows.Forms;
using MKH.Library.Control;

namespace PhysiotherapyCare.View.MainForms.VisitPatient
{
    partial class VisitPatientPaymentBimeh_UC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisitPatientPaymentBimeh_UC));
            Janus.Windows.GridEX.GridEXLayout GridViewVisitPatientPaymentBimeh_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.vWVisitPatientPaymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mssPanel1 = new MKH.Library.Control.MSSPanel(this.components);
            this.textBoxSetValue = new MKH.Library.Control.MSSTextBox(this.components);
            this.label6 = new MKH.Library.Control.MSSLabel(this.components);
            this.btnSetValueVisit = new MKH.Library.Control.MSSButton(this.components);
            this.DatePickerSet = new MKH.Library.Control.MSSDatePicker(this.components);
            this.comboBoxSetValue = new MKH.Library.Control.MSSComboBox();
            this.comboItemInsuLetterNo = new DevComponents.Editors.ComboItem();
            this.comboItemCostReqInsuIran = new DevComponents.Editors.ComboItem();
            this.nUpDownSetValue = new MKH.Library.Control.MSSIntBox(this.components);
            this.mssLabel4 = new MKH.Library.Control.MSSLabel(this.components);
            this.comboBoxPaymentStatus = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.HeaderGridVisitPatientPaymentBimeh = new MKH.Library.Control.MSSHeaderGrid();
            this.GridViewVisitPatientPaymentBimeh = new MKH.Library.Control.MSSGridexView();
            this.ContextMenuStripStatus = new MKH.Library.Control.MSSContextMenuStrip(this.components);
            this.ToolStripMenuItemVisitPatientPaymentBimehLog = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemVisitPatientPaymentBimehCurrentRow = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemVisitPatientPaymentBimehAllList = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonItemSendVisitPayment = new DevComponents.DotNetBar.ButtonItem();
            this.mssPanel2 = new MKH.Library.Control.MSSPanel(this.components);
            this.RadioBoxPaymentStatus1 = new MKH.Library.Control.MSSCheckBox(this.components);
            this.RadioBoxPaymentStatusNot1 = new MKH.Library.Control.MSSCheckBox(this.components);
            this.RadioBoxAllContract = new MKH.Library.Control.MSSCheckBox(this.components);
            this.DatePickerEnd = new MKH.Library.Control.MSSDatePicker(this.components);
            this.ComboBoxSerach = new MKH.Library.Control.MSSComboBox();
            this.comboItemPaymentDate = new DevComponents.Editors.ComboItem();
            this.comboItemLetterDate = new DevComponents.Editors.ComboItem();
            this.comboItemContractDate = new DevComponents.Editors.ComboItem();
            this.comboItemVisitDate = new DevComponents.Editors.ComboItem();
            this.comboItemInsuLetterDate = new DevComponents.Editors.ComboItem();
            this.comboItemSecretiatDate = new DevComponents.Editors.ComboItem();
            this.comboItemBonyadConfirmDate = new DevComponents.Editors.ComboItem();
            this.DatePickerStart = new MKH.Library.Control.MSSDatePicker(this.components);
            this.mssLabel5 = new MKH.Library.Control.MSSLabel(this.components);
            this.mssLabel1 = new MKH.Library.Control.MSSLabel(this.components);
            this.mssLabel2 = new MKH.Library.Control.MSSLabel(this.components);
            this.mssLabel3 = new MKH.Library.Control.MSSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.vWVisitPatientPaymentBindingSource)).BeginInit();
            this.mssPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewVisitPatientPaymentBimeh)).BeginInit();
            this.ContextMenuStripStatus.SuspendLayout();
            this.mssPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // vWVisitPatientPaymentBindingSource
            // 
            this.vWVisitPatientPaymentBindingSource.DataSource = typeof(PhysiotherapyCare.Model.VisitPatient.VW_VisitPatientPayment);
            // 
            // mssPanel1
            // 
            this.mssPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.mssPanel1.Controls.Add(this.textBoxSetValue);
            this.mssPanel1.Controls.Add(this.label6);
            this.mssPanel1.Controls.Add(this.btnSetValueVisit);
            this.mssPanel1.Controls.Add(this.DatePickerSet);
            this.mssPanel1.Controls.Add(this.comboBoxSetValue);
            this.mssPanel1.Controls.Add(this.nUpDownSetValue);
            this.mssPanel1.Controls.Add(this.mssLabel4);
            this.mssPanel1.Controls.Add(this.comboBoxPaymentStatus);
            this.mssPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mssPanel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.mssPanel1.Location = new System.Drawing.Point(0, 340);
            this.mssPanel1.Name = "mssPanel1";
            this.mssPanel1.Size = new System.Drawing.Size(985, 38);
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
            this.textBoxSetValue.Location = new System.Drawing.Point(127, 9);
            this.textBoxSetValue.MaxLength = 0;
            this.textBoxSetValue.Name = "textBoxSetValue";
            this.textBoxSetValue.Size = new System.Drawing.Size(173, 21);
            this.textBoxSetValue.TabIndex = 86;
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
            // btnSetValueVisit
            // 
            this.btnSetValueVisit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSetValueVisit.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnSetValueVisit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSetValueVisit.Location = new System.Drawing.Point(14, 4);
            this.btnSetValueVisit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSetValueVisit.Name = "btnSetValueVisit";
            this.btnSetValueVisit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSetValueVisit.Size = new System.Drawing.Size(94, 31);
            this.btnSetValueVisit.TabIndex = 80;
            this.btnSetValueVisit.Tag = "229";
            this.btnSetValueVisit.Text = "ثبت مقدار جدید\r\nردیفهای انتخابی";
            this.btnSetValueVisit.Click += new System.EventHandler(this.btnSetValue_Click);
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
            // HeaderGridVisitPatientPaymentBimeh
            // 
            // 
            // 
            // 
            this.HeaderGridVisitPatientPaymentBimeh.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridVisitPatientPaymentBimeh.BackgroundStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridVisitPatientPaymentBimeh.BackgroundStyle.BorderBottomWidth = 1;
            this.HeaderGridVisitPatientPaymentBimeh.BackgroundStyle.BorderLeftWidth = 1;
            this.HeaderGridVisitPatientPaymentBimeh.BackgroundStyle.BorderRightWidth = 1;
            this.HeaderGridVisitPatientPaymentBimeh.BackgroundStyle.BorderTopWidth = 1;
            this.HeaderGridVisitPatientPaymentBimeh.BackgroundStyle.Class = "ItemPanel";
            this.HeaderGridVisitPatientPaymentBimeh.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.HeaderGridVisitPatientPaymentBimeh.BackgroundStyle.PaddingBottom = 1;
            this.HeaderGridVisitPatientPaymentBimeh.BackgroundStyle.PaddingLeft = 1;
            this.HeaderGridVisitPatientPaymentBimeh.BackgroundStyle.PaddingRight = 1;
            this.HeaderGridVisitPatientPaymentBimeh.BackgroundStyle.PaddingTop = 1;
            this.HeaderGridVisitPatientPaymentBimeh.ButtonDeletePermissionCode = 224;
            this.HeaderGridVisitPatientPaymentBimeh.ButtonDeleteVisible = true;
            this.HeaderGridVisitPatientPaymentBimeh.ButtonEditPermissionCode = 223;
            this.HeaderGridVisitPatientPaymentBimeh.ButtonEditVisible = true;
            this.HeaderGridVisitPatientPaymentBimeh.ButtonExcelExportVisible = true;
            this.HeaderGridVisitPatientPaymentBimeh.ButtonExcelPermissionCode = 226;
            this.HeaderGridVisitPatientPaymentBimeh.ButtonInsertPermissionCode = 0;
            this.HeaderGridVisitPatientPaymentBimeh.ButtonInsertVisible = false;
            this.HeaderGridVisitPatientPaymentBimeh.ButtonPrintExpertPermissionCode = 0;
            this.HeaderGridVisitPatientPaymentBimeh.ButtonPrintExpertVisible = false;
            this.HeaderGridVisitPatientPaymentBimeh.ButtonPrintPermissionCode = 225;
            this.HeaderGridVisitPatientPaymentBimeh.ButtonPrintVisible = true;
            this.HeaderGridVisitPatientPaymentBimeh.ButtonPrintWithDesignPermissionCode = 227;
            this.HeaderGridVisitPatientPaymentBimeh.ButtonPrintWithDesignVisible = true;
            this.HeaderGridVisitPatientPaymentBimeh.ButtonRefreshVisible = true;
            this.HeaderGridVisitPatientPaymentBimeh.ButtonSearchExpertVisible = false;
            this.HeaderGridVisitPatientPaymentBimeh.ButtonSearchVisible = true;
            this.HeaderGridVisitPatientPaymentBimeh.ButtonSelectorVisible = true;
            this.HeaderGridVisitPatientPaymentBimeh.ContainerControlProcessDialogKey = true;
            this.HeaderGridVisitPatientPaymentBimeh.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderGridVisitPatientPaymentBimeh.FitButtonsToContainerWidth = true;
            this.HeaderGridVisitPatientPaymentBimeh.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.HeaderGridVisitPatientPaymentBimeh.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.HeaderGridVisitPatientPaymentBimeh.GridViewSet = this.GridViewVisitPatientPaymentBimeh;
            this.HeaderGridVisitPatientPaymentBimeh.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItemSendVisitPayment});
            this.HeaderGridVisitPatientPaymentBimeh.Location = new System.Drawing.Point(0, 0);
            this.HeaderGridVisitPatientPaymentBimeh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HeaderGridVisitPatientPaymentBimeh.Name = "HeaderGridVisitPatientPaymentBimeh";
            this.HeaderGridVisitPatientPaymentBimeh.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HeaderGridVisitPatientPaymentBimeh.Size = new System.Drawing.Size(985, 56);
            this.HeaderGridVisitPatientPaymentBimeh.TabIndex = 33;
            this.HeaderGridVisitPatientPaymentBimeh.Tag = "";
            this.HeaderGridVisitPatientPaymentBimeh.ThemeAware = true;
            this.HeaderGridVisitPatientPaymentBimeh.buttonItemEditClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemEditClickEventHandler(this.headerGridVisitPatientPaymentBimeh_btnEditClick);
            this.HeaderGridVisitPatientPaymentBimeh.buttonItemDeleteClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemDeleteClickEventHandler(this.headerGridVisitPatientPaymentBimeh_btnDeleteClick);
            this.HeaderGridVisitPatientPaymentBimeh.buttonItemRefreshClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemRefreshClickEventHandler(this.headerGridVisitPatientPaymentBimeh_btnRefreshClick);
            // 
            // GridViewVisitPatientPaymentBimeh
            // 
            this.GridViewVisitPatientPaymentBimeh.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.GridViewVisitPatientPaymentBimeh.AlternatingColors = true;
            this.GridViewVisitPatientPaymentBimeh.AlternatingRowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewVisitPatientPaymentBimeh.BuiltInTextsData = resources.GetString("GridViewVisitPatientPaymentBimeh.BuiltInTextsData");
            this.GridViewVisitPatientPaymentBimeh.CardViewGridlines = Janus.Windows.GridEX.CardViewGridlines.Both;
            this.GridViewVisitPatientPaymentBimeh.ContextMenuStrip = this.ContextMenuStripStatus;
            this.GridViewVisitPatientPaymentBimeh.DataSource = this.vWVisitPatientPaymentBindingSource;
            this.GridViewVisitPatientPaymentBimeh.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            GridViewVisitPatientPaymentBimeh_DesignTimeLayout.LayoutString = resources.GetString("GridViewVisitPatientPaymentBimeh_DesignTimeLayout.LayoutString");
            this.GridViewVisitPatientPaymentBimeh.DesignTimeLayout = GridViewVisitPatientPaymentBimeh_DesignTimeLayout;
            this.GridViewVisitPatientPaymentBimeh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewVisitPatientPaymentBimeh.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.GridViewVisitPatientPaymentBimeh.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.GridViewVisitPatientPaymentBimeh.Font = new System.Drawing.Font("Tahoma", 8.150944F);
            this.GridViewVisitPatientPaymentBimeh.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewVisitPatientPaymentBimeh.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
            this.GridViewVisitPatientPaymentBimeh.Location = new System.Drawing.Point(0, 56);
            this.GridViewVisitPatientPaymentBimeh.Name = "GridViewVisitPatientPaymentBimeh";
            this.GridViewVisitPatientPaymentBimeh.RecordNavigator = true;
            this.GridViewVisitPatientPaymentBimeh.RowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewVisitPatientPaymentBimeh.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition;
            this.GridViewVisitPatientPaymentBimeh.RowHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewVisitPatientPaymentBimeh.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.GridViewVisitPatientPaymentBimeh.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelection;
            this.GridViewVisitPatientPaymentBimeh.SettingsKey = "GridViewVisitPatientPaymentBimeh";
            this.GridViewVisitPatientPaymentBimeh.Size = new System.Drawing.Size(985, 284);
            this.GridViewVisitPatientPaymentBimeh.TabIndex = 39;
            this.GridViewVisitPatientPaymentBimeh.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.GridViewVisitPatientPaymentBimeh.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.GridViewVisitPatientPaymentBimeh.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010;
            this.GridViewVisitPatientPaymentBimeh.SelectionChanged += new System.EventHandler(this.GridViewVisitPatientPaymentBimeh_SelectionChanged);
            this.GridViewVisitPatientPaymentBimeh.DoubleClick += new System.EventHandler(this.headerGridVisitPatientPaymentBimeh_btnEditClick);
            // 
            // ContextMenuStripStatus
            // 
            this.ContextMenuStripStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemVisitPatientPaymentBimehLog});
            this.ContextMenuStripStatus.Name = "ContextMenuStripStatus";
            this.ContextMenuStripStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ContextMenuStripStatus.Size = new System.Drawing.Size(95, 26);
            // 
            // ToolStripMenuItemVisitPatientPaymentBimehLog
            // 
            this.ToolStripMenuItemVisitPatientPaymentBimehLog.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemVisitPatientPaymentBimehCurrentRow,
            this.ToolStripMenuItemVisitPatientPaymentBimehAllList});
            this.ToolStripMenuItemVisitPatientPaymentBimehLog.Name = "ToolStripMenuItemVisitPatientPaymentBimehLog";
            this.ToolStripMenuItemVisitPatientPaymentBimehLog.Size = new System.Drawing.Size(94, 22);
            this.ToolStripMenuItemVisitPatientPaymentBimehLog.Text = "Log";
            // 
            // ToolStripMenuItemVisitPatientPaymentBimehCurrentRow
            // 
            this.ToolStripMenuItemVisitPatientPaymentBimehCurrentRow.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripMenuItemVisitPatientPaymentBimehCurrentRow.Name = "ToolStripMenuItemVisitPatientPaymentBimehCurrentRow";
            this.ToolStripMenuItemVisitPatientPaymentBimehCurrentRow.Size = new System.Drawing.Size(140, 22);
            this.ToolStripMenuItemVisitPatientPaymentBimehCurrentRow.Tag = "262";
            this.ToolStripMenuItemVisitPatientPaymentBimehCurrentRow.Text = "سطر انتخابی";
            this.ToolStripMenuItemVisitPatientPaymentBimehCurrentRow.Click += new System.EventHandler(this.ToolStripMenuItemVisitPatientPaymentBimehCurrentRow_Click);
            // 
            // ToolStripMenuItemVisitPatientPaymentBimehAllList
            // 
            this.ToolStripMenuItemVisitPatientPaymentBimehAllList.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripMenuItemVisitPatientPaymentBimehAllList.Name = "ToolStripMenuItemVisitPatientPaymentBimehAllList";
            this.ToolStripMenuItemVisitPatientPaymentBimehAllList.Size = new System.Drawing.Size(140, 22);
            this.ToolStripMenuItemVisitPatientPaymentBimehAllList.Tag = "263";
            this.ToolStripMenuItemVisitPatientPaymentBimehAllList.Text = "کل لیست";
            this.ToolStripMenuItemVisitPatientPaymentBimehAllList.Click += new System.EventHandler(this.ToolStripMenuItemVisitPatientPaymentBimehAllList_Click);
            // 
            // buttonItemSendVisitPayment
            // 
            this.buttonItemSendVisitPayment.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemSendVisitPayment.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemSendVisitPayment.Icon = ((System.Drawing.Icon)(resources.GetObject("buttonItemSendVisitPayment.Icon")));
            this.buttonItemSendVisitPayment.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium;
            this.buttonItemSendVisitPayment.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemSendVisitPayment.Name = "buttonItemSendVisitPayment";
            this.buttonItemSendVisitPayment.Tag = "228";
            this.buttonItemSendVisitPayment.Text = "تایید و ارسال جهت مالی";
            this.buttonItemSendVisitPayment.ThemeAware = true;
            this.buttonItemSendVisitPayment.Click += new System.EventHandler(this.buttonItemSendPhysioterapyPayment_Click);
            // 
            // mssPanel2
            // 
            this.mssPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.mssPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.mssPanel2.Controls.Add(this.RadioBoxPaymentStatus1);
            this.mssPanel2.Controls.Add(this.RadioBoxPaymentStatusNot1);
            this.mssPanel2.Controls.Add(this.RadioBoxAllContract);
            this.mssPanel2.Controls.Add(this.DatePickerEnd);
            this.mssPanel2.Controls.Add(this.ComboBoxSerach);
            this.mssPanel2.Controls.Add(this.DatePickerStart);
            this.mssPanel2.Controls.Add(this.mssLabel5);
            this.mssPanel2.Controls.Add(this.mssLabel1);
            this.mssPanel2.Controls.Add(this.mssLabel2);
            this.mssPanel2.Controls.Add(this.mssLabel3);
            this.mssPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mssPanel2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.mssPanel2.Location = new System.Drawing.Point(0, 378);
            this.mssPanel2.Name = "mssPanel2";
            this.mssPanel2.Size = new System.Drawing.Size(985, 61);
            this.mssPanel2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.mssPanel2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.mssPanel2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.mssPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.mssPanel2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.mssPanel2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.mssPanel2.Style.GradientAngle = 90;
            this.mssPanel2.TabIndex = 1;
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
            this.RadioBoxPaymentStatus1.Location = new System.Drawing.Point(696, 9);
            this.RadioBoxPaymentStatus1.Name = "RadioBoxPaymentStatus1";
            this.RadioBoxPaymentStatus1.Size = new System.Drawing.Size(92, 17);
            this.RadioBoxPaymentStatus1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.RadioBoxPaymentStatus1.TabIndex = 2;
            this.RadioBoxPaymentStatus1.Text = "ارسال به بیمه";
            this.RadioBoxPaymentStatus1.TextColor = System.Drawing.Color.Black;
            this.RadioBoxPaymentStatus1.CheckedChanged += new System.EventHandler(this.RadioBoxAllContract_CheckedChanged);
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
            this.RadioBoxPaymentStatusNot1.Location = new System.Drawing.Point(525, 9);
            this.RadioBoxPaymentStatusNot1.Name = "RadioBoxPaymentStatusNot1";
            this.RadioBoxPaymentStatusNot1.Size = new System.Drawing.Size(129, 17);
            this.RadioBoxPaymentStatusNot1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.RadioBoxPaymentStatusNot1.TabIndex = 3;
            this.RadioBoxPaymentStatusNot1.Text = "تایید و ارسال به مالی";
            this.RadioBoxPaymentStatusNot1.TextColor = System.Drawing.Color.Black;
            this.RadioBoxPaymentStatusNot1.CheckedChanged += new System.EventHandler(this.RadioBoxAllContract_CheckedChanged);
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
            this.RadioBoxAllContract.Location = new System.Drawing.Point(832, 7);
            this.RadioBoxAllContract.Name = "RadioBoxAllContract";
            this.RadioBoxAllContract.Size = new System.Drawing.Size(72, 17);
            this.RadioBoxAllContract.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.RadioBoxAllContract.TabIndex = 1;
            this.RadioBoxAllContract.TabStop = false;
            this.RadioBoxAllContract.Text = "کل لیست";
            this.RadioBoxAllContract.TextColor = System.Drawing.Color.Black;
            this.RadioBoxAllContract.CheckedChanged += new System.EventHandler(this.RadioBoxAllContract_CheckedChanged);
            // 
            // DatePickerEnd
            // 
            this.DatePickerEnd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DatePickerEnd.BackColor = System.Drawing.Color.White;
            this.DatePickerEnd.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.DatePickerEnd.Location = new System.Drawing.Point(265, 32);
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
            this.comboItemVisitDate,
            this.comboItemInsuLetterDate,
            this.comboItemSecretiatDate,
            this.comboItemBonyadConfirmDate});
            this.ComboBoxSerach.Location = new System.Drawing.Point(583, 32);
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
            // comboItemVisitDate
            // 
            this.comboItemVisitDate.Text = "تاریخ ویزیت";
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
            this.DatePickerStart.Location = new System.Drawing.Point(421, 32);
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
            // mssLabel5
            // 
            this.mssLabel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mssLabel5.AutoSize = true;
            // 
            // 
            // 
            this.mssLabel5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mssLabel5.ForeColor = System.Drawing.Color.Black;
            this.mssLabel5.Location = new System.Drawing.Point(768, 34);
            this.mssLabel5.Name = "mssLabel5";
            this.mssLabel5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mssLabel5.Size = new System.Drawing.Size(128, 16);
            this.mssLabel5.TabIndex = 0;
            this.mssLabel5.Text = "قرادادها براساس بازه زمانی";
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
            this.mssLabel1.Location = new System.Drawing.Point(696, 34);
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
            this.mssLabel2.Location = new System.Drawing.Point(525, 32);
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
            this.mssLabel3.Location = new System.Drawing.Point(373, 32);
            this.mssLabel3.Name = "mssLabel3";
            this.mssLabel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mssLabel3.Size = new System.Drawing.Size(37, 16);
            this.mssLabel3.TabIndex = 0;
            this.mssLabel3.Text = "تا تاریخ:";
            // 
            // VisitPatientPaymentBimeh_UC
            // 
            this.Controls.Add(this.GridViewVisitPatientPaymentBimeh);
            this.Controls.Add(this.mssPanel1);
            this.Controls.Add(this.HeaderGridVisitPatientPaymentBimeh);
            this.Controls.Add(this.mssPanel2);
            this.Name = "VisitPatientPaymentBimeh_UC";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(985, 439);
            this.Tag = "لیست ارسالی به بیمه ویزیت";
            this.Load += new System.EventHandler(this.VisitPatientPaymentBimeh_UC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vWVisitPatientPaymentBindingSource)).EndInit();
            this.mssPanel1.ResumeLayout(false);
            this.mssPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewVisitPatientPaymentBimeh)).EndInit();
            this.ContextMenuStripStatus.ResumeLayout(false);
            this.mssPanel2.ResumeLayout(false);
            this.mssPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource vWVisitPatientPaymentBindingSource;
        private MSSHeaderGrid HeaderGridVisitPatientPaymentBimeh;
        private MSSPanel mssPanel1;
        private MSSLabel label6;
        private MSSButton btnSetValueVisit;
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
        private DevComponents.Editors.ComboItem comboItemVisitDate;
        private DevComponents.Editors.ComboItem comboItemInsuLetterDate;
        private DevComponents.Editors.ComboItem comboItemSecretiatDate;
        private MSSDatePicker DatePickerStart;
        private MSSLabel mssLabel1;
        private MSSLabel mssLabel2;
        private MSSLabel mssLabel3;
        private MSSTextBox textBoxSetValue;
        private DevComponents.Editors.ComboItem comboItemBonyadConfirmDate;
        private DevComponents.DotNetBar.ButtonItem buttonItemSendVisitPayment;
        private MSSCheckBox RadioBoxPaymentStatusNot1;
        private MSSCheckBox RadioBoxPaymentStatus1;
        private MSSGridexView GridViewVisitPatientPaymentBimeh;
        private MSSContextMenuStrip ContextMenuStripStatus;
        private ToolStripMenuItem ToolStripMenuItemVisitPatientPaymentBimehLog;
        private ToolStripMenuItem ToolStripMenuItemVisitPatientPaymentBimehCurrentRow;
        private ToolStripMenuItem ToolStripMenuItemVisitPatientPaymentBimehAllList;
        private MSSLabel mssLabel5;
    }
}
