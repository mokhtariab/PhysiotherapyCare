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
using MKH.Permission.ViewModel.Security;


namespace MKH.Permission.View.Security
{

    public class MSSChangePassword_Cls
    {
        public static bool CheckPass(string UserName, string PrePass, string NewPass, string ReNewPass)
        {
            if (PrePass == "")
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("رمز عبور فعلی خالی می باشد", MKH.Library.Clasess.MSSMessage.MessageType.SError);
                return false;
            }
            
            if (NewPass == "")
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("رمز عبور جدید خالی می باشد", MKH.Library.Clasess.MSSMessage.MessageType.SError);
                return false;
            }
            
            if (ReNewPass == "")
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("رمز عبور جدید تکرار خالی می باشد", MKH.Library.Clasess.MSSMessage.MessageType.SError);
                return false;
            }

            if (!MainClass_cls.CheckUserPass(UserName, PrePass))
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("رمز عبور فعلی اشتباه می باشد", MKH.Library.Clasess.MSSMessage.MessageType.SError);
                return false;
            }

            if (NewPass != ReNewPass)
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("رمز عبور تکرار اشتباه می باشد", MKH.Library.Clasess.MSSMessage.MessageType.SError);
                return false;
            }

            try
            {
                MainClass_cls.ApplyPass(UserName, NewPass);
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("تغییرات اعمال شد", MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation);
            }
            catch (Exception ex)
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "اشکال", ex.Message);
                return false;
            }

            return true;
        }


    }
}



