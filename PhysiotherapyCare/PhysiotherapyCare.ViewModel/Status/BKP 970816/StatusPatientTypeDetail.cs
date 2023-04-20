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
    public class StatusPatientTypeDetail : IInsUpDel<TBL_StatusPatientTypeDetail, long?>,
        IGetList<VW_StatusPatientTypeDetail, int>, IDataErrorInfo, INotifyPropertyChanged
    {
       
        #region Constructor

        public StatusPatientTypeDetail()
        {

        }
        #endregion

        #region Properties

        DataClassesStatusPatientDataContext DRN = new DataClassesStatusPatientDataContext(MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.InternalConnectionString);

        public bool InsertEntity(List<TBL_StatusPatientTypeDetail> ListObj, ref string msgRet, ref long? idSet)
        {
            try
            {
                foreach (TBL_StatusPatientTypeDetail FieldList in ListObj)
                {
                    DRN.SP_StatusPatientTypeDetailInsert(
                        FieldList.StatusPatient_Id,
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

        public bool UpdateEntity(List<TBL_StatusPatientTypeDetail> ListObj, ref string msgRet)
        {
            int Id = 0;
            try
            {
                foreach (TBL_StatusPatientTypeDetail FieldList in ListObj)
                {
                    DRN.SP_StatusPatientTypeDetailUpdate(
                        FieldList.StatusPatient_Id,
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

        public bool DeleteEntity(List<TBL_StatusPatientTypeDetail> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_StatusPatientTypeDetail FieldList in ListObj)
                {
                    DRN.SP_StatusPatientTypeDetailDelete(
                        FieldList.StatusPatient_Id,
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


        public List<VW_StatusPatientTypeDetail> GetAllList(ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_StatusPatientTypeDetails select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_StatusPatientTypeDetail> GetAllListByID(int Id, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_StatusPatientTypeDetails where d.StatusPatient_Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_StatusPatientTypeDetail> GetAllListByFilter(List<MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.Filter> filter, ref string msgRet)
        {
            try
            {
                var deleg = MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.GetExpression<VW_StatusPatientTypeDetail>(filter).Compile();
                var filteredCollection = (from d in DRN.VW_StatusPatientTypeDetails select d).Where(deleg);
                return filteredCollection.ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public int CountAll(List<VW_StatusPatientTypeDetail> ListObj)
        {
            return ListObj.Count();
        }

        public List<VW_StatusPatientTypeDetail> GetAllListByDetailRow(int Id, long DetailRowId, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_StatusPatientTypeDetails where d.StatusPatient_Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public bool StatusPatientTypeDetailDeleteWithId(long StatusPatient_Id, ref string msgRet)
        {
            try
            {
                DRN.SP_StatusPatientTypeDetailDeleteWithId(
                    StatusPatient_Id,
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
