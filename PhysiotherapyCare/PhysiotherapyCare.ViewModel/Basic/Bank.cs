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
    public class Bank : IInsUpDel<TBL_Bank, short?>,
        IGetList<VW_Bank, short>, IDataErrorInfo, INotifyPropertyChanged
    {
       
        #region Constructor

        public Bank()
        {

        }
        #endregion

        #region Properties

        DataClassesBaseDataContext DRN = new DataClassesBaseDataContext(MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.InternalConnectionString);

        public bool InsertEntity(List<TBL_Bank> ListObj, ref string msgRet, ref short? idSet)
        {
            try
            {
                foreach (TBL_Bank FieldList in ListObj)
                {
                    DRN.SP_BankInsert(
                        ref idSet,
                        FieldList.TitleName,
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

        public bool UpdateEntity(List<TBL_Bank> ListObj, ref string msgRet)
        {
    
            try
            {
                foreach (TBL_Bank FieldList in ListObj)
                {
                    DRN.SP_BankUpdate(
                       FieldList.Id,
                        FieldList.TitleName,
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

        public bool DeleteEntity(List<TBL_Bank> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_Bank FieldList in ListObj)
                {
                    DRN.SP_BankDelete(
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


        public List<VW_Bank> GetAllList(ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_Banks select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_Bank> GetAllListByID(short Id, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_Banks where d.Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_Bank> GetAllListByFilter(List<MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.Filter> filter, ref string msgRet)
        {
            try
            {
                var deleg = MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.GetExpression<VW_Bank>(filter).Compile();
                var filteredCollection = (from d in DRN.VW_Banks select d).Where(deleg);
                return filteredCollection.ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public int CountAll(List<VW_Bank> ListObj)
        {
            return ListObj.Count();
        }

        public List<VW_Bank> GetAllListByDetailRow(short Id, long DetailRowId, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_Banks where d.Id == Id select d).ToList();
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
