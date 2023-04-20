namespace MKH.Contacts.View.UserControls
{
    partial class PersonGroupList_UC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonGroupList_UC));
            Janus.Windows.GridEX.GridEXLayout GridViewGroupTelMob_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.tabControlPanelPMContacts = new DevComponents.DotNetBar.TabControlPanel();
            this.mssPanel1 = new MKH.Library.Control.MSSPanel(this.components);
            this.GridViewGroupTelMob = new MKH.Library.Control.MSSGridexView();
            this.vWGroupTelMobBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HeaderGridGroupTelMob = new MKH.Library.Control.MSSHeaderGrid();
            this.mssExpandableSplitter1 = new MKH.Library.Control.MSSExpandableSplitter(this.components);
            this.TabControlMain = new MKH.Library.Control.MSSTabControl(this.components);
            this.tabControlPanelPersonTelMob = new DevComponents.DotNetBar.TabControlPanel();
            this.personTelMob_UC1 = new MKH.Contacts.View.UserControls.PersonTelMob_UC();
            this.tabItemPersonTelMob = new DevComponents.DotNetBar.TabItem(this.components);
            this.mssPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewGroupTelMob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWGroupTelMobBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabControlMain)).BeginInit();
            this.TabControlMain.SuspendLayout();
            this.tabControlPanelPersonTelMob.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlPanelPMContacts
            // 
            this.tabControlPanelPMContacts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanelPMContacts.Location = new System.Drawing.Point(0, 28);
            this.tabControlPanelPMContacts.Name = "tabControlPanelPMContacts";
            this.tabControlPanelPMContacts.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanelPMContacts.Size = new System.Drawing.Size(813, 326);
            this.tabControlPanelPMContacts.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(254)))));
            this.tabControlPanelPMContacts.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(188)))), ((int)(((byte)(227)))));
            this.tabControlPanelPMContacts.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanelPMContacts.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.tabControlPanelPMContacts.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanelPMContacts.Style.GradientAngle = 90;
            this.tabControlPanelPMContacts.TabIndex = 2;
            this.tabControlPanelPMContacts.Tag = "222";
            // 
            // mssPanel1
            // 
            this.mssPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.mssPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.mssPanel1.Controls.Add(this.GridViewGroupTelMob);
            this.mssPanel1.Controls.Add(this.HeaderGridGroupTelMob);
            this.mssPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mssPanel1.Location = new System.Drawing.Point(0, 0);
            this.mssPanel1.Name = "mssPanel1";
            this.mssPanel1.Size = new System.Drawing.Size(720, 196);
            this.mssPanel1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.mssPanel1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.mssPanel1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.mssPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.mssPanel1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.mssPanel1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.mssPanel1.Style.GradientAngle = 90;
            this.mssPanel1.TabIndex = 7;
            this.mssPanel1.Text = "mssPanel1";
            // 
            // GridViewGroupTelMob
            // 
            this.GridViewGroupTelMob.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.GridViewGroupTelMob.AlternatingColors = true;
            this.GridViewGroupTelMob.AlternatingRowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewGroupTelMob.BuiltInTextsData = resources.GetString("GridViewGroupTelMob.BuiltInTextsData");
            this.GridViewGroupTelMob.CardViewGridlines = Janus.Windows.GridEX.CardViewGridlines.Both;
            this.GridViewGroupTelMob.DataSource = this.vWGroupTelMobBindingSource;
            this.GridViewGroupTelMob.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            GridViewGroupTelMob_DesignTimeLayout.LayoutString = resources.GetString("GridViewGroupTelMob_DesignTimeLayout.LayoutString");
            this.GridViewGroupTelMob.DesignTimeLayout = GridViewGroupTelMob_DesignTimeLayout;
            this.GridViewGroupTelMob.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewGroupTelMob.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.GridViewGroupTelMob.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.GridViewGroupTelMob.Font = new System.Drawing.Font("Tahoma", 8.150944F);
            this.GridViewGroupTelMob.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewGroupTelMob.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
            this.GridViewGroupTelMob.Location = new System.Drawing.Point(0, 59);
            this.GridViewGroupTelMob.Name = "GridViewGroupTelMob";
            this.GridViewGroupTelMob.RecordNavigator = true;
            this.GridViewGroupTelMob.RowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewGroupTelMob.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition;
            this.GridViewGroupTelMob.RowHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewGroupTelMob.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.GridViewGroupTelMob.Size = new System.Drawing.Size(720, 137);
            this.GridViewGroupTelMob.TabIndex = 9;
            this.GridViewGroupTelMob.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.GridViewGroupTelMob.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010;
            this.GridViewGroupTelMob.SelectionChanged += new System.EventHandler(this.GridViewGroupTelMob_SelectionChanged);
            this.GridViewGroupTelMob.DoubleClick += new System.EventHandler(this.headerGridGroupTelMob_btnEditClick);
            // 
            // vWGroupTelMobBindingSource
            // 
            this.vWGroupTelMobBindingSource.DataSource = typeof(MKH.Contacts.Model.GroupTelMob.VW_GroupTelMob);
            // 
            // HeaderGridGroupTelMob
            // 
            // 
            // 
            // 
            this.HeaderGridGroupTelMob.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridGroupTelMob.BackgroundStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridGroupTelMob.BackgroundStyle.BorderBottomWidth = 1;
            this.HeaderGridGroupTelMob.BackgroundStyle.BorderLeftWidth = 1;
            this.HeaderGridGroupTelMob.BackgroundStyle.BorderRightWidth = 1;
            this.HeaderGridGroupTelMob.BackgroundStyle.BorderTopWidth = 1;
            this.HeaderGridGroupTelMob.BackgroundStyle.Class = "ItemPanel";
            this.HeaderGridGroupTelMob.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.HeaderGridGroupTelMob.BackgroundStyle.PaddingBottom = 1;
            this.HeaderGridGroupTelMob.BackgroundStyle.PaddingLeft = 1;
            this.HeaderGridGroupTelMob.BackgroundStyle.PaddingRight = 1;
            this.HeaderGridGroupTelMob.BackgroundStyle.PaddingTop = 1;
            this.HeaderGridGroupTelMob.ButtonDeletePermissionCode = 218;
            this.HeaderGridGroupTelMob.ButtonDeleteVisible = true;
            this.HeaderGridGroupTelMob.ButtonEditPermissionCode = 217;
            this.HeaderGridGroupTelMob.ButtonEditVisible = true;
            this.HeaderGridGroupTelMob.ButtonExcelExportVisible = false;
            this.HeaderGridGroupTelMob.ButtonExcelPermissionCode = 221;
            this.HeaderGridGroupTelMob.ButtonInsertPermissionCode = 216;
            this.HeaderGridGroupTelMob.ButtonInsertVisible = true;
            this.HeaderGridGroupTelMob.ButtonPrintExpertPermissionCode = 220;
            this.HeaderGridGroupTelMob.ButtonPrintExpertVisible = false;
            this.HeaderGridGroupTelMob.ButtonPrintPermissionCode = 219;
            this.HeaderGridGroupTelMob.ButtonPrintVisible = true;
            this.HeaderGridGroupTelMob.ButtonRefreshVisible = true;
            this.HeaderGridGroupTelMob.ButtonSearchExpertVisible = false;
            this.HeaderGridGroupTelMob.ButtonSearchVisible = true;
            this.HeaderGridGroupTelMob.ButtonSelectorVisible = false;
            this.HeaderGridGroupTelMob.ContainerControlProcessDialogKey = true;
            this.HeaderGridGroupTelMob.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderGridGroupTelMob.FitButtonsToContainerWidth = true;
            this.HeaderGridGroupTelMob.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.HeaderGridGroupTelMob.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.HeaderGridGroupTelMob.GridViewSet = this.GridViewGroupTelMob;
            this.HeaderGridGroupTelMob.Location = new System.Drawing.Point(0, 0);
            this.HeaderGridGroupTelMob.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HeaderGridGroupTelMob.Name = "HeaderGridGroupTelMob";
            this.HeaderGridGroupTelMob.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HeaderGridGroupTelMob.Size = new System.Drawing.Size(720, 59);
            this.HeaderGridGroupTelMob.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.HeaderGridGroupTelMob.TabIndex = 10;
            this.HeaderGridGroupTelMob.ThemeAware = true;
            this.HeaderGridGroupTelMob.buttonItemInsertClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemInsertClickEventHandler(this.headerGridGroupTelMob_btnInsertClick);
            this.HeaderGridGroupTelMob.buttonItemEditClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemEditClickEventHandler(this.headerGridGroupTelMob_btnEditClick);
            this.HeaderGridGroupTelMob.buttonItemDeleteClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemDeleteClickEventHandler(this.headerGridGroupTelMob_btnDeleteClick);
            this.HeaderGridGroupTelMob.buttonItemRefreshClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemRefreshClickEventHandler(this.headerGridGroupTelMob_btnRefreshClick);
            // 
            // mssExpandableSplitter1
            // 
            this.mssExpandableSplitter1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(108)))), ((int)(((byte)(122)))));
            this.mssExpandableSplitter1.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.mssExpandableSplitter1.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.mssExpandableSplitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mssExpandableSplitter1.ExpandFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(108)))), ((int)(((byte)(122)))));
            this.mssExpandableSplitter1.ExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.mssExpandableSplitter1.ExpandLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(120)))));
            this.mssExpandableSplitter1.ExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.mssExpandableSplitter1.ForeColor = System.Drawing.Color.Black;
            this.mssExpandableSplitter1.GripDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(120)))));
            this.mssExpandableSplitter1.GripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.mssExpandableSplitter1.GripLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(232)))), ((int)(((byte)(246)))));
            this.mssExpandableSplitter1.GripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.mssExpandableSplitter1.HotBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(200)))), ((int)(((byte)(103)))));
            this.mssExpandableSplitter1.HotBackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(226)))), ((int)(((byte)(135)))));
            this.mssExpandableSplitter1.HotBackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground2;
            this.mssExpandableSplitter1.HotBackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground;
            this.mssExpandableSplitter1.HotExpandFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(108)))), ((int)(((byte)(122)))));
            this.mssExpandableSplitter1.HotExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.mssExpandableSplitter1.HotExpandLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(120)))));
            this.mssExpandableSplitter1.HotExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.mssExpandableSplitter1.HotGripDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(108)))), ((int)(((byte)(122)))));
            this.mssExpandableSplitter1.HotGripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.mssExpandableSplitter1.HotGripLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(232)))), ((int)(((byte)(246)))));
            this.mssExpandableSplitter1.HotGripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.mssExpandableSplitter1.Location = new System.Drawing.Point(0, 196);
            this.mssExpandableSplitter1.Name = "mssExpandableSplitter1";
            this.mssExpandableSplitter1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mssExpandableSplitter1.Size = new System.Drawing.Size(720, 10);
            this.mssExpandableSplitter1.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007;
            this.mssExpandableSplitter1.TabIndex = 6;
            this.mssExpandableSplitter1.TabStop = false;
            // 
            // TabControlMain
            // 
            this.TabControlMain.CanReorderTabs = true;
            this.TabControlMain.Controls.Add(this.tabControlPanelPersonTelMob);
            this.TabControlMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TabControlMain.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TabControlMain.ForeColor = System.Drawing.Color.Black;
            this.TabControlMain.Location = new System.Drawing.Point(0, 206);
            this.TabControlMain.Name = "TabControlMain";
            this.TabControlMain.SelectedTabFont = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TabControlMain.SelectedTabIndex = 0;
            this.TabControlMain.Size = new System.Drawing.Size(720, 358);
            this.TabControlMain.Style = DevComponents.DotNetBar.eTabStripStyle.Office2007Document;
            this.TabControlMain.TabIndex = 8;
            this.TabControlMain.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.MultilineNoNavigationBox;
            this.TabControlMain.Tabs.Add(this.tabItemPersonTelMob);
            this.TabControlMain.Text = "mssTabControl1";
            // 
            // tabControlPanelPersonTelMob
            // 
            this.tabControlPanelPersonTelMob.Controls.Add(this.personTelMob_UC1);
            this.tabControlPanelPersonTelMob.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanelPersonTelMob.Location = new System.Drawing.Point(0, 28);
            this.tabControlPanelPersonTelMob.Name = "tabControlPanelPersonTelMob";
            this.tabControlPanelPersonTelMob.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanelPersonTelMob.Size = new System.Drawing.Size(720, 330);
            this.tabControlPanelPersonTelMob.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabControlPanelPersonTelMob.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanelPersonTelMob.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(157)))), ((int)(((byte)(189)))));
            this.tabControlPanelPersonTelMob.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanelPersonTelMob.Style.GradientAngle = 90;
            this.tabControlPanelPersonTelMob.TabIndex = 1;
            this.tabControlPanelPersonTelMob.TabItem = this.tabItemPersonTelMob;
            this.tabControlPanelPersonTelMob.Tag = "223";
            // 
            // personTelMob_UC1
            // 
            this.personTelMob_UC1.AutoScroll = true;
            this.personTelMob_UC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.personTelMob_UC1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.personTelMob_UC1.Location = new System.Drawing.Point(1, 1);
            this.personTelMob_UC1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.personTelMob_UC1.Name = "personTelMob_UC1";
            this.personTelMob_UC1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.personTelMob_UC1.Size = new System.Drawing.Size(718, 328);
            this.personTelMob_UC1.TabIndex = 0;
            // 
            // tabItemPersonTelMob
            // 
            this.tabItemPersonTelMob.AttachedControl = this.tabControlPanelPersonTelMob;
            this.tabItemPersonTelMob.Name = "tabItemPersonTelMob";
            this.tabItemPersonTelMob.Text = "افراد";
            // 
            // PersonGroupList_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mssPanel1);
            this.Controls.Add(this.mssExpandableSplitter1);
            this.Controls.Add(this.TabControlMain);
            this.Font = new System.Drawing.Font("Tahoma", 7.841584F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "PersonGroupList_UC";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(720, 564);
            this.Tag = "دفترچه تلفن";
            this.Load += new System.EventHandler(this.PersonGroupList_UC_Load);
            this.mssPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewGroupTelMob)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWGroupTelMobBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabControlMain)).EndInit();
            this.TabControlMain.ResumeLayout(false);
            this.tabControlPanelPersonTelMob.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MKH.Library.Control.MSSExpandableSplitter mssExpandableSplitter1;
        private MKH.Library.Control.MSSPanel mssPanel1;
        private MKH.Library.Control.MSSGridexView GridViewGroupTelMob;
        private MKH.Library.Control.MSSHeaderGrid HeaderGridGroupTelMob;
        private MKH.Library.Control.MSSTabControl TabControlMain;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanelPersonTelMob;
        private DevComponents.DotNetBar.TabItem tabItemPersonTelMob;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanelPMContacts;
        private System.Windows.Forms.BindingSource vWGroupTelMobBindingSource;
        private PersonTelMob_UC personTelMob_UC1;
    }
}
