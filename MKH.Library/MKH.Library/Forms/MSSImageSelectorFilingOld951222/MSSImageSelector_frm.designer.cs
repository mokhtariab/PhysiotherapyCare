namespace MKH.Library.Forms
{
    partial class MSSImageSelector_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MSSImageSelector_frm));
            this.expandableSplitter_PICFILM = new DevComponents.DotNetBar.ExpandableSplitter();
            this.groupPanel_Films = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.listView_Film = new System.Windows.Forms.ListView();
            this.imageList_LargeFilm = new System.Windows.Forms.ImageList(this.components);
            this.imageList_SmallFilm = new System.Windows.Forms.ImageList(this.components);
            this.bubbleBar_Film = new DevComponents.DotNetBar.BubbleBar();
            this.bubbleBarTab_Film = new DevComponents.DotNetBar.BubbleBarTab(this.components);
            this.bubbleButton_FilmIcon = new DevComponents.DotNetBar.BubbleButton();
            this.bubbleButton_FilmView = new DevComponents.DotNetBar.BubbleButton();
            this.bubbleButton_FilmDel = new DevComponents.DotNetBar.BubbleButton();
            this.bubbleButton_FilmNew = new DevComponents.DotNetBar.BubbleButton();
            this.groupPanel_Pics = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.listView_Pic = new System.Windows.Forms.ListView();
            this.imageList_LargePic = new System.Windows.Forms.ImageList(this.components);
            this.imageList_SmallPic = new System.Windows.Forms.ImageList(this.components);
            this.bubbleBar_Pic = new DevComponents.DotNetBar.BubbleBar();
            this.bubbleBarTab_Pic = new DevComponents.DotNetBar.BubbleBarTab(this.components);
            this.bubbleButton_IconPic = new DevComponents.DotNetBar.BubbleButton();
            this.bubbleButton_PicView = new DevComponents.DotNetBar.BubbleButton();
            this.bubbleButton_PicDel = new DevComponents.DotNetBar.BubbleButton();
            this.bubbleButton_PicNew = new DevComponents.DotNetBar.BubbleButton();
            this.mssGroupPanel1.SuspendLayout();
            this.groupPanel_Films.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bubbleBar_Film)).BeginInit();
            this.groupPanel_Pics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bubbleBar_Pic)).BeginInit();
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
            this.ribbonBarNewBar.Location = new System.Drawing.Point(0, 486);
            this.ribbonBarNewBar.Size = new System.Drawing.Size(957, 66);
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
            this.mssGroupPanel1.Controls.Add(this.groupPanel_Pics);
            this.mssGroupPanel1.Controls.Add(this.expandableSplitter_PICFILM);
            this.mssGroupPanel1.Controls.Add(this.groupPanel_Films);
            this.mssGroupPanel1.Location = new System.Drawing.Point(0, 32);
            this.mssGroupPanel1.Size = new System.Drawing.Size(957, 454);
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
            this.buttonItemOK.Click += new System.EventHandler(this.buttonItem_OK_Click);
            // 
            // expandableSplitter_PICFILM
            // 
            this.expandableSplitter_PICFILM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.expandableSplitter_PICFILM.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(108)))), ((int)(((byte)(122)))));
            this.expandableSplitter_PICFILM.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter_PICFILM.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandableSplitter_PICFILM.ExpandableControl = this.groupPanel_Films;
            this.expandableSplitter_PICFILM.ExpandFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(108)))), ((int)(((byte)(122)))));
            this.expandableSplitter_PICFILM.ExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter_PICFILM.ExpandLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(120)))));
            this.expandableSplitter_PICFILM.ExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandableSplitter_PICFILM.GripDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(120)))));
            this.expandableSplitter_PICFILM.GripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandableSplitter_PICFILM.GripLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(232)))), ((int)(((byte)(246)))));
            this.expandableSplitter_PICFILM.GripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.expandableSplitter_PICFILM.HotBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(200)))), ((int)(((byte)(103)))));
            this.expandableSplitter_PICFILM.HotBackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(226)))), ((int)(((byte)(135)))));
            this.expandableSplitter_PICFILM.HotBackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground2;
            this.expandableSplitter_PICFILM.HotBackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground;
            this.expandableSplitter_PICFILM.HotExpandFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(108)))), ((int)(((byte)(122)))));
            this.expandableSplitter_PICFILM.HotExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter_PICFILM.HotExpandLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(120)))));
            this.expandableSplitter_PICFILM.HotExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandableSplitter_PICFILM.HotGripDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(108)))), ((int)(((byte)(122)))));
            this.expandableSplitter_PICFILM.HotGripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter_PICFILM.HotGripLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(232)))), ((int)(((byte)(246)))));
            this.expandableSplitter_PICFILM.HotGripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.expandableSplitter_PICFILM.Location = new System.Drawing.Point(369, 0);
            this.expandableSplitter_PICFILM.Name = "expandableSplitter_PICFILM";
            this.expandableSplitter_PICFILM.Size = new System.Drawing.Size(5, 448);
            this.expandableSplitter_PICFILM.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007;
            this.expandableSplitter_PICFILM.TabIndex = 21;
            this.expandableSplitter_PICFILM.TabStop = false;
            // 
            // groupPanel_Films
            // 
            this.groupPanel_Films.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel_Films.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel_Films.Controls.Add(this.listView_Film);
            this.groupPanel_Films.Controls.Add(this.bubbleBar_Film);
            this.groupPanel_Films.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupPanel_Films.Location = new System.Drawing.Point(0, 0);
            this.groupPanel_Films.Name = "groupPanel_Films";
            this.groupPanel_Films.Size = new System.Drawing.Size(369, 448);
            // 
            // 
            // 
            this.groupPanel_Films.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel_Films.Style.BackColorGradientAngle = 90;
            this.groupPanel_Films.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel_Films.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_Films.Style.BorderBottomWidth = 1;
            this.groupPanel_Films.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel_Films.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_Films.Style.BorderLeftWidth = 1;
            this.groupPanel_Films.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_Films.Style.BorderRightWidth = 1;
            this.groupPanel_Films.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_Films.Style.BorderTopWidth = 1;
            this.groupPanel_Films.Style.CornerDiameter = 4;
            this.groupPanel_Films.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel_Films.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel_Films.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel_Films.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel_Films.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel_Films.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel_Films.TabIndex = 20;
            this.groupPanel_Films.Text = "فیلم ها و سایر فایل ها";
            // 
            // listView_Film
            // 
            this.listView_Film.BackColor = System.Drawing.SystemColors.Window;
            this.listView_Film.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_Film.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.listView_Film.ForeColor = System.Drawing.Color.Black;
            this.listView_Film.LargeImageList = this.imageList_LargeFilm;
            this.listView_Film.Location = new System.Drawing.Point(0, 0);
            this.listView_Film.Name = "listView_Film";
            this.listView_Film.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listView_Film.ShowItemToolTips = true;
            this.listView_Film.Size = new System.Drawing.Size(363, 363);
            this.listView_Film.SmallImageList = this.imageList_SmallFilm;
            this.listView_Film.TabIndex = 13;
            this.listView_Film.UseCompatibleStateImageBehavior = false;
            this.listView_Film.DoubleClick += new System.EventHandler(this.listView_Film_DoubleClick);
            // 
            // imageList_LargeFilm
            // 
            this.imageList_LargeFilm.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            this.imageList_LargeFilm.ImageSize = new System.Drawing.Size(128, 100);
            this.imageList_LargeFilm.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList_SmallFilm
            // 
            this.imageList_SmallFilm.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            this.imageList_SmallFilm.ImageSize = new System.Drawing.Size(64, 50);
            this.imageList_SmallFilm.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // bubbleBar_Film
            // 
            this.bubbleBar_Film.Alignment = DevComponents.DotNetBar.eBubbleButtonAlignment.Bottom;
            this.bubbleBar_Film.AntiAlias = true;
            this.bubbleBar_Film.BackColor = System.Drawing.SystemColors.ActiveCaption;
            // 
            // 
            // 
            this.bubbleBar_Film.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.bubbleBar_Film.ButtonBackAreaStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bubbleBar_Film.ButtonBackAreaStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.bubbleBar_Film.ButtonBackAreaStyle.BorderBottomWidth = 1;
            this.bubbleBar_Film.ButtonBackAreaStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.bubbleBar_Film.ButtonBackAreaStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.bubbleBar_Film.ButtonBackAreaStyle.BorderLeftWidth = 1;
            this.bubbleBar_Film.ButtonBackAreaStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.bubbleBar_Film.ButtonBackAreaStyle.BorderRightWidth = 1;
            this.bubbleBar_Film.ButtonBackAreaStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.bubbleBar_Film.ButtonBackAreaStyle.BorderTopWidth = 1;
            this.bubbleBar_Film.ButtonBackAreaStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.bubbleBar_Film.ButtonBackAreaStyle.PaddingBottom = 3;
            this.bubbleBar_Film.ButtonBackAreaStyle.PaddingLeft = 3;
            this.bubbleBar_Film.ButtonBackAreaStyle.PaddingRight = 3;
            this.bubbleBar_Film.ButtonBackAreaStyle.PaddingTop = 3;
            this.bubbleBar_Film.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bubbleBar_Film.ImageSizeLarge = new System.Drawing.Size(98, 98);
            this.bubbleBar_Film.ImageSizeNormal = new System.Drawing.Size(48, 48);
            this.bubbleBar_Film.Location = new System.Drawing.Point(0, 363);
            this.bubbleBar_Film.Margin = new System.Windows.Forms.Padding(4);
            this.bubbleBar_Film.MouseOverTabColors.BorderColor = System.Drawing.SystemColors.Highlight;
            this.bubbleBar_Film.Name = "bubbleBar_Film";
            this.bubbleBar_Film.SelectedTab = this.bubbleBarTab_Film;
            this.bubbleBar_Film.SelectedTabColors.BorderColor = System.Drawing.Color.Black;
            this.bubbleBar_Film.Size = new System.Drawing.Size(363, 60);
            this.bubbleBar_Film.TabIndex = 12;
            this.bubbleBar_Film.Tabs.Add(this.bubbleBarTab_Film);
            // 
            // bubbleBarTab_Film
            // 
            this.bubbleBarTab_Film.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            this.bubbleBarTab_Film.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(168)))), ((int)(((byte)(228)))));
            this.bubbleBarTab_Film.Buttons.AddRange(new DevComponents.DotNetBar.BubbleButton[] {
            this.bubbleButton_FilmIcon,
            this.bubbleButton_FilmView,
            this.bubbleButton_FilmDel,
            this.bubbleButton_FilmNew});
            this.bubbleBarTab_Film.DarkBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bubbleBarTab_Film.LightBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bubbleBarTab_Film.Name = "bubbleBarTab_Film";
            this.bubbleBarTab_Film.PredefinedColor = DevComponents.DotNetBar.eTabItemColor.Blue;
            this.bubbleBarTab_Film.Text = "";
            this.bubbleBarTab_Film.TextColor = System.Drawing.Color.Black;
            // 
            // bubbleButton_FilmIcon
            // 
            this.bubbleButton_FilmIcon.Image = ((System.Drawing.Image)(resources.GetObject("bubbleButton_FilmIcon.Image")));
            this.bubbleButton_FilmIcon.ImageLarge = ((System.Drawing.Image)(resources.GetObject("bubbleButton_FilmIcon.ImageLarge")));
            this.bubbleButton_FilmIcon.Name = "bubbleButton_FilmIcon";
            this.bubbleButton_FilmIcon.Shortcut = DevComponents.DotNetBar.eShortcut.ShiftF12;
            this.bubbleButton_FilmIcon.TooltipText = "بزرگ نمایی";
            this.bubbleButton_FilmIcon.Click += new DevComponents.DotNetBar.ClickEventHandler(this.bubbleButton_FilmIcon_Click);
            // 
            // bubbleButton_FilmView
            // 
            this.bubbleButton_FilmView.Image = ((System.Drawing.Image)(resources.GetObject("bubbleButton_FilmView.Image")));
            this.bubbleButton_FilmView.ImageLarge = ((System.Drawing.Image)(resources.GetObject("bubbleButton_FilmView.ImageLarge")));
            this.bubbleButton_FilmView.Name = "bubbleButton_FilmView";
            this.bubbleButton_FilmView.Shortcut = DevComponents.DotNetBar.eShortcut.ShiftF11;
            this.bubbleButton_FilmView.TooltipText = "نمایش";
            this.bubbleButton_FilmView.Click += new DevComponents.DotNetBar.ClickEventHandler(this.bubbleButton_FilmView_Click);
            // 
            // bubbleButton_FilmDel
            // 
            this.bubbleButton_FilmDel.Image = ((System.Drawing.Image)(resources.GetObject("bubbleButton_FilmDel.Image")));
            this.bubbleButton_FilmDel.ImageLarge = ((System.Drawing.Image)(resources.GetObject("bubbleButton_FilmDel.ImageLarge")));
            this.bubbleButton_FilmDel.Name = "bubbleButton_FilmDel";
            this.bubbleButton_FilmDel.Shortcut = DevComponents.DotNetBar.eShortcut.ShiftDel;
            this.bubbleButton_FilmDel.TooltipText = "حذف فایل";
            this.bubbleButton_FilmDel.Click += new DevComponents.DotNetBar.ClickEventHandler(this.bubbleButton_FilmDel_Click);
            // 
            // bubbleButton_FilmNew
            // 
            this.bubbleButton_FilmNew.Image = global::MKH.Library.Properties.Resources.File;
            this.bubbleButton_FilmNew.ImageLarge = global::MKH.Library.Properties.Resources.File;
            this.bubbleButton_FilmNew.Name = "bubbleButton_FilmNew";
            this.bubbleButton_FilmNew.Shortcut = DevComponents.DotNetBar.eShortcut.ShiftIns;
            this.bubbleButton_FilmNew.TooltipText = "فایل جدید";
            this.bubbleButton_FilmNew.Click += new DevComponents.DotNetBar.ClickEventHandler(this.bubbleButton_FilmNew_Click);
            // 
            // groupPanel_Pics
            // 
            this.groupPanel_Pics.AutoScroll = true;
            this.groupPanel_Pics.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel_Pics.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel_Pics.Controls.Add(this.listView_Pic);
            this.groupPanel_Pics.Controls.Add(this.bubbleBar_Pic);
            this.groupPanel_Pics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel_Pics.Location = new System.Drawing.Point(374, 0);
            this.groupPanel_Pics.Name = "groupPanel_Pics";
            this.groupPanel_Pics.Size = new System.Drawing.Size(577, 448);
            // 
            // 
            // 
            this.groupPanel_Pics.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel_Pics.Style.BackColorGradientAngle = 90;
            this.groupPanel_Pics.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel_Pics.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_Pics.Style.BorderBottomWidth = 1;
            this.groupPanel_Pics.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel_Pics.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_Pics.Style.BorderLeftWidth = 1;
            this.groupPanel_Pics.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_Pics.Style.BorderRightWidth = 1;
            this.groupPanel_Pics.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_Pics.Style.BorderTopWidth = 1;
            this.groupPanel_Pics.Style.CornerDiameter = 4;
            this.groupPanel_Pics.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel_Pics.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel_Pics.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel_Pics.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel_Pics.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel_Pics.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel_Pics.TabIndex = 19;
            this.groupPanel_Pics.Text = "تصاویر";
            // 
            // listView_Pic
            // 
            this.listView_Pic.BackColor = System.Drawing.SystemColors.Window;
            this.listView_Pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_Pic.Font = new System.Drawing.Font("Times New Roman", 1.358491F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.listView_Pic.ForeColor = System.Drawing.Color.White;
            this.listView_Pic.LargeImageList = this.imageList_LargePic;
            this.listView_Pic.Location = new System.Drawing.Point(0, 0);
            this.listView_Pic.Name = "listView_Pic";
            this.listView_Pic.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listView_Pic.ShowItemToolTips = true;
            this.listView_Pic.Size = new System.Drawing.Size(571, 363);
            this.listView_Pic.SmallImageList = this.imageList_SmallPic;
            this.listView_Pic.TabIndex = 11;
            this.listView_Pic.UseCompatibleStateImageBehavior = false;
            this.listView_Pic.DoubleClick += new System.EventHandler(this.listView_Pic_DoubleClick);
            // 
            // imageList_LargePic
            // 
            this.imageList_LargePic.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList_LargePic.ImageSize = new System.Drawing.Size(256, 200);
            this.imageList_LargePic.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList_SmallPic
            // 
            this.imageList_SmallPic.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList_SmallPic.ImageSize = new System.Drawing.Size(128, 100);
            this.imageList_SmallPic.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // bubbleBar_Pic
            // 
            this.bubbleBar_Pic.Alignment = DevComponents.DotNetBar.eBubbleButtonAlignment.Bottom;
            this.bubbleBar_Pic.AntiAlias = true;
            this.bubbleBar_Pic.BackColor = System.Drawing.SystemColors.ActiveCaption;
            // 
            // 
            // 
            this.bubbleBar_Pic.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.bubbleBar_Pic.ButtonBackAreaStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bubbleBar_Pic.ButtonBackAreaStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.bubbleBar_Pic.ButtonBackAreaStyle.BorderBottomWidth = 1;
            this.bubbleBar_Pic.ButtonBackAreaStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.bubbleBar_Pic.ButtonBackAreaStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.bubbleBar_Pic.ButtonBackAreaStyle.BorderLeftWidth = 1;
            this.bubbleBar_Pic.ButtonBackAreaStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.bubbleBar_Pic.ButtonBackAreaStyle.BorderRightWidth = 1;
            this.bubbleBar_Pic.ButtonBackAreaStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.bubbleBar_Pic.ButtonBackAreaStyle.BorderTopWidth = 1;
            this.bubbleBar_Pic.ButtonBackAreaStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.bubbleBar_Pic.ButtonBackAreaStyle.PaddingBottom = 3;
            this.bubbleBar_Pic.ButtonBackAreaStyle.PaddingLeft = 3;
            this.bubbleBar_Pic.ButtonBackAreaStyle.PaddingRight = 3;
            this.bubbleBar_Pic.ButtonBackAreaStyle.PaddingTop = 3;
            this.bubbleBar_Pic.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bubbleBar_Pic.ImageSizeLarge = new System.Drawing.Size(98, 98);
            this.bubbleBar_Pic.ImageSizeNormal = new System.Drawing.Size(48, 48);
            this.bubbleBar_Pic.Location = new System.Drawing.Point(0, 363);
            this.bubbleBar_Pic.Margin = new System.Windows.Forms.Padding(4);
            this.bubbleBar_Pic.MouseOverTabColors.BorderColor = System.Drawing.SystemColors.Highlight;
            this.bubbleBar_Pic.Name = "bubbleBar_Pic";
            this.bubbleBar_Pic.SelectedTab = this.bubbleBarTab_Pic;
            this.bubbleBar_Pic.SelectedTabColors.BorderColor = System.Drawing.Color.Black;
            this.bubbleBar_Pic.Size = new System.Drawing.Size(571, 60);
            this.bubbleBar_Pic.TabIndex = 10;
            this.bubbleBar_Pic.Tabs.Add(this.bubbleBarTab_Pic);
            // 
            // bubbleBarTab_Pic
            // 
            this.bubbleBarTab_Pic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            this.bubbleBarTab_Pic.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(168)))), ((int)(((byte)(228)))));
            this.bubbleBarTab_Pic.Buttons.AddRange(new DevComponents.DotNetBar.BubbleButton[] {
            this.bubbleButton_IconPic,
            this.bubbleButton_PicView,
            this.bubbleButton_PicDel,
            this.bubbleButton_PicNew});
            this.bubbleBarTab_Pic.DarkBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bubbleBarTab_Pic.LightBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bubbleBarTab_Pic.Name = "bubbleBarTab_Pic";
            this.bubbleBarTab_Pic.PredefinedColor = DevComponents.DotNetBar.eTabItemColor.Blue;
            this.bubbleBarTab_Pic.Text = "";
            this.bubbleBarTab_Pic.TextColor = System.Drawing.Color.Black;
            // 
            // bubbleButton_IconPic
            // 
            this.bubbleButton_IconPic.Image = ((System.Drawing.Image)(resources.GetObject("bubbleButton_IconPic.Image")));
            this.bubbleButton_IconPic.ImageLarge = ((System.Drawing.Image)(resources.GetObject("bubbleButton_IconPic.ImageLarge")));
            this.bubbleButton_IconPic.Name = "bubbleButton_IconPic";
            this.bubbleButton_IconPic.Shortcut = DevComponents.DotNetBar.eShortcut.CtrlF12;
            this.bubbleButton_IconPic.TooltipText = "بزرگ نمایی";
            this.bubbleButton_IconPic.Click += new DevComponents.DotNetBar.ClickEventHandler(this.bubbleButton_IconPic_Click);
            // 
            // bubbleButton_PicView
            // 
            this.bubbleButton_PicView.Image = ((System.Drawing.Image)(resources.GetObject("bubbleButton_PicView.Image")));
            this.bubbleButton_PicView.ImageLarge = ((System.Drawing.Image)(resources.GetObject("bubbleButton_PicView.ImageLarge")));
            this.bubbleButton_PicView.Name = "bubbleButton_PicView";
            this.bubbleButton_PicView.Shortcut = DevComponents.DotNetBar.eShortcut.CtrlF11;
            this.bubbleButton_PicView.TooltipText = "نمایش";
            this.bubbleButton_PicView.Click += new DevComponents.DotNetBar.ClickEventHandler(this.bubbleButton_PicView_Click);
            // 
            // bubbleButton_PicDel
            // 
            this.bubbleButton_PicDel.Image = ((System.Drawing.Image)(resources.GetObject("bubbleButton_PicDel.Image")));
            this.bubbleButton_PicDel.ImageLarge = ((System.Drawing.Image)(resources.GetObject("bubbleButton_PicDel.ImageLarge")));
            this.bubbleButton_PicDel.Name = "bubbleButton_PicDel";
            this.bubbleButton_PicDel.Shortcut = DevComponents.DotNetBar.eShortcut.CtrlDel;
            this.bubbleButton_PicDel.TooltipText = "حذف عکس";
            this.bubbleButton_PicDel.Click += new DevComponents.DotNetBar.ClickEventHandler(this.bubbleButton_PicDel_Click);
            // 
            // bubbleButton_PicNew
            // 
            this.bubbleButton_PicNew.Image = ((System.Drawing.Image)(resources.GetObject("bubbleButton_PicNew.Image")));
            this.bubbleButton_PicNew.ImageLarge = ((System.Drawing.Image)(resources.GetObject("bubbleButton_PicNew.ImageLarge")));
            this.bubbleButton_PicNew.Name = "bubbleButton_PicNew";
            this.bubbleButton_PicNew.Shortcut = DevComponents.DotNetBar.eShortcut.CtrlIns;
            this.bubbleButton_PicNew.TooltipText = "عکس جدید";
            this.bubbleButton_PicNew.Click += new DevComponents.DotNetBar.ClickEventHandler(this.bubbleButton_PicNew_Click);
            // 
            // MSSImageSelector_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 552);
            this.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "MSSImageSelector_frm";
            this.ShowInTaskbar = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MSSImageSelector_frm_Load);
            this.mssGroupPanel1.ResumeLayout(false);
            this.groupPanel_Films.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bubbleBar_Film)).EndInit();
            this.groupPanel_Pics.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bubbleBar_Pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel_Films;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel_Pics;
        private DevComponents.DotNetBar.ExpandableSplitter expandableSplitter_PICFILM;
        private DevComponents.DotNetBar.BubbleBar bubbleBar_Pic;
        private DevComponents.DotNetBar.BubbleBarTab bubbleBarTab_Pic;
        private DevComponents.DotNetBar.BubbleButton bubbleButton_PicView;
        private DevComponents.DotNetBar.BubbleButton bubbleButton_PicDel;
        private DevComponents.DotNetBar.BubbleButton bubbleButton_PicNew;
        private DevComponents.DotNetBar.BubbleBar bubbleBar_Film;
        private DevComponents.DotNetBar.BubbleBarTab bubbleBarTab_Film;
        private DevComponents.DotNetBar.BubbleButton bubbleButton_FilmView;
        private DevComponents.DotNetBar.BubbleButton bubbleButton_FilmDel;
        private DevComponents.DotNetBar.BubbleButton bubbleButton_FilmNew;
        private System.Windows.Forms.ImageList imageList_LargePic;
        private System.Windows.Forms.ImageList imageList_SmallPic;
        private System.Windows.Forms.ImageList imageList_SmallFilm;
        private System.Windows.Forms.ImageList imageList_LargeFilm;
        private DevComponents.DotNetBar.BubbleButton bubbleButton_IconPic;
        private DevComponents.DotNetBar.BubbleButton bubbleButton_FilmIcon;
        private System.Windows.Forms.ListView listView_Film;
        private System.Windows.Forms.ListView listView_Pic;
    }

}