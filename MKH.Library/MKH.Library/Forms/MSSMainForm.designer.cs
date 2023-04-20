namespace MKH.Library.Forms
{
    partial class MSSMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MSSMainForm));
            this.bar_MainView = new DevComponents.DotNetBar.Bar();
            this.label_main = new MKH.Library.Control.MSSLabel(this.components);
            this.timerMain = new System.Windows.Forms.Timer(this.components);
            this.styleManagerMain = new DevComponents.DotNetBar.StyleManager(this.components);
            this.TabControlMain = new MKH.Library.Control.MSSTabControl(this.components);
            this.tabControlPanelStart = new DevComponents.DotNetBar.TabControlPanel();
            this.tabItemStart = new DevComponents.DotNetBar.TabItem(this.components);
            this.RibbonControlMain = new MKH.Library.Control.MSSRibbonControl(this.components);
            this.ribbonPanelFile = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBarFile = new DevComponents.DotNetBar.RibbonBar();
            this.ribbonPanelSystem = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBarSystem = new DevComponents.DotNetBar.RibbonBar();
            this.ribbonPanelSetting = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBarSetting = new DevComponents.DotNetBar.RibbonBar();
            this.ribbonPanelTools = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBarTools = new DevComponents.DotNetBar.RibbonBar();
            this.ribbonPanelReport = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBarReport = new DevComponents.DotNetBar.RibbonBar();
            this.ribbonPanelBase = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBarBase = new DevComponents.DotNetBar.RibbonBar();
            this.ribbonTabItemFile = new DevComponents.DotNetBar.RibbonTabItem();
            this.ribbonTabItemBase = new DevComponents.DotNetBar.RibbonTabItem();
            this.ribbonTabItemReport = new DevComponents.DotNetBar.RibbonTabItem();
            this.ribbonTabItemTools = new DevComponents.DotNetBar.RibbonTabItem();
            this.ribbonTabItemSetting = new DevComponents.DotNetBar.RibbonTabItem();
            this.ribbonTabItemSystem = new DevComponents.DotNetBar.RibbonTabItem();
            this.buttonItemHelp = new DevComponents.DotNetBar.ButtonItem();
            this.qatCustomizeItem1 = new DevComponents.DotNetBar.QatCustomizeItem();
            ((System.ComponentModel.ISupportInitialize)(this.bar_MainView)).BeginInit();
            this.bar_MainView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabControlMain)).BeginInit();
            this.TabControlMain.SuspendLayout();
            this.RibbonControlMain.SuspendLayout();
            this.ribbonPanelFile.SuspendLayout();
            this.ribbonPanelSystem.SuspendLayout();
            this.ribbonPanelSetting.SuspendLayout();
            this.ribbonPanelTools.SuspendLayout();
            this.ribbonPanelReport.SuspendLayout();
            this.ribbonPanelBase.SuspendLayout();
            this.SuspendLayout();
            // 
            // bar_MainView
            // 
            this.bar_MainView.AccessibleDescription = "bar1 (bar1)";
            this.bar_MainView.AccessibleName = "bar1";
            this.bar_MainView.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
            this.bar_MainView.Controls.Add(this.label_main);
            this.bar_MainView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bar_MainView.Font = new System.Drawing.Font("Tahoma", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bar_MainView.Location = new System.Drawing.Point(0, 537);
            this.bar_MainView.Name = "bar_MainView";
            this.bar_MainView.Size = new System.Drawing.Size(681, 25);
            this.bar_MainView.Stretch = true;
            this.bar_MainView.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.bar_MainView.TabIndex = 4;
            this.bar_MainView.TabStop = false;
            // 
            // label_main
            // 
            this.label_main.AutoSize = true;
            this.label_main.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.label_main.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.label_main.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_main.ForeColor = System.Drawing.Color.DarkGreen;
            this.label_main.Location = new System.Drawing.Point(354, 4);
            this.label_main.Name = "label_main";
            this.label_main.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label_main.Size = new System.Drawing.Size(22, 21);
            this.label_main.TabIndex = 0;
            this.label_main.Tag = "0";
            this.label_main.Text = "Ali";
            this.label_main.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // timerMain
            // 
            this.timerMain.Enabled = true;
            this.timerMain.Interval = 1000;
            this.timerMain.Tick += new System.EventHandler(this.timerMain_Tick);
            // 
            // styleManagerMain
            // 
            this.styleManagerMain.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Blue;
            this.styleManagerMain.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(222)))), ((int)(((byte)(192))))), System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(67)))), ((int)(((byte)(32))))));
            // 
            // TabControlMain
            // 
            this.TabControlMain.AutoCloseTabs = true;
            this.TabControlMain.CanReorderTabs = false;
            this.TabControlMain.CausesValidation = false;
            this.TabControlMain.CloseButtonOnTabsVisible = true;
            this.TabControlMain.CloseButtonPosition = DevComponents.DotNetBar.eTabCloseButtonPosition.Right;
            this.TabControlMain.Controls.Add(this.tabControlPanelStart);
            this.TabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControlMain.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TabControlMain.ForeColor = System.Drawing.Color.Black;
            this.TabControlMain.Location = new System.Drawing.Point(0, 100);
            this.TabControlMain.Name = "TabControlMain";
            this.TabControlMain.SelectedTabFont = new System.Drawing.Font("Tahoma", 9.267326F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TabControlMain.SelectedTabIndex = 0;
            this.TabControlMain.Size = new System.Drawing.Size(681, 437);
            this.TabControlMain.Style = DevComponents.DotNetBar.eTabStripStyle.Office2007Document;
            this.TabControlMain.TabIndex = 4;
            this.TabControlMain.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.MultilineNoNavigationBox;
            this.TabControlMain.Tabs.Add(this.tabItemStart);
            // 
            // tabControlPanelStart
            // 
            this.tabControlPanelStart.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.tabControlPanelStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanelStart.Location = new System.Drawing.Point(0, 26);
            this.tabControlPanelStart.Name = "tabControlPanelStart";
            this.tabControlPanelStart.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanelStart.Size = new System.Drawing.Size(681, 411);
            this.tabControlPanelStart.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabControlPanelStart.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanelStart.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(157)))), ((int)(((byte)(189)))));
            this.tabControlPanelStart.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanelStart.Style.GradientAngle = 90;
            this.tabControlPanelStart.TabIndex = 1;
            this.tabControlPanelStart.TabItem = this.tabItemStart;
            // 
            // tabItemStart
            // 
            this.tabItemStart.AttachedControl = this.tabControlPanelStart;
            this.tabItemStart.Name = "tabItemStart";
            this.tabItemStart.Text = "شروع";
            // 
            // RibbonControlMain
            // 
            // 
            // 
            // 
            this.RibbonControlMain.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.RibbonControlMain.Controls.Add(this.ribbonPanelFile);
            this.RibbonControlMain.Controls.Add(this.ribbonPanelBase);
            this.RibbonControlMain.Controls.Add(this.ribbonPanelSystem);
            this.RibbonControlMain.Controls.Add(this.ribbonPanelSetting);
            this.RibbonControlMain.Controls.Add(this.ribbonPanelTools);
            this.RibbonControlMain.Controls.Add(this.ribbonPanelReport);
            this.RibbonControlMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.RibbonControlMain.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.RibbonControlMain.ForeColor = System.Drawing.Color.Black;
            this.RibbonControlMain.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ribbonTabItemFile,
            this.ribbonTabItemBase,
            this.ribbonTabItemReport,
            this.ribbonTabItemTools,
            this.ribbonTabItemSetting,
            this.ribbonTabItemSystem,
            this.buttonItemHelp});
            this.RibbonControlMain.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
            this.RibbonControlMain.Location = new System.Drawing.Point(0, 0);
            this.RibbonControlMain.Name = "RibbonControlMain";
            this.RibbonControlMain.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.RibbonControlMain.QuickToolbarItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.qatCustomizeItem1});
            this.RibbonControlMain.Size = new System.Drawing.Size(681, 100);
            this.RibbonControlMain.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.RibbonControlMain.SystemText.MaximizeRibbonText = "&Maximize the Ribbon";
            this.RibbonControlMain.SystemText.MinimizeRibbonText = "Mi&nimize the Ribbon";
            this.RibbonControlMain.SystemText.QatAddItemText = "&Add to Quick Access Toolbar";
            this.RibbonControlMain.SystemText.QatCustomizeMenuLabel = "<b>Customize Quick Access Toolbar</b>";
            this.RibbonControlMain.SystemText.QatCustomizeText = "&Customize Quick Access Toolbar...";
            this.RibbonControlMain.SystemText.QatDialogAddButton = "&Add >>";
            this.RibbonControlMain.SystemText.QatDialogCancelButton = "Cancel";
            this.RibbonControlMain.SystemText.QatDialogCaption = "Customize Quick Access Toolbar";
            this.RibbonControlMain.SystemText.QatDialogCategoriesLabel = "&Choose commands from:";
            this.RibbonControlMain.SystemText.QatDialogOkButton = "OK";
            this.RibbonControlMain.SystemText.QatDialogPlacementCheckbox = "&Place Quick Access Toolbar below the Ribbon";
            this.RibbonControlMain.SystemText.QatDialogRemoveButton = "&Remove";
            this.RibbonControlMain.SystemText.QatPlaceAboveRibbonText = "&Place Quick Access Toolbar above the Ribbon";
            this.RibbonControlMain.SystemText.QatPlaceBelowRibbonText = "&Place Quick Access Toolbar below the Ribbon";
            this.RibbonControlMain.SystemText.QatRemoveItemText = "&Remove from Quick Access Toolbar";
            this.RibbonControlMain.TabGroupHeight = 5;
            this.RibbonControlMain.TabGroupsVisible = true;
            this.RibbonControlMain.TabIndex = 5;
            this.RibbonControlMain.Text = "RibbonControlMain";
            // 
            // ribbonPanelFile
            // 
            this.ribbonPanelFile.AutoScroll = true;
            this.ribbonPanelFile.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanelFile.Controls.Add(this.ribbonBarFile);
            this.ribbonPanelFile.DefaultLayout = true;
            this.ribbonPanelFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanelFile.Location = new System.Drawing.Point(0, 51);
            this.ribbonPanelFile.Name = "ribbonPanelFile";
            this.ribbonPanelFile.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanelFile.Size = new System.Drawing.Size(681, 47);
            // 
            // 
            // 
            this.ribbonPanelFile.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanelFile.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanelFile.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanelFile.TabIndex = 1;
            // 
            // ribbonBarFile
            // 
            this.ribbonBarFile.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBarFile.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBarFile.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBarFile.ContainerControlProcessDialogKey = true;
            this.ribbonBarFile.Dock = System.Windows.Forms.DockStyle.Right;
            this.ribbonBarFile.Location = new System.Drawing.Point(452, 0);
            this.ribbonBarFile.Name = "ribbonBarFile";
            this.ribbonBarFile.Size = new System.Drawing.Size(226, 44);
            this.ribbonBarFile.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBarFile.TabIndex = 1;
            // 
            // 
            // 
            this.ribbonBarFile.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBarFile.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // ribbonPanelSystem
            // 
            this.ribbonPanelSystem.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanelSystem.Controls.Add(this.ribbonBarSystem);
            this.ribbonPanelSystem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanelSystem.Location = new System.Drawing.Point(0, 51);
            this.ribbonPanelSystem.Name = "ribbonPanelSystem";
            this.ribbonPanelSystem.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanelSystem.Size = new System.Drawing.Size(681, 47);
            // 
            // 
            // 
            this.ribbonPanelSystem.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanelSystem.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanelSystem.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanelSystem.TabIndex = 6;
            this.ribbonPanelSystem.Visible = false;
            // 
            // ribbonBarSystem
            // 
            this.ribbonBarSystem.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBarSystem.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBarSystem.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBarSystem.ContainerControlProcessDialogKey = true;
            this.ribbonBarSystem.Dock = System.Windows.Forms.DockStyle.Right;
            this.ribbonBarSystem.Location = new System.Drawing.Point(383, 0);
            this.ribbonBarSystem.Name = "ribbonBarSystem";
            this.ribbonBarSystem.Size = new System.Drawing.Size(295, 44);
            this.ribbonBarSystem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBarSystem.TabIndex = 2;
            // 
            // 
            // 
            this.ribbonBarSystem.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBarSystem.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // ribbonPanelSetting
            // 
            this.ribbonPanelSetting.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanelSetting.Controls.Add(this.ribbonBarSetting);
            this.ribbonPanelSetting.DefaultLayout = true;
            this.ribbonPanelSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanelSetting.Location = new System.Drawing.Point(0, 45);
            this.ribbonPanelSetting.Name = "ribbonPanelSetting";
            this.ribbonPanelSetting.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanelSetting.Size = new System.Drawing.Size(681, 55);
            // 
            // 
            // 
            this.ribbonPanelSetting.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanelSetting.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanelSetting.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanelSetting.TabIndex = 4;
            this.ribbonPanelSetting.Visible = false;
            // 
            // ribbonBarSetting
            // 
            this.ribbonBarSetting.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBarSetting.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBarSetting.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBarSetting.ContainerControlProcessDialogKey = true;
            this.ribbonBarSetting.Dock = System.Windows.Forms.DockStyle.Right;
            this.ribbonBarSetting.Location = new System.Drawing.Point(430, 0);
            this.ribbonBarSetting.Name = "ribbonBarSetting";
            this.ribbonBarSetting.Size = new System.Drawing.Size(248, 52);
            this.ribbonBarSetting.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBarSetting.TabIndex = 1;
            // 
            // 
            // 
            this.ribbonBarSetting.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBarSetting.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // ribbonPanelTools
            // 
            this.ribbonPanelTools.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanelTools.Controls.Add(this.ribbonBarTools);
            this.ribbonPanelTools.DefaultLayout = true;
            this.ribbonPanelTools.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanelTools.Location = new System.Drawing.Point(0, 45);
            this.ribbonPanelTools.Name = "ribbonPanelTools";
            this.ribbonPanelTools.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanelTools.Size = new System.Drawing.Size(681, 55);
            // 
            // 
            // 
            this.ribbonPanelTools.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanelTools.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanelTools.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanelTools.TabIndex = 5;
            this.ribbonPanelTools.Visible = false;
            // 
            // ribbonBarTools
            // 
            this.ribbonBarTools.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBarTools.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBarTools.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBarTools.ContainerControlProcessDialogKey = true;
            this.ribbonBarTools.Dock = System.Windows.Forms.DockStyle.Right;
            this.ribbonBarTools.Location = new System.Drawing.Point(427, 0);
            this.ribbonBarTools.Name = "ribbonBarTools";
            this.ribbonBarTools.Size = new System.Drawing.Size(251, 52);
            this.ribbonBarTools.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBarTools.TabIndex = 1;
            // 
            // 
            // 
            this.ribbonBarTools.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBarTools.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // ribbonPanelReport
            // 
            this.ribbonPanelReport.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanelReport.Controls.Add(this.ribbonBarReport);
            this.ribbonPanelReport.DefaultLayout = true;
            this.ribbonPanelReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanelReport.Location = new System.Drawing.Point(0, 45);
            this.ribbonPanelReport.Name = "ribbonPanelReport";
            this.ribbonPanelReport.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanelReport.Size = new System.Drawing.Size(681, 55);
            // 
            // 
            // 
            this.ribbonPanelReport.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanelReport.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanelReport.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanelReport.TabIndex = 3;
            this.ribbonPanelReport.Visible = false;
            // 
            // ribbonBarReport
            // 
            this.ribbonBarReport.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBarReport.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBarReport.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBarReport.ContainerControlProcessDialogKey = true;
            this.ribbonBarReport.Dock = System.Windows.Forms.DockStyle.Right;
            this.ribbonBarReport.Location = new System.Drawing.Point(472, 0);
            this.ribbonBarReport.Name = "ribbonBarReport";
            this.ribbonBarReport.Size = new System.Drawing.Size(206, 52);
            this.ribbonBarReport.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBarReport.TabIndex = 1;
            // 
            // 
            // 
            this.ribbonBarReport.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBarReport.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // ribbonPanelBase
            // 
            this.ribbonPanelBase.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanelBase.Controls.Add(this.ribbonBarBase);
            this.ribbonPanelBase.DefaultLayout = true;
            this.ribbonPanelBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanelBase.Location = new System.Drawing.Point(0, 51);
            this.ribbonPanelBase.Name = "ribbonPanelBase";
            this.ribbonPanelBase.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanelBase.Size = new System.Drawing.Size(681, 47);
            // 
            // 
            // 
            this.ribbonPanelBase.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanelBase.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanelBase.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanelBase.TabIndex = 2;
            this.ribbonPanelBase.Visible = false;
            // 
            // ribbonBarBase
            // 
            this.ribbonBarBase.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBarBase.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBarBase.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBarBase.ContainerControlProcessDialogKey = true;
            this.ribbonBarBase.Dock = System.Windows.Forms.DockStyle.Right;
            this.ribbonBarBase.Location = new System.Drawing.Point(452, 0);
            this.ribbonBarBase.Name = "ribbonBarBase";
            this.ribbonBarBase.Size = new System.Drawing.Size(226, 44);
            this.ribbonBarBase.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBarBase.TabIndex = 0;
            // 
            // 
            // 
            this.ribbonBarBase.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBarBase.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // ribbonTabItemFile
            // 
            this.ribbonTabItemFile.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.ribbonTabItemFile.Checked = true;
            this.ribbonTabItemFile.Icon = ((System.Drawing.Icon)(resources.GetObject("ribbonTabItemFile.Icon")));
            this.ribbonTabItemFile.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.ribbonTabItemFile.Name = "ribbonTabItemFile";
            this.ribbonTabItemFile.Panel = this.ribbonPanelFile;
            this.ribbonTabItemFile.Text = "پرونده";
            // 
            // ribbonTabItemBase
            // 
            this.ribbonTabItemBase.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.ribbonTabItemBase.Icon = ((System.Drawing.Icon)(resources.GetObject("ribbonTabItemBase.Icon")));
            this.ribbonTabItemBase.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.ribbonTabItemBase.Name = "ribbonTabItemBase";
            this.ribbonTabItemBase.Panel = this.ribbonPanelBase;
            this.ribbonTabItemBase.Text = "اطلاعات پایه";
            // 
            // ribbonTabItemReport
            // 
            this.ribbonTabItemReport.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.ribbonTabItemReport.Image = ((System.Drawing.Image)(resources.GetObject("ribbonTabItemReport.Image")));
            this.ribbonTabItemReport.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.ribbonTabItemReport.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.ribbonTabItemReport.Name = "ribbonTabItemReport";
            this.ribbonTabItemReport.Panel = this.ribbonPanelReport;
            this.ribbonTabItemReport.Text = "گزارشات";
            // 
            // ribbonTabItemTools
            // 
            this.ribbonTabItemTools.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.ribbonTabItemTools.Image = ((System.Drawing.Image)(resources.GetObject("ribbonTabItemTools.Image")));
            this.ribbonTabItemTools.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.ribbonTabItemTools.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.ribbonTabItemTools.Name = "ribbonTabItemTools";
            this.ribbonTabItemTools.Panel = this.ribbonPanelTools;
            this.ribbonTabItemTools.Text = "امکانات";
            // 
            // ribbonTabItemSetting
            // 
            this.ribbonTabItemSetting.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.ribbonTabItemSetting.Image = ((System.Drawing.Image)(resources.GetObject("ribbonTabItemSetting.Image")));
            this.ribbonTabItemSetting.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.ribbonTabItemSetting.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.ribbonTabItemSetting.Name = "ribbonTabItemSetting";
            this.ribbonTabItemSetting.Panel = this.ribbonPanelSetting;
            this.ribbonTabItemSetting.Text = "تنظیمات";
            // 
            // ribbonTabItemSystem
            // 
            this.ribbonTabItemSystem.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.ribbonTabItemSystem.Image = ((System.Drawing.Image)(resources.GetObject("ribbonTabItemSystem.Image")));
            this.ribbonTabItemSystem.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.ribbonTabItemSystem.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.ribbonTabItemSystem.Name = "ribbonTabItemSystem";
            this.ribbonTabItemSystem.Panel = this.ribbonPanelSystem;
            this.ribbonTabItemSystem.Text = "سیستمی";
            // 
            // buttonItemHelp
            // 
            this.buttonItemHelp.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemHelp.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonItemHelp.Image = ((System.Drawing.Image)(resources.GetObject("buttonItemHelp.Image")));
            this.buttonItemHelp.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            this.buttonItemHelp.Name = "buttonItemHelp";
            this.buttonItemHelp.Text = "راهنما";
            // 
            // qatCustomizeItem1
            // 
            this.qatCustomizeItem1.Name = "qatCustomizeItem1";
            // 
            // MSSMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 562);
            this.Controls.Add(this.TabControlMain);
            this.Controls.Add(this.RibbonControlMain);
            this.Controls.Add(this.bar_MainView);
            this.Font = new System.Drawing.Font("Tahoma", 7.841584F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "MSSMainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.bar_MainView)).EndInit();
            this.bar_MainView.ResumeLayout(false);
            this.bar_MainView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabControlMain)).EndInit();
            this.TabControlMain.ResumeLayout(false);
            this.RibbonControlMain.ResumeLayout(false);
            this.RibbonControlMain.PerformLayout();
            this.ribbonPanelFile.ResumeLayout(false);
            this.ribbonPanelSystem.ResumeLayout(false);
            this.ribbonPanelSetting.ResumeLayout(false);
            this.ribbonPanelTools.ResumeLayout(false);
            this.ribbonPanelReport.ResumeLayout(false);
            this.ribbonPanelBase.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Bar bar_MainView;
        private MKH.Library.Control.MSSLabel label_main;
        private System.Windows.Forms.Timer timerMain;
        private DevComponents.DotNetBar.QatCustomizeItem qatCustomizeItem1;
        private DevComponents.DotNetBar.StyleManager styleManagerMain;
        protected Control.MSSRibbonControl RibbonControlMain;
        private DevComponents.DotNetBar.TabItem tabItemStart;
        protected DevComponents.DotNetBar.RibbonTabItem ribbonTabItemFile;
        protected DevComponents.DotNetBar.RibbonTabItem ribbonTabItemBase;
        protected DevComponents.DotNetBar.RibbonPanel ribbonPanelBase;
        protected DevComponents.DotNetBar.RibbonTabItem ribbonTabItemTools;
        protected DevComponents.DotNetBar.RibbonPanel ribbonPanelReport;
        protected DevComponents.DotNetBar.RibbonPanel ribbonPanelSetting;
        protected DevComponents.DotNetBar.RibbonTabItem ribbonTabItemReport;
        protected DevComponents.DotNetBar.RibbonTabItem ribbonTabItemSetting;
        protected DevComponents.DotNetBar.RibbonPanel ribbonPanelTools;
        protected DevComponents.DotNetBar.RibbonBar ribbonBarBase;
        protected DevComponents.DotNetBar.RibbonBar ribbonBarSetting;
        protected DevComponents.DotNetBar.RibbonBar ribbonBarTools;
        protected DevComponents.DotNetBar.RibbonBar ribbonBarReport;
        protected DevComponents.DotNetBar.RibbonBar ribbonBarFile;
        public Control.MSSTabControl TabControlMain;
        protected DevComponents.DotNetBar.ButtonItem buttonItemHelp;
        protected DevComponents.DotNetBar.RibbonPanel ribbonPanelSystem;
        protected DevComponents.DotNetBar.RibbonBar ribbonBarSystem;
        protected DevComponents.DotNetBar.RibbonTabItem ribbonTabItemSystem;
        protected DevComponents.DotNetBar.RibbonPanel ribbonPanelFile;
        protected DevComponents.DotNetBar.TabControlPanel tabControlPanelStart;
    }
}