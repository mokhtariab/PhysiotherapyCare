using MKH.Library.Control;

namespace PhysiotherapyCare.View.BaseForms
{
    partial class PatientType_Frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientType_Frm));
            Janus.Windows.GridEX.GridEXLayout GridViewPatientType_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.con = new MKH.Library.Control.MSSGroupPanel(this.components);
            this.GridViewPatientType = new MKH.Library.Control.MSSGridexView();
            this.tBLPatientTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HeaderGridPatientType = new MKH.Library.Control.MSSHeaderGrid();
            this.mssPanel1 = new MKH.Library.Control.MSSPanel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewPatientType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLPatientTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // con
            // 
            this.con.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.con.Font = new System.Drawing.Font("Tahoma", 8F);
            this.con.Location = new System.Drawing.Point(0, 405);
            this.con.Name = "con";
            this.con.Size = new System.Drawing.Size(461, 26);
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
            // GridViewPatientType
            // 
            this.GridViewPatientType.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.GridViewPatientType.AlternatingColors = true;
            this.GridViewPatientType.AlternatingRowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewPatientType.BuiltInTextsData = resources.GetString("GridViewPatientType.BuiltInTextsData");
            this.GridViewPatientType.CardViewGridlines = Janus.Windows.GridEX.CardViewGridlines.Both;
            this.GridViewPatientType.DataSource = this.tBLPatientTypeBindingSource;
            this.GridViewPatientType.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            GridViewPatientType_DesignTimeLayout.LayoutString = resources.GetString("GridViewPatientType_DesignTimeLayout.LayoutString");
            this.GridViewPatientType.DesignTimeLayout = GridViewPatientType_DesignTimeLayout;
            this.GridViewPatientType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewPatientType.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.GridViewPatientType.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.GridViewPatientType.Font = new System.Drawing.Font("Tahoma", 8.150944F);
            this.GridViewPatientType.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewPatientType.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
            this.GridViewPatientType.Location = new System.Drawing.Point(0, 56);
            this.GridViewPatientType.Name = "GridViewPatientType";
            this.GridViewPatientType.RecordNavigator = true;
            this.GridViewPatientType.RowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewPatientType.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition;
            this.GridViewPatientType.RowHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewPatientType.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.GridViewPatientType.Size = new System.Drawing.Size(461, 349);
            this.GridViewPatientType.TabIndex = 30;
            this.GridViewPatientType.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.GridViewPatientType.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010;
            this.GridViewPatientType.DoubleClick += new System.EventHandler(this.headerGridPatientType_btnEditClick);
            // 
            // tBLPatientTypeBindingSource
            // 
            this.tBLPatientTypeBindingSource.DataSource = typeof(PhysiotherapyCare.Model.Basic.TBL_PatientType);
            // 
            // HeaderGridPatientType
            // 
            // 
            // 
            // 
            this.HeaderGridPatientType.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridPatientType.BackgroundStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridPatientType.BackgroundStyle.BorderBottomWidth = 1;
            this.HeaderGridPatientType.BackgroundStyle.BorderLeftWidth = 1;
            this.HeaderGridPatientType.BackgroundStyle.BorderRightWidth = 1;
            this.HeaderGridPatientType.BackgroundStyle.BorderTopWidth = 1;
            this.HeaderGridPatientType.BackgroundStyle.Class = "ItemPanel";
            this.HeaderGridPatientType.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.HeaderGridPatientType.BackgroundStyle.PaddingBottom = 1;
            this.HeaderGridPatientType.BackgroundStyle.PaddingLeft = 1;
            this.HeaderGridPatientType.BackgroundStyle.PaddingRight = 1;
            this.HeaderGridPatientType.BackgroundStyle.PaddingTop = 1;
            this.HeaderGridPatientType.ButtonDeletePermissionCode = 94;
            this.HeaderGridPatientType.ButtonDeleteVisible = true;
            this.HeaderGridPatientType.ButtonEditPermissionCode = 93;
            this.HeaderGridPatientType.ButtonEditVisible = true;
            this.HeaderGridPatientType.ButtonExcelExportVisible = false;
            this.HeaderGridPatientType.ButtonExcelPermissionCode = 0;
            this.HeaderGridPatientType.ButtonInsertPermissionCode = 92;
            this.HeaderGridPatientType.ButtonInsertVisible = true;
            this.HeaderGridPatientType.ButtonPrintExpertPermissionCode = 0;
            this.HeaderGridPatientType.ButtonPrintExpertVisible = false;
            this.HeaderGridPatientType.ButtonPrintPermissionCode = 95;
            this.HeaderGridPatientType.ButtonPrintVisible = true;
            this.HeaderGridPatientType.ButtonPrintWithDesignPermissionCode = 0;
            this.HeaderGridPatientType.ButtonPrintWithDesignVisible = false;
            this.HeaderGridPatientType.ButtonRefreshVisible = true;
            this.HeaderGridPatientType.ButtonSearchExpertVisible = false;
            this.HeaderGridPatientType.ButtonSearchVisible = true;
            this.HeaderGridPatientType.ButtonSelectorVisible = false;
            this.HeaderGridPatientType.ContainerControlProcessDialogKey = true;
            this.HeaderGridPatientType.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderGridPatientType.FitButtonsToContainerWidth = true;
            this.HeaderGridPatientType.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.HeaderGridPatientType.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.HeaderGridPatientType.GridViewSet = this.GridViewPatientType;
            this.HeaderGridPatientType.Location = new System.Drawing.Point(0, 0);
            this.HeaderGridPatientType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HeaderGridPatientType.Name = "HeaderGridPatientType";
            this.HeaderGridPatientType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HeaderGridPatientType.Size = new System.Drawing.Size(461, 56);
            this.HeaderGridPatientType.TabIndex = 31;
            this.HeaderGridPatientType.Text = "mssHeaderGrid1";
            this.HeaderGridPatientType.ThemeAware = true;
            this.HeaderGridPatientType.buttonItemInsertClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemInsertClickEventHandler(this.headerGridPatientType_btnInsertClick);
            this.HeaderGridPatientType.buttonItemEditClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemEditClickEventHandler(this.headerGridPatientType_btnEditClick);
            this.HeaderGridPatientType.buttonItemDeleteClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemDeleteClickEventHandler(this.headerGridPatientType_btnDeleteClick);
            this.HeaderGridPatientType.buttonItemRefreshClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemRefreshClickEventHandler(this.headerGridPatientType_btnRefreshClick);
            // 
            // mssPanel1
            // 
            this.mssPanel1.Location = new System.Drawing.Point(0, 0);
            this.mssPanel1.Name = "mssPanel1";
            this.mssPanel1.Size = new System.Drawing.Size(200, 100);
            this.mssPanel1.TabIndex = 0;
            // 
            // PatientType_Frm
            // 
            this.ClientSize = new System.Drawing.Size(461, 431);
            this.Controls.Add(this.GridViewPatientType);
            this.Controls.Add(this.HeaderGridPatientType);
            this.Controls.Add(this.con);
            this.Name = "PatientType_Frm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "نسبت با شهید";
            this.Load += new System.EventHandler(this.PatientType_Frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewPatientType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLPatientTypeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MSSGroupPanel con;
        private MSSGridexView GridViewPatientType;
        private MSSHeaderGrid HeaderGridPatientType;
        private MSSPanel mssPanel1;
        private System.Windows.Forms.BindingSource tBLPatientTypeBindingSource;
    }
}
