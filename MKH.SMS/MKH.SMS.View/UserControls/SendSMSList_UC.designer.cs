namespace MKH.SMS.View.UserControls
{
    partial class SendSMSList_UC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendSMSList_UC));
            Janus.Windows.GridEX.GridEXLayout GridexViewSendSMS_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.GridexViewSendSMS = new MKH.Library.Control.MSSGridexView();
            this.ContextMenuStripResend = new MKH.Library.Control.MSSContextMenuStrip(this.components);
            this.ToolStripMenuItemResendSMS = new System.Windows.Forms.ToolStripMenuItem();
            this.mssPanel2 = new MKH.Library.Control.MSSPanel(this.components);
            this.LabelSleep = new MKH.Library.Control.MSSLabel(this.components);
            this.DatePickerEnd = new MKH.Library.Control.MSSDatePicker(this.components);
            this.DatePickerStart = new MKH.Library.Control.MSSDatePicker(this.components);
            this.mssLabel2 = new MKH.Library.Control.MSSLabel(this.components);
            this.mssLabel3 = new MKH.Library.Control.MSSLabel(this.components);
            this.HeaderGridSendSMS = new MKH.Library.Control.MSSHeaderGrid();
            this.buttonItemSendSMS = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem2 = new DevComponents.DotNetBar.ButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.GridexViewSendSMS)).BeginInit();
            this.ContextMenuStripResend.SuspendLayout();
            this.mssPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridexViewSendSMS
            // 
            this.GridexViewSendSMS.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.GridexViewSendSMS.AlternatingRowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridexViewSendSMS.BuiltInTextsData = resources.GetString("GridexViewSendSMS.BuiltInTextsData");
            this.GridexViewSendSMS.CardViewGridlines = Janus.Windows.GridEX.CardViewGridlines.Both;
            this.GridexViewSendSMS.ContextMenuStrip = this.ContextMenuStripResend;
            this.GridexViewSendSMS.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            GridexViewSendSMS_DesignTimeLayout.LayoutString = resources.GetString("GridexViewSendSMS_DesignTimeLayout.LayoutString");
            this.GridexViewSendSMS.DesignTimeLayout = GridexViewSendSMS_DesignTimeLayout;
            this.GridexViewSendSMS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridexViewSendSMS.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.GridexViewSendSMS.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.GridexViewSendSMS.Font = new System.Drawing.Font("Tahoma", 8.150944F);
            this.GridexViewSendSMS.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridexViewSendSMS.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
            this.GridexViewSendSMS.Location = new System.Drawing.Point(0, 56);
            this.GridexViewSendSMS.Name = "GridexViewSendSMS";
            this.GridexViewSendSMS.RecordNavigator = true;
            this.GridexViewSendSMS.RowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridexViewSendSMS.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition;
            this.GridexViewSendSMS.RowHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridexViewSendSMS.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.GridexViewSendSMS.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelection;
            this.GridexViewSendSMS.Size = new System.Drawing.Size(958, 464);
            this.GridexViewSendSMS.TabIndex = 41;
            this.GridexViewSendSMS.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.GridexViewSendSMS.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010;
            // 
            // ContextMenuStripResend
            // 
            this.ContextMenuStripResend.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemResendSMS});
            this.ContextMenuStripResend.Name = "mssContextMenuStrip1";
            this.ContextMenuStripResend.Size = new System.Drawing.Size(150, 26);
            // 
            // ToolStripMenuItemResendSMS
            // 
            this.ToolStripMenuItemResendSMS.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripMenuItemResendSMS.Name = "ToolStripMenuItemResendSMS";
            this.ToolStripMenuItemResendSMS.Size = new System.Drawing.Size(149, 22);
            this.ToolStripMenuItemResendSMS.Text = "ارسال دوباره";
            this.ToolStripMenuItemResendSMS.Click += new System.EventHandler(this.ToolStripMenuItemResendSMS_Click);
            // 
            // mssPanel2
            // 
            this.mssPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.mssPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.mssPanel2.Controls.Add(this.LabelSleep);
            this.mssPanel2.Controls.Add(this.DatePickerEnd);
            this.mssPanel2.Controls.Add(this.DatePickerStart);
            this.mssPanel2.Controls.Add(this.mssLabel2);
            this.mssPanel2.Controls.Add(this.mssLabel3);
            this.mssPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mssPanel2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.mssPanel2.Location = new System.Drawing.Point(0, 520);
            this.mssPanel2.Name = "mssPanel2";
            this.mssPanel2.Size = new System.Drawing.Size(958, 44);
            this.mssPanel2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.mssPanel2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.mssPanel2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.mssPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.mssPanel2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.mssPanel2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.mssPanel2.Style.GradientAngle = 90;
            this.mssPanel2.TabIndex = 40;
            // 
            // LabelSleep
            // 
            this.LabelSleep.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LabelSleep.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.LabelSleep.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelSleep.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LabelSleep.ForeColor = System.Drawing.Color.Maroon;
            this.LabelSleep.Location = new System.Drawing.Point(147, 12);
            this.LabelSleep.Name = "LabelSleep";
            this.LabelSleep.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LabelSleep.SingleLineColor = System.Drawing.Color.Maroon;
            this.LabelSleep.Size = new System.Drawing.Size(199, 23);
            this.LabelSleep.TabIndex = 3;
            this.LabelSleep.Text = "لطفا کمی صبر کنید ...";
            this.LabelSleep.Visible = false;
            // 
            // DatePickerEnd
            // 
            this.DatePickerEnd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DatePickerEnd.BackColor = System.Drawing.Color.White;
            this.DatePickerEnd.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.DatePickerEnd.Location = new System.Drawing.Point(378, 12);
            this.DatePickerEnd.Name = "DatePickerEnd";
            this.DatePickerEnd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DatePickerEnd.ShowTime = false;
            this.DatePickerEnd.Size = new System.Drawing.Size(103, 18);
            this.DatePickerEnd.TabIndex = 2;
            this.DatePickerEnd.Text = "mssDatePicker1";
            this.DatePickerEnd.UseFarsiDigits = true;
            this.DatePickerEnd.Value = ((KagNetComponents2.KagPersianDate)(resources.GetObject("DatePickerEnd.Value")));
            this.DatePickerEnd.ValueEn = new System.DateTime(2017, 3, 6, 18, 57, 29, 0);
            this.DatePickerEnd.ValueChanged += new KagNetComponents2.KagPersianDatePicker.onValueChanged(this.DatePickerStart_ValueChanged);
            // 
            // DatePickerStart
            // 
            this.DatePickerStart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DatePickerStart.BackColor = System.Drawing.Color.White;
            this.DatePickerStart.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.DatePickerStart.Location = new System.Drawing.Point(540, 12);
            this.DatePickerStart.Name = "DatePickerStart";
            this.DatePickerStart.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DatePickerStart.ShowTime = false;
            this.DatePickerStart.Size = new System.Drawing.Size(101, 18);
            this.DatePickerStart.TabIndex = 2;
            this.DatePickerStart.Text = "mssDatePicker1";
            this.DatePickerStart.UseFarsiDigits = true;
            this.DatePickerStart.Value = ((KagNetComponents2.KagPersianDate)(resources.GetObject("DatePickerStart.Value")));
            this.DatePickerStart.ValueEn = new System.DateTime(2017, 3, 6, 18, 57, 29, 0);
            this.DatePickerStart.ValueChanged += new KagNetComponents2.KagPersianDatePicker.onValueChanged(this.DatePickerStart_ValueChanged);
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
            this.mssLabel2.Location = new System.Drawing.Point(644, 12);
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
            this.mssLabel3.Location = new System.Drawing.Point(486, 12);
            this.mssLabel3.Name = "mssLabel3";
            this.mssLabel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mssLabel3.Size = new System.Drawing.Size(37, 16);
            this.mssLabel3.TabIndex = 0;
            this.mssLabel3.Text = "تا تاریخ:";
            // 
            // HeaderGridSendSMS
            // 
            // 
            // 
            // 
            this.HeaderGridSendSMS.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridSendSMS.BackgroundStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridSendSMS.BackgroundStyle.BorderBottomWidth = 1;
            this.HeaderGridSendSMS.BackgroundStyle.BorderLeftWidth = 1;
            this.HeaderGridSendSMS.BackgroundStyle.BorderRightWidth = 1;
            this.HeaderGridSendSMS.BackgroundStyle.BorderTopWidth = 1;
            this.HeaderGridSendSMS.BackgroundStyle.Class = "ItemPanel";
            this.HeaderGridSendSMS.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.HeaderGridSendSMS.BackgroundStyle.PaddingBottom = 1;
            this.HeaderGridSendSMS.BackgroundStyle.PaddingLeft = 1;
            this.HeaderGridSendSMS.BackgroundStyle.PaddingRight = 1;
            this.HeaderGridSendSMS.BackgroundStyle.PaddingTop = 1;
            this.HeaderGridSendSMS.ButtonDeletePermissionCode = 0;
            this.HeaderGridSendSMS.ButtonDeleteVisible = false;
            this.HeaderGridSendSMS.ButtonEditPermissionCode = 0;
            this.HeaderGridSendSMS.ButtonEditVisible = false;
            this.HeaderGridSendSMS.ButtonExcelExportVisible = true;
            this.HeaderGridSendSMS.ButtonExcelPermissionCode = 293;
            this.HeaderGridSendSMS.ButtonInsertPermissionCode = 0;
            this.HeaderGridSendSMS.ButtonInsertVisible = false;
            this.HeaderGridSendSMS.ButtonPrintExpertPermissionCode = 0;
            this.HeaderGridSendSMS.ButtonPrintExpertVisible = false;
            this.HeaderGridSendSMS.ButtonPrintPermissionCode = 292;
            this.HeaderGridSendSMS.ButtonPrintVisible = true;
            this.HeaderGridSendSMS.ButtonPrintWithDesignPermissionCode = 0;
            this.HeaderGridSendSMS.ButtonPrintWithDesignVisible = false;
            this.HeaderGridSendSMS.ButtonRefreshVisible = true;
            this.HeaderGridSendSMS.ButtonSearchExpertVisible = false;
            this.HeaderGridSendSMS.ButtonSearchVisible = true;
            this.HeaderGridSendSMS.ButtonSelectorVisible = true;
            this.HeaderGridSendSMS.ContainerControlProcessDialogKey = true;
            this.HeaderGridSendSMS.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderGridSendSMS.FitButtonsToContainerWidth = true;
            this.HeaderGridSendSMS.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.HeaderGridSendSMS.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.HeaderGridSendSMS.GridViewSet = this.GridexViewSendSMS;
            this.HeaderGridSendSMS.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItemSendSMS,
            this.buttonItem1,
            this.buttonItem2});
            this.HeaderGridSendSMS.Location = new System.Drawing.Point(0, 0);
            this.HeaderGridSendSMS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HeaderGridSendSMS.Name = "HeaderGridSendSMS";
            this.HeaderGridSendSMS.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HeaderGridSendSMS.Size = new System.Drawing.Size(958, 56);
            this.HeaderGridSendSMS.TabIndex = 39;
            this.HeaderGridSendSMS.Tag = "";
            this.HeaderGridSendSMS.ThemeAware = true;
            this.HeaderGridSendSMS.buttonItemRefreshClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemRefreshClickEventHandler(this.headerGridSendSMS_btnRefreshClick);
            // 
            // buttonItemSendSMS
            // 
            this.buttonItemSendSMS.BeginGroup = true;
            this.buttonItemSendSMS.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemSendSMS.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemSendSMS.Image = ((System.Drawing.Image)(resources.GetObject("buttonItemSendSMS.Image")));
            this.buttonItemSendSMS.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemSendSMS.Name = "buttonItemSendSMS";
            this.buttonItemSendSMS.Text = "ارسال گروهی";
            this.buttonItemSendSMS.ThemeAware = true;
            this.buttonItemSendSMS.Click += new System.EventHandler(this.buttonItemSendSMS_Click);
            // 
            // buttonItem1
            // 
            this.buttonItem1.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem1.ForeColor = System.Drawing.Color.Gold;
            this.buttonItem1.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem1.Image")));
            this.buttonItem1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.Text = "باز خوانی وضعیت";
            this.buttonItem1.ThemeAware = true;
            // 
            // buttonItem2
            // 
            this.buttonItem2.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem2.ForeColor = System.Drawing.Color.Gold;
            this.buttonItem2.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem2.Image")));
            this.buttonItem2.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem2.Name = "buttonItem2";
            this.buttonItem2.Text = "باز ارسال پیامک ها";
            this.buttonItem2.ThemeAware = true;
            // 
            // SendSMSList_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GridexViewSendSMS);
            this.Controls.Add(this.mssPanel2);
            this.Controls.Add(this.HeaderGridSendSMS);
            this.Font = new System.Drawing.Font("Tahoma", 7.841584F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "SendSMSList_UC";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(958, 564);
            this.Tag = "های ارسالی SMS لیست";
            this.Load += new System.EventHandler(this.SendSMSList_UC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridexViewSendSMS)).EndInit();
            this.ContextMenuStripResend.ResumeLayout(false);
            this.mssPanel2.ResumeLayout(false);
            this.mssPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Library.Control.MSSGridexView GridexViewSendSMS;
        private Library.Control.MSSPanel mssPanel2;
        private Library.Control.MSSDatePicker DatePickerEnd;
        private Library.Control.MSSDatePicker DatePickerStart;
        private Library.Control.MSSLabel mssLabel2;
        private Library.Control.MSSLabel mssLabel3;
        private Library.Control.MSSHeaderGrid HeaderGridSendSMS;
        private DevComponents.DotNetBar.ButtonItem buttonItemSendSMS;
        private Library.Control.MSSContextMenuStrip ContextMenuStripResend;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemResendSMS;
        private Library.Control.MSSLabel LabelSleep;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.DotNetBar.ButtonItem buttonItem2;
    }
}
