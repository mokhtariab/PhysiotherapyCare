using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace MKH.Library.Control
{
    public partial class MSSPictureBox : System.Windows.Forms.PictureBox
    {
        public MSSPictureBox()
        {
            InitializeComponent();
        }

        public MSSPictureBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();

            this.DoubleClick += MSSPictureBox_DoubleClick;
        }

        void MSSPictureBox_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToBoolean(this.Tag ?? false)) this.Tag = false; else this.Tag = true;
                MKH.Library.Clasess.ControlResizer.Init(this, Convert.ToBoolean(this.Tag));
                this.BringToFront();
                //this.Image.Save("C:\\TempPicFile22365.jpg");
                //System.Diagnostics.Process.Start("C:\\TempPicFile22365.jpg");
            }
            catch { }

        }
    }
}
