namespace MKH.Library.Forms
{
    partial class MSSBaseNew_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MSSBaseNew_frm));
            this.ribbonBarNewBar = new MKH.Library.Control.MSSRibbonBar(this.components);
            this.buttonItemOK = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemCancel = new DevComponents.DotNetBar.ButtonItem();
            this.mssGroupPanel1 = new MKH.Library.Control.MSSGroupPanel(this.components);
            this.mssPanel1 = new MKH.Library.Control.MSSPanel(this.components);
            this.SuspendLayout();
            // 
            // ribbonBarNewBar
            // 
            this.ribbonBarNewBar.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBarNewBar.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBarNewBar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBarNewBar.ContainerControlProcessDialogKey = true;
            this.ribbonBarNewBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ribbonBarNewBar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ribbonBarNewBar.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItemOK,
            this.buttonItemCancel});
            this.ribbonBarNewBar.Location = new System.Drawing.Point(0, 475);
            this.ribbonBarNewBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbonBarNewBar.Name = "ribbonBarNewBar";
            this.ribbonBarNewBar.Size = new System.Drawing.Size(607, 55);
            this.ribbonBarNewBar.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
            this.ribbonBarNewBar.TabIndex = 3;
            // 
            // 
            // 
            this.ribbonBarNewBar.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBarNewBar.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBarNewBar.TitleVisible = false;
            // 
            // buttonItemOK
            // 
            this.buttonItemOK.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemOK.FixedSize = new System.Drawing.Size(160, 60);
            this.buttonItemOK.HotFontBold = true;
            this.buttonItemOK.Image = ((System.Drawing.Image)(resources.GetObject("buttonItemOK.Image")));
            this.buttonItemOK.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.buttonItemOK.ImagePaddingHorizontal = 20;
            this.buttonItemOK.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemOK.Name = "buttonItemOK";
            this.buttonItemOK.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F2);
            this.buttonItemOK.SubItemsExpandWidth = 20;
            this.buttonItemOK.Text = "تایید و بسته شدن";
            // 
            // buttonItemCancel
            // 
            this.buttonItemCancel.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemCancel.FixedSize = new System.Drawing.Size(80, 60);
            this.buttonItemCancel.HotFontBold = true;
            this.buttonItemCancel.Image = ((System.Drawing.Image)(resources.GetObject("buttonItemCancel.Image")));
            this.buttonItemCancel.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.buttonItemCancel.ImagePaddingHorizontal = 20;
            this.buttonItemCancel.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemCancel.Name = "buttonItemCancel";
            this.buttonItemCancel.SubItemsExpandWidth = 14;
            this.buttonItemCancel.Text = "انصراف";
            this.buttonItemCancel.Click += new System.EventHandler(this.buttonItem_Cancel_Click);
            // 
            // mssGroupPanel1
            // 
            this.mssGroupPanel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mssGroupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.mssGroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.mssGroupPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mssGroupPanel1.Location = new System.Drawing.Point(0, 34);
            this.mssGroupPanel1.Name = "mssGroupPanel1";
            this.mssGroupPanel1.Size = new System.Drawing.Size(607, 441);
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
            this.mssGroupPanel1.TabIndex = 5;
            // 
            // mssPanel1
            // 
            this.mssPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.mssPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.mssPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.mssPanel1.Location = new System.Drawing.Point(0, 0);
            this.mssPanel1.Name = "mssPanel1";
            this.mssPanel1.Size = new System.Drawing.Size(607, 34);
            this.mssPanel1.Style.BackColor1.Color = System.Drawing.Color.White;
            this.mssPanel1.Style.BackColor2.Color = System.Drawing.Color.LightBlue;
            this.mssPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.mssPanel1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.mssPanel1.Style.ForeColor.Color = System.Drawing.Color.Maroon;
            this.mssPanel1.Style.GradientAngle = 90;
            this.mssPanel1.Style.MarginLeft = 15;
            this.mssPanel1.TabIndex = 4;
            // 
            // MSSBaseNew_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 530);
            this.Controls.Add(this.mssGroupPanel1);
            this.Controls.Add(this.mssPanel1);
            this.Controls.Add(this.ribbonBarNewBar);
            this.Font = new System.Drawing.Font("Tahoma", 7.841584F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MSSBaseNew_frm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MSSBaseNew_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonItem buttonItemCancel;
        protected MKH.Library.Control.MSSRibbonBar ribbonBarNewBar;
        protected Control.MSSGroupPanel mssGroupPanel1;
        private Control.MSSPanel mssPanel1;
        protected DevComponents.DotNetBar.ButtonItem buttonItemOK;
    }
}