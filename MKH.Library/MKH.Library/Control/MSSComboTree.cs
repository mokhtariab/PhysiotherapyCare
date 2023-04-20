using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace MKH.Library.Control
{
    public partial class MSSComboTree : DevComponents.DotNetBar.Controls.ComboTree
    {
        public MSSComboTree()
        {
            InitializeComponent();
            
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
        }
    }
}
