using MKH.Library.Control;

namespace PhysiotherapyCare.View.MainForms.Status
{
    partial class StatusTypeDetail_Frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatusTypeDetail_Frm));
            Janus.Windows.GridEX.GridEXLayout GridViewStatusTypeDetail_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.con = new MKH.Library.Control.MSSGroupPanel(this.components);
            this.GridViewStatusTypeDetail = new MKH.Library.Control.MSSGridexView();
            this.HeaderGridStatusTypeDetail = new MKH.Library.Control.MSSHeaderGrid();
            this.mssPanel1 = new MKH.Library.Control.MSSPanel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewStatusTypeDetail)).BeginInit();
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
            // GridViewStatusTypeDetail
            // 
            this.GridViewStatusTypeDetail.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.GridViewStatusTypeDetail.AlternatingColors = true;
            this.GridViewStatusTypeDetail.AlternatingRowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewStatusTypeDetail.BuiltInTextsData = resources.GetString("GridViewStatusTypeDetail.BuiltInTextsData");
            this.GridViewStatusTypeDetail.CardViewGridlines = Janus.Windows.GridEX.CardViewGridlines.Both;
            this.GridViewStatusTypeDetail.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            GridViewStatusTypeDetail_DesignTimeLayout.LayoutString = resources.GetString("GridViewStatusTypeDetail_DesignTimeLayout.LayoutString");
            this.GridViewStatusTypeDetail.DesignTimeLayout = GridViewStatusTypeDetail_DesignTimeLayout;
            this.GridViewStatusTypeDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewStatusTypeDetail.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.GridViewStatusTypeDetail.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.GridViewStatusTypeDetail.Font = new System.Drawing.Font("Tahoma", 8.150944F);
            this.GridViewStatusTypeDetail.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewStatusTypeDetail.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
            this.GridViewStatusTypeDetail.Location = new System.Drawing.Point(0, 61);
            this.GridViewStatusTypeDetail.Name = "GridViewStatusTypeDetail";
            this.GridViewStatusTypeDetail.RecordNavigator = true;
            this.GridViewStatusTypeDetail.RowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewStatusTypeDetail.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition;
            this.GridViewStatusTypeDetail.RowHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewStatusTypeDetail.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.GridViewStatusTypeDetail.Size = new System.Drawing.Size(454, 344);
            this.GridViewStatusTypeDetail.TabIndex = 30;
            this.GridViewStatusTypeDetail.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.GridViewStatusTypeDetail.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010;
            this.GridViewStatusTypeDetail.DoubleClick += new System.EventHandler(this.headerGridStatusTypeDetail_btnEditClick);
            // 
            // HeaderGridStatusTypeDetail
            // 
            // 
            // 
            // 
            this.HeaderGridStatusTypeDetail.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridStatusTypeDetail.BackgroundStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridStatusTypeDetail.BackgroundStyle.BorderBottomWidth = 1;
            this.HeaderGridStatusTypeDetail.BackgroundStyle.BorderLeftWidth = 1;
            this.HeaderGridStatusTypeDetail.BackgroundStyle.BorderRightWidth = 1;
            this.HeaderGridStatusTypeDetail.BackgroundStyle.BorderTopWidth = 1;
            this.HeaderGridStatusTypeDetail.BackgroundStyle.Class = "ItemPanel";
            this.HeaderGridStatusTypeDetail.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.HeaderGridStatusTypeDetail.BackgroundStyle.PaddingBottom = 1;
            this.HeaderGridStatusTypeDetail.BackgroundStyle.PaddingLeft = 1;
            this.HeaderGridStatusTypeDetail.BackgroundStyle.PaddingRight = 1;
            this.HeaderGridStatusTypeDetail.BackgroundStyle.PaddingTop = 1;
            this.HeaderGridStatusTypeDetail.ButtonDeletePermissionCode = 140;
            this.HeaderGridStatusTypeDetail.ButtonDeleteVisible = true;
            this.HeaderGridStatusTypeDetail.ButtonEditPermissionCode = 139;
            this.HeaderGridStatusTypeDetail.ButtonEditVisible = true;
            this.HeaderGridStatusTypeDetail.ButtonExcelExportVisible = false;
            this.HeaderGridStatusTypeDetail.ButtonExcelPermissionCode = 0;
            this.HeaderGridStatusTypeDetail.ButtonInsertPermissionCode = 138;
            this.HeaderGridStatusTypeDetail.ButtonInsertVisible = true;
            this.HeaderGridStatusTypeDetail.ButtonPrintExpertPermissionCode = 0;
            this.HeaderGridStatusTypeDetail.ButtonPrintExpertVisible = false;
            this.HeaderGridStatusTypeDetail.ButtonPrintPermissionCode = 141;
            this.HeaderGridStatusTypeDetail.ButtonPrintVisible = true;
            this.HeaderGridStatusTypeDetail.ButtonPrintWithDesignPermissionCode = 0;
            this.HeaderGridStatusTypeDetail.ButtonPrintWithDesignVisible = false;
            this.HeaderGridStatusTypeDetail.ButtonRefreshVisible = true;
            this.HeaderGridStatusTypeDetail.ButtonSearchExpertVisible = false;
            this.HeaderGridStatusTypeDetail.ButtonSearchVisible = true;
            this.HeaderGridStatusTypeDetail.ButtonSelectorVisible = false;
            this.HeaderGridStatusTypeDetail.ContainerControlProcessDialogKey = true;
            this.HeaderGridStatusTypeDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderGridStatusTypeDetail.FitButtonsToContainerWidth = true;
            this.HeaderGridStatusTypeDetail.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.HeaderGridStatusTypeDetail.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.HeaderGridStatusTypeDetail.GridViewSet = this.GridViewStatusTypeDetail;
            this.HeaderGridStatusTypeDetail.Location = new System.Drawing.Point(0, 0);
            this.HeaderGridStatusTypeDetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HeaderGridStatusTypeDetail.Name = "HeaderGridStatusTypeDetail";
            this.HeaderGridStatusTypeDetail.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HeaderGridStatusTypeDetail.Size = new System.Drawing.Size(454, 61);
            this.HeaderGridStatusTypeDetail.TabIndex = 31;
            this.HeaderGridStatusTypeDetail.Text = "mssHeaderGrid1";
            this.HeaderGridStatusTypeDetail.ThemeAware = true;
            this.HeaderGridStatusTypeDetail.buttonItemInsertClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemInsertClickEventHandler(this.headerGridStatusTypeDetail_btnInsertClick);
            this.HeaderGridStatusTypeDetail.buttonItemEditClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemEditClickEventHandler(this.headerGridStatusTypeDetail_btnEditClick);
            this.HeaderGridStatusTypeDetail.buttonItemDeleteClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemDeleteClickEventHandler(this.headerGridStatusTypeDetail_btnDeleteClick);
            this.HeaderGridStatusTypeDetail.buttonItemRefreshClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemRefreshClickEventHandler(this.headerGridStatusTypeDetail_btnRefreshClick);
            // 
            // mssPanel1
            // 
            this.mssPanel1.Location = new System.Drawing.Point(0, 0);
            this.mssPanel1.Name = "mssPanel1";
            this.mssPanel1.Size = new System.Drawing.Size(200, 100);
            this.mssPanel1.TabIndex = 0;
            // 
            // StatusTypeDetail_Frm
            // 
            this.ClientSize = new System.Drawing.Size(454, 431);
            this.Controls.Add(this.GridViewStatusTypeDetail);
            this.Controls.Add(this.HeaderGridStatusTypeDetail);
            this.Controls.Add(this.con);
            this.Name = "StatusTypeDetail_Frm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "جزییات وضعیت";
            this.Load += new System.EventHandler(this.StatusTypeDetail_Frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewStatusTypeDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MSSGroupPanel con;
        private MSSGridexView GridViewStatusTypeDetail;
        private MSSHeaderGrid HeaderGridStatusTypeDetail;
        private MSSPanel mssPanel1;
    }
}
