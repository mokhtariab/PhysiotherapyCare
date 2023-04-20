  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using PhysiotherapyCare.Model;
using MKH.Library.Clasess.Security;
using PhysiotherapyCare.Model.VisitPatientCare;


namespace PhysiotherapyCare.ViewModel.VisitPatientCare
{
    public class VisitPatientCarePayment : IInsUpDel<TBL_VisitPatientCarePayment, long?>,
        IGetList<VW_VisitPatientCarePayment, long>, IDataErrorInfo, INotifyPropertyChanged
    {
       
        #region Constructor

        public VisitPatientCarePayment()
        {

        }
        #endregion

        #region Properties

        DataClassesVisitPatientCarePaymentDataContext DRN = new DataClassesVisitPatientCarePaymentDataContext(MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.InternalConnectionString);

        public bool InsertEntity(List<TBL_VisitPatientCarePayment> ListObj, ref string msgRet, ref long? idRet)
        {
            try
            {
                foreach (TBL_VisitPatientCarePayment FieldList in ListObj)
                {
                    DRN.SP_VisitPatientCarePaymentInsert(
                        ref idRet,
                        FieldList.VisitPatientCare_Id,
                        FieldList.Patient_Id,
                        FieldList.Doctor_Id,

                        FieldList.DosiersNo,
                        FieldList.PatientName,
                        FieldList.PatientFamily,
                        FieldList.ParentName,
                        FieldList.SexStr,
                        FieldList.IDNO,
                        FieldList.NationalCode,
                        FieldList.PatientTypeStr,
                        FieldList.InjuryTypeStr,
                        FieldList.BrithDate,
                        FieldList.BrithCityName,
                        FieldList.PercentState,
                        FieldList.SingleOrNo,
                        FieldList.BonyadAddEvenStr,
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
                        FieldList.IssueArchive,
                        FieldList.LetterNo,
                        FieldList.LetterDate,
                        FieldList.ContractNo,
                        FieldList.ContractDate,
                        FieldList.CarrierName,
                        FieldList.CarrierFamily,
                        FieldList.CarrierNationalCode,
                        FieldList.CarrierSexStr,
                        FieldList.CarrierBrithDate,
                        FieldList.CarrierAddress,
                        FieldList.CarrierTelHome,
                        FieldList.CarrierMobile,
                        FieldList.KinShipName,
                        FieldList.PatientFillAccount,

                        FieldList.PaymentDate,
                        FieldList.BeginDate,
                        FieldList.EndDate,
                        FieldList.DurationDays,
                        FieldList.ShiftFew,
                        FieldList.CasherName,
                        FieldList.CasherKinship_Id,
                        FieldList.CasherNationalCode,
                        FieldList.Bank_Id,
                        FieldList.CardBankNo1,
                        FieldList.CardBankNo2,
                        FieldList.PaymentType_Id,
                        FieldList.PaymentStatus_Id,
                        FieldList.PaymentStatusDate,
                        
                        FieldList.InsuLetterNo,
                        FieldList.InsuLetterDate,
                        FieldList.CostReqInsu,
                        FieldList.CostCachInsu,
                        
                        FieldList.ReportCode,
                        FieldList.BonyadConfirmNo,
                        FieldList.BonyadConfirmDate,
                        FieldList.SecretiatNo,
                        FieldList.SecretiatDate,
                        FieldList.AnalyzePage,
                        FieldList.AnalyzeNo,
                        FieldList.AnalyzeDate,
                        FieldList.AccountingDocumentNumber,
                        FieldList.AccountingDocumentDate,
                        FieldList.BursaryNumber,
                        FieldList.BursaryDate,

                        FieldList.CostCompany,
                        FieldList.CostIncrease,
                        FieldList.CostIncreaseDate,
                        FieldList.CostDoctorTax,
                        FieldList.CostDoctorInsurance,
                        FieldList.CostDoctorPrePayment,
                        
                        FieldList.CostDoctor,
                        FieldList.CostVisitDoctorBes,
                        FieldList.CostVisitDoctorRemind,
                        FieldList.PaymentDoctorDate,
                        FieldList.Description,
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

        public bool UpdateEntity(List<TBL_VisitPatientCarePayment> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_VisitPatientCarePayment FieldList in ListObj)
                {
                    DRN.SP_VisitPatientCarePaymentUpdate(
                        FieldList.Id,
                        FieldList.VisitPatientCare_Id,
                        FieldList.Patient_Id,
                        FieldList.Doctor_Id,
                        FieldList.PaymentDate,
                        FieldList.BeginDate,
                        FieldList.EndDate,
                        FieldList.DurationDays,
                        FieldList.ShiftFew,
                        FieldList.CasherName,
                        FieldList.CasherKinship_Id,
                        FieldList.CasherNationalCode,
                        FieldList.Bank_Id,
                        FieldList.CardBankNo1,
                        FieldList.CardBankNo2,
                        FieldList.PaymentType_Id,
                        FieldList.PaymentStatus_Id,
                        FieldList.PaymentStatusDate,

                        FieldList.InsuLetterNo,
                        FieldList.InsuLetterDate,
                        FieldList.CostReqInsu,
                        FieldList.CostCachInsu,

                        FieldList.ReportCode,
                        FieldList.BonyadConfirmNo,
                        FieldList.BonyadConfirmDate,
                        FieldList.SecretiatNo,
                        FieldList.SecretiatDate,
                        FieldList.AnalyzePage,
                        FieldList.AnalyzeNo,
                        FieldList.AnalyzeDate,
                        FieldList.AccountingDocumentNumber,
                        FieldList.AccountingDocumentDate,
                        FieldList.BursaryNumber,
                        FieldList.BursaryDate,
                        
                        FieldList.CostCompany,
                        FieldList.CostIncrease,
                        FieldList.CostIncreaseDate,
                        FieldList.CostDoctorTax,
                        FieldList.CostDoctorInsurance,
                        FieldList.CostDoctorPrePayment,
                        
                        FieldList.CostDoctor,
                        FieldList.CostVisitDoctorBes,
                        FieldList.CostVisitDoctorRemind,
                        FieldList.PaymentDoctorDate,
                        FieldList.Description,
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


        public bool UpdateEntityForDetail(List<TBL_VisitPatientCarePayment> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_VisitPatientCarePayment FieldList in ListObj)
                {
                    DRN.SP_VisitPatientCarePaymentForDetailUpdate(
                        FieldList.Id,
                        FieldList.CasherName,
                        FieldList.CasherNationalCode,
                        FieldList.Bank_Id,
                        FieldList.CardBankNo1,
                        FieldList.PaymentDate,

                        FieldList.PaymentStatus_Id,
                        FieldList.PaymentStatusDate,

                        //FieldList.InsuLetterNo,
                        //FieldList.InsuLetterDate,
                        //FieldList.CostReqInsu,
                        FieldList.CostCachInsu,
                        //FieldList.ReportCode,
                        FieldList.BonyadConfirmNo,
                        FieldList.BonyadConfirmDate,
                        FieldList.SecretiatNo,
                        FieldList.SecretiatDate,
                        FieldList.AnalyzePage,
                        FieldList.AnalyzeNo,
                        FieldList.AnalyzeDate,
                        FieldList.AccountingDocumentNumber,
                        FieldList.AccountingDocumentDate,
                        FieldList.BursaryNumber,
                        FieldList.BursaryDate,

                        FieldList.CostCompany,
                        FieldList.CostIncrease,
                        FieldList.CostIncreaseDate,
                        FieldList.CostDoctor,
                        FieldList.CostVisitDoctorBes,
                        FieldList.CostVisitDoctorRemind,
                        FieldList.PaymentDoctorDate,
                        FieldList.Description,
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

        public bool UpdateEntityForDetailBimeh(List<TBL_VisitPatientCarePayment> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_VisitPatientCarePayment FieldList in ListObj)
                {
                    DRN.SP_VisitPatientCarePaymentForDetailBimehUpdate(
                        FieldList.Id,
                        FieldList.CasherName,
                        FieldList.CasherNationalCode,
                        FieldList.Bank_Id,
                        FieldList.CardBankNo1,

                        FieldList.InsuLetterNo,
                        FieldList.InsuLetterDate,
                        FieldList.CostReqInsu,
                        //FieldList.CostCachInsu,
                        FieldList.ReportCode,
                        //FieldList.BonyadConfirmNo,
                        //FieldList.BonyadConfirmDate,
                        //FieldList.SecretiatNo,
                        //FieldList.SecretiatDate,
                        //FieldList.AnalyzePage,
                        //FieldList.AnalyzeNo,
                        //FieldList.AnalyzeDate,
                        //FieldList.AccountingDocumentNumber,
                        //FieldList.AccountingDocumentDate,
                        //FieldList.BursaryNumber,
                        //FieldList.BursaryDate,

                        //FieldList.CostCompany,
                        //FieldList.CostIncrease,
                        //FieldList.CostIncreaseDate,
                        //FieldList.CostDoctor,
                        //FieldList.CostVisitDoctorBes,
                        //FieldList.CostVisitDoctorRemind,
                        //FieldList.PaymentDoctorDate,
                        //FieldList.Description,
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




        public bool DeleteEntity(List<TBL_VisitPatientCarePayment> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_VisitPatientCarePayment FieldList in ListObj)
                {
                    DRN.SP_VisitPatientCarePaymentDelete(
                        FieldList.Id,
                        ref msgRet
                     );
                }
                DRN.SubmitChanges();

                long? idRet = 0;
                foreach (TBL_VisitPatientCarePayment LogFieldList in ListObj)
                {
                    MKH.Permission.Model.Log.dbo_TBL_VisitPatientCarePayment Login = new MKH.Permission.Model.Log.dbo_TBL_VisitPatientCarePayment()
                    {
                        ComputerName = new MSSConfigHelp().ComputerName,
                        UserProfile = new MSSConfigHelp().CurrentWinUserName,
                        ActionType_Id = 3,
                        Id = LogFieldList.Id,

                        VisitPatientCare_Id = LogFieldList.VisitPatientCare_Id,
                        PaymentType_Id = LogFieldList.PaymentType_Id,
                        PaymentStatus_Id = LogFieldList.PaymentStatus_Id,

                        AccountingDocumentDate = LogFieldList.AccountingDocumentDate,
                        AccountingDocumentNumber = LogFieldList.AccountingDocumentNumber,
                        Address = LogFieldList.Address,
                        AddressPart = LogFieldList.AddressPart,
                        AnalyzeDate = LogFieldList.AnalyzeDate,
                        AnalyzeNo = LogFieldList.AnalyzeNo,
                        AnalyzePage = LogFieldList.AnalyzePage,
                        BasicInsurance = LogFieldList.BasicInsurance,
                        BonyadAddEvenStr = LogFieldList.BonyadAddEvenStr,
                        BonyadConfirmDate = LogFieldList.BonyadConfirmDate,
                        BonyadConfirmNo = LogFieldList.BonyadConfirmNo,
                        BrithCityName = LogFieldList.BrithCityName,
                        BrithDate = LogFieldList.BrithDate,
                        BursaryDate = LogFieldList.BursaryDate,
                        BursaryNumber = LogFieldList.BursaryNumber,
                        CardBankNo1 = LogFieldList.CardBankNo1,
                        CardBankNo2 = LogFieldList.CardBankNo2,
                        CityPart = LogFieldList.CityPart,
                        CompletionInsurance = LogFieldList.CompletionInsurance,
                        ContractDate = LogFieldList.ContractDate,
                        ContractNo = LogFieldList.ContractNo,
                        CostCachInsu = LogFieldList.CostCachInsu,
                        CostCompany = LogFieldList.CostCompany,
                        CostDoctor = LogFieldList.CostDoctor,
                        CostIncrease = LogFieldList.CostIncrease,
                        CostIncreaseDate = LogFieldList.CostIncreaseDate,
                        CostReqInsu = LogFieldList.CostReqInsu,
                        CostVisitDoctorBes = LogFieldList.CostVisitDoctorBes,
                        CostVisitDoctorRemind = LogFieldList.CostVisitDoctorRemind,
                        Description = LogFieldList.Description,
                        Doctor_Id = LogFieldList.Doctor_Id,
                        DosiersNo = LogFieldList.DosiersNo,
                        Email = LogFieldList.Email,
                        IDNO = LogFieldList.IDNO,
                        InjuryTypeStr = LogFieldList.InjuryTypeStr,
                        InstitutePart = LogFieldList.InstitutePart,
                        InsuLetterDate = LogFieldList.InsuLetterNo,
                        InsuLetterNo = LogFieldList.InsuLetterNo,
                        IssueArchive = LogFieldList.IssueArchive,
                        LetterDate = LogFieldList.LetterDate,
                        LetterNo = LogFieldList.LetterNo,
                        Mobile = LogFieldList.Mobile,
                        Mobile2 = LogFieldList.Mobile2,
                        NationalCode = LogFieldList.NationalCode,
                        ParentName = LogFieldList.ParentName,
                        Patient_Id = LogFieldList.Patient_Id,
                        PatientFamily = LogFieldList.PatientFamily,
                        PatientName = LogFieldList.PatientName,
                        PatientTypeStr = LogFieldList.PatientTypeStr,
                        PaymentDate = LogFieldList.PaymentDate,
                        PaymentDoctorDate = LogFieldList.PaymentDoctorDate,
                        PaymentStatusDate = LogFieldList.PaymentStatusDate,
                        PercentState = LogFieldList.PercentState,
                        PostalCode = LogFieldList.PostalCode,
                        ReportCode = LogFieldList.ReportCode,
                        SecretiatDate = LogFieldList.SecretiatDate,
                        SecretiatNo = LogFieldList.SecretiatNo,
                        SexStr = LogFieldList.SexStr,
                        SingleOrNo = LogFieldList.SingleOrNo,
                        TelBusiness = LogFieldList.TelBusiness,
                        TelHome = LogFieldList.TelHome,

                        Bank_Id = LogFieldList.Bank_Id,
                        BeginDate = LogFieldList.BeginDate,
                        CarrierAddress = LogFieldList.CarrierAddress,
                        CarrierBrithDate = LogFieldList.CarrierBrithDate,
                        CarrierFamily = LogFieldList.CarrierFamily,
                        CarrierMobile = LogFieldList.CarrierMobile,
                        CarrierName = LogFieldList.CarrierName,
                        CarrierNationalCode = LogFieldList.CarrierNationalCode,
                        CarrierSexStr = LogFieldList.CarrierSexStr,
                        CarrierTelHome = LogFieldList.CarrierTelHome,
                        CasherKinship_Id = LogFieldList.CasherKinship_Id,
                        CasherName = LogFieldList.CasherName,
                        CasherNationalCode = LogFieldList.CasherNationalCode,
                        DurationDays = LogFieldList.DurationDays,
                        EndDate = LogFieldList.EndDate,
                        KinShipName = LogFieldList.KinShipName,
                        PatientFillAccount = LogFieldList.PatientFillAccount,
                        ShiftFew = LogFieldList.ShiftFew,

                        CostDoctorTax = LogFieldList.CostDoctorTax,
                        CostDoctorInsurance = LogFieldList.CostDoctorInsurance,
                        CostDoctorPrePayment = LogFieldList.CostDoctorPrePayment,

                        BonyadDosier = LogFieldList.BonyadDosier,
                        StatePart = LogFieldList.StatePart,
                        CityState = LogFieldList.CityState,


                        User_Id = MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                        ChangeDateTime = MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now),
                    };
                    List<MKH.Permission.Model.Log.dbo_TBL_VisitPatientCarePayment> A = new List<MKH.Permission.Model.Log.dbo_TBL_VisitPatientCarePayment>();
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


        public List<VW_VisitPatientCarePayment> GetAllList(ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_VisitPatientCarePayments select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_VisitPatientCarePayment> GetAllListByID(long Id, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_VisitPatientCarePayments where d.Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<TBL_VisitPatientCarePayment> GetAllListByTblID(long Id, ref string msgRet)
        {
            try
            {
                return (from d in DRN.TBL_VisitPatientCarePayments where d.Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_VisitPatientCarePayment> GetAllListByFilter(List<MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.Filter> filter, ref string msgRet)
        {
            try
            {
                var deleg = MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.GetExpression<VW_VisitPatientCarePayment>(filter).Compile();
                var filteredCollection = (from d in DRN.VW_VisitPatientCarePayments select d).Where(deleg);
                return filteredCollection.ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public int CountAll(List<VW_VisitPatientCarePayment> ListObj)
        {
            return ListObj.Count();
        }

        public List<VW_VisitPatientCarePayment> GetAllListByDetailRow(long Id, long DetailRowId, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_VisitPatientCarePayments where d.VisitPatientCare_Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }


        public bool UpdateEntityWithFieldValue(long Id, string FieldName, string FieldValue, int User_Id, string ChangeDateTime, ref string msgRet)
        {
            try
            {
                DRN.SP_VisitPatientCarePaymentUpdateWithFieldValue(
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


        public bool VisitPatientCarePaymentCalculateRemind(string CasherNationalCode, ref string msgRet)
        {
            try
            {
                DRN.SP_VisitPatientCarePaymentCalculateRemind(
                    CasherNationalCode
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


        public bool VisitPatientCarePaymentCalculateRemindAllPayment(ref string msgRet)
        {
            try
            {
                DRN.SP_VisitPatientCarePaymentCalculateRemindAllPayment();
                DRN.SubmitChanges();

                return true;
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return false;
        }


//        public List<SP_VisitPatientCarePaymentReportResult> GetReport(string DateStart, string DateEnd, bool MonthSet, ref string msgRet)
        public List<SP_VisitPatientCarePaymentReportResult> GetReport(string FieldGroup, string FieldDateGroup, string WhereStr, ref string msgRet)
        {
            try
            {
                return (from d in DRN.SP_VisitPatientCarePaymentReport(FieldGroup, FieldDateGroup, WhereStr) select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<SP_VisitPatientCarePaymentForPrePaymentResult> GetAllListForPrePayment(string CasherNationalCode, ref string msgRet)
        {
            try
            {
                return (from d in DRN.SP_VisitPatientCarePaymentForPrePayment(CasherNationalCode) select d).ToList();
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
