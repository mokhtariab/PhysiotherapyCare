  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using PhysiotherapyCare.Model;
using MKH.Library.Clasess.Security;
using PhysiotherapyCare.Model.VisitHealthCare;


namespace PhysiotherapyCare.ViewModel.VisitHealthCare
{
    public class ServiceTypeDsc : IInsUpDel<TBL_ServiceTypeDsc, int?>,
        IGetList<VW_ServiceTypeDsc,int>, IDataErrorInfo, INotifyPropertyChanged
    {
       
        #region Constructor

        public ServiceTypeDsc()
        {

        }
        #endregion

        #region Properties

        DataClassesVisitHealthCareBaseDataContext DRN = new DataClassesVisitHealthCareBaseDataContext(MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.InternalConnectionString);

        public bool InsertEntity(List<TBL_ServiceTypeDsc> ListObj, ref string msgRet, ref int? idRet)
        {
            try
            {
                foreach (TBL_ServiceTypeDsc FieldList in ListObj)
                {
                    DRN.SP_ServiceTypeDscInsert(
                        ref idRet,
                        FieldList.ServiceType_Id,
                        FieldList.TitleName,
                        FieldList.PriceType,
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

        public bool UpdateEntity(List<TBL_ServiceTypeDsc> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_ServiceTypeDsc FieldList in ListObj)
                {
                    DRN.SP_ServiceTypeDscUpdate(
                        FieldList.Id,
                        FieldList.ServiceType_Id,
                        FieldList.TitleName,
                        FieldList.PriceType,
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

        public bool DeleteEntity(List<TBL_ServiceTypeDsc> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_ServiceTypeDsc FieldList in ListObj)
                {
                    DRN.SP_ServiceTypeDscDelete(
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


        public List<VW_ServiceTypeDsc> GetAllList(ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_ServiceTypeDscs select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_ServiceTypeDsc> GetAllListByID(int Id, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_ServiceTypeDscs where d.Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_ServiceTypeDsc> GetAllListByFilter(List<MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.Filter> filter, ref string msgRet)
        {
            try
            {
                var deleg = MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.GetExpression<VW_ServiceTypeDsc>(filter).Compile();
                var filteredCollection = (from d in DRN.VW_ServiceTypeDscs select d).Where(deleg);
                return filteredCollection.ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public int CountAll(List<VW_ServiceTypeDsc> ListObj)
        {
            return ListObj.Count();
        }

        public List<VW_ServiceTypeDsc> GetAllListByDetailRow(int Id, long DetailRowId, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_ServiceTypeDscs where d.Id == Id select d).ToList();
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
