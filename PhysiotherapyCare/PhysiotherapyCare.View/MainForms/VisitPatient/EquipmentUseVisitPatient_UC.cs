using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MKH.Library.Clasess.FilterClass;
using PhysiotherapyCare.Model.VisitPatient;

namespace PhysiotherapyCare.View.MainForms.VisitPatient
{
    public partial class EquipmentUseVisitPatient_UC : UserControl
    {
        public bool SaveResult = true;
        public string MessageResultEquipmentUseDetailDetail = "";

        long _visitpatient_Id = 0;
        int _drug_Id = 0;
        long _Id = 0;
        string str = "";


        public EquipmentUseVisitPatient_UC(long VisitPatient_Id, int Drug_Id, long Id)
        {
            InitializeComponent();

            _visitpatient_Id = VisitPatient_Id;
            _drug_Id = Drug_Id;
            _Id = Id;



            ViewModel.VisitPatient.EquipmentUseVisitPatient RN = new ViewModel.VisitPatient.EquipmentUseVisitPatient();
            List<VW_EquipmentUseVisitPatient> U = RN.GetAllListByDetailRow(Id, ref str);

            TextBoxTitleName.Text = U[0].EquipmentUseName;
            TextBoxTitleName.Tag = U[0].EquipmentUse_Id;
            IntBoxFew.Value = int.Parse(U[0].Few.ToString());
            TextBoxDiscription.Text = U[0].Description;

        }

        public EquipmentUseVisitPatient_UC()
        {
            InitializeComponent();
        }


        public bool CheckvalidationUC()
        {
            if (TextBoxTitleName.Text == "")
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("ردیف ( " + LabelRow.Text + ") عنوان تجهیزات مصرفی را وارد نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SError);
                return false;
            }

            if (IntBoxFew.Text == "0" || IntBoxFew.Text.Trim().Length == 0)
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("ردیف ( " + LabelRow.Text + ") تعداد تجهیزات مصرفی را وارد نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SError);
                return false;
            }

            //if (TextBoxDiscription.Text.Trim().Length == 0 || TextBoxDiscription.Text == "")
            //{
            //    MKH.Library.Clasess.MSSMessage.MSSMessage_View("ردیف ( " + LabelRow.Text + ") توضیحات را وارد نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SError);
            //    return false;
            //}
            return true;
        }

        public void save(long VisitPationt_Id)
        {
            try
            {
                long? f = 0;

                List<TBL_EquipmentUseVisitPatient> Ls = new List<TBL_EquipmentUseVisitPatient>(1);
                TBL_EquipmentUseVisitPatient EquipmentUseVisitPatient = new TBL_EquipmentUseVisitPatient();

                EquipmentUseVisitPatient.EquipmentUse_Id = TextBoxTitleName.Tag.ToString().ToInt();
                EquipmentUseVisitPatient.VisitPatient_Id = VisitPationt_Id;
                EquipmentUseVisitPatient.Few = int.Parse(IntBoxFew.Value.ToString());
                EquipmentUseVisitPatient.Description = TextBoxDiscription.Text.ToString();


                Ls.Add(EquipmentUseVisitPatient);

                new ViewModel.VisitPatient.EquipmentUseVisitPatient().InsertEntity(Ls, ref str, ref f);
                SaveResult = true;
            }
            catch (Exception ex)
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View(ex.Message, MKH.Library.Clasess.MSSMessage.MessageType.SError);
                SaveResult = false;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation, true, "آیا مایلید ردیف حذف شود؟"))
                this.Visible = false;
        }

        public void setRowNo(int RowNo)
        {
            LabelRow.Text = RowNo.ToString();
        }

        private void buttonServiceTypeDsc_Click(object sender, EventArgs e)
        {
            try
            {
                string StrSet = "";
                Dictionary<string, string> SD = new Dictionary<string, string>();
                Dictionary<string, string> SD1 = new Dictionary<string, string>();

                foreach (var item in new ViewModel.VisitPatient.EquipmentUse().GetAllList(ref StrSet))
                    SD.Add(item.Id.ToString(), item.TitleName);

                SD1 = MKH.Library.Forms.MSSSelector_frm.SetDataSelect(SD);
                TextBoxTitleName.Tag = SD1.Keys.ToList()[0];
                TextBoxTitleName.Text = SD1.Values.ToList()[0];
               
            }
            catch { }
        }

    }
}
