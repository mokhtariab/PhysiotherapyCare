using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MKH.SMS.Model.SendSMS;

namespace MKH.SMS.View.UserControls
{
    public partial class SendSMSList_UC: UserControl
    {
        public SendSMSList_UC()
        {
            InitializeComponent();
        }

        string str = "", InternetUserName = "", InternetPassword = "", InternetTelNumber = "";
        bool SendOk = false;

        public void BindData(int RowNumberSet)
        {
            List<VW_SendSM> LSQ = new List<VW_SendSM>();
            LSQ = new ViewModel.SendSMS.SendSMS().GetAllList(ref str);

            try
            {
                GridexViewSendSMS.DataSource = LSQ.Where(d => MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.SendDateTime) >= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladiWithTime(DatePickerStart.Value.ToString(), "", "", "", 0, 0, 0)
                    && MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.SendDateTime) <= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladiWithTime(DatePickerEnd.Value.ToString(), "", "", "", 23, 59, 59)).ToList();
            }
            catch { }



            try { GridexViewSendSMS.Row = RowNumberSet; }
            catch { }
        }

        
        
        
        public void BindDataState(int RowNumberSet)
        {
            //mssProgressBar1.Visible = true;
            //mssProgressBar1.Style = ProgressBarStyle.Marquee.;
            //System.Threading.Thread thread =
            //  new System.Threading.Thread(new System.Threading.ThreadStart(loadTable));
            //thread.Start();


            InternetUserName = new ViewModel.SettingSMS.SettingSMS().GetAllValue("InternetUserName", ref str);
            InternetPassword = MKH.Library.Clasess.Security.MSSFunction_Cls.DecriptionText(new ViewModel.SettingSMS.SettingSMS().GetAllValue("InternetPassword", ref str), Library.Clasess.Security.MSSFunction_Cls.EncDecryption.PrivateEncDec);
            InternetTelNumber = new ViewModel.SettingSMS.SettingSMS().GetAllValue("InternetTelNumber", ref str);
            SendOk = false;

            try
            {
                for (int i = 0; i < GridexViewSendSMS.RowCount; i++)
                {
                    GridexViewSendSMS.Row = i;
                    if (GridexViewSendSMS.CurrentRow.Cells["Status"].Value.ToString() == "در صف ارسال" || GridexViewSendSMS.CurrentRow.Cells["Status"].Value.ToString() == "خطا در ارسال" ||
                      GridexViewSendSMS.CurrentRow.Cells["Status"].Value.ToString() == "رسیده به مخابرات")
                    {
                        string Status = SMS.View.Class.SMSClass.GetMessageStatusSendSMS(InternetUserName, InternetPassword, Convert.ToInt64(GridexViewSendSMS.CurrentRow.Cells["MessageID"].Value), ref SendOk);
                        while (!SendOk)
                            Application.DoEvents();
                        Application.DoEvents();

                        new ViewModel.SendSMS.SendSMS().UpdateStatus(
                            Convert.ToInt64(GridexViewSendSMS.CurrentRow.Cells["Id"].Value),
                            Status,
                            ref str
                            );
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The underlying connection was closed: The connection was closed unexpectedly."))
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "ارتباط با اینترنت برقرار نمی باشد", ex.Message);
                else
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "اشکال - دوباره تلاش کنید", ex.Message);
            }



            List<VW_SendSM> LSQ = new List<VW_SendSM>();
            LSQ = new ViewModel.SendSMS.SendSMS().GetAllList(ref str);

            try
            {
                GridexViewSendSMS.DataSource = LSQ.Where(d => MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.SendDateTime) >= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladiWithTime(DatePickerStart.Value.ToString(), "", "", "", 0, 0, 0)
                    && MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.SendDateTime) <= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladiWithTime(DatePickerEnd.Value.ToString(), "", "", "", 23, 59, 59)).ToList();
            }
            catch { }

            
            
            try { GridexViewSendSMS.Row = RowNumberSet; }
            catch { }
        }

        #region All UI Button

        private void headerGridSendSMS_btnRefreshClick(object sender, System.EventArgs e)
        {
            BindData(GridexViewSendSMS.Row);
        }

        #endregion

        bool setdate = true;
        private void SendSMSList_UC_Load(object sender, System.EventArgs e)
        {
            buttonItemSendSMS.Enabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(291);

            try
            {
                setdate = false;
                DatePickerStart.Value = KagNetComponents2.KagPersianDate.Now;
                setdate = true;
                DatePickerEnd.Value = KagNetComponents2.KagPersianDate.Now;
            }
            catch { }
        }

        private void DatePickerStart_ValueChanged(object sender, KagNetComponents2.PersianMonthCalendarEventArgs e)
        {
            if (setdate) BindData(GridexViewSendSMS.Row);
        }

        private void buttonItemSendSMS_Click(object sender, EventArgs e)
        {
            Forms.SendSMSAdd_Frm ssa = new Forms.SendSMSAdd_Frm();
            ssa.Show();
            //if (ssa.ShowDialog() == DialogResult.OK)
              //  BindData(GridexViewSendSMS.Row);
        }

        private void ToolStripMenuItemResendSMS_Click(object sender, EventArgs e)
        {
            LabelSleep.Visible = true;
            Application.DoEvents();
            try
            {
                long smsId = 0;
                List<Model.SendSMS.TBL_SendSM> Ls = new List<Model.SendSMS.TBL_SendSM>(1);

                for (int i = 0; i < GridexViewSendSMS.SelectedItems.Count; i++)
                {
                    try
                    {
                        try
                        {
                            smsId = View.Class.SMSClass.SendSMS(InternetUserName, InternetPassword, InternetTelNumber, GridexViewSendSMS.SelectedItems[i].GetRow().Cells["MobileNo"].Value.ToString(), GridexViewSendSMS.SelectedItems[i].GetRow().Cells["MessageText"].Value.ToString(), ref SendOk);
                            while (!SendOk)
                                Application.DoEvents();
                        }
                        catch { }

                        //if (smsId < 1)
                        //{
                        //    MKH.Library.Clasess.MSSMessage.MSSMessage_View("اشکال: ارسال نشد", MKH.Library.Clasess.MSSMessage.MessageType.SError);
                        //}
                        //else
                        //{
                        //    GridexViewSendSMS.CurrentRow.Cells[3].Value = "ارسال شد";


                        Model.SendSMS.TBL_SendSM SendSMS = new Model.SendSMS.TBL_SendSM();

                        SendSMS.Id = long.Parse(GridexViewSendSMS.SelectedItems[i].GetRow().Cells["Id"].Value.ToString());
                        SendSMS.MessageID = smsId;
                        SendSMS.MessageText = GridexViewSendSMS.SelectedItems[i].GetRow().Cells["MessageText"].Value.ToString();
                        SendSMS.MobileNo = GridexViewSendSMS.SelectedItems[i].GetRow().Cells["MobileNo"].Value.ToString();
                        SendSMS.SenderName = GridexViewSendSMS.SelectedItems[i].GetRow().Cells["SenderName"].Value.ToString();
                        SendSMS.SenderJob = GridexViewSendSMS.SelectedItems[i].GetRow().Cells["SenderJob"].Value.ToString();
                        SendSMS.Status = "در صف ارسال"; //View.Class.SMSClass.GetMessageStatusSendSMS(InternetUserName, InternetPassword, smsId, ref SendOk);
                        while (!SendOk)
                            Application.DoEvents();
                        SendSMS.SMS_Few = (GridexViewSendSMS.SelectedItems[i].GetRow().Cells["MessageText"].Value.ToString().Length / 70) + 1;
                        SendSMS.SendDateTime = MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now);
                        SendSMS.Description = GridexViewSendSMS.SelectedItems[i].GetRow().Cells["Description"].Value.ToString() + "ارسال مجدد:" + MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now) + " ";
                        SendSMS.Archive = false;
                        SendSMS.User_Id = MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID;
                        SendSMS.ChangeDateTime = MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now);
                        Ls.Add(SendSMS);
                    }
                    catch { }
                }

                new ViewModel.SendSMS.SendSMS().UpdateEntity(Ls, ref str);

                if (str != "")
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "اشکال ثبت اطلاعات", str);
                else
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View("پیامک ها مجددا ارسال شد.", MKH.Library.Clasess.MSSMessage.MessageType.SInformation);
                }

            }
            catch (Exception ex)
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, ex.Message);
            }

            Application.DoEvents();
            

            BindData(GridexViewSendSMS.Row);

            LabelSleep.Visible = false;
        }




    }
}
