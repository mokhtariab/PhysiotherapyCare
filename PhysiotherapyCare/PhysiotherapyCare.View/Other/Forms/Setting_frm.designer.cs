using System.Windows.Forms;
namespace PhysiotherapyCare.Other.Forms
{
    partial class Setting_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setting_frm));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("تنظیمات سیستمی");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("پشتیبانی و بازیابی");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("تنظیمات SMS");
            this.imageList_Setting = new System.Windows.Forms.ImageList(this.components);
            this.treeView_Setting = new MKH.Library.Control.MSSTreeView(this.components);
            this.tabControl_Setting = new DevComponents.DotNetBar.TabControl();
            this.tabControlPanel_SetSystem = new DevComponents.DotNetBar.TabControlPanel();
            this.mssGroupPanel8 = new MKH.Library.Control.MSSGroupPanel(this.components);
            this.mssLabel8 = new MKH.Library.Control.MSSLabel(this.components);
            this.mssLabel16 = new MKH.Library.Control.MSSLabel(this.components);
            this.IntBoxCostReqInsuVisitEven = new MKH.Library.Control.MSSIntBox(this.components);
            this.mssLabel13 = new MKH.Library.Control.MSSLabel(this.components);
            this.mssLabel2 = new MKH.Library.Control.MSSLabel(this.components);
            this.IntBoxCostCompanyVisitPercent = new MKH.Library.Control.MSSIntBox(this.components);
            this.mssLabel3 = new MKH.Library.Control.MSSLabel(this.components);
            this.IntBoxCostReqInsuVisitAdd = new MKH.Library.Control.MSSIntBox(this.components);
            this.mssLabel9 = new MKH.Library.Control.MSSLabel(this.components);
            this.TextBoxFileSavingVisit = new MKH.Library.Control.MSSTextBox(this.components);
            this.mssLabel12 = new MKH.Library.Control.MSSLabel(this.components);
            this.mssGroupPanel6 = new MKH.Library.Control.MSSGroupPanel(this.components);
            this.mssLabel4 = new MKH.Library.Control.MSSLabel(this.components);
            this.IntBoxCostCompanyHealthPercent = new MKH.Library.Control.MSSIntBox(this.components);
            this.mssLabel6 = new MKH.Library.Control.MSSLabel(this.components);
            this.TextBoxFileSavingHealth = new MKH.Library.Control.MSSTextBox(this.components);
            this.mssLabel7 = new MKH.Library.Control.MSSLabel(this.components);
            this.mssGroupPanel3 = new MKH.Library.Control.MSSGroupPanel(this.components);
            this.mssLabel27 = new MKH.Library.Control.MSSLabel(this.components);
            this.IntBoxCareDaysDefault = new MKH.Library.Control.MSSIntBox(this.components);
            this.mssLabel24 = new MKH.Library.Control.MSSLabel(this.components);
            this.mssLabel26 = new MKH.Library.Control.MSSLabel(this.components);
            this.mssLabel23 = new MKH.Library.Control.MSSLabel(this.components);
            this.mssLabel25 = new MKH.Library.Control.MSSLabel(this.components);
            this.mssLabel21 = new MKH.Library.Control.MSSLabel(this.components);
            this.mssLabel22 = new MKH.Library.Control.MSSLabel(this.components);
            this.IntBoxCareShift1 = new MKH.Library.Control.MSSIntBox(this.components);
            this.IntBoxCareShift3 = new MKH.Library.Control.MSSIntBox(this.components);
            this.IntBoxCareShift2 = new MKH.Library.Control.MSSIntBox(this.components);
            this.mssLabel15 = new MKH.Library.Control.MSSLabel(this.components);
            this.mssLabel17 = new MKH.Library.Control.MSSLabel(this.components);
            this.IntBoxCostCompanyCarePercent = new MKH.Library.Control.MSSIntBox(this.components);
            this.TextBoxFileSavingCare = new MKH.Library.Control.MSSTextBox(this.components);
            this.mssLabel18 = new MKH.Library.Control.MSSLabel(this.components);
            this.mssGroupPanel2 = new MKH.Library.Control.MSSGroupPanel(this.components);
            this.mssLabel5 = new MKH.Library.Control.MSSLabel(this.components);
            this.IntBoxCostCompanyPhsiotraphyPercent = new MKH.Library.Control.MSSIntBox(this.components);
            this.mssLabel11 = new MKH.Library.Control.MSSLabel(this.components);
            this.mssLabel10 = new MKH.Library.Control.MSSLabel(this.components);
            this.IntBoxCostReqInsuPhsiotraphy = new MKH.Library.Control.MSSIntBox(this.components);
            this.mssLabel14 = new MKH.Library.Control.MSSLabel(this.components);
            this.TextBoxFileSavingPhysiotherapy = new MKH.Library.Control.MSSTextBox(this.components);
            this.mssLabel1 = new MKH.Library.Control.MSSLabel(this.components);
            this.tabItem_SetSystem = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel_SetBkpRst = new DevComponents.DotNetBar.TabControlPanel();
            this.ButtonClearCash = new MKH.Library.Control.MSSButton(this.components);
            this.mssGroupPanel5 = new MKH.Library.Control.MSSGroupPanel(this.components);
            this.TextBoxFileSavingPatient = new MKH.Library.Control.MSSTextBox(this.components);
            this.mssLabel19 = new MKH.Library.Control.MSSLabel(this.components);
            this.TextBoxBkpAuto = new MKH.Library.Control.MSSTextBox(this.components);
            this.radioButton_BkpAuto = new MKH.Library.Control.MSSCheckBox(this.components);
            this.radioButton_BkpNonAuto = new MKH.Library.Control.MSSCheckBox(this.components);
            this.radioButton_BkpNo = new MKH.Library.Control.MSSCheckBox(this.components);
            this.mssGroupPanel4 = new MKH.Library.Control.MSSGroupPanel(this.components);
            this.button_RstChangePass = new MKH.Library.Control.MSSButton(this.components);
            this.panel4 = new MKH.Library.Control.MSSPanel(this.components);
            this.tabItem_SetBkpRst = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel_SMS = new DevComponents.DotNetBar.TabControlPanel();
            this.mssGroupPanel7 = new MKH.Library.Control.MSSGroupPanel(this.components);
            this.button_SMSSetting = new MKH.Library.Control.MSSButton(this.components);
            this.tabItem_SMS = new DevComponents.DotNetBar.TabItem(this.components);
            this.mssGroupPanel9 = new MKH.Library.Control.MSSGroupPanel(this.components);
            this.mssLabel20 = new MKH.Library.Control.MSSLabel(this.components);
            this.IntBoxCostInsurancePercent = new MKH.Library.Control.MSSIntBox(this.components);
            this.mssLabel28 = new MKH.Library.Control.MSSLabel(this.components);
            this.mssGroupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl_Setting)).BeginInit();
            this.tabControl_Setting.SuspendLayout();
            this.tabControlPanel_SetSystem.SuspendLayout();
            this.mssGroupPanel8.SuspendLayout();
            this.mssGroupPanel6.SuspendLayout();
            this.mssGroupPanel3.SuspendLayout();
            this.mssGroupPanel2.SuspendLayout();
            this.tabControlPanel_SetBkpRst.SuspendLayout();
            this.mssGroupPanel5.SuspendLayout();
            this.mssGroupPanel4.SuspendLayout();
            this.tabControlPanel_SMS.SuspendLayout();
            this.mssGroupPanel7.SuspendLayout();
            this.mssGroupPanel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonBarNewBar
            // 
            // 
            // 
            // 
            this.ribbonBarNewBar.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBarNewBar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBarNewBar.Location = new System.Drawing.Point(0, 570);
            this.ribbonBarNewBar.Size = new System.Drawing.Size(823, 55);
            // 
            // 
            // 
            this.ribbonBarNewBar.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBarNewBar.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // mssGroupPanel1
            // 
            this.mssGroupPanel1.Controls.Add(this.tabControl_Setting);
            this.mssGroupPanel1.Controls.Add(this.treeView_Setting);
            this.mssGroupPanel1.Size = new System.Drawing.Size(823, 536);
            // 
            // 
            // 
            this.mssGroupPanel1.Style.BackColor = System.Drawing.SystemColors.Control;
            this.mssGroupPanel1.Style.BackColor2 = System.Drawing.SystemColors.Control;
            this.mssGroupPanel1.Style.BackColorGradientAngle = 90;
            this.mssGroupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.mssGroupPanel1.Style.BorderBottomWidth = 1;
            this.mssGroupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.mssGroupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.mssGroupPanel1.Style.BorderLeftWidth = 1;
            this.mssGroupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.mssGroupPanel1.Style.BorderRightWidth = 1;
            this.mssGroupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.mssGroupPanel1.Style.BorderTopWidth = 1;
            this.mssGroupPanel1.Style.CornerDiameter = 4;
            this.mssGroupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.mssGroupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.mssGroupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.mssGroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.mssGroupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.mssGroupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // buttonItemOK
            // 
            this.buttonItemOK.Click += new System.EventHandler(this.buttonItemOK_Click);
            // 
            // imageList_Setting
            // 
            this.imageList_Setting.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_Setting.ImageStream")));
            this.imageList_Setting.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_Setting.Images.SetKeyName(0, "home.png");
            this.imageList_Setting.Images.SetKeyName(1, "advancedsettings.png");
            this.imageList_Setting.Images.SetKeyName(2, "announcements.png");
            this.imageList_Setting.Images.SetKeyName(3, "artscontrol.png");
            this.imageList_Setting.Images.SetKeyName(4, "go_kde.png");
            this.imageList_Setting.Images.SetKeyName(5, "sms.png");
            this.imageList_Setting.Images.SetKeyName(6, "kfm_home.png");
            this.imageList_Setting.Images.SetKeyName(7, "Startup Wizard.png");
            this.imageList_Setting.Images.SetKeyName(8, "bell.png");
            this.imageList_Setting.Images.SetKeyName(9, "kcmdf.png");
            this.imageList_Setting.Images.SetKeyName(10, "knode.png");
            this.imageList_Setting.Images.SetKeyName(11, "blender.png");
            this.imageList_Setting.Images.SetKeyName(12, "navigator.png");
            this.imageList_Setting.Images.SetKeyName(13, "systemsettings.png");
            this.imageList_Setting.Images.SetKeyName(14, "Utilities.png");
            // 
            // treeView_Setting
            // 
            this.treeView_Setting.BackColor = System.Drawing.Color.White;
            this.treeView_Setting.Dock = System.Windows.Forms.DockStyle.Right;
            this.treeView_Setting.Font = new System.Drawing.Font("Tahoma", 8.830189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.treeView_Setting.ForeColor = System.Drawing.Color.Black;
            this.treeView_Setting.Indent = 25;
            this.treeView_Setting.ItemHeight = 40;
            this.treeView_Setting.LineColor = System.Drawing.Color.MediumVioletRed;
            this.treeView_Setting.Location = new System.Drawing.Point(632, 0);
            this.treeView_Setting.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.treeView_Setting.Name = "treeView_Setting";
            treeNode1.Name = "Node_SetSystem";
            treeNode1.StateImageKey = "systemsettings.png";
            treeNode1.Tag = "297";
            treeNode1.Text = "تنظیمات سیستمی";
            treeNode2.Name = "Node_SetBkpRst";
            treeNode2.StateImageKey = "kcmdf.png";
            treeNode2.Tag = "298";
            treeNode2.Text = "پشتیبانی و بازیابی";
            treeNode3.Name = "Node_SMS";
            treeNode3.StateImageKey = "sms.png";
            treeNode3.Tag = "299";
            treeNode3.Text = "تنظیمات SMS";
            this.treeView_Setting.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            this.treeView_Setting.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.treeView_Setting.RightToLeftLayout = true;
            this.treeView_Setting.Size = new System.Drawing.Size(185, 530);
            this.treeView_Setting.StateImageList = this.imageList_Setting;
            this.treeView_Setting.TabIndex = 5;
            this.treeView_Setting.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_Setting_NodeMouseClick);
            // 
            // tabControl_Setting
            // 
            this.tabControl_Setting.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tabControl_Setting.CanReorderTabs = true;
            this.tabControl_Setting.Controls.Add(this.tabControlPanel_SetSystem);
            this.tabControl_Setting.Controls.Add(this.tabControlPanel_SetBkpRst);
            this.tabControl_Setting.Controls.Add(this.tabControlPanel_SMS);
            this.tabControl_Setting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Setting.FixedTabSize = new System.Drawing.Size(1, 1);
            this.tabControl_Setting.Location = new System.Drawing.Point(0, 0);
            this.tabControl_Setting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl_Setting.Name = "tabControl_Setting";
            this.tabControl_Setting.SelectedTabFont = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Bold);
            this.tabControl_Setting.SelectedTabIndex = 0;
            this.tabControl_Setting.Size = new System.Drawing.Size(632, 530);
            this.tabControl_Setting.Style = DevComponents.DotNetBar.eTabStripStyle.Office2007Document;
            this.tabControl_Setting.TabIndex = 6;
            this.tabControl_Setting.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.MultilineNoNavigationBox;
            this.tabControl_Setting.Tabs.Add(this.tabItem_SetBkpRst);
            this.tabControl_Setting.Tabs.Add(this.tabItem_SetSystem);
            this.tabControl_Setting.Tabs.Add(this.tabItem_SMS);
            // 
            // tabControlPanel_SetSystem
            // 
            this.tabControlPanel_SetSystem.AutoScroll = true;
            this.tabControlPanel_SetSystem.AutoScrollMinSize = new System.Drawing.Size(600, 400);
            this.tabControlPanel_SetSystem.Controls.Add(this.mssGroupPanel9);
            this.tabControlPanel_SetSystem.Controls.Add(this.mssGroupPanel8);
            this.tabControlPanel_SetSystem.Controls.Add(this.mssGroupPanel6);
            this.tabControlPanel_SetSystem.Controls.Add(this.mssGroupPanel3);
            this.tabControlPanel_SetSystem.Controls.Add(this.mssGroupPanel2);
            this.tabControlPanel_SetSystem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel_SetSystem.Location = new System.Drawing.Point(0, 4);
            this.tabControlPanel_SetSystem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControlPanel_SetSystem.Name = "tabControlPanel_SetSystem";
            this.tabControlPanel_SetSystem.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel_SetSystem.Size = new System.Drawing.Size(632, 526);
            this.tabControlPanel_SetSystem.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(254)))));
            this.tabControlPanel_SetSystem.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(188)))), ((int)(((byte)(227)))));
            this.tabControlPanel_SetSystem.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel_SetSystem.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.tabControlPanel_SetSystem.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel_SetSystem.Style.GradientAngle = 90;
            this.tabControlPanel_SetSystem.TabIndex = 7;
            this.tabControlPanel_SetSystem.TabItem = this.tabItem_SetSystem;
            // 
            // mssGroupPanel8
            // 
            this.mssGroupPanel8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mssGroupPanel8.BackColor = System.Drawing.Color.Transparent;
            this.mssGroupPanel8.CanvasColor = System.Drawing.SystemColors.Control;
            this.mssGroupPanel8.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.mssGroupPanel8.Controls.Add(this.mssLabel8);
            this.mssGroupPanel8.Controls.Add(this.mssLabel16);
            this.mssGroupPanel8.Controls.Add(this.IntBoxCostReqInsuVisitEven);
            this.mssGroupPanel8.Controls.Add(this.mssLabel13);
            this.mssGroupPanel8.Controls.Add(this.mssLabel2);
            this.mssGroupPanel8.Controls.Add(this.IntBoxCostCompanyVisitPercent);
            this.mssGroupPanel8.Controls.Add(this.mssLabel3);
            this.mssGroupPanel8.Controls.Add(this.IntBoxCostReqInsuVisitAdd);
            this.mssGroupPanel8.Controls.Add(this.mssLabel9);
            this.mssGroupPanel8.Controls.Add(this.TextBoxFileSavingVisit);
            this.mssGroupPanel8.Controls.Add(this.mssLabel12);
            this.mssGroupPanel8.Location = new System.Drawing.Point(54, 357);
            this.mssGroupPanel8.Name = "mssGroupPanel8";
            this.mssGroupPanel8.Size = new System.Drawing.Size(551, 128);
            // 
            // 
            // 
            this.mssGroupPanel8.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.mssGroupPanel8.Style.BackColorGradientAngle = 90;
            this.mssGroupPanel8.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.mssGroupPanel8.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.mssGroupPanel8.Style.BorderBottomWidth = 1;
            this.mssGroupPanel8.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.mssGroupPanel8.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.mssGroupPanel8.Style.BorderLeftWidth = 1;
            this.mssGroupPanel8.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.mssGroupPanel8.Style.BorderRightWidth = 1;
            this.mssGroupPanel8.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.mssGroupPanel8.Style.BorderTopWidth = 1;
            this.mssGroupPanel8.Style.CornerDiameter = 4;
            this.mssGroupPanel8.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.mssGroupPanel8.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.mssGroupPanel8.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.mssGroupPanel8.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.mssGroupPanel8.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.mssGroupPanel8.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mssGroupPanel8.TabIndex = 3;
            this.mssGroupPanel8.Text = "ویزیت";
            // 
            // mssLabel8
            // 
            this.mssLabel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mssLabel8.AutoSize = true;
            this.mssLabel8.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.mssLabel8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mssLabel8.Font = new System.Drawing.Font("Tahoma", 8F);
            this.mssLabel8.ForeColor = System.Drawing.Color.Black;
            this.mssLabel8.Location = new System.Drawing.Point(338, 46);
            this.mssLabel8.Name = "mssLabel8";
            this.mssLabel8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mssLabel8.Size = new System.Drawing.Size(97, 15);
            this.mssLabel8.TabIndex = 32;
            this.mssLabel8.Text = "مبلغ ماهانه بابت زوج:";
            // 
            // mssLabel16
            // 
            this.mssLabel16.AutoSize = true;
            this.mssLabel16.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.mssLabel16.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mssLabel16.Font = new System.Drawing.Font("Tahoma", 8F);
            this.mssLabel16.ForeColor = System.Drawing.Color.Black;
            this.mssLabel16.Location = new System.Drawing.Point(64, 45);
            this.mssLabel16.Name = "mssLabel16";
            this.mssLabel16.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mssLabel16.Size = new System.Drawing.Size(19, 15);
            this.mssLabel16.TabIndex = 31;
            this.mssLabel16.Text = "ریال";
            // 
            // IntBoxCostReqInsuVisitEven
            // 
            this.IntBoxCostReqInsuVisitEven.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IntBoxCostReqInsuVisitEven.Location = new System.Drawing.Point(89, 41);
            this.IntBoxCostReqInsuVisitEven.Name = "IntBoxCostReqInsuVisitEven";
            this.IntBoxCostReqInsuVisitEven.Size = new System.Drawing.Size(240, 22);
            this.IntBoxCostReqInsuVisitEven.TabIndex = 30;
            this.IntBoxCostReqInsuVisitEven.Text = "0";
            this.IntBoxCostReqInsuVisitEven.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
            this.IntBoxCostReqInsuVisitEven.Value = 0;
            this.IntBoxCostReqInsuVisitEven.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int32;
            // 
            // mssLabel13
            // 
            this.mssLabel13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mssLabel13.AutoSize = true;
            this.mssLabel13.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.mssLabel13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mssLabel13.Font = new System.Drawing.Font("Tahoma", 8F);
            this.mssLabel13.ForeColor = System.Drawing.Color.Black;
            this.mssLabel13.Location = new System.Drawing.Point(337, 15);
            this.mssLabel13.Name = "mssLabel13";
            this.mssLabel13.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mssLabel13.Size = new System.Drawing.Size(96, 15);
            this.mssLabel13.TabIndex = 29;
            this.mssLabel13.Text = "مبلغ ماهانه بابت فرد:";
            // 
            // mssLabel2
            // 
            this.mssLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mssLabel2.AutoSize = true;
            this.mssLabel2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.mssLabel2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mssLabel2.Font = new System.Drawing.Font("Tahoma", 8F);
            this.mssLabel2.ForeColor = System.Drawing.Color.Black;
            this.mssLabel2.Location = new System.Drawing.Point(331, 77);
            this.mssLabel2.Name = "mssLabel2";
            this.mssLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mssLabel2.Size = new System.Drawing.Size(121, 15);
            this.mssLabel2.TabIndex = 26;
            this.mssLabel2.Text = "درصد سهم سازمان ویزیت:";
            // 
            // IntBoxCostCompanyVisitPercent
            // 
            this.IntBoxCostCompanyVisitPercent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IntBoxCostCompanyVisitPercent.Location = new System.Drawing.Point(262, 74);
            this.IntBoxCostCompanyVisitPercent.MaxLength = 100;
            this.IntBoxCostCompanyVisitPercent.Name = "IntBoxCostCompanyVisitPercent";
            this.IntBoxCostCompanyVisitPercent.Size = new System.Drawing.Size(63, 22);
            this.IntBoxCostCompanyVisitPercent.TabIndex = 27;
            this.IntBoxCostCompanyVisitPercent.Text = "0.00";
            this.IntBoxCostCompanyVisitPercent.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
            this.IntBoxCostCompanyVisitPercent.Value = 0D;
            this.IntBoxCostCompanyVisitPercent.ValueType = Janus.Windows.GridEX.NumericEditValueType.Double;
            // 
            // mssLabel3
            // 
            this.mssLabel3.AutoSize = true;
            this.mssLabel3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.mssLabel3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mssLabel3.Font = new System.Drawing.Font("Tahoma", 8F);
            this.mssLabel3.ForeColor = System.Drawing.Color.Black;
            this.mssLabel3.Location = new System.Drawing.Point(63, 14);
            this.mssLabel3.Name = "mssLabel3";
            this.mssLabel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mssLabel3.Size = new System.Drawing.Size(19, 15);
            this.mssLabel3.TabIndex = 19;
            this.mssLabel3.Text = "ریال";
            // 
            // IntBoxCostReqInsuVisitAdd
            // 
            this.IntBoxCostReqInsuVisitAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IntBoxCostReqInsuVisitAdd.Location = new System.Drawing.Point(88, 10);
            this.IntBoxCostReqInsuVisitAdd.Name = "IntBoxCostReqInsuVisitAdd";
            this.IntBoxCostReqInsuVisitAdd.Size = new System.Drawing.Size(240, 22);
            this.IntBoxCostReqInsuVisitAdd.TabIndex = 18;
            this.IntBoxCostReqInsuVisitAdd.Text = "0";
            this.IntBoxCostReqInsuVisitAdd.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
            this.IntBoxCostReqInsuVisitAdd.Value = 0;
            this.IntBoxCostReqInsuVisitAdd.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int32;
            // 
            // mssLabel9
            // 
            this.mssLabel9.AutoSize = true;
            this.mssLabel9.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.mssLabel9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mssLabel9.Font = new System.Drawing.Font("Tahoma", 8F);
            this.mssLabel9.ForeColor = System.Drawing.Color.Black;
            this.mssLabel9.Location = new System.Drawing.Point(234, 80);
            this.mssLabel9.Name = "mssLabel9";
            this.mssLabel9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mssLabel9.Size = new System.Drawing.Size(25, 15);
            this.mssLabel9.TabIndex = 16;
            this.mssLabel9.Text = "درصد";
            // 
            // TextBoxFileSavingVisit
            // 
            // 
            // 
            // 
            this.TextBoxFileSavingVisit.Border.Class = "TextBoxBorder";
            this.TextBoxFileSavingVisit.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxFileSavingVisit.Location = new System.Drawing.Point(50, 99);
            this.TextBoxFileSavingVisit.Name = "TextBoxFileSavingVisit";
            this.TextBoxFileSavingVisit.Size = new System.Drawing.Size(284, 22);
            this.TextBoxFileSavingVisit.TabIndex = 13;
            this.TextBoxFileSavingVisit.Visible = false;
            // 
            // mssLabel12
            // 
            this.mssLabel12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mssLabel12.AutoSize = true;
            this.mssLabel12.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.mssLabel12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mssLabel12.ForeColor = System.Drawing.Color.Black;
            this.mssLabel12.Location = new System.Drawing.Point(334, 98);
            this.mssLabel12.Name = "mssLabel12";
            this.mssLabel12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mssLabel12.Size = new System.Drawing.Size(183, 17);
            this.mssLabel12.TabIndex = 12;
            this.mssLabel12.Text = "آدرس ذخیره سازی فایل ها در سرور:";
            this.mssLabel12.Visible = false;
            // 
            // mssGroupPanel6
            // 
            this.mssGroupPanel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mssGroupPanel6.BackColor = System.Drawing.Color.Transparent;
            this.mssGroupPanel6.CanvasColor = System.Drawing.SystemColors.Control;
            this.mssGroupPanel6.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.mssGroupPanel6.Controls.Add(this.mssLabel4);
            this.mssGroupPanel6.Controls.Add(this.IntBoxCostCompanyHealthPercent);
            this.mssGroupPanel6.Controls.Add(this.mssLabel6);
            this.mssGroupPanel6.Controls.Add(this.TextBoxFileSavingHealth);
            this.mssGroupPanel6.Controls.Add(this.mssLabel7);
            this.mssGroupPanel6.Location = new System.Drawing.Point(54, 287);
            this.mssGroupPanel6.Name = "mssGroupPanel6";
            this.mssGroupPanel6.Size = new System.Drawing.Size(551, 67);
            // 
            // 
            // 
            this.mssGroupPanel6.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.mssGroupPanel6.Style.BackColorGradientAngle = 90;
            this.mssGroupPanel6.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.mssGroupPanel6.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.mssGroupPanel6.Style.BorderBottomWidth = 1;
            this.mssGroupPanel6.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.mssGroupPanel6.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.mssGroupPanel6.Style.BorderLeftWidth = 1;
            this.mssGroupPanel6.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.mssGroupPanel6.Style.BorderRightWidth = 1;
            this.mssGroupPanel6.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.mssGroupPanel6.Style.BorderTopWidth = 1;
            this.mssGroupPanel6.Style.CornerDiameter = 4;
            this.mssGroupPanel6.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.mssGroupPanel6.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.mssGroupPanel6.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.mssGroupPanel6.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.mssGroupPanel6.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.mssGroupPanel6.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mssGroupPanel6.TabIndex = 2;
            this.mssGroupPanel6.Text = "بهیاری";
            // 
            // mssLabel4
            // 
            this.mssLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mssLabel4.AutoSize = true;
            this.mssLabel4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.mssLabel4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mssLabel4.Font = new System.Drawing.Font("Tahoma", 8F);
            this.mssLabel4.ForeColor = System.Drawing.Color.Black;
            this.mssLabel4.Location = new System.Drawing.Point(334, 14);
            this.mssLabel4.Name = "mssLabel4";
            this.mssLabel4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mssLabel4.Size = new System.Drawing.Size(125, 15);
            this.mssLabel4.TabIndex = 29;
            this.mssLabel4.Text = "درصد سهم سازمان بهیاری:";
            // 
            // IntBoxCostCompanyHealthPercent
            // 
            this.IntBoxCostCompanyHealthPercent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IntBoxCostCompanyHealthPercent.Location = new System.Drawing.Point(259, 8);
            this.IntBoxCostCompanyHealthPercent.MaxLength = 100;
            this.IntBoxCostCompanyHealthPercent.Name = "IntBoxCostCompanyHealthPercent";
            this.IntBoxCostCompanyHealthPercent.Size = new System.Drawing.Size(69, 22);
            this.IntBoxCostCompanyHealthPercent.TabIndex = 30;
            this.IntBoxCostCompanyHealthPercent.Text = "0.00";
            this.IntBoxCostCompanyHealthPercent.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
            this.IntBoxCostCompanyHealthPercent.Value = 0D;
            this.IntBoxCostCompanyHealthPercent.ValueType = Janus.Windows.GridEX.NumericEditValueType.Double;
            // 
            // mssLabel6
            // 
            this.mssLabel6.AutoSize = true;
            this.mssLabel6.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.mssLabel6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mssLabel6.Font = new System.Drawing.Font("Tahoma", 8F);
            this.mssLabel6.ForeColor = System.Drawing.Color.Black;
            this.mssLabel6.Location = new System.Drawing.Point(228, 15);
            this.mssLabel6.Name = "mssLabel6";
            this.mssLabel6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mssLabel6.Size = new System.Drawing.Size(25, 15);
            this.mssLabel6.TabIndex = 28;
            this.mssLabel6.Text = "درصد";
            // 
            // TextBoxFileSavingHealth
            // 
            // 
            // 
            // 
            this.TextBoxFileSavingHealth.Border.Class = "TextBoxBorder";
            this.TextBoxFileSavingHealth.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxFileSavingHealth.Location = new System.Drawing.Point(50, 40);
            this.TextBoxFileSavingHealth.Name = "TextBoxFileSavingHealth";
            this.TextBoxFileSavingHealth.Size = new System.Drawing.Size(284, 22);
            this.TextBoxFileSavingHealth.TabIndex = 13;
            this.TextBoxFileSavingHealth.Visible = false;
            // 
            // mssLabel7
            // 
            this.mssLabel7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mssLabel7.AutoSize = true;
            this.mssLabel7.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.mssLabel7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mssLabel7.ForeColor = System.Drawing.Color.Black;
            this.mssLabel7.Location = new System.Drawing.Point(334, 39);
            this.mssLabel7.Name = "mssLabel7";
            this.mssLabel7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mssLabel7.Size = new System.Drawing.Size(183, 17);
            this.mssLabel7.TabIndex = 12;
            this.mssLabel7.Text = "آدرس ذخیره سازی فایل ها در سرور:";
            this.mssLabel7.Visible = false;
            // 
            // mssGroupPanel3
            // 
            this.mssGroupPanel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mssGroupPanel3.BackColor = System.Drawing.Color.Transparent;
            this.mssGroupPanel3.CanvasColor = System.Drawing.SystemColors.Control;
            this.mssGroupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.mssGroupPanel3.Controls.Add(this.mssLabel27);
            this.mssGroupPanel3.Controls.Add(this.IntBoxCareDaysDefault);
            this.mssGroupPanel3.Controls.Add(this.mssLabel24);
            this.mssGroupPanel3.Controls.Add(this.mssLabel26);
            this.mssGroupPanel3.Controls.Add(this.mssLabel23);
            this.mssGroupPanel3.Controls.Add(this.mssLabel25);
            this.mssGroupPanel3.Controls.Add(this.mssLabel21);
            this.mssGroupPanel3.Controls.Add(this.mssLabel22);
            this.mssGroupPanel3.Controls.Add(this.IntBoxCareShift1);
            this.mssGroupPanel3.Controls.Add(this.IntBoxCareShift3);
            this.mssGroupPanel3.Controls.Add(this.IntBoxCareShift2);
            this.mssGroupPanel3.Controls.Add(this.mssLabel15);
            this.mssGroupPanel3.Controls.Add(this.mssLabel17);
            this.mssGroupPanel3.Controls.Add(this.IntBoxCostCompanyCarePercent);
            this.mssGroupPanel3.Controls.Add(this.TextBoxFileSavingCare);
            this.mssGroupPanel3.Controls.Add(this.mssLabel18);
            this.mssGroupPanel3.Location = new System.Drawing.Point(51, 4);
            this.mssGroupPanel3.Name = "mssGroupPanel3";
            this.mssGroupPanel3.Size = new System.Drawing.Size(551, 184);
            // 
            // 
            // 
            this.mssGroupPanel3.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.mssGroupPanel3.Style.BackColorGradientAngle = 90;
            this.mssGroupPanel3.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.mssGroupPanel3.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.mssGroupPanel3.Style.BorderBottomWidth = 1;
            this.mssGroupPanel3.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.mssGroupPanel3.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.mssGroupPanel3.Style.BorderLeftWidth = 1;
            this.mssGroupPanel3.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.mssGroupPanel3.Style.BorderRightWidth = 1;
            this.mssGroupPanel3.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.mssGroupPanel3.Style.BorderTopWidth = 1;
            this.mssGroupPanel3.Style.CornerDiameter = 4;
            this.mssGroupPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.mssGroupPanel3.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.mssGroupPanel3.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.mssGroupPanel3.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.mssGroupPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.mssGroupPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mssGroupPanel3.TabIndex = 1;
            this.mssGroupPanel3.Text = "مراقبت";
            // 
            // mssLabel27
            // 
            this.mssLabel27.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mssLabel27.AutoSize = true;
            this.mssLabel27.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.mssLabel27.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mssLabel27.Font = new System.Drawing.Font("Tahoma", 8F);
            this.mssLabel27.ForeColor = System.Drawing.Color.Black;
            this.mssLabel27.Location = new System.Drawing.Point(337, 100);
            this.mssLabel27.Name = "mssLabel27";
            this.mssLabel27.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mssLabel27.Size = new System.Drawing.Size(169, 15);
            this.mssLabel27.TabIndex = 34;
            this.mssLabel27.Text = "تعداد روزهای ماه به صورت پیش فرض:";
            // 
            // IntBoxCareDaysDefault
            // 
            this.IntBoxCareDaysDefault.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IntBoxCareDaysDefault.Location = new System.Drawing.Point(262, 97);
            this.IntBoxCareDaysDefault.Name = "IntBoxCareDaysDefault";
            this.IntBoxCareDaysDefault.Size = new System.Drawing.Size(69, 22);
            this.IntBoxCareDaysDefault.TabIndex = 35;
            this.IntBoxCareDaysDefault.Text = "30";
            this.IntBoxCareDaysDefault.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
            this.IntBoxCareDaysDefault.Value = 30;
            this.IntBoxCareDaysDefault.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int32;
            // 
            // mssLabel24
            // 
            this.mssLabel24.AutoSize = true;
            this.mssLabel24.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.mssLabel24.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mssLabel24.Font = new System.Drawing.Font("Tahoma", 8F);
            this.mssLabel24.ForeColor = System.Drawing.Color.Black;
            this.mssLabel24.Location = new System.Drawing.Point(63, 17);
            this.mssLabel24.Name = "mssLabel24";
            this.mssLabel24.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mssLabel24.Size = new System.Drawing.Size(19, 15);
            this.mssLabel24.TabIndex = 32;
            this.mssLabel24.Text = "ریال";
            // 
            // mssLabel26
            // 
            this.mssLabel26.AutoSize = true;
            this.mssLabel26.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.mssLabel26.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mssLabel26.Font = new System.Drawing.Font("Tahoma", 8F);
            this.mssLabel26.ForeColor = System.Drawing.Color.Black;
            this.mssLabel26.Location = new System.Drawing.Point(63, 79);
            this.mssLabel26.Name = "mssLabel26";
            this.mssLabel26.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mssLabel26.Size = new System.Drawing.Size(19, 15);
            this.mssLabel26.TabIndex = 33;
            this.mssLabel26.Text = "ریال";
            // 
            // mssLabel23
            // 
            this.mssLabel23.AutoSize = true;
            this.mssLabel23.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.mssLabel23.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mssLabel23.Font = new System.Drawing.Font("Tahoma", 8F);
            this.mssLabel23.ForeColor = System.Drawing.Color.Black;
            this.mssLabel23.Location = new System.Drawing.Point(63, 48);
            this.mssLabel23.Name = "mssLabel23";
            this.mssLabel23.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mssLabel23.Size = new System.Drawing.Size(19, 15);
            this.mssLabel23.TabIndex = 33;
            this.mssLabel23.Text = "ریال";
            // 
            // mssLabel25
            // 
            this.mssLabel25.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mssLabel25.AutoSize = true;
            this.mssLabel25.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.mssLabel25.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mssLabel25.Font = new System.Drawing.Font("Tahoma", 8F);
            this.mssLabel25.ForeColor = System.Drawing.Color.Black;
            this.mssLabel25.Location = new System.Drawing.Point(337, 69);
            this.mssLabel25.Name = "mssLabel25";
            this.mssLabel25.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mssLabel25.Size = new System.Drawing.Size(110, 15);
            this.mssLabel25.TabIndex = 28;
            this.mssLabel25.Text = "مبلغ ماهانه سه شیفت:";
            // 
            // mssLabel21
            // 
            this.mssLabel21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mssLabel21.AutoSize = true;
            this.mssLabel21.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.mssLabel21.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mssLabel21.Font = new System.Drawing.Font("Tahoma", 8F);
            this.mssLabel21.ForeColor = System.Drawing.Color.Black;
            this.mssLabel21.Location = new System.Drawing.Point(337, 38);
            this.mssLabel21.Name = "mssLabel21";
            this.mssLabel21.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mssLabel21.Size = new System.Drawing.Size(102, 15);
            this.mssLabel21.TabIndex = 28;
            this.mssLabel21.Text = "مبلغ ماهانه دو شیفت:";
            // 
            // mssLabel22
            // 
            this.mssLabel22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mssLabel22.AutoSize = true;
            this.mssLabel22.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.mssLabel22.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mssLabel22.Font = new System.Drawing.Font("Tahoma", 8F);
            this.mssLabel22.ForeColor = System.Drawing.Color.Black;
            this.mssLabel22.Location = new System.Drawing.Point(337, 7);
            this.mssLabel22.Name = "mssLabel22";
            this.mssLabel22.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mssLabel22.Size = new System.Drawing.Size(106, 15);
            this.mssLabel22.TabIndex = 28;
            this.mssLabel22.Text = "مبلغ ماهانه تک شیفت:";
            // 
            // IntBoxCareShift1
            // 
            this.IntBoxCareShift1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IntBoxCareShift1.Location = new System.Drawing.Point(85, 4);
            this.IntBoxCareShift1.Name = "IntBoxCareShift1";
            this.IntBoxCareShift1.Size = new System.Drawing.Size(246, 22);
            this.IntBoxCareShift1.TabIndex = 30;
            this.IntBoxCareShift1.Text = "0";
            this.IntBoxCareShift1.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
            this.IntBoxCareShift1.Value = 0;
            this.IntBoxCareShift1.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int32;
            // 
            // IntBoxCareShift3
            // 
            this.IntBoxCareShift3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IntBoxCareShift3.Location = new System.Drawing.Point(85, 66);
            this.IntBoxCareShift3.Name = "IntBoxCareShift3";
            this.IntBoxCareShift3.Size = new System.Drawing.Size(246, 22);
            this.IntBoxCareShift3.TabIndex = 31;
            this.IntBoxCareShift3.Text = "0";
            this.IntBoxCareShift3.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
            this.IntBoxCareShift3.Value = 0;
            this.IntBoxCareShift3.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int32;
            // 
            // IntBoxCareShift2
            // 
            this.IntBoxCareShift2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IntBoxCareShift2.Location = new System.Drawing.Point(85, 35);
            this.IntBoxCareShift2.Name = "IntBoxCareShift2";
            this.IntBoxCareShift2.Size = new System.Drawing.Size(246, 22);
            this.IntBoxCareShift2.TabIndex = 31;
            this.IntBoxCareShift2.Text = "0";
            this.IntBoxCareShift2.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
            this.IntBoxCareShift2.Value = 0;
            this.IntBoxCareShift2.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int32;
            // 
            // mssLabel15
            // 
            this.mssLabel15.AutoSize = true;
            this.mssLabel15.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.mssLabel15.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mssLabel15.Font = new System.Drawing.Font("Tahoma", 8F);
            this.mssLabel15.ForeColor = System.Drawing.Color.Black;
            this.mssLabel15.Location = new System.Drawing.Point(233, 134);
            this.mssLabel15.Name = "mssLabel15";
            this.mssLabel15.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mssLabel15.Size = new System.Drawing.Size(25, 15);
            this.mssLabel15.TabIndex = 27;
            this.mssLabel15.Text = "درصد";
            // 
            // mssLabel17
            // 
            this.mssLabel17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mssLabel17.AutoSize = true;
            this.mssLabel17.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.mssLabel17.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mssLabel17.Font = new System.Drawing.Font("Tahoma", 8F);
            this.mssLabel17.ForeColor = System.Drawing.Color.Black;
            this.mssLabel17.Location = new System.Drawing.Point(337, 131);
            this.mssLabel17.Name = "mssLabel17";
            this.mssLabel17.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mssLabel17.Size = new System.Drawing.Size(126, 15);
            this.mssLabel17.TabIndex = 23;
            this.mssLabel17.Text = "درصد سهم سازمان مراقبت:";
            // 
            // IntBoxCostCompanyCarePercent
            // 
            this.IntBoxCostCompanyCarePercent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IntBoxCostCompanyCarePercent.Location = new System.Drawing.Point(262, 128);
            this.IntBoxCostCompanyCarePercent.MaxLength = 100;
            this.IntBoxCostCompanyCarePercent.Name = "IntBoxCostCompanyCarePercent";
            this.IntBoxCostCompanyCarePercent.Size = new System.Drawing.Size(69, 22);
            this.IntBoxCostCompanyCarePercent.TabIndex = 25;
            this.IntBoxCostCompanyCarePercent.Text = "0.00";
            this.IntBoxCostCompanyCarePercent.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
            this.IntBoxCostCompanyCarePercent.Value = 0D;
            this.IntBoxCostCompanyCarePercent.ValueType = Janus.Windows.GridEX.NumericEditValueType.Double;
            // 
            // TextBoxFileSavingCare
            // 
            // 
            // 
            // 
            this.TextBoxFileSavingCare.Border.Class = "TextBoxBorder";
            this.TextBoxFileSavingCare.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxFileSavingCare.Location = new System.Drawing.Point(50, 151);
            this.TextBoxFileSavingCare.Name = "TextBoxFileSavingCare";
            this.TextBoxFileSavingCare.Size = new System.Drawing.Size(284, 22);
            this.TextBoxFileSavingCare.TabIndex = 21;
            this.TextBoxFileSavingCare.Visible = false;
            // 
            // mssLabel18
            // 
            this.mssLabel18.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mssLabel18.AutoSize = true;
            this.mssLabel18.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.mssLabel18.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mssLabel18.ForeColor = System.Drawing.Color.Black;
            this.mssLabel18.Location = new System.Drawing.Point(337, 154);
            this.mssLabel18.Name = "mssLabel18";
            this.mssLabel18.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mssLabel18.Size = new System.Drawing.Size(183, 17);
            this.mssLabel18.TabIndex = 20;
            this.mssLabel18.Text = "آدرس ذخیره سازی فایل ها در سرور:";
            this.mssLabel18.Visible = false;
            // 
            // mssGroupPanel2
            // 
            this.mssGroupPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mssGroupPanel2.BackColor = System.Drawing.Color.Transparent;
            this.mssGroupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.mssGroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.mssGroupPanel2.Controls.Add(this.mssLabel5);
            this.mssGroupPanel2.Controls.Add(this.IntBoxCostCompanyPhsiotraphyPercent);
            this.mssGroupPanel2.Controls.Add(this.mssLabel11);
            this.mssGroupPanel2.Controls.Add(this.mssLabel10);
            this.mssGroupPanel2.Controls.Add(this.IntBoxCostReqInsuPhsiotraphy);
            this.mssGroupPanel2.Controls.Add(this.mssLabel14);
            this.mssGroupPanel2.Controls.Add(this.TextBoxFileSavingPhysiotherapy);
            this.mssGroupPanel2.Controls.Add(this.mssLabel1);
            this.mssGroupPanel2.Location = new System.Drawing.Point(51, 192);
            this.mssGroupPanel2.Name = "mssGroupPanel2";
            this.mssGroupPanel2.Size = new System.Drawing.Size(551, 92);
            // 
            // 
            // 
            this.mssGroupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.mssGroupPanel2.Style.BackColorGradientAngle = 90;
            this.mssGroupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.mssGroupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.mssGroupPanel2.Style.BorderBottomWidth = 1;
            this.mssGroupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.mssGroupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.mssGroupPanel2.Style.BorderLeftWidth = 1;
            this.mssGroupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.mssGroupPanel2.Style.BorderRightWidth = 1;
            this.mssGroupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.mssGroupPanel2.Style.BorderTopWidth = 1;
            this.mssGroupPanel2.Style.CornerDiameter = 4;
            this.mssGroupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.mssGroupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.mssGroupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.mssGroupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.mssGroupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.mssGroupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mssGroupPanel2.TabIndex = 0;
            this.mssGroupPanel2.Text = "فیزیوتراپی";
            // 
            // mssLabel5
            // 
            this.mssLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mssLabel5.AutoSize = true;
            this.mssLabel5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.mssLabel5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mssLabel5.Font = new System.Drawing.Font("Tahoma", 8F);
            this.mssLabel5.ForeColor = System.Drawing.Color.Black;
            this.mssLabel5.Location = new System.Drawing.Point(337, 38);
            this.mssLabel5.Name = "mssLabel5";
            this.mssLabel5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mssLabel5.Size = new System.Drawing.Size(140, 15);
            this.mssLabel5.TabIndex = 26;
            this.mssLabel5.Text = "درصد سهم سازمان فیزیوتراپی:";
            // 
            // IntBoxCostCompanyPhsiotraphyPercent
            // 
            this.IntBoxCostCompanyPhsiotraphyPercent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IntBoxCostCompanyPhsiotraphyPercent.Location = new System.Drawing.Point(262, 35);
            this.IntBoxCostCompanyPhsiotraphyPercent.MaxLength = 100;
            this.IntBoxCostCompanyPhsiotraphyPercent.Name = "IntBoxCostCompanyPhsiotraphyPercent";
            this.IntBoxCostCompanyPhsiotraphyPercent.Size = new System.Drawing.Size(69, 22);
            this.IntBoxCostCompanyPhsiotraphyPercent.TabIndex = 27;
            this.IntBoxCostCompanyPhsiotraphyPercent.Text = "0.00";
            this.IntBoxCostCompanyPhsiotraphyPercent.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
            this.IntBoxCostCompanyPhsiotraphyPercent.Value = 0D;
            this.IntBoxCostCompanyPhsiotraphyPercent.ValueType = Janus.Windows.GridEX.NumericEditValueType.Double;
            // 
            // mssLabel11
            // 
            this.mssLabel11.AutoSize = true;
            this.mssLabel11.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.mssLabel11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mssLabel11.Font = new System.Drawing.Font("Tahoma", 8F);
            this.mssLabel11.ForeColor = System.Drawing.Color.Black;
            this.mssLabel11.Location = new System.Drawing.Point(63, 10);
            this.mssLabel11.Name = "mssLabel11";
            this.mssLabel11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mssLabel11.Size = new System.Drawing.Size(19, 15);
            this.mssLabel11.TabIndex = 19;
            this.mssLabel11.Text = "ریال";
            // 
            // mssLabel10
            // 
            this.mssLabel10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mssLabel10.AutoSize = true;
            this.mssLabel10.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.mssLabel10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mssLabel10.Font = new System.Drawing.Font("Tahoma", 8F);
            this.mssLabel10.ForeColor = System.Drawing.Color.Black;
            this.mssLabel10.Location = new System.Drawing.Point(337, 10);
            this.mssLabel10.Name = "mssLabel10";
            this.mssLabel10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mssLabel10.Size = new System.Drawing.Size(156, 15);
            this.mssLabel10.TabIndex = 17;
            this.mssLabel10.Text = "درخواستی از بیمه بابت هر جلسه:";
            // 
            // IntBoxCostReqInsuPhsiotraphy
            // 
            this.IntBoxCostReqInsuPhsiotraphy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IntBoxCostReqInsuPhsiotraphy.Location = new System.Drawing.Point(88, 6);
            this.IntBoxCostReqInsuPhsiotraphy.Name = "IntBoxCostReqInsuPhsiotraphy";
            this.IntBoxCostReqInsuPhsiotraphy.Size = new System.Drawing.Size(246, 22);
            this.IntBoxCostReqInsuPhsiotraphy.TabIndex = 18;
            this.IntBoxCostReqInsuPhsiotraphy.Text = "0";
            this.IntBoxCostReqInsuPhsiotraphy.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
            this.IntBoxCostReqInsuPhsiotraphy.Value = 0;
            this.IntBoxCostReqInsuPhsiotraphy.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int32;
            // 
            // mssLabel14
            // 
            this.mssLabel14.AutoSize = true;
            this.mssLabel14.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.mssLabel14.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mssLabel14.Font = new System.Drawing.Font("Tahoma", 8F);
            this.mssLabel14.ForeColor = System.Drawing.Color.Black;
            this.mssLabel14.Location = new System.Drawing.Point(234, 41);
            this.mssLabel14.Name = "mssLabel14";
            this.mssLabel14.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mssLabel14.Size = new System.Drawing.Size(25, 15);
            this.mssLabel14.TabIndex = 16;
            this.mssLabel14.Text = "درصد";
            // 
            // TextBoxFileSavingPhysiotherapy
            // 
            // 
            // 
            // 
            this.TextBoxFileSavingPhysiotherapy.Border.Class = "TextBoxBorder";
            this.TextBoxFileSavingPhysiotherapy.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxFileSavingPhysiotherapy.Location = new System.Drawing.Point(50, 64);
            this.TextBoxFileSavingPhysiotherapy.Name = "TextBoxFileSavingPhysiotherapy";
            this.TextBoxFileSavingPhysiotherapy.Size = new System.Drawing.Size(284, 22);
            this.TextBoxFileSavingPhysiotherapy.TabIndex = 13;
            this.TextBoxFileSavingPhysiotherapy.Visible = false;
            // 
            // mssLabel1
            // 
            this.mssLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mssLabel1.AutoSize = true;
            this.mssLabel1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.mssLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mssLabel1.ForeColor = System.Drawing.Color.Black;
            this.mssLabel1.Location = new System.Drawing.Point(337, 63);
            this.mssLabel1.Name = "mssLabel1";
            this.mssLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mssLabel1.Size = new System.Drawing.Size(183, 17);
            this.mssLabel1.TabIndex = 12;
            this.mssLabel1.Text = "آدرس ذخیره سازی فایل ها در سرور:";
            this.mssLabel1.Visible = false;
            // 
            // tabItem_SetSystem
            // 
            this.tabItem_SetSystem.AttachedControl = this.tabControlPanel_SetSystem;
            this.tabItem_SetSystem.Name = "tabItem_SetSystem";
            this.tabItem_SetSystem.Text = "tabItem_SetAlarms";
            // 
            // tabControlPanel_SetBkpRst
            // 
            this.tabControlPanel_SetBkpRst.AutoScroll = true;
            this.tabControlPanel_SetBkpRst.AutoScrollMinSize = new System.Drawing.Size(600, 400);
            this.tabControlPanel_SetBkpRst.Controls.Add(this.ButtonClearCash);
            this.tabControlPanel_SetBkpRst.Controls.Add(this.mssGroupPanel5);
            this.tabControlPanel_SetBkpRst.Controls.Add(this.mssGroupPanel4);
            this.tabControlPanel_SetBkpRst.Controls.Add(this.panel4);
            this.tabControlPanel_SetBkpRst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel_SetBkpRst.Location = new System.Drawing.Point(0, 4);
            this.tabControlPanel_SetBkpRst.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControlPanel_SetBkpRst.Name = "tabControlPanel_SetBkpRst";
            this.tabControlPanel_SetBkpRst.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel_SetBkpRst.Size = new System.Drawing.Size(632, 526);
            this.tabControlPanel_SetBkpRst.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(254)))));
            this.tabControlPanel_SetBkpRst.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(188)))), ((int)(((byte)(227)))));
            this.tabControlPanel_SetBkpRst.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel_SetBkpRst.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.tabControlPanel_SetBkpRst.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel_SetBkpRst.Style.GradientAngle = 90;
            this.tabControlPanel_SetBkpRst.TabIndex = 6;
            this.tabControlPanel_SetBkpRst.TabItem = this.tabItem_SetBkpRst;
            // 
            // ButtonClearCash
            // 
            this.ButtonClearCash.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonClearCash.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ButtonClearCash.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonClearCash.Location = new System.Drawing.Point(187, 458);
            this.ButtonClearCash.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonClearCash.Name = "ButtonClearCash";
            this.ButtonClearCash.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ButtonClearCash.Size = new System.Drawing.Size(235, 40);
            this.ButtonClearCash.TabIndex = 0;
            this.ButtonClearCash.Text = "Clear Cash";
            this.ButtonClearCash.Click += new System.EventHandler(this.ButtonClearCash_Click);
            // 
            // mssGroupPanel5
            // 
            this.mssGroupPanel5.BackColor = System.Drawing.Color.Transparent;
            this.mssGroupPanel5.CanvasColor = System.Drawing.SystemColors.Control;
            this.mssGroupPanel5.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.mssGroupPanel5.Controls.Add(this.TextBoxFileSavingPatient);
            this.mssGroupPanel5.Controls.Add(this.mssLabel19);
            this.mssGroupPanel5.Controls.Add(this.TextBoxBkpAuto);
            this.mssGroupPanel5.Controls.Add(this.radioButton_BkpAuto);
            this.mssGroupPanel5.Controls.Add(this.radioButton_BkpNonAuto);
            this.mssGroupPanel5.Controls.Add(this.radioButton_BkpNo);
            this.mssGroupPanel5.Location = new System.Drawing.Point(34, 18);
            this.mssGroupPanel5.Name = "mssGroupPanel5";
            this.mssGroupPanel5.Size = new System.Drawing.Size(570, 229);
            // 
            // 
            // 
            this.mssGroupPanel5.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.mssGroupPanel5.Style.BackColorGradientAngle = 90;
            this.mssGroupPanel5.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.mssGroupPanel5.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.mssGroupPanel5.Style.BorderBottomWidth = 1;
            this.mssGroupPanel5.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.mssGroupPanel5.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.mssGroupPanel5.Style.BorderLeftWidth = 1;
            this.mssGroupPanel5.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.mssGroupPanel5.Style.BorderRightWidth = 1;
            this.mssGroupPanel5.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.mssGroupPanel5.Style.BorderTopWidth = 1;
            this.mssGroupPanel5.Style.CornerDiameter = 4;
            this.mssGroupPanel5.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.mssGroupPanel5.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.mssGroupPanel5.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.mssGroupPanel5.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.mssGroupPanel5.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.mssGroupPanel5.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mssGroupPanel5.TabIndex = 16;
            // 
            // TextBoxFileSavingPatient
            // 
            // 
            // 
            // 
            this.TextBoxFileSavingPatient.Border.Class = "TextBoxBorder";
            this.TextBoxFileSavingPatient.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxFileSavingPatient.Location = new System.Drawing.Point(49, 157);
            this.TextBoxFileSavingPatient.Name = "TextBoxFileSavingPatient";
            this.TextBoxFileSavingPatient.Size = new System.Drawing.Size(284, 22);
            this.TextBoxFileSavingPatient.TabIndex = 23;
            this.TextBoxFileSavingPatient.Visible = false;
            // 
            // mssLabel19
            // 
            this.mssLabel19.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mssLabel19.AutoSize = true;
            this.mssLabel19.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.mssLabel19.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mssLabel19.ForeColor = System.Drawing.Color.Black;
            this.mssLabel19.Location = new System.Drawing.Point(336, 160);
            this.mssLabel19.Name = "mssLabel19";
            this.mssLabel19.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mssLabel19.Size = new System.Drawing.Size(183, 17);
            this.mssLabel19.TabIndex = 22;
            this.mssLabel19.Text = "آدرس ذخیره سازی فایل ها در سرور:";
            this.mssLabel19.Visible = false;
            // 
            // TextBoxBkpAuto
            // 
            // 
            // 
            // 
            this.TextBoxBkpAuto.Border.Class = "TextBoxBorder";
            this.TextBoxBkpAuto.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxBkpAuto.Location = new System.Drawing.Point(3, 27);
            this.TextBoxBkpAuto.Name = "TextBoxBkpAuto";
            this.TextBoxBkpAuto.Size = new System.Drawing.Size(246, 22);
            this.TextBoxBkpAuto.TabIndex = 14;
            // 
            // radioButton_BkpAuto
            // 
            this.radioButton_BkpAuto.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.radioButton_BkpAuto.AutoSize = true;
            this.radioButton_BkpAuto.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.radioButton_BkpAuto.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.radioButton_BkpAuto.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.radioButton_BkpAuto.Checked = true;
            this.radioButton_BkpAuto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.radioButton_BkpAuto.CheckValue = "Y";
            this.radioButton_BkpAuto.Location = new System.Drawing.Point(248, 24);
            this.radioButton_BkpAuto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton_BkpAuto.Name = "radioButton_BkpAuto";
            this.radioButton_BkpAuto.Size = new System.Drawing.Size(239, 17);
            this.radioButton_BkpAuto.TabIndex = 3;
            this.radioButton_BkpAuto.Text = "به صورت اتوماتیک گرفته شود            مسیر";
            // 
            // radioButton_BkpNonAuto
            // 
            this.radioButton_BkpNonAuto.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.radioButton_BkpNonAuto.AutoSize = true;
            this.radioButton_BkpNonAuto.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.radioButton_BkpNonAuto.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.radioButton_BkpNonAuto.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.radioButton_BkpNonAuto.Location = new System.Drawing.Point(303, 63);
            this.radioButton_BkpNonAuto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton_BkpNonAuto.Name = "radioButton_BkpNonAuto";
            this.radioButton_BkpNonAuto.Size = new System.Drawing.Size(184, 17);
            this.radioButton_BkpNonAuto.TabIndex = 2;
            this.radioButton_BkpNonAuto.Text = "در هنگام خروج مسیر سوال شود";
            // 
            // radioButton_BkpNo
            // 
            this.radioButton_BkpNo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.radioButton_BkpNo.AutoSize = true;
            this.radioButton_BkpNo.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.radioButton_BkpNo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.radioButton_BkpNo.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.radioButton_BkpNo.Location = new System.Drawing.Point(421, 103);
            this.radioButton_BkpNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton_BkpNo.Name = "radioButton_BkpNo";
            this.radioButton_BkpNo.Size = new System.Drawing.Size(66, 17);
            this.radioButton_BkpNo.TabIndex = 4;
            this.radioButton_BkpNo.Text = "هیچکدام";
            // 
            // mssGroupPanel4
            // 
            this.mssGroupPanel4.CanvasColor = System.Drawing.SystemColors.Control;
            this.mssGroupPanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.mssGroupPanel4.Controls.Add(this.button_RstChangePass);
            this.mssGroupPanel4.Location = new System.Drawing.Point(67, 325);
            this.mssGroupPanel4.Name = "mssGroupPanel4";
            this.mssGroupPanel4.Size = new System.Drawing.Size(487, 100);
            // 
            // 
            // 
            this.mssGroupPanel4.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.mssGroupPanel4.Style.BackColorGradientAngle = 90;
            this.mssGroupPanel4.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.mssGroupPanel4.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.mssGroupPanel4.Style.BorderBottomWidth = 1;
            this.mssGroupPanel4.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.mssGroupPanel4.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.mssGroupPanel4.Style.BorderLeftWidth = 1;
            this.mssGroupPanel4.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.mssGroupPanel4.Style.BorderRightWidth = 1;
            this.mssGroupPanel4.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.mssGroupPanel4.Style.BorderTopWidth = 1;
            this.mssGroupPanel4.Style.CornerDiameter = 4;
            this.mssGroupPanel4.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.mssGroupPanel4.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.mssGroupPanel4.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.mssGroupPanel4.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.mssGroupPanel4.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.mssGroupPanel4.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mssGroupPanel4.TabIndex = 15;
            // 
            // button_RstChangePass
            // 
            this.button_RstChangePass.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.button_RstChangePass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_RstChangePass.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.button_RstChangePass.Location = new System.Drawing.Point(92, 31);
            this.button_RstChangePass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_RstChangePass.Name = "button_RstChangePass";
            this.button_RstChangePass.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button_RstChangePass.Size = new System.Drawing.Size(235, 40);
            this.button_RstChangePass.TabIndex = 0;
            this.button_RstChangePass.Tag = "304";
            this.button_RstChangePass.Text = "تغییر رمز بازیابی";
            this.button_RstChangePass.Click += new System.EventHandler(this.button_RstChangePass_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(12, 297);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(602, 4);
            this.panel4.TabIndex = 13;
            // 
            // tabItem_SetBkpRst
            // 
            this.tabItem_SetBkpRst.AttachedControl = this.tabControlPanel_SetBkpRst;
            this.tabItem_SetBkpRst.Name = "tabItem_SetBkpRst";
            this.tabItem_SetBkpRst.Text = "tabItem_SetBkpRst";
            // 
            // tabControlPanel_SMS
            // 
            this.tabControlPanel_SMS.Controls.Add(this.mssGroupPanel7);
            this.tabControlPanel_SMS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel_SMS.Location = new System.Drawing.Point(0, 4);
            this.tabControlPanel_SMS.Name = "tabControlPanel_SMS";
            this.tabControlPanel_SMS.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel_SMS.Size = new System.Drawing.Size(632, 526);
            this.tabControlPanel_SMS.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(254)))));
            this.tabControlPanel_SMS.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(188)))), ((int)(((byte)(227)))));
            this.tabControlPanel_SMS.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel_SMS.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.tabControlPanel_SMS.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel_SMS.Style.GradientAngle = 90;
            this.tabControlPanel_SMS.TabIndex = 8;
            this.tabControlPanel_SMS.TabItem = this.tabItem_SMS;
            // 
            // mssGroupPanel7
            // 
            this.mssGroupPanel7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mssGroupPanel7.CanvasColor = System.Drawing.SystemColors.Control;
            this.mssGroupPanel7.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.mssGroupPanel7.Controls.Add(this.button_SMSSetting);
            this.mssGroupPanel7.Location = new System.Drawing.Point(73, 122);
            this.mssGroupPanel7.Name = "mssGroupPanel7";
            this.mssGroupPanel7.Size = new System.Drawing.Size(487, 296);
            // 
            // 
            // 
            this.mssGroupPanel7.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.mssGroupPanel7.Style.BackColorGradientAngle = 90;
            this.mssGroupPanel7.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.mssGroupPanel7.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.mssGroupPanel7.Style.BorderBottomWidth = 1;
            this.mssGroupPanel7.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.mssGroupPanel7.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.mssGroupPanel7.Style.BorderLeftWidth = 1;
            this.mssGroupPanel7.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.mssGroupPanel7.Style.BorderRightWidth = 1;
            this.mssGroupPanel7.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.mssGroupPanel7.Style.BorderTopWidth = 1;
            this.mssGroupPanel7.Style.CornerDiameter = 4;
            this.mssGroupPanel7.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.mssGroupPanel7.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.mssGroupPanel7.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.mssGroupPanel7.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.mssGroupPanel7.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.mssGroupPanel7.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mssGroupPanel7.TabIndex = 16;
            // 
            // button_SMSSetting
            // 
            this.button_SMSSetting.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.button_SMSSetting.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_SMSSetting.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.button_SMSSetting.Location = new System.Drawing.Point(105, 111);
            this.button_SMSSetting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_SMSSetting.Name = "button_SMSSetting";
            this.button_SMSSetting.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button_SMSSetting.Size = new System.Drawing.Size(285, 40);
            this.button_SMSSetting.TabIndex = 0;
            this.button_SMSSetting.Text = "تنظیمات SMS";
            this.button_SMSSetting.Click += new System.EventHandler(this.button_SMSSetting_Click);
            // 
            // tabItem_SMS
            // 
            this.tabItem_SMS.AttachedControl = this.tabControlPanel_SMS;
            this.tabItem_SMS.Name = "tabItem_SMS";
            this.tabItem_SMS.Text = "tabItem1";
            // 
            // mssGroupPanel9
            // 
            this.mssGroupPanel9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mssGroupPanel9.BackColor = System.Drawing.Color.Transparent;
            this.mssGroupPanel9.CanvasColor = System.Drawing.SystemColors.Control;
            this.mssGroupPanel9.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.mssGroupPanel9.Controls.Add(this.mssLabel20);
            this.mssGroupPanel9.Controls.Add(this.IntBoxCostInsurancePercent);
            this.mssGroupPanel9.Controls.Add(this.mssLabel28);
            this.mssGroupPanel9.Location = new System.Drawing.Point(54, 489);
            this.mssGroupPanel9.Name = "mssGroupPanel9";
            this.mssGroupPanel9.Size = new System.Drawing.Size(551, 33);
            // 
            // 
            // 
            this.mssGroupPanel9.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.mssGroupPanel9.Style.BackColorGradientAngle = 90;
            this.mssGroupPanel9.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.mssGroupPanel9.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.mssGroupPanel9.Style.BorderBottomWidth = 1;
            this.mssGroupPanel9.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.mssGroupPanel9.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.mssGroupPanel9.Style.BorderLeftWidth = 1;
            this.mssGroupPanel9.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.mssGroupPanel9.Style.BorderRightWidth = 1;
            this.mssGroupPanel9.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.mssGroupPanel9.Style.BorderTopWidth = 1;
            this.mssGroupPanel9.Style.CornerDiameter = 4;
            this.mssGroupPanel9.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.mssGroupPanel9.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.mssGroupPanel9.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.mssGroupPanel9.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.mssGroupPanel9.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.mssGroupPanel9.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mssGroupPanel9.TabIndex = 4;
            // 
            // mssLabel20
            // 
            this.mssLabel20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mssLabel20.AutoSize = true;
            this.mssLabel20.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.mssLabel20.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mssLabel20.Font = new System.Drawing.Font("Tahoma", 8F);
            this.mssLabel20.ForeColor = System.Drawing.Color.Black;
            this.mssLabel20.Location = new System.Drawing.Point(331, 8);
            this.mssLabel20.Name = "mssLabel20";
            this.mssLabel20.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mssLabel20.Size = new System.Drawing.Size(79, 15);
            this.mssLabel20.TabIndex = 29;
            this.mssLabel20.Text = "درصد سهم بیمه:";
            // 
            // IntBoxCostInsurancePercent
            // 
            this.IntBoxCostInsurancePercent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IntBoxCostInsurancePercent.Location = new System.Drawing.Point(265, 1);
            this.IntBoxCostInsurancePercent.MaxLength = 100;
            this.IntBoxCostInsurancePercent.Name = "IntBoxCostInsurancePercent";
            this.IntBoxCostInsurancePercent.Size = new System.Drawing.Size(63, 22);
            this.IntBoxCostInsurancePercent.TabIndex = 30;
            this.IntBoxCostInsurancePercent.Text = "0.00";
            this.IntBoxCostInsurancePercent.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
            this.IntBoxCostInsurancePercent.Value = 0D;
            this.IntBoxCostInsurancePercent.ValueType = Janus.Windows.GridEX.NumericEditValueType.Double;
            // 
            // mssLabel28
            // 
            this.mssLabel28.AutoSize = true;
            this.mssLabel28.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.mssLabel28.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mssLabel28.Font = new System.Drawing.Font("Tahoma", 8F);
            this.mssLabel28.ForeColor = System.Drawing.Color.Black;
            this.mssLabel28.Location = new System.Drawing.Point(216, 7);
            this.mssLabel28.Name = "mssLabel28";
            this.mssLabel28.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mssLabel28.Size = new System.Drawing.Size(25, 15);
            this.mssLabel28.TabIndex = 28;
            this.mssLabel28.Text = "درصد";
            // 
            // Setting_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.ClientSize = new System.Drawing.Size(823, 625);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Setting_frm";
            this.ShowInTaskbar = false;
            this.Text = "تنظیمات";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Setting_frm_FormClosing);
            this.Load += new System.EventHandler(this.Setting_frm_Load);
            this.mssGroupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabControl_Setting)).EndInit();
            this.tabControl_Setting.ResumeLayout(false);
            this.tabControlPanel_SetSystem.ResumeLayout(false);
            this.mssGroupPanel8.ResumeLayout(false);
            this.mssGroupPanel8.PerformLayout();
            this.mssGroupPanel6.ResumeLayout(false);
            this.mssGroupPanel6.PerformLayout();
            this.mssGroupPanel3.ResumeLayout(false);
            this.mssGroupPanel3.PerformLayout();
            this.mssGroupPanel2.ResumeLayout(false);
            this.mssGroupPanel2.PerformLayout();
            this.tabControlPanel_SetBkpRst.ResumeLayout(false);
            this.mssGroupPanel5.ResumeLayout(false);
            this.mssGroupPanel5.PerformLayout();
            this.mssGroupPanel4.ResumeLayout(false);
            this.tabControlPanel_SMS.ResumeLayout(false);
            this.mssGroupPanel7.ResumeLayout(false);
            this.mssGroupPanel9.ResumeLayout(false);
            this.mssGroupPanel9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList_Setting;
        public MKH.Library.Control.MSSTreeView treeView_Setting;
        private DevComponents.DotNetBar.TabControl tabControl_Setting;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel_SetSystem;
        private DevComponents.DotNetBar.TabItem tabItem_SetSystem;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel_SetBkpRst;
        private MKH.Library.Control.MSSButton button_RstChangePass;
        private MKH.Library.Control.MSSCheckBox radioButton_BkpNo;
        private MKH.Library.Control.MSSCheckBox radioButton_BkpAuto;
        private MKH.Library.Control.MSSCheckBox radioButton_BkpNonAuto;
        private MKH.Library.Control.MSSPanel panel4;
        private DevComponents.DotNetBar.TabItem tabItem_SetBkpRst;
        private MKH.Library.Control.MSSGroupPanel mssGroupPanel2;
        private MKH.Library.Control.MSSGroupPanel mssGroupPanel5;
        private MKH.Library.Control.MSSGroupPanel mssGroupPanel4;
        private MKH.Library.Control.MSSLabel mssLabel1;
        private MKH.Library.Control.MSSGroupPanel mssGroupPanel3;
        private MKH.Library.Control.MSSTextBox TextBoxBkpAuto;
        private MKH.Library.Control.MSSTextBox TextBoxFileSavingPhysiotherapy;
        private MKH.Library.Control.MSSLabel mssLabel14;
        private MKH.Library.Control.MSSLabel mssLabel11;
        private MKH.Library.Control.MSSLabel mssLabel10;
        private MKH.Library.Control.MSSIntBox IntBoxCostReqInsuPhsiotraphy;
        private MKH.Library.Control.MSSLabel mssLabel15;
        private MKH.Library.Control.MSSLabel mssLabel17;
        private MKH.Library.Control.MSSIntBox IntBoxCostCompanyCarePercent;
        private MKH.Library.Control.MSSTextBox TextBoxFileSavingCare;
        private MKH.Library.Control.MSSLabel mssLabel18;
        private MKH.Library.Control.MSSTextBox TextBoxFileSavingPatient;
        private MKH.Library.Control.MSSLabel mssLabel19;
        private MKH.Library.Control.MSSLabel mssLabel27;
        private MKH.Library.Control.MSSIntBox IntBoxCareDaysDefault;
        private MKH.Library.Control.MSSLabel mssLabel24;
        private MKH.Library.Control.MSSLabel mssLabel26;
        private MKH.Library.Control.MSSLabel mssLabel23;
        private MKH.Library.Control.MSSLabel mssLabel25;
        private MKH.Library.Control.MSSLabel mssLabel21;
        private MKH.Library.Control.MSSLabel mssLabel22;
        private MKH.Library.Control.MSSIntBox IntBoxCareShift1;
        private MKH.Library.Control.MSSIntBox IntBoxCareShift3;
        private MKH.Library.Control.MSSIntBox IntBoxCareShift2;
        private MKH.Library.Control.MSSGroupPanel mssGroupPanel6;
        private MKH.Library.Control.MSSTextBox TextBoxFileSavingHealth;
        private MKH.Library.Control.MSSLabel mssLabel7;
        private MKH.Library.Control.MSSLabel mssLabel5;
        private MKH.Library.Control.MSSIntBox IntBoxCostCompanyPhsiotraphyPercent;
        private MKH.Library.Control.MSSLabel mssLabel4;
        private MKH.Library.Control.MSSIntBox IntBoxCostCompanyHealthPercent;
        private MKH.Library.Control.MSSLabel mssLabel6;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel_SMS;
        private MKH.Library.Control.MSSGroupPanel mssGroupPanel7;
        private MKH.Library.Control.MSSButton button_SMSSetting;
        private DevComponents.DotNetBar.TabItem tabItem_SMS;
        private MKH.Library.Control.MSSGroupPanel mssGroupPanel8;
        private MKH.Library.Control.MSSLabel mssLabel2;
        private MKH.Library.Control.MSSIntBox IntBoxCostCompanyVisitPercent;
        private MKH.Library.Control.MSSLabel mssLabel3;
        private MKH.Library.Control.MSSIntBox IntBoxCostReqInsuVisitAdd;
        private MKH.Library.Control.MSSLabel mssLabel9;
        private MKH.Library.Control.MSSTextBox TextBoxFileSavingVisit;
        private MKH.Library.Control.MSSLabel mssLabel12;
        private MKH.Library.Control.MSSLabel mssLabel8;
        private MKH.Library.Control.MSSLabel mssLabel16;
        private MKH.Library.Control.MSSIntBox IntBoxCostReqInsuVisitEven;
        private MKH.Library.Control.MSSLabel mssLabel13;
        private MKH.Library.Control.MSSButton ButtonClearCash;
        private MKH.Library.Control.MSSGroupPanel mssGroupPanel9;
        private MKH.Library.Control.MSSLabel mssLabel20;
        private MKH.Library.Control.MSSIntBox IntBoxCostInsurancePercent;
        private MKH.Library.Control.MSSLabel mssLabel28;
    }
}