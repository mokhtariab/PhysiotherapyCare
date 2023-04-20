  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using PhysiotherapyCare.Model;
using MKH.Library.Clasess.Security;
using PhysiotherapyCare.Model.Report;


namespace PhysiotherapyCare.ViewModel.Report
{
    public class ReportDesignList : IInsUpDel<TBL_ReportDesignList, int?>,
        IGetList<VW_ReportDesignList,int>, IDataErrorInfo, INotifyPropertyChanged
    {
       
        #region Constructor

        public ReportDesignList()
        {

        }
        #endregion

        #region Properties

        DataClassesDesignReportDataContext DRN = new DataClassesDesignReportDataContext(MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.InternalConnectionString);

        public bool InsertEntity(List<TBL_ReportDesignList> ListObj, ref string msgRet, ref int? idRet)
        {
            try
            {
                foreach (TBL_ReportDesignList FieldList in ListObj)
                {
                    DRN.SP_ReportDesignListInsert(
                        ref idRet,
                        FieldList.ReportDesignName,
                        FieldList.ReportDesignAddress,
                        FieldList.DesignSetForm,
                        FieldList.User_Id,
                        FieldList.ChangeDateTime,
                        ref msgRet
                        );
                }
                DRN.SubmitChanges();

                

                return true;
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }

            return false;
        }

        public bool UpdateEntity(List<TBL_ReportDesignList> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_ReportDesignList FieldList in ListObj)
                {
                    DRN.SP_ReportDesignListUpdate(
                        FieldList.Id,
                        FieldList.ReportDesignName,
                        FieldList.ReportDesignAddress,
                        FieldList.DesignSetForm,
                        FieldList.User_Id,
                        FieldList.ChangeDateTime,
                        ref msgRet
                        );
                }
                DRN.SubmitChanges();

               

                return true;
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return false;
        }

        public bool DeleteEntity(List<TBL_ReportDesignList> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_ReportDesignList FieldList in ListObj)
                {
                    DRN.SP_ReportDesignListDelete(
                        FieldList.Id,
                        ref msgRet
                     );
                }
                DRN.SubmitChanges();

               

                return true;
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return false;
        }


        public List<VW_ReportDesignList> GetAllList(ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_ReportDesignLists select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_ReportDesignList> GetAllListByID(int Id, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_ReportDesignLists where d.Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_ReportDesignList> GetAllListByFilter(List<MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.Filter> filter, ref string msgRet)
        {
            try
            {
                var deleg = MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.GetExpression<VW_ReportDesignList>(filter).Compile();
                var filteredCollection = (from d in DRN.VW_ReportDesignLists select d).Where(deleg);
                return filteredCollection.ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public int CountAll(List<VW_ReportDesignList> ListObj)
        {
            return ListObj.Count();
        }

        public List<VW_ReportDesignList> GetAllListByDetailRow(int Id, long DetailRowId, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_ReportDesignLists where d.Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

       
        
        
        #endregion

        #region IDataErrorInfo

        public string Error
        {
            get { throw new NotImplementedException(); }
        }

        public string this[string columnName]
        {
            get { throw new NotImplementedException(); }
        }

        #endregion

        #region INotifyPropertyChanged
        [field: NonSerialized]
        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion




    }
}
