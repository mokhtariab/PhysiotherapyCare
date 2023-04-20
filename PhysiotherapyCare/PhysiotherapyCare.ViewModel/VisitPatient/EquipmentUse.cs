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
    public class EquipmentUse : IInsUpDel<TBL_EquipmentUse, int?>,
        IGetList<VW_EquipmentUse, int>, IDataErrorInfo, INotifyPropertyChanged
    {
       
        #region Constructor

        public EquipmentUse()
        {

        }
        #endregion

        #region Properties

        DataClassesVisitPatientBaseDataContext DRN = new DataClassesVisitPatientBaseDataContext(MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.InternalConnectionString);

        public bool InsertEntity(List<TBL_EquipmentUse> ListObj, ref string msgRet, ref int? idSet)
        {
            try
            {
                foreach (TBL_EquipmentUse FieldList in ListObj)
                {
                    DRN.SP_EquipmentUseInsert(
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

        public bool UpdateEntity(List<TBL_EquipmentUse> ListObj, ref string msgRet)
        {

            try
            {
                foreach (TBL_EquipmentUse FieldList in ListObj)
                {
                    DRN.SP_EquipmentUseUpdate(
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

        public bool DeleteEntity(List<TBL_EquipmentUse> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_EquipmentUse FieldList in ListObj)
                {
                    DRN.SP_EquipmentUseDelete(
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


        public List<VW_EquipmentUse> GetAllList(ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_EquipmentUses select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_EquipmentUse> GetAllListByID(int Id, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_EquipmentUses where d.Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_EquipmentUse> GetAllListByFilter(List<MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.Filter> filter, ref string msgRet)
        {
            try
            {
                var deleg = MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.GetExpression<VW_EquipmentUse>(filter).Compile();
                var filteredCollection = (from d in DRN.VW_EquipmentUses select d).Where(deleg);
                return filteredCollection.ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public int CountAll(List<VW_EquipmentUse> ListObj)
        {
            return ListObj.Count();
        }

        public List<VW_EquipmentUse> GetAllListByDetailRow(int Id, long DetailRowId, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_EquipmentUses where d.Id == Id select d).ToList();
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
