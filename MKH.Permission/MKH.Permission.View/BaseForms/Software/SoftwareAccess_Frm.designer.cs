using MKH.Library.Control;

namespace MKH.Permission.View.BaseForms
{
    partial class SoftwareAccess_Frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SoftwareAccess_Frm));
            this.con = new MKH.Library.Control.MSSGroupPanel(this.components);
            this.TreeViewSoftwareAccess = new MKH.Library.Control.MSSTreeView(this.components);
            this.mssItemPanel1 = new MKH.Library.Control.MSSItemPanel(this.components);
            this.buttonItemNodeAdd = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemChildAdd = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemNodeEdit = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemNodeDel = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemRefresh = new DevComponents.DotNetBar.ButtonItem();
            this.SuspendLayout();
            // 
            // con
            // 
            this.con.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.con.Font = new System.Drawing.Font("Tahoma", 8F);
            this.con.Location = new System.Drawing.Point(0, 420);
            this.con.Name = "con";
            this.con.Size = new System.Drawing.Size(637, 26);
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
            // TreeViewSoftwareAccess
            // 
            this.TreeViewSoftwareAccess.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.TreeViewSoftwareAccess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TreeViewSoftwareAccess.Font = new System.Drawing.Font("Tahoma", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TreeViewSoftwareAccess.ItemHeight = 25;
            this.TreeViewSoftwareAccess.Location = new System.Drawing.Point(0, 64);
            this.TreeViewSoftwareAccess.Name = "TreeViewSoftwareAccess";
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
            this.TreeViewSoftwareAccess.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode5});
            this.TreeViewSoftwareAccess.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TreeViewSoftwareAccess.RightToLeftLayout = true;
            this.TreeViewSoftwareAccess.ShowNodeToolTips = true;
            this.TreeViewSoftwareAccess.Size = new System.Drawing.Size(637, 356);
            this.TreeViewSoftwareAccess.TabIndex = 32;
            // 
            // mssItemPanel1
            // 
            this.mssItemPanel1.BackColor = System.Drawing.SystemColors.Info;
            // 
            // 
            // 
            this.mssItemPanel1.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.mssItemPanel1.BackgroundStyle.Class = "ItemPanel";
            this.mssItemPanel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mssItemPanel1.ContainerControlProcessDialogKey = true;
            this.mssItemPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.mssItemPanel1.Font = new System.Drawing.Font("Tahoma", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.mssItemPanel1.ForeColor = System.Drawing.Color.Black;
            this.mssItemPanel1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItemNodeAdd,
            this.buttonItemChildAdd,
            this.buttonItemNodeEdit,
            this.buttonItemNodeDel,
            this.buttonItemRefresh});
            this.mssItemPanel1.Location = new System.Drawing.Point(0, 0);
            this.mssItemPanel1.Name = "mssItemPanel1";
            this.mssItemPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mssItemPanel1.Size = new System.Drawing.Size(637, 64);
            this.mssItemPanel1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.mssItemPanel1.TabIndex = 33;
            // 
            // buttonItemNodeAdd
            // 
            this.buttonItemNodeAdd.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemNodeAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.buttonItemNodeAdd.FixedSize = new System.Drawing.Size(60, 60);
            this.buttonItemNodeAdd.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemNodeAdd.Icon = ((System.Drawing.Icon)(resources.GetObject("buttonItemNodeAdd.Icon")));
            this.buttonItemNodeAdd.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemNodeAdd.Name = "buttonItemNodeAdd";
            this.buttonItemNodeAdd.Text = "ایجاد شاخه";
            this.buttonItemNodeAdd.Click += new System.EventHandler(this.buttonItemNodeAdd_Click);
            // 
            // buttonItemChildAdd
            // 
            this.buttonItemChildAdd.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemChildAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.buttonItemChildAdd.FixedSize = new System.Drawing.Size(60, 60);
            this.buttonItemChildAdd.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemChildAdd.Icon = ((System.Drawing.Icon)(resources.GetObject("buttonItemChildAdd.Icon")));
            this.buttonItemChildAdd.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemChildAdd.Name = "buttonItemChildAdd";
            this.buttonItemChildAdd.Text = "ایجاد فرزند";
            this.buttonItemChildAdd.Click += new System.EventHandler(this.buttonItemChildAdd_Click);
            // 
            // buttonItemNodeEdit
            // 
            this.buttonItemNodeEdit.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemNodeEdit.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.buttonItemNodeEdit.FixedSize = new System.Drawing.Size(60, 60);
            this.buttonItemNodeEdit.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemNodeEdit.Icon = ((System.Drawing.Icon)(resources.GetObject("buttonItemNodeEdit.Icon")));
            this.buttonItemNodeEdit.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemNodeEdit.Name = "buttonItemNodeEdit";
            this.buttonItemNodeEdit.Text = "ویرایش";
            this.buttonItemNodeEdit.Click += new System.EventHandler(this.headerGridSoftwareAccess_btnEditClick);
            // 
            // buttonItemNodeDel
            // 
            this.buttonItemNodeDel.BeginGroup = true;
            this.buttonItemNodeDel.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemNodeDel.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.buttonItemNodeDel.FixedSize = new System.Drawing.Size(60, 60);
            this.buttonItemNodeDel.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemNodeDel.Icon = ((System.Drawing.Icon)(resources.GetObject("buttonItemNodeDel.Icon")));
            this.buttonItemNodeDel.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemNodeDel.Name = "buttonItemNodeDel";
            this.buttonItemNodeDel.Text = "حذف";
            this.buttonItemNodeDel.Click += new System.EventHandler(this.headerGridSoftwareAccess_btnDeleteClick);
            // 
            // buttonItemRefresh
            // 
            this.buttonItemRefresh.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemRefresh.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.buttonItemRefresh.FixedSize = new System.Drawing.Size(60, 60);
            this.buttonItemRefresh.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemRefresh.Icon = ((System.Drawing.Icon)(resources.GetObject("buttonItemRefresh.Icon")));
            this.buttonItemRefresh.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemRefresh.Name = "buttonItemRefresh";
            this.buttonItemRefresh.Text = "بازخوانی";
            this.buttonItemRefresh.Click += new System.EventHandler(this.buttonItemRefresh_Click);
            // 
            // SoftwareAccess_Frm
            // 
            this.ClientSize = new System.Drawing.Size(637, 446);
            this.Controls.Add(this.TreeViewSoftwareAccess);
            this.Controls.Add(this.mssItemPanel1);
            this.Controls.Add(this.con);
            this.Name = "SoftwareAccess_Frm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "دسترسی نرم افزار";
            this.Load += new System.EventHandler(this.SoftwareAccess_Frm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MSSGroupPanel con;
        private MSSTreeView TreeViewSoftwareAccess;
        private MSSItemPanel mssItemPanel1;
        private DevComponents.DotNetBar.ButtonItem buttonItemNodeAdd;
        private DevComponents.DotNetBar.ButtonItem buttonItemChildAdd;
        private DevComponents.DotNetBar.ButtonItem buttonItemNodeEdit;
        private DevComponents.DotNetBar.ButtonItem buttonItemNodeDel;
        private DevComponents.DotNetBar.ButtonItem buttonItemRefresh;
    }
}
