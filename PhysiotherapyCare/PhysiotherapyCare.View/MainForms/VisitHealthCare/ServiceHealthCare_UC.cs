using System.Linq;
using System.Collections.Generic;
using PhysiotherapyCare.Model.Basic;
using PhysiotherapyCare.Model;
using MKH.Library.Clasess.FilterClass;
using System.Windows.Forms;
using PhysiotherapyCare.Model.VisitHealthCare;
using PhysiotherapyCare.View.MainForms.VisitHealthCare;

namespace PhysiotherapyCare.View.MainForms.VisitHealthCare
{
    public partial class ServiceHealthCare_UC : UserControl
    {
        public ServiceHealthCare_UC()
        {
            InitializeComponent();
        }

        public void BindData(int VisitHealthCare_Id)
        {
            string str = "";

            List<VW_ServiceHealthCare> LSQ = new List<VW_ServiceHealthCare>();

            if (VisitHealthCare_Id == 0)
                LSQ = new ViewModel.VisitHealthCare.ServiceHealthCare().GetAllList(ref str);
            else
                LSQ = new ViewModel.VisitHealthCare.ServiceHealthCare().GetAllList(ref str).Where(pp => pp.VisitHealthCare_Id == VisitHealthCare_Id).ToList();


            GridViewServiceHealthCare.DataSource = LSQ;

        }

       
    }
}
