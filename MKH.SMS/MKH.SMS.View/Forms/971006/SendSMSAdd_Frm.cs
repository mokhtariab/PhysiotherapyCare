using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using MKH.SMS.ViewModel.SendSMS;
using MKH.SMS.Model.SendSMS;
using MKH.Library.Clasess.Filing;
using System.Threading;


namespace MKH.SMS.View.Forms
{
    public partial class SendSMSAdd_Frm : MKH.Library.Forms.MSSBaseNew_frm
    {

        public SendSMSAdd_Frm()
        {
            InitializeComponent();
        }


        public SendSMSAdd_Frm(List<MKH.Library.Clasess.PublicClass.AllPersonForSMS> ListForSelectPerson, string MsgSet = "")
        {
            InitializeComponent();

            for (int i = 0; i < ListForSelectPerson.Count; i++)
            {
                try
                {
                    //GridexViewSetForSMS.AddItem(ListForSelectPerson[i].PersonNameFamily);
                    //GridexViewSetForSMS.CurrentRow.Cells[1].Value = ListForSelectPerson[i].JobType;
                    //GridexViewSetForSMS.CurrentRow.Cells[2].Value = ListForSelectPerson[i].MobileNo1;

                    Janus.Windows.GridEX.GridEXRow g = GridexViewSetForSMS.AddItem();
                    g.BeginEdit();
                    g.Cells[0].Value = ListForSelectPerson[i].PersonNameFamily;
                    g.Cells[1].Value = ListForSelectPerson[i].JobType;
                    g.Cells[2].Value = ListForSelectPerson[i].MobileNo1;
                    g.EndEdit();


                }
                catch
                {
                }
            }
            TextBoxMessage.Text = MsgSet;
        }

        private void SendSMSAdd_Frm_Load(object sender, EventArgs e)
        {
            GridexViewPerson.DataSource = MKH.Library.Clasess.PublicClass.ListAllPersonForSMS.ToList();
        }
       
        
        string str = "";
        string InternetUserName = "";
        string InternetPassword = "";
        string InternetTelNumber = "";
        bool SendOk = false;
        private void btnSend_Click(object sender, EventArgs e)
        {
            if (!CheckValidation())
                return;

            InternetUserName = new ViewModel.SettingSMS.SettingSMS().GetAllValue("InternetUserName", ref str);
            InternetPassword = MKH.Library.Clasess.Security.MSSFunction_Cls.DecriptionText(new ViewModel.SettingSMS.SettingSMS().GetAllValue("InternetPassword", ref str), Library.Clasess.Security.MSSFunction_Cls.EncDecryption.PrivateEncDec);
            InternetTelNumber = new ViewModel.SettingSMS.SettingSMS().GetAllValue("InternetTelNumber", ref str);

            ProgressBarSMS.Value = GridexViewSetForSMS.RowCount;
            ProgressBarSMS.Visible = true;

            
            LabelSleep.Visible = true;

            ProgressBarSMS.Enabled = true;


            //Thread t = new Thread(MyProc);
            //t.Start();

            MyProc();

            LabelSleep.Visible = false;

            ProgressBarSMS.Enabled = false;
            ProgressBarSMS.Visible = false;



        }

        //Semaphore MySem = new Semaphore(3, 3);

        private void MyProc()
        {
            for (int i = 0; i < GridexViewSetForSMS.RowCount; i++)
            {
                string[] hh = {i.ToString(), 
                              (GridexViewSetForSMS.CurrentRow.Cells[2].Value ?? "").ToString(),//MobileNo
                              (GridexViewSetForSMS.CurrentRow.Cells[0].Value ?? "").ToString(),//SenderName
                              (GridexViewSetForSMS.CurrentRow.Cells[1].Value ?? "").ToString(),//SenderJob
                              TextBoxMessage.Text
                              };
                //MySem.WaitOne();
                //ThreadPool.QueueUserWorkItem(ProcessFile, hh);
                ProcessFile(hh);
            }

            // wait for all threads to finish
            //int count = 0;
            //while (count < 3)
            //{
            //    MySem.WaitOne();
            //    ++count;
            //}
        }
        

