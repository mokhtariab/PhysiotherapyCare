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
    public class StatusVisitHealthCareTypeDetail : IInsUpDel<TBL_StatusVisitHealthCareTypeDetail, long?>,
        IGetList<VW_StatusVisitHealthCareTypeDetail, int>, IDataErrorInfo, INotifyPropertyChanged
    {
       
        #region Constructor

        public StatusVisitHealthCareTypeDetail()
        {

        }
        #endregion

        #region Properties

        DataClassesStatusVisitHealthCareDataContext DRN = new DataClassesStatusVisitHealthCareDataContext(MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.InternalConnectionString);

        public bool InsertEntity(List<TBL_StatusVisitHealthCareTypeDetail> ListObj, ref string msgRet, ref long? idSet)
        {
            try
            {
                foreach (TBL_StatusVisitHealthCareTypeDetail FieldList in ListObj)
                {
                    DRN.SP_StatusVisitHealthCareTypeDetailInsert(
                        FieldList.StatusVisitHealthCare_Id,
                        FieldList.StatusTypeDetail_Id,
                        FieldList.ConfirmSet,
                        FieldList.Description,
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

        public bool UpdateEntity(List<TBL_StatusVisitHealthCareTypeDetail> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_StatusVisitHealthCareTypeDetail FieldList in ListObj)
                {
                    DRN.SP_StatusVisitHealthCareTypeDetailUpdate(
                        FieldList.StatusVisitHealthCare_Id,
                        FieldList.StatusTypeDetail_Id,
                        FieldList.ConfirmSet,
                        FieldList.Description,
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

        public bool DeleteEntity(List<TBL_StatusVisitHealthCareTypeDetail> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_StatusVisitHealthCareTypeDetail FieldList in ListObj)
                {
                    DRN.SP_StatusVisitHealthCareTypeDetailDelete(
                        FieldList.StatusVisitHealthCare_Id,
                        FieldList.StatusTypeDetail_Id,
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


        public List<VW_StatusVisitHealthCareTypeDetail> GetAllList(ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_StatusVisitHealthCareTypeDetails select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_StatusVisitHealthCareTypeDetail> GetAllListByID(int Id, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_StatusVisitHealthCareTypeDetails where d.StatusVisitHealthCare_Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_StatusVisitHealthCareTypeDetail> GetAllListByFilter(List<MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.Filter> filter, ref string msgRet)
        {
            try
            {
                var deleg = MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.GetExpression<VW_StatusVisitHealthCareTypeDetail>(filter).Compile();
                var filteredCollection = (from d in DRN.VW_StatusVisitHealthCareTypeDetails select d).Where(deleg);
                return filteredCollection.ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public int CountAll(List<VW_StatusVisitHealthCareTypeDetail> ListObj)
        {
            return ListObj.Count();
        }

        public List<VW_StatusVisitHealthCareTypeDetail> GetAllListByDetailRow(int Id, long DetailRowId, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_StatusVisitHealthCareTypeDetails where d.StatusVisitHealthCare_Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public bool StatusVisitHealthCareTypeDetailDeleteWithId(long StatusVisitHealthCare_Id, ref string msgRet)
        {
            try
            {
                DRN.SP_StatusVisitHealthCareTypeDetailDeleteWithId(
                    StatusVisitHealthCare_Id,
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
