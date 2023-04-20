using System.Linq;
using System.Collections.Generic;
using PhysiotherapyCare.Model.Basic;
using PhysiotherapyCare.Model;
using MKH.Library.Clasess.FilterClass;
using System.Windows.Forms;
using PhysiotherapyCare.Model.VisitPatientPhysiotherapy;

namespace PhysiotherapyCare.View.MainForms.VisitPatientPhysiotherapyPayment
{
    public partial class VisitPatientPhysiotherapyPayment_UC : UserControl
    {
        public long _visitPatientPhysiotherapy_Id = 0;
        public VisitPatientPhysiotherapyPayment_UC()
        {
            InitializeComponent();
           
        }


        public void BindData(long VisitPatientPhysiotherapy_Id)
        {
            string str = "";
            _visitPatientPhysiotherapy_Id = VisitPatientPhysiotherapy_Id;
            if (_visitPatientPhysiotherapy_Id == 0)
            {

                HeaderGridVisitPatientPhysiotherapyPayment.ButtonInsertVisible = false;
                HeaderGridVisitPatientPhysiotherapyPayment.ButtonEditVisible = false;
                HeaderGridVisitPatientPhysiotherapyPayment.ButtonDeleteVisible = false;

                HeaderGridVisitPatientPhysiotherapyPayment.ButtonSearchExpertVisible = true;
                HeaderGridVisitPatientPhysiotherapyPayment.ButtonExcelExportVisible = true;

                GridViewVisitPatientPhysiotherapyPayment.Tag = "PL";

                if (GridViewVisitPatientPhysiotherapyPayment.FilterList.Count == 0)
                    GridViewVisitPatientPhysiotherapyPayment.DataSource = new ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapyPayment().GetAllList(ref str);
                else
                    GridViewVisitPatientPhysiotherapyPayment.DataSource =
                        new ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapyPayment().GetAllListByFilter(GridViewVisitPatientPhysiotherapyPayment.FilterList, ref str);
            }
            else
            {
                HeaderGridVisitPatientPhysiotherapyPayment.ButtonInsertVisible = true;
                HeaderGridVisitPatientPhysiotherapyPayment.ButtonEditVisible = true;
                HeaderGridVisitPatientPhysiotherapyPayment.ButtonDeleteVisible = true;

                HeaderGridVisitPatientPhysiotherapyPayment.ButtonSearchExpertVisible = false;
                HeaderGridVisitPatientPhysiotherapyPayment.ButtonExcelExportVisible = false;

                GridViewVisitPatientPhysiotherapyPayment.Tag = "PU";

                List<QueryFilter.ExpressionBuilder.Filter> filter = new List<QueryFilter.ExpressionBuilder.Filter>();
                filter.Add(
                new QueryFilter.ExpressionBuilder.Filter
                {
                    PropertyName = "VisitPatientPhysiotherapy_Id",
                    Operation = QueryFilter.ExpressionBuilder.Op.Equals,
                    Value = _visitPatientPhysiotherapy_Id,
                    OperationFilter = QueryFilter.ExpressionBuilder.OpFilter.And
                }
                );
                GridViewVisitPatientPhysiotherapyPayment.DataSource = new ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapyPayment().GetAllListByFilter(filter, ref str);
            }


        }

        
        #region All UI Button

        private void headerGridVisitPatientPhysiotherapyPayment_btnInsertClick(object sender, System.EventArgs e)
        {
            try
            {
                VisitPatientPhysiotherapyPaymentAdd_Frm VisitPatientPhysiotherapyPaymentAdd = new VisitPatientPhysiotherapyPaymentAdd_Frm(
                        _visitPatientPhysiotherapy_Id);

                if (VisitPatientPhysiotherapyPaymentAdd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    BindData(_visitPatientPhysiotherapy_Id);

                try { GridViewVisitPatientPhysiotherapyPayment.Row = GridViewVisitPatientPhysiotherapyPayment.RowCount; }
                catch { }
            }
            catch { }
        }

        private void headerGridVisitPatientPhysiotherapyPayment_btnEditClick(object sender, System.EventArgs e)
        {
            try
            {
                VisitPatientPhysiotherapyPaymentAdd_Frm VisitPatientPhysiotherapyPaymentAdd = new VisitPatientPhysiotherapyPaymentAdd_Frm(
                    long.Parse(GridViewVisitPatientPhysiotherapyPayment.CurrentRow.Cells["Id"].Value.ToString()),
                    long.Parse(GridViewVisitPatientPhysiotherapyPayment.CurrentRow.Cells["VisitPatientPhysiotherapy_Id"].Value.ToString()));

                VisitPatientPhysiotherapyPaymentAdd.ShowDialog();

                
                int i = GridViewVisitPatientPhysiotherapyPayment.Row;

                BindData(_visitPatientPhysiotherapy_Id);

                try { GridViewVisitPatientPhysiotherapyPayment.Row = i; }
                catch { }
            }
            catch { }
        }

        private void headerGridVisitPatientPhysiotherapyPayment_btnDeleteClick(object sender, System.EventArgs e)
        {
            if (MKH.Library.Clasess.MSSMessage.MSSMessage_View(0,MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation,true, "آیا به حذف این مورد اطمینان دارید؟"))
            {
                try
                {
                    List<TBL_VisitPatientPhysiotherapyPayment> Ls = new List<TBL_VisitPatientPhysiotherapyPayment>();
                    TBL_VisitPatientPhysiotherapyPayment VisitPatientPhysiotherapyPayment = new TBL_VisitPatientPhysiotherapyPayment();
                    VisitPatientPhysiotherapyPayment.Id = int.Parse(GridViewVisitPatientPhysiotherapyPayment.CurrentRow.Cells["Id"].Value.ToString());
                    Ls.Add(VisitPatientPhysiotherapyPayment);


                    string str = "";
                    new ViewModel.VisitPatientPhysiotherapy.VisitPatientPhysiotherapyPayment().DeleteEntity(Ls, ref str);
                    if (str != "") MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "امکان حذف این مورد در سیستم وجود ندارد", str);
                    else
                    {
                        int i = GridViewVisitPatientPhysiotherapyPayment.Row;
                        BindData(_visitPatientPhysiotherapy_Id);
                        try { GridViewVisitPatientPhysiotherapyPayment.Row = i - 1; }
                        catch { }
                    }
                }
                catch (System.Exception ex)
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "اشکال", ex.Message);
                }

            }
        }

        private void headerGridVisitPatientPhysiotherapyPayment_btnRefreshClick(object sender, System.EventArgs e)
        {
            int i = GridViewVisitPatientPhysiotherapyPayment.Row;
            BindData(_visitPatientPhysiotherapy_Id);
            try { GridViewVisitPatientPhysiotherapyPayment.Row = i; }
            catch { }
        }

        #endregion

        private void VisitPatientPhysiotherapyPayment_UC_Load(object sender, System.EventArgs e)
        {
            new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionControl(this);
            BindData(_visitPatientPhysiotherapy_Id);

            try { GridViewVisitPatientPhysiotherapyPayment.Row = 0; }
            catch { }
        }

        private void GridViewVisitPatientPhysiotherapyPayment_BindingDataSourceSet(object sender, System.EventArgs e)
        {
            int i = GridViewVisitPatientPhysiotherapyPayment.Row; 
            BindData(_visitPatientPhysiotherapy_Id);

            try { GridViewVisitPatientPhysiotherapyPayment.Row = i; }
            catch { }
        }

       
    }
}
