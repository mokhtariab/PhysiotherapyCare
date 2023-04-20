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
    public class VisitPatientCare : IInsUpDel<TBL_VisitPatientCare, long?>,
        IGetList<VW_VisitPatientCare,long>, IDataErrorInfo, INotifyPropertyChanged
    {
       
        #region Constructor

        public VisitPatientCare()
        {

        }
        #endregion

        #region Properties

        DataClassesVisitPatientCareDataContext DRN = new DataClassesVisitPatientCareDataContext(MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.InternalConnectionString);

        public bool InsertEntity(List<TBL_VisitPatientCare> ListObj, ref string msgRet, ref long? idRet)
        {
            try
            {
                foreach (TBL_VisitPatientCare FieldList in ListObj)
                {
                    DRN.SP_VisitPatientCareInsert(
                        ref idRet,
                        FieldList.Patient_Id,
                        FieldList.IssueArchive,
                        FieldList.LetterNo,
                        FieldList.LetterDate,
                        FieldList.ContractNo,
                        FieldList.ContractDate,
                        FieldList.Doctor_Id,
                        FieldList.CarrierName,
                        FieldList.CarrierFamily,
                        FieldList.CarrierNationalCode,
                        FieldList.CarrierSex,
                        FieldList.CarrierBrithDate,
                        FieldList.CarrierAddress,
                        FieldList.CarrierTelHome,
                        FieldList.CarrierMobile,
                        FieldList.Bank_Id,
                        FieldList.CardBankNo1,
                        FieldList.CardBankNo2,
                        FieldList.KinShip_Id,
                        FieldList.PatientFillAccount,
                        FieldList.ShiftFew,
                        FieldList.BeginDate,
                        FieldList.EndDate,
                        FieldList.VisitStatus_Id,
                        FieldList.ReciveFileDate,
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

        public bool UpdateEntity(List<TBL_VisitPatientCare> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_VisitPatientCare FieldList in ListObj)
                {
                    DRN.SP_VisitPatientCareUpdate(
                        FieldList.Id,
                        FieldList.Patient_Id,
                        FieldList.IssueArchive,
                        FieldList.LetterNo,
                        FieldList.LetterDate,
                        FieldList.ContractNo,
                        FieldList.ContractDate,
                        FieldList.Doctor_Id,
                        FieldList.CarrierName,
                        FieldList.CarrierFamily,
                        FieldList.CarrierNationalCode,
                        FieldList.CarrierSex,
                        FieldList.CarrierBrithDate,
                        FieldList.CarrierAddress,
                        FieldList.CarrierTelHome,
                        FieldList.CarrierMobile,
                        FieldList.Bank_Id,
                        FieldList.CardBankNo1,
                        FieldList.CardBankNo2,
                        FieldList.KinShip_Id,
                        FieldList.PatientFillAccount,
                        FieldList.ShiftFew,
                        FieldList.BeginDate,
                        FieldList.EndDate,
                        FieldList.VisitStatus_Id,
                        FieldList.ReciveFileDate,
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

        public bool DeleteEntity(List<TBL_VisitPatientCare> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_VisitPatientCare FieldList in ListObj)
                {
                    DRN.SP_VisitPatientCareDelete(
                        FieldList.Id,
                        ref msgRet
                     );
                }
                DRN.SubmitChanges();

                long? idRet = 0;
                foreach (TBL_VisitPatientCare LogFieldList in ListObj)
                {
                    MKH.Permission.Model.Log.dbo_TBL_VisitPatientCare Login = new MKH.Permission.Model.Log.dbo_TBL_VisitPatientCare()
                    {
                        ComputerName = new MSSConfigHelp().ComputerName,
                        UserProfile = new MSSConfigHelp().CurrentWinUserName,
                        ActionType_Id = 3,
                        Id = LogFieldList.Id,
                        
                        Patient_Id = LogFieldList.Patient_Id,
                        Bank_Id = LogFieldList.Bank_Id,
                        KinShip_Id = LogFieldList.KinShip_Id,
                        VisitStatus_Id = LogFieldList.VisitStatus_Id,

                        BeginDate = LogFieldList.BeginDate,
                        CarrierAddress = LogFieldList.CarrierAddress,
                        CarrierBrithDate = LogFieldList.CarrierBrithDate,
                        CarrierFamily = LogFieldList.CarrierFamily,
                        CarrierMobile = LogFieldList.CarrierMobile,
                        CarrierName = LogFieldList.CarrierName,
                        CarrierNationalCode = LogFieldList.CarrierNationalCode,
                        CarrierSex = LogFieldList.CarrierSex,
                        CarrierTelHome = LogFieldList.CarrierTelHome,
                        EndDate = LogFieldList.EndDate,
                        PatientFillAccount = LogFieldList.PatientFillAccount,
                        ShiftFew = LogFieldList.ShiftFew,

                        CardBankNo1 = LogFieldList.CardBankNo1,
                        CardBankNo2 = LogFieldList.CardBankNo2,
                        ContractDate = LogFieldList.ContractDate,
                        ContractNo = LogFieldList.ContractNo,
                        Description = LogFieldList.Description,
                        Doctor_Id = LogFieldList.Doctor_Id,
                        IssueArchive = LogFieldList.IssueArchive,
                        LetterDate = LogFieldList.LetterDate,
                        LetterNo = LogFieldList.LetterNo,
                        ReciveFileDate = LogFieldList.ReciveFileDate,

                        User_Id = MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                        ChangeDateTime = MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now),
                    };
                    List<MKH.Permission.Model.Log.dbo_TBL_VisitPatientCare> A = new List<MKH.Permission.Model.Log.dbo_TBL_VisitPatientCare>();
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


        public List<VW_VisitPatientCare> GetAllList(ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_VisitPatientCares select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_VisitPatientCare> GetAllListByID(long Id, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_VisitPatientCares where d.Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<TBL_VisitPatientCare> GetAllListByTblID(long Id, ref string msgRet)
        {
            try
            {
                return (from d in DRN.TBL_VisitPatientCares where d.Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_VisitPatientCare> GetAllListByFilter(List<MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.Filter> filter, ref string msgRet)
        {
            try
            {
                var deleg = MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.GetExpression<VW_VisitPatientCare>(filter).Compile();
                var filteredCollection = (from d in DRN.VW_VisitPatientCares select d).Where(deleg);
                return filteredCollection.ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public int CountAll(List<VW_VisitPatientCare> ListObj)
        {
            return ListObj.Count();
        }

        public List<VW_VisitPatientCare> GetAllListByDetailRow(long Id, long DetailRowId, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_VisitPatientCares where d.Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_VisitPatientCare> GetAllListByLastPatientID(int PatientId, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_VisitPatientCares where d.Patient_Id == PatientId  orderby d.EndDate descending select d).ToList();
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
                DRN.SP_VisitPatientCareUpdateWithFieldValue(
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

        public bool UpdateVisitStatus(long Id, short VisitStatus_Id, int User_Id, string ChangeDateTime, ref string msgRet)
        {
            try
            {
                DRN.SP_VisitPatientCareVisitStatusUpdate(
                    Id,
                    VisitStatus_Id,
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


        public List<SP_VisitPatientCareReportResult> GetReport(string DateStart, string DateEnd, bool MonthSet, ref string msgRet)
        {
            try
            {
                return (from d in DRN.SP_VisitPatientCareReport(DateStart, DateEnd, MonthSet) select d).ToList();
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
