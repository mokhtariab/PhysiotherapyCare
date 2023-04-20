namespace PhysiotherapyCare.View.MainForms.VisitHealthCare
{
    partial class VisitHealthCareDetail_UC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisitHealthCareDetail_UC));
            this.buttonDelete = new MKH.Library.Control.MSSButton(this.components);
            this.label1 = new MKH.Library.Control.MSSLabel(this.components);
            this.label2 = new MKH.Library.Control.MSSLabel(this.components);
            this.IntBoxServiceTypeDscFew = new MKH.Library.Control.MSSIntBox(this.components);
            this.LabelRow = new MKH.Library.Control.MSSLabel(this.components);
            this.mssLabel1 = new MKH.Library.Control.MSSLabel(this.components);
            this.IntBoxPriceType = new MKH.Library.Control.MSSIntBox(this.components);
            this.mssLabel2 = new MKH.Library.Control.MSSLabel(this.components);
            this.IntBoxTotalPriceType = new MKH.Library.Control.MSSIntBox(this.components);
            this.buttonServiceTypeDsc = new MKH.Library.Control.MSSButton(this.components);
            this.TextBoxServiceTypeDsc = new MKH.Library.Control.MSSTextBox(this.components);
            this.mssLabel3 = new MKH.Library.Control.MSSLabel(this.components);
            this.SuspendLayout();
            // 
            // buttonDelete
            // 
            this.buttonDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete.Image = ((System.Drawing.Image)(resources.GetObject("buttonDelete.Image")));
            this.buttonDelete.Location = new System.Drawing.Point(772, 3);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonDelete.Size = new System.Drawing.Size(34, 27);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            // 
            // 
            // 
            this.label1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(652, 8);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 66;
            this.label1.Text = "نوع و شرح خدمت";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            // 
            // 
            // 
            this.label2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(340, 8);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 68;
            this.label2.Text = "تعداد خدمات";
            // 
            // IntBoxServiceTypeDscFew
            // 
            this.IntBoxServiceTypeDscFew.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.General;
            this.IntBoxServiceTypeDscFew.Location = new System.Drawing.Point(298, 5);
            this.IntBoxServiceTypeDscFew.Name = "IntBoxServiceTypeDscFew";
            this.IntBoxServiceTypeDscFew.Size = new System.Drawing.Size(45, 21);
            this.IntBoxServiceTypeDscFew.TabIndex = 4;
            this.IntBoxServiceTypeDscFew.Text = "0";
            this.IntBoxServiceTypeDscFew.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
            this.IntBoxServiceTypeDscFew.Value = 0;
            this.IntBoxServiceTypeDscFew.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int32;
            this.IntBoxServiceTypeDscFew.ValueChanged += new System.EventHandler(this.IntBoxServiceTypeDscFew_ValueChanged);
            // 
            // LabelRow
            // 
            this.LabelRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelRow.AutoSize = true;
            this.LabelRow.BackColor = System.Drawing.SystemColors.Info;
            // 
            // 
            // 
            this.LabelRow.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelRow.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRow.ForeColor = System.Drawing.Color.Olive;
            this.LabelRow.Location = new System.Drawing.Point(747, 1);
            this.LabelRow.Name = "LabelRow";
            this.LabelRow.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LabelRow.Size = new System.Drawing.Size(14, 30);
            this.LabelRow.TabIndex = 78;
            this.LabelRow.Text = "0";
            // 
            // mssLabel1
            // 
            this.mssLabel1.AutoSize = true;
            // 
            // 
            // 
            this.mssLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mssLabel1.ForeColor = System.Drawing.Color.Black;
            this.mssLabel1.Location = new System.Drawing.Point(229, 8);
            this.mssLabel1.Name = "mssLabel1";
            this.mssLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mssLabel1.Size = new System.Drawing.Size(59, 16);
            this.mssLabel1.TabIndex = 68;
            this.mssLabel1.Text = "تعرفه خدمت";
            // 
            // IntBoxPriceType
            // 
            this.IntBoxPriceType.Location = new System.Drawing.Point(168, 5);
            this.IntBoxPriceType.Name = "IntBoxPriceType";
            this.IntBoxPriceType.ReadOnly = true;
            this.IntBoxPriceType.Size = new System.Drawing.Size(62, 21);
            this.IntBoxPriceType.TabIndex = 5;
            this.IntBoxPriceType.Text = "0";
            this.IntBoxPriceType.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
            this.IntBoxPriceType.Value = 0;
            this.IntBoxPriceType.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int32;
            this.IntBoxPriceType.ValueChanged += new System.EventHandler(this.IntBoxServiceTypeDscFew_ValueChanged);
            // 
            // mssLabel2
            // 
            this.mssLabel2.AutoSize = true;
            // 
            // 
            // 
            this.mssLabel2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mssLabel2.ForeColor = System.Drawing.Color.Black;
            this.mssLabel2.Location = new System.Drawing.Point(137, 8);
            this.mssLabel2.Name = "mssLabel2";
            this.mssLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mssLabel2.Size = new System.Drawing.Size(23, 16);
            this.mssLabel2.TabIndex = 68;
            this.mssLabel2.Text = "جمع";
            // 
            // IntBoxTotalPriceType
            // 
            this.IntBoxTotalPriceType.Location = new System.Drawing.Point(34, 5);
            this.IntBoxTotalPriceType.Name = "IntBoxTotalPriceType";
            this.IntBoxTotalPriceType.ReadOnly = true;
            this.IntBoxTotalPriceType.Size = new System.Drawing.Size(103, 21);
            this.IntBoxTotalPriceType.TabIndex = 6;
            this.IntBoxTotalPriceType.Text = "0";
            this.IntBoxTotalPriceType.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
            this.IntBoxTotalPriceType.Value = 0;
            this.IntBoxTotalPriceType.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int32;
            // 
            // buttonServiceTypeDsc
            // 
            this.buttonServiceTypeDsc.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonServiceTypeDsc.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonServiceTypeDsc.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonServiceTypeDsc.Location = new System.Drawing.Point(411, 3);
            this.buttonServiceTypeDsc.Name = "buttonServiceTypeDsc";
            this.buttonServiceTypeDsc.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonServiceTypeDsc.Size = new System.Drawing.Size(31, 24);
            this.buttonServiceTypeDsc.TabIndex = 3;
            this.buttonServiceTypeDsc.Text = "...";
            this.buttonServiceTypeDsc.Click += new System.EventHandler(this.buttonServiceTypeDsc_Click);
            // 
            // TextBoxServiceTypeDsc
            // 
            this.TextBoxServiceTypeDsc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.TextBoxServiceTypeDsc.Border.Class = "TextBoxBorder";
            this.TextBoxServiceTypeDsc.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxServiceTypeDsc.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TextBoxServiceTypeDsc.ForeColor = System.Drawing.Color.Black;
            this.TextBoxServiceTypeDsc.Location = new System.Drawing.Point(448, 5);
            this.TextBoxServiceTypeDsc.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TextBoxServiceTypeDsc.MaxLength = 50;
            this.TextBoxServiceTypeDsc.Name = "TextBoxServiceTypeDsc";
            this.TextBoxServiceTypeDsc.ReadOnly = true;
            this.TextBoxServiceTypeDsc.Size = new System.Drawing.Size(203, 21);
            this.TextBoxServiceTypeDsc.TabIndex = 2;
            // 
            // mssLabel3
            // 
            this.mssLabel3.AutoSize = true;
            // 
            // 
            // 
            this.mssLabel3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mssLabel3.ForeColor = System.Drawing.Color.Black;
            this.mssLabel3.Location = new System.Drawing.Point(8, 8);
            this.mssLabel3.Name = "mssLabel3";
            this.mssLabel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mssLabel3.Size = new System.Drawing.Size(20, 16);
            this.mssLabel3.TabIndex = 68;
            this.mssLabel3.Text = "ریال";
            // 
            // VisitHealthCareDetail_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.buttonServiceTypeDsc);
            this.Controls.Add(this.TextBoxServiceTypeDsc);
            this.Controls.Add(this.LabelRow);
            this.Controls.Add(this.IntBoxTotalPriceType);
            this.Controls.Add(this.IntBoxPriceType);
            this.Controls.Add(this.IntBoxServiceTypeDscFew);
            this.Controls.Add(this.mssLabel3);
            this.Controls.Add(this.mssLabel2);
            this.Controls.Add(this.mssLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDelete);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "VisitHealthCareDetail_UC";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(810, 32);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MKH.Library.Control.MSSButton buttonDelete;
        private MKH.Library.Control.MSSLabel label1;
        private MKH.Library.Control.MSSLabel label2;
        private MKH.Library.Control.MSSIntBox IntBoxServiceTypeDscFew;
        private MKH.Library.Control.MSSLabel LabelRow;
        private MKH.Library.Control.MSSLabel mssLabel1;
        private MKH.Library.Control.MSSIntBox IntBoxPriceType;
        private MKH.Library.Control.MSSLabel mssLabel2;
        private MKH.Library.Control.MSSIntBox IntBoxTotalPriceType;
        private MKH.Library.Control.MSSButton buttonServiceTypeDsc;
        private MKH.Library.Control.MSSTextBox TextBoxServiceTypeDsc;
        private MKH.Library.Control.MSSLabel mssLabel3;
    }
}
