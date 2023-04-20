namespace PhysiotherapyCare.View.MainForms.AllStatus
{
    partial class AllStatusDetail_UC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllStatusDetail_UC));
            this.LabelRow = new MKH.Library.Control.MSSLabel(this.components);
            this.CheckBoxStatusTypeDetail = new MKH.Library.Control.MSSCheckBox(this.components);
            this.TextBoxDescription = new MKH.Library.Control.MSSTextBox(this.components);
            this.buttonDelete = new MKH.Library.Control.MSSButton(this.components);
            this.SuspendLayout();
            // 
            // LabelRow
            // 
            this.LabelRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelRow.BackColor = System.Drawing.SystemColors.Info;
            // 
            // 
            // 
            this.LabelRow.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelRow.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRow.ForeColor = System.Drawing.Color.Olive;
            this.LabelRow.Location = new System.Drawing.Point(450, 1);
            this.LabelRow.Name = "LabelRow";
            this.LabelRow.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LabelRow.Size = new System.Drawing.Size(14, 26);
            this.LabelRow.TabIndex = 78;
            this.LabelRow.Text = "0";
            // 
            // CheckBoxStatusTypeDetail
            // 
            this.CheckBoxStatusTypeDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.CheckBoxStatusTypeDetail.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.CheckBoxStatusTypeDetail.Location = new System.Drawing.Point(182, 2);
            this.CheckBoxStatusTypeDetail.Name = "CheckBoxStatusTypeDetail";
            this.CheckBoxStatusTypeDetail.Size = new System.Drawing.Size(262, 23);
            this.CheckBoxStatusTypeDetail.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CheckBoxStatusTypeDetail.TabIndex = 79;
            this.CheckBoxStatusTypeDetail.Text = "جزییات وضعیت";
            this.CheckBoxStatusTypeDetail.TextColor = System.Drawing.Color.Black;
            // 
            // TextBoxDescription
            // 
            this.TextBoxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.TextBoxDescription.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxDescription.Location = new System.Drawing.Point(8, 4);
            this.TextBoxDescription.Multiline = true;
            this.TextBoxDescription.Name = "TextBoxDescription";
            this.TextBoxDescription.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TextBoxDescription.Size = new System.Drawing.Size(168, 19);
            this.TextBoxDescription.TabIndex = 80;
            // 
            // buttonDelete
            // 
            this.buttonDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete.Image = ((System.Drawing.Image)(resources.GetObject("buttonDelete.Image")));
            this.buttonDelete.Location = new System.Drawing.Point(463, 0);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonDelete.Size = new System.Drawing.Size(34, 27);
            this.buttonDelete.TabIndex = 81;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // AllStatusDetail_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.TextBoxDescription);
            this.Controls.Add(this.CheckBoxStatusTypeDetail);
            this.Controls.Add(this.LabelRow);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AllStatusDetail_UC";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(505, 27);
            this.ResumeLayout(false);

        }

        #endregion

        private MKH.Library.Control.MSSLabel LabelRow;
        public MKH.Library.Control.MSSCheckBox CheckBoxStatusTypeDetail;
        public MKH.Library.Control.MSSTextBox TextBoxDescription;
        public MKH.Library.Control.MSSButton buttonDelete;
    }
}
