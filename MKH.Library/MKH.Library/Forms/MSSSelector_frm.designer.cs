namespace MKH.Library.Forms
{
    partial class MSSSelector_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MSSSelector_frm));
            Janus.Windows.GridEX.GridEXLayout GridexViewSelector_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.panelSelector = new DevComponents.DotNetBar.PanelEx();
            this.GridexViewSelector = new MKH.Library.Control.MSSGridexView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelSelector.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridexViewSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSelector
            // 
            this.panelSelector.CanvasColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelSelector.Controls.Add(this.GridexViewSelector);
            this.panelSelector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSelector.Location = new System.Drawing.Point(0, 0);
            this.panelSelector.Margin = new System.Windows.Forms.Padding(0);
            this.panelSelector.Name = "panelSelector";
            this.panelSelector.Padding = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.panelSelector.ShowFocusRectangle = true;
            this.panelSelector.Size = new System.Drawing.Size(377, 524);
            this.panelSelector.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelSelector.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panelSelector.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.CustomizeText;
            this.panelSelector.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelSelector.Style.BorderColor.Color = System.Drawing.Color.Olive;
            this.panelSelector.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelSelector.Style.GradientAngle = 90;
            this.panelSelector.TabIndex = 3;
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
            this.GridexViewSelector.Size = new System.Drawing.Size(319, 474);
            this.GridexViewSelector.TabIndex = 15;
            this.GridexViewSelector.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.GridexViewSelector.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010;
            this.GridexViewSelector.DoubleClick += new System.EventHandler(this.dataGridView_MSSSelector_DoubleClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // MSSSelector_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 524);
            this.Controls.Add(this.panelSelector);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "MSSSelector_frm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.Text = "انتخاب";
            this.Load += new System.EventHandler(this.MSSSelector_frm_Load);
            this.panelSelector.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridexViewSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelSelector;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Control.MSSGridexView GridexViewSelector;
    }
}