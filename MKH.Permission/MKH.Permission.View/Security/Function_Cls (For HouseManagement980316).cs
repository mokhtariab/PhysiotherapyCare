using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using HouseManagement_Prj.Properties;
using System.Configuration;
using System.IO;
using System.Xml.Linq;
using System.Collections.Specialized;
using System.Threading;
using System.Management;

namespace HouseManagement_Prj
{
    class Function_Cls
    {

        #region BackUp & Restore DB

        static public void SetBackUpDBAll(string PathSaveBackup)
        {
            SqlConnection SqlConn = new SqlConnection(Global_Cls.ConnectionStr);
            SqlCommand SqlCmd = new SqlCommand();
            SqlCmd.CommandText = " BACKUP DATABASE [House_Management] TO DISK = N'" + PathSaveBackup + "' " +
                                 " WITH FORMAT, INIT, NAME = N'House_Management-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10 ";
            SqlCmd.CommandType = CommandType.Text;
            SqlCmd.Connection = SqlConn;

            SqlConn.Open();

            try
            {
                SqlCmd.ExecuteReader();

                SetBackUpPicFilm_DesignRep(Path.GetDirectoryName(PathSaveBackup), Path.GetFileName(PathSaveBackup).Replace(Path.GetExtension(PathSaveBackup), ""));

                Global_Cls.Message_Sara(0, Global_Cls.MessageType.SConfirmation, false, "عمل پشتیبانی با موفقیت انجام شد");
            }
            catch (Exception ex)
            {
                string ex_str = Convert.ToString(ex);
                if (ex_str.IndexOf("Cannot open backup device") > 0)
                    Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "مسیر پشتیبانی را عوض کنید!");
                else
                    MessageBox.Show(Convert.ToString(ex));
            }
            SqlConn.Close();
        }

        static public void SetBackUpPicFilm_DesignRep(string PathSaveBackup, string FileName)
        {
            if (Global_Cls.BkpRstPicsFilms)
                CopyFolder(Global_Cls.RootSaveLoad() + "\\PicsFilms", PathSaveBackup + "\\" + FileName + "_BkpPicsFilms");
            if (Global_Cls.BkpRstDesignReport)
                CopyFolder(Global_Cls.RootSaveLoad() + "\\Report", PathSaveBackup + "\\" + FileName + "_BkpReport");
        }

        static public void CopyFolder(string sourceFolder, string destFolder)
        {
            if (!Directory.Exists(destFolder))
                Directory.CreateDirectory(destFolder);
            string[] files = Directory.GetFiles(sourceFolder);
            foreach (string file in files)
            {
                string name = Path.GetFileName(file);
                string dest = Path.Combine(destFolder, name);
                try { File.Copy(file, dest); }
                catch { }
            }
            string[] folders = Directory.GetDirectories(sourceFolder);
            foreach (string folder in folders)
            {
                string name = Path.GetFileName(folder);
                string dest = Path.Combine(destFolder, name);
                try { CopyFolder(folder, dest); }
                catch { }
            }
        }

        static public void SetRestoreDBAll(string PathSaveRestore)
        {
            SqlConnection SqlConn = new SqlConnection(Global_Cls.ConnectionStr);
            SqlCommand SqlCmd = new SqlCommand();

            SqlCmd.CommandText =
                "use master " +
                "ALTER DATABASE [House_Management] SET SINGLE_USER WITH ROLLBACK IMMEDIATE " +
                "RESTORE DATABASE [House_Management] FROM  DISK = N'" + PathSaveRestore +
                "' WITH  FILE = 1,  NOUNLOAD,  REPLACE,  STATS = 10";
            //@"' WITH FILE = 1,  NOUNLOAD,  REPLACE, MOVE 'APPSERVER' TO 'C:\Program Files\Microsoft SQL Server\MSSQL.1\MSSQL\Data\APPSERVER_Data.MDF', " +
            //@"MOVE 'APPSERVER_Log' TO 'C:\Program Files\Microsoft SQL Server\MSSQL.1\MSSQL\Data\APPSERVER_Log.LDF' ";
            SqlCmd.CommandType = CommandType.Text;
            SqlCmd.Connection = SqlConn;

            SqlDataAdapter SDA = new SqlDataAdapter(SqlCmd.CommandText, SqlConn);
            SDA.UpdateCommand = new SqlCommand(SqlCmd.CommandText, SqlConn);

            SqlConn.Open();

            try
            {
                SDA.UpdateCommand.ExecuteReader();

                RestorePicFilm_DesignRep(Path.GetDirectoryName(PathSaveRestore), Path.GetFileName(PathSaveRestore).Replace(Path.GetExtension(PathSaveRestore), ""));

                Global_Cls.Message_Sara(0, Global_Cls.MessageType.SConfirmation, false, "عمل بازیابی با موفقیت انجام شد");
            }
            catch (Exception ex)
            {
                string ex_str = Convert.ToString(ex);
                if (ex_str.IndexOf("Cannot open backup device") > 0)
                    Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "مسیر بازیابی را عوض کنید!");
                else
                    MessageBox.Show(Convert.ToString(ex));
            }

