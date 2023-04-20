using MKH.Permission.View.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MKH.Permission
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //args = new string[2];
            //args[0] =  492621.ToString();
            //args[1] = 12.ToString();

            //if (args.Count() > 0)
            //{
            //    MKH.Permission.View.Security.MSSLogin_cls LoginClass = new MKH.Permission.View.Security.MSSLogin_cls();
            //    try
            //    {
            //        LoginClass.GetPermissionManagment(22, args[0], args[1],
            //            new Permission.View.MainStart_Frm());
            //    }
            //    catch (Exception ex)
            //    {
            //        MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "خطا", "خطای " + ex.Message);
            //    }
            //}

            ////Application.Run(new Permission.View.MainStart_Frm());


            if (!MKH.Library.Clasess.PublicClass.IsAnyInstanceExist("MKH.Permission"))
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("برنامه در حال اجرا می باشد", MKH.Library.Clasess.MSSMessage.MessageType.SError);
            else
            {
                string ArgsSet = args[0];
                //string ArgsSet = "";
                //ArgsSet = 492621.ToString() + "--" + 12.ToString();
                string _userLogin = ArgsSet.Substring(0, ArgsSet.IndexOf("--"));
                string _userPass = ArgsSet.Substring(ArgsSet.IndexOf("--") + 2, ArgsSet.Length - ArgsSet.IndexOf("--") - 2);


                if (args.Count() > 0)
                {

                    MKH.Permission.View.Security.MSSLogin_cls LoginClass = new MKH.Permission.View.Security.MSSLogin_cls();
                    try
                    {
                        LoginClass.GetPermissionManagment(22, _userLogin, _userPass,
                            new Permission.View.MainStart_Frm());
                    }
                    catch (Exception ex)
                    {
                        MKH.Library.Clasess.MSSMessage.MSSMessage_View("خطای " + ex.Message, MKH.Library.Clasess.MSSMessage.MessageType.SError);
                    }

                }

                ////Application.Run(new Permission.View.MainStart_Frm());
            }

        }
    }
}
