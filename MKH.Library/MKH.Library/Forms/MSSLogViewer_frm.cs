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
   
    public partial class MSSLogViewer_frm: Form
    {
        public DataTable ColumnList;
        
        public MSSLogViewer_frm()
        {
            InitializeComponent();
        }
        

       
        private void DataBind()
        {
            for (int i = 0; i < ColumnList.Columns.Count; i++)
            {
                GridexViewSelector.RootTable.Columns.Add(ColumnList.Columns[i].ColumnName);
                GridexViewSelector.RootTable.Columns[i + 5].Caption = ColumnList.Columns[i].Caption;
            }
            
            //GridexViewSelector.DataSource = DataListLog;

        }

        private void MSSLogViewer_frm_Load(object sender, EventArgs e)
        {
            DataBind();
        }

      

    }

}
