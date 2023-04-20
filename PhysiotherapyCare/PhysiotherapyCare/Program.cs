using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PhysiotherapyCare
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

            if (!MKH.Library.Clasess.PublicClass.IsAnyInstanceExist("PhysiotherapyCare"))
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("برنامه در حال اجرا می باشد", MKH.Library.Clasess.MSSMessage.MessageType.SError);
            else
            {

                //Application.EnableVisualStyles();
                //Application.SetCompatibleTextRenderingDefault(false);

                MKH.Permission.View.Security.MSSLogin_cls LoginClass = new MKH.Permission.View.Security.MSSLogin_cls();
                try
                {
                    LoginClass.GetPermissionManagment(0, new PhysiotherapyCare.View.MainStart_Frm());
                }
                catch (Exception ex)
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "خطا", "خطای " + ex.Message);
                }
               
            }
            
        }
    }
}
