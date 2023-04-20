  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using PhysiotherapyCare.Model;
using MKH.Library.Clasess.Security;
using PhysiotherapyCare.Model.Patient;


namespace PhysiotherapyCare.ViewModel.Patient
{
    public class Patient : IInsUpDel<TBL_Patient, int?>,
        IGetList<VW_Patient, int>, IDataErrorInfo, INotifyPropertyChanged
    {
       
        #region Constructor

        public Patient()
        {

        }
        #endregion

        #region Properties

        DataClassesPatientDataContext DRN = new DataClassesPatientDataContext(MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.InternalConnectionString);

        public bool InsertEntity(List<TBL_Patient> ListObj, ref string msgRet, ref int? IdRet)
        {
            try
            {
                foreach (TBL_Patient FieldList in ListObj)
                {
                    DRN.SP_PatientInsert(
                        ref IdRet,
                        FieldList.CreateDate,
                        FieldList.DosiersNo,
                        FieldList.PatientName,
                        FieldList.PatientFamily,
                        FieldList.ParentName,
                        FieldList.Sex,
                        FieldList.IDNO,
                        FieldList.NationalCode,
                        FieldList.Martyr_Id,
                        FieldList.PatientTypeStr,
                        FieldList.InjuryTypeStr,
                        FieldList.BrithDate,
                        FieldList.BrithCityName,
                        FieldList.PercentState,
                        FieldList.SingleOrNo,
                        FieldList.BonyadAddEven,
                        FieldList.BonyadDosier,
                        FieldList.StatePart,
                        FieldList.CityState,
                        FieldList.CityPart,
                        FieldList.InstitutePart,
                        FieldList.AddressPart,
                        FieldList.Address,
                        FieldList.PostalCode,
                        FieldList.TelHome,
                        FieldList.TelBusiness,
                        FieldList.Mobile,
                        FieldList.Mobile2,
                        FieldList.Email,
                        FieldList.BasicInsurance,
                        FieldList.CompletionInsurance,
                        FieldList.LastDoctorVisit_Id,
                        FieldList.LastVisitDate,
                        FieldList.LastDoctorPhysiotherapy_Id,
                        FieldList.LastPhysiotherapyDate,
                        FieldList.LastDoctorHealthCare_Id,
                        FieldList.LastHealthCareDate,
                        FieldList.LastVisitPatientCare_Id,
                        FieldList.LastCareDate,
                        FieldList.Bank_Id,
                        FieldList.AccountNo1,
                        FieldList.AccountNo2,
                        FieldList.AccountNo3,
                        FieldList.Description,
                        "",
                        true,
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

        public bool UpdateEntity(List<TBL_Patient> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_Patient FieldList in ListObj)
                {
                    DRN.SP_PatientUpdate(
                        FieldList.Id,
                        FieldList.CreateDate,
                        FieldList.DosiersNo,
                        FieldList.PatientName,
                        FieldList.PatientFamily,
                        FieldList.ParentName,
                        FieldList.Sex,
                        FieldList.IDNO,
                        FieldList.NationalCode,
                        FieldList.Martyr_Id,
                        FieldList.PatientTypeStr,
                        FieldList.InjuryTypeStr,
                        FieldList.BrithDate,
                        FieldList.BrithCityName,
                        FieldList.PercentState,
                        FieldList.SingleOrNo,
                        FieldList.BonyadAddEven,
                        FieldList.BonyadDosier,
                        FieldList.StatePart,
                        FieldList.CityState,
                        FieldList.CityPart,
                        FieldList.InstitutePart,
                        FieldList.AddressPart,
                        FieldList.Address,
                        FieldList.PostalCode,
                        FieldList.TelHome,
                        FieldList.TelBusiness,
                        FieldList.Mobile,
                        FieldList.Mobile2,
                        FieldList.Email,
                        FieldList.BasicInsurance,
                        FieldList.CompletionInsurance,
                        FieldList.LastDoctorVisit_Id,
                        FieldList.LastVisitDate,
                        FieldList.LastDoctorPhysiotherapy_Id,
                        FieldList.LastPhysiotherapyDate,
                        FieldList.LastDoctorHealthCare_Id,
                        FieldList.LastHealthCareDate,
                        FieldList.LastVisitPatientCare_Id,
                        FieldList.LastCareDate,
                        FieldList.Bank_Id,
                        FieldList.AccountNo1,
                        FieldList.AccountNo2,
                        FieldList.AccountNo3,
                        FieldList.Description,
                        FieldList.DeActiveDsc,
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

        public bool DeleteEntity(List<TBL_Patient> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_Patient FieldList in ListObj)
                {
                    DRN.SP_PatientDelete(
                        FieldList.Id,
                        ref msgRet
                     );
                }
                DRN.SubmitChanges();

                long? idRet = 0;
                foreach (TBL_Patient LogFieldList in ListObj)
                {
                    MKH.Permission.Model.Log.dbo_TBL_Patient Login = new MKH.Permission.Model.Log.dbo_TBL_Patient()
                    {
                        ComputerName = new MSSConfigHelp().ComputerName,
                        UserProfile = new MSSConfigHelp().CurrentWinUserName,
                        ActionType_Id = 3,
                        Id = LogFieldList.Id,
                        PatientName = LogFieldList.PatientName,
                        PatientFamily = LogFieldList.PatientFamily,
                        NationalCode = LogFieldList.NationalCode,
                        LastDoctorVisit_Id = LogFieldList.LastDoctorVisit_Id,
                        LastVisitDate = LogFieldList.LastVisitDate,
                        LastDoctorPhysiotherapy_Id = LogFieldList.LastDoctorPhysiotherapy_Id,
                        LastPhysiotherapyDate = LogFieldList.LastPhysiotherapyDate,
                        LastDoctorHealthCare_Id = LogFieldList.LastDoctorHealthCare_Id,
                        LastHealthCareDate = LogFieldList.LastHealthCareDate,
                        LastVisitPatientCare_Id = LogFieldList.LastVisitPatientCare_Id,
                        LastCareDate = LogFieldList.LastCareDate,
                        Sex = LogFieldList.Sex,
                        BonyadAddEven = LogFieldList.BonyadAddEven,
                        Bank_Id = LogFieldList.Bank_Id,

                        DosiersNo = LogFieldList.DosiersNo,
                        ParentName = LogFieldList.ParentName,
                        IDNO = LogFieldList.IDNO,
                        PatientTypeStr = LogFieldList.PatientTypeStr,
                        InjuryTypeStr = LogFieldList.InjuryTypeStr,
                        BrithDate = LogFieldList.BrithDate,
                        BrithCityName = LogFieldList.BrithCityName,
                        PercentState = LogFieldList.PercentState,
                    
                        SingleOrNo = LogFieldList.SingleOrNo,
                        BonyadDosier = LogFieldList.BonyadDosier,
                        StatePart = LogFieldList.StatePart,
                        CityState = LogFieldList.CityState,
                        CityPart = LogFieldList.CityPart,
                        InstitutePart = LogFieldList.InstitutePart,
                        AddressPart = LogFieldList.AddressPart,
                        Address = LogFieldList.Address,
                        PostalCode = LogFieldList.PostalCode,
                        TelHome = LogFieldList.TelHome,
                        TelBusiness = LogFieldList.TelBusiness,
                        Mobile = LogFieldList.Mobile,
                        Mobile2 = LogFieldList.Mobile2,
                        Email = LogFieldList.Email,
                        BasicInsurance = LogFieldList.BasicInsurance,
                        CompletionInsurance = LogFieldList.CompletionInsurance,
                        AccountNo1 = LogFieldList.AccountNo1,
                        AccountNo2 = LogFieldList.AccountNo2,
                        AccountNo3 = LogFieldList.AccountNo3,
                        Description = LogFieldList.Description,
                        DeActiveDsc = LogFieldList.DeActiveDsc,
                        
                        Active = LogFieldList.Active,
                        User_Id = MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                        ChangeDateTime = MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now),
                    };
                    List<MKH.Permission.Model.Log.dbo_TBL_Patient> A = new List<MKH.Permission.Model.Log.dbo_TBL_Patient>();
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


        public List<VW_Patient> GetAllList(ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_Patients select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_Patient> GetAllListByID(int Id, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_Patients where d.Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<TBL_Patient> GetAllListByTblID(int Id, ref string msgRet)
        {
            try
            {
                return (from d in DRN.TBL_Patients where d.Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_Patient> GetAllListByFilter(List<MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.Filter> filter, ref string msgRet)
        {
            try
            {
                var deleg = MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.GetExpression<VW_Patient>(filter).Compile();
                var filteredCollection = (from d in DRN.VW_Patients select d).Where(deleg);
                return filteredCollection.ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public int CountAll(List<VW_Patient> ListObj)
        {
            return ListObj.Count();
        }

        public List<VW_Patient> GetAllListByDetailRow(int Id, long DetailRowId, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_Patients where d.Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }



        public bool UpdateEntityWithFieldValue(int Id, string FieldName, string FieldValue, int User_Id, string ChangeDateTime, ref string msgRet)
        {
            try
            {
                DRN.SP_PatientUpdateWithFieldValue(
                    Id,
                    FieldName,
                    FieldValue,
                    User_Id,
                    ChangeDateTime,
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

        public bool UpdateTableNameWithNullValue(int Id, string FieldName, int User_Id, string ChangeDateTime, ref string msgRet)
        {
            try
            {
                DRN.SP_TableNameUpdateWithNullValue(
                    Id,
                    "dbo.TBL_Patient",
                    FieldName,
                    User_Id,
                    ChangeDateTime,
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

        public bool UpdatePatientInjuryStr(int PatientId, ref string msgRet)
        {
            try
            {
                DRN.SP_PatientInjuryStrUpdate(
                    PatientId,
                    ref msgRet);

                DRN.SubmitChanges();

                return true;
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return false;
        }


        public bool UpdatePatientDel(int PatientId, bool ActiveOrNo, string DeActiveDsc, ref string msgRet)
        {
            try
            {
                DRN.SP_PatientDelUpdate(
                    PatientId,
                    ActiveOrNo,
                    DeActiveDsc,
                    MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                    MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now),
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



        public bool PatientReIndexForAllAction(ref string msgRet)
        {
            try
            {
                DRN.SP_PatientReIndexForAllAction(
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
