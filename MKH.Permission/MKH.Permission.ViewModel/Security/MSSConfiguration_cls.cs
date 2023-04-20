using System;
using System.Web;
using System.Text;
using System.Reflection;
using System.Data;
using System.Collections.Generic;
using MKH.Library.Clasess.Security;

namespace MKH.Permission.ViewModel.Security
{
    public class MSSConfiguration_cls
    {
        private static MSSConfiguration_cls internalInstance;
        public static MSSConfiguration_cls Instance
        {
            get
            {
                if (internalInstance == null)
                    internalInstance = new MSSConfiguration_cls();
                return internalInstance;
            }
        }


        public string USER = "admin";
        public string PASSWORD = "1";

        public int USERID = 1;
        public bool IsAdmin = false;

        public int SoftwareId
        {
            get;
            set;
        }

        private string systemName = "";
        public string SystemName
        {
            get { return systemName; }
            set { systemName = value; }
        }

        private string _computerName = "";
        public string ComputerName
        {
            get
            {
                if (_computerName.Trim() == "")
                    _computerName = new MSSConfigHelp().ComputerName;
                return _computerName;
            }
            set
            {
                _computerName = value;
            }
        }




        //public string InternalConnectionString = Security.MSSFunction_Cls.DecriptionText("eNuYUD/TAWNlnOz5CFgm/H8NZnQj5gkqrMo9oILCeQFoKOWXziYe7SI+8ebfnWF2z4BKCSQcr1Y3kWwopQJt0kpPyFMVM9pIXPPvzO42eCfU7kJKtlXCIGgEqX8JE/pt/cWr6HnxEDXFdAns0hKp0UdkhtoGpYomEtrIWJa/h5E=", Security.MSSFunction_Cls.EncDecryption.PublicEncDec);
        public string InternalConnectionString = new MKH.Permission.ViewModel.Security.MSSSqlConnection().ConnectionString();
        

        private string m_CurrentUserName = null;
        public string CurrentUserName
        {
            get
            {
                return m_CurrentUserName;
            }
            set
            {
                m_CurrentUserName = value;
            }
        }




        #region Security

        public List<string> AllowedIds = null;


        private Int32 _currentUserId;
        public Int32 CurrentUserId
        {
            get
            {
                return _currentUserId;
            }
            set
            {
                _currentUserId = value;
            }
        }


        private string _currentUserLogin;
        public string CurrentUserLogin
        {
            get
            {
                return _currentUserLogin;
            }
            set
            {
                _currentUserLogin = value;
            }
        }

        public bool RemoteMode
        {
            get
            {
                return false;
            }
        }

        public string DllPath
        {
            get
            {
                if (InternalDllPath == null)
                {
                    string str = Assembly.GetExecutingAssembly().Location;
                    string[] pathParts = str.Split('\\');
                    StringBuilder sb = new StringBuilder();

                    for (int i = 0; i < pathParts.Length - 1; i++)
                    {
                        sb.Append(pathParts[i]);
                        sb.Append(@"\");
                    }
                    InternalDllPath = sb.ToString();
                }

                return InternalDllPath;
            }
        }
        private string InternalDllPath = null;



        public string ConfigFileFullName
        {
            get
            {
                return DllPath + ConfigFileName;
            }
        }

        public static string ConfigFileName
        {
            get
            {
                return _internalConfigFileName;
            }
            set
            {
                _internalConfigFileName = value;
            }
        }
        private static string _internalConfigFileName = "MKH.Permission.exe.config";

        #endregion

        #region Log Parameters
        public void AddParameterLog(System.Data.SqlClient.SqlCommand cmd)
        {
            AddParameterLog(cmd, "@UserId ", "@ComputerName", "@SystemId");
        }

        public void AddParameterLog(System.Data.SqlClient.SqlCommand cmd, string userIdParamName,
            string computerNameParamName, string systemIdParamName)
        {
            cmd.Parameters.Add(userIdParamName, SqlDbType.Int);
            cmd.Parameters[userIdParamName].Value = Security.MSSConfiguration_cls.Instance.CurrentUserId;
            cmd.Parameters[userIdParamName].Direction = ParameterDirection.Input;

            cmd.Parameters.Add(computerNameParamName, SqlDbType.VarChar);
            cmd.Parameters[computerNameParamName].Value = Security.MSSConfiguration_cls.Instance.ComputerName;
            cmd.Parameters[computerNameParamName].Direction = ParameterDirection.Input;

            cmd.Parameters.Add(systemIdParamName, SqlDbType.Int);
            cmd.Parameters[systemIdParamName].Value = Security.MSSConfiguration_cls.Instance.SoftwareId;
            cmd.Parameters[systemIdParamName].Direction = ParameterDirection.Input;
        }

        #endregion


    }
}
