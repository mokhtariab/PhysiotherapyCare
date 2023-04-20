using MKH.Library.Control;

namespace PhysiotherapyCare.View.MainForms.Patient
{
    partial class Patient_UC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Patient_UC));
            Janus.Windows.GridEX.GridEXLayout GridViewPatient_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.GridViewPatient = new MKH.Library.Control.MSSGridexView();
            this.ContextMenuStripStatus = new MKH.Library.Control.MSSContextMenuStrip(this.components);
            this.ToolStripMenuItemVisit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemVisitPatientInsert = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemDoctorInsert = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemStatusPatient = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemPatientLog = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemPatientCurrentRow = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemPatientAllList = new System.Windows.Forms.ToolStripMenuItem();
            this.vWPatientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HeaderGridPatient = new MKH.Library.Control.MSSHeaderGrid();
            this.buttonItemDelPatient = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemDelPatientDead = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemDelPatientCancel = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemNoHamkar = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemMosalah = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemNoCotract = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemDelPatientOther = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemSendSMS = new DevComponents.DotNetBar.ButtonItem();
            this.itemContainer1 = new DevComponents.DotNetBar.ItemContainer();
            this.buttonItemFiling = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemPatientCareList = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemPatientPhysiotherapy = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemVisitHealthCare = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemVisitPatient = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem2 = new DevComponents.DotNetBar.ButtonItem();
            this.mssPanel1 = new MKH.Library.Control.MSSPanel(this.components);
            this.RadioBoxWithTime = new MKH.Library.Control.MSSCheckBox(this.components);
            this.DatePickerEnd = new MKH.Library.Control.MSSDatePicker(this.components);
            this.DatePickerStart = new MKH.Library.Control.MSSDatePicker(this.components);
            this.ComboBoxSerach = new MKH.Library.Control.MSSComboBox();
            this.comboItemLastCareDate = new DevComponents.Editors.ComboItem();
            this.comboItemLastPhysiotherapyDate = new DevComponents.Editors.ComboItem();
            this.comboItemLastHealthCareDate = new DevComponents.Editors.ComboItem();
            this.comboItemLastVisitDate = new DevComponents.Editors.ComboItem();
            this.mssLabel3 = new MKH.Library.Control.MSSLabel(this.components);
            this.mssLabel2 = new MKH.Library.Control.MSSLabel(this.components);
            this.mssLabel1 = new MKH.Library.Control.MSSLabel(this.components);
            this.TextBoxDosiersNoSearch = new MKH.Library.Control.MSSTextBox(this.components);
            this.TextBoxNationalCodeSearch = new MKH.Library.Control.MSSTextBox(this.components);
            this.RadioBoxAllPatient = new MKH.Library.Control.MSSCheckBox(this.components);
            this.RadioBoxDosiersNo = new MKH.Library.Control.MSSCheckBox(this.components);
            this.RadioBoxNationalCodes = new MKH.Library.Control.MSSCheckBox(this.components);
            this.RadioBoxPatientVisit = new MKH.Library.Control.MSSCheckBox(this.components);
            this.RadioBoxPatientHealth = new MKH.Library.Control.MSSCheckBox(this.components);
            this.RadioBoxPatientCare = new MKH.Library.Control.MSSCheckBox(this.components);
            this.RadioBoxPatientPhysioterapy = new MKH.Library.Control.MSSCheckBox(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewPatient)).BeginInit();
            this.ContextMenuStripStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vWPatientBindingSource)).BeginInit();
            this.mssPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridViewPatient
            // 
            this.GridViewPatient.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.GridViewPatient.AlternatingColors = true;
            this.GridViewPatient.AlternatingRowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewPatient.BuiltInTextsData = resources.GetString("GridViewPatient.BuiltInTextsData");
            this.GridViewPatient.CardViewGridlines = Janus.Windows.GridEX.CardViewGridlines.Both;
            this.GridViewPatient.ContextMenuStrip = this.ContextMenuStripStatus;
            this.GridViewPatient.DataSource = this.vWPatientBindingSource;
            this.GridViewPatient.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            GridViewPatient_DesignTimeLayout.LayoutString = resources.GetString("GridViewPatient_DesignTimeLayout.LayoutString");
            this.GridViewPatient.DesignTimeLayout = GridViewPatient_DesignTimeLayout;
            this.GridViewPatient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewPatient.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.GridViewPatient.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.GridViewPatient.Font = new System.Drawing.Font("Tahoma", 8.150944F);
            this.GridViewPatient.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewPatient.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
            this.GridViewPatient.Location = new System.Drawing.Point(0, 56);
            this.GridViewPatient.Name = "GridViewPatient";
            this.GridViewPatient.RecordNavigator = true;
            this.GridViewPatient.RowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewPatient.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition;
            this.GridViewPatient.RowHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewPatient.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.GridViewPatient.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelection;
            this.GridViewPatient.SettingsKey = "Patient_UC";
            this.GridViewPatient.Size = new System.Drawing.Size(1209, 340);
            this.GridViewPatient.TabIndex = 32;
            this.GridViewPatient.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.GridViewPatient.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010;
            this.GridViewPatient.DoubleClick += new System.EventHandler(this.headerGridPatient_btnEditClick);
            // 
            // ContextMenuStripStatus
            // 
            this.ContextMenuStripStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemVisit,
            this.ToolStripMenuItemStatusPatient,
            this.ToolStripMenuItemPatientLog});
            this.ContextMenuStripStatus.Name = "ContextMenuStripStatus";
            this.ContextMenuStripStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ContextMenuStripStatus.Size = new System.Drawing.Size(150, 70);
            // 
            // ToolStripMenuItemVisit
            // 
            this.ToolStripMenuItemVisit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemVisitPatientInsert,
            this.ToolStripMenuItemDoctorInsert});
            this.ToolStripMenuItemVisit.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripMenuItemVisit.Name = "ToolStripMenuItemVisit";
            this.ToolStripMenuItemVisit.Size = new System.Drawing.Size(149, 22);
            this.ToolStripMenuItemVisit.Tag = "";
            this.ToolStripMenuItemVisit.Text = "ویزیت";
            // 
            // ToolStripMenuItemVisitPatientInsert
            // 
            this.ToolStripMenuItemVisitPatientInsert.Name = "ToolStripMenuItemVisitPatientInsert";
            this.ToolStripMenuItemVisitPatientInsert.Size = new System.Drawing.Size(200, 22);
            this.ToolStripMenuItemVisitPatientInsert.Tag = "306";
            this.ToolStripMenuItemVisitPatientInsert.Text = "ثبت ویزیت گروهی بیماران";
            this.ToolStripMenuItemVisitPatientInsert.Click += new System.EventHandler(this.ToolStripMenuItemVisitPatientInsert_Click);
            // 
            // ToolStripMenuItemDoctorInsert
            // 
            this.ToolStripMenuItemDoctorInsert.Name = "ToolStripMenuItemDoctorInsert";
            this.ToolStripMenuItemDoctorInsert.Size = new System.Drawing.Size(200, 22);
            this.ToolStripMenuItemDoctorInsert.Tag = "307";
            this.ToolStripMenuItemDoctorInsert.Text = "تعیین پزشک ویزیت";
            this.ToolStripMenuItemDoctorInsert.Click += new System.EventHandler(this.ToolStripMenuItemDoctorInsert_Click);
            // 
            // ToolStripMenuItemStatusPatient
            // 
            this.ToolStripMenuItemStatusPatient.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripMenuItemStatusPatient.Name = "ToolStripMenuItemStatusPatient";
            this.ToolStripMenuItemStatusPatient.Size = new System.Drawing.Size(149, 22);
            this.ToolStripMenuItemStatusPatient.Tag = "123";
            this.ToolStripMenuItemStatusPatient.Text = "بررسی وضعیت";
            this.ToolStripMenuItemStatusPatient.Click += new System.EventHandler(this.ToolStripMenuItemStatus_Click);
            // 
            // ToolStripMenuItemPatientLog
            // 
            this.ToolStripMenuItemPatientLog.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemPatientCurrentRow,
            this.ToolStripMenuItemPatientAllList});
            this.ToolStripMenuItemPatientLog.Name = "ToolStripMenuItemPatientLog";
            this.ToolStripMenuItemPatientLog.Size = new System.Drawing.Size(149, 22);
            this.ToolStripMenuItemPatientLog.Text = "Log";
            // 
            // ToolStripMenuItemPatientCurrentRow
            // 
            this.ToolStripMenuItemPatientCurrentRow.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripMenuItemPatientCurrentRow.Name = "ToolStripMenuItemPatientCurrentRow";
            this.ToolStripMenuItemPatientCurrentRow.Size = new System.Drawing.Size(140, 22);
            this.ToolStripMenuItemPatientCurrentRow.Tag = "283";
            this.ToolStripMenuItemPatientCurrentRow.Text = "سطر انتخابی";
            this.ToolStripMenuItemPatientCurrentRow.Click += new System.EventHandler(this.ToolStripMenuItemPatientCurrentRow_Click);
            // 
            // ToolStripMenuItemPatientAllList
            // 
            this.ToolStripMenuItemPatientAllList.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripMenuItemPatientAllList.Name = "ToolStripMenuItemPatientAllList";
            this.ToolStripMenuItemPatientAllList.Size = new System.Drawing.Size(140, 22);
            this.ToolStripMenuItemPatientAllList.Tag = "284";
            this.ToolStripMenuItemPatientAllList.Text = "کل لیست";
            this.ToolStripMenuItemPatientAllList.Click += new System.EventHandler(this.ToolStripMenuItemPatientAllList_Click);
            // 
            // vWPatientBindingSource
            // 
            this.vWPatientBindingSource.DataSource = typeof(PhysiotherapyCare.Model.Patient.VW_Patient);
            // 
            // HeaderGridPatient
            // 
            // 
            // 
            // 
            this.HeaderGridPatient.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridPatient.BackgroundStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridPatient.BackgroundStyle.BorderBottomWidth = 1;
            this.HeaderGridPatient.BackgroundStyle.BorderLeftWidth = 1;
            this.HeaderGridPatient.BackgroundStyle.BorderRightWidth = 1;
            this.HeaderGridPatient.BackgroundStyle.BorderTopWidth = 1;
            this.HeaderGridPatient.BackgroundStyle.Class = "ItemPanel";
            this.HeaderGridPatient.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.HeaderGridPatient.BackgroundStyle.PaddingBottom = 1;
            this.HeaderGridPatient.BackgroundStyle.PaddingLeft = 1;
            this.HeaderGridPatient.BackgroundStyle.PaddingRight = 1;
            this.HeaderGridPatient.BackgroundStyle.PaddingTop = 1;
            this.HeaderGridPatient.ButtonDeletePermissionCode = 0;
            this.HeaderGridPatient.ButtonDeleteVisible = false;
            this.HeaderGridPatient.ButtonEditPermissionCode = 28;
            this.HeaderGridPatient.ButtonEditVisible = true;
            this.HeaderGridPatient.ButtonExcelExportVisible = true;
            this.HeaderGridPatient.ButtonExcelPermissionCode = 31;
            this.HeaderGridPatient.ButtonInsertPermissionCode = 27;
            this.HeaderGridPatient.ButtonInsertVisible = true;
            this.HeaderGridPatient.ButtonPrintExpertPermissionCode = 0;
            this.HeaderGridPatient.ButtonPrintExpertVisible = false;
            this.HeaderGridPatient.ButtonPrintPermissionCode = 30;
            this.HeaderGridPatient.ButtonPrintVisible = true;
            this.HeaderGridPatient.ButtonPrintWithDesignPermissionCode = 122;
            this.HeaderGridPatient.ButtonPrintWithDesignVisible = true;
            this.HeaderGridPatient.ButtonRefreshVisible = true;
            this.HeaderGridPatient.ButtonSearchExpertVisible = false;
            this.HeaderGridPatient.ButtonSearchVisible = true;
            this.HeaderGridPatient.ButtonSelectorVisible = true;
            this.HeaderGridPatient.ContainerControlProcessDialogKey = true;
            this.HeaderGridPatient.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderGridPatient.FitButtonsToContainerWidth = true;
            this.HeaderGridPatient.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.HeaderGridPatient.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.HeaderGridPatient.GridViewSet = this.GridViewPatient;
            this.HeaderGridPatient.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItemDelPatient,
            this.buttonItemSendSMS,
            this.itemContainer1,
            this.buttonItemFiling,
            this.buttonItemPatientCareList,
            this.buttonItemPatientPhysiotherapy,
            this.buttonItemVisitHealthCare,
            this.buttonItemVisitPatient,
            this.buttonItem1,
            this.buttonItem2});
            this.HeaderGridPatient.Location = new System.Drawing.Point(0, 0);
            this.HeaderGridPatient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HeaderGridPatient.Name = "HeaderGridPatient";
            this.HeaderGridPatient.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HeaderGridPatient.Size = new System.Drawing.Size(1209, 56);
            this.HeaderGridPatient.TabIndex = 31;
            this.HeaderGridPatient.Tag = "";
            this.HeaderGridPatient.ThemeAware = true;
            this.HeaderGridPatient.buttonItemInsertClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemInsertClickEventHandler(this.headerGridPatient_btnInsertClick);
            this.HeaderGridPatient.buttonItemEditClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemEditClickEventHandler(this.headerGridPatient_btnEditClick);
            this.HeaderGridPatient.buttonItemRefreshClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemRefreshClickEventHandler(this.headerGridPatient_btnRefreshClick);
            // 
            // buttonItemDelPatient
            // 
            this.buttonItemDelPatient.BeginGroup = true;
            this.buttonItemDelPatient.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemDelPatient.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemDelPatient.Icon = ((System.Drawing.Icon)(resources.GetObject("buttonItemDelPatient.Icon")));
            this.buttonItemDelPatient.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium;
            this.buttonItemDelPatient.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemDelPatient.Name = "buttonItemDelPatient";
            this.buttonItemDelPatient.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItemDelPatientDead,
            this.buttonItemDelPatientCancel,
            this.buttonItemNoHamkar,
            this.buttonItemMosalah,
            this.buttonItemNoCotract,
            this.buttonItemDelPatientOther});
            this.buttonItemDelPatient.Tag = "29";
            this.buttonItemDelPatient.Text = "حذف";
            this.buttonItemDelPatient.ThemeAware = true;
            // 
            // buttonItemDelPatientDead
            // 
            this.buttonItemDelPatientDead.Name = "buttonItemDelPatientDead";
            this.buttonItemDelPatientDead.Text = "فوت";
            this.buttonItemDelPatientDead.ThemeAware = true;
            this.buttonItemDelPatientDead.Click += new System.EventHandler(this.buttonItemDelPatientDead_Click);
            // 
            // buttonItemDelPatientCancel
            // 
            this.buttonItemDelPatientCancel.Name = "buttonItemDelPatientCancel";
            this.buttonItemDelPatientCancel.Text = "انصراف";
            this.buttonItemDelPatientCancel.ThemeAware = true;
            this.buttonItemDelPatientCancel.Click += new System.EventHandler(this.buttonItemDelPatientDead_Click);
            // 
            // buttonItemNoHamkar
            // 
            this.buttonItemNoHamkar.Name = "buttonItemNoHamkar";
            this.buttonItemNoHamkar.Text = "عدم همکاری";
            this.buttonItemNoHamkar.ThemeAware = true;
            this.buttonItemNoHamkar.Click += new System.EventHandler(this.buttonItemDelPatientDead_Click);
            // 
            // buttonItemMosalah
            // 
            this.buttonItemMosalah.Name = "buttonItemMosalah";
            this.buttonItemMosalah.Text = "نیروهای مسلح";
            this.buttonItemMosalah.ThemeAware = true;
            this.buttonItemMosalah.Click += new System.EventHandler(this.buttonItemDelPatientDead_Click);
            // 
            // buttonItemNoCotract
            // 
            this.buttonItemNoCotract.Name = "buttonItemNoCotract";
            this.buttonItemNoCotract.Text = "عدم قرارداد";
            this.buttonItemNoCotract.ThemeAware = true;
            this.buttonItemNoCotract.Click += new System.EventHandler(this.buttonItemDelPatientDead_Click);
            // 
            // buttonItemDelPatientOther
            // 
            this.buttonItemDelPatientOther.Name = "buttonItemDelPatientOther";
            this.buttonItemDelPatientOther.Text = "سایر";
            this.buttonItemDelPatientOther.ThemeAware = true;
            this.buttonItemDelPatientOther.Click += new System.EventHandler(this.buttonItemDelPatientDead_Click);
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
            this.buttonItemSendSMS.Tag = "204";
            this.buttonItemSendSMS.Text = "SMS ارسال";
            this.buttonItemSendSMS.ThemeAware = true;
            this.buttonItemSendSMS.Click += new System.EventHandler(this.buttonItemSendSMS_Click);
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
            this.buttonItemFiling.BeginGroup = true;
            this.buttonItemFiling.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemFiling.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemFiling.Icon = ((System.Drawing.Icon)(resources.GetObject("buttonItemFiling.Icon")));
            this.buttonItemFiling.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium;
            this.buttonItemFiling.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemFiling.Name = "buttonItemFiling";
            this.buttonItemFiling.Tag = "32";
            this.buttonItemFiling.Text = "فایل های سوابق";
            this.buttonItemFiling.ThemeAware = true;
            this.buttonItemFiling.Click += new System.EventHandler(this.buttonItemFiling_Click);
            // 
            // buttonItemPatientCareList
            // 
            this.buttonItemPatientCareList.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemPatientCareList.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemPatientCareList.Icon = ((System.Drawing.Icon)(resources.GetObject("buttonItemPatientCareList.Icon")));
            this.buttonItemPatientCareList.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium;
            this.buttonItemPatientCareList.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemPatientCareList.Name = "buttonItemPatientCareList";
            this.buttonItemPatientCareList.Tag = "10";
            this.buttonItemPatientCareList.Text = "پرونده مراقبت";
            this.buttonItemPatientCareList.ThemeAware = true;
            this.buttonItemPatientCareList.Click += new System.EventHandler(this.buttonItemPatientCareList_Click);
            // 
            // buttonItemPatientPhysiotherapy
            // 
            this.buttonItemPatientPhysiotherapy.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemPatientPhysiotherapy.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemPatientPhysiotherapy.Icon = ((System.Drawing.Icon)(resources.GetObject("buttonItemPatientPhysiotherapy.Icon")));
            this.buttonItemPatientPhysiotherapy.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium;
            this.buttonItemPatientPhysiotherapy.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemPatientPhysiotherapy.Name = "buttonItemPatientPhysiotherapy";
            this.buttonItemPatientPhysiotherapy.Tag = "9";
            this.buttonItemPatientPhysiotherapy.Text = "پرونده فیزیو تراپی";
            this.buttonItemPatientPhysiotherapy.ThemeAware = true;
            this.buttonItemPatientPhysiotherapy.Click += new System.EventHandler(this.buttonItemPatientPhysiotherapy_Click);
            // 
            // buttonItemVisitHealthCare
            // 
            this.buttonItemVisitHealthCare.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemVisitHealthCare.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemVisitHealthCare.Icon = ((System.Drawing.Icon)(resources.GetObject("buttonItemVisitHealthCare.Icon")));
            this.buttonItemVisitHealthCare.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium;
            this.buttonItemVisitHealthCare.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemVisitHealthCare.Name = "buttonItemVisitHealthCare";
            this.buttonItemVisitHealthCare.Tag = "114";
            this.buttonItemVisitHealthCare.Text = "پرونده بهیاری";
            this.buttonItemVisitHealthCare.ThemeAware = true;
            this.buttonItemVisitHealthCare.Click += new System.EventHandler(this.buttonItemVisitHealthCare_Click);
            // 
            // buttonItemVisitPatient
            // 
            this.buttonItemVisitPatient.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemVisitPatient.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemVisitPatient.Icon = ((System.Drawing.Icon)(resources.GetObject("buttonItemVisitPatient.Icon")));
            this.buttonItemVisitPatient.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium;
            this.buttonItemVisitPatient.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemVisitPatient.Name = "buttonItemVisitPatient";
            this.buttonItemVisitPatient.Tag = "209";
            this.buttonItemVisitPatient.Text = "پرونده ویزیت";
            this.buttonItemVisitPatient.ThemeAware = true;
            this.buttonItemVisitPatient.Click += new System.EventHandler(this.buttonItemVisitPatient_Click);
            // 
            // buttonItem1
            // 
            this.buttonItem1.FixedSize = new System.Drawing.Size(50, 20);
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.ThemeAware = true;
            this.buttonItem1.Visible = false;
            this.buttonItem1.Click += new System.EventHandler(this.buttonItem1_Click);
            // 
            // buttonItem2
            // 
            this.buttonItem2.FixedSize = new System.Drawing.Size(50, 20);
            this.buttonItem2.Name = "buttonItem2";
            this.buttonItem2.ThemeAware = true;
            this.buttonItem2.Visible = false;
            this.buttonItem2.Click += new System.EventHandler(this.buttonItem2_Click);
            // 
            // mssPanel1
            // 
            this.mssPanel1.AutoScroll = true;
            this.mssPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.mssPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.mssPanel1.Controls.Add(this.RadioBoxWithTime);
            this.mssPanel1.Controls.Add(this.DatePickerEnd);
            this.mssPanel1.Controls.Add(this.DatePickerStart);
            this.mssPanel1.Controls.Add(this.ComboBoxSerach);
            this.mssPanel1.Controls.Add(this.mssLabel3);
            this.mssPanel1.Controls.Add(this.mssLabel2);
            this.mssPanel1.Controls.Add(this.mssLabel1);
            this.mssPanel1.Controls.Add(this.TextBoxDosiersNoSearch);
            this.mssPanel1.Controls.Add(this.TextBoxNationalCodeSearch);
            this.mssPanel1.Controls.Add(this.RadioBoxAllPatient);
            this.mssPanel1.Controls.Add(this.RadioBoxDosiersNo);
            this.mssPanel1.Controls.Add(this.RadioBoxNationalCodes);
            this.mssPanel1.Controls.Add(this.RadioBoxPatientVisit);
            this.mssPanel1.Controls.Add(this.RadioBoxPatientHealth);
            this.mssPanel1.Controls.Add(this.RadioBoxPatientCare);
            this.mssPanel1.Controls.Add(this.RadioBoxPatientPhysioterapy);
            this.mssPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mssPanel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.mssPanel1.Location = new System.Drawing.Point(0, 396);
            this.mssPanel1.Name = "mssPanel1";
            this.mssPanel1.Size = new System.Drawing.Size(1209, 109);
            this.mssPanel1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.mssPanel1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.mssPanel1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.mssPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.mssPanel1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.mssPanel1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.mssPanel1.Style.GradientAngle = 90;
            this.mssPanel1.TabIndex = 1;
            // 
            // RadioBoxWithTime
            // 
            this.RadioBoxWithTime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.RadioBoxWithTime.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.RadioBoxWithTime.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.RadioBoxWithTime.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.RadioBoxWithTime.Location = new System.Drawing.Point(834, 74);
            this.RadioBoxWithTime.Name = "RadioBoxWithTime";
            this.RadioBoxWithTime.Size = new System.Drawing.Size(203, 23);
            this.RadioBoxWithTime.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.RadioBoxWithTime.TabIndex = 10;
            this.RadioBoxWithTime.TabStop = false;
            this.RadioBoxWithTime.Text = "آخرین بازدیدها براساس بازه زمانی";
            this.RadioBoxWithTime.TextColor = System.Drawing.Color.Black;
            this.RadioBoxWithTime.CheckedChanged += new System.EventHandler(this.RadioBoxAllPatient_CheckedChanged);
            // 
            // DatePickerEnd
            // 
            this.DatePickerEnd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DatePickerEnd.BackColor = System.Drawing.Color.White;
            this.DatePickerEnd.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.DatePickerEnd.Location = new System.Drawing.Point(286, 77);
            this.DatePickerEnd.Name = "DatePickerEnd";
            this.DatePickerEnd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DatePickerEnd.ShowTime = false;
            this.DatePickerEnd.Size = new System.Drawing.Size(115, 18);
            this.DatePickerEnd.TabIndex = 13;
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
            this.DatePickerStart.Location = new System.Drawing.Point(453, 77);
            this.DatePickerStart.Name = "DatePickerStart";
            this.DatePickerStart.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DatePickerStart.ShowTime = false;
            this.DatePickerStart.Size = new System.Drawing.Size(115, 18);
            this.DatePickerStart.TabIndex = 12;
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
            this.comboItemLastCareDate,
            this.comboItemLastPhysiotherapyDate,
            this.comboItemLastHealthCareDate,
            this.comboItemLastVisitDate});
            this.ComboBoxSerach.Location = new System.Drawing.Point(652, 76);
            this.ComboBoxSerach.Name = "ComboBoxSerach";
            this.ComboBoxSerach.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ComboBoxSerach.Size = new System.Drawing.Size(107, 22);
            this.ComboBoxSerach.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ComboBoxSerach.TabIndex = 11;
            this.ComboBoxSerach.SelectedIndexChanged += new System.EventHandler(this.RadioBoxAllPatient_CheckedChanged);
            // 
            // comboItemLastCareDate
            // 
            this.comboItemLastCareDate.Text = "تاریخ آخرین مراقبت";
            // 
            // comboItemLastPhysiotherapyDate
            // 
            this.comboItemLastPhysiotherapyDate.Text = "تاریخ آخرین فیزیوتراپی";
            // 
            // comboItemLastHealthCareDate
            // 
            this.comboItemLastHealthCareDate.Text = "تاریخ آخرین بهیاری";
            // 
            // comboItemLastVisitDate
            // 
            this.comboItemLastVisitDate.Text = "تاریخ آخرین ویزیت";
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
            this.mssLabel3.Location = new System.Drawing.Point(407, 77);
            this.mssLabel3.Name = "mssLabel3";
            this.mssLabel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mssLabel3.Size = new System.Drawing.Size(37, 16);
            this.mssLabel3.TabIndex = 6;
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
            this.mssLabel2.Location = new System.Drawing.Point(571, 77);
            this.mssLabel2.Name = "mssLabel2";
            this.mssLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mssLabel2.Size = new System.Drawing.Size(38, 16);
            this.mssLabel2.TabIndex = 7;
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
            this.mssLabel1.Location = new System.Drawing.Point(765, 79);
            this.mssLabel1.Name = "mssLabel1";
            this.mssLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mssLabel1.Size = new System.Drawing.Size(36, 17);
            this.mssLabel1.TabIndex = 8;
            this.mssLabel1.Text = "ستون:";
            // 
            // TextBoxDosiersNoSearch
            // 
            this.TextBoxDosiersNoSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.TextBoxDosiersNoSearch.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxDosiersNoSearch.Font = new System.Drawing.Font("Tahoma", 8F);
            this.TextBoxDosiersNoSearch.Location = new System.Drawing.Point(67, 6);
            this.TextBoxDosiersNoSearch.Multiline = true;
            this.TextBoxDosiersNoSearch.Name = "TextBoxDosiersNoSearch";
            this.TextBoxDosiersNoSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TextBoxDosiersNoSearch.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBoxDosiersNoSearch.Size = new System.Drawing.Size(115, 57);
            this.TextBoxDosiersNoSearch.TabIndex = 9;
            // 
            // TextBoxNationalCodeSearch
            // 
            this.TextBoxNationalCodeSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.TextBoxNationalCodeSearch.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxNationalCodeSearch.Font = new System.Drawing.Font("Tahoma", 8F);
            this.TextBoxNationalCodeSearch.Location = new System.Drawing.Point(314, 6);
            this.TextBoxNationalCodeSearch.Multiline = true;
            this.TextBoxNationalCodeSearch.Name = "TextBoxNationalCodeSearch";
            this.TextBoxNationalCodeSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TextBoxNationalCodeSearch.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBoxNationalCodeSearch.Size = new System.Drawing.Size(115, 57);
            this.TextBoxNationalCodeSearch.TabIndex = 7;
            // 
            // RadioBoxAllPatient
            // 
            this.RadioBoxAllPatient.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RadioBoxAllPatient.AutoSize = true;
            // 
            // 
            // 
            this.RadioBoxAllPatient.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.RadioBoxAllPatient.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.RadioBoxAllPatient.Checked = true;
            this.RadioBoxAllPatient.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RadioBoxAllPatient.CheckValue = "Y";
            this.RadioBoxAllPatient.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.RadioBoxAllPatient.Location = new System.Drawing.Point(1072, 27);
            this.RadioBoxAllPatient.Name = "RadioBoxAllPatient";
            this.RadioBoxAllPatient.Size = new System.Drawing.Size(72, 17);
            this.RadioBoxAllPatient.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.RadioBoxAllPatient.TabIndex = 1;
            this.RadioBoxAllPatient.Text = "کل لیست";
            this.RadioBoxAllPatient.TextColor = System.Drawing.Color.Black;
            this.RadioBoxAllPatient.CheckedChanged += new System.EventHandler(this.RadioBoxAllPatient_CheckedChanged);
            // 
            // RadioBoxDosiersNo
            // 
            this.RadioBoxDosiersNo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.RadioBoxDosiersNo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.RadioBoxDosiersNo.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.RadioBoxDosiersNo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.RadioBoxDosiersNo.Location = new System.Drawing.Point(188, 6);
            this.RadioBoxDosiersNo.Name = "RadioBoxDosiersNo";
            this.RadioBoxDosiersNo.Size = new System.Drawing.Size(99, 57);
            this.RadioBoxDosiersNo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.RadioBoxDosiersNo.TabIndex = 8;
            this.RadioBoxDosiersNo.TabStop = false;
            this.RadioBoxDosiersNo.Text = "براساس شماره \r\nپرونده ها";
            this.RadioBoxDosiersNo.TextColor = System.Drawing.Color.Black;
            this.RadioBoxDosiersNo.CheckedChanged += new System.EventHandler(this.RadioBoxAllPatient_CheckedChanged);
            // 
            // RadioBoxNationalCodes
            // 
            this.RadioBoxNationalCodes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RadioBoxNationalCodes.AutoSize = true;
            // 
            // 
            // 
            this.RadioBoxNationalCodes.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.RadioBoxNationalCodes.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.RadioBoxNationalCodes.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.RadioBoxNationalCodes.Location = new System.Drawing.Point(435, 27);
            this.RadioBoxNationalCodes.Name = "RadioBoxNationalCodes";
            this.RadioBoxNationalCodes.Size = new System.Drawing.Size(117, 17);
            this.RadioBoxNationalCodes.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.RadioBoxNationalCodes.TabIndex = 6;
            this.RadioBoxNationalCodes.TabStop = false;
            this.RadioBoxNationalCodes.Text = "براساس کدملی ها";
            this.RadioBoxNationalCodes.TextColor = System.Drawing.Color.Black;
            this.RadioBoxNationalCodes.CheckedChanged += new System.EventHandler(this.RadioBoxAllPatient_CheckedChanged);
            // 
            // RadioBoxPatientVisit
            // 
            this.RadioBoxPatientVisit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RadioBoxPatientVisit.AutoSize = true;
            // 
            // 
            // 
            this.RadioBoxPatientVisit.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.RadioBoxPatientVisit.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.RadioBoxPatientVisit.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.RadioBoxPatientVisit.Location = new System.Drawing.Point(581, 27);
            this.RadioBoxPatientVisit.Name = "RadioBoxPatientVisit";
            this.RadioBoxPatientVisit.Size = new System.Drawing.Size(88, 17);
            this.RadioBoxPatientVisit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.RadioBoxPatientVisit.TabIndex = 5;
            this.RadioBoxPatientVisit.TabStop = false;
            this.RadioBoxPatientVisit.Text = "بیماران ویزیت";
            this.RadioBoxPatientVisit.TextColor = System.Drawing.Color.Black;
            this.RadioBoxPatientVisit.CheckedChanged += new System.EventHandler(this.RadioBoxAllPatient_CheckedChanged);
            // 
            // RadioBoxPatientHealth
            // 
            this.RadioBoxPatientHealth.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RadioBoxPatientHealth.AutoSize = true;
            // 
            // 
            // 
            this.RadioBoxPatientHealth.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.RadioBoxPatientHealth.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.RadioBoxPatientHealth.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.RadioBoxPatientHealth.Location = new System.Drawing.Point(696, 27);
            this.RadioBoxPatientHealth.Name = "RadioBoxPatientHealth";
            this.RadioBoxPatientHealth.Size = new System.Drawing.Size(92, 17);
            this.RadioBoxPatientHealth.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.RadioBoxPatientHealth.TabIndex = 4;
            this.RadioBoxPatientHealth.TabStop = false;
            this.RadioBoxPatientHealth.Text = "بیماران بهیاری";
            this.RadioBoxPatientHealth.TextColor = System.Drawing.Color.Black;
            this.RadioBoxPatientHealth.CheckedChanged += new System.EventHandler(this.RadioBoxAllPatient_CheckedChanged);
            // 
            // RadioBoxPatientCare
            // 
            this.RadioBoxPatientCare.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RadioBoxPatientCare.AutoSize = true;
            // 
            // 
            // 
            this.RadioBoxPatientCare.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.RadioBoxPatientCare.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.RadioBoxPatientCare.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.RadioBoxPatientCare.Location = new System.Drawing.Point(951, 27);
            this.RadioBoxPatientCare.Name = "RadioBoxPatientCare";
            this.RadioBoxPatientCare.Size = new System.Drawing.Size(94, 17);
            this.RadioBoxPatientCare.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.RadioBoxPatientCare.TabIndex = 2;
            this.RadioBoxPatientCare.Text = "بیماران مراقبت";
            this.RadioBoxPatientCare.TextColor = System.Drawing.Color.Black;
            this.RadioBoxPatientCare.CheckedChanged += new System.EventHandler(this.RadioBoxAllPatient_CheckedChanged);
            // 
            // RadioBoxPatientPhysioterapy
            // 
            this.RadioBoxPatientPhysioterapy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RadioBoxPatientPhysioterapy.AutoSize = true;
            // 
            // 
            // 
            this.RadioBoxPatientPhysioterapy.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.RadioBoxPatientPhysioterapy.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.RadioBoxPatientPhysioterapy.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.RadioBoxPatientPhysioterapy.Location = new System.Drawing.Point(815, 27);
            this.RadioBoxPatientPhysioterapy.Name = "RadioBoxPatientPhysioterapy";
            this.RadioBoxPatientPhysioterapy.Size = new System.Drawing.Size(109, 17);
            this.RadioBoxPatientPhysioterapy.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.RadioBoxPatientPhysioterapy.TabIndex = 3;
            this.RadioBoxPatientPhysioterapy.Text = "بیماران فیزیوتراپی";
            this.RadioBoxPatientPhysioterapy.TextColor = System.Drawing.Color.Black;
            this.RadioBoxPatientPhysioterapy.CheckedChanged += new System.EventHandler(this.RadioBoxAllPatient_CheckedChanged);
            // 
            // Patient_UC
            // 
            this.Controls.Add(this.GridViewPatient);
            this.Controls.Add(this.HeaderGridPatient);
            this.Controls.Add(this.mssPanel1);
            this.Name = "Patient_UC";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(1209, 505);
            this.Tag = "لیست بیماران";
            this.Load += new System.EventHandler(this.Patient_UC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewPatient)).EndInit();
            this.ContextMenuStripStatus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vWPatientBindingSource)).EndInit();
            this.mssPanel1.ResumeLayout(false);
            this.mssPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MSSHeaderGrid HeaderGridPatient;
        private MSSGridexView GridViewPatient;
        private System.Windows.Forms.BindingSource vWPatientBindingSource;
        private DevComponents.DotNetBar.ButtonItem buttonItemDelPatient;
        private DevComponents.DotNetBar.ButtonItem buttonItemDelPatientDead;
        private DevComponents.DotNetBar.ButtonItem buttonItemDelPatientCancel;
        private DevComponents.DotNetBar.ButtonItem buttonItemDelPatientOther;
        private DevComponents.DotNetBar.ButtonItem buttonItemPatientPhysiotherapy;
        private DevComponents.DotNetBar.ButtonItem buttonItemPatientCareList;
        private DevComponents.DotNetBar.ItemContainer itemContainer1;
        private DevComponents.DotNetBar.ButtonItem buttonItemFiling;
        private DevComponents.DotNetBar.ButtonItem buttonItemNoHamkar;
        private DevComponents.DotNetBar.ButtonItem buttonItemMosalah;
        private DevComponents.DotNetBar.ButtonItem buttonItemNoCotract;
        private DevComponents.DotNetBar.ButtonItem buttonItemVisitHealthCare;
        private MSSContextMenuStrip ContextMenuStripStatus;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemStatusPatient;
        private MSSPanel mssPanel1;
        private MSSCheckBox RadioBoxAllPatient;
        private MSSCheckBox RadioBoxPatientHealth;
        private MSSCheckBox RadioBoxPatientCare;
        private MSSCheckBox RadioBoxPatientPhysioterapy;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.DotNetBar.ButtonItem buttonItem2;
        private DevComponents.DotNetBar.ButtonItem buttonItemSendSMS;
        private MSSCheckBox RadioBoxPatientVisit;
        private DevComponents.DotNetBar.ButtonItem buttonItemVisitPatient;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemPatientLog;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemPatientCurrentRow;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemPatientAllList;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemVisit;
        private MSSCheckBox RadioBoxDosiersNo;
        private MSSCheckBox RadioBoxNationalCodes;
        private MSSTextBox TextBoxNationalCodeSearch;
        private MSSTextBox TextBoxDosiersNoSearch;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemVisitPatientInsert;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemDoctorInsert;
        private MSSCheckBox RadioBoxWithTime;
        private MSSDatePicker DatePickerEnd;
        private MSSDatePicker DatePickerStart;
        private MSSComboBox ComboBoxSerach;
        private DevComponents.Editors.ComboItem comboItemLastPhysiotherapyDate;
        private DevComponents.Editors.ComboItem comboItemLastCareDate;
        private DevComponents.Editors.ComboItem comboItemLastHealthCareDate;
        private DevComponents.Editors.ComboItem comboItemLastVisitDate;
        private MSSLabel mssLabel3;
        private MSSLabel mssLabel2;
        private MSSLabel mssLabel1;
    }
}
