using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using MKH.SMS.Model.Key;
using MKH.SMS.Model;


namespace MKH.SMS.ViewModel.Key
{
    public class Key : IInsUpDel<TBL_Key, int?>,
        IGetList<VW_Key, int>, IDataErrorInfo, INotifyPropertyChanged
    {
       
        #region Constructor

        public Key()
        {

        }
        #endregion

        #region Properties

        DataClassesKeyDataContext DRN = new DataClassesKeyDataContext(MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.InternalConnectionString);

        public bool InsertEntity(List<TBL_Key> ListObj, ref string msgRet, ref int? idRet)
        {
            throw new NotImplementedException();
        }

        public bool DeleteEntity(List<TBL_Key> ListObj, ref string msgRet)
        {
            throw new NotImplementedException();
        }


        public bool InsertEntitySet(string TitleName, ref string msgRet)
        {
            int? idret = 0;
            try
            {
                DRN.SP_KeyInsert(
                    idret,
                    TitleName,
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

        public bool UpdateEntity(List<TBL_Key> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_Key FieldList in ListObj)
                {
                    DRN.SP_KeyUpdate(
                        FieldList.Id,
                        FieldList.TitleName,
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

        public bool DeleteEntitySet(int Id, ref string msgRet)
        {
            try
            {
                DRN.SP_KeyDelete(
                    Id,
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


        public List<VW_Key> GetAllList(ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_Keys select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_Key> GetAllListByID(int Id, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_Keys where d.Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_Key> GetAllListByFilter(List<MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.Filter> filter, ref string msgRet)
        {
            try
            {
                var deleg = MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.GetExpression<VW_Key>(filter).Compile();
                var filteredCollection = (from d in DRN.VW_Keys select d).Where(deleg);
                return filteredCollection.ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public int CountAll(List<VW_Key> ListObj)
        {
            return ListObj.Count();
        }

        public List<VW_Key> GetAllListByDetailRow(int Id, long DetailRowId, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_Keys where d.Id == Id select d).ToList();
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
