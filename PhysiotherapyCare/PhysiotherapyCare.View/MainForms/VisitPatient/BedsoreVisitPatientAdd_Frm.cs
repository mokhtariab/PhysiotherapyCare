using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using MKH.Library.Clasess;
using PhysiotherapyCare.Model.VisitPatient;
using MKH.Library.Clasess.FilterClass;

namespace PhysiotherapyCare.View.MainForms.VisitPatient
{
    public partial class BedsoreAdd_Frm : MKH.Library.Forms.MSSBaseNew_frm
    {

        private long _id = 0;
        private long _visitpatient_Id = 0;
        private bool _editIns = false;
        private string str = "";

        public BedsoreAdd_Frm()
        {
            InitializeComponent();
        }


        public BedsoreAdd_Frm(long VisitPatient_Id, string EmptyStr)
        {
            InitializeComponent();
            _visitpatient_Id = VisitPatient_Id;
            string str = "";
        }

        public BedsoreAdd_Frm(long Id)
        {
            InitializeComponent();
            _id = Id;
            _editIns = true;
        }

        private void VisitHealthCareAdd_Frm_Load(object sender, EventArgs e)
        {
            //if (_editIns)
            fillControl();
        }

        private void fillControl()
        {
            FillTableLayoutPanel(_id);
        }

        private void FillTableLayoutPanel(long Id)
        {
            try
            {
                int i = 0;
                var collation = new ViewModel.VisitPatient.BedsoreVisitPatient().GetAllList(ref str).Where(d => d.VisitPatient_Id == _visitpatient_Id);
                foreach (var item in collation)
                {
                    BedsoreVisitPatient_UC smsp = new BedsoreVisitPatient_UC(item.Id);
                    smsp.Tag = item.Id;
                    smsp.Controls.Owner.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                    tableLayoutPanelNews.Controls.Add(smsp, 1, ++i);
                }

            }
            catch (Exception ex)
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, ex.Message);
            }
            SetRowTableSet();
        }

        public void SetRowTableSet()
        {
            int tableLayoutPanelRowCnt = 0;
            int SumServiceHealthCare = 0;

            foreach (Control fg in tableLayoutPanelNews.Controls)
                if ((fg as BedsoreVisitPatient_UC).Visible)
                {
                    (fg as BedsoreVisitPatient_UC).setRowNo(++tableLayoutPanelRowCnt);
                }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckValidation())
                return;
            try
            {
                SaveParametersUsercontrols(_visitpatient_Id);
                if (str != "")
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MSSMessage.MessageType.SError, false, "اشکال اطلاعات", str);
                else
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View("اطلاعات ذخیره شد", MKH.Library.Clasess.MSSMessage.MessageType.SInformation);
                    DialogResult = System.Windows.Forms.DialogResult.OK;

                    Close();
                }
            }
            catch (Exception ex)
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "اشکال در ذخیره اطلاعات", ex.Message);
            }
        }

        private bool CheckParametersUsercontrols()
        {
            foreach (Control fg in tableLayoutPanelNews.Controls)
            {
                if ((fg as BedsoreVisitPatient_UC).Visible)
                    if (!(fg as BedsoreVisitPatient_UC).CheckvalidationUC())
                        return false;
            }
            return true;
        }

        private void SaveParametersUsercontrols(long VisitPatient_Id)
        {
            string str = "";
            new ViewModel.VisitPatient.BedsoreVisitPatient().VisitPatientWithBedsoreVisitPatientDelete(VisitPatient_Id, ref str);
            foreach (Control fg in tableLayoutPanelNews.Controls)
            {
                if ((fg as BedsoreVisitPatient_UC).Visible)
                    (fg as BedsoreVisitPatient_UC).save(VisitPatient_Id);
            }
        }



        private bool CheckValidation()
        {
            if (!CheckParametersUsercontrols())
            {
                return false;
            }
            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void buttonAddNews_Click(object sender, EventArgs e)
        {
            BedsoreVisitPatient_UC SSUC = new BedsoreVisitPatient_UC();
            SSUC.Controls.Owner.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            tableLayoutPanelNews.Controls.Add(SSUC, 1, tableLayoutPanelNews.Controls.Count + 1);
            SetRowTableSet();
        }

     
    }
}
