namespace PhysiotherapyCare.View.MainForms.VisitPatient
{
    partial class SicknessVisitPatient_UC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SicknessVisitPatient_UC));
            this.buttonDelete = new MKH.Library.Control.MSSButton(this.components);
            this.label1 = new MKH.Library.Control.MSSLabel(this.components);
            this.label2 = new MKH.Library.Control.MSSLabel(this.components);
            this.LabelRow = new MKH.Library.Control.MSSLabel(this.components);
            this.buttonServiceTypeDsc = new MKH.Library.Control.MSSButton(this.components);
            this.TextBoxTitleName = new MKH.Library.Control.MSSTextBox(this.components);
            this.TextBoxDiscription = new MKH.Library.Control.MSSTextBox(this.components);
            this.SuspendLayout();
            // 
            // buttonDelete
            // 
            this.buttonDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete.Image = ((System.Drawing.Image)(resources.GetObject("buttonDelete.Image")));
            this.buttonDelete.Location = new System.Drawing.Point(651, 3);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonDelete.Size = new System.Drawing.Size(34, 27);
            this.buttonDelete.TabIndex = 0;
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
            this.label1.Location = new System.Drawing.Point(548, 8);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 66;
            this.label1.Text = "عنوان بیماری";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            // 
            // 
            // 
            this.label2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(244, 8);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 68;
            this.label2.Text = "توضیحات";
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
            this.LabelRow.Location = new System.Drawing.Point(626, 1);
            this.LabelRow.Name = "LabelRow";
            this.LabelRow.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LabelRow.Size = new System.Drawing.Size(14, 30);
            this.LabelRow.TabIndex = 78;
            this.LabelRow.Text = "0";
            // 
            // buttonServiceTypeDsc
            // 
            this.buttonServiceTypeDsc.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonServiceTypeDsc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonServiceTypeDsc.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonServiceTypeDsc.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonServiceTypeDsc.Location = new System.Drawing.Point(307, 3);
            this.buttonServiceTypeDsc.Name = "buttonServiceTypeDsc";
            this.buttonServiceTypeDsc.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonServiceTypeDsc.Size = new System.Drawing.Size(31, 24);
            this.buttonServiceTypeDsc.TabIndex = 2;
            this.buttonServiceTypeDsc.Text = "...";
            this.buttonServiceTypeDsc.Click += new System.EventHandler(this.buttonServiceTypeDsc_Click);
            // 
            // TextBoxTitleName
            // 
            this.TextBoxTitleName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.TextBoxTitleName.Border.Class = "TextBoxBorder";
            this.TextBoxTitleName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxTitleName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TextBoxTitleName.ForeColor = System.Drawing.Color.Black;
            this.TextBoxTitleName.Location = new System.Drawing.Point(344, 5);
            this.TextBoxTitleName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TextBoxTitleName.MaxLength = 50;
            this.TextBoxTitleName.Name = "TextBoxTitleName";
            this.TextBoxTitleName.ReadOnly = true;
            this.TextBoxTitleName.Size = new System.Drawing.Size(203, 21);
            this.TextBoxTitleName.TabIndex = 1;
            // 
            // TextBoxDiscription
            // 
            this.TextBoxDiscription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.TextBoxDiscription.Border.Class = "TextBoxBorder";
            this.TextBoxDiscription.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxDiscription.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TextBoxDiscription.ForeColor = System.Drawing.Color.Black;
            this.TextBoxDiscription.Location = new System.Drawing.Point(8, 6);
            this.TextBoxDiscription.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TextBoxDiscription.MaxLength = 50;
            this.TextBoxDiscription.Name = "TextBoxDiscription";
            this.TextBoxDiscription.Size = new System.Drawing.Size(230, 21);
            this.TextBoxDiscription.TabIndex = 3;
            // 
            // SicknessVisitPatient_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.TextBoxDiscription);
            this.Controls.Add(this.buttonServiceTypeDsc);
            this.Controls.Add(this.TextBoxTitleName);
            this.Controls.Add(this.LabelRow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDelete);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "SicknessVisitPatient_UC";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(689, 32);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MKH.Library.Control.MSSButton buttonDelete;
        private MKH.Library.Control.MSSLabel label1;
        private MKH.Library.Control.MSSLabel label2;
        private MKH.Library.Control.MSSLabel LabelRow;
        private MKH.Library.Control.MSSButton buttonServiceTypeDsc;
        private MKH.Library.Control.MSSTextBox TextBoxDiscription;
        public MKH.Library.Control.MSSTextBox TextBoxTitleName;
    }
}
