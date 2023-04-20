namespace MKH.Library.UserControls
{
    partial class MSSSearch_UC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MSSSearch_UC));
            this.ComboBoxIf = new MKH.Library.Control.MSSComboBox();
            this.Equals = new DevComponents.Editors.ComboItem();
            this.GreaterThan = new DevComponents.Editors.ComboItem();
            this.LessThan = new DevComponents.Editors.ComboItem();
            this.GreaterThanOrEqual = new DevComponents.Editors.ComboItem();
            this.LessThanOrEqual = new DevComponents.Editors.ComboItem();
            this.Contains = new DevComponents.Editors.ComboItem();
            this.StartsWith = new DevComponents.Editors.ComboItem();
            this.EndsWith = new DevComponents.Editors.ComboItem();
            this.ComboBoxFieldList = new MKH.Library.Control.MSSComboBox();
            this.TextBoxStrSearch = new MKH.Library.Control.MSSTextBox(this.components);
            this.label1 = new MKH.Library.Control.MSSLabel(this.components);
            this.label2 = new MKH.Library.Control.MSSLabel(this.components);
            this.comboBoxAndOr = new MKH.Library.Control.MSSComboBox();
            this.comboItemAnd = new DevComponents.Editors.ComboItem();
            this.comboItemOr = new DevComponents.Editors.ComboItem();
            this.buttonDelete = new MKH.Library.Control.MSSButton(this.components);
            this.DatePickerSearch = new MKH.Library.Control.MSSDatePicker(this.components);
            this.IntBoxSearch = new MKH.Library.Control.MSSIntBox(this.components);
            this.SuspendLayout();
            // 
            // ComboBoxIf
            // 
            this.ComboBoxIf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxIf.DisplayMember = "Text";
            this.ComboBoxIf.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxIf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxIf.FormattingEnabled = true;
            this.ComboBoxIf.ItemHeight = 15;
            this.ComboBoxIf.Items.AddRange(new object[] {
            this.Equals,
            this.GreaterThan,
            this.LessThan,
            this.GreaterThanOrEqual,
            this.LessThanOrEqual,
            this.Contains,
            this.StartsWith,
            this.EndsWith});
            this.ComboBoxIf.Location = new System.Drawing.Point(274, 4);
            this.ComboBoxIf.Name = "ComboBoxIf";
            this.ComboBoxIf.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ComboBoxIf.Size = new System.Drawing.Size(128, 21);
            this.ComboBoxIf.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ComboBoxIf.TabIndex = 75;
            // 
            // Equals
            // 
            this.Equals.Text = "مساوی";
            this.Equals.TextAlignment = System.Drawing.StringAlignment.Center;
            this.Equals.TextLineAlignment = System.Drawing.StringAlignment.Center;
            // 
            // GreaterThan
            // 
            this.GreaterThan.Text = "بزرگتر از";
            this.GreaterThan.TextAlignment = System.Drawing.StringAlignment.Center;
            this.GreaterThan.TextLineAlignment = System.Drawing.StringAlignment.Center;
            // 
            // LessThan
            // 
            this.LessThan.Text = "کوچکتر از";
            this.LessThan.TextAlignment = System.Drawing.StringAlignment.Center;
            this.LessThan.TextLineAlignment = System.Drawing.StringAlignment.Center;
            // 
            // GreaterThanOrEqual
            // 
            this.GreaterThanOrEqual.Text = "بزرگتر یا مساوی";
            this.GreaterThanOrEqual.TextAlignment = System.Drawing.StringAlignment.Center;
            this.GreaterThanOrEqual.TextLineAlignment = System.Drawing.StringAlignment.Center;
            // 
            // LessThanOrEqual
            // 
            this.LessThanOrEqual.Text = "کوچکتر یا مساوی";
            this.LessThanOrEqual.TextAlignment = System.Drawing.StringAlignment.Center;
            this.LessThanOrEqual.TextLineAlignment = System.Drawing.StringAlignment.Center;
            // 
            // Contains
            // 
            this.Contains.Text = "شامل";
            this.Contains.TextAlignment = System.Drawing.StringAlignment.Center;
            this.Contains.TextLineAlignment = System.Drawing.StringAlignment.Center;
            // 
            // StartsWith
            // 
            this.StartsWith.Text = "ابتدا شامل";
            this.StartsWith.TextAlignment = System.Drawing.StringAlignment.Center;
            this.StartsWith.TextLineAlignment = System.Drawing.StringAlignment.Center;
            // 
            // EndsWith
            // 
            this.EndsWith.Text = "انتها شامل";
            this.EndsWith.TextAlignment = System.Drawing.StringAlignment.Center;
            this.EndsWith.TextLineAlignment = System.Drawing.StringAlignment.Center;
            // 
            // ComboBoxFieldList
            // 
            this.ComboBoxFieldList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxFieldList.DisplayMember = "Text";
            this.ComboBoxFieldList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxFieldList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxFieldList.FormattingEnabled = true;
            this.ComboBoxFieldList.ItemHeight = 15;
            this.ComboBoxFieldList.Location = new System.Drawing.Point(416, 4);
            this.ComboBoxFieldList.Name = "ComboBoxFieldList";
            this.ComboBoxFieldList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ComboBoxFieldList.Size = new System.Drawing.Size(177, 21);
            this.ComboBoxFieldList.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ComboBoxFieldList.TabIndex = 74;
            this.ComboBoxFieldList.SelectedValueChanged += new System.EventHandler(this.ComboBoxFieldList_SelectedValueChanged);
            // 
            // TextBoxStrSearch
            // 
            this.TextBoxStrSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.TextBoxStrSearch.Border.Class = "TextBoxBorder";
            this.TextBoxStrSearch.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxStrSearch.Location = new System.Drawing.Point(63, 3);
            this.TextBoxStrSearch.Name = "TextBoxStrSearch";
            this.TextBoxStrSearch.Size = new System.Drawing.Size(161, 21);
            this.TextBoxStrSearch.TabIndex = 73;
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
            this.label1.Location = new System.Drawing.Point(230, 6);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 72;
            this.label1.Text = "عبارت:";
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
            this.label2.Location = new System.Drawing.Point(596, 7);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 68;
            this.label2.Text = "انتخاب فیلد:";
            // 
            // comboBoxAndOr
            // 
            this.comboBoxAndOr.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxAndOr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAndOr.DropDownWidth = 47;
            this.comboBoxAndOr.FormattingEnabled = true;
            this.comboBoxAndOr.ItemHeight = 15;
            this.comboBoxAndOr.Items.AddRange(new object[] {
            this.comboItemAnd,
            this.comboItemOr});
            this.comboBoxAndOr.Location = new System.Drawing.Point(7, 3);
            this.comboBoxAndOr.Name = "comboBoxAndOr";
            this.comboBoxAndOr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBoxAndOr.Size = new System.Drawing.Size(47, 21);
            this.comboBoxAndOr.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxAndOr.TabIndex = 71;
            // 
            // comboItemAnd
            // 
            this.comboItemAnd.Text = "و";
            this.comboItemAnd.TextAlignment = System.Drawing.StringAlignment.Center;
            this.comboItemAnd.TextLineAlignment = System.Drawing.StringAlignment.Center;
            // 
            // comboItemOr
            // 
            this.comboItemOr.Text = "یا";
            this.comboItemOr.TextAlignment = System.Drawing.StringAlignment.Center;
            this.comboItemOr.TextLineAlignment = System.Drawing.StringAlignment.Center;
            // 
            // buttonDelete
            // 
            this.buttonDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.buttonDelete.Image = ((System.Drawing.Image)(resources.GetObject("buttonDelete.Image")));
            this.buttonDelete.Location = new System.Drawing.Point(677, 2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonDelete.Size = new System.Drawing.Size(29, 25);
            this.buttonDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonDelete.TabIndex = 65;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // DatePickerSearch
            // 
            this.DatePickerSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DatePickerSearch.BackColor = System.Drawing.Color.White;
            this.DatePickerSearch.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.DatePickerSearch.Location = new System.Drawing.Point(109, 5);
            this.DatePickerSearch.Name = "DatePickerSearch";
            this.DatePickerSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DatePickerSearch.ShowTime = false;
            this.DatePickerSearch.Size = new System.Drawing.Size(115, 18);
            this.DatePickerSearch.TabIndex = 76;
            this.DatePickerSearch.Text = "mssDatePicker1";
            this.DatePickerSearch.UseFarsiDigits = true;
            this.DatePickerSearch.Value = ((KagNetComponents2.KagPersianDate)(resources.GetObject("DatePickerSearch.Value")));
            this.DatePickerSearch.ValueEn = new System.DateTime(2017, 3, 1, 10, 0, 15, 0);
            // 
            // IntBoxSearch
            // 
            this.IntBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IntBoxSearch.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.General;
            this.IntBoxSearch.Location = new System.Drawing.Point(109, 3);
            this.IntBoxSearch.Name = "IntBoxSearch";
            this.IntBoxSearch.Size = new System.Drawing.Size(115, 21);
            this.IntBoxSearch.TabIndex = 77;
            this.IntBoxSearch.Text = "0";
            this.IntBoxSearch.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
            this.IntBoxSearch.UseCompatibleTextRendering = false;
            this.IntBoxSearch.Value = 0;
            this.IntBoxSearch.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int32;
            this.IntBoxSearch.Visible = false;
            // 
            // MSSSearch_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.IntBoxSearch);
            this.Controls.Add(this.DatePickerSearch);
            this.Controls.Add(this.ComboBoxIf);
            this.Controls.Add(this.ComboBoxFieldList);
            this.Controls.Add(this.TextBoxStrSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxAndOr);
            this.Controls.Add(this.buttonDelete);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MSSSearch_UC";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(711, 29);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Control.MSSButton buttonDelete;
        private Control.MSSLabel label2;
        private Control.MSSComboBox comboBoxAndOr;
        private DevComponents.Editors.ComboItem comboItemAnd;
        private DevComponents.Editors.ComboItem comboItemOr;
        private Control.MSSLabel label1;
        private Control.MSSTextBox TextBoxStrSearch;
        private Control.MSSComboBox ComboBoxFieldList;
        private Control.MSSComboBox ComboBoxIf;
        private DevComponents.Editors.ComboItem Equals;
        private DevComponents.Editors.ComboItem GreaterThan;
        private DevComponents.Editors.ComboItem LessThan;
        private DevComponents.Editors.ComboItem GreaterThanOrEqual;
        private DevComponents.Editors.ComboItem LessThanOrEqual;
        private DevComponents.Editors.ComboItem Contains;
        private DevComponents.Editors.ComboItem StartsWith;
        private DevComponents.Editors.ComboItem EndsWith;
        private Control.MSSDatePicker DatePickerSearch;
        private Control.MSSIntBox IntBoxSearch;
    }
}
