using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace MKH.Library.Control
{
    public partial class MSSProgressBar : DevComponents.DotNetBar.Controls.ProgressBarX
    {
        public MSSProgressBar()
        {
            InitializeComponent();
        }

        public MSSProgressBar(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

    }
}
