using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace MKH.Library.Control
{
    public partial class MSSComboBox : DevComponents.DotNetBar.Controls.ComboBoxEx
    {
        public MSSComboBox()
        {
            InitializeComponent();
            
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
        }
    }
}
