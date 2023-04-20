using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PhysiotherapyCare.Other.Forms
{
    public partial class RstPass_frm : MKH.Library.Forms.MSSBaseNew_frm
    {
        public RstPass_frm()
        {
            InitializeComponent();
        }
        
        public bool Edit_Enter;
        private void button_OK_Click(object sender, EventArgs e)
        {
            string str = "";
            if (Edit_Enter)
            {
                if (textBox_PrePass.Text != DeCodePassRestore(new ViewModel.Setting.Setting().GetAllValue("BkpRstPssRstrr", ref str)))
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View("رمز قبلی اشتباه می باشد. دوباره آنرا وارد نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SWarning);
                    textBox_PrePass.Focus();
                    return;
                }
                if (textBox_ReNewPass.Text != textBox_NewPass.Text)
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View("رمزی که دوباره وارد شده اشتباه می باشد. دوباره آنرا وارد نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SWarning);
                    textBox_ReNewPass.Focus();
                    return;
                }

               List<Model.Setting.TBL_Setting> ls = new List<Model.Setting.TBL_Setting>();
               ls.Add(new Model.Setting.TBL_Setting(){Name = "BkpRstPssRstrr", value =CodePassRestore(textBox_ReNewPass.Text)});
               new ViewModel.Setting.Setting().UpdateEntity(ls, ref str);
            }
            else 
            {
                if (textBox_Pass.Text == DeCodePassRestore(new ViewModel.Setting.Setting().GetAllValue("BkpRstPssRstrr", ref str)))
                {
                    OpenFileDialog dlg = new OpenFileDialog();
                    dlg.Filter = "All BackUp Files(*.bak)|*.bak";
                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        PhysiotherapyCare.Other.Class.Function_Cls.SetRestoreDBAll(dlg.FileName);
                        //SetDataSet_GridViewFiles();
                    }
                }
                else
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View("رمزی که وارد شده اشتباه می باشد. دوباره آنرا وارد نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SWarning);
                    textBox_Pass.Focus();
                    return;
                }
            }
            Close();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RstPass_frm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape) Close();
        }

        private string CodePassRestore(string PassRst)
        {
            string Result="";
            for (int i=0;i<PassRst.Length;i++) 
                Result += Convert.ToChar(PassRst[i]+'D');
            return Result;
        }

        private string DeCodePassRestore(string PassRst)
        {
            string Result = "";
            for (int i = 0; i < PassRst.Length; i++)
                Result += Convert.ToChar(PassRst[i] - 'D');
            return Result;
        }
    }
}
