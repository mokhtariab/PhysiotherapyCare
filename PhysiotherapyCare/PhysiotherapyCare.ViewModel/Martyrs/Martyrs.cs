  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using PhysiotherapyCare.Model;
using MKH.Library.Clasess.Security;
using PhysiotherapyCare.Model.Martyrs;


namespace PhysiotherapyCare.ViewModel.Martyrs
{
    public class Martyr : IInsUpDel<TBL_Martyr, int?>,
        IGetList<VW_Martyr, int>, IDataErrorInfo, INotifyPropertyChanged
    {
       
        #region Constructor

        public Martyr()
        {

        }
        #endregion

        #region Properties

        DataClassesMartyrsDataContext DRN = new DataClassesMartyrsDataContext(MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.InternalConnectionString);

        public bool InsertEntity(List<TBL_Martyr> ListObj, ref string msgRet, ref int? idRet)
        {
            try
            {
                foreach (TBL_Martyr FieldList in ListObj)
                {
                    DRN.SP_MartyrsInsert(
                        ref idRet,
                        FieldList.MartyrNameFamily,
                        FieldList.MartyrFew,
                        FieldList.DosiersNo1,
                        FieldList.NationalCode1,
                        FieldList.MartyrName1,
                        FieldList.BrithDate1,
                        FieldList.MartyrDate1,
                        FieldList.MartyrLocation1,
                        FieldList.DosiersNo2,
                        FieldList.NationalCode2,
                        FieldList.MartyrName2,
                        FieldList.BrithDate2,
                        FieldList.MartyrDate2,
                        FieldList.MartyrLocation2,
                        FieldList.DosiersNo3,
                        FieldList.NationalCode3,
                        FieldList.MartyrName3,
                        FieldList.BrithDate3,
                        FieldList.MartyrDate3,
                        FieldList.MartyrLocation3,
                        FieldList.Description,
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

        public bool UpdateEntity(List<TBL_Martyr> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_Martyr FieldList in ListObj)
                {
                    DRN.SP_MartyrsUpdate(
                        FieldList.MartyrId,
                        FieldList.MartyrNameFamily,
                        FieldList.MartyrFew,
                        FieldList.DosiersNo1,
                        FieldList.NationalCode1,
                        FieldList.MartyrName1,
                        FieldList.BrithDate1,
                        FieldList.MartyrDate1,
                        FieldList.MartyrLocation1,
                        FieldList.DosiersNo2,
                        FieldList.NationalCode2,
                        FieldList.MartyrName2,
                        FieldList.BrithDate2,
                        FieldList.MartyrDate2,
                        FieldList.MartyrLocation2,
                        FieldList.DosiersNo3,
                        FieldList.NationalCode3,
                        FieldList.MartyrName3,
                        FieldList.BrithDate3,
                        FieldList.MartyrDate3,
                        FieldList.MartyrLocation3,
                        FieldList.Description,
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

        public bool DeleteEntity(List<TBL_Martyr> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_Martyr FieldList in ListObj)
                {
                    DRN.SP_MartyrsDelete(
                        FieldList.MartyrId,
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


        public List<VW_Martyr> GetAllList(ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_Martyrs select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_Martyr> GetAllListByID(int Id, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_Martyrs where d.MartyrId == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_Martyr> GetAllListByFilter(List<MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.Filter> filter, ref string msgRet)
        {
            try
            {
                var deleg = MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.GetExpression<VW_Martyr>(filter).Compile();
                var filteredCollection = (from d in DRN.VW_Martyrs select d).Where(deleg);
                return filteredCollection.ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public int CountAll(List<VW_Martyr> ListObj)
        {
            return ListObj.Count();
        }

        public List<VW_Martyr> GetAllListByDetailRow(int Id, long DetailRowId, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_Martyrs where d.MartyrId == Id select d).ToList();
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
