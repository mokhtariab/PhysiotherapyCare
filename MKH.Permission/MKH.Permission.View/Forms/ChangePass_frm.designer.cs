namespace MKH.Permission.View.Forms
{
    partial class ChangePass_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePass_frm));
            this.textBox_ReNewPass = new MKH.Library.Control.MSSTextBox();
            this.textBox_NewPass = new MKH.Library.Control.MSSTextBox();
            this.textBox_PrePass = new MKH.Library.Control.MSSTextBox();
            this.labelX_ReNewPass = new MKH.Library.Control.MSSLabel();
            this.labelX_NewPass = new MKH.Library.Control.MSSLabel();
            this.labelX_PrePass = new MKH.Library.Control.MSSLabel();
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
            this.ribbonBarNewBar.Location = new System.Drawing.Point(0, 154);
            this.ribbonBarNewBar.Size = new System.Drawing.Size(326, 55);
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
            this.mssGroupPanel1.Controls.Add(this.textBox_ReNewPass);
            this.mssGroupPanel1.Controls.Add(this.textBox_NewPass);
            this.mssGroupPanel1.Controls.Add(this.textBox_PrePass);
            this.mssGroupPanel1.Controls.Add(this.labelX_PrePass);
            this.mssGroupPanel1.Controls.Add(this.labelX_ReNewPass);
            this.mssGroupPanel1.Controls.Add(this.labelX_NewPass);
            this.mssGroupPanel1.Size = new System.Drawing.Size(326, 120);
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
            this.buttonItemOK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // textBox_ReNewPass
            // 
            // 
            // 
            // 
            this.textBox_ReNewPass.Border.Class = "TextBoxBorder";
            this.textBox_ReNewPass.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBox_ReNewPass.Location = new System.Drawing.Point(9, 76);
            this.textBox_ReNewPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_ReNewPass.Name = "textBox_ReNewPass";
            this.textBox_ReNewPass.PasswordChar = '*';
            this.textBox_ReNewPass.Size = new System.Drawing.Size(217, 24);
            this.textBox_ReNewPass.TabIndex = 2;
            // 
            // textBox_NewPass
            // 
            // 
            // 
            // 
            this.textBox_NewPass.Border.Class = "TextBoxBorder";
            this.textBox_NewPass.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBox_NewPass.Location = new System.Drawing.Point(9, 45);
            this.textBox_NewPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_NewPass.Name = "textBox_NewPass";
            this.textBox_NewPass.PasswordChar = '*';
            this.textBox_NewPass.Size = new System.Drawing.Size(217, 24);
            this.textBox_NewPass.TabIndex = 1;
            // 
            // textBox_PrePass
            // 
            // 
            // 
            // 
            this.textBox_PrePass.Border.Class = "TextBoxBorder";
            this.textBox_PrePass.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBox_PrePass.Location = new System.Drawing.Point(9, 14);
            this.textBox_PrePass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_PrePass.Name = "textBox_PrePass";
            this.textBox_PrePass.PasswordChar = '*';
            this.textBox_PrePass.Size = new System.Drawing.Size(217, 24);
            this.textBox_PrePass.TabIndex = 0;
            // 
            // labelX_ReNewPass
            // 
            this.labelX_ReNewPass.AutoSize = true;
            this.labelX_ReNewPass.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX_ReNewPass.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX_ReNewPass.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelX_ReNewPass.ForeColor = System.Drawing.Color.Maroon;
            this.labelX_ReNewPass.Location = new System.Drawing.Point(232, 76);
            this.labelX_ReNewPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelX_ReNewPass.Name = "labelX_ReNewPass";
            this.labelX_ReNewPass.Size = new System.Drawing.Size(80, 18);
            this.labelX_ReNewPass.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.labelX_ReNewPass.TabIndex = 14;
            this.labelX_ReNewPass.Text = "تکرار رمز جدید:";
            this.labelX_ReNewPass.WordWrap = true;
            // 
            // labelX_NewPass
            // 
            this.labelX_NewPass.AutoSize = true;
            this.labelX_NewPass.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX_NewPass.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX_NewPass.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelX_NewPass.ForeColor = System.Drawing.Color.Maroon;
            this.labelX_NewPass.Location = new System.Drawing.Point(232, 45);
            this.labelX_NewPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelX_NewPass.Name = "labelX_NewPass";
            this.labelX_NewPass.Size = new System.Drawing.Size(53, 18);
            this.labelX_NewPass.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.labelX_NewPass.TabIndex = 17;
            this.labelX_NewPass.Text = "رمز جدید:";
            // 
            // labelX_PrePass
            // 
            this.labelX_PrePass.AutoSize = true;
            this.labelX_PrePass.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX_PrePass.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX_PrePass.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelX_PrePass.ForeColor = System.Drawing.Color.Maroon;
            this.labelX_PrePass.Location = new System.Drawing.Point(232, 14);
            this.labelX_PrePass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelX_PrePass.Name = "labelX_PrePass";
            this.labelX_PrePass.Size = new System.Drawing.Size(55, 18);
            this.labelX_PrePass.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.labelX_PrePass.TabIndex = 12;
            this.labelX_PrePass.Text = "رمز فعلی:";
            // 
            // ChangePass_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 209);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "ChangePass_frm";
            this.ShowInTaskbar = false;
            this.mssGroupPanel1.ResumeLayout(false);
            this.mssGroupPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public MKH.Library.Control.MSSTextBox textBox_ReNewPass;
        public MKH.Library.Control.MSSTextBox textBox_NewPass;
        public MKH.Library.Control.MSSTextBox textBox_PrePass;
        private MKH.Library.Control.MSSLabel labelX_ReNewPass;
        private MKH.Library.Control.MSSLabel labelX_NewPass;
        private MKH.Library.Control.MSSLabel labelX_PrePass;
    }
}