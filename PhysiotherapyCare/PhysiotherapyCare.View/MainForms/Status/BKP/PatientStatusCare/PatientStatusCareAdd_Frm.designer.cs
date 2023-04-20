
using MKH.Library.Control;
namespace PhysiotherapyCare.View.MainForms.PatientStatusCare
{
    partial class PatientStatusCareAdd_Frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientStatusCareAdd_Frm));
            this.mssLabel8 = new MKH.Library.Control.MSSLabel(this.components);
            this.DatePickerStatusDate = new MKH.Library.Control.MSSDatePicker(this.components);
            this.mssLabel1 = new MKH.Library.Control.MSSLabel(this.components);
            this.ComboBoxPatientStatusType = new MKH.Library.Control.MSSComboBox();
            this.checkBoxIsDo = new MKH.Library.Control.MSSCheckBox(this.components);
            this.TextBoxDescription = new MKH.Library.Control.MSSTextBox(this.components);
            this.mssLabel17 = new MKH.Library.Control.MSSLabel(this.components);
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
            this.ribbonBarNewBar.Location = new System.Drawing.Point(0, 202);
            this.ribbonBarNewBar.Size = new System.Drawing.Size(431, 57);
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
            this.mssGroupPanel1.Controls.Add(this.TextBoxDescription);
            this.mssGroupPanel1.Controls.Add(this.mssLabel17);
            this.mssGroupPanel1.Controls.Add(this.checkBoxIsDo);
            this.mssGroupPanel1.Controls.Add(this.ComboBoxPatientStatusType);
            this.mssGroupPanel1.Controls.Add(this.mssLabel1);
            this.mssGroupPanel1.Controls.Add(this.DatePickerStatusDate);
            this.mssGroupPanel1.Controls.Add(this.mssLabel8);
            this.mssGroupPanel1.Size = new System.Drawing.Size(431, 168);
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
            this.mssLabel8.Location = new System.Drawing.Point(345, 13);
            this.mssLabel8.Name = "mssLabel8";
            this.mssLabel8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mssLabel8.Size = new System.Drawing.Size(27, 15);
            this.mssLabel8.TabIndex = 2;
            this.mssLabel8.Text = "تاریخ:";
            // 
            // DatePickerStatusDate
            // 
            this.DatePickerStatusDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DatePickerStatusDate.BackColor = System.Drawing.Color.White;
            this.DatePickerStatusDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.DatePickerStatusDate.Location = new System.Drawing.Point(224, 10);
            this.DatePickerStatusDate.Name = "DatePickerStatusDate";
            this.DatePickerStatusDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DatePickerStatusDate.ShowTime = false;
            this.DatePickerStatusDate.Size = new System.Drawing.Size(115, 18);
            this.DatePickerStatusDate.TabIndex = 4;
            this.DatePickerStatusDate.UseFarsiDigits = true;
            this.DatePickerStatusDate.Value = ((KagNetComponents2.KagPersianDate)(resources.GetObject("DatePickerStatusDate.Value")));
            this.DatePickerStatusDate.ValueEn = new System.DateTime(2015, 9, 20, 19, 9, 34, 0);
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
            this.mssLabel1.Location = new System.Drawing.Point(345, 43);
            this.mssLabel1.Name = "mssLabel1";
            this.mssLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mssLabel1.Size = new System.Drawing.Size(55, 15);
            this.mssLabel1.TabIndex = 5;
            this.mssLabel1.Text = "نوع وضعیت:";
            // 
            // ComboBoxPatientStatusType
            // 
            this.ComboBoxPatientStatusType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxPatientStatusType.DisplayMember = "Text";
            this.ComboBoxPatientStatusType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxPatientStatusType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxPatientStatusType.FormattingEnabled = true;
            this.ComboBoxPatientStatusType.ItemHeight = 14;
            this.ComboBoxPatientStatusType.Location = new System.Drawing.Point(152, 43);
            this.ComboBoxPatientStatusType.Name = "ComboBoxPatientStatusType";
            this.ComboBoxPatientStatusType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ComboBoxPatientStatusType.Size = new System.Drawing.Size(187, 20);
            this.ComboBoxPatientStatusType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ComboBoxPatientStatusType.TabIndex = 65;
            // 
            // checkBoxIsDo
            // 
            this.checkBoxIsDo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxIsDo.AutoSize = true;
            this.checkBoxIsDo.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.checkBoxIsDo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxIsDo.Checked = true;
            this.checkBoxIsDo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxIsDo.CheckValue = "Y";
            this.checkBoxIsDo.Font = new System.Drawing.Font("Tahoma", 8F);
            this.checkBoxIsDo.Location = new System.Drawing.Point(270, 131);
            this.checkBoxIsDo.Name = "checkBoxIsDo";
            this.checkBoxIsDo.Size = new System.Drawing.Size(69, 15);
            this.checkBoxIsDo.TabIndex = 66;
            this.checkBoxIsDo.Text = "انجام شده";
            // 
            // TextBoxDescription
            // 
            this.TextBoxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.TextBoxDescription.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxDescription.Font = new System.Drawing.Font("Tahoma", 8F);
            this.TextBoxDescription.Location = new System.Drawing.Point(32, 74);
            this.TextBoxDescription.Multiline = true;
            this.TextBoxDescription.Name = "TextBoxDescription";
            this.TextBoxDescription.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TextBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBoxDescription.Size = new System.Drawing.Size(307, 47);
            this.TextBoxDescription.TabIndex = 68;
            // 
            // mssLabel17
            // 
            this.mssLabel17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mssLabel17.AutoSize = true;
            this.mssLabel17.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.mssLabel17.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mssLabel17.Font = new System.Drawing.Font("Tahoma", 8F);
            this.mssLabel17.ForeColor = System.Drawing.Color.Black;
            this.mssLabel17.Location = new System.Drawing.Point(345, 74);
            this.mssLabel17.Name = "mssLabel17";
            this.mssLabel17.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mssLabel17.Size = new System.Drawing.Size(45, 15);
            this.mssLabel17.TabIndex = 67;
            this.mssLabel17.Text = "توضیحات:";
            // 
            // PatientStatusCareAdd_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(431, 259);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 197);
            this.Name = "PatientStatusCareAdd_Frm";
            this.Text = "ثبت وضعیت مراقبت";
            this.Load += new System.EventHandler(this.PatientStatusCareAdd_Frm_Load);
            this.mssGroupPanel1.ResumeLayout(false);
            this.mssGroupPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MSSDatePicker DatePickerStatusDate;
        private MSSLabel mssLabel8;
        private MSSLabel mssLabel1;
        private MSSComboBox ComboBoxPatientStatusType;
        private MSSCheckBox checkBoxIsDo;
        private MSSTextBox TextBoxDescription;
        private MSSLabel mssLabel17;


    }
}
