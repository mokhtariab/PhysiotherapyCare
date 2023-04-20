using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using PhysiotherapyCare.ViewModel.PatientStatusPhysiotherapys;
using PhysiotherapyCare.Model.PatientStatusPhysiotherapy;


namespace PhysiotherapyCare.View.MainForms.PatientStatusPhysiotherapy
{
    public partial class PatientStatusPhysiotherapyAdd_Frm : MKH.Library.Forms.MSSBaseNew_frm
    {
        private int _id = 0, _visitPatientPhysiotherapy_Id = 0;
        private bool _editIns = false;
        private string str = "";

        public PatientStatusPhysiotherapyAdd_Frm(int visitPatientPhysiotherapy_Id)
        {
            InitializeComponent();
            _visitPatientPhysiotherapy_Id = visitPatientPhysiotherapy_Id; 
        }


        public PatientStatusPhysiotherapyAdd_Frm(int visitPatientPhysiotherapy_Id, int Id)
        {
            InitializeComponent();
            _id = Id;
            _visitPatientPhysiotherapy_Id = visitPatientPhysiotherapy_Id;
            _editIns = true;
        }

        private void PatientStatusPhysiotherapyAdd_Frm_Load(object sender, EventArgs e)
        {

            DatePickerStatusDate.Value = KagNetComponents2.KagPersianDate.Parse(DateTime.Now);
            SetComboBox();

            if (_editIns) fillControl();
        }

        private void SetComboBox()
        {
            ComboBoxPatientStatusType.ValueMember = "Id";
            ComboBoxPatientStatusType.DisplayMember = "TitleName";
            ComboBoxPatientStatusType.DataSource = new PhysiotherapyCare.ViewModel.Basic.PatientStatusType().GetAllList(ref str);
        }
        private void fillControl()
        {
            string str = "";
            ViewModel.PatientStatusPhysiotherapys.PatientStatusPhysiotherapy RN = new ViewModel.PatientStatusPhysiotherapys.PatientStatusPhysiotherapy();
            
            DatePickerStatusDate.Value = KagNetComponents2.KagPersianDate.Parse(RN.GetAllListByID(_id, ref str)[0].StatusDate);
            ComboBoxPatientStatusType.SelectedValue = RN.GetAllListByID(_id, ref str)[0].PatientStatusType_Id;
            checkBoxIsDo.Checked = RN.GetAllListByID(_id, ref str)[0].IsDo.Value;
            TextBoxDescription.Text = RN.GetAllListByID(_id, ref str)[0].Description;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckValidation())
                return;
            try
            {
                string str = ""; long? idSet = 0;
                List<TBL_PatientStatusPhysiotherapy> Ls = new List<TBL_PatientStatusPhysiotherapy>(1);
                TBL_PatientStatusPhysiotherapy PatientStatusPhysiotherapy = new TBL_PatientStatusPhysiotherapy();

                PatientStatusPhysiotherapy.Id = _id;
                PatientStatusPhysiotherapy.VisitPatientPhysiotherapy_Id = _visitPatientPhysiotherapy_Id;
                PatientStatusPhysiotherapy.StatusDate = DatePickerStatusDate.Value.ToString().Substring(0, 10);
                PatientStatusPhysiotherapy.PatientStatusType_Id = Convert.ToInt16(ComboBoxPatientStatusType.SelectedValue);

                PatientStatusPhysiotherapy.IsDo = checkBoxIsDo.Checked;
                PatientStatusPhysiotherapy.Description = TextBoxDescription.Text;

                Ls.Add(PatientStatusPhysiotherapy);

                if (!_editIns)
                {
                    new ViewModel.PatientStatusPhysiotherapys.PatientStatusPhysiotherapy().InsertEntity(Ls, ref str, ref idSet);
                }
                else
                {
                    new ViewModel.PatientStatusPhysiotherapys.PatientStatusPhysiotherapy().UpdateEntity(Ls, ref str);
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
            catch (Exception ex)
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, ex.Message);
            }

        }



        private bool CheckValidation()
        {
            //if (TextBoxContractNo.Text.Trim() == "")
            //{
            //    MKH.Library.Clasess.MSSMessage.MSSMessage_View("لطفا شماره قرارداد را پر نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SWarning);
            //    return false;
            //}
            //if (DatePickerStatusDate.Value > DatePickerContractEndDate.Value)
            //{
            //    MKH.Library.Clasess.MSSMessage.MSSMessage_View("تاریخ شروع نبایستی از تاریخ پایان بزرگتر باشد", MKH.Library.Clasess.MSSMessage.MessageType.SWarning);
            //    return false;
            //}
            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
