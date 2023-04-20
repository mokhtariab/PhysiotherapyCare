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
    public class Vaccination : IInsUpDel<TBL_Vaccination, int?>,
        IGetList<VW_Vaccination, int>, IDataErrorInfo, INotifyPropertyChanged
    {
       
        #region Constructor

        public Vaccination()
        {

        }
        #endregion

        #region Properties

        DataClassesVisitPatientBaseDataContext DRN = new DataClassesVisitPatientBaseDataContext(MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.InternalConnectionString);

        public bool InsertEntity(List<TBL_Vaccination> ListObj, ref string msgRet, ref int? idSet)
        {
            try
            {
                foreach (TBL_Vaccination FieldList in ListObj)
                {
                    DRN.SP_VaccinationInsert(
                        ref idSet,
                        FieldList.TitleName,
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

        public bool UpdateEntity(List<TBL_Vaccination> ListObj, ref string msgRet)
        {

            try
            {
                foreach (TBL_Vaccination FieldList in ListObj)
                {
                    DRN.SP_VaccinationUpdate(
                       FieldList.Id,
                        FieldList.TitleName,
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

        public bool DeleteEntity(List<TBL_Vaccination> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_Vaccination FieldList in ListObj)
                {
                    DRN.SP_VaccinationDelete(
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


        public List<VW_Vaccination> GetAllList(ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_Vaccinations select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_Vaccination> GetAllListByID(int Id, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_Vaccinations where d.Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_Vaccination> GetAllListByFilter(List<MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.Filter> filter, ref string msgRet)
        {
            try
            {
                var deleg = MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.GetExpression<VW_Vaccination>(filter).Compile();
                var filteredCollection = (from d in DRN.VW_Vaccinations select d).Where(deleg);
                return filteredCollection.ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public int CountAll(List<VW_Vaccination> ListObj)
        {
            return ListObj.Count();
        }

        public List<VW_Vaccination> GetAllListByDetailRow(int Id, long DetailRowId, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_Vaccinations where d.Id == Id select d).ToList();
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
