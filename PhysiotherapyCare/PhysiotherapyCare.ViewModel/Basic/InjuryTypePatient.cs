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
    public class InjuryTypePatient : IInsUpDel<TBL_InjuryTypePatient, short?>,
        IGetList<VW_InjuryTypePatient,short>, IDataErrorInfo, INotifyPropertyChanged
    {

        #region Constructor

        public InjuryTypePatient()
        {

        }
        #endregion

        #region Properties

        DataClassesBaseDataContext DRN = new DataClassesBaseDataContext(MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.InternalConnectionString);

        public bool InsertEntity(List<TBL_InjuryTypePatient> ListObj, ref string msgRet, ref short? idRet)
        {
            try
            {
                foreach (TBL_InjuryTypePatient FieldList in ListObj)
                {
                    DRN.SP_InjuryTypePatientInsert(
                        FieldList.InjuryType_Id,
                        FieldList.Patient_Id,
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

        public bool UpdateEntity(List<TBL_InjuryTypePatient> ListObj, ref string msgRet)
        {
            return true;
        }

        public bool DeleteEntity(List<TBL_InjuryTypePatient> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_InjuryTypePatient FieldList in ListObj)
                {
                    DRN.SP_InjuryTypePatientDelete(
                        FieldList.InjuryType_Id,
                    FieldList.Patient_Id,
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


        public List<VW_InjuryTypePatient> GetAllList(ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_InjuryTypePatients select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_InjuryTypePatient> GetAllListByID(short Id, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_InjuryTypePatients where d.InjuryType_Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_InjuryTypePatient> GetAllListByPatientId(int PatientId, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_InjuryTypePatients where d.Patient_Id == PatientId select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_InjuryTypePatient> GetAllListByFilter(List<MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.Filter> filter, ref string msgRet)
        {
            try
            {
                var deleg = MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.GetExpression<VW_InjuryTypePatient>(filter).Compile();
                var filteredCollection = (from d in DRN.VW_InjuryTypePatients select d).Where(deleg);
                return filteredCollection.ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public int CountAll(List<VW_InjuryTypePatient> ListObj)
        {
            return ListObj.Count();
        }
        public List<VW_InjuryTypePatient> GetAllListByDetailRow(short Id, long DetailRowId, ref string msgRet)

        {
            try
            {
                return (from d in DRN.VW_InjuryTypePatients where d.Patient_Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }


        public bool DeleteWithPatientID(int PatientID, ref string msgRet)
        {
            try
            {
                DRN.SP_InjuryTypePatientDeleteWithPatientId(
                    PatientID,
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
