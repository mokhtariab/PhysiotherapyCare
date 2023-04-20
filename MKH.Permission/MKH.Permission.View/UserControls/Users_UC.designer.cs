namespace MKH.Permission.View.UserControls
{
    partial class Users_UC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Users_UC));
            Janus.Windows.GridEX.GridEXLayout GridViewUsers_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.GridViewUsers = new MKH.Library.Control.MSSGridexView();
            this.vWUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mssPanel4 = new MKH.Library.Control.MSSPanel(this.components);
            this.PictureBoxUserPic = new MKH.Library.Control.MSSPictureBox(this.components);
            this.HeaderGridUsers = new MKH.Library.Control.MSSHeaderGrid();
            this.itemContainer1 = new DevComponents.DotNetBar.ItemContainer();
            this.buttonItemResetPassword = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemSoftwareAccessUser = new DevComponents.DotNetBar.ButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWUsersBindingSource)).BeginInit();
            this.mssPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxUserPic)).BeginInit();
            this.SuspendLayout();
            // 
            // GridViewUsers
            // 
            this.GridViewUsers.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.GridViewUsers.AlternatingRowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewUsers.BuiltInTextsData = resources.GetString("GridViewUsers.BuiltInTextsData");
            this.GridViewUsers.CardViewGridlines = Janus.Windows.GridEX.CardViewGridlines.Both;
            this.GridViewUsers.DataSource = this.vWUsersBindingSource;
            this.GridViewUsers.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            GridViewUsers_DesignTimeLayout.LayoutString = resources.GetString("GridViewUsers_DesignTimeLayout.LayoutString");
            this.GridViewUsers.DesignTimeLayout = GridViewUsers_DesignTimeLayout;
            this.GridViewUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewUsers.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.GridViewUsers.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.GridViewUsers.Font = new System.Drawing.Font("Tahoma", 8.150944F);
            this.GridViewUsers.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewUsers.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
            this.GridViewUsers.Hierarchical = true;
            this.GridViewUsers.Location = new System.Drawing.Point(189, 61);
            this.GridViewUsers.Name = "GridViewUsers";
            this.GridViewUsers.RecordNavigator = true;
            this.GridViewUsers.RowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewUsers.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition;
            this.GridViewUsers.RowHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewUsers.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.GridViewUsers.Size = new System.Drawing.Size(1236, 388);
            this.GridViewUsers.TabIndex = 10;
            this.GridViewUsers.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.GridViewUsers.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010;
            this.GridViewUsers.SelectionChanged += new System.EventHandler(this.GridViewUsers_SelectionChanged);
            this.GridViewUsers.DoubleClick += new System.EventHandler(this.headerGridUsers_btnEditClick);
            // 
            // vWUsersBindingSource
            // 
            this.vWUsersBindingSource.DataSource = typeof(MKH.Permission.Model.Users.VW_User);
            // 
            // mssPanel4
            // 
            this.mssPanel4.CanvasColor = System.Drawing.SystemColors.Control;
            this.mssPanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.mssPanel4.Controls.Add(this.PictureBoxUserPic);
            this.mssPanel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.mssPanel4.Location = new System.Drawing.Point(0, 61);
            this.mssPanel4.Name = "mssPanel4";
            this.mssPanel4.Size = new System.Drawing.Size(189, 388);
            this.mssPanel4.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.mssPanel4.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.mssPanel4.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.mssPanel4.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.mssPanel4.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.mssPanel4.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.mssPanel4.Style.GradientAngle = 90;
            this.mssPanel4.TabIndex = 34;
            // 
            // PictureBoxUserPic
            // 
            this.PictureBoxUserPic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PictureBoxUserPic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PictureBoxUserPic.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxUserPic.Image")));
            this.PictureBoxUserPic.Location = new System.Drawing.Point(11, 89);
            this.PictureBoxUserPic.Name = "PictureBoxUserPic";
            this.PictureBoxUserPic.Size = new System.Drawing.Size(168, 188);
            this.PictureBoxUserPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxUserPic.TabIndex = 0;
            this.PictureBoxUserPic.TabStop = false;
            // 
            // HeaderGridUsers
            // 
            // 
            // 
            // 
            this.HeaderGridUsers.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridUsers.BackgroundStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridUsers.BackgroundStyle.BorderBottomWidth = 1;
            this.HeaderGridUsers.BackgroundStyle.BorderLeftWidth = 1;
            this.HeaderGridUsers.BackgroundStyle.BorderRightWidth = 1;
            this.HeaderGridUsers.BackgroundStyle.BorderTopWidth = 1;
            this.HeaderGridUsers.BackgroundStyle.Class = "ItemPanel";
            this.HeaderGridUsers.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.HeaderGridUsers.BackgroundStyle.PaddingBottom = 1;
            this.HeaderGridUsers.BackgroundStyle.PaddingLeft = 1;
            this.HeaderGridUsers.BackgroundStyle.PaddingRight = 1;
            this.HeaderGridUsers.BackgroundStyle.PaddingTop = 1;
            this.HeaderGridUsers.ButtonDeletePermissionCode = 0;
            this.HeaderGridUsers.ButtonDeleteVisible = true;
            this.HeaderGridUsers.ButtonEditPermissionCode = 0;
            this.HeaderGridUsers.ButtonEditVisible = true;
            this.HeaderGridUsers.ButtonExcelExportVisible = true;
            this.HeaderGridUsers.ButtonExcelPermissionCode = 0;
            this.HeaderGridUsers.ButtonInsertPermissionCode = 0;
            this.HeaderGridUsers.ButtonInsertVisible = true;
            this.HeaderGridUsers.ButtonPrintExpertPermissionCode = 0;
            this.HeaderGridUsers.ButtonPrintExpertVisible = false;
            this.HeaderGridUsers.ButtonPrintPermissionCode = 0;
            this.HeaderGridUsers.ButtonPrintVisible = true;
            this.HeaderGridUsers.ButtonRefreshVisible = true;
            this.HeaderGridUsers.ButtonSearchExpertVisible = true;
            this.HeaderGridUsers.ButtonSearchVisible = true;
            this.HeaderGridUsers.ButtonSelectorVisible = true;
            this.HeaderGridUsers.ContainerControlProcessDialogKey = true;
            this.HeaderGridUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderGridUsers.FitButtonsToContainerWidth = true;
            this.HeaderGridUsers.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.HeaderGridUsers.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.HeaderGridUsers.GridViewSet = this.GridViewUsers;
            this.HeaderGridUsers.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer1,
            this.buttonItemResetPassword,
            this.buttonItemSoftwareAccessUser});
            this.HeaderGridUsers.Location = new System.Drawing.Point(0, 0);
            this.HeaderGridUsers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HeaderGridUsers.Name = "HeaderGridUsers";
            this.HeaderGridUsers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HeaderGridUsers.Size = new System.Drawing.Size(1425, 61);
            this.HeaderGridUsers.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.HeaderGridUsers.TabIndex = 9;
            this.HeaderGridUsers.ThemeAware = true;
            this.HeaderGridUsers.buttonItemInsertClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemInsertClickEventHandler(this.headerGridUsers_btnInsertClick);
            this.HeaderGridUsers.buttonItemEditClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemEditClickEventHandler(this.headerGridUsers_btnEditClick);
            this.HeaderGridUsers.buttonItemDeleteClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemDeleteClickEventHandler(this.headerGridUsers_btnDeleteClick);
            this.HeaderGridUsers.buttonItemRefreshClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemRefreshClickEventHandler(this.headerGridUsers_btnRefreshClick);
            // 
            // itemContainer1
            // 
            // 
            // 
            // 
            this.itemContainer1.BackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.DockSiteBackColor2;
            this.itemContainer1.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.itemContainer1.BackgroundStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.itemContainer1.BackgroundStyle.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.itemContainer1.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.itemContainer1.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.itemContainer1.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.itemContainer1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer1.Name = "itemContainer1";
            this.itemContainer1.ThemeAware = true;
            // 
            // buttonItemResetPassword
            // 
            this.buttonItemResetPassword.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemResetPassword.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemResetPassword.Icon = ((System.Drawing.Icon)(resources.GetObject("buttonItemResetPassword.Icon")));
            this.buttonItemResetPassword.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.buttonItemResetPassword.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemResetPassword.Name = "buttonItemResetPassword";
            this.buttonItemResetPassword.Text = "ریست پسورد";
            this.buttonItemResetPassword.ThemeAware = true;
            this.buttonItemResetPassword.Click += new System.EventHandler(this.buttonItemResetPassword_Click);
            // 
            // buttonItemSoftwareAccessUser
            // 
            this.buttonItemSoftwareAccessUser.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemSoftwareAccessUser.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemSoftwareAccessUser.Image = ((System.Drawing.Image)(resources.GetObject("buttonItemSoftwareAccessUser.Image")));
            this.buttonItemSoftwareAccessUser.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.buttonItemSoftwareAccessUser.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemSoftwareAccessUser.Name = "buttonItemSoftwareAccessUser";
            this.buttonItemSoftwareAccessUser.Text = "تخصیص دسترسی به کاربر";
            this.buttonItemSoftwareAccessUser.ThemeAware = true;
            this.buttonItemSoftwareAccessUser.Click += new System.EventHandler(this.buttonItemSoftwareAccessUser_Click);
            // 
            // Users_UC
            // 
            this.Controls.Add(this.GridViewUsers);
            this.Controls.Add(this.mssPanel4);
            this.Controls.Add(this.HeaderGridUsers);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "Users_UC";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(1425, 449);
            this.Tag = "لیست کاربران";
            this.Load += new System.EventHandler(this.Users_UC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWUsersBindingSource)).EndInit();
            this.mssPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxUserPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MKH.Library.Control.MSSHeaderGrid HeaderGridUsers;
        private MKH.Library.Control.MSSGridexView GridViewUsers;
        private DevComponents.DotNetBar.ButtonItem buttonItemResetPassword;
        private System.Windows.Forms.BindingSource vWUsersBindingSource;
        private DevComponents.DotNetBar.ItemContainer itemContainer1;
        private DevComponents.DotNetBar.ButtonItem buttonItemSoftwareAccessUser;
        private MKH.Library.Control.MSSPanel mssPanel4;
        private MKH.Library.Control.MSSPictureBox PictureBoxUserPic;

    }
}
