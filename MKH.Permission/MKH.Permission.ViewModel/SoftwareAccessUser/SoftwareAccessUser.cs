using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using MKH.Permission.Model.SoftwareAccessUser;
using MKH.Permission.Model;

namespace MKH.Permission.ViewModel.SoftwareAccessUser
{
    public class SoftwareAccessUser :
        IInsUpDel<TBL_SoftwareAccessUser, int?>,
        IGetList<VW_SoftwareAccessUser, int>,
        IDataErrorInfo, 
        INotifyPropertyChanged
    {
        #region Constructor
       
        public SoftwareAccessUser()
        {
            
        }
        #endregion

        #region Properties

        DataClassesSoftwareAccessUserDataContext DRN = new DataClassesSoftwareAccessUserDataContext(ViewModel.Security.MSSConfiguration_cls.Instance.InternalConnectionString);

        public bool InsertEntity(List<TBL_SoftwareAccessUser> ListObj, ref string msgRet, ref int? idRet)
        {
            try
            {
                foreach (TBL_SoftwareAccessUser FieldList in ListObj)
                {
                    DRN.SP_SoftwareAccessUserInsert(
                        FieldList.SoftwareAccess_Id,
                        FieldList.User_Id,
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

        public bool UpdateEntity(List<TBL_SoftwareAccessUser> ListObj, ref string msgRet)
        {
            throw new NotImplementedException();
        }
        public bool DeleteEntity(List<TBL_SoftwareAccessUser> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_SoftwareAccessUser FieldList in ListObj)
                {
                    DRN.SP_SoftwareAccessUserDelete(                        
                        FieldList.SoftwareAccess_Id,
                        FieldList.User_Id,
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

        public List<VW_SoftwareAccessUser> GetAllList(ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_SoftwareAccessUsers select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_SoftwareAccessUser> GetAllListByID(int Id, ref string msgRet)
        {
            throw new NotImplementedException();
        }

        public List<VW_SoftwareAccessUser> GetAllListByFilter(List<MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.Filter> filter, ref string msgRet)
        {
            try
            {
                var deleg = MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.GetExpression<VW_SoftwareAccessUser>(filter).Compile();
                var filteredCollection = (from d in DRN.VW_SoftwareAccessUsers select d).Where(deleg);
                return filteredCollection.ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public int CountAll(List<VW_SoftwareAccessUser> ListObj)
        {
            return ListObj.Count();
        }

        public List<VW_SoftwareAccessUser> GetAllListByID(int SoftwareAccess_Id, int User_Id, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_SoftwareAccessUsers where d.SoftwareAccess_Id == SoftwareAccess_Id && d.User_Id == User_Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }
        public List<VW_SoftwareAccessUser> GetAllListByDetailRow(int Id, long DetailRowId, ref string msgRet)
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
