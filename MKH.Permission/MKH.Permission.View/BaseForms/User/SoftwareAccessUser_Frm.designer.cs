using MKH.Library.Control;

namespace MKH.Permission.View.BaseForms
{
    partial class SoftwareAccessUser_Frm
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Node0");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Node2");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Node4");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Node3", new System.Windows.Forms.TreeNode[] {
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Node1", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode4});
            this.TreeViewSoftwareAccessUser = new MKH.Library.Control.MSSTreeView(this.components);
            this.mssPanel3 = new MKH.Library.Control.MSSPanel(this.components);
            this.LabelFullName = new MKH.Library.Control.MSSLabel(this.components);
            this.mssLabel1 = new MKH.Library.Control.MSSLabel(this.components);
            this.ButtonDeselect = new MKH.Library.Control.MSSButton(this.components);
            this.ButtonSelect = new MKH.Library.Control.MSSButton(this.components);
            this.mssGroupPanel1.SuspendLayout();
            this.mssPanel3.SuspendLayout();
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
            this.ribbonBarNewBar.Location = new System.Drawing.Point(0, 314);
            this.ribbonBarNewBar.Size = new System.Drawing.Size(546, 68);
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
            this.mssGroupPanel1.Controls.Add(this.mssPanel3);
            this.mssGroupPanel1.Size = new System.Drawing.Size(546, 280);
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
            // TreeViewSoftwareAccessUser
            // 
            this.TreeViewSoftwareAccessUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TreeViewSoftwareAccessUser.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.TreeViewSoftwareAccessUser.CheckBoxes = true;
            this.TreeViewSoftwareAccessUser.Font = new System.Drawing.Font("Tahoma", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TreeViewSoftwareAccessUser.ItemHeight = 25;
            this.TreeViewSoftwareAccessUser.Location = new System.Drawing.Point(64, 32);
            this.TreeViewSoftwareAccessUser.Name = "TreeViewSoftwareAccessUser";
            treeNode1.Name = "Node0";
            treeNode1.Text = "Node0";
            treeNode2.Name = "Node2";
            treeNode2.Text = "Node2";
            treeNode3.Name = "Node4";
            treeNode3.Text = "Node4";
            treeNode4.Name = "Node3";
            treeNode4.Text = "Node3";
            treeNode5.Name = "Node1";
            treeNode5.Text = "Node1";
            this.TreeViewSoftwareAccessUser.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode5});
            this.TreeViewSoftwareAccessUser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TreeViewSoftwareAccessUser.RightToLeftLayout = true;
            this.TreeViewSoftwareAccessUser.ShowNodeToolTips = true;
            this.TreeViewSoftwareAccessUser.Size = new System.Drawing.Size(399, 219);
            this.TreeViewSoftwareAccessUser.TabIndex = 32;
            // 
            // mssPanel3
            // 
            this.mssPanel3.CanvasColor = System.Drawing.SystemColors.Control;
            this.mssPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.mssPanel3.Controls.Add(this.LabelFullName);
            this.mssPanel3.Controls.Add(this.mssLabel1);
            this.mssPanel3.Controls.Add(this.ButtonDeselect);
            this.mssPanel3.Controls.Add(this.ButtonSelect);
            this.mssPanel3.Controls.Add(this.TreeViewSoftwareAccessUser);
            this.mssPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mssPanel3.Location = new System.Drawing.Point(0, 0);
            this.mssPanel3.Name = "mssPanel3";
            this.mssPanel3.Size = new System.Drawing.Size(540, 274);
            this.mssPanel3.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.mssPanel3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.mssPanel3.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.mssPanel3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.mssPanel3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.mssPanel3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.mssPanel3.Style.GradientAngle = 90;
            this.mssPanel3.TabIndex = 1;
            // 
            // LabelFullName
            // 
            this.LabelFullName.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            // 
            // 
            // 
            this.LabelFullName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelFullName.Font = new System.Drawing.Font("Tahoma", 8.830189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LabelFullName.ForeColor = System.Drawing.Color.Black;
            this.LabelFullName.Location = new System.Drawing.Point(109, 10);
            this.LabelFullName.Name = "LabelFullName";
            this.LabelFullName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LabelFullName.Size = new System.Drawing.Size(160, 15);
            this.LabelFullName.TabIndex = 35;
            this.LabelFullName.Text = "نقش:";
            // 
            // mssLabel1
            // 
            this.mssLabel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            // 
            // 
            // 
            this.mssLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mssLabel1.ForeColor = System.Drawing.Color.Black;
            this.mssLabel1.Location = new System.Drawing.Point(274, 10);
            this.mssLabel1.Name = "mssLabel1";
            this.mssLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mssLabel1.Size = new System.Drawing.Size(27, 15);
            this.mssLabel1.TabIndex = 35;
            this.mssLabel1.Text = "کاربر:";
            // 
            // ButtonDeselect
            // 
            this.ButtonDeselect.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonDeselect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonDeselect.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonDeselect.Location = new System.Drawing.Point(316, 7);
            this.ButtonDeselect.Name = "ButtonDeselect";
            this.ButtonDeselect.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ButtonDeselect.Size = new System.Drawing.Size(77, 20);
            this.ButtonDeselect.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonDeselect.TabIndex = 34;
            this.ButtonDeselect.Text = "عدم انتخاب همه";
            this.ButtonDeselect.Click += new System.EventHandler(this.ButtonDeselect_Click);
            // 
            // ButtonSelect
            // 
            this.ButtonSelect.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonSelect.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonSelect.Location = new System.Drawing.Point(399, 7);
            this.ButtonSelect.Name = "ButtonSelect";
            this.ButtonSelect.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ButtonSelect.Size = new System.Drawing.Size(64, 20);
            this.ButtonSelect.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonSelect.TabIndex = 33;
            this.ButtonSelect.Text = "انتخاب همه";
            this.ButtonSelect.Click += new System.EventHandler(this.ButtonSelect_Click);
            // 
            // SoftwareAccessUser_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(546, 382);
            this.Name = "SoftwareAccessUser_Frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "تخصیص دسترسی ها به کاربر";
            this.Load += new System.EventHandler(this.SoftwareAccessUser_Frm_Load);
            this.mssGroupPanel1.ResumeLayout(false);
            this.mssPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MSSTreeView TreeViewSoftwareAccessUser;
        private MSSPanel mssPanel3;
        private MSSButton ButtonDeselect;
        private MSSButton ButtonSelect;
        private MSSLabel mssLabel1;
        private MSSLabel LabelFullName;
    }
}
