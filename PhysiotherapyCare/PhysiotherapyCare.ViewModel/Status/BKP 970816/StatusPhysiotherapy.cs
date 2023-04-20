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
    public class StatusPhysiotherapy : IInsUpDel<TBL_StatusPhysiotherapy, long?>,
        IGetList<VW_StatusPhysiotherapy, long>, IDataErrorInfo, INotifyPropertyChanged
    {
       
        #region Constructor

        public StatusPhysiotherapy()
        {

        }
        #endregion

        #region Properties

        DataClassesStatusPhysiotherapyDataContext DRN = new DataClassesStatusPhysiotherapyDataContext(MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.InternalConnectionString);

        public bool InsertEntity(List<TBL_StatusPhysiotherapy> ListObj, ref string msgRet, ref long? IdRet)
        {
            try
            {
                foreach (TBL_StatusPhysiotherapy FieldList in ListObj)
                {
                    DRN.SP_StatusPhysiotherapyInsert(
                        ref IdRet,
                        FieldList.VisitPatientPhysiotherapy_Id,
                        FieldList.StatusType_Id,
                        FieldList.VisitPatientPhysiotherapyComment,
                        FieldList.StartDateAlarm,
                        FieldList.User_Id,
                        FieldList.ChangeDateTime,
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

        public bool UpdateEntity(List<TBL_StatusPhysiotherapy> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_StatusPhysiotherapy FieldList in ListObj)
                {
                    DRN.SP_StatusPhysiotherapyUpdate(
                        FieldList.Id,
                        FieldList.VisitPatientPhysiotherapy_Id,
                        FieldList.StatusType_Id,
                        FieldList.VisitPatientPhysiotherapyComment,
                        FieldList.StartDateAlarm,
                        FieldList.User_Id,
                        FieldList.ChangeDateTime,
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

        public bool DeleteEntity(List<TBL_StatusPhysiotherapy> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_StatusPhysiotherapy FieldList in ListObj)
                {
                    DRN.SP_StatusPhysiotherapyDelete(
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


        public List<VW_StatusPhysiotherapy> GetAllList(ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_StatusPhysiotherapies select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_StatusPhysiotherapy> GetAllListByID(long Id, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_StatusPhysiotherapies where d.Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_StatusPhysiotherapy> GetAllListByFilter(List<MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.Filter> filter, ref string msgRet)
        {
            try
            {
                var deleg = MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.GetExpression<VW_StatusPhysiotherapy>(filter).Compile();
                var filteredCollection = (from d in DRN.VW_StatusPhysiotherapies select d).Where(deleg);
                return filteredCollection.ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public int CountAll(List<VW_StatusPhysiotherapy> ListObj)
        {
            return ListObj.Count();
        }

        public List<VW_StatusPhysiotherapy> GetAllListByDetailRow(long Id, long DetailRowId, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_StatusPhysiotherapies where d.VisitPatientPhysiotherapy_Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_StatusPhysiotherapyReport> GetResid(long Id, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_StatusPhysiotherapyReports where d.VisitPatientPhysiotherapy_Id == Id select d).ToList();
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
