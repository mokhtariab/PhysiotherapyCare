using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MKH.Library.UserControls
{
    public partial class MSSUserControl_UC : UserControl
    {

        public MSSUserControl_UC()
        {
            InitializeComponent();
        }

        public MKH.Library.UserControls.MSSUserControl_UC _userControl_Slave;
        [System.ComponentModel.DefaultValue(typeof(MKH.Library.UserControls.MSSUserControl_UC), "(none)")]
        public MKH.Library.UserControls.MSSUserControl_UC UserControl_Slave
        {
            get
            {
                if (_userControl_Slave == null) return null;
                return _userControl_Slave;
            }
            set
            {
                _userControl_Slave = value;
            }
        }

        public Dictionary<string, object> _parameterSet;
        public Dictionary<string, object> ParameterSet
        {
            get
            {
                if (_parameterSet == null) return null;
                return _parameterSet;
            }
            set
            {
                _parameterSet = value;
            }
        }


        public bool _headerVisible = true;
        public bool HeaderVisible
        {
            get
            {
                return _headerVisible;
            }
            set
            {
                _headerVisible = value;
            }
        }


        public delegate void ParameterSetChange();
        public event ParameterSetChange ParameterSetEvent;

        public void ParameterSomeEvent()
        {
            if (!Object.ReferenceEquals(null, ParameterSetEvent))
                ParameterSetEvent(); 
        }

    }
}
