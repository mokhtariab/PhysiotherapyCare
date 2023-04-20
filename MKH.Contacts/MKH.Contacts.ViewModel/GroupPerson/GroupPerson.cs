using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using MKH.Contacts.Model.GroupPerson;
using MKH.Contacts.Model;


namespace MKH.Contacts.ViewModel.GroupPerson
{
    public class GroupPerson : IInsUpDel<TBL_GroupPerson, int?>,
        IGetList<VW_GroupPerson, int>, IDataErrorInfo, INotifyPropertyChanged
    {
       
        #region Constructor

        public GroupPerson()
        {

        }
        #endregion

        #region Properties

        DataClassesGroupPersonDataContext DRN = new DataClassesGroupPersonDataContext(MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.InternalConnectionString);

        public bool InsertEntity(List<TBL_GroupPerson> ListObj, ref string msgRet, ref int? idRet)
        {
            idRet = 0;
            try
            {
                foreach (TBL_GroupPerson FieldList in ListObj)
                {
                    DRN.SP_GroupPersonInsert(
                        FieldList.Group_ID,
                        FieldList.Person_ID,
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

        public bool UpdateEntity(List<TBL_GroupPerson> ListObj, ref string msgRet)
        {
            try
            {
                return true;
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return false;
        }


        public bool DeleteEntity(List<TBL_GroupPerson> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_GroupPerson FieldList in ListObj)
                {
                    DRN.SP_GroupPersonDelete(
                        FieldList.Group_ID,
                        FieldList.Person_ID,
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


        public List<VW_GroupPerson> GetAllList(ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_GroupPersons select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_GroupPerson> GetAllListByID(int Id, ref string msgRet)
        {
            return null;
        }

        public List<VW_GroupPerson> GetAllListByFilter(List<MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.Filter> filter, ref string msgRet)
        {
            try
            {
                var deleg = MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.GetExpression<VW_GroupPerson>(filter).Compile();
                var filteredCollection = (from d in DRN.VW_GroupPersons select d).Where(deleg);
                return filteredCollection.ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public int CountAll(List<VW_GroupPerson> ListObj)
        {
            return ListObj.Count();
        }

        public List<VW_GroupPerson> GetAllListByDetailRow(int Id, long DetailRowId, ref string msgRet)
        {
            return null;
        }

        public List<TBL_GroupPerson> GetAllListByIDPic(int Id, ref string msgRet)
        {
            return null;
        }

        public List<VW_GroupPerson> GetAllListByIds(int Group_ID, int Person_ID, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_GroupPersons where d.Person_ID == Person_ID & d.Group_ID == Group_ID select d).ToList();
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
