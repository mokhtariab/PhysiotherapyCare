using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace PhysiotherapyCare.Other.Forms
{
    public partial class SearchInternet_frm : Form
    {
        public SearchInternet_frm()
        {
            InitializeComponent();
        }


        public int SearchTypeEnter = 1;//1: Search  2: Map Search

        private void SearchInternet_frm_Load(object sender, EventArgs e)
        {
            //comboBox_SelEngine.SelectedIndex = 0;

           // buttonItem_ieSearch.Visible = (SearchTypeEnter == 1);
           // buttonItem_MapSearch.Visible = (SearchTypeEnter == 2);

           // if (SearchTypeEnter == 1)
          //  {
              //  panel_SelectEngine.Top = panel_Text.Top;
                //panel_Text.Top = panel_Part.Top;
          //  }

            //panel_SelectEngine.Visible = (SearchTypeEnter == 1);
          //  panel_Part.Visible = (SearchTypeEnter == 2);
            
        }

        private void SearchInternet_frm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) Close();
        }

        private void buttonItem_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonItem_ieSearch_Click(object sender, EventArgs e)
        {
            if (SetConnection())
                if (textBox_SearchText.Text!="") SearchInternetFunc(textBox_SearchText.Text, comboBox_SelEngine.SelectedIndex);
                else MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SWarning, false, " متن را وارد نمایید");
        }

        private void buttonItem_MapSearch_Click(object sender, EventArgs e)
        {
            if (SetConnection())
                if (textBox_SearchText.Text != "") SearchInternetFunc(textBox_SearchText.Text, 2);
                else MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SWarning, false, " متن را وارد نمایید");
        }


        private void SearchInternetFunc(string s_unicode, int SearchEngin)
        {
            try
            {
                System.Diagnostics.Process process = new System.Diagnostics.Process();

                process.StartInfo.UseShellExecute = true;
                process.StartInfo.FileName = "iexplore.exe";

                char[] myChars = new char[s_unicode.Length];
                for (int i = 0; i < s_unicode.Length; i++)
                    myChars[i] = Convert.ToChar(s_unicode[i]);

                Encoding u8 = Encoding.UTF8;
                byte[] bytes = u8.GetBytes(myChars);

                string s_unicode2 = PrintHexBytes(bytes);

                s_unicode2 = s_unicode2.Remove(s_unicode2.Length - 1);
                s_unicode2 = "%" + s_unicode2.Replace(" ", "%");

                if (SearchEngin == 0) process.StartInfo.Arguments = "http://www.google.com/search?hl=fa&q=" + s_unicode2;
                else if (SearchEngin == 1) process.StartInfo.Arguments = "http://search.yahoo.com/search?p=" + s_unicode2;
                else if (SearchEngin == 2) process.StartInfo.Arguments = "http://maps.google.com/maps?hl=en&tab=wl&q=" + s_unicode2;

                process.Start();
            }
            catch
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, " برنامه اینترنت اکسپلور نصب نمی باشد!");
            }
        }

        private string PrintHexBytes(byte[] bytes)
        {
            string s = "";
            if ((bytes == null) || (bytes.Length == 0))
                Console.WriteLine("<none>");
            else
            {
                for (int i = 0; i < bytes.Length; i++)
                    s += string.Format("{0:X2} ", bytes[i]);
            }
            return s;
        }


        #region Select Part
       // DataClasses_MainDataContext DCMD = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
        private int CntID, StID, CyID;
        private void comboBox_Country_Enter(object sender, EventArgs e)
        {
            //if (comboBox_Country.DataSource == null)
            //{
            //    var hh = from prd in DCMD.TBL_PrtCountries
            //             select prd;
            //    comboBox_Country.DataSource = hh;
            //}
        }

        private void comboBox_Country_Leave(object sender, EventArgs e)
        {
            CntID = Convert.ToInt32(comboBox_Country.SelectedValue);
        }

        private void comboBox_State_Enter(object sender, EventArgs e)
        {
            //if (!comboBox_State.Tag.Equals(CntID))
            //{
            //    comboBox_State.Tag = CntID;
            //    var hh = from prd in DCMD.TBL_PrtStates
            //             where prd.CountryID == CntID
            //             select prd;
            //    comboBox_State.DataSource = hh;
            //}
        }

        private void comboBox_State_Leave(object sender, EventArgs e)
        {
            StID = Convert.ToInt32(comboBox_State.SelectedValue);
        }

        private void comboBox_City_Enter(object sender, EventArgs e)
        {
            //if (!comboBox_City.Tag.Equals(StID))
            //{
            //    comboBox_City.Tag = StID;
            //    var hh = from prd in DCMD.TBL_PrtCities
            //             where prd.StateID == StID
            //             orderby prd.CityName_Fa
            //             select prd;
            //    comboBox_City.DataSource = hh;
            //}
        }

        private void comboBox_City_Leave(object sender, EventArgs e)
        {
            CyID = Convert.ToInt32(comboBox_City.SelectedValue);
        }

        private void comboBox_Part_Enter(object sender, EventArgs e)
        {
            //if (!comboBox_Part.Tag.Equals(CyID))
            //{
            //    comboBox_Part.Tag = CyID;
            //    var h1 = from prd in DCMD.TBL_PrtParts
            //             where prd.CityID == CyID
            //             orderby prd.PartName_Fa
            //             select prd;
            //    comboBox_Part.DataSource = h1;
            //}
        }
        #endregion

        private void comboBox_Part_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox_SearchText.Text = comboBox_Part.Text.Substring(comboBox_Part.Text.IndexOf("-") + 1, comboBox_Part.Text.Length - comboBox_Part.Text.IndexOf("-") - 1)
                                    + "," + comboBox_City.Text + "," + comboBox_State.Text + "," + comboBox_Country.Text;
        }


        static public bool SetConnection()
        {
            ConnectionState Description = 0;
            if (!InternetGetConnectedState(ref Description, 0))
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SWarning, false, "اتصال به اینترنت برقرار نمی باشد!");
                return false;
            }
            return true;
        }

        [DllImport("wininet.dll", CharSet = CharSet.Auto)]

        static extern bool InternetGetConnectedState(ref ConnectionState lpdwFlags, int dwReserved);

        [Flags]
        enum ConnectionState : int
        {
            INTERNET_CONNECTION_MODEM = 0x1,
            INTERNET_CONNECTION_LAN = 0x2,
            INTERNET_CONNECTION_PROXY = 0x4,
            INTERNET_RAS_INSTALLED = 0x10,
            INTERNET_CONNECTION_OFFLINE = 0x20,
            INTERNET_CONNECTION_CONFIGURED = 0x40
        }

    }
}
