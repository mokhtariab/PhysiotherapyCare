using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace MKH.Library.Control
{
    public partial class MSSListView : System.Windows.Forms.ListView
    {
        public MSSListView()
        {
            InitializeComponent();

            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            RightToLeftLayout = true;
        }

        public MSSListView(IContainer container)
        {
            container.Add(this);

            InitializeComponent();

        }
    }
}
