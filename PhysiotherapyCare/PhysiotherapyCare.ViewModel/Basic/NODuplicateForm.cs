  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using PhysiotherapyCare.Model;
using MKH.Library.Clasess.Security;
using PhysiotherapyCare.Model.Basic;

namespace PhysiotherapyCare.ViewModel.Basic
{
    public class NODuplicateForm : 
        IGetList<TBL_NODuplicateForm, short>, IDataErrorInfo, INotifyPropertyChanged
    {
       
        #region Constructor

        public NODuplicateForm()
        {

        }
        #endregion

        #region Properties

        DataClassesBaseDataContext DRN = new DataClassesBaseDataContext(MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.InternalConnectionString);


        public bool InsertEntity(string FormName, string Id, ref string msgRet)
        {
            try
            {
                DRN.SP_NODuplicateFormInsert(
                    FormName,
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


        public bool DeleteEntity(string FormName, string Id, ref string msgRet)
        {
            try
            {
                DRN.SP_NODuplicateFormDelete(
                    FormName,
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


        public List<TBL_NODuplicateForm> GetAllList(ref string msgRet)
        {
            try
            {
                return (from d in DRN.TBL_NODuplicateForms select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<TBL_NODuplicateForm> GetAllListByIDForm(string FormName, string Id, ref string msgRet)
        {
            try
            {
                return (from d in DRN.TBL_NODuplicateForms where d.Id == Id && d.FormName == FormName select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<TBL_NODuplicateForm> GetAllListByFilter(List<MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.Filter> filter, ref string msgRet)
        {
            try
            {
                var deleg = MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.GetExpression<TBL_NODuplicateForm>(filter).Compile();
                var filteredCollection = (from d in DRN.TBL_NODuplicateForms select d).Where(deleg);
                return filteredCollection.ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public int CountAll(List<TBL_NODuplicateForm> ListObj)
        {
            return ListObj.Count();
        }

        public bool CheckNODuplicateForm(string FormName, string Id, ref string msgRet)
        {
            try
            {
                return DRN.CheckNODuplicateForm(FormName, Id).Value;
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return true;
        }


        public List<TBL_NODuplicateForm> GetAllListByID(short Id, ref string msgRet)
        {
            throw new NotImplementedException();
        }

        public List<TBL_NODuplicateForm> GetAllListByDetailRow(short Id, long DetailRowId, ref string msgRet)
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
