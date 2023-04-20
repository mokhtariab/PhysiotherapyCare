using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using PhysiotherapyCare.Model.Basic;


namespace PhysiotherapyCare.View.BaseForms
{
    public partial class LocationPartAdd_Frm : MKH.Library.Forms.MSSBaseNew_frm
    {
        private byte _LocationPartCode = 0;
        private bool _editIns = false;

        public LocationPartAdd_Frm()
        {
            InitializeComponent();
        }

        public LocationPartAdd_Frm(byte LocationPartCode)
        {
            InitializeComponent();
            _LocationPartCode = LocationPartCode;
            string str = "";
            textBoxTitleName.Text = new ViewModel.Basic.LocationPart().GetAllListByID(LocationPartCode, ref str)[0].TitleName;
            _editIns = true;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckValidation())
                return;
            try
            {
                string str = ""; short? idSet = 0;
                List<TBL_LocationPart> Ls = new List<TBL_LocationPart>(1);
                TBL_LocationPart LocationPart = new TBL_LocationPart();
                LocationPart.Id = _LocationPartCode;
                LocationPart.TitleName = textBoxTitleName.Text;
                Ls.Add(LocationPart);

                if (!_editIns)
                {
                    new ViewModel.Basic.LocationPart().InsertEntity(Ls, ref str, ref idSet);
                }
                else
                {
                    new ViewModel.Basic.LocationPart().UpdateEntity(Ls, ref str);
                }

                if (str != "")
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, "اشکال اطلاعات", str);
                else
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View("اطلاعات ذخیره شد", MKH.Library.Clasess.MSSMessage.MessageType.SInformation);
                    DialogResult = System.Windows.Forms.DialogResult.OK;
                    Close();
                }

            }
            catch(Exception ex)
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, ex.Message);
            }

        }


        private bool CheckValidation()
        {
            if (textBoxTitleName.Text.Trim() == "")
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("جای خالی را پر نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SInformation);
                return false;
            }
            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
