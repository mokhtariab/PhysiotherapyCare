
using MKH.Library.Control;
namespace PhysiotherapyCare.View.MainForms.Patient
{
    partial class VisitPatientWithGroupAdd_Frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisitPatientWithGroupAdd_Frm));
            this.buttonDoctor = new MKH.Library.Control.MSSButton(this.components);
            this.TextBoxDoctor = new MKH.Library.Control.MSSTextBox(this.components);
            this.mssGroupPanel2 = new MKH.Library.Control.MSSGroupPanel(this.components);
            this.DatePickerVisitDate = new MKH.Library.Control.MSSDatePicker(this.components);
            this.mssLabel3 = new MKH.Library.Control.MSSLabel(this.components);
            this.ComboBoxBonyadAddEven = new MKH.Library.Control.MSSComboBox();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.TextBoxDescription = new MKH.Library.Control.MSSTextBox(this.components);
            this.mssLabel15 = new MKH.Library.Control.MSSLabel(this.components);
            this.CheckBoxBonyadAddEven = new MKH.Library.Control.MSSCheckBox(this.components);
            this.mssLabel1 = new MKH.Library.Control.MSSLabel(this.components);
            this.TextBoxLetterNo = new MKH.Library.Control.MSSTextBox(this.components);
            this.TextBoxIssueArchive = new MKH.Library.Control.MSSTextBox(this.components);
            this.DatePickerLetterDate = new MKH.Library.Control.MSSDatePicker(this.components);
            this.CheckBoxLetterDate = new MKH.Library.Control.MSSCheckBox(this.components);
            this.CheckBoxLetterNo = new MKH.Library.Control.MSSCheckBox(this.components);
            this.CheckBoxIssueArchive = new MKH.Library.Control.MSSCheckBox(this.components);
            this.mssGroupPanel1.SuspendLayout();
            this.mssGroupPanel2.SuspendLayout();
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
            this.ribbonBarNewBar.Location = new System.Drawing.Point(0, 332);
            this.ribbonBarNewBar.Size = new System.Drawing.Size(531, 61);
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
            this.mssGroupPanel1.Controls.Add(this.mssGroupPanel2);
            this.mssGroupPanel1.Size = new System.Drawing.Size(531, 298);
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
            // buttonDoctor
            // 
            this.buttonDoctor.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonDoctor.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonDoctor.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonDoctor.Location = new System.Drawing.Point(43, 97);
            this.buttonDoctor.Name = "buttonDoctor";
            this.buttonDoctor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonDoctor.Size = new System.Drawing.Size(31, 20);
            this.buttonDoctor.TabIndex = 7;
            this.buttonDoctor.Text = "...";
            this.buttonDoctor.Click += new System.EventHandler(this.buttonDoctor_Click);
            // 
            // TextBoxDoctor
            // 
            this.TextBoxDoctor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.TextBoxDoctor.Border.Class = "TextBoxBorder";
            this.TextBoxDoctor.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxDoctor.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TextBoxDoctor.ForeColor = System.Drawing.Color.Black;
            this.TextBoxDoctor.Location = new System.Drawing.Point(80, 97);
            this.TextBoxDoctor.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TextBoxDoctor.MaxLength = 50;
            this.TextBoxDoctor.Name = "TextBoxDoctor";
            this.TextBoxDoctor.ReadOnly = true;
            this.TextBoxDoctor.Size = new System.Drawing.Size(325, 21);
            this.TextBoxDoctor.TabIndex = 6;
            // 
            // mssGroupPanel2
            // 
            this.mssGroupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.mssGroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.mssGroupPanel2.Controls.Add(this.TextBoxLetterNo);
            this.mssGroupPanel2.Controls.Add(this.TextBoxIssueArchive);
            this.mssGroupPanel2.Controls.Add(this.DatePickerLetterDate);
            this.mssGroupPanel2.Controls.Add(this.CheckBoxIssueArchive);
            this.mssGroupPanel2.Controls.Add(this.CheckBoxLetterNo);
            this.mssGroupPanel2.Controls.Add(this.CheckBoxLetterDate);
            this.mssGroupPanel2.Controls.Add(this.CheckBoxBonyadAddEven);
            this.mssGroupPanel2.Controls.Add(this.DatePickerVisitDate);
            this.mssGroupPanel2.Controls.Add(this.mssLabel1);
            this.mssGroupPanel2.Controls.Add(this.mssLabel3);
            this.mssGroupPanel2.Controls.Add(this.buttonDoctor);
            this.mssGroupPanel2.Controls.Add(this.TextBoxDoctor);
            this.mssGroupPanel2.Controls.Add(this.ComboBoxBonyadAddEven);
            this.mssGroupPanel2.Controls.Add(this.mssLabel15);
            this.mssGroupPanel2.Controls.Add(this.TextBoxDescription);
            this.mssGroupPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mssGroupPanel2.Location = new System.Drawing.Point(0, 0);
            this.mssGroupPanel2.Name = "mssGroupPanel2";
            this.mssGroupPanel2.Size = new System.Drawing.Size(525, 292);
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
            this.mssGroupPanel2.TabIndex = 1;
            // 
            // DatePickerVisitDate
            // 
            this.DatePickerVisitDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DatePickerVisitDate.BackColor = System.Drawing.Color.White;
            this.DatePickerVisitDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.DatePickerVisitDate.Location = new System.Drawing.Point(301, 126);
            this.DatePickerVisitDate.Name = "DatePickerVisitDate";
            this.DatePickerVisitDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DatePickerVisitDate.ShowTime = false;
            this.DatePickerVisitDate.Size = new System.Drawing.Size(104, 18);
            this.DatePickerVisitDate.TabIndex = 93;
            this.DatePickerVisitDate.Text = "mssDatePicker1";
            this.DatePickerVisitDate.UseFarsiDigits = true;
            this.DatePickerVisitDate.Value = ((KagNetComponents2.KagPersianDate)(resources.GetObject("DatePickerVisitDate.Value")));
            this.DatePickerVisitDate.ValueEn = new System.DateTime(2015, 9, 20, 19, 9, 34, 0);
            // 
            // mssLabel3
            // 
            this.mssLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mssLabel3.AutoSize = true;
            this.mssLabel3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.mssLabel3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mssLabel3.Font = new System.Drawing.Font("Tahoma", 8F);
            this.mssLabel3.ForeColor = System.Drawing.Color.Black;
            this.mssLabel3.Location = new System.Drawing.Point(411, 128);
            this.mssLabel3.Name = "mssLabel3";
            this.mssLabel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mssLabel3.Size = new System.Drawing.Size(55, 15);
            this.mssLabel3.TabIndex = 92;
            this.mssLabel3.Text = "تاریخ ویزیت:";
            // 
            // ComboBoxBonyadAddEven
            // 
            this.ComboBoxBonyadAddEven.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxBonyadAddEven.DisplayMember = "Text";
            this.ComboBoxBonyadAddEven.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxBonyadAddEven.Enabled = false;
            this.ComboBoxBonyadAddEven.FormattingEnabled = true;
            this.ComboBoxBonyadAddEven.ItemHeight = 14;
            this.ComboBoxBonyadAddEven.Items.AddRange(new object[] {
            this.comboItem1,
            this.comboItem2});
            this.ComboBoxBonyadAddEven.Location = new System.Drawing.Point(290, 152);
            this.ComboBoxBonyadAddEven.Name = "ComboBoxBonyadAddEven";
            this.ComboBoxBonyadAddEven.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ComboBoxBonyadAddEven.Size = new System.Drawing.Size(115, 22);
            this.ComboBoxBonyadAddEven.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ComboBoxBonyadAddEven.TabIndex = 13;
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "زوج";
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "فرد";
            // 
            // TextBoxDescription
            // 
            this.TextBoxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.TextBoxDescription.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxDescription.Font = new System.Drawing.Font("Tahoma", 8F);
            this.TextBoxDescription.Location = new System.Drawing.Point(42, 182);
            this.TextBoxDescription.Multiline = true;
            this.TextBoxDescription.Name = "TextBoxDescription";
            this.TextBoxDescription.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TextBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBoxDescription.Size = new System.Drawing.Size(362, 85);
            this.TextBoxDescription.TabIndex = 8;
            // 
            // mssLabel15
            // 
            this.mssLabel15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mssLabel15.AutoSize = true;
            this.mssLabel15.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.mssLabel15.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mssLabel15.Font = new System.Drawing.Font("Tahoma", 8F);
            this.mssLabel15.ForeColor = System.Drawing.Color.Black;
            this.mssLabel15.Location = new System.Drawing.Point(411, 183);
            this.mssLabel15.Name = "mssLabel15";
            this.mssLabel15.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mssLabel15.Size = new System.Drawing.Size(45, 15);
            this.mssLabel15.TabIndex = 2;
            this.mssLabel15.Text = "توضیحات:";
            // 
            // CheckBoxBonyadAddEven
            // 
            this.CheckBoxBonyadAddEven.AutoSize = true;
            this.CheckBoxBonyadAddEven.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.CheckBoxBonyadAddEven.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.CheckBoxBonyadAddEven.Font = new System.Drawing.Font("Tahoma", 8F);
            this.CheckBoxBonyadAddEven.Location = new System.Drawing.Point(411, 155);
            this.CheckBoxBonyadAddEven.Name = "CheckBoxBonyadAddEven";
            this.CheckBoxBonyadAddEven.Size = new System.Drawing.Size(62, 15);
            this.CheckBoxBonyadAddEven.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CheckBoxBonyadAddEven.TabIndex = 94;
            this.CheckBoxBonyadAddEven.Text = "زوج / فرد";
            this.CheckBoxBonyadAddEven.TextColor = System.Drawing.Color.Black;
            this.CheckBoxBonyadAddEven.CheckedChanged += new System.EventHandler(this.CheckBoxBonyadAddEven_CheckedChanged);
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
            this.mssLabel1.Location = new System.Drawing.Point(411, 101);
            this.mssLabel1.Name = "mssLabel1";
            this.mssLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mssLabel1.Size = new System.Drawing.Size(50, 15);
            this.mssLabel1.TabIndex = 92;
            this.mssLabel1.Text = "نام پزشک:";
            // 
            // TextBoxLetterNo
            // 
            this.TextBoxLetterNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.TextBoxLetterNo.Border.Class = "TextBoxBorder";
            this.TextBoxLetterNo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxLetterNo.Enabled = false;
            this.TextBoxLetterNo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TextBoxLetterNo.ForeColor = System.Drawing.Color.Black;
            this.TextBoxLetterNo.Location = new System.Drawing.Point(195, 42);
            this.TextBoxLetterNo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TextBoxLetterNo.MaxLength = 50;
            this.TextBoxLetterNo.Name = "TextBoxLetterNo";
            this.TextBoxLetterNo.Size = new System.Drawing.Size(210, 21);
            this.TextBoxLetterNo.TabIndex = 98;
            // 
            // TextBoxIssueArchive
            // 
            this.TextBoxIssueArchive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.TextBoxIssueArchive.Border.Class = "TextBoxBorder";
            this.TextBoxIssueArchive.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxIssueArchive.Enabled = false;
            this.TextBoxIssueArchive.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TextBoxIssueArchive.ForeColor = System.Drawing.Color.Black;
            this.TextBoxIssueArchive.Location = new System.Drawing.Point(195, 13);
            this.TextBoxIssueArchive.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TextBoxIssueArchive.MaxLength = 50;
            this.TextBoxIssueArchive.Name = "TextBoxIssueArchive";
            this.TextBoxIssueArchive.Size = new System.Drawing.Size(210, 21);
            this.TextBoxIssueArchive.TabIndex = 95;
            // 
            // DatePickerLetterDate
            // 
            this.DatePickerLetterDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DatePickerLetterDate.BackColor = System.Drawing.Color.White;
            this.DatePickerLetterDate.Enabled = false;
            this.DatePickerLetterDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.DatePickerLetterDate.Location = new System.Drawing.Point(301, 71);
            this.DatePickerLetterDate.Name = "DatePickerLetterDate";
            this.DatePickerLetterDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DatePickerLetterDate.ShowTime = false;
            this.DatePickerLetterDate.Size = new System.Drawing.Size(104, 18);
            this.DatePickerLetterDate.TabIndex = 99;
            this.DatePickerLetterDate.Text = "mssDatePicker1";
            this.DatePickerLetterDate.UseFarsiDigits = true;
            this.DatePickerLetterDate.Value = ((KagNetComponents2.KagPersianDate)(resources.GetObject("DatePickerLetterDate.Value")));
            this.DatePickerLetterDate.ValueEn = new System.DateTime(2015, 9, 20, 19, 9, 34, 0);
            // 
            // CheckBoxLetterDate
            // 
            this.CheckBoxLetterDate.AutoSize = true;
            this.CheckBoxLetterDate.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.CheckBoxLetterDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.CheckBoxLetterDate.Font = new System.Drawing.Font("Tahoma", 8F);
            this.CheckBoxLetterDate.Location = new System.Drawing.Point(411, 71);
            this.CheckBoxLetterDate.Name = "CheckBoxLetterDate";
            this.CheckBoxLetterDate.Size = new System.Drawing.Size(86, 15);
            this.CheckBoxLetterDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CheckBoxLetterDate.TabIndex = 94;
            this.CheckBoxLetterDate.Text = "تاریخ نامه بنیاد";
            this.CheckBoxLetterDate.TextColor = System.Drawing.Color.Black;
            this.CheckBoxLetterDate.CheckedChanged += new System.EventHandler(this.CheckBoxLetterDate_CheckedChanged);
            // 
            // CheckBoxLetterNo
            // 
            this.CheckBoxLetterNo.AutoSize = true;
            this.CheckBoxLetterNo.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.CheckBoxLetterNo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.CheckBoxLetterNo.Font = new System.Drawing.Font("Tahoma", 8F);
            this.CheckBoxLetterNo.Location = new System.Drawing.Point(411, 45);
            this.CheckBoxLetterNo.Name = "CheckBoxLetterNo";
            this.CheckBoxLetterNo.Size = new System.Drawing.Size(94, 15);
            this.CheckBoxLetterNo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CheckBoxLetterNo.TabIndex = 94;
            this.CheckBoxLetterNo.Text = "شماره نامه بنیاد";
            this.CheckBoxLetterNo.TextColor = System.Drawing.Color.Black;
            this.CheckBoxLetterNo.CheckedChanged += new System.EventHandler(this.CheckBoxLetterNo_CheckedChanged);
            // 
            // CheckBoxIssueArchive
            // 
            this.CheckBoxIssueArchive.AutoSize = true;
            this.CheckBoxIssueArchive.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.CheckBoxIssueArchive.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.CheckBoxIssueArchive.Font = new System.Drawing.Font("Tahoma", 8F);
            this.CheckBoxIssueArchive.Location = new System.Drawing.Point(411, 19);
            this.CheckBoxIssueArchive.Name = "CheckBoxIssueArchive";
            this.CheckBoxIssueArchive.Size = new System.Drawing.Size(86, 15);
            this.CheckBoxIssueArchive.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CheckBoxIssueArchive.TabIndex = 94;
            this.CheckBoxIssueArchive.Text = "شماره بایگانی";
            this.CheckBoxIssueArchive.TextColor = System.Drawing.Color.Black;
            this.CheckBoxIssueArchive.CheckedChanged += new System.EventHandler(this.CheckBoxIssueArchive_CheckedChanged);
            // 
            // VisitPatientWithGroupAdd_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.ClientSize = new System.Drawing.Size(531, 393);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(347, 223);
            this.Name = "VisitPatientWithGroupAdd_Frm";
            this.Text = "ثبت ویزیت گروهی بیماران";
            this.Load += new System.EventHandler(this.VisitPatientWithGroupAdd_Frm_Load);
            this.mssGroupPanel1.ResumeLayout(false);
            this.mssGroupPanel2.ResumeLayout(false);
            this.mssGroupPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MSSButton buttonDoctor;
        private MSSTextBox TextBoxDoctor;
        private MSSGroupPanel mssGroupPanel2;
        private MSSComboBox ComboBoxBonyadAddEven;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
        private MSSDatePicker DatePickerVisitDate;
        private MSSLabel mssLabel3;
        private MSSLabel mssLabel15;
        private MSSTextBox TextBoxDescription;
        private MSSCheckBox CheckBoxBonyadAddEven;
        private MSSLabel mssLabel1;
        private MSSTextBox TextBoxLetterNo;
        private MSSTextBox TextBoxIssueArchive;
        private MSSDatePicker DatePickerLetterDate;
        private MSSCheckBox CheckBoxIssueArchive;
        private MSSCheckBox CheckBoxLetterNo;
        private MSSCheckBox CheckBoxLetterDate;
    }
}
