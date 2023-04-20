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
    public class StatusPhysiotherapyTypeDetail : IInsUpDel<TBL_StatusPhysiotherapyTypeDetail, long?>,
        IGetList<VW_StatusPhysiotherapyTypeDetail, int>, IDataErrorInfo, INotifyPropertyChanged
    {
       
        #region Constructor

        public StatusPhysiotherapyTypeDetail()
        {

        }
        #endregion

        #region Properties

        DataClassesStatusPhysiotherapyDataContext DRN = new DataClassesStatusPhysiotherapyDataContext(MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.InternalConnectionString);

        public bool InsertEntity(List<TBL_StatusPhysiotherapyTypeDetail> ListObj, ref string msgRet, ref long? idSet)
        {
            try
            {
                foreach (TBL_StatusPhysiotherapyTypeDetail FieldList in ListObj)
                {
                    DRN.SP_StatusPhysiotherapyTypeDetailInsert(
                        FieldList.StatusPhysiotherapy_Id,
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

        public bool UpdateEntity(List<TBL_StatusPhysiotherapyTypeDetail> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_StatusPhysiotherapyTypeDetail FieldList in ListObj)
                {
                    DRN.SP_StatusPhysiotherapyTypeDetailUpdate(
                        FieldList.StatusPhysiotherapy_Id,
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

        public bool DeleteEntity(List<TBL_StatusPhysiotherapyTypeDetail> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_StatusPhysiotherapyTypeDetail FieldList in ListObj)
                {
                    DRN.SP_StatusPhysiotherapyTypeDetailDelete(
                        FieldList.StatusPhysiotherapy_Id,
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


        public List<VW_StatusPhysiotherapyTypeDetail> GetAllList(ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_StatusPhysiotherapyTypeDetails select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_StatusPhysiotherapyTypeDetail> GetAllListByID(int Id, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_StatusPhysiotherapyTypeDetails where d.StatusPhysiotherapy_Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_StatusPhysiotherapyTypeDetail> GetAllListByFilter(List<MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.Filter> filter, ref string msgRet)
        {
            try
            {
                var deleg = MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.GetExpression<VW_StatusPhysiotherapyTypeDetail>(filter).Compile();
                var filteredCollection = (from d in DRN.VW_StatusPhysiotherapyTypeDetails select d).Where(deleg);
                return filteredCollection.ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public int CountAll(List<VW_StatusPhysiotherapyTypeDetail> ListObj)
        {
            return ListObj.Count();
        }

        public List<VW_StatusPhysiotherapyTypeDetail> GetAllListByDetailRow(int Id, long DetailRowId, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_StatusPhysiotherapyTypeDetails where d.StatusPhysiotherapy_Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }


        public bool StatusPhysiotherapyTypeDetailDeleteWithId(long StatusPhysiotherapy_Id, ref string msgRet)
        {
            try
            {
                DRN.SP_StatusPhysiotherapyTypeDetailDeleteWithId(
                    StatusPhysiotherapy_Id,
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
