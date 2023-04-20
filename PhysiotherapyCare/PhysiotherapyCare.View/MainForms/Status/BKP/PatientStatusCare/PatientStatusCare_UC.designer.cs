using MKH.Library.Control;

namespace PhysiotherapyCare.View.MainForms.PatientStatusCare
{
    partial class PatientStatusCare_UC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientStatusCare_UC));
            Janus.Windows.GridEX.GridEXLayout GridViewPatientStatusCare_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.con = new MKH.Library.Control.MSSGroupPanel(this.components);
            this.GridViewPatientStatusCare = new MKH.Library.Control.MSSGridexView();
            this.vWPatientStatusCareBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HeaderGridPatientStatusCare = new MKH.Library.Control.MSSHeaderGrid();
            this.mssPanel1 = new MKH.Library.Control.MSSPanel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewPatientStatusCare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWPatientStatusCareBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // con
            // 
            this.con.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.con.Font = new System.Drawing.Font("Tahoma", 8F);
            this.con.Location = new System.Drawing.Point(0, 405);
            this.con.Name = "con";
            this.con.Size = new System.Drawing.Size(613, 26);
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
            // GridViewPatientStatusCare
            // 
            this.GridViewPatientStatusCare.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.GridViewPatientStatusCare.AlternatingColors = true;
            this.GridViewPatientStatusCare.AlternatingRowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewPatientStatusCare.BuiltInTextsData = resources.GetString("GridViewPatientStatusCare.BuiltInTextsData");
            this.GridViewPatientStatusCare.CardViewGridlines = Janus.Windows.GridEX.CardViewGridlines.Both;
            this.GridViewPatientStatusCare.DataSource = this.vWPatientStatusCareBindingSource;
            this.GridViewPatientStatusCare.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            GridViewPatientStatusCare_DesignTimeLayout.LayoutString = resources.GetString("GridViewPatientStatusCare_DesignTimeLayout.LayoutString");
            this.GridViewPatientStatusCare.DesignTimeLayout = GridViewPatientStatusCare_DesignTimeLayout;
            this.GridViewPatientStatusCare.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewPatientStatusCare.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.GridViewPatientStatusCare.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.GridViewPatientStatusCare.Font = new System.Drawing.Font("Tahoma", 8.150944F);
            this.GridViewPatientStatusCare.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewPatientStatusCare.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
            this.GridViewPatientStatusCare.Location = new System.Drawing.Point(0, 57);
            this.GridViewPatientStatusCare.Name = "GridViewPatientStatusCare";
            this.GridViewPatientStatusCare.RecordNavigator = true;
            this.GridViewPatientStatusCare.RowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewPatientStatusCare.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition;
            this.GridViewPatientStatusCare.RowHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewPatientStatusCare.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.GridViewPatientStatusCare.Size = new System.Drawing.Size(613, 348);
            this.GridViewPatientStatusCare.TabIndex = 30;
            this.GridViewPatientStatusCare.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.GridViewPatientStatusCare.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010;
            this.GridViewPatientStatusCare.DoubleClick += new System.EventHandler(this.headerGridPatientStatusCare_btnEditClick);
            // 
            // vWPatientStatusCareBindingSource
            // 
            this.vWPatientStatusCareBindingSource.DataSource = typeof(PhysiotherapyCare.Model.PatientStatusCare.VW_PatientStatusCare);
            // 
            // HeaderGridPatientStatusCare
            // 
            // 
            // 
            // 
            this.HeaderGridPatientStatusCare.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridPatientStatusCare.BackgroundStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridPatientStatusCare.BackgroundStyle.BorderBottomWidth = 1;
            this.HeaderGridPatientStatusCare.BackgroundStyle.BorderLeftWidth = 1;
            this.HeaderGridPatientStatusCare.BackgroundStyle.BorderRightWidth = 1;
            this.HeaderGridPatientStatusCare.BackgroundStyle.BorderTopWidth = 1;
            this.HeaderGridPatientStatusCare.BackgroundStyle.Class = "ItemPanel";
            this.HeaderGridPatientStatusCare.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.HeaderGridPatientStatusCare.BackgroundStyle.PaddingBottom = 1;
            this.HeaderGridPatientStatusCare.BackgroundStyle.PaddingLeft = 1;
            this.HeaderGridPatientStatusCare.BackgroundStyle.PaddingRight = 1;
            this.HeaderGridPatientStatusCare.BackgroundStyle.PaddingTop = 1;
            this.HeaderGridPatientStatusCare.ButtonDeletePermissionCode = 77;
            this.HeaderGridPatientStatusCare.ButtonDeleteVisible = true;
            this.HeaderGridPatientStatusCare.ButtonEditPermissionCode = 76;
            this.HeaderGridPatientStatusCare.ButtonEditVisible = true;
            this.HeaderGridPatientStatusCare.ButtonExcelExportVisible = false;
            this.HeaderGridPatientStatusCare.ButtonExcelPermissionCode = 0;
            this.HeaderGridPatientStatusCare.ButtonInsertPermissionCode = 75;
            this.HeaderGridPatientStatusCare.ButtonInsertVisible = true;
            this.HeaderGridPatientStatusCare.ButtonPrintExpertPermissionCode = 0;
            this.HeaderGridPatientStatusCare.ButtonPrintExpertVisible = false;
            this.HeaderGridPatientStatusCare.ButtonPrintPermissionCode = 78;
            this.HeaderGridPatientStatusCare.ButtonPrintVisible = true;
            this.HeaderGridPatientStatusCare.ButtonRefreshVisible = true;
            this.HeaderGridPatientStatusCare.ButtonSearchExpertVisible = false;
            this.HeaderGridPatientStatusCare.ButtonSearchVisible = true;
            this.HeaderGridPatientStatusCare.ButtonSelectorVisible = false;
            this.HeaderGridPatientStatusCare.ContainerControlProcessDialogKey = true;
            this.HeaderGridPatientStatusCare.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderGridPatientStatusCare.FitButtonsToContainerWidth = true;
            this.HeaderGridPatientStatusCare.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.HeaderGridPatientStatusCare.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.HeaderGridPatientStatusCare.GridViewSet = this.GridViewPatientStatusCare;
            this.HeaderGridPatientStatusCare.Location = new System.Drawing.Point(0, 0);
            this.HeaderGridPatientStatusCare.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HeaderGridPatientStatusCare.Name = "HeaderGridPatientStatusCare";
            this.HeaderGridPatientStatusCare.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HeaderGridPatientStatusCare.Size = new System.Drawing.Size(613, 57);
            this.HeaderGridPatientStatusCare.TabIndex = 31;
            this.HeaderGridPatientStatusCare.Text = "mssHeaderGrid1";
            this.HeaderGridPatientStatusCare.ThemeAware = true;
            this.HeaderGridPatientStatusCare.buttonItemInsertClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemInsertClickEventHandler(this.headerGridPatientStatusCare_btnInsertClick);
            this.HeaderGridPatientStatusCare.buttonItemEditClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemEditClickEventHandler(this.headerGridPatientStatusCare_btnEditClick);
            this.HeaderGridPatientStatusCare.buttonItemDeleteClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemDeleteClickEventHandler(this.headerGridPatientStatusCare_btnDeleteClick);
            this.HeaderGridPatientStatusCare.buttonItemRefreshClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemRefreshClickEventHandler(this.headerGridPatientStatusCare_btnRefreshClick);
            // 
            // mssPanel1
            // 
            this.mssPanel1.Location = new System.Drawing.Point(0, 0);
            this.mssPanel1.Name = "mssPanel1";
            this.mssPanel1.Size = new System.Drawing.Size(200, 100);
            this.mssPanel1.TabIndex = 0;
            // 
            // PatientStatusCare_UC
            // 
            this.Controls.Add(this.GridViewPatientStatusCare);
            this.Controls.Add(this.HeaderGridPatientStatusCare);
            this.Controls.Add(this.con);
            this.Name = "PatientStatusCare_UC";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(613, 431);
            this.Load += new System.EventHandler(this.PatientStatusCare_UC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewPatientStatusCare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWPatientStatusCareBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MSSGroupPanel con;
        private MSSGridexView GridViewPatientStatusCare;
        private MSSHeaderGrid HeaderGridPatientStatusCare;
        private MSSPanel mssPanel1;
        private System.Windows.Forms.BindingSource vWPatientStatusCareBindingSource;
    }
}
