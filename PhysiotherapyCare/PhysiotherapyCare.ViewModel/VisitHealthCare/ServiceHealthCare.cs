  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using PhysiotherapyCare.Model;
using MKH.Library.Clasess.Security;
using PhysiotherapyCare.Model.VisitHealthCare;


namespace PhysiotherapyCare.ViewModel.VisitHealthCare
{
    public class ServiceHealthCare : IInsUpDel<TBL_ServiceHealthCare, int?>,
        IGetList<VW_ServiceHealthCare,int>, IDataErrorInfo, INotifyPropertyChanged
    {
       
        #region Constructor

        public ServiceHealthCare()
        {

        }
        #endregion

        #region Properties

        DataClassesVisitHealthCareBaseDataContext DRN = new DataClassesVisitHealthCareBaseDataContext(MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.InternalConnectionString);

        public bool InsertEntity(List<TBL_ServiceHealthCare> ListObj, ref string msgRet, ref int? idRet)
        {
            try
            {
                foreach (TBL_ServiceHealthCare FieldList in ListObj)
                {
                    DRN.SP_ServiceHealthCareInsert(
                        FieldList.VisitHealthCare_Id,
                        FieldList.ServiceTypeDsc_Id,
                        FieldList.ServiceTypeDscFew,
                        FieldList.PriceType,
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

        public bool UpdateEntity(List<TBL_ServiceHealthCare> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_ServiceHealthCare FieldList in ListObj)
                {
                    DRN.SP_ServiceHealthCareUpdate(
                        FieldList.VisitHealthCare_Id,
                        FieldList.ServiceTypeDsc_Id,
                        FieldList.ServiceTypeDscFew,
                        FieldList.PriceType,
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

        public bool DeleteEntity(List<TBL_ServiceHealthCare> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_ServiceHealthCare FieldList in ListObj)
                {
                    DRN.SP_ServiceHealthCareDelete(
                        FieldList.VisitHealthCare_Id,
                        FieldList.ServiceTypeDsc_Id,
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


        public List<VW_ServiceHealthCare> GetAllList(ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_ServiceHealthCares select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_ServiceHealthCare> GetAllListByID(int Id, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_ServiceHealthCares where d.VisitHealthCare_Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_ServiceHealthCare> GetAllListByFilter(List<MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.Filter> filter, ref string msgRet)
        {
            try
            {
                var deleg = MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.GetExpression<VW_ServiceHealthCare>(filter).Compile();
                var filteredCollection = (from d in DRN.VW_ServiceHealthCares select d).Where(deleg);
                return filteredCollection.ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public int CountAll(List<VW_ServiceHealthCare> ListObj)
        {
            return ListObj.Count();
        }

        public List<VW_ServiceHealthCare> GetAllListByDetailRow(int Id, long DetailRowId, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_ServiceHealthCares where d.ServiceTypeDsc_Id == Id && d.VisitHealthCare_Id == DetailRowId select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public bool ServiceHealthCareWithVisitHealthCareDelete(long VisitHealthCare_Id, ref string msgRet)
        {
            try
            {
                DRN.SP_ServiceHealthCareWithVisitHealthCareDelete(
                    VisitHealthCare_Id,
                    ref msgRet
                    );
                DRN.SubmitChanges();

                return true;
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return false;
        }


        public int SumServiceHealthCare(long VisitHealthCare_Id)
        {
            try
            {
                return DRN.SumServiceHealthCare(VisitHealthCare_Id).Value;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }


        public List<SP_ServiceHealthCareReportForDetailResult> GetReportForDetail(string DateStart, string DateEnd, ref string msgRet)
        {
            try
            {
                return (from d in DRN.SP_ServiceHealthCareReportForDetail(DateStart, DateEnd) select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<SP_ServiceHealthCareReportForDetailWithGroupResult> GetReportForDetailWithGroup(ref string msgRet)
        {
            try
            {
                return (from d in DRN.SP_ServiceHealthCareReportForDetailWithGroup() select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<SP_ServiceHealthCareReportForDetailSumResult> GetReportForDetailSum(string DateStart, string DateEnd, ref string msgRet)
        {
            try
            {
                return (from d in DRN.SP_ServiceHealthCareReportForDetailSum(DateStart, DateEnd) select d).ToList();
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
