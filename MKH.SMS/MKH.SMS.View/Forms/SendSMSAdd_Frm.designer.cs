
using MKH.Library.Control;
namespace MKH.SMS.View.Forms
{
    partial class SendSMSAdd_Frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendSMSAdd_Frm));
            Janus.Windows.GridEX.GridEXLayout GridexViewSetForSMS_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout GridexViewPerson_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.mssLabel9 = new MKH.Library.Control.MSSLabel(this.components);
            this.TextBoxMessage = new MKH.Library.Control.MSSTextBox(this.components);
            this.mssPanel2 = new MKH.Library.Control.MSSPanel(this.components);
            this.ButtonKey = new MKH.Library.Control.MSSButton(this.components);
            this.mssPanel3 = new MKH.Library.Control.MSSPanel(this.components);
            this.ButtonSetForListSMS = new MKH.Library.Control.MSSButton(this.components);
            this.mssPanel5 = new MKH.Library.Control.MSSPanel(this.components);
            this.GridexViewSetForSMS = new MKH.Library.Control.MSSGridexView();
            this.mssPanel4 = new MKH.Library.Control.MSSPanel(this.components);
            this.GridexViewPerson = new MKH.Library.Control.MSSGridexView();
            this.mssLabel2 = new MKH.Library.Control.MSSLabel(this.components);
            this.mssLabel1 = new MKH.Library.Control.MSSLabel(this.components);
            this.mssExpandableSplitter1 = new MKH.Library.Control.MSSExpandableSplitter(this.components);
            this.mssGroupPanel1.SuspendLayout();
            this.mssPanel2.SuspendLayout();
            this.mssPanel3.SuspendLayout();
            this.mssPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridexViewSetForSMS)).BeginInit();
            this.mssPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridexViewPerson)).BeginInit();
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
            this.ribbonBarNewBar.Location = new System.Drawing.Point(0, 584);
            this.ribbonBarNewBar.Size = new System.Drawing.Size(902, 57);
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
            this.mssGroupPanel1.Controls.Add(this.mssExpandableSplitter1);
            this.mssGroupPanel1.Controls.Add(this.mssPanel2);
            this.mssGroupPanel1.Controls.Add(this.mssPanel3);
            this.mssGroupPanel1.Size = new System.Drawing.Size(902, 550);
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
            this.buttonItemOK.Image = ((System.Drawing.Image)(resources.GetObject("buttonItemOK.Image")));
            this.buttonItemOK.Text = "ارسال";
            this.buttonItemOK.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // mssLabel9
            // 
            this.mssLabel9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mssLabel9.AutoSize = true;
            this.mssLabel9.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.mssLabel9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mssLabel9.Font = new System.Drawing.Font("Tahoma", 8F);
            this.mssLabel9.ForeColor = System.Drawing.Color.Black;
            this.mssLabel9.Location = new System.Drawing.Point(259, 12);
            this.mssLabel9.Name = "mssLabel9";
            this.mssLabel9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mssLabel9.Size = new System.Drawing.Size(43, 15);
            this.mssLabel9.TabIndex = 2;
            this.mssLabel9.Text = "متن پیام:";
            // 
            // TextBoxMessage
            // 
            this.TextBoxMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.TextBoxMessage.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxMessage.Font = new System.Drawing.Font("Tahoma", 8F);
            this.TextBoxMessage.Location = new System.Drawing.Point(51, 33);
            this.TextBoxMessage.Multiline = true;
            this.TextBoxMessage.Name = "TextBoxMessage";
            this.TextBoxMessage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TextBoxMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBoxMessage.Size = new System.Drawing.Size(295, 479);
            this.TextBoxMessage.TabIndex = 1;
            // 
            // mssPanel2
            // 
            this.mssPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.mssPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.mssPanel2.Controls.Add(this.ButtonKey);
            this.mssPanel2.Controls.Add(this.TextBoxMessage);
            this.mssPanel2.Controls.Add(this.mssLabel9);
            this.mssPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mssPanel2.Location = new System.Drawing.Point(570, 0);
            this.mssPanel2.Name = "mssPanel2";
            this.mssPanel2.Size = new System.Drawing.Size(326, 544);
            this.mssPanel2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.mssPanel2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.mssPanel2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.mssPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.mssPanel2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.mssPanel2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.mssPanel2.Style.GradientAngle = 90;
            this.mssPanel2.TabIndex = 1;
            // 
            // ButtonKey
            // 
            this.ButtonKey.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonKey.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.ButtonKey.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ButtonKey.Location = new System.Drawing.Point(15, 33);
            this.ButtonKey.Name = "ButtonKey";
            this.ButtonKey.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ButtonKey.Size = new System.Drawing.Size(28, 28);
            this.ButtonKey.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonKey.TabIndex = 9;
            this.ButtonKey.Text = "+";
            this.ButtonKey.Click += new System.EventHandler(this.ButtonKey_Click);
            // 
            // mssPanel3
            // 
            this.mssPanel3.CanvasColor = System.Drawing.SystemColors.Control;
            this.mssPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.mssPanel3.Controls.Add(this.ButtonSetForListSMS);
            this.mssPanel3.Controls.Add(this.mssPanel5);
            this.mssPanel3.Controls.Add(this.mssPanel4);
            this.mssPanel3.Controls.Add(this.mssLabel2);
            this.mssPanel3.Controls.Add(this.mssLabel1);
            this.mssPanel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.mssPanel3.Location = new System.Drawing.Point(0, 0);
            this.mssPanel3.Name = "mssPanel3";
            this.mssPanel3.Size = new System.Drawing.Size(570, 544);
            this.mssPanel3.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.mssPanel3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.mssPanel3.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.mssPanel3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.mssPanel3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.mssPanel3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.mssPanel3.Style.GradientAngle = 90;
            this.mssPanel3.TabIndex = 2;
            // 
            // ButtonSetForListSMS
            // 
            this.ButtonSetForListSMS.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonSetForListSMS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ButtonSetForListSMS.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.ButtonSetForListSMS.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ButtonSetForListSMS.Image = ((System.Drawing.Image)(resources.GetObject("ButtonSetForListSMS.Image")));
            this.ButtonSetForListSMS.Location = new System.Drawing.Point(180, 276);
            this.ButtonSetForListSMS.Name = "ButtonSetForListSMS";
            this.ButtonSetForListSMS.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ButtonSetForListSMS.Size = new System.Drawing.Size(201, 31);
            this.ButtonSetForListSMS.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonSetForListSMS.TabIndex = 1;
            this.ButtonSetForListSMS.Text = "ارسال به لیست اصلی";
            this.ButtonSetForListSMS.Click += new System.EventHandler(this.ButtonSetForListSMS_Click);
            // 
            // mssPanel5
            // 
            this.mssPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mssPanel5.CanvasColor = System.Drawing.SystemColors.Control;
            this.mssPanel5.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.mssPanel5.Controls.Add(this.GridexViewSetForSMS);
            this.mssPanel5.Location = new System.Drawing.Point(20, 334);
            this.mssPanel5.Name = "mssPanel5";
            this.mssPanel5.Size = new System.Drawing.Size(534, 190);
            this.mssPanel5.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.mssPanel5.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.mssPanel5.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.mssPanel5.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.mssPanel5.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.mssPanel5.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.mssPanel5.Style.GradientAngle = 90;
            this.mssPanel5.TabIndex = 8;
            this.mssPanel5.Text = "mssPanel5";
            // 
            // GridexViewSetForSMS
            // 
            this.GridexViewSetForSMS.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            this.GridexViewSetForSMS.AllowColumnDrag = false;
            this.GridexViewSetForSMS.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            this.GridexViewSetForSMS.AlternatingRowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridexViewSetForSMS.AutoEdit = true;
            this.GridexViewSetForSMS.BoundMode = Janus.Windows.GridEX.BoundMode.Unbound;
            this.GridexViewSetForSMS.BuiltInTextsData = resources.GetString("GridexViewSetForSMS.BuiltInTextsData");
            this.GridexViewSetForSMS.CardViewGridlines = Janus.Windows.GridEX.CardViewGridlines.Both;
            this.GridexViewSetForSMS.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            GridexViewSetForSMS_DesignTimeLayout.LayoutString = resources.GetString("GridexViewSetForSMS_DesignTimeLayout.LayoutString");
            this.GridexViewSetForSMS.DesignTimeLayout = GridexViewSetForSMS_DesignTimeLayout;
            this.GridexViewSetForSMS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridexViewSetForSMS.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.GridexViewSetForSMS.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.GridexViewSetForSMS.Font = new System.Drawing.Font("Tahoma", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.GridexViewSetForSMS.GroupByBoxVisible = false;
            this.GridexViewSetForSMS.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridexViewSetForSMS.Location = new System.Drawing.Point(0, 0);
            this.GridexViewSetForSMS.Name = "GridexViewSetForSMS";
            this.GridexViewSetForSMS.RecordNavigator = true;
            this.GridexViewSetForSMS.RowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridexViewSetForSMS.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition;
            this.GridexViewSetForSMS.RowHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridexViewSetForSMS.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.GridexViewSetForSMS.Size = new System.Drawing.Size(534, 190);
            this.GridexViewSetForSMS.TabIndex = 2;
            this.GridexViewSetForSMS.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.GridexViewSetForSMS.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010;
            // 
            // mssPanel4
            // 
            this.mssPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mssPanel4.CanvasColor = System.Drawing.SystemColors.Control;
            this.mssPanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.mssPanel4.Controls.Add(this.GridexViewPerson);
            this.mssPanel4.Location = new System.Drawing.Point(20, 24);
            this.mssPanel4.Name = "mssPanel4";
            this.mssPanel4.Size = new System.Drawing.Size(534, 240);
            this.mssPanel4.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.mssPanel4.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.mssPanel4.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.mssPanel4.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.mssPanel4.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.mssPanel4.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.mssPanel4.Style.GradientAngle = 90;
            this.mssPanel4.TabIndex = 7;
            this.mssPanel4.Text = "mssPanel4";
            // 
            // GridexViewPerson
            // 
            this.GridexViewPerson.AlternatingRowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridexViewPerson.BuiltInTextsData = resources.GetString("GridexViewPerson.BuiltInTextsData");
            this.GridexViewPerson.CardViewGridlines = Janus.Windows.GridEX.CardViewGridlines.Both;
            this.GridexViewPerson.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            GridexViewPerson_DesignTimeLayout.LayoutString = resources.GetString("GridexViewPerson_DesignTimeLayout.LayoutString");
            this.GridexViewPerson.DesignTimeLayout = GridexViewPerson_DesignTimeLayout;
            this.GridexViewPerson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridexViewPerson.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.GridexViewPerson.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.GridexViewPerson.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.GridexViewPerson.Font = new System.Drawing.Font("Tahoma", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.GridexViewPerson.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridexViewPerson.Location = new System.Drawing.Point(0, 0);
            this.GridexViewPerson.Name = "GridexViewPerson";
            this.GridexViewPerson.RecordNavigator = true;
            this.GridexViewPerson.RowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridexViewPerson.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition;
            this.GridexViewPerson.RowHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridexViewPerson.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.GridexViewPerson.Size = new System.Drawing.Size(534, 240);
            this.GridexViewPerson.TabIndex = 0;
            this.GridexViewPerson.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.GridexViewPerson.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010;
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
            this.mssLabel2.Location = new System.Drawing.Point(260, 313);
            this.mssLabel2.Name = "mssLabel2";
            this.mssLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mssLabel2.Size = new System.Drawing.Size(294, 15);
            this.mssLabel2.TabIndex = 4;
            this.mssLabel2.Text = "لیست گیرندگان (شماره ها را با Enter اضافه و با Del حذف نمایید):";
            // 
            // mssLabel1
            // 
            this.mssLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mssLabel1.AutoSize = true;
            this.mssLabel1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.mssLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mssLabel1.Font = new System.Drawing.Font("Tahoma", 8F);
            this.mssLabel1.ForeColor = System.Drawing.Color.Black;
            this.mssLabel1.Location = new System.Drawing.Point(497, 3);
            this.mssLabel1.Name = "mssLabel1";
            this.mssLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mssLabel1.Size = new System.Drawing.Size(57, 15);
            this.mssLabel1.TabIndex = 3;
            this.mssLabel1.Text = "لیست افراد:";
            // 
            // mssExpandableSplitter1
            // 
            this.mssExpandableSplitter1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.mssExpandableSplitter1.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.mssExpandableSplitter1.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.mssExpandableSplitter1.ExpandFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.mssExpandableSplitter1.ExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.mssExpandableSplitter1.ExpandLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mssExpandableSplitter1.ExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.mssExpandableSplitter1.ForeColor = System.Drawing.Color.Black;
            this.mssExpandableSplitter1.GripDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mssExpandableSplitter1.GripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.mssExpandableSplitter1.GripLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.mssExpandableSplitter1.GripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.mssExpandableSplitter1.HotBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(151)))), ((int)(((byte)(61)))));
            this.mssExpandableSplitter1.HotBackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(94)))));
            this.mssExpandableSplitter1.HotBackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground2;
            this.mssExpandableSplitter1.HotBackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground;
            this.mssExpandableSplitter1.HotExpandFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.mssExpandableSplitter1.HotExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.mssExpandableSplitter1.HotExpandLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mssExpandableSplitter1.HotExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.mssExpandableSplitter1.HotGripDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.mssExpandableSplitter1.HotGripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.mssExpandableSplitter1.HotGripLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.mssExpandableSplitter1.HotGripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.mssExpandableSplitter1.Location = new System.Drawing.Point(570, 0);
            this.mssExpandableSplitter1.Name = "mssExpandableSplitter1";
            this.mssExpandableSplitter1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mssExpandableSplitter1.Size = new System.Drawing.Size(6, 544);
            this.mssExpandableSplitter1.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007;
            this.mssExpandableSplitter1.TabIndex = 66;
            this.mssExpandableSplitter1.TabStop = false;
            // 
            // SendSMSAdd_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(902, 641);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(300, 197);
            this.Name = "SendSMSAdd_Frm";
            this.Text = "ارسال SMS";
            this.Load += new System.EventHandler(this.SendSMSAdd_Frm_Load);
            this.mssGroupPanel1.ResumeLayout(false);
            this.mssPanel2.ResumeLayout(false);
            this.mssPanel2.PerformLayout();
            this.mssPanel3.ResumeLayout(false);
            this.mssPanel3.PerformLayout();
            this.mssPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridexViewSetForSMS)).EndInit();
            this.mssPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridexViewPerson)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MSSTextBox TextBoxMessage;
        private MSSLabel mssLabel9;
        private MSSPanel mssPanel2;
        private MSSPanel mssPanel3;
        private MSSExpandableSplitter mssExpandableSplitter1;
        private MSSGridexView GridexViewPerson;
        private MSSLabel mssLabel1;
        private MSSLabel mssLabel2;
        private MSSPanel mssPanel4;
        private MSSPanel mssPanel5;
        private MSSGridexView GridexViewSetForSMS;
        private MSSButton ButtonSetForListSMS;
        private MSSButton ButtonKey;


    }
}
