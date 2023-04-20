using System;
using System.Windows.Forms;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace MKH.Library.Control
{
    public partial class MSSIntBox : Janus.Windows.GridEX.EditControls.NumericEditBox
    {
        public MSSIntBox()
        {
            InitializeComponent();
        }

        public MSSIntBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }


        void SetProperties()
        {
            this.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.General;
            this.Font = new System.Drawing.Font("Tahoma", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
            this.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int32;
            this.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010;
        }

    }
}
