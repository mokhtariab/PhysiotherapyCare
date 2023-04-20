using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MKH.Permission.ViewModel.Security
{
    public class MSSSqlConnection
    {
        public string ConnectionString()
        {
            //return new MKH.Permission.ViewModel.SetDefCon.SetDefCon().GetConnectionString(ConnectionName);
            return @"Data Source=" + GetServerName() + @"; Initial Catalog=PhysiotherapyCare;User ID=PhysiotherapyCare;Password=MkhPhysiotherapyCare;";
        }

        public string GetServerName()
        {
            string ServerName = ".";
            if (System.IO.File.Exists(System.Windows.Forms.Application.StartupPath + "\\LocalConfig.xml"))
            {
                try
                {
                    System.Xml.Linq.XDocument loaded = System.Xml.Linq.XDocument.Load("LocalConfig.xml");

                    var q = (from c in loaded.Descendants("setting")
                             select c).ToList();


                    ServerName = q.Find(j => j.FirstAttribute.Value == "ServerName").Value;

                }
                catch { }
            }
            return ServerName;
        }

    }
}
