using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace MKH.Library.Control
{
    public partial class MSSGroupPanel : DevComponents.DotNetBar.Controls.GroupPanel
    {
        public MSSGroupPanel()
        {
            InitializeComponent();
        }

        public MSSGroupPanel(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
