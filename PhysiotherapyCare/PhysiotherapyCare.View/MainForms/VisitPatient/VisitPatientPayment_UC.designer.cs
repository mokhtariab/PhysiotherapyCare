using System.Windows.Forms;
using MKH.Library.Control;

namespace PhysiotherapyCare.View.MainForms.VisitPatient
{
    partial class VisitPatientPayment_UC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisitPatientPayment_UC));
            Janus.Windows.GridEX.GridEXLayout GridViewVisitPatientPayment_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.vWVisitPatientPaymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mssPanel1 = new MKH.Library.Control.MSSPanel(this.components);
            this.comboBoxBank = new MKH.Library.Control.MSSComboBox();
            this.textBoxSetValue = new MKH.Library.Control.MSSTextBox(this.components);
            this.label6 = new MKH.Library.Control.MSSLabel(this.components);
            this.btnSetValueVisit = new MKH.Library.Control.MSSButton(this.components);
            this.DatePickerSet = new MKH.Library.Control.MSSDatePicker(this.components);
            this.comboBoxSetValue = new MKH.Library.Control.MSSComboBox();
            this.comboItemPaymentStatus = new DevComponents.Editors.ComboItem();
            this.comboItemCostCachInsuIran = new DevComponents.Editors.ComboItem();
            this.comboItemAnalyzePage = new DevComponents.Editors.ComboItem();
            this.comboItemAnalyzeNo = new DevComponents.Editors.ComboItem();
            this.comboItemAccountingDocumentNumber = new DevComponents.Editors.ComboItem();
            this.comboItemBursaryNumber = new DevComponents.Editors.ComboItem();
            this.comboItemCostVisitCo = new DevComponents.Editors.ComboItem();
            this.comboItemCostVisitCoPercent = new DevComponents.Editors.ComboItem();
            this.comboItemCostIncrease = new DevComponents.Editors.ComboItem();
            this.comboItemCostIncreasePercent = new DevComponents.Editors.ComboItem();
            this.comboItemPaymentDoctor = new DevComponents.Editors.ComboItem();
            this.comboItemCostDoctorTax = new DevComponents.Editors.ComboItem();
            this.comboItemDescription = new DevComponents.Editors.ComboItem();
            this.comboItemBonyadConfirmNo = new DevComponents.Editors.ComboItem();
            this.comboItemSecretiatNo = new DevComponents.Editors.ComboItem();
            this.comboItemCostDoctorTaxPercent = new DevComponents.Editors.ComboItem();
            this.comboItemReportCode = new DevComponents.Editors.ComboItem();
            this.comboItemCostDoctorInsurance = new DevComponents.Editors.ComboItem();
            this.comboItemCostDoctorInsurancePercent = new DevComponents.Editors.ComboItem();
            this.comboItemCardBankNo1 = new DevComponents.Editors.ComboItem();
            this.comboItemBankName = new DevComponents.Editors.ComboItem();
            this.nUpDownSetValue = new MKH.Library.Control.MSSIntBox(this.components);
            this.mssLabel4 = new MKH.Library.Control.MSSLabel(this.components);
            this.comboBoxPaymentStatus = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.HeaderGridVisitPatientPayment = new MKH.Library.Control.MSSHeaderGrid();
            this.GridViewVisitPatientPayment = new MKH.Library.Control.MSSGridexView();
            this.ContextMenuStripStatus = new MKH.Library.Control.MSSContextMenuStrip(this.components);
            this.ToolStripMenuItemVisitPatientPaymentLog = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemVisitPatientPaymentCurrentRow = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemVisitPatientPaymentAllList = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonItemVisitPaymentCalculateRimindAll = new DevComponents.DotNetBar.ButtonItem();
            this.mssPanel2 = new MKH.Library.Control.MSSPanel(this.components);
            this.DatePickerEnd = new MKH.Library.Control.MSSDatePicker(this.components);
            this.ComboBoxSerach = new MKH.Library.Control.MSSComboBox();
            this.comboItemPaymentDate = new DevComponents.Editors.ComboItem();
            this.comboItemLetterDate = new DevComponents.Editors.ComboItem();
            this.comboItemContractDate = new DevComponents.Editors.ComboItem();
            this.comboItemVisitDate = new DevComponents.Editors.ComboItem();
            this.comboItemInsuLetterDate = new DevComponents.Editors.ComboItem();
            this.comboItemSecretiatDate = new DevComponents.Editors.ComboItem();
            this.comboItemAnalyzeDate = new DevComponents.Editors.ComboItem();
            this.comboItemCostIncreaseDate = new DevComponents.Editors.ComboItem();
            this.comboItemPaymentDoctorDate = new DevComponents.Editors.ComboItem();
            this.comboItemBonyadConfirmDate = new DevComponents.Editors.ComboItem();
            this.comboItemAccountingDocumentDate = new DevComponents.Editors.ComboItem();
            this.comboItemBursaryDate = new DevComponents.Editors.ComboItem();
            this.DatePickerStart = new MKH.Library.Control.MSSDatePicker(this.components);
            this.mssLabel5 = new MKH.Library.Control.MSSLabel(this.components);
            this.mssLabel1 = new MKH.Library.Control.MSSLabel(this.components);
            this.mssLabel2 = new MKH.Library.Control.MSSLabel(this.components);
            this.mssLabel3 = new MKH.Library.Control.MSSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.vWVisitPatientPaymentBindingSource)).BeginInit();
            this.mssPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewVisitPatientPayment)).BeginInit();
            this.ContextMenuStripStatus.SuspendLayout();
            this.mssPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // vWVisitPatientPaymentBindingSource
            // 
            this.vWVisitPatientPaymentBindingSource.DataSource = typeof(PhysiotherapyCare.Model.VisitPatient.VW_VisitPatientPayment);
            // 
            // mssPanel1
            // 
            this.mssPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.mssPanel1.Controls.Add(this.comboBoxBank);
            this.mssPanel1.Controls.Add(this.textBoxSetValue);
            this.mssPanel1.Controls.Add(this.label6);
            this.mssPanel1.Controls.Add(this.btnSetValueVisit);
            this.mssPanel1.Controls.Add(this.DatePickerSet);
            this.mssPanel1.Controls.Add(this.comboBoxSetValue);
            this.mssPanel1.Controls.Add(this.nUpDownSetValue);
            this.mssPanel1.Controls.Add(this.mssLabel4);
            this.mssPanel1.Controls.Add(this.comboBoxPaymentStatus);
            this.mssPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mssPanel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.mssPanel1.Location = new System.Drawing.Point(0, 385);
            this.mssPanel1.Name = "mssPanel1";
            this.mssPanel1.Size = new System.Drawing.Size(947, 38);
            this.mssPanel1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.mssPanel1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.mssPanel1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.mssPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.mssPanel1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.mssPanel1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.mssPanel1.Style.GradientAngle = 90;
            this.mssPanel1.TabIndex = 1;
            // 
            // comboBoxBank
            // 
            this.comboBoxBank.DisplayMember = "Text";
            this.comboBoxBank.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBank.ItemHeight = 15;
            this.comboBoxBank.Location = new System.Drawing.Point(154, 9);
            this.comboBoxBank.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxBank.Name = "comboBoxBank";
            this.comboBoxBank.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBoxBank.Size = new System.Drawing.Size(115, 21);
            this.comboBoxBank.TabIndex = 3;
            this.comboBoxBank.Visible = false;
            // 
            // textBoxSetValue
            // 
            // 
            // 
            // 
            this.textBoxSetValue.Border.Class = "TextBoxBorder";
            this.textBoxSetValue.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxSetValue.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBoxSetValue.ForeColor = System.Drawing.Color.Black;
            this.textBoxSetValue.Location = new System.Drawing.Point(127, 9);
            this.textBoxSetValue.MaxLength = 0;
            this.textBoxSetValue.Name = "textBoxSetValue";
            this.textBoxSetValue.Size = new System.Drawing.Size(173, 21);
            this.textBoxSetValue.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.label6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(479, 11);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(38, 16);
            this.label6.TabIndex = 84;
            this.label6.Text = "ستون:";
            // 
            // btnSetValueVisit
            // 
            this.btnSetValueVisit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSetValueVisit.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnSetValueVisit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSetValueVisit.Location = new System.Drawing.Point(14, 4);
            this.btnSetValueVisit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSetValueVisit.Name = "btnSetValueVisit";
            this.btnSetValueVisit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSetValueVisit.Size = new System.Drawing.Size(94, 31);
            this.btnSetValueVisit.TabIndex = 4;
            this.btnSetValueVisit.Tag = "237";
            this.btnSetValueVisit.Text = "ثبت مقدار جدید\r\nردیفهای انتخابی";
            this.btnSetValueVisit.Click += new System.EventHandler(this.btnSetValue_Click);
            // 
            // DatePickerSet
            // 
            this.DatePickerSet.BackColor = System.Drawing.Color.White;
            this.DatePickerSet.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.DatePickerSet.Location = new System.Drawing.Point(540, 11);
            this.DatePickerSet.Name = "DatePickerSet";
            this.DatePickerSet.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DatePickerSet.ShowTime = false;
            this.DatePickerSet.Size = new System.Drawing.Size(115, 18);
            this.DatePickerSet.TabIndex = 1;
            this.DatePickerSet.Text = "mssDatePicker1";
            this.DatePickerSet.UseFarsiDigits = true;
            this.DatePickerSet.Value = ((KagNetComponents2.KagPersianDate)(resources.GetObject("DatePickerSet.Value")));
            this.DatePickerSet.ValueEn = new System.DateTime(2017, 3, 6, 18, 57, 29, 0);
            this.DatePickerSet.ValueChanged += new KagNetComponents2.KagPersianDatePicker.onValueChanged(this.DatePickerStart_ValueChanged);
            // 
            // comboBoxSetValue
            // 
            this.comboBoxSetValue.DisplayMember = "Text";
            this.comboBoxSetValue.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxSetValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSetValue.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.comboBoxSetValue.ItemHeight = 15;
            this.comboBoxSetValue.Items.AddRange(new object[] {
            this.comboItemPaymentStatus,
            this.comboItemCostCachInsuIran,
            this.comboItemAnalyzePage,
            this.comboItemAnalyzeNo,
            this.comboItemAccountingDocumentNumber,
            this.comboItemBursaryNumber,
            this.comboItemCostVisitCo,
            this.comboItemCostVisitCoPercent,
            this.comboItemCostIncrease,
            this.comboItemCostIncreasePercent,
            this.comboItemPaymentDoctor,
            this.comboItemCostDoctorTax,
            this.comboItemDescription,
            this.comboItemBonyadConfirmNo,
            this.comboItemSecretiatNo,
            this.comboItemCostDoctorTaxPercent,
            this.comboItemReportCode,
            this.comboItemCostDoctorInsurance,
            this.comboItemCostDoctorInsurancePercent,
            this.comboItemCardBankNo1,
            this.comboItemBankName});
            this.comboBoxSetValue.Location = new System.Drawing.Point(326, 8);
            this.comboBoxSetValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxSetValue.Name = "comboBoxSetValue";
            this.comboBoxSetValue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBoxSetValue.Size = new System.Drawing.Size(147, 21);
            this.comboBoxSetValue.TabIndex = 2;
            this.comboBoxSetValue.SelectedIndexChanged += new System.EventHandler(this.comboBoxSetValue_SelectedIndexChanged);
            // 
            // comboItemPaymentStatus
            // 
            this.comboItemPaymentStatus.Text = "وضعیت پرداخت";
            // 
            // comboItemCostCachInsuIran
            // 
            this.comboItemCostCachInsuIran.Text = "مبلغ دریافتی از بیمه";
            // 
            // comboItemAnalyzePage
            // 
            this.comboItemAnalyzePage.Text = "شماره صفحه آنالیز";
            // 
            // comboItemAnalyzeNo
            // 
            this.comboItemAnalyzeNo.Text = "شماره آنالیز";
            // 
            // comboItemAccountingDocumentNumber
            // 
            this.comboItemAccountingDocumentNumber.Text = "سند حسابداری";
            // 
            // comboItemBursaryNumber
            // 
            this.comboItemBursaryNumber.Text = "شماره سند خزانه داری";
            // 
            // comboItemCostVisitCo
            // 
            this.comboItemCostVisitCo.Text = "سهم سازمان";
            // 
            // comboItemCostVisitCoPercent
            // 
            this.comboItemCostVisitCoPercent.Text = "سهم سازمان درصدی";
            // 
            // comboItemCostIncrease
            // 
            this.comboItemCostIncrease.Text = "کسورات";
            // 
            // comboItemCostIncreasePercent
            // 
            this.comboItemCostIncreasePercent.Text = "کسورات درصدی";
            // 
            // comboItemPaymentDoctor
            // 
            this.comboItemPaymentDoctor.Text = "ثبت تاریخ پرداخت نهایی";
            // 
            // comboItemCostDoctorTax
            // 
            this.comboItemCostDoctorTax.Text = "مالیات خدمات";
            // 
            // comboItemDescription
            // 
            this.comboItemDescription.Text = "توضیحات";
            // 
            // comboItemBonyadConfirmNo
            // 
            this.comboItemBonyadConfirmNo.Text = "شماره نامه تایید بنیاد";
            // 
            // comboItemSecretiatNo
            // 
            this.comboItemSecretiatNo.Text = "شماره دبیرخانه";
            // 
            // comboItemCostDoctorTaxPercent
            // 
            this.comboItemCostDoctorTaxPercent.Text = "مالیات خدمات درصدی";
            // 
            // comboItemReportCode
            // 
            this.comboItemReportCode.Text = "کد گزارش";
            // 
            // comboItemCostDoctorInsurance
            // 
            this.comboItemCostDoctorInsurance.Text = "بیمه خدمات";
            // 
            // comboItemCostDoctorInsurancePercent
            // 
            this.comboItemCostDoctorInsurancePercent.Text = "بیمه خدمات درصدی";
            // 
            // comboItemCardBankNo1
            // 
            this.comboItemCardBankNo1.Text = "شماره حساب پزشک";
            // 
            // comboItemBankName
            // 
            this.comboItemBankName.Text = "بانک عامل پزشک";
            // 
            // nUpDownSetValue
            // 
            this.nUpDownSetValue.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.nUpDownSetValue.ForeColor = System.Drawing.Color.Black;
            this.nUpDownSetValue.Location = new System.Drawing.Point(158, 8);
            this.nUpDownSetValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nUpDownSetValue.Name = "nUpDownSetValue";
            this.nUpDownSetValue.Size = new System.Drawing.Size(120, 22);
            this.nUpDownSetValue.TabIndex = 82;
            this.nUpDownSetValue.Text = "0";
            this.nUpDownSetValue.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
            this.nUpDownSetValue.Value = 0;
            this.nUpDownSetValue.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int32;
            this.nUpDownSetValue.Visible = false;
            // 
            // mssLabel4
            // 
            this.mssLabel4.AutoSize = true;
            // 
            // 
            // 
            this.mssLabel4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mssLabel4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.mssLabel4.ForeColor = System.Drawing.Color.White;
            this.mssLabel4.Location = new System.Drawing.Point(658, 11);
            this.mssLabel4.Name = "mssLabel4";
            this.mssLabel4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mssLabel4.Size = new System.Drawing.Size(32, 16);
            this.mssLabel4.TabIndex = 0;
            this.mssLabel4.Text = "تاریخ:";
            // 
            // comboBoxPaymentStatus
            // 
            this.comboBoxPaymentStatus.DisplayMember = "Text";
            this.comboBoxPaymentStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxPaymentStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPaymentStatus.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.comboBoxPaymentStatus.ItemHeight = 15;
            this.comboBoxPaymentStatus.Location = new System.Drawing.Point(154, 9);
            this.comboBoxPaymentStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxPaymentStatus.Name = "comboBoxPaymentStatus";
            this.comboBoxPaymentStatus.Size = new System.Drawing.Size(124, 21);
            this.comboBoxPaymentStatus.TabIndex = 83;
            this.comboBoxPaymentStatus.Visible = false;
            // 
            // HeaderGridVisitPatientPayment
            // 
            // 
            // 
            // 
            this.HeaderGridVisitPatientPayment.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridVisitPatientPayment.BackgroundStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridVisitPatientPayment.BackgroundStyle.BorderBottomWidth = 1;
            this.HeaderGridVisitPatientPayment.BackgroundStyle.BorderLeftWidth = 1;
            this.HeaderGridVisitPatientPayment.BackgroundStyle.BorderRightWidth = 1;
            this.HeaderGridVisitPatientPayment.BackgroundStyle.BorderTopWidth = 1;
            this.HeaderGridVisitPatientPayment.BackgroundStyle.Class = "ItemPanel";
            this.HeaderGridVisitPatientPayment.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.HeaderGridVisitPatientPayment.BackgroundStyle.PaddingBottom = 1;
            this.HeaderGridVisitPatientPayment.BackgroundStyle.PaddingLeft = 1;
            this.HeaderGridVisitPatientPayment.BackgroundStyle.PaddingRight = 1;
            this.HeaderGridVisitPatientPayment.BackgroundStyle.PaddingTop = 1;
            this.HeaderGridVisitPatientPayment.ButtonDeletePermissionCode = 232;
            this.HeaderGridVisitPatientPayment.ButtonDeleteVisible = true;
            this.HeaderGridVisitPatientPayment.ButtonEditPermissionCode = 231;
            this.HeaderGridVisitPatientPayment.ButtonEditVisible = true;
            this.HeaderGridVisitPatientPayment.ButtonExcelExportVisible = true;
            this.HeaderGridVisitPatientPayment.ButtonExcelPermissionCode = 234;
            this.HeaderGridVisitPatientPayment.ButtonInsertPermissionCode = 230;
            this.HeaderGridVisitPatientPayment.ButtonInsertVisible = true;
            this.HeaderGridVisitPatientPayment.ButtonPrintExpertPermissionCode = 0;
            this.HeaderGridVisitPatientPayment.ButtonPrintExpertVisible = false;
            this.HeaderGridVisitPatientPayment.ButtonPrintPermissionCode = 233;
            this.HeaderGridVisitPatientPayment.ButtonPrintVisible = true;
            this.HeaderGridVisitPatientPayment.ButtonPrintWithDesignPermissionCode = 235;
            this.HeaderGridVisitPatientPayment.ButtonPrintWithDesignVisible = true;
            this.HeaderGridVisitPatientPayment.ButtonRefreshVisible = true;
            this.HeaderGridVisitPatientPayment.ButtonSearchExpertVisible = false;
            this.HeaderGridVisitPatientPayment.ButtonSearchVisible = true;
            this.HeaderGridVisitPatientPayment.ButtonSelectorVisible = true;
            this.HeaderGridVisitPatientPayment.ContainerControlProcessDialogKey = true;
            this.HeaderGridVisitPatientPayment.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderGridVisitPatientPayment.FitButtonsToContainerWidth = true;
            this.HeaderGridVisitPatientPayment.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.HeaderGridVisitPatientPayment.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.HeaderGridVisitPatientPayment.GridViewSet = this.GridViewVisitPatientPayment;
            this.HeaderGridVisitPatientPayment.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItemVisitPaymentCalculateRimindAll});
            this.HeaderGridVisitPatientPayment.Location = new System.Drawing.Point(0, 0);
            this.HeaderGridVisitPatientPayment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HeaderGridVisitPatientPayment.Name = "HeaderGridVisitPatientPayment";
            this.HeaderGridVisitPatientPayment.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HeaderGridVisitPatientPayment.Size = new System.Drawing.Size(947, 56);
            this.HeaderGridVisitPatientPayment.TabIndex = 33;
            this.HeaderGridVisitPatientPayment.Tag = "";
            this.HeaderGridVisitPatientPayment.ThemeAware = true;
            this.HeaderGridVisitPatientPayment.buttonItemInsertClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemInsertClickEventHandler(this.headerGridVisitPatientPayment_btnInsertClick);
            this.HeaderGridVisitPatientPayment.buttonItemEditClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemEditClickEventHandler(this.headerGridVisitPatientPayment_btnEditClick);
            this.HeaderGridVisitPatientPayment.buttonItemDeleteClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemDeleteClickEventHandler(this.headerGridVisitPatientPayment_btnDeleteClick);
            this.HeaderGridVisitPatientPayment.buttonItemRefreshClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemRefreshClickEventHandler(this.headerGridVisitPatientPayment_btnRefreshClick);
            // 
            // GridViewVisitPatientPayment
            // 
            this.GridViewVisitPatientPayment.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.GridViewVisitPatientPayment.AlternatingColors = true;
            this.GridViewVisitPatientPayment.AlternatingRowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewVisitPatientPayment.BuiltInTextsData = resources.GetString("GridViewVisitPatientPayment.BuiltInTextsData");
            this.GridViewVisitPatientPayment.CardViewGridlines = Janus.Windows.GridEX.CardViewGridlines.Both;
            this.GridViewVisitPatientPayment.ContextMenuStrip = this.ContextMenuStripStatus;
            this.GridViewVisitPatientPayment.DataSource = this.vWVisitPatientPaymentBindingSource;
            this.GridViewVisitPatientPayment.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            GridViewVisitPatientPayment_DesignTimeLayout.LayoutString = resources.GetString("GridViewVisitPatientPayment_DesignTimeLayout.LayoutString");
            this.GridViewVisitPatientPayment.DesignTimeLayout = GridViewVisitPatientPayment_DesignTimeLayout;
            this.GridViewVisitPatientPayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewVisitPatientPayment.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.GridViewVisitPatientPayment.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.GridViewVisitPatientPayment.Font = new System.Drawing.Font("Tahoma", 8.150944F);
            this.GridViewVisitPatientPayment.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewVisitPatientPayment.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
            this.GridViewVisitPatientPayment.Location = new System.Drawing.Point(0, 56);
            this.GridViewVisitPatientPayment.Name = "GridViewVisitPatientPayment";
            this.GridViewVisitPatientPayment.RecordNavigator = true;
            this.GridViewVisitPatientPayment.RowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewVisitPatientPayment.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition;
            this.GridViewVisitPatientPayment.RowHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewVisitPatientPayment.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.GridViewVisitPatientPayment.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelection;
            this.GridViewVisitPatientPayment.SettingsKey = "GridViewVisitPatientPayment";
            this.GridViewVisitPatientPayment.Size = new System.Drawing.Size(947, 329);
            this.GridViewVisitPatientPayment.TabIndex = 38;
            this.GridViewVisitPatientPayment.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.GridViewVisitPatientPayment.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.GridViewVisitPatientPayment.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010;
            this.GridViewVisitPatientPayment.DoubleClick += new System.EventHandler(this.headerGridVisitPatientPayment_btnEditClick);
            // 
            // ContextMenuStripStatus
            // 
            this.ContextMenuStripStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemVisitPatientPaymentLog});
            this.ContextMenuStripStatus.Name = "ContextMenuStripStatus";
            this.ContextMenuStripStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ContextMenuStripStatus.Size = new System.Drawing.Size(95, 26);
            // 
            // ToolStripMenuItemVisitPatientPaymentLog
            // 
            this.ToolStripMenuItemVisitPatientPaymentLog.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemVisitPatientPaymentCurrentRow,
            this.ToolStripMenuItemVisitPatientPaymentAllList});
            this.ToolStripMenuItemVisitPatientPaymentLog.Name = "ToolStripMenuItemVisitPatientPaymentLog";
            this.ToolStripMenuItemVisitPatientPaymentLog.Size = new System.Drawing.Size(94, 22);
            this.ToolStripMenuItemVisitPatientPaymentLog.Text = "Log";
            // 
            // ToolStripMenuItemVisitPatientPaymentCurrentRow
            // 
            this.ToolStripMenuItemVisitPatientPaymentCurrentRow.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripMenuItemVisitPatientPaymentCurrentRow.Name = "ToolStripMenuItemVisitPatientPaymentCurrentRow";
            this.ToolStripMenuItemVisitPatientPaymentCurrentRow.Size = new System.Drawing.Size(140, 22);
            this.ToolStripMenuItemVisitPatientPaymentCurrentRow.Tag = "260";
            this.ToolStripMenuItemVisitPatientPaymentCurrentRow.Text = "سطر انتخابی";
            this.ToolStripMenuItemVisitPatientPaymentCurrentRow.Click += new System.EventHandler(this.ToolStripMenuItemVisitPatientPaymentCurrentRow_Click);
            // 
            // ToolStripMenuItemVisitPatientPaymentAllList
            // 
            this.ToolStripMenuItemVisitPatientPaymentAllList.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripMenuItemVisitPatientPaymentAllList.Name = "ToolStripMenuItemVisitPatientPaymentAllList";
            this.ToolStripMenuItemVisitPatientPaymentAllList.Size = new System.Drawing.Size(140, 22);
            this.ToolStripMenuItemVisitPatientPaymentAllList.Tag = "261";
            this.ToolStripMenuItemVisitPatientPaymentAllList.Text = "کل لیست";
            this.ToolStripMenuItemVisitPatientPaymentAllList.Click += new System.EventHandler(this.ToolStripMenuItemVisitPatientPaymentAllList_Click);
            // 
            // buttonItemVisitPaymentCalculateRimindAll
            // 
            this.buttonItemVisitPaymentCalculateRimindAll.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemVisitPaymentCalculateRimindAll.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemVisitPaymentCalculateRimindAll.Icon = ((System.Drawing.Icon)(resources.GetObject("buttonItemVisitPaymentCalculateRimindAll.Icon")));
            this.buttonItemVisitPaymentCalculateRimindAll.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium;
            this.buttonItemVisitPaymentCalculateRimindAll.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemVisitPaymentCalculateRimindAll.Name = "buttonItemVisitPaymentCalculateRimindAll";
            this.buttonItemVisitPaymentCalculateRimindAll.Tag = "236";
            this.buttonItemVisitPaymentCalculateRimindAll.Text = "محاسبه مانده";
            this.buttonItemVisitPaymentCalculateRimindAll.ThemeAware = true;
            this.buttonItemVisitPaymentCalculateRimindAll.Click += new System.EventHandler(this.buttonItemPhysioterapyPaymentCalculateRimindAll_Click);
            // 
            // mssPanel2
            // 
            this.mssPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.mssPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.mssPanel2.Controls.Add(this.DatePickerEnd);
            this.mssPanel2.Controls.Add(this.ComboBoxSerach);
            this.mssPanel2.Controls.Add(this.DatePickerStart);
            this.mssPanel2.Controls.Add(this.mssLabel5);
            this.mssPanel2.Controls.Add(this.mssLabel1);
            this.mssPanel2.Controls.Add(this.mssLabel2);
            this.mssPanel2.Controls.Add(this.mssLabel3);
            this.mssPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mssPanel2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.mssPanel2.Location = new System.Drawing.Point(0, 423);
            this.mssPanel2.Name = "mssPanel2";
            this.mssPanel2.Size = new System.Drawing.Size(947, 44);
            this.mssPanel2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.mssPanel2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.mssPanel2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.mssPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.mssPanel2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.mssPanel2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.mssPanel2.Style.GradientAngle = 90;
            this.mssPanel2.TabIndex = 2;
            // 
            // DatePickerEnd
            // 
            this.DatePickerEnd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DatePickerEnd.BackColor = System.Drawing.Color.White;
            this.DatePickerEnd.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.DatePickerEnd.Location = new System.Drawing.Point(148, 13);
            this.DatePickerEnd.Name = "DatePickerEnd";
            this.DatePickerEnd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DatePickerEnd.ShowTime = false;
            this.DatePickerEnd.Size = new System.Drawing.Size(103, 18);
            this.DatePickerEnd.TabIndex = 5;
            this.DatePickerEnd.Text = "mssDatePicker1";
            this.DatePickerEnd.UseFarsiDigits = true;
            this.DatePickerEnd.Value = ((KagNetComponents2.KagPersianDate)(resources.GetObject("DatePickerEnd.Value")));
            this.DatePickerEnd.ValueEn = new System.DateTime(2017, 3, 6, 18, 57, 29, 0);
            this.DatePickerEnd.ValueChanged += new KagNetComponents2.KagPersianDatePicker.onValueChanged(this.DatePickerStart_ValueChanged);
            // 
            // ComboBoxSerach
            // 
            this.ComboBoxSerach.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ComboBoxSerach.DisplayMember = "Text";
            this.ComboBoxSerach.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxSerach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxSerach.FormattingEnabled = true;
            this.ComboBoxSerach.ItemHeight = 15;
            this.ComboBoxSerach.Items.AddRange(new object[] {
            this.comboItemPaymentDate,
            this.comboItemLetterDate,
            this.comboItemContractDate,
            this.comboItemVisitDate,
            this.comboItemInsuLetterDate,
            this.comboItemSecretiatDate,
            this.comboItemAnalyzeDate,
            this.comboItemCostIncreaseDate,
            this.comboItemPaymentDoctorDate,
            this.comboItemBonyadConfirmDate,
            this.comboItemAccountingDocumentDate,
            this.comboItemBursaryDate});
            this.ComboBoxSerach.Location = new System.Drawing.Point(490, 12);
            this.ComboBoxSerach.Name = "ComboBoxSerach";
            this.ComboBoxSerach.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ComboBoxSerach.Size = new System.Drawing.Size(107, 21);
            this.ComboBoxSerach.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ComboBoxSerach.TabIndex = 3;
            this.ComboBoxSerach.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSerach_SelectedIndexChanged);
            // 
            // comboItemPaymentDate
            // 
            this.comboItemPaymentDate.Text = "تاریخ ثبت در مالی";
            // 
            // comboItemLetterDate
            // 
            this.comboItemLetterDate.Text = "تاریخ نامه بنیاد";
            // 
            // comboItemContractDate
            // 
            this.comboItemContractDate.Text = "تاریخ قرارداد";
            // 
            // comboItemVisitDate
            // 
            this.comboItemVisitDate.Text = "تاریخ ویزیت";
            // 
            // comboItemInsuLetterDate
            // 
            this.comboItemInsuLetterDate.Text = "تاریخ ثبت هزینه بیمه";
            // 
            // comboItemSecretiatDate
            // 
            this.comboItemSecretiatDate.Text = "تاریخ دبیرخانه";
            // 
            // comboItemAnalyzeDate
            // 
            this.comboItemAnalyzeDate.Text = "تاریخ آنالیز";
            // 
            // comboItemCostIncreaseDate
            // 
            this.comboItemCostIncreaseDate.Text = "تاریخ ثبت کسورات";
            // 
            // comboItemPaymentDoctorDate
            // 
            this.comboItemPaymentDoctorDate.Text = "تاریخ پرداخت نهایی";
            // 
            // comboItemBonyadConfirmDate
            // 
            this.comboItemBonyadConfirmDate.Text = "تاریخ نامه تایید بنیاد";
            // 
            // comboItemAccountingDocumentDate
            // 
            this.comboItemAccountingDocumentDate.Text = "تاریخ سند حسابداری";
            // 
            // comboItemBursaryDate
            // 
            this.comboItemBursaryDate.Text = "تاریخ سند خزانه داری";
            // 
            // DatePickerStart
            // 
            this.DatePickerStart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DatePickerStart.BackColor = System.Drawing.Color.White;
            this.DatePickerStart.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.DatePickerStart.Location = new System.Drawing.Point(325, 13);
            this.DatePickerStart.Name = "DatePickerStart";
            this.DatePickerStart.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DatePickerStart.ShowTime = false;
            this.DatePickerStart.Size = new System.Drawing.Size(101, 18);
            this.DatePickerStart.TabIndex = 4;
            this.DatePickerStart.Text = "mssDatePicker1";
            this.DatePickerStart.UseFarsiDigits = true;
            this.DatePickerStart.Value = ((KagNetComponents2.KagPersianDate)(resources.GetObject("DatePickerStart.Value")));
            this.DatePickerStart.ValueEn = new System.DateTime(2017, 3, 6, 18, 57, 29, 0);
            this.DatePickerStart.ValueChanged += new KagNetComponents2.KagPersianDatePicker.onValueChanged(this.DatePickerStart_ValueChanged);
            // 
            // mssLabel5
            // 
            this.mssLabel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mssLabel5.AutoSize = true;
            // 
            // 
            // 
            this.mssLabel5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mssLabel5.ForeColor = System.Drawing.Color.Black;
            this.mssLabel5.Location = new System.Drawing.Point(669, 14);
            this.mssLabel5.Name = "mssLabel5";
            this.mssLabel5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mssLabel5.Size = new System.Drawing.Size(130, 16);
            this.mssLabel5.TabIndex = 0;
            this.mssLabel5.Text = "پرداختی براساس بازه زمانی";
            // 
            // mssLabel1
            // 
            this.mssLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mssLabel1.AutoSize = true;
            // 
            // 
            // 
            this.mssLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mssLabel1.ForeColor = System.Drawing.Color.Black;
            this.mssLabel1.Location = new System.Drawing.Point(603, 14);
            this.mssLabel1.Name = "mssLabel1";
            this.mssLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mssLabel1.Size = new System.Drawing.Size(33, 16);
            this.mssLabel1.TabIndex = 0;
            this.mssLabel1.Text = "ستون:";
            // 
            // mssLabel2
            // 
            this.mssLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mssLabel2.AutoSize = true;
            // 
            // 
            // 
            this.mssLabel2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mssLabel2.ForeColor = System.Drawing.Color.Black;
            this.mssLabel2.Location = new System.Drawing.Point(429, 14);
            this.mssLabel2.Name = "mssLabel2";
            this.mssLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mssLabel2.Size = new System.Drawing.Size(38, 16);
            this.mssLabel2.TabIndex = 0;
            this.mssLabel2.Text = "از تاریخ:";
            // 
            // mssLabel3
            // 
            this.mssLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mssLabel3.AutoSize = true;
            // 
            // 
            // 
            this.mssLabel3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mssLabel3.ForeColor = System.Drawing.Color.Black;
            this.mssLabel3.Location = new System.Drawing.Point(256, 14);
            this.mssLabel3.Name = "mssLabel3";
            this.mssLabel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mssLabel3.Size = new System.Drawing.Size(37, 16);
            this.mssLabel3.TabIndex = 0;
            this.mssLabel3.Text = "تا تاریخ:";
            // 
            // VisitPatientPayment_UC
            // 
            this.Controls.Add(this.GridViewVisitPatientPayment);
            this.Controls.Add(this.mssPanel1);
            this.Controls.Add(this.HeaderGridVisitPatientPayment);
            this.Controls.Add(this.mssPanel2);
            this.Name = "VisitPatientPayment_UC";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(947, 467);
            this.Tag = "لیست پرداختی ویزیت";
            this.Load += new System.EventHandler(this.VisitPatientPayment_UC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vWVisitPatientPaymentBindingSource)).EndInit();
            this.mssPanel1.ResumeLayout(false);
            this.mssPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewVisitPatientPayment)).EndInit();
            this.ContextMenuStripStatus.ResumeLayout(false);
            this.mssPanel2.ResumeLayout(false);
            this.mssPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource vWVisitPatientPaymentBindingSource;
        private MSSHeaderGrid HeaderGridVisitPatientPayment;
        private MSSPanel mssPanel1;
        private MSSLabel label6;
        private MSSButton btnSetValueVisit;
        private MSSComboBox comboBoxSetValue;
        private DevComponents.Editors.ComboItem comboItemCostCachInsuIran;
        private DevComponents.Editors.ComboItem comboItemAnalyzeNo;
        private DevComponents.Editors.ComboItem comboItemAccountingDocumentNumber;
        private DevComponents.Editors.ComboItem comboItemCostVisitCo;
        private DevComponents.Editors.ComboItem comboItemCostIncrease;
        private DevComponents.Editors.ComboItem comboItemCostIncreasePercent;
        private DevComponents.Editors.ComboItem comboItemPaymentDoctor;
        private DevComponents.Editors.ComboItem comboItemPaymentStatus;
        private DevComponents.Editors.ComboItem comboItemDescription;
        private MSSIntBox nUpDownSetValue;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxPaymentStatus;
        private MSSDatePicker DatePickerSet;
        private MSSLabel mssLabel4;
        private DevComponents.DotNetBar.ButtonItem buttonItemVisitPaymentCalculateRimindAll;
        private MSSPanel mssPanel2;
        private MSSDatePicker DatePickerEnd;
        private MSSComboBox ComboBoxSerach;
        private DevComponents.Editors.ComboItem comboItemPaymentDate;
        private DevComponents.Editors.ComboItem comboItemLetterDate;
        private DevComponents.Editors.ComboItem comboItemContractDate;
        private DevComponents.Editors.ComboItem comboItemVisitDate;
        private DevComponents.Editors.ComboItem comboItemInsuLetterDate;
        private DevComponents.Editors.ComboItem comboItemSecretiatDate;
        private DevComponents.Editors.ComboItem comboItemAnalyzeDate;
        private DevComponents.Editors.ComboItem comboItemCostIncreaseDate;
        private DevComponents.Editors.ComboItem comboItemPaymentDoctorDate;
        private MSSDatePicker DatePickerStart;
        private MSSLabel mssLabel1;
        private MSSLabel mssLabel2;
        private MSSLabel mssLabel3;
        private MSSTextBox textBoxSetValue;
        private DevComponents.Editors.ComboItem comboItemBonyadConfirmDate;
        private DevComponents.Editors.ComboItem comboItemAccountingDocumentDate;
        private DevComponents.Editors.ComboItem comboItemBursaryDate;
        private DevComponents.Editors.ComboItem comboItemAnalyzePage;
        private DevComponents.Editors.ComboItem comboItemBursaryNumber;
        private DevComponents.Editors.ComboItem comboItemCostVisitCoPercent;
        private DevComponents.Editors.ComboItem comboItemCostDoctorTax;
        private DevComponents.Editors.ComboItem comboItemBonyadConfirmNo;
        private DevComponents.Editors.ComboItem comboItemSecretiatNo;
        private DevComponents.Editors.ComboItem comboItemCostDoctorTaxPercent;
        private MSSGridexView GridViewVisitPatientPayment;
        private DevComponents.Editors.ComboItem comboItemReportCode;
        private MSSContextMenuStrip ContextMenuStripStatus;
        private ToolStripMenuItem ToolStripMenuItemVisitPatientPaymentLog;
        private ToolStripMenuItem ToolStripMenuItemVisitPatientPaymentCurrentRow;
        private ToolStripMenuItem ToolStripMenuItemVisitPatientPaymentAllList;
        private DevComponents.Editors.ComboItem comboItemCostDoctorInsurance;
        private DevComponents.Editors.ComboItem comboItemCostDoctorInsurancePercent;
        private MSSComboBox comboBoxBank;
        private DevComponents.Editors.ComboItem comboItemCardBankNo1;
        private DevComponents.Editors.ComboItem comboItemBankName;
        private MSSLabel mssLabel5;
    }
}
