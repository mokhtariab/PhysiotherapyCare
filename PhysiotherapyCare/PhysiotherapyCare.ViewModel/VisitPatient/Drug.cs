  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using PhysiotherapyCare.Model;
using MKH.Library.Clasess.Security;
using PhysiotherapyCare.Model.VisitPatient;

namespace PhysiotherapyCare.ViewModel.VisitPatient
{
    public class Drug : IInsUpDel<TBL_Drug, int?>,
        IGetList<VW_Drug, int>, IDataErrorInfo, INotifyPropertyChanged
    {
       
        #region Constructor

        public Drug()
        {

        }
        #endregion

        #region Properties

        DataClassesVisitPatientBaseDataContext DRN = new DataClassesVisitPatientBaseDataContext(MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.InternalConnectionString);

        public bool InsertEntity(List<TBL_Drug> ListObj, ref string msgRet, ref int? idSet)
        {
            try
            {
                foreach (TBL_Drug FieldList in ListObj)
                {
                    DRN.SP_DrugInsert(
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

        public bool UpdateEntity(List<TBL_Drug> ListObj, ref string msgRet)
        {

            try
            {
                foreach (TBL_Drug FieldList in ListObj)
                {
                    DRN.SP_DrugUpdate(
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

        public bool DeleteEntity(List<TBL_Drug> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_Drug FieldList in ListObj)
                {
                    DRN.SP_DrugDelete(
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


        public List<VW_Drug> GetAllList(ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_Drugs select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }
        
        

        public List<VW_Drug> GetAllListByID(int Id, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_Drugs where d.Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_Drug> GetAllListByFilter(List<MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.Filter> filter, ref string msgRet)
        {
            try
            {
                var deleg = MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.GetExpression<VW_Drug>(filter).Compile();
                var filteredCollection = (from d in DRN.VW_Drugs select d).Where(deleg);
                return filteredCollection.ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public int CountAll(List<VW_Drug> ListObj)
        {
            return ListObj.Count();
        }

        public List<VW_Drug> GetAllListByDetailRow(int Id, long DetailRowId, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_Drugs where d.Id == Id select d).ToList();
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
