using MKH.Library.Control;

namespace PhysiotherapyCare.View.MainForms.VisitPatientPhysiotherapy
{
    partial class VisitPatientPhysiotherapy_UC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisitPatientPhysiotherapy_UC));
            Janus.Windows.GridEX.GridEXLayout GridViewVisitPatientPhysiotherapy_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.tabControlPanel1 = new DevComponents.DotNetBar.TabControlPanel();
            this.GridViewVisitPatientPhysiotherapy = new MKH.Library.Control.MSSGridexView();
            this.ContextMenuStripStatus = new MKH.Library.Control.MSSContextMenuStrip(this.components);
            this.ToolStripMenuItemStatusPhysioterapy = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemVisitPatientPhysiotherapyLog = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemVisitPatientPhysiotherapyCurrentRow = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemVisitPatientPhysiotherapyAllList = new System.Windows.Forms.ToolStripMenuItem();
            this.vWVisitPatientPhysiotherapyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HeaderGridVisitPatientPhysiotherapy = new MKH.Library.Control.MSSHeaderGrid();
            this.buttonItemSendSMS = new DevComponents.DotNetBar.ButtonItem();
            this.itemContainer2 = new DevComponents.DotNetBar.ItemContainer();
            this.buttonItemSendPhysioterapyPayment = new DevComponents.DotNetBar.ButtonItem();
            this.itemContainer1 = new DevComponents.DotNetBar.ItemContainer();
            this.buttonItemFiling = new DevComponents.DotNetBar.ButtonItem();
            this.mssPanel1 = new MKH.Library.Control.MSSPanel(this.components);
            this.ButtonReciveFileDate = new MKH.Library.Control.MSSButton(this.components);
            this.DatePickerReciveFileDate = new MKH.Library.Control.MSSDatePicker(this.components);
            this.mssLabel4 = new MKH.Library.Control.MSSLabel(this.components);
            this.RadioBoxAllContract = new MKH.Library.Control.MSSCheckBox(this.components);
            this.RadioBoxContractWithTime = new MKH.Library.Control.MSSCheckBox(this.components);
            this.RadioBoxVisitStatus1 = new MKH.Library.Control.MSSCheckBox(this.components);
            this.RadioBoxVisitStatus4 = new MKH.Library.Control.MSSCheckBox(this.components);
            this.RadioBoxVisitStatus2 = new MKH.Library.Control.MSSCheckBox(this.components);
            this.DatePickerEnd = new MKH.Library.Control.MSSDatePicker(this.components);
            this.DatePickerStart = new MKH.Library.Control.MSSDatePicker(this.components);
            this.ComboBoxSerach = new MKH.Library.Control.MSSComboBox();
            this.comboItemLetterDate = new DevComponents.Editors.ComboItem();
            this.comboItemContractDate = new DevComponents.Editors.ComboItem();
            this.comboItemCordinateDate = new DevComponents.Editors.ComboItem();
            this.comboItemBeginDate = new DevComponents.Editors.ComboItem();
            this.comboItemEndDate = new DevComponents.Editors.ComboItem();
            this.mssLabel3 = new MKH.Library.Control.MSSLabel(this.components);
            this.mssLabel2 = new MKH.Library.Control.MSSLabel(this.components);
            this.mssLabel1 = new MKH.Library.Control.MSSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewVisitPatientPhysiotherapy)).BeginInit();
            this.ContextMenuStripStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vWVisitPatientPhysiotherapyBindingSource)).BeginInit();
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
            // GridViewVisitPatientPhysiotherapy
            // 
            this.GridViewVisitPatientPhysiotherapy.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.GridViewVisitPatientPhysiotherapy.AlternatingRowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewVisitPatientPhysiotherapy.BuiltInTextsData = resources.GetString("GridViewVisitPatientPhysiotherapy.BuiltInTextsData");
            this.GridViewVisitPatientPhysiotherapy.CardViewGridlines = Janus.Windows.GridEX.CardViewGridlines.Both;
            this.GridViewVisitPatientPhysiotherapy.ContextMenuStrip = this.ContextMenuStripStatus;
            this.GridViewVisitPatientPhysiotherapy.DataSource = this.vWVisitPatientPhysiotherapyBindingSource;
            this.GridViewVisitPatientPhysiotherapy.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            GridViewVisitPatientPhysiotherapy_DesignTimeLayout.LayoutString = resources.GetString("GridViewVisitPatientPhysiotherapy_DesignTimeLayout.LayoutString");
            this.GridViewVisitPatientPhysiotherapy.DesignTimeLayout = GridViewVisitPatientPhysiotherapy_DesignTimeLayout;
            this.GridViewVisitPatientPhysiotherapy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewVisitPatientPhysiotherapy.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.GridViewVisitPatientPhysiotherapy.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.GridViewVisitPatientPhysiotherapy.Font = new System.Drawing.Font("Tahoma", 8.150944F);
            this.GridViewVisitPatientPhysiotherapy.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewVisitPatientPhysiotherapy.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
            this.GridViewVisitPatientPhysiotherapy.Location = new System.Drawing.Point(0, 56);
            this.GridViewVisitPatientPhysiotherapy.Name = "GridViewVisitPatientPhysiotherapy";
            this.GridViewVisitPatientPhysiotherapy.RecordNavigator = true;
            this.GridViewVisitPatientPhysiotherapy.RowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewVisitPatientPhysiotherapy.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition;
            this.GridViewVisitPatientPhysiotherapy.RowHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewVisitPatientPhysiotherapy.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.GridViewVisitPatientPhysiotherapy.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelection;
            this.GridViewVisitPatientPhysiotherapy.Size = new System.Drawing.Size(932, 460);
            this.GridViewVisitPatientPhysiotherapy.TabIndex = 32;
            this.GridViewVisitPatientPhysiotherapy.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.GridViewVisitPatientPhysiotherapy.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010;
            this.GridViewVisitPatientPhysiotherapy.DoubleClick += new System.EventHandler(this.headerGridVisitPatientPhysiotherapy_btnEditClick);
            // 
            // ContextMenuStripStatus
            // 
            this.ContextMenuStripStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemStatusPhysioterapy,
            this.ToolStripMenuItemVisitPatientPhysiotherapyLog});
            this.ContextMenuStripStatus.Name = "ContextMenuStripStatus";
            this.ContextMenuStripStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ContextMenuStripStatus.Size = new System.Drawing.Size(150, 48);
            // 
            // ToolStripMenuItemStatusPhysioterapy
            // 
            this.ToolStripMenuItemStatusPhysioterapy.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripMenuItemStatusPhysioterapy.Name = "ToolStripMenuItemStatusPhysioterapy";
            this.ToolStripMenuItemStatusPhysioterapy.Size = new System.Drawing.Size(149, 22);
            this.ToolStripMenuItemStatusPhysioterapy.Tag = "58";
            this.ToolStripMenuItemStatusPhysioterapy.Text = "بررسی وضعیت";
            this.ToolStripMenuItemStatusPhysioterapy.Click += new System.EventHandler(this.ToolStripMenuItemStatus_Click);
            // 
            // ToolStripMenuItemVisitPatientPhysiotherapyLog
            // 
            this.ToolStripMenuItemVisitPatientPhysiotherapyLog.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemVisitPatientPhysiotherapyCurrentRow,
            this.ToolStripMenuItemVisitPatientPhysiotherapyAllList});
            this.ToolStripMenuItemVisitPatientPhysiotherapyLog.Name = "ToolStripMenuItemVisitPatientPhysiotherapyLog";
            this.ToolStripMenuItemVisitPatientPhysiotherapyLog.Size = new System.Drawing.Size(149, 22);
            this.ToolStripMenuItemVisitPatientPhysiotherapyLog.Text = "Log";
            // 
            // ToolStripMenuItemVisitPatientPhysiotherapyCurrentRow
            // 
            this.ToolStripMenuItemVisitPatientPhysiotherapyCurrentRow.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripMenuItemVisitPatientPhysiotherapyCurrentRow.Name = "ToolStripMenuItemVisitPatientPhysiotherapyCurrentRow";
            this.ToolStripMenuItemVisitPatientPhysiotherapyCurrentRow.Size = new System.Drawing.Size(140, 22);
            this.ToolStripMenuItemVisitPatientPhysiotherapyCurrentRow.Tag = "277";
            this.ToolStripMenuItemVisitPatientPhysiotherapyCurrentRow.Text = "سطر انتخابی";
            this.ToolStripMenuItemVisitPatientPhysiotherapyCurrentRow.Click += new System.EventHandler(this.ToolStripMenuItemVisitPatientPhysiotherapyCurrentRow_Click);
            // 
            // ToolStripMenuItemVisitPatientPhysiotherapyAllList
            // 
            this.ToolStripMenuItemVisitPatientPhysiotherapyAllList.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripMenuItemVisitPatientPhysiotherapyAllList.Name = "ToolStripMenuItemVisitPatientPhysiotherapyAllList";
            this.ToolStripMenuItemVisitPatientPhysiotherapyAllList.Size = new System.Drawing.Size(140, 22);
            this.ToolStripMenuItemVisitPatientPhysiotherapyAllList.Tag = "278";
            this.ToolStripMenuItemVisitPatientPhysiotherapyAllList.Text = "کل لیست";
            this.ToolStripMenuItemVisitPatientPhysiotherapyAllList.Click += new System.EventHandler(this.ToolStripMenuItemVisitPatientPhysiotherapyAllList_Click);
            // 
            // vWVisitPatientPhysiotherapyBindingSource
            // 
            this.vWVisitPatientPhysiotherapyBindingSource.DataSource = typeof(PhysiotherapyCare.Model.VisitPatientPhysiotherapy.VW_VisitPatientPhysiotherapy);
            // 
            // HeaderGridVisitPatientPhysiotherapy
            // 
            // 
            // 
            // 
            this.HeaderGridVisitPatientPhysiotherapy.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridVisitPatientPhysiotherapy.BackgroundStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridVisitPatientPhysiotherapy.BackgroundStyle.BorderBottomWidth = 1;
            this.HeaderGridVisitPatientPhysiotherapy.BackgroundStyle.BorderLeftWidth = 1;
            this.HeaderGridVisitPatientPhysiotherapy.BackgroundStyle.BorderRightWidth = 1;
            this.HeaderGridVisitPatientPhysiotherapy.BackgroundStyle.BorderTopWidth = 1;
            this.HeaderGridVisitPatientPhysiotherapy.BackgroundStyle.Class = "ItemPanel";
            this.HeaderGridVisitPatientPhysiotherapy.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.HeaderGridVisitPatientPhysiotherapy.BackgroundStyle.PaddingBottom = 1;
            this.HeaderGridVisitPatientPhysiotherapy.BackgroundStyle.PaddingLeft = 1;
            this.HeaderGridVisitPatientPhysiotherapy.BackgroundStyle.PaddingRight = 1;
            this.HeaderGridVisitPatientPhysiotherapy.BackgroundStyle.PaddingTop = 1;
            this.HeaderGridVisitPatientPhysiotherapy.ButtonDeletePermissionCode = 54;
            this.HeaderGridVisitPatientPhysiotherapy.ButtonDeleteVisible = true;
            this.HeaderGridVisitPatientPhysiotherapy.ButtonEditPermissionCode = 53;
            this.HeaderGridVisitPatientPhysiotherapy.ButtonEditVisible = true;
            this.HeaderGridVisitPatientPhysiotherapy.ButtonExcelExportVisible = true;
            this.HeaderGridVisitPatientPhysiotherapy.ButtonExcelPermissionCode = 56;
            this.HeaderGridVisitPatientPhysiotherapy.ButtonInsertPermissionCode = 52;
            this.HeaderGridVisitPatientPhysiotherapy.ButtonInsertVisible = true;
            this.HeaderGridVisitPatientPhysiotherapy.ButtonPrintExpertPermissionCode = 0;
            this.HeaderGridVisitPatientPhysiotherapy.ButtonPrintExpertVisible = false;
            this.HeaderGridVisitPatientPhysiotherapy.ButtonPrintPermissionCode = 55;
            this.HeaderGridVisitPatientPhysiotherapy.ButtonPrintVisible = true;
            this.HeaderGridVisitPatientPhysiotherapy.ButtonPrintWithDesignPermissionCode = 125;
            this.HeaderGridVisitPatientPhysiotherapy.ButtonPrintWithDesignVisible = true;
            this.HeaderGridVisitPatientPhysiotherapy.ButtonRefreshVisible = true;
            this.HeaderGridVisitPatientPhysiotherapy.ButtonSearchExpertVisible = false;
            this.HeaderGridVisitPatientPhysiotherapy.ButtonSearchVisible = true;
            this.HeaderGridVisitPatientPhysiotherapy.ButtonSelectorVisible = true;
            this.HeaderGridVisitPatientPhysiotherapy.ContainerControlProcessDialogKey = true;
            this.HeaderGridVisitPatientPhysiotherapy.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderGridVisitPatientPhysiotherapy.FitButtonsToContainerWidth = true;
            this.HeaderGridVisitPatientPhysiotherapy.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.HeaderGridVisitPatientPhysiotherapy.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.HeaderGridVisitPatientPhysiotherapy.GridViewSet = this.GridViewVisitPatientPhysiotherapy;
            this.HeaderGridVisitPatientPhysiotherapy.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItemSendSMS,
            this.itemContainer2,
            this.buttonItemSendPhysioterapyPayment,
            this.itemContainer1,
            this.buttonItemFiling});
            this.HeaderGridVisitPatientPhysiotherapy.Location = new System.Drawing.Point(0, 0);
            this.HeaderGridVisitPatientPhysiotherapy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HeaderGridVisitPatientPhysiotherapy.Name = "HeaderGridVisitPatientPhysiotherapy";
            this.HeaderGridVisitPatientPhysiotherapy.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HeaderGridVisitPatientPhysiotherapy.Size = new System.Drawing.Size(932, 56);
            this.HeaderGridVisitPatientPhysiotherapy.TabIndex = 31;
            this.HeaderGridVisitPatientPhysiotherapy.Tag = "پزشکان";
            this.HeaderGridVisitPatientPhysiotherapy.Text = "پزشکان";
            this.HeaderGridVisitPatientPhysiotherapy.ThemeAware = true;
            this.HeaderGridVisitPatientPhysiotherapy.buttonItemInsertClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemInsertClickEventHandler(this.headerGridVisitPatientPhysiotherapy_btnInsertClick);
            this.HeaderGridVisitPatientPhysiotherapy.buttonItemEditClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemEditClickEventHandler(this.headerGridVisitPatientPhysiotherapy_btnEditClick);
            this.HeaderGridVisitPatientPhysiotherapy.buttonItemDeleteClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemDeleteClickEventHandler(this.headerGridVisitPatientPhysiotherapy_btnDeleteClick);
            this.HeaderGridVisitPatientPhysiotherapy.buttonItemRefreshClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemRefreshClickEventHandler(this.headerGridVisitPatientPhysiotherapy_btnRefreshClick);
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
            this.buttonItemSendSMS.Tag = "208";
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
            // buttonItemSendPhysioterapyPayment
            // 
            this.buttonItemSendPhysioterapyPayment.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemSendPhysioterapyPayment.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemSendPhysioterapyPayment.Icon = ((System.Drawing.Icon)(resources.GetObject("buttonItemSendPhysioterapyPayment.Icon")));
            this.buttonItemSendPhysioterapyPayment.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium;
            this.buttonItemSendPhysioterapyPayment.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemSendPhysioterapyPayment.Name = "buttonItemSendPhysioterapyPayment";
            this.buttonItemSendPhysioterapyPayment.Tag = "127";
            this.buttonItemSendPhysioterapyPayment.Text = "تایید و ارسال جهت بیمه";
            this.buttonItemSendPhysioterapyPayment.ThemeAware = true;
            this.buttonItemSendPhysioterapyPayment.Click += new System.EventHandler(this.buttonItemSendPhysioterapyPayment_Click);
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
            this.buttonItemFiling.Tag = "57";
            this.buttonItemFiling.Text = "فایل های فیزیوتراپی";
            this.buttonItemFiling.ThemeAware = true;
            this.buttonItemFiling.Click += new System.EventHandler(this.buttonItemFiling_Click);
            // 
            // mssPanel1
            // 
            this.mssPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.mssPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.mssPanel1.Controls.Add(this.ButtonReciveFileDate);
            this.mssPanel1.Controls.Add(this.DatePickerReciveFileDate);
            this.mssPanel1.Controls.Add(this.mssLabel4);
            this.mssPanel1.Controls.Add(this.RadioBoxAllContract);
            this.mssPanel1.Controls.Add(this.RadioBoxContractWithTime);
            this.mssPanel1.Controls.Add(this.RadioBoxVisitStatus1);
            this.mssPanel1.Controls.Add(this.RadioBoxVisitStatus4);
            this.mssPanel1.Controls.Add(this.RadioBoxVisitStatus2);
            this.mssPanel1.Controls.Add(this.DatePickerEnd);
            this.mssPanel1.Controls.Add(this.DatePickerStart);
            this.mssPanel1.Controls.Add(this.ComboBoxSerach);
            this.mssPanel1.Controls.Add(this.mssLabel3);
            this.mssPanel1.Controls.Add(this.mssLabel2);
            this.mssPanel1.Controls.Add(this.mssLabel1);
            this.mssPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mssPanel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.mssPanel1.Location = new System.Drawing.Point(0, 516);
            this.mssPanel1.Name = "mssPanel1";
            this.mssPanel1.Size = new System.Drawing.Size(932, 67);
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
            this.ButtonReciveFileDate.Location = new System.Drawing.Point(8, 6);
            this.ButtonReciveFileDate.Name = "ButtonReciveFileDate";
            this.ButtonReciveFileDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ButtonReciveFileDate.Size = new System.Drawing.Size(52, 23);
            this.ButtonReciveFileDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonReciveFileDate.TabIndex = 10;
            this.ButtonReciveFileDate.Tag = "198";
            this.ButtonReciveFileDate.Text = "ثبت";
            this.ButtonReciveFileDate.Click += new System.EventHandler(this.ButtonReciveFileDate_Click);
            // 
            // DatePickerReciveFileDate
            // 
            this.DatePickerReciveFileDate.BackColor = System.Drawing.Color.White;
            this.DatePickerReciveFileDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.DatePickerReciveFileDate.Location = new System.Drawing.Point(66, 8);
            this.DatePickerReciveFileDate.Name = "DatePickerReciveFileDate";
            this.DatePickerReciveFileDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DatePickerReciveFileDate.ShowTime = false;
            this.DatePickerReciveFileDate.Size = new System.Drawing.Size(103, 18);
            this.DatePickerReciveFileDate.TabIndex = 9;
            this.DatePickerReciveFileDate.Text = "mssDatePicker1";
            this.DatePickerReciveFileDate.UseFarsiDigits = true;
            this.DatePickerReciveFileDate.Value = ((KagNetComponents2.KagPersianDate)(resources.GetObject("DatePickerReciveFileDate.Value")));
            this.DatePickerReciveFileDate.ValueEn = new System.DateTime(2017, 3, 6, 18, 57, 29, 0);
            // 
            // mssLabel4
            // 
            this.mssLabel4.AutoSize = true;
            // 
            // 
            // 
            this.mssLabel4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mssLabel4.ForeColor = System.Drawing.Color.Black;
            this.mssLabel4.Location = new System.Drawing.Point(175, 8);
            this.mssLabel4.Name = "mssLabel4";
            this.mssLabel4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mssLabel4.Size = new System.Drawing.Size(80, 16);
            this.mssLabel4.TabIndex = 7;
            this.mssLabel4.Text = "تاریخ تحویل فایل:";
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
            this.RadioBoxAllContract.Location = new System.Drawing.Point(743, 8);
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
            this.RadioBoxContractWithTime.Location = new System.Drawing.Point(656, 37);
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
            this.RadioBoxVisitStatus1.Location = new System.Drawing.Point(621, 8);
            this.RadioBoxVisitStatus1.Name = "RadioBoxVisitStatus1";
            this.RadioBoxVisitStatus1.Size = new System.Drawing.Size(88, 17);
            this.RadioBoxVisitStatus1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.RadioBoxVisitStatus1.TabIndex = 2;
            this.RadioBoxVisitStatus1.Text = "در انتظار تایید";
            this.RadioBoxVisitStatus1.TextColor = System.Drawing.Color.Black;
            this.RadioBoxVisitStatus1.CheckedChanged += new System.EventHandler(this.ComboBoxSerach_SelectedIndexChanged);
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
            this.RadioBoxVisitStatus4.Location = new System.Drawing.Point(358, 8);
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
            this.RadioBoxVisitStatus2.Location = new System.Drawing.Point(468, 8);
            this.RadioBoxVisitStatus2.Name = "RadioBoxVisitStatus2";
            this.RadioBoxVisitStatus2.Size = new System.Drawing.Size(126, 17);
            this.RadioBoxVisitStatus2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.RadioBoxVisitStatus2.TabIndex = 3;
            this.RadioBoxVisitStatus2.Text = "تایید و ارسال به بیمه";
            this.RadioBoxVisitStatus2.TextColor = System.Drawing.Color.Black;
            this.RadioBoxVisitStatus2.CheckedChanged += new System.EventHandler(this.ComboBoxSerach_SelectedIndexChanged);
            // 
            // DatePickerEnd
            // 
            this.DatePickerEnd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DatePickerEnd.BackColor = System.Drawing.Color.White;
            this.DatePickerEnd.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.DatePickerEnd.Location = new System.Drawing.Point(108, 40);
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
            this.DatePickerStart.Location = new System.Drawing.Point(275, 40);
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
            this.comboItemCordinateDate,
            this.comboItemBeginDate,
            this.comboItemEndDate});
            this.ComboBoxSerach.Location = new System.Drawing.Point(474, 39);
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
            // comboItemCordinateDate
            // 
            this.comboItemCordinateDate.Text = "تاریخ هماهنگی با فیزیوتراپ";
            // 
            // comboItemBeginDate
            // 
            this.comboItemBeginDate.Text = "تاریخ شروع";
            // 
            // comboItemEndDate
            // 
            this.comboItemEndDate.Text = "تاریح پایان";
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
            this.mssLabel3.Location = new System.Drawing.Point(229, 40);
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
            this.mssLabel2.Location = new System.Drawing.Point(393, 40);
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
            this.mssLabel1.Location = new System.Drawing.Point(587, 42);
            this.mssLabel1.Name = "mssLabel1";
            this.mssLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mssLabel1.Size = new System.Drawing.Size(36, 17);
            this.mssLabel1.TabIndex = 0;
            this.mssLabel1.Text = "ستون:";
            // 
            // VisitPatientPhysiotherapy_UC
            // 
            this.Controls.Add(this.GridViewVisitPatientPhysiotherapy);
            this.Controls.Add(this.HeaderGridVisitPatientPhysiotherapy);
            this.Controls.Add(this.mssPanel1);
            this.Name = "VisitPatientPhysiotherapy_UC";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(932, 583);
            this.Tag = "لیست فیزیو تراپی ها";
            this.Load += new System.EventHandler(this.VisitPatientPhysiotherapy_UC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewVisitPatientPhysiotherapy)).EndInit();
            this.ContextMenuStripStatus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vWVisitPatientPhysiotherapyBindingSource)).EndInit();
            this.mssPanel1.ResumeLayout(false);
            this.mssPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MSSHeaderGrid HeaderGridVisitPatientPhysiotherapy;
        private MSSGridexView GridViewVisitPatientPhysiotherapy;
        private System.Windows.Forms.BindingSource vWVisitPatientPhysiotherapyBindingSource;
        private DevComponents.DotNetBar.ButtonItem buttonItemFiling;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel1;
        private DevComponents.DotNetBar.ButtonItem buttonItemSendPhysioterapyPayment;
        private DevComponents.DotNetBar.ItemContainer itemContainer1;
        private DevComponents.DotNetBar.ItemContainer itemContainer2;
        private MSSContextMenuStrip ContextMenuStripStatus;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemStatusPhysioterapy;
        private MSSPanel mssPanel1;
        private MSSCheckBox RadioBoxAllContract;
        private MSSCheckBox RadioBoxContractWithTime;
        private MSSCheckBox RadioBoxVisitStatus1;
        private MSSCheckBox RadioBoxVisitStatus2;
        private MSSDatePicker DatePickerEnd;
        private MSSDatePicker DatePickerStart;
        private MSSComboBox ComboBoxSerach;
        private DevComponents.Editors.ComboItem comboItemLetterDate;
        private DevComponents.Editors.ComboItem comboItemContractDate;
        private DevComponents.Editors.ComboItem comboItemCordinateDate;
        private DevComponents.Editors.ComboItem comboItemBeginDate;
        private MSSLabel mssLabel3;
        private MSSLabel mssLabel2;
        private MSSLabel mssLabel1;
        private DevComponents.Editors.ComboItem comboItemEndDate;
        private DevComponents.DotNetBar.ButtonItem buttonItemSendSMS;
        private MSSCheckBox RadioBoxVisitStatus4;
        private MSSButton ButtonReciveFileDate;
        private MSSDatePicker DatePickerReciveFileDate;
        private MSSLabel mssLabel4;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemVisitPatientPhysiotherapyLog;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemVisitPatientPhysiotherapyCurrentRow;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemVisitPatientPhysiotherapyAllList;
    }
}
