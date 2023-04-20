using MKH.Library.Control;

namespace PhysiotherapyCare.View.BaseForms
{
    partial class SicknessDetail_Frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SicknessDetail_Frm));
            Janus.Windows.GridEX.GridEXLayout GridViewSicknessDetail_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.con = new MKH.Library.Control.MSSGroupPanel(this.components);
            this.GridViewSicknessDetail = new MKH.Library.Control.MSSGridexView();
            this.HeaderGridSicknessDetail = new MKH.Library.Control.MSSHeaderGrid();
            this.mssPanel1 = new MKH.Library.Control.MSSPanel(this.components);
            this.vWSicknessDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewSicknessDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWSicknessDetailBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // con
            // 
            this.con.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.con.Font = new System.Drawing.Font("Tahoma", 8F);
            this.con.Location = new System.Drawing.Point(0, 405);
            this.con.Name = "con";
            this.con.Size = new System.Drawing.Size(519, 26);
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
            // GridViewSicknessDetail
            // 
            this.GridViewSicknessDetail.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.GridViewSicknessDetail.AlternatingColors = true;
            this.GridViewSicknessDetail.AlternatingRowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewSicknessDetail.BuiltInTextsData = resources.GetString("GridViewSicknessDetail.BuiltInTextsData");
            this.GridViewSicknessDetail.CardViewGridlines = Janus.Windows.GridEX.CardViewGridlines.Both;
            this.GridViewSicknessDetail.DataSource = this.vWSicknessDetailBindingSource;
            this.GridViewSicknessDetail.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            GridViewSicknessDetail_DesignTimeLayout.LayoutString = resources.GetString("GridViewSicknessDetail_DesignTimeLayout.LayoutString");
            this.GridViewSicknessDetail.DesignTimeLayout = GridViewSicknessDetail_DesignTimeLayout;
            this.GridViewSicknessDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewSicknessDetail.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.GridViewSicknessDetail.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.GridViewSicknessDetail.Font = new System.Drawing.Font("Tahoma", 8.150944F);
            this.GridViewSicknessDetail.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewSicknessDetail.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
            this.GridViewSicknessDetail.Location = new System.Drawing.Point(0, 61);
            this.GridViewSicknessDetail.Name = "GridViewSicknessDetail";
            this.GridViewSicknessDetail.RecordNavigator = true;
            this.GridViewSicknessDetail.RowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewSicknessDetail.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition;
            this.GridViewSicknessDetail.RowHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewSicknessDetail.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.GridViewSicknessDetail.Size = new System.Drawing.Size(519, 344);
            this.GridViewSicknessDetail.TabIndex = 30;
            this.GridViewSicknessDetail.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.GridViewSicknessDetail.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010;
            this.GridViewSicknessDetail.DoubleClick += new System.EventHandler(this.headerGridSicknessDetail_btnEditClick);
            // 
            // HeaderGridSicknessDetail
            // 
            // 
            // 
            // 
            this.HeaderGridSicknessDetail.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridSicknessDetail.BackgroundStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridSicknessDetail.BackgroundStyle.BorderBottomWidth = 1;
            this.HeaderGridSicknessDetail.BackgroundStyle.BorderLeftWidth = 1;
            this.HeaderGridSicknessDetail.BackgroundStyle.BorderRightWidth = 1;
            this.HeaderGridSicknessDetail.BackgroundStyle.BorderTopWidth = 1;
            this.HeaderGridSicknessDetail.BackgroundStyle.Class = "ItemPanel";
            this.HeaderGridSicknessDetail.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.HeaderGridSicknessDetail.BackgroundStyle.PaddingBottom = 1;
            this.HeaderGridSicknessDetail.BackgroundStyle.PaddingLeft = 1;
            this.HeaderGridSicknessDetail.BackgroundStyle.PaddingRight = 1;
            this.HeaderGridSicknessDetail.BackgroundStyle.PaddingTop = 1;
            this.HeaderGridSicknessDetail.ButtonDeletePermissionCode = 148;
            this.HeaderGridSicknessDetail.ButtonDeleteVisible = true;
            this.HeaderGridSicknessDetail.ButtonEditPermissionCode = 147;
            this.HeaderGridSicknessDetail.ButtonEditVisible = true;
            this.HeaderGridSicknessDetail.ButtonExcelExportVisible = false;
            this.HeaderGridSicknessDetail.ButtonExcelPermissionCode = 0;
            this.HeaderGridSicknessDetail.ButtonInsertPermissionCode = 146;
            this.HeaderGridSicknessDetail.ButtonInsertVisible = true;
            this.HeaderGridSicknessDetail.ButtonPrintExpertPermissionCode = 0;
            this.HeaderGridSicknessDetail.ButtonPrintExpertVisible = false;
            this.HeaderGridSicknessDetail.ButtonPrintPermissionCode = 149;
            this.HeaderGridSicknessDetail.ButtonPrintVisible = true;
            this.HeaderGridSicknessDetail.ButtonPrintWithDesignPermissionCode = 0;
            this.HeaderGridSicknessDetail.ButtonPrintWithDesignVisible = false;
            this.HeaderGridSicknessDetail.ButtonRefreshVisible = true;
            this.HeaderGridSicknessDetail.ButtonSearchExpertVisible = false;
            this.HeaderGridSicknessDetail.ButtonSearchVisible = true;
            this.HeaderGridSicknessDetail.ButtonSelectorVisible = false;
            this.HeaderGridSicknessDetail.ContainerControlProcessDialogKey = true;
            this.HeaderGridSicknessDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderGridSicknessDetail.FitButtonsToContainerWidth = true;
            this.HeaderGridSicknessDetail.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.HeaderGridSicknessDetail.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.HeaderGridSicknessDetail.GridViewSet = this.GridViewSicknessDetail;
            this.HeaderGridSicknessDetail.Location = new System.Drawing.Point(0, 0);
            this.HeaderGridSicknessDetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HeaderGridSicknessDetail.Name = "HeaderGridSicknessDetail";
            this.HeaderGridSicknessDetail.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HeaderGridSicknessDetail.Size = new System.Drawing.Size(519, 61);
            this.HeaderGridSicknessDetail.TabIndex = 31;
            this.HeaderGridSicknessDetail.Text = "mssHeaderGrid1";
            this.HeaderGridSicknessDetail.ThemeAware = true;
            this.HeaderGridSicknessDetail.buttonItemInsertClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemInsertClickEventHandler(this.headerGridSicknessDetail_btnInsertClick);
            this.HeaderGridSicknessDetail.buttonItemEditClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemEditClickEventHandler(this.headerGridSicknessDetail_btnEditClick);
            this.HeaderGridSicknessDetail.buttonItemDeleteClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemDeleteClickEventHandler(this.headerGridSicknessDetail_btnDeleteClick);
            this.HeaderGridSicknessDetail.buttonItemRefreshClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemRefreshClickEventHandler(this.headerGridSicknessDetail_btnRefreshClick);
            // 
            // mssPanel1
            // 
            this.mssPanel1.Location = new System.Drawing.Point(0, 0);
            this.mssPanel1.Name = "mssPanel1";
            this.mssPanel1.Size = new System.Drawing.Size(200, 100);
            this.mssPanel1.TabIndex = 0;
            // 
            // vWSicknessDetailBindingSource
            // 
            this.vWSicknessDetailBindingSource.DataSource = typeof(PhysiotherapyCare.Model.VisitPatient.VW_SicknessDetail);
            // 
            // SicknessDetail_Frm
            // 
            this.ClientSize = new System.Drawing.Size(519, 431);
            this.Controls.Add(this.GridViewSicknessDetail);
            this.Controls.Add(this.HeaderGridSicknessDetail);
            this.Controls.Add(this.con);
            this.Name = "SicknessDetail_Frm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "جزییات وضعیت بیماری";
            this.Load += new System.EventHandler(this.SicknessDetail_Frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewSicknessDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWSicknessDetailBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MSSGroupPanel con;
        private MSSGridexView GridViewSicknessDetail;
        private MSSHeaderGrid HeaderGridSicknessDetail;
        private MSSPanel mssPanel1;
        private System.Windows.Forms.BindingSource vWSicknessDetailBindingSource;
    }
}
