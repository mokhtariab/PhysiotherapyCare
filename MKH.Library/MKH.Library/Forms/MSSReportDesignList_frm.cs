using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace MKH.Library.Forms
{
    public partial class MSSReportDesignList_frm : Form
    {
        public DataTable DataRelationNew;
        public DataTable DataRelationNewSlave;
        //public List<object> DataRelationNew;
        public string NameForDB;
        public string NameForDBSlave;
        public string _reportName;

        public MSSReportDesignList_frm(string ReportName)
        {
            InitializeComponent();
            _reportName = ReportName;
        }

        private void MSSReportDesignList_frm_Load(object sender, EventArgs e)
        {
            ReadFromXmlFiles();
            comboBoxDesignReportListBind();
            buttonAdd.Enabled = Library.Clasess.PublicParam.MSSReportDesignListbuttonAddPermission;
            ButtonEdit.Enabled = Library.Clasess.PublicParam.MSSReportDesignListbuttonEditPermission;
            buttonDel.Enabled = Library.Clasess.PublicParam.MSSReportDesignListbuttonDelPermission;
        }


        public class ReportDesignerClass
        {
            [XmlElement("ReportDesignName")]
            public String ReportDesignName { get; set; }

            [XmlElement("DesignSetForm")]
            public String DesignSetForm { get; set; }

            [XmlElement("ReportDesignAddress")]
            public string ReportDesignAddress { get; set; }

        }

        List<ReportDesignerClass> ListReportDesigner = new List<ReportDesignerClass>();
        public void ReadFromXmlFiles()
        {
            if (File.Exists(Library.Clasess.PublicParam.AddressReportDesign + "\\Report\\ReportDesignList" + _reportName + ".xml"))
            {
                using (var reader = new StreamReader(Library.Clasess.PublicParam.AddressReportDesign + "\\Report\\ReportDesignList" + _reportName + ".xml"))
                {
                    XmlSerializer deserializer = new XmlSerializer(typeof(List<ReportDesignerClass>), new XmlRootAttribute(_reportName));
                    try { ListReportDesigner = (List<ReportDesignerClass>)deserializer.Deserialize(reader); }
                    catch { }
                }
            }
        }


        public void WriteToXmlFiles()
        {
            if (!Directory.Exists(Library.Clasess.PublicParam.AddressReportDesign + "\\Report"))
                Directory.CreateDirectory(Library.Clasess.PublicParam.AddressReportDesign + "\\Report");

            using (var writer = new FileStream(Library.Clasess.PublicParam.AddressReportDesign + "\\Report\\ReportDesignList" + _reportName + ".xml", FileMode.Create))
            {
                XmlSerializer ser = new XmlSerializer(typeof(List<ReportDesignerClass>),
                    new XmlRootAttribute(_reportName));
                ser.Serialize(writer, ListReportDesigner);
            }
        }

        public void comboBoxDesignReportListBind()
        {
            comboBoxDesignReportList.DisplayMember = "ReportDesignName";
            comboBoxDesignReportList.ValueMember = "ReportDesignAddress";
            comboBoxDesignReportList.DataSource = ListReportDesigner.Where(o => o.DesignSetForm == _reportName).ToList();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("نام گذاری",
                       "عنوان",
                       "",
                       400,
                       300);
            if (input == "") 
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("لطفا عنوان طراحی گزارش را وارد نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SWarning);
                return;
            }

            if (ListReportDesigner.Where(o => o.ReportDesignName == input).Count() > 0)
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("عنوان طراحی گزارش تکراری است", MKH.Library.Clasess.MSSMessage.MessageType.SWarning);
                return;
            }

            string str = "";
            FastReport.Report rpt = new FastReport.Report();
            int CountList = ListReportDesigner.Count();
            if (CountList > 0)
            {
                str = ListReportDesigner.Last().ReportDesignAddress;
                str = str.Substring((Library.Clasess.PublicParam.AddressReportDesign + @"Report\" + _reportName).Length, str.IndexOf(".frx") - (Library.Clasess.PublicParam.AddressReportDesign + @"Report\" + _reportName).Length);
                File.Copy(Library.Clasess.PublicParam.AddressReportDesign + @"Report\" + _reportName + str + ".frx", Library.Clasess.PublicParam.AddressReportDesign + @"Report\" + _reportName + (str.ToInt() + 1).ToString() + ".frx", true);
            }
            else
                File.Copy(Library.Clasess.PublicParam.AddressReportDesign + @"\Report\Template.frx", Library.Clasess.PublicParam.AddressReportDesign + @"Report\" + _reportName + (++CountList) + ".frx", true);

            string NewAddress = (Library.Clasess.PublicParam.AddressReportDesign + @"Report\" + _reportName + (str.ToInt() + 1).ToString() + ".frx").ToString();
            rpt.Load(NewAddress);

            rpt.RegisterData(DataRelationNew, NameForDB);
            rpt.GetDataSource(NameForDB).Enabled = true;

            if (DataRelationNewSlave != null)
            {
                rpt.RegisterData(DataRelationNewSlave, NameForDBSlave);
                rpt.GetDataSource(NameForDBSlave).Enabled = true;
            }

            try
            {
                rpt.Parameters[0].Value = mssTextBox1.Text;
                rpt.Parameters[1].Value = mssTextBox2.Text;
                rpt.Parameters[2].Value = mssTextBox3.Text;
            }
            catch { }

            rpt.Design();

            ListReportDesigner.Add(new ReportDesignerClass { DesignSetForm = _reportName, ReportDesignName = input, ReportDesignAddress = NewAddress });
            WriteToXmlFiles();
            comboBoxDesignReportListBind();
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("نام گذاری",
                       "عنوان",
                       comboBoxDesignReportList.Text,
                       400,
                       300);
            if (input == "")
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View("لطفا عنوان طراحی گزارش را وارد نمایید", MKH.Library.Clasess.MSSMessage.MessageType.SWarning);
                return;
            }


            FastReport.Report rpt = new FastReport.Report();

            //rpt.Load(comboBoxDesignReportList.SelectedValue.ToString());
            if (File.Exists(comboBoxDesignReportList.SelectedValue.ToString()))
            {
                rpt.Load(comboBoxDesignReportList.SelectedValue.ToString());
            }
            else
            {
                string sst = comboBoxDesignReportList.SelectedValue.ToString();
                rpt.Load(Library.Clasess.PublicParam.AddressReportDesign + sst.Substring(sst.IndexOf("\\Report\\" + _reportName), sst.Length - sst.IndexOf("\\Report\\" + _reportName)));
            }

            rpt.RegisterData(DataRelationNew, NameForDB);
            rpt.GetDataSource(NameForDB).Enabled = true;

            if (DataRelationNewSlave != null)
            {
                rpt.RegisterData(DataRelationNewSlave, NameForDBSlave);
                rpt.GetDataSource(NameForDBSlave).Enabled = true;
            }

            try
            {
                rpt.Parameters[0].Value = mssTextBox1.Text;
                rpt.Parameters[1].Value = mssTextBox2.Text;
                rpt.Parameters[2].Value = mssTextBox3.Text;
            }
            catch { }

            rpt.Design();

            try
            {
                ListReportDesigner.First(l => l.ReportDesignAddress == comboBoxDesignReportList.SelectedValue.ToString()).ReportDesignName = input;
                WriteToXmlFiles();
                comboBoxDesignReportListBind();
            }
            catch { }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (!MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation, true, "آیا به حذف این طراحی گزارش اطمینان دارید؟")) return;

            bool bit = ListReportDesigner.Remove(new ReportDesignerClass { DesignSetForm = _reportName, ReportDesignName = comboBoxDesignReportList.Text, ReportDesignAddress = comboBoxDesignReportList.SelectedValue.ToString() });
            ListReportDesigner.RemoveAt(comboBoxDesignReportList.SelectedIndex);

            WriteToXmlFiles();
            comboBoxDesignReportListBind();
        }

        private void ButtonPrint_Click(object sender, EventArgs e)
        {
            FastReport.Report rpt = new FastReport.Report();

            if (File.Exists(comboBoxDesignReportList.SelectedValue.ToString()))
            {
                rpt.Load(comboBoxDesignReportList.SelectedValue.ToString());
            }
            else
            {
                string sst = comboBoxDesignReportList.SelectedValue.ToString();
                rpt.Load(Library.Clasess.PublicParam.AddressReportDesign + sst.Substring(sst.IndexOf("\\Report\\" + _reportName), sst.Length - sst.IndexOf("\\Report\\" + _reportName)));
            }

            rpt.RegisterData(DataRelationNew, NameForDB);
            rpt.GetDataSource(NameForDB).Enabled = true;
            
            if (DataRelationNewSlave != null)
            {
                rpt.RegisterData(DataRelationNewSlave, NameForDBSlave);
                rpt.GetDataSource(NameForDBSlave).Enabled = true;
            }

            try
            {
                rpt.Parameters[0].Value = mssTextBox1.Text;
                rpt.Parameters[1].Value = mssTextBox2.Text;
                rpt.Parameters[2].Value = mssTextBox3.Text;
            }
            catch { }

            rpt.Show();
        }

       


    }
}
