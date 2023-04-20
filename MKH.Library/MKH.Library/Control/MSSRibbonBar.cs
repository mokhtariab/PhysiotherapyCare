using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace MKH.Library.Control
{
    public partial class MSSRibbonBar : DevComponents.DotNetBar.RibbonBar
    {
        public MSSRibbonBar()
        {
            InitializeComponent();
        }

        public MSSRibbonBar(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
