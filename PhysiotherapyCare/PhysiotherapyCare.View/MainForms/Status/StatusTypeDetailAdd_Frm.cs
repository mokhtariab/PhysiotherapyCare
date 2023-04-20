using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using PhysiotherapyCare.Model.Status;
using PhysiotherapyCare.ViewModel.Status;


namespace PhysiotherapyCare.View.MainForms.Status
{
    public partial class StatusTypeDetailAdd_Frm : MKH.Library.Forms.MSSBaseNew_frm
    {
        private int _id = 0;
        private bool _editIns = false;
        string str = "";

        public StatusTypeDetailAdd_Frm()
        {
            InitializeComponent();
        }

        public StatusTypeDetailAdd_Frm(int Id)
        {
            InitializeComponent();
            _id = Id;
            _editIns = true;
        }

        private void StatusTypeDetailAdd_Frm_Load(object sender, EventArgs e)
        {
            SetComboBox();

            if (_editIns) fillControl();
        }

        private void SetComboBox()
        {
            ComboBoxStatusType.ValueMember = "Id";
            ComboBoxStatusType.DisplayMember = "TitleName";
            ComboBoxStatusType.DataSource = new StatusType().GetAllList(ref str);
        }


        private void fillControl()
        {
            string str = "";
            StatusTypeDetail RN = new StatusTypeDetail();
            List<VW_StatusTypeDetail> DT = RN.GetAllListByID(_id, ref str);


            ComboBoxStatusType.SelectedValue = DT[0].StatusType_Id;
            textBoxTitleName.Text = DT[0].TitleName;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckValidation())
                return;
            try
            {
                string str = ""; int? idSet = 0;
                List<TBL_StatusTypeDetail> Ls = new List<TBL_StatusTypeDetail>(1);
                TBL_StatusTypeDetail StatusTypeDetail = new TBL_StatusTypeDetail();
                StatusTypeDetail.Id = _id;
                StatusTypeDetail.StatusType_Id = Convert.ToInt16(ComboBoxStatusType.SelectedValue);
                StatusTypeDetail.TitleName = textBoxTitleName.Text;
                Ls.Add(StatusTypeDetail);

                if (!_editIns)
                {
                    new ViewModel.Status.StatusTypeDetail().InsertEntity(Ls, ref str, ref idSet);
                }
                else
                {
                    new ViewModel.Status.StatusTypeDetail().UpdateEntity(Ls, ref str);
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
            if (ComboBoxStatusType.Text.Trim() == "")
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("وضعیت را پر نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SInformation);
                return false;
            }
            if (textBoxTitleName.Text.Trim() == "")
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("جزییات وضعیت را پر نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SInformation);
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
