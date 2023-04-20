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
    public class StatusTypeDetailCare : IInsUpDel<TBL_StatusTypeDetailCare, long?>,
        IGetList<VW_StatusTypeDetailCare, long>, IDataErrorInfo, INotifyPropertyChanged
    {
       
        #region Constructor

        public StatusTypeDetailCare()
        {

        }
        #endregion

        #region Properties

        DataClassesStatusCareDataContext DRN = new DataClassesStatusCareDataContext(MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.InternalConnectionString);

        public bool InsertEntity(List<TBL_StatusTypeDetailCare> ListObj, ref string msgRet, ref long? IdRet)
        {
            try
            {
                foreach (TBL_StatusTypeDetailCare FieldList in ListObj)
                {
                    DRN.SP_StatusTypeDetailCareInsert(
                        ref IdRet,
                        FieldList.VisitPatientCare_Id,
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

        public bool UpdateEntity(List<TBL_StatusTypeDetailCare> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_StatusTypeDetailCare FieldList in ListObj)
                {
                    DRN.SP_StatusTypeDetailCareUpdate(
                        FieldList.Id,
                        FieldList.VisitPatientCare_Id,
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

        public bool DeleteEntity(List<TBL_StatusTypeDetailCare> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_StatusTypeDetailCare FieldList in ListObj)
                {
                    DRN.SP_StatusTypeDetailCareDelete(
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


        public List<VW_StatusTypeDetailCare> GetAllList(ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_StatusTypeDetailCares select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_StatusTypeDetailCare> GetAllListByID(long Id, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_StatusTypeDetailCares where d.Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_StatusTypeDetailCare> GetAllListByFilter(List<MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.Filter> filter, ref string msgRet)
        {
            try
            {
                var deleg = MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.GetExpression<VW_StatusTypeDetailCare>(filter).Compile();
                var filteredCollection = (from d in DRN.VW_StatusTypeDetailCares select d).Where(deleg);
                return filteredCollection.ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public int CountAll(List<VW_StatusTypeDetailCare> ListObj)
        {
            return ListObj.Count();
        }

        public List<VW_StatusTypeDetailCare> GetAllListByDetailRow(long Id, long DetailRowId, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_StatusTypeDetailCares where d.VisitPatientCare_Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_StatusTypeDetailCareReport> GetResid(long Id, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_StatusTypeDetailCareReports where d.VisitPatientCare_Id == Id select d).ToList(); 
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }


        public bool DeleteWithCareId(long VisitPatientCare_Id, ref string msgRet)
        {
            try
            {
                DRN.SP_StatusTypeDetailCareDeleteWithCareId(
                    VisitPatientCare_Id,
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
