using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Collections.Specialized;
using MKH.Library.Clasess.Security;


namespace MKH.Permission.View.Security
{
    public class MSSLogin_cls : IDisposable
    {
        public void Dispose()
        {
        }

        public void GetPermissionManagment(int SoftwareId, Form mainForm)
        {
            if (!MKH.Permission.View.Security.CheckKey_Cls.CheckKeyFile())
                return;

            bool showLogin = false;
            ViewModel.Security.MSSPolicySystem_cls passPlcy = new ViewModel.Security.MSSPolicySystem_cls();

            View.Forms.Start_frm login = new View.Forms.Start_frm(passPlcy, SoftwareId);
            if (login.ShowDialog() == DialogResult.OK)
            {
                showLogin = true;
            }
            else
                showLogin = false;


            if (showLogin == true)
            {
                Application.Run(mainForm);
            }
        }

        public void GetPermissionManagment(int SoftwareId, string UserLogin, string Password, Form mainForm)
        {
            if (!MKH.Permission.View.Security.CheckKey_Cls.CheckKeyFile())
                return;

            ViewModel.Security.MSSPolicySystem_cls passPlcy = new ViewModel.Security.MSSPolicySystem_cls();

            bool UserOrPass = true;
            string messageError = passPlcy.CheckAuthentication(UserLogin, Password, SoftwareId, ref UserOrPass);

            if (String.IsNullOrEmpty(messageError))
            {
                //if (passPlcy.GetAccessibleResourceIds(UserLogin))
                //{
                Application.Run(mainForm);
                //}
                //else
                //{
                //    MKH.Library.Clasess.MSSMessage.MSSMessage_View("امکان دسترسی به این نرم افزار برای شما وجود ندارد", MKH.Library.Clasess.MSSMessage.MessageType.SError);
                //}
            }
            else
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View(messageError, MKH.Library.Clasess.MSSMessage.MessageType.SError);
            }
        }
    }
}
