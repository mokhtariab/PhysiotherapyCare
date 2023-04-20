using MKH.Library.Clasess.FilterClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MKH.Library.Forms
{
    public partial class MSSSearchPanel_frm : Form
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


        public MSSSearchPanel_frm(MKH.Library.Control.MSSGridexView GridViewEnter)
        {
            InitializeComponent();
            this.GridViewSet = GridViewEnter;
        }


        #region Load
        private void MSSSearchPanel_UC_Load(object sender, EventArgs e)
        {
            FillComponents(_grid.FilterList);
        }

        int i = 0;
        private void FillComponents(List<QueryFilter.ExpressionBuilder.Filter> FilterList)
        {
            try
            {
                i = 0;
                tableLayoutPanelVisit.Controls.Clear();

                foreach (QueryFilter.ExpressionBuilder.Filter fg in FilterList)
                {
                    UserControls.MSSSearch_UC SSUC = new UserControls.MSSSearch_UC(_grid,fg);
                    SSUC.Controls.Owner.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                    tableLayoutPanelVisit.Controls.Add(SSUC, 1, i++);
                }
            }
            catch (Exception ex)
            {
                MKH.Library.Clasess.MSSMessage.MSSMessage_View(ex.Message, Library.Clasess.MSSMessage.MessageType.SError);
            }
        }
        #endregion


        #region Save

        private void buttonOK_Click(object sender, EventArgs e)
        {
            _grid.FilterList.Clear();

            QueryFilter.ExpressionBuilder.Filter _filter = null;
            List<QueryFilter.ExpressionBuilder.Filter> _listFilter = new List<QueryFilter.ExpressionBuilder.Filter>();

            foreach (System.Windows.Forms.Control fg in tableLayoutPanelVisit.Controls)
            {
                if (!fg.Visible) continue;
                _filter = new QueryFilter.ExpressionBuilder.Filter();
                (fg as UserControls.MSSSearch_UC).save(ref _filter);
                if (!(fg as UserControls.MSSSearch_UC).SaveResult)
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View((fg as UserControls.MSSSearch_UC).MessageResultStateDrugs, Library.Clasess.MSSMessage.MessageType.SError);
                    return;
                }
                _listFilter.Add(_filter);
            }
            _grid.FilterList = _listFilter;
            _grid.BindingContext = null;

            Close();
        }


        #endregion

      

        private void buttonAddSearch_Click(object sender, EventArgs e)
        {
            UserControls.MSSSearch_UC SSUC = new UserControls.MSSSearch_UC(_grid, null);
            SSUC.Controls.Owner.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            tableLayoutPanelVisit.Controls.Add(SSUC, 1, i++);
        }

    }


  
}
