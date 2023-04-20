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
    public partial class MSSSelector_frm: Form
    {

        public MSSSelector_frm()
        {
            InitializeComponent();
        }

        Dictionary<string, string> _dicStr = new Dictionary<string, string>();

        public static Dictionary<string,string> SetDataSelect(Dictionary<string,string> DicStr)
        {
            MSSSelector_frm MS = new MSSSelector_frm();
            MS._dicStr = DicStr;
            MS.ShowDialog();
            if (MS.CodeC.ToString() == "" && MS.NameC.ToString() == "")
                return null;
            else
            {
                Dictionary<string, string> S = new Dictionary<string, string>();
                S.Add(MS.CodeC.ToString(), MS.NameC.ToString());
                return S;
            }
        }
        

        private void DataBind()
        {
            Dictionary<string, string> DicS = new Dictionary<string, string>(_dicStr);
            GridexViewSelector.DataSource = null;
            //if (textBoxF1.Text != "")
            //    DicS = DicS.Where(p => p.Key.Contains(textBoxF1.Text)).ToDictionary(p => p.Key, p => p.Value);
            //if (textBoxF2.Text != "")
            //    DicS = DicS.Where(p => p.Value.Contains(textBoxF2.Text)).ToDictionary(p => p.Key, p => p.Value);

            GridexViewSelector.DataSource = DicS.ToList();

            GridexViewSelector.RootTable.Columns["Key"].Caption = "کد";
            GridexViewSelector.RootTable.Columns["Value"].Caption = "نام";
            GridexViewSelector.RootTable.Columns["Key"].Width = 100;
            GridexViewSelector.RootTable.Columns["Value"].Width = 150;
        }


        public string CodeC = "";
        public string NameC = "";

        private void dataGridView_MSSSelector_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                CodeC = GridexViewSelector.CurrentRow.Cells["Key"].Value.ToString();
                NameC = GridexViewSelector.CurrentRow.Cells["Value"].Value.ToString();
                Close();
            }
            catch { }
        }

        private void MSSSelector_frm_Load(object sender, EventArgs e)
        {
            DataBind();
            errorProvider1.SetError(GridexViewSelector, "جهت انتخاب بر روی ردیف مورد نظر دوبار کلیک نمایید");
            errorProvider1.SetIconAlignment(GridexViewSelector, ErrorIconAlignment.TopRight);
            //textBoxF2.Focus();
        }

    }
}
