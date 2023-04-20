using MKH.Library.Control;

namespace PhysiotherapyCare.View.MainForms.VisitHealthCare
{
    partial class ServiceType_Frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceType_Frm));
            Janus.Windows.GridEX.GridEXLayout GridViewServiceType_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.con = new MKH.Library.Control.MSSGroupPanel(this.components);
            this.GridViewServiceType = new MKH.Library.Control.MSSGridexView();
            this.tBLServiceTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HeaderGridServiceType = new MKH.Library.Control.MSSHeaderGrid();
            this.mssPanel1 = new MKH.Library.Control.MSSPanel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewServiceType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLServiceTypeBindingSource)).BeginInit();
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
            // GridViewServiceType
            // 
            this.GridViewServiceType.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.GridViewServiceType.AlternatingColors = true;
            this.GridViewServiceType.AlternatingRowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewServiceType.BuiltInTextsData = resources.GetString("GridViewServiceType.BuiltInTextsData");
            this.GridViewServiceType.CardViewGridlines = Janus.Windows.GridEX.CardViewGridlines.Both;
            this.GridViewServiceType.DataSource = this.tBLServiceTypeBindingSource;
            this.GridViewServiceType.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            GridViewServiceType_DesignTimeLayout.LayoutString = resources.GetString("GridViewServiceType_DesignTimeLayout.LayoutString");
            this.GridViewServiceType.DesignTimeLayout = GridViewServiceType_DesignTimeLayout;
            this.GridViewServiceType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewServiceType.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.GridViewServiceType.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.GridViewServiceType.Font = new System.Drawing.Font("Tahoma", 8.150944F);
            this.GridViewServiceType.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewServiceType.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
            this.GridViewServiceType.Location = new System.Drawing.Point(0, 61);
            this.GridViewServiceType.Name = "GridViewServiceType";
            this.GridViewServiceType.RecordNavigator = true;
            this.GridViewServiceType.RowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewServiceType.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition;
            this.GridViewServiceType.RowHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewServiceType.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.GridViewServiceType.Size = new System.Drawing.Size(454, 344);
            this.GridViewServiceType.TabIndex = 30;
            this.GridViewServiceType.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.GridViewServiceType.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010;
            this.GridViewServiceType.DoubleClick += new System.EventHandler(this.headerGridServiceType_btnEditClick);
            // 
            // tBLServiceTypeBindingSource
            // 
            this.tBLServiceTypeBindingSource.DataSource = typeof(PhysiotherapyCare.Model.VisitHealthCare.TBL_ServiceType);
            // 
            // HeaderGridServiceType
            // 
            // 
            // 
            // 
            this.HeaderGridServiceType.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridServiceType.BackgroundStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridServiceType.BackgroundStyle.BorderBottomWidth = 1;
            this.HeaderGridServiceType.BackgroundStyle.BorderLeftWidth = 1;
            this.HeaderGridServiceType.BackgroundStyle.BorderRightWidth = 1;
            this.HeaderGridServiceType.BackgroundStyle.BorderTopWidth = 1;
            this.HeaderGridServiceType.BackgroundStyle.Class = "ItemPanel";
            this.HeaderGridServiceType.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.HeaderGridServiceType.BackgroundStyle.PaddingBottom = 1;
            this.HeaderGridServiceType.BackgroundStyle.PaddingLeft = 1;
            this.HeaderGridServiceType.BackgroundStyle.PaddingRight = 1;
            this.HeaderGridServiceType.BackgroundStyle.PaddingTop = 1;
            this.HeaderGridServiceType.ButtonDeletePermissionCode = 152;
            this.HeaderGridServiceType.ButtonDeleteVisible = true;
            this.HeaderGridServiceType.ButtonEditPermissionCode = 151;
            this.HeaderGridServiceType.ButtonEditVisible = true;
            this.HeaderGridServiceType.ButtonExcelExportVisible = false;
            this.HeaderGridServiceType.ButtonExcelPermissionCode = 0;
            this.HeaderGridServiceType.ButtonInsertPermissionCode = 150;
            this.HeaderGridServiceType.ButtonInsertVisible = true;
            this.HeaderGridServiceType.ButtonPrintExpertPermissionCode = 0;
            this.HeaderGridServiceType.ButtonPrintExpertVisible = false;
            this.HeaderGridServiceType.ButtonPrintPermissionCode = 153;
            this.HeaderGridServiceType.ButtonPrintVisible = true;
            this.HeaderGridServiceType.ButtonPrintWithDesignPermissionCode = 0;
            this.HeaderGridServiceType.ButtonPrintWithDesignVisible = true;
            this.HeaderGridServiceType.ButtonRefreshVisible = true;
            this.HeaderGridServiceType.ButtonSearchExpertVisible = false;
            this.HeaderGridServiceType.ButtonSearchVisible = true;
            this.HeaderGridServiceType.ButtonSelectorVisible = false;
            this.HeaderGridServiceType.ContainerControlProcessDialogKey = true;
            this.HeaderGridServiceType.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderGridServiceType.FitButtonsToContainerWidth = true;
            this.HeaderGridServiceType.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.HeaderGridServiceType.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.HeaderGridServiceType.GridViewSet = this.GridViewServiceType;
            this.HeaderGridServiceType.Location = new System.Drawing.Point(0, 0);
            this.HeaderGridServiceType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HeaderGridServiceType.Name = "HeaderGridServiceType";
            this.HeaderGridServiceType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HeaderGridServiceType.Size = new System.Drawing.Size(454, 61);
            this.HeaderGridServiceType.TabIndex = 31;
            this.HeaderGridServiceType.Text = "mssHeaderGrid1";
            this.HeaderGridServiceType.ThemeAware = true;
            this.HeaderGridServiceType.buttonItemInsertClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemInsertClickEventHandler(this.headerGridServiceType_btnInsertClick);
            this.HeaderGridServiceType.buttonItemEditClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemEditClickEventHandler(this.headerGridServiceType_btnEditClick);
            this.HeaderGridServiceType.buttonItemDeleteClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemDeleteClickEventHandler(this.headerGridServiceType_btnDeleteClick);
            this.HeaderGridServiceType.buttonItemRefreshClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemRefreshClickEventHandler(this.headerGridServiceType_btnRefreshClick);
            // 
            // mssPanel1
            // 
            this.mssPanel1.Location = new System.Drawing.Point(0, 0);
            this.mssPanel1.Name = "mssPanel1";
            this.mssPanel1.Size = new System.Drawing.Size(200, 100);
            this.mssPanel1.TabIndex = 0;
            // 
            // ServiceType_Frm
            // 
            this.ClientSize = new System.Drawing.Size(454, 431);
            this.Controls.Add(this.GridViewServiceType);
            this.Controls.Add(this.HeaderGridServiceType);
            this.Controls.Add(this.con);
            this.Name = "ServiceType_Frm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "نوع خدمت";
            this.Load += new System.EventHandler(this.ServiceType_Frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewServiceType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLServiceTypeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MSSGroupPanel con;
        private MSSGridexView GridViewServiceType;
        private MSSHeaderGrid HeaderGridServiceType;
        private MSSPanel mssPanel1;
        private System.Windows.Forms.BindingSource tBLServiceTypeBindingSource;
    }
}
