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
    public class StatusVisitHealthCare : IInsUpDel<TBL_StatusVisitHealthCare, long?>,
        IGetList<VW_StatusVisitHealthCare, long>, IDataErrorInfo, INotifyPropertyChanged
    {
       
        #region Constructor

        public StatusVisitHealthCare()
        {

        }
        #endregion

        #region Properties

        DataClassesStatusVisitHealthCareDataContext DRN = new DataClassesStatusVisitHealthCareDataContext(MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.InternalConnectionString);

        public bool InsertEntity(List<TBL_StatusVisitHealthCare> ListObj, ref string msgRet, ref long? IdRet)
        {
            try
            {
                foreach (TBL_StatusVisitHealthCare FieldList in ListObj)
                {
                    DRN.SP_StatusVisitHealthCareInsert(
                        ref IdRet,
                        FieldList.VisitHealthCare_Id,
                        FieldList.StatusType_Id,
                        FieldList.VisitHealthCareComment,
                        FieldList.StartDateAlarm,
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

        public bool UpdateEntity(List<TBL_StatusVisitHealthCare> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_StatusVisitHealthCare FieldList in ListObj)
                {
                    DRN.SP_StatusVisitHealthCareUpdate(
                        FieldList.Id,
                        FieldList.VisitHealthCare_Id,
                        FieldList.StatusType_Id,
                        FieldList.VisitHealthCareComment,
                        FieldList.StartDateAlarm,
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

        public bool DeleteEntity(List<TBL_StatusVisitHealthCare> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_StatusVisitHealthCare FieldList in ListObj)
                {
                    DRN.SP_StatusVisitHealthCareDelete(
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


        public List<VW_StatusVisitHealthCare> GetAllList(ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_StatusVisitHealthCares select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_StatusVisitHealthCare> GetAllListByID(long Id, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_StatusVisitHealthCares where d.Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_StatusVisitHealthCare> GetAllListByFilter(List<MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.Filter> filter, ref string msgRet)
        {
            try
            {
                var deleg = MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.GetExpression<VW_StatusVisitHealthCare>(filter).Compile();
                var filteredCollection = (from d in DRN.VW_StatusVisitHealthCares select d).Where(deleg);
                return filteredCollection.ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public int CountAll(List<VW_StatusVisitHealthCare> ListObj)
        {
            return ListObj.Count();
        }

        public List<VW_StatusVisitHealthCare> GetAllListByDetailRow(long Id, long DetailRowId, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_StatusVisitHealthCares where d.VisitHealthCare_Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_StatusVisitHealthCareReport> GetResid(long Id, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_StatusVisitHealthCareReports where d.VisitHealthCare_Id == Id select d).ToList();
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
