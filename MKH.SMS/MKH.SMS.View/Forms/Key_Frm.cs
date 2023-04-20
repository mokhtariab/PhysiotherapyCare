using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MKH.SMS.View.Forms
{
    public partial class Key_frm: Form
    {
        public Key_frm()
        {
            InitializeComponent();
        }

        private void Key_frm_Load(object sender, EventArgs e)
        {
            DataBind();
        }

        public void DataBind()
        {
            string str = "";
            GridexViewKey.DataSource = new ViewModel.Key.Key().GetAllList(ref str);
        }


        public int KeyCodeSet = 0;
        public string KeyDscSet = "";

        private void GridexViewKey_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                KeyCodeSet = int.Parse(GridexViewKey.CurrentRow.Cells["Id"].Value.ToString());
                KeyDscSet = GridexViewKey.CurrentRow.Cells["TitleName"].Value.ToString();
                Close();
            }
            catch { }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            string str = "";
            if (textBoxKey.Text != "")
            {
                new ViewModel.Key.Key().InsertEntitySet(textBoxKey.Text, ref str);
                DataBind();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string str = "";
            new ViewModel.Key.Key().DeleteEntitySet(int.Parse(GridexViewKey.CurrentRow.Cells["Id"].Value.ToString()), ref str);

            DataBind();
        }

    }
}
