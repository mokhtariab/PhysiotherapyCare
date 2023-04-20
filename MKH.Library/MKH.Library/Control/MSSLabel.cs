using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace MKH.Library.Control
{
    public partial class MSSLabel :  DevComponents.DotNetBar.LabelX
    {
        public MSSLabel()
        {
            InitializeComponent();

            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            ForeColor = System.Drawing.Color.Black;
        }

        public MSSLabel(IContainer container)
        {
            container.Add(this);

            InitializeComponent();

        }
    }
}
