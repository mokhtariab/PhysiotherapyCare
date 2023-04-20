using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Win32;
using System.Configuration;
using System.Management;
using System.IO;
using System.Xml.Linq;

namespace PhysiotherapyCare
{
    public partial class StartRC_frm : Form
    {
        
        public StartRC_frm()
        {
            InitializeComponent();
        }
        

        private string UserPer = "", UserName = "", UserPrmHF = "";
        private int UserCode=1;

        private void buttonX_OK_Click(object sender, EventArgs e)
        {
            TopMost = false;
            UserPer = ""; UserPrmHF = "";

            if (textBox_NUser.Text == "1" && textBox_Pass.Text == "")
            {
                MKH.Library.Clasess.PublicParam.UserLoginName = "کاربر ارشد";

                //MKH.Library.Clasess.PublicParam.ConnectionStringSet = ConStr();

                MKH.Library.Clasess.PublicParam.MainForm = new View.MainStart_Frm();
                MKH.Library.Clasess.PublicParam.MainForm.Show();
                this.Hide();
                return;
            }

            if (textBox_NUser.Text != "1")
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("نام کاربری اشتباه می باشد!",MKH.Library.Clasess.MSSMessage.MessageType.SError);
                textBox_NUser.Focus();
                return;
            }
            if (textBox_Pass.Text != "")
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("رمز ورود اشتباه می باشد!", MKH.Library.Clasess.MSSMessage.MessageType.SError);
                textBox_Pass.Focus();
                return;
            }

        }

        private void buttonX_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StartHM_frm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Escape))
                this.Close();
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                buttonX_OK_Click(this, null);
        }

        private void StartHM_frm_Load(object sender, EventArgs e)
        {
            Function_Cls.CheckKeyFile();
            
            ReadFromXmlFiles();
            SetLanguageProgram();

        }

        private void SetLanguageProgram()
        {
            InputLanguage lang = GetFarsiLanguage();
            if (lang == null)
                throw new NotSupportedException("Farsi Language keyboard is not installed.");
            InputLanguage.CurrentInputLanguage = lang;
        }

        private InputLanguage GetFarsiLanguage()
        {
            foreach (InputLanguage lang in InputLanguage.InstalledInputLanguages)
            {
                if ((lang.LayoutName.ToLower() == "farsi") | (lang.LayoutName == "Persian"))
                    return lang;
            }
            return null;
        }

        string ServerName = ".";
        private string ConStr()
        {
            return @"Data Source=" + ServerName + @"; Initial Catalog=PhysiotherapyCare;User ID=PhysiotherapyCare;Password=MkhPhysiotherapyCare;";
        }

        public void ReadFromXmlFiles()
        {
            if (File.Exists(Application.StartupPath + "\\LocalConfig.xml"))
            {
                try
                {
                    XDocument loaded = XDocument.Load("LocalConfig.xml");

                    var q = (from c in loaded.Descendants("setting")
                             select c).ToList();


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

                    ServerName = q.Find(j => j.FirstAttribute.Value == "ServerName").Value;
                    //Global_Cls.ConnectionDef = q.Find(j => j.FirstAttribute.Value == "ConnectionDef").Value;
                    //Global_Cls.ServerNameForLock = q.Find(j => j.FirstAttribute.Value == "ServerNameForLock").Value;
                    //Global_Cls.ColorDisplay = Convert.ToByte(q.Find(j => j.FirstAttribute.Value == "ColorDisplay").Value);
                    //Global_Cls.CONameStr = q.Find(j => j.FirstAttribute.Value == "CONameStr").Value.ToString();

                }
                catch { }
            }
        }

    }
}
