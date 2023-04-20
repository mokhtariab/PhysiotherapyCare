using MKH.Library.Control;

namespace PhysiotherapyCare.View.BaseForms
{
    partial class PatientStatusType_Frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientStatusType_Frm));
            Janus.Windows.GridEX.GridEXLayout GridViewPatientStatusType_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.con = new MKH.Library.Control.MSSGroupPanel(this.components);
            this.GridViewPatientStatusType = new MKH.Library.Control.MSSGridexView();
            this.tBLPatientStatusTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HeaderGridPatientStatusType = new MKH.Library.Control.MSSHeaderGrid();
            this.mssPanel1 = new MKH.Library.Control.MSSPanel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewPatientStatusType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLPatientStatusTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // con
            // 
            this.con.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.con.Font = new System.Drawing.Font("Tahoma", 8F);
            this.con.Location = new System.Drawing.Point(0, 405);
            this.con.Name = "con";
            this.con.Size = new System.Drawing.Size(518, 26);
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
            // GridViewPatientStatusType
            // 
            this.GridViewPatientStatusType.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.GridViewPatientStatusType.AlternatingColors = true;
            this.GridViewPatientStatusType.AlternatingRowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewPatientStatusType.BuiltInTextsData = resources.GetString("GridViewPatientStatusType.BuiltInTextsData");
            this.GridViewPatientStatusType.CardViewGridlines = Janus.Windows.GridEX.CardViewGridlines.Both;
            this.GridViewPatientStatusType.DataSource = this.tBLPatientStatusTypeBindingSource;
            this.GridViewPatientStatusType.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            GridViewPatientStatusType_DesignTimeLayout.LayoutString = resources.GetString("GridViewPatientStatusType_DesignTimeLayout.LayoutString");
            this.GridViewPatientStatusType.DesignTimeLayout = GridViewPatientStatusType_DesignTimeLayout;
            this.GridViewPatientStatusType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewPatientStatusType.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.GridViewPatientStatusType.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.GridViewPatientStatusType.Font = new System.Drawing.Font("Tahoma", 8.150944F);
            this.GridViewPatientStatusType.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewPatientStatusType.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
            this.GridViewPatientStatusType.Location = new System.Drawing.Point(0, 61);
            this.GridViewPatientStatusType.Name = "GridViewPatientStatusType";
            this.GridViewPatientStatusType.RecordNavigator = true;
            this.GridViewPatientStatusType.RowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewPatientStatusType.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition;
            this.GridViewPatientStatusType.RowHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewPatientStatusType.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.GridViewPatientStatusType.Size = new System.Drawing.Size(518, 344);
            this.GridViewPatientStatusType.TabIndex = 30;
            this.GridViewPatientStatusType.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.GridViewPatientStatusType.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010;
            this.GridViewPatientStatusType.DoubleClick += new System.EventHandler(this.headerGridPatientStatusType_btnEditClick);
            // 
            // tBLPatientStatusTypeBindingSource
            // 
            this.tBLPatientStatusTypeBindingSource.DataSource = typeof(PhysiotherapyCare.Model.Basic.TBL_PatientStatusType);
            // 
            // HeaderGridPatientStatusType
            // 
            // 
            // 
            // 
            this.HeaderGridPatientStatusType.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridPatientStatusType.BackgroundStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridPatientStatusType.BackgroundStyle.BorderBottomWidth = 1;
            this.HeaderGridPatientStatusType.BackgroundStyle.BorderLeftWidth = 1;
            this.HeaderGridPatientStatusType.BackgroundStyle.BorderRightWidth = 1;
            this.HeaderGridPatientStatusType.BackgroundStyle.BorderTopWidth = 1;
            this.HeaderGridPatientStatusType.BackgroundStyle.Class = "ItemPanel";
            this.HeaderGridPatientStatusType.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.HeaderGridPatientStatusType.BackgroundStyle.PaddingBottom = 1;
            this.HeaderGridPatientStatusType.BackgroundStyle.PaddingLeft = 1;
            this.HeaderGridPatientStatusType.BackgroundStyle.PaddingRight = 1;
            this.HeaderGridPatientStatusType.BackgroundStyle.PaddingTop = 1;
            this.HeaderGridPatientStatusType.ButtonDeletePermissionCode = 98;
            this.HeaderGridPatientStatusType.ButtonDeleteVisible = true;
            this.HeaderGridPatientStatusType.ButtonEditPermissionCode = 97;
            this.HeaderGridPatientStatusType.ButtonEditVisible = true;
            this.HeaderGridPatientStatusType.ButtonExcelExportVisible = false;
            this.HeaderGridPatientStatusType.ButtonExcelPermissionCode = 0;
            this.HeaderGridPatientStatusType.ButtonInsertPermissionCode = 96;
            this.HeaderGridPatientStatusType.ButtonInsertVisible = true;
            this.HeaderGridPatientStatusType.ButtonPrintExpertPermissionCode = 0;
            this.HeaderGridPatientStatusType.ButtonPrintExpertVisible = false;
            this.HeaderGridPatientStatusType.ButtonPrintPermissionCode = 99;
            this.HeaderGridPatientStatusType.ButtonPrintVisible = true;
            this.HeaderGridPatientStatusType.ButtonRefreshVisible = true;
            this.HeaderGridPatientStatusType.ButtonSearchExpertVisible = false;
            this.HeaderGridPatientStatusType.ButtonSearchVisible = true;
            this.HeaderGridPatientStatusType.ButtonSelectorVisible = false;
            this.HeaderGridPatientStatusType.ContainerControlProcessDialogKey = true;
            this.HeaderGridPatientStatusType.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderGridPatientStatusType.FitButtonsToContainerWidth = true;
            this.HeaderGridPatientStatusType.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.HeaderGridPatientStatusType.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.HeaderGridPatientStatusType.GridViewSet = this.GridViewPatientStatusType;
            this.HeaderGridPatientStatusType.Location = new System.Drawing.Point(0, 0);
            this.HeaderGridPatientStatusType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HeaderGridPatientStatusType.Name = "HeaderGridPatientStatusType";
            this.HeaderGridPatientStatusType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HeaderGridPatientStatusType.Size = new System.Drawing.Size(518, 61);
            this.HeaderGridPatientStatusType.TabIndex = 31;
            this.HeaderGridPatientStatusType.Text = "mssHeaderGrid1";
            this.HeaderGridPatientStatusType.ThemeAware = true;
            this.HeaderGridPatientStatusType.buttonItemInsertClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemInsertClickEventHandler(this.headerGridPatientStatusType_btnInsertClick);
            this.HeaderGridPatientStatusType.buttonItemEditClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemEditClickEventHandler(this.headerGridPatientStatusType_btnEditClick);
            this.HeaderGridPatientStatusType.buttonItemDeleteClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemDeleteClickEventHandler(this.headerGridPatientStatusType_btnDeleteClick);
            this.HeaderGridPatientStatusType.buttonItemRefreshClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemRefreshClickEventHandler(this.headerGridPatientStatusType_btnRefreshClick);
            // 
            // mssPanel1
            // 
            this.mssPanel1.Location = new System.Drawing.Point(0, 0);
            this.mssPanel1.Name = "mssPanel1";
            this.mssPanel1.Size = new System.Drawing.Size(200, 100);
            this.mssPanel1.TabIndex = 0;
            // 
            // PatientStatusType_Frm
            // 
            this.ClientSize = new System.Drawing.Size(518, 431);
            this.Controls.Add(this.GridViewPatientStatusType);
            this.Controls.Add(this.HeaderGridPatientStatusType);
            this.Controls.Add(this.con);
            this.Name = "PatientStatusType_Frm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "وضعیت";
            this.Load += new System.EventHandler(this.PatientStatusType_Frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewPatientStatusType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLPatientStatusTypeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MSSGroupPanel con;
        private MSSGridexView GridViewPatientStatusType;
        private MSSHeaderGrid HeaderGridPatientStatusType;
        private MSSPanel mssPanel1;
        private System.Windows.Forms.BindingSource tBLPatientStatusTypeBindingSource;
    }
}
