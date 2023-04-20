using MKH.Library.Control;

namespace PhysiotherapyCare.View.MainForms.Doctors
{
    partial class Doctors_UC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doctors_UC));
            Janus.Windows.GridEX.GridEXLayout GridViewDoctors_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.HeaderGridDoctors = new MKH.Library.Control.MSSHeaderGrid();
            this.GridViewDoctors = new MKH.Library.Control.MSSGridexView();
            this.ContextMenuStripStatus = new MKH.Library.Control.MSSContextMenuStrip(this.components);
            this.ToolStripMenuItemDoctorsLog = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemDoctorsCurrentRow = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemDoctorsAllList = new System.Windows.Forms.ToolStripMenuItem();
            this.vWDoctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonItemFiling = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemSendSMS = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemDoctorContract = new DevComponents.DotNetBar.ButtonItem();
            this.mssPanel4 = new MKH.Library.Control.MSSPanel(this.components);
            this.PictureBoxDoctorPic = new MKH.Library.Control.MSSPictureBox(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewDoctors)).BeginInit();
            this.ContextMenuStripStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vWDoctorBindingSource)).BeginInit();
            this.mssPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxDoctorPic)).BeginInit();
            this.SuspendLayout();
            // 
            // HeaderGridDoctors
            // 
            // 
            // 
            // 
            this.HeaderGridDoctors.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridDoctors.BackgroundStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridDoctors.BackgroundStyle.BorderBottomWidth = 1;
            this.HeaderGridDoctors.BackgroundStyle.BorderLeftWidth = 1;
            this.HeaderGridDoctors.BackgroundStyle.BorderRightWidth = 1;
            this.HeaderGridDoctors.BackgroundStyle.BorderTopWidth = 1;
            this.HeaderGridDoctors.BackgroundStyle.Class = "ItemPanel";
            this.HeaderGridDoctors.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.HeaderGridDoctors.BackgroundStyle.PaddingBottom = 1;
            this.HeaderGridDoctors.BackgroundStyle.PaddingLeft = 1;
            this.HeaderGridDoctors.BackgroundStyle.PaddingRight = 1;
            this.HeaderGridDoctors.BackgroundStyle.PaddingTop = 1;
            this.HeaderGridDoctors.ButtonDeletePermissionCode = 35;
            this.HeaderGridDoctors.ButtonDeleteVisible = true;
            this.HeaderGridDoctors.ButtonEditPermissionCode = 34;
            this.HeaderGridDoctors.ButtonEditVisible = true;
            this.HeaderGridDoctors.ButtonExcelExportVisible = true;
            this.HeaderGridDoctors.ButtonExcelPermissionCode = 37;
            this.HeaderGridDoctors.ButtonInsertPermissionCode = 33;
            this.HeaderGridDoctors.ButtonInsertVisible = true;
            this.HeaderGridDoctors.ButtonPrintExpertPermissionCode = 0;
            this.HeaderGridDoctors.ButtonPrintExpertVisible = false;
            this.HeaderGridDoctors.ButtonPrintPermissionCode = 36;
            this.HeaderGridDoctors.ButtonPrintVisible = true;
            this.HeaderGridDoctors.ButtonPrintWithDesignPermissionCode = 124;
            this.HeaderGridDoctors.ButtonPrintWithDesignVisible = true;
            this.HeaderGridDoctors.ButtonRefreshVisible = true;
            this.HeaderGridDoctors.ButtonSearchExpertVisible = false;
            this.HeaderGridDoctors.ButtonSearchVisible = true;
            this.HeaderGridDoctors.ButtonSelectorVisible = true;
            this.HeaderGridDoctors.ContainerControlProcessDialogKey = true;
            this.HeaderGridDoctors.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderGridDoctors.FitButtonsToContainerWidth = true;
            this.HeaderGridDoctors.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.HeaderGridDoctors.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.HeaderGridDoctors.GridViewSet = this.GridViewDoctors;
            this.HeaderGridDoctors.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItemFiling,
            this.buttonItemSendSMS,
            this.buttonItemDoctorContract});
            this.HeaderGridDoctors.Location = new System.Drawing.Point(0, 0);
            this.HeaderGridDoctors.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HeaderGridDoctors.Name = "HeaderGridDoctors";
            this.HeaderGridDoctors.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HeaderGridDoctors.Size = new System.Drawing.Size(819, 56);
            this.HeaderGridDoctors.TabIndex = 31;
            this.HeaderGridDoctors.Tag = "پزشکان";
            this.HeaderGridDoctors.Text = "پزشکان";
            this.HeaderGridDoctors.ThemeAware = true;
            this.HeaderGridDoctors.buttonItemInsertClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemInsertClickEventHandler(this.headerGridDoctors_btnInsertClick);
            this.HeaderGridDoctors.buttonItemEditClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemEditClickEventHandler(this.headerGridDoctors_btnEditClick);
            this.HeaderGridDoctors.buttonItemDeleteClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemDeleteClickEventHandler(this.headerGridDoctors_btnDeleteClick);
            this.HeaderGridDoctors.buttonItemRefreshClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemRefreshClickEventHandler(this.headerGridDoctors_btnRefreshClick);
            // 
            // GridViewDoctors
            // 
            this.GridViewDoctors.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.GridViewDoctors.AlternatingRowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewDoctors.BuiltInTextsData = resources.GetString("GridViewDoctors.BuiltInTextsData");
            this.GridViewDoctors.CardViewGridlines = Janus.Windows.GridEX.CardViewGridlines.Both;
            this.GridViewDoctors.ContextMenuStrip = this.ContextMenuStripStatus;
            this.GridViewDoctors.DataSource = this.vWDoctorBindingSource;
            this.GridViewDoctors.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            GridViewDoctors_DesignTimeLayout.LayoutString = resources.GetString("GridViewDoctors_DesignTimeLayout.LayoutString");
            this.GridViewDoctors.DesignTimeLayout = GridViewDoctors_DesignTimeLayout;
            this.GridViewDoctors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewDoctors.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.GridViewDoctors.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.GridViewDoctors.Font = new System.Drawing.Font("Tahoma", 8.150944F);
            this.GridViewDoctors.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewDoctors.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
            this.GridViewDoctors.Location = new System.Drawing.Point(222, 56);
            this.GridViewDoctors.Name = "GridViewDoctors";
            this.GridViewDoctors.RecordNavigator = true;
            this.GridViewDoctors.RowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewDoctors.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition;
            this.GridViewDoctors.RowHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewDoctors.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.GridViewDoctors.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelection;
            this.GridViewDoctors.Size = new System.Drawing.Size(597, 449);
            this.GridViewDoctors.TabIndex = 32;
            this.GridViewDoctors.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.GridViewDoctors.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010;
            this.GridViewDoctors.SelectionChanged += new System.EventHandler(this.GridViewDoctors_SelectionChanged);
            this.GridViewDoctors.DoubleClick += new System.EventHandler(this.headerGridDoctors_btnEditClick);
            // 
            // ContextMenuStripStatus
            // 
            this.ContextMenuStripStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemDoctorsLog});
            this.ContextMenuStripStatus.Name = "ContextMenuStripStatus";
            this.ContextMenuStripStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ContextMenuStripStatus.Size = new System.Drawing.Size(95, 26);
            // 
            // ToolStripMenuItemDoctorsLog
            // 
            this.ToolStripMenuItemDoctorsLog.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemDoctorsCurrentRow,
            this.ToolStripMenuItemDoctorsAllList});
            this.ToolStripMenuItemDoctorsLog.Name = "ToolStripMenuItemDoctorsLog";
            this.ToolStripMenuItemDoctorsLog.Size = new System.Drawing.Size(94, 22);
            this.ToolStripMenuItemDoctorsLog.Text = "Log";
            // 
            // ToolStripMenuItemDoctorsCurrentRow
            // 
            this.ToolStripMenuItemDoctorsCurrentRow.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripMenuItemDoctorsCurrentRow.Name = "ToolStripMenuItemDoctorsCurrentRow";
            this.ToolStripMenuItemDoctorsCurrentRow.Size = new System.Drawing.Size(140, 22);
            this.ToolStripMenuItemDoctorsCurrentRow.Tag = "287";
            this.ToolStripMenuItemDoctorsCurrentRow.Text = "سطر انتخابی";
            this.ToolStripMenuItemDoctorsCurrentRow.Click += new System.EventHandler(this.ToolStripMenuItemDoctorsCurrentRow_Click);
            // 
            // ToolStripMenuItemDoctorsAllList
            // 
            this.ToolStripMenuItemDoctorsAllList.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripMenuItemDoctorsAllList.Name = "ToolStripMenuItemDoctorsAllList";
            this.ToolStripMenuItemDoctorsAllList.Size = new System.Drawing.Size(140, 22);
            this.ToolStripMenuItemDoctorsAllList.Tag = "288";
            this.ToolStripMenuItemDoctorsAllList.Text = "کل لیست";
            this.ToolStripMenuItemDoctorsAllList.Click += new System.EventHandler(this.ToolStripMenuItemDoctorsAllList_Click);
            // 
            // vWDoctorBindingSource
            // 
            this.vWDoctorBindingSource.DataSource = typeof(PhysiotherapyCare.Model.Doctors.VW_Doctor);
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
            // buttonItemSendSMS
            // 
            this.buttonItemSendSMS.BeginGroup = true;
            this.buttonItemSendSMS.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemSendSMS.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemSendSMS.Image = ((System.Drawing.Image)(resources.GetObject("buttonItemSendSMS.Image")));
            this.buttonItemSendSMS.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium;
            this.buttonItemSendSMS.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemSendSMS.Name = "buttonItemSendSMS";
            this.buttonItemSendSMS.Tag = "203";
            this.buttonItemSendSMS.Text = "SMS ارسال";
            this.buttonItemSendSMS.ThemeAware = true;
            this.buttonItemSendSMS.Click += new System.EventHandler(this.buttonItemSendSMS_Click);
            // 
            // buttonItemDoctorContract
            // 
            this.buttonItemDoctorContract.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemDoctorContract.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemDoctorContract.Icon = ((System.Drawing.Icon)(resources.GetObject("buttonItemDoctorContract.Icon")));
            this.buttonItemDoctorContract.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Large;
            this.buttonItemDoctorContract.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemDoctorContract.Name = "buttonItemDoctorContract";
            this.buttonItemDoctorContract.Tag = "38";
            this.buttonItemDoctorContract.Text = "قراردادهای پزشکان";
            this.buttonItemDoctorContract.ThemeAware = true;
            this.buttonItemDoctorContract.Click += new System.EventHandler(this.buttonItemDoctorContract_Click);
            // 
            // mssPanel4
            // 
            this.mssPanel4.CanvasColor = System.Drawing.SystemColors.Control;
            this.mssPanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.mssPanel4.Controls.Add(this.PictureBoxDoctorPic);
            this.mssPanel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.mssPanel4.Location = new System.Drawing.Point(0, 56);
            this.mssPanel4.Name = "mssPanel4";
            this.mssPanel4.Size = new System.Drawing.Size(222, 449);
            this.mssPanel4.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.mssPanel4.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.mssPanel4.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.mssPanel4.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.mssPanel4.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.mssPanel4.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.mssPanel4.Style.GradientAngle = 90;
            this.mssPanel4.TabIndex = 33;
            // 
            // PictureBoxDoctorPic
            // 
            this.PictureBoxDoctorPic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PictureBoxDoctorPic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PictureBoxDoctorPic.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxDoctorPic.Image")));
            this.PictureBoxDoctorPic.Location = new System.Drawing.Point(11, 98);
            this.PictureBoxDoctorPic.Name = "PictureBoxDoctorPic";
            this.PictureBoxDoctorPic.Size = new System.Drawing.Size(200, 246);
            this.PictureBoxDoctorPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxDoctorPic.TabIndex = 0;
            this.PictureBoxDoctorPic.TabStop = false;
            // 
            // Doctors_UC
            // 
            this.Controls.Add(this.GridViewDoctors);
            this.Controls.Add(this.mssPanel4);
            this.Controls.Add(this.HeaderGridDoctors);
            this.Name = "Doctors_UC";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(819, 505);
            this.Tag = "لیست پزشکان";
            this.Load += new System.EventHandler(this.Doctors_UC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewDoctors)).EndInit();
            this.ContextMenuStripStatus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vWDoctorBindingSource)).EndInit();
            this.mssPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxDoctorPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MSSHeaderGrid HeaderGridDoctors;
        private MSSGridexView GridViewDoctors;
        private System.Windows.Forms.BindingSource vWDoctorBindingSource;
        private MSSPanel mssPanel4;
        private MSSPictureBox PictureBoxDoctorPic;
        private DevComponents.DotNetBar.ButtonItem buttonItemDoctorContract;
        private DevComponents.DotNetBar.ButtonItem buttonItemSendSMS;
        private DevComponents.DotNetBar.ButtonItem buttonItemFiling;
        private MSSContextMenuStrip ContextMenuStripStatus;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemDoctorsLog;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemDoctorsCurrentRow;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemDoctorsAllList;
    }
}
