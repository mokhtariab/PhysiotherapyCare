using System;
using System.Windows.Forms;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace MKH.Library.Control
{
    public partial class MSSNumberBox : Janus.Windows.GridEX.EditControls.NumericEditBox
    //public partial class MSSNumberBox : DevComponents.DotNetBar.Controls.TextBoxX
    {
        public MSSNumberBox()
        {
            InitializeComponent();
        }

        public MSSNumberBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();

            //this.KeyPress += MSSNumberBox_KeyPress;
            //this.TextChanged += MSSNumberBox_TextChanged;
        }


        void SetProperties()
        {
            this.Font = new System.Drawing.Font("Tahoma", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
            this.ValueType = Janus.Windows.GridEX.NumericEditValueType.Double;
            this.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010;
        }

        //TextBox tx = new TextBox();
        //void MSSNumberBox_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (!System.Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Delete && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
        //    { e.KeyChar = '\0'; return; }

        //    if (e.KeyChar == (char)Keys.Space)
        //    {
        //        tx = (TextBox)sender;
        //        if (tx.Text.Length < 18) tx.Text = tx.Text + "000";
        //        tx.SelectionStart = tx.Text.Length;
        //    }
        //}

        //void MSSNumberBox_TextChanged(object sender, EventArgs e)
        //{
        //    tx = (TextBox)sender;
        //    string str = tx.Text;
        //    int ts = tx.SelectionStart;
        //    if (tx.Text != "")
        //    {
        //        try
        //        {
        //            str = System.String.Format("{0:###,###}", System.Int64.Parse(str, System.Globalization.NumberStyles.Number));
        //        }
        //        catch
        //        {
        //            str = str.Replace(",", "");
        //        }
        //        tx.Text = str.Replace(" ", "");
        //        tx.SelectionStart = ts + 1;
        //    }
        //}

        //public string TextValue
        //{
        //    get
        //    {
        //        return this.Text.Replace(",", "");
        //    }
        //    set
        //    {
        //        this.Text = value;
        //    }
        //}
    }
}
