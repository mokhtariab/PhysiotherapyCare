using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Net;
using RestSharp;
using Newtonsoft.Json; 

namespace MKH.SMS.View.Class
{
    public class SMS_Cls
    {
        class SendResult
        {
            public String result { get; set; }
            public String messageids { get; set; }
        }

        public static int GetMessageStatusSMS(string username, string password, long MessageIDs)
        {
            long[] MessageIDs1 = { MessageIDs };
            int[] MessageIDs2;
            string MessageIDsStr = MessageIDs.ToString();
            SMSService.v2 ws = new SMSService.v2();
            MessageIDs2 = ws.GetMessageStatus(username, password, MessageIDs1);
            //MessageBox.Show(Convert.ToString(MessageIDs2[0]));
            return MessageIDs2[0];

            //var client = new RestClient(" https://ghasedakapi.com/v1/account/status ");
            //var request = new RestRequest(Method.GET);
            //request.AddHeader("apikey", "fVaI1m2At+EmWaEhgjitIwhKWfu6P2bMhYHMw8sjuNc");
            //request.AddParameter("messageid", MessageIDsStr);
            //IRestResponse response = client.Execute(request);


            //if (response.StatusCode == System.Net.HttpStatusCode.OK)
            //{
            //    SendResult result = JsonConvert.DeserializeObject<SendResult>(response.Content);
            //    if (result.result == "success")
            //        return Convert.ToInt32(result.messageids);
            //    else
            //        return 0;
            //}
            //else
            //{
            //    return Convert.ToInt32(response.StatusCode);
            //}


        }
        
        public static double GetCreditSMS(string UserName, string Password)
        {
            double resCredit = 0;
            SMSService.v2 ws = new SMSService.v2();
            resCredit = ws.GetCredit(UserName, Password);
            
            //MessageBox.Show("Credit : " + resCredit + "");
            return resCredit;
        }



        public class ListReciveSMS
        {
            public long MessageID { get; set; }
            public string SenderNumber { get; set; }
            public string RecipientNumber { get; set; }
            public string ReceiveDate { get; set; }
            public string Body { get; set; }
        }

        public static List<ListReciveSMS> RecivedSMS(string username, string password, string destNumber, bool ReadChecked)
        {
            List<ListReciveSMS> MsgStr = new List<ListReciveSMS>();
            //MsgStr = null;
            int isRead = 0;
            if (ReadChecked == true)
            {
                isRead = 1;
            }

            SMSService.v2 ws = new SMSService.v2();

            SMSService.Messages[] Messages = null;

            Messages = ws.GetReceiveMessages(username, password, destNumber, isRead);
          
            if (Messages != null)
            {
                int count = 0;
                count = Messages.Length;

                ListReciveSMS A = null;
                if (count != 0)
                {
                    int i = 0;
                    for (i = 0; i <= count - 1; i++)
                    {
                        A = new ListReciveSMS();
                        A.Body = Messages[i].Body;
                        A.SenderNumber = Messages[i].SenderNumber;
                        A.RecipientNumber = Messages[i].RecipientNumber;
                        A.ReceiveDate = Messages[i].ReceiveDate;
                        A.MessageID = Messages[i].MessageID;

                        MsgStr.Add(A);
                    }
                }
            }
            else
            {
            }
            return MsgStr;
        }

        static DateTime EPOCH = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);

        public static double ConvertDatetimeToUnixTimeStamp(DateTime date, int Time_Zone = 0)
        {
            TimeSpan The_Date = (date - EPOCH);
            return Math.Floor(The_Date.TotalSeconds) - (Time_Zone * 3600);
        }
        
        public static long SendSMS(string UserName, string Password, string SenderMobile, string ReciverMobile, string MessageStr)
        {
            DateTime date;
            date = DateTime.Now;
            //date = DateTime.Now.AddMinutes(5);
            string[] senddate = { Convert.ToString(ConvertDatetimeToUnixTimeStamp(date)) };
            
            string[] senderNumbers =  {SenderMobile };
            string[] recipientNumbers =  {ReciverMobile };
            string[] messageBodies =  {MessageStr} ;
            
            int[] messageClasses = { };
            long[] MessageIDs = { };
            SMSService.v2 ws = new SMSService.v2();
            MessageIDs = ws.SendSMS(UserName, Password, senderNumbers, recipientNumbers, messageBodies, null, null, null);
            //MessageBox.Show("MessageID : " + MessageIDs[0] + "");

            return MessageIDs[0];


            //var client = new RestClient("http://api.smsapp.ir/v2/sms/send/simple");
            //var request = new RestRequest(Method.POST);
            //request.AddHeader("apikey", "fVaI1m2At+EmWaEhgjitIwhKWfu6P2bMhYHMw8sjuNc");
            //request.AddParameter("senddate", senddate);
            //request.AddParameter("receptor", recipientNumbers);
            //request.AddParameter("message", messageBodies);
            //request.AddParameter("checkmessageids", "");
            //request.AddParameter("sender", senderNumbers);
            //request.AddParameter("output", "xml/Json");
            //IRestResponse response = client.Execute(request);
            //if (response.StatusCode == System.Net.HttpStatusCode.OK)
            //{
            //    SendResult result = JsonConvert.DeserializeObject<SendResult>(response.Content);
            //    if (result.result == "success")
            //        return Convert.ToInt64(result.messageids);
            //    else
            //        return -1;
            //}
            //else
            //{
            //    return Convert.ToInt64( response.StatusCode);
            //}
            
        }

        
    }
}
