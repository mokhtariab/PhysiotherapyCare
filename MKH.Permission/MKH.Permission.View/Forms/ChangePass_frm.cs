using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace MKH.Permission.View.Forms
{
    public partial class ChangePass_frm : MKH.Library.Forms.MSSBaseNew_frm
    {
        public ChangePass_frm()
        {
            InitializeComponent();
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            if (Security.MSSChangePassword_Cls.CheckPass(
                MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USER,
                textBox_PrePass.Text,
                textBox_NewPass.Text, textBox_ReNewPass.Text))
                Close();
        }

    }
}
