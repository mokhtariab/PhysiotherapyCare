using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace MKH.SMS.View.Class
{
    public class SMSClass
    {


        public static long SendSMS(string InternetUserName, string InternetPassword, string InternetTelNumber, string PhoneNumber, string MessageStr, ref bool SendSMSOK)
        {
            long smsId = -1;
            SendSMSOK = false;
            try
            {
                smsId = SMS_Cls.SendSMS(    InternetUserName,
                                            InternetPassword,
                                            InternetTelNumber,
                                            PhoneNumber, 
                                            MessageStr
                                            );
                SendSMSOK = true;
            }
            catch (Exception ex)
            {
                SendSMSOK = true;
                return -1;
            }
            return smsId;
        }


        public static string GetMessageStatusSendSMS(string InternetUserName, string InternetPassword, long MessageIDs, ref bool SendSMSOK)
        {
            SendSMSOK = false;
            try
            {
                int Code = SMS_Cls.GetMessageStatusSMS(InternetUserName,
                                                   InternetPassword,
                                                   MessageIDs);

                SendSMSOK = true;

                if (Code == 0) return "در صف ارسال";
                if (Code == 1) return "رسیده به گوشی";
                if (Code == 2) return "عدم رسیدن گوشی";
                if (Code == 8) return "رسیده به مخابرات";
                if (Code == 16) return "عدم رسیدن به مخابرات";
                if (Code == 27) return "شماره در لیست سیاه";
                if (Code == -1) return "شناسه ارسالی اشتباه";
            }
            catch
            {

            }
            return "خطا در ارسال";
        }


        //public static int InsertToSMSList(string MobileNo, string SMSText)
        //{
            
        //    List<Model.SendSMS.TBL_SendSM> Ls = new List<Model.SendSMS.TBL_SendSM>(1);
        //        Model.SendSMS.TBL_SendSM SendSMS = new Model.SendSMS.TBL_SendSM();

        //        SendSMS.MessageText = SMSText;
        //        SendSMS.MobileNo = MobileNo;
        //        SendSMS. = TextBoxParentName.Text;
        //        PersonTelMob.IDNO = TextBoxIDNO.Text;
        //        PersonTelMob.NationalCode = TextBoxNationalCode.Text;
        //        PersonTelMob.BrithDate = DatePickerBrithDate.Value.ToString().Substring(0, 10);
        //        PersonTelMob.BrithCityName = TextBoxBrithCityName.Text;
        //        PersonTelMob.TelHome = TextBoxTelHome.Text;
        //        PersonTelMob.TelBusiness = TextBoxTelBusiness.Text;
        //        PersonTelMob.Mobile = TextBoxMobile.Text;
        //        PersonTelMob.Mobile2 = TextBoxMobile2.Text;
        //        PersonTelMob.Email = TextBoxEmail.Text;
        //        PersonTelMob.Address = TextBoxAddress.Text;
        //        PersonTelMob.AddressBusiness = TextBoxAddressBusiness.Text;
        //        PersonTelMob.Description = TextBoxDescription.Text;
        //        PersonTelMob.Active = checkBoxActive.Checked;
        //        Ls.Add(PersonTelMob);
            
        //    new ViewModel.SendSMS.SendSMS().InsertEntity()
        //    TBL_SendSMS th = new TBL_SendSMS();
        //    th.Mobile_No = MobileNo;
        //    th.MessageText = SMSText; //+ " 'R.C.M' ";
        //    th.Status = 0;
        //    th.SMS_Few = 1;
        //    th.Archive = false;
        //    th.SendDate = Global_Cls.MiladiDateToShamsi(DateTime.Now);
        //    th.SendTime = DateTime.Now.TimeOfDay.Hours.ToString() + ":" + DateTime.Now.TimeOfDay.Minutes.ToString("00") + ":" + DateTime.Now.TimeOfDay.Seconds.ToString("00");
        //    th.UserCode = Global_Cls.UserCode_Exist;
        //    th.UseName = Global_Cls.UserName_Exist;
        //    th.Description = "";
        //    DCDC.TBL_SendSMS.InsertOnSubmit(th);
        //    DCDC.SubmitChanges();

        //    int jj = int.Parse((from fg in DCDC.TBL_SendSMS select fg.SMSCode).Max().ToString());
        //    return jj;
        //}

        //public static void SendList(int SMSCode)
        //{
        //    ConnectToPort();
        //    DataClasses_MainDataContext df = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
        //    string ResultStrSMS = "";

        //    var ggg = from gh in df.TBL_SendSMS
        //              where gh.Status == 0
        //              select gh;
        //    if (SMSCode != 0)
        //        ggg = ggg.Where(jh => jh.SMSCode == SMSCode);

        //    foreach (var ft in ggg)
        //    {
        //        try
        //        {
        //            ResultStrSMS = SendSMS(ft.Mobile_No, ft.MessageText);

        //            TBL_SendSMS hy = df.TBL_SendSMS.First(kk => kk.SMSCode == ft.SMSCode);
        //            hy.Description = "ارسال شد";
        //            hy.SendDate = Global_Cls.MiladiDateToShamsi(DateTime.Now);
        //            hy.SendTime = DateTime.Now.Hour.ToString("00") + ":" + DateTime.Now.Minute.ToString("00") + ":" + DateTime.Now.Second.ToString("00");
        //            hy.Status = 1;
        //            df.SubmitChanges();
        //        }
        //        catch (Exception ex)
        //        {
        //            string str = "";
        //            if (ex.Message.Contains("COM")) str = "پورت شناسایی نشد";
        //            if (ex.Message.Contains("Message service error 144")) str = "شماره موبایل اشتباه است!";
        //            if (ex.Message.Contains("Message service error 322")) str = "حافظه پر است!";

        //            TBL_SendSMS hy = df.TBL_SendSMS.First(kk => kk.SMSCode == ft.SMSCode);
        //            hy.Description = str;
        //            hy.Status = 2;
        //            df.SubmitChanges();
        //        }
        //    }
        //    DisconnectPort();
        //}



        public static double GetCreditSMS(string UserName, string Password)
        {
            double resCredit = 0;
            resCredit = SMS_Cls.GetCreditSMS(UserName, Password);
            return resCredit;
        }


        //public static string MessageDelete(int Index)
        //{
        //    try
        //    {
        //        objSMS.Inbox().Message(Index).Delete();
        //        return "";
        //    }
        //    catch (mCore.SMSReadException ex)
        //    {
        //        return ex.Message;
        //    }
        //    catch (mCore.GeneralException ex)
        //    {
        //        return ex.Message;
        //    }
        //    catch (Exception ex)
        //    {
        //        return ex.Message;
        //    }
        //}







        //public static string ReciveSMS(ref DataTable DT, int RSType)
        //{
        //    string Result = "";
            
        //    ConnectToPort();

        //// new 950308
        //    if (Global_Cls.SMSSet)
        //    {
        //        int i = 0;
        //        List<SMS_Cls.ListReciveSMS> LLRS = SMS_Cls.RecivedSMS(Global_Cls.IntUserName, Global_Cls.IntPassword, Global_Cls.IntTelNumber, true);
        //        try
        //        {
                    
        //            string PhoneName = "";
        //            //MsgCount = LLRS.Count();
        //            foreach (SMS_Cls.ListReciveSMS Msg in LLRS)
        //            {
        //                DataRow DR = DT.NewRow();
        //                DR["Checked"] = false;
        //                DR["Mobile"] = Msg.SenderNumber;
        //                DR["Message"] = Msg.Body;
        //                DR["DateReciveMiladi"] = Msg.ReceiveDate;
        //                DR["DateRecive"] = Msg.ReceiveDate;//Global_Cls.MiladiDateToShamsiWithTime(Msg.ReceiveDate);
        //                DR["TimeStampRFC"] = Msg.ReceiveDate;//Msg.TimeStampRFC;
        //                DR["Index"] = i;//Msg.Index;
        //                DR["ConfirmOK"] = 0;
        //                DT.Rows.Add(DR);
        //                i++;
        //            }
        //            return "";
        //        }
        //        catch { }


        //        Result = "مجموع پیامک ها: " + i;
        //        if (i > 0)
        //            Result = Result + "\r\n( جهت مشاهده پیامک ها بر روی سطر مورد نظر دو بار کلیک نمایید )";

        //    }
        //    else
        //    {
        //        // new 950308

        //        mCore.Inbox objInbox = objSMS.Inbox();



        //        switch (RSType)
        //        {
        //            case 0:
        //                {
        //                    objSMS.MessageMemory = mCore.MessageMemory.SM;
        //                    break;
        //                }
        //            case 1:
        //                {
        //                    objSMS.MessageMemory = mCore.MessageMemory.ME;
        //                    break;
        //                }
        //            case 2:
        //                {
        //                    objSMS.MessageMemory = mCore.MessageMemory.MT;
        //                    break;
        //                }
        //        }

        //        System.Windows.Forms.Application.DoEvents();

        //        try
        //        {
        //            objInbox.Refresh();
        //        }
        //        catch (mCore.SMSReadException ex)
        //        {
        //            Result = ex.Message;
        //        }
        //        catch (mCore.GeneralException ex)
        //        {
        //            Result = ex.Message;
        //        }
        //        catch (Exception ex)
        //        {
        //            Result = ex.Message;
        //        }

        //        if (Result != "")
        //        {
        //            DisconnectPort();
        //            return Result;
        //        }

        //        try
        //        {
        //            foreach (mCore.Message Msg in objInbox)
        //            {
        //                DataRow DR = DT.NewRow();
        //                DR["Checked"] = false;
        //                DR["Mobile"] = System.Text.ASCIIEncoding.UTF8.GetString(System.Text.ASCIIEncoding.UTF8.GetBytes(Msg.Phone));
        //                DR["Message"] = System.Text.ASCIIEncoding.UTF8.GetString(System.Text.ASCIIEncoding.UTF8.GetBytes(Msg.Text));
        //                DR["DateReciveMiladi"] = Msg.TimeStamp;
        //                DR["DateRecive"] = Global_Cls.MiladiDateToShamsiWithTime(Msg.TimeStamp);
        //                DR["TimeStampRFC"] = Msg.TimeStampRFC;
        //                DR["Index"] = Msg.Index;
        //                DR["ConfirmOK"] = 0;
        //                DT.Rows.Add(DR);
        //            }

        //            Result = "مجموع پیامک ها: " + objInbox.Count;
        //            if (objInbox.Count > 0)
        //                Result = Result + "\r\n( جهت مشاهده پیامک ها بر روی سطر مورد نظر دو بار کلیک نمایید )";
        //        }
        //        catch (mCore.SMSReadException ex)
        //        {
        //            Result = ex.Message;
        //        }
        //        catch (mCore.GeneralException ex)
        //        {
        //            Result = ex.Message;
        //        }
        //        catch (Exception ex)
        //        {
        //            Result = ex.Message;
        //        }
        //    }
        //    DisconnectPort();
        //    return Result;
        //}


        //public static GsmCommMain comm;
        public static string ReadSMS(ref DataTable DT)
        {

            string Result = "", str = "";

            int m = 0;
            List<SMS_Cls.ListReciveSMS> LLRS = SMS_Cls.RecivedSMS(
                            new ViewModel.SettingSMS.SettingSMS().GetAllValue("InternetUserName", ref str),
                            MKH.Library.Clasess.Security.MSSFunction_Cls.DecriptionText( new ViewModel.SettingSMS.SettingSMS().GetAllValue("InternetPassword", ref str),Library.Clasess.Security.MSSFunction_Cls.EncDecryption.PrivateEncDec),
                            new ViewModel.SettingSMS.SettingSMS().GetAllValue("InternetTelNumber", ref str), false);
            try
            {
                System.DateTime dateT = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
                foreach (SMS_Cls.ListReciveSMS Msg in LLRS)
                {
                    DataRow DR = DT.NewRow();
                    DR["Checked"] = false;
                    DR["Mobile"] = Msg.SenderNumber;
                    DR["Message"] = Msg.Body;
                    DR["DateReciveMiladi"] = dateT.AddSeconds(double.Parse(Msg.ReceiveDate));
                    //UnixTimeStampToDateTime(double.Parse(Msg.ReceiveDate))
                    DR["DateRecive"] = MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(dateT.AddSeconds(double.Parse(Msg.ReceiveDate)));
                    DR["TimeStampRFC"] = Msg.ReceiveDate;//Msg.TimeStampRFC;
                    DR["Index"] = m;//Msg.Index;
                    DR["ConfirmOK"] = 0;
                    DR["RecipientNumber"] = Msg.RecipientNumber;
                    DR["MessageID"] = Msg.MessageID;
                    DT.Rows.Add(DR);
                    m++;
                }
            }
            catch { }


            Result = "مجموع پیامک ها: " + m;
            if (m > 0)
                Result = Result + "\r\n( جهت مشاهده پیامک ها بر روی سطر مورد نظر دو بار کلیک نمایید )";

            return Result;
        }

        //private static void FillDataTable(SmsPdu pdu, ref DataTable DT, int index)
        //{
        //    if (pdu is SmsSubmitPdu)
        //    {
        //        // Stored (sent/unsent) message
        //        SmsSubmitPdu data = (SmsSubmitPdu)pdu;

        //        DataRow DR = DT.NewRow(); 
        //        DR["Checked"] = false;
        //        DR["Mobile"] = data.DestinationAddress;
        //        DR["Message"] = data.UserDataText;
        //        DR["DateReciveMiladi"] = DateTime.Parse(("20" + data.GetTimestamp().Year + "-" + data.GetTimestamp().Month.ToString("00") + "-" + data.GetTimestamp().Day.ToString("00") + " " + data.GetTimestamp().Hour + ":" + data.GetTimestamp().Minute).ToString());
        //        DR["DateRecive"] = Global_Cls.MiladiDateToShamsiWithTime(DateTime.Parse(("20" + data.GetTimestamp().Year + "-" + data.GetTimestamp().Month.ToString("00") + "-" + data.GetTimestamp().Day.ToString("00") + " " + data.GetTimestamp().Hour + ":" + data.GetTimestamp().Minute).ToString()));
        //        DR["TimeStampRFC"] = data.GetTimestamp();
        //        DR["Index"] = index;
        //        DR["ConfirmOK"] = 0;

        //        DT.Rows.Add(DR);
        //        return;
        //    }
        //    if (pdu is SmsDeliverPdu)
        //    {
        //        // Received message
        //        SmsDeliverPdu data = (SmsDeliverPdu)pdu;
        //        DataRow DR = DT.NewRow(); 
        //        DR["Checked"] = false;
        //        DR["Mobile"] = data.OriginatingAddress;
        //        DR["Message"] = data.UserDataText;
        //        DR["DateReciveMiladi"] = DateTime.Parse(("20" + data.SCTimestamp.Year + "-" + data.SCTimestamp.Month.ToString("00") + "-" + data.SCTimestamp.Day.ToString("00") + " " + data.SCTimestamp.Hour + ":" + data.SCTimestamp.Minute).ToString());
        //        DR["DateRecive"] = Global_Cls.MiladiDateToShamsiWithTime(DateTime.Parse(("20" + data.SCTimestamp.Year + "-" + data.SCTimestamp.Month.ToString("00") + "-" + data.SCTimestamp.Day.ToString("00") + " " + data.SCTimestamp.Hour + ":" + data.SCTimestamp.Minute).ToString()));
        //        DR["TimeStampRFC"] = data.SCTimestamp;
        //        DR["Index"] = index;
        //        DR["ConfirmOK"] = 0;
                
        //        DT.Rows.Add(DR);
        //        return;
        //    }
        //    if (pdu is SmsStatusReportPdu)
        //    {
        //        // Status report
        //        SmsStatusReportPdu data = (SmsStatusReportPdu)pdu;
                
        //        DataRow DR = DT.NewRow();
        //        DR["Checked"] = false;
        //        DR["Mobile"] = data.RecipientAddress;
        //        DR["Message"] = data.UserDataText;
        //        DR["DateReciveMiladi"] = DateTime.Parse(("20" + data.SCTimestamp.Year + "-" + data.SCTimestamp.Month.ToString("00") + "-" + data.SCTimestamp.Day.ToString("00") + " " + data.SCTimestamp.Hour + ":" + data.SCTimestamp.Minute).ToString());
        //        DR["DateRecive"] = Global_Cls.MiladiDateToShamsiWithTime(DateTime.Parse(("20" + data.SCTimestamp.Year + "-" + data.SCTimestamp.Month.ToString("00") + "-" + data.SCTimestamp.Day.ToString("00") + " " + data.SCTimestamp.Hour + ":" + data.SCTimestamp.Minute).ToString()));
        //        DR["TimeStampRFC"] = data.SCTimestamp;
        //        DR["Index"] = index;
        //        DR["ConfirmOK"] = 0;

        //        DT.Rows.Add(DR);
        //        return;
        //    }
        //    //Output("Unknown message type: " + pdu.GetType().ToString());

        //}

        //public static string DeleteSMS(int index, int SimPhone)
        //{
        //    string Result = "";

        //    // new 950308
        //    if (Global_Cls.SMSSet)
        //    {
        //    }
        //    else
        //    {
        //        string storage = "";
        //        if (SimPhone == 0) storage = PhoneStorageType.Sim;
        //        else storage = PhoneStorageType.Phone;

        //        comm = new GsmCommMain(
        //            Convert.ToInt16(Global_Cls.SMSPort.Replace("COM", "")),
        //            Convert.ToInt32(Global_Cls.SMSBaudRate),
        //            400);

        //        try
        //        {
        //            comm.Open();
        //            comm.DeleteMessage(index, storage);
        //        }
        //        catch (Exception ex)
        //        {
        //            Result = ex.Message;
        //        }
        //        comm.Close();
        //    }
        //    return Result;
        //}

        //public static DateTime UnixTimeStampToDateTime(double unixTimeStamp)
        //{
        //    // Unix timestamp is seconds past epoch
        //    System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
        //    dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime();
        //    return dtDateTime;
        //}
    }
}
