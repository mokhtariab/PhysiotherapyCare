using MKH.Library.Control;

namespace PhysiotherapyCare.View.MainForms.VisitHealthCare
{
    partial class ServiceTypeDscAdd_Frm
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
            this.textBoxTitleName = new MKH.Library.Control.MSSTextBox(this.components);
            this.label1 = new MKH.Library.Control.MSSLabel(this.components);
            this.mssLabel1 = new MKH.Library.Control.MSSLabel(this.components);
            this.ComboBoxServiceType = new MKH.Library.Control.MSSComboBox();
            this.mssLabel2 = new MKH.Library.Control.MSSLabel(this.components);
            this.IntBoxPriceType = new MKH.Library.Control.MSSIntBox(this.components);
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
            this.ribbonBarNewBar.Location = new System.Drawing.Point(0, 136);
            this.ribbonBarNewBar.Size = new System.Drawing.Size(358, 57);
            this.ribbonBarNewBar.TabIndex = 2;
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
            this.mssGroupPanel1.Controls.Add(this.IntBoxPriceType);
            this.mssGroupPanel1.Controls.Add(this.ComboBoxServiceType);
            this.mssGroupPanel1.Controls.Add(this.textBoxTitleName);
            this.mssGroupPanel1.Controls.Add(this.mssLabel1);
            this.mssGroupPanel1.Controls.Add(this.mssLabel2);
            this.mssGroupPanel1.Controls.Add(this.label1);
            this.mssGroupPanel1.Size = new System.Drawing.Size(358, 102);
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
            this.mssGroupPanel1.TabIndex = 1;
            // 
            // buttonItemOK
            // 
            this.buttonItemOK.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // textBoxTitleName
            // 
            this.textBoxTitleName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.textBoxTitleName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxTitleName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTitleName.Location = new System.Drawing.Point(34, 40);
            this.textBoxTitleName.Name = "textBoxTitleName";
            this.textBoxTitleName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxTitleName.Size = new System.Drawing.Size(199, 16);
            this.textBoxTitleName.TabIndex = 2;
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
            this.label1.Location = new System.Drawing.Point(239, 40);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "شرح خدمت:";
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
            this.mssLabel1.Location = new System.Drawing.Point(239, 17);
            this.mssLabel1.Name = "mssLabel1";
            this.mssLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mssLabel1.Size = new System.Drawing.Size(52, 15);
            this.mssLabel1.TabIndex = 2;
            this.mssLabel1.Text = "نوع خدمت:";
            // 
            // ComboBoxServiceType
            // 
            this.ComboBoxServiceType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxServiceType.DisplayMember = "Text";
            this.ComboBoxServiceType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxServiceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxServiceType.FormattingEnabled = true;
            this.ComboBoxServiceType.ItemHeight = 14;
            this.ComboBoxServiceType.Location = new System.Drawing.Point(34, 12);
            this.ComboBoxServiceType.Name = "ComboBoxServiceType";
            this.ComboBoxServiceType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ComboBoxServiceType.Size = new System.Drawing.Size(199, 20);
            this.ComboBoxServiceType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ComboBoxServiceType.TabIndex = 1;
            // 
            // mssLabel2
            // 
            this.mssLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mssLabel2.AutoSize = true;
            this.mssLabel2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.mssLabel2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mssLabel2.Font = new System.Drawing.Font("Tahoma", 8F);
            this.mssLabel2.ForeColor = System.Drawing.Color.Black;
            this.mssLabel2.Location = new System.Drawing.Point(239, 67);
            this.mssLabel2.Name = "mssLabel2";
            this.mssLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mssLabel2.Size = new System.Drawing.Size(57, 15);
            this.mssLabel2.TabIndex = 2;
            this.mssLabel2.Text = "مبلغ خدمت:";
            // 
            // IntBoxPriceType
            // 
            this.IntBoxPriceType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IntBoxPriceType.Location = new System.Drawing.Point(34, 64);
            this.IntBoxPriceType.Name = "IntBoxPriceType";
            this.IntBoxPriceType.Size = new System.Drawing.Size(199, 20);
            this.IntBoxPriceType.TabIndex = 3;
            this.IntBoxPriceType.Text = "0";
            this.IntBoxPriceType.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
            this.IntBoxPriceType.Value = 0;
            this.IntBoxPriceType.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int32;
            // 
            // ServiceTypeDscAdd_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(358, 193);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 280);
            this.MinimumSize = new System.Drawing.Size(300, 197);
            this.Name = "ServiceTypeDscAdd_Frm";
            this.Text = "شرح خدمت";
            this.Load += new System.EventHandler(this.ServiceTypeDscAdd_Frm_Load);
            this.mssGroupPanel1.ResumeLayout(false);
            this.mssGroupPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MSSTextBox textBoxTitleName;
        private MSSLabel label1;
        private MSSLabel mssLabel1;
        private MSSComboBox ComboBoxServiceType;
        private MSSLabel mssLabel2;
        private MSSIntBox IntBoxPriceType;


    }




    
}
