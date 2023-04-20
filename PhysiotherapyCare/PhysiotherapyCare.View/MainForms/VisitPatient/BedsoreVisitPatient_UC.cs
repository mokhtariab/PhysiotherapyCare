using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MKH.Library.Clasess.FilterClass;
using PhysiotherapyCare.Model.VisitPatient;

namespace PhysiotherapyCare.View.MainForms.VisitPatient
{
    public partial class BedsoreVisitPatient_UC : UserControl
    {
        public bool SaveResult = true;
        public string MessageResultBedsoreDetailDetail = "";

        long _id = 0;
       
        
        string str = "";


        public BedsoreVisitPatient_UC(long Id)
        {
            InitializeComponent();

            _id = Id;
           
            ViewModel.VisitPatient.BedsoreVisitPatient RN = new ViewModel.VisitPatient.BedsoreVisitPatient();
            List<VW_BedsoreVisitPatient> U = RN.GetAllListByDetailRow(Id, ref str);

            TextBoxBedsoreDeep.Text = U[0].BedsoreDeep;
            TextBoxBedsoreGrade.Text = U[0].BedsoreGrade;
            TextBoxBedsorePosition.Text = U[0].BedsorePosition;
            TextBoxBedsoreRemain.Text = U[0].BedsoreRemain;
            TextBoxBedsoreStartTime.Text = U[0].BedsoreStartTime;
            IntBoxBedsoreMeasurement.Value = int.Parse(U[0].BedsoreMeasurement.ToString());
            TextBoxDiscription.Text = U[0].Description;

        }

        public BedsoreVisitPatient_UC()
        {
            InitializeComponent();
        }


        public bool CheckvalidationUC()
        {
            if (TextBoxBedsorePosition.Text == "")
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("ردیف ( " + LabelRow.Text + ") محل زخم را وارد نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SError);
                return false;
            }
            if (TextBoxBedsoreDeep.Text == "")
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("ردیف ( " + LabelRow.Text + ") وسعت زخم را وارد نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SError);
                return false;
            }
            if (TextBoxBedsoreGrade.Text == "")
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("ردیف ( " + LabelRow.Text + ") گرید (درجه) را وارد نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SError);
                return false;
            }
            if (TextBoxBedsoreRemain.Text == "")
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("ردیف ( " + LabelRow.Text + ") روند بهبودی را وارد نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SError);
                return false;
            }
            //if (TextBoxDiscription.Text.Trim().Length == 0 || TextBoxDiscription.Text == "")
            //{
            //    MKH.Library.Clasess.MSSMessage.MSSMessage_View("ردیف ( " + LabelRow.Text + ") توضیحات را وارد نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SError);
            //    return false;
            //}
            if (IntBoxBedsoreMeasurement.Text == "0" || IntBoxBedsoreMeasurement.Text.Trim().Length == 0)
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("ردیف ( " + LabelRow.Text + ") ابعاد زخم را وارد نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SError);
                return false;
            }
            return true;
        }

        public void save(long VisitPationt_Id)
        {
            try
            {
                long? f = 0;

                List<TBL_BedsoreVisitPatient> Ls = new List<TBL_BedsoreVisitPatient>(1);
                TBL_BedsoreVisitPatient BedsoreVisitPatient = new TBL_BedsoreVisitPatient();

                //VaccinationVisitPatient.Vaccination_Id = TextBoxTitleName.Tag.ToString().ToInt();

                BedsoreVisitPatient.VisitPatient_Id = VisitPationt_Id;
                BedsoreVisitPatient.BedsoreMeasurement = int.Parse(IntBoxBedsoreMeasurement.Value.ToString());
                BedsoreVisitPatient.BedsoreDeep = TextBoxBedsoreDeep.Text.ToString();
                BedsoreVisitPatient.BedsoreGrade = TextBoxBedsoreGrade.Text.ToString();
                BedsoreVisitPatient.BedsorePosition = TextBoxBedsorePosition.Text.ToString();
                BedsoreVisitPatient.BedsoreRemain= TextBoxBedsoreRemain.Text.ToString();
                BedsoreVisitPatient.BedsoreStartTime = TextBoxBedsoreStartTime.Text.ToString();
                BedsoreVisitPatient.Description = TextBoxDiscription.Text.ToString();

                Ls.Add(BedsoreVisitPatient);

                new ViewModel.VisitPatient.BedsoreVisitPatient().InsertEntity(Ls, ref str, ref f);
                SaveResult = true;
            }
            catch (Exception ex)
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View(ex.Message, MKH.Library.Clasess.MSSMessage.MessageType.SError);
                SaveResult = false;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation, true, "آیا مایلید ردیف حذف شود؟"))
                this.Visible = false;
        }

        public void setRowNo(int RowNo)
        {
            LabelRow.Text = RowNo.ToString();
        }

        private void buttonServiceTypeDsc_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    string StrSet = "";
            //    Dictionary<string, string> SD = new Dictionary<string, string>();
            //    Dictionary<string, string> SD1 = new Dictionary<string, string>();

            //    foreach (var item in new ViewModel.Basic.Vaccination().GetAllList(ref StrSet))
            //        SD.Add(item.Id.ToString(), item.TitleName);

            //    SD1 = MKH.Library.Forms.MSSSelector_frm.SetDataSelect(SD);
            //    TextBoxTitleName.Tag = SD1.Keys.ToList()[0];
            //    TextBoxTitleName.Text = SD1.Values.ToList()[0];
               
            //}
            //catch { }
        }

    }
}
