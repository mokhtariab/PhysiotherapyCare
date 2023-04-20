using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using MKH.SMS.Model.ReciveSMS;
using MKH.Library.Clasess.FilterClass;


namespace MKH.SMS.View.UserControls
{
    public partial class ReciveSMSList_UC : System.Windows.Forms.UserControl
    {
        public ReciveSMSList_UC()
        {
            InitializeComponent();
        }

        public void BindData(int RowNumberSet)
        {
            string str = "";

            List<VW_ReciveSM> LSQ = new List<VW_ReciveSM>();

            LSQ = new ViewModel.ReciveSMS.ReciveSMS().GetAllList(ref str);


           // GridexViewReciveSM.DataSource = LSQ;
            try
            {
                GridexViewReciveSM.DataSource = LSQ.Where(d => MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.ReciveDateTime) >= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladiWithTime(DatePickerStart.Value.ToString(), "", "", "", 0, 0, 0)
                    && MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladi(d.ReciveDateTime) <= MKH.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladiWithTime(DatePickerEnd.Value.ToString(), "", "", "", 23, 59, 59)).ToList();
            }
            catch { }

            try { GridexViewReciveSM.Row = RowNumberSet; }
            catch { }
        }


        #region All UI Button


        private void headerGridReciveSM_btnRefreshClick(object sender, System.EventArgs e)
        {
            BindData(GridexViewReciveSM.Row);
        }

        #endregion

        bool setdate = true;
        private void ReciveSMList_UC_Load(object sender, System.EventArgs e)
        {
            buttonItemReciveNoRead.Enabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(294);

            try
            {
                setdate = false;
                DatePickerStart.Value = KagNetComponents2.KagPersianDate.Now.AddDays(-7);
                setdate = true;
                DatePickerEnd.Value = KagNetComponents2.KagPersianDate.Now;
            }
            catch { }
        }

        private void DatePickerStart_ValueChanged(object sender, KagNetComponents2.PersianMonthCalendarEventArgs e)
        {
            if (setdate) BindData(GridexViewReciveSM.Row);
        }

        private void buttonItemReciveNoRead_Click(object sender, EventArgs e)
        {
            ShowListRcvSMS();
        }


        private void ShowListRcvSMS()
        {
            DataTable dt = new DataTable("ReciveSMS");
            dt.Columns.Add("Checked", typeof(bool));
            dt.Columns.Add("Message", typeof(string));
            dt.Columns.Add("Mobile", typeof(string));
            dt.Columns.Add("DateRecive", typeof(string));
            dt.Columns.Add("DateReciveMiladi", typeof(DateTime));
            dt.Columns.Add("TimeStampRFC", typeof(string));
            dt.Columns.Add("Index", typeof(int));
            dt.Columns.Add("ConfirmOK", typeof(int));
            dt.Columns.Add("RecipientNumber", typeof(string));
            dt.Columns.Add("MessageID", typeof(long)); dt.Clear();


            string SResult = MKH.SMS.View.Class.SMSClass.ReadSMS(ref dt);

            MKH.Library.Clasess.MSSMessage.MSSMessage_View(SResult, Library.Clasess.MSSMessage.MessageType.SInformation);
            string str = ""; long? retId = 0;
            try
            {
                List<TBL_ReciveSM> ls = new List<TBL_ReciveSM>();
                foreach (var Msg in dt.Select())
                {
                    TBL_ReciveSM ReciveSMs = new TBL_ReciveSM();
                    ReciveSMs.MessageID = Convert.ToInt32(Msg["MessageID"]);
                    ReciveSMs.ReciveDateTime = Msg["DateRecive"].ToString();
                    ReciveSMs.MessageText = Msg["Message"].ToString();
                    ReciveSMs.RecipientNumber = Msg["RecipientNumber"].ToString();
                    ReciveSMs.ReciverNumber = Msg["Mobile"].ToString();


                    ReciveSMs.ReciverName = MKH.Library.Clasess.PublicClass.ListAllPersonForSMS.First(e => e.MobileNo1.Contains(ReciveSMs.ReciverNumber.Substring(ReciveSMs.ReciverNumber.Length - 10)) || e.MobileNo2.Contains(ReciveSMs.ReciverNumber.Substring(ReciveSMs.ReciverNumber.Length - 10))).PersonNameFamily ?? "";
                    ReciveSMs.ReciverJob = MKH.Library.Clasess.PublicClass.ListAllPersonForSMS.First(e => e.MobileNo1.Contains(ReciveSMs.ReciverNumber.Substring(ReciveSMs.ReciverNumber.Length - 10)) || e.MobileNo2.Contains(ReciveSMs.ReciverNumber.Substring(ReciveSMs.ReciverNumber.Length - 10))).JobType ?? "";
                    ReciveSMs.Description = "";
                    ReciveSMs.SMS_Few = 1;
                    ReciveSMs.User_Id = MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID;
                    ReciveSMs.ChangeDateTime = MKH.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(DateTime.Now);
                    ls.Add(ReciveSMs);
                }
                new ViewModel.ReciveSMS.ReciveSMS().InsertEntity(ls, ref str, ref retId);
            }
            catch (Exception ex)
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("ثبت اطلاعات پیامک های جدید با مشکل مواجه گردید" + ex.Message, Library.Clasess.MSSMessage.MessageType.SError);
            }
            BindData(GridexViewReciveSM.Row);
        }



    }
}
