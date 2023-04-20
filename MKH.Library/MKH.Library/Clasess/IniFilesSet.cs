using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace MKH.Library.Clasess
{
    public class IniFilesSet
    {

        public static string ReadFromXmlFiles(string ValueAttribute)
        {
            string Result ="";
            if (File.Exists("LocalConfig.xml"))
            {
                try
                {
                    XDocument loaded = XDocument.Load("LocalConfig.xml");

                    var q = (from c in loaded.Descendants("setting")
                             select c).ToList();

                    Result = q.Find(j => j.FirstAttribute.Value == ValueAttribute).Value;

                    //Global_Cls.SMSPort = q.Find(j => j.FirstAttribute.Value == "SMSPort").Value;
                    //Global_Cls.SMSBaudRate = Convert.ToInt32(q.Find(j => j.FirstAttribute.Value == "SMSBaudRate").Value);
                    //Global_Cls.SMSDataBits = Convert.ToInt32(q.Find(j => j.FirstAttribute.Value == "SMSDataBits").Value);
                    //Global_Cls.SMSParity = Convert.ToInt32(q.Find(j => j.FirstAttribute.Value == "SMSParity").Value);
                    //Global_Cls.SMSStopBits = Convert.ToInt32(q.Find(j => j.FirstAttribute.Value == "SMSStopBits").Value);
                    //Global_Cls.SMSFlowControl = Convert.ToInt32(q.Find(j => j.FirstAttribute.Value == "SMSFlowControl").Value);
                    //Global_Cls.SMSTimeOut = Convert.ToInt32(q.Find(j => j.FirstAttribute.Value == "SMSTimeOut").Value);

                    //Global_Cls.SMSEncoding = Convert.ToInt32(q.Find(j => j.FirstAttribute.Value == "SMSEncoding").Value);
                    //Global_Cls.SMSLongMsg = Convert.ToInt32(q.Find(j => j.FirstAttribute.Value == "SMSLongMsg").Value);
                    //Global_Cls.SMSDeliveryReport = Convert.ToBoolean(q.Find(j => j.FirstAttribute.Value == "SMSDeliveryReport").Value);

                    //Global_Cls.PrvAlarmDayForVisit = Convert.ToInt32(q.Find(j => j.FirstAttribute.Value == "PrvAlarmDayForVisit").Value);

                    //Global_Cls.ServerName = q.Find(j => j.FirstAttribute.Value == "ServerName").Value;
                    //Global_Cls.ConnectionDef = q.Find(j => j.FirstAttribute.Value == "ConnectionDef").Value;
                    //Global_Cls.ServerNameForLock = q.Find(j => j.FirstAttribute.Value == "ServerNameForLock").Value;
                    //Global_Cls.ColorDisplay = Convert.ToByte(q.Find(j => j.FirstAttribute.Value == "ColorDisplay").Value);
                    //Global_Cls.CONameStr = q.Find(j => j.FirstAttribute.Value == "CONameStr").Value.ToString();

                }
                catch { }
            }
            return Result;
        }

        public static void WriteToXmlFiles(string NameAttribute, string ValueAttribute)
        {

            //if (File.Exists("LocalConfig.xml"))
            //{
            XElement xmlLoacl = 
                new XElement("userSettings",
                   new XElement("setting",
                            new XAttribute("Name", NameAttribute),
                            new XElement("Value", ValueAttribute)
                        )
                        //new XElement("setting",
                        //    new XAttribute("Name", "SMSBaudRate"),
                        //    new XElement("Value", Global_Cls.SMSBaudRate.ToString())
                        //),
                        //new XElement("setting",
                        //    new XAttribute("Name", "SMSDataBits"),
                        //    new XElement("Value", Global_Cls.SMSDataBits.ToString())
                        //),
                        //new XElement("setting",
                        //    new XAttribute("Name", "SMSParity"),
                        //    new XElement("Value", Global_Cls.SMSParity.ToString())
                        //),
                        //new XElement("setting",
                        //    new XAttribute("Name", "SMSStopBits"),
                        //    new XElement("Value", Global_Cls.SMSStopBits.ToString())
                        //),
                        //new XElement("setting",
                        //    new XAttribute("Name", "SMSFlowControl"),
                        //    new XElement("Value", Global_Cls.SMSFlowControl.ToString())
                        //),
                        //new XElement("setting",
                        //    new XAttribute("Name", "SMSTimeOut"),
                        //    new XElement("Value", Global_Cls.SMSTimeOut.ToString())
                        //),
                        //new XElement("setting",
                        //    new XAttribute("Name", "SMSEncoding"),
                        //    new XElement("Value", Global_Cls.SMSEncoding.ToString())
                        //),
                        //new XElement("setting",
                        //    new XAttribute("Name", "SMSLongMsg"),
                        //    new XElement("Value", Global_Cls.SMSLongMsg.ToString())
                        //),
                        //new XElement("setting",
                        //    new XAttribute("Name", "SMSDeliveryReport"),
                        //    new XElement("Value", Global_Cls.SMSDeliveryReport.ToString())
                        //),

                        //new XElement("setting",
                        //    new XAttribute("Name", "PrvAlarmDayForVisit"),
                        //    new XElement("Value", Global_Cls.PrvAlarmDayForVisit)
                        //),
                        //new XElement("setting",
                        //    new XAttribute("Name", "ServerName"),
                        //    new XElement("Value", Global_Cls.ServerName)
                        //),
                        //new XElement("setting",
                        //    new XAttribute("Name", "ConnectionDef"),
                        //    new XElement("Value", Global_Cls.ConnectionDef)
                        //),
                        //new XElement("setting",
                        //    new XAttribute("Name", "ServerNameForLock"),
                        //    new XElement("Value", Global_Cls.ServerNameForLock)
                        //),

                        //new XElement("setting",
                        //    new XAttribute("Name", "ColorDisplay"),
                        //    new XElement("Value", Global_Cls.ColorDisplay)
                        //),

                        //new XElement("setting",
                        //    new XAttribute("Name", "CONameStr"),
                        //    new XElement("Value", Global_Cls.CONameStr)
                        //)
                    );
            xmlLoacl.Save("LocalConfig.xml");

        }


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


    }
}
