using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.IO;
using System.Xml.Linq;
using System.Collections.Specialized;
using System.Threading;
using System.Management;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MKH.Permission.View.Security
{
    class CheckKey_Cls
    {

        #region Security

        public static bool ExitForce = false;

        public static bool CheckKeyFile()
        {
            if (System.IO.File.Exists(System.Windows.Forms.Application.StartupPath + @"\KeyFile.txt"))
            {
                string SC = "";
                try
                {
                    SC = ExtractCodeOfKey(System.Windows.Forms.Application.StartupPath + @"\KeyFile.txt");
                }
                catch (Exception ex)
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "قفل نرم افزاری معتبر نمی باشد", ex.Message);
                    ExitForce = true;
                    return false;
                }

                try
                {
                    if (!CheckExtractCodeOfKey(ListExtractOfCode(SC)))
                    {
                        MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "امکان راه اندازی برنامه در این محیط (سیستم) وجود ندارد");
                        ExitForce = true;
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "امکان راه اندازی برنامه در این محیط (سیستم) وجود ندارد", ex.Message);
                    ExitForce = true;
                    return false;
                }
            }
            else
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false,
                    "لطفا کدهای ذیل را جهت گرفتن فایل راه انداز ارسال نمایید ",
                    HddAndCpuDef());
                ExitForce = true;
                return false;
            }
            return true;
        }

        private static bool CheckExtractCodeOfKey(Dictionary<string, string> LEC)
        {
            string Model = "";
            ManagementObjectSearcher mosDisks = new ManagementObjectSearcher(
                "SELECT  * FROM Win32_DiskDrive ");

            foreach (ManagementObject moDisk in mosDisks.Get())
            {
                if (LEC["Model"] == moDisk["Model"].ToString())
                {
                    Model = LEC["Model"];
                    break;
                }
            }
            if (Model == "") return false;

            if (LEC["CPU"] != GetCPU() && LEC["MacAddress"] != GetMacAddress()) return false;
            if (LEC["TotalCylinders"] != GetTotalCylindersHDD(Model)) return false;
            if (LEC["TotalSectors"] != GetTotalSectorsHDD(Model)) return false;

            MKH.Library.Clasess.PublicParam.SoftwareCode = LEC["SoftwareCode"] == "" ? "Trial" : LEC["SoftwareCode"];

            return true;
        }

        private static Dictionary<string, string> ListExtractOfCode(string SC)
        {
            Dictionary<string, string> Result = new Dictionary<string, string>(6);

            Result.Add("Model", SC.Substring(0, SC.IndexOf("+++")));
            SC = SC.Remove(0, SC.IndexOf("+++") + 3);
            Result.Add("TotalCylinders", SC.Substring(0, SC.IndexOf("+++")));
            SC = SC.Remove(0, SC.IndexOf("+++") + 3);
            Result.Add("TotalSectors", SC.Substring(0, SC.IndexOf("+++")));
            SC = SC.Remove(0, SC.IndexOf("+++") + 3);
            Result.Add("CPU", SC.Substring(0, SC.IndexOf("+++")));
            SC = SC.Remove(0, SC.IndexOf("+++") + 3);

            try
            {
                Result.Add("MacAddress", SC.Substring(0, SC.IndexOf("+++")));
                SC = SC.Remove(0, SC.IndexOf("+++") + 3);
                Result.Add("SoftwareCode", SC);
            }
            catch
            {
                Result.Add("MacAddress", SC);
                Result.Add("SoftwareCode", "");
            }

            return Result;
        }

        public static string ExtractCodeOfKey(string PathFile)
        {
            string text = System.IO.File.ReadAllText(PathFile);

            RSaEncryptionLib.BaseCom BS = new RSaEncryptionLib.BaseCom();
            BS.LoadPublicKey();
            BS.LoadPrivateKey();


            string Result = "";
            try
            {
                Result = BS.PrivateDecryption(text);
            }
            catch { }

            return Result;
        }


        //private static string HddAndCpuCheck(string model)
        //{
        //    string S = "", M = "", TC = "", TS = "";
        //    ManagementObjectSearcher mosDisks = new ManagementObjectSearcher(
        //        "SELECT * FROM Win32_DiskDrive WHERE Model = '" + model + "'");

        //    foreach (ManagementObject moDisk in mosDisks.Get())
        //    {
        //        //S = moDisk["SerialNumber"].ToString();
        //        M = moDisk["Model"].ToString();
        //        TC = moDisk["TotalCylinders"].ToString();
        //        TS = moDisk["TotalSectors"].ToString();
        //    }
        //    return model + "+++" + GetCPU() + "+++" + GetMacAddress() + "+++" + GetTotalCylindersHDD(model) + "+++" + GetTotalSectorsHDD(model);
        //}

        //private static string HddAndCpuDefFinalCheck(string model)
        //{
        //    string M = "", TC = "", TS = "";
        //    ManagementObjectSearcher mosDisks = new ManagementObjectSearcher(
        //        "SELECT * FROM Win32_DiskDrive WHERE Model = '" + model + "'");

        //    foreach (ManagementObject moDisk in mosDisks.Get())
        //    {
        //        M = moDisk["Model"].ToString();
        //        TC = moDisk["TotalCylinders"].ToString();
        //        TS = moDisk["TotalSectors"].ToString();
        //    }
        //    return M + "+++" + GetCPU() + "+++" + TC + "+++" + TS;
        //}

        private static string HddAndCpuDef()
        {
            string Model = "", HddAndCpuDef = "";
            ManagementObjectSearcher mosDisks = new ManagementObjectSearcher(
                "SELECT  * FROM Win32_DiskDrive ");

            foreach (ManagementObject moDisk in mosDisks.Get())
            {
                Model = moDisk["Model"].ToString();
                HddAndCpuDef += Model + "\\";
                HddAndCpuDef += GetTotalCylindersHDD(Model) + "\\";
                HddAndCpuDef += GetTotalSectorsHDD(Model) + "//////";
                HddAndCpuDef += GetCPU() + "\\";
                HddAndCpuDef += GetMacAddress() + "//////////////";
            }

            return HddAndCpuDef;
        }

        private static string GetTotalCylindersHDD(string model)
        {
            string TotalCylinders = "";
            ManagementObjectSearcher mosDisks = new ManagementObjectSearcher(
                "SELECT  * FROM Win32_DiskDrive WHERE Model = '" + model + "'");

            foreach (ManagementObject moDisk in mosDisks.Get())
            {
                try { TotalCylinders = moDisk["TotalCylinders"].ToString(); }
                catch { TotalCylinders = ""; }
            }
            return TotalCylinders;
        }

        private static string GetTotalSectorsHDD(string model)
        {
            string TotalSectors = "";
            ManagementObjectSearcher mosDisks = new ManagementObjectSearcher(
                "SELECT  * FROM Win32_DiskDrive WHERE Model = '" + model + "'");

            foreach (ManagementObject moDisk in mosDisks.Get())
            {
                try { TotalSectors = moDisk["TotalSectors"].ToString(); }
                catch { TotalSectors = ""; }
            }
            return TotalSectors;
        }

        private static string GetMacAddress()
        {
            string macAddresses = string.Empty;

            foreach (System.Net.NetworkInformation.NetworkInterface nic in System.Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces())
            {
                if (nic.OperationalStatus == System.Net.NetworkInformation.OperationalStatus.Up)
                {
                    macAddresses += nic.GetPhysicalAddress().ToString();
                    break;
                }
            }

            return macAddresses;
        }

        private static string GetCPU()
        {
            string GetCPU = string.Empty;
            System.Management.ManagementClass theClass = new System.Management.ManagementClass("Win32_Processor");
            System.Management.ManagementObjectCollection theCollectionOfResults = theClass.GetInstances();

            foreach (System.Management.ManagementObject currentResult in theCollectionOfResults)
            {
                GetCPU += currentResult["ProcessorID"].ToString();
            }

            return GetCPU;

        }


        public static string DecriptionText(string TextStr)
        {
            RSaEncryptionLib.BaseCom BS = new RSaEncryptionLib.BaseCom();
            BS.LoadPublicKey();
            BS.LoadPrivateKey();


            string Result = "";
            try
            {
                Result = BS.PrivateDecryption(TextStr);
            }
            catch { }

            return Result;
        }

        public static string EncriptionText(string TextStr)
        {
            RSaEncryptionLib.BaseCom BS = new RSaEncryptionLib.BaseCom();
            BS.LoadPublicKey();
            BS.LoadPrivateKey();


            string Result = "";
            try
            {
                Result = BS.PublicEncrypt(TextStr);
            }
            catch { }

            return Result;
        }

        #endregion


    }
}
