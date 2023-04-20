using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.ComponentModel;
using System.Diagnostics;
using MKH.Permission.Model;
using MKH.Permission.Model.Users;
using MKH.Library.Clasess.Security;


namespace MKH.Permission.ViewModel.Security
{
    public class MainClass_cls
    {
        DataClassesUsersDataContext DVV = new DataClassesUsersDataContext(Security.MSSConfiguration_cls.Instance.InternalConnectionString);
        public string UserPasswordIsOkay(string userLogin, string password, ref bool UserOrPass)
        {
            string ret = "";
          
            try
            {
                TBL_User CheckUser =
                DVV.TBL_Users.First(gk => gk.UserName == userLogin);

                if (CheckUser.IsActive == false)
                {
                    ret = "اين كاربر غير فعال ميباشد...";
                    UserOrPass = true;
                }
                else
                    if (CheckUser.UserPassword != MSSFunction_Cls.EncriptionText(password, MSSFunction_Cls.EncDecryption.PublicEncDec))
                    {
                        ret = "رمزعبور اشتباه است...";
                        UserOrPass = false;
                    }
            }
            catch (Exception ex)
            {
                ret = "چنين كاربري تعريف نشده است... /n"+ ex.Message;
                UserOrPass = true;
            }

            return ret;
        }

        public bool GetAccessibleResourceIds(string userLogin, int SoftwareId)
        {
            try
            {
                
                //TBL_SoftwareUser gh =
                //DVV.TBL_SoftwareUsers.First(gk => gk.User_Id ==
                //    DVV.TBL_Users.First(gl => gl.UserName == userLogin).UserId
                //    && gk.Software_Id == SoftwareId);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool CheckUserPass(string UserName, string PrePass)
        {
            DataClassesUsersDataContext DVV = new DataClassesUsersDataContext(ViewModel.Security.MSSConfiguration_cls.Instance.InternalConnectionString);
            try
            {
                TBL_User gh =
                DVV.TBL_Users.First(gk => gk.UserName == UserName &&
                            gk.UserPassword == MSSFunction_Cls.EncriptionText(PrePass,MSSFunction_Cls.EncDecryption.PrivateEncDec));
                return true;
            }
            catch
            {
                try
                {
                    TBL_User gh =
                    DVV.TBL_Users.First(gk => gk.UserName == UserName && gk.UserPassword == PrePass);
                    return true;
                }
                catch
                {
                    return false;
                }
                return false;
            }
        }


        public static void ApplyPass(string UserName, string NewPass)
        {
            DataClassesUsersDataContext DVV = new DataClassesUsersDataContext(ViewModel.Security.MSSConfiguration_cls.Instance.InternalConnectionString);

            TBL_User gh = DVV.TBL_Users.First(gk => gk.UserName == UserName);
            gh.UserPassword = MSSFunction_Cls.EncriptionText(NewPass, MSSFunction_Cls.EncDecryption.PrivateEncDec);
            DVV.SubmitChanges();
        }
    }
}
