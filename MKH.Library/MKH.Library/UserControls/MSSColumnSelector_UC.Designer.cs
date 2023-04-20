namespace MKH.Library.UserControls
{
    partial class MSSColumnSelector_UC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MSSColumnSelector_UC));
            this.mssGroupPanel1 = new MKH.Library.Control.MSSGroupPanel(this.components);
            this.itemPanelSelector = new DevComponents.DotNetBar.ItemPanel();
            this.checkBoxItem1 = new DevComponents.DotNetBar.CheckBoxItem();
            this.mssPanel1 = new MKH.Library.Control.MSSPanel(this.components);
            this.ButtonSelect = new MKH.Library.Control.MSSButton(this.components);
            this.mssGroupPanel2 = new MKH.Library.Control.MSSGroupPanel(this.components);
            this.buttonDel = new MKH.Library.Control.MSSButton(this.components);
            this.buttonSave = new MKH.Library.Control.MSSButton(this.components);
            this.comboBoxSelector = new MKH.Library.Control.MSSComboBox();
            this.mssGroupPanel1.SuspendLayout();
            this.mssPanel1.SuspendLayout();
            this.mssGroupPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mssGroupPanel1
            // 
            this.mssGroupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.mssGroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.mssGroupPanel1.Controls.Add(this.itemPanelSelector);
            this.mssGroupPanel1.Controls.Add(this.mssPanel1);
            this.mssGroupPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mssGroupPanel1.Location = new System.Drawing.Point(222, 0);
            this.mssGroupPanel1.Name = "mssGroupPanel1";
            this.mssGroupPanel1.Size = new System.Drawing.Size(530, 84);
            // 
            // 
            // 
            this.mssGroupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.mssGroupPanel1.Style.BackColorGradientAngle = 90;
            this.mssGroupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
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
            this.mssGroupPanel1.TabIndex = 99;
            this.mssGroupPanel1.Text = "انتخاب ستونها";
            // 
            // itemPanelSelector
            // 
            this.itemPanelSelector.AutoScroll = true;
            // 
            // 
            // 
            this.itemPanelSelector.BackgroundStyle.Class = "ItemPanel";
            this.itemPanelSelector.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemPanelSelector.ContainerControlProcessDialogKey = true;
            this.itemPanelSelector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemPanelSelector.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.checkBoxItem1});
            this.itemPanelSelector.Location = new System.Drawing.Point(0, 0);
            this.itemPanelSelector.MultiLine = true;
            this.itemPanelSelector.Name = "itemPanelSelector";
            this.itemPanelSelector.ResizeItemsToFit = false;
            this.itemPanelSelector.Size = new System.Drawing.Size(494, 63);
            this.itemPanelSelector.TabIndex = 100;
            this.itemPanelSelector.Text = "itemPanelSelectColumn";
            // 
            // checkBoxItem1
            // 
            this.checkBoxItem1.Name = "checkBoxItem1";
            this.checkBoxItem1.Text = "checkBoxItem1";
            // 
            // mssPanel1
            // 
            this.mssPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.mssPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.mssPanel1.Controls.Add(this.ButtonSelect);
            this.mssPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.mssPanel1.Location = new System.Drawing.Point(494, 0);
            this.mssPanel1.Name = "mssPanel1";
            this.mssPanel1.Size = new System.Drawing.Size(30, 63);
            this.mssPanel1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.mssPanel1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.mssPanel1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.mssPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.mssPanel1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.mssPanel1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.mssPanel1.Style.GradientAngle = 90;
            this.mssPanel1.TabIndex = 102;
            // 
            // ButtonSelect
            // 
            this.ButtonSelect.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonSelect.AutoCheckOnClick = true;
            this.ButtonSelect.Checked = true;
            this.ButtonSelect.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.ButtonSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonSelect.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ButtonSelect.Image = ((System.Drawing.Image)(resources.GetObject("ButtonSelect.Image")));
            this.ButtonSelect.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.ButtonSelect.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.ButtonSelect.Location = new System.Drawing.Point(0, 0);
            this.ButtonSelect.Name = "ButtonSelect";
            this.ButtonSelect.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ButtonSelect.Size = new System.Drawing.Size(30, 63);
            this.ButtonSelect.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonSelect.TabIndex = 101;
            this.ButtonSelect.Text = "عدم/انتخاب همه";
            this.ButtonSelect.CheckedChanged += new System.EventHandler(this.ButtonSelect_CheckedChanged);
            // 
            // mssGroupPanel2
            // 
            this.mssGroupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.mssGroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.mssGroupPanel2.Controls.Add(this.buttonDel);
            this.mssGroupPanel2.Controls.Add(this.buttonSave);
            this.mssGroupPanel2.Controls.Add(this.comboBoxSelector);
            this.mssGroupPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.mssGroupPanel2.Location = new System.Drawing.Point(0, 0);
            this.mssGroupPanel2.Name = "mssGroupPanel2";
            this.mssGroupPanel2.Size = new System.Drawing.Size(222, 84);
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
            this.mssGroupPanel2.TabIndex = 100;
            this.mssGroupPanel2.Text = "ذخیره سازی";
            // 
            // buttonDel
            // 
            this.buttonDel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonDel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonDel.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.buttonDel.Image = ((System.Drawing.Image)(resources.GetObject("buttonDel.Image")));
            this.buttonDel.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.buttonDel.Location = new System.Drawing.Point(10, 36);
            this.buttonDel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonDel.Size = new System.Drawing.Size(65, 24);
            this.buttonDel.TabIndex = 98;
            this.buttonDel.Text = "حذف";
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonSave.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.buttonSave.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave.Image")));
            this.buttonSave.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.buttonSave.Location = new System.Drawing.Point(81, 36);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonSave.Size = new System.Drawing.Size(73, 24);
            this.buttonSave.TabIndex = 97;
            this.buttonSave.Text = "ذخیره";
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // comboBoxSelector
            // 
            this.comboBoxSelector.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBoxSelector.DisplayMember = "Text";
            this.comboBoxSelector.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxSelector.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.comboBoxSelector.ItemHeight = 15;
            this.comboBoxSelector.Location = new System.Drawing.Point(4, 8);
            this.comboBoxSelector.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxSelector.Name = "comboBoxSelector";
            this.comboBoxSelector.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBoxSelector.Size = new System.Drawing.Size(202, 21);
            this.comboBoxSelector.TabIndex = 96;
            this.comboBoxSelector.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelector_SelectedIndexChanged);
            // 
            // MSSColumnSelector_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mssGroupPanel1);
            this.Controls.Add(this.mssGroupPanel2);
            this.Font = new System.Drawing.Font("Tahoma", 7.841584F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "MSSColumnSelector_UC";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(752, 84);
            this.Load += new System.EventHandler(this.MSSColumnSelector_UC_Load);
            this.mssGroupPanel1.ResumeLayout(false);
            this.mssPanel1.ResumeLayout(false);
            this.mssGroupPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Control.MSSButton buttonSave;
        private Control.MSSComboBox comboBoxSelector;
        private DevComponents.DotNetBar.ItemPanel itemPanelSelector;
        private DevComponents.DotNetBar.CheckBoxItem checkBoxItem1;
        private Control.MSSGroupPanel mssGroupPanel1;
        private Control.MSSGroupPanel mssGroupPanel2;
        private Control.MSSButton buttonDel;
        private Control.MSSButton ButtonSelect;
        private Control.MSSPanel mssPanel1;
    }
}
