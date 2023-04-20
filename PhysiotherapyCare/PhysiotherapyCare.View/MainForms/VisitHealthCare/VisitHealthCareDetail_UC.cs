using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MKH.Library.Clasess.FilterClass;
using PhysiotherapyCare.Model.VisitHealthCare;

namespace PhysiotherapyCare.View.MainForms.VisitHealthCare
{
    public partial class VisitHealthCareDetail_UC: UserControl
    {
        public bool SaveResult = true;
        public string MessageResultVisitHealthCareDetail = "";

        long _visitHealthCare_Id = 0; int _serviceTypeDsc_Id = 0;
        string str = "";

        public VisitHealthCareDetail_UC(long VisitHealthCare_Id, int ServiceTypeDsc_Id)
        {
            InitializeComponent();

            _visitHealthCare_Id = VisitHealthCare_Id;
            _serviceTypeDsc_Id = ServiceTypeDsc_Id;

            ViewModel.VisitHealthCare.ServiceHealthCare RN = new ViewModel.VisitHealthCare.ServiceHealthCare();
            List<VW_ServiceHealthCare> U = RN.GetAllListByDetailRow(_serviceTypeDsc_Id, _visitHealthCare_Id, ref str);

            TextBoxServiceTypeDsc.Text = U[0].ServiceTypeName + " - " + U[0].ServiceTypeDscName;
            TextBoxServiceTypeDsc.Tag = U[0].ServiceTypeDsc_Id;
            IntBoxServiceTypeDscFew.Value = U[0].ServiceTypeDscFew;
            IntBoxPriceType.Value = U[0].PriceType;
        }

        public VisitHealthCareDetail_UC()
        {
            InitializeComponent();
        }


        public bool CheckvalidationUC()
        {
            if (TextBoxServiceTypeDsc.Text == "")
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("ردیف ( " + LabelRow.Text + ") نوع و شرح خدمات را وارد نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SError);
                return false;
            }
            if (IntBoxServiceTypeDscFew.Text == "0" || IntBoxServiceTypeDscFew.Text == "") 
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("ردیف ( " + LabelRow.Text + ") تعداد خدمات را وارد نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SError);
                return false;
            }
            return true;
        }

        public void save(long VisitHealthCare_Id)
        {
            try
            {
                int? f = 0;

                List<TBL_ServiceHealthCare> Ls = new List<TBL_ServiceHealthCare>(1);
                TBL_ServiceHealthCare ServiceHealthCare = new TBL_ServiceHealthCare();

                ServiceHealthCare.ServiceTypeDsc_Id = TextBoxServiceTypeDsc.Tag.ToString().ToInt();
                ServiceHealthCare.VisitHealthCare_Id = VisitHealthCare_Id;
                ServiceHealthCare.ServiceTypeDscFew = IntBoxServiceTypeDscFew.Value.ToString().ToInt();
                ServiceHealthCare.PriceType = IntBoxPriceType.Value.ToString().ToInt();
                
                Ls.Add(ServiceHealthCare);
                    
                new ViewModel.VisitHealthCare.ServiceHealthCare().InsertEntity(Ls, ref str, ref f);

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
        
        public int getTotalPriceType()
        {
            return IntBoxTotalPriceType.Value.ToString().ToInt();
        }

        private void buttonServiceTypeDsc_Click(object sender, EventArgs e)
        {
            try
            {
                string StrSet = "";
                Dictionary<string, string> SD = new Dictionary<string, string>();
                Dictionary<string, string> SD1 = new Dictionary<string, string>();

                foreach (var item in new ViewModel.VisitHealthCare.ServiceTypeDsc().GetAllList(ref StrSet))
                    SD.Add(item.Id.ToString(), item.ServiceTypeName + " - " + item.TitleName);

                SD1 = MKH.Library.Forms.MSSSelector_frm.SetDataSelect(SD);
                TextBoxServiceTypeDsc.Tag = SD1.Keys.ToList()[0];
                TextBoxServiceTypeDsc.Text = SD1.Values.ToList()[0];
                IntBoxPriceType.Value = new ViewModel.VisitHealthCare.ServiceTypeDsc().GetAllListByID(SD1.Keys.ToList()[0].ToInt(), ref str).Single().PriceType;
            }
            catch { }

        }

        private void IntBoxServiceTypeDscFew_ValueChanged(object sender, EventArgs e)
        {
            IntBoxTotalPriceType.Value = IntBoxPriceType.Value.ToString().ToInt() * IntBoxServiceTypeDscFew.Value.ToString().ToInt();
        }

    }
}
