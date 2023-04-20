using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MKH.Library.Forms
{
    public partial class MSSBaseNew_frm : Form
    {
        public MSSBaseNew_frm()
        {
            InitializeComponent();
        }

        private void MSSBaseNew_KeyDown(object sender, KeyEventArgs e)
        {
            DoKeyDown(e);
        }

        protected virtual void DoKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                ClosePage();
            else if ((e.KeyCode == Keys.F2) && (buttonItemOK.Enabled) && (buttonItemOK.Visible))
                buttonItemOK.Click += buttonItemOK_Click;
        }

        void buttonItemOK_Click(object sender, EventArgs e)
        {
        }


        private void buttonItem_Cancel_Click(object sender, EventArgs e)
        {
            PressCancelButton();
        }

        protected virtual void PressCancelButton()
        {
            this.DialogResult = DialogResult.Cancel;
            ClosePage();
        }


        protected void ClosePage()
        {
            Close();
        }

       
        //public delegate void buttonItemOKClickEventHandler(object sender,
        //                        System.EventArgs e);
        //public event buttonItemOKClickEventHandler buttonItemOKClick;

        //void buttonItemOK_Click(object sender, System.EventArgs e)
        //{
        //    if (buttonItemOKClick != null)
        //        buttonItemOKClick(sender, e);
        //}




    }
}
