using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using MKH.Contacts.Model.GroupTelMob;
using MKH.Contacts.Model;


namespace MKH.Contacts.ViewModel.GroupTelMob
{
    public class GroupTelMob : IInsUpDel<TBL_GroupTelMob, int?>,
        IGetList<VW_GroupTelMob, int>, IDataErrorInfo, INotifyPropertyChanged
    {
       
        #region Constructor

        public GroupTelMob()
        {

        }
        #endregion

        #region Properties

        DataClassesGroupTelMobDataContext DRN = new DataClassesGroupTelMobDataContext(MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.InternalConnectionString);

        public bool InsertEntity(List<TBL_GroupTelMob> ListObj, ref string msgRet, ref int? idRet)
        {
            try
            {
                foreach (TBL_GroupTelMob FieldList in ListObj)
                {
                    DRN.SP_GroupTelMobInsert(
                        ref idRet,
                        FieldList.GroupName,
                        FieldList.Active,
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

        public bool UpdateEntity(List<TBL_GroupTelMob> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_GroupTelMob FieldList in ListObj)
                {
                    DRN.SP_GroupTelMobUpdate(
                        FieldList.Id,
                        FieldList.GroupName,
                        FieldList.Active,
                        ref msgRet
                        );
                }
                DRN. SubmitChanges();

               

                return true;
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return false;
        }

        public bool DeleteEntity(List<TBL_GroupTelMob> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_GroupTelMob FieldList in ListObj)
                {
                    DRN.SP_GroupTelMobDelete(
                        FieldList.Id,
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


        public List<VW_GroupTelMob> GetAllList(ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_GroupTelMobs select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_GroupTelMob> GetAllListByID(int Id, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_GroupTelMobs where d.Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_GroupTelMob> GetAllListByFilter(List<MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.Filter> filter, ref string msgRet)
        {
            try
            {
                var deleg = MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.GetExpression<VW_GroupTelMob>(filter).Compile();
                var filteredCollection = (from d in DRN.VW_GroupTelMobs select d).Where(deleg);
                return filteredCollection.ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public int CountAll(List<VW_GroupTelMob> ListObj)
        {
            return ListObj.Count();
        }

        public List<VW_GroupTelMob> GetAllListByDetailRow(int Id, long DetailRowId, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_GroupTelMobs where d.Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }


        public List<TBL_GroupTelMob> GetAllListByIDPic(int Id, ref string msgRet)
        {
            try
            {
                return (from d in DRN.TBL_GroupTelMobs where d.Id == Id select d).ToList();
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
