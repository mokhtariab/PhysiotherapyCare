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
    public class Sickness : IInsUpDel<TBL_Sickness, int?>,
        IGetList<VW_Sickness, int>, IDataErrorInfo, INotifyPropertyChanged
    {
       
        #region Constructor

        public Sickness()
        {

        }
        #endregion

        #region Properties

        DataClassesVisitPatientBaseDataContext DRN = new DataClassesVisitPatientBaseDataContext(MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.InternalConnectionString);

        public bool InsertEntity(List<TBL_Sickness> ListObj, ref string msgRet, ref int? idSet)
        {
            try
            {
                foreach (TBL_Sickness FieldList in ListObj)
                {
                    DRN.SP_SicknessInsert(
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

        public bool UpdateEntity(List<TBL_Sickness> ListObj, ref string msgRet)
        {
            int Id = 0;
            try
            {
                foreach (TBL_Sickness FieldList in ListObj)
                {
                    DRN.SP_SicknessUpdate(
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

        public bool DeleteEntity(List<TBL_Sickness> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_Sickness FieldList in ListObj)
                {
                    DRN.SP_SicknessDelete(
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


        public List<VW_Sickness> GetAllList(ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_Sicknesses select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_Sickness> GetAllListByID(int Id, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_Sicknesses where d.Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_Sickness> GetAllListByFilter(List<MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.Filter> filter, ref string msgRet)
        {
            try
            {
                var deleg = MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.GetExpression<VW_Sickness>(filter).Compile();
                var filteredCollection = (from d in DRN.VW_Sicknesses select d).Where(deleg);
                return filteredCollection.ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public int CountAll(List<VW_Sickness> ListObj)
        {
            return ListObj.Count();
        }

        public List<VW_Sickness> GetAllListByDetailRow(int Id, long DetailRowId, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_Sicknesses where d.Id == Id select d).ToList();
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
