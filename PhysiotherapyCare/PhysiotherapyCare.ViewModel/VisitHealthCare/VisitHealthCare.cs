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
    public class VisitHealthCare : IInsUpDel<TBL_VisitHealthCare, long?>,
        IGetList<VW_VisitHealthCare,long>, IDataErrorInfo, INotifyPropertyChanged
    {
       
        #region Constructor

        public VisitHealthCare()
        {

        }
        #endregion

        #region Properties

        DataClassesVisitHealthCareDataContext DRN = new DataClassesVisitHealthCareDataContext(MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.InternalConnectionString);

        public bool InsertEntity(List<TBL_VisitHealthCare> ListObj, ref string msgRet, ref long? idRet)
        {
            try
            {
                foreach (TBL_VisitHealthCare FieldList in ListObj)
                {
                    DRN.SP_VisitHealthCareInsert(
                        ref idRet,
                        FieldList.Patient_Id,
                        FieldList.IssueArchive,
                        FieldList.LetterNo,
                        FieldList.LetterDate,
                        FieldList.Doctor_Id,
                        FieldList.RequestDate,
                        FieldList.PatientProblem,
                        FieldList.HealthCareDate,
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

        public bool UpdateEntity(List<TBL_VisitHealthCare> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_VisitHealthCare FieldList in ListObj)
                {
                    DRN.SP_VisitHealthCareUpdate(
                        FieldList.Id,
                        FieldList.Patient_Id,
                        FieldList.IssueArchive,
                        FieldList.LetterNo,
                        FieldList.LetterDate,
                        FieldList.Doctor_Id,
                        FieldList.RequestDate,
                        FieldList.PatientProblem,
                        FieldList.HealthCareDate,
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

        public bool DeleteEntity(List<TBL_VisitHealthCare> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_VisitHealthCare FieldList in ListObj)
                {
                    DRN.SP_VisitHealthCareDelete(
                        FieldList.Id,
                        ref msgRet
                     );
                }
                DRN.SubmitChanges();

                long? idRet = 0;
                foreach (TBL_VisitHealthCare LogFieldList in ListObj)
                {
                    MKH.Permission.Model.Log.dbo_TBL_VisitHealthCare Login = new MKH.Permission.Model.Log.dbo_TBL_VisitHealthCare()
                    {
                        ComputerName = new MSSConfigHelp().ComputerName,
                        UserProfile = new MSSConfigHelp().CurrentWinUserName,
                        ActionType_Id = 3,
                        Id = LogFieldList.Id,
                        Patient_Id = LogFieldList.Patient_Id,
                        Doctor_Id = LogFieldList.Doctor_Id,
                        VisitStatus_Id = LogFieldList.VisitStatus_Id,
                        Description = LogFieldList.Description,
                        HealthCareDate = LogFieldList.HealthCareDate,
                        IssueArchive = LogFieldList.IssueArchive,
                        LetterDate = LogFieldList.LetterDate,
                        LetterNo = LogFieldList.LetterNo,
                        PatientProblem = LogFieldList.PatientProblem,
                        ReciveFileDate = LogFieldList.ReciveFileDate,
                        RequestDate = LogFieldList.RequestDate,
                        
                        User_Id = MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                        ChangeDateTime = MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now),
                    };
                    List<MKH.Permission.Model.Log.dbo_TBL_VisitHealthCare> A = new List<MKH.Permission.Model.Log.dbo_TBL_VisitHealthCare>();
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


        public List<VW_VisitHealthCare> GetAllList(ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_VisitHealthCares select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_VisitHealthCare> GetAllListByID(long Id, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_VisitHealthCares where d.Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<TBL_VisitHealthCare> GetAllListByTblID(long Id, ref string msgRet)
        {
            try
            {
                return (from d in DRN.TBL_VisitHealthCares where d.Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_VisitHealthCare> GetAllListByFilter(List<MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.Filter> filter, ref string msgRet)
        {
            try
            {
                var deleg = MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.GetExpression<VW_VisitHealthCare>(filter).Compile();
                var filteredCollection = (from d in DRN.VW_VisitHealthCares select d).Where(deleg);
                return filteredCollection.ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public int CountAll(List<VW_VisitHealthCare> ListObj)
        {
            return ListObj.Count();
        }

        public List<VW_VisitHealthCare> GetAllListByDetailRow(long Id, long DetailRowId, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_VisitHealthCares where d.Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }


        public bool UpdateVisitStatus(long Id, short VisitStatus_Id, int User_Id, string ChangeDateTime, ref string msgRet)
        {
            try
            {
                DRN.SP_VisitHealthCareVisitStatusUpdate(
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

        public List<VW_VisitHealthCare> GetAllListByLastPatientID(int PatientId, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_VisitHealthCares where d.Patient_Id == PatientId orderby d.HealthCareDate descending select d).ToList();
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
                DRN.SP_VisitHealthCareUpdateWithFieldValue(
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

        public List<SP_VisitHealthCareReportResult> GetReport(string DateStart, string DateEnd, bool MonthSet, ref string msgRet)
        {
            try
            {
                return (from d in DRN.SP_VisitHealthCareReport(DateStart, DateEnd, MonthSet) select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<SP_VisitHealthCareReportForDetailResult> GetReportForDetail(string DateStart, string DateEnd, ref string msgRet)
        {
            try
            {
                return (from d in DRN.SP_VisitHealthCareReportForDetail(DateStart, DateEnd) select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }
        public List<SP_VisitHealthCareReportForDetailSumResult> GetReportForDetailSum(string DateStart, string DateEnd, ref string msgRet)
        {
            try
            {
                return (from d in DRN.SP_VisitHealthCareReportForDetailSum(DateStart, DateEnd) select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }


        public List<SP_VisitHealthCareWithServiceHealthCareReportResult> GetReportWithService(string WhereStr, ref string msgRet)
        {
            try
            {

                return (from d in DRN.SP_VisitHealthCareWithServiceHealthCareReport(WhereStr) select d).ToList();
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
