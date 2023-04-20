  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using PhysiotherapyCare.Model;
using MKH.Library.Clasess.Security;
using PhysiotherapyCare.Model.Doctors;


namespace PhysiotherapyCare.ViewModel.Doctors
{
    public class Doctor : IInsUpDel<TBL_Doctor, int?>,
        IGetList<VW_Doctor, int>, IDataErrorInfo, INotifyPropertyChanged
    {
       
        #region Constructor

        public Doctor()
        {

        }
        #endregion

        #region Properties

        DataClassesDoctorsDataContext DRN = new DataClassesDoctorsDataContext(MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.InternalConnectionString);

        public bool InsertEntity(List<TBL_Doctor> ListObj, ref string msgRet, ref int? idRet)
        {
            try
            {
                foreach (TBL_Doctor FieldList in ListObj)
                {
                    DRN.SP_DoctorsInsert(
                        ref idRet,
                        FieldList.DoctorParent_Id,
                        FieldList.MedicalCode,
                        FieldList.CreateDate,
                        FieldList.DoctorPic,
                        FieldList.DoctorName,
                        FieldList.DoctorFamily,
                        FieldList.ParentName,
                        FieldList.IDNO,
                        FieldList.NationalCode,
                        FieldList.BrithDate,
                        FieldList.BrithCityName,
                        FieldList.DoctorType_Id,
                        FieldList.AddressPart,
                        FieldList.Address,
                        FieldList.TelHome,
                        FieldList.TelBusiness,
                        FieldList.Mobile,
                        FieldList.Email,
                        FieldList.Bank_Id,
                        FieldList.CardBankNo1,
                        FieldList.CardBankNo2,
                        FieldList.DoctorPrice,
                        FieldList.DoctorTaxPercent,
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

        public bool UpdateEntity(List<TBL_Doctor> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_Doctor FieldList in ListObj)
                {
                    DRN.SP_DoctorsUpdate(
                        FieldList.Id,
                        FieldList.DoctorParent_Id,
                        FieldList.MedicalCode,
                        FieldList.CreateDate,
                        FieldList.DoctorPic,
                        FieldList.DoctorName,
                        FieldList.DoctorFamily,
                        FieldList.ParentName,
                        FieldList.IDNO,
                        FieldList.NationalCode,
                        FieldList.BrithDate,
                        FieldList.BrithCityName,
                        FieldList.DoctorType_Id,
                        FieldList.AddressPart,
                        FieldList.Address,
                        FieldList.TelHome,
                        FieldList.TelBusiness,
                        FieldList.Mobile,
                        FieldList.Email,
                        FieldList.Bank_Id,
                        FieldList.CardBankNo1,
                        FieldList.CardBankNo2,
                        FieldList.DoctorPrice,
                        FieldList.DoctorTaxPercent,
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

        public bool DeleteEntity(List<TBL_Doctor> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_Doctor FieldList in ListObj)
                {
                    DRN.SP_DoctorsDelete(
                        FieldList.Id,
                        ref msgRet
                     );
                }
                DRN.SubmitChanges();


                long? idRet = 0;
                foreach (TBL_Doctor LogFieldList in ListObj)
                {
                    MKH.Permission.Model.Log.dbo_TBL_Doctor Login = new MKH.Permission.Model.Log.dbo_TBL_Doctor()
                    {
                        ComputerName = new MSSConfigHelp().ComputerName,
                        UserProfile = new MSSConfigHelp().CurrentWinUserName,
                        ActionType_Id = 3,
                        Id = LogFieldList.Id,
                        DoctorParent_Id = LogFieldList.DoctorParent_Id,
                        MedicalCode = LogFieldList.MedicalCode,
                        CreateDate = LogFieldList.CreateDate,
                        DoctorPic = LogFieldList.DoctorPic,
                        DoctorName = LogFieldList.DoctorName,
                        DoctorFamily = LogFieldList.DoctorFamily,
                        ParentName = LogFieldList.ParentName,
                        IDNO = LogFieldList.IDNO,
                        NationalCode = LogFieldList.NationalCode,
                        BrithDate = LogFieldList.BrithDate,
                        BrithCityName = LogFieldList.BrithCityName,
                        DoctorType_Id = LogFieldList.DoctorType_Id,
                        AddressPart = LogFieldList.AddressPart,
                        Address = LogFieldList.Address,
                        TelHome = LogFieldList.TelHome,
                        TelBusiness = LogFieldList.TelBusiness,
                        Mobile = LogFieldList.Mobile,
                        Email = LogFieldList.Email,
                        Bank_Id = LogFieldList.Bank_Id,
                        CardBankNo1 = LogFieldList.CardBankNo1,
                        CardBankNo2 = LogFieldList.CardBankNo2,
                        DoctorPrice = LogFieldList.DoctorPrice,
                        DoctorTaxPercent = LogFieldList.DoctorTaxPercent,
                        Active = LogFieldList.Active,
                        User_Id = MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                        ChangeDateTime = MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now),
                    };
                    List<MKH.Permission.Model.Log.dbo_TBL_Doctor> A = new List<MKH.Permission.Model.Log.dbo_TBL_Doctor>();
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


        public List<VW_Doctor> GetAllList(ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_Doctors select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_Doctor> GetAllListByID(int Id, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_Doctors where d.Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<TBL_Doctor> GetAllListByTblID(int Id, ref string msgRet)
        {
            try
            {
                return (from d in DRN.TBL_Doctors where d.Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_Doctor> GetAllListByFilter(List<MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.Filter> filter, ref string msgRet)
        {
            try
            {
                var deleg = MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.GetExpression<VW_Doctor>(filter).Compile();
                var filteredCollection = (from d in DRN.VW_Doctors select d).Where(deleg);
                return filteredCollection.ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public int CountAll(List<VW_Doctor> ListObj)
        {
            return ListObj.Count();
        }

        public List<VW_Doctor> GetAllListByDetailRow(int Id, long DetailRowId, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_Doctors where d.Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }


        public List<TBL_Doctor> GetAllListByIDPic(int Id, ref string msgRet)
        {
            try
            {
                return (from d in DRN.TBL_Doctors where d.Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }
        #endregion


        public int CheckExistNationalCode(string NationalCode, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_Doctors where d.NationalCode == NationalCode select d).Count();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return 0;
        }


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