        string RowState = "";
        void ProcessFile(object state)
        {
            long A = FuncSendSMS((state as string[])[1], (state as string[])[4]);
           // Thread.Sleep(100);
           // MySem.Release();  // release so another thread can start
            ProgressBarSMS.Value += 1;
            RowState = InsertToTable(A, (state as string[])[1], (state as string[])[2], (state as string[])[3], (state as string[])[4]);
            GridexViewSetForSMS.Row = (state as string[])[0].ToInt();
            GridexViewSetForSMS.CurrentRow.Cells[3].Value = RowState;
        }


        private long FuncSendSMS(string MobileNo, string MessageTxt)
        {
            return View.Class.SMSClass.SendSMS(InternetUserName, InternetPassword, InternetTelNumber, MobileNo, MessageTxt, ref SendOk);
        }

        private string InsertToTable(long smsId, string MobileNo, string SenderName, string SenderJob, string MessageTxt)
        {
            string result;
            try
            {
                if (smsId < 1)
                    result = "اشکال: ارسال نشد";
                else if (smsId == 8)
                    result = "شماره اشتباه است";
                else
                {
                    result = "ارسال شد";

                    Model.SendSMS.TBL_SendSM SendSMS = new Model.SendSMS.TBL_SendSM();
                    List<Model.SendSMS.TBL_SendSM> Ls = new List<Model.SendSMS.TBL_SendSM>(1);
                    SendSMS.MessageID = smsId;
                    SendSMS.MessageText = MessageTxt;
                    SendSMS.MobileNo = MobileNo;
                    SendSMS.SenderName = SenderName;
                    SendSMS.SenderJob = SenderJob;
                    SendSMS.Status = "در صف ارسال";//View.Class.SMSClass.GetMessageStatusSendSMS(InternetUserName, InternetPassword, smsId, ref SendOk);
                    //while (!SendOk)
                    //  Application.DoEvents();
                    SendSMS.SMS_Few = (TextBoxMessage.Text.Length / 70) + 1;
                    SendSMS.SendDateTime = MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now);
                    SendSMS.Description = "";
                    SendSMS.Archive = false;
                    SendSMS.User_Id = MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID;
                    SendSMS.ChangeDateTime = MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now);

                    Ls.Add(SendSMS);
                    long? idret = 0;
                    new ViewModel.SendSMS.SendSMS().InsertEntity(Ls, ref str, ref idret);

                }
            }
            catch (Exception ex)
            {
                result = "اشکال: ارسال نشدerrore" + ex.Message;
            }
            return result;
        }


        private void SendSMSProce(object Rcnt)
        {

            try
            {

                List<Model.SendSMS.TBL_SendSM> Ls = new List<Model.SendSMS.TBL_SendSM>(1);

                    GridexViewSetForSMS.Row = Rcnt.ToString().ToInt();
                    try
                    {
                        long smsId = 0;
                        try
                        {
                            Application.DoEvents();
                            smsId = View.Class.SMSClass.SendSMS(InternetUserName, InternetPassword, InternetTelNumber, GridexViewSetForSMS.CurrentRow.Cells[2].Value.ToString(), TextBoxMessage.Text, ref SendOk);
                            while (!SendOk)
                                Application.DoEvents();

                        }
                        catch { }

                        if (smsId < 1)
                            GridexViewSetForSMS.CurrentRow.Cells[3].Value = "اشکال: ارسال نشد";
                        else if (smsId == 8)
                            GridexViewSetForSMS.CurrentRow.Cells[3].Value = "شماره اشتباه است";
                        else
                        {
                            GridexViewSetForSMS.CurrentRow.Cells[3].Value = "ارسال شد";

                            Model.SendSMS.TBL_SendSM SendSMS = new Model.SendSMS.TBL_SendSM();

                            SendSMS.MessageID = smsId;
                            SendSMS.MessageText = TextBoxMessage.Text;
                            SendSMS.MobileNo = (GridexViewSetForSMS.CurrentRow.Cells[2].Value ?? "").ToString();
                            SendSMS.SenderName = (GridexViewSetForSMS.CurrentRow.Cells[0].Value ?? "").ToString();
                            SendSMS.SenderJob = (GridexViewSetForSMS.CurrentRow.Cells[1].Value ?? "").ToString();
                            SendSMS.Status = "در صف ارسال";//View.Class.SMSClass.GetMessageStatusSendSMS(InternetUserName, InternetPassword, smsId, ref SendOk);
                            while (!SendOk)
                                Application.DoEvents();
                            SendSMS.SMS_Few = (TextBoxMessage.Text.Length / 70) + 1;
                            SendSMS.SendDateTime = MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now);
                            SendSMS.Description = "";
                            SendSMS.Archive = false;
                            SendSMS.User_Id = MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID;
                            SendSMS.ChangeDateTime = MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now);

                            Ls.Add(SendSMS);

                        }
                    }
                    catch { }
                
            long? idret = 0;
                new ViewModel.SendSMS.SendSMS().InsertEntity(Ls, ref str, ref idret);

                //if (str != "")
                //    MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "اشکال ثبت اطلاعات", str);
                //else
                //{
                //    MKH.Library.Clasess.MSSMessage.MSSMessage_View("پیامک ها ارسال شد. جهت مشاهده وضعیت به لیست ارسال مراجعه بفرمایید", MKH.Library.Clasess.MSSMessage.MessageType.SInformation);
                //    //DialogResult = System.Windows.Forms.DialogResult.OK;

                //    //Close();
                //}

            }
            catch (Exception ex)
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, ex.Message);
            }

        }


        private bool CheckValidation()
        {
            if (TextBoxMessage.Text.Trim() == "")
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("لطفا متن پیام را پر نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                return false;
            }

            bool ret = true;
            for (int i = 0; i < GridexViewSetForSMS.RowCount; i++)
            {
                GridexViewSetForSMS.Row = i;
                try
                {
                    GridexViewSetForSMS.CurrentRow.Cells[3].Value = "";
                    if (GridexViewSetForSMS.CurrentRow.Cells[2].Value.ToString().Length != 11)
                    {
                        GridexViewSetForSMS.CurrentRow.Cells[3].Value = "شماره موبایل صحیح نمی باشد";
                        ret = false;
                    }

                }
                catch (Exception)
                {

                }
            }

            return ret;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonSetForListSMS_Click(object sender, EventArgs e)
        {
            try
            {
                //foreach (Janus.Windows.GridEX.GridEXSelectedItem item in GridexViewPerson.SelectedItems)
                //{
                //    Janus.Windows.GridEX.GridEXRow g = GridexViewSetForSMS.AddItem();
                //    g.BeginEdit();
                //    g.Cells[0].Value = item.GetRow().Cells[1].Value.ToString();
                //    g.Cells[1].Value = item.GetRow().Cells[2].Value.ToString();
                //    g.Cells[2].Value = item.GetRow().Cells[3].Value.ToString();
                //    g.EndEdit();
                //}
            }
            catch { }

            for (int i = 0; i < GridexViewPerson.RowCount; i++)
            {
                GridexViewPerson.Row = i;
                try
                {
                    if (Convert.ToBoolean(GridexViewPerson.CurrentRow.Cells[0].Value))
                    {
                        Janus.Windows.GridEX.GridEXRow g = GridexViewSetForSMS.AddItem();
                        g.BeginEdit();
                        g.Cells[0].Value = GridexViewPerson.CurrentRow.Cells[1].Value.ToString();
                        g.Cells[1].Value = GridexViewPerson.CurrentRow.Cells[2].Value.ToString();
                        g.Cells[2].Value = GridexViewPerson.CurrentRow.Cells[3].Value.ToString();
                        g.EndEdit();
                        //GridexViewSetForSMS.AddItem(GridexViewPerson.CurrentRow.Cells[1].Value.ToString());
                        //GridexViewSetForSMS.CurrentRow.Cells[1].Value = GridexViewPerson.CurrentRow.Cells[2].Value.ToString();
                        //GridexViewSetForSMS.CurrentRow.Cells[2].Value = GridexViewPerson.CurrentRow.Cells[3].Value.ToString();
                    }

                }
                catch (Exception)
                {

                }
            }
        }

        private void ButtonKey_Click(object sender, EventArgs e)
        {
            Key_frm Ky = new Key_frm();
            Ky.ShowDialog();
            if (Ky.KeyDscSet != "")
                TextBoxMessage.Text += Ky.KeyDscSet;
        }




    }
}
