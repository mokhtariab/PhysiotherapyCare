using MKH.Library.Control;

namespace PhysiotherapyCare.View.MainForms.VisitHealthCare
{
    partial class ServiceTypeDsc_Frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceTypeDsc_Frm));
            Janus.Windows.GridEX.GridEXLayout GridViewServiceTypeDsc_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.con = new MKH.Library.Control.MSSGroupPanel(this.components);
            this.GridViewServiceTypeDsc = new MKH.Library.Control.MSSGridexView();
            this.HeaderGridServiceTypeDsc = new MKH.Library.Control.MSSHeaderGrid();
            this.mssPanel1 = new MKH.Library.Control.MSSPanel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewServiceTypeDsc)).BeginInit();
            this.SuspendLayout();
            // 
            // con
            // 
            this.con.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.con.Font = new System.Drawing.Font("Tahoma", 8F);
            this.con.Location = new System.Drawing.Point(0, 405);
            this.con.Name = "con";
            this.con.Size = new System.Drawing.Size(542, 26);
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
            // GridViewServiceTypeDsc
            // 
            this.GridViewServiceTypeDsc.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.GridViewServiceTypeDsc.AlternatingColors = true;
            this.GridViewServiceTypeDsc.AlternatingRowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewServiceTypeDsc.BuiltInTextsData = resources.GetString("GridViewServiceTypeDsc.BuiltInTextsData");
            this.GridViewServiceTypeDsc.CardViewGridlines = Janus.Windows.GridEX.CardViewGridlines.Both;
            this.GridViewServiceTypeDsc.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            GridViewServiceTypeDsc_DesignTimeLayout.LayoutString = resources.GetString("GridViewServiceTypeDsc_DesignTimeLayout.LayoutString");
            this.GridViewServiceTypeDsc.DesignTimeLayout = GridViewServiceTypeDsc_DesignTimeLayout;
            this.GridViewServiceTypeDsc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewServiceTypeDsc.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.GridViewServiceTypeDsc.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.GridViewServiceTypeDsc.Font = new System.Drawing.Font("Tahoma", 8.150944F);
            this.GridViewServiceTypeDsc.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewServiceTypeDsc.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
            this.GridViewServiceTypeDsc.Location = new System.Drawing.Point(0, 61);
            this.GridViewServiceTypeDsc.Name = "GridViewServiceTypeDsc";
            this.GridViewServiceTypeDsc.RecordNavigator = true;
            this.GridViewServiceTypeDsc.RowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewServiceTypeDsc.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition;
            this.GridViewServiceTypeDsc.RowHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewServiceTypeDsc.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.GridViewServiceTypeDsc.Size = new System.Drawing.Size(542, 344);
            this.GridViewServiceTypeDsc.TabIndex = 30;
            this.GridViewServiceTypeDsc.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.GridViewServiceTypeDsc.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010;
            this.GridViewServiceTypeDsc.DoubleClick += new System.EventHandler(this.headerGridServiceTypeDsc_btnEditClick);
            // 
            // HeaderGridServiceTypeDsc
            // 
            // 
            // 
            // 
            this.HeaderGridServiceTypeDsc.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridServiceTypeDsc.BackgroundStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridServiceTypeDsc.BackgroundStyle.BorderBottomWidth = 1;
            this.HeaderGridServiceTypeDsc.BackgroundStyle.BorderLeftWidth = 1;
            this.HeaderGridServiceTypeDsc.BackgroundStyle.BorderRightWidth = 1;
            this.HeaderGridServiceTypeDsc.BackgroundStyle.BorderTopWidth = 1;
            this.HeaderGridServiceTypeDsc.BackgroundStyle.Class = "ItemPanel";
            this.HeaderGridServiceTypeDsc.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.HeaderGridServiceTypeDsc.BackgroundStyle.PaddingBottom = 1;
            this.HeaderGridServiceTypeDsc.BackgroundStyle.PaddingLeft = 1;
            this.HeaderGridServiceTypeDsc.BackgroundStyle.PaddingRight = 1;
            this.HeaderGridServiceTypeDsc.BackgroundStyle.PaddingTop = 1;
            this.HeaderGridServiceTypeDsc.ButtonDeletePermissionCode = 156;
            this.HeaderGridServiceTypeDsc.ButtonDeleteVisible = true;
            this.HeaderGridServiceTypeDsc.ButtonEditPermissionCode = 155;
            this.HeaderGridServiceTypeDsc.ButtonEditVisible = true;
            this.HeaderGridServiceTypeDsc.ButtonExcelExportVisible = false;
            this.HeaderGridServiceTypeDsc.ButtonExcelPermissionCode = 0;
            this.HeaderGridServiceTypeDsc.ButtonInsertPermissionCode = 154;
            this.HeaderGridServiceTypeDsc.ButtonInsertVisible = true;
            this.HeaderGridServiceTypeDsc.ButtonPrintExpertPermissionCode = 0;
            this.HeaderGridServiceTypeDsc.ButtonPrintExpertVisible = false;
            this.HeaderGridServiceTypeDsc.ButtonPrintPermissionCode = 157;
            this.HeaderGridServiceTypeDsc.ButtonPrintVisible = true;
            this.HeaderGridServiceTypeDsc.ButtonPrintWithDesignPermissionCode = 0;
            this.HeaderGridServiceTypeDsc.ButtonPrintWithDesignVisible = true;
            this.HeaderGridServiceTypeDsc.ButtonRefreshVisible = true;
            this.HeaderGridServiceTypeDsc.ButtonSearchExpertVisible = false;
            this.HeaderGridServiceTypeDsc.ButtonSearchVisible = true;
            this.HeaderGridServiceTypeDsc.ButtonSelectorVisible = false;
            this.HeaderGridServiceTypeDsc.ContainerControlProcessDialogKey = true;
            this.HeaderGridServiceTypeDsc.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderGridServiceTypeDsc.FitButtonsToContainerWidth = true;
            this.HeaderGridServiceTypeDsc.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.HeaderGridServiceTypeDsc.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.HeaderGridServiceTypeDsc.GridViewSet = this.GridViewServiceTypeDsc;
            this.HeaderGridServiceTypeDsc.Location = new System.Drawing.Point(0, 0);
            this.HeaderGridServiceTypeDsc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HeaderGridServiceTypeDsc.Name = "HeaderGridServiceTypeDsc";
            this.HeaderGridServiceTypeDsc.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HeaderGridServiceTypeDsc.Size = new System.Drawing.Size(542, 61);
            this.HeaderGridServiceTypeDsc.TabIndex = 31;
            this.HeaderGridServiceTypeDsc.Text = "mssHeaderGrid1";
            this.HeaderGridServiceTypeDsc.ThemeAware = true;
            this.HeaderGridServiceTypeDsc.buttonItemInsertClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemInsertClickEventHandler(this.headerGridServiceTypeDsc_btnInsertClick);
            this.HeaderGridServiceTypeDsc.buttonItemEditClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemEditClickEventHandler(this.headerGridServiceTypeDsc_btnEditClick);
            this.HeaderGridServiceTypeDsc.buttonItemDeleteClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemDeleteClickEventHandler(this.headerGridServiceTypeDsc_btnDeleteClick);
            this.HeaderGridServiceTypeDsc.buttonItemRefreshClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemRefreshClickEventHandler(this.headerGridServiceTypeDsc_btnRefreshClick);
            // 
            // mssPanel1
            // 
            this.mssPanel1.Location = new System.Drawing.Point(0, 0);
            this.mssPanel1.Name = "mssPanel1";
            this.mssPanel1.Size = new System.Drawing.Size(200, 100);
            this.mssPanel1.TabIndex = 0;
            // 
            // ServiceTypeDsc_Frm
            // 
            this.ClientSize = new System.Drawing.Size(542, 431);
            this.Controls.Add(this.GridViewServiceTypeDsc);
            this.Controls.Add(this.HeaderGridServiceTypeDsc);
            this.Controls.Add(this.con);
            this.Name = "ServiceTypeDsc_Frm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "شرح خدمت";
            this.Load += new System.EventHandler(this.ServiceTypeDsc_Frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewServiceTypeDsc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MSSGroupPanel con;
        private MSSGridexView GridViewServiceTypeDsc;
        private MSSHeaderGrid HeaderGridServiceTypeDsc;
        private MSSPanel mssPanel1;
    }
}
