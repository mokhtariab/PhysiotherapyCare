using MKH.Library.Control;

namespace PhysiotherapyCare.View.BaseForms
{
    partial class InjuryType_Frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InjuryType_Frm));
            Janus.Windows.GridEX.GridEXLayout GridViewInjuryType_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.con = new MKH.Library.Control.MSSGroupPanel(this.components);
            this.GridViewInjuryType = new MKH.Library.Control.MSSGridexView();
            this.tBLInjuryTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HeaderGridInjuryType = new MKH.Library.Control.MSSHeaderGrid();
            this.mssPanel1 = new MKH.Library.Control.MSSPanel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewInjuryType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLInjuryTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // con
            // 
            this.con.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.con.Font = new System.Drawing.Font("Tahoma", 8F);
            this.con.Location = new System.Drawing.Point(0, 405);
            this.con.Name = "con";
            this.con.Size = new System.Drawing.Size(433, 26);
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
            // GridViewInjuryType
            // 
            this.GridViewInjuryType.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.GridViewInjuryType.AlternatingColors = true;
            this.GridViewInjuryType.AlternatingRowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewInjuryType.BuiltInTextsData = resources.GetString("GridViewInjuryType.BuiltInTextsData");
            this.GridViewInjuryType.CardViewGridlines = Janus.Windows.GridEX.CardViewGridlines.Both;
            this.GridViewInjuryType.DataSource = this.tBLInjuryTypeBindingSource;
            this.GridViewInjuryType.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            GridViewInjuryType_DesignTimeLayout.LayoutString = resources.GetString("GridViewInjuryType_DesignTimeLayout.LayoutString");
            this.GridViewInjuryType.DesignTimeLayout = GridViewInjuryType_DesignTimeLayout;
            this.GridViewInjuryType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewInjuryType.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.GridViewInjuryType.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.GridViewInjuryType.Font = new System.Drawing.Font("Tahoma", 8.150944F);
            this.GridViewInjuryType.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewInjuryType.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
            this.GridViewInjuryType.Location = new System.Drawing.Point(0, 61);
            this.GridViewInjuryType.Name = "GridViewInjuryType";
            this.GridViewInjuryType.RecordNavigator = true;
            this.GridViewInjuryType.RowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewInjuryType.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition;
            this.GridViewInjuryType.RowHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewInjuryType.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.GridViewInjuryType.Size = new System.Drawing.Size(433, 344);
            this.GridViewInjuryType.TabIndex = 30;
            this.GridViewInjuryType.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.GridViewInjuryType.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010;
            this.GridViewInjuryType.DoubleClick += new System.EventHandler(this.headerGridInjuryType_btnEditClick);
            // 
            // tBLInjuryTypeBindingSource
            // 
            this.tBLInjuryTypeBindingSource.DataSource = typeof(PhysiotherapyCare.Model.Basic.TBL_InjuryType);
            // 
            // HeaderGridInjuryType
            // 
            // 
            // 
            // 
            this.HeaderGridInjuryType.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridInjuryType.BackgroundStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridInjuryType.BackgroundStyle.BorderBottomWidth = 1;
            this.HeaderGridInjuryType.BackgroundStyle.BorderLeftWidth = 1;
            this.HeaderGridInjuryType.BackgroundStyle.BorderRightWidth = 1;
            this.HeaderGridInjuryType.BackgroundStyle.BorderTopWidth = 1;
            this.HeaderGridInjuryType.BackgroundStyle.Class = "ItemPanel";
            this.HeaderGridInjuryType.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.HeaderGridInjuryType.BackgroundStyle.PaddingBottom = 1;
            this.HeaderGridInjuryType.BackgroundStyle.PaddingLeft = 1;
            this.HeaderGridInjuryType.BackgroundStyle.PaddingRight = 1;
            this.HeaderGridInjuryType.BackgroundStyle.PaddingTop = 1;
            this.HeaderGridInjuryType.ButtonDeletePermissionCode = 90;
            this.HeaderGridInjuryType.ButtonDeleteVisible = true;
            this.HeaderGridInjuryType.ButtonEditPermissionCode = 89;
            this.HeaderGridInjuryType.ButtonEditVisible = true;
            this.HeaderGridInjuryType.ButtonExcelExportVisible = false;
            this.HeaderGridInjuryType.ButtonExcelPermissionCode = 0;
            this.HeaderGridInjuryType.ButtonInsertPermissionCode = 88;
            this.HeaderGridInjuryType.ButtonInsertVisible = true;
            this.HeaderGridInjuryType.ButtonPrintExpertPermissionCode = 0;
            this.HeaderGridInjuryType.ButtonPrintExpertVisible = false;
            this.HeaderGridInjuryType.ButtonPrintPermissionCode = 91;
            this.HeaderGridInjuryType.ButtonPrintVisible = true;
            this.HeaderGridInjuryType.ButtonPrintWithDesignPermissionCode = 0;
            this.HeaderGridInjuryType.ButtonPrintWithDesignVisible = false;
            this.HeaderGridInjuryType.ButtonRefreshVisible = true;
            this.HeaderGridInjuryType.ButtonSearchExpertVisible = false;
            this.HeaderGridInjuryType.ButtonSearchVisible = true;
            this.HeaderGridInjuryType.ButtonSelectorVisible = false;
            this.HeaderGridInjuryType.ContainerControlProcessDialogKey = true;
            this.HeaderGridInjuryType.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderGridInjuryType.FitButtonsToContainerWidth = true;
            this.HeaderGridInjuryType.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.HeaderGridInjuryType.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.HeaderGridInjuryType.GridViewSet = this.GridViewInjuryType;
            this.HeaderGridInjuryType.Location = new System.Drawing.Point(0, 0);
            this.HeaderGridInjuryType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HeaderGridInjuryType.Name = "HeaderGridInjuryType";
            this.HeaderGridInjuryType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HeaderGridInjuryType.Size = new System.Drawing.Size(433, 61);
            this.HeaderGridInjuryType.TabIndex = 31;
            this.HeaderGridInjuryType.Text = "mssHeaderGrid1";
            this.HeaderGridInjuryType.ThemeAware = true;
            this.HeaderGridInjuryType.buttonItemInsertClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemInsertClickEventHandler(this.headerGridInjuryType_btnInsertClick);
            this.HeaderGridInjuryType.buttonItemEditClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemEditClickEventHandler(this.headerGridInjuryType_btnEditClick);
            this.HeaderGridInjuryType.buttonItemDeleteClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemDeleteClickEventHandler(this.headerGridInjuryType_btnDeleteClick);
            this.HeaderGridInjuryType.buttonItemRefreshClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemRefreshClickEventHandler(this.headerGridInjuryType_btnRefreshClick);
            // 
            // mssPanel1
            // 
            this.mssPanel1.Location = new System.Drawing.Point(0, 0);
            this.mssPanel1.Name = "mssPanel1";
            this.mssPanel1.Size = new System.Drawing.Size(200, 100);
            this.mssPanel1.TabIndex = 0;
            // 
            // InjuryType_Frm
            // 
            this.ClientSize = new System.Drawing.Size(433, 431);
            this.Controls.Add(this.GridViewInjuryType);
            this.Controls.Add(this.HeaderGridInjuryType);
            this.Controls.Add(this.con);
            this.Name = "InjuryType_Frm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "نوع بیماری";
            this.Load += new System.EventHandler(this.InjuryType_Frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewInjuryType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLInjuryTypeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MSSGroupPanel con;
        private MSSGridexView GridViewInjuryType;
        private MSSHeaderGrid HeaderGridInjuryType;
        private MSSPanel mssPanel1;
        private System.Windows.Forms.BindingSource tBLInjuryTypeBindingSource;
    }
}
