using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace MKH.Library.Control
{
    public partial class MSSLabelReflection :  DevComponents.DotNetBar.Controls.ReflectionLabel
    {
        public MSSLabelReflection()
        {
            InitializeComponent();

            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            ForeColor = System.Drawing.Color.Black;
        }

        public MSSLabelReflection(IContainer container)
        {
            container.Add(this);

            InitializeComponent();

        }
    }
}
