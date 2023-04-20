using MKH.Library.Control;

namespace PhysiotherapyCare.View.BaseForms
{
    partial class Sickness_Frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sickness_Frm));
            Janus.Windows.GridEX.GridEXLayout GridViewSickness_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.con = new MKH.Library.Control.MSSGroupPanel(this.components);
            this.GridViewSickness = new MKH.Library.Control.MSSGridexView();
            this.tBLSicknessBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HeaderGridSickness = new MKH.Library.Control.MSSHeaderGrid();
            this.mssPanel1 = new MKH.Library.Control.MSSPanel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewSickness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLSicknessBindingSource)).BeginInit();
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
            // GridViewSickness
            // 
            this.GridViewSickness.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.GridViewSickness.AlternatingColors = true;
            this.GridViewSickness.AlternatingRowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewSickness.BuiltInTextsData = resources.GetString("GridViewSickness.BuiltInTextsData");
            this.GridViewSickness.CardViewGridlines = Janus.Windows.GridEX.CardViewGridlines.Both;
            this.GridViewSickness.DataSource = this.tBLSicknessBindingSource;
            this.GridViewSickness.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            GridViewSickness_DesignTimeLayout.LayoutString = resources.GetString("GridViewSickness_DesignTimeLayout.LayoutString");
            this.GridViewSickness.DesignTimeLayout = GridViewSickness_DesignTimeLayout;
            this.GridViewSickness.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewSickness.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.GridViewSickness.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.GridViewSickness.Font = new System.Drawing.Font("Tahoma", 8.150944F);
            this.GridViewSickness.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewSickness.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
            this.GridViewSickness.Location = new System.Drawing.Point(0, 61);
            this.GridViewSickness.Name = "GridViewSickness";
            this.GridViewSickness.RecordNavigator = true;
            this.GridViewSickness.RowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewSickness.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition;
            this.GridViewSickness.RowHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewSickness.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.GridViewSickness.Size = new System.Drawing.Size(454, 344);
            this.GridViewSickness.TabIndex = 30;
            this.GridViewSickness.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.GridViewSickness.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010;
            this.GridViewSickness.DoubleClick += new System.EventHandler(this.headerGridSickness_btnEditClick);
            // 
            // tBLSicknessBindingSource
            // 
            this.tBLSicknessBindingSource.DataSource = typeof(PhysiotherapyCare.Model.VisitPatient.TBL_Sickness);
            // 
            // HeaderGridSickness
            // 
            // 
            // 
            // 
            this.HeaderGridSickness.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridSickness.BackgroundStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridSickness.BackgroundStyle.BorderBottomWidth = 1;
            this.HeaderGridSickness.BackgroundStyle.BorderLeftWidth = 1;
            this.HeaderGridSickness.BackgroundStyle.BorderRightWidth = 1;
            this.HeaderGridSickness.BackgroundStyle.BorderTopWidth = 1;
            this.HeaderGridSickness.BackgroundStyle.Class = "ItemPanel";
            this.HeaderGridSickness.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.HeaderGridSickness.BackgroundStyle.PaddingBottom = 1;
            this.HeaderGridSickness.BackgroundStyle.PaddingLeft = 1;
            this.HeaderGridSickness.BackgroundStyle.PaddingRight = 1;
            this.HeaderGridSickness.BackgroundStyle.PaddingTop = 1;
            this.HeaderGridSickness.ButtonDeletePermissionCode = 144;
            this.HeaderGridSickness.ButtonDeleteVisible = true;
            this.HeaderGridSickness.ButtonEditPermissionCode = 143;
            this.HeaderGridSickness.ButtonEditVisible = true;
            this.HeaderGridSickness.ButtonExcelExportVisible = false;
            this.HeaderGridSickness.ButtonExcelPermissionCode = 0;
            this.HeaderGridSickness.ButtonInsertPermissionCode = 142;
            this.HeaderGridSickness.ButtonInsertVisible = true;
            this.HeaderGridSickness.ButtonPrintExpertPermissionCode = 0;
            this.HeaderGridSickness.ButtonPrintExpertVisible = false;
            this.HeaderGridSickness.ButtonPrintPermissionCode = 145;
            this.HeaderGridSickness.ButtonPrintVisible = true;
            this.HeaderGridSickness.ButtonPrintWithDesignPermissionCode = 0;
            this.HeaderGridSickness.ButtonPrintWithDesignVisible = false;
            this.HeaderGridSickness.ButtonRefreshVisible = true;
            this.HeaderGridSickness.ButtonSearchExpertVisible = false;
            this.HeaderGridSickness.ButtonSearchVisible = true;
            this.HeaderGridSickness.ButtonSelectorVisible = false;
            this.HeaderGridSickness.ContainerControlProcessDialogKey = true;
            this.HeaderGridSickness.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderGridSickness.FitButtonsToContainerWidth = true;
            this.HeaderGridSickness.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.HeaderGridSickness.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.HeaderGridSickness.GridViewSet = this.GridViewSickness;
            this.HeaderGridSickness.Location = new System.Drawing.Point(0, 0);
            this.HeaderGridSickness.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HeaderGridSickness.Name = "HeaderGridSickness";
            this.HeaderGridSickness.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HeaderGridSickness.Size = new System.Drawing.Size(454, 61);
            this.HeaderGridSickness.TabIndex = 31;
            this.HeaderGridSickness.Text = "mssHeaderGrid1";
            this.HeaderGridSickness.ThemeAware = true;
            this.HeaderGridSickness.buttonItemInsertClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemInsertClickEventHandler(this.headerGridSickness_btnInsertClick);
            this.HeaderGridSickness.buttonItemEditClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemEditClickEventHandler(this.headerGridSickness_btnEditClick);
            this.HeaderGridSickness.buttonItemDeleteClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemDeleteClickEventHandler(this.headerGridSickness_btnDeleteClick);
            this.HeaderGridSickness.buttonItemRefreshClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemRefreshClickEventHandler(this.headerGridSickness_btnRefreshClick);
            // 
            // mssPanel1
            // 
            this.mssPanel1.Location = new System.Drawing.Point(0, 0);
            this.mssPanel1.Name = "mssPanel1";
            this.mssPanel1.Size = new System.Drawing.Size(200, 100);
            this.mssPanel1.TabIndex = 0;
            // 
            // Sickness_Frm
            // 
            this.ClientSize = new System.Drawing.Size(454, 431);
            this.Controls.Add(this.GridViewSickness);
            this.Controls.Add(this.HeaderGridSickness);
            this.Controls.Add(this.con);
            this.Name = "Sickness_Frm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "بیماری";
            this.Load += new System.EventHandler(this.Sickness_Frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewSickness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLSicknessBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MSSGroupPanel con;
        private MSSGridexView GridViewSickness;
        private MSSHeaderGrid HeaderGridSickness;
        private MSSPanel mssPanel1;
        private System.Windows.Forms.BindingSource tBLSicknessBindingSource;
    }
}
