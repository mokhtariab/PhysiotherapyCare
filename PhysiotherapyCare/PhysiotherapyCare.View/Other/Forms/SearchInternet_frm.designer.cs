namespace PhysiotherapyCare.Other.Forms
{
    partial class SearchInternet_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchInternet_frm));
            this.panel_Text = new DevComponents.DotNetBar.PanelEx();
            this.textBox_SearchText = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.ribbonBar_ieSearch = new DevComponents.DotNetBar.RibbonBar();
            this.buttonItem_MapSearch = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem_ieSearch = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem_Cancel = new DevComponents.DotNetBar.ButtonItem();
            this.panel_Part = new DevComponents.DotNetBar.PanelEx();
            this.comboBox_Part = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboBox_State = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboBox_Country = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboBox_City = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.label_Country = new System.Windows.Forms.Label();
            this.label_State = new System.Windows.Forms.Label();
            this.label_City = new System.Windows.Forms.Label();
            this.label_Part = new System.Windows.Forms.Label();
            this.bar_MainView = new DevComponents.DotNetBar.Bar();
            this.panel_SelectEngine = new DevComponents.DotNetBar.PanelEx();
            this.comboBox_SelEngine = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.panel_Text.SuspendLayout();
            this.panel_Part.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bar_MainView)).BeginInit();
            this.panel_SelectEngine.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Text
            // 
            this.panel_Text.Controls.Add(this.textBox_SearchText);
            this.panel_Text.Location = new System.Drawing.Point(4, 88);
            this.panel_Text.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_Text.Name = "panel_Text";
            this.panel_Text.Size = new System.Drawing.Size(443, 135);
            this.panel_Text.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panel_Text.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.panel_Text.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.panel_Text.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panel_Text.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panel_Text.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panel_Text.Style.GradientAngle = 90;
            this.panel_Text.Style.LineAlignment = System.Drawing.StringAlignment.Near;
            this.panel_Text.TabIndex = 11;
            this.panel_Text.Text = "متن";
            // 
            // textBox_SearchText
            // 
            this.textBox_SearchText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.textBox_SearchText.Border.Class = "TextBoxBorder";
            this.textBox_SearchText.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBox_SearchText.ForeColor = System.Drawing.Color.Black;
            this.textBox_SearchText.Location = new System.Drawing.Point(27, 21);
            this.textBox_SearchText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_SearchText.MaxLength = 2000;
            this.textBox_SearchText.Multiline = true;
            this.textBox_SearchText.Name = "textBox_SearchText";
            this.textBox_SearchText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_SearchText.Size = new System.Drawing.Size(388, 103);
            this.textBox_SearchText.TabIndex = 0;
            this.textBox_SearchText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ribbonBar_ieSearch
            // 
            this.ribbonBar_ieSearch.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar_ieSearch.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar_ieSearch.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar_ieSearch.ContainerControlProcessDialogKey = true;
            this.ribbonBar_ieSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbonBar_ieSearch.HorizontalItemAlignment = DevComponents.DotNetBar.eHorizontalItemsAlignment.Right;
            this.ribbonBar_ieSearch.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem_MapSearch,
            this.buttonItem_ieSearch,
            this.buttonItem_Cancel});
            this.ribbonBar_ieSearch.Location = new System.Drawing.Point(0, 0);
            this.ribbonBar_ieSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbonBar_ieSearch.Name = "ribbonBar_ieSearch";
            this.ribbonBar_ieSearch.Size = new System.Drawing.Size(448, 82);
            this.ribbonBar_ieSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBar_ieSearch.TabIndex = 10;
            // 
            // 
            // 
            this.ribbonBar_ieSearch.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar_ieSearch.TitleStyle.Font = new System.Drawing.Font("Tahoma", 6.792453F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            // 
            // 
            // 
            this.ribbonBar_ieSearch.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar_ieSearch.TitleVisible = false;
            // 
            // buttonItem_MapSearch
            // 
            this.buttonItem_MapSearch.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem_MapSearch.FixedSize = new System.Drawing.Size(120, 60);
            this.buttonItem_MapSearch.HotFontBold = true;
            this.buttonItem_MapSearch.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem_MapSearch.Image")));
            this.buttonItem_MapSearch.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Default;
            this.buttonItem_MapSearch.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem_MapSearch.Name = "buttonItem_MapSearch";
            this.buttonItem_MapSearch.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F2);
            this.buttonItem_MapSearch.SubItemsExpandWidth = 14;
            this.buttonItem_MapSearch.Text = "جستجوی نقشه";
            this.buttonItem_MapSearch.Tooltip = "F2";
            this.buttonItem_MapSearch.Click += new System.EventHandler(this.buttonItem_MapSearch_Click);
            // 
            // buttonItem_ieSearch
            // 
            this.buttonItem_ieSearch.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem_ieSearch.FixedSize = new System.Drawing.Size(120, 60);
            this.buttonItem_ieSearch.HotFontBold = true;
            this.buttonItem_ieSearch.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem_ieSearch.Image")));
            this.buttonItem_ieSearch.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem_ieSearch.Name = "buttonItem_ieSearch";
            this.buttonItem_ieSearch.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F2);
            this.buttonItem_ieSearch.SubItemsExpandWidth = 14;
            this.buttonItem_ieSearch.Text = "جستجو";
            this.buttonItem_ieSearch.Tooltip = "F2";
            this.buttonItem_ieSearch.Visible = false;
            this.buttonItem_ieSearch.Click += new System.EventHandler(this.buttonItem_ieSearch_Click);
            // 
            // buttonItem_Cancel
            // 
            this.buttonItem_Cancel.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem_Cancel.FixedSize = new System.Drawing.Size(100, 60);
            this.buttonItem_Cancel.HotFontBold = true;
            this.buttonItem_Cancel.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem_Cancel.Image")));
            this.buttonItem_Cancel.ImagePaddingHorizontal = 20;
            this.buttonItem_Cancel.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem_Cancel.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            this.buttonItem_Cancel.Name = "buttonItem_Cancel";
            this.buttonItem_Cancel.SplitButton = true;
            this.buttonItem_Cancel.Stretch = true;
            this.buttonItem_Cancel.SubItemsExpandWidth = 14;
            this.buttonItem_Cancel.Text = "انصراف";
            this.buttonItem_Cancel.Tooltip = "Esc";
            this.buttonItem_Cancel.Click += new System.EventHandler(this.buttonItem_Cancel_Click);
            // 
            // panel_Part
            // 
            this.panel_Part.Controls.Add(this.comboBox_Part);
            this.panel_Part.Controls.Add(this.comboBox_State);
            this.panel_Part.Controls.Add(this.comboBox_Country);
            this.panel_Part.Controls.Add(this.comboBox_City);
            this.panel_Part.Controls.Add(this.label_Country);
            this.panel_Part.Controls.Add(this.label_State);
            this.panel_Part.Controls.Add(this.label_City);
            this.panel_Part.Controls.Add(this.label_Part);
            this.panel_Part.Location = new System.Drawing.Point(4, 86);
            this.panel_Part.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_Part.Name = "panel_Part";
            this.panel_Part.Size = new System.Drawing.Size(443, 67);
            this.panel_Part.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panel_Part.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.panel_Part.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.panel_Part.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panel_Part.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panel_Part.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panel_Part.Style.GradientAngle = 90;
            this.panel_Part.Style.LineAlignment = System.Drawing.StringAlignment.Near;
            this.panel_Part.TabIndex = 12;
            this.panel_Part.Text = "منطقه جستجو";
            this.panel_Part.Visible = false;
            // 
            // comboBox_Part
            // 
            this.comboBox_Part.DisplayMember = "PartName_Fa";
            this.comboBox_Part.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBox_Part.DropDownHeight = 100;
            this.comboBox_Part.DropDownWidth = 200;
            this.comboBox_Part.FocusHighlightEnabled = true;
            this.comboBox_Part.Font = new System.Drawing.Font("Tahoma", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.comboBox_Part.ForeColor = System.Drawing.Color.Black;
            this.comboBox_Part.IntegralHeight = false;
            this.comboBox_Part.ItemHeight = 20;
            this.comboBox_Part.Location = new System.Drawing.Point(6, 35);
            this.comboBox_Part.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox_Part.Name = "comboBox_Part";
            this.comboBox_Part.PreventEnterBeep = true;
            this.comboBox_Part.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox_Part.Size = new System.Drawing.Size(157, 26);
            this.comboBox_Part.TabIndex = 51;
            this.comboBox_Part.Tag = "0";
            this.comboBox_Part.ValueMember = "PartID";
            this.comboBox_Part.SelectedIndexChanged += new System.EventHandler(this.comboBox_Part_SelectedIndexChanged);
            this.comboBox_Part.SelectedValueChanged += new System.EventHandler(this.comboBox_Part_SelectedIndexChanged);
            this.comboBox_Part.Enter += new System.EventHandler(this.comboBox_Part_Enter);
            // 
            // comboBox_State
            // 
            this.comboBox_State.DisplayMember = "StateName_Fa";
            this.comboBox_State.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBox_State.DropDownHeight = 100;
            this.comboBox_State.DropDownWidth = 100;
            this.comboBox_State.FocusHighlightColor = System.Drawing.Color.Empty;
            this.comboBox_State.Font = new System.Drawing.Font("Tahoma", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.comboBox_State.ForeColor = System.Drawing.Color.Black;
            this.comboBox_State.IntegralHeight = false;
            this.comboBox_State.ItemHeight = 20;
            this.comboBox_State.Location = new System.Drawing.Point(257, 35);
            this.comboBox_State.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox_State.Name = "comboBox_State";
            this.comboBox_State.PreventEnterBeep = true;
            this.comboBox_State.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox_State.Size = new System.Drawing.Size(84, 26);
            this.comboBox_State.TabIndex = 49;
            this.comboBox_State.Tag = "0";
            this.comboBox_State.ValueMember = "StateID";
            this.comboBox_State.WatermarkColor = System.Drawing.Color.Empty;
            this.comboBox_State.Enter += new System.EventHandler(this.comboBox_State_Enter);
            this.comboBox_State.Leave += new System.EventHandler(this.comboBox_State_Leave);
            // 
            // comboBox_Country
            // 
            this.comboBox_Country.DisplayMember = "CountryName_Fa";
            this.comboBox_Country.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBox_Country.DropDownHeight = 100;
            this.comboBox_Country.DropDownWidth = 100;
            this.comboBox_Country.FocusHighlightColor = System.Drawing.Color.Empty;
            this.comboBox_Country.Font = new System.Drawing.Font("Tahoma", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.comboBox_Country.ForeColor = System.Drawing.Color.Black;
            this.comboBox_Country.IntegralHeight = false;
            this.comboBox_Country.ItemHeight = 20;
            this.comboBox_Country.Location = new System.Drawing.Point(347, 35);
            this.comboBox_Country.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox_Country.Name = "comboBox_Country";
            this.comboBox_Country.PreventEnterBeep = true;
            this.comboBox_Country.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox_Country.Size = new System.Drawing.Size(84, 26);
            this.comboBox_Country.TabIndex = 48;
            this.comboBox_Country.Tag = "0";
            this.comboBox_Country.ValueMember = "CountryID";
            this.comboBox_Country.WatermarkColor = System.Drawing.Color.Empty;
            this.comboBox_Country.Enter += new System.EventHandler(this.comboBox_Country_Enter);
            this.comboBox_Country.Leave += new System.EventHandler(this.comboBox_Country_Leave);
            // 
            // comboBox_City
            // 
            this.comboBox_City.DisplayMember = "CityName_Fa";
            this.comboBox_City.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBox_City.DropDownHeight = 100;
            this.comboBox_City.DropDownWidth = 100;
            this.comboBox_City.FocusHighlightColor = System.Drawing.Color.Empty;
            this.comboBox_City.Font = new System.Drawing.Font("Tahoma", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.comboBox_City.ForeColor = System.Drawing.Color.Black;
            this.comboBox_City.IntegralHeight = false;
            this.comboBox_City.ItemHeight = 20;
            this.comboBox_City.Location = new System.Drawing.Point(167, 35);
            this.comboBox_City.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox_City.Name = "comboBox_City";
            this.comboBox_City.PreventEnterBeep = true;
            this.comboBox_City.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox_City.Size = new System.Drawing.Size(84, 26);
            this.comboBox_City.TabIndex = 50;
            this.comboBox_City.Tag = "0";
            this.comboBox_City.ValueMember = "CityID";
            this.comboBox_City.WatermarkColor = System.Drawing.Color.Empty;
            this.comboBox_City.Enter += new System.EventHandler(this.comboBox_City_Enter);
            this.comboBox_City.Leave += new System.EventHandler(this.comboBox_City_Leave);
            // 
            // label_Country
            // 
            this.label_Country.AutoSize = true;
            this.label_Country.BackColor = System.Drawing.Color.Transparent;
            this.label_Country.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Country.ForeColor = System.Drawing.Color.Black;
            this.label_Country.Location = new System.Drawing.Point(388, 16);
            this.label_Country.Name = "label_Country";
            this.label_Country.Size = new System.Drawing.Size(39, 14);
            this.label_Country.TabIndex = 52;
            this.label_Country.Text = "کشور:";
            // 
            // label_State
            // 
            this.label_State.AutoSize = true;
            this.label_State.BackColor = System.Drawing.Color.Transparent;
            this.label_State.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_State.ForeColor = System.Drawing.Color.Black;
            this.label_State.Location = new System.Drawing.Point(294, 16);
            this.label_State.Name = "label_State";
            this.label_State.Size = new System.Drawing.Size(42, 14);
            this.label_State.TabIndex = 53;
            this.label_State.Text = "استان:";
            // 
            // label_City
            // 
            this.label_City.AutoSize = true;
            this.label_City.BackColor = System.Drawing.Color.Transparent;
            this.label_City.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_City.ForeColor = System.Drawing.Color.Black;
            this.label_City.Location = new System.Drawing.Point(213, 16);
            this.label_City.Name = "label_City";
            this.label_City.Size = new System.Drawing.Size(35, 14);
            this.label_City.TabIndex = 54;
            this.label_City.Text = "شهر:";
            // 
            // label_Part
            // 
            this.label_Part.AutoSize = true;
            this.label_Part.BackColor = System.Drawing.Color.Transparent;
            this.label_Part.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Part.ForeColor = System.Drawing.Color.Black;
            this.label_Part.Location = new System.Drawing.Point(105, 16);
            this.label_Part.Name = "label_Part";
            this.label_Part.Size = new System.Drawing.Size(42, 14);
            this.label_Part.TabIndex = 55;
            this.label_Part.Text = "منطقه:";
            // 
            // bar_MainView
            // 
            this.bar_MainView.AccessibleDescription = "bar1 (bar1)";
            this.bar_MainView.AccessibleName = "bar1";
            this.bar_MainView.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
            this.bar_MainView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bar_MainView.Font = new System.Drawing.Font("Tahoma", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bar_MainView.Location = new System.Drawing.Point(0, 226);
            this.bar_MainView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bar_MainView.Name = "bar_MainView";
            this.bar_MainView.Size = new System.Drawing.Size(448, 25);
            this.bar_MainView.Stretch = true;
            this.bar_MainView.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.bar_MainView.TabIndex = 14;
            this.bar_MainView.TabStop = false;
            // 
            // panel_SelectEngine
            // 
            this.panel_SelectEngine.Controls.Add(this.comboBox_SelEngine);
            this.panel_SelectEngine.Location = new System.Drawing.Point(4, 227);
            this.panel_SelectEngine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_SelectEngine.Name = "panel_SelectEngine";
            this.panel_SelectEngine.Size = new System.Drawing.Size(443, 59);
            this.panel_SelectEngine.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panel_SelectEngine.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.panel_SelectEngine.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.panel_SelectEngine.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panel_SelectEngine.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panel_SelectEngine.Style.ForeColor.Color = System.Drawing.Color.Black;
            this.panel_SelectEngine.Style.GradientAngle = 90;
            this.panel_SelectEngine.Style.LineAlignment = System.Drawing.StringAlignment.Near;
            this.panel_SelectEngine.TabIndex = 15;
            this.panel_SelectEngine.Text = "انتخاب سایت";
            // 
            // comboBox_SelEngine
            // 
            this.comboBox_SelEngine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_SelEngine.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox_SelEngine.DropDownHeight = 100;
            this.comboBox_SelEngine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_SelEngine.ForeColor = System.Drawing.Color.Black;
            this.comboBox_SelEngine.IntegralHeight = false;
            this.comboBox_SelEngine.ItemHeight = 16;
            this.comboBox_SelEngine.Items.AddRange(new object[] {
            this.comboItem1,
            this.comboItem2});
            this.comboBox_SelEngine.Location = new System.Drawing.Point(62, 25);
            this.comboBox_SelEngine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_SelEngine.Name = "comboBox_SelEngine";
            this.comboBox_SelEngine.Size = new System.Drawing.Size(319, 22);
            this.comboBox_SelEngine.TabIndex = 0;
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "www.google.com";
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "www.yahoo.com";
            // 
            // SearchInternet_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 251);
            this.Controls.Add(this.bar_MainView);
            this.Controls.Add(this.panel_Part);
            this.Controls.Add(this.panel_Text);
            this.Controls.Add(this.ribbonBar_ieSearch);
            this.Controls.Add(this.panel_SelectEngine);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(456, 255);
            this.Name = "SearchInternet_frm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "جستجو در اینترنت";
            this.Load += new System.EventHandler(this.SearchInternet_frm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchInternet_frm_KeyDown);
            this.panel_Text.ResumeLayout(false);
            this.panel_Part.ResumeLayout(false);
            this.panel_Part.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bar_MainView)).EndInit();
            this.panel_SelectEngine.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panel_Text;
        public DevComponents.DotNetBar.Controls.TextBoxX textBox_SearchText;
        private DevComponents.DotNetBar.RibbonBar ribbonBar_ieSearch;
        public DevComponents.DotNetBar.ButtonItem buttonItem_ieSearch;
        private DevComponents.DotNetBar.ButtonItem buttonItem_Cancel;
        private DevComponents.DotNetBar.PanelEx panel_Part;
        public DevComponents.DotNetBar.ButtonItem buttonItem_MapSearch;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBox_Part;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBox_State;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBox_Country;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBox_City;
        private System.Windows.Forms.Label label_Country;
        private System.Windows.Forms.Label label_State;
        private System.Windows.Forms.Label label_City;
        private System.Windows.Forms.Label label_Part;
        private DevComponents.DotNetBar.Bar bar_MainView;
        private DevComponents.DotNetBar.PanelEx panel_SelectEngine;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBox_SelEngine;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
    }
}