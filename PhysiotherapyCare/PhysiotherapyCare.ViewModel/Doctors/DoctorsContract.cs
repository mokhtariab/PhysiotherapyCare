  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using PhysiotherapyCare.Model;
using MKH.Library.Clasess.Security;
using PhysiotherapyCare.Model.Doctors;


namespace PhysiotherapyCare.ViewModel.DoctorsContracts
{
    public class DoctorsContract : IInsUpDel<TBL_DoctorsContract, int?>,
        IGetList<VW_DoctorsContract, int>, IDataErrorInfo, INotifyPropertyChanged
    {
       
        #region Constructor

        public DoctorsContract()
        {

        }
        #endregion

        #region Properties

        DataClassesDoctorsContractDataContext DRN = new DataClassesDoctorsContractDataContext(MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.InternalConnectionString);

        public bool InsertEntity(List<TBL_DoctorsContract> ListObj, ref string msgRet, ref int? idRet)
        {
            try
            {
                foreach (TBL_DoctorsContract FieldList in ListObj)
                {
                    DRN.SP_DoctorsContractInsert(
                        ref idRet,
                        FieldList.Doctor_Id,
                        FieldList.ContractNo,
                        FieldList.ContractDate,
                        FieldList.ContractEndDate,
                        FieldList.ContractPercent,
                        FieldList.Active,
                        FieldList.User_Id,
                        FieldList.ChangeDateTime,
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

        public bool UpdateEntity(List<TBL_DoctorsContract> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_DoctorsContract FieldList in ListObj)
                {
                    DRN.SP_DoctorsContractUpdate(
                        FieldList.Id,
                        FieldList.Doctor_Id,
                        FieldList.ContractNo,
                        FieldList.ContractDate,
                        FieldList.ContractEndDate,
                        FieldList.ContractPercent,
                        FieldList.Active,
                        FieldList.User_Id,
                        FieldList.ChangeDateTime,
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

        public bool DeleteEntity(List<TBL_DoctorsContract> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_DoctorsContract FieldList in ListObj)
                {
                    DRN.SP_DoctorsContractDelete(
                        FieldList.Id,
                        ref msgRet
                     );
                }
                DRN.SubmitChanges();


                long? idRet = 0;
                foreach (TBL_DoctorsContract LogFieldList in ListObj)
                {
                    MKH.Permission.Model.Log.dbo_TBL_DoctorsContract Login = new MKH.Permission.Model.Log.dbo_TBL_DoctorsContract()
                    {
                        ComputerName = new MSSConfigHelp().ComputerName,
                        UserProfile = new MSSConfigHelp().CurrentWinUserName,
                        ActionType_Id = 3,
                        Id = LogFieldList.Id,
                        Doctor_Id = LogFieldList.Doctor_Id,
                        ContractNo = LogFieldList.ContractNo,
                        ContractDate = LogFieldList.ContractDate,
                        ContractEndDate = LogFieldList.ContractEndDate,
                        ContractPercent = LogFieldList.ContractPercent,
                        Active = LogFieldList.Active,
                        User_Id = MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                        ChangeDateTime = MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now),
                    };
                    List<MKH.Permission.Model.Log.dbo_TBL_DoctorsContract> A = new List<MKH.Permission.Model.Log.dbo_TBL_DoctorsContract>();
                    A.Add(Login);
                    new MKH.Permission.ViewModel.Log.Log().InsertEntity(A, ref msgRet, ref idRet);
                }

                return true;
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return false;
        }


        public List<VW_DoctorsContract> GetAllList(ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_DoctorsContracts select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_DoctorsContract> GetAllListByID(int Id, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_DoctorsContracts where d.Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_DoctorsContract> GetAllListByFilter(List<MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.Filter> filter, ref string msgRet)
        {
            try
            {
                var deleg = MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.GetExpression<VW_DoctorsContract>(filter).Compile();
                var filteredCollection = (from d in DRN.VW_DoctorsContracts select d).Where(deleg);
                return filteredCollection.ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public int CountAll(List<VW_DoctorsContract> ListObj)
        {
            return ListObj.Count();
        }

        public List<VW_DoctorsContract> GetAllListByDetailRow(int Id, long DetailRowId, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_DoctorsContracts where d.Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }


        public List<TBL_DoctorsContract> GetAllListByDoctorID(int Doctor_Id, ref string msgRet)
        {
            try
            {
                return (from d in DRN.TBL_DoctorsContracts where d.Doctor_Id == Doctor_Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }


        public void GetAllUpdateContract(ref string msgRet)
        {
            try
            {
                 DRN.SP_DoctorsContractOnLineUpdate(ref msgRet);
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
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
