namespace MKH.SMS.View.UserControls
{
    partial class ReciveSMSList_UC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReciveSMSList_UC));
            Janus.Windows.GridEX.GridEXLayout GridexViewReciveSM_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.mssPanel2 = new MKH.Library.Control.MSSPanel(this.components);
            this.DatePickerEnd = new MKH.Library.Control.MSSDatePicker(this.components);
            this.DatePickerStart = new MKH.Library.Control.MSSDatePicker(this.components);
            this.mssLabel2 = new MKH.Library.Control.MSSLabel(this.components);
            this.mssLabel3 = new MKH.Library.Control.MSSLabel(this.components);
            this.HeaderGridReciveSM = new MKH.Library.Control.MSSHeaderGrid();
            this.GridexViewReciveSM = new MKH.Library.Control.MSSGridexView();
            this.vWReciveSMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonItemReciveNoRead = new DevComponents.DotNetBar.ButtonItem();
            this.mssPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridexViewReciveSM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWReciveSMBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mssPanel2
            // 
            this.mssPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.mssPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.mssPanel2.Controls.Add(this.DatePickerEnd);
            this.mssPanel2.Controls.Add(this.DatePickerStart);
            this.mssPanel2.Controls.Add(this.mssLabel2);
            this.mssPanel2.Controls.Add(this.mssLabel3);
            this.mssPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mssPanel2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.mssPanel2.Location = new System.Drawing.Point(0, 340);
            this.mssPanel2.Name = "mssPanel2";
            this.mssPanel2.Size = new System.Drawing.Size(916, 44);
            this.mssPanel2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.mssPanel2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.mssPanel2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.mssPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.mssPanel2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.mssPanel2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.mssPanel2.Style.GradientAngle = 90;
            this.mssPanel2.TabIndex = 37;
            // 
            // DatePickerEnd
            // 
            this.DatePickerEnd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DatePickerEnd.BackColor = System.Drawing.Color.White;
            this.DatePickerEnd.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.DatePickerEnd.Location = new System.Drawing.Point(296, 12);
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
            this.DatePickerStart.Location = new System.Drawing.Point(458, 12);
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
            this.mssLabel2.Location = new System.Drawing.Point(562, 12);
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
            this.mssLabel3.Location = new System.Drawing.Point(404, 12);
            this.mssLabel3.Name = "mssLabel3";
            this.mssLabel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mssLabel3.Size = new System.Drawing.Size(37, 16);
            this.mssLabel3.TabIndex = 0;
            this.mssLabel3.Text = "تا تاریخ:";
            // 
            // HeaderGridReciveSM
            // 
            // 
            // 
            // 
            this.HeaderGridReciveSM.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridReciveSM.BackgroundStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridReciveSM.BackgroundStyle.BorderBottomWidth = 1;
            this.HeaderGridReciveSM.BackgroundStyle.BorderLeftWidth = 1;
            this.HeaderGridReciveSM.BackgroundStyle.BorderRightWidth = 1;
            this.HeaderGridReciveSM.BackgroundStyle.BorderTopWidth = 1;
            this.HeaderGridReciveSM.BackgroundStyle.Class = "ItemPanel";
            this.HeaderGridReciveSM.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.HeaderGridReciveSM.BackgroundStyle.PaddingBottom = 1;
            this.HeaderGridReciveSM.BackgroundStyle.PaddingLeft = 1;
            this.HeaderGridReciveSM.BackgroundStyle.PaddingRight = 1;
            this.HeaderGridReciveSM.BackgroundStyle.PaddingTop = 1;
            this.HeaderGridReciveSM.ButtonDeletePermissionCode = 0;
            this.HeaderGridReciveSM.ButtonDeleteVisible = false;
            this.HeaderGridReciveSM.ButtonEditPermissionCode = 0;
            this.HeaderGridReciveSM.ButtonEditVisible = false;
            this.HeaderGridReciveSM.ButtonExcelExportVisible = true;
            this.HeaderGridReciveSM.ButtonExcelPermissionCode = 296;
            this.HeaderGridReciveSM.ButtonInsertPermissionCode = 0;
            this.HeaderGridReciveSM.ButtonInsertVisible = false;
            this.HeaderGridReciveSM.ButtonPrintExpertPermissionCode = 0;
            this.HeaderGridReciveSM.ButtonPrintExpertVisible = false;
            this.HeaderGridReciveSM.ButtonPrintPermissionCode = 295;
            this.HeaderGridReciveSM.ButtonPrintVisible = true;
            this.HeaderGridReciveSM.ButtonPrintWithDesignPermissionCode = 0;
            this.HeaderGridReciveSM.ButtonPrintWithDesignVisible = false;
            this.HeaderGridReciveSM.ButtonRefreshVisible = true;
            this.HeaderGridReciveSM.ButtonSearchExpertVisible = false;
            this.HeaderGridReciveSM.ButtonSearchVisible = true;
            this.HeaderGridReciveSM.ButtonSelectorVisible = true;
            this.HeaderGridReciveSM.ContainerControlProcessDialogKey = true;
            this.HeaderGridReciveSM.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderGridReciveSM.FitButtonsToContainerWidth = true;
            this.HeaderGridReciveSM.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.HeaderGridReciveSM.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.HeaderGridReciveSM.GridViewSet = this.GridexViewReciveSM;
            this.HeaderGridReciveSM.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItemReciveNoRead});
            this.HeaderGridReciveSM.Location = new System.Drawing.Point(0, 0);
            this.HeaderGridReciveSM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HeaderGridReciveSM.Name = "HeaderGridReciveSM";
            this.HeaderGridReciveSM.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HeaderGridReciveSM.Size = new System.Drawing.Size(916, 56);
            this.HeaderGridReciveSM.TabIndex = 32;
            this.HeaderGridReciveSM.Tag = "";
            this.HeaderGridReciveSM.ThemeAware = true;
            this.HeaderGridReciveSM.buttonItemRefreshClick += new MKH.Library.Control.MSSHeaderGrid.buttonItemRefreshClickEventHandler(this.headerGridReciveSM_btnRefreshClick);
            // 
            // GridexViewReciveSM
            // 
            this.GridexViewReciveSM.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.GridexViewReciveSM.AlternatingRowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridexViewReciveSM.BuiltInTextsData = resources.GetString("GridexViewReciveSM.BuiltInTextsData");
            this.GridexViewReciveSM.CardViewGridlines = Janus.Windows.GridEX.CardViewGridlines.Both;
            this.GridexViewReciveSM.DataSource = this.vWReciveSMBindingSource;
            this.GridexViewReciveSM.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            GridexViewReciveSM_DesignTimeLayout.LayoutString = resources.GetString("GridexViewReciveSM_DesignTimeLayout.LayoutString");
            this.GridexViewReciveSM.DesignTimeLayout = GridexViewReciveSM_DesignTimeLayout;
            this.GridexViewReciveSM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridexViewReciveSM.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.GridexViewReciveSM.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.GridexViewReciveSM.Font = new System.Drawing.Font("Tahoma", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.GridexViewReciveSM.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridexViewReciveSM.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
            this.GridexViewReciveSM.Location = new System.Drawing.Point(0, 56);
            this.GridexViewReciveSM.Name = "GridexViewReciveSM";
            this.GridexViewReciveSM.RecordNavigator = true;
            this.GridexViewReciveSM.RowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridexViewReciveSM.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition;
            this.GridexViewReciveSM.RowHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridexViewReciveSM.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.GridexViewReciveSM.Size = new System.Drawing.Size(916, 284);
            this.GridexViewReciveSM.TabIndex = 38;
            this.GridexViewReciveSM.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.GridexViewReciveSM.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010;
            // 
            // vWReciveSMBindingSource
            // 
            this.vWReciveSMBindingSource.DataSource = typeof(MKH.SMS.Model.ReciveSMS.VW_ReciveSM);
            // 
            // buttonItemReciveNoRead
            // 
            this.buttonItemReciveNoRead.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemReciveNoRead.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemReciveNoRead.Icon = ((System.Drawing.Icon)(resources.GetObject("buttonItemReciveNoRead.Icon")));
            this.buttonItemReciveNoRead.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Large;
            this.buttonItemReciveNoRead.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemReciveNoRead.Name = "buttonItemReciveNoRead";
            this.buttonItemReciveNoRead.Tag = "294";
            this.buttonItemReciveNoRead.Text = "دریافت خوانده نشده ها";
            this.buttonItemReciveNoRead.ThemeAware = true;
            this.buttonItemReciveNoRead.Click += new System.EventHandler(this.buttonItemReciveNoRead_Click);
            // 
            // ReciveSMSList_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.GridexViewReciveSM);
            this.Controls.Add(this.mssPanel2);
            this.Controls.Add(this.HeaderGridReciveSM);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ReciveSMSList_UC";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(916, 384);
            this.Tag = "دریافتی SMS لیست";
            this.Load += new System.EventHandler(this.ReciveSMList_UC_Load);
            this.mssPanel2.ResumeLayout(false);
            this.mssPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridexViewReciveSM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWReciveSMBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MKH.Library.Control.MSSHeaderGrid HeaderGridReciveSM;
        private DevComponents.DotNetBar.ButtonItem buttonItemReciveNoRead;
        private Library.Control.MSSPanel mssPanel2;
        private Library.Control.MSSDatePicker DatePickerEnd;
        private Library.Control.MSSDatePicker DatePickerStart;
        private Library.Control.MSSLabel mssLabel2;
        private Library.Control.MSSLabel mssLabel3;
        private System.Windows.Forms.BindingSource vWReciveSMBindingSource;
        private Library.Control.MSSGridexView GridexViewReciveSM;
    }
}
