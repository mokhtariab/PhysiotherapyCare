using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace MKH.Library.Control
{
    public partial class MSSTabControl : DevComponents.DotNetBar.TabControl
    {
        public MSSTabControl()
        {
            InitializeComponent();

            SetDetailTab();
        }

        public MSSTabControl(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
            
            SetDetailTab();
        }

        private void SetDetailTab()
        {
            this.CloseButtonOnTabsVisible = false;
            this.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Location = new System.Drawing.Point(0, 143);
            this.Name = "tabControl_Main";
            this.SelectedTabFont = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.SelectedTabIndex = 0;
            this.Size = new System.Drawing.Size(1162, 589);
            this.Style = DevComponents.DotNetBar.eTabStripStyle.Office2007Document;
            this.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.MultilineNoNavigationBox;
            this.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.tabControl_Main_ControlRemoved);
        }

        public string tabNameStr;
        public void tabControl_Main_ControlRemoved(object sender, System.Windows.Forms.ControlEventArgs e)
        {
            tabNameStr = tabNameStr.Replace(this.SelectedPanel.Name + ",", "");
            this.Tabs.Capacity--;
        }
        public void AddTabToTabControl(string tabName, string tabCaption, System.Windows.Forms.UserControl UC)
        {
            if (tabNameStr != null && tabNameStr.Contains(tabName + "Pnl,"))
            {
                this.SelectedPanel = (DevComponents.DotNetBar.TabControlPanel)this.Controls[tabName + "Pnl"];
                UC.Dispose();
                return;
            }

            DevComponents.DotNetBar.TabItem NewTabItem = new DevComponents.DotNetBar.TabItem(this.components);
            DevComponents.DotNetBar.TabControlPanel NewTabControlPanel = new DevComponents.DotNetBar.TabControlPanel();

            NewTabControlPanel.Controls.Add(UC);
            UC.Dock = System.Windows.Forms.DockStyle.Fill;
            NewTabControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            NewTabControlPanel.Location = new System.Drawing.Point(0, 0);
            NewTabControlPanel.Padding = new System.Windows.Forms.Padding(1);
            NewTabControlPanel.Size = new System.Drawing.Size(778, 289);
            NewTabControlPanel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            NewTabControlPanel.Style.BorderColor.Color = System.Drawing.SystemColors.ControlDarkDark;
            NewTabControlPanel.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right)
                 | DevComponents.DotNetBar.eBorderSide.Top)));
            NewTabControlPanel.Style.GradientAngle = -90;
            NewTabControlPanel.TabIndex = 1;

            NewTabControlPanel.TabItem = NewTabItem;
            NewTabItem.AttachedControl = NewTabControlPanel;


            //
            tabNameStr += tabName + "Pnl,";

            NewTabControlPanel.Name = tabName + "Pnl";
            NewTabControlPanel.Text = tabCaption;

            try
            {
                NewTabItem.Name = tabName + "Itm";
            }
            catch
            {
            }
            NewTabItem.Text = tabCaption;

            this.Controls.Add(NewTabControlPanel);
            this.Tabs.Add(NewTabItem);
            this.Refresh();

            this.SelectedPanel = NewTabControlPanel;
        }

      
    }
}
