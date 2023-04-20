using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace MKH.Library.Control
{
    public partial class MSSRibbonControl : DevComponents.DotNetBar.RibbonControl
    {
        public MSSRibbonControl()
        {
            InitializeComponent();
            InitComponents();
        }

        public MSSRibbonControl(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
            InitComponents();
        }


        //private DevComponents.DotNetBar.RibbonPanel ribbonPanelFile;
        //private DevComponents.DotNetBar.RibbonPanel ribbonPanelReport;
        //private DevComponents.DotNetBar.RibbonPanel ribbonPanelTools;
        //private DevComponents.DotNetBar.RibbonPanel ribbonPanelSetting;

        private void InitComponents()
        {
            //this.ribbonPanelFile = new DevComponents.DotNetBar.RibbonPanel();

            //this.ribbonPanelFile.AutoScroll = true;
            //this.ribbonPanelFile.AutoScrollMinSize = new System.Drawing.Size(1, 0);
            //this.ribbonPanelFile.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
            ////this.ribbonPanelFile.Controls.Add(this.ribbonBarPayment);
            //this.ribbonPanelFile.DefaultLayout = true;
            //this.ribbonPanelFile.Dock = System.Windows.Forms.DockStyle.Fill;
            //this.ribbonPanelFile.Location = new System.Drawing.Point(0, 81);
            //this.ribbonPanelFile.Name = "ribbonPanelFile";
            //this.ribbonPanelFile.Padding = new System.Windows.Forms.Padding(3, 1, 3, 3);
            //this.ribbonPanelFile.Size = new System.Drawing.Size(1162, 60);
            //this.ribbonPanelFile.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            //this.ribbonPanelFile.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            //this.ribbonPanelFile.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;


            ////////////////=============================
            //this.ribbonPanelReport = new DevComponents.DotNetBar.RibbonPanel();

            //this.ribbonPanelReport.AutoScroll = true;
            //this.ribbonPanelReport.AutoScrollMinSize = new System.Drawing.Size(1, 0);
            //this.ribbonPanelReport.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
            ////this.ribbonPanelReport.Controls.Add(this.ribbonBarPayment);
            //this.ribbonPanelReport.DefaultLayout = true;
            //this.ribbonPanelReport.Dock = System.Windows.Forms.DockStyle.Fill;
            //this.ribbonPanelReport.Location = new System.Drawing.Point(0, 81);
            //this.ribbonPanelReport.Name = "ribbonPanelReport";
            //this.ribbonPanelReport.Padding = new System.Windows.Forms.Padding(3, 1, 3, 3);
            //this.ribbonPanelReport.Size = new System.Drawing.Size(1162, 60);
            //this.ribbonPanelReport.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            //this.ribbonPanelReport.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            //this.ribbonPanelReport.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;


            ////////===============================
            //this.ribbonPanelTools = new DevComponents.DotNetBar.RibbonPanel();

            //this.ribbonPanelTools.AutoScroll = true;
            //this.ribbonPanelTools.AutoScrollMinSize = new System.Drawing.Size(1, 0);
            //this.ribbonPanelTools.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
            ////this.ribbonPanelTools.Controls.Add(this.ribbonBarPayment);
            //this.ribbonPanelTools.DefaultLayout = true;
            //this.ribbonPanelTools.Dock = System.Windows.Forms.DockStyle.Fill;
            //this.ribbonPanelTools.Location = new System.Drawing.Point(0, 81);
            //this.ribbonPanelTools.Name = "ribbonPanelTools";
            //this.ribbonPanelTools.Padding = new System.Windows.Forms.Padding(3, 1, 3, 3);
            //this.ribbonPanelTools.Size = new System.Drawing.Size(1162, 60);
            //this.ribbonPanelTools.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            //this.ribbonPanelTools.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            //this.ribbonPanelTools.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;


            /////////===================================
            //this.ribbonPanelSetting = new DevComponents.DotNetBar.RibbonPanel();

            //this.ribbonPanelSetting.AutoScroll = true;
            //this.ribbonPanelSetting.AutoScrollMinSize = new System.Drawing.Size(1, 0);
            //this.ribbonPanelSetting.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
            ////this.ribbonPanelSetting.Controls.Add(this.ribbonBarPayment);
            //this.ribbonPanelSetting.DefaultLayout = true;
            //this.ribbonPanelSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            //this.ribbonPanelSetting.Location = new System.Drawing.Point(0, 81);
            //this.ribbonPanelSetting.Name = "ribbonPanelSetting";
            //this.ribbonPanelSetting.Padding = new System.Windows.Forms.Padding(3, 1, 3, 3);
            //this.ribbonPanelSetting.Size = new System.Drawing.Size(1162, 60);
            //this.ribbonPanelSetting.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            //this.ribbonPanelSetting.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            //this.ribbonPanelSetting.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;





            this.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            //this.Controls.Add(this.ribbonPanelFile);
            //this.Controls.Add(this.ribbonPanelReport);
            //this.Controls.Add(this.ribbonPanelTools);
            //this.Controls.Add(this.ribbonPanelSetting);
            this.Dock = System.Windows.Forms.DockStyle.Top;
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ForeColor = System.Drawing.Color.Black;
            //this.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            //this.ribbonTabItem_DocPat,
            //this.ribbonTabItem_Reports,
            //this.ribbonTabItem_Tools,
            //this.ribbonTabItem_UNet,
            //this.ribbonTabItem_Setting,
            //this.ribbonTabItem_Sys,
            //this.ribbonTabItem_BasicData,
            //this.buttonItem_Help});
            this.KeyTipsFont = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "ribbonControl_Main";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.Size = new System.Drawing.Size(1162, 143);
            this.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro;
            this.SystemText.MaximizeRibbonText = "&Maximize the Ribbon";
            this.SystemText.MinimizeRibbonText = "Mi&nimize the Ribbon";
            this.SystemText.QatAddItemText = "&Add to Quick Access Toolbar";
            this.SystemText.QatCustomizeMenuLabel = "<b>Customize Quick Access Toolbar</b>";
            this.SystemText.QatCustomizeText = "&Customize Quick Access Toolbar...";
            this.SystemText.QatDialogAddButton = "&Add >>";
            this.SystemText.QatDialogCancelButton = "Cancel";
            this.SystemText.QatDialogCaption = "Customize Quick Access Toolbar";
            this.SystemText.QatDialogCategoriesLabel = "&Choose commands from:";
            this.SystemText.QatDialogOkButton = "OK";
            this.SystemText.QatDialogPlacementCheckbox = "&Place Quick Access Toolbar below the Ribbon";
            this.SystemText.QatDialogRemoveButton = "&Remove";
            this.SystemText.QatPlaceAboveRibbonText = "&Place Quick Access Toolbar above the Ribbon";
            this.SystemText.QatPlaceBelowRibbonText = "&Place Quick Access Toolbar below the Ribbon";
            this.SystemText.QatRemoveItemText = "&Remove from Quick Access Toolbar";
            this.TabGroupHeight = 15;
            this.TabGroupsVisible = true;
            this.CaptionVisible = false;

        }
    }
}
