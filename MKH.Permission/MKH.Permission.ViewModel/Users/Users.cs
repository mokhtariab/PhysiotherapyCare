using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using MKH.Permission.Model.Users;
using MKH.Permission.Model;
using MKH.Library.Clasess.Security;

namespace MKH.Permission.ViewModel.Users
{
    public class Users :
        IInsUpDel<TBL_User, int?>,
        IGetList<VW_User, int>,
        IDataErrorInfo, 
        INotifyPropertyChanged
    {
        #region Constructor
       
        public Users()
        {
            
        }
        #endregion

        #region Properties

        DataClassesUsersDataContext DRN = new DataClassesUsersDataContext(Security.MSSConfiguration_cls.Instance.InternalConnectionString);
        public bool InsertEntity(List<TBL_User> ListObj, ref string msgRet, ref int? idSet)
        {
            try
            {
                foreach (TBL_User FieldList in ListObj)
                {
                    DRN.SP_UsersInsert(
                        ref idSet,
                        FieldList.Name,
                        FieldList.Family,
                        FieldList.UserPic,
                        FieldList.NationalCode,
                        FieldList.BirthDate,
                        FieldList.TelNo,
                        FieldList.MobileNo,
                        FieldList.UserName,
                        MSSFunction_Cls.EncriptionText("1", MSSFunction_Cls.EncDecryption.PrivateEncDec), 
                        FieldList.DateActive, 
                        FieldList.DateInActive,
                        FieldList.Description,
                        FieldList.IsActive,
                        FieldList.IsAdmin,
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

        public bool UpdateEntity(List<TBL_User> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_User FieldList in ListObj)
                {
                    DRN.SP_UsersUpdate(
                        FieldList.Id,
                        FieldList.Name,
                        FieldList.Family,
                        FieldList.UserPic,
                        FieldList.NationalCode,
                        FieldList.BirthDate,
                        FieldList.TelNo,
                        FieldList.MobileNo,
                        FieldList.UserName,
                        FieldList.DateActive,
                        FieldList.DateInActive,
                        FieldList.Description,
                        FieldList.IsActive,
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

        public bool DeleteEntity(List<TBL_User> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_User FieldList in ListObj)
                {
                    if (FieldList.IsAdmin == true)
                    {
                        return false;
                    }
                    
                    DRN.SP_UsersDelete(
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

        public List<VW_User> GetAllList(ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_Users select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_User> GetAllListByID(int Id, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_Users where d.Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_User> GetAllListByFilter(List<MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.Filter> filter, ref string msgRet)
        {
            try
            {
                var deleg = MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.GetExpression<VW_User>(filter).Compile();
                var filteredCollection = (from d in DRN.VW_Users select d).Where(deleg);
                return filteredCollection.ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public int CountAll(List<VW_User> ListObj)
        {
            return ListObj.Count();
        }

        public bool UpdatePass(int UserId, ref string msgRet)
        {
            string StrPass = MSSFunction_Cls.EncriptionText("1", MSSFunction_Cls.EncDecryption.PrivateEncDec);
            if (StrPass == "errore") return false;
            try
            {
                TBL_User U = DRN.TBL_Users.First(h => h.Id == UserId);
                U.UserPassword = StrPass;
                DRN.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }

            return false;
        }
        
        public List<VW_User> GetAllListByDetailRow(int Id, long DetailRowId, ref string msgRet)
        {
            throw new NotImplementedException();
        }

        public List<TBL_User> GetAllListByIDPic(int Id, ref string msgRet)
        {
            try
            {
                return (from d in DRN.TBL_Users where d.Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_User> GetAllListByLogin(string userLogin, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_Users where d.UserName == userLogin select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public int  CountList()
        {
            return (from d in DRN.VW_Users select d).ToList().Count();
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
