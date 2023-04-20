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
    public class StatusTypeDetailVisitPatient : IInsUpDel<TBL_StatusTypeDetailVisitPatient, long?>,
        IGetList<VW_StatusTypeDetailVisitPatient, long>, IDataErrorInfo, INotifyPropertyChanged
    {
       
        #region Constructor

        public StatusTypeDetailVisitPatient()
        {

        }
        #endregion

        #region Properties

        DataClassesStatusVisitPatientDataContext DRN = new DataClassesStatusVisitPatientDataContext(MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.InternalConnectionString);

        public bool InsertEntity(List<TBL_StatusTypeDetailVisitPatient> ListObj, ref string msgRet, ref long? IdRet)
        {
            try
            {
                foreach (TBL_StatusTypeDetailVisitPatient FieldList in ListObj)
                {
                    DRN.SP_StatusTypeDetailVisitPatientInsert(
                        ref IdRet,
                        FieldList.VisitPatient_Id,
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

        public bool UpdateEntity(List<TBL_StatusTypeDetailVisitPatient> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_StatusTypeDetailVisitPatient FieldList in ListObj)
                {
                    DRN.SP_StatusTypeDetailVisitPatientUpdate(
                        FieldList.Id,
                        FieldList.VisitPatient_Id,
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

        public bool DeleteEntity(List<TBL_StatusTypeDetailVisitPatient> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_StatusTypeDetailVisitPatient FieldList in ListObj)
                {
                    DRN.SP_StatusTypeDetailVisitPatientDelete(
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


        public List<VW_StatusTypeDetailVisitPatient> GetAllList(ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_StatusTypeDetailVisitPatients select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_StatusTypeDetailVisitPatient> GetAllListByID(long Id, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_StatusTypeDetailVisitPatients where d.Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_StatusTypeDetailVisitPatient> GetAllListByFilter(List<MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.Filter> filter, ref string msgRet)
        {
            try
            {
                var deleg = MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.GetExpression<VW_StatusTypeDetailVisitPatient>(filter).Compile();
                var filteredCollection = (from d in DRN.VW_StatusTypeDetailVisitPatients select d).Where(deleg);
                return filteredCollection.ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public int CountAll(List<VW_StatusTypeDetailVisitPatient> ListObj)
        {
            return ListObj.Count();
        }

        public List<VW_StatusTypeDetailVisitPatient> GetAllListByDetailRow(long Id, long DetailRowId, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_StatusTypeDetailVisitPatients where d.VisitPatient_Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_StatusTypeDetailVisitPatientReport> GetResid(long Id, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_StatusTypeDetailVisitPatientReports where d.VisitPatient_Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }


        public bool DeleteWithVisitPatientId(long VisitPatientVisitPatient_Id, ref string msgRet)
        {
            try
            {
                DRN.SP_StatusTypeDetailVisitPatientDeleteWithVisitPatientId(
                    VisitPatientVisitPatient_Id,
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
