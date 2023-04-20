using MKH.Library.Control;
namespace MKH.Contacts.View.Forms
{
    partial class GroupTelMobAdd_Frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupTelMobAdd_Frm));
            this.TextBoxGroupName = new MKH.Library.Control.MSSTextBox(this.components);
            this.mssLabel1 = new MKH.Library.Control.MSSLabel(this.components);
            this.CheckBoxActive = new MKH.Library.Control.MSSCheckBox(this.components);
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
            this.ribbonBarNewBar.Location = new System.Drawing.Point(0, 131);
            this.ribbonBarNewBar.Size = new System.Drawing.Size(334, 63);
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
            this.mssGroupPanel1.Controls.Add(this.CheckBoxActive);
            this.mssGroupPanel1.Controls.Add(this.mssLabel1);
            this.mssGroupPanel1.Controls.Add(this.TextBoxGroupName);
            this.mssGroupPanel1.Size = new System.Drawing.Size(334, 97);
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
            // TextBoxGroupName
            // 
            this.TextBoxGroupName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.TextBoxGroupName.Border.Class = "TextBoxBorder";
            this.TextBoxGroupName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxGroupName.Location = new System.Drawing.Point(38, 28);
            this.TextBoxGroupName.Name = "TextBoxGroupName";
            this.TextBoxGroupName.Size = new System.Drawing.Size(207, 25);
            this.TextBoxGroupName.TabIndex = 0;
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
            this.mssLabel1.ForeColor = System.Drawing.Color.Black;
            this.mssLabel1.Location = new System.Drawing.Point(251, 30);
            this.mssLabel1.Name = "mssLabel1";
            this.mssLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mssLabel1.Size = new System.Drawing.Size(50, 18);
            this.mssLabel1.TabIndex = 1;
            this.mssLabel1.Text = "نام گروه:";
            // 
            // CheckBoxActive
            // 
            this.CheckBoxActive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckBoxActive.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.CheckBoxActive.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.CheckBoxActive.Checked = true;
            this.CheckBoxActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBoxActive.CheckValue = "Y";
            this.CheckBoxActive.Location = new System.Drawing.Point(145, 59);
            this.CheckBoxActive.Name = "CheckBoxActive";
            this.CheckBoxActive.Size = new System.Drawing.Size(100, 23);
            this.CheckBoxActive.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CheckBoxActive.TabIndex = 2;
            this.CheckBoxActive.Text = "فعال";
            this.CheckBoxActive.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // GroupTelMobAdd_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 194);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "GroupTelMobAdd_Frm";
            this.ShowInTaskbar = false;
            this.Text = "گروه";
            this.Load += new System.EventHandler(this.GroupTelMobAdd_Frm_Load);
            this.mssGroupPanel1.ResumeLayout(false);
            this.mssGroupPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MSSLabel mssLabel1;
        private MSSTextBox TextBoxGroupName;
        private MSSCheckBox CheckBoxActive;

    }
}