  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace PhysiotherapyCare.ViewModel
{
    public class PublicClass 
    {
       
        #region Constructor

        public PublicClass()
        {

        }
        #endregion

        #region Properties
        public static void FillForSMS()
        {
            try
            {
                MKH.Library.Clasess.PublicClass.ListAllPersonForSMS = new List<MKH.Library.Clasess.PublicClass.AllPersonForSMS>();

                string str = "";

                foreach (Model.Doctors.VW_Doctor item in new ViewModel.Doctors.Doctor().GetAllList(ref str).Where(dd => dd.Mobile != null && dd.Mobile.Trim().StartsWith("09")).ToList())
                    MKH.Library.Clasess.PublicClass.ListAllPersonForSMS.Add(new MKH.Library.Clasess.PublicClass.AllPersonForSMS() { PersonNameFamily = item.DoctorName + " " + item.DoctorFamily, JobType = item.DoctorTypeTitleName, MobileNo1 = item.Mobile, MobileNo2 = item.TelBusiness + " " + item.TelHome });

                foreach (Model.Patient.VW_Patient item in new ViewModel.Patient.Patient().GetAllList(ref str).Where(dd => (dd.Mobile != null && dd.Mobile.Trim().StartsWith("09")) ||(dd.Mobile2 != null && dd.Mobile2.Trim().StartsWith("09"))).ToList())
                    MKH.Library.Clasess.PublicClass.ListAllPersonForSMS.Add(new MKH.Library.Clasess.PublicClass.AllPersonForSMS() { PersonNameFamily = item.PatientName + " " + item.PatientFamily, JobType = "بیمار", MobileNo1 = item.Mobile ?? item.Mobile2, MobileNo2 = item.TelBusiness + " " + item.TelHome });

                var mmf = new ViewModel.VisitPatientCare.VisitPatientCare().GetAllList(ref str).Where(dd => dd.Mobile != null && dd.CarrierMobile.StartsWith("09")).Select(df => new { df.CarrierName, df.CarrierFamily, df.CarrierMobile }).Distinct().ToList();//, df.CarrierTelHome 
                foreach (var item in mmf)
                    MKH.Library.Clasess.PublicClass.ListAllPersonForSMS.Add(new MKH.Library.Clasess.PublicClass.AllPersonForSMS() { PersonNameFamily = item.CarrierName + " " + item.CarrierFamily, JobType = "مراقب", MobileNo1 = item.CarrierMobile, MobileNo2 = "" });

                foreach (MKH.Contacts.Model.PersonTelMob.VW_PersonTelMob item in new MKH.Contacts.ViewModel.PersonTelMob.PersonTelMob().GetAllList(ref str).Where(dd => (dd.Mobile != null && dd.Mobile.StartsWith("09")) || (dd.Mobile2 != null && dd.Mobile2.StartsWith("09"))))
                    MKH.Library.Clasess.PublicClass.ListAllPersonForSMS.Add(new MKH.Library.Clasess.PublicClass.AllPersonForSMS() { PersonNameFamily = item.FirstName + " " + item.LastName, JobType = item.GroupName, MobileNo1 = item.Mobile ?? item.Mobile2, MobileNo2 = item.Mobile2 + " " + item.TelHome + " " + item.TelBusiness });
            }
            catch { }

        }

        
        #endregion

      
    }
}
