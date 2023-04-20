using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using PhysiotherapyCare.Model.VisitPatient;
using PhysiotherapyCare.ViewModel.VisitPatient;


namespace PhysiotherapyCare.View.BaseForms
{
    public partial class SicknessDetailAdd_Frm : MKH.Library.Forms.MSSBaseNew_frm
    {
        private int _id = 0;
        private bool _editIns = false;
        string str = "";

        public SicknessDetailAdd_Frm()
        {
            InitializeComponent();
        }

        public SicknessDetailAdd_Frm(int Id)
        {
            InitializeComponent();
            _id = Id;
            _editIns = true;
        }

        private void SicknessDetailAdd_Frm_Load(object sender, EventArgs e)
        {
            SetComboBox();

            if (_editIns) fillControl();
        }

        private void SetComboBox()
        {
            ComboBoxSickness.ValueMember = "Id";
            ComboBoxSickness.DisplayMember = "TitleName";
            ComboBoxSickness.DataSource = new Sickness().GetAllList(ref str);
        }


        private void fillControl()
        {
            string str = "";
            SicknessDetail RN = new SicknessDetail();
            List<VW_SicknessDetail> DT = RN.GetAllListByID(_id, ref str);


            ComboBoxSickness.SelectedValue = DT[0].Sickness_Id;
            textBoxTitleName.Text = DT[0].SicknessDetailName;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckValidation())
                return;
            try
            {
                string str = ""; int? idSet = 0;
                List<TBL_SicknessDetail> Ls = new List<TBL_SicknessDetail>(1);
                TBL_SicknessDetail SicknessDetail = new TBL_SicknessDetail();
                SicknessDetail.Id = _id;
                SicknessDetail.Sickness_Id = Convert.ToInt16(ComboBoxSickness.SelectedValue);
                SicknessDetail.TitleName = textBoxTitleName.Text;
                Ls.Add(SicknessDetail);

                if (!_editIns)
                {
                    new ViewModel.VisitPatient.SicknessDetail().InsertEntity(Ls, ref str, ref idSet);
                }
                else
                {
                    new ViewModel.VisitPatient.SicknessDetail().UpdateEntity(Ls, ref str);
                }

                if (str != "")
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "اشکال اطلاعات", str);
                else
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View("اطلاعات ذخیره شد", MKH.Library.Clasess.MSSMessage.MessageType.SInformation);
                    DialogResult = System.Windows.Forms.DialogResult.OK;
                    Close();
                }

            }
            catch(Exception ex)
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, ex.Message);
            }

        }


        private bool CheckValidation()
        {
            if (ComboBoxSickness.Text.Trim() == "")
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("وضعیت بیماری را پر نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SInformation);
                return false;
            }
            if (textBoxTitleName.Text.Trim() == "")
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("جزییات وضعیت بیماری را پر نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SInformation);
                return false;
            }
            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
