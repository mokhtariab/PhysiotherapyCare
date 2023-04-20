using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace PhysiotherapyCare.Other.Forms
{
    public partial class Setting_frm : MKH.Library.Forms.MSSBaseNew_frm
    {
        public Setting_frm()
        {
            InitializeComponent();
        }

        private bool CloseOK = false;


        #region Load & UI
        private void Setting_frm_Load(object sender, EventArgs e)
        {
            if (! new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(297)) treeView_Setting.Nodes["Node_SetSystem"].Remove();
            if (! new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(298)) treeView_Setting.Nodes["Node_SetBkpRst"].Remove();
            if (! new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(299)) treeView_Setting.Nodes["Node_SMS"].Remove();
            button_RstChangePass.Enabled = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(304);
           
            treeView_Setting.ExpandAll();
            TreeNodeMouseClickEventArgs a = new TreeNodeMouseClickEventArgs(treeView_Setting.SelectedNode, MouseButtons.Left, 1, 0, 0);
            treeView_Setting_NodeMouseClick(this, a);


            //sms start
            //InitializeComboBoxSMS();

            //cmbPort.Text = Global_Cls.SMSPort.ToString();
            //cmbBaudRate.Text = Global_Cls.SMSBaudRate.ToString();
            //cmbDataBits.Text = Global_Cls.SMSDataBits.ToString();
            //cmbParity.SelectedIndex = Global_Cls.SMSParity;
            //cmbStopBits.SelectedIndex = Global_Cls.SMSStopBits - 1;
            //cmbFlowControl.SelectedIndex = Global_Cls.SMSFlowControl;
            //cmbTimeOut.Text = Global_Cls.SMSTimeOut.ToString();

            //cmbEncoding.SelectedIndex = Global_Cls.SMSEncoding;
            //cmbLongMsg.SelectedIndex = Global_Cls.SMSLongMsg;
            //chkDeliveryReport.Checked = Global_Cls.SMSDeliveryReport;
            //sms end 

            //BkpRst start
            string str = "";
            TextBoxBkpAuto.Text = new ViewModel.Setting.Setting().GetAllValue("BkpRstPathSaveBackup", ref str);
            radioButton_BkpAuto.Checked = (new ViewModel.Setting.Setting().GetAllValue("BkpRstExitType", ref str) == "2");
            radioButton_BkpNonAuto.Checked = (new ViewModel.Setting.Setting().GetAllValue("BkpRstExitType", ref str) == "1");
            radioButton_BkpNo.Checked = (new ViewModel.Setting.Setting().GetAllValue("BkpRstExitType", ref str) == "0");
            
            //checkBox_BRPicFilm.Checked = Global_Cls.BkpRstPicsFilms;
            //checkBox_BRDesignRep.Checked = Global_Cls.BkpRstDesignReport;
            //BkpRst end

            ////All Alarm start
            //nUpDownPrvAlarmDayForVisit.Value = Global_Cls.PrvAlarmDayForVisit;
            ////All Alarm end


            //Setting start
            TextBoxFileSavingPatient.Text = new ViewModel.Setting.Setting().GetAllValue("FileSavingPatient", ref str);
            TextBoxFileSavingPhysiotherapy.Text = new ViewModel.Setting.Setting().GetAllValue("FileSavingPhysiotherapy", ref str);
            TextBoxFileSavingCare.Text = new ViewModel.Setting.Setting().GetAllValue("FileSavingCare", ref str);
            TextBoxFileSavingHealth.Text = new ViewModel.Setting.Setting().GetAllValue("FileSavingHealth", ref str);
            TextBoxFileSavingVisit.Text = new ViewModel.Setting.Setting().GetAllValue("FileSavingVisit", ref str);

            IntBoxCareShift1.Value = new ViewModel.Setting.Setting().GetAllValue("CareShift1", ref str);
            IntBoxCareShift2.Value = new ViewModel.Setting.Setting().GetAllValue("CareShift2", ref str);
            IntBoxCareShift3.Value = new ViewModel.Setting.Setting().GetAllValue("CareShift3", ref str);
            IntBoxCareDaysDefault.Value = new ViewModel.Setting.Setting().GetAllValue("CareDaysDefault", ref str);
            IntBoxCostCompanyCarePercent.Value = new ViewModel.Setting.Setting().GetAllValue("CostCompanyCarePercent", ref str);

            IntBoxCostReqInsuPhsiotraphy.Value = new ViewModel.Setting.Setting().GetAllValue("CostReqInsuPhsiotraphy", ref str);
            IntBoxCostCompanyPhsiotraphyPercent.Value = new ViewModel.Setting.Setting().GetAllValue("CostCompanyPhsiotraphyPercent", ref str);

            IntBoxCostCompanyHealthPercent.Value = new ViewModel.Setting.Setting().GetAllValue("CostCompanyHealthPercent", ref str);

            IntBoxCostReqInsuVisitAdd.Value = new ViewModel.Setting.Setting().GetAllValue("CostReqInsuVisitAdd", ref str);
            IntBoxCostReqInsuVisitEven.Value = new ViewModel.Setting.Setting().GetAllValue("CostReqInsuVisitEven", ref str);
            IntBoxCostCompanyVisitPercent.Value = new ViewModel.Setting.Setting().GetAllValue("CostCompanyVisitPercent", ref str);
            IntBoxCostInsurancePercent.Value = new ViewModel.Setting.Setting().GetAllValue("CostInsurancePercent", ref str);


            //Setting end
        }


        //private void InitializeComboBoxSMS()
        //{
        //    //-------------------------------------
        //    //Initialize COM Port DropDown List
        //    //-------------------------------------
        //    cmbPort.Items.Add("Select Port");
        //    for (int i = 1; i <= 256; i++)
        //    {
        //        cmbPort.Items.Add("COM" + i.ToString());
        //    }
        //    cmbPort.SelectedIndex = 0;


        //    //--------------------------------------
        //    //Initialize BaudRate DropDown List
        //    //--------------------------------------
        //    cmbBaudRate.Items.Add("110");
        //    cmbBaudRate.Items.Add("300");
        //    cmbBaudRate.Items.Add("1200");
        //    cmbBaudRate.Items.Add("2400");
        //    cmbBaudRate.Items.Add("4800");
        //    cmbBaudRate.Items.Add("9600");
        //    cmbBaudRate.Items.Add("14400");
        //    cmbBaudRate.Items.Add("19200");
        //    cmbBaudRate.Items.Add("38400");
        //    cmbBaudRate.Items.Add("57600");
        //    cmbBaudRate.Items.Add("115200");
        //    cmbBaudRate.Items.Add("230400");
        //    cmbBaudRate.Items.Add("460800");
        //    cmbBaudRate.Items.Add("921600");
        //    //cmbBaudRate.SelectedIndex = cmbBaudRate.FindString(((int)objSMS.BaudRate).ToString());

        //    //--------------------------------------
        //    //Initialize DataBits DropDown List
        //    //--------------------------------------
        //    cmbDataBits.Items.Add("4");
        //    cmbDataBits.Items.Add("5");
        //    cmbDataBits.Items.Add("6");
        //    cmbDataBits.Items.Add("7");
        //    cmbDataBits.Items.Add("8");
        //    //cmbDataBits.SelectedIndex = cmbDataBits.FindString(((int)objSMS.DataBits).ToString());


        //    //--------------------------------------
        //    //Initialize Parity DropDown List
        //    //--------------------------------------
        //    cmbParity.Items.Add("None");
        //    cmbParity.Items.Add("Odd");
        //    cmbParity.Items.Add("Even");
        //    cmbParity.Items.Add("Mark");
        //    cmbParity.Items.Add("Space");
        //    //cmbParity.SelectedIndex = (int)objSMS.Parity;


        //    //--------------------------------------
        //    //Initialize StopBits DropDown List
        //    //--------------------------------------
        //    cmbStopBits.Items.Add("1");
        //    cmbStopBits.Items.Add("2");
        //    cmbStopBits.Items.Add("1.5");
        //    //cmbStopBits.SelectedIndex = (int)objSMS.StopBits - 1;


        //    //--------------------------------------
        //    //Initialize FlowControl DropDown List
        //    //--------------------------------------
        //    cmbFlowControl.Items.Add("None");
        //    cmbFlowControl.Items.Add("Hardware");
        //    cmbFlowControl.Items.Add("Xon/Xoff");
        //    //cmbFlowControl.SelectedIndex = (int)objSMS.FlowControl;


        //    cmbEncoding.Items.Add("Default Alphabet");
        //    cmbEncoding.Items.Add("ANSI (8-bit)");
        //    cmbEncoding.Items.Add("Unicode (16-bit)");
        //    //cmbEncoding.SelectedIndex = (int)objSMS.Encoding;

        //    //----------------------------------------
        //    //Initialize Long Message DropDown List
        //    //----------------------------------------
        //    cmbLongMsg.Items.Add("Truncate");
        //    cmbLongMsg.Items.Add("Simple Split");
        //    cmbLongMsg.Items.Add("Formatted Split");
        //    cmbLongMsg.Items.Add("Concatenate");
        //}

        
        private void buttonItem_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Setting_frm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (!Global_Cls.MainForm.CloseAllOK && !CloseOK && !Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SConfirmation, true, "آیا از این فرم خارج می شوید؟"))
            //    e.Cancel = true;
        }
        #endregion


        
        #region OK

        private void buttonItem_OK_Click(object sender, EventArgs e)
        {
            ////sms start

            //Global_Cls.SMSPort = cmbPort.Text;
            //Global_Cls.SMSBaudRate = Convert.ToInt32(cmbBaudRate.Text);
            //Global_Cls.SMSDataBits = Convert.ToInt32(cmbDataBits.Text);
            //Global_Cls.SMSParity = cmbParity.SelectedIndex;
            //Global_Cls.SMSStopBits = cmbStopBits.SelectedIndex + 1;
            //Global_Cls.SMSFlowControl = cmbFlowControl.SelectedIndex;
            //Global_Cls.SMSTimeOut = Convert.ToInt32(cmbTimeOut.Text);

            //Global_Cls.SMSEncoding = cmbEncoding.SelectedIndex;
            //Global_Cls.SMSLongMsg = cmbLongMsg.SelectedIndex;
            //Global_Cls.SMSDeliveryReport = chkDeliveryReport.Checked;

            ////Global_Cls.Comm_Port = Convert.ToInt32(cmbport.Text);
            ////Global_Cls.Comm_BaudRate = Convert.ToInt32(cmbBaudRate.Text);
            ////Global_Cls.Comm_TimeOut = Convert.ToInt32(cmbTimeOut.Text);
            ////Global_Cls.Send_Unicode = chkunicode.Checked;
            ////sms end

            ////All Alarm start
            //Global_Cls.PrvAlarmDayForVisit = int.Parse(nUpDownPrvAlarmDayForVisit.Value.ToString());
            ////All Alarm end

            ////BkpRst start
            //Global_Cls.BkpAutoRoot = label_BkpAuto.Text;
            //if (radioButton_BkpAuto.Checked) Global_Cls.BkpExitType = 2;
            //else if (radioButton_BkpNonAuto.Checked) Global_Cls.BkpExitType = 1;
            //else Global_Cls.BkpExitType = 0;
            ////Global_Cls.BkpRstPicsFilms = checkBox_BRPicFilm.Checked;
            ////Global_Cls.BkpRstDesignReport = checkBox_BRDesignRep.Checked;
            ////BkpRst end


            //Function_Cls.WriteToXmlFiles();

            //CloseOK = true;
            this.Close();

        }

        #endregion



        #region Other

        //private void button_BkpAuto_Click(object sender, EventArgs e)
        //{
        //    FolderBrowserDialog dir = new FolderBrowserDialog();
        //    dir.SelectedPath = label_BkpAuto.Text;
        //    if (dir.ShowDialog() == DialogResult.OK)
        //    {
        //        label_BkpAuto.Text = dir.SelectedPath;
        //    }
        //}

        private void button_RstChangePass_Click(object sender, EventArgs e)
        {
            PhysiotherapyCare.Other.Class.Function_Cls.Restore_Func(true);
        }

        private void treeView_Setting_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                if (e.Node.Name == "Node_SetSystem") tabControl_Setting.SelectedTab = tabControl_Setting.Tabs["tabItem_SetSystem"];
            }
            catch { } 
            
            try
            {
                if (e.Node.Name == "Node_SetPosDef") tabControl_Setting.SelectedTab = tabControl_Setting.Tabs["tabItem_SetPosDef"];
            }
            catch { } 
            
            try
            {
                if (e.Node.Name == "Node_SetAlarms") tabControl_Setting.SelectedTab = tabControl_Setting.Tabs["tabItem_SetAlarms"];
            }
            catch { } 
            
            try
            {
                if (e.Node.Name == "Node_SetBkpRst") tabControl_Setting.SelectedTab = tabControl_Setting.Tabs["tabItem_SetBkpRst"];
            }
            catch { }

            try
            {
                if (e.Node.Name == "Node_SMS") tabControl_Setting.SelectedTab = tabControl_Setting.Tabs["tabItem_SMS"];
            }
            catch { }
        }

        #endregion

        private void buttonItemOK_Click(object sender, EventArgs e)
        {
            //BkpRst start
            string str = "";


            PhysiotherapyCare.Model.Setting.TBL_Setting setting = null;
            List<PhysiotherapyCare.Model.Setting.TBL_Setting> ls = new List<Model.Setting.TBL_Setting>();
                
            setting = new Model.Setting.TBL_Setting();
            setting.Name = "BkpRstPathSaveBackup";
            setting.value = TextBoxBkpAuto.Text;
            ls.Add(setting);

            setting = new Model.Setting.TBL_Setting();
            setting.Name = "BkpRstExitType";
            setting.value = (radioButton_BkpAuto.Checked ? "2": radioButton_BkpNonAuto.Checked ? "1": "0");
            ls.Add(setting);

            //BkpRst end


            //Setting start
            setting = new Model.Setting.TBL_Setting();
            setting.Name = "FileSavingPatient";
            setting.value = TextBoxFileSavingPatient.Text;
            ls.Add(setting);

            setting = new Model.Setting.TBL_Setting();
            setting.Name = "FileSavingPhysiotherapy";
            setting.value = TextBoxFileSavingPhysiotherapy.Text;
            ls.Add(setting);

            setting = new Model.Setting.TBL_Setting();
            setting.Name = "FileSavingHealth";
            setting.value = TextBoxFileSavingHealth.Text;
            ls.Add(setting);


            setting = new Model.Setting.TBL_Setting();
            setting.Name = "FileSavingCare";
            setting.value = TextBoxFileSavingCare.Text;
            ls.Add(setting);


            setting = new Model.Setting.TBL_Setting();
            setting.Name = "FileSavingVisit";
            setting.value = TextBoxFileSavingVisit.Text;
            ls.Add(setting);


            
            
            
            setting = new Model.Setting.TBL_Setting();
            setting.Name = "CostCompanyCarePercent";
            setting.value = IntBoxCostCompanyCarePercent.Value.ToString();
            ls.Add(setting);

            setting = new Model.Setting.TBL_Setting();
            setting.Name = "CareShift1";
            setting.value = IntBoxCareShift1.Value.ToString();
            ls.Add(setting);

            setting = new Model.Setting.TBL_Setting();
            setting.Name = "CareShift2";
            setting.value = IntBoxCareShift2.Value.ToString();
            ls.Add(setting);

            setting = new Model.Setting.TBL_Setting();
            setting.Name = "CareShift3";
            setting.value = IntBoxCareShift3.Value.ToString();
            ls.Add(setting);

            setting = new Model.Setting.TBL_Setting();
            setting.Name = "CareDaysDefault";
            setting.value = IntBoxCareDaysDefault.Value.ToString();
            ls.Add(setting);





            setting = new Model.Setting.TBL_Setting();
            setting.Name = "CostCompanyPhsiotraphyPercent";
            setting.value = IntBoxCostCompanyPhsiotraphyPercent.Value.ToString();
            ls.Add(setting);


            setting = new Model.Setting.TBL_Setting();
            setting.Name = "CostReqInsuPhsiotraphy";
            setting.value = IntBoxCostReqInsuPhsiotraphy.Value.ToString();
            ls.Add(setting);







            setting = new Model.Setting.TBL_Setting();
            setting.Name = "CostCompanyHealthPercent";
            setting.value = IntBoxCostCompanyHealthPercent.Value.ToString();
            ls.Add(setting);








            setting = new Model.Setting.TBL_Setting();
            setting.Name = "CostReqInsuVisitAdd";
            setting.value = IntBoxCostReqInsuVisitAdd.Value.ToString();
            ls.Add(setting);


            setting = new Model.Setting.TBL_Setting();
            setting.Name = "CostReqInsuVisitEven";
            setting.value = IntBoxCostReqInsuVisitEven.Value.ToString();
            ls.Add(setting);


            setting = new Model.Setting.TBL_Setting();
            setting.Name = "CostCompanyVisitPercent";
            setting.value = IntBoxCostCompanyVisitPercent.Value.ToString();
            ls.Add(setting);

            setting = new Model.Setting.TBL_Setting();
            setting.Name = "CostInsurancePercent";
            setting.value = IntBoxCostInsurancePercent.Value.ToString();
            ls.Add(setting);



            //Setting end

            new ViewModel.Setting.Setting().UpdateEntity(ls,ref str);

            Close();
        }

        private void button_SMSSetting_Click(object sender, EventArgs e)
        {
            MKH.SMS.View.Forms.SMSSetting_Frm SMSSet = new MKH.SMS.View.Forms.SMSSetting_Frm();
            SMSSet.ShowDialog();
        }

        private void ButtonClearCash_Click(object sender, EventArgs e)
        {
            string str = "";
            if (MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation, true, "آیا اطمینان دارید؟"))
                new ViewModel.Setting.Setting().ClearCashForSystem(ref str);
        }


    }
}