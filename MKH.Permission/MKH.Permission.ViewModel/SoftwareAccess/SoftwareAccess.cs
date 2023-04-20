using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using MKH.Permission.Model.SoftwareAccess;
using MKH.Permission.Model;

namespace MKH.Permission.ViewModel.SoftwareAccess
{
    public class SoftwareAccess :
        IInsUpDel<TBL_SoftwareAccess, int?>,
        IGetList<VW_SoftwareAccess, int>,
        IDataErrorInfo, INotifyPropertyChanged
    {
        #region Constructor
       
        public SoftwareAccess()
        {
            
        }
        #endregion

        #region Properties

        DataClassesSoftwareAccessDataContext DRN = new DataClassesSoftwareAccessDataContext(Security.MSSConfiguration_cls.Instance.InternalConnectionString);
        public bool InsertEntity(List<TBL_SoftwareAccess> ListObj, ref string msgRet, ref int? idSet)
        {
            try
            {
                foreach (TBL_SoftwareAccess FieldList in ListObj)
                {
                    DRN.SP_SoftwareAccessInsert(
                        ref idSet,
                        FieldList.ParentId,
                        FieldList.ResourceNameFarsi, 
                        FieldList.ResourceName, 
                        FieldList.ResourceLevel, 
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

        public bool UpdateEntity(List<TBL_SoftwareAccess> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_SoftwareAccess FieldList in ListObj)
                {
                    DRN.SP_SoftwareAccessUpdate(
                        FieldList.Id,
                        FieldList.ParentId,
                        FieldList.ResourceNameFarsi,
                        FieldList.ResourceName,
                        FieldList.ResourceLevel,
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

        public bool DeleteEntity(List<TBL_SoftwareAccess> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_SoftwareAccess FieldList in ListObj)
                {
                    DRN.SP_SoftwareAccessDelete(
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


        public List<VW_SoftwareAccess> GetAllList(ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_SoftwareAccesses select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_SoftwareAccess> GetAllListByID(int Id, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_SoftwareAccesses where d.Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_SoftwareAccess> GetAllListByFilter(List<MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.Filter> filter, ref string msgRet)
        {
            try
            {
                var deleg = MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.GetExpression<VW_SoftwareAccess>(filter).Compile();
                var filteredCollection = (from d in DRN.VW_SoftwareAccesses select d).Where(deleg);
                return filteredCollection.ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_SoftwareAccess> GetAllListByDetailRow(int Id, long DetailRowId, ref string msgRet)
        {
            throw new NotImplementedException();
        }
        
        public int CountAll(List<VW_SoftwareAccess> ListObj)
        {
            return ListObj.Count();
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
