using MKH.Library.Control;

namespace PhysiotherapyCare.View.MainForms.Doctors
{
    partial class DoctorsContract_Frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorsContract_Frm));
            Janus.Windows.GridEX.GridEXLayout GridViewDoctorsContract_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.con = new MKH.Library.Control.MSSGroupPanel(this.components);
            this.GridViewDoctorsContract = new MKH.Library.Control.MSSGridexView();
            this.ContextMenuStripStatus = new MKH.Library.Control.MSSContextMenuStrip(this.components);
            this.ToolStripMenuItemDoctorsContractLog = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemDoctorsContractCurrentRow = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemDoctorsContractAllList = new System.Windows.Forms.ToolStripMenuItem();
            this.HeaderGridDoctorsContract = new MKH.Library.Control.MSSHeaderGrid();
            this.mssPanel1 = new MKH.Library.Control.MSSPanel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewDoctorsContract)).BeginInit();
            this.ContextMenuStripStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // con
            // 
            this.con.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.con.Font = new System.Drawing.Font("Tahoma", 8F);
            this.con.Location = new System.Drawing.Point(0, 405);
            this.con.Name = "con";
            this.con.Size = new System.Drawing.Size(722, 26);
            // 
            // 
            // 
            this.con.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.con.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.con.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.con.TabIndex = 28;
            // 
            // GridViewDoctorsContract
            // 
            this.GridViewDoctorsContract.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.GridViewDoctorsContract.AlternatingColors = true;
            this.GridViewDoctorsContract.AlternatingRowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewDoctorsContract.BuiltInTextsData = resources.GetString("GridViewDoctorsContract.BuiltInTextsData");
            this.GridViewDoctorsContract.CardViewGridlines = Janus.Windows.GridEX.CardViewGridlines.Both;
            this.GridViewDoctorsContract.ContextMenuStrip = this.ContextMenuStripStatus;
            this.GridViewDoctorsContract.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            GridViewDoctorsContract_DesignTimeLayout.LayoutString = resources.GetString("GridViewDoctorsContract_DesignTimeLayout.LayoutString");
            this.GridViewDoctorsContract.DesignTimeLayout = GridViewDoctorsContract_DesignTimeLayout;
            this.GridViewDoctorsContract.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewDoctorsContract.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.GridViewDoctorsContract.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.GridViewDoctorsContract.Font = new System.Drawing.Font("Tahoma", 8.150944F);
            this.GridViewDoctorsContract.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewDoctorsContract.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
            this.GridViewDoctorsContract.Location = new System.Drawing.Point(0, 61);
            this.GridViewDoctorsContract.Name = "GridViewDoctorsContract";
            this.GridViewDoctorsContract.RecordNavigator = true;
            this.GridViewDoctorsContract.RowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewDoctorsContract.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition;
            this.GridViewDoctorsContract.RowHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewDoctorsContract.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.GridViewDoctorsContract.Size = new System.Drawing.Size(722, 344);
            this.GridViewDoctorsContract.TabIndex = 30;
            this.GridViewDoctorsContract.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.GridViewDoctorsContract.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010;
            this.GridViewDoctorsContract.DoubleClick += new System.EventHandler(this.headerGridDoctorsContract_btnEditClick);
            // 
            // ContextMenuStripStatus
            // 
            this.ContextMenuStripStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemDoctorsContractLog});
            this.ContextMenuStripStatus.Name = "ContextMenuStripStatus";
            this.ContextMenuStripStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ContextMenuStripStatus.Size = new System.Drawing.Size(153, 48);
            // 
            // ToolStripMenuItemDoctorsContractLog
            // 
            this.ToolStripMenuItemDoctorsContractLog.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemDoctorsContractCurrentRow,
            this.ToolStripMenuItemDoctorsContractAllList});
            this.ToolStripMenuItemDoctorsContractLog.Name = "ToolStripMenuItemDoctorsContractLog";
            this.ToolStripMenuItemDoctorsContractLog.Size = new System.Drawing.Size(152, 22);
            this.ToolStripMenuItemDoctorsContractLog.Text = "Log";
            // 
            // ToolStripMenuItemDoctorsContractCurrentRow
            // 
            this.ToolStripMenuItemDoctorsContractCurrentRow.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripMenuItemDoctorsContractCurrentRow.Name = "ToolStripMenuItemDoctorsContractCurrentRow";
            this.ToolStripMenuItemDoctorsContractCurrentRow.Size = new System.Drawing.Size(152, 22);
            this.ToolStripMenuItemDoctorsContractCurrentRow.Tag = "289";
            this.ToolStripMenuItemDoctorsContractCurrentRow.Text = "سطر انتخابی";
            this.ToolStripMenuItemDoctorsContractCurrentRow.Click += new System.EventHandler(this.ToolStripMenuItemDoctorsContractCurrentRow_Click);
            // 
            // ToolStripMenuItemDoctorsContractAllList
            // 
            this.ToolStripMenuItemDoctorsContractAllList.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripMenuItemDoctorsContractAllList.Name = "ToolStripMenuItemDoctorsContractAllList";
            this.ToolStripMenuItemDoctorsContractAllList.Size = new System.Drawing.Size(152, 22);
            this.ToolStripMenuItemDoctorsContractAllList.Tag = "290";
            this.ToolStripMenuItemDoctorsContractAllList.Text = "کل لیست";
            this.ToolStripMenuItemDoctorsContractAllList.Click += new System.EventHandler(this.ToolStripMenuItemDoctorsContractAllList_Click);
            // 
            // HeaderGridDoctorsContract
            // 
            // 
            // 
            // 
            this.HeaderGridDoctorsContract.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridDoctorsContract.BackgroundStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridDoctorsContract.BackgroundStyle.BorderBottomWidth = 1;
            this.HeaderGridDoctorsContract.BackgroundStyle.BorderLeftWidth = 1;
            this.HeaderGridDoctorsContract.BackgroundStyle.BorderRightWidth = 1;
            this.HeaderGridDoctorsContract.BackgroundStyle.BorderTopWidth = 1;
            this.HeaderGridDoctorsContract.BackgroundStyle.Class = "ItemPanel";
            this.HeaderGridDoctorsContract.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.HeaderGridDoctorsContract.BackgroundStyle.PaddingBottom = 1;
            this.HeaderGridDoctorsContract.BackgroundStyle.PaddingLeft = 1;
            this.HeaderGridDoctorsContract.BackgroundStyle.PaddingRight = 1;
            this.HeaderGridDoctorsContract.BackgroundStyle.PaddingTop = 1;
            this.HeaderGridDoctorsContract.ButtonDeletePermissionCode = 41;
            this.HeaderGridDoctorsContract.ButtonDeleteVisible = true;
            this.HeaderGridDoctorsContract.ButtonEditPermissionCode = 40;
            this.HeaderGridDoctorsContract.ButtonEditVisible = true;
            this.HeaderGridDoctorsContract.ButtonExcelExportVisible = false;
            this.HeaderGridDoctorsContract.ButtonExcelPermissionCode = 0;
            this.HeaderGridDoctorsContract.ButtonInsertPermissionCode = 39;
            this.HeaderGridDoctorsContract.ButtonInsertVisible = true;
            this.HeaderGridDoctorsContract.ButtonPrintExpertPermissionCode = 0;
            this.HeaderGridDoctorsContract.ButtonPrintExpertVisible = false;
            this.HeaderGridDoctorsContract.ButtonPrintPermissionCode = 42;
            this.HeaderGridDoctorsContract.ButtonPrintVisible = true;
            this.HeaderGridDoctorsContract.ButtonPrintWithDesignPermissionCode = 0;
            this.HeaderGridDoctorsContract.ButtonPrintWithDesignVisible = false;
            this.HeaderGridDoctorsContract.ButtonRefreshVisible = true;
            this.HeaderGridDoctorsContract.ButtonSearchExpertVisible = false;
            this.HeaderGridDoctorsContract.ButtonSearchVisible = true;
            this.HeaderGridDoctorsContract.ButtonSelectorVisible = false;
            this.HeaderGridDoctorsContract.ContainerControlProcessDialogKey = true;
            this.HeaderGridDoctorsContract.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderGridDoctorsContract.FitButtonsToContainerWidth = true;
            this.HeaderGridDoctorsContract.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.HeaderGridDoctorsContract.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.HeaderGridDoctorsContract.GridViewSet = this.GridViewDoctorsContract;
            this.HeaderGridDoctorsContract.Location = new System.Drawing.Point(0, 0);
            this.HeaderGridDoctorsContract.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HeaderGridDoctorsContract.Name = "HeaderGridDoctorsContract";
            this.HeaderGridDoctorsContract.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HeaderGridDoctorsContract.Size = new System.Drawing.Size(722, 61);
            this.HeaderGridDoctorsContract.TabIndex = 31;
            this.HeaderGridDoctorsContract.Text = "mssHeaderGrid1";
            this.HeaderGridDoctorsContract.ThemeAware = true;
            this.HeaderGridDoctorsContract.buttonItemInsertClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemInsertClickEventHandler(this.headerGridDoctorsContract_btnInsertClick);
            this.HeaderGridDoctorsContract.buttonItemEditClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemEditClickEventHandler(this.headerGridDoctorsContract_btnEditClick);
            this.HeaderGridDoctorsContract.buttonItemDeleteClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemDeleteClickEventHandler(this.headerGridDoctorsContract_btnDeleteClick);
            this.HeaderGridDoctorsContract.buttonItemRefreshClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemRefreshClickEventHandler(this.headerGridDoctorsContract_btnRefreshClick);
            // 
            // mssPanel1
            // 
            this.mssPanel1.Location = new System.Drawing.Point(0, 0);
            this.mssPanel1.Name = "mssPanel1";
            this.mssPanel1.Size = new System.Drawing.Size(200, 100);
            this.mssPanel1.TabIndex = 0;
            // 
            // DoctorsContract_Frm
            // 
            this.ClientSize = new System.Drawing.Size(722, 431);
            this.Controls.Add(this.GridViewDoctorsContract);
            this.Controls.Add(this.HeaderGridDoctorsContract);
            this.Controls.Add(this.con);
            this.Name = "DoctorsContract_Frm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "قرارداد فیزیوتراپ و بهیار";
            this.Load += new System.EventHandler(this.DoctorsContract_Frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewDoctorsContract)).EndInit();
            this.ContextMenuStripStatus.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MSSGroupPanel con;
        private MSSGridexView GridViewDoctorsContract;
        private MSSHeaderGrid HeaderGridDoctorsContract;
        private MSSPanel mssPanel1;
        private MSSContextMenuStrip ContextMenuStripStatus;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemDoctorsContractLog;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemDoctorsContractCurrentRow;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemDoctorsContractAllList;
    }
}
