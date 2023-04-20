using MKH.Library.Control;
namespace MKH.SMS.View.Forms
{
    partial class Key_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Key_frm));
            Janus.Windows.GridEX.GridEXLayout GridexViewKey_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.panelEx_Users = new MKH.Library.Control.MSSPanel(this.components);
            this.GridexViewKey = new MKH.Library.Control.MSSGridexView();
            this.label1 = new MKH.Library.Control.MSSLabel(this.components);
            this.btnDel = new MKH.Library.Control.MSSButton(this.components);
            this.btnNew = new MKH.Library.Control.MSSButton(this.components);
            this.textBoxKey = new MKH.Library.Control.MSSTextBox(this.components);
            this.panelEx_Users.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridexViewKey)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx_Users
            // 
            this.panelEx_Users.CanvasColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelEx_Users.Controls.Add(this.GridexViewKey);
            this.panelEx_Users.Controls.Add(this.label1);
            this.panelEx_Users.Controls.Add(this.btnDel);
            this.panelEx_Users.Controls.Add(this.btnNew);
            this.panelEx_Users.Controls.Add(this.textBoxKey);
            this.panelEx_Users.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx_Users.Location = new System.Drawing.Point(0, 0);
            this.panelEx_Users.Margin = new System.Windows.Forms.Padding(0);
            this.panelEx_Users.Name = "panelEx_Users";
            this.panelEx_Users.Padding = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.panelEx_Users.ShowFocusRectangle = true;
            this.panelEx_Users.Size = new System.Drawing.Size(400, 466);
            this.panelEx_Users.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx_Users.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panelEx_Users.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.CustomizeText;
            this.panelEx_Users.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx_Users.Style.BorderColor.Color = System.Drawing.Color.Olive;
            this.panelEx_Users.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx_Users.Style.GradientAngle = 90;
            this.panelEx_Users.TabIndex = 3;
            // 
            // GridexViewKey
            // 
            this.GridexViewKey.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.GridexViewKey.AlternatingRowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridexViewKey.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridexViewKey.BuiltInTextsData = resources.GetString("GridexViewKey.BuiltInTextsData");
            this.GridexViewKey.CardViewGridlines = Janus.Windows.GridEX.CardViewGridlines.Both;
            this.GridexViewKey.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            GridexViewKey_DesignTimeLayout.LayoutString = resources.GetString("GridexViewKey_DesignTimeLayout.LayoutString");
            this.GridexViewKey.DesignTimeLayout = GridexViewKey_DesignTimeLayout;
            this.GridexViewKey.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.GridexViewKey.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.GridexViewKey.Font = new System.Drawing.Font("Tahoma", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.GridexViewKey.GroupByBoxVisible = false;
            this.GridexViewKey.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridexViewKey.Location = new System.Drawing.Point(18, 75);
            this.GridexViewKey.Name = "GridexViewKey";
            this.GridexViewKey.RecordNavigator = true;
            this.GridexViewKey.RowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridexViewKey.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition;
            this.GridexViewKey.RowHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridexViewKey.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.GridexViewKey.Size = new System.Drawing.Size(364, 367);
            this.GridexViewKey.TabIndex = 18;
            this.GridexViewKey.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.GridexViewKey.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010;
            this.GridexViewKey.DoubleClick += new System.EventHandler(this.GridexViewKey_DoubleClick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            // 
            // 
            // 
            this.label1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(319, 13);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "متن مورد نظر:";
            // 
            // btnDel
            // 
            this.btnDel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDel.Location = new System.Drawing.Point(27, 39);
            this.btnDel.Name = "btnDel";
            this.btnDel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnDel.Size = new System.Drawing.Size(46, 21);
            this.btnDel.TabIndex = 16;
            this.btnDel.Text = "حذف -";
            this.btnDel.Tooltip = "جدید";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnNew
            // 
            this.btnNew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnNew.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnNew.Location = new System.Drawing.Point(27, 12);
            this.btnNew.Name = "btnNew";
            this.btnNew.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnNew.Size = new System.Drawing.Size(46, 21);
            this.btnNew.TabIndex = 15;
            this.btnNew.Text = "اضافه +";
            this.btnNew.Tooltip = "اضافه";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // textBoxKey
            // 
            this.textBoxKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxKey.BackColor = System.Drawing.Color.Azure;
            // 
            // 
            // 
            this.textBoxKey.Border.Class = "TextBoxBorder";
            this.textBoxKey.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxKey.ForeColor = System.Drawing.Color.Black;
            this.textBoxKey.Location = new System.Drawing.Point(79, 12);
            this.textBoxKey.Multiline = true;
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(238, 47);
            this.textBoxKey.TabIndex = 13;
            // 
            // Key_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 466);
            this.Controls.Add(this.panelEx_Users);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Key_frm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.Text = "جملات کلیدی";
            this.Load += new System.EventHandler(this.Key_frm_Load);
            this.panelEx_Users.ResumeLayout(false);
            this.panelEx_Users.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridexViewKey)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MSSPanel panelEx_Users;
        private MSSTextBox textBoxKey;
        private MSSButton btnNew;
        private MSSButton btnDel;
        private MSSLabel label1;
        private MSSGridexView GridexViewKey;
    }
}