            SqlConn.Close();
        }

        static public void RestorePicFilm_DesignRep(string PathSaveRst, string FileName)
        {
            if (Global_Cls.BkpRstPicsFilms)
                CopyFolder(PathSaveRst + "\\" + FileName + "_BkpPicsFilms", Global_Cls.RootSaveLoad() + "\\PicsFilms");
            if (Global_Cls.BkpRstDesignReport)
                CopyFolder(PathSaveRst + "\\" + FileName + "_BkpReport", Global_Cls.RootSaveLoad() + "\\Report");
        }

        static public void Restore_Func(bool EditPass_EnterPass)
        {
            RstPass_frm RPF = new RstPass_frm();

            RPF.Edit_Enter = EditPass_EnterPass;
            if (EditPass_EnterPass)
            {
                RPF.groupPanel_NewPass.Visible = true;
                RPF.Height = 212;
            }
            else
            {
                RPF.groupPanel_EnterPass.Visible = true;
                RPF.Height = 140;
            }

            RPF.ShowDialog();
        }

        #endregion



        #region SearchInternet
        public static void SearchInternet(int SearchType)
        {
            //1: Search  2: Map Search
            SearchInternet_frm SIf = new SearchInternet_frm();
            SIf.SearchTypeEnter = SearchType;
            SIf.ShowDialog();
        }

        #endregion



        //#region Security

        //public static bool ExitForce = false;

        //public static void CheckKeyFile()
        //{
        //    if (System.IO.File.Exists(System.Windows.Forms.Application.StartupPath + @"\KeyFile.txt"))
        //    {
        //        string SC = "";
        //        try
        //        {
        //            SC = ExtractCodeOfKey(System.Windows.Forms.Application.StartupPath + @"\KeyFile.txt");
        //        }
        //        catch (Exception ex)
        //        {
        //            Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "قفل نرم افزاری معتبر نمی باشد", ex.Message);
        //            ExitForce = true;
        //            Application.Exit();
        //        }

        //        try
        //        {
        //            if (!CheckExtractCodeOfKey(ListExtractOfCode(SC)))
        //            {
        //                Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "امکان راه اندازی برنامه در این محیط (سیستم) وجود ندارد");
        //                ExitForce = true;
        //                Application.Exit();
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "امکان راه اندازی برنامه در این محیط (سیستم) وجود ندارد", ex.Message);
        //            ExitForce = true;
        //            Application.Exit();
        //        }
        //    }
        //    else
        //    {
        //        Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false,
        //            "لطفا کدهای ذیل را جهت گرفتن فایل راه انداز ارسال نمایید ",
        //            HddAndCpuDef());
        //        ExitForce = true;
        //        Application.Exit();
        //    }

        //}

        //private static bool CheckExtractCodeOfKey(Dictionary<string, string> LEC)
        //{
        //    string Model = "";
        //    ManagementObjectSearcher mosDisks = new ManagementObjectSearcher(
        //        "SELECT  * FROM Win32_DiskDrive ");

        //    foreach (ManagementObject moDisk in mosDisks.Get())
        //    {
        //        if (LEC["Model"] == moDisk["Model"].ToString())
        //        {
        //            Model = LEC["Model"];
        //            break;
        //        }
        //    }
        //    if (Model == "") return false;

        //    if (LEC["CPU"] != GetCPU()) return false;
        //    if (LEC["MacAddress"] != GetMacAddress()) return false;
        //    if (LEC["TotalCylinders"] != GetTotalCylindersHDD(Model)) return false;
        //    if (LEC["TotalSectors"] != GetTotalSectorsHDD(Model)) return false;

        //    Global_Cls.SoftwareCode = LEC["SoftwareCode"] == "" ? "Trial" : LEC["SoftwareCode"];

        //    return true;
        //}

        //private static Dictionary<string, string> ListExtractOfCode(string SC)
        //{
        //    Dictionary<string, string> Result = new Dictionary<string, string>(6);

        //    Result.Add("Model", SC.Substring(0, SC.IndexOf("+++")));
        //    SC = SC.Remove(0, SC.IndexOf("+++") + 3);
        //    Result.Add("TotalCylinders", SC.Substring(0, SC.IndexOf("+++")));
        //    SC = SC.Remove(0, SC.IndexOf("+++") + 3);
        //    Result.Add("TotalSectors", SC.Substring(0, SC.IndexOf("+++")));
        //    SC = SC.Remove(0, SC.IndexOf("+++") + 3);
        //    Result.Add("CPU", SC.Substring(0, SC.IndexOf("+++")));
        //    SC = SC.Remove(0, SC.IndexOf("+++") + 3);

        //    try
        //    {
        //        Result.Add("MacAddress", SC.Substring(0, SC.IndexOf("+++")));
        //        SC = SC.Remove(0, SC.IndexOf("+++") + 3);
        //        Result.Add("SoftwareCode", SC);
        //    }
        //    catch
        //    {
        //        Result.Add("MacAddress", SC);
        //        Result.Add("SoftwareCode", "");
        //    }

        //    return Result;
        //}

        //public static string ExtractCodeOfKey(string PathFile)
        //{
        //    string text = System.IO.File.ReadAllText(PathFile);

        //    RSaEncryptionLib.BaseCom BS = new RSaEncryptionLib.BaseCom();
        //    BS.LoadPublicKey();
        //    BS.LoadPrivateKey();


        //    string Result = "";
        //    try
        //    {
        //        Result = BS.PrivateDecryption(text);
        //    }
        //    catch { }

        //    return Result;
        //}


        ////private static string HddAndCpuCheck(string model)
        ////{
        ////    string S = "", M = "", TC = "", TS = "";
        ////    ManagementObjectSearcher mosDisks = new ManagementObjectSearcher(
        ////        "SELECT * FROM Win32_DiskDrive WHERE Model = '" + model + "'");

        ////    foreach (ManagementObject moDisk in mosDisks.Get())
        ////    {
        ////        //S = moDisk["SerialNumber"].ToString();
        ////        M = moDisk["Model"].ToString();
        ////        TC = moDisk["TotalCylinders"].ToString();
        ////        TS = moDisk["TotalSectors"].ToString();
        ////    }
        ////    return model + "+++" + GetCPU() + "+++" + GetMacAddress() + "+++" + GetTotalCylindersHDD(model) + "+++" + GetTotalSectorsHDD(model);
        ////}

        ////private static string HddAndCpuDefFinalCheck(string model)
        ////{
        ////    string M = "", TC = "", TS = "";
        ////    ManagementObjectSearcher mosDisks = new ManagementObjectSearcher(
        ////        "SELECT * FROM Win32_DiskDrive WHERE Model = '" + model + "'");

        ////    foreach (ManagementObject moDisk in mosDisks.Get())
        ////    {
        ////        M = moDisk["Model"].ToString();
        ////        TC = moDisk["TotalCylinders"].ToString();
        ////        TS = moDisk["TotalSectors"].ToString();
        ////    }
        ////    return M + "+++" + GetCPU() + "+++" + TC + "+++" + TS;
        ////}

        //private static string HddAndCpuDef()
        //{
        //    string Model = "", HddAndCpuDef = "";
        //    ManagementObjectSearcher mosDisks = new ManagementObjectSearcher(
        //        "SELECT  * FROM Win32_DiskDrive ");

        //    foreach (ManagementObject moDisk in mosDisks.Get())
        //    {
        //        Model = moDisk["Model"].ToString();
        //        HddAndCpuDef += Model + "\\";
        //        HddAndCpuDef += GetTotalCylindersHDD(Model) + "\\";
        //        HddAndCpuDef += GetTotalSectorsHDD(Model) + "//////";
        //    }

        //    HddAndCpuDef += GetCPU() + "\\" + GetMacAddress() + "//////////////";

        //    return HddAndCpuDef;
        //}

        //private static string GetTotalCylindersHDD(string model)
        //{
        //    string TotalCylinders = "";
        //    ManagementObjectSearcher mosDisks = new ManagementObjectSearcher(
        //        "SELECT  * FROM Win32_DiskDrive WHERE Model = '" + model + "'");

        //    foreach (ManagementObject moDisk in mosDisks.Get())
        //    {
        //        try { TotalCylinders = moDisk["TotalCylinders"].ToString(); }
        //        catch { TotalCylinders = ""; }
        //    }
        //    return TotalCylinders;
        //}

        //private static string GetTotalSectorsHDD(string model)
        //{
        //    string TotalSectors = "";
        //    ManagementObjectSearcher mosDisks = new ManagementObjectSearcher(
        //        "SELECT  * FROM Win32_DiskDrive WHERE Model = '" + model + "'");

        //    foreach (ManagementObject moDisk in mosDisks.Get())
        //    {
        //        try { TotalSectors = moDisk["TotalSectors"].ToString(); }
        //        catch { TotalSectors = ""; }
        //    }
        //    return TotalSectors;
        //}

        //private static string GetMacAddress()
        //{
        //    string macAddresses = string.Empty;

        //    foreach (System.Net.NetworkInformation.NetworkInterface nic in System.Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces())
        //    {
        //        if (nic.OperationalStatus == System.Net.NetworkInformation.OperationalStatus.Up)
        //        {
        //            macAddresses += nic.GetPhysicalAddress().ToString();
        //            break;
        //        }
        //    }

        //    return macAddresses;
        //}

        //private static string GetCPU()
        //{
        //    string GetCPU = string.Empty;
        //    System.Management.ManagementClass theClass = new System.Management.ManagementClass("Win32_Processor");
        //    System.Management.ManagementObjectCollection theCollectionOfResults = theClass.GetInstances();

        //    foreach (System.Management.ManagementObject currentResult in theCollectionOfResults)
        //    {
        //        GetCPU += currentResult["ProcessorID"].ToString();
        //    }

        //    return GetCPU;

        //}


        //public static string DecriptionText(string TextStr)
        //{
        //    RSaEncryptionLib.BaseCom BS = new RSaEncryptionLib.BaseCom();
        //    BS.LoadPublicKey();
        //    BS.LoadPrivateKey();


        //    string Result = "";
        //    try
        //    {
        //        Result = BS.PrivateDecryption(TextStr);
        //    }
        //    catch { }

        //    return Result;
        //}

        //public static string EncriptionText(string TextStr)
        //{
        //    RSaEncryptionLib.BaseCom BS = new RSaEncryptionLib.BaseCom();
        //    BS.LoadPublicKey();
        //    BS.LoadPrivateKey();


        //    string Result = "";
        //    try
        //    {
        //        Result = BS.PublicEncrypt(TextStr);
        //    }
        //    catch { }

        //    return Result;
        //}

        //#endregion


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
                    Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "قفل نرم افزاری معتبر نمی باشد", ex.Message);
                    ExitForce = true;
                     Application.Exit();;
                }

                try
                {
                    if (!CheckExtractCodeOfKey(ListExtractOfCode(SC)))
                    {
                        Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "امکان راه اندازی برنامه در این محیط (سیستم) وجود ندارد");
                        ExitForce = true;
                         Application.Exit();;
                    }
                }
                catch (Exception ex)
                {
                    Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "امکان راه اندازی برنامه در این محیط (سیستم) وجود ندارد", ex.Message);
                    ExitForce = true;
                     Application.Exit();;
                }
            }
            else
            {
                Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false,
                    "لطفا کدهای ذیل را جهت گرفتن فایل راه انداز ارسال نمایید ",
                    HddAndCpuDef());
                ExitForce = true;
                 Application.Exit();;
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

            if (LEC["CPU"] != GetCPU() && LEC["MacAddress"] != GetMacAddress() && LEC["TotalCylinders"] != GetTotalCylindersHDD(Model)) return false;
            if (LEC["TotalCylinders"] != GetTotalCylindersHDD(Model)) return false;
            if (LEC["TotalSectors"] != GetTotalSectorsHDD(Model)) return false;

            Global_Cls.SoftwareCode = LEC["SoftwareCode"] == "" ? "Trial" : LEC["SoftwareCode"];

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
            try
            {
                Result.Add("CPU", SC.Substring(0, SC.IndexOf("+++")));
                SC = SC.Remove(0, SC.IndexOf("+++") + 3);
                Result.Add("SoftwareCode", SC);
            }
            catch
            {
                Result.Add("CPU", "");
                Result.Add("SoftwareCode", SC);
            }

            try
            {
                Result.Add("MacAddress", SC.Substring(0, SC.IndexOf("+++")));
                SC = SC.Remove(0, SC.IndexOf("+++") + 3);
                Result.Add("SoftwareCode", SC);
            }
            catch
            {
                try
                {
                    Result.Add("MacAddress", "");
                    Result.Add("SoftwareCode", SC);
                }
                catch { }
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



        #region TestAccount

        public static string AgencyCodeStr = "";
        public static string AgencyPassStr = "";

        public static bool TestAccount_OKExpr(bool SendOrReciveFile)
        {
            UserPassWeb_frm UPWf = new UserPassWeb_frm();
            UPWf.SendOrReciveFile = SendOrReciveFile;
            UPWf.ShowDialog();
            return UPWf.AccountStatus;
        }

        #endregion


        #region Update Part & DownLoadFile

        static public void UpdatePart(string CityCode)
        {
            Application.DoEvents();
            string StrConnWeb = Function_Cls.ConnStrWeb;

            try
            {
                string StrConn = Global_Cls.ConnectionStr;

                SqlConnection SqConn = new SqlConnection(StrConn);

                SqlCommand SqCmd = new SqlCommand();
                SqCmd.Connection = SqConn;
                SqConn.Open();
                Application.DoEvents();
                SqCmd.CommandType = CommandType.StoredProcedure;
                SqCmd.CommandText = " [UpdatePart_sp] '" + StrConnWeb + "', " + CityCode + " ";

                SqlDataAdapter SDA = new SqlDataAdapter(SqCmd.CommandText, SqConn);
                SDA.UpdateCommand = new SqlCommand(SqCmd.CommandText, SqConn);
                try
                {
                    SDA.UpdateCommand.ExecuteReader();
                    Application.DoEvents();
                    Global_Cls.Message_Sara(0, Global_Cls.MessageType.SInformation, false, "مناطق به روز رسانی شدند");
                    SqConn.Close();
                }
                catch (Exception ex)
                {
                    Global_Cls.Message_Sara(0, Global_Cls.MessageType.SInformation, false, "اشکال در به روز رسانی مناطق", ex.ToString());

                    SqCmd.CommandType = CommandType.Text;
                    SqCmd.CommandText = " IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TBL_PartTemp]') AND type in (N'U'))" +
                                        " DROP TABLE [dbo].[TBL_PartTemp] ";

                    try
                    {
                        SqlDataReader SAD = SqCmd.ExecuteReader(CommandBehavior.Default);
                        SAD.Close();
                    }
                    catch { }

                }
                SqConn.Close();

            }
            catch (Exception ex)
            {
                Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "اشکال در اتصال به سرور", ex.ToString());
            }
        }

        static public bool DownLoadFile(DateTime DateYMD1, DateTime DateYMD2, int InterfaceMode)
        {
            Application.DoEvents();

            string StrConnWeb = Function_Cls.ConnStrWeb;
            string StrConn = Global_Cls.ConnectionStr;


            string StrWhere = " (1=1) ";

            if (InterfaceMode == 1)
            {
                if (DateYMD1 < Function_Cls.LastChargeDateRCV)
                {
                    //                    if (Function_Cls.LastChargeDateRCV > DateTime.Today.AddDays(-30)) StrWhere += " And (Modify_Date >= ''''" + Function_Cls.LastChargeDateRCV.ToShortDateString() + "'''')";
                    //                  else StrWhere += " And (Modify_Date >= ''''" + DateTime.Today.AddDays(-30).ToShortDateString() + "'''')";
                    if (Function_Cls.LastChargeDateRCV > DateTime.Today.AddDays(-30)) StrWhere += " And (Modify_Date >= ''" + Function_Cls.LastChargeDateRCV.ToShortDateString() + "'')";
                    else StrWhere += " And (Modify_Date >= ''" + DateTime.Today.AddDays(-30).ToShortDateString() + "'')";
                }
                else if (DateYMD1 >= Function_Cls.LastChargeDateRCV)
                {
                    //                    if (DateYMD1 > DateTime.Today.AddDays(-30)) StrWhere += " And (Modify_Date >= ''''" + DateYMD1.ToShortDateString() + "'''')";
                    //                  else StrWhere += " And (Modify_Date >= ''''" + DateTime.Today.AddDays(-30).ToShortDateString() + "'''')";
                    if (DateYMD1 > DateTime.Today.AddDays(-30)) StrWhere += " And (Modify_Date >= ''" + DateYMD1.ToShortDateString() + "'')";
                    else StrWhere += " And (Modify_Date >= ''" + DateTime.Today.AddDays(-30).ToShortDateString() + "'')";
                }

                //                if (DateYMD2 <= DateYMD1) StrWhere += " And (Modify_Date <= ''''" + DateYMD1.ToShortDateString() + "'''')";
                //              else StrWhere += " And (Modify_Date <= ''''" + DateYMD2.ToShortDateString() + "'''')";
                if (DateYMD2 <= DateYMD1) StrWhere += " And (Modify_Date <= ''" + DateYMD1.ToShortDateString() + "'')";
                else StrWhere += " And (Modify_Date <= ''" + DateYMD2.ToShortDateString() + "'')";

                StrWhere += " And (Lord_CityID = " + Function_Cls.Agency_CityIDRCV + ")";

                StrWhere += " And (Lord_PartRegion in (" + Function_Cls.FileReqRcvRegionRCV + ") )";

                StrWhere += " And (File_Level >= " + Function_Cls.Level_Use + " )";

            }
            else
            {

                if (DateYMD1 < Function_Cls.LastChargeDateRCV)
                {
                    //                    if (Function_Cls.LastChargeDateRCV > DateTime.Today.AddDays(-30)) StrWhere += " And (RequestDate >= ''''" + Function_Cls.LastChargeDateRCV.ToShortDateString() + "'''')";
                    //                  else StrWhere += " And (RequestDate >= ''''" + DateTime.Today.AddDays(-30).ToShortDateString() + "'''')";
                    if (Function_Cls.LastChargeDateRCV > DateTime.Today.AddDays(-30)) StrWhere += " And (RequestDate >= ''" + Function_Cls.LastChargeDateRCV.ToShortDateString() + "'')";
                    else StrWhere += " And (RequestDate >= ''" + DateTime.Today.AddDays(-30).ToShortDateString() + "'')";
                }
                else if (DateYMD1 >= Function_Cls.LastChargeDateRCV)
                {
                    //                    if (DateYMD1 > DateTime.Today.AddDays(-30)) StrWhere += " And (RequestDate >= ''''" + DateYMD1.ToShortDateString() + "'''')";
                    //                  else StrWhere += " And (RequestDate >= ''''" + DateTime.Today.AddDays(-30).ToShortDateString() + "'''')";
                    if (DateYMD1 > DateTime.Today.AddDays(-30)) StrWhere += " And (RequestDate >= ''" + DateYMD1.ToShortDateString() + "'')";
                    else StrWhere += " And (RequestDate >= ''" + DateTime.Today.AddDays(-30).ToShortDateString() + "'')";
                }

                //                if (DateYMD2 <= DateYMD1) StrWhere += " And (RequestDate <= ''''" + DateYMD1.ToShortDateString() + "'''')";
                //              else StrWhere += " And (RequestDate <= ''''" + DateYMD2.ToShortDateString() + "'''')";
                if (DateYMD2 <= DateYMD1) StrWhere += " And (RequestDate <= ''" + DateYMD1.ToShortDateString() + "'')";
                else StrWhere += " And (RequestDate <= ''" + DateYMD2.ToShortDateString() + "'')";

                StrWhere += " And (Customer_CityID = " + Function_Cls.Agency_CityIDRCV + ")";

                StrWhere += " And (Customer_PartRegion1 in (" + Function_Cls.FileReqRcvRegionRCV + ") " +
                    " Or Customer_PartRegion2 in (" + Function_Cls.FileReqRcvRegionRCV + ") " +
                    " Or Customer_PartRegion3 in (" + Function_Cls.FileReqRcvRegionRCV + ") " +
                    " Or Customer_PartRegion4 in (" + Function_Cls.FileReqRcvRegionRCV + ") " +
                    " )";

            }




            SqlConnection SqConWeb = new SqlConnection(StrConnWeb);
            SqlConnection SqConn = new SqlConnection(StrConn);


            //To Calculate The RowCount Of tbl_WebhouseFile Or tbl_WebHouseRequest Of Site
            try
            {
                SqlCommand SqCmd = new SqlCommand();
                SqCmd.Connection = SqConWeb;
                SqConWeb.Open();

                Application.DoEvents();

                if (InterfaceMode == 1)
                    SqCmd.CommandText = " Select Count(*) from tbl_WebHouseFile Where " + StrWhere.Replace("''", "'");
                else
                    SqCmd.CommandText = " Select Count(*) from TBL_WebHouseRequest Where " + StrWhere.Replace("''", "'");

                try
                {
                    SqlDataReader sda = SqCmd.ExecuteReader();
                    if (sda.Read())
                        Function_Cls.WebHouseReqRowCount = Convert.ToInt32(sda[0]);
                    SqConWeb.Close();
                    if (Function_Cls.WebHouseReqRowCount == 0)
                    {
                        Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "هیچ فایلی یافت نشد");
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "اشکال در محاسبه تعداد رکوردها", ex.ToString());
                    SqConWeb.Close();
                    return false;
                }
            }
            catch (Exception ex)
            {
                Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "اشکال در اتصال به سرور", ex.ToString());
                SqConWeb.Close();
                return false;
            }

            /////////////////////////////////////////////////////////////////



            // For Empty Table
            try
            {
                Application.DoEvents();

                SqlCommand SqCmd1 = new SqlCommand();
                SqCmd1.Connection = SqConn;
                SqConn.Open();

                if (InterfaceMode == 1)
                    SqCmd1.CommandText = " truncate table House_Management.dbo.TBL_TmpHouseFile ";
                else SqCmd1.CommandText = " truncate table House_Management.dbo.TBL_TmpHouseRequest ";
                SqlDataAdapter SDA = new SqlDataAdapter(SqCmd1.CommandText, SqConn);
                SDA.UpdateCommand = new SqlCommand(SqCmd1.CommandText, SqConn);
                try
                {
                    SDA.UpdateCommand.ExecuteReader();
                    SqConn.Close();
                }
                catch (Exception ex)
                {
                    Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "جدول خالی نشد", ex.ToString());
                    SqConn.Close();
                }
            }
            catch (Exception ex)
            {
                Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "اشکال در اتصال به دیتابیس", ex.ToString());
                SqConn.Close();
                return false;
            }
            /////////////////////////////////////////////







            // For Insert Data From Web
            try
            {
                System.Collections.ArrayList sdf = new System.Collections.ArrayList();

                SqlCommand SqCmd2 = new SqlCommand();
                SqCmd2.Connection = SqConWeb;
                SqConWeb.Open();

                Application.DoEvents();

                if (InterfaceMode == 1)
                    SqCmd2.CommandText = " Select HouseID FROM tbl_WebHouseFile Where " + StrWhere.Replace("''", "'") + " Order By HouseID ";
                else
                    SqCmd2.CommandText = " Select RequestID FROM TBL_WebHouseRequest Where " + StrWhere.Replace("''", "'") + " Order By RequestID ";

                try
                {
                    SqlDataReader sda = SqCmd2.ExecuteReader();

                    while (sda.Read())
                        sdf.Add(Convert.ToInt64(sda[0]));
                    sda.Close();
                    SqConWeb.Close();
                }
                catch (Exception ex)
                {
                    Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "اشکال در ذخیره آی دی", ex.ToString());
                    SqConWeb.Close();
                    return false;
                }

                //////////////////////////////////////////////////////////////////////////

                SqlCommand SqCmd3 = new SqlCommand();
                SqCmd3.Connection = SqConn;

                int WRCount = Function_Cls.WebHouseReqRowCount / 5;
                if (Function_Cls.WebHouseReqRowCount % 5 == 0) WRCount--;
                int WCounter = 0;
                string StrWhereLoop = "";

                SqConn.Open();

                while (WCounter <= WRCount)
                {
                    if (Function_Cls.CloseFormDownLoad) break;


                    if (InterfaceMode == 1)
                        StrWhereLoop = StrWhere + " And (HouseID >= " + sdf[WCounter * 5] + ")";
                    else
                        StrWhereLoop = StrWhere + " And (RequestID >= " + sdf[WCounter * 5] + ")";

                    Application.DoEvents();

                    if (InterfaceMode == 1)
                        SqCmd3.CommandText = StoreProceText.InsertFromTBLWebHouseFileToLocal_sp(StrConnWeb, StrWhereLoop);
                    else
                        SqCmd3.CommandText = StoreProceText.InsertFromTBLWebHouseReqToLocal_sp(StrConnWeb, StrWhereLoop);

                    try
                    {
                        SqlDataReader sda = SqCmd3.ExecuteReader(CommandBehavior.Default);
                        sda.Close();
                    }
                    catch (Exception ex)
                    {
                        Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "اشکال در درج اطلاعات", (WCounter * 5).ToString() + " " + ex.ToString());
                        SqConn.Close();
                        return false;
                    }
                    Application.DoEvents();

                    WCounter++;
                    Function_Cls.WebHouseReqFewRowEffect = WCounter * 5;

                }

                Global_Cls.Message_Sara(0, Global_Cls.MessageType.SInformation, false, "اطلاعات درج شدند");
                SqConn.Close();

            }
            catch (Exception ex)
            {
                Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "اشکال در اتصال به سرور", ex.ToString());
                SqConWeb.Close();
                SqConn.Close();
                return false;
            }

            return true;
        }

        /*SqCmd.CommandType = CommandType.StoredProcedure;
        if (InterfaceMode == 1)
            SqCmd.CommandText = " InsertFromTBLWebHouseFileToLocal_sp '" + StrConnWeb + "', '" + StrWhere + "' ";
        else SqCmd.CommandText = " InsertFromTBLWebHouseReqToLocal_sp '" + StrConnWeb + "', '" + StrWhere + "' ";*/

        /*string PartStr = Convert.ToString(comboBox_HPart1.SelectedValue) + "," + Convert.ToString(comboBox_HPart2.SelectedValue) + "," +
    Convert.ToString(comboBox_HPart3.SelectedValue) + "," + Convert.ToString(comboBox_HPart4.SelectedValue) + "," +
    Convert.ToString(comboBox_HPart5.SelectedValue) + "," + Convert.ToString(comboBox_HPart6.SelectedValue) + "," +
    Convert.ToString(comboBox_HPart7.SelectedValue) + "," + Convert.ToString(comboBox_HPart8.SelectedValue);
if (InterfaceMode == 1)
{
    if (DateYMD1 < DateTime.Today.AddDays(-30)) StrWhere += " And (Modify_Date >= ''''" + DateTime.Today.AddDays(-30).ToShortDateString() + "'''')";
    else StrWhere += " And (Modify_Date >= ''''" + DateYMD1.ToShortDateString() + "'''')";
    if (DateYMD2 < DateTime.Today.AddDays(-30)) StrWhere += " And (Modify_Date <= ''''" + DateTime.Today.AddDays(-30).ToShortDateString() + "'''')";
    else StrWhere += " And (Modify_Date <= ''''" + DateYMD2.ToShortDateString() + "'''')";
    StrWhere += "And (patindex(''''%''''+isnull(convert(varchar(8),Lord_Part),''''0'''')+''''%'''',''''" + PartStr + "'''')>0) ";
}
else
{
    if (DateYMD1 < DateTime.Today.AddDays(-30)) StrWhere += " And (RequestDate >= ''''" + DateTime.Today.AddDays(-30).ToShortDateString() + "'''')";
    else StrWhere += " And (RequestDate >= ''''" + DateYMD1.ToShortDateString() + "'''')";
    if (DateYMD2 < DateTime.Today.AddDays(-30)) StrWhere += " And (RequestDate <= ''''" + DateTime.Today.AddDays(-30).ToShortDateString() + "'''')";
    else StrWhere += " And (RequestDate <= ''''" + DateYMD2.ToShortDateString() + "'''')";
    StrWhere += " And ((patindex(''''%''''+isnull(convert(varchar(8),PartRequest1),''''0'''')+''''%'''',''''" + PartStr + "'''')>0) Or (patindex(''''%''''+isnull(convert(varchar(8),PartRequest2),''''0'''')+''''%'''',''''" + PartStr + "'''')>0)" +
                " Or   (patindex(''''%''''+isnull(convert(varchar(8),PartRequest3),''''0'''')+''''%'''',''''" + PartStr + "'''')>0) Or (patindex(''''%''''+isnull(convert(varchar(8),PartRequest4),''''0'''')+''''%'''',''''" + PartStr + "'''')>0)" +
                " Or   (patindex(''''%''''+isnull(convert(varchar(8),PartRequest3),''''0'''')+''''%'''',''''" + PartStr + "'''')>0) Or (patindex(''''%''''+isnull(convert(varchar(8),PartRequest4),''''0'''')+''''%'''',''''" + PartStr + "'''')>0))";
}*/


        #endregion


        #region Read&Write ConfigFile & Settings

        static public void ReadSettingFromDB()
        {
            Global_Cls.TypeHouseAllCases = new StringCollection();
            Global_Cls.HouseFor = new StringCollection();
            Global_Cls.HouseForPrm = new StringCollection();
            Global_Cls.RequestFor = new StringCollection();

            DataClassesSecondDataContext da = new DataClassesSecondDataContext(Global_Cls.ConnectionStr);
            var result = da.TBL_SetDefaultSettings.First(c => c.SetID == 1);

            string TypeHousestr = result.TypeHouse;
            WriteToParameter(TypeHousestr, Global_Cls.TypeHouseAllCases);

            string HouseForStr = result.HouseFor;
            WriteToParameter(HouseForStr, Global_Cls.HouseFor);

            string RequestForStr = result.RequestFor;
            WriteToParameter(RequestForStr, Global_Cls.RequestFor);


            if (Global_Cls.MainForm.UserPrmHouseFor == "admin" || Global_Cls.MainForm.UserPrmHouseFor == "")
                Global_Cls.HouseForPrm = Global_Cls.HouseFor;
            else
            {
                string UserPrmHouseForStr = Global_Cls.MainForm.UserPrmHouseFor;
                WriteToParameter(UserPrmHouseForStr, Global_Cls.HouseForPrm);
            }

            Global_Cls.Money_Unit = result.Money_Unit;
            Global_Cls.Money_Change = result.Money_Change.Value;

        }

        public static void WriteSettingToDB()
        {
            DataClassesSecondDataContext da = new DataClassesSecondDataContext(Global_Cls.ConnectionStr);
            var dd = da.TBL_SetDefaultSettings.First(c => c.SetID == 1);
            dd.TypeHouse = ReadFromParameter(Global_Cls.TypeHouseAllCases);
            dd.HouseFor = ReadFromParameter(Global_Cls.HouseFor);
            dd.RequestFor = ReadFromParameter(Global_Cls.RequestFor);
            da.SubmitChanges();
        }


        public static void ReadFromXmlFiles()
        {
            Global_Cls.Adver_FieldName = new StringCollection();
            WriteToParameter(@"PartName_Fa;TypeHouse;HouseFor;FH_Submeter;FH_estateNo;Price_HouseAllStr;Price_MR;", Global_Cls.Adver_FieldName);
            Global_Cls.DefaultValueHouseFile = new StringCollection();
            WriteToParameter(@"11619162;1;2;1;سنگ;سرامیک;سنگ;اوپن;MDF;شخصی;1;1389/02/04;آپارتمان;فروش;checkBox_IRWc;checkBox_Tel;checkBox_Balcony;checkBox_FirePlace;checkBox_Parking;checkBox_StRoom;checkBox_Water;checkBox_Electricity;checkBox_Gaz;checkBox_Cooler;checkBox_Heat;checkBox_Property;checkBox_DocUse;", Global_Cls.DefaultValueHouseFile);
            Global_Cls.AllSelectField_Conclusion = new StringCollection();
            WriteToParameter(@"Hc_No;Hc_Type;LordName;CustomerName;CostPrice;DateCnclu;CostMtgRent;", Global_Cls.AllSelectField_Conclusion);
            Global_Cls.AllSelectField_House = new StringCollection();
            WriteToParameter(@"FileNOInt;ModifyDate;HouseFor;TypeHouse;PartName_Fa;FH_estateNo;FH_Submeter;Price_HouseAllStr;Price_MR;", Global_Cls.AllSelectField_House);
            Global_Cls.AllSelectField_Customer = new StringCollection();
            WriteToParameter(@"Request_NO;RequestDate;HouseReqFor;TypeHouseReq;Customer_Name;Customer_Mobile;Req_SubMeterStr;Bodget_BuyStr;Bodget_RentStr;Bodget_MortgageStr;", Global_Cls.AllSelectField_Customer);
            Global_Cls.AllSelectField_NonActiveHouse = new StringCollection();
            WriteToParameter(@"FileNOInt;HouseFor;TypeHouse;PartName_Fa;FH_estateNo;FH_Submeter;Price_HouseAllStr;Price_MR;", Global_Cls.AllSelectField_NonActiveHouse);
            Global_Cls.AllSelectField_ForMemorundom = new StringCollection();
            WriteToParameter(@"FileNOInt;HouseFor;TypeHouse;PartName_Fa;FH_estateNo;FH_Submeter;Price_HouseAllStr;Price_MR;", Global_Cls.AllSelectField_ForMemorundom);
            Global_Cls.AllSelectField_DelHouse = new StringCollection();
            WriteToParameter("FileNOInt;HouseFor;TypeHouse;PartName_Fa;FH_estateNo;FH_Submeter;Price_HouseAllStr;Price_MR;", Global_Cls.AllSelectField_DelHouse);
            Global_Cls.AllSelectField_TmpHouse = new StringCollection();
            WriteToParameter(@"FileNO;HouseFor;TypeHouse;Lord_NF;Lord_Mobile;PartName_Fa;FH_estateNo;FH_Submeter;Price_HouseAllStr;Price_MR;", Global_Cls.AllSelectField_TmpHouse);
            Global_Cls.AllSelectField_TmpCustomer = new StringCollection();
            WriteToParameter(@"Request_NO;RequestDate;HouseReqFor;TypeHouseReq;Customer_Name;Customer_Mobile;Req_SubMeterStr;Bodget_BuyStr;Bodget_RentStr;Bodget_MortgageStr;", Global_Cls.AllSelectField_TmpCustomer);
            Global_Cls.SetWebHousePart = new StringCollection();
            WriteToParameter(@"0;0;0;0;0;0;0;0;", Global_Cls.SetWebHousePart);

            if (File.Exists(Application.StartupPath + "\\LocalConfig.xml"))
            {
                try
                {
                    XDocument loaded = XDocument.Load(Application.StartupPath + "\\LocalConfig.xml");

                    var q = (from c in loaded.Descendants("setting")
                             select c).ToList();

                    Global_Cls.NonActiveOn_Off = Convert.ToBoolean(q.Find(j => j.FirstAttribute.Value == "NonActiveOn_Off").Value);
                    Global_Cls.NonActive_Day = Convert.ToInt16(q.Find(j => j.FirstAttribute.Value == "NonActive_Day").Value);
                    WriteToParameter(q.Find(j => j.FirstAttribute.Value == "Adver_FieldName").Value, Global_Cls.Adver_FieldName);
                    Global_Cls.Adver_separator = q.Find(j => j.FirstAttribute.Value == "Adver_separator").Value;
                    WriteToParameter(q.Find(j => j.FirstAttribute.Value == "DefaultValueHouseFile").Value, Global_Cls.DefaultValueHouseFile);
                    Global_Cls.IsDefaultValue = Convert.ToBoolean(q.Find(j => j.FirstAttribute.Value == "IsDefaultValue").Value);
                    Global_Cls.ServerName = q.Find(j => j.FirstAttribute.Value == "ServerName").Value;
                    Global_Cls.ConnectionDef = q.Find(j => j.FirstAttribute.Value == "ConnectionDef").Value;
                    Global_Cls.ServerNameForLock = q.Find(j => j.FirstAttribute.Value == "ServerNameForLock").Value;
                    Global_Cls.HouseFile_Print = Convert.ToBoolean(q.Find(j => j.FirstAttribute.Value == "HouseFile_Print").Value);
                    Global_Cls.HouseFile_TelNtBook = Convert.ToBoolean(q.Find(j => j.FirstAttribute.Value == "HouseFile_TelNtBook").Value);
                    Global_Cls.HouseFile_DataHolder = Convert.ToBoolean(q.Find(j => j.FirstAttribute.Value == "HouseFile_DataHolder").Value);
                    Global_Cls.HouseFile_CustomerList = Convert.ToBoolean(q.Find(j => j.FirstAttribute.Value == "HouseFile_CustomerList").Value);
                    Global_Cls.ColorDisplay = Convert.ToByte(q.Find(j => j.FirstAttribute.Value == "ColorDisplay").Value);
                    Global_Cls.FileNoFlage = Convert.ToBoolean(q.Find(j => j.FirstAttribute.Value == "FileNoFlage").Value);

                    WriteToParameter(q.Find(j => j.FirstAttribute.Value == "AllSelectField_Conclusion").Value, Global_Cls.AllSelectField_Conclusion);
                    WriteToParameter(q.Find(j => j.FirstAttribute.Value == "AllSelectField_House").Value, Global_Cls.AllSelectField_House);
                    WriteToParameter(q.Find(j => j.FirstAttribute.Value == "AllSelectField_Customer").Value, Global_Cls.AllSelectField_Customer);
                    WriteToParameter(q.Find(j => j.FirstAttribute.Value == "AllSelectField_NonActiveHouse").Value, Global_Cls.AllSelectField_NonActiveHouse);
                    WriteToParameter(q.Find(j => j.FirstAttribute.Value == "AllSelectField_ForMemorundom").Value, Global_Cls.AllSelectField_ForMemorundom);
                    WriteToParameter(q.Find(j => j.FirstAttribute.Value == "AllSelectField_DelHouse").Value, Global_Cls.AllSelectField_DelHouse);
                    WriteToParameter(q.Find(j => j.FirstAttribute.Value == "AllSelectField_TmpHouse").Value, Global_Cls.AllSelectField_TmpHouse);
                    WriteToParameter(q.Find(j => j.FirstAttribute.Value == "AllSelectField_TmpCustomer").Value, Global_Cls.AllSelectField_TmpCustomer);
                    WriteToParameter(q.Find(j => j.FirstAttribute.Value == "SetWebHousePart").Value, Global_Cls.SetWebHousePart);
                }
                catch { }
            }



            Global_Cls.ReportDesignAddress = new StringCollection();
            Global_Cls.ReportDesignHouseType = new StringCollection();
            WriteToParameter(@"Report\HouseFiles\main.mrt;Report\HouseFiles\main.mrt;Report\HouseFiles\main.mrt;Report\HouseFiles\main.mrt;Report\HouseFiles\main.mrt;Report\HouseFiles\main.mrt;Report\HouseFiles\main.mrt;Report\HouseFiles\ActiveHouse.mrt;Report\HouseFiles\NonActiveHouse.mrt;Report\HouseFiles\MemHouse.mrt;Report\HouseFiles\DelHouse.mrt;Report\Customer\ListCustomer.mrt;Report\Other\ListConclusion.mrt;Report\Other\UserList.mrt;Report\Other\PersonTelMobile.mrt;Report\Other\Advertisment.mrt;", Global_Cls.ReportDesignAddress);
            WriteToParameter(@"آپارتمان,اتاق اداری,;خانه,,;زمین,,;باغ,,;,,;,,;", Global_Cls.ReportDesignHouseType);

            string RootStr = Global_Cls.RootSaveLoad() + "\\MainConfig.xml";

            if (File.Exists(RootStr))
            {
                try
                {
                    XDocument loaded = XDocument.Load(RootStr);

                    var q = (from c in loaded.Descendants("setting")
                             select c).ToList();

                    Global_Cls.SMSPort = q.Find(j => j.FirstAttribute.Value == "SMSPort").Value;
                    Global_Cls.SMSBaudRate = Convert.ToInt32(q.Find(j => j.FirstAttribute.Value == "SMSBaudRate").Value);
                    Global_Cls.SMSDataBits = Convert.ToInt32(q.Find(j => j.FirstAttribute.Value == "SMSDataBits").Value);
                    Global_Cls.SMSParity = Convert.ToInt32(q.Find(j => j.FirstAttribute.Value == "SMSParity").Value);
                    Global_Cls.SMSStopBits = Convert.ToInt32(q.Find(j => j.FirstAttribute.Value == "SMSStopBits").Value);
                    Global_Cls.SMSFlowControl = Convert.ToInt32(q.Find(j => j.FirstAttribute.Value == "SMSFlowControl").Value);
                    Global_Cls.SMSTimeOut = Convert.ToInt32(q.Find(j => j.FirstAttribute.Value == "SMSTimeOut").Value);

                    Global_Cls.SMSEncoding = Convert.ToInt32(q.Find(j => j.FirstAttribute.Value == "SMSEncoding").Value);
                    Global_Cls.SMSLongMsg = Convert.ToInt32(q.Find(j => j.FirstAttribute.Value == "SMSLongMsg").Value);
                    Global_Cls.SMSDeliveryReport = Convert.ToBoolean(q.Find(j => j.FirstAttribute.Value == "SMSDeliveryReport").Value);

                    //Global_Cls.Comm_Port = Convert.ToInt32(q.Find(j => j.FirstAttribute.Value == "Comm_Port").Value);
                    //Global_Cls.Comm_BaudRate = Convert.ToInt32(q.Find(j => j.FirstAttribute.Value == "Comm_BaudRate").Value);
                    //Global_Cls.Comm_TimeOut = Convert.ToInt32(q.Find(j => j.FirstAttribute.Value == "Comm_TimeOut").Value);
                    //Global_Cls.Send_Unicode = Convert.ToBoolean(q.Find(j => j.FirstAttribute.Value == "Send_Unicode").Value);
                    Global_Cls.AgancyAdmin_Name = q.Find(j => j.FirstAttribute.Value == "AgancyAdmin_Name").Value;
                    Global_Cls.Agancy_Name = q.Find(j => j.FirstAttribute.Value == "Agancy_Name").Value;
                    Global_Cls.Agancy_Tel = q.Find(j => j.FirstAttribute.Value == "Agancy_Tel").Value;
                    Global_Cls.Agancy_Mobile = q.Find(j => j.FirstAttribute.Value == "Agancy_Mobile").Value;
                    Global_Cls.Agancy_Address = q.Find(j => j.FirstAttribute.Value == "Agancy_Address").Value;
                    Global_Cls.Agancy_Email = q.Find(j => j.FirstAttribute.Value == "Agancy_Email").Value;
                    Global_Cls.Agancy_LogoName = q.Find(j => j.FirstAttribute.Value == "Agancy_LogoName").Value;
                    Global_Cls.CityPic_Name = q.Find(j => j.FirstAttribute.Value == "CityPic_Name").Value;
                    Global_Cls.BkpExitType = Convert.ToInt32(q.Find(j => j.FirstAttribute.Value == "BkpExitType").Value);
                    Global_Cls.BkpAutoRoot = q.Find(j => j.FirstAttribute.Value == "BkpAutoRoot").Value;
                    Global_Cls.PssRstrr = q.Find(j => j.FirstAttribute.Value == "PssRstrr").Value;
                    Global_Cls.BkpRstPicsFilms = Convert.ToBoolean(q.Find(j => j.FirstAttribute.Value == "BkpRstPicsFilms").Value);
                    Global_Cls.BkpRstDesignReport = Convert.ToBoolean(q.Find(j => j.FirstAttribute.Value == "BkpRstDesignReport").Value);
                    WriteToParameter(q.Find(j => j.FirstAttribute.Value == "ReportDesignAddress").Value, Global_Cls.ReportDesignAddress);
                    WriteToParameter(q.Find(j => j.FirstAttribute.Value == "ReportDesignHouseType").Value, Global_Cls.ReportDesignHouseType);
                }
                catch { }
            }

        }

        public static string ConnStrWeb = //@"Data Source=.;Initial Catalog=HouseManagement_Sara;Integrated Security=True";
        @"Server=208.43.158.133\SQL2005,6688;Uid=fgpco;Pwd=sara0331mkh;Database=HouseManagement_SR;Trusted_Connection=no;";
        public static string FileReqRcvRegionRCV = "";
        public static int Agency_CityIDRCV = 0;
        public static Int16 Level_Use = 3;
        public static DateTime LastChargeDateRCV = DateTime.Today;
        public static int WebHouseReqRowCount = 0;
        public static int WebHouseReqFewRowEffect = 0;
        public static bool CloseFormDownLoad = false;

        public static void WriteToXmlFiles()
        {
            XElement xmlLoacl = new XElement("userSettings",
                        new XElement("setting",
                            new XAttribute("Name", "NonActiveOn_Off"),
                            new XElement("Value", Global_Cls.NonActiveOn_Off.ToString())
                        ),
                        new XElement("setting",
                            new XAttribute("Name", "NonActive_Day"),
                            new XElement("Value", Global_Cls.NonActive_Day.ToString())
                        ),
                        new XElement("setting",
                            new XAttribute("Name", "Adver_FieldName"),
                            new XElement("Value", ReadFromParameter(Global_Cls.Adver_FieldName))
                        ),
                        new XElement("setting",
                            new XAttribute("Name", "Adver_separator"),
                            new XElement("Value", Global_Cls.Adver_separator.ToString())
                        ),
                        new XElement("setting",
                            new XAttribute("Name", "DefaultValueHouseFile"),
                            new XElement("Value", ReadFromParameter(Global_Cls.DefaultValueHouseFile))
                        ),
                        new XElement("setting",
                            new XAttribute("Name", "IsDefaultValue"),
                            new XElement("Value", Global_Cls.IsDefaultValue.ToString())
                        ),
                        new XElement("setting",
                            new XAttribute("Name", "ServerName"),
                            new XElement("Value", Global_Cls.ServerName)
                        ),
                        new XElement("setting",
                            new XAttribute("Name", "ConnectionDef"),
                            new XElement("Value", Global_Cls.ConnectionDef)
                        ),
                        new XElement("setting",
                            new XAttribute("Name", "ServerNameForLock"),
                            new XElement("Value", Global_Cls.ServerNameForLock)
                        ),
                        new XElement("setting",
                            new XAttribute("Name", "HouseFile_Print"),
                            new XElement("Value", Global_Cls.HouseFile_Print.ToString())
                        ),
                        new XElement("setting",
                            new XAttribute("Name", "HouseFile_TelNtBook"),
                            new XElement("Value", Global_Cls.HouseFile_TelNtBook)
                        ),
                        new XElement("setting",
                            new XAttribute("Name", "HouseFile_DataHolder"),
                            new XElement("Value", Global_Cls.HouseFile_DataHolder)
                        ),
                        new XElement("setting",
                            new XAttribute("Name", "HouseFile_CustomerList"),
                            new XElement("Value", Global_Cls.HouseFile_CustomerList)
                        ),
                        new XElement("setting",
                            new XAttribute("Name", "ColorDisplay"),
                            new XElement("Value", Global_Cls.ColorDisplay)
                        ),
                        new XElement("setting",
                            new XAttribute("Name", "FileNoFlage"),
                            new XElement("Value", Global_Cls.FileNoFlage)
                        ),
                        new XElement("setting",
                            new XAttribute("Name", "AllSelectField_Conclusion"),
                            new XElement("Value", ReadFromParameter(Global_Cls.AllSelectField_Conclusion))
                        ),
                        new XElement("setting",
                            new XAttribute("Name", "AllSelectField_House"),
                            new XElement("Value", ReadFromParameter(Global_Cls.AllSelectField_House))
                        ),
                        new XElement("setting",
                            new XAttribute("Name", "AllSelectField_Customer"),
                            new XElement("Value", ReadFromParameter(Global_Cls.AllSelectField_Customer))
                        ),
                        new XElement("setting",
                            new XAttribute("Name", "AllSelectField_NonActiveHouse"),
                            new XElement("Value", ReadFromParameter(Global_Cls.AllSelectField_NonActiveHouse))
                        ),
                        new XElement("setting",
                            new XAttribute("Name", "AllSelectField_ForMemorundom"),
                            new XElement("Value", ReadFromParameter(Global_Cls.AllSelectField_ForMemorundom))
                        ),
                        new XElement("setting",
                            new XAttribute("Name", "AllSelectField_DelHouse"),
                            new XElement("Value", ReadFromParameter(Global_Cls.AllSelectField_DelHouse))
                        ),
                        new XElement("setting",
                            new XAttribute("Name", "AllSelectField_TmpHouse"),
                            new XElement("Value", ReadFromParameter(Global_Cls.AllSelectField_TmpHouse))
                        ),
                        new XElement("setting",
                            new XAttribute("Name", "AllSelectField_TmpCustomer"),
                            new XElement("Value", ReadFromParameter(Global_Cls.AllSelectField_TmpCustomer))
                        ),
                        new XElement("setting",
                            new XAttribute("Name", "SetWebHousePart"),
                            new XElement("Value", ReadFromParameter(Global_Cls.SetWebHousePart))
                        )
                    );
            xmlLoacl.Save(Application.StartupPath + "\\LocalConfig.xml");



            if (!Global_Cls.ClientSoftOK)
            {
                XElement XmlMain = new XElement("userSettings",
                    //new XElement("setting",
                    //    new XAttribute("Name", "Comm_Port"),
                    //    new XElement("Value", Global_Cls.Comm_Port.ToString())
                    //),
                    //new XElement("setting",
                    //    new XAttribute("Name", "Comm_BaudRate"),
                    //    new XElement("Value", Global_Cls.Comm_BaudRate.ToString())
                    //),
                    //new XElement("setting",
                    //    new XAttribute("Name", "Comm_TimeOut"),
                    //    new XElement("Value", Global_Cls.Comm_TimeOut.ToString())
                    //),
                    //new XElement("setting",
                    //    new XAttribute("Name", "Send_Unicode"),
                    //    new XElement("Value", Global_Cls.Send_Unicode.ToString())
                    //),

                        new XElement("setting",
                            new XAttribute("Name", "SMSPort"),
                            new XElement("Value", Global_Cls.SMSPort.ToString())
                        ),
                        new XElement("setting",
                            new XAttribute("Name", "SMSBaudRate"),
                            new XElement("Value", Global_Cls.SMSBaudRate.ToString())
                        ),
                        new XElement("setting",
                            new XAttribute("Name", "SMSDataBits"),
                            new XElement("Value", Global_Cls.SMSDataBits.ToString())
                        ),
                        new XElement("setting",
                            new XAttribute("Name", "SMSParity"),
                            new XElement("Value", Global_Cls.SMSParity.ToString())
                        ),
                        new XElement("setting",
                            new XAttribute("Name", "SMSStopBits"),
                            new XElement("Value", Global_Cls.SMSStopBits.ToString())
                        ),
                        new XElement("setting",
                            new XAttribute("Name", "SMSFlowControl"),
                            new XElement("Value", Global_Cls.SMSFlowControl.ToString())
                        ),
                        new XElement("setting",
                            new XAttribute("Name", "SMSTimeOut"),
                            new XElement("Value", Global_Cls.SMSTimeOut.ToString())
                        ),
                        new XElement("setting",
                            new XAttribute("Name", "SMSEncoding"),
                            new XElement("Value", Global_Cls.SMSEncoding.ToString())
                        ),
                        new XElement("setting",
                            new XAttribute("Name", "SMSLongMsg"),
                            new XElement("Value", Global_Cls.SMSLongMsg.ToString())
                        ),
                        new XElement("setting",
                            new XAttribute("Name", "SMSDeliveryReport"),
                            new XElement("Value", Global_Cls.SMSDeliveryReport.ToString())
                        ),



                        new XElement("setting",
                            new XAttribute("Name", "AgancyAdmin_Name"),
                            new XElement("Value", Global_Cls.AgancyAdmin_Name)
                        ),
                        new XElement("setting",
                            new XAttribute("Name", "Agancy_Name"),
                            new XElement("Value", Global_Cls.Agancy_Name)
                        ),
                        new XElement("setting",
                            new XAttribute("Name", "Agancy_Tel"),
                            new XElement("Value", Global_Cls.Agancy_Tel)
                        ),
                        new XElement("setting",
                            new XAttribute("Name", "Agancy_Mobile"),
                            new XElement("Value", Global_Cls.Agancy_Mobile)
                        ),
                        new XElement("setting",
                            new XAttribute("Name", "Agancy_Address"),
                            new XElement("Value", Global_Cls.Agancy_Address)
                        ),
                        new XElement("setting",
                            new XAttribute("Name", "Agancy_Email"),
                            new XElement("Value", Global_Cls.Agancy_Email)
                        ),
                        new XElement("setting",
                            new XAttribute("Name", "Agancy_LogoName"),
                            new XElement("Value", Global_Cls.Agancy_LogoName)
                        ),
                        new XElement("setting",
                            new XAttribute("Name", "CityPic_Name"),
                            new XElement("Value", Global_Cls.CityPic_Name)
                        ),
                        new XElement("setting",
                            new XAttribute("Name", "BkpExitType"),
                            new XElement("Value", Global_Cls.BkpExitType.ToString())
                        ),
                        new XElement("setting",
                            new XAttribute("Name", "BkpAutoRoot"),
                            new XElement("Value", Global_Cls.BkpAutoRoot)
                        ),
                        new XElement("setting",
                            new XAttribute("Name", "PssRstrr"),
                            new XElement("Value", Global_Cls.PssRstrr)
                        ),
                        new XElement("setting",
                            new XAttribute("Name", "BkpRstPicsFilms"),
                            new XElement("Value", Global_Cls.BkpRstPicsFilms.ToString())
                        ),
                        new XElement("setting",
                            new XAttribute("Name", "BkpRstDesignReport"),
                            new XElement("Value", Global_Cls.BkpRstDesignReport.ToString())
                        ),
                        new XElement("setting",
                            new XAttribute("Name", "ReportDesignAddress"),
                            new XElement("Value", ReadFromParameter(Global_Cls.ReportDesignAddress))
                        ),
                        new XElement("setting",
                            new XAttribute("Name", "ReportDesignHouseType"),
                            new XElement("Value", ReadFromParameter(Global_Cls.ReportDesignHouseType))
                        )
                    );

                XmlMain.Save(Global_Cls.RootSaveLoad() + "\\MainConfig.xml");
            }

        }


        public static void WriteToParameter(string StrEnter, StringCollection StrColect)
        {
            int i = 0;
            StrColect.Clear();
            while (StrEnter.Length > 0)
            {
                StrColect.Insert(i, StrEnter.Substring(0, StrEnter.IndexOf(";")));
                StrEnter = StrEnter.Remove(0, StrEnter.IndexOf(";") + 1);
                i++;
            }
        }

        public static string ReadFromParameter(StringCollection StrColect)
        {
            string Result = "";
            for (int i = 0; i < StrColect.Count; i++)
                Result += StrColect[i].ToString() + ";";
            return Result;
        }


        #endregion


        static public void CreateShortcut(string SourceFile, string ShortcutFile, string Description,
                 string Arguments, string HotKey, string WorkingDirectory)
        {
            // Check necessary parameters first:
            if (String.IsNullOrEmpty(SourceFile))
                throw new ArgumentNullException("SourceFile");
            if (String.IsNullOrEmpty(ShortcutFile))
                throw new ArgumentNullException("ShortcutFile");

            // Create WshShellClass instance:
            IWshRuntimeLibrary.WshShellClass wshShell = new IWshRuntimeLibrary.WshShellClass();

            // Create shortcut object:
            IWshRuntimeLibrary.IWshShortcut shorcut = (IWshRuntimeLibrary.IWshShortcut)wshShell.CreateShortcut(ShortcutFile);

            // Assign shortcut properties:
            shorcut.TargetPath = SourceFile;
            shorcut.Description = Description;
            if (!String.IsNullOrEmpty(Arguments))
                shorcut.Arguments = Arguments;
            if (!String.IsNullOrEmpty(HotKey))
                shorcut.Hotkey = HotKey;
            if (!String.IsNullOrEmpty(WorkingDirectory))
                shorcut.WorkingDirectory = WorkingDirectory;

            // Save the shortcut:
            shorcut.Save();
        }

        #region Trial Version

        public static bool CheckTrialVersion(int HouseOrCustOr)
        {
            //HouseOrCustOr = 1 House
            //HouseOrCustOr = 2 Customer
            //HouseOrCustOr = 3 House
            DataClasses_MainDataContext df = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
            if (HouseOrCustOr == 1)
                if (df.TBL_HouseFiles.Count() >= 10)
                {
                    Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "فعالیت شما جهت استفاده از نسخه رایگان به پایان رسیده است! لطفا جهت ارتقا با شرکت تماس بگیرید!");
                    return false;
                }
            if (HouseOrCustOr == 2)
                if (df.TBL_HouseRequests.Count() >= 10)
                {
                    Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "فعالیت شما جهت استفاده از نسخه رایگان به پایان رسیده است! لطفا جهت ارتقا با شرکت تماس بگیرید!");
                    return false;
                }

            return true;
        }

        #endregion
    }
}



