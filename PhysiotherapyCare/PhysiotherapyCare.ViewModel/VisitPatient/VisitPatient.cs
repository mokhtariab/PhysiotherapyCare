using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using PhysiotherapyCare.Model;
using MKH.Library.Clasess.Security;
using PhysiotherapyCare.Model.VisitPatient;
using MKH.Library.Clasess.FilterClass;

namespace PhysiotherapyCare.ViewModel.VisitPatient
{
    public class VisitPatient : IInsUpDel<TBL_VisitPatient, long?>,
        IGetList<VW_VisitPatient, long>, IDataErrorInfo, INotifyPropertyChanged
    {

        #region Constructor

        public VisitPatient()
        {

        }
        #endregion

        #region Properties

        DataClassesVisitPatientDataContext DRN = new DataClassesVisitPatientDataContext(MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.InternalConnectionString);

        public bool InsertEntity(List<TBL_VisitPatient> ListObj, ref string msgRet, ref long? idRet)
        {
            try
            {
                foreach (TBL_VisitPatient FieldList in ListObj)
                {
                    DRN.SP_VisitPatientInsert(
                        ref idRet,
                        FieldList.Patient_Id,
                        FieldList.IssueArchive,
                        FieldList.LetterNo,
                        FieldList.LetterDate,
                        FieldList.Doctor_Id,
                        FieldList.VisitDate,
                        FieldList.StateSicknessDsc,
                        FieldList.ParaclinicDsc,
                        FieldList.DrugsDsc,
                        FieldList.BedsoreDsc,
                        FieldList.VaccinationDsc,
                        FieldList.EquipmentUseDsc,
                        FieldList.BonyadAddEven,
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


        public bool InsertEntityGrouping(List<TBL_VisitPatient> ListObj, ref string msgRet, ref long? idRet)
        {
            try
            {
                foreach (TBL_VisitPatient FieldList in ListObj)
                {
                    try
                    {
                        DRN.SP_VisitPatientInsert(
                            ref idRet,
                            FieldList.Patient_Id,
                            FieldList.IssueArchive,
                            FieldList.LetterNo,
                            FieldList.LetterDate,
                            FieldList.Doctor_Id,
                            FieldList.VisitDate,
                            FieldList.StateSicknessDsc,
                            FieldList.ParaclinicDsc,
                            FieldList.DrugsDsc,
                            FieldList.BedsoreDsc,
                            FieldList.VaccinationDsc,
                            FieldList.EquipmentUseDsc,
                            FieldList.BonyadAddEven,
                            FieldList.VisitStatus_Id,
                            FieldList.ReciveFileDate,
                            FieldList.Description,
                            FieldList.User_Id,
                            FieldList.ChangeDateTime,
                            ref msgRet
                            );
                    }
                    catch (Exception ex)
                    {
                        if (ex.Message.Contains("Duplicated Row! VisitDate"))
                            msgRet += "کدبیمار: " + FieldList.Patient_Id.ToString() + ",";
                    }
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

        public bool UpdateEntity(List<TBL_VisitPatient> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_VisitPatient FieldList in ListObj)
                {
                    DRN.SP_VisitPatientUpdate(
                        FieldList.Id,
                        FieldList.Patient_Id,
                        FieldList.IssueArchive,
                        FieldList.LetterNo,
                        FieldList.LetterDate,
                        FieldList.Doctor_Id,
                        FieldList.VisitDate,
                        FieldList.StateSicknessDsc,
                        FieldList.ParaclinicDsc,
                        FieldList.DrugsDsc,
                        FieldList.BedsoreDsc,
                        FieldList.VaccinationDsc,
                        FieldList.EquipmentUseDsc,
                        FieldList.BonyadAddEven,
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

        public bool DeleteEntity(List<TBL_VisitPatient> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_VisitPatient FieldList in ListObj)
                {
                    DRN.SP_VisitPatientDelete(
                        FieldList.Id,
                        ref msgRet
                     );
                }
                DRN.SubmitChanges();

                
                long? idRet = 0;
                foreach (TBL_VisitPatient LogFieldList in ListObj)
                {
                    MKH.Permission.Model.Log.VST_TBL_VisitPatient Login = new MKH.Permission.Model.Log.VST_TBL_VisitPatient()
                    {
                        ComputerName = new MSSConfigHelp().ComputerName,
                        UserProfile = new MSSConfigHelp().CurrentWinUserName,
                        ActionType_Id = 3,
                        Id = LogFieldList.Id,

                        Patient_Id = LogFieldList.Patient_Id,
                        Doctor_Id = LogFieldList.Doctor_Id,
                        VisitDate = LogFieldList.VisitDate,
                        BonyadAddEven = LogFieldList.BonyadAddEven,
                        VisitStatus_Id = LogFieldList.VisitStatus_Id,

                        BedsoreDsc = LogFieldList.BedsoreDsc,
                        Description = LogFieldList.Description,
                        DrugsDsc = LogFieldList.DrugsDsc,
                        EquipmentUseDsc = LogFieldList.EquipmentUseDsc,
                        IssueArchive = LogFieldList.IssueArchive,
                        LetterDate = LogFieldList.LetterDate,
                        LetterNo = LogFieldList.LetterNo,
                        ParaclinicDsc = LogFieldList.ParaclinicDsc,
                        ReciveFileDate = LogFieldList.ReciveFileDate,
                        StateSicknessDsc = LogFieldList.StateSicknessDsc,
                        VaccinationDsc = LogFieldList.VaccinationDsc,

                        User_Id = MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID,
                        ChangeDateTime = MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now),
                    };
                    List<MKH.Permission.Model.Log.VST_TBL_VisitPatient> A = new List<MKH.Permission.Model.Log.VST_TBL_VisitPatient>();
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


        public List<VW_VisitPatient> GetAllList(ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_VisitPatients select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<SP_VisitPatientSelectResult> GetAllListSet(string datestart,string dateEnd, short statusId, ref string msgRet)
        {
            try
            {
                return (from d in DRN.SP_VisitPatientSelect(datestart,dateEnd,statusId) select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_VisitPatient> GetAllListByID(long Id, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_VisitPatients where d.Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<TBL_VisitPatient> GetAllListByTblID(long Id, ref string msgRet)
        {
            try
            {
                return (from d in DRN.TBL_VisitPatients where d.Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_VisitPatient> GetAllListByFilter(List<MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.Filter> filter, ref string msgRet)
        {
            try
            {
                var deleg = MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.GetExpression<VW_VisitPatient>(filter).Compile();
                var filteredCollection = (from d in DRN.VW_VisitPatients select d).Where(deleg);
                return filteredCollection.ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_VisitPatientForReport> GetAllListByFilterForReport(List<MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.Filter> filter, ref string msgRet)
        {
            try
            {
                var deleg = MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.GetExpression<VW_VisitPatientForReport>(filter).Compile();
                var filteredCollection = (from d in DRN.VW_VisitPatientForReports select d).Where(deleg);
                return filteredCollection.ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }


        public List<SP_VisitPatientReportResult> GetReport(string WhereStr, ref string msgRet)
        {
            try
            {
                return (from d in DRN.SP_VisitPatientReport(WhereStr) select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<SP_VisitPatientChartResult> GetChart(short EnterPatientType, string WhereStr, ref string msgRet)
        {
            try
            {
                return (from d in DRN.SP_VisitPatientChart(EnterPatientType, WhereStr) select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public int CountAll(List<VW_VisitPatient> ListObj)
        {
            return ListObj.Count();
        }

        //public List<VW_VisitPatient> GetAllListByDetailRow(long Id, ref string msgRet)
        //{

        //}



        //public bool UpdateLastReciveReport(long Id, string LastReciveReportDate, ref string msgRet)
        //{
        //    try
        //    {
        //        DRN.SP_VisitPatientLastReciveReportUpdate(
        //            Id,
        //            LastReciveReportDate,
        //            ref msgRet
        //            );
        //        DRN.SubmitChanges();



        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        msgRet = ex.Message;
        //    }
        //    return false;
        //}

        //public bool UpdateFinancialSettlement(long Id, bool FinancialSettlement, ref string msgRet)
        //{
        //    try
        //    {
        //        DRN.SP_VisitPatientFinancialSettlementUpdate(
        //            Id,
        //            FinancialSettlement,
        //            ref msgRet
        //            );
        //        DRN.SubmitChanges();

        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        msgRet = ex.Message;
        //    }
        //    return false;
        //}

        public bool UpdateVisitStatus(long Id, short VisitStatus_Id, int User_Id, string ChangeDateTime, ref string msgRet)
        {
            try
            {
                DRN.SP_VisitPatientVisitStatusUpdate(
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

        public List<VW_VisitPatient> GetAllListByLastPatientID(int PatientId, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_VisitPatients where d.Patient_Id == PatientId orderby d.VisitDate descending select d).ToList();
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
                DRN.SP_VisitPatientUpdateWithFieldValue(
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


 
        //public List<SP_VisitPatientReportResult> GetReport(string DateStart, string DateEnd, ref string msgRet)
        //{
        //    try
        //    {
        //        return (from d in DRN.SP_VisitPatientReport(DateStart, DateEnd) select d).ToList();
        //    }
        //    catch (Exception ex)
        //    {
        //        msgRet = ex.Message;
        //    }
        //    return null;
        //}

        /*
        public bool VisitPatientWithSicknessVisitPatientDelete(long VisitPatient_Id, ref string msgRet)
        {
            try
            {
                DRN.SP_VisitPatientWithSicknessVisitPatientDelete(
                    VisitPatient_Id,
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

        public bool VisitPatientWithParaclinicVisitPatientDelete(long VisitPatient_Id, ref string msgRet)
        {
            try
            {
                DRN.SP_VisitPatientWithParaclinicVisitPatientDelete(
                    VisitPatient_Id,
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

        public bool VisitPatientWithDrugVisitPatientDelete(long VisitPatient_Id, ref string msgRet)
        {
            try
            {
                DRN.SP_VisitPatientWithDrugVisitPatientDelete(
                    VisitPatient_Id,
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



        public bool VisitPatientWithVaccinationVisitPatientDelete(long VisitPatient_Id, ref string msgRet)
        {
            try
            {
                DRN.SP_VisitPatientWithVaccinationVisitPatientDelete(
                    VisitPatient_Id,
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


        public bool VisitPatientWithEquipmentUseVisitPatientDelete(long VisitPatient_Id, ref string msgRet)
        {
            try
            {
                DRN.SP_VisitPatientWithEquipmentUseVisitPatientDelete(
                    VisitPatient_Id,
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
        public bool VisitPatientWithBedsoreVisitPatientDelete(long VisitPatient_Id, ref string msgRet)
        {
            try
            {
                DRN.SP_VisitPatientWithBedsoreVisitPatientDelete(
                    VisitPatient_Id,
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
         */

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

        public List<VW_VisitPatient> GetAllListByDetailRow(long Id, long DetailRowId, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_VisitPatients where d.Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }


        #endregion

    }
}
