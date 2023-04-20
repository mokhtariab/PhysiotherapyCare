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
    public class LocationPartDoctors : IInsUpDel<TBL_LocationPartDoctor, short?>,
        IGetList<VW_LocationPartDoctor,short>, IDataErrorInfo, INotifyPropertyChanged
    {

        #region Constructor

        public LocationPartDoctors()
        {

        }
        #endregion

        #region Properties

        DataClassesBaseDataContext DRN = new DataClassesBaseDataContext(MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.InternalConnectionString);

        public bool InsertEntity(List<TBL_LocationPartDoctor> ListObj, ref string msgRet, ref short? idRet)
        {
            try
            {
                foreach (TBL_LocationPartDoctor FieldList in ListObj)
                {
                    DRN.SP_LocationPartDoctorsInsert(
                        FieldList.LocationPart_Id,
                        FieldList.Doctors_Id,
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

        public bool UpdateEntity(List<TBL_LocationPartDoctor> ListObj, ref string msgRet)
        {
            return true;
        }

        public bool DeleteEntity(List<TBL_LocationPartDoctor> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_LocationPartDoctor FieldList in ListObj)
                {
                    DRN.SP_LocationPartDoctorsDelete(
                        FieldList.LocationPart_Id,
                        FieldList.Doctors_Id,
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


        public List<VW_LocationPartDoctor> GetAllList(ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_LocationPartDoctors select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_LocationPartDoctor> GetAllListByID(short Id, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_LocationPartDoctors where d.LocationPart_Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_LocationPartDoctor> GetAllListByFilter(List<MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.Filter> filter, ref string msgRet)
        {
            try
            {
                var deleg = MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.GetExpression<VW_LocationPartDoctor>(filter).Compile();
                var filteredCollection = (from d in DRN.VW_LocationPartDoctors select d).Where(deleg);
                return filteredCollection.ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public int CountAll(List<VW_LocationPartDoctor> ListObj)
        {
            return ListObj.Count();
        }
        public List<VW_LocationPartDoctor> GetAllListByDetailRow(short Id, long DetailRowId, ref string msgRet)

        {
            try
            {
                return (from d in DRN.VW_LocationPartDoctors where d.LocationPart_Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }


        public List<VW_LocationPartDoctor> GetAllListByDoctorID(int Doctor_Id, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_LocationPartDoctors where d.Doctors_Id == Doctor_Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public bool DeleteWithDoctor_Id(int DoctorId, ref string msgRet)
        {
            try
            {
                DRN.SP_LocationPartDoctorsDeleteWithDoctor_Id(
                    DoctorId,
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
