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
    public partial class ParaclinicVisitPatient_UC : UserControl
    {
        public bool SaveResult = true;
        public string MessageResultSicknessDetailDetail = "";

        long _visitpatient_Id = 0;
        int _sicknessdetail_Id = 0;
        long _Id = 0;
        string str = "";


        public ParaclinicVisitPatient_UC(long VisitPatient_Id, int SicknessDetail_Id, long Id)
        {
            InitializeComponent();

            _visitpatient_Id = VisitPatient_Id;
            _sicknessdetail_Id = SicknessDetail_Id;
            _Id = Id;

            ViewModel.VisitPatient.ParaclinicVisitPatient RN = new ViewModel.VisitPatient.ParaclinicVisitPatient();
            List<VW_ParaclinicVisitPatient> U = RN.GetAllListByDetailRow(Id, ref str);

            TextBoxTitleName.Text = U[0].ParaclinicName;
            TextBoxTitleName.Tag = U[0].Paraclinic_Id;
            TextBoxParaclinicState.Text = U[0].ParaclinicsState;
            TextBoxDiscription.Text = U[0].Description;
        }

        public ParaclinicVisitPatient_UC()
        {
            InitializeComponent();
        }


        public bool CheckvalidationUC()
        {
            if (TextBoxTitleName.Text == "")
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("ردیف ( " + LabelRow.Text + ") عنوان پاراکلینیک را وارد نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SError);
                return false;
            }
            
            //if (TextBoxParaclinicState.Text == "")
            //{
            //    MKH.Library.Clasess.MSSMessage.MSSMessage_View("ردیف ( " + LabelRow.Text + ") وضعیت پاراکلینیک را وارد نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SError);
            //    return false;
            //}

            //if (TextBoxDiscription.Text.Trim().Length == 0 || TextBoxDiscription.Text == "")
            //{
            //    MKH.Library.Clasess.MSSMessage.MSSMessage_View("ردیف ( " + LabelRow.Text + ") توضیحات را وارد نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SError);
            //    return false;
            //}
            return true;
        }

        public void save(long VisitPationt_Id)
        {
            try
            {
                long? f = 0;

                List<TBL_ParaclinicVisitPatient> Ls = new List<TBL_ParaclinicVisitPatient>(1);
                TBL_ParaclinicVisitPatient ParaclinicVisitPatient = new TBL_ParaclinicVisitPatient();

                ParaclinicVisitPatient.Paraclinic_Id = TextBoxTitleName.Tag.ToString().ToInt();
                ParaclinicVisitPatient.VisitPatient_Id = VisitPationt_Id;
                ParaclinicVisitPatient.ParaclinicsState = TextBoxParaclinicState.Text;
                ParaclinicVisitPatient.Description = TextBoxDiscription.Text.ToString();
                

                Ls.Add(ParaclinicVisitPatient);
                
                new ViewModel.VisitPatient.ParaclinicVisitPatient().InsertEntity(Ls, ref str, ref f);

               
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
            try
            {
                string StrSet = "";
                Dictionary<string, string> SD = new Dictionary<string, string>();
                Dictionary<string, string> SD1 = new Dictionary<string, string>();

                foreach (var item in new ViewModel.VisitPatient.Paraclinic().GetAllList(ref StrSet))
                    SD.Add(item.Id.ToString(), item.TitleName);

                SD1 = MKH.Library.Forms.MSSSelector_frm.SetDataSelect(SD);
                TextBoxTitleName.Tag = SD1.Keys.ToList()[0];
                TextBoxTitleName.Text = SD1.Values.ToList()[0];
                //  IntBoxPriceType.Value = new ViewModel.VisitHealthCare.ServiceTypeDsc().GetAllListByID(SD1.Keys.ToList()[0].ToInt(), ref str).Single().PriceType;
            }
            catch { }

        }

        //private void IntBoxServiceTypeDscFew_ValueChanged(object sender, EventArgs e)
        //{
        //    IntBoxTotalPriceType.Value = IntBoxPriceType.Value.ToString().ToInt() * IntBoxDescription.Value.ToString().ToInt();
        //}

    }
}
