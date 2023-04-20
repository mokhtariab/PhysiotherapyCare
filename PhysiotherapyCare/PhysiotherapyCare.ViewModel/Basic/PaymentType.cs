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
    public class PaymentType : 
        IGetList<VW_PaymentType, short>, IDataErrorInfo, INotifyPropertyChanged
    {
       
        #region Constructor

        public PaymentType()
        {

        }
        #endregion

        #region Properties

        DataClassesBaseDataContext DRN = new DataClassesBaseDataContext(MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.InternalConnectionString);

        
        public List<VW_PaymentType> GetAllList(ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_PaymentTypes select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_PaymentType> GetAllListByID(short Id, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_PaymentTypes where d.Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_PaymentType> GetAllListByFilter(List<MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.Filter> filter, ref string msgRet)
        {
            try
            {
                var deleg = MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.GetExpression<VW_PaymentType>(filter).Compile();
                var filteredCollection = (from d in DRN.VW_PaymentTypes select d).Where(deleg);
                return filteredCollection.ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public int CountAll(List<VW_PaymentType> ListObj)
        {
            return ListObj.Count();
        }

        public List<VW_PaymentType> GetAllListByDetailRow(short Id, long DetailRowId, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_PaymentTypes where d.Id == Id select d).ToList();
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
