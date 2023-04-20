using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MKH.Library.Control
{
    public partial class MSSGridexView : Janus.Windows.GridEX.GridEX
    {
        public List<MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.Filter> FilterList = new List<Clasess.FilterClass.QueryFilter.ExpressionBuilder.Filter>();
        public MSSGridexView()
        {
            InitializeComponent();

            this.AllowDrop = false;
            //this.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            //this.AlternatingColors = true;

            this.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010;
            this.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.Font = new System.Drawing.Font("Tahoma", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));

            this.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            this.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex;

            this.BuiltInTextsData = "<LocalizableData ID='LocalizableStrings' Collection='true'><GroupByBoxInfo>برای گروه بندی اطلاعات فیلد مورد نظرتان را به این محل درگ نمایید</GroupByBoxInfo><RecordNavigator> ردیف | از</RecordNavigator><FilterRowConditionEqual>مساوی</FilterRowConditionEqual><FilterRowConditionNotEqual>مخالف</FilterRowConditionNotEqual><FilterRowConditionGreaterThan>بزرگتر</FilterRowConditionGreaterThan><FilterRowConditionGreaterThanOrEqual>بزرگتر مساوی</FilterRowConditionGreaterThanOrEqual><FilterRowConditionLessThan>کوچکتر</FilterRowConditionLessThan><FilterRowConditionLessThanOrEqual>کوچکتر مساوی</FilterRowConditionLessThanOrEqual><FilterRowConditionContains>شامل</FilterRowConditionContains><FilterRowConditionNotContains>شامل نباشد</FilterRowConditionNotContains><FilterRowConditionEndsWith>از انتها</FilterRowConditionEndsWith><FilterRowConditionBeginsWith>از ابتدا</FilterRowConditionBeginsWith><FilterRowConditionIsEmpty>خالی</FilterRowConditionIsEmpty><FilterRowConditionNotIsEmpty>خالی نباشد</FilterRowConditionNotIsEmpty><FilterRowConditionClear>هیچ</FilterRowConditionClear></LocalizableData>";

            this.CardViewGridlines = Janus.Windows.GridEX.CardViewGridlines.Both;

            this.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.RowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition;
            this.RowHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.AlternatingRowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;

            this.RecordNavigator = true;

            this.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
           // this.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
            this.KeyDown += MSSGridexView_KeyDown;   
        }

        void MSSGridexView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
                this.SelectAll();
        }

        public event EventHandler BindingDataSourceSet;

        public override BindingContext BindingContext
        {
            get
            {
                return base.BindingContext;
            }
            set
            {
                base.BindingContext = value;
                BindingDataSourceSet(this, null);
            }
        }

        protected override void OnDoubleClick(System.EventArgs e)
        {
            base.OnDoubleClick(e);
        }

    }
}
