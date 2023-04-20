using System.Windows.Forms;
using MKH.Library.Control;
namespace PhysiotherapyCare.View.MainForms.VisitPatient
{
    partial class VisitPatientPaymentBimehAdd_Frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisitPatientPaymentBimehAdd_Frm));
            this.groupPanel_All = new MKH.Library.Control.MSSGroupPanel(this.components);
            this.label_FName = new MKH.Library.Control.MSSLabel(this.components);
            this.TextBoxDoctor = new MKH.Library.Control.MSSTextBox(this.components);
            this.IntBoxCostReqInsu = new MKH.Library.Control.MSSIntBox(this.components);
            this.mssLabel1 = new MKH.Library.Control.MSSLabel(this.components);
            this.mssLabel3 = new MKH.Library.Control.MSSLabel(this.components);
            this.mssLabel4 = new MKH.Library.Control.MSSLabel(this.components);
            this.IntBoxReportCode = new MKH.Library.Control.MSSIntBox(this.components);
            this.mssLabel5 = new MKH.Library.Control.MSSLabel(this.components);
            this.TextBoxInsuLetterNo = new MKH.Library.Control.MSSTextBox(this.components);
            this.DatePickerInsuLetterDate = new MKH.Library.Control.MSSDatePicker(this.components);
            this.CheckBoxInsuLetterDate = new MKH.Library.Control.MSSCheckBox(this.components);
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
            this.ribbonBarNewBar.Location = new System.Drawing.Point(0, 171);
            this.ribbonBarNewBar.Size = new System.Drawing.Size(608, 55);
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
            this.mssGroupPanel1.Controls.Add(this.CheckBoxInsuLetterDate);
            this.mssGroupPanel1.Controls.Add(this.IntBoxReportCode);
            this.mssGroupPanel1.Controls.Add(this.IntBoxCostReqInsu);
            this.mssGroupPanel1.Controls.Add(this.mssLabel4);
            this.mssGroupPanel1.Controls.Add(this.mssLabel1);
            this.mssGroupPanel1.Controls.Add(this.mssLabel3);
            this.mssGroupPanel1.Controls.Add(this.TextBoxDoctor);
            this.mssGroupPanel1.Controls.Add(this.DatePickerInsuLetterDate);
            this.mssGroupPanel1.Controls.Add(this.label_FName);
            this.mssGroupPanel1.Controls.Add(this.TextBoxInsuLetterNo);
            this.mssGroupPanel1.Controls.Add(this.mssLabel5);
            this.mssGroupPanel1.Size = new System.Drawing.Size(608, 137);
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
            // groupPanel_All
            // 
            this.groupPanel_All.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel_All.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel_All.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel_All.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel_All.IsShadowEnabled = true;
            this.groupPanel_All.Location = new System.Drawing.Point(0, 34);
            this.groupPanel_All.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupPanel_All.Name = "groupPanel_All";
            this.groupPanel_All.Size = new System.Drawing.Size(608, 192);
            // 
            // 
            // 
            this.groupPanel_All.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel_All.Style.BackColorGradientAngle = 90;
            this.groupPanel_All.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel_All.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_All.Style.BorderBottomWidth = 1;
            this.groupPanel_All.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel_All.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_All.Style.BorderLeftWidth = 1;
            this.groupPanel_All.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_All.Style.BorderRightWidth = 1;
            this.groupPanel_All.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_All.Style.BorderTopWidth = 1;
            this.groupPanel_All.Style.CornerDiameter = 4;
            this.groupPanel_All.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel_All.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel_All.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel_All.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel_All.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel_All.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel_All.TabIndex = 1;
            this.groupPanel_All.Text = "مشخصات اولیه";
            // 
            // label_FName
            // 
            this.label_FName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_FName.AutoSize = true;
            this.label_FName.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.label_FName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.label_FName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label_FName.ForeColor = System.Drawing.Color.Black;
            this.label_FName.Location = new System.Drawing.Point(466, 10);
            this.label_FName.Name = "label_FName";
            this.label_FName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label_FName.Size = new System.Drawing.Size(52, 16);
            this.label_FName.TabIndex = 65;
            this.label_FName.Text = "نام پزشک:";
            // 
            // TextBoxDoctor
            // 
            this.TextBoxDoctor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.TextBoxDoctor.Border.Class = "TextBoxBorder";
            this.TextBoxDoctor.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxDoctor.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TextBoxDoctor.ForeColor = System.Drawing.Color.Black;
            this.TextBoxDoctor.Location = new System.Drawing.Point(238, 8);
            this.TextBoxDoctor.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TextBoxDoctor.MaxLength = 50;
            this.TextBoxDoctor.Name = "TextBoxDoctor";
            this.TextBoxDoctor.ReadOnly = true;
            this.TextBoxDoctor.Size = new System.Drawing.Size(227, 21);
            this.TextBoxDoctor.TabIndex = 0;
            // 
            // IntBoxCostReqInsu
            // 
            this.IntBoxCostReqInsu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IntBoxCostReqInsu.Location = new System.Drawing.Point(291, 35);
            this.IntBoxCostReqInsu.Name = "IntBoxCostReqInsu";
            this.IntBoxCostReqInsu.Size = new System.Drawing.Size(173, 22);
            this.IntBoxCostReqInsu.TabIndex = 1;
            this.IntBoxCostReqInsu.Text = "0";
            this.IntBoxCostReqInsu.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
            this.IntBoxCostReqInsu.Value = 0;
            this.IntBoxCostReqInsu.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int32;
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
            this.mssLabel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mssLabel1.ForeColor = System.Drawing.Color.Black;
            this.mssLabel1.Location = new System.Drawing.Point(265, 40);
            this.mssLabel1.Name = "mssLabel1";
            this.mssLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mssLabel1.Size = new System.Drawing.Size(20, 16);
            this.mssLabel1.TabIndex = 118;
            this.mssLabel1.Text = "ریال";
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
            this.mssLabel3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mssLabel3.ForeColor = System.Drawing.Color.Black;
            this.mssLabel3.Location = new System.Drawing.Point(466, 38);
            this.mssLabel3.Name = "mssLabel3";
            this.mssLabel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mssLabel3.Size = new System.Drawing.Size(102, 16);
            this.mssLabel3.TabIndex = 117;
            this.mssLabel3.Text = "مبلغ درخواستی بیمه:";
            // 
            // mssLabel4
            // 
            this.mssLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mssLabel4.AutoSize = true;
            this.mssLabel4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.mssLabel4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mssLabel4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mssLabel4.ForeColor = System.Drawing.Color.Black;
            this.mssLabel4.Location = new System.Drawing.Point(466, 66);
            this.mssLabel4.Name = "mssLabel4";
            this.mssLabel4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mssLabel4.Size = new System.Drawing.Size(51, 16);
            this.mssLabel4.TabIndex = 117;
            this.mssLabel4.Text = "کد گزارش:";
            // 
            // IntBoxReportCode
            // 
            this.IntBoxReportCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IntBoxReportCode.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.General;
            this.IntBoxReportCode.Location = new System.Drawing.Point(291, 63);
            this.IntBoxReportCode.Name = "IntBoxReportCode";
            this.IntBoxReportCode.Size = new System.Drawing.Size(173, 22);
            this.IntBoxReportCode.TabIndex = 2;
            this.IntBoxReportCode.Text = "0";
            this.IntBoxReportCode.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
            this.IntBoxReportCode.Value = 0;
            this.IntBoxReportCode.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int32;
            // 
            // mssLabel5
            // 
            this.mssLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mssLabel5.AutoSize = true;
            this.mssLabel5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.mssLabel5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mssLabel5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.mssLabel5.ForeColor = System.Drawing.Color.Black;
            this.mssLabel5.Location = new System.Drawing.Point(466, 94);
            this.mssLabel5.Name = "mssLabel5";
            this.mssLabel5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mssLabel5.Size = new System.Drawing.Size(116, 16);
            this.mssLabel5.TabIndex = 61;
            this.mssLabel5.Text = "شماره معرفی نامه بیمه:";
            // 
            // TextBoxInsuLetterNo
            // 
            this.TextBoxInsuLetterNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.TextBoxInsuLetterNo.Border.Class = "TextBoxBorder";
            this.TextBoxInsuLetterNo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxInsuLetterNo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TextBoxInsuLetterNo.ForeColor = System.Drawing.Color.Black;
            this.TextBoxInsuLetterNo.Location = new System.Drawing.Point(291, 91);
            this.TextBoxInsuLetterNo.MaxLength = 20;
            this.TextBoxInsuLetterNo.Name = "TextBoxInsuLetterNo";
            this.TextBoxInsuLetterNo.Size = new System.Drawing.Size(173, 21);
            this.TextBoxInsuLetterNo.TabIndex = 3;
            // 
            // DatePickerInsuLetterDate
            // 
            this.DatePickerInsuLetterDate.BackColor = System.Drawing.Color.White;
            this.DatePickerInsuLetterDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.DatePickerInsuLetterDate.Location = new System.Drawing.Point(22, 93);
            this.DatePickerInsuLetterDate.Name = "DatePickerInsuLetterDate";
            this.DatePickerInsuLetterDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DatePickerInsuLetterDate.ShowTime = false;
            this.DatePickerInsuLetterDate.Size = new System.Drawing.Size(115, 18);
            this.DatePickerInsuLetterDate.TabIndex = 5;
            this.DatePickerInsuLetterDate.Text = "mssDatePicker1";
            this.DatePickerInsuLetterDate.UseFarsiDigits = true;
            this.DatePickerInsuLetterDate.Value = ((KagNetComponents2.KagPersianDate)(resources.GetObject("DatePickerInsuLetterDate.Value")));
            this.DatePickerInsuLetterDate.ValueEn = new System.DateTime(2017, 3, 9, 8, 12, 22, 0);
            // 
            // CheckBoxInsuLetterDate
            // 
            this.CheckBoxInsuLetterDate.AutoSize = true;
            this.CheckBoxInsuLetterDate.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.CheckBoxInsuLetterDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.CheckBoxInsuLetterDate.Checked = true;
            this.CheckBoxInsuLetterDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBoxInsuLetterDate.CheckValue = "Y";
            this.CheckBoxInsuLetterDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.CheckBoxInsuLetterDate.Location = new System.Drawing.Point(140, 95);
            this.CheckBoxInsuLetterDate.Name = "CheckBoxInsuLetterDate";
            this.CheckBoxInsuLetterDate.Size = new System.Drawing.Size(116, 16);
            this.CheckBoxInsuLetterDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CheckBoxInsuLetterDate.TabIndex = 4;
            this.CheckBoxInsuLetterDate.Text = "تاریخ ثبت هزینه بیمه";
            this.CheckBoxInsuLetterDate.TextColor = System.Drawing.Color.Black;
            this.CheckBoxInsuLetterDate.CheckedChanged += new System.EventHandler(this.CheckBoxAnalyzeDate_CheckedChanged);
            // 
            // VisitPatientPaymentBimehAdd_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.ClientSize = new System.Drawing.Size(608, 226);
            this.Controls.Add(this.groupPanel_All);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "VisitPatientPaymentBimehAdd_Frm";
            this.ShowInTaskbar = false;
            this.Text = "ویرایش بیمه";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VisitPatientPaymentBimehAdd_Frm_FormClosed);
            this.Load += new System.EventHandler(this.DoctorPaymentNE_frm_Load);
            this.Controls.SetChildIndex(this.groupPanel_All, 0);
            this.Controls.SetChildIndex(this.ribbonBarNewBar, 0);
            this.Controls.SetChildIndex(this.mssGroupPanel1, 0);
            this.mssGroupPanel1.ResumeLayout(false);
            this.mssGroupPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MSSGroupPanel groupPanel_All;
        private MSSLabel label_FName;
        private MSSTextBox TextBoxDoctor;
        private MSSIntBox IntBoxReportCode;
        private MSSIntBox IntBoxCostReqInsu;
        private MSSLabel mssLabel4;
        private MSSLabel mssLabel1;
        private MSSLabel mssLabel3;
        private MSSDatePicker DatePickerInsuLetterDate;
        private MSSTextBox TextBoxInsuLetterNo;
        private MSSLabel mssLabel5;
        private MSSCheckBox CheckBoxInsuLetterDate;
    }
}