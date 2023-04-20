using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
using System.Xml.Linq;
using System.Collections.Specialized;
using System.Threading;
using System.Management;

namespace MKH.Permission.View.Security
{

    public class MSSGetChangePass_Cls
    {
        public void GetChangePassword()
        {
            MKH.Permission.View.Forms.ChangePass_frm ChangePass = new View.Forms.ChangePass_frm();
            ChangePass.ShowDialog();
        }

    }
}



