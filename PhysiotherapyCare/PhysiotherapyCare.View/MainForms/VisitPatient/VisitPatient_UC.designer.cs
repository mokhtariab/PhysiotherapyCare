using MKH.Library.Control;

namespace PhysiotherapyCare.View.MainForms.VisitPatient
{
    partial class VisitPatient_UC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisitPatient_UC));
            Janus.Windows.GridEX.GridEXLayout GridViewVisitPatietSet_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.tabControlPanel1 = new DevComponents.DotNetBar.TabControlPanel();
            this.GridViewVisitPatietSet = new MKH.Library.Control.MSSGridexView();
            this.ContextMenuStripStatus = new MKH.Library.Control.MSSContextMenuStrip(this.components);
            this.ToolStripMenuItemStatusVisit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemVisitPatientLog = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemVisitPatientCurrentRow = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemVisitPatientAllList = new System.Windows.Forms.ToolStripMenuItem();
            this.vWVisitPatientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HeaderGridVisitPatient = new MKH.Library.Control.MSSHeaderGrid();
            this.buttonItemSendSMS = new DevComponents.DotNetBar.ButtonItem();
            this.itemContainer3 = new DevComponents.DotNetBar.ItemContainer();
            this.buttonItemVisitPatientPrintList = new DevComponents.DotNetBar.ButtonItem();
            this.itemContainer2 = new DevComponents.DotNetBar.ItemContainer();
            this.buttonItemSendVisitPayment = new DevComponents.DotNetBar.ButtonItem();
            this.itemContainer1 = new DevComponents.DotNetBar.ItemContainer();
            this.buttonItemFiling = new DevComponents.DotNetBar.ButtonItem();
            this.mssPanel1 = new MKH.Library.Control.MSSPanel(this.components);
            this.ButtonReciveFileDate = new MKH.Library.Control.MSSButton(this.components);
            this.RadioBoxAllContract = new MKH.Library.Control.MSSCheckBox(this.components);
            this.DatePickerReciveFileDate = new MKH.Library.Control.MSSDatePicker(this.components);
            this.mssLabel1 = new MKH.Library.Control.MSSLabel(this.components);
            this.mssLabel4 = new MKH.Library.Control.MSSLabel(this.components);
            this.mssLabel2 = new MKH.Library.Control.MSSLabel(this.components);
            this.mssLabel3 = new MKH.Library.Control.MSSLabel(this.components);
            this.RadioBoxVisitStatus1 = new MKH.Library.Control.MSSCheckBox(this.components);
            this.DatePickerStart = new MKH.Library.Control.MSSDatePicker(this.components);
            this.RadioBoxVisitStatus2 = new MKH.Library.Control.MSSCheckBox(this.components);
            this.DatePickerEnd = new MKH.Library.Control.MSSDatePicker(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewVisitPatietSet)).BeginInit();
            this.ContextMenuStripStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vWVisitPatientBindingSource)).BeginInit();
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
            // GridViewVisitPatietSet
            // 
            this.GridViewVisitPatietSet.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.GridViewVisitPatietSet.AlternatingRowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewVisitPatietSet.BuiltInTextsData = resources.GetString("GridViewVisitPatietSet.BuiltInTextsData");
            this.GridViewVisitPatietSet.CardViewGridlines = Janus.Windows.GridEX.CardViewGridlines.Both;
            this.GridViewVisitPatietSet.ContextMenuStrip = this.ContextMenuStripStatus;
            this.GridViewVisitPatietSet.DataSource = this.vWVisitPatientBindingSource;
            this.GridViewVisitPatietSet.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            GridViewVisitPatietSet_DesignTimeLayout.LayoutString = resources.GetString("GridViewVisitPatietSet_DesignTimeLayout.LayoutString");
            this.GridViewVisitPatietSet.DesignTimeLayout = GridViewVisitPatietSet_DesignTimeLayout;
            this.GridViewVisitPatietSet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewVisitPatietSet.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.GridViewVisitPatietSet.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.GridViewVisitPatietSet.Font = new System.Drawing.Font("Tahoma", 8.150944F);
            this.GridViewVisitPatietSet.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewVisitPatietSet.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
            this.GridViewVisitPatietSet.Location = new System.Drawing.Point(0, 56);
            this.GridViewVisitPatietSet.Name = "GridViewVisitPatietSet";
            this.GridViewVisitPatietSet.RecordNavigator = true;
            this.GridViewVisitPatietSet.RowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewVisitPatietSet.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition;
            this.GridViewVisitPatietSet.RowHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewVisitPatietSet.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.GridViewVisitPatietSet.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelection;
            this.GridViewVisitPatietSet.SettingsKey = "GridViewVisitPatietSet";
            this.GridViewVisitPatietSet.Size = new System.Drawing.Size(1140, 411);
            this.GridViewVisitPatietSet.TabIndex = 32;
            this.GridViewVisitPatietSet.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.GridViewVisitPatietSet.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010;
            this.GridViewVisitPatietSet.DoubleClick += new System.EventHandler(this.headerGridVisitPatient_btnEditClick);
            // 
            // ContextMenuStripStatus
            // 
            this.ContextMenuStripStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemStatusVisit,
            this.ToolStripMenuItemVisitPatientLog});
            this.ContextMenuStripStatus.Name = "ContextMenuStripStatus";
            this.ContextMenuStripStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ContextMenuStripStatus.Size = new System.Drawing.Size(150, 48);
            // 
            // ToolStripMenuItemStatusVisit
            // 
            this.ToolStripMenuItemStatusVisit.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripMenuItemStatusVisit.Name = "ToolStripMenuItemStatusVisit";
            this.ToolStripMenuItemStatusVisit.Size = new System.Drawing.Size(149, 22);
            this.ToolStripMenuItemStatusVisit.Tag = "218";
            this.ToolStripMenuItemStatusVisit.Text = "بررسی وضعیت";
            this.ToolStripMenuItemStatusVisit.Click += new System.EventHandler(this.ToolStripMenuItemStatus_Click);
            // 
            // ToolStripMenuItemVisitPatientLog
            // 
            this.ToolStripMenuItemVisitPatientLog.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemVisitPatientCurrentRow,
            this.ToolStripMenuItemVisitPatientAllList});
            this.ToolStripMenuItemVisitPatientLog.Name = "ToolStripMenuItemVisitPatientLog";
            this.ToolStripMenuItemVisitPatientLog.Size = new System.Drawing.Size(149, 22);
            this.ToolStripMenuItemVisitPatientLog.Text = "Log";
            // 
            // ToolStripMenuItemVisitPatientCurrentRow
            // 
            this.ToolStripMenuItemVisitPatientCurrentRow.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripMenuItemVisitPatientCurrentRow.Name = "ToolStripMenuItemVisitPatientCurrentRow";
            this.ToolStripMenuItemVisitPatientCurrentRow.Size = new System.Drawing.Size(140, 22);
            this.ToolStripMenuItemVisitPatientCurrentRow.Tag = "258";
            this.ToolStripMenuItemVisitPatientCurrentRow.Text = "سطر انتخابی";
            this.ToolStripMenuItemVisitPatientCurrentRow.Click += new System.EventHandler(this.ToolStripMenuItemVisitPatientCurrentRow_Click);
            // 
            // ToolStripMenuItemVisitPatientAllList
            // 
            this.ToolStripMenuItemVisitPatientAllList.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripMenuItemVisitPatientAllList.Name = "ToolStripMenuItemVisitPatientAllList";
            this.ToolStripMenuItemVisitPatientAllList.Size = new System.Drawing.Size(140, 22);
            this.ToolStripMenuItemVisitPatientAllList.Tag = "259";
            this.ToolStripMenuItemVisitPatientAllList.Text = "کل لیست";
            this.ToolStripMenuItemVisitPatientAllList.Click += new System.EventHandler(this.ToolStripMenuItemVisitPatientAllList_Click);
            // 
            // vWVisitPatientBindingSource
            // 
            this.vWVisitPatientBindingSource.DataSource = typeof(PhysiotherapyCare.Model.VisitPatient.VW_VisitPatient);
            // 
            // HeaderGridVisitPatient
            // 
            // 
            // 
            // 
            this.HeaderGridVisitPatient.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridVisitPatient.BackgroundStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridVisitPatient.BackgroundStyle.BorderBottomWidth = 1;
            this.HeaderGridVisitPatient.BackgroundStyle.BorderLeftWidth = 1;
            this.HeaderGridVisitPatient.BackgroundStyle.BorderRightWidth = 1;
            this.HeaderGridVisitPatient.BackgroundStyle.BorderTopWidth = 1;
            this.HeaderGridVisitPatient.BackgroundStyle.Class = "ItemPanel";
            this.HeaderGridVisitPatient.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.HeaderGridVisitPatient.BackgroundStyle.PaddingBottom = 1;
            this.HeaderGridVisitPatient.BackgroundStyle.PaddingLeft = 1;
            this.HeaderGridVisitPatient.BackgroundStyle.PaddingRight = 1;
            this.HeaderGridVisitPatient.BackgroundStyle.PaddingTop = 1;
            this.HeaderGridVisitPatient.ButtonDeletePermissionCode = 214;
            this.HeaderGridVisitPatient.ButtonDeleteVisible = true;
            this.HeaderGridVisitPatient.ButtonEditPermissionCode = 213;
            this.HeaderGridVisitPatient.ButtonEditVisible = true;
            this.HeaderGridVisitPatient.ButtonExcelExportVisible = true;
            this.HeaderGridVisitPatient.ButtonExcelPermissionCode = 216;
            this.HeaderGridVisitPatient.ButtonInsertPermissionCode = 212;
            this.HeaderGridVisitPatient.ButtonInsertVisible = true;
            this.HeaderGridVisitPatient.ButtonPrintExpertPermissionCode = 0;
            this.HeaderGridVisitPatient.ButtonPrintExpertVisible = false;
            this.HeaderGridVisitPatient.ButtonPrintPermissionCode = 215;
            this.HeaderGridVisitPatient.ButtonPrintVisible = true;
            this.HeaderGridVisitPatient.ButtonPrintWithDesignPermissionCode = 219;
            this.HeaderGridVisitPatient.ButtonPrintWithDesignVisible = true;
            this.HeaderGridVisitPatient.ButtonRefreshVisible = true;
            this.HeaderGridVisitPatient.ButtonSearchExpertVisible = false;
            this.HeaderGridVisitPatient.ButtonSearchVisible = true;
            this.HeaderGridVisitPatient.ButtonSelectorVisible = true;
            this.HeaderGridVisitPatient.ContainerControlProcessDialogKey = true;
            this.HeaderGridVisitPatient.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderGridVisitPatient.FitButtonsToContainerWidth = true;
            this.HeaderGridVisitPatient.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.HeaderGridVisitPatient.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.HeaderGridVisitPatient.GridViewSet = this.GridViewVisitPatietSet;
            this.HeaderGridVisitPatient.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItemSendSMS,
            this.itemContainer3,
            this.buttonItemVisitPatientPrintList,
            this.itemContainer2,
            this.buttonItemSendVisitPayment,
            this.itemContainer1,
            this.buttonItemFiling});
            this.HeaderGridVisitPatient.Location = new System.Drawing.Point(0, 0);
            this.HeaderGridVisitPatient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HeaderGridVisitPatient.Name = "HeaderGridVisitPatient";
            this.HeaderGridVisitPatient.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HeaderGridVisitPatient.Size = new System.Drawing.Size(1140, 56);
            this.HeaderGridVisitPatient.TabIndex = 31;
            this.HeaderGridVisitPatient.Tag = "پزشکان";
            this.HeaderGridVisitPatient.Text = "پزشکان";
            this.HeaderGridVisitPatient.ThemeAware = true;
            this.HeaderGridVisitPatient.buttonItemInsertClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemInsertClickEventHandler(this.headerGridVisitPatientPhysiotherapy_btnInsertClick);
            this.HeaderGridVisitPatient.buttonItemEditClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemEditClickEventHandler(this.headerGridVisitPatient_btnEditClick);
            this.HeaderGridVisitPatient.buttonItemDeleteClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemDeleteClickEventHandler(this.headerGridVisitPatientPhysiotherapy_btnDeleteClick);
            this.HeaderGridVisitPatient.buttonItemRefreshClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemRefreshClickEventHandler(this.headerGridVisitPatient_btnRefreshClick);
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
            this.buttonItemSendSMS.Tag = "222";
            this.buttonItemSendSMS.Text = "SMS ارسال";
            this.buttonItemSendSMS.ThemeAware = true;
            this.buttonItemSendSMS.Click += new System.EventHandler(this.buttonItemSendSMS_Click);
            // 
            // itemContainer3
            // 
            // 
            // 
            // 
            this.itemContainer3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer3.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer3.Name = "itemContainer3";
            this.itemContainer3.ThemeAware = true;
            // 
            // buttonItemVisitPatientPrintList
            // 
            this.buttonItemVisitPatientPrintList.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemVisitPatientPrintList.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemVisitPatientPrintList.Icon = ((System.Drawing.Icon)(resources.GetObject("buttonItemVisitPatientPrintList.Icon")));
            this.buttonItemVisitPatientPrintList.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium;
            this.buttonItemVisitPatientPrintList.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemVisitPatientPrintList.Name = "buttonItemVisitPatientPrintList";
            this.buttonItemVisitPatientPrintList.Tag = "305";
            this.buttonItemVisitPatientPrintList.Text = "چاپ برگه های ویزیت";
            this.buttonItemVisitPatientPrintList.ThemeAware = true;
            this.buttonItemVisitPatientPrintList.Visible = false;
            this.buttonItemVisitPatientPrintList.Click += new System.EventHandler(this.buttonItemVisitPatientPrintList_Click);
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
            this.itemContainer2.Visible = false;
            // 
            // buttonItemSendVisitPayment
            // 
            this.buttonItemSendVisitPayment.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemSendVisitPayment.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemSendVisitPayment.Icon = ((System.Drawing.Icon)(resources.GetObject("buttonItemSendVisitPayment.Icon")));
            this.buttonItemSendVisitPayment.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium;
            this.buttonItemSendVisitPayment.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemSendVisitPayment.Name = "buttonItemSendVisitPayment";
            this.buttonItemSendVisitPayment.Tag = "220";
            this.buttonItemSendVisitPayment.Text = "تاييد و ارسال جهت بيمه";
            this.buttonItemSendVisitPayment.ThemeAware = true;
            this.buttonItemSendVisitPayment.Click += new System.EventHandler(this.buttonItemSendVisitPayment_Click);
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
            this.buttonItemFiling.Tag = "217";
            this.buttonItemFiling.Text = "فایل های ویزیت";
            this.buttonItemFiling.ThemeAware = true;
            this.buttonItemFiling.Click += new System.EventHandler(this.buttonItemFiling_Click);
            // 
            // mssPanel1
            // 
            this.mssPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.mssPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.mssPanel1.Controls.Add(this.ButtonReciveFileDate);
            this.mssPanel1.Controls.Add(this.RadioBoxAllContract);
            this.mssPanel1.Controls.Add(this.DatePickerReciveFileDate);
            this.mssPanel1.Controls.Add(this.mssLabel1);
            this.mssPanel1.Controls.Add(this.mssLabel4);
            this.mssPanel1.Controls.Add(this.mssLabel2);
            this.mssPanel1.Controls.Add(this.mssLabel3);
            this.mssPanel1.Controls.Add(this.RadioBoxVisitStatus1);
            this.mssPanel1.Controls.Add(this.DatePickerStart);
            this.mssPanel1.Controls.Add(this.RadioBoxVisitStatus2);
            this.mssPanel1.Controls.Add(this.DatePickerEnd);
            this.mssPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mssPanel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.mssPanel1.Location = new System.Drawing.Point(0, 467);
            this.mssPanel1.Name = "mssPanel1";
            this.mssPanel1.Size = new System.Drawing.Size(1140, 61);
            this.mssPanel1.Style.Alignment = System.Drawing.StringAlignment.Center;
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
            this.ButtonReciveFileDate.Location = new System.Drawing.Point(24, 4);
            this.ButtonReciveFileDate.Name = "ButtonReciveFileDate";
            this.ButtonReciveFileDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ButtonReciveFileDate.Size = new System.Drawing.Size(52, 23);
            this.ButtonReciveFileDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonReciveFileDate.TabIndex = 9;
            this.ButtonReciveFileDate.Tag = "221";
            this.ButtonReciveFileDate.Text = "ثبت";
            this.ButtonReciveFileDate.Click += new System.EventHandler(this.ButtonReciveFileDate_Click);
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
            this.RadioBoxAllContract.Location = new System.Drawing.Point(863, 6);
            this.RadioBoxAllContract.Name = "RadioBoxAllContract";
            this.RadioBoxAllContract.Size = new System.Drawing.Size(84, 17);
            this.RadioBoxAllContract.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.RadioBoxAllContract.TabIndex = 1;
            this.RadioBoxAllContract.TabStop = false;
            this.RadioBoxAllContract.Text = "کل ویزیت ها";
            this.RadioBoxAllContract.TextColor = System.Drawing.Color.Black;
            this.RadioBoxAllContract.CheckValueChanged += new System.EventHandler(this.RadioBoxAllContract_CheckValueChanged);
            // 
            // DatePickerReciveFileDate
            // 
            this.DatePickerReciveFileDate.BackColor = System.Drawing.Color.White;
            this.DatePickerReciveFileDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.DatePickerReciveFileDate.Location = new System.Drawing.Point(82, 6);
            this.DatePickerReciveFileDate.Name = "DatePickerReciveFileDate";
            this.DatePickerReciveFileDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DatePickerReciveFileDate.ShowTime = false;
            this.DatePickerReciveFileDate.Size = new System.Drawing.Size(103, 18);
            this.DatePickerReciveFileDate.TabIndex = 8;
            this.DatePickerReciveFileDate.Text = "mssDatePicker1";
            this.DatePickerReciveFileDate.UseFarsiDigits = true;
            this.DatePickerReciveFileDate.Value = ((KagNetComponents2.KagPersianDate)(resources.GetObject("DatePickerReciveFileDate.Value")));
            this.DatePickerReciveFileDate.ValueEn = new System.DateTime(2017, 3, 6, 18, 57, 29, 0);
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
            this.mssLabel1.Location = new System.Drawing.Point(741, 33);
            this.mssLabel1.Name = "mssLabel1";
            this.mssLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mssLabel1.Size = new System.Drawing.Size(171, 17);
            this.mssLabel1.TabIndex = 0;
            this.mssLabel1.Text = "تاریخ ویزیت ها براساس بازه زمانی";
            // 
            // mssLabel4
            // 
            this.mssLabel4.AutoSize = true;
            // 
            // 
            // 
            this.mssLabel4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mssLabel4.ForeColor = System.Drawing.Color.Black;
            this.mssLabel4.Location = new System.Drawing.Point(191, 6);
            this.mssLabel4.Name = "mssLabel4";
            this.mssLabel4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mssLabel4.Size = new System.Drawing.Size(80, 16);
            this.mssLabel4.TabIndex = 7;
            this.mssLabel4.Text = "تاریخ تحویل فایل:";
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
            this.mssLabel2.Location = new System.Drawing.Point(693, 33);
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
            this.mssLabel3.Location = new System.Drawing.Point(529, 33);
            this.mssLabel3.Name = "mssLabel3";
            this.mssLabel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mssLabel3.Size = new System.Drawing.Size(37, 16);
            this.mssLabel3.TabIndex = 0;
            this.mssLabel3.Text = "تا تاریخ:";
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
            this.RadioBoxVisitStatus1.Location = new System.Drawing.Point(741, 6);
            this.RadioBoxVisitStatus1.Name = "RadioBoxVisitStatus1";
            this.RadioBoxVisitStatus1.Size = new System.Drawing.Size(88, 17);
            this.RadioBoxVisitStatus1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.RadioBoxVisitStatus1.TabIndex = 2;
            this.RadioBoxVisitStatus1.Text = "در انتظار تایید";
            this.RadioBoxVisitStatus1.TextColor = System.Drawing.Color.Black;
            this.RadioBoxVisitStatus1.CheckValueChanged += new System.EventHandler(this.RadioBoxAllContract_CheckValueChanged);
            // 
            // DatePickerStart
            // 
            this.DatePickerStart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DatePickerStart.BackColor = System.Drawing.Color.White;
            this.DatePickerStart.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.DatePickerStart.Location = new System.Drawing.Point(575, 33);
            this.DatePickerStart.Name = "DatePickerStart";
            this.DatePickerStart.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DatePickerStart.ShowTime = false;
            this.DatePickerStart.Size = new System.Drawing.Size(115, 18);
            this.DatePickerStart.TabIndex = 6;
            this.DatePickerStart.Text = "mssDatePicker1";
            this.DatePickerStart.UseFarsiDigits = true;
            this.DatePickerStart.Value = ((KagNetComponents2.KagPersianDate)(resources.GetObject("DatePickerStart.Value")));
            this.DatePickerStart.ValueEn = new System.DateTime(2017, 3, 6, 18, 57, 29, 0);
            this.DatePickerStart.ValueChanged += new KagNetComponents2.KagPersianDatePicker.onValueChanged(this.DatePickerStart_ValueChanged);
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
            this.RadioBoxVisitStatus2.Location = new System.Drawing.Point(588, 6);
            this.RadioBoxVisitStatus2.Name = "RadioBoxVisitStatus2";
            this.RadioBoxVisitStatus2.Size = new System.Drawing.Size(126, 17);
            this.RadioBoxVisitStatus2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.RadioBoxVisitStatus2.TabIndex = 3;
            this.RadioBoxVisitStatus2.Text = "تایید و ارسال به بیمه";
            this.RadioBoxVisitStatus2.TextColor = System.Drawing.Color.Black;
            this.RadioBoxVisitStatus2.CheckValueChanged += new System.EventHandler(this.RadioBoxAllContract_CheckValueChanged);
            // 
            // DatePickerEnd
            // 
            this.DatePickerEnd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DatePickerEnd.BackColor = System.Drawing.Color.White;
            this.DatePickerEnd.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.DatePickerEnd.Location = new System.Drawing.Point(408, 33);
            this.DatePickerEnd.Name = "DatePickerEnd";
            this.DatePickerEnd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DatePickerEnd.ShowTime = false;
            this.DatePickerEnd.Size = new System.Drawing.Size(115, 18);
            this.DatePickerEnd.TabIndex = 7;
            this.DatePickerEnd.Text = "mssDatePicker1";
            this.DatePickerEnd.UseFarsiDigits = true;
            this.DatePickerEnd.Value = ((KagNetComponents2.KagPersianDate)(resources.GetObject("DatePickerEnd.Value")));
            this.DatePickerEnd.ValueEn = new System.DateTime(2017, 3, 6, 18, 57, 29, 0);
            this.DatePickerEnd.ValueChanged += new KagNetComponents2.KagPersianDatePicker.onValueChanged(this.DatePickerStart_ValueChanged);
            // 
            // VisitPatient_UC
            // 
            this.Controls.Add(this.GridViewVisitPatietSet);
            this.Controls.Add(this.mssPanel1);
            this.Controls.Add(this.HeaderGridVisitPatient);
            this.Name = "VisitPatient_UC";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(1140, 528);
            this.Tag = "لیست ویزیت  ها";
            this.Load += new System.EventHandler(this.VisitPatient_UC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewVisitPatietSet)).EndInit();
            this.ContextMenuStripStatus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vWVisitPatientBindingSource)).EndInit();
            this.mssPanel1.ResumeLayout(false);
            this.mssPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MSSHeaderGrid HeaderGridVisitPatient;
        private MSSGridexView GridViewVisitPatietSet;
        private DevComponents.DotNetBar.ButtonItem buttonItemFiling;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel1;
        private DevComponents.DotNetBar.ButtonItem buttonItemSendVisitPayment;
        private DevComponents.DotNetBar.ItemContainer itemContainer1;
        private DevComponents.DotNetBar.ItemContainer itemContainer2;
        private MSSContextMenuStrip ContextMenuStripStatus;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemStatusVisit;
        private DevComponents.DotNetBar.ButtonItem buttonItemSendSMS;
        private MSSPanel mssPanel1;
        private MSSButton ButtonReciveFileDate;
        private MSSCheckBox RadioBoxAllContract;
        private MSSDatePicker DatePickerReciveFileDate;
        private MSSLabel mssLabel1;
        private MSSLabel mssLabel4;
        private MSSLabel mssLabel2;
        private MSSLabel mssLabel3;
        private MSSCheckBox RadioBoxVisitStatus1;
        private MSSDatePicker DatePickerStart;
        private MSSCheckBox RadioBoxVisitStatus2;
        private MSSDatePicker DatePickerEnd;
        private System.Windows.Forms.BindingSource vWVisitPatientBindingSource;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemVisitPatientLog;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemVisitPatientCurrentRow;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemVisitPatientAllList;
        private DevComponents.DotNetBar.ItemContainer itemContainer3;
        private DevComponents.DotNetBar.ButtonItem buttonItemVisitPatientPrintList;
    }
}
