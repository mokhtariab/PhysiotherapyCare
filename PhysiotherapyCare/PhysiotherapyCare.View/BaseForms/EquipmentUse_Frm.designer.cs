using MKH.Library.Control;

namespace PhysiotherapyCare.View.BaseForms
{
    partial class EquipmentUse_Frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EquipmentUse_Frm));
            Janus.Windows.GridEX.GridEXLayout GridViewEquipmentUse_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.con = new MKH.Library.Control.MSSGroupPanel(this.components);
            this.GridViewEquipmentUse = new MKH.Library.Control.MSSGridexView();
            this.tBLKinShipBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HeaderGridKinShip = new MKH.Library.Control.MSSHeaderGrid();
            this.mssPanel1 = new MKH.Library.Control.MSSPanel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewEquipmentUse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLKinShipBindingSource)).BeginInit();
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
            // GridViewEquipmentUse
            // 
            this.GridViewEquipmentUse.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.GridViewEquipmentUse.AlternatingColors = true;
            this.GridViewEquipmentUse.AlternatingRowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewEquipmentUse.BuiltInTextsData = resources.GetString("GridViewEquipmentUse.BuiltInTextsData");
            this.GridViewEquipmentUse.CardViewGridlines = Janus.Windows.GridEX.CardViewGridlines.Both;
            this.GridViewEquipmentUse.DataSource = this.tBLKinShipBindingSource;
            this.GridViewEquipmentUse.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            GridViewEquipmentUse_DesignTimeLayout.LayoutString = resources.GetString("GridViewEquipmentUse_DesignTimeLayout.LayoutString");
            this.GridViewEquipmentUse.DesignTimeLayout = GridViewEquipmentUse_DesignTimeLayout;
            this.GridViewEquipmentUse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewEquipmentUse.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.GridViewEquipmentUse.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.GridViewEquipmentUse.Font = new System.Drawing.Font("Tahoma", 8.150944F);
            this.GridViewEquipmentUse.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewEquipmentUse.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
            this.GridViewEquipmentUse.Location = new System.Drawing.Point(0, 61);
            this.GridViewEquipmentUse.Name = "GridViewEquipmentUse";
            this.GridViewEquipmentUse.RecordNavigator = true;
            this.GridViewEquipmentUse.RowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewEquipmentUse.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition;
            this.GridViewEquipmentUse.RowHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewEquipmentUse.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.GridViewEquipmentUse.Size = new System.Drawing.Size(454, 344);
            this.GridViewEquipmentUse.TabIndex = 30;
            this.GridViewEquipmentUse.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.GridViewEquipmentUse.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010;
            this.GridViewEquipmentUse.DoubleClick += new System.EventHandler(this.headerGridKinShip_btnEditClick);
            // 
            // tBLKinShipBindingSource
            // 
            this.tBLKinShipBindingSource.DataSource = typeof(PhysiotherapyCare.Model.Basic.TBL_KinShip);
            // 
            // HeaderGridKinShip
            // 
            // 
            // 
            // 
            this.HeaderGridKinShip.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridKinShip.BackgroundStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridKinShip.BackgroundStyle.BorderBottomWidth = 1;
            this.HeaderGridKinShip.BackgroundStyle.BorderLeftWidth = 1;
            this.HeaderGridKinShip.BackgroundStyle.BorderRightWidth = 1;
            this.HeaderGridKinShip.BackgroundStyle.BorderTopWidth = 1;
            this.HeaderGridKinShip.BackgroundStyle.Class = "ItemPanel";
            this.HeaderGridKinShip.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.HeaderGridKinShip.BackgroundStyle.PaddingBottom = 1;
            this.HeaderGridKinShip.BackgroundStyle.PaddingLeft = 1;
            this.HeaderGridKinShip.BackgroundStyle.PaddingRight = 1;
            this.HeaderGridKinShip.BackgroundStyle.PaddingTop = 1;
            this.HeaderGridKinShip.ButtonDeletePermissionCode = 256;
            this.HeaderGridKinShip.ButtonDeleteVisible = true;
            this.HeaderGridKinShip.ButtonEditPermissionCode = 255;
            this.HeaderGridKinShip.ButtonEditVisible = true;
            this.HeaderGridKinShip.ButtonExcelExportVisible = false;
            this.HeaderGridKinShip.ButtonExcelPermissionCode = 0;
            this.HeaderGridKinShip.ButtonInsertPermissionCode = 254;
            this.HeaderGridKinShip.ButtonInsertVisible = true;
            this.HeaderGridKinShip.ButtonPrintExpertPermissionCode = 0;
            this.HeaderGridKinShip.ButtonPrintExpertVisible = false;
            this.HeaderGridKinShip.ButtonPrintPermissionCode = 257;
            this.HeaderGridKinShip.ButtonPrintVisible = true;
            this.HeaderGridKinShip.ButtonPrintWithDesignPermissionCode = 0;
            this.HeaderGridKinShip.ButtonPrintWithDesignVisible = false;
            this.HeaderGridKinShip.ButtonRefreshVisible = true;
            this.HeaderGridKinShip.ButtonSearchExpertVisible = false;
            this.HeaderGridKinShip.ButtonSearchVisible = true;
            this.HeaderGridKinShip.ButtonSelectorVisible = false;
            this.HeaderGridKinShip.ContainerControlProcessDialogKey = true;
            this.HeaderGridKinShip.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderGridKinShip.FitButtonsToContainerWidth = true;
            this.HeaderGridKinShip.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.HeaderGridKinShip.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.HeaderGridKinShip.GridViewSet = this.GridViewEquipmentUse;
            this.HeaderGridKinShip.Location = new System.Drawing.Point(0, 0);
            this.HeaderGridKinShip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HeaderGridKinShip.Name = "HeaderGridKinShip";
            this.HeaderGridKinShip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HeaderGridKinShip.Size = new System.Drawing.Size(454, 61);
            this.HeaderGridKinShip.TabIndex = 31;
            this.HeaderGridKinShip.Text = "mssHeaderGrid1";
            this.HeaderGridKinShip.ThemeAware = true;
            this.HeaderGridKinShip.buttonItemInsertClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemInsertClickEventHandler(this.headerGridKinShip_btnInsertClick);
            this.HeaderGridKinShip.buttonItemEditClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemEditClickEventHandler(this.headerGridKinShip_btnEditClick);
            this.HeaderGridKinShip.buttonItemDeleteClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemDeleteClickEventHandler(this.headerGridKinShip_btnDeleteClick);
            this.HeaderGridKinShip.buttonItemRefreshClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemRefreshClickEventHandler(this.headerGridKinShip_btnRefreshClick);
            // 
            // mssPanel1
            // 
            this.mssPanel1.Location = new System.Drawing.Point(0, 0);
            this.mssPanel1.Name = "mssPanel1";
            this.mssPanel1.Size = new System.Drawing.Size(200, 100);
            this.mssPanel1.TabIndex = 0;
            // 
            // EquipmentUse_Frm
            // 
            this.ClientSize = new System.Drawing.Size(454, 431);
            this.Controls.Add(this.GridViewEquipmentUse);
            this.Controls.Add(this.HeaderGridKinShip);
            this.Controls.Add(this.con);
            this.Name = "EquipmentUse_Frm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "تجهیزات مصرفی";
            this.Load += new System.EventHandler(this.KinShip_Frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewEquipmentUse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLKinShipBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MSSGroupPanel con;
        private MSSGridexView GridViewEquipmentUse;
        private MSSHeaderGrid HeaderGridKinShip;
        private MSSPanel mssPanel1;
        private System.Windows.Forms.BindingSource tBLKinShipBindingSource;
    }
}
