using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace MKH.Library.UserControls
{
    public partial class MSSColumnSelector_UC : UserControl
    {
        public MKH.Library.Control.MSSGridexView _grid;
        [System.ComponentModel.DefaultValue(typeof(MKH.Library.Control.MSSGridexView), "(none)")]
        public MKH.Library.Control.MSSGridexView GridViewSet
        {
            get
            {
                if (_grid == null) return null;
                return _grid;
            }
            set
            {
                _grid = value;
            }
        }

        public MSSColumnSelector_UC(MKH.Library.Control.MSSGridexView GridViewEnter)
        {
            InitializeComponent();
            this.GridViewSet = GridViewEnter;
        }

        string DefaulSettingsKey = "";
        private void MSSColumnSelector_UC_Load(object sender, EventArgs e)
        {
            DefaulSettingsKey = _grid.SettingsKey + (new Random().NextDouble()).ToString();
            _grid.SaveSettings = true;
            ReadFromXmlFiles();
            CreateCheckBoxFromGrid();
            ComboBoxSelectorBind();
        }

        private void CreateCheckBoxFromGrid()
        {
            itemPanelSelector.Items.Clear();

            foreach (Janus.Windows.GridEX.GridEXColumn item in _grid.RootTable.Columns)
            {
                if (item.Tag == null || item.Tag == "")
                {

                    DevComponents.DotNetBar.CheckBoxItem checkBoxItem = new DevComponents.DotNetBar.CheckBoxItem();
                    checkBoxItem.Name = item.Key;
                    checkBoxItem.Text = item.Caption;
                    checkBoxItem.Checked = true;
                    checkBoxItem.CheckedChanged += checkBoxItem_CheckedChanged;
                    itemPanelSelector.Items.Add(checkBoxItem);
                }
            }
        }

        void checkBoxItem_CheckedChanged(object sender, DevComponents.DotNetBar.CheckBoxChangeEventArgs e)
        {
            _grid.CurrentTable.Columns[(sender as DevComponents.DotNetBar.CheckBoxItem).Name].Visible = e.NewChecked.Checked;

            //if (e.NewChecked.Checked)
            //{
            //    Janus.Windows.GridEX.GridEXColumnSet CS = new Janus.Windows.GridEX.GridEXColumnSet();
            //    CS.HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            //    CS.ColumnCount = 1;
            //    CS.Key = (sender as DevComponents.DotNetBar.CheckBoxItem).Name;
            //    _grid.RootTable.ColumnSets.Add(CS);
            //    CS.Add(_grid.RootTable.Columns[(sender as DevComponents.DotNetBar.CheckBoxItem).Name], 0, 0);
            //}
            //else
            //{
            //    Janus.Windows.GridEX.GridEXColumnSet CS = new Janus.Windows.GridEX.GridEXColumnSet();
            //    CS.HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            //    CS.ColumnCount = 1;
            //    CS.Key = (sender as DevComponents.DotNetBar.CheckBoxItem).Name;
            //    _grid.RootTable.ColumnSets.Remove(CS);
            //    _grid.RootTable.ColumnSets[CS.Key].Remove(_grid.RootTable.Columns[(sender as DevComponents.DotNetBar.CheckBoxItem).Name]);
            //}
        }

       
        public void ComboBoxSelectorBind()
        {
            comboBoxSelector.DataSource = ListColumnSelectors.Select(o => o.SelectorsColumn).Distinct().ToList();

            //comboBoxSelector.DataSource = ListColumnSelectors.Select(o => o.SelectorsColumn).Distinct().ToList();
            //if(comboBoxSelector.SelectedValue == null)
            //{
            //    int ColCount = 0;
            //    foreach (Janus.Windows.GridEX.GridEXColumn item in _grid.RootTable.Columns)
            //        if (item.Tag == null) ColCount += 1;

            //    try
            //    {
            //        //foreach (Janus.Windows.GridEX.GridEXColumnSet item in _grid.RootTable.ColumnSets)
            //        //{
            //            _grid.RootTable.ColumnSets.Clear();
            //        //}
            //    }
            //    catch { }
            //    Janus.Windows.GridEX.GridEXColumnSet CS = null;
            //    _grid.RootTable.ColumnSetRowCount = 1;
            //    foreach (Janus.Windows.GridEX.GridEXColumn item in _grid.RootTable.Columns)
            //    {
            //        CS = new Janus.Windows.GridEX.GridEXColumnSet();
            //        CS.HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            //        CS.ColumnCount = 1;
            //        CS.Key = item.Key;
            //        _grid.RootTable.ColumnSets.Add(CS);
            //        try
            //        {
            //            CS.Add(item, 0, 0);
            //        }
            //        catch { }
            //    }
            //}

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            WriteSave(comboBoxSelector.Text, true);
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            WriteSave(comboBoxSelector.Text, false);
        }
        private void comboBoxSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            try { System.IO.Directory.Delete(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\PhysiotherapyCare", true); }
            catch { }

            ReadList(comboBoxSelector.Text);
        }

        private void ReadList(string ColumnSelectorName)
        {
            // _grid.SaveSettings = false;
            _grid.SettingsKey = ColumnSelectorName;
           // _grid.SaveSettings = true;
            _grid.LoadComponentSettings();

            foreach (DevComponents.DotNetBar.CheckBoxItem item in itemPanelSelector.Items)
                item.Checked = false;

            ColumnSelectorsClass ColumnSelect = new ColumnSelectorsClass();
            foreach (Janus.Windows.GridEX.GridEXColumn item in _grid.RootTable.Columns)
            {
                ColumnSelect = null;
                ColumnSelect = ListColumnSelectors.Find(b => b.SelectorsColumn == ColumnSelectorName && b.NameColumn == item.Key);
                if (ColumnSelect != null)
                {
                    try
                    {
                        (itemPanelSelector.Items[item.Key] as DevComponents.DotNetBar.CheckBoxItem).Checked = true;
                        item.Width = ColumnSelect.WidthColumn;
                    }
                    catch { }
                }
            }
        }


        #region Read&Write ConfigFile & Settings


        public class ColumnSelectorsClass
        {
            [XmlElement("columnselectors")]
            public String SelectorsColumn { get; set; }

            [XmlElement("namecolumn")]
            public String NameColumn { get; set; }

            [XmlElement("widthcolumn")]
            public Int32 WidthColumn { get; set; }

        }

        List<ColumnSelectorsClass> ListColumnSelectors = new List<ColumnSelectorsClass>();
        public void WriteSave(string ColumnSelectorName, bool UpdateOrDel)
        {
            ListColumnSelectors.RemoveAll(k => k.SelectorsColumn == ColumnSelectorName);
            if (UpdateOrDel)
            {
               // _grid.SaveSettings = false;
                _grid.SettingsKey = ColumnSelectorName;
                //_grid.SaveSettings = true;
                _grid.SaveComponentSettings();
                //ListColumnSelectors.Add(new ColumnSelectorsClass { SelectorsColumn = ColumnSelectorName});

                foreach (Janus.Windows.GridEX.GridEXColumn item in _grid.CurrentTable.Columns)
                {
                    if (item.Visible)
                        ListColumnSelectors.Add(new ColumnSelectorsClass { SelectorsColumn = ColumnSelectorName, NameColumn = item.Key, WidthColumn = item.Width });
                }

            }
            WriteToXmlFiles();
            ComboBoxSelectorBind();
        }


        string AddressCloumnSelector = Clasess.PublicParam.AddressReportDesign.Replace("\\Report", "");
        //string AddressCloumnSelector = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\ColumnSelector\\" + _grid.Name + (_grid.Tag ?? 0).ToString() + ".xml");
        public void ReadFromXmlFiles()
        {
            if (File.Exists(AddressCloumnSelector+ "\\ColumnSelector\\" + _grid.Name + (_grid.Tag ?? 0).ToString() + ".xml"))
            {
                using (var reader = new StreamReader(AddressCloumnSelector + "\\ColumnSelector\\" + _grid.Name + (_grid.Tag ?? 0).ToString() + ".xml"))
                {
                    XmlSerializer deserializer = new XmlSerializer(typeof(List<ColumnSelectorsClass>),
                        new XmlRootAttribute("Column_Selector"));
                    ListColumnSelectors = (List<ColumnSelectorsClass>)deserializer.Deserialize(reader);
                }
            }

        }

        public void WriteToXmlFiles()
        {
            if (!Directory.Exists(AddressCloumnSelector + "\\ColumnSelector"))
                Directory.CreateDirectory(AddressCloumnSelector + "\\ColumnSelector");

            using (var writer = new FileStream(AddressCloumnSelector + "\\ColumnSelector\\" + _grid.Name + (_grid.Tag ?? 0).ToString() + ".xml", FileMode.Create))
            {
                XmlSerializer ser = new XmlSerializer(typeof(List<ColumnSelectorsClass>),
                    new XmlRootAttribute("Column_Selector"));
                ser.Serialize(writer, ListColumnSelectors);
            }
        }




        #endregion

        private void ButtonSelect_CheckedChanged(object sender, EventArgs e)
        {
            _grid.SettingsKey = DefaulSettingsKey;
            _grid.LoadComponentSettings();
            try
            {
                foreach (DevComponents.DotNetBar.CheckBoxItem item in itemPanelSelector.Items)
                    item.Checked = ButtonSelect.Checked;
            }
            catch { }
        }

        //private void MSSColumnSelector_UC_FormClosed(object sender, FormClosedEventArgs e)
        //{
        //    _grid.SaveSettings = false;
        //}

    }
}
