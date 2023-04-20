using MKH.Library.Control;

namespace PhysiotherapyCare.View.MainForms.PatientStatusPhysiotherapy
{
    partial class PatientStatusPhysiotherapy_UC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientStatusPhysiotherapy_UC));
            Janus.Windows.GridEX.GridEXLayout GridViewPatientStatusPhysiotherapy_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.con = new MKH.Library.Control.MSSGroupPanel(this.components);
            this.GridViewPatientStatusPhysiotherapy = new MKH.Library.Control.MSSGridexView();
            this.vWPatientStatusPhysiotherapyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HeaderGridPatientStatusPhysiotherapy = new MKH.Library.Control.MSSHeaderGrid();
            this.mssPanel1 = new MKH.Library.Control.MSSPanel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewPatientStatusPhysiotherapy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWPatientStatusPhysiotherapyBindingSource)).BeginInit();
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
            // GridViewPatientStatusPhysiotherapy
            // 
            this.GridViewPatientStatusPhysiotherapy.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.GridViewPatientStatusPhysiotherapy.AlternatingColors = true;
            this.GridViewPatientStatusPhysiotherapy.AlternatingRowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewPatientStatusPhysiotherapy.BuiltInTextsData = resources.GetString("GridViewPatientStatusPhysiotherapy.BuiltInTextsData");
            this.GridViewPatientStatusPhysiotherapy.CardViewGridlines = Janus.Windows.GridEX.CardViewGridlines.Both;
            this.GridViewPatientStatusPhysiotherapy.DataSource = this.vWPatientStatusPhysiotherapyBindingSource;
            this.GridViewPatientStatusPhysiotherapy.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            GridViewPatientStatusPhysiotherapy_DesignTimeLayout.LayoutString = resources.GetString("GridViewPatientStatusPhysiotherapy_DesignTimeLayout.LayoutString");
            this.GridViewPatientStatusPhysiotherapy.DesignTimeLayout = GridViewPatientStatusPhysiotherapy_DesignTimeLayout;
            this.GridViewPatientStatusPhysiotherapy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewPatientStatusPhysiotherapy.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.GridViewPatientStatusPhysiotherapy.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.GridViewPatientStatusPhysiotherapy.Font = new System.Drawing.Font("Tahoma", 8.150944F);
            this.GridViewPatientStatusPhysiotherapy.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewPatientStatusPhysiotherapy.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
            this.GridViewPatientStatusPhysiotherapy.Location = new System.Drawing.Point(0, 61);
            this.GridViewPatientStatusPhysiotherapy.Name = "GridViewPatientStatusPhysiotherapy";
            this.GridViewPatientStatusPhysiotherapy.RecordNavigator = true;
            this.GridViewPatientStatusPhysiotherapy.RowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewPatientStatusPhysiotherapy.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition;
            this.GridViewPatientStatusPhysiotherapy.RowHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewPatientStatusPhysiotherapy.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.GridViewPatientStatusPhysiotherapy.Size = new System.Drawing.Size(613, 344);
            this.GridViewPatientStatusPhysiotherapy.TabIndex = 30;
            this.GridViewPatientStatusPhysiotherapy.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.GridViewPatientStatusPhysiotherapy.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010;
            this.GridViewPatientStatusPhysiotherapy.DoubleClick += new System.EventHandler(this.headerGridPatientStatusPhysiotherapy_btnEditClick);
            // 
            // vWPatientStatusPhysiotherapyBindingSource
            // 
            this.vWPatientStatusPhysiotherapyBindingSource.DataSource = typeof(PhysiotherapyCare.Model.PatientStatusPhysiotherapy.VW_PatientStatusPhysiotherapy);
            // 
            // HeaderGridPatientStatusPhysiotherapy
            // 
            // 
            // 
            // 
            this.HeaderGridPatientStatusPhysiotherapy.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridPatientStatusPhysiotherapy.BackgroundStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridPatientStatusPhysiotherapy.BackgroundStyle.BorderBottomWidth = 1;
            this.HeaderGridPatientStatusPhysiotherapy.BackgroundStyle.BorderLeftWidth = 1;
            this.HeaderGridPatientStatusPhysiotherapy.BackgroundStyle.BorderRightWidth = 1;
            this.HeaderGridPatientStatusPhysiotherapy.BackgroundStyle.BorderTopWidth = 1;
            this.HeaderGridPatientStatusPhysiotherapy.BackgroundStyle.Class = "ItemPanel";
            this.HeaderGridPatientStatusPhysiotherapy.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.HeaderGridPatientStatusPhysiotherapy.BackgroundStyle.PaddingBottom = 1;
            this.HeaderGridPatientStatusPhysiotherapy.BackgroundStyle.PaddingLeft = 1;
            this.HeaderGridPatientStatusPhysiotherapy.BackgroundStyle.PaddingRight = 1;
            this.HeaderGridPatientStatusPhysiotherapy.BackgroundStyle.PaddingTop = 1;
            this.HeaderGridPatientStatusPhysiotherapy.ButtonDeletePermissionCode = 61;
            this.HeaderGridPatientStatusPhysiotherapy.ButtonDeleteVisible = true;
            this.HeaderGridPatientStatusPhysiotherapy.ButtonEditPermissionCode = 60;
            this.HeaderGridPatientStatusPhysiotherapy.ButtonEditVisible = true;
            this.HeaderGridPatientStatusPhysiotherapy.ButtonExcelExportVisible = false;
            this.HeaderGridPatientStatusPhysiotherapy.ButtonExcelPermissionCode = 0;
            this.HeaderGridPatientStatusPhysiotherapy.ButtonInsertPermissionCode = 59;
            this.HeaderGridPatientStatusPhysiotherapy.ButtonInsertVisible = true;
            this.HeaderGridPatientStatusPhysiotherapy.ButtonPrintExpertPermissionCode = 0;
            this.HeaderGridPatientStatusPhysiotherapy.ButtonPrintExpertVisible = false;
            this.HeaderGridPatientStatusPhysiotherapy.ButtonPrintPermissionCode = 62;
            this.HeaderGridPatientStatusPhysiotherapy.ButtonPrintVisible = true;
            this.HeaderGridPatientStatusPhysiotherapy.ButtonRefreshVisible = true;
            this.HeaderGridPatientStatusPhysiotherapy.ButtonSearchExpertVisible = false;
            this.HeaderGridPatientStatusPhysiotherapy.ButtonSearchVisible = true;
            this.HeaderGridPatientStatusPhysiotherapy.ButtonSelectorVisible = false;
            this.HeaderGridPatientStatusPhysiotherapy.ContainerControlProcessDialogKey = true;
            this.HeaderGridPatientStatusPhysiotherapy.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderGridPatientStatusPhysiotherapy.FitButtonsToContainerWidth = true;
            this.HeaderGridPatientStatusPhysiotherapy.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.HeaderGridPatientStatusPhysiotherapy.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.HeaderGridPatientStatusPhysiotherapy.GridViewSet = this.GridViewPatientStatusPhysiotherapy;
            this.HeaderGridPatientStatusPhysiotherapy.Location = new System.Drawing.Point(0, 0);
            this.HeaderGridPatientStatusPhysiotherapy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HeaderGridPatientStatusPhysiotherapy.Name = "HeaderGridPatientStatusPhysiotherapy";
            this.HeaderGridPatientStatusPhysiotherapy.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HeaderGridPatientStatusPhysiotherapy.Size = new System.Drawing.Size(613, 61);
            this.HeaderGridPatientStatusPhysiotherapy.TabIndex = 31;
            this.HeaderGridPatientStatusPhysiotherapy.Text = "mssHeaderGrid1";
            this.HeaderGridPatientStatusPhysiotherapy.ThemeAware = true;
            this.HeaderGridPatientStatusPhysiotherapy.buttonItemInsertClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemInsertClickEventHandler(this.headerGridPatientStatusPhysiotherapy_btnInsertClick);
            this.HeaderGridPatientStatusPhysiotherapy.buttonItemEditClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemEditClickEventHandler(this.headerGridPatientStatusPhysiotherapy_btnEditClick);
            this.HeaderGridPatientStatusPhysiotherapy.buttonItemDeleteClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemDeleteClickEventHandler(this.headerGridPatientStatusPhysiotherapy_btnDeleteClick);
            this.HeaderGridPatientStatusPhysiotherapy.buttonItemRefreshClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemRefreshClickEventHandler(this.headerGridPatientStatusPhysiotherapy_btnRefreshClick);
            // 
            // mssPanel1
            // 
            this.mssPanel1.Location = new System.Drawing.Point(0, 0);
            this.mssPanel1.Name = "mssPanel1";
            this.mssPanel1.Size = new System.Drawing.Size(200, 100);
            this.mssPanel1.TabIndex = 0;
            // 
            // PatientStatusPhysiotherapy_UC
            // 
            this.Controls.Add(this.GridViewPatientStatusPhysiotherapy);
            this.Controls.Add(this.HeaderGridPatientStatusPhysiotherapy);
            this.Controls.Add(this.con);
            this.Name = "PatientStatusPhysiotherapy_UC";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(613, 431);
            this.Load += new System.EventHandler(this.PatientStatusPhysiotherapy_UC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewPatientStatusPhysiotherapy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWPatientStatusPhysiotherapyBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MSSGroupPanel con;
        private MSSGridexView GridViewPatientStatusPhysiotherapy;
        private MSSHeaderGrid HeaderGridPatientStatusPhysiotherapy;
        private MSSPanel mssPanel1;
        private System.Windows.Forms.BindingSource vWPatientStatusPhysiotherapyBindingSource;
    }
}
