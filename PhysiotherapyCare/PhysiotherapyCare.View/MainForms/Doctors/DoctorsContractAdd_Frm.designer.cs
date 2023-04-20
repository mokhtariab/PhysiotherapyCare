
using MKH.Library.Control;
namespace PhysiotherapyCare.View.MainForms.Doctors
{
    partial class DoctorsContractAdd_Frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorsContractAdd_Frm));
            this.mssLabel7 = new MKH.Library.Control.MSSLabel(this.components);
            this.TextBoxContractNo = new MKH.Library.Control.MSSTextBox(this.components);
            this.mssLabel8 = new MKH.Library.Control.MSSLabel(this.components);
            this.DatePickerContractDate = new MKH.Library.Control.MSSDatePicker(this.components);
            this.DatePickerContractEndDate = new MKH.Library.Control.MSSDatePicker(this.components);
            this.mssLabel1 = new MKH.Library.Control.MSSLabel(this.components);
            this.IntBoxContractPercent = new MKH.Library.Control.MSSIntBox(this.components);
            this.mssLabel16 = new MKH.Library.Control.MSSLabel(this.components);
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
            this.ribbonBarNewBar.Location = new System.Drawing.Point(0, 166);
            this.ribbonBarNewBar.Size = new System.Drawing.Size(366, 57);
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
            this.mssGroupPanel1.Controls.Add(this.IntBoxContractPercent);
            this.mssGroupPanel1.Controls.Add(this.mssLabel16);
            this.mssGroupPanel1.Controls.Add(this.DatePickerContractEndDate);
            this.mssGroupPanel1.Controls.Add(this.mssLabel1);
            this.mssGroupPanel1.Controls.Add(this.DatePickerContractDate);
            this.mssGroupPanel1.Controls.Add(this.mssLabel8);
            this.mssGroupPanel1.Controls.Add(this.TextBoxContractNo);
            this.mssGroupPanel1.Controls.Add(this.mssLabel7);
            this.mssGroupPanel1.Size = new System.Drawing.Size(366, 132);
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
            // mssLabel7
            // 
            this.mssLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mssLabel7.AutoSize = true;
            this.mssLabel7.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.mssLabel7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mssLabel7.Font = new System.Drawing.Font("Tahoma", 8F);
            this.mssLabel7.ForeColor = System.Drawing.Color.Black;
            this.mssLabel7.Location = new System.Drawing.Point(262, 13);
            this.mssLabel7.Name = "mssLabel7";
            this.mssLabel7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mssLabel7.Size = new System.Drawing.Size(66, 15);
            this.mssLabel7.TabIndex = 2;
            this.mssLabel7.Text = "شماره قرارداد:";
            // 
            // TextBoxContractNo
            // 
            this.TextBoxContractNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.TextBoxContractNo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxContractNo.Font = new System.Drawing.Font("Tahoma", 8F);
            this.TextBoxContractNo.Location = new System.Drawing.Point(75, 14);
            this.TextBoxContractNo.Name = "TextBoxContractNo";
            this.TextBoxContractNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TextBoxContractNo.Size = new System.Drawing.Size(177, 13);
            this.TextBoxContractNo.TabIndex = 1;
            // 
            // mssLabel8
            // 
            this.mssLabel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mssLabel8.AutoSize = true;
            this.mssLabel8.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.mssLabel8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mssLabel8.Font = new System.Drawing.Font("Tahoma", 8F);
            this.mssLabel8.ForeColor = System.Drawing.Color.Black;
            this.mssLabel8.Location = new System.Drawing.Point(262, 42);
            this.mssLabel8.Name = "mssLabel8";
            this.mssLabel8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mssLabel8.Size = new System.Drawing.Size(87, 15);
            this.mssLabel8.TabIndex = 2;
            this.mssLabel8.Text = "تاریخ شروع قرارداد:";
            // 
            // DatePickerContractDate
            // 
            this.DatePickerContractDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DatePickerContractDate.BackColor = System.Drawing.Color.White;
            this.DatePickerContractDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.DatePickerContractDate.Location = new System.Drawing.Point(138, 40);
            this.DatePickerContractDate.Name = "DatePickerContractDate";
            this.DatePickerContractDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DatePickerContractDate.ShowTime = false;
            this.DatePickerContractDate.Size = new System.Drawing.Size(115, 18);
            this.DatePickerContractDate.TabIndex = 2;
            this.DatePickerContractDate.Text = "mssDatePicker1";
            this.DatePickerContractDate.UseFarsiDigits = true;
            this.DatePickerContractDate.Value = ((KagNetComponents2.KagPersianDate)(resources.GetObject("DatePickerContractDate.Value")));
            this.DatePickerContractDate.ValueEn = new System.DateTime(2015, 9, 20, 19, 9, 34, 0);
            // 
            // DatePickerContractEndDate
            // 
            this.DatePickerContractEndDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DatePickerContractEndDate.BackColor = System.Drawing.Color.White;
            this.DatePickerContractEndDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.DatePickerContractEndDate.Location = new System.Drawing.Point(138, 70);
            this.DatePickerContractEndDate.Name = "DatePickerContractEndDate";
            this.DatePickerContractEndDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DatePickerContractEndDate.ShowTime = false;
            this.DatePickerContractEndDate.Size = new System.Drawing.Size(115, 18);
            this.DatePickerContractEndDate.TabIndex = 3;
            this.DatePickerContractEndDate.Text = "mssDatePicker1";
            this.DatePickerContractEndDate.UseFarsiDigits = true;
            this.DatePickerContractEndDate.Value = ((KagNetComponents2.KagPersianDate)(resources.GetObject("DatePickerContractEndDate.Value")));
            this.DatePickerContractEndDate.ValueEn = new System.DateTime(2015, 9, 20, 19, 9, 34, 0);
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
            this.mssLabel1.Location = new System.Drawing.Point(262, 71);
            this.mssLabel1.Name = "mssLabel1";
            this.mssLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mssLabel1.Size = new System.Drawing.Size(81, 15);
            this.mssLabel1.TabIndex = 5;
            this.mssLabel1.Text = "تاریخ پایان قرارداد:";
            // 
            // IntBoxContractPercent
            // 
            this.IntBoxContractPercent.Location = new System.Drawing.Point(137, 99);
            this.IntBoxContractPercent.Name = "IntBoxContractPercent";
            this.IntBoxContractPercent.Size = new System.Drawing.Size(115, 20);
            this.IntBoxContractPercent.TabIndex = 4;
            this.IntBoxContractPercent.Text = "0";
            this.IntBoxContractPercent.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
            this.IntBoxContractPercent.Value = 0;
            this.IntBoxContractPercent.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int32;
            // 
            // mssLabel16
            // 
            this.mssLabel16.AutoSize = true;
            this.mssLabel16.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.mssLabel16.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mssLabel16.Font = new System.Drawing.Font("Tahoma", 8F);
            this.mssLabel16.ForeColor = System.Drawing.Color.Black;
            this.mssLabel16.Location = new System.Drawing.Point(260, 101);
            this.mssLabel16.Name = "mssLabel16";
            this.mssLabel16.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mssLabel16.Size = new System.Drawing.Size(60, 15);
            this.mssLabel16.TabIndex = 7;
            this.mssLabel16.Text = "درصد قرارداد:";
            // 
            // DoctorsContractAdd_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(366, 223);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 197);
            this.Name = "DoctorsContractAdd_Frm";
            this.Text = "قرارداد فیزیوتراپ و بهیار";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DoctorsContractAdd_Frm_FormClosed);
            this.Load += new System.EventHandler(this.DoctorsContractAdd_Frm_Load);
            this.mssGroupPanel1.ResumeLayout(false);
            this.mssGroupPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MSSDatePicker DatePickerContractDate;
        private MSSTextBox TextBoxContractNo;
        private MSSLabel mssLabel8;
        private MSSLabel mssLabel7;
        private MSSDatePicker DatePickerContractEndDate;
        private MSSLabel mssLabel1;
        private MSSIntBox IntBoxContractPercent;
        private MSSLabel mssLabel16;


    }
}
