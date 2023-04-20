namespace MKH.Library.Forms
{
    partial class MSSSelectorMulti_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MSSSelectorMulti_frm));
            Janus.Windows.GridEX.GridEXLayout GridexViewSelector_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.panelSelector = new DevComponents.DotNetBar.PanelEx();
            this.button_OK = new DevComponents.DotNetBar.ButtonX();
            this.GridexViewSelector = new MKH.Library.Control.MSSGridexView();
            this.panelSelector.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridexViewSelector)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSelector
            // 
            this.panelSelector.CanvasColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelSelector.Controls.Add(this.button_OK);
            this.panelSelector.Controls.Add(this.GridexViewSelector);
            this.panelSelector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSelector.Location = new System.Drawing.Point(0, 0);
            this.panelSelector.Margin = new System.Windows.Forms.Padding(0);
            this.panelSelector.Name = "panelSelector";
            this.panelSelector.Padding = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.panelSelector.ShowFocusRectangle = true;
            this.panelSelector.Size = new System.Drawing.Size(410, 483);
            this.panelSelector.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelSelector.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panelSelector.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.CustomizeText;
            this.panelSelector.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelSelector.Style.BorderColor.Color = System.Drawing.Color.Olive;
            this.panelSelector.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelSelector.Style.GradientAngle = 90;
            this.panelSelector.TabIndex = 3;
            // 
            // button_OK
            // 
            this.button_OK.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.button_OK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_OK.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.button_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_OK.Image = ((System.Drawing.Image)(resources.GetObject("button_OK.Image")));
            this.button_OK.Location = new System.Drawing.Point(28, 438);
            this.button_OK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(352, 28);
            this.button_OK.TabIndex = 17;
            this.button_OK.Text = "انتخاب و ارسال";
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // GridexViewSelector
            // 
            this.GridexViewSelector.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.GridexViewSelector.AlternatingRowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridexViewSelector.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridexViewSelector.BuiltInTextsData = resources.GetString("GridexViewSelector.BuiltInTextsData");
            this.GridexViewSelector.CardViewGridlines = Janus.Windows.GridEX.CardViewGridlines.Both;
            this.GridexViewSelector.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            GridexViewSelector_DesignTimeLayout.LayoutString = resources.GetString("GridexViewSelector_DesignTimeLayout.LayoutString");
            this.GridexViewSelector.DesignTimeLayout = GridexViewSelector_DesignTimeLayout;
            this.GridexViewSelector.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.GridexViewSelector.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.GridexViewSelector.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.GridexViewSelector.Font = new System.Drawing.Font("Tahoma", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.GridexViewSelector.GroupByBoxVisible = false;
            this.GridexViewSelector.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridexViewSelector.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
            this.GridexViewSelector.Location = new System.Drawing.Point(28, 25);
            this.GridexViewSelector.Name = "GridexViewSelector";
            this.GridexViewSelector.RecordNavigator = true;
            this.GridexViewSelector.RowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridexViewSelector.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition;
            this.GridexViewSelector.RowHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridexViewSelector.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.GridexViewSelector.Size = new System.Drawing.Size(352, 400);
            this.GridexViewSelector.TabIndex = 15;
            this.GridexViewSelector.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.GridexViewSelector.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010;
            // 
            // MSSSelectorMulti_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 483);
            this.Controls.Add(this.panelSelector);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "MSSSelectorMulti_frm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.Text = "انتخاب";
            this.Load += new System.EventHandler(this.MSSSelectorMulti_frm_Load);
            this.panelSelector.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridexViewSelector)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelSelector;
        private Control.MSSGridexView GridexViewSelector;
        public DevComponents.DotNetBar.ButtonX button_OK;
    }
}