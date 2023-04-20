using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MKH.Library.Clasess.Security
{
    public class MSSConfigHelp
    {
        #region Retrieves the operating system information

        public string UserName
        {
            get
            {
                return SystemInformation.UserName;
            }
        }

        public string UserDomainName
        {
            get
            {
                return SystemInformation.UserDomainName;
            }
        }

        public string CurrentWinUserName
        {
            get
            {
                return System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            }
        }

        public string DomainName
        {
            get
            {
                return System.Net.NetworkInformation.IPGlobalProperties.GetIPGlobalProperties().DomainName;
            }
        }

        public string IPName
        {
            get
            {
                return (System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName()).AddressList)[1].ToString();
            }
        }

        public string ComputerName
        {
            get
            {
                return SystemInformation.ComputerName;   //or System.Environment.MachineName
            }
        }

        public string Network
        {
            get
            {
                if (SystemInformation.Network)
                    return "Connected";
                else
                    return "Disconnected";

            }
        }

        public string MonitorInfo
        {
            get
            {
                return SystemInformation.MonitorCount.ToString();
            }
        }

        public string MouseInfo
        {
            get
            {
                if (SystemInformation.MousePresent)
                {
                    return SystemInformation.MouseButtons.ToString() + " Button Mouse";
                }
                else
                    return "No Mouse Connected";
            }
        }
        public string BootInfo
        {
            get
            {
                if (SystemInformation.BootMode == BootMode.Normal)
                    return "Normal";
                else if (SystemInformation.BootMode == BootMode.FailSafe)
                    return "Started In Safe Mode";
                else if (SystemInformation.BootMode == BootMode.FailSafeWithNetwork)
                    return "Started In Safe Mode with Network Support";
                else
                    return "No info";
            }
        }

        public string ExecPath
        {
            get
            {

                //return Application.StartupPath;
                return Path.GetDirectoryName(Application.ExecutablePath); //or Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location); 
                // Learning 
                //Application.StartupPath  
                //Environment.CurrentDirectory
                //System.Reflection.Assembly.GetExecutingAssembly().Location

            }
        }

        #endregion

    }
}
