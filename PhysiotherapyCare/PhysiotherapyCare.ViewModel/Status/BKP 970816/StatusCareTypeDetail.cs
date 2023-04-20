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
    public class StatusCareTypeDetail : IInsUpDel<TBL_StatusCareTypeDetail, long?>,
        IGetList<VW_StatusCareTypeDetail, int>, IDataErrorInfo, INotifyPropertyChanged
    {
       
        #region Constructor

        public StatusCareTypeDetail()
        {

        }
        #endregion

        #region Properties

        DataClassesStatusCareDataContext DRN = new DataClassesStatusCareDataContext(MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.InternalConnectionString);

        public bool InsertEntity(List<TBL_StatusCareTypeDetail> ListObj, ref string msgRet, ref long? idSet)
        {
            try
            {
                foreach (TBL_StatusCareTypeDetail FieldList in ListObj)
                {
                    DRN.SP_StatusCareTypeDetailInsert(
                        FieldList.StatusCare_Id,
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

        public bool UpdateEntity(List<TBL_StatusCareTypeDetail> ListObj, ref string msgRet)
        {
            int Id = 0;
            try
            {
                foreach (TBL_StatusCareTypeDetail FieldList in ListObj)
                {
                    DRN.SP_StatusCareTypeDetailUpdate(
                        FieldList.StatusCare_Id,
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

        public bool DeleteEntity(List<TBL_StatusCareTypeDetail> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_StatusCareTypeDetail FieldList in ListObj)
                {
                    DRN.SP_StatusCareTypeDetailDelete(
                        FieldList.StatusCare_Id,
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


        public List<VW_StatusCareTypeDetail> GetAllList(ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_StatusCareTypeDetails select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_StatusCareTypeDetail> GetAllListByID(int Id, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_StatusCareTypeDetails where d.StatusCare_Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_StatusCareTypeDetail> GetAllListByFilter(List<MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.Filter> filter, ref string msgRet)
        {
            try
            {
                var deleg = MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.GetExpression<VW_StatusCareTypeDetail>(filter).Compile();
                var filteredCollection = (from d in DRN.VW_StatusCareTypeDetails select d).Where(deleg);
                return filteredCollection.ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public int CountAll(List<VW_StatusCareTypeDetail> ListObj)
        {
            return ListObj.Count();
        }

        public List<VW_StatusCareTypeDetail> GetAllListByDetailRow(int Id, long DetailRowId, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_StatusCareTypeDetails where d.StatusCare_Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }


        public bool StatusCareTypeDetailDeleteWithId(long StatusCare_Id, ref string msgRet)
        {
            try
            {
                DRN.SP_StatusCareTypeDetailDeleteWithId(
                    StatusCare_Id,
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
