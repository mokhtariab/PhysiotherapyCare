  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using MKH.SMS.Model;
using MKH.Library.Clasess.Security;
using MKH.SMS.Model.SettingSMS;


namespace MKH.SMS.ViewModel.SettingSMS
{
    public class SettingSMS : IInsUpDel<TBL_SettingSM, string>,
        IDataErrorInfo, INotifyPropertyChanged
    {
       
        #region Constructor

        public SettingSMS()
        {

        }
        #endregion

        #region Properties

        DataClassesSettingSMSDataContext DRN = new DataClassesSettingSMSDataContext(MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.InternalConnectionString);

        public bool UpdateEntity(List<TBL_SettingSM> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_SettingSM FieldList in ListObj)
                {
                    DRN.SP_SettingSMSUpdate(
                        FieldList.Name,
                        FieldList.value,
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

        public string GetAllValue(string Name, ref string msgRet)
        {
            try
            {
                return (from d in DRN.TBL_SettingSMs where d.Name == Name select d).Single().value;
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        
        public bool InsertEntity(List<TBL_SettingSM> ListObj, ref string msgRet, ref string idRet)
        {
            throw new NotImplementedException();
        }

        public bool DeleteEntity(List<TBL_SettingSM> ListObj, ref string msgRet)
        {
            throw new NotImplementedException();
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
