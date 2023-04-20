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
    public partial class MSSSelectorMulti_frm: Form
    {
        public DataTable DataListMulti;
        public DataTable DataListMultiOut;
        public MSSSelectorMulti_frm()
        {
            InitializeComponent();
        }
        

        private void DataBind()
        {
            for (int i = 0; i < DataListMulti.Columns.Count; i++)
            {
                GridexViewSelector.RootTable.Columns.Add(DataListMulti.Columns[i].ColumnName);
                GridexViewSelector.RootTable.Columns[i + 1].Caption = DataListMulti.Columns[i].Caption;
            }

            GridexViewSelector.DataSource = DataListMulti;

        }

        private void MSSSelectorMulti_frm_Load(object sender, EventArgs e)
        {
            DataBind();
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            GridexViewSelector.RemoveFilters();
            try
            {
                System.Data.DataTable table = new System.Data.DataTable();
                for (int i = 1; i < GridexViewSelector.RootTable.Columns.Count; i++)
                {
                    table.Columns.Add(GridexViewSelector.RootTable.Columns[i].Key);
                }

                for (int j = 0; j < GridexViewSelector.RowCount; j++)
                {
                    GridexViewSelector.Row = j;
                    if (Convert.ToBoolean(GridexViewSelector.CurrentRow.Cells[0].Value) == true)
                    {
                        object[] values = new object[GridexViewSelector.RootTable.Columns.Count-1];
                        for (int i = 0; i < values.Length; i++)
                            values[i] = GridexViewSelector.CurrentRow.Cells[i+1].Value;
                        table.Rows.Add(values);
                    }
                }

                DataListMultiOut = table;
                DialogResult = System.Windows.Forms.DialogResult.OK;
                Close();
            }
            catch { }

        }

    }

}
