  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using PhysiotherapyCare.Model;
using MKH.Library.Clasess.Security;
using PhysiotherapyCare.Model.Patient;

namespace PhysiotherapyCare.ViewModel.Patient
{
    public class PatientStateSickness : IInsUpDel<TBL_PatientStateSickness, int?>,
        IGetList<VW_PatientStateSickness, short>, IDataErrorInfo, INotifyPropertyChanged
    {
       
        #region Constructor

        public PatientStateSickness()
        {

        }
        #endregion

        #region Properties

        DataClassesPatientDataContext DRN = new DataClassesPatientDataContext(MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.InternalConnectionString);

        public bool InsertEntity(List<TBL_PatientStateSickness> ListObj, ref string msgRet, ref int? idSet)
        {
            try
            {
                foreach (TBL_PatientStateSickness FieldList in ListObj)
                {
                    DRN.SP_PatientStateSicknessInsert(
                        FieldList.Patient_Id,
                        FieldList.StateSicknessDetail_Id,
                        FieldList.Description,
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

        public bool UpdateEntity(List<TBL_PatientStateSickness> ListObj, ref string msgRet)
        {
            int Id = 0;
            try
            {
                foreach (TBL_PatientStateSickness FieldList in ListObj)
                {
                    DRN.SP_PatientStateSicknessUpdate(
                        FieldList.Patient_Id,
                        FieldList.StateSicknessDetail_Id,
                        FieldList.Description,
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

        public bool DeleteEntity(List<TBL_PatientStateSickness> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_PatientStateSickness FieldList in ListObj)
                {
                    DRN.SP_PatientStateSicknessDelete(
                        FieldList.Patient_Id,
                        FieldList.StateSicknessDetail_Id,
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


        public List<VW_PatientStateSickness> GetAllList(ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_PatientStateSicknesses select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_PatientStateSickness> GetAllListByID(short Id, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_PatientStateSicknesses where d.Patient_Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_PatientStateSickness> GetAllListByFilter(List<MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.Filter> filter, ref string msgRet)
        {
            try
            {
                var deleg = MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.GetExpression<VW_PatientStateSickness>(filter).Compile();
                var filteredCollection = (from d in DRN.VW_PatientStateSicknesses select d).Where(deleg);
                return filteredCollection.ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public int CountAll(List<VW_PatientStateSickness> ListObj)
        {
            return ListObj.Count();
        }

        public List<VW_PatientStateSickness> GetAllListByDetailRow(short Id, long DetailRowId, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_PatientStateSicknesses where d.Patient_Id == Id select d).ToList();
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
