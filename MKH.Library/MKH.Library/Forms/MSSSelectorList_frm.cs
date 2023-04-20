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
    public partial class MSSSelectorList_frm: Form
    {
        public DataTable DataListPrePayment;
        public DataTable DataListPrePaymentOut;
        public MSSSelectorList_frm()
        {
            InitializeComponent();
        }
        

        private void DataBind()
        {
            GridexViewSelector.DataSource = DataListPrePayment;
            GridexViewSelector.RetrieveStructure();
        }



        private void dataGridView_MSSSelectorList_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                System.Data.DataTable table = new System.Data.DataTable();
                for (int i = 0; i < GridexViewSelector.RootTable.Columns.Count; i++)
                {
                    table.Columns.Add(GridexViewSelector.RootTable.Columns[i].Key);
                }
                object[] values = new object[GridexViewSelector.RootTable.Columns.Count];
                for (int i = 0; i < values.Length; i++)
                    values[i] = GridexViewSelector.CurrentRow.Cells[i].Value;
                table.Rows.Add(values);


                DataListPrePaymentOut = table;
                DialogResult = System.Windows.Forms.DialogResult.OK;
                Close();
            }
            catch { }
        }

        private void MSSSelectorList_frm_Load(object sender, EventArgs e)
        {
            DataBind();
            errorProvider1.SetError(GridexViewSelector, "جهت انتخاب بر روی ردیف مورد نظر دوبار کلیک نمایید");
            errorProvider1.SetIconAlignment(GridexViewSelector, ErrorIconAlignment.TopRight);
        }

    }

}
