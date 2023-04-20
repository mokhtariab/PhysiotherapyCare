using MKH.Library.Control;

namespace PhysiotherapyCare.View.BaseForms
{
    partial class Bank_Frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bank_Frm));
            Janus.Windows.GridEX.GridEXLayout GridViewBank_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.con = new MKH.Library.Control.MSSGroupPanel(this.components);
            this.GridViewBank = new MKH.Library.Control.MSSGridexView();
            this.HeaderGridBank = new MKH.Library.Control.MSSHeaderGrid();
            this.mssPanel1 = new MKH.Library.Control.MSSPanel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewBank)).BeginInit();
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
            // GridViewBank
            // 
            this.GridViewBank.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.GridViewBank.AlternatingColors = true;
            this.GridViewBank.AlternatingRowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewBank.BuiltInTextsData = resources.GetString("GridViewBank.BuiltInTextsData");
            this.GridViewBank.CardViewGridlines = Janus.Windows.GridEX.CardViewGridlines.Both;
            this.GridViewBank.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            GridViewBank_DesignTimeLayout.LayoutString = resources.GetString("GridViewBank_DesignTimeLayout.LayoutString");
            this.GridViewBank.DesignTimeLayout = GridViewBank_DesignTimeLayout;
            this.GridViewBank.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewBank.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.GridViewBank.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.GridViewBank.Font = new System.Drawing.Font("Tahoma", 8.150944F);
            this.GridViewBank.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewBank.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
            this.GridViewBank.Location = new System.Drawing.Point(0, 61);
            this.GridViewBank.Name = "GridViewBank";
            this.GridViewBank.RecordNavigator = true;
            this.GridViewBank.RowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewBank.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition;
            this.GridViewBank.RowHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewBank.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.GridViewBank.Size = new System.Drawing.Size(518, 344);
            this.GridViewBank.TabIndex = 30;
            this.GridViewBank.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.GridViewBank.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010;
            this.GridViewBank.DoubleClick += new System.EventHandler(this.headerGridBank_btnEditClick);
            // 
            // HeaderGridBank
            // 
            // 
            // 
            // 
            this.HeaderGridBank.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridBank.BackgroundStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridBank.BackgroundStyle.BorderBottomWidth = 1;
            this.HeaderGridBank.BackgroundStyle.BorderLeftWidth = 1;
            this.HeaderGridBank.BackgroundStyle.BorderRightWidth = 1;
            this.HeaderGridBank.BackgroundStyle.BorderTopWidth = 1;
            this.HeaderGridBank.BackgroundStyle.Class = "ItemPanel";
            this.HeaderGridBank.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.HeaderGridBank.BackgroundStyle.PaddingBottom = 1;
            this.HeaderGridBank.BackgroundStyle.PaddingLeft = 1;
            this.HeaderGridBank.BackgroundStyle.PaddingRight = 1;
            this.HeaderGridBank.BackgroundStyle.PaddingTop = 1;
            this.HeaderGridBank.ButtonDeletePermissionCode = 102;
            this.HeaderGridBank.ButtonDeleteVisible = true;
            this.HeaderGridBank.ButtonEditPermissionCode = 101;
            this.HeaderGridBank.ButtonEditVisible = true;
            this.HeaderGridBank.ButtonExcelExportVisible = false;
            this.HeaderGridBank.ButtonExcelPermissionCode = 0;
            this.HeaderGridBank.ButtonInsertPermissionCode = 100;
            this.HeaderGridBank.ButtonInsertVisible = true;
            this.HeaderGridBank.ButtonPrintExpertPermissionCode = 0;
            this.HeaderGridBank.ButtonPrintExpertVisible = false;
            this.HeaderGridBank.ButtonPrintPermissionCode = 103;
            this.HeaderGridBank.ButtonPrintVisible = true;
            this.HeaderGridBank.ButtonPrintWithDesignPermissionCode = 0;
            this.HeaderGridBank.ButtonPrintWithDesignVisible = false;
            this.HeaderGridBank.ButtonRefreshVisible = true;
            this.HeaderGridBank.ButtonSearchExpertVisible = false;
            this.HeaderGridBank.ButtonSearchVisible = true;
            this.HeaderGridBank.ButtonSelectorVisible = false;
            this.HeaderGridBank.ContainerControlProcessDialogKey = true;
            this.HeaderGridBank.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderGridBank.FitButtonsToContainerWidth = true;
            this.HeaderGridBank.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.HeaderGridBank.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.HeaderGridBank.GridViewSet = this.GridViewBank;
            this.HeaderGridBank.Location = new System.Drawing.Point(0, 0);
            this.HeaderGridBank.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HeaderGridBank.Name = "HeaderGridBank";
            this.HeaderGridBank.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HeaderGridBank.Size = new System.Drawing.Size(518, 61);
            this.HeaderGridBank.TabIndex = 31;
            this.HeaderGridBank.Text = "mssHeaderGrid1";
            this.HeaderGridBank.ThemeAware = true;
            this.HeaderGridBank.buttonItemInsertClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemInsertClickEventHandler(this.headerGridBank_btnInsertClick);
            this.HeaderGridBank.buttonItemEditClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemEditClickEventHandler(this.headerGridBank_btnEditClick);
            this.HeaderGridBank.buttonItemDeleteClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemDeleteClickEventHandler(this.headerGridBank_btnDeleteClick);
            this.HeaderGridBank.buttonItemRefreshClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemRefreshClickEventHandler(this.headerGridBank_btnRefreshClick);
            // 
            // mssPanel1
            // 
            this.mssPanel1.Location = new System.Drawing.Point(0, 0);
            this.mssPanel1.Name = "mssPanel1";
            this.mssPanel1.Size = new System.Drawing.Size(200, 100);
            this.mssPanel1.TabIndex = 0;
            // 
            // Bank_Frm
            // 
            this.ClientSize = new System.Drawing.Size(518, 431);
            this.Controls.Add(this.GridViewBank);
            this.Controls.Add(this.HeaderGridBank);
            this.Controls.Add(this.con);
            this.Name = "Bank_Frm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "بانک";
            this.Load += new System.EventHandler(this.Bank_Frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewBank)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MSSGroupPanel con;
        private MSSGridexView GridViewBank;
        private MSSHeaderGrid HeaderGridBank;
        private MSSPanel mssPanel1;
    }
}
