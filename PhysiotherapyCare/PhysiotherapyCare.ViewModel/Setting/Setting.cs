  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using PhysiotherapyCare.Model;
using MKH.Library.Clasess.Security;
using PhysiotherapyCare.Model.Setting;


namespace PhysiotherapyCare.ViewModel.Setting
{
    public class Setting : IInsUpDel<TBL_Setting, string>,
        IDataErrorInfo, INotifyPropertyChanged
    {
       
        #region Constructor

        public Setting()
        {

        }
        #endregion

        #region Properties

        DataClassesSettingDataContext DRN = new DataClassesSettingDataContext(MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.InternalConnectionString);

        public bool UpdateEntity(List<TBL_Setting> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_Setting FieldList in ListObj)
                {
                    DRN.SP_SettingUpdate(
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
                return (from d in DRN.TBL_Settings where d.Name == Name select d).Single().value;
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        
        public bool InsertEntity(List<TBL_Setting> ListObj, ref string msgRet, ref string idRet)
        {
            throw new NotImplementedException();
        }

        public bool DeleteEntity(List<TBL_Setting> ListObj, ref string msgRet)
        {
            throw new NotImplementedException();
        }

        public bool ClearCashForSystem(ref string msgRet)
        {
            try
            {
                DRN.SP_ClearCashForSystem(ref msgRet);
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
