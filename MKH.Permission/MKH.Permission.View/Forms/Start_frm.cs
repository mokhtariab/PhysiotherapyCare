using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Win32;
using System.Configuration;
using System.Management;
using System.Collections.Generic;
using System.Drawing;
using MKH.Permission.ViewModel.Security;

namespace MKH.Permission.View.Forms
{
    public partial class Start_frm : Form
    {
        
        
        #region Constructor
        public Start_frm(MSSPolicySystem_cls passPlcy, int SoftwareId)
        {
            InitializeComponent();
            _passPlcy = passPlcy;
            _softwareId = SoftwareId;

        }
        #endregion


        private void Start_frm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Escape))
                this.Close();
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                btnOk_Click(this, null);
        }

        private void Start_frm_Load(object sender, EventArgs e)
        {
            SetLanguageProgram();
        }

        private void SetLanguageProgram()
        {
            InputLanguage lang = GetFarsiLanguage();
            if (lang == null)
                throw new NotSupportedException("Farsi Language keyboard is not installed.");
            InputLanguage.CurrentInputLanguage = lang;
        }

        private InputLanguage GetFarsiLanguage()
        {
            foreach (InputLanguage lang in InputLanguage.InstalledInputLanguages)
            {
                if ((lang.LayoutName.ToLower() == "farsi") | (lang.LayoutName == "Persian"))
                    return lang;
            }
            return null;
        }

        private MSSPolicySystem_cls _passPlcy;
        private int _softwareId;

        private void btnOk_Click(object sender, EventArgs e)
        {
            bool UserOrPass = true;
            string messageError = _passPlcy.CheckAuthentication(txtUserLogin.Text, txtPassword.Text, _softwareId, ref UserOrPass);

            if (String.IsNullOrEmpty(messageError))
            {
                //if (_passPlcy.GetAccessibleResourceIds(txtUserLogin.Text))
                //{
                this.DialogResult = DialogResult.OK;
                ClosePage();
                //}
                //else
                //{
                //MKH.Library.Clasess.MSSMessage.MSSMessage_View("امکان دسترسی به این نرم افزار برای شما وجود ندارد", MKH.Library.Clasess.MSSMessage.MessageType.SError);
                //}
            }
            else
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SError, false, messageError);
                if (UserOrPass) txtUserLogin.Focus(); else txtPassword.Focus();
            }
        }

        private void ClosePage()
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClosePage();
        }



    }
}
