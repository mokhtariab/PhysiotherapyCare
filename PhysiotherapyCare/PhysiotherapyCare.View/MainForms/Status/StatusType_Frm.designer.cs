using MKH.Library.Control;

namespace PhysiotherapyCare.View.MainForms.Status
{
    partial class StatusType_Frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatusType_Frm));
            Janus.Windows.GridEX.GridEXLayout GridViewStatusType_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.con = new MKH.Library.Control.MSSGroupPanel(this.components);
            this.GridViewStatusType = new MKH.Library.Control.MSSGridexView();
            this.tBLStatusTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HeaderGridStatusType = new MKH.Library.Control.MSSHeaderGrid();
            this.mssPanel1 = new MKH.Library.Control.MSSPanel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewStatusType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLStatusTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // con
            // 
            this.con.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.con.Font = new System.Drawing.Font("Tahoma", 8F);
            this.con.Location = new System.Drawing.Point(0, 405);
            this.con.Name = "con";
            this.con.Size = new System.Drawing.Size(454, 26);
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
            // GridViewStatusType
            // 
            this.GridViewStatusType.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.GridViewStatusType.AlternatingColors = true;
            this.GridViewStatusType.AlternatingRowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewStatusType.BuiltInTextsData = resources.GetString("GridViewStatusType.BuiltInTextsData");
            this.GridViewStatusType.CardViewGridlines = Janus.Windows.GridEX.CardViewGridlines.Both;
            this.GridViewStatusType.DataSource = this.tBLStatusTypeBindingSource;
            this.GridViewStatusType.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            GridViewStatusType_DesignTimeLayout.LayoutString = resources.GetString("GridViewStatusType_DesignTimeLayout.LayoutString");
            this.GridViewStatusType.DesignTimeLayout = GridViewStatusType_DesignTimeLayout;
            this.GridViewStatusType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewStatusType.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.GridViewStatusType.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.GridViewStatusType.Font = new System.Drawing.Font("Tahoma", 8.150944F);
            this.GridViewStatusType.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewStatusType.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
            this.GridViewStatusType.Location = new System.Drawing.Point(0, 61);
            this.GridViewStatusType.Name = "GridViewStatusType";
            this.GridViewStatusType.RecordNavigator = true;
            this.GridViewStatusType.RowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewStatusType.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition;
            this.GridViewStatusType.RowHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewStatusType.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.GridViewStatusType.Size = new System.Drawing.Size(454, 344);
            this.GridViewStatusType.TabIndex = 30;
            this.GridViewStatusType.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.GridViewStatusType.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010;
            this.GridViewStatusType.DoubleClick += new System.EventHandler(this.headerGridStatusType_btnEditClick);
            // 
            // tBLStatusTypeBindingSource
            // 
            this.tBLStatusTypeBindingSource.DataSource = typeof(PhysiotherapyCare.Model.Status.TBL_StatusType);
            // 
            // HeaderGridStatusType
            // 
            // 
            // 
            // 
            this.HeaderGridStatusType.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridStatusType.BackgroundStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridStatusType.BackgroundStyle.BorderBottomWidth = 1;
            this.HeaderGridStatusType.BackgroundStyle.BorderLeftWidth = 1;
            this.HeaderGridStatusType.BackgroundStyle.BorderRightWidth = 1;
            this.HeaderGridStatusType.BackgroundStyle.BorderTopWidth = 1;
            this.HeaderGridStatusType.BackgroundStyle.Class = "ItemPanel";
            this.HeaderGridStatusType.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.HeaderGridStatusType.BackgroundStyle.PaddingBottom = 1;
            this.HeaderGridStatusType.BackgroundStyle.PaddingLeft = 1;
            this.HeaderGridStatusType.BackgroundStyle.PaddingRight = 1;
            this.HeaderGridStatusType.BackgroundStyle.PaddingTop = 1;
            this.HeaderGridStatusType.ButtonDeletePermissionCode = 98;
            this.HeaderGridStatusType.ButtonDeleteVisible = true;
            this.HeaderGridStatusType.ButtonEditPermissionCode = 97;
            this.HeaderGridStatusType.ButtonEditVisible = true;
            this.HeaderGridStatusType.ButtonExcelExportVisible = false;
            this.HeaderGridStatusType.ButtonExcelPermissionCode = 0;
            this.HeaderGridStatusType.ButtonInsertPermissionCode = 96;
            this.HeaderGridStatusType.ButtonInsertVisible = true;
            this.HeaderGridStatusType.ButtonPrintExpertPermissionCode = 0;
            this.HeaderGridStatusType.ButtonPrintExpertVisible = false;
            this.HeaderGridStatusType.ButtonPrintPermissionCode = 99;
            this.HeaderGridStatusType.ButtonPrintVisible = true;
            this.HeaderGridStatusType.ButtonPrintWithDesignPermissionCode = 0;
            this.HeaderGridStatusType.ButtonPrintWithDesignVisible = false;
            this.HeaderGridStatusType.ButtonRefreshVisible = true;
            this.HeaderGridStatusType.ButtonSearchExpertVisible = false;
            this.HeaderGridStatusType.ButtonSearchVisible = true;
            this.HeaderGridStatusType.ButtonSelectorVisible = false;
            this.HeaderGridStatusType.ContainerControlProcessDialogKey = true;
            this.HeaderGridStatusType.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderGridStatusType.FitButtonsToContainerWidth = true;
            this.HeaderGridStatusType.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.HeaderGridStatusType.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.HeaderGridStatusType.GridViewSet = this.GridViewStatusType;
            this.HeaderGridStatusType.Location = new System.Drawing.Point(0, 0);
            this.HeaderGridStatusType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HeaderGridStatusType.Name = "HeaderGridStatusType";
            this.HeaderGridStatusType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HeaderGridStatusType.Size = new System.Drawing.Size(454, 61);
            this.HeaderGridStatusType.TabIndex = 31;
            this.HeaderGridStatusType.Text = "mssHeaderGrid1";
            this.HeaderGridStatusType.ThemeAware = true;
            this.HeaderGridStatusType.buttonItemInsertClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemInsertClickEventHandler(this.headerGridStatusType_btnInsertClick);
            this.HeaderGridStatusType.buttonItemEditClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemEditClickEventHandler(this.headerGridStatusType_btnEditClick);
            this.HeaderGridStatusType.buttonItemDeleteClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemDeleteClickEventHandler(this.headerGridStatusType_btnDeleteClick);
            this.HeaderGridStatusType.buttonItemRefreshClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemRefreshClickEventHandler(this.headerGridStatusType_btnRefreshClick);
            // 
            // mssPanel1
            // 
            this.mssPanel1.Location = new System.Drawing.Point(0, 0);
            this.mssPanel1.Name = "mssPanel1";
            this.mssPanel1.Size = new System.Drawing.Size(200, 100);
            this.mssPanel1.TabIndex = 0;
            // 
            // StatusType_Frm
            // 
            this.ClientSize = new System.Drawing.Size(454, 431);
            this.Controls.Add(this.GridViewStatusType);
            this.Controls.Add(this.HeaderGridStatusType);
            this.Controls.Add(this.con);
            this.Name = "StatusType_Frm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "وضعیت";
            this.Load += new System.EventHandler(this.StatusType_Frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewStatusType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLStatusTypeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MSSGroupPanel con;
        private MSSGridexView GridViewStatusType;
        private MSSHeaderGrid HeaderGridStatusType;
        private MSSPanel mssPanel1;
        private System.Windows.Forms.BindingSource tBLStatusTypeBindingSource;
    }
}
