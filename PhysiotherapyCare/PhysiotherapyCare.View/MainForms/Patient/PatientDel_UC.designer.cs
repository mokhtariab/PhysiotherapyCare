using MKH.Library.Control;

namespace PhysiotherapyCare.View.MainForms.Patient
{
    partial class PatientDel_UC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientDel_UC));
            Janus.Windows.GridEX.GridEXLayout GridViewPatientDel_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.HeaderGridPatientDel = new MKH.Library.Control.MSSHeaderGrid();
            this.GridViewPatientDel = new MKH.Library.Control.MSSGridexView();
            this.ContextMenuStripStatus = new MKH.Library.Control.MSSContextMenuStrip(this.components);
            this.ToolStripMenuItemPatientDelLog = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemPatientDelCurrentRow = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemPatientDelAllList = new System.Windows.Forms.ToolStripMenuItem();
            this.vWPatientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonItemSendSMS = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemBackToPatient = new DevComponents.DotNetBar.ButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewPatientDel)).BeginInit();
            this.ContextMenuStripStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vWPatientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // HeaderGridPatientDel
            // 
            // 
            // 
            // 
            this.HeaderGridPatientDel.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridPatientDel.BackgroundStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridPatientDel.BackgroundStyle.BorderBottomWidth = 1;
            this.HeaderGridPatientDel.BackgroundStyle.BorderLeftWidth = 1;
            this.HeaderGridPatientDel.BackgroundStyle.BorderRightWidth = 1;
            this.HeaderGridPatientDel.BackgroundStyle.BorderTopWidth = 1;
            this.HeaderGridPatientDel.BackgroundStyle.Class = "ItemPanel";
            this.HeaderGridPatientDel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.HeaderGridPatientDel.BackgroundStyle.PaddingBottom = 1;
            this.HeaderGridPatientDel.BackgroundStyle.PaddingLeft = 1;
            this.HeaderGridPatientDel.BackgroundStyle.PaddingRight = 1;
            this.HeaderGridPatientDel.BackgroundStyle.PaddingTop = 1;
            this.HeaderGridPatientDel.ButtonDeletePermissionCode = 43;
            this.HeaderGridPatientDel.ButtonDeleteVisible = true;
            this.HeaderGridPatientDel.ButtonEditPermissionCode = 0;
            this.HeaderGridPatientDel.ButtonEditVisible = false;
            this.HeaderGridPatientDel.ButtonExcelExportVisible = true;
            this.HeaderGridPatientDel.ButtonExcelPermissionCode = 45;
            this.HeaderGridPatientDel.ButtonInsertPermissionCode = 0;
            this.HeaderGridPatientDel.ButtonInsertVisible = false;
            this.HeaderGridPatientDel.ButtonPrintExpertPermissionCode = 0;
            this.HeaderGridPatientDel.ButtonPrintExpertVisible = false;
            this.HeaderGridPatientDel.ButtonPrintPermissionCode = 44;
            this.HeaderGridPatientDel.ButtonPrintVisible = true;
            this.HeaderGridPatientDel.ButtonPrintWithDesignPermissionCode = 158;
            this.HeaderGridPatientDel.ButtonPrintWithDesignVisible = true;
            this.HeaderGridPatientDel.ButtonRefreshVisible = true;
            this.HeaderGridPatientDel.ButtonSearchExpertVisible = false;
            this.HeaderGridPatientDel.ButtonSearchVisible = true;
            this.HeaderGridPatientDel.ButtonSelectorVisible = true;
            this.HeaderGridPatientDel.ContainerControlProcessDialogKey = true;
            this.HeaderGridPatientDel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderGridPatientDel.FitButtonsToContainerWidth = true;
            this.HeaderGridPatientDel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.HeaderGridPatientDel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.HeaderGridPatientDel.GridViewSet = this.GridViewPatientDel;
            this.HeaderGridPatientDel.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItemSendSMS,
            this.buttonItemBackToPatient});
            this.HeaderGridPatientDel.Location = new System.Drawing.Point(0, 0);
            this.HeaderGridPatientDel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HeaderGridPatientDel.Name = "HeaderGridPatientDel";
            this.HeaderGridPatientDel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HeaderGridPatientDel.Size = new System.Drawing.Size(819, 56);
            this.HeaderGridPatientDel.TabIndex = 31;
            this.HeaderGridPatientDel.Tag = "";
            this.HeaderGridPatientDel.ThemeAware = true;
            this.HeaderGridPatientDel.buttonItemDeleteClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemDeleteClickEventHandler(this.headerGridPatient_btnDeleteClick);
            this.HeaderGridPatientDel.buttonItemRefreshClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemRefreshClickEventHandler(this.headerGridPatient_btnRefreshClick);
            // 
            // GridViewPatientDel
            // 
            this.GridViewPatientDel.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.GridViewPatientDel.AlternatingColors = true;
            this.GridViewPatientDel.AlternatingRowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewPatientDel.BuiltInTextsData = resources.GetString("GridViewPatientDel.BuiltInTextsData");
            this.GridViewPatientDel.CardViewGridlines = Janus.Windows.GridEX.CardViewGridlines.Both;
            this.GridViewPatientDel.ContextMenuStrip = this.ContextMenuStripStatus;
            this.GridViewPatientDel.DataSource = this.vWPatientBindingSource;
            this.GridViewPatientDel.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            GridViewPatientDel_DesignTimeLayout.LayoutString = resources.GetString("GridViewPatientDel_DesignTimeLayout.LayoutString");
            this.GridViewPatientDel.DesignTimeLayout = GridViewPatientDel_DesignTimeLayout;
            this.GridViewPatientDel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewPatientDel.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.GridViewPatientDel.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.GridViewPatientDel.Font = new System.Drawing.Font("Tahoma", 8.150944F);
            this.GridViewPatientDel.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewPatientDel.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
            this.GridViewPatientDel.Location = new System.Drawing.Point(0, 56);
            this.GridViewPatientDel.Name = "GridViewPatientDel";
            this.GridViewPatientDel.RecordNavigator = true;
            this.GridViewPatientDel.RowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewPatientDel.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition;
            this.GridViewPatientDel.RowHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewPatientDel.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.GridViewPatientDel.Size = new System.Drawing.Size(819, 449);
            this.GridViewPatientDel.TabIndex = 32;
            this.GridViewPatientDel.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.GridViewPatientDel.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010;
            this.GridViewPatientDel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GridViewPatientDel_KeyDown);
            // 
            // ContextMenuStripStatus
            // 
            this.ContextMenuStripStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemPatientDelLog});
            this.ContextMenuStripStatus.Name = "ContextMenuStripStatus";
            this.ContextMenuStripStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ContextMenuStripStatus.Size = new System.Drawing.Size(95, 26);
            // 
            // ToolStripMenuItemPatientDelLog
            // 
            this.ToolStripMenuItemPatientDelLog.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemPatientDelCurrentRow,
            this.ToolStripMenuItemPatientDelAllList});
            this.ToolStripMenuItemPatientDelLog.Name = "ToolStripMenuItemPatientDelLog";
            this.ToolStripMenuItemPatientDelLog.Size = new System.Drawing.Size(94, 22);
            this.ToolStripMenuItemPatientDelLog.Text = "Log";
            // 
            // ToolStripMenuItemPatientDelCurrentRow
            // 
            this.ToolStripMenuItemPatientDelCurrentRow.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripMenuItemPatientDelCurrentRow.Name = "ToolStripMenuItemPatientDelCurrentRow";
            this.ToolStripMenuItemPatientDelCurrentRow.Size = new System.Drawing.Size(140, 22);
            this.ToolStripMenuItemPatientDelCurrentRow.Tag = "285";
            this.ToolStripMenuItemPatientDelCurrentRow.Text = "سطر انتخابی";
            this.ToolStripMenuItemPatientDelCurrentRow.Click += new System.EventHandler(this.ToolStripMenuItemPatientDelCurrentRow_Click);
            // 
            // ToolStripMenuItemPatientDelAllList
            // 
            this.ToolStripMenuItemPatientDelAllList.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripMenuItemPatientDelAllList.Name = "ToolStripMenuItemPatientDelAllList";
            this.ToolStripMenuItemPatientDelAllList.Size = new System.Drawing.Size(140, 22);
            this.ToolStripMenuItemPatientDelAllList.Tag = "286";
            this.ToolStripMenuItemPatientDelAllList.Text = "کل لیست";
            this.ToolStripMenuItemPatientDelAllList.Click += new System.EventHandler(this.ToolStripMenuItemPatientDelAllList_Click);
            // 
            // vWPatientBindingSource
            // 
            this.vWPatientBindingSource.DataSource = typeof(PhysiotherapyCare.Model.Patient.VW_Patient);
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
            this.buttonItemSendSMS.Tag = "205";
            this.buttonItemSendSMS.Text = "SMS ارسال";
            this.buttonItemSendSMS.ThemeAware = true;
            this.buttonItemSendSMS.Click += new System.EventHandler(this.buttonItemSendSMS_Click);
            // 
            // buttonItemBackToPatient
            // 
            this.buttonItemBackToPatient.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemBackToPatient.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemBackToPatient.Icon = ((System.Drawing.Icon)(resources.GetObject("buttonItemBackToPatient.Icon")));
            this.buttonItemBackToPatient.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemBackToPatient.Name = "buttonItemBackToPatient";
            this.buttonItemBackToPatient.Tag = "46";
            this.buttonItemBackToPatient.Text = "برگشت به لیست بیماران";
            this.buttonItemBackToPatient.ThemeAware = true;
            this.buttonItemBackToPatient.Click += new System.EventHandler(this.buttonItemBackToPatient_Click);
            // 
            // PatientDel_UC
            // 
            this.Controls.Add(this.GridViewPatientDel);
            this.Controls.Add(this.HeaderGridPatientDel);
            this.Name = "PatientDel_UC";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(819, 505);
            this.Tag = "بیماران بایگانی شده";
            this.Load += new System.EventHandler(this.PatientDel_UC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewPatientDel)).EndInit();
            this.ContextMenuStripStatus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vWPatientBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MSSHeaderGrid HeaderGridPatientDel;
        private MSSGridexView GridViewPatientDel;
        private System.Windows.Forms.BindingSource vWPatientBindingSource;
        private DevComponents.DotNetBar.ButtonItem buttonItemBackToPatient;
        private DevComponents.DotNetBar.ButtonItem buttonItemSendSMS;
        private MSSContextMenuStrip ContextMenuStripStatus;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemPatientDelLog;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemPatientDelCurrentRow;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemPatientDelAllList;
    }
}
