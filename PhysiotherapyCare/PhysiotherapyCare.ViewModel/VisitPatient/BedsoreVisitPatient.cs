using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using PhysiotherapyCare.Model;
using MKH.Library.Clasess.Security;
using PhysiotherapyCare.Model.VisitPatient;


namespace PhysiotherapyCare.ViewModel.VisitPatient
{
    public class BedsoreVisitPatient : IInsUpDel<TBL_BedsoreVisitPatient, long?>,
        IGetList<VW_BedsoreVisitPatient, long>, IDataErrorInfo, INotifyPropertyChanged
    {

        #region Constructor

        public BedsoreVisitPatient()
        {

        }
        #endregion

        #region Properties

        DataClassesVisitPatientLinkDataContext DRN = new DataClassesVisitPatientLinkDataContext(MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.InternalConnectionString);

        public bool InsertEntity(List<TBL_BedsoreVisitPatient> ListObj, ref string msgRet, ref long? idRet)
        {
            try
            {
                foreach (TBL_BedsoreVisitPatient FieldList in ListObj)
                {
                    DRN.SP_BedsoreVisitPatientInsert(
                        ref idRet,
                        FieldList.VisitPatient_Id,
                        FieldList.BedsorePosition,
                        FieldList.BedsoreMeasurement,
                        FieldList.BedsoreDeep,
                        FieldList.BedsoreStartTime,
                        FieldList.BedsoreGrade,
                        FieldList.BedsoreRemain,
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

        public bool UpdateEntity(List<TBL_BedsoreVisitPatient> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_BedsoreVisitPatient FieldList in ListObj)
                {
                    DRN.SP_BedsoreVisitPatientUpdate(
                        FieldList.Id,
                        FieldList.VisitPatient_Id,
                        FieldList.BedsorePosition,
                        FieldList.BedsoreMeasurement,
                        FieldList.BedsoreDeep,
                        FieldList.BedsoreStartTime,
                        FieldList.BedsoreGrade,
                        FieldList.BedsoreRemain,
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

        public bool DeleteEntity(List<TBL_BedsoreVisitPatient> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_BedsoreVisitPatient FieldList in ListObj)
                {
                    DRN.SP_BedsoreVisitPatientDelete(
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


        public List<VW_BedsoreVisitPatient> GetAllList(ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_BedsoreVisitPatients select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_BedsoreVisitPatient> GetAllListByID(long Id, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_BedsoreVisitPatients where d.Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_BedsoreVisitPatient> GetAllListByFilter(List<MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.Filter> filter, ref string msgRet)
        {
            try
            {
                var deleg = MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.GetExpression<VW_BedsoreVisitPatient>(filter).Compile();
                var filteredCollection = (from d in DRN.VW_BedsoreVisitPatients select d).Where(deleg);
                return filteredCollection.ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public int CountAll(List<VW_BedsoreVisitPatient> ListObj)
        {
            return ListObj.Count();
        }

        public List<VW_BedsoreVisitPatient> GetAllListByDetailRow(long Id, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_BedsoreVisitPatients where d.Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }




        public bool VisitPatientWithBedsoreVisitPatientDelete(long VisitPatient_Id, ref string msgRet)
        {
            try
            {
                DRN.SP_VisitPatientWithBedsoreVisitPatientDelete(
                    VisitPatient_Id,
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

        public List<VW_BedsoreVisitPatient> GetAllListByDetailRow(long Id, long DetailRowId, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_BedsoreVisitPatients where d.Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

       
        #endregion



    }
}
