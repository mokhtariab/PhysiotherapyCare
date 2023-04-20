using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using MKH.SMS.Model.SendSMS;
using MKH.SMS.Model;


namespace MKH.SMS.ViewModel.SendSMS
{
    public class SendSMS : IInsUpDel<TBL_SendSM, long?>,
        IGetList<VW_SendSM, int>, IDataErrorInfo, INotifyPropertyChanged
    {
       
        #region Constructor

        public SendSMS()
        {

        }
        #endregion

        #region Properties

        DataClassesSendSMSDataContext DRN = new DataClassesSendSMSDataContext(MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.InternalConnectionString);

        public bool InsertEntity(List<TBL_SendSM> ListObj, ref string msgRet, ref long? idRet)
        {
            try
            {
                foreach (TBL_SendSM FieldList in ListObj)
                {
                    DRN.SP_SendSMSInsert(
                        ref idRet,
                        FieldList.MessageID,
                        FieldList.MobileNo,
                        FieldList.SenderName,
                        FieldList.SenderJob,
                        FieldList.SendDateTime,
                        FieldList.MessageText,
                        FieldList.Status,
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

        public bool UpdateEntity(List<TBL_SendSM> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_SendSM FieldList in ListObj)
                {
                    DRN.SP_SendSMSUpdate(
                        FieldList.Id,
                        FieldList.MessageID,
                        FieldList.MobileNo,
                        FieldList.SenderName,
                        FieldList.SenderJob,
                        FieldList.SendDateTime,
                        FieldList.MessageText,
                        FieldList.Status,
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

        public bool DeleteEntity(List<TBL_SendSM> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_SendSM FieldList in ListObj)
                {
                    DRN.SP_SendSMSDelete(
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


        public bool UpdateStatus(long Id, string Status, ref string msgRet)
        {
            try
            {
                DRN.SP_SendSMSUpdateStatus(
                    Id,
                    Status,
                    ref msgRet
                    );


                return true;
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return false;
        }


        public List<VW_SendSM> GetAllList(ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_SendSMs select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_SendSM> GetAllListByID(int Id, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_SendSMs where d.Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_SendSM> GetAllListByFilter(List<MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.Filter> filter, ref string msgRet)
        {
            try
            {
                var deleg = MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.GetExpression<VW_SendSM>(filter).Compile();
                var filteredCollection = (from d in DRN.VW_SendSMs select d).Where(deleg);
                return filteredCollection.ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public int CountAll(List<VW_SendSM> ListObj)
        {
            return ListObj.Count();
        }

        public List<VW_SendSM> GetAllListByDetailRow(int Id, long DetailRowId, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_SendSMs where d.Id == Id select d).ToList();
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
