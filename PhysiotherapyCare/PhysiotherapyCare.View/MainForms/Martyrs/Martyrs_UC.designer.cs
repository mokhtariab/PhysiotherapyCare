using MKH.Library.Control;

namespace PhysiotherapyCare.View.MainForms.Martyrs
{
    partial class Martyrs_UC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Martyrs_UC));
            Janus.Windows.GridEX.GridEXLayout GridViewMartyrs_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.GridViewMartyrs = new MKH.Library.Control.MSSGridexView();
            this.tBLMartyrBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HeaderGridMartyrs = new MKH.Library.Control.MSSHeaderGrid();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewMartyrs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLMartyrBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // GridViewMartyrs
            // 
            this.GridViewMartyrs.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.GridViewMartyrs.AlternatingColors = true;
            this.GridViewMartyrs.AlternatingRowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewMartyrs.BuiltInTextsData = resources.GetString("GridViewMartyrs.BuiltInTextsData");
            this.GridViewMartyrs.CardViewGridlines = Janus.Windows.GridEX.CardViewGridlines.Both;
            this.GridViewMartyrs.DataSource = this.tBLMartyrBindingSource;
            this.GridViewMartyrs.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            GridViewMartyrs_DesignTimeLayout.LayoutString = resources.GetString("GridViewMartyrs_DesignTimeLayout.LayoutString");
            this.GridViewMartyrs.DesignTimeLayout = GridViewMartyrs_DesignTimeLayout;
            this.GridViewMartyrs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewMartyrs.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.GridViewMartyrs.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.GridViewMartyrs.Font = new System.Drawing.Font("Tahoma", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.GridViewMartyrs.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewMartyrs.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
            this.GridViewMartyrs.Location = new System.Drawing.Point(0, 56);
            this.GridViewMartyrs.Name = "GridViewMartyrs";
            this.GridViewMartyrs.RecordNavigator = true;
            this.GridViewMartyrs.RowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewMartyrs.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition;
            this.GridViewMartyrs.RowHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewMartyrs.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.GridViewMartyrs.Size = new System.Drawing.Size(819, 449);
            this.GridViewMartyrs.TabIndex = 32;
            this.GridViewMartyrs.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.GridViewMartyrs.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010;
            this.GridViewMartyrs.DoubleClick += new System.EventHandler(this.headerGridMartyrs_btnEditClick);
            // 
            // tBLMartyrBindingSource
            // 
            this.tBLMartyrBindingSource.DataSource = typeof(PhysiotherapyCare.Model.Martyrs.TBL_Martyr);
            // 
            // HeaderGridMartyrs
            // 
            // 
            // 
            // 
            this.HeaderGridMartyrs.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridMartyrs.BackgroundStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridMartyrs.BackgroundStyle.BorderBottomWidth = 1;
            this.HeaderGridMartyrs.BackgroundStyle.BorderLeftWidth = 1;
            this.HeaderGridMartyrs.BackgroundStyle.BorderRightWidth = 1;
            this.HeaderGridMartyrs.BackgroundStyle.BorderTopWidth = 1;
            this.HeaderGridMartyrs.BackgroundStyle.Class = "ItemPanel";
            this.HeaderGridMartyrs.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.HeaderGridMartyrs.BackgroundStyle.PaddingBottom = 1;
            this.HeaderGridMartyrs.BackgroundStyle.PaddingLeft = 1;
            this.HeaderGridMartyrs.BackgroundStyle.PaddingRight = 1;
            this.HeaderGridMartyrs.BackgroundStyle.PaddingTop = 1;
            this.HeaderGridMartyrs.ButtonDeletePermissionCode = 49;
            this.HeaderGridMartyrs.ButtonDeleteVisible = true;
            this.HeaderGridMartyrs.ButtonEditPermissionCode = 48;
            this.HeaderGridMartyrs.ButtonEditVisible = true;
            this.HeaderGridMartyrs.ButtonExcelExportVisible = true;
            this.HeaderGridMartyrs.ButtonExcelPermissionCode = 51;
            this.HeaderGridMartyrs.ButtonInsertPermissionCode = 47;
            this.HeaderGridMartyrs.ButtonInsertVisible = true;
            this.HeaderGridMartyrs.ButtonPrintExpertPermissionCode = 0;
            this.HeaderGridMartyrs.ButtonPrintExpertVisible = false;
            this.HeaderGridMartyrs.ButtonPrintPermissionCode = 50;
            this.HeaderGridMartyrs.ButtonPrintVisible = true;
            this.HeaderGridMartyrs.ButtonPrintWithDesignPermissionCode = 0;
            this.HeaderGridMartyrs.ButtonPrintWithDesignVisible = false;
            this.HeaderGridMartyrs.ButtonRefreshVisible = true;
            this.HeaderGridMartyrs.ButtonSearchExpertVisible = false;
            this.HeaderGridMartyrs.ButtonSearchVisible = true;
            this.HeaderGridMartyrs.ButtonSelectorVisible = true;
            this.HeaderGridMartyrs.ContainerControlProcessDialogKey = true;
            this.HeaderGridMartyrs.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderGridMartyrs.FitButtonsToContainerWidth = true;
            this.HeaderGridMartyrs.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.HeaderGridMartyrs.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.HeaderGridMartyrs.GridViewSet = this.GridViewMartyrs;
            this.HeaderGridMartyrs.Location = new System.Drawing.Point(0, 0);
            this.HeaderGridMartyrs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HeaderGridMartyrs.Name = "HeaderGridMartyrs";
            this.HeaderGridMartyrs.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HeaderGridMartyrs.Size = new System.Drawing.Size(819, 56);
            this.HeaderGridMartyrs.TabIndex = 31;
            this.HeaderGridMartyrs.Tag = "خانواده شهید";
            this.HeaderGridMartyrs.Text = "خانواده شهید";
            this.HeaderGridMartyrs.ThemeAware = true;
            this.HeaderGridMartyrs.buttonItemInsertClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemInsertClickEventHandler(this.headerGridMartyrs_btnInsertClick);
            this.HeaderGridMartyrs.buttonItemEditClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemEditClickEventHandler(this.headerGridMartyrs_btnEditClick);
            this.HeaderGridMartyrs.buttonItemDeleteClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemDeleteClickEventHandler(this.headerGridMartyrs_btnDeleteClick);
            this.HeaderGridMartyrs.buttonItemRefreshClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemRefreshClickEventHandler(this.headerGridMartyrs_btnRefreshClick);
            // 
            // Martyrs_UC
            // 
            this.Controls.Add(this.GridViewMartyrs);
            this.Controls.Add(this.HeaderGridMartyrs);
            this.Name = "Martyrs_UC";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(819, 505);
            this.Tag = "خانواده شهید";
            this.Load += new System.EventHandler(this.Martyrs_UC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewMartyrs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLMartyrBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MSSHeaderGrid HeaderGridMartyrs;
        private MSSGridexView GridViewMartyrs;
        private System.Windows.Forms.BindingSource tBLMartyrBindingSource;
    }
}
