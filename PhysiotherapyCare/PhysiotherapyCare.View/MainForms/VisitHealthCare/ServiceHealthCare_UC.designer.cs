using MKH.Library.Control;

namespace PhysiotherapyCare.View.MainForms.VisitHealthCare
{
    partial class ServiceHealthCare_UC
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceHealthCare_UC));
            Janus.Windows.GridEX.GridEXLayout GridViewServiceHealthCare_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.tabControlPanel1 = new DevComponents.DotNetBar.TabControlPanel();
            this.vWServiceHealthCareBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GridViewServiceHealthCare = new MKH.Library.Control.MSSGridexView();
            ((System.ComponentModel.ISupportInitialize)(this.vWServiceHealthCareBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewServiceHealthCare)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlPanel1
            // 
            this.tabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel1.Location = new System.Drawing.Point(0, 26);
            this.tabControlPanel1.Name = "tabControlPanel1";
            this.tabControlPanel1.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel1.Size = new System.Drawing.Size(819, 211);
            this.tabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(254)))));
            this.tabControlPanel1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(188)))), ((int)(((byte)(227)))));
            this.tabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.tabControlPanel1.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel1.Style.GradientAngle = 90;
            this.tabControlPanel1.TabIndex = 3;
            // 
            // vWServiceHealthCareBindingSource
            // 
            this.vWServiceHealthCareBindingSource.DataSource = typeof(PhysiotherapyCare.Model.VisitHealthCare.VW_ServiceHealthCare);
            // 
            // GridViewServiceHealthCare
            // 
            this.GridViewServiceHealthCare.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.GridViewServiceHealthCare.AlternatingRowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewServiceHealthCare.BuiltInTextsData = resources.GetString("GridViewServiceHealthCare.BuiltInTextsData");
            this.GridViewServiceHealthCare.CardViewGridlines = Janus.Windows.GridEX.CardViewGridlines.Both;
            this.GridViewServiceHealthCare.DataSource = this.vWServiceHealthCareBindingSource;
            this.GridViewServiceHealthCare.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            GridViewServiceHealthCare_DesignTimeLayout.LayoutString = resources.GetString("GridViewServiceHealthCare_DesignTimeLayout.LayoutString");
            this.GridViewServiceHealthCare.DesignTimeLayout = GridViewServiceHealthCare_DesignTimeLayout;
            this.GridViewServiceHealthCare.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewServiceHealthCare.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.GridViewServiceHealthCare.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.GridViewServiceHealthCare.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.GridViewServiceHealthCare.Font = new System.Drawing.Font("Tahoma", 8.150944F);
            this.GridViewServiceHealthCare.GroupByBoxVisible = false;
            this.GridViewServiceHealthCare.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewServiceHealthCare.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
            this.GridViewServiceHealthCare.Location = new System.Drawing.Point(0, 0);
            this.GridViewServiceHealthCare.Name = "GridViewServiceHealthCare";
            this.GridViewServiceHealthCare.RecordNavigator = true;
            this.GridViewServiceHealthCare.RowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewServiceHealthCare.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition;
            this.GridViewServiceHealthCare.RowHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewServiceHealthCare.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.GridViewServiceHealthCare.SettingsKey = "GridViewServiceHealthCare";
            this.GridViewServiceHealthCare.Size = new System.Drawing.Size(667, 111);
            this.GridViewServiceHealthCare.TabIndex = 33;
            this.GridViewServiceHealthCare.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.GridViewServiceHealthCare.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.GridViewServiceHealthCare.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010;
            // 
            // ServiceHealthCare_UC
            // 
            this.Controls.Add(this.GridViewServiceHealthCare);
            this.Name = "ServiceHealthCare_UC";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(667, 111);
            this.Tag = "لیست خدمات";
            ((System.ComponentModel.ISupportInitialize)(this.vWServiceHealthCareBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewServiceHealthCare)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource vWServiceHealthCareBindingSource;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel1;
        private MSSGridexView GridViewServiceHealthCare;
    }
}
