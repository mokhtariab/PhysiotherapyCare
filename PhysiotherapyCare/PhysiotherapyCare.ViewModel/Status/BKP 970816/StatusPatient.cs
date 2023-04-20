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
    public class StatusPatient : IInsUpDel<TBL_StatusPatient, long?>,
        IGetList<VW_StatusPatient, long>, IDataErrorInfo, INotifyPropertyChanged
    {
       
        #region Constructor

        public StatusPatient()
        {

        }
        #endregion

        #region Properties

        DataClassesStatusPatientDataContext DRN = new DataClassesStatusPatientDataContext(MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.InternalConnectionString);

        public bool InsertEntity(List<TBL_StatusPatient> ListObj, ref string msgRet, ref long? IdRet)
        {
            try
            {
                foreach (TBL_StatusPatient FieldList in ListObj)
                {
                    DRN.SP_StatusPatientInsert(
                        ref IdRet,
                        FieldList.Patient_Id,
                        FieldList.StatusType_Id,
                        FieldList.StatusPatientComment,
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

        public bool UpdateEntity(List<TBL_StatusPatient> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_StatusPatient FieldList in ListObj)
                {
                    DRN.SP_StatusPatientUpdate(
                        FieldList.Id,
                        FieldList.Patient_Id,
                        FieldList.StatusType_Id,
                        FieldList.StatusPatientComment,
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

        public bool DeleteEntity(List<TBL_StatusPatient> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_StatusPatient FieldList in ListObj)
                {
                    DRN.SP_StatusPatientDelete(
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


        public List<VW_StatusPatient> GetAllList(ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_StatusPatients select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_StatusPatient> GetAllListByID(long Id, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_StatusPatients where d.Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_StatusPatient> GetAllListByFilter(List<MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.Filter> filter, ref string msgRet)
        {
            try
            {
                var deleg = MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.GetExpression<VW_StatusPatient>(filter).Compile();
                var filteredCollection = (from d in DRN.VW_StatusPatients select d).Where(deleg);
                return filteredCollection.ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public int CountAll(List<VW_StatusPatient> ListObj)
        {
            return ListObj.Count();
        }

        public List<VW_StatusPatient> GetAllListByDetailRow(long Id, long DetailRowId, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_StatusPatients where d.Patient_Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_StatusPatientReport> GetResid(long Id, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_StatusPatientReports where d.Patient_Id == Id select d).ToList();
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
