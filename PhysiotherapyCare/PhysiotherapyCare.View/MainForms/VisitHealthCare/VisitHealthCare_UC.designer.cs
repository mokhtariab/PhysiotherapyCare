using MKH.Library.Control;

namespace PhysiotherapyCare.View.MainForms.VisitHealthCare
{
    partial class VisitHealthCare_UC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisitHealthCare_UC));
            Janus.Windows.GridEX.GridEXLayout GridViewVisitHealthCare_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.tabControlPanel1 = new DevComponents.DotNetBar.TabControlPanel();
            this.serviceHealthCare_UC1 = new PhysiotherapyCare.View.MainForms.VisitHealthCare.ServiceHealthCare_UC();
            this.mssExpandableSplitter1 = new MKH.Library.Control.MSSExpandableSplitter(this.components);
            this.GridViewVisitHealthCare = new MKH.Library.Control.MSSGridexView();
            this.ContextMenuStripStatus = new MKH.Library.Control.MSSContextMenuStrip(this.components);
            this.ToolStripMenuItemStatusHealth = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemVisitHealthCareLog = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemVisitHealthCareCurrentRow = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemVisitHealthCareAllList = new System.Windows.Forms.ToolStripMenuItem();
            this.vWVisitHealthCareBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HeaderGridVisitHealthCare = new MKH.Library.Control.MSSHeaderGrid();
            this.buttonItemSendSMS = new DevComponents.DotNetBar.ButtonItem();
            this.itemContainer2 = new DevComponents.DotNetBar.ItemContainer();
            this.buttonItemSendHealthPayment = new DevComponents.DotNetBar.ButtonItem();
            this.itemContainer1 = new DevComponents.DotNetBar.ItemContainer();
            this.buttonItemFiling = new DevComponents.DotNetBar.ButtonItem();
            this.mssPanel1 = new MKH.Library.Control.MSSPanel(this.components);
            this.ButtonReciveFileDate = new MKH.Library.Control.MSSButton(this.components);
            this.RadioBoxVisitStatus4 = new MKH.Library.Control.MSSCheckBox(this.components);
            this.RadioBoxVisitStatus2 = new MKH.Library.Control.MSSCheckBox(this.components);
            this.RadioBoxAllContract = new MKH.Library.Control.MSSCheckBox(this.components);
            this.RadioBoxContractWithTime = new MKH.Library.Control.MSSCheckBox(this.components);
            this.RadioBoxVisitStatus1 = new MKH.Library.Control.MSSCheckBox(this.components);
            this.DatePickerReciveFileDate = new MKH.Library.Control.MSSDatePicker(this.components);
            this.DatePickerEnd = new MKH.Library.Control.MSSDatePicker(this.components);
            this.DatePickerStart = new MKH.Library.Control.MSSDatePicker(this.components);
            this.ComboBoxSerach = new MKH.Library.Control.MSSComboBox();
            this.comboItemLetterDate = new DevComponents.Editors.ComboItem();
            this.comboItemContractDate = new DevComponents.Editors.ComboItem();
            this.comboItemRequestDate = new DevComponents.Editors.ComboItem();
            this.comboItemHealthCareDate = new DevComponents.Editors.ComboItem();
            this.mssLabel4 = new MKH.Library.Control.MSSLabel(this.components);
            this.mssLabel3 = new MKH.Library.Control.MSSLabel(this.components);
            this.mssLabel2 = new MKH.Library.Control.MSSLabel(this.components);
            this.mssLabel1 = new MKH.Library.Control.MSSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewVisitHealthCare)).BeginInit();
            this.ContextMenuStripStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vWVisitHealthCareBindingSource)).BeginInit();
            this.mssPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlPanel1
            // 
            this.tabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel1.Location = new System.Drawing.Point(0, 26);
            this.tabControlPanel1.Name = "tabControlPanel1";
            this.tabControlPanel1.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel1.Size = new System.Drawing.Size(819, 211);
            this.tabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(254)))));
            this.tabControlPanel1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(188)))), ((int)(((byte)(227)))));
            this.tabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.tabControlPanel1.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel1.Style.GradientAngle = 90;
            this.tabControlPanel1.TabIndex = 3;
            // 
            // serviceHealthCare_UC1
            // 
            this.serviceHealthCare_UC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serviceHealthCare_UC1.Location = new System.Drawing.Point(0, 407);
            this.serviceHealthCare_UC1.Name = "serviceHealthCare_UC1";
            this.serviceHealthCare_UC1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.serviceHealthCare_UC1.Size = new System.Drawing.Size(1059, 109);
            this.serviceHealthCare_UC1.TabIndex = 38;
            this.serviceHealthCare_UC1.Tag = "لیست بهیاری ها";
            // 
            // mssExpandableSplitter1
            // 
            this.mssExpandableSplitter1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.mssExpandableSplitter1.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.mssExpandableSplitter1.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.mssExpandableSplitter1.Dock = System.Windows.Forms.DockStyle.Top;
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
            this.mssExpandableSplitter1.Location = new System.Drawing.Point(0, 401);
            this.mssExpandableSplitter1.Name = "mssExpandableSplitter1";
            this.mssExpandableSplitter1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mssExpandableSplitter1.Size = new System.Drawing.Size(1059, 6);
            this.mssExpandableSplitter1.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007;
            this.mssExpandableSplitter1.TabIndex = 39;
            this.mssExpandableSplitter1.TabStop = false;
            // 
            // GridViewVisitHealthCare
            // 
            this.GridViewVisitHealthCare.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.GridViewVisitHealthCare.AlternatingRowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewVisitHealthCare.BuiltInTextsData = resources.GetString("GridViewVisitHealthCare.BuiltInTextsData");
            this.GridViewVisitHealthCare.CardViewGridlines = Janus.Windows.GridEX.CardViewGridlines.Both;
            this.GridViewVisitHealthCare.ContextMenuStrip = this.ContextMenuStripStatus;
            this.GridViewVisitHealthCare.DataSource = this.vWVisitHealthCareBindingSource;
            this.GridViewVisitHealthCare.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            GridViewVisitHealthCare_DesignTimeLayout.LayoutString = resources.GetString("GridViewVisitHealthCare_DesignTimeLayout.LayoutString");
            this.GridViewVisitHealthCare.DesignTimeLayout = GridViewVisitHealthCare_DesignTimeLayout;
            this.GridViewVisitHealthCare.Dock = System.Windows.Forms.DockStyle.Top;
            this.GridViewVisitHealthCare.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.GridViewVisitHealthCare.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.GridViewVisitHealthCare.Font = new System.Drawing.Font("Tahoma", 8.150944F);
            this.GridViewVisitHealthCare.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewVisitHealthCare.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
            this.GridViewVisitHealthCare.Location = new System.Drawing.Point(0, 56);
            this.GridViewVisitHealthCare.Name = "GridViewVisitHealthCare";
            this.GridViewVisitHealthCare.RecordNavigator = true;
            this.GridViewVisitHealthCare.RowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewVisitHealthCare.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition;
            this.GridViewVisitHealthCare.RowHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewVisitHealthCare.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.GridViewVisitHealthCare.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelection;
            this.GridViewVisitHealthCare.SettingsKey = "GridViewVisitHealthCare";
            this.GridViewVisitHealthCare.Size = new System.Drawing.Size(1059, 345);
            this.GridViewVisitHealthCare.TabIndex = 33;
            this.GridViewVisitHealthCare.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.GridViewVisitHealthCare.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.GridViewVisitHealthCare.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010;
            this.GridViewVisitHealthCare.SelectionChanged += new System.EventHandler(this.GridViewVisitHealthCare_SelectionChanged);
            this.GridViewVisitHealthCare.DoubleClick += new System.EventHandler(this.headerGridVisitHealthCare_btnEditClick);
            // 
            // ContextMenuStripStatus
            // 
            this.ContextMenuStripStatus.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContextMenuStripStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemStatusHealth,
            this.ToolStripMenuItemVisitHealthCareLog});
            this.ContextMenuStripStatus.Name = "ContextMenuStripStatus";
            this.ContextMenuStripStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ContextMenuStripStatus.Size = new System.Drawing.Size(150, 48);
            // 
            // ToolStripMenuItemStatusHealth
            // 
            this.ToolStripMenuItemStatusHealth.Name = "ToolStripMenuItemStatusHealth";
            this.ToolStripMenuItemStatusHealth.Size = new System.Drawing.Size(149, 22);
            this.ToolStripMenuItemStatusHealth.Tag = "135";
            this.ToolStripMenuItemStatusHealth.Text = "بررسی وضعیت";
            this.ToolStripMenuItemStatusHealth.Click += new System.EventHandler(this.ToolStripMenuItemStatus_Click);
            // 
            // ToolStripMenuItemVisitHealthCareLog
            // 
            this.ToolStripMenuItemVisitHealthCareLog.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemVisitHealthCareCurrentRow,
            this.ToolStripMenuItemVisitHealthCareAllList});
            this.ToolStripMenuItemVisitHealthCareLog.Name = "ToolStripMenuItemVisitHealthCareLog";
            this.ToolStripMenuItemVisitHealthCareLog.Size = new System.Drawing.Size(149, 22);
            this.ToolStripMenuItemVisitHealthCareLog.Text = "Log";
            // 
            // ToolStripMenuItemVisitHealthCareCurrentRow
            // 
            this.ToolStripMenuItemVisitHealthCareCurrentRow.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripMenuItemVisitHealthCareCurrentRow.Name = "ToolStripMenuItemVisitHealthCareCurrentRow";
            this.ToolStripMenuItemVisitHealthCareCurrentRow.Size = new System.Drawing.Size(140, 22);
            this.ToolStripMenuItemVisitHealthCareCurrentRow.Tag = "264";
            this.ToolStripMenuItemVisitHealthCareCurrentRow.Text = "سطر انتخابی";
            this.ToolStripMenuItemVisitHealthCareCurrentRow.Click += new System.EventHandler(this.ToolStripMenuItemVisitHealthCareCurrentRow_Click);
            // 
            // ToolStripMenuItemVisitHealthCareAllList
            // 
            this.ToolStripMenuItemVisitHealthCareAllList.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripMenuItemVisitHealthCareAllList.Name = "ToolStripMenuItemVisitHealthCareAllList";
            this.ToolStripMenuItemVisitHealthCareAllList.Size = new System.Drawing.Size(140, 22);
            this.ToolStripMenuItemVisitHealthCareAllList.Tag = "265";
            this.ToolStripMenuItemVisitHealthCareAllList.Text = "کل لیست";
            this.ToolStripMenuItemVisitHealthCareAllList.Click += new System.EventHandler(this.ToolStripMenuItemVisitHealthCareAllList_Click);
            // 
            // vWVisitHealthCareBindingSource
            // 
            this.vWVisitHealthCareBindingSource.DataSource = typeof(PhysiotherapyCare.Model.VisitHealthCare.VW_VisitHealthCare);
            // 
            // HeaderGridVisitHealthCare
            // 
            // 
            // 
            // 
            this.HeaderGridVisitHealthCare.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridVisitHealthCare.BackgroundStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridVisitHealthCare.BackgroundStyle.BorderBottomWidth = 1;
            this.HeaderGridVisitHealthCare.BackgroundStyle.BorderLeftWidth = 1;
            this.HeaderGridVisitHealthCare.BackgroundStyle.BorderRightWidth = 1;
            this.HeaderGridVisitHealthCare.BackgroundStyle.BorderTopWidth = 1;
            this.HeaderGridVisitHealthCare.BackgroundStyle.Class = "ItemPanel";
            this.HeaderGridVisitHealthCare.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.HeaderGridVisitHealthCare.BackgroundStyle.PaddingBottom = 1;
            this.HeaderGridVisitHealthCare.BackgroundStyle.PaddingLeft = 1;
            this.HeaderGridVisitHealthCare.BackgroundStyle.PaddingRight = 1;
            this.HeaderGridVisitHealthCare.BackgroundStyle.PaddingTop = 1;
            this.HeaderGridVisitHealthCare.ButtonDeletePermissionCode = 131;
            this.HeaderGridVisitHealthCare.ButtonDeleteVisible = true;
            this.HeaderGridVisitHealthCare.ButtonEditPermissionCode = 130;
            this.HeaderGridVisitHealthCare.ButtonEditVisible = true;
            this.HeaderGridVisitHealthCare.ButtonExcelExportVisible = true;
            this.HeaderGridVisitHealthCare.ButtonExcelPermissionCode = 133;
            this.HeaderGridVisitHealthCare.ButtonInsertPermissionCode = 129;
            this.HeaderGridVisitHealthCare.ButtonInsertVisible = true;
            this.HeaderGridVisitHealthCare.ButtonPrintExpertPermissionCode = 0;
            this.HeaderGridVisitHealthCare.ButtonPrintExpertVisible = false;
            this.HeaderGridVisitHealthCare.ButtonPrintPermissionCode = 132;
            this.HeaderGridVisitHealthCare.ButtonPrintVisible = true;
            this.HeaderGridVisitHealthCare.ButtonPrintWithDesignPermissionCode = 136;
            this.HeaderGridVisitHealthCare.ButtonPrintWithDesignVisible = true;
            this.HeaderGridVisitHealthCare.ButtonRefreshVisible = true;
            this.HeaderGridVisitHealthCare.ButtonSearchExpertVisible = false;
            this.HeaderGridVisitHealthCare.ButtonSearchVisible = true;
            this.HeaderGridVisitHealthCare.ButtonSelectorVisible = true;
            this.HeaderGridVisitHealthCare.ContainerControlProcessDialogKey = true;
            this.HeaderGridVisitHealthCare.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderGridVisitHealthCare.FitButtonsToContainerWidth = true;
            this.HeaderGridVisitHealthCare.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.HeaderGridVisitHealthCare.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.HeaderGridVisitHealthCare.GridViewSet = this.GridViewVisitHealthCare;
            this.HeaderGridVisitHealthCare.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItemSendSMS,
            this.itemContainer2,
            this.buttonItemSendHealthPayment,
            this.itemContainer1,
            this.buttonItemFiling});
            this.HeaderGridVisitHealthCare.Location = new System.Drawing.Point(0, 0);
            this.HeaderGridVisitHealthCare.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HeaderGridVisitHealthCare.Name = "HeaderGridVisitHealthCare";
            this.HeaderGridVisitHealthCare.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HeaderGridVisitHealthCare.Size = new System.Drawing.Size(1059, 56);
            this.HeaderGridVisitHealthCare.TabIndex = 31;
            this.HeaderGridVisitHealthCare.Tag = "پزشکان";
            this.HeaderGridVisitHealthCare.Text = "پزشکان";
            this.HeaderGridVisitHealthCare.ThemeAware = true;
            this.HeaderGridVisitHealthCare.buttonItemInsertClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemInsertClickEventHandler(this.headerGridVisitHealthCare_btnInsertClick);
            this.HeaderGridVisitHealthCare.buttonItemEditClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemEditClickEventHandler(this.headerGridVisitHealthCare_btnEditClick);
            this.HeaderGridVisitHealthCare.buttonItemDeleteClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemDeleteClickEventHandler(this.headerGridVisitHealthCare_btnDeleteClick);
            this.HeaderGridVisitHealthCare.buttonItemRefreshClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemRefreshClickEventHandler(this.headerGridVisitHealthCare_btnRefreshClick);
            // 
            // buttonItemSendSMS
            // 
            this.buttonItemSendSMS.BeginGroup = true;
            this.buttonItemSendSMS.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemSendSMS.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemSendSMS.Image = ((System.Drawing.Image)(resources.GetObject("buttonItemSendSMS.Image")));
            this.buttonItemSendSMS.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium;
            this.buttonItemSendSMS.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemSendSMS.Name = "buttonItemSendSMS";
            this.buttonItemSendSMS.Tag = "206";
            this.buttonItemSendSMS.Text = "SMS ارسال";
            this.buttonItemSendSMS.ThemeAware = true;
            this.buttonItemSendSMS.Click += new System.EventHandler(this.buttonItemSendSMS_Click);
            // 
            // itemContainer2
            // 
            // 
            // 
            // 
            this.itemContainer2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer2.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer2.Name = "itemContainer2";
            this.itemContainer2.ThemeAware = true;
            // 
            // buttonItemSendHealthPayment
            // 
            this.buttonItemSendHealthPayment.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemSendHealthPayment.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemSendHealthPayment.Icon = ((System.Drawing.Icon)(resources.GetObject("buttonItemSendHealthPayment.Icon")));
            this.buttonItemSendHealthPayment.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium;
            this.buttonItemSendHealthPayment.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemSendHealthPayment.Name = "buttonItemSendHealthPayment";
            this.buttonItemSendHealthPayment.Tag = "137";
            this.buttonItemSendHealthPayment.Text = "تایید و ارسال به بیمه";
            this.buttonItemSendHealthPayment.ThemeAware = true;
            this.buttonItemSendHealthPayment.Click += new System.EventHandler(this.buttonItemSendPhysioterapyPayment_Click);
            // 
            // itemContainer1
            // 
            // 
            // 
            // 
            this.itemContainer1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer1.Name = "itemContainer1";
            this.itemContainer1.ThemeAware = true;
            // 
            // buttonItemFiling
            // 
            this.buttonItemFiling.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemFiling.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemFiling.Icon = ((System.Drawing.Icon)(resources.GetObject("buttonItemFiling.Icon")));
            this.buttonItemFiling.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium;
            this.buttonItemFiling.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemFiling.Name = "buttonItemFiling";
            this.buttonItemFiling.Tag = "134";
            this.buttonItemFiling.Text = "فایل های بهیاری";
            this.buttonItemFiling.ThemeAware = true;
            this.buttonItemFiling.Click += new System.EventHandler(this.buttonItemFiling_Click);
            // 
            // mssPanel1
            // 
            this.mssPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.mssPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.mssPanel1.Controls.Add(this.ButtonReciveFileDate);
            this.mssPanel1.Controls.Add(this.RadioBoxVisitStatus4);
            this.mssPanel1.Controls.Add(this.RadioBoxVisitStatus2);
            this.mssPanel1.Controls.Add(this.RadioBoxAllContract);
            this.mssPanel1.Controls.Add(this.RadioBoxContractWithTime);
            this.mssPanel1.Controls.Add(this.RadioBoxVisitStatus1);
            this.mssPanel1.Controls.Add(this.DatePickerReciveFileDate);
            this.mssPanel1.Controls.Add(this.DatePickerEnd);
            this.mssPanel1.Controls.Add(this.DatePickerStart);
            this.mssPanel1.Controls.Add(this.ComboBoxSerach);
            this.mssPanel1.Controls.Add(this.mssLabel4);
            this.mssPanel1.Controls.Add(this.mssLabel3);
            this.mssPanel1.Controls.Add(this.mssLabel2);
            this.mssPanel1.Controls.Add(this.mssLabel1);
            this.mssPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mssPanel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.mssPanel1.Location = new System.Drawing.Point(0, 516);
            this.mssPanel1.Name = "mssPanel1";
            this.mssPanel1.Size = new System.Drawing.Size(1059, 67);
            this.mssPanel1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.mssPanel1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.mssPanel1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.mssPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.mssPanel1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.mssPanel1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.mssPanel1.Style.GradientAngle = 90;
            this.mssPanel1.TabIndex = 1;
            // 
            // ButtonReciveFileDate
            // 
            this.ButtonReciveFileDate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonReciveFileDate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonReciveFileDate.Location = new System.Drawing.Point(19, 6);
            this.ButtonReciveFileDate.Name = "ButtonReciveFileDate";
            this.ButtonReciveFileDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ButtonReciveFileDate.Size = new System.Drawing.Size(52, 23);
            this.ButtonReciveFileDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonReciveFileDate.TabIndex = 6;
            this.ButtonReciveFileDate.Tag = "200";
            this.ButtonReciveFileDate.Text = "ثبت";
            this.ButtonReciveFileDate.Click += new System.EventHandler(this.ButtonDateReciveFile_Click);
            // 
            // RadioBoxVisitStatus4
            // 
            this.RadioBoxVisitStatus4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RadioBoxVisitStatus4.AutoSize = true;
            this.RadioBoxVisitStatus4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            // 
            // 
            // 
            this.RadioBoxVisitStatus4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.RadioBoxVisitStatus4.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.RadioBoxVisitStatus4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.RadioBoxVisitStatus4.Location = new System.Drawing.Point(405, 8);
            this.RadioBoxVisitStatus4.Name = "RadioBoxVisitStatus4";
            this.RadioBoxVisitStatus4.Size = new System.Drawing.Size(73, 17);
            this.RadioBoxVisitStatus4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.RadioBoxVisitStatus4.TabIndex = 4;
            this.RadioBoxVisitStatus4.Text = "ثبت موقت";
            this.RadioBoxVisitStatus4.TextColor = System.Drawing.Color.Black;
            this.RadioBoxVisitStatus4.CheckedChanged += new System.EventHandler(this.ComboBoxSerach_SelectedIndexChanged);
            // 
            // RadioBoxVisitStatus2
            // 
            this.RadioBoxVisitStatus2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RadioBoxVisitStatus2.AutoSize = true;
            this.RadioBoxVisitStatus2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            // 
            // 
            // 
            this.RadioBoxVisitStatus2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.RadioBoxVisitStatus2.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.RadioBoxVisitStatus2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.RadioBoxVisitStatus2.Location = new System.Drawing.Point(515, 8);
            this.RadioBoxVisitStatus2.Name = "RadioBoxVisitStatus2";
            this.RadioBoxVisitStatus2.Size = new System.Drawing.Size(126, 17);
            this.RadioBoxVisitStatus2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.RadioBoxVisitStatus2.TabIndex = 3;
            this.RadioBoxVisitStatus2.Text = "تایید و ارسال به بیمه";
            this.RadioBoxVisitStatus2.TextColor = System.Drawing.Color.Black;
            this.RadioBoxVisitStatus2.CheckedChanged += new System.EventHandler(this.ComboBoxSerach_SelectedIndexChanged);
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
            this.RadioBoxAllContract.Location = new System.Drawing.Point(806, 8);
            this.RadioBoxAllContract.Name = "RadioBoxAllContract";
            this.RadioBoxAllContract.Size = new System.Drawing.Size(79, 17);
            this.RadioBoxAllContract.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.RadioBoxAllContract.TabIndex = 1;
            this.RadioBoxAllContract.TabStop = false;
            this.RadioBoxAllContract.Text = "کل قرادادها";
            this.RadioBoxAllContract.TextColor = System.Drawing.Color.Black;
            this.RadioBoxAllContract.CheckedChanged += new System.EventHandler(this.ComboBoxSerach_SelectedIndexChanged);
            // 
            // RadioBoxContractWithTime
            // 
            this.RadioBoxContractWithTime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.RadioBoxContractWithTime.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.RadioBoxContractWithTime.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.RadioBoxContractWithTime.Location = new System.Drawing.Point(719, 37);
            this.RadioBoxContractWithTime.Name = "RadioBoxContractWithTime";
            this.RadioBoxContractWithTime.Size = new System.Drawing.Size(169, 23);
            this.RadioBoxContractWithTime.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.RadioBoxContractWithTime.TabIndex = 5;
            this.RadioBoxContractWithTime.TabStop = false;
            this.RadioBoxContractWithTime.Text = "قرادادها براساس بازه زمانی";
            this.RadioBoxContractWithTime.TextColor = System.Drawing.Color.Black;
            this.RadioBoxContractWithTime.CheckedChanged += new System.EventHandler(this.ComboBoxSerach_SelectedIndexChanged);
            // 
            // RadioBoxVisitStatus1
            // 
            this.RadioBoxVisitStatus1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RadioBoxVisitStatus1.AutoSize = true;
            // 
            // 
            // 
            this.RadioBoxVisitStatus1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.RadioBoxVisitStatus1.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.RadioBoxVisitStatus1.Checked = true;
            this.RadioBoxVisitStatus1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RadioBoxVisitStatus1.CheckValue = "Y";
            this.RadioBoxVisitStatus1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.RadioBoxVisitStatus1.Location = new System.Drawing.Point(684, 8);
            this.RadioBoxVisitStatus1.Name = "RadioBoxVisitStatus1";
            this.RadioBoxVisitStatus1.Size = new System.Drawing.Size(88, 17);
            this.RadioBoxVisitStatus1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.RadioBoxVisitStatus1.TabIndex = 2;
            this.RadioBoxVisitStatus1.Text = "در انتظار تایید";
            this.RadioBoxVisitStatus1.TextColor = System.Drawing.Color.Black;
            this.RadioBoxVisitStatus1.CheckedChanged += new System.EventHandler(this.ComboBoxSerach_SelectedIndexChanged);
            // 
            // DatePickerReciveFileDate
            // 
            this.DatePickerReciveFileDate.BackColor = System.Drawing.Color.White;
            this.DatePickerReciveFileDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.DatePickerReciveFileDate.Location = new System.Drawing.Point(77, 8);
            this.DatePickerReciveFileDate.Name = "DatePickerReciveFileDate";
            this.DatePickerReciveFileDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DatePickerReciveFileDate.ShowTime = false;
            this.DatePickerReciveFileDate.Size = new System.Drawing.Size(103, 18);
            this.DatePickerReciveFileDate.TabIndex = 9;
            this.DatePickerReciveFileDate.Text = "mssDatePicker1";
            this.DatePickerReciveFileDate.UseFarsiDigits = true;
            this.DatePickerReciveFileDate.Value = ((KagNetComponents2.KagPersianDate)(resources.GetObject("DatePickerReciveFileDate.Value")));
            this.DatePickerReciveFileDate.ValueEn = new System.DateTime(2017, 3, 6, 18, 57, 29, 0);
            this.DatePickerReciveFileDate.ValueChanged += new KagNetComponents2.KagPersianDatePicker.onValueChanged(this.DatePickerStart_ValueChanged);
            // 
            // DatePickerEnd
            // 
            this.DatePickerEnd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DatePickerEnd.BackColor = System.Drawing.Color.White;
            this.DatePickerEnd.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.DatePickerEnd.Location = new System.Drawing.Point(171, 40);
            this.DatePickerEnd.Name = "DatePickerEnd";
            this.DatePickerEnd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DatePickerEnd.ShowTime = false;
            this.DatePickerEnd.Size = new System.Drawing.Size(115, 18);
            this.DatePickerEnd.TabIndex = 8;
            this.DatePickerEnd.Text = "mssDatePicker1";
            this.DatePickerEnd.UseFarsiDigits = true;
            this.DatePickerEnd.Value = ((KagNetComponents2.KagPersianDate)(resources.GetObject("DatePickerEnd.Value")));
            this.DatePickerEnd.ValueEn = new System.DateTime(2017, 3, 6, 18, 57, 29, 0);
            this.DatePickerEnd.ValueChanged += new KagNetComponents2.KagPersianDatePicker.onValueChanged(this.DatePickerStart_ValueChanged);
            // 
            // DatePickerStart
            // 
            this.DatePickerStart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DatePickerStart.BackColor = System.Drawing.Color.White;
            this.DatePickerStart.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.DatePickerStart.Location = new System.Drawing.Point(338, 40);
            this.DatePickerStart.Name = "DatePickerStart";
            this.DatePickerStart.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DatePickerStart.ShowTime = false;
            this.DatePickerStart.Size = new System.Drawing.Size(115, 18);
            this.DatePickerStart.TabIndex = 7;
            this.DatePickerStart.Text = "mssDatePicker1";
            this.DatePickerStart.UseFarsiDigits = true;
            this.DatePickerStart.Value = ((KagNetComponents2.KagPersianDate)(resources.GetObject("DatePickerStart.Value")));
            this.DatePickerStart.ValueEn = new System.DateTime(2017, 3, 6, 18, 57, 29, 0);
            this.DatePickerStart.ValueChanged += new KagNetComponents2.KagPersianDatePicker.onValueChanged(this.DatePickerStart_ValueChanged);
            // 
            // ComboBoxSerach
            // 
            this.ComboBoxSerach.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ComboBoxSerach.DisplayMember = "Text";
            this.ComboBoxSerach.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxSerach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxSerach.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ComboBoxSerach.FormattingEnabled = true;
            this.ComboBoxSerach.ItemHeight = 16;
            this.ComboBoxSerach.Items.AddRange(new object[] {
            this.comboItemLetterDate,
            this.comboItemContractDate,
            this.comboItemRequestDate,
            this.comboItemHealthCareDate});
            this.ComboBoxSerach.Location = new System.Drawing.Point(537, 39);
            this.ComboBoxSerach.Name = "ComboBoxSerach";
            this.ComboBoxSerach.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ComboBoxSerach.Size = new System.Drawing.Size(107, 22);
            this.ComboBoxSerach.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ComboBoxSerach.TabIndex = 6;
            this.ComboBoxSerach.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSerach_SelectedIndexChanged);
            // 
            // comboItemLetterDate
            // 
            this.comboItemLetterDate.Text = "تاریخ نامه بنیاد";
            // 
            // comboItemContractDate
            // 
            this.comboItemContractDate.Text = "تاریخ قرارداد";
            // 
            // comboItemRequestDate
            // 
            this.comboItemRequestDate.Text = "تاریح درخواست";
            // 
            // comboItemHealthCareDate
            // 
            this.comboItemHealthCareDate.Text = "تاریح انجام بهیاری";
            // 
            // mssLabel4
            // 
            this.mssLabel4.AutoSize = true;
            // 
            // 
            // 
            this.mssLabel4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mssLabel4.ForeColor = System.Drawing.Color.Black;
            this.mssLabel4.Location = new System.Drawing.Point(186, 8);
            this.mssLabel4.Name = "mssLabel4";
            this.mssLabel4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mssLabel4.Size = new System.Drawing.Size(80, 16);
            this.mssLabel4.TabIndex = 0;
            this.mssLabel4.Text = "تاریخ تحویل فایل:";
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
            this.mssLabel3.Location = new System.Drawing.Point(292, 40);
            this.mssLabel3.Name = "mssLabel3";
            this.mssLabel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mssLabel3.Size = new System.Drawing.Size(37, 16);
            this.mssLabel3.TabIndex = 0;
            this.mssLabel3.Text = "تا تاریخ:";
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
            this.mssLabel2.Location = new System.Drawing.Point(456, 40);
            this.mssLabel2.Name = "mssLabel2";
            this.mssLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mssLabel2.Size = new System.Drawing.Size(38, 16);
            this.mssLabel2.TabIndex = 0;
            this.mssLabel2.Text = "از تاریخ:";
            // 
            // mssLabel1
            // 
            this.mssLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mssLabel1.AutoSize = true;
            // 
            // 
            // 
            this.mssLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mssLabel1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.mssLabel1.ForeColor = System.Drawing.Color.Black;
            this.mssLabel1.Location = new System.Drawing.Point(650, 42);
            this.mssLabel1.Name = "mssLabel1";
            this.mssLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mssLabel1.Size = new System.Drawing.Size(36, 17);
            this.mssLabel1.TabIndex = 0;
            this.mssLabel1.Text = "ستون:";
            // 
            // VisitHealthCare_UC
            // 
            this.Controls.Add(this.serviceHealthCare_UC1);
            this.Controls.Add(this.mssExpandableSplitter1);
            this.Controls.Add(this.GridViewVisitHealthCare);
            this.Controls.Add(this.HeaderGridVisitHealthCare);
            this.Controls.Add(this.mssPanel1);
            this.Name = "VisitHealthCare_UC";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(1059, 583);
            this.Tag = "لیست بهیاری ها";
            this.Load += new System.EventHandler(this.VisitHealthCare_UC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewVisitHealthCare)).EndInit();
            this.ContextMenuStripStatus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vWVisitHealthCareBindingSource)).EndInit();
            this.mssPanel1.ResumeLayout(false);
            this.mssPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MSSHeaderGrid HeaderGridVisitHealthCare;
        private System.Windows.Forms.BindingSource vWVisitHealthCareBindingSource;
        private DevComponents.DotNetBar.ButtonItem buttonItemFiling;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel1;
        private DevComponents.DotNetBar.ButtonItem buttonItemSendHealthPayment;
        private DevComponents.DotNetBar.ItemContainer itemContainer1;
        private DevComponents.DotNetBar.ItemContainer itemContainer2;
        private MSSGridexView GridViewVisitHealthCare;
        private MSSContextMenuStrip ContextMenuStripStatus;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemStatusHealth;
        private MSSPanel mssPanel1;
        private MSSCheckBox RadioBoxAllContract;
        private MSSCheckBox RadioBoxContractWithTime;
        private MSSCheckBox RadioBoxVisitStatus1;
        private MSSDatePicker DatePickerEnd;
        private MSSDatePicker DatePickerStart;
        private MSSComboBox ComboBoxSerach;
        private DevComponents.Editors.ComboItem comboItemLetterDate;
        private DevComponents.Editors.ComboItem comboItemContractDate;
        private DevComponents.Editors.ComboItem comboItemRequestDate;
        private DevComponents.Editors.ComboItem comboItemHealthCareDate;
        private MSSLabel mssLabel3;
        private MSSLabel mssLabel2;
        private MSSLabel mssLabel1;
        private DevComponents.DotNetBar.ButtonItem buttonItemSendSMS;
        private MSSCheckBox RadioBoxVisitStatus4;
        private MSSCheckBox RadioBoxVisitStatus2;
        private ServiceHealthCare_UC serviceHealthCare_UC1;
        private MSSExpandableSplitter mssExpandableSplitter1;
        private MSSDatePicker DatePickerReciveFileDate;
        private MSSLabel mssLabel4;
        private MSSButton ButtonReciveFileDate;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemVisitHealthCareLog;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemVisitHealthCareCurrentRow;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemVisitHealthCareAllList;
    }
}
