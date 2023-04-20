using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MKH.Library.Clasess.FilterClass;

namespace MKH.Library.UserControls
{
    public partial class MSSSearch_UC : UserControl
    {
        public bool SaveResult = true;
        public string MessageResultStateDrugs = "";


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

        QueryFilter.ExpressionBuilder.Filter _thisFilter = new QueryFilter.ExpressionBuilder.Filter();
        public MSSSearch_UC(MKH.Library.Control.MSSGridexView GridViewEnter, QueryFilter.ExpressionBuilder.Filter ThisFilter)
        {
            InitializeComponent();
            
            this.GridViewSet = GridViewEnter;

            SetColumnList();
            
            _thisFilter = ThisFilter;
            comboBoxAndOr.SelectedIndex = 1;
            SetComponentFilter();
        }

        private void SetComponentFilter()
        {
            if (_thisFilter == null) return;

            ComboBoxFieldList.SelectedValue = _thisFilter.PropertyName;
            ComboBoxIf.SelectedIndex = (int)_thisFilter.Operation;
            TextBoxStrSearch.Text = _thisFilter.Value.ToString();
            comboBoxAndOr.SelectedIndex = (int)_thisFilter.OperationFilter;
        }

        List<Tuple<string, string, Type>> lm = new List<Tuple<string,string,Type>>();
        private void SetColumnList()
        {
            ComboBoxFieldList.Items.Clear();
            lm.Clear();

            Dictionary<string, string> k = new Dictionary<string, string>();
            foreach (Janus.Windows.GridEX.GridEXColumn item in _grid.RootTable.Columns)
            {
                if (item.Tag != null) continue;
                k.Add(item.Key, item.Caption);
                lm.Add(new Tuple<string, string, Type>(item.Key, item.Caption, item.Type));
            }
            ComboBoxFieldList.DisplayMember = "Value";
            ComboBoxFieldList.ValueMember = "Key";
            
            ComboBoxFieldList.DataSource = (from l in k.ToList() select new { l.Key, l.Value }).ToList();
            

            //foreach (System.Windows.Forms.ComboBox.ObjectCollection item in ComboBoxFieldList.Items)
            //    (item as DevComponents.Editors.ComboItem).TextAlignment = StringAlignment.Center;
        }


        public void save(ref QueryFilter.ExpressionBuilder.Filter thisfilter)
        {
            if ((TextBoxStrSearch.Visible && (TextBoxStrSearch.Text == "" || ComboBoxIf.SelectedIndex == -1 || comboBoxAndOr.SelectedIndex == -1 || ComboBoxFieldList.Text == "")) ||
                (IntBoxSearch.Visible && (IntBoxSearch.Text == "0" || ComboBoxIf.SelectedIndex == -1 || comboBoxAndOr.SelectedIndex == -1 || ComboBoxFieldList.Text == "")) ||
                (DatePickerSearch.Visible && (ComboBoxIf.SelectedIndex == -1 || comboBoxAndOr.SelectedIndex == -1 || ComboBoxFieldList.Text == "")) 
                )
            {
                SaveResult = false;
                MessageResultStateDrugs = "تمامی موارد را وارد نمایید";
                return;
            }
            try
            {
                SaveResult = true;
                _thisFilter = new QueryFilter.ExpressionBuilder.Filter();
                _thisFilter.PropertyName = ComboBoxFieldList.SelectedValue.ToString();
                _thisFilter.Operation = (QueryFilter.ExpressionBuilder.Op)ComboBoxIf.SelectedIndex;
                foreach (Tuple<string,string,Type> oo in lm)
                    if (oo.Item1 == _thisFilter.PropertyName)
                    {
                        if(TextBoxStrSearch.Visible)
                            _thisFilter.Value = Convert.ChangeType(TextBoxStrSearch.Text, oo.Item3);
                        else if (DatePickerSearch.Visible)
                            _thisFilter.Value = Convert.ChangeType(DatePickerSearch.Value.ToString().Substring(0,10), oo.Item3);
                        else if (IntBoxSearch.Visible)
                            _thisFilter.Value = Convert.ChangeType(IntBoxSearch.Value.ToString(), oo.Item3);
                        break;
                    }

                _thisFilter.OperationFilter = (QueryFilter.ExpressionBuilder.OpFilter)comboBoxAndOr.SelectedIndex;
                thisfilter =  _thisFilter;
            }
            catch (Exception ex)
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View(ex.Message, MKH.Library.Clasess.MSSMessage.MessageType.SError);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void ComboBoxFieldList_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (Tuple<string, string, Type> oo in lm)
                    if (oo.Item1 == ComboBoxFieldList.SelectedValue.ToString())
                    {
                        IntBoxSearch.Visible = false; TextBoxStrSearch.Visible = false; DatePickerSearch.Visible = false;
                        TextBoxStrSearch.Visible = oo.Item3.Name == "String" && !oo.Item1.Contains("Date");
                        DatePickerSearch.Visible = oo.Item3.Name == "String" && oo.Item1.Contains("Date") || oo.Item3.Name == "DateTime" && oo.Item1.Contains("Date");
                        if (oo.Item3.Name == "Int16" || oo.Item3.Name == "Int32" || oo.Item3.Name == "Byte")
                        {
                            IntBoxSearch.Visible = true;
                            IntBoxSearch.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int32;
                        }
                        if (oo.Item3.Name == "Double" || oo.Item3.Name == "Decimal")
                        {
                            IntBoxSearch.Visible = true;
                            IntBoxSearch.ValueType = Janus.Windows.GridEX.NumericEditValueType.Double;
                        }
                        if (!TextBoxStrSearch.Visible)
                            TextBoxStrSearch.Visible = !DatePickerSearch.Visible && !IntBoxSearch.Visible;
                        break;
                    }
            }
            catch { }
        }

       

    }
}
