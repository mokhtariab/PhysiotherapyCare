using MKH.Library.Control;

namespace PhysiotherapyCare.View.BaseForms
{
    partial class LocationPart_Frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocationPart_Frm));
            Janus.Windows.GridEX.GridEXLayout GridViewLocationPart_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.con = new MKH.Library.Control.MSSGroupPanel(this.components);
            this.GridViewLocationPart = new MKH.Library.Control.MSSGridexView();
            this.HeaderGridLocationPart = new MKH.Library.Control.MSSHeaderGrid();
            this.mssPanel1 = new MKH.Library.Control.MSSPanel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewLocationPart)).BeginInit();
            this.SuspendLayout();
            // 
            // con
            // 
            this.con.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.con.Font = new System.Drawing.Font("Tahoma", 8F);
            this.con.Location = new System.Drawing.Point(0, 405);
            this.con.Name = "con";
            this.con.Size = new System.Drawing.Size(452, 26);
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
            // GridViewLocationPart
            // 
            this.GridViewLocationPart.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.GridViewLocationPart.AlternatingColors = true;
            this.GridViewLocationPart.AlternatingRowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewLocationPart.BuiltInTextsData = resources.GetString("GridViewLocationPart.BuiltInTextsData");
            this.GridViewLocationPart.CardViewGridlines = Janus.Windows.GridEX.CardViewGridlines.Both;
            this.GridViewLocationPart.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            GridViewLocationPart_DesignTimeLayout.LayoutString = resources.GetString("GridViewLocationPart_DesignTimeLayout.LayoutString");
            this.GridViewLocationPart.DesignTimeLayout = GridViewLocationPart_DesignTimeLayout;
            this.GridViewLocationPart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewLocationPart.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.GridViewLocationPart.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.GridViewLocationPart.Font = new System.Drawing.Font("Tahoma", 8.150944F);
            this.GridViewLocationPart.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewLocationPart.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
            this.GridViewLocationPart.Location = new System.Drawing.Point(0, 61);
            this.GridViewLocationPart.Name = "GridViewLocationPart";
            this.GridViewLocationPart.RecordNavigator = true;
            this.GridViewLocationPart.RowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewLocationPart.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition;
            this.GridViewLocationPart.RowHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewLocationPart.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.GridViewLocationPart.Size = new System.Drawing.Size(452, 344);
            this.GridViewLocationPart.TabIndex = 30;
            this.GridViewLocationPart.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.GridViewLocationPart.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010;
            this.GridViewLocationPart.DoubleClick += new System.EventHandler(this.headerGridLocationPart_btnEditClick);
            // 
            // HeaderGridLocationPart
            // 
            // 
            // 
            // 
            this.HeaderGridLocationPart.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridLocationPart.BackgroundStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridLocationPart.BackgroundStyle.BorderBottomWidth = 1;
            this.HeaderGridLocationPart.BackgroundStyle.BorderLeftWidth = 1;
            this.HeaderGridLocationPart.BackgroundStyle.BorderRightWidth = 1;
            this.HeaderGridLocationPart.BackgroundStyle.BorderTopWidth = 1;
            this.HeaderGridLocationPart.BackgroundStyle.Class = "ItemPanel";
            this.HeaderGridLocationPart.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.HeaderGridLocationPart.BackgroundStyle.PaddingBottom = 1;
            this.HeaderGridLocationPart.BackgroundStyle.PaddingLeft = 1;
            this.HeaderGridLocationPart.BackgroundStyle.PaddingRight = 1;
            this.HeaderGridLocationPart.BackgroundStyle.PaddingTop = 1;
            this.HeaderGridLocationPart.ButtonDeletePermissionCode = 106;
            this.HeaderGridLocationPart.ButtonDeleteVisible = true;
            this.HeaderGridLocationPart.ButtonEditPermissionCode = 105;
            this.HeaderGridLocationPart.ButtonEditVisible = true;
            this.HeaderGridLocationPart.ButtonExcelExportVisible = false;
            this.HeaderGridLocationPart.ButtonExcelPermissionCode = 0;
            this.HeaderGridLocationPart.ButtonInsertPermissionCode = 104;
            this.HeaderGridLocationPart.ButtonInsertVisible = true;
            this.HeaderGridLocationPart.ButtonPrintExpertPermissionCode = 0;
            this.HeaderGridLocationPart.ButtonPrintExpertVisible = false;
            this.HeaderGridLocationPart.ButtonPrintPermissionCode = 107;
            this.HeaderGridLocationPart.ButtonPrintVisible = true;
            this.HeaderGridLocationPart.ButtonPrintWithDesignPermissionCode = 0;
            this.HeaderGridLocationPart.ButtonPrintWithDesignVisible = false;
            this.HeaderGridLocationPart.ButtonRefreshVisible = true;
            this.HeaderGridLocationPart.ButtonSearchExpertVisible = false;
            this.HeaderGridLocationPart.ButtonSearchVisible = true;
            this.HeaderGridLocationPart.ButtonSelectorVisible = false;
            this.HeaderGridLocationPart.ContainerControlProcessDialogKey = true;
            this.HeaderGridLocationPart.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderGridLocationPart.FitButtonsToContainerWidth = true;
            this.HeaderGridLocationPart.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.HeaderGridLocationPart.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.HeaderGridLocationPart.GridViewSet = this.GridViewLocationPart;
            this.HeaderGridLocationPart.Location = new System.Drawing.Point(0, 0);
            this.HeaderGridLocationPart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HeaderGridLocationPart.Name = "HeaderGridLocationPart";
            this.HeaderGridLocationPart.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HeaderGridLocationPart.Size = new System.Drawing.Size(452, 61);
            this.HeaderGridLocationPart.TabIndex = 31;
            this.HeaderGridLocationPart.Text = "mssHeaderGrid1";
            this.HeaderGridLocationPart.ThemeAware = true;
            this.HeaderGridLocationPart.buttonItemInsertClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemInsertClickEventHandler(this.headerGridLocationPart_btnInsertClick);
            this.HeaderGridLocationPart.buttonItemEditClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemEditClickEventHandler(this.headerGridLocationPart_btnEditClick);
            this.HeaderGridLocationPart.buttonItemDeleteClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemDeleteClickEventHandler(this.headerGridLocationPart_btnDeleteClick);
            this.HeaderGridLocationPart.buttonItemRefreshClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemRefreshClickEventHandler(this.headerGridLocationPart_btnRefreshClick);
            // 
            // mssPanel1
            // 
            this.mssPanel1.Location = new System.Drawing.Point(0, 0);
            this.mssPanel1.Name = "mssPanel1";
            this.mssPanel1.Size = new System.Drawing.Size(200, 100);
            this.mssPanel1.TabIndex = 0;
            // 
            // LocationPart_Frm
            // 
            this.ClientSize = new System.Drawing.Size(452, 431);
            this.Controls.Add(this.GridViewLocationPart);
            this.Controls.Add(this.HeaderGridLocationPart);
            this.Controls.Add(this.con);
            this.Name = "LocationPart_Frm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "منطقه تحت پوشش";
            this.Load += new System.EventHandler(this.LocationPart_Frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewLocationPart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MSSGroupPanel con;
        private MSSGridexView GridViewLocationPart;
        private MSSHeaderGrid HeaderGridLocationPart;
        private MSSPanel mssPanel1;
    }
}
