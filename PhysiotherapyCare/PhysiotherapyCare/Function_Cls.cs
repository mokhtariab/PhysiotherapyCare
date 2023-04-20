using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using System.IO;
using System.Xml.Linq;
using System.Collections.Specialized;
using System.Threading;
using System.Management;

namespace PhysiotherapyCare
{
    class Function_Cls
    {

  
        //#region SearchInternet
        //public static void SearchInternet(int SearchType)
        //{
        //    //1: Search  2: Map Search
        //    SearchInternet_frm SIf = new SearchInternet_frm();
        //    SIf.SearchTypeEnter = SearchType;
        //    SIf.ShowDialog();
        //}

        //#endregion


        #region Security


        //public code
        string SoftwareCode = "Trial";
        //"Trial"
        //"L1";//"L2";"+S"
        //"N1";//"N2";"+S"

        public static bool ExitForce = false;

        public static void CheckKeyFile()
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
                    Application.Exit();
                }

                try
                {
                    if (!CheckExtractCodeOfKey(ListExtractOfCode(SC)))
                    {
                        MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "امکان راه اندازی برنامه در این محیط (سیستم) وجود ندارد");
                        ExitForce = true;
                        Application.Exit();
                    }
                }
                catch (Exception ex)
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "امکان راه اندازی برنامه در این محیط (سیستم) وجود ندارد", ex.Message);
                    ExitForce = true;
                    Application.Exit();
                }
            }
            else
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false,
                    "لطفا کدهای ذیل را جهت گرفتن فایل راه انداز ارسال نمایید ",
                    HddAndCpuDef());
                ExitForce = true;
                Application.Exit();
            }

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


            //public code
            string SoftwareCode = "Trial";
            //"Trial"
            //"L1";//"L2";"+S"
            //"N1";//"N2";"+S"
            
            
            SoftwareCode = LEC["SoftwareCode"] == "" ? "Trial" : LEC["SoftwareCode"];

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


        //#region Read&Write ConfigFile & Settings

        //public static void ReadFromXmlFiles()
        //{
        //    if (File.Exists(Application.StartupPath + "\\LocalConfig.xml"))
        //    {
        //        try
        //        {
        //            XDocument loaded = XDocument.Load("LocalConfig.xml");

        //            var q = (from c in loaded.Descendants("setting")
        //                     select c).ToList();


        //            Global_Cls.SMSPort = q.Find(j => j.FirstAttribute.Value == "SMSPort").Value;
        //            Global_Cls.SMSBaudRate = Convert.ToInt32(q.Find(j => j.FirstAttribute.Value == "SMSBaudRate").Value);
        //            Global_Cls.SMSDataBits = Convert.ToInt32(q.Find(j => j.FirstAttribute.Value == "SMSDataBits").Value);
        //            Global_Cls.SMSParity = Convert.ToInt32(q.Find(j => j.FirstAttribute.Value == "SMSParity").Value);
        //            Global_Cls.SMSStopBits = Convert.ToInt32(q.Find(j => j.FirstAttribute.Value == "SMSStopBits").Value);
        //            Global_Cls.SMSFlowControl = Convert.ToInt32(q.Find(j => j.FirstAttribute.Value == "SMSFlowControl").Value);
        //            Global_Cls.SMSTimeOut = Convert.ToInt32(q.Find(j => j.FirstAttribute.Value == "SMSTimeOut").Value);

        //            Global_Cls.SMSEncoding = Convert.ToInt32(q.Find(j => j.FirstAttribute.Value == "SMSEncoding").Value);
        //            Global_Cls.SMSLongMsg = Convert.ToInt32(q.Find(j => j.FirstAttribute.Value == "SMSLongMsg").Value);
        //            Global_Cls.SMSDeliveryReport = Convert.ToBoolean(q.Find(j => j.FirstAttribute.Value == "SMSDeliveryReport").Value);

        //            Global_Cls.PrvAlarmDayForVisit = Convert.ToInt32(q.Find(j => j.FirstAttribute.Value == "PrvAlarmDayForVisit").Value);

        //            Global_Cls.ServerName = q.Find(j => j.FirstAttribute.Value == "ServerName").Value;
        //            Global_Cls.ConnectionDef = q.Find(j => j.FirstAttribute.Value == "ConnectionDef").Value;
        //            Global_Cls.ServerNameForLock = q.Find(j => j.FirstAttribute.Value == "ServerNameForLock").Value;
        //            Global_Cls.ColorDisplay = Convert.ToByte(q.Find(j => j.FirstAttribute.Value == "ColorDisplay").Value);
        //            Global_Cls.CONameStr = q.Find(j => j.FirstAttribute.Value == "CONameStr").Value.ToString();

        //        }
        //        catch { }
        //    }

        //    string RootStr = Global_Cls.RootSaveLoad() + "\\MainConfig.xml";

        //    if (File.Exists(RootStr))
        //    {
        //        try
        //        {
        //            XDocument loaded = XDocument.Load(RootStr);

        //            var q = (from c in loaded.Descendants("setting")
        //                     select c).ToList();

        //            Global_Cls.BkpExitType = Convert.ToInt32(q.Find(j => j.FirstAttribute.Value == "BkpExitType").Value);
        //            Global_Cls.BkpAutoRoot = q.Find(j => j.FirstAttribute.Value == "BkpAutoRoot").Value;
        //            Global_Cls.PssRstrr = q.Find(j => j.FirstAttribute.Value == "PssRstrr").Value;
        //            Global_Cls.BkpRstPicsFilms = Convert.ToBoolean(q.Find(j => j.FirstAttribute.Value == "BkpRstPicsFilms").Value);
        //            Global_Cls.BkpRstDesignReport = Convert.ToBoolean(q.Find(j => j.FirstAttribute.Value == "BkpRstDesignReport").Value);

        //        }
        //        catch { }
        //    }

        //}

        //public static void WriteToXmlFiles()
        //{

        //    XElement xmlLoacl = new XElement("userSettings",
        //           new XElement("setting",
        //                    new XAttribute("Name", "SMSPort"),
        //                    new XElement("Value", Global_Cls.SMSPort.ToString())
        //                ),
        //                new XElement("setting",
        //                    new XAttribute("Name", "SMSBaudRate"),
        //                    new XElement("Value", Global_Cls.SMSBaudRate.ToString())
        //                ),
        //                new XElement("setting",
        //                    new XAttribute("Name", "SMSDataBits"),
        //                    new XElement("Value", Global_Cls.SMSDataBits.ToString())
        //                ),
        //                new XElement("setting",
        //                    new XAttribute("Name", "SMSParity"),
        //                    new XElement("Value", Global_Cls.SMSParity.ToString())
        //                ),
        //                new XElement("setting",
        //                    new XAttribute("Name", "SMSStopBits"),
        //                    new XElement("Value", Global_Cls.SMSStopBits.ToString())
        //                ),
        //                new XElement("setting",
        //                    new XAttribute("Name", "SMSFlowControl"),
        //                    new XElement("Value", Global_Cls.SMSFlowControl.ToString())
        //                ),
        //                new XElement("setting",
        //                    new XAttribute("Name", "SMSTimeOut"),
        //                    new XElement("Value", Global_Cls.SMSTimeOut.ToString())
        //                ),
        //                new XElement("setting",
        //                    new XAttribute("Name", "SMSEncoding"),
        //                    new XElement("Value", Global_Cls.SMSEncoding.ToString())
        //                ),
        //                new XElement("setting",
        //                    new XAttribute("Name", "SMSLongMsg"),
        //                    new XElement("Value", Global_Cls.SMSLongMsg.ToString())
        //                ),
        //                new XElement("setting",
        //                    new XAttribute("Name", "SMSDeliveryReport"),
        //                    new XElement("Value", Global_Cls.SMSDeliveryReport.ToString())
        //                ),

        //                new XElement("setting",
        //                    new XAttribute("Name", "PrvAlarmDayForVisit"),
        //                    new XElement("Value", Global_Cls.PrvAlarmDayForVisit)
        //                ),
        //                new XElement("setting",
        //                    new XAttribute("Name", "ServerName"),
        //                    new XElement("Value", Global_Cls.ServerName)
        //                ),
        //                new XElement("setting",
        //                    new XAttribute("Name", "ConnectionDef"),
        //                    new XElement("Value", Global_Cls.ConnectionDef)
        //                ),
        //                new XElement("setting",
        //                    new XAttribute("Name", "ServerNameForLock"),
        //                    new XElement("Value", Global_Cls.ServerNameForLock)
        //                ),

        //                new XElement("setting",
        //                    new XAttribute("Name", "ColorDisplay"),
        //                    new XElement("Value", Global_Cls.ColorDisplay)
        //                ),

        //                new XElement("setting",
        //                    new XAttribute("Name", "CONameStr"),
        //                    new XElement("Value", Global_Cls.CONameStr)
        //                )
        //            );
        //    xmlLoacl.Save(Application.StartupPath + "\\LocalConfig.xml");



        //    if (!Global_Cls.ClientSoftOK)
        //    {
        //        XElement XmlMain = new XElement("userSettings",
        //                new XElement("setting",
        //                    new XAttribute("Name", "BkpExitType"),
        //                    new XElement("Value", Global_Cls.BkpExitType.ToString())
        //                ),
        //                new XElement("setting",
        //                    new XAttribute("Name", "BkpAutoRoot"),
        //                    new XElement("Value", Global_Cls.BkpAutoRoot)
        //                ),
        //                new XElement("setting",
        //                    new XAttribute("Name", "PssRstrr"),
        //                    new XElement("Value", Global_Cls.PssRstrr)
        //                ),
        //                new XElement("setting",
        //                    new XAttribute("Name", "BkpRstPicsFilms"),
        //                    new XElement("Value", Global_Cls.BkpRstPicsFilms.ToString())
        //                ),
        //                new XElement("setting",
        //                    new XAttribute("Name", "BkpRstDesignReport"),
        //                    new XElement("Value", Global_Cls.BkpRstDesignReport.ToString())
        //                )

        //          );

        //        XmlMain.Save(Global_Cls.RootSaveLoad() + "\\MainConfig.xml");
        //    }

        //}


        //public static void WriteToParameter(string StrEnter, System.Collections.Specialized.StringCollection StrColect)
        //{
        //    int i = 0;
        //    StrColect.Clear();
        //    while (StrEnter.Length > 0)
        //    {
        //        StrColect.Insert(i, StrEnter.Substring(0, StrEnter.IndexOf(";")));
        //        StrEnter = StrEnter.Remove(0, StrEnter.IndexOf(";") + 1);
        //        i++;
        //    }
        //}


        //public static string ReadFromParameter(System.Collections.Specialized.StringCollection StrColect)
        //{
        //    string Result = "";
        //    for (int i = 0; i < StrColect.Count; i++)
        //        Result += StrColect[i].ToString() + ";";
        //    return Result;
        //}


        //#endregion



        //#region ExcelExport

        //public static void ExportExcelGrid(DevExpress.XtraGrid.GridControl GridControl)
        //{
        //    //DataTable dt = new DataTable("grid");
        //    //foreach (DevExpress.XtraGrid.Columns.GridColumn item in ((DevExpress.XtraGrid.Views.Base.ColumnView)GridControl.Views[0]).Columns)
        //    //    if (item.VisibleIndex != -1) 
        //    //        dt.Columns.Add(item.Name);

        //    ////foreach (DevExpress.XtraGrid.Views.Grid.row Columns.Gridro item in ((DevExpress.XtraGrid.Views.Base.ColumnView)GridControl.Views[0]).Columns)

        //    //for (int f = 0; f <= GridControl.Views[0].RowCount; f++)
        //    //{

        //    //    dt.Rows.Add(GridControl.Views[0].GetRow(f));
        //    //}

        //    //DevExpress.XtraGrid.GridControl GridC = new DevExpress.XtraGrid.GridControl();
        //    //GridC.DataSource = dt.DataSet.Tables[0];



        //    DevExpress.XtraGrid.GridControl GridC = new DevExpress.XtraGrid.GridControl();
        //    GridC = GridControl;

        //    Dictionary<string, int> h = new Dictionary<string, int>();
        //    foreach (DevExpress.XtraGrid.Columns.GridColumn item in ((DevExpress.XtraGrid.Views.Base.ColumnView)GridControl.Views[0]).Columns)
        //        if (item.VisibleIndex != -1)
        //            h.Add(item.Name, item.VisibleIndex);

        //    foreach (DevExpress.XtraGrid.Columns.GridColumn item in ((DevExpress.XtraGrid.Views.Base.ColumnView)GridC.Views[0]).Columns)
        //        item.Visible = false;


        //    foreach (KeyValuePair<string, int> pair in h)
        //    {
        //        ((((DevExpress.XtraGrid.Views.Base.ColumnView)GridC.Views[0]).Columns) as DevExpress.XtraGrid.Columns.GridColumnCollection)[pair.Key].VisibleIndex = h.Count() - 1;
        //    }

           

        //    using (SaveFileDialog saveDialog = new SaveFileDialog())
        //    {
        //        saveDialog.Filter = "Excel (2003)(.xls)|*.xls|Excel (2010) (.xlsx)|*.xlsx"; //|RichText File (.rtf)|*.rtf |Pdf File (.pdf)|*.pdf |Html File (.html)|*.html";
        //        if (saveDialog.ShowDialog() != DialogResult.Cancel)
        //        {
        //            string exportFilePath = saveDialog.FileName;
        //            string fileExtenstion = new FileInfo(exportFilePath).Extension;

        //            switch (fileExtenstion)
        //            {
        //                case ".xls":
        //                    GridC.ExportToXls(exportFilePath);
        //                    break;
        //                case ".xlsx":
        //                    GridC.ExportToXlsx(exportFilePath);
        //                    break;
        //                //case ".rtf":
        //                //    gridControl.ExportToRtf(exportFilePath);
        //                //    break;
        //                //case ".pdf":
        //                //    gridControl.ExportToPdf(exportFilePath);
        //                //    break;
        //                //case ".html":
        //                //    gridControl.ExportToHtml(exportFilePath);
        //                //    break;
        //                //case ".mht":
        //                //    gridControl.ExportToMht(exportFilePath);
        //                //    break;
        //                default:
        //                    break;
        //            }

        //            if (File.Exists(exportFilePath))
        //            {
        //                try
        //                {
        //                    //Try to open the file and let windows decide how to open it.
        //                    System.Diagnostics.Process.Start(exportFilePath);
        //                }
        //                catch
        //                {
        //                    String msg = "The file could not be opened." + Environment.NewLine + Environment.NewLine + "Path: " + exportFilePath;
        //                    MessageBox.Show(msg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                }
        //            }
        //            else
        //            {
        //                String msg = "The file could not be saved." + Environment.NewLine + Environment.NewLine + "Path: " + exportFilePath;
        //                MessageBox.Show(msg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            }
        //        }
        //    }
        //}

        //#endregion

    }
}



