using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MKH.Library.Clasess.FilterClass;
using PhysiotherapyCare.Model.Status;

namespace PhysiotherapyCare.View.MainForms.AllStatus
{
    public partial class AllStatusDetail_UC: UserControl
    {
       
        public AllStatusDetail_UC()
        {
            InitializeComponent();
        }

        public void setRowNo(int RowNo)
        {
            LabelRow.Text = RowNo.ToString();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation, true, "آیا مایلید وضعیت حذف شود؟"))
                this.Visible = false;
        }

       
    }
}
