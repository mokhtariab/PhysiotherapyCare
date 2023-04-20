  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using PhysiotherapyCare.Model;
using MKH.Library.Clasess.Security;
using PhysiotherapyCare.Model.VisitPatientPhysiotherapy;


namespace PhysiotherapyCare.ViewModel.VisitPatientPhysiotherapy
{
    public class VisitPatientPhysiotherapy : IInsUpDel<TBL_VisitPatientPhysiotherapy, long?>,
        IGetList<VW_VisitPatientPhysiotherapy, long>, IDataErrorInfo, INotifyPropertyChanged
    {
       
        #region Constructor

        public VisitPatientPhysiotherapy()
        {

        }
        #endregion

        #region Properties

        DataClassesVisitPatientPhysiotherapyDataContext DRN = new DataClassesVisitPatientPhysiotherapyDataContext(MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.InternalConnectionString);

        public bool InsertEntity(List<TBL_VisitPatientPhysiotherapy> ListObj, ref string msgRet, ref long? idRet)
        {
            try
            {
                foreach (TBL_VisitPatientPhysiotherapy FieldList in ListObj)
                {
                    DRN.SP_VisitPatientPhysiotherapyInsert(
                        ref idRet,
                        FieldList.Patient_Id,
                        FieldList.IssueArchive,
                        FieldList.LetterNo,
                        FieldList.LetterDate,
                        FieldList.Doctor_Id,
                        FieldList.DoctorPhysio_Id,
                        FieldList.PatientProblem,
                        FieldList.PhysiotherapyType,
                        FieldList.CordinateDate,
                        FieldList.VisitFew,
                        FieldList.VisitFewDoing,
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

        public bool UpdateEntity(List<TBL_VisitPatientPhysiotherapy> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_VisitPatientPhysiotherapy FieldList in ListObj)
                {
                    DRN.SP_VisitPatientPhysiotherapyUpdate(
                        FieldList.Id,
                        FieldList.Patient_Id,
                        FieldList.IssueArchive,
                        FieldList.LetterNo,
                        FieldList.LetterDate,
                        FieldList.Doctor_Id,
                        FieldList.DoctorPhysio_Id,
                        FieldList.PatientProblem,
                        FieldList.PhysiotherapyType,
                        FieldList.CordinateDate,
                        FieldList.VisitFew,
                        FieldList.VisitFewDoing,
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

        public bool DeleteEntity(List<TBL_VisitPatientPhysiotherapy> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_VisitPatientPhysiotherapy FieldList in ListObj)
                {
                    DRN.SP_VisitPatientPhysiotherapyDelete(
                        FieldList.Id,
                        ref msgRet
                     );
                }
                DRN.SubmitChanges();

                long? idRet = 0;
                foreach (TBL_VisitPatientPhysiotherapy LogFieldList in ListObj)
                {
                    MKH.Permission.Model.Log.dbo_TBL_VisitPatientPhysiotherapy Login = new MKH.Permission.Model.Log.dbo_TBL_VisitPatientPhysiotherapy()
                    {
                        ComputerName = new MSSConfigHelp().ComputerName,
                        UserProfile = new MSSConfigHelp().CurrentWinUserName,
                        ActionType_Id = 3,
                        Id = LogFieldList.Id,

                        Patient_Id = LogFieldList.Patient_Id,
                        Doctor_Id = LogFieldList.Doctor_Id,
                        DoctorPhysio_Id = LogFieldList.DoctorPhysio_Id,
                        VisitStatus_Id = LogFieldList.VisitStatus_Id,
                        BeginDate = LogFieldList.BeginDate,
                        CordinateDate = LogFieldList.CordinateDate,
                        Description = LogFieldList.Description,
                        EndDate = LogFieldList.EndDate,
                        IssueArchive = LogFieldList.IssueArchive,
                        LetterDate = LogFieldList.LetterDate,
                        LetterNo = LogFieldList.LetterNo,
                        PatientProblem = LogFieldList.PatientProblem,
                        PhysiotherapyType = LogFieldList.PhysiotherapyType,
                        ReciveFileDate = LogFieldList.ReciveFileDate,
                        VisitFew = LogFieldList.VisitFew,
                        VisitFewDoing = LogFieldList.VisitFewDoing,

                        User_Id = MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                        ChangeDateTime = MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now),
                    };
                    List<MKH.Permission.Model.Log.dbo_TBL_VisitPatientPhysiotherapy> A = new List<MKH.Permission.Model.Log.dbo_TBL_VisitPatientPhysiotherapy>();
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


        public List<VW_VisitPatientPhysiotherapy> GetAllList(ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_VisitPatientPhysiotherapies select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_VisitPatientPhysiotherapy> GetAllListByID(long Id, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_VisitPatientPhysiotherapies where d.Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<TBL_VisitPatientPhysiotherapy> GetAllListByTblID(long Id, ref string msgRet)
        {
            try
            {
                return (from d in DRN.TBL_VisitPatientPhysiotherapies where d.Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_VisitPatientPhysiotherapy> GetAllListByFilter(List<MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.Filter> filter, ref string msgRet)
        {
            try
            {
                var deleg = MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.GetExpression<VW_VisitPatientPhysiotherapy>(filter).Compile();
                var filteredCollection = (from d in DRN.VW_VisitPatientPhysiotherapies select d).Where(deleg);
                return filteredCollection.ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public int CountAll(List<VW_VisitPatientPhysiotherapy> ListObj)
        {
            return ListObj.Count();
        }

        public List<VW_VisitPatientPhysiotherapy> GetAllListByDetailRow(long Id, long DetailRowId, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_VisitPatientPhysiotherapies where d.Id == Id select d).ToList();
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
                DRN.SP_VisitPatientPhysiotherapyUpdateWithFieldValue(
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
                DRN.SP_VisitPatientPhysiotherapyVisitStatusUpdate(
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

        public List<VW_VisitPatientPhysiotherapy> GetAllListByLastPatientID(int PatientId, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_VisitPatientPhysiotherapies where d.Patient_Id == PatientId orderby d.EndDate descending select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        
        public List<SP_VisitPatientPhysiotherapyReportResult> GetReport(string DateStart, string DateEnd, bool MonthSet, ref string msgRet)
        {
            try
            {
                return (from d in DRN.SP_VisitPatientPhysiotherapyReport(DateStart, DateEnd, MonthSet) select d).ToList();
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
