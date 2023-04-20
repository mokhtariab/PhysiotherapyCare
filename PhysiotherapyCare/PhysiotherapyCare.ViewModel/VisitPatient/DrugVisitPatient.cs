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
    public class DrugVisitPatient : IInsUpDel<TBL_DrugVisitPatient, long?>,
        IGetList<VW_DrugVisitPatient, long>, IDataErrorInfo, INotifyPropertyChanged
    {

        #region Constructor

        public DrugVisitPatient()
        {

        }
        #endregion

        #region Properties

        DataClassesVisitPatientLinkDataContext DRN = new DataClassesVisitPatientLinkDataContext(MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.InternalConnectionString);

        public bool InsertEntity(List<TBL_DrugVisitPatient> ListObj, ref string msgRet, ref long? idRet)
        {
            try
            {
                foreach (TBL_DrugVisitPatient FieldList in ListObj)
                {
                    DRN.SP_DrugVisitPatientInsert(
                        ref idRet,
                        FieldList.VisitPatient_Id,
                        FieldList.Drug_Id,
                        FieldList.UseAmount,
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

        public bool UpdateEntity(List<TBL_DrugVisitPatient> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_DrugVisitPatient FieldList in ListObj)
                {
                    DRN.SP_DrugVisitPatientUpdate(
                        FieldList.Id,
                        FieldList.VisitPatient_Id,
                        FieldList.Drug_Id,
                        FieldList.UseAmount,
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

        public bool DeleteEntity(List<TBL_DrugVisitPatient> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_DrugVisitPatient FieldList in ListObj)
                {
                    DRN.SP_DrugVisitPatientDelete(
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


        public List<VW_DrugVisitPatient> GetAllList(ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_DrugVisitPatients select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_DrugVisitPatient> GetAllListByID(long Id, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_DrugVisitPatients where d.Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_DrugVisitPatient> GetAllListByFilter(List<MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.Filter> filter, ref string msgRet)
        {
            try
            {
                var deleg = MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.GetExpression<VW_DrugVisitPatient>(filter).Compile();
                var filteredCollection = (from d in DRN.VW_DrugVisitPatients select d).Where(deleg);
                return filteredCollection.ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public int CountAll(List<VW_DrugVisitPatient> ListObj)
        {
            return ListObj.Count();
        }

        public List<VW_DrugVisitPatient> GetAllListByDetailRow(long Id, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_DrugVisitPatients where d.Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }


        public bool VisitPatientWithDrugVisitPatientDelete(long VisitPatient_Id, ref string msgRet)
        {
            try
            {
                DRN.SP_VisitPatientWithDrugVisitPatientDelete(
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

        public List<VW_DrugVisitPatient> GetAllListByDetailRow(long Id, long DetailRowId, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_DrugVisitPatients where d.Id == Id select d).ToList();
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
