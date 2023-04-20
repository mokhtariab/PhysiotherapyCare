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
    public partial class DrugVisitPatient_UC : UserControl
    {
        public bool SaveResult = true;
        public string MessageResultDrugDetailDetail = "";

        long _visitpatient_Id = 0;
        int _drug_Id = 0;
        long _Id = 0;
        string str = "";


        public DrugVisitPatient_UC(long VisitPatient_Id, int Drug_Id, long Id)
        {
            InitializeComponent();

            _visitpatient_Id = VisitPatient_Id;
            _drug_Id = Drug_Id;
            _Id = Id;



            ViewModel.VisitPatient.DrugVisitPatient RN = new ViewModel.VisitPatient.DrugVisitPatient();
            List<VW_DrugVisitPatient> U = RN.GetAllListByDetailRow(Id, ref str);

            TextBoxTitleName.Text = U[0].DrugName ;
            TextBoxTitleName.Tag = U[0].Drug_Id;
            TextBoxUseAmount.Text = U[0].UseAmount;
            TextBoxDiscription.Text = U[0].Description;
           
        }

        public DrugVisitPatient_UC()
        {
            InitializeComponent();
        }


        public bool CheckvalidationUC()
        {
            if (TextBoxTitleName.Text == "")
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("ردیف ( " + LabelRow.Text + ") عنوان دارو را وارد نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SError);
                return false;
            }

            if (TextBoxUseAmount.Text == "")
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("ردیف ( " + LabelRow.Text + ") مقدار دارو را وارد نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SError);
                return false;
            }
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

                List<TBL_DrugVisitPatient> Ls = new List<TBL_DrugVisitPatient>(1);
                TBL_DrugVisitPatient DrugVisitPatient = new TBL_DrugVisitPatient();

                DrugVisitPatient.Drug_Id = TextBoxTitleName.Tag.ToString().ToInt();
                DrugVisitPatient.VisitPatient_Id = VisitPationt_Id;
                DrugVisitPatient.UseAmount = TextBoxUseAmount.Text;
                DrugVisitPatient.Description = TextBoxDiscription.Text.ToString();
                

                Ls.Add(DrugVisitPatient);
                
                new ViewModel.VisitPatient.DrugVisitPatient().InsertEntity(Ls, ref str, ref f);
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
         

        //public List<VW_SicknessVisitPatient> getvalueObject()
        //{

        //    List<VW_SicknessVisitPatient> Ls = new List<VW_SicknessVisitPatient>(1);
        //    VW_SicknessVisitPatient ServiceHealthCare = new VW_SicknessVisitPatient();
        //    Ls.Clear();
        //    _lst.Clear();
        //    //ViewModel.VisitPatient.SicknessVisitPatient RN = new ViewModel.VisitPatient.SicknessVisitPatient();
        //    //List<VW_SicknessVisitPatient> U = RN.GetAllListByDetailRow(Id, ref str);

        //    //TextBoxTitleName.Text = U[0].TitleName + " - " + U[0].TitleNameDetail;

        //    ServiceHealthCare.SicknessDetail_Id = TextBoxTitleName.Tag.ToString().ToInt();
        //    ServiceHealthCare.VisitPatient_Id = _visitpatient_Id;
        //    ServiceHealthCare.Description = TextBoxDiscription.Text;
        //    ServiceHealthCare.TitleName = TextBoxTitleName.Text;


        //    Ls.Add(ServiceHealthCare);

        //    return Ls;
        //}

        private void buttonServiceTypeDsc_Click(object sender, EventArgs e)
        {
            try
            {
                string StrSet = "";
                Dictionary<string, string> SD = new Dictionary<string, string>();
                Dictionary<string, string> SD1 = new Dictionary<string, string>();

                foreach (var item in new ViewModel.VisitPatient.Drug().GetAllList(ref StrSet))
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
