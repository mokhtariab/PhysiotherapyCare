using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using MKH.Contacts.Model.PersonTelMob;
using MKH.Contacts.Model;


namespace MKH.Contacts.ViewModel.PersonTelMob
{
    public class PersonTelMob : IInsUpDel<TBL_PersonTelMob, int?>,
        IGetList<VW_PersonTelMob, int>, IDataErrorInfo, INotifyPropertyChanged
    {
       
        #region Constructor

        public PersonTelMob()
        {

        }
        #endregion

        #region Properties

        DataClassesPersonTelMobDataContext DRN = new DataClassesPersonTelMobDataContext(MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.InternalConnectionString);

        public bool InsertEntity(List<TBL_PersonTelMob> ListObj, ref string msgRet, ref int? idRet)
        {
            try
            {
                foreach (TBL_PersonTelMob FieldList in ListObj)
                {
                    DRN.SP_PersonTelMobInsert(
                        ref idRet,
                        FieldList.FirstName,
                        FieldList.LastName,
                        FieldList.PersonPic,
                        FieldList.ParentName,
                        FieldList.IDNO,
                        FieldList.NationalCode,
                        FieldList.BrithDate,
                        FieldList.BrithCityName,
                        FieldList.TelHome,
                        FieldList.TelBusiness,
                        FieldList.Mobile,
                        FieldList.Mobile2,
                        FieldList.Email,
                        FieldList.Address,
                        FieldList.AddressBusiness,
                        FieldList.Description,
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

        public bool UpdateEntity(List<TBL_PersonTelMob> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_PersonTelMob FieldList in ListObj)
                {
                    DRN.SP_PersonTelMobUpdate(
                        FieldList.Id,
                        FieldList.FirstName,
                        FieldList.LastName,
                        FieldList.PersonPic,
                        FieldList.ParentName,
                        FieldList.IDNO,
                        FieldList.NationalCode,
                        FieldList.BrithDate,
                        FieldList.BrithCityName,
                        FieldList.TelHome,
                        FieldList.TelBusiness,
                        FieldList.Mobile,
                        FieldList.Mobile2,
                        FieldList.Email,
                        FieldList.Address,
                        FieldList.AddressBusiness,
                        FieldList.Description,
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

        public bool DeleteEntity(List<TBL_PersonTelMob> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_PersonTelMob FieldList in ListObj)
                {
                    DRN.SP_PersonTelMobDelete(
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


        public List<VW_PersonTelMob> GetAllList(ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_PersonTelMobs select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_PersonTelMob> GetAllListByID(int Id, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_PersonTelMobs where d.Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_PersonTelMob> GetAllListByFilter(List<MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.Filter> filter, ref string msgRet)
        {
            try
            {
                var deleg = MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.GetExpression<VW_PersonTelMob>(filter).Compile();
                var filteredCollection = (from d in DRN.VW_PersonTelMobs select d).Where(deleg);
                return filteredCollection.ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public int CountAll(List<VW_PersonTelMob> ListObj)
        {
            return ListObj.Count();
        }

        public List<VW_PersonTelMob> GetAllListByDetailRow(int Id, long DetailRowId, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_PersonTelMobs where d.Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_PersonTelMob> GetAllListByGroupID(int Group_ID, ref string msgRet)
        {
            try
            {
                return DRN.SP_PersonTelMobSelectWithGroupPerson(Group_ID, ref msgRet).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }


        public List<TBL_PersonTelMob> GetAllListByIDPic(int Id, ref string msgRet)
        {
            try
            {
                return (from d in DRN.TBL_PersonTelMobs where d.Id == Id select d).ToList();
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
