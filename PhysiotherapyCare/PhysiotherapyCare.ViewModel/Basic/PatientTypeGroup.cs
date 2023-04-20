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
    public class PatientTypeGroup : IInsUpDel<TBL_PatientTypeGroup, int?>,
        IGetList<VW_PatientTypeGroup,int>, IDataErrorInfo, INotifyPropertyChanged
    {

        #region Constructor

        public PatientTypeGroup()
        {

        }
        #endregion

        #region Properties

        DataClassesBaseDataContext DRN = new DataClassesBaseDataContext(MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.InternalConnectionString);

        public bool InsertEntity(List<TBL_PatientTypeGroup> ListObj, ref string msgRet, ref int? idRet)
        {
            try
            {
                foreach (TBL_PatientTypeGroup FieldList in ListObj)
                {
                    DRN.SP_PatientTypeGroupInsert(
                        FieldList.PatientType_Id,
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

        public bool UpdateEntity(List<TBL_PatientTypeGroup> ListObj, ref string msgRet)
        {
            return true;
        }

        public bool DeleteEntity(List<TBL_PatientTypeGroup> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_PatientTypeGroup FieldList in ListObj)
                {
                    DRN.SP_PatientTypeGroupDelete(
                        FieldList.PatientType_Id,
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


        public List<VW_PatientTypeGroup> GetAllList(ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_PatientTypeGroups select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_PatientTypeGroup> GetAllListByID(int Id, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_PatientTypeGroups where d.PatientType_Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }
        public List<VW_PatientTypeGroup> GetAllListByPatientId(int Id, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_PatientTypeGroups where d.Patient_Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_PatientTypeGroup> GetAllListByFilter(List<MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.Filter> filter, ref string msgRet)
        {
            try
            {
                var deleg = MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.GetExpression<VW_PatientTypeGroup>(filter).Compile();
                var filteredCollection = (from d in DRN.VW_PatientTypeGroups select d).Where(deleg);
                return filteredCollection.ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public int CountAll(List<VW_PatientTypeGroup> ListObj)
        {
            return ListObj.Count();
        }

        public List<VW_PatientTypeGroup> GetAllListByDetailRow(int Id, long DetailRowId, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_PatientTypeGroups where d.Patient_Id == Id select d).ToList();
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
                DRN.SP_PatientTypeGroupDeleteWithPatientId(
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
