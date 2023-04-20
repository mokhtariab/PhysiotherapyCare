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
    public class ParaclinicVisitPatient : IInsUpDel<TBL_ParaclinicVisitPatient, long?>,
        IGetList<VW_ParaclinicVisitPatient, long>, IDataErrorInfo, INotifyPropertyChanged
    {

        #region Constructor

        public ParaclinicVisitPatient()
        {

        }
        #endregion

        #region Properties

        DataClassesVisitPatientLinkDataContext DRN = new DataClassesVisitPatientLinkDataContext(MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.InternalConnectionString);

        public bool InsertEntity(List<TBL_ParaclinicVisitPatient> ListObj, ref string msgRet, ref long? idRet)
        {
            try
            {
                foreach (TBL_ParaclinicVisitPatient FieldList in ListObj)
                {
                    DRN.SP_ParaclinicVisitPatientInsert(
                        ref idRet,
                        FieldList.VisitPatient_Id,
                        FieldList.Paraclinic_Id,
                        FieldList.ParaclinicsState,
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

        public bool UpdateEntity(List<TBL_ParaclinicVisitPatient> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_ParaclinicVisitPatient FieldList in ListObj)
                {
                    DRN.SP_ParaclinicVisitPatientUpdate(
                        FieldList.Id,
                        FieldList.VisitPatient_Id,
                        FieldList.Paraclinic_Id,
                        FieldList.ParaclinicsState,
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

        public bool DeleteEntity(List<TBL_ParaclinicVisitPatient> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_ParaclinicVisitPatient FieldList in ListObj)
                {
                    DRN.SP_ParaclinicVisitPatientDelete(
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


        public List<VW_ParaclinicVisitPatient> GetAllList(ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_ParaclinicVisitPatients select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_ParaclinicVisitPatient> GetAllListByID(long Id, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_ParaclinicVisitPatients where d.Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_ParaclinicVisitPatient> GetAllListByFilter(List<MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.Filter> filter, ref string msgRet)
        {
            try
            {
                var deleg = MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.GetExpression<VW_ParaclinicVisitPatient>(filter).Compile();
                var filteredCollection = (from d in DRN.VW_ParaclinicVisitPatients select d).Where(deleg);
                return filteredCollection.ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public int CountAll(List<VW_ParaclinicVisitPatient> ListObj)
        {
            return ListObj.Count();
        }

        public List<VW_ParaclinicVisitPatient> GetAllListByDetailRow(long Id, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_ParaclinicVisitPatients where d.Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public bool VisitPatientWithParaclinicVisitPatientDelete(long VisitPatient_Id, ref string msgRet)
        {
            try
            {
                DRN.SP_VisitPatientWithParaclinicVisitPatientDelete(
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

        //public bool ServiceHealthCareWithVisitHealthCareDelete(long VisitHealthCare_Id, ref string msgRet)
        //{
        //    try
        //    {
        //        DRN.SP_ServiceHealthCareWithVisitHealthCareDelete(
        //            VisitHealthCare_Id,
        //            ref msgRet
        //            );
        //        DRN.SubmitChanges();

        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        msgRet = ex.Message;
        //    }
        //    return false;
        //}


        //public int SumServiceHealthCare(long VisitHealthCare_Id)
        //{
        //    try
        //    {
        //        return DRN.SumServiceHealthCare(VisitHealthCare_Id).Value;
        //    }
        //    catch (Exception ex)
        //    {
        //        return 0;
        //    }
        //}

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

        public List<VW_ParaclinicVisitPatient> GetAllListByDetailRow(long Id, long DetailRowId, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_ParaclinicVisitPatients where d.Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        //bool IInsUpDel<TBL_SicknessVisitPatient, int?>.InsertEntity(List<TBL_SicknessVisitPatient> ListObj, ref string msgRet, ref int? idRet)
        //{
        //    throw new NotImplementedException();
        //}

        //bool IInsUpDel<TBL_SicknessVisitPatient, int?>.UpdateEntity(List<TBL_SicknessVisitPatient> ListObj, ref string msgRet)
        //{
        //    throw new NotImplementedException();
        //}

        //bool IInsUpDel<TBL_SicknessVisitPatient, int?>.DeleteEntity(List<TBL_SicknessVisitPatient> ListObj, ref string msgRet)
        //{
        //    throw new NotImplementedException();
        //}
        #endregion



    }
}
