namespace MKH.Library.Forms
{
    partial class MSSSearchPanel_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MSSSearchPanel_frm));
            this.groupPanel_All = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.buttonOK = new DevComponents.DotNetBar.ButtonX();
            this.buttonAddSearch = new DevComponents.DotNetBar.ButtonX();
            this.textBoxVisitCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanelVisit = new System.Windows.Forms.TableLayoutPanel();
            this.groupPanel_All.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupPanel_All
            // 
            this.groupPanel_All.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel_All.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel_All.Controls.Add(this.buttonOK);
            this.groupPanel_All.Controls.Add(this.buttonAddSearch);
            this.groupPanel_All.Controls.Add(this.textBoxVisitCode);
            this.groupPanel_All.Controls.Add(this.label1);
            this.groupPanel_All.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanel_All.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel_All.IsShadowEnabled = true;
            this.groupPanel_All.Location = new System.Drawing.Point(0, 0);
            this.groupPanel_All.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupPanel_All.Name = "groupPanel_All";
            this.groupPanel_All.Size = new System.Drawing.Size(788, 52);
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
            this.groupPanel_All.Text = "جستجو";
            // 
            // buttonOK
            // 
            this.buttonOK.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonOK.BackColor = System.Drawing.Color.MistyRose;
            this.buttonOK.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta;
            this.buttonOK.Font = new System.Drawing.Font("Tahoma", 8.150944F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonOK.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.buttonOK.Location = new System.Drawing.Point(3, 0);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.buttonOK.Size = new System.Drawing.Size(93, 26);
            this.buttonOK.TabIndex = 72;
            this.buttonOK.Text = "تایید";
            this.buttonOK.TextColor = System.Drawing.Color.Black;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonAddSearch
            // 
            this.buttonAddSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonAddSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonAddSearch.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonAddSearch.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddSearch.Image")));
            this.buttonAddSearch.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.buttonAddSearch.Location = new System.Drawing.Point(706, 0);
            this.buttonAddSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddSearch.Name = "buttonAddSearch";
            this.buttonAddSearch.Size = new System.Drawing.Size(68, 26);
            this.buttonAddSearch.TabIndex = 71;
            this.buttonAddSearch.Text = "اضافه";
            this.buttonAddSearch.TextColor = System.Drawing.Color.Black;
            this.buttonAddSearch.Click += new System.EventHandler(this.buttonAddSearch_Click);
            // 
            // textBoxVisitCode
            // 
            this.textBoxVisitCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.textBoxVisitCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxVisitCode.Location = new System.Drawing.Point(114, 5);
            this.textBoxVisitCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxVisitCode.Name = "textBoxVisitCode";
            this.textBoxVisitCode.ReadOnly = true;
            this.textBoxVisitCode.Size = new System.Drawing.Size(486, 17);
            this.textBoxVisitCode.TabIndex = 68;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(606, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 67;
            this.label1.Text = "عبارت جستجو:";
            // 
            // tableLayoutPanelVisit
            // 
            this.tableLayoutPanelVisit.AutoScroll = true;
            this.tableLayoutPanelVisit.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanelVisit.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tableLayoutPanelVisit.ColumnCount = 1;
            this.tableLayoutPanelVisit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelVisit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelVisit.Location = new System.Drawing.Point(0, 52);
            this.tableLayoutPanelVisit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanelVisit.Name = "tableLayoutPanelVisit";
            this.tableLayoutPanelVisit.RowCount = 1;
            this.tableLayoutPanelVisit.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelVisit.Size = new System.Drawing.Size(788, 146);
            this.tableLayoutPanelVisit.TabIndex = 6;
            // 
            // MSSSearchPanel_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 198);
            this.Controls.Add(this.tableLayoutPanelVisit);
            this.Controls.Add(this.groupPanel_All);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MSSSearchPanel_frm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Load += new System.EventHandler(this.MSSSearchPanel_UC_Load);
            this.groupPanel_All.ResumeLayout(false);
            this.groupPanel_All.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel_All;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelVisit;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxVisitCode;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.ButtonX buttonAddSearch;
        private DevComponents.DotNetBar.ButtonX buttonOK;
    }
}