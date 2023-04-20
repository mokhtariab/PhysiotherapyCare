  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using PhysiotherapyCare.Model;
using MKH.Library.Clasess.Security;
using PhysiotherapyCare.Model.Status;

namespace PhysiotherapyCare.ViewModel.Status
{
    public class StatusTypeDetail : IInsUpDel<TBL_StatusTypeDetail, int?>,
        IGetList<VW_StatusTypeDetail, int>, IDataErrorInfo, INotifyPropertyChanged
    {
       
        #region Constructor

        public StatusTypeDetail()
        {

        }
        #endregion

        #region Properties

        DataClassesStatusTypeDataContext DRN = new DataClassesStatusTypeDataContext(MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.InternalConnectionString);

        public bool InsertEntity(List<TBL_StatusTypeDetail> ListObj, ref string msgRet, ref int? idSet)
        {
            try
            {
                foreach (TBL_StatusTypeDetail FieldList in ListObj)
                {
                    DRN.SP_StatusTypeDetailInsert(
                        ref idSet,
                        FieldList.StatusType_Id,
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

        public bool UpdateEntity(List<TBL_StatusTypeDetail> ListObj, ref string msgRet)
        {
            int Id = 0;
            try
            {
                foreach (TBL_StatusTypeDetail FieldList in ListObj)
                {
                    DRN.SP_StatusTypeDetailUpdate(
                       FieldList.Id,
                        FieldList.StatusType_Id,
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

        public bool DeleteEntity(List<TBL_StatusTypeDetail> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_StatusTypeDetail FieldList in ListObj)
                {
                    DRN.SP_StatusTypeDetailDelete(
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


        public List<VW_StatusTypeDetail> GetAllList(ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_StatusTypeDetails select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_StatusTypeDetail> GetAllListByID(int Id, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_StatusTypeDetails where d.Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_StatusTypeDetail> GetAllListByFilter(List<MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.Filter> filter, ref string msgRet)
        {
            try
            {
                var deleg = MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.GetExpression<VW_StatusTypeDetail>(filter).Compile();
                var filteredCollection = (from d in DRN.VW_StatusTypeDetails select d).Where(deleg);
                return filteredCollection.ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public int CountAll(List<VW_StatusTypeDetail> ListObj)
        {
            return ListObj.Count();
        }

        public List<VW_StatusTypeDetail> GetAllListByDetailRow(int Id, long DetailRowId, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_StatusTypeDetails where d.StatusType_Id == Id select d).ToList();
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
