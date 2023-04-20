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
    public class StatusCare : IInsUpDel<TBL_StatusCare, long?>,
        IGetList<VW_StatusCare, long>, IDataErrorInfo, INotifyPropertyChanged
    {
       
        #region Constructor

        public StatusCare()
        {

        }
        #endregion

        #region Properties

        DataClassesStatusCareDataContext DRN = new DataClassesStatusCareDataContext(MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.InternalConnectionString);

        public bool InsertEntity(List<TBL_StatusCare> ListObj, ref string msgRet, ref long? IdRet)
        {
            try
            {
                foreach (TBL_StatusCare FieldList in ListObj)
                {
                    DRN.SP_StatusCareInsert(
                        ref IdRet,
                        FieldList.VisitPatientCare_Id,
                        FieldList.StatusType_Id,
                        FieldList.VisitPatientCareComment,
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

        public bool UpdateEntity(List<TBL_StatusCare> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_StatusCare FieldList in ListObj)
                {
                    DRN.SP_StatusCareUpdate(
                        FieldList.Id,
                        FieldList.VisitPatientCare_Id,
                        FieldList.StatusType_Id,
                        FieldList.VisitPatientCareComment,
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

        public bool DeleteEntity(List<TBL_StatusCare> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_StatusCare FieldList in ListObj)
                {
                    DRN.SP_StatusCareDelete(
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


        public List<VW_StatusCare> GetAllList(ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_StatusCares select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_StatusCare> GetAllListByID(long Id, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_StatusCares where d.Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_StatusCare> GetAllListByFilter(List<MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.Filter> filter, ref string msgRet)
        {
            try
            {
                var deleg = MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.GetExpression<VW_StatusCare>(filter).Compile();
                var filteredCollection = (from d in DRN.VW_StatusCares select d).Where(deleg);
                return filteredCollection.ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public int CountAll(List<VW_StatusCare> ListObj)
        {
            return ListObj.Count();
        }

        public List<VW_StatusCare> GetAllListByDetailRow(long Id, long DetailRowId, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_StatusCares where d.VisitPatientCare_Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_StatusCareReport> GetResid(long Id, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_StatusCareReports where d.VisitPatientCare_Id == Id select d).ToList(); 
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
