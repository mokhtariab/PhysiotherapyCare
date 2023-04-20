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
    public class StatusTypeDetailPatient : IInsUpDel<TBL_StatusTypeDetailPatient, long?>,
        IGetList<VW_StatusTypeDetailPatient, long>, IDataErrorInfo, INotifyPropertyChanged
    {
       
        #region Constructor

        public StatusTypeDetailPatient()
        {

        }
        #endregion

        #region Properties

        DataClassesStatusPatientDataContext DRN = new DataClassesStatusPatientDataContext(MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.InternalConnectionString);

        public bool InsertEntity(List<TBL_StatusTypeDetailPatient> ListObj, ref string msgRet, ref long? IdRet)
        {
            try
            {
                foreach (TBL_StatusTypeDetailPatient FieldList in ListObj)
                {
                    DRN.SP_StatusTypeDetailPatientInsert(
                        ref IdRet,
                        FieldList.Patient_Id,
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

        public bool UpdateEntity(List<TBL_StatusTypeDetailPatient> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_StatusTypeDetailPatient FieldList in ListObj)
                {
                    DRN.SP_StatusTypeDetailPatientUpdate(
                        FieldList.Id,
                        FieldList.Patient_Id,
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

        public bool DeleteEntity(List<TBL_StatusTypeDetailPatient> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_StatusTypeDetailPatient FieldList in ListObj)
                {
                    DRN.SP_StatusTypeDetailPatientDelete(
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


        public List<VW_StatusTypeDetailPatient> GetAllList(ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_StatusTypeDetailPatients select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_StatusTypeDetailPatient> GetAllListByID(long Id, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_StatusTypeDetailPatients where d.Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_StatusTypeDetailPatient> GetAllListByFilter(List<MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.Filter> filter, ref string msgRet)
        {
            try
            {
                var deleg = MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.GetExpression<VW_StatusTypeDetailPatient>(filter).Compile();
                var filteredCollection = (from d in DRN.VW_StatusTypeDetailPatients select d).Where(deleg);
                return filteredCollection.ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public int CountAll(List<VW_StatusTypeDetailPatient> ListObj)
        {
            return ListObj.Count();
        }

        public List<VW_StatusTypeDetailPatient> GetAllListByDetailRow(long Id, long DetailRowId, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_StatusTypeDetailPatients where d.Patient_Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_StatusTypeDetailPatientReport> GetResid(long Id, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_StatusTypeDetailPatientReports where d.Patient_Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }



        public bool DeleteWithPatientId(int Patient_Id, ref string msgRet)
        {
            try
            {
                DRN.SP_StatusTypeDetailPatientDeleteWithPatientId(
                    Patient_Id,
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
