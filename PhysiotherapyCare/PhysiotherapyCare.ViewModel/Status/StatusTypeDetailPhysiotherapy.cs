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
    public class StatusTypeDetailPhysiotherapy : IInsUpDel<TBL_StatusTypeDetailPhysiotherapy, long?>,
        IGetList<VW_StatusTypeDetailPhysiotherapy, long>, IDataErrorInfo, INotifyPropertyChanged
    {
       
        #region Constructor

        public StatusTypeDetailPhysiotherapy()
        {

        }
        #endregion

        #region Properties

        DataClassesStatusPhysiotherapyDataContext DRN = new DataClassesStatusPhysiotherapyDataContext(MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.InternalConnectionString);

        public bool InsertEntity(List<TBL_StatusTypeDetailPhysiotherapy> ListObj, ref string msgRet, ref long? IdRet)
        {
            try
            {
                foreach (TBL_StatusTypeDetailPhysiotherapy FieldList in ListObj)
                {
                    DRN.SP_StatusTypeDetailPhysiotherapyInsert(
                        ref IdRet,
                        FieldList.VisitPatientPhysiotherapy_Id,
                        FieldList.StatusTypeDetail_Id,
                        FieldList.ConfirmSet,
                        FieldList.Description,
                        FieldList.StartDateAlarm,
                        FieldList.FReserve1,
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

        public bool UpdateEntity(List<TBL_StatusTypeDetailPhysiotherapy> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_StatusTypeDetailPhysiotherapy FieldList in ListObj)
                {
                    DRN.SP_StatusTypeDetailPhysiotherapyUpdate(
                        FieldList.Id,
                        FieldList.VisitPatientPhysiotherapy_Id,
                        FieldList.StatusTypeDetail_Id,
                        FieldList.ConfirmSet,
                        FieldList.Description,
                        FieldList.StartDateAlarm,
                        FieldList.FReserve1,
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

        public bool DeleteEntity(List<TBL_StatusTypeDetailPhysiotherapy> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_StatusTypeDetailPhysiotherapy FieldList in ListObj)
                {
                    DRN.SP_StatusTypeDetailPhysiotherapyDelete(
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


        public List<VW_StatusTypeDetailPhysiotherapy> GetAllList(ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_StatusTypeDetailPhysiotherapies select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_StatusTypeDetailPhysiotherapy> GetAllListByID(long Id, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_StatusTypeDetailPhysiotherapies where d.Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_StatusTypeDetailPhysiotherapy> GetAllListByFilter(List<MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.Filter> filter, ref string msgRet)
        {
            try
            {
                var deleg = MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.GetExpression<VW_StatusTypeDetailPhysiotherapy>(filter).Compile();
                var filteredCollection = (from d in DRN.VW_StatusTypeDetailPhysiotherapies select d).Where(deleg);
                return filteredCollection.ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public int CountAll(List<VW_StatusTypeDetailPhysiotherapy> ListObj)
        {
            return ListObj.Count();
        }

        public List<VW_StatusTypeDetailPhysiotherapy> GetAllListByDetailRow(long Id, long DetailRowId, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_StatusTypeDetailPhysiotherapies where d.VisitPatientPhysiotherapy_Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_StatusTypeDetailPhysiotherapyReport> GetResid(long Id, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_StatusTypeDetailPhysiotherapyReports where d.VisitPatientPhysiotherapy_Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }


        public bool DeleteWithPhysiotherapyId(long VisitPatientPhysiotherapy_Id, ref string msgRet)
        {
            try
            {
                DRN.SP_StatusTypeDetailPhysiotherapyDeleteWithPhysiotherapyId(
                    VisitPatientPhysiotherapy_Id,
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
