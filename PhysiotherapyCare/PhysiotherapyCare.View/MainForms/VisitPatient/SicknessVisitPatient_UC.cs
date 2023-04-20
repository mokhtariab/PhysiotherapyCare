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
    public partial class SicknessVisitPatient_UC : UserControl
    {
        public bool SaveResult = true;
        public string MessageResultSicknessDetailDetail = "";

        long _visitpatient_Id = 0;
        int _sicknessdetail_Id = 0;
        long _Id = 0;
        string str = "";


        public SicknessVisitPatient_UC(long VisitPatient_Id, int SicknessDetail_Id, long Id)
        {
            InitializeComponent();

            _visitpatient_Id = VisitPatient_Id;
            _sicknessdetail_Id = SicknessDetail_Id;
            _Id = Id;



            ViewModel.VisitPatient.SicknessVisitPatient RN = new ViewModel.VisitPatient.SicknessVisitPatient();
            List<VW_SicknessVisitPatient> U = RN.GetAllListByDetailRow(Id, ref str);

            TextBoxTitleName.Text = U[0].SicknessName + " - " + U[0].SicknessDetailName;
            TextBoxTitleName.Tag = U[0].SicknessDetail_Id;
            TextBoxDiscription.Text = U[0].Description;
           
        }

        public SicknessVisitPatient_UC()
        {
            InitializeComponent();
        }


        public bool CheckvalidationUC()
        {
            if (TextBoxTitleName.Text == "")
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("ردیف ( " + LabelRow.Text + ") عنوان بیماری را وارد نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SError);
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

                List<TBL_SicknessVisitPatient> Ls = new List<TBL_SicknessVisitPatient>(1);
                TBL_SicknessVisitPatient SicknessVisitPatient = new TBL_SicknessVisitPatient();

                SicknessVisitPatient.SicknessDetail_Id = TextBoxTitleName.Tag.ToString().ToInt();
                SicknessVisitPatient.VisitPatient_Id = VisitPationt_Id;
                SicknessVisitPatient.Description = TextBoxDiscription.Text.ToString();
                

                Ls.Add(SicknessVisitPatient);
                
                new ViewModel.VisitPatient.SicknessVisitPatient().InsertEntity(Ls, ref str, ref f);

               
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

                foreach (var item in new ViewModel.VisitPatient.SicknessDetail().GetAllList(ref StrSet))
                    SD.Add(item.Id.ToString(), item.SicknessName + " - " + item.SicknessDetailName);

                SD1 = MKH.Library.Forms.MSSSelector_frm.SetDataSelect(SD);
                TextBoxTitleName.Tag = SD1.Keys.ToList()[0];
                TextBoxTitleName.Text = SD1.Values.ToList()[0];
            }
            catch { }

        }

 
    }
}
