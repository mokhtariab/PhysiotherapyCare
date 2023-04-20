using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Collections.Specialized;
using System.Management;
using MKH.Library.Forms;


namespace MKH.Library.Clasess
{
    public class MSSMessage
    {
        public enum MessageType { SError, SWarning, SConfirmation, SInformation };

        static public bool MSSMessage_View(string Str_Msg, MessageType TypeMsg)
        {
            return MSSMessage_View(0, TypeMsg, false, Str_Msg, "");
        }

        static public bool MSSMessage_View(int Code_Msg, MessageType TypeMsg, bool OK_Cancel, string Str_Msg)
        {
            return MSSMessage_View(Code_Msg, TypeMsg, OK_Cancel, Str_Msg, "");
        }

        static public bool MSSMessage_View(int Code_Msg, MessageType TypeMsg, bool OK_Cancel, string Str_Msg, string Str_Error)
        {
            MSSMessage_frm MSF = new MSSMessage_frm();

            MSF.label_MsgS.Text = Str_Msg;
            MSF.pictureBox_Error.Visible = (TypeMsg == MessageType.SError); MSF.pictureBox_Error.Top = 20;
            MSF.pictureBox_Warning.Visible = (TypeMsg == MessageType.SWarning); MSF.pictureBox_Warning.Top = 20;
            MSF.pictureBox_Configuration.Visible = (TypeMsg == MessageType.SConfirmation); MSF.pictureBox_Configuration.Top = 20;
            MSF.pictureBox_Information.Visible = (TypeMsg == MessageType.SInformation); MSF.pictureBox_Information.Top = 20;
            MSF.button_Cancel.Visible = OK_Cancel;

            if (Str_Error != "")
            {
                MSF.button_Details.Visible = true;
                MSF.label_Detail.Text = Str_Error;
            }

            if (!OK_Cancel) MSF.button_OK.Left = 133;
            MSF.ShowDialog();
           // MPG_WinShutDowm.ShowShutForm sf = new MPG_WinShutDowm.ShowShutForm(MSF);

            if (MSF.DialogResult == System.Windows.Forms.DialogResult.OK) return true;
            return false;
        }

    }
}
