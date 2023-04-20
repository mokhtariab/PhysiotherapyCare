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
    public class VisitPatientPayment : IInsUpDel<TBL_VisitPatientPayment, long?>,
        IGetList<VW_VisitPatientPayment, long>, IDataErrorInfo, INotifyPropertyChanged
    {

        #region Constructor

        public VisitPatientPayment()
        {

        }
        #endregion

        #region Properties

        DataClassesVisitPatientPaymentDataContext DRN = new DataClassesVisitPatientPaymentDataContext(MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.InternalConnectionString);

        public bool InsertEntity(List<TBL_VisitPatientPayment> ListObj, ref string msgRet, ref long? idRet)
        {
            try
            {
                foreach (TBL_VisitPatientPayment FieldList in ListObj)
                {
                    DRN.SP_VisitPatientPaymentInsert(
                        ref idRet,
                        FieldList.VisitPatient_Id,

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

                        , FieldList.VisitDate
                        , FieldList.StateSicknessDsc
                        , FieldList.ParaclinicDsc
                        , FieldList.DrugsDsc
                        , FieldList.BedsoreDsc
                        , FieldList.VaccinationDsc
                        , FieldList.EquipmentUseDsc
                        , FieldList.BonyadAddEvenStr

                        , FieldList.ContractNo
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

                    //for Update VisitPatient Status
                    try
                    {
                        new ViewModel.VisitPatient.VisitPatient().UpdateVisitStatus(
                                                    FieldList.VisitPatient_Id.Value,
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

        public bool UpdateEntity(List<TBL_VisitPatientPayment> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_VisitPatientPayment FieldList in ListObj)
                {
                    DRN.SP_VisitPatientPaymentUpdate(
                        FieldList.Id,
                        FieldList.VisitPatient_Id,
                         FieldList.Patient_Id,

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

        public bool UpdateEntityForDetail(List<TBL_VisitPatientPayment> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_VisitPatientPayment FieldList in ListObj)
                {
                    DRN.SP_VisitPatientPaymentForDetailUpdate(
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

        public bool UpdateEntityForDetailBimeh(List<TBL_VisitPatientPayment> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_VisitPatientPayment FieldList in ListObj)
                {
                    DRN.SP_VisitPatientPaymentForDetailBimehUpdate(
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



        public bool DeleteEntity(List<TBL_VisitPatientPayment> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_VisitPatientPayment FieldList in ListObj)
                {
                    DRN.SP_VisitPatientPaymentDelete(
                        FieldList.Id,
                        ref msgRet
                     );

                    //for Update VisitPatient Status
                    try
                    {
                        new ViewModel.VisitPatient.VisitPatient().UpdateVisitStatus(
                                                    FieldList.VisitPatient_Id.Value,
                                                    1,//درحال انتظار
                                                    FieldList.User_Id.Value,
                                                    FieldList.ChangeDateTime,
                                                    ref msgRet);
                    }
                    catch { }

                }
                DRN.SubmitChanges();

                long? idRet = 0;
                foreach (TBL_VisitPatientPayment LogFieldList in ListObj)
                {
                    MKH.Permission.Model.Log.VST_TBL_VisitPatientPayment Login = new MKH.Permission.Model.Log.VST_TBL_VisitPatientPayment()
                    {
                        ComputerName = new MSSConfigHelp().ComputerName,
                        UserProfile = new MSSConfigHelp().CurrentWinUserName,
                        ActionType_Id = 3,
                        Id = LogFieldList.Id,

                        VisitPatient_Id = LogFieldList.VisitPatient_Id,
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

                        BedsoreDsc = LogFieldList.BedsoreDsc,
                        DrugsDsc = LogFieldList.DrugsDsc,
                        EquipmentUseDsc = LogFieldList.EquipmentUseDsc,
                        ParaclinicDsc = LogFieldList.ParaclinicDsc,
                        StateSicknessDsc = LogFieldList.StateSicknessDsc,
                        VaccinationDsc = LogFieldList.VaccinationDsc,
                        VisitDate = LogFieldList.VisitDate,
                        


                        User_Id = MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                        ChangeDateTime = MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now),
                    };
                    List<MKH.Permission.Model.Log.VST_TBL_VisitPatientPayment> A = new List<MKH.Permission.Model.Log.VST_TBL_VisitPatientPayment>();
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


        public List<VW_VisitPatientPayment> GetAllList(ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_VisitPatientPayments select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<SP_VisitPatientPaymentSelectResult> GetAllListSet(string WhereStr, ref string msgRet)
        {
            try
            {
                return (from d in DRN.SP_VisitPatientPaymentSelect(WhereStr) select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        //public List<VW_DoctorsMehrParvar> GetAllListOld(ref string msgRet)
        //{
        //    try
        //    {
        //        return (from d in DRN.VW_DoctorsMehrParvars select d).ToList();
        //    }
        //    catch (Exception ex)
        //    {
        //        msgRet = ex.Message;
        //    }
        //    return null;
        //}


        public List<VW_VisitPatientPayment> GetAllListByID(long Id, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_VisitPatientPayments where d.Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<TBL_VisitPatientPayment> GetAllListByTblID(long Id, ref string msgRet)
        {
            try
            {
                return (from d in DRN.TBL_VisitPatientPayments where d.Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_VisitPatientPayment> GetAllListByFilter(List<MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.Filter> filter, ref string msgRet)
        {
            try
            {
                var deleg = MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.GetExpression<VW_VisitPatientPayment>(filter).Compile();
                var filteredCollection = (from d in DRN.VW_VisitPatientPayments select d).Where(deleg);
                return filteredCollection.ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public int CountAll(List<VW_VisitPatientPayment> ListObj)
        {
            return ListObj.Count();
        }

        public List<VW_VisitPatientPayment> GetAllListByDetailRow(long Id, long DetailRowId, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_VisitPatientPayments where d.Id == Id select d).ToList();
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
                DRN.SP_VisitPatientPaymentUpdateWithFieldValue(
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


        public bool VisitPatientPaymentCalculateRemind(int Doctor_Id, ref string msgRet)
        {
            try
            {
                DRN.SP_VisitPatientPaymentCalculateRemind(
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


        public bool VisitPatientPaymentCalculateRemindAllPayment(ref string msgRet)
        {
            try
            {
                DRN.SP_VisitPatientPaymentCalculateRemindAllPayment();
                DRN.SubmitChanges();

                return true;
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return false;
        }


        public List<SP_VisitPatientPaymentForPrePaymentResult> GetAllListForPrePayment(int Doctor_Id, ref string msgRet)
        {
            try
            {
                return (from d in DRN.SP_VisitPatientPaymentForPrePayment(Doctor_Id) select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }






























        //public List<SP_VisitPatientPaymentReportResult> GetReport(string DateStart, string DateEnd, bool MonthSet, ref string msgRet)
        //{
        //    try
        //    {
        //        return (from d in DRN.SP_VisitPatientPaymentReport(DateStart, DateEnd, MonthSet) select d).ToList();
        //    }
        //    catch (Exception ex)
        //    {
        //        msgRet = ex.Message;
        //    }
        //    return null;
        //}

        public List<SP_VisitPatientPaymentReportResult> GetReport(string FieldGroup, string FieldDateGroup, string WhereStr, ref string msgRet)
        {
            try
            {
                return (from d in DRN.SP_VisitPatientPaymentReport(FieldGroup, FieldDateGroup, WhereStr) select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<SP_VisitPatientPaymentReportWithDetailResult> GetReportWithDetail(string WhereStr, ref string msgRet)
        {
            try
            {
                return (from d in DRN.SP_VisitPatientPaymentReportWithDetail(WhereStr) select d).ToList();
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
