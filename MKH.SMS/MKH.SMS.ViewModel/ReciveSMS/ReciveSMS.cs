using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using MKH.SMS.Model.ReciveSMS;
using MKH.SMS.Model;


namespace MKH.SMS.ViewModel.ReciveSMS
{
    public class ReciveSMS : IInsUpDel<TBL_ReciveSM, long?>,
        IGetList<VW_ReciveSM, int>, IDataErrorInfo, INotifyPropertyChanged
    {
       
        #region Constructor

        public ReciveSMS()
        {

        }
        #endregion

        #region Properties

        DataClassesReciveSMSDataContext DRN = new DataClassesReciveSMSDataContext(MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.InternalConnectionString);

        public bool InsertEntity(List<TBL_ReciveSM> ListObj, ref string msgRet, ref long? idRet)
        {
            try
            {
                foreach (TBL_ReciveSM FieldList in ListObj)
                {
                    DRN.SP_ReciveSMSInsert(
                        ref idRet,
                        FieldList.MessageID,
                        FieldList.ReciverNumber,
                        FieldList.ReciverName,
                        FieldList.ReciverJob,
                        FieldList.ReciveDateTime,
                        FieldList.MessageText,
                        FieldList.RecipientNumber,
                        FieldList.SMS_Few,
                        FieldList.Description,
                        FieldList.Archive,
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

        public bool UpdateEntity(List<TBL_ReciveSM> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_ReciveSM FieldList in ListObj)
                {
                    DRN.SP_ReciveSMSUpdate(
                        FieldList.Id,
                        FieldList.MessageID,
                        FieldList.ReciverNumber,
                        FieldList.ReciverName,
                        FieldList.ReciverJob,
                        FieldList.ReciveDateTime,
                        FieldList.MessageText,
                        FieldList.RecipientNumber,
                        FieldList.SMS_Few,
                        FieldList.Description,
                        FieldList.Archive,
                        FieldList.User_Id,
                        FieldList.ChangeDateTime,
                        ref msgRet
                        );
                }
                DRN. SubmitChanges();

               

                return true;
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return false;
        }

        public bool DeleteEntity(List<TBL_ReciveSM> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_ReciveSM FieldList in ListObj)
                {
                    DRN.SP_ReciveSMSDelete(
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


        public List<VW_ReciveSM> GetAllList(ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_ReciveSMs select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_ReciveSM> GetAllListByID(int Id, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_ReciveSMs where d.Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_ReciveSM> GetAllListByFilter(List<MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.Filter> filter, ref string msgRet)
        {
            try
            {
                var deleg = MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.GetExpression<VW_ReciveSM>(filter).Compile();
                var filteredCollection = (from d in DRN.VW_ReciveSMs select d).Where(deleg);
                return filteredCollection.ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public int CountAll(List<VW_ReciveSM> ListObj)
        {
            return ListObj.Count();
        }

        public List<VW_ReciveSM> GetAllListByDetailRow(int Id, long DetailRowId, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_ReciveSMs where d.Id == Id select d).ToList();
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
