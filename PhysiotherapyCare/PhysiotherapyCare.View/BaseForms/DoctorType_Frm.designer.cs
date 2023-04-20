using MKH.Library.Control;

namespace PhysiotherapyCare.View.BaseForms
{
    partial class DoctorType_Frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorType_Frm));
            Janus.Windows.GridEX.GridEXLayout GridViewDoctorType_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.con = new MKH.Library.Control.MSSGroupPanel(this.components);
            this.GridViewDoctorType = new MKH.Library.Control.MSSGridexView();
            this.tBLDoctorTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HeaderGridDoctorType = new MKH.Library.Control.MSSHeaderGrid();
            this.mssPanel1 = new MKH.Library.Control.MSSPanel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewDoctorType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLDoctorTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // con
            // 
            this.con.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.con.Font = new System.Drawing.Font("Tahoma", 8F);
            this.con.Location = new System.Drawing.Point(0, 405);
            this.con.Name = "con";
            this.con.Size = new System.Drawing.Size(442, 26);
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
            // GridViewDoctorType
            // 
            this.GridViewDoctorType.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.GridViewDoctorType.AlternatingColors = true;
            this.GridViewDoctorType.AlternatingRowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewDoctorType.BuiltInTextsData = resources.GetString("GridViewDoctorType.BuiltInTextsData");
            this.GridViewDoctorType.CardViewGridlines = Janus.Windows.GridEX.CardViewGridlines.Both;
            this.GridViewDoctorType.DataSource = this.tBLDoctorTypeBindingSource;
            this.GridViewDoctorType.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            GridViewDoctorType_DesignTimeLayout.LayoutString = resources.GetString("GridViewDoctorType_DesignTimeLayout.LayoutString");
            this.GridViewDoctorType.DesignTimeLayout = GridViewDoctorType_DesignTimeLayout;
            this.GridViewDoctorType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewDoctorType.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.GridViewDoctorType.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.GridViewDoctorType.Font = new System.Drawing.Font("Tahoma", 8.150944F);
            this.GridViewDoctorType.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewDoctorType.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
            this.GridViewDoctorType.Location = new System.Drawing.Point(0, 61);
            this.GridViewDoctorType.Name = "GridViewDoctorType";
            this.GridViewDoctorType.RecordNavigator = true;
            this.GridViewDoctorType.RowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewDoctorType.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition;
            this.GridViewDoctorType.RowHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewDoctorType.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.GridViewDoctorType.Size = new System.Drawing.Size(442, 344);
            this.GridViewDoctorType.TabIndex = 30;
            this.GridViewDoctorType.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.GridViewDoctorType.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010;
            this.GridViewDoctorType.DoubleClick += new System.EventHandler(this.headerGridDoctorType_btnEditClick);
            // 
            // HeaderGridDoctorType
            // 
            // 
            // 
            // 
            this.HeaderGridDoctorType.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridDoctorType.BackgroundStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridDoctorType.BackgroundStyle.BorderBottomWidth = 1;
            this.HeaderGridDoctorType.BackgroundStyle.BorderLeftWidth = 1;
            this.HeaderGridDoctorType.BackgroundStyle.BorderRightWidth = 1;
            this.HeaderGridDoctorType.BackgroundStyle.BorderTopWidth = 1;
            this.HeaderGridDoctorType.BackgroundStyle.Class = "ItemPanel";
            this.HeaderGridDoctorType.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.HeaderGridDoctorType.BackgroundStyle.PaddingBottom = 1;
            this.HeaderGridDoctorType.BackgroundStyle.PaddingLeft = 1;
            this.HeaderGridDoctorType.BackgroundStyle.PaddingRight = 1;
            this.HeaderGridDoctorType.BackgroundStyle.PaddingTop = 1;
            this.HeaderGridDoctorType.ButtonDeletePermissionCode = 86;
            this.HeaderGridDoctorType.ButtonDeleteVisible = true;
            this.HeaderGridDoctorType.ButtonEditPermissionCode = 85;
            this.HeaderGridDoctorType.ButtonEditVisible = true;
            this.HeaderGridDoctorType.ButtonExcelExportVisible = false;
            this.HeaderGridDoctorType.ButtonExcelPermissionCode = 0;
            this.HeaderGridDoctorType.ButtonInsertPermissionCode = 84;
            this.HeaderGridDoctorType.ButtonInsertVisible = true;
            this.HeaderGridDoctorType.ButtonPrintExpertPermissionCode = 0;
            this.HeaderGridDoctorType.ButtonPrintExpertVisible = false;
            this.HeaderGridDoctorType.ButtonPrintPermissionCode = 87;
            this.HeaderGridDoctorType.ButtonPrintVisible = true;
            this.HeaderGridDoctorType.ButtonPrintWithDesignPermissionCode = 0;
            this.HeaderGridDoctorType.ButtonPrintWithDesignVisible = false;
            this.HeaderGridDoctorType.ButtonRefreshVisible = true;
            this.HeaderGridDoctorType.ButtonSearchExpertVisible = false;
            this.HeaderGridDoctorType.ButtonSearchVisible = true;
            this.HeaderGridDoctorType.ButtonSelectorVisible = false;
            this.HeaderGridDoctorType.ContainerControlProcessDialogKey = true;
            this.HeaderGridDoctorType.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderGridDoctorType.FitButtonsToContainerWidth = true;
            this.HeaderGridDoctorType.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.HeaderGridDoctorType.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.HeaderGridDoctorType.GridViewSet = this.GridViewDoctorType;
            this.HeaderGridDoctorType.Location = new System.Drawing.Point(0, 0);
            this.HeaderGridDoctorType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HeaderGridDoctorType.Name = "HeaderGridDoctorType";
            this.HeaderGridDoctorType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HeaderGridDoctorType.Size = new System.Drawing.Size(442, 61);
            this.HeaderGridDoctorType.TabIndex = 31;
            this.HeaderGridDoctorType.Text = "mssHeaderGrid1";
            this.HeaderGridDoctorType.ThemeAware = true;
            this.HeaderGridDoctorType.buttonItemInsertClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemInsertClickEventHandler(this.headerGridDoctorType_btnInsertClick);
            this.HeaderGridDoctorType.buttonItemEditClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemEditClickEventHandler(this.headerGridDoctorType_btnEditClick);
            this.HeaderGridDoctorType.buttonItemDeleteClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemDeleteClickEventHandler(this.headerGridDoctorType_btnDeleteClick);
            this.HeaderGridDoctorType.buttonItemRefreshClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemRefreshClickEventHandler(this.headerGridDoctorType_btnRefreshClick);
            // 
            // mssPanel1
            // 
            this.mssPanel1.Location = new System.Drawing.Point(0, 0);
            this.mssPanel1.Name = "mssPanel1";
            this.mssPanel1.Size = new System.Drawing.Size(200, 100);
            this.mssPanel1.TabIndex = 0;
            // 
            // DoctorType_Frm
            // 
            this.ClientSize = new System.Drawing.Size(442, 431);
            this.Controls.Add(this.GridViewDoctorType);
            this.Controls.Add(this.HeaderGridDoctorType);
            this.Controls.Add(this.con);
            this.Name = "DoctorType_Frm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "نوع پزشک";
            this.Load += new System.EventHandler(this.DoctorType_Frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewDoctorType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLDoctorTypeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MSSGroupPanel con;
        private MSSGridexView GridViewDoctorType;
        private MSSHeaderGrid HeaderGridDoctorType;
        private MSSPanel mssPanel1;
        private System.Windows.Forms.BindingSource tBLDoctorTypeBindingSource;
    }
}
