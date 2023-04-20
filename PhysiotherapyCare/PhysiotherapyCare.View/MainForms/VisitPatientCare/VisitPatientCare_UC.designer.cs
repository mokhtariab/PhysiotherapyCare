using MKH.Library.Control;

namespace PhysiotherapyCare.View.MainForms.VisitPatientCare
{
    partial class VisitPatientCare_UC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisitPatientCare_UC));
            Janus.Windows.GridEX.GridEXLayout GridViewVisitPatientCare_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.GridViewVisitPatientCare = new MKH.Library.Control.MSSGridexView();
            this.ContextMenuStripStatus = new MKH.Library.Control.MSSContextMenuStrip(this.components);
            this.ToolStripMenuItemStatusCare = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemVisitPatientCareLog = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemVisitPatientCareCurrentRow = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemVisitPatientCareAllList = new System.Windows.Forms.ToolStripMenuItem();
            this.vWVisitPatientCareBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HeaderGridVisitPatientCare = new MKH.Library.Control.MSSHeaderGrid();
            this.buttonItemSendSMS = new DevComponents.DotNetBar.ButtonItem();
            this.itemContainer2 = new DevComponents.DotNetBar.ItemContainer();
            this.buttonItemSendCarePayment = new DevComponents.DotNetBar.ButtonItem();
            this.itemContainer1 = new DevComponents.DotNetBar.ItemContainer();
            this.buttonItemFiling = new DevComponents.DotNetBar.ButtonItem();
            this.mssPanel1 = new MKH.Library.Control.MSSPanel(this.components);
            this.ButtonReciveFileDate = new MKH.Library.Control.MSSButton(this.components);
            this.DatePickerReciveFileDate = new MKH.Library.Control.MSSDatePicker(this.components);
            this.mssLabel4 = new MKH.Library.Control.MSSLabel(this.components);
            this.RadioBoxAllContract = new MKH.Library.Control.MSSCheckBox(this.components);
            this.RadioBoxContractWithTime = new MKH.Library.Control.MSSCheckBox(this.components);
            this.RadioBoxVisitStatus1 = new MKH.Library.Control.MSSCheckBox(this.components);
            this.RadioBoxVisitStatus2 = new MKH.Library.Control.MSSCheckBox(this.components);
            this.RadioBoxOnlineContract = new MKH.Library.Control.MSSCheckBox(this.components);
            this.DatePickerEnd = new MKH.Library.Control.MSSDatePicker(this.components);
            this.DatePickerStart = new MKH.Library.Control.MSSDatePicker(this.components);
            this.ComboBoxSerach = new MKH.Library.Control.MSSComboBox();
            this.comboItemLetterDate = new DevComponents.Editors.ComboItem();
            this.comboItemContractDate = new DevComponents.Editors.ComboItem();
            this.comboItemBeginDate = new DevComponents.Editors.ComboItem();
            this.comboItemEndDate = new DevComponents.Editors.ComboItem();
            this.mssLabel3 = new MKH.Library.Control.MSSLabel(this.components);
            this.mssLabel2 = new MKH.Library.Control.MSSLabel(this.components);
            this.mssLabel1 = new MKH.Library.Control.MSSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewVisitPatientCare)).BeginInit();
            this.ContextMenuStripStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vWVisitPatientCareBindingSource)).BeginInit();
            this.mssPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridViewVisitPatientCare
            // 
            this.GridViewVisitPatientCare.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.GridViewVisitPatientCare.AlternatingRowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewVisitPatientCare.BuiltInTextsData = resources.GetString("GridViewVisitPatientCare.BuiltInTextsData");
            this.GridViewVisitPatientCare.CardViewGridlines = Janus.Windows.GridEX.CardViewGridlines.Both;
            this.GridViewVisitPatientCare.ContextMenuStrip = this.ContextMenuStripStatus;
            this.GridViewVisitPatientCare.DataSource = this.vWVisitPatientCareBindingSource;
            this.GridViewVisitPatientCare.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            GridViewVisitPatientCare_DesignTimeLayout.LayoutString = resources.GetString("GridViewVisitPatientCare_DesignTimeLayout.LayoutString");
            this.GridViewVisitPatientCare.DesignTimeLayout = GridViewVisitPatientCare_DesignTimeLayout;
            this.GridViewVisitPatientCare.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewVisitPatientCare.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.GridViewVisitPatientCare.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.GridViewVisitPatientCare.Font = new System.Drawing.Font("Tahoma", 8.150944F);
            this.GridViewVisitPatientCare.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewVisitPatientCare.HideSelection = Janus.Windows.GridEX.HideSelection.Highlight;
            this.GridViewVisitPatientCare.Location = new System.Drawing.Point(0, 56);
            this.GridViewVisitPatientCare.Name = "GridViewVisitPatientCare";
            this.GridViewVisitPatientCare.RecordNavigator = true;
            this.GridViewVisitPatientCare.RowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewVisitPatientCare.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition;
            this.GridViewVisitPatientCare.RowHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewVisitPatientCare.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.GridViewVisitPatientCare.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelection;
            this.GridViewVisitPatientCare.Size = new System.Drawing.Size(925, 430);
            this.GridViewVisitPatientCare.TabIndex = 32;
            this.GridViewVisitPatientCare.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.GridViewVisitPatientCare.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010;
            this.GridViewVisitPatientCare.BindingDataSourceSet += new System.EventHandler(this.GridViewVisitPatientCare_BindingDataSourceSet);
            this.GridViewVisitPatientCare.DoubleClick += new System.EventHandler(this.headerGridVisitPatientCare_btnEditClick);
            // 
            // ContextMenuStripStatus
            // 
            this.ContextMenuStripStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemStatusCare,
            this.ToolStripMenuItemVisitPatientCareLog});
            this.ContextMenuStripStatus.Name = "ContextMenuStripStatus";
            this.ContextMenuStripStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ContextMenuStripStatus.Size = new System.Drawing.Size(150, 48);
            // 
            // ToolStripMenuItemStatusCare
            // 
            this.ToolStripMenuItemStatusCare.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripMenuItemStatusCare.Name = "ToolStripMenuItemStatusCare";
            this.ToolStripMenuItemStatusCare.Size = new System.Drawing.Size(149, 22);
            this.ToolStripMenuItemStatusCare.Tag = "74";
            this.ToolStripMenuItemStatusCare.Text = "بررسی وضعیت";
            this.ToolStripMenuItemStatusCare.Click += new System.EventHandler(this.ToolStripMenuItemStatus_Click);
            // 
            // ToolStripMenuItemVisitPatientCareLog
            // 
            this.ToolStripMenuItemVisitPatientCareLog.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemVisitPatientCareCurrentRow,
            this.ToolStripMenuItemVisitPatientCareAllList});
            this.ToolStripMenuItemVisitPatientCareLog.Name = "ToolStripMenuItemVisitPatientCareLog";
            this.ToolStripMenuItemVisitPatientCareLog.Size = new System.Drawing.Size(149, 22);
            this.ToolStripMenuItemVisitPatientCareLog.Text = "Log";
            // 
            // ToolStripMenuItemVisitPatientCareCurrentRow
            // 
            this.ToolStripMenuItemVisitPatientCareCurrentRow.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripMenuItemVisitPatientCareCurrentRow.Name = "ToolStripMenuItemVisitPatientCareCurrentRow";
            this.ToolStripMenuItemVisitPatientCareCurrentRow.Size = new System.Drawing.Size(140, 22);
            this.ToolStripMenuItemVisitPatientCareCurrentRow.Tag = "270";
            this.ToolStripMenuItemVisitPatientCareCurrentRow.Text = "سطر انتخابی";
            this.ToolStripMenuItemVisitPatientCareCurrentRow.Click += new System.EventHandler(this.ToolStripMenuItemVisitPatientCareCurrentRow_Click);
            // 
            // ToolStripMenuItemVisitPatientCareAllList
            // 
            this.ToolStripMenuItemVisitPatientCareAllList.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripMenuItemVisitPatientCareAllList.Name = "ToolStripMenuItemVisitPatientCareAllList";
            this.ToolStripMenuItemVisitPatientCareAllList.Size = new System.Drawing.Size(140, 22);
            this.ToolStripMenuItemVisitPatientCareAllList.Tag = "271";
            this.ToolStripMenuItemVisitPatientCareAllList.Text = "کل لیست";
            this.ToolStripMenuItemVisitPatientCareAllList.Click += new System.EventHandler(this.ToolStripMenuItemVisitPatientCareAllList_Click);
            // 
            // vWVisitPatientCareBindingSource
            // 
            this.vWVisitPatientCareBindingSource.DataSource = typeof(PhysiotherapyCare.Model.VisitPatientCare.VW_VisitPatientCare);
            // 
            // HeaderGridVisitPatientCare
            // 
            // 
            // 
            // 
            this.HeaderGridVisitPatientCare.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridVisitPatientCare.BackgroundStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridVisitPatientCare.BackgroundStyle.BorderBottomWidth = 1;
            this.HeaderGridVisitPatientCare.BackgroundStyle.BorderLeftWidth = 1;
            this.HeaderGridVisitPatientCare.BackgroundStyle.BorderRightWidth = 1;
            this.HeaderGridVisitPatientCare.BackgroundStyle.BorderTopWidth = 1;
            this.HeaderGridVisitPatientCare.BackgroundStyle.Class = "ItemPanel";
            this.HeaderGridVisitPatientCare.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.HeaderGridVisitPatientCare.BackgroundStyle.PaddingBottom = 1;
            this.HeaderGridVisitPatientCare.BackgroundStyle.PaddingLeft = 1;
            this.HeaderGridVisitPatientCare.BackgroundStyle.PaddingRight = 1;
            this.HeaderGridVisitPatientCare.BackgroundStyle.PaddingTop = 1;
            this.HeaderGridVisitPatientCare.ButtonDeletePermissionCode = 70;
            this.HeaderGridVisitPatientCare.ButtonDeleteVisible = true;
            this.HeaderGridVisitPatientCare.ButtonEditPermissionCode = 69;
            this.HeaderGridVisitPatientCare.ButtonEditVisible = true;
            this.HeaderGridVisitPatientCare.ButtonExcelExportVisible = true;
            this.HeaderGridVisitPatientCare.ButtonExcelPermissionCode = 72;
            this.HeaderGridVisitPatientCare.ButtonInsertPermissionCode = 68;
            this.HeaderGridVisitPatientCare.ButtonInsertVisible = true;
            this.HeaderGridVisitPatientCare.ButtonPrintExpertPermissionCode = 0;
            this.HeaderGridVisitPatientCare.ButtonPrintExpertVisible = false;
            this.HeaderGridVisitPatientCare.ButtonPrintPermissionCode = 71;
            this.HeaderGridVisitPatientCare.ButtonPrintVisible = true;
            this.HeaderGridVisitPatientCare.ButtonPrintWithDesignPermissionCode = 126;
            this.HeaderGridVisitPatientCare.ButtonPrintWithDesignVisible = true;
            this.HeaderGridVisitPatientCare.ButtonRefreshVisible = true;
            this.HeaderGridVisitPatientCare.ButtonSearchExpertVisible = false;
            this.HeaderGridVisitPatientCare.ButtonSearchVisible = true;
            this.HeaderGridVisitPatientCare.ButtonSelectorVisible = true;
            this.HeaderGridVisitPatientCare.ContainerControlProcessDialogKey = true;
            this.HeaderGridVisitPatientCare.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderGridVisitPatientCare.FitButtonsToContainerWidth = true;
            this.HeaderGridVisitPatientCare.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.HeaderGridVisitPatientCare.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.HeaderGridVisitPatientCare.GridViewSet = this.GridViewVisitPatientCare;
            this.HeaderGridVisitPatientCare.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItemSendSMS,
            this.itemContainer2,
            this.buttonItemSendCarePayment,
            this.itemContainer1,
            this.buttonItemFiling});
            this.HeaderGridVisitPatientCare.Location = new System.Drawing.Point(0, 0);
            this.HeaderGridVisitPatientCare.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HeaderGridVisitPatientCare.Name = "HeaderGridVisitPatientCare";
            this.HeaderGridVisitPatientCare.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HeaderGridVisitPatientCare.Size = new System.Drawing.Size(925, 56);
            this.HeaderGridVisitPatientCare.TabIndex = 31;
            this.HeaderGridVisitPatientCare.Tag = "پزشکان";
            this.HeaderGridVisitPatientCare.Text = "پزشکان";
            this.HeaderGridVisitPatientCare.ThemeAware = true;
            this.HeaderGridVisitPatientCare.buttonItemInsertClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemInsertClickEventHandler(this.headerGridVisitPatientCare_btnInsertClick);
            this.HeaderGridVisitPatientCare.buttonItemEditClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemEditClickEventHandler(this.headerGridVisitPatientCare_btnEditClick);
            this.HeaderGridVisitPatientCare.buttonItemDeleteClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemDeleteClickEventHandler(this.headerGridVisitPatientCare_btnDeleteClick);
            this.HeaderGridVisitPatientCare.buttonItemRefreshClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemRefreshClickEventHandler(this.headerGridVisitPatientCare_btnRefreshClick);
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
            this.buttonItemSendSMS.Tag = "207";
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
            // buttonItemSendCarePayment
            // 
            this.buttonItemSendCarePayment.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemSendCarePayment.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemSendCarePayment.Icon = ((System.Drawing.Icon)(resources.GetObject("buttonItemSendCarePayment.Icon")));
            this.buttonItemSendCarePayment.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium;
            this.buttonItemSendCarePayment.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemSendCarePayment.Name = "buttonItemSendCarePayment";
            this.buttonItemSendCarePayment.Tag = "128";
            this.buttonItemSendCarePayment.Text = "تایید و ارسال جهت بیمه";
            this.buttonItemSendCarePayment.ThemeAware = true;
            this.buttonItemSendCarePayment.Click += new System.EventHandler(this.buttonItemSendCarePayment_Click);
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
            this.buttonItemFiling.Tag = "73";
            this.buttonItemFiling.Text = "فایل های مراقبت";
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
            this.mssPanel1.Controls.Add(this.RadioBoxVisitStatus2);
            this.mssPanel1.Controls.Add(this.RadioBoxOnlineContract);
            this.mssPanel1.Controls.Add(this.DatePickerEnd);
            this.mssPanel1.Controls.Add(this.DatePickerStart);
            this.mssPanel1.Controls.Add(this.ComboBoxSerach);
            this.mssPanel1.Controls.Add(this.mssLabel3);
            this.mssPanel1.Controls.Add(this.mssLabel2);
            this.mssPanel1.Controls.Add(this.mssLabel1);
            this.mssPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mssPanel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.mssPanel1.Location = new System.Drawing.Point(0, 486);
            this.mssPanel1.Name = "mssPanel1";
            this.mssPanel1.Size = new System.Drawing.Size(925, 61);
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
            this.ButtonReciveFileDate.Location = new System.Drawing.Point(21, 9);
            this.ButtonReciveFileDate.Name = "ButtonReciveFileDate";
            this.ButtonReciveFileDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ButtonReciveFileDate.Size = new System.Drawing.Size(52, 23);
            this.ButtonReciveFileDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonReciveFileDate.TabIndex = 10;
            this.ButtonReciveFileDate.Tag = "199";
            this.ButtonReciveFileDate.Text = "ثبت";
            this.ButtonReciveFileDate.Click += new System.EventHandler(this.ButtonReciveFileDate_Click);
            // 
            // DatePickerReciveFileDate
            // 
            this.DatePickerReciveFileDate.BackColor = System.Drawing.Color.White;
            this.DatePickerReciveFileDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.DatePickerReciveFileDate.Location = new System.Drawing.Point(79, 11);
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
            this.mssLabel4.Location = new System.Drawing.Point(188, 11);
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
            this.RadioBoxAllContract.Location = new System.Drawing.Point(739, 8);
            this.RadioBoxAllContract.Name = "RadioBoxAllContract";
            this.RadioBoxAllContract.Size = new System.Drawing.Size(79, 17);
            this.RadioBoxAllContract.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.RadioBoxAllContract.TabIndex = 1;
            this.RadioBoxAllContract.TabStop = false;
            this.RadioBoxAllContract.Text = "کل قرادادها";
            this.RadioBoxAllContract.TextColor = System.Drawing.Color.Black;
            // 
            // RadioBoxContractWithTime
            // 
            this.RadioBoxContractWithTime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.RadioBoxContractWithTime.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.RadioBoxContractWithTime.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.RadioBoxContractWithTime.Location = new System.Drawing.Point(652, 30);
            this.RadioBoxContractWithTime.Name = "RadioBoxContractWithTime";
            this.RadioBoxContractWithTime.Size = new System.Drawing.Size(169, 23);
            this.RadioBoxContractWithTime.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.RadioBoxContractWithTime.TabIndex = 5;
            this.RadioBoxContractWithTime.TabStop = false;
            this.RadioBoxContractWithTime.Text = "قرادادها براساس بازه زمانی";
            this.RadioBoxContractWithTime.TextColor = System.Drawing.Color.Black;
            this.RadioBoxContractWithTime.CheckedChanged += new System.EventHandler(this.RadioBoxOnlineContract_CheckedChanged);
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
            this.RadioBoxVisitStatus1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.RadioBoxVisitStatus1.Location = new System.Drawing.Point(501, 8);
            this.RadioBoxVisitStatus1.Name = "RadioBoxVisitStatus1";
            this.RadioBoxVisitStatus1.Size = new System.Drawing.Size(88, 17);
            this.RadioBoxVisitStatus1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.RadioBoxVisitStatus1.TabIndex = 3;
            this.RadioBoxVisitStatus1.Text = "در انتظار تایید";
            this.RadioBoxVisitStatus1.TextColor = System.Drawing.Color.Black;
            this.RadioBoxVisitStatus1.CheckedChanged += new System.EventHandler(this.RadioBoxOnlineContract_CheckedChanged);
            // 
            // RadioBoxVisitStatus2
            // 
            this.RadioBoxVisitStatus2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RadioBoxVisitStatus2.AutoSize = true;
            // 
            // 
            // 
            this.RadioBoxVisitStatus2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.RadioBoxVisitStatus2.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.RadioBoxVisitStatus2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.RadioBoxVisitStatus2.Location = new System.Drawing.Point(348, 8);
            this.RadioBoxVisitStatus2.Name = "RadioBoxVisitStatus2";
            this.RadioBoxVisitStatus2.Size = new System.Drawing.Size(141, 17);
            this.RadioBoxVisitStatus2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.RadioBoxVisitStatus2.TabIndex = 4;
            this.RadioBoxVisitStatus2.Text = "تایید و ارسال جهت بیمه";
            this.RadioBoxVisitStatus2.TextColor = System.Drawing.Color.Black;
            this.RadioBoxVisitStatus2.CheckedChanged += new System.EventHandler(this.RadioBoxOnlineContract_CheckedChanged);
            // 
            // RadioBoxOnlineContract
            // 
            this.RadioBoxOnlineContract.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RadioBoxOnlineContract.AutoSize = true;
            // 
            // 
            // 
            this.RadioBoxOnlineContract.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.RadioBoxOnlineContract.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.RadioBoxOnlineContract.Checked = true;
            this.RadioBoxOnlineContract.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RadioBoxOnlineContract.CheckValue = "Y";
            this.RadioBoxOnlineContract.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.RadioBoxOnlineContract.Location = new System.Drawing.Point(613, 8);
            this.RadioBoxOnlineContract.Name = "RadioBoxOnlineContract";
            this.RadioBoxOnlineContract.Size = new System.Drawing.Size(102, 17);
            this.RadioBoxOnlineContract.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.RadioBoxOnlineContract.TabIndex = 2;
            this.RadioBoxOnlineContract.Text = "قرادادهای جاری";
            this.RadioBoxOnlineContract.TextColor = System.Drawing.Color.Black;
            this.RadioBoxOnlineContract.CheckedChanged += new System.EventHandler(this.RadioBoxOnlineContract_CheckedChanged);
            // 
            // DatePickerEnd
            // 
            this.DatePickerEnd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DatePickerEnd.BackColor = System.Drawing.Color.White;
            this.DatePickerEnd.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.DatePickerEnd.Location = new System.Drawing.Point(104, 35);
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
            this.DatePickerStart.Location = new System.Drawing.Point(271, 35);
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
            this.comboItemBeginDate,
            this.comboItemEndDate});
            this.ComboBoxSerach.Location = new System.Drawing.Point(470, 32);
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
            // comboItemBeginDate
            // 
            this.comboItemBeginDate.Text = "تاریخ شروع مراقبت";
            // 
            // comboItemEndDate
            // 
            this.comboItemEndDate.Text = "تاریح پایان مراقبت";
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
            this.mssLabel3.Location = new System.Drawing.Point(225, 35);
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
            this.mssLabel2.Location = new System.Drawing.Point(389, 35);
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
            this.mssLabel1.Location = new System.Drawing.Point(583, 35);
            this.mssLabel1.Name = "mssLabel1";
            this.mssLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mssLabel1.Size = new System.Drawing.Size(36, 17);
            this.mssLabel1.TabIndex = 0;
            this.mssLabel1.Text = "ستون:";
            // 
            // VisitPatientCare_UC
            // 
            this.Controls.Add(this.GridViewVisitPatientCare);
            this.Controls.Add(this.mssPanel1);
            this.Controls.Add(this.HeaderGridVisitPatientCare);
            this.Name = "VisitPatientCare_UC";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(925, 547);
            this.Tag = "لیست مراقبت ها";
            this.Load += new System.EventHandler(this.VisitPatientCare_UC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewVisitPatientCare)).EndInit();
            this.ContextMenuStripStatus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vWVisitPatientCareBindingSource)).EndInit();
            this.mssPanel1.ResumeLayout(false);
            this.mssPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MSSHeaderGrid HeaderGridVisitPatientCare;
        private MSSGridexView GridViewVisitPatientCare;
        private System.Windows.Forms.BindingSource vWVisitPatientCareBindingSource;
        private DevComponents.DotNetBar.ButtonItem buttonItemFiling;
        private MSSPanel mssPanel1;
        private MSSDatePicker DatePickerEnd;
        private MSSDatePicker DatePickerStart;
        private MSSComboBox ComboBoxSerach;
        private DevComponents.Editors.ComboItem comboItemLetterDate;
        private DevComponents.Editors.ComboItem comboItemContractDate;
        private DevComponents.Editors.ComboItem comboItemBeginDate;
        private DevComponents.Editors.ComboItem comboItemEndDate;
        private MSSLabel mssLabel3;
        private MSSLabel mssLabel2;
        private MSSLabel mssLabel1;
        private DevComponents.DotNetBar.ItemContainer itemContainer2;
        private DevComponents.DotNetBar.ButtonItem buttonItemSendCarePayment;
        private DevComponents.DotNetBar.ItemContainer itemContainer1;
        private MSSCheckBox RadioBoxAllContract;
        private MSSCheckBox RadioBoxOnlineContract;
        private MSSContextMenuStrip ContextMenuStripStatus;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemStatusCare;
        private MSSCheckBox RadioBoxContractWithTime;
        private MSSCheckBox RadioBoxVisitStatus1;
        private MSSCheckBox RadioBoxVisitStatus2;
        private DevComponents.DotNetBar.ButtonItem buttonItemSendSMS;
        private MSSButton ButtonReciveFileDate;
        private MSSDatePicker DatePickerReciveFileDate;
        private MSSLabel mssLabel4;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemVisitPatientCareLog;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemVisitPatientCareCurrentRow;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemVisitPatientCareAllList;
    }
}
