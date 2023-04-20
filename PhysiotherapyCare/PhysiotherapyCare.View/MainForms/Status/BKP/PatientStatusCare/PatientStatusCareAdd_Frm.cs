using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using PhysiotherapyCare.ViewModel;
using PhysiotherapyCare.Model;


namespace PhysiotherapyCare.View.MainForms.PatientStatusCare
{
    public partial class PatientStatusCareAdd_Frm : MKH.Library.Forms.MSSBaseNew_frm
    {
        private int _id = 0, _visitPatientCare_Id = 0;
        private bool _editIns = false;
        private string str = "";

        public PatientStatusCareAdd_Frm(int VisitPatientCare_Id)
        {
            InitializeComponent();
            _visitPatientCare_Id = VisitPatientCare_Id; 
        }


        public PatientStatusCareAdd_Frm(int VisitPatientCare_Id, int Id)
        {
            InitializeComponent();
            _id = Id;
            _visitPatientCare_Id = VisitPatientCare_Id;
            _editIns = true;
        }

        private void PatientStatusCareAdd_Frm_Load(object sender, EventArgs e)
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
            ViewModel.PatientStatusCares.PatientStatusCare RN = new ViewModel.PatientStatusCares.PatientStatusCare();
            
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
                List<TBL_PatientStatusCare> Ls = new List<TBL_PatientStatusCare>(1);
                TBL_PatientStatusCare PatientStatusCare = new TBL_PatientStatusCare();

                PatientStatusCare.Id = _id;
                PatientStatusCare.VisitPatientCare_Id = _visitPatientCare_Id;
                PatientStatusCare.StatusDate = DatePickerStatusDate.Value.ToString().Substring(0, 10);
                PatientStatusCare.PatientStatusType_Id = Convert.ToInt16(ComboBoxPatientStatusType.SelectedValue);

                PatientStatusCare.IsDo = checkBoxIsDo.Checked;
                PatientStatusCare.Description = TextBoxDescription.Text;

                Ls.Add(PatientStatusCare);

                if (!_editIns)
                {
                    new ViewModel.PatientStatusCares.PatientStatusCare().InsertEntity(Ls, ref str, ref idSet);
                }
                else
                {
                    new ViewModel.PatientStatusCares.PatientStatusCare().UpdateEntity(Ls, ref str);
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
