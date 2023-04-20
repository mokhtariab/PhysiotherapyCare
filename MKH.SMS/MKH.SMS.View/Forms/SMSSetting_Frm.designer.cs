
using MKH.Library.Control;
namespace MKH.SMS.View.Forms
{
    partial class SMSSetting_Frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SMSSetting_Frm));
            this.mssLabel18 = new MKH.Library.Control.MSSLabel(this.components);
            this.textBoxUserName = new MKH.Library.Control.MSSTextBox(this.components);
            this.mssPanel3 = new MKH.Library.Control.MSSPanel(this.components);
            this.buttonTestCredit = new MKH.Library.Control.MSSButton(this.components);
            this.textBoxTelNumber = new MKH.Library.Control.MSSTextBox(this.components);
            this.mssLabel7 = new MKH.Library.Control.MSSLabel(this.components);
            this.textBoxPassword = new MKH.Library.Control.MSSTextBox(this.components);
            this.mssLabel6 = new MKH.Library.Control.MSSLabel(this.components);
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
            this.ribbonBarNewBar.Location = new System.Drawing.Point(0, 272);
            this.ribbonBarNewBar.Size = new System.Drawing.Size(509, 57);
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
            this.mssGroupPanel1.Size = new System.Drawing.Size(509, 238);
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
            // mssLabel18
            // 
            this.mssLabel18.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mssLabel18.AutoSize = true;
            this.mssLabel18.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.mssLabel18.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mssLabel18.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mssLabel18.ForeColor = System.Drawing.Color.Black;
            this.mssLabel18.Location = new System.Drawing.Point(127, 36);
            this.mssLabel18.Name = "mssLabel18";
            this.mssLabel18.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mssLabel18.Size = new System.Drawing.Size(66, 18);
            this.mssLabel18.TabIndex = 2;
            this.mssLabel18.Text = "UserName:";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.textBoxUserName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxUserName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserName.Location = new System.Drawing.Point(212, 36);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxUserName.Size = new System.Drawing.Size(171, 16);
            this.textBoxUserName.TabIndex = 15;
            // 
            // mssPanel3
            // 
            this.mssPanel3.CanvasColor = System.Drawing.SystemColors.Control;
            this.mssPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.mssPanel3.Controls.Add(this.buttonTestCredit);
            this.mssPanel3.Controls.Add(this.textBoxTelNumber);
            this.mssPanel3.Controls.Add(this.mssLabel7);
            this.mssPanel3.Controls.Add(this.textBoxPassword);
            this.mssPanel3.Controls.Add(this.mssLabel6);
            this.mssPanel3.Controls.Add(this.textBoxUserName);
            this.mssPanel3.Controls.Add(this.mssLabel18);
            this.mssPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mssPanel3.Location = new System.Drawing.Point(0, 0);
            this.mssPanel3.Name = "mssPanel3";
            this.mssPanel3.Size = new System.Drawing.Size(503, 232);
            this.mssPanel3.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.mssPanel3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.mssPanel3.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.mssPanel3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.mssPanel3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.mssPanel3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.mssPanel3.Style.GradientAngle = 90;
            this.mssPanel3.TabIndex = 65;
            // 
            // buttonTestCredit
            // 
            this.buttonTestCredit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonTestCredit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonTestCredit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonTestCredit.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonTestCredit.Location = new System.Drawing.Point(199, 128);
            this.buttonTestCredit.Name = "buttonTestCredit";
            this.buttonTestCredit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonTestCredit.Size = new System.Drawing.Size(184, 23);
            this.buttonTestCredit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonTestCredit.TabIndex = 62;
            this.buttonTestCredit.Text = "Test & Credit";
            this.buttonTestCredit.Click += new System.EventHandler(this.buttonTestCredit_Click);
            // 
            // textBoxTelNumber
            // 
            this.textBoxTelNumber.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.textBoxTelNumber.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxTelNumber.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTelNumber.Location = new System.Drawing.Point(212, 93);
            this.textBoxTelNumber.Name = "textBoxTelNumber";
            this.textBoxTelNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxTelNumber.Size = new System.Drawing.Size(171, 16);
            this.textBoxTelNumber.TabIndex = 15;
            // 
            // mssLabel7
            // 
            this.mssLabel7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mssLabel7.AutoSize = true;
            this.mssLabel7.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.mssLabel7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mssLabel7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mssLabel7.ForeColor = System.Drawing.Color.Black;
            this.mssLabel7.Location = new System.Drawing.Point(126, 93);
            this.mssLabel7.Name = "mssLabel7";
            this.mssLabel7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mssLabel7.Size = new System.Drawing.Size(70, 18);
            this.mssLabel7.TabIndex = 2;
            this.mssLabel7.Text = "TelNumber:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.textBoxPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxPassword.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(212, 65);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxPassword.Size = new System.Drawing.Size(171, 16);
            this.textBoxPassword.TabIndex = 15;
            // 
            // mssLabel6
            // 
            this.mssLabel6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mssLabel6.AutoSize = true;
            this.mssLabel6.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.mssLabel6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mssLabel6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mssLabel6.ForeColor = System.Drawing.Color.Black;
            this.mssLabel6.Location = new System.Drawing.Point(128, 65);
            this.mssLabel6.Name = "mssLabel6";
            this.mssLabel6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mssLabel6.Size = new System.Drawing.Size(61, 18);
            this.mssLabel6.TabIndex = 2;
            this.mssLabel6.Text = "Password:";
            // 
            // SMSSetting_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(509, 329);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 197);
            this.Name = "SMSSetting_Frm";
            this.Text = "تنظیمات SMS";
            this.Load += new System.EventHandler(this.SMSSetting_Frm_Load);
            this.mssGroupPanel1.ResumeLayout(false);
            this.mssPanel3.ResumeLayout(false);
            this.mssPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MSSTextBox textBoxUserName;
        private MSSLabel mssLabel18;
        private MSSPanel mssPanel3;
        private MSSTextBox textBoxTelNumber;
        private MSSLabel mssLabel7;
        private MSSTextBox textBoxPassword;
        private MSSLabel mssLabel6;
        private MSSButton buttonTestCredit;


    }
}
