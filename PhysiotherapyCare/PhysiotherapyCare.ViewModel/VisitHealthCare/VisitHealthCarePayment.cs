  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using PhysiotherapyCare.Model;
using MKH.Library.Clasess.Security;
using PhysiotherapyCare.Model.VisitHealthCare;


namespace PhysiotherapyCare.ViewModel.VisitHealthCare
{
    public class VisitHealthCarePayment : IInsUpDel<TBL_VisitHealthCarePayment, long?>,
        IGetList<VW_VisitHealthCarePayment, long>, IDataErrorInfo, INotifyPropertyChanged
    {
       
        #region Constructor

        public VisitHealthCarePayment()
        {

        }
        #endregion

        #region Properties

        DataClassesVisitHealthCarePaymentDataContext DRN = new DataClassesVisitHealthCarePaymentDataContext(MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.InternalConnectionString);

        public bool InsertEntity(List<TBL_VisitHealthCarePayment> ListObj, ref string msgRet, ref long? idRet)
        {
            try
            {
                foreach (TBL_VisitHealthCarePayment FieldList in ListObj)
                {
                    DRN.SP_VisitHealthCarePaymentInsert(
                        ref idRet,
                        FieldList.VisitHealthCare_Id,

                        FieldList.Patient_Id
                        , FieldList.DosiersNo
                        , FieldList.PatientName
                        , FieldList.PatientFamily
                        , FieldList.ParentName
                        , FieldList.SexStr
                        , FieldList.IDNO
                        , FieldList.NationalCode
                        , FieldList.PatientTypeStr
                        , FieldList.InjuryTypeStr
                        , FieldList.BrithDate
                        , FieldList.BrithCityName
                        , FieldList.PercentState
                        , FieldList.SingleOrNo
                        , FieldList.BonyadAddEvenStr
                        , FieldList.BonyadDosier
                        , FieldList.StatePart
                        , FieldList.CityState
                        , FieldList.CityPart
                        , FieldList.InstitutePart
                        , FieldList.AddressPart
                        , FieldList.Address
                        , FieldList.PostalCode
                        , FieldList.TelHome
                        , FieldList.TelBusiness
                        , FieldList.Mobile
                        , FieldList.Mobile2
                        , FieldList.Email
                        , FieldList.BasicInsurance
                        , FieldList.CompletionInsurance
                        , FieldList.IssueArchive
                        , FieldList.LetterNo
                        , FieldList.LetterDate
                        , FieldList.RequestDate
                        , FieldList.PatientProblem
                        , FieldList.HealthCareDate
                        , FieldList.SumServiceHealthCare
                        , FieldList.SumServiceTypeDscFewHealthCare,
                        FieldList.ContractNo
                        , FieldList.ContractDate
                        , FieldList.MedicalCode
                        , FieldList.DoctorName
                        , FieldList.DoctorFamily
                        , FieldList.DoctorNationalCode
                        , FieldList.DoctorBrithDate
                        , FieldList.LocationPart
                        , FieldList.DoctorAddress
                        , FieldList.DoctorTelBusiness
                        , FieldList.DoctorMobile
                        , FieldList.BankName
                        , FieldList.CardBankNo1
                        , FieldList.CardBankNo2,


                        FieldList.PaymentDate,
                        FieldList.Doctor_Id,

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

                    //for Update VisitHealthCare Status
                    try
                    {
                        new ViewModel.VisitHealthCare.VisitHealthCare().UpdateVisitStatus(
                                FieldList.VisitHealthCare_Id.Value,
                                2,//تایید و ارسال
                                FieldList.User_Id.Value,
                                FieldList.ChangeDateTime,
                                ref msgRet);
                    }
                    catch { }

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

        public bool UpdateEntity(List<TBL_VisitHealthCarePayment> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_VisitHealthCarePayment FieldList in ListObj)
                {
                    DRN.SP_VisitHealthCarePaymentUpdate(
                        FieldList.Id,
                        FieldList.VisitHealthCare_Id,
                        FieldList.PaymentDate,
                        FieldList.Doctor_Id,
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

        public bool UpdateEntityForDetail(List<TBL_VisitHealthCarePayment> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_VisitHealthCarePayment FieldList in ListObj)
                {
                    DRN.SP_VisitHealthCarePaymentForDetailUpdate(
                        FieldList.Id,
                        //FieldList.VisitPatientPhysiotherapy_Id,
                        FieldList.PaymentDate,

                        FieldList.PaymentStatus_Id,
                        FieldList.PaymentStatusDate,

                        FieldList.CostCachInsu,
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

        public bool UpdateEntityForDetailBimeh(List<TBL_VisitHealthCarePayment> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_VisitHealthCarePayment FieldList in ListObj)
                {
                    DRN.SP_VisitHealthCarePaymentForDetailBimehUpdate(
                        FieldList.Id,
                        FieldList.InsuLetterNo,
                        FieldList.InsuLetterDate,
                        FieldList.CostReqInsu,
                        FieldList.ReportCode,
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


        public bool DeleteEntity(List<TBL_VisitHealthCarePayment> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_VisitHealthCarePayment FieldList in ListObj)
                {
                    DRN.SP_VisitHealthCarePaymentDelete(
                        FieldList.Id,
                        ref msgRet
                     );

                    //for Update VisitHealthCare Status
                    try
                    {
                        new ViewModel.VisitHealthCare.VisitHealthCare().UpdateVisitStatus(
                                FieldList.VisitHealthCare_Id.Value,
                                1,//درحال انتظار
                                FieldList.User_Id.Value,
                                FieldList.ChangeDateTime,
                                ref msgRet);
                    }
                    catch { }

                }
                DRN.SubmitChanges();


                long? idRet = 0;
                foreach (TBL_VisitHealthCarePayment LogFieldList in ListObj)
                {
                    MKH.Permission.Model.Log.dbo_TBL_VisitHealthCarePayment Login = new MKH.Permission.Model.Log.dbo_TBL_VisitHealthCarePayment()
                    {
                        ComputerName = new MSSConfigHelp().ComputerName,
                        UserProfile = new MSSConfigHelp().CurrentWinUserName,
                        ActionType_Id = 3,
                        Id = LogFieldList.Id,

                        VisitHealthCare_Id = LogFieldList.VisitHealthCare_Id,
                        PaymentType_Id = LogFieldList.PaymentType_Id,
                        PaymentStatus_Id = LogFieldList.PaymentStatus_Id,

                        AccountingDocumentDate = LogFieldList.AccountingDocumentDate,
                        AccountingDocumentNumber = LogFieldList.AccountingDocumentNumber,
                        Address = LogFieldList.Address,
                        AddressPart = LogFieldList.AddressPart,
                        AnalyzeDate = LogFieldList.AnalyzeDate,
                        AnalyzeNo = LogFieldList.AnalyzeNo,
                        AnalyzePage = LogFieldList.AnalyzePage,
                        BankName = LogFieldList.BankName,
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
                        BonyadDosier = LogFieldList.BonyadDosier,
                        StatePart = LogFieldList.StatePart,
                        CityState = LogFieldList.CityState,
                        CityPart = LogFieldList.CityPart,
                        CompletionInsurance = LogFieldList.CompletionInsurance,
                        ContractDate = LogFieldList.ContractDate,
                        ContractNo = LogFieldList.ContractNo,
                        CostCachInsu = LogFieldList.CostCachInsu,
                        CostCompany = LogFieldList.CostCompany,
                        CostDoctor = LogFieldList.CostDoctor,
                        CostDoctorTax = LogFieldList.CostDoctorTax,
                        CostDoctorInsurance = LogFieldList.CostDoctorInsurance,
                        CostDoctorPrePayment = LogFieldList.CostDoctorPrePayment,
                        CostIncrease = LogFieldList.CostIncrease,
                        CostIncreaseDate = LogFieldList.CostIncreaseDate,
                        CostReqInsu = LogFieldList.CostReqInsu,
                        CostVisitDoctorBes = LogFieldList.CostVisitDoctorBes,
                        CostVisitDoctorRemind = LogFieldList.CostVisitDoctorRemind,
                        Description = LogFieldList.Description,
                        Doctor_Id = LogFieldList.Doctor_Id,
                        DoctorAddress = LogFieldList.DoctorAddress,
                        DoctorBrithDate = LogFieldList.DoctorBrithDate,
                        DoctorFamily = LogFieldList.DoctorFamily,
                        DoctorMobile = LogFieldList.DoctorMobile,
                        DoctorName = LogFieldList.DoctorName,
                        DoctorNationalCode = LogFieldList.DoctorNationalCode,
                        DoctorTelBusiness = LogFieldList.DoctorTelBusiness,
                        DosiersNo = LogFieldList.DosiersNo,
                        Email = LogFieldList.Email,
                        HealthCareDate = LogFieldList.HealthCareDate,
                        IDNO = LogFieldList.IDNO,
                        InjuryTypeStr = LogFieldList.InjuryTypeStr,
                        InstitutePart = LogFieldList.InstitutePart,
                        InsuLetterDate = LogFieldList.InsuLetterNo,
                        InsuLetterNo = LogFieldList.InsuLetterNo,
                        IssueArchive = LogFieldList.IssueArchive,
                        LetterDate = LogFieldList.LetterDate,
                        LetterNo = LogFieldList.LetterNo,
                        LocationPart = LogFieldList.LocationPart,
                        MedicalCode = LogFieldList.MedicalCode,
                        Mobile = LogFieldList.Mobile,
                        Mobile2 = LogFieldList.Mobile2,
                        NationalCode = LogFieldList.NationalCode,
                        ParentName = LogFieldList.ParentName,
                        Patient_Id = LogFieldList.Patient_Id,
                        PatientFamily = LogFieldList.PatientFamily,
                        PatientName = LogFieldList.PatientName,
                        PatientProblem = LogFieldList.PatientProblem,
                        PatientTypeStr = LogFieldList.PatientTypeStr,
                        PaymentDate = LogFieldList.PaymentDate,
                        PaymentDoctorDate = LogFieldList.PaymentDoctorDate,
                        PaymentStatusDate = LogFieldList.PaymentStatusDate,
                        PercentState = LogFieldList.PercentState,
                        PostalCode = LogFieldList.PostalCode,
                        ReportCode = LogFieldList.ReportCode,
                        RequestDate = LogFieldList.RequestDate,
                        SecretiatDate = LogFieldList.SecretiatDate,
                        SecretiatNo = LogFieldList.SecretiatNo,
                        SexStr = LogFieldList.SexStr,
                        SingleOrNo = LogFieldList.SingleOrNo,
                        SumServiceHealthCare = LogFieldList.SumServiceHealthCare,
                        SumServiceTypeDscFewHealthCare = LogFieldList.SumServiceTypeDscFewHealthCare,
                        TelBusiness = LogFieldList.TelBusiness,
                        TelHome = LogFieldList.TelHome,

                        User_Id = MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                        ChangeDateTime = MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now),
                    };
                    List<MKH.Permission.Model.Log.dbo_TBL_VisitHealthCarePayment> A = new List<MKH.Permission.Model.Log.dbo_TBL_VisitHealthCarePayment>();
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


        public List<VW_VisitHealthCarePayment> GetAllList(ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_VisitHealthCarePayments select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_VisitHealthCarePayment> GetAllListByID(long Id, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_VisitHealthCarePayments where d.Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<TBL_VisitHealthCarePayment> GetAllListByTblID(long Id, ref string msgRet)
        {
            try
            {
                return (from d in DRN.TBL_VisitHealthCarePayments where d.Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_VisitHealthCarePayment> GetAllListByFilter(List<MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.Filter> filter, ref string msgRet)
        {
            try
            {
                var deleg = MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.GetExpression<VW_VisitHealthCarePayment>(filter).Compile();
                var filteredCollection = (from d in DRN.VW_VisitHealthCarePayments select d).Where(deleg);
                return filteredCollection.ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public int CountAll(List<VW_VisitHealthCarePayment> ListObj)
        {
            return ListObj.Count();
        }

        public List<VW_VisitHealthCarePayment> GetAllListByDetailRow(long Id, long DetailRowId, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_VisitHealthCarePayments where d.Id == Id select d).ToList();
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
                DRN.SP_VisitHealthCarePaymentUpdateWithFieldValue(
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


        public bool VisitHealthCarePaymentCalculateRemind(int Doctor_Id, ref string msgRet)
        {
            try
            {
                DRN.SP_VisitHealthCarePaymentCalculateRemind(
                    Doctor_Id
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


        public bool VisitHealthCarePaymentCalculateRemindAllPayment(ref string msgRet)
        {
            try
            {
                DRN.SP_VisitHealthCarePaymentCalculateRemindAllPayment();
                DRN.SubmitChanges();

                return true;
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return false;
        }


        //public List<SP_VisitHealthCarePaymentReportResult> GetReport(string DateStart, string DateEnd, bool MonthSet, bool HealthCareOrInsuLetterDate, ref string msgRet)
        public List<SP_VisitHealthCarePaymentReportResult> GetReport(string FieldGroup, string FieldDateGroup, string WhereStr, ref string msgRet)
        {
            try
            {

                return (from d in DRN.SP_VisitHealthCarePaymentReport(FieldGroup, FieldDateGroup, WhereStr) select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<SP_VisitHealthCarePaymentWithServiceHealthCareReportResult> GetReportWithService(string FieldGroup, string FieldDateGroup, string WhereStr, ref string msgRet)
        {
            try
            {

                return (from d in DRN.SP_VisitHealthCarePaymentWithServiceHealthCareReport(FieldGroup, FieldDateGroup, WhereStr) select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<SP_VisitHealthCarePaymentForPrePaymentResult> GetAllListForPrePayment(int Doctor_Id, ref string msgRet)
        {
            try
            {
                return (from d in DRN.SP_VisitHealthCarePaymentForPrePayment(Doctor_Id) select d).ToList();
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
