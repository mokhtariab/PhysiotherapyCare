using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace MKH.Library.Control
{
    public partial class MSSDatePicker : KagNetComponents2.KagPersianDatePicker
    {
        public MSSDatePicker()
        {
            InitializeComponent();

            BackColor = System.Drawing.Color.White;
            Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            UseFarsiDigits = true;

            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
        }

        public MSSDatePicker(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
            
            BackColor = System.Drawing.Color.White;
            Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            UseFarsiDigits = true;

            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
        }
    }
}