/*public class WorkerDownLoadFile
{
    public DateTime DateYMD1 = DateTime.Today;
    public DateTime DateYMD2 = DateTime.Today;
    public int InterfaceMode = 0;
    public bool RetValue = false;
    public void DoWork()
    {
        while (!_shouldStop)
        {
            RetValue = HouseManagement_Prj.Function_Cls.DownLoadFile(DateYMD1, DateYMD2, InterfaceMode);
        }
        //MessageBox.Show("worker thread: terminating gracefully.");
    }
    public void RequestStop()
    {
        _shouldStop = true;
    }
    // Volatile is used as hint to the compiler that this data
    // member will be accessed by multiple threads.
    private volatile bool _shouldStop;
}

public class WorkerThreadDownLoadFile
{
    public bool Main(DateTime DateYMD1, DateTime DateYMD2, int InterfaceMode)
    {
        // Create the thread object. This does not start the thread.
        

        WorkerDownLoadFile workerObject = new WorkerDownLoadFile();
        workerObject.DateYMD1 = DateYMD1;
        workerObject.DateYMD2 = DateYMD2;
        workerObject.InterfaceMode = InterfaceMode;

        Thread WTDownLoadFile = new Thread(workerObject.DoWork);

        // Start the worker thread.
        WTDownLoadFile.Start();
        Console.WriteLine("main thread: Starting worker thread...");

        // Loop until worker thread activates.
        while (!WTDownLoadFile.IsAlive) ;

        // Put the main thread to sleep for 1 millisecond to
        // allow the worker thread to do some work:
        Thread.Sleep(2);

        // Request that the worker thread stop itself:
        workerObject.RequestStop();

        // Use the Join method to block the current thread 
        // until the object's thread terminates.
        WTDownLoadFile.Join();
        return workerObject.RetValue;
        //MessageBox.Show("main thread: Worker DownLoadFile has terminated.");
    }

}


public class WorkerLockTest
{
    public AxTINYLib.AxTiny TinySara;
    public string UserPass = "";
    public string SrNo = "";
    public string SpecID = "";

    public bool RetValue = false;
    public void DoWork()
    {
        while (!_shouldStop)
        {
            RetValue = HouseManagement_Prj.Function_Cls.TinySetFunc(TinySara, UserPass, SrNo, SpecID);
        }
    }
    public void RequestStop()
    {
        _shouldStop = true;
    }
    private volatile bool _shouldStop;
}

public class WorkerThreadLockTest
{
    public bool Main(AxTINYLib.AxTiny TinySara, string UserPass, string SrNo, string SpecID)
    {

        WorkerLockTest workerObject = new WorkerLockTest();
        workerObject.TinySara = TinySara;
        workerObject.UserPass = UserPass;
        workerObject.SrNo = SrNo;
        workerObject.SpecID = SpecID;

        Thread workerThread = new Thread(workerObject.DoWork);

        // Start the worker thread.
        workerThread.Start();
        Console.WriteLine("main thread: Starting worker thread...");

        // Loop until worker thread activates.
        while (!workerThread.IsAlive) ;

        // Put the main thread to sleep for 1 millisecond to
        // allow the worker thread to do some work:
        Thread.Sleep(1);

        // Request that the worker thread stop itself:
        workerObject.RequestStop();

        // Use the Join method to block the current thread 
        // until the object's thread terminates.
        workerThread.Join();
        return workerObject.RetValue;
        //MessageBox.Show("main thread: Worker DownLoadFile has terminated.");
    }

}
*/
