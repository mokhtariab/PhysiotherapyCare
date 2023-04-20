using System.Windows.Forms;
using MKH.Library.Control;

namespace PhysiotherapyCare.View.MainForms.VisitPatientPhysiotherapy
{
    partial class VisitPatientPhysiotherapyPaymentBimeh_UC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisitPatientPhysiotherapyPaymentBimeh_UC));
            Janus.Windows.GridEX.GridEXLayout GridViewVisitPatientPhysiotherapyPaymentBimeh_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.vWVisitPatientPhysiotherapyPaymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mssPanel1 = new MKH.Library.Control.MSSPanel(this.components);
            this.textBoxSetValue = new MKH.Library.Control.MSSTextBox(this.components);
            this.label6 = new MKH.Library.Control.MSSLabel(this.components);
            this.btnSetValuePhysioterapy = new MKH.Library.Control.MSSButton(this.components);
            this.DatePickerSet = new MKH.Library.Control.MSSDatePicker(this.components);
            this.comboBoxSetValue = new MKH.Library.Control.MSSComboBox();
            this.comboItemInsuLetterNo = new DevComponents.Editors.ComboItem();
            this.comboItemCostReqInsuIran = new DevComponents.Editors.ComboItem();
            this.nUpDownSetValue = new MKH.Library.Control.MSSIntBox(this.components);
            this.mssLabel4 = new MKH.Library.Control.MSSLabel(this.components);
            this.comboBoxPaymentStatus = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.HeaderGridVisitPatientPhysiotherapyPaymentBimeh = new MKH.Library.Control.MSSHeaderGrid();
            this.GridViewVisitPatientPhysiotherapyPaymentBimeh = new MKH.Library.Control.MSSGridexView();
            this.ContextMenuStripStatus = new MKH.Library.Control.MSSContextMenuStrip(this.components);
            this.ToolStripMenuItemVisitPatientPhysiotherapyPaymentBimehLog = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemVisitPatientPhysiotherapyPaymentBimehCurrentRow = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemVisitPatientPhysiotherapyPaymentBimehAllList = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonItemSendPhysioterapyPayment = new DevComponents.DotNetBar.ButtonItem();
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
            ((System.ComponentModel.ISupportInitialize)(this.vWVisitPatientPhysiotherapyPaymentBindingSource)).BeginInit();
            this.mssPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewVisitPatientPhysiotherapyPaymentBimeh)).BeginInit();
            this.ContextMenuStripStatus.SuspendLayout();
            this.mssPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // vWVisitPatientPhysiotherapyPaymentBindingSource
            // 
            this.vWVisitPatientPhysiotherapyPaymentBindingSource.DataSource = typeof(PhysiotherapyCare.Model.VisitPatientPhysiotherapy.VW_VisitPatientPhysiotherapyPayment);
            // 
            // mssPanel1
            // 
            this.mssPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.mssPanel1.Controls.Add(this.textBoxSetValue);
            this.mssPanel1.Controls.Add(this.label6);
            this.mssPanel1.Controls.Add(this.btnSetValuePhysioterapy);
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
            this.mssPanel1.TabIndex = 1;
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
            this.textBoxSetValue.TabIndex = 3;
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
            // btnSetValuePhysioterapy
            // 
            this.btnSetValuePhysioterapy.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSetValuePhysioterapy.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnSetValuePhysioterapy.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSetValuePhysioterapy.Location = new System.Drawing.Point(14, 4);
            this.btnSetValuePhysioterapy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSetValuePhysioterapy.Name = "btnSetValuePhysioterapy";
            this.btnSetValuePhysioterapy.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSetValuePhysioterapy.Size = new System.Drawing.Size(94, 31);
            this.btnSetValuePhysioterapy.TabIndex = 4;
            this.btnSetValuePhysioterapy.Tag = "189";
            this.btnSetValuePhysioterapy.Text = "ثبت مقدار جدید\r\nردیفهای انتخابی";
            this.btnSetValuePhysioterapy.Click += new System.EventHandler(this.btnSetValue_Click);
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
            // nUpDownSetValue
            // 
            this.nUpDownSetValue.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.nUpDownSetValue.ForeColor = System.Drawing.Color.Black;
            this.nUpDownSetValue.Location = new System.Drawing.Point(158, 8);
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
            // HeaderGridVisitPatientPhysiotherapyPaymentBimeh
            // 
            // 
            // 
            // 
            this.HeaderGridVisitPatientPhysiotherapyPaymentBimeh.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridVisitPatientPhysiotherapyPaymentBimeh.BackgroundStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridVisitPatientPhysiotherapyPaymentBimeh.BackgroundStyle.BorderBottomWidth = 1;
            this.HeaderGridVisitPatientPhysiotherapyPaymentBimeh.BackgroundStyle.BorderLeftWidth = 1;
            this.HeaderGridVisitPatientPhysiotherapyPaymentBimeh.BackgroundStyle.BorderRightWidth = 1;
            this.HeaderGridVisitPatientPhysiotherapyPaymentBimeh.BackgroundStyle.BorderTopWidth = 1;
            this.HeaderGridVisitPatientPhysiotherapyPaymentBimeh.BackgroundStyle.Class = "ItemPanel";
            this.HeaderGridVisitPatientPhysiotherapyPaymentBimeh.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.HeaderGridVisitPatientPhysiotherapyPaymentBimeh.BackgroundStyle.PaddingBottom = 1;
            this.HeaderGridVisitPatientPhysiotherapyPaymentBimeh.BackgroundStyle.PaddingLeft = 1;
            this.HeaderGridVisitPatientPhysiotherapyPaymentBimeh.BackgroundStyle.PaddingRight = 1;
            this.HeaderGridVisitPatientPhysiotherapyPaymentBimeh.BackgroundStyle.PaddingTop = 1;
            this.HeaderGridVisitPatientPhysiotherapyPaymentBimeh.ButtonDeletePermissionCode = 184;
            this.HeaderGridVisitPatientPhysiotherapyPaymentBimeh.ButtonDeleteVisible = true;
            this.HeaderGridVisitPatientPhysiotherapyPaymentBimeh.ButtonEditPermissionCode = 183;
            this.HeaderGridVisitPatientPhysiotherapyPaymentBimeh.ButtonEditVisible = true;
            this.HeaderGridVisitPatientPhysiotherapyPaymentBimeh.ButtonExcelExportVisible = true;
            this.HeaderGridVisitPatientPhysiotherapyPaymentBimeh.ButtonExcelPermissionCode = 186;
            this.HeaderGridVisitPatientPhysiotherapyPaymentBimeh.ButtonInsertPermissionCode = 0;
            this.HeaderGridVisitPatientPhysiotherapyPaymentBimeh.ButtonInsertVisible = false;
            this.HeaderGridVisitPatientPhysiotherapyPaymentBimeh.ButtonPrintExpertPermissionCode = 0;
            this.HeaderGridVisitPatientPhysiotherapyPaymentBimeh.ButtonPrintExpertVisible = false;
            this.HeaderGridVisitPatientPhysiotherapyPaymentBimeh.ButtonPrintPermissionCode = 185;
            this.HeaderGridVisitPatientPhysiotherapyPaymentBimeh.ButtonPrintVisible = true;
            this.HeaderGridVisitPatientPhysiotherapyPaymentBimeh.ButtonPrintWithDesignPermissionCode = 187;
            this.HeaderGridVisitPatientPhysiotherapyPaymentBimeh.ButtonPrintWithDesignVisible = true;
            this.HeaderGridVisitPatientPhysiotherapyPaymentBimeh.ButtonRefreshVisible = true;
            this.HeaderGridVisitPatientPhysiotherapyPaymentBimeh.ButtonSearchExpertVisible = false;
            this.HeaderGridVisitPatientPhysiotherapyPaymentBimeh.ButtonSearchVisible = true;
            this.HeaderGridVisitPatientPhysiotherapyPaymentBimeh.ButtonSelectorVisible = true;
            this.HeaderGridVisitPatientPhysiotherapyPaymentBimeh.ContainerControlProcessDialogKey = true;
            this.HeaderGridVisitPatientPhysiotherapyPaymentBimeh.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderGridVisitPatientPhysiotherapyPaymentBimeh.FitButtonsToContainerWidth = true;
            this.HeaderGridVisitPatientPhysiotherapyPaymentBimeh.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.HeaderGridVisitPatientPhysiotherapyPaymentBimeh.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.HeaderGridVisitPatientPhysiotherapyPaymentBimeh.GridViewSet = this.GridViewVisitPatientPhysiotherapyPaymentBimeh;
            this.HeaderGridVisitPatientPhysiotherapyPaymentBimeh.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItemSendPhysioterapyPayment});
            this.HeaderGridVisitPatientPhysiotherapyPaymentBimeh.Location = new System.Drawing.Point(0, 0);
            this.HeaderGridVisitPatientPhysiotherapyPaymentBimeh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HeaderGridVisitPatientPhysiotherapyPaymentBimeh.Name = "HeaderGridVisitPatientPhysiotherapyPaymentBimeh";
            this.HeaderGridVisitPatientPhysiotherapyPaymentBimeh.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HeaderGridVisitPatientPhysiotherapyPaymentBimeh.Size = new System.Drawing.Size(985, 56);
            this.HeaderGridVisitPatientPhysiotherapyPaymentBimeh.TabIndex = 33;
            this.HeaderGridVisitPatientPhysiotherapyPaymentBimeh.Tag = "";
            this.HeaderGridVisitPatientPhysiotherapyPaymentBimeh.ThemeAware = true;
            this.HeaderGridVisitPatientPhysiotherapyPaymentBimeh.buttonItemEditClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemEditClickEventHandler(this.headerGridVisitPatientPhysiotherapyPaymentBimeh_btnEditClick);
            this.HeaderGridVisitPatientPhysiotherapyPaymentBimeh.buttonItemDeleteClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemDeleteClickEventHandler(this.headerGridVisitPatientPhysiotherapyPaymentBimeh_btnDeleteClick);
            this.HeaderGridVisitPatientPhysiotherapyPaymentBimeh.buttonItemRefreshClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemRefreshClickEventHandler(this.headerGridVisitPatientPhysiotherapyPaymentBimeh_btnRefreshClick);
            // 
            // GridViewVisitPatientPhysiotherapyPaymentBimeh
            // 
            this.GridViewVisitPatientPhysiotherapyPaymentBimeh.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.GridViewVisitPatientPhysiotherapyPaymentBimeh.AlternatingColors = true;
            this.GridViewVisitPatientPhysiotherapyPaymentBimeh.AlternatingRowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewVisitPatientPhysiotherapyPaymentBimeh.BuiltInTextsData = resources.GetString("GridViewVisitPatientPhysiotherapyPaymentBimeh.BuiltInTextsData");
            this.GridViewVisitPatientPhysiotherapyPaymentBimeh.CardViewGridlines = Janus.Windows.GridEX.CardViewGridlines.Both;
            this.GridViewVisitPatientPhysiotherapyPaymentBimeh.ContextMenuStrip = this.ContextMenuStripStatus;
            this.GridViewVisitPatientPhysiotherapyPaymentBimeh.DataSource = this.vWVisitPatientPhysiotherapyPaymentBindingSource;
            this.GridViewVisitPatientPhysiotherapyPaymentBimeh.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            GridViewVisitPatientPhysiotherapyPaymentBimeh_DesignTimeLayout.LayoutString = resources.GetString("GridViewVisitPatientPhysiotherapyPaymentBimeh_DesignTimeLayout.LayoutString");
            this.GridViewVisitPatientPhysiotherapyPaymentBimeh.DesignTimeLayout = GridViewVisitPatientPhysiotherapyPaymentBimeh_DesignTimeLayout;
            this.GridViewVisitPatientPhysiotherapyPaymentBimeh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewVisitPatientPhysiotherapyPaymentBimeh.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.GridViewVisitPatientPhysiotherapyPaymentBimeh.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.GridViewVisitPatientPhysiotherapyPaymentBimeh.Font = new System.Drawing.Font("Tahoma", 8.150944F);
            this.GridViewVisitPatientPhysiotherapyPaymentBimeh.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewVisitPatientPhysiotherapyPaymentBimeh.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
            this.GridViewVisitPatientPhysiotherapyPaymentBimeh.Location = new System.Drawing.Point(0, 56);
            this.GridViewVisitPatientPhysiotherapyPaymentBimeh.Name = "GridViewVisitPatientPhysiotherapyPaymentBimeh";
            this.GridViewVisitPatientPhysiotherapyPaymentBimeh.RecordNavigator = true;
            this.GridViewVisitPatientPhysiotherapyPaymentBimeh.RowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewVisitPatientPhysiotherapyPaymentBimeh.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition;
            this.GridViewVisitPatientPhysiotherapyPaymentBimeh.RowHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewVisitPatientPhysiotherapyPaymentBimeh.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.GridViewVisitPatientPhysiotherapyPaymentBimeh.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelection;
            this.GridViewVisitPatientPhysiotherapyPaymentBimeh.Size = new System.Drawing.Size(985, 284);
            this.GridViewVisitPatientPhysiotherapyPaymentBimeh.TabIndex = 87;
            this.GridViewVisitPatientPhysiotherapyPaymentBimeh.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.GridViewVisitPatientPhysiotherapyPaymentBimeh.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.GridViewVisitPatientPhysiotherapyPaymentBimeh.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010;
            this.GridViewVisitPatientPhysiotherapyPaymentBimeh.SelectionChanged += new System.EventHandler(this.GridViewVisitPatientPhysiotherapyPaymentBimeh_SelectionChanged);
            this.GridViewVisitPatientPhysiotherapyPaymentBimeh.DoubleClick += new System.EventHandler(this.headerGridVisitPatientPhysiotherapyPaymentBimeh_btnEditClick);
            // 
            // ContextMenuStripStatus
            // 
            this.ContextMenuStripStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemVisitPatientPhysiotherapyPaymentBimehLog});
            this.ContextMenuStripStatus.Name = "ContextMenuStripStatus";
            this.ContextMenuStripStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ContextMenuStripStatus.Size = new System.Drawing.Size(95, 26);
            // 
            // ToolStripMenuItemVisitPatientPhysiotherapyPaymentBimehLog
            // 
            this.ToolStripMenuItemVisitPatientPhysiotherapyPaymentBimehLog.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemVisitPatientPhysiotherapyPaymentBimehCurrentRow,
            this.ToolStripMenuItemVisitPatientPhysiotherapyPaymentBimehAllList});
            this.ToolStripMenuItemVisitPatientPhysiotherapyPaymentBimehLog.Name = "ToolStripMenuItemVisitPatientPhysiotherapyPaymentBimehLog";
            this.ToolStripMenuItemVisitPatientPhysiotherapyPaymentBimehLog.Size = new System.Drawing.Size(94, 22);
            this.ToolStripMenuItemVisitPatientPhysiotherapyPaymentBimehLog.Text = "Log";
            // 
            // ToolStripMenuItemVisitPatientPhysiotherapyPaymentBimehCurrentRow
            // 
            this.ToolStripMenuItemVisitPatientPhysiotherapyPaymentBimehCurrentRow.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripMenuItemVisitPatientPhysiotherapyPaymentBimehCurrentRow.Name = "ToolStripMenuItemVisitPatientPhysiotherapyPaymentBimehCurrentRow";
            this.ToolStripMenuItemVisitPatientPhysiotherapyPaymentBimehCurrentRow.Size = new System.Drawing.Size(140, 22);
            this.ToolStripMenuItemVisitPatientPhysiotherapyPaymentBimehCurrentRow.Tag = "281";
            this.ToolStripMenuItemVisitPatientPhysiotherapyPaymentBimehCurrentRow.Text = "سطر انتخابی";
            this.ToolStripMenuItemVisitPatientPhysiotherapyPaymentBimehCurrentRow.Click += new System.EventHandler(this.ToolStripMenuItemVisitPatientPhysiotherapyPaymentBimehCurrentRow_Click);
            // 
            // ToolStripMenuItemVisitPatientPhysiotherapyPaymentBimehAllList
            // 
            this.ToolStripMenuItemVisitPatientPhysiotherapyPaymentBimehAllList.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripMenuItemVisitPatientPhysiotherapyPaymentBimehAllList.Name = "ToolStripMenuItemVisitPatientPhysiotherapyPaymentBimehAllList";
            this.ToolStripMenuItemVisitPatientPhysiotherapyPaymentBimehAllList.Size = new System.Drawing.Size(140, 22);
            this.ToolStripMenuItemVisitPatientPhysiotherapyPaymentBimehAllList.Tag = "282";
            this.ToolStripMenuItemVisitPatientPhysiotherapyPaymentBimehAllList.Text = "کل لیست";
            this.ToolStripMenuItemVisitPatientPhysiotherapyPaymentBimehAllList.Click += new System.EventHandler(this.ToolStripMenuItemVisitPatientPhysiotherapyPaymentBimehAllList_Click);
            // 
            // buttonItemSendPhysioterapyPayment
            // 
            this.buttonItemSendPhysioterapyPayment.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemSendPhysioterapyPayment.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemSendPhysioterapyPayment.Icon = ((System.Drawing.Icon)(resources.GetObject("buttonItemSendPhysioterapyPayment.Icon")));
            this.buttonItemSendPhysioterapyPayment.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium;
            this.buttonItemSendPhysioterapyPayment.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemSendPhysioterapyPayment.Name = "buttonItemSendPhysioterapyPayment";
            this.buttonItemSendPhysioterapyPayment.Tag = "188";
            this.buttonItemSendPhysioterapyPayment.Text = "تایید و ارسال جهت مالی";
            this.buttonItemSendPhysioterapyPayment.ThemeAware = true;
            this.buttonItemSendPhysioterapyPayment.Click += new System.EventHandler(this.buttonItemSendPhysioterapyPayment_Click);
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
            this.RadioBoxContractWithTime.Location = new System.Drawing.Point(735, 30);
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
            this.RadioBoxPaymentStatus1.Location = new System.Drawing.Point(696, 9);
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
            this.RadioBoxPaymentStatusNot1.Location = new System.Drawing.Point(525, 9);
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
            this.RadioBoxAllContract.Location = new System.Drawing.Point(832, 7);
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
            this.comboItemBeginDate,
            this.comboItemEndDate,
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
            // comboItemBeginDate
            // 
            this.comboItemBeginDate.Text = "تاریخ شروع فیزیوتراپی";
            // 
            // comboItemEndDate
            // 
            this.comboItemEndDate.Text = "تاریح پایان فیزیوتراپی";
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
            // VisitPatientPhysiotherapyPaymentBimeh_UC
            // 
            this.Controls.Add(this.GridViewVisitPatientPhysiotherapyPaymentBimeh);
            this.Controls.Add(this.mssPanel1);
            this.Controls.Add(this.HeaderGridVisitPatientPhysiotherapyPaymentBimeh);
            this.Controls.Add(this.mssPanel2);
            this.Name = "VisitPatientPhysiotherapyPaymentBimeh_UC";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(985, 439);
            this.Tag = "لیست ارسالی به بیمه فیزیوتراپی";
            this.Load += new System.EventHandler(this.VisitPatientPhysiotherapyPaymentBimeh_UC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vWVisitPatientPhysiotherapyPaymentBindingSource)).EndInit();
            this.mssPanel1.ResumeLayout(false);
            this.mssPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewVisitPatientPhysiotherapyPaymentBimeh)).EndInit();
            this.ContextMenuStripStatus.ResumeLayout(false);
            this.mssPanel2.ResumeLayout(false);
            this.mssPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource vWVisitPatientPhysiotherapyPaymentBindingSource;
        private MSSHeaderGrid HeaderGridVisitPatientPhysiotherapyPaymentBimeh;
        private MSSPanel mssPanel1;
        private MSSLabel label6;
        private MSSButton btnSetValuePhysioterapy;
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
        private DevComponents.Editors.ComboItem comboItemBeginDate;
        private DevComponents.Editors.ComboItem comboItemEndDate;
        private DevComponents.Editors.ComboItem comboItemInsuLetterDate;
        private DevComponents.Editors.ComboItem comboItemSecretiatDate;
        private MSSDatePicker DatePickerStart;
        private MSSLabel mssLabel1;
        private MSSLabel mssLabel2;
        private MSSLabel mssLabel3;
        private MSSTextBox textBoxSetValue;
        private DevComponents.Editors.ComboItem comboItemBonyadConfirmDate;
        private MSSGridexView GridViewVisitPatientPhysiotherapyPaymentBimeh;
        private DevComponents.DotNetBar.ButtonItem buttonItemSendPhysioterapyPayment;
        private MSSCheckBox RadioBoxPaymentStatusNot1;
        private MSSCheckBox RadioBoxPaymentStatus1;
        private MSSCheckBox RadioBoxContractWithTime;
        private MSSContextMenuStrip ContextMenuStripStatus;
        private ToolStripMenuItem ToolStripMenuItemVisitPatientPhysiotherapyPaymentBimehLog;
        private ToolStripMenuItem ToolStripMenuItemVisitPatientPhysiotherapyPaymentBimehCurrentRow;
        private ToolStripMenuItem ToolStripMenuItemVisitPatientPhysiotherapyPaymentBimehAllList;
    }
}
