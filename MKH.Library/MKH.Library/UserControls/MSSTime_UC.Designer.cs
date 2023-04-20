namespace MKH.Library.UserControls
{
    partial class MSSTime_UC
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
            this.panelDate = new System.Windows.Forms.Panel();
            this.integerUpDownMinute = new Janus.Windows.GridEX.EditControls.IntegerUpDown();
            this.integerUpDownTime = new Janus.Windows.GridEX.EditControls.IntegerUpDown();
            this.label_Date2 = new System.Windows.Forms.Label();
            this.panelDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDate
            // 
            this.panelDate.BackColor = System.Drawing.Color.Transparent;
            this.panelDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDate.Controls.Add(this.integerUpDownMinute);
            this.panelDate.Controls.Add(this.integerUpDownTime);
            this.panelDate.Controls.Add(this.label_Date2);
            this.panelDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.panelDate.Location = new System.Drawing.Point(0, 0);
            this.panelDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelDate.Name = "panelDate";
            this.panelDate.Size = new System.Drawing.Size(87, 29);
            this.panelDate.TabIndex = 2;
            // 
            // integerUpDownMinute
            // 
            this.integerUpDownMinute.Location = new System.Drawing.Point(44, 2);
            this.integerUpDownMinute.Maximum = 59;
            this.integerUpDownMinute.Name = "integerUpDownMinute";
            this.integerUpDownMinute.Size = new System.Drawing.Size(37, 22);
            this.integerUpDownMinute.TabIndex = 48;
            // 
            // integerUpDownTime
            // 
            this.integerUpDownTime.Location = new System.Drawing.Point(2, 2);
            this.integerUpDownTime.Maximum = 23;
            this.integerUpDownTime.Name = "integerUpDownTime";
            this.integerUpDownTime.Size = new System.Drawing.Size(37, 22);
            this.integerUpDownTime.TabIndex = 49;
            // 
            // label_Date2
            // 
            this.label_Date2.AutoSize = true;
            this.label_Date2.Location = new System.Drawing.Point(36, 5);
            this.label_Date2.Name = "label_Date2";
            this.label_Date2.Size = new System.Drawing.Size(13, 16);
            this.label_Date2.TabIndex = 17;
            this.label_Date2.Text = ":";
            // 
            // MSSTime_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panelDate);
            this.Font = new System.Drawing.Font("Tahoma", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "MSSTime_UC";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(87, 29);
            this.panelDate.ResumeLayout(false);
            this.panelDate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDate;
        public System.Windows.Forms.Label label_Date2;
        private Janus.Windows.GridEX.EditControls.IntegerUpDown integerUpDownMinute;
        private Janus.Windows.GridEX.EditControls.IntegerUpDown integerUpDownTime;
    }
}
