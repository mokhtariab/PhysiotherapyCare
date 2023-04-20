  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using PhysiotherapyCare.Model;
using MKH.Library.Clasess.Security;
using PhysiotherapyCare.Model.Setting;
using System.Data.SqlClient;

namespace PhysiotherapyCare.ViewModel.Setting
{
    public class BackupRestore : IDataErrorInfo, INotifyPropertyChanged
    {
       
        #region Constructor

        public BackupRestore()
        {

        }
        #endregion

        #region Properties

        DataClassesSettingDataContext DRN = new DataClassesSettingDataContext(MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.InternalConnectionString);


        public bool DataBaseBackup(string PathSaveBackup, ref string msgRet)
        {
            try
            {
                DRN.SP_DataBaseBackup(
                        PathSaveBackup,
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

        public bool DataBaseRestore(string PathLoadBackup, ref string msgRet)
        {

            try
            {
                SqlConnection SqlConn = new SqlConnection(MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.InternalConnectionString);
                SqlCommand SqlCmd = new SqlCommand();

                SqlCmd.CommandText =
                    "use master " +
                    "ALTER DATABASE [PhysiotherapyCare] SET SINGLE_USER WITH ROLLBACK IMMEDIATE " +
                    "RESTORE DATABASE [PhysiotherapyCare] FROM  DISK = N'" + PathLoadBackup +
                    "' WITH  FILE = 1,  NOUNLOAD,  REPLACE,  STATS = 10";

                SqlCmd.CommandType = System.Data.CommandType.Text;
                SqlCmd.Connection = SqlConn;

                SqlDataAdapter SDA = new SqlDataAdapter(SqlCmd.CommandText, SqlConn);
                SDA.UpdateCommand = new SqlCommand(SqlCmd.CommandText, SqlConn);

                SqlConn.Open();

                SDA.UpdateCommand.ExecuteReader();


                //DRN.SP_DataBaseRestore(
                //        PathLoadBackup,
                //        ref msgRet
                //        );

                //DRN.SubmitChanges();

                return true;
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }

            return false;
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
