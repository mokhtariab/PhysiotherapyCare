using MKH.Library.Control;

namespace MKH.Permission.View.BaseForms
{
    partial class SoftwareAccessAdd_Frm
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
            this.textBoxResourceNameFarsi = new MKH.Library.Control.MSSTextBox(this.components);
            this.label1 = new MKH.Library.Control.MSSLabel(this.components);
            this.checkBoxIsActive = new MKH.Library.Control.MSSCheckBox(this.components);
            this.mssLabel1 = new MKH.Library.Control.MSSLabel(this.components);
            this.TextBoxResourceName = new MKH.Library.Control.MSSTextBox(this.components);
            this.mssGroupPanel1.SuspendLayout();
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
            this.ribbonBarNewBar.Location = new System.Drawing.Point(0, 156);
            this.ribbonBarNewBar.Size = new System.Drawing.Size(437, 66);
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
            this.mssGroupPanel1.Controls.Add(this.checkBoxIsActive);
            this.mssGroupPanel1.Controls.Add(this.TextBoxResourceName);
            this.mssGroupPanel1.Controls.Add(this.mssLabel1);
            this.mssGroupPanel1.Controls.Add(this.textBoxResourceNameFarsi);
            this.mssGroupPanel1.Controls.Add(this.label1);
            this.mssGroupPanel1.Size = new System.Drawing.Size(437, 122);
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
            this.buttonItemOK.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // textBoxResourceNameFarsi
            // 
            this.textBoxResourceNameFarsi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.textBoxResourceNameFarsi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxResourceNameFarsi.Font = new System.Drawing.Font("Tahoma", 8F);
            this.textBoxResourceNameFarsi.Location = new System.Drawing.Point(29, 22);
            this.textBoxResourceNameFarsi.Name = "textBoxResourceNameFarsi";
            this.textBoxResourceNameFarsi.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxResourceNameFarsi.Size = new System.Drawing.Size(282, 17);
            this.textBoxResourceNameFarsi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.label1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(325, 22);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "عنوان فارسی :";
            // 
            // checkBoxIsActive
            // 
            this.checkBoxIsActive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxIsActive.AutoSize = true;
            this.checkBoxIsActive.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.checkBoxIsActive.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxIsActive.Font = new System.Drawing.Font("Tahoma", 8F);
            this.checkBoxIsActive.Location = new System.Drawing.Point(267, 90);
            this.checkBoxIsActive.Name = "checkBoxIsActive";
            this.checkBoxIsActive.Size = new System.Drawing.Size(44, 17);
            this.checkBoxIsActive.TabIndex = 59;
            this.checkBoxIsActive.Text = "فعال";
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
            this.mssLabel1.Location = new System.Drawing.Point(325, 55);
            this.mssLabel1.Name = "mssLabel1";
            this.mssLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mssLabel1.Size = new System.Drawing.Size(61, 17);
            this.mssLabel1.TabIndex = 2;
            this.mssLabel1.Text = "عنوان لاتین:";
            // 
            // TextBoxResourceName
            // 
            this.TextBoxResourceName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.TextBoxResourceName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxResourceName.Font = new System.Drawing.Font("Tahoma", 8F);
            this.TextBoxResourceName.Location = new System.Drawing.Point(29, 55);
            this.TextBoxResourceName.Name = "TextBoxResourceName";
            this.TextBoxResourceName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TextBoxResourceName.Size = new System.Drawing.Size(282, 17);
            this.TextBoxResourceName.TabIndex = 1;
            // 
            // SoftwareAccessAdd_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.ClientSize = new System.Drawing.Size(437, 222);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1164, 320);
            this.MinimumSize = new System.Drawing.Size(347, 223);
            this.Name = "SoftwareAccessAdd_Frm";
            this.Text = "دسترسی نرم افزار";
            this.mssGroupPanel1.ResumeLayout(false);
            this.mssGroupPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MSSTextBox textBoxResourceNameFarsi;
        private MSSLabel label1;
        private MSSCheckBox checkBoxIsActive;
        private MSSTextBox TextBoxResourceName;
        private MSSLabel mssLabel1;


    }
}
