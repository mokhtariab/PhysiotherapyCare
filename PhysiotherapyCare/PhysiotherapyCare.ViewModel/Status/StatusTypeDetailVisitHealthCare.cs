  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using PhysiotherapyCare.Model;
using MKH.Library.Clasess.Security;
using PhysiotherapyCare.Model.Status;


namespace PhysiotherapyCare.ViewModel.Status
{
    public class StatusTypeDetailVisitHealthCare : IInsUpDel<TBL_StatusTypeDetailVisitHealthCare, long?>,
        IGetList<VW_StatusTypeDetailVisitHealthCare, long>, IDataErrorInfo, INotifyPropertyChanged
    {
       
        #region Constructor

        public StatusTypeDetailVisitHealthCare()
        {

        }
        #endregion

        #region Properties

        DataClassesStatusVisitHealthCareDataContext DRN = new DataClassesStatusVisitHealthCareDataContext(MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.InternalConnectionString);

        public bool InsertEntity(List<TBL_StatusTypeDetailVisitHealthCare> ListObj, ref string msgRet, ref long? IdRet)
        {
            try
            {
                foreach (TBL_StatusTypeDetailVisitHealthCare FieldList in ListObj)
                {
                    DRN.SP_StatusTypeDetailVisitHealthCareInsert(
                        ref IdRet,
                        FieldList.VisitHealthCare_Id,
                        FieldList.StatusTypeDetail_Id,
                        FieldList.ConfirmSet,
                        FieldList.Description,
                        FieldList.StartDateAlarm,
                        FieldList.FReserve1,
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

        public bool UpdateEntity(List<TBL_StatusTypeDetailVisitHealthCare> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_StatusTypeDetailVisitHealthCare FieldList in ListObj)
                {
                    DRN.SP_StatusTypeDetailVisitHealthCareUpdate(
                        FieldList.Id,
                        FieldList.VisitHealthCare_Id,
                        FieldList.StatusTypeDetail_Id,
                        FieldList.ConfirmSet,
                        FieldList.Description,
                        FieldList.StartDateAlarm,
                        FieldList.FReserve1,
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

        public bool DeleteEntity(List<TBL_StatusTypeDetailVisitHealthCare> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_StatusTypeDetailVisitHealthCare FieldList in ListObj)
                {
                    DRN.SP_StatusTypeDetailVisitHealthCareDelete(
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


        public List<VW_StatusTypeDetailVisitHealthCare> GetAllList(ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_StatusTypeDetailVisitHealthCares select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_StatusTypeDetailVisitHealthCare> GetAllListByID(long Id, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_StatusTypeDetailVisitHealthCares where d.Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_StatusTypeDetailVisitHealthCare> GetAllListByFilter(List<MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.Filter> filter, ref string msgRet)
        {
            try
            {
                var deleg = MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.GetExpression<VW_StatusTypeDetailVisitHealthCare>(filter).Compile();
                var filteredCollection = (from d in DRN.VW_StatusTypeDetailVisitHealthCares select d).Where(deleg);
                return filteredCollection.ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public int CountAll(List<VW_StatusTypeDetailVisitHealthCare> ListObj)
        {
            return ListObj.Count();
        }

        public List<VW_StatusTypeDetailVisitHealthCare> GetAllListByDetailRow(long Id, long DetailRowId, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_StatusTypeDetailVisitHealthCares where d.VisitHealthCare_Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_StatusTypeDetailVisitHealthCareReport> GetResid(long Id, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_StatusTypeDetailVisitHealthCareReports where d.VisitHealthCare_Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }


        public bool DeleteWithHealthCareId(long VisitHealthCare_Id, ref string msgRet)
        {
            try
            {
                DRN.SP_StatusTypeDetailVisitHealthCareDeleteWithHealthCareId(
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
