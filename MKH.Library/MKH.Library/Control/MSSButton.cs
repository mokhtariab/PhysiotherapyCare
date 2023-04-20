using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace MKH.Library.Control
{
    public partial class MSSButton : DevComponents.DotNetBar.ButtonX
    {
        public MSSButton()
        {
            InitializeComponent();

            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            ForeColor = System.Drawing.Color.Black;
        }

        public MSSButton(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
