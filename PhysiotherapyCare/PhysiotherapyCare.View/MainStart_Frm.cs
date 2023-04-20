using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PhysiotherapyCare.View.BaseForms;
using PhysiotherapyCare.View.MainForms;

namespace PhysiotherapyCare.View
{
    public partial class MainStart_Frm : MKH.Library.Forms.MSSMainForm
    {
        public MainStart_Frm()
        {
            InitializeComponent();
            MKH.Library.Clasess.PublicParam.MainForm = this;
        }

        private void MainStart_Frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            PhysiotherapyCare.Other.Class.Function_Cls.BackUpDBExitSet();

            Application.Exit();
        }

        private void MainStart_Frm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation, true, "آیا از برنامه خارج می شوید؟"))
            {
                e.Cancel = true;
                return;
            }

        }

        private void MainStart_Frm_Load(object sender, EventArgs e)
        {
            new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionControl(this);
            LabelCONameStr.Text = GetCompanyName();

            string str = "";
            new ViewModel.DoctorsContracts.DoctorsContract().GetAllUpdateContract(ref str);
            if (str != "")
                MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "قراردادهای پزشکان به روز آوری نشد", str);

            MKH.Library.Clasess.PublicParam.AddressReportDesign = new ViewModel.Setting.Setting().GetAllValue("FileDesignReport", ref str);
            MKH.Library.Clasess.PublicParam.MSSReportDesignListbuttonAddPermission = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(301);
            MKH.Library.Clasess.PublicParam.MSSReportDesignListbuttonEditPermission = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(302);
            MKH.Library.Clasess.PublicParam.MSSReportDesignListbuttonDelPermission = new MKH.Permission.ViewModel.Security.MSSCheckPermission_cls().CheckPermissionItem(303);

        }

       
        public string GetCompanyName()
        {
            string CompanyName = ".";
            if (System.IO.File.Exists(System.Windows.Forms.Application.StartupPath + "\\LocalConfig.xml"))
            {
                try
                {
                    System.Xml.Linq.XDocument loaded = System.Xml.Linq.XDocument.Load("LocalConfig.xml");

                    var q = (from c in loaded.Descendants("setting")
                             select c).ToList();


                    CompanyName = q.Find(j => j.FirstAttribute.Value == "CONameStr").Value;

                }
                catch { }
            }
            return CompanyName;

        }

        #region Basic Form
        private void buttonItemDoctorType_Click(object sender, EventArgs e)
        {
            DoctorType_Frm SS = new DoctorType_Frm();
            SS.ShowDialog();
        }
        private void buttonItemInjuryType_Click(object sender, EventArgs e)
        {
            InjuryType_Frm SS = new InjuryType_Frm();
            SS.ShowDialog();
        }

        private void buttonItemPatientType_Click(object sender, EventArgs e)
        {
            PatientType_Frm SS = new PatientType_Frm();
            SS.ShowDialog();
        }


        private void buttonItemBank_Click(object sender, EventArgs e)
        {
            Bank_Frm SS = new Bank_Frm();
            SS.ShowDialog();
        }

        private void buttonItemLocationPart_Click(object sender, EventArgs e)
        {
            LocationPart_Frm SS = new LocationPart_Frm();
            SS.ShowDialog();
        }

        private void buttonItemKinShip_Click(object sender, EventArgs e)
        {
            KinShip_Frm SS = new KinShip_Frm();
            SS.ShowDialog();
        }

        private void buttonItemPatientStatusType_Click(object sender, EventArgs e)
        {
            PhysiotherapyCare.View.MainForms.Status.StatusType_Frm SS = new PhysiotherapyCare.View.MainForms.Status.StatusType_Frm();
            SS.ShowDialog();
        }


        private void buttonItemStatusTypeDetail_Click(object sender, EventArgs e)
        {
            PhysiotherapyCare.View.MainForms.Status.StatusTypeDetail_Frm SS = new PhysiotherapyCare.View.MainForms.Status.StatusTypeDetail_Frm();
            SS.ShowDialog();
        }

        private void buttonItemServiceType_Click(object sender, EventArgs e)
        {
            PhysiotherapyCare.View.MainForms.VisitHealthCare.ServiceType_Frm SS = new MainForms.VisitHealthCare.ServiceType_Frm();
            SS.ShowDialog();
        }

        private void buttonItemServiceTypeDsc_Click(object sender, EventArgs e)
        {
            PhysiotherapyCare.View.MainForms.VisitHealthCare.ServiceTypeDsc_Frm SS = new MainForms.VisitHealthCare.ServiceTypeDsc_Frm();
            SS.ShowDialog();
        }


        #region Visit Base


        private void buttonItemSickness_Click(object sender, EventArgs e)
        {
            Sickness_Frm SS = new Sickness_Frm();
            SS.ShowDialog();
        }

        private void buttonItemSicknessDetail_Click(object sender, EventArgs e)
        {
            SicknessDetail_Frm SS = new SicknessDetail_Frm();
            SS.ShowDialog();
        }


        private void buttonItemParaclinic_Click(object sender, EventArgs e)
        {
            Paraclinic_Frm SS = new Paraclinic_Frm();
            SS.ShowDialog();
        }

        private void buttonItemDrug_Click(object sender, EventArgs e)
        {
            Drug_Frm SS = new Drug_Frm();
            SS.ShowDialog();
        }

        private void buttonItemVaccination_Click(object sender, EventArgs e)
        {
            Vaccination_Frm SS = new Vaccination_Frm();
            SS.ShowDialog();
        }

        private void buttonItemEquipmentUse_Click(object sender, EventArgs e)
        {
            EquipmentUse_Frm SS = new EquipmentUse_Frm();
            SS.ShowDialog();
        }



        #endregion  


        #endregion


        #region Main UserControl

        private void buttonItemDoctors_Click(object sender, EventArgs e)
        {
            PhysiotherapyCare.View.MainForms.Doctors.Doctors_UC SPU = new PhysiotherapyCare.View.MainForms.Doctors.Doctors_UC();
            TabControlMain.AddTabToTabControl(SPU.Name, SPU.Tag.ToString(), SPU);
        }

        private void buttonItemMartyrs_Click(object sender, EventArgs e)
        {
            MainForms.Martyrs.Martyrs_UC SPU = new MainForms.Martyrs.Martyrs_UC();
            TabControlMain.AddTabToTabControl(SPU.Name, SPU.Tag.ToString(), SPU);
        }

        private void buttonItemPatient_Click(object sender, EventArgs e)
        {
            MainForms.Patient.Patient_UC SPU = new MainForms.Patient.Patient_UC();
            TabControlMain.AddTabToTabControl(SPU.Name, SPU.Tag.ToString(), SPU);
        }

        private void buttonItemVisitPatientPhysiotherapy_Click(object sender, EventArgs e)
        {
            MainForms.VisitPatientPhysiotherapy.VisitPatientPhysiotherapy_UC SPU = new MainForms.VisitPatientPhysiotherapy.VisitPatientPhysiotherapy_UC();
            TabControlMain.AddTabToTabControl(SPU.Name, SPU.Tag.ToString(), SPU);
        }

        private void buttonItemPaymentBimeh_Click(object sender, EventArgs e)
        {
            MainForms.VisitPatientPhysiotherapy.VisitPatientPhysiotherapyPaymentBimeh_UC SPU = new MainForms.VisitPatientPhysiotherapy.VisitPatientPhysiotherapyPaymentBimeh_UC();
            TabControlMain.AddTabToTabControl(SPU.Name, SPU.Tag.ToString(), SPU);
        }


        private void buttonItemVisitPatientCare_Click(object sender, EventArgs e)
        {
            MainForms.VisitPatientCare.VisitPatientCare_UC SPU = new MainForms.VisitPatientCare.VisitPatientCare_UC();
            TabControlMain.AddTabToTabControl(SPU.Name, SPU.Tag.ToString(), SPU);
        }

        private void buttonItemPatientDel_Click(object sender, EventArgs e)
        {
            MainForms.Patient.PatientDel_UC SPU = new MainForms.Patient.PatientDel_UC();
            TabControlMain.AddTabToTabControl(SPU.Name, SPU.Tag.ToString(), SPU);
        }

        private void buttonItemVisitHealthCare_Click(object sender, EventArgs e)
        {
            MainForms.VisitHealthCare.VisitHealthCare_UC SPU = new MainForms.VisitHealthCare.VisitHealthCare_UC();
            TabControlMain.AddTabToTabControl(SPU.Name, SPU.Tag.ToString(), SPU);
        }

        private void buttonItemTelBook_Click(object sender, EventArgs e)
        {
            ViewModel.PublicClass.FillForSMS();
            MKH.Contacts.View.UserControls.PersonGroupList_UC SPU = new MKH.Contacts.View.UserControls.PersonGroupList_UC();
            TabControlMain.AddTabToTabControl(SPU.Name, SPU.Tag.ToString(), SPU);
        }

        private void buttonItemReciveSMS_Click(object sender, EventArgs e)
        {
            ViewModel.PublicClass.FillForSMS();

            MKH.SMS.View.UserControls.ReciveSMSList_UC SPU = new MKH.SMS.View.UserControls.ReciveSMSList_UC();
            TabControlMain.AddTabToTabControl(SPU.Name, SPU.Tag.ToString(), SPU);
        }


        private void buttonItemSendSMS_Click(object sender, EventArgs e)
        {
            ViewModel.PublicClass.FillForSMS();

            MKH.SMS.View.UserControls.SendSMSList_UC SPU = new MKH.SMS.View.UserControls.SendSMSList_UC();
            TabControlMain.AddTabToTabControl(SPU.Name, SPU.Tag.ToString(), SPU);
        }


        private void buttonItemVisitHealthCareBimeh_Click(object sender, EventArgs e)
        {
            MainForms.VisitHealthCare.VisitHealthCarePaymentBimeh_UC SPU = new MainForms.VisitHealthCare.VisitHealthCarePaymentBimeh_UC();
            TabControlMain.AddTabToTabControl(SPU.Name, SPU.Tag.ToString(), SPU);
        }

        private void buttonItemVisitPatientCareBimeh_Click(object sender, EventArgs e)
        {
            MainForms.VisitPatientCare.VisitPatientCarePaymentBimeh_UC SPU = new MainForms.VisitPatientCare.VisitPatientCarePaymentBimeh_UC();
            TabControlMain.AddTabToTabControl(SPU.Name, SPU.Tag.ToString(), SPU);
        }

        private void buttonItemVisitPatient_Click(object sender, EventArgs e)
        {
            MainForms.VisitPatient.VisitPatient_UC SPU = new MainForms.VisitPatient.VisitPatient_UC();
            TabControlMain.AddTabToTabControl(SPU.Name+"Visit", SPU.Tag.ToString(), SPU);
        }

        private void buttonItemVisitPatientBimeh_Click(object sender, EventArgs e)
        {
            MainForms.VisitPatient.VisitPatientPaymentBimeh_UC SPU = new MainForms.VisitPatient.VisitPatientPaymentBimeh_UC();
            TabControlMain.AddTabToTabControl(SPU.Name, SPU.Tag.ToString(), SPU);
        }

        private void buttonItemVisitPatientPayment_Click(object sender, EventArgs e)
        {
            MainForms.VisitPatient.VisitPatientPayment_UC SPU = new MainForms.VisitPatient.VisitPatientPayment_UC();
            TabControlMain.AddTabToTabControl(SPU.Name, SPU.Tag.ToString(), SPU);
        }

        #endregion


      
        #region setting
        private void buttonItemRestore_Click(object sender, EventArgs e)
        {
            if (MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation, true, "آیا نسبت به عمل بازیابی مطمئنید؟"))
                PhysiotherapyCare.Other.Class.Function_Cls.Restore_Func(false);
        }

        private void buttonItemBackUp_Click(object sender, EventArgs e)
        {
            PhysiotherapyCare.Other.Class.Function_Cls.Func_CallTheBackUp();
        }

        private void buttonItemSetting_Click(object sender, EventArgs e)
        {
            PhysiotherapyCare.Other.Forms.Setting_frm Sf = new PhysiotherapyCare.Other.Forms.Setting_frm();
            Sf.treeView_Setting.SelectedNode = Sf.treeView_Setting.Nodes[0];
            Sf.ShowDialog();
        }

        private void buttonItemUsers_Click(object sender, EventArgs e)
        {
            MKH.Permission.View.UserControls.Users_UC SPU = new MKH.Permission.View.UserControls.Users_UC();
            TabControlMain.AddTabToTabControl(SPU.Name, SPU.Tag.ToString(), SPU);
        }

        private void buttonItemChangePass_Click(object sender, EventArgs e)
        {
            MKH.Permission.View.Security.MSSGetChangePass_Cls LoginClass = new MKH.Permission.View.Security.MSSGetChangePass_Cls();
            try
            {
                LoginClass.GetChangePassword();
            }
            catch (Exception ex)
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "خطا", "خطای " + ex.Message);
            }
        }

        #endregion


        #region report
        private void buttonItemRepPhysiotherapy_Click(object sender, EventArgs e)
        {
            MainForms.VisitPatientPhysiotherapy.VisitPatientPhysiotherapyPayment_UC SPU = new MainForms.VisitPatientPhysiotherapy.VisitPatientPhysiotherapyPayment_UC();
            TabControlMain.AddTabToTabControl(SPU.Name, SPU.Tag.ToString(), SPU);
        }

        private void buttonItemRepCare_Click(object sender, EventArgs e)
        {
            MainForms.VisitPatientCare.VisitPatientCarePayment_UC SPU = new MainForms.VisitPatientCare.VisitPatientCarePayment_UC();
            TabControlMain.AddTabToTabControl(SPU.Name, SPU.Tag.ToString(), SPU);
        }

        private void buttonItemVisitHealthCarePayment_Click(object sender, EventArgs e)
        {
            MainForms.VisitHealthCare.VisitHealthCarePayment_UC SPU = new MainForms.VisitHealthCare.VisitHealthCarePayment_UC();
            TabControlMain.AddTabToTabControl(SPU.Name, SPU.Tag.ToString(), SPU);
        }


        private void buttonItemCareRep_Click(object sender, EventArgs e)
        {
            PhysiotherapyCare.Report.VisitPatientCare.VisitPatientCareRep_frm SS = new Report.VisitPatientCare.VisitPatientCareRep_frm();
            SS.ShowDialog();
        }

        private void buttonItemRepPhysioterapy_Click(object sender, EventArgs e)
        {
            PhysiotherapyCare.Report.VisitPatientPhysiotherapy.VisitPatientPhysiotherapyRep_frm SS = new Report.VisitPatientPhysiotherapy.VisitPatientPhysiotherapyRep_frm();
            SS.ShowDialog();
        }

        private void buttonItemRepHealth_Click(object sender, EventArgs e)
        {
            PhysiotherapyCare.Report.VisitHealthCare.VisitHealthCareRep_frm SS = new Report.VisitHealthCare.VisitHealthCareRep_frm();
            SS.ShowDialog();
        }

        private void buttonItemRepVisitPatient_Click(object sender, EventArgs e)
        {
            PhysiotherapyCare.Report.VisitPatient.VisitPatientRep_frm SS = new Report.VisitPatient.VisitPatientRep_frm();
            SS.ShowDialog();
        }
        
        #endregion

        private void buttonItemMap_Click(object sender, EventArgs e)
        {
            PhysiotherapyCare.Other.Forms.SearchInternet_frm SS = new Other.Forms.SearchInternet_frm();
            SS.ShowDialog();
        }

        



    }
}
