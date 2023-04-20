﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using MKH.Library.Clasess;
using PhysiotherapyCare.Model.VisitPatient;
using MKH.Library.Clasess.FilterClass;

namespace PhysiotherapyCare.View.MainForms.VisitPatient
{
    public partial class DrugAdd_Frm : MKH.Library.Forms.MSSBaseNew_frm
    {

        private long _id = 0;
        private long _visitpatient_Id = 0;
        private bool _editIns = false;
        private string str = "";

        public DrugAdd_Frm()
        {
            InitializeComponent();
        }


        public DrugAdd_Frm(long VisitPatient_Id, string EmptyStr)
        {
            InitializeComponent();
            _visitpatient_Id = VisitPatient_Id;
            string str = "";
        }

        public DrugAdd_Frm(long Id)
        {
            InitializeComponent();
            _id = Id;
            _editIns = true;
        }

        private void VisitHealthCareAdd_Frm_Load(object sender, EventArgs e)
        {
            //if (_editIns)
            fillControl();
        }

        private void fillControl()
        {
            FillTableLayoutPanel(_id);
        }

        private void FillTableLayoutPanel(long Id)
        {
            try
            {
                int i = 0;
                var collation = new ViewModel.VisitPatient.DrugVisitPatient().GetAllList(ref str).Where(d => d.VisitPatient_Id == _visitpatient_Id);
                foreach (var item in collation)
                {
                    DrugVisitPatient_UC smsp = new DrugVisitPatient_UC(Convert.ToInt32(item.VisitPatient_Id), Convert.ToInt32(item.Drug_Id), item.Id);
                    smsp.Tag = item.Drug_Id;
                    smsp.Controls.Owner.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                    tableLayoutPanelNews.Controls.Add(smsp, 1, ++i);
                }

            }
            catch (Exception ex)
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, ex.Message);
            }
            SetRowTableSet();
        }

        public void SetRowTableSet()
        {
            int tableLayoutPanelRowCnt = 0;
            int SumServiceHealthCare = 0;

            foreach (Control fg in tableLayoutPanelNews.Controls)
                if ((fg as DrugVisitPatient_UC).Visible)
                {
                    (fg as DrugVisitPatient_UC).setRowNo(++tableLayoutPanelRowCnt);
                }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckValidation())
                return;
            try
            {
                SaveParametersUsercontrols(_visitpatient_Id);
                if (str != "")
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MSSMessage.MessageType.SError, false, "اشکال اطلاعات", str);
                else
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View("اطلاعات ذخیره شد", MKH.Library.Clasess.MSSMessage.MessageType.SInformation);
                    DialogResult = System.Windows.Forms.DialogResult.OK;

                    Close();
                }
            }
            catch (Exception ex)
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "اشکال در ذخیره اطلاعات", ex.Message);
            }
        }

        private bool CheckParametersUsercontrols()
        {
            foreach (Control fg in tableLayoutPanelNews.Controls)
            {
                if ((fg as DrugVisitPatient_UC).Visible)
                    if (!(fg as DrugVisitPatient_UC).CheckvalidationUC())
                        return false;
            }
            return true;
        }
        private void SaveParametersUsercontrols(long VisitPatient_Id)
        {
            string str = "";
            new ViewModel.VisitPatient.DrugVisitPatient().VisitPatientWithDrugVisitPatientDelete(VisitPatient_Id, ref str);
            foreach (Control fg in tableLayoutPanelNews.Controls)
            {
                if ((fg as DrugVisitPatient_UC).Visible)
                    (fg as DrugVisitPatient_UC).save(VisitPatient_Id);
            }
        }



        private bool CheckValidation()
        {
            if (!CheckParametersUsercontrols())
            {
                return false;
            }
            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAddNews_Click(object sender, EventArgs e)
        {
            try
            {
                string Str = "";

                MKH.Library.Forms.MSSSelectorMulti_frm ctrl = new MKH.Library.Forms.MSSSelectorMulti_frm();
                ctrl.DataListMulti = MKH.Library.Clasess.PublicClass.ToDataTable<Model.VisitPatient.VW_Drug>(new ViewModel.VisitPatient.Drug().GetAllList(ref Str));
                for (int i = 0; i < ctrl.DataListMulti.Columns.Count; i++)
                {
                    if (ctrl.DataListMulti.Columns[i].ColumnName == "Id") ctrl.DataListMulti.Columns[i].Caption = "کد";
                    if (ctrl.DataListMulti.Columns[i].ColumnName == "TitleName") ctrl.DataListMulti.Columns[i].Caption = "عنوان دارو";
               }

                
                if (ctrl.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    foreach (DataRow row in ctrl.DataListMultiOut.Rows)
                    {
                        DrugVisitPatient_UC SSUC = new DrugVisitPatient_UC();

                        SSUC.TextBoxTitleName.Tag = row[0].ToString();
                        SSUC.TextBoxTitleName.Text = row[1].ToString();


                        SSUC.Controls.Owner.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                        tableLayoutPanelNews.Controls.Add(SSUC, 1, tableLayoutPanelNews.Controls.Count + 1);
                    }
                }
            }
            catch { }

            SetRowTableSet();
        }

      
    }
}