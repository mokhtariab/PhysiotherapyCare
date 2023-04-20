using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MKH.Library.Control
{
    public partial class MSSHeaderGrid : DevComponents.DotNetBar.ItemPanel
    {
        public MSSGridexView _grid;
        public Janus.Windows.GridEX.Export.GridEXExporter _gridEXExporter;
        public System.Windows.Forms.SaveFileDialog _saveFileDialog;
        public Janus.Windows.GridEX.GridEXPrintDocument _gridPrintDocument;

//        System.Windows.Forms.Form _frmOwner = null;
  //      System.Windows.Forms.UserControl _ucOwner = null;

        public MSSHeaderGrid()
        {
            SetBound();
        }

        DevComponents.DotNetBar.ButtonItem buttonItemInsert = null;
        DevComponents.DotNetBar.ButtonItem buttonItemEdit = null;
        DevComponents.DotNetBar.ButtonItem buttonItemDelete = null;
        DevComponents.DotNetBar.ButtonItem buttonItemSearch = null;
        DevComponents.DotNetBar.ButtonItem buttonItemSearchExpert = null;
        DevComponents.DotNetBar.ButtonItem buttonItemPrint = null;
        DevComponents.DotNetBar.ButtonItem buttonItemPrintWithDesign = null;
        DevComponents.DotNetBar.ButtonItem buttonItemPrintExpert = null;
        DevComponents.DotNetBar.ButtonItem buttonItemExcelExport = null;
        DevComponents.DotNetBar.ButtonItem buttonItemFieldSelector = null;
        DevComponents.DotNetBar.ButtonItem buttonItemRefresh = null;

        
        private void SetInitButton()
        {
            buttonItemInsert = new DevComponents.DotNetBar.ButtonItem();
            buttonItemEdit = new DevComponents.DotNetBar.ButtonItem();
            buttonItemDelete = new DevComponents.DotNetBar.ButtonItem();
            buttonItemSearch = new DevComponents.DotNetBar.ButtonItem();
            buttonItemSearchExpert = new DevComponents.DotNetBar.ButtonItem();
            buttonItemPrint = new DevComponents.DotNetBar.ButtonItem();
            buttonItemPrintWithDesign = new DevComponents.DotNetBar.ButtonItem();
            buttonItemPrintExpert = new DevComponents.DotNetBar.ButtonItem();
            buttonItemExcelExport = new DevComponents.DotNetBar.ButtonItem();
            buttonItemFieldSelector = new DevComponents.DotNetBar.ButtonItem();
            buttonItemRefresh = new DevComponents.DotNetBar.ButtonItem();
        }

        private void SetBound()
        {
            SetInitButton();

            //this.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(198)))));
            //this.BackgroundStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(198)))));
            this.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.BackgroundStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.BackgroundStyle.BorderBottomWidth = 1;
            this.BackgroundStyle.BorderLeftWidth = 1;
            this.BackgroundStyle.BorderRightWidth = 1;
            this.BackgroundStyle.BorderTopWidth = 1;
            this.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.BackgroundStyle.PaddingBottom = 1;
            this.BackgroundStyle.PaddingLeft = 1;
            this.BackgroundStyle.PaddingRight = 1;
            this.BackgroundStyle.PaddingTop = 1;
            this.ContainerControlProcessDialogKey = true;
            this.Dock = System.Windows.Forms.DockStyle.Top;
            this.FitButtonsToContainerWidth = true;
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ForeColor = System.Drawing.Color.WhiteSmoke;

            this.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            buttonItemInsert,
            buttonItemEdit,
            buttonItemDelete,
            buttonItemSearch,
            buttonItemSearchExpert,
            buttonItemPrint,
            buttonItemPrintExpert,
            buttonItemExcelExport,
            buttonItemFieldSelector,
            buttonItemRefresh
            });

            this.Location = new System.Drawing.Point(0, 42);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "itemPanelCommon";
            this.Size = new System.Drawing.Size(521, 61);
            this.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Horizontal;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
           
            this.ThemeAware = true;

            SetInsertButton();
            SetEditButton();
            SetDeleteButton();
            SetSearchButton();
            SetSearchExpertButton();
            SetPrintButton();
            SetPrintWithDesignButton();
            SetPrintExpertButton();
            SetExcelExportButton();
            SetFieldSelectorButton();
            SetRefreshButton();
        }

        private void SetInsertButton()
        {
            buttonItemInsert.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            buttonItemInsert.ForeColor = System.Drawing.Color.Gold;
            buttonItemInsert.Icon = Properties.Resources.Add;
            buttonItemInsert.ImageFixedSize = new System.Drawing.Size(30, 30);
            buttonItemInsert.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            buttonItemInsert.Name = "buttonItemInsert";
            buttonItemInsert.Text = "جدید";
            buttonItemInsert.ThemeAware = true;
            buttonItemInsert.Click += new System.EventHandler(this.buttonItemInsert_Click);
        }

        private void SetEditButton()
        {
            buttonItemEdit.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            buttonItemEdit.ForeColor = System.Drawing.Color.Gold;
            buttonItemEdit.Icon = Properties.Resources.Edited;
            buttonItemEdit.ImageFixedSize = new System.Drawing.Size(30, 30);
            buttonItemEdit.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            buttonItemEdit.Name = "buttonItemEdit";
            buttonItemEdit.Text = "ویرایش";
            buttonItemEdit.ThemeAware = true;
            buttonItemEdit.Click += new System.EventHandler(this.buttonItemEdit_Click);
        }

        private void SetDeleteButton()
        {
            buttonItemDelete.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            buttonItemDelete.ForeColor = System.Drawing.Color.Gold;
            buttonItemDelete.Icon = Properties.Resources.deletered;
            buttonItemDelete.ImageFixedSize = new System.Drawing.Size(30, 30); 
            buttonItemDelete.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            buttonItemDelete.Name = "buttonItemDelete";
            buttonItemDelete.Text = "حذف";
            buttonItemDelete.ThemeAware = true;
            buttonItemDelete.Click += new System.EventHandler(this.buttonItemDelete_Click);
        }

        private void SetSearchButton()
        {
            buttonItemSearch.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            buttonItemSearch.ForeColor = System.Drawing.Color.Gold;
            buttonItemSearch.Icon = Properties.Resources.edit_find;
            buttonItemSearch.ImageFixedSize = new System.Drawing.Size(30, 30);
            buttonItemSearch.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            buttonItemSearch.Name = "buttonItemSearch";
            buttonItemSearch.Text = "جستجو";
            buttonItemSearch.ThemeAware = true;

            buttonItemSearch.Click += new System.EventHandler(this.buttonItemSearch_Click);
        }

        private void SetSearchExpertButton()
        {
            buttonItemSearchExpert.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            buttonItemSearchExpert.ForeColor = System.Drawing.Color.Gold;
            buttonItemSearchExpert.Icon = Properties.Resources.SerachExpert;
            buttonItemSearchExpert.ImageFixedSize = new System.Drawing.Size(30, 30);
            buttonItemSearchExpert.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            buttonItemSearchExpert.Name = "buttonItemSearchExpert";
            buttonItemSearchExpert.Text = "جستجو پیشرفته";
            buttonItemSearchExpert.ThemeAware = true;

            buttonItemSearchExpert.Click += new System.EventHandler(this.buttonItemSearchExpert_Click);
        }

        private void SetPrintButton()
        {
            buttonItemPrint.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            buttonItemPrint.ForeColor = System.Drawing.Color.Gold;
            buttonItemPrint.Icon = Properties.Resources.printer;
            buttonItemPrint.ImageFixedSize = new System.Drawing.Size(30, 30);
            buttonItemPrint.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            buttonItemPrint.Name = "buttonItemPrint";
            this.buttonItemPrint.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItemPrintWithDesign});
            buttonItemPrint.Text = "چاپ لیست";
            buttonItemPrint.ThemeAware = true;
            buttonItemPrint.Click += new System.EventHandler(this.buttonItemPrint_Click);
        }

        private void SetPrintWithDesignButton()
        {
            buttonItemPrintWithDesign.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            buttonItemPrintWithDesign.ForeColor = System.Drawing.Color.Black;
            buttonItemPrintWithDesign.Icon = Properties.Resources.printer;
            buttonItemPrintWithDesign.ImageFixedSize = new System.Drawing.Size(30, 30);
            buttonItemPrintWithDesign.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            buttonItemPrintWithDesign.Name = "buttonItemPrintWithDesign";
            buttonItemPrintWithDesign.Text = "چاپ لیست با طراحی";
            buttonItemPrintWithDesign.ThemeAware = true;
            buttonItemPrintWithDesign.Click += new System.EventHandler(this.buttonItemPrintWithDesign_Click);
        }

        
        private void SetPrintExpertButton()
        {
            buttonItemPrintExpert.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            buttonItemPrintExpert.ForeColor = System.Drawing.Color.Gold;
            buttonItemPrintExpert.Icon = Properties.Resources.Print;
            buttonItemPrintExpert.ImageFixedSize = new System.Drawing.Size(30, 30);
            buttonItemPrintExpert.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            buttonItemPrintExpert.Name = "buttonItemPrintExpert";
            buttonItemPrintExpert.Text = "چاپ";
            buttonItemPrintExpert.ThemeAware = true;
            buttonItemPrintExpert.Click += new System.EventHandler(this.buttonItemPrintExpert_Click);
        }


        private void SetRefreshButton()
        {
            buttonItemRefresh.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            buttonItemRefresh.ForeColor = System.Drawing.Color.Gold;
            buttonItemRefresh.Icon = Properties.Resources.interact;
            buttonItemRefresh.ImageFixedSize = new System.Drawing.Size(30, 30);
            buttonItemRefresh.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            buttonItemRefresh.Name = "buttonItemRefresh";
            buttonItemRefresh.Text = "بازخوانی";
            buttonItemRefresh.ThemeAware = true;
            buttonItemRefresh.Click += new System.EventHandler(this.buttonItemRefresh_Click);
        }

        private void SetExcelExportButton()
        {
            buttonItemExcelExport.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            buttonItemExcelExport.ForeColor = System.Drawing.Color.Gold;
            buttonItemExcelExport.Icon = Properties.Resources.excel;
            buttonItemExcelExport.ImageFixedSize = new System.Drawing.Size(30, 30);
            buttonItemExcelExport.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            buttonItemExcelExport.Name = "buttonItemExcelExport";
            buttonItemExcelExport.Text = "ارسال به اکسل";
            buttonItemExcelExport.ThemeAware = true;
            buttonItemExcelExport.Click += new System.EventHandler(this.buttonItemExcelExport_Click);
        }

       
        private void SetFieldSelectorButton()
        {
            buttonItemFieldSelector.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            buttonItemFieldSelector.ForeColor = System.Drawing.Color.Gold;
            buttonItemFieldSelector.Icon = Properties.Resources.SelectColor;
            buttonItemFieldSelector.ImageFixedSize = new System.Drawing.Size(30, 30);
            buttonItemFieldSelector.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            buttonItemFieldSelector.Name = "buttonItemFieldSelector";
            buttonItemFieldSelector.Text = "انتخاب ستونها";
            buttonItemFieldSelector.ThemeAware = true;
            buttonItemFieldSelector.Click += new System.EventHandler(this.buttonItemFieldSelector_Click);
        }


        #region Delegate Event

        public delegate void buttonItemInsertClickEventHandler(object sender,
                                  System.EventArgs e);
        public event buttonItemInsertClickEventHandler buttonItemInsertClick;

        void buttonItemInsert_Click(object sender, System.EventArgs e)
        {
            if (buttonItemInsertClick != null)
                buttonItemInsertClick(sender, e);
        }


        public delegate void buttonItemEditClickEventHandler(object sender,
                                  System.EventArgs e);
        public event buttonItemEditClickEventHandler buttonItemEditClick;

        void buttonItemEdit_Click(object sender, System.EventArgs e)
        {
            if (buttonItemEditClick != null)
                buttonItemEditClick(sender, e);
        }


        public delegate void buttonItemDeleteClickEventHandler(object sender,
                                 System.EventArgs e);
        public event buttonItemDeleteClickEventHandler buttonItemDeleteClick;

        void buttonItemDelete_Click(object sender, System.EventArgs e)
        {
            if (buttonItemDeleteClick != null)
                buttonItemDeleteClick(sender, e);
        }


        public delegate void buttonItemRefreshClickEventHandler(object sender,
                                System.EventArgs e);
        public event buttonItemRefreshClickEventHandler buttonItemRefreshClick;

        void buttonItemRefresh_Click(object sender, System.EventArgs e)
        {
            if (buttonItemRefreshClick != null)
                buttonItemRefreshClick(sender, e);
        }


        public delegate void buttonItemPrintExpertClickEventHandler(object sender,
                                        System.EventArgs e);
        public event buttonItemPrintExpertClickEventHandler buttonItemPrintExpertClick;
        private void buttonItemPrintExpert_Click(object sender, EventArgs e)
        {
            if (buttonItemPrintExpertClick != null)
                buttonItemPrintExpertClick(sender, e);
        }

        #endregion


        void buttonItemSearch_Click(object sender, System.EventArgs e)
        {
            if (_grid == null)
            {
                System.Windows.Forms.MessageBox.Show("Code 2: Set Search Grid!");
            }
            else
            {
                buttonItemSearch.Checked = !buttonItemSearch.Checked;

                if (buttonItemSearch.Checked)
                    _grid.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
                else
                    _grid.FilterMode = Janus.Windows.GridEX.FilterMode.None;
            }
        }
        void buttonItemSearchExpert_Click(object sender, System.EventArgs e)
        {
            //if (_grid == null)
            //{
            //    System.Windows.Forms.MessageBox.Show("Code 2: Set SearchExpert Grid!");
            //}
            //else
            //{
            //    new Forms.MSSSearchPanel_frm(_grid).Show();
            //}
            
            if (_grid == null)
            {
                System.Windows.Forms.MessageBox.Show("Code 2: Set SearchExpert Grid!");
            }
            else
            {
                buttonItemSearchExpert.Checked = !buttonItemSearchExpert.Checked;

                if (buttonItemSearchExpert.Checked)
                {
                    System.Windows.Forms.Control ctrl = new UserControls.MSSSearchPanel_UC(this._grid);
                    ctrl.Name = "MSSSearchPanel_UC";
                    ctrl.Dock = DockStyle.Top;
                    this.Parent.Controls.Add(ctrl);

                    MKH.Library.Control.MSSExpandableSplitter ctrl1 = new MKH.Library.Control.MSSExpandableSplitter();
                    ctrl1.Name = "MSSExpandableSplitter1";
                    ctrl1.Dock = DockStyle.Top;
                    this.Parent.Controls.Add(ctrl1);

                    ctrl1.SendToBack();
                    ctrl.SendToBack();
                    this.SendToBack();
                }
                else
                {
                    this.Parent.Controls.Remove(this.Parent.Controls.Find("MSSSearchPanel_UC", true)[0]);
                    this.Parent.Controls.Remove(this.Parent.Controls.Find("MSSExpandableSplitter1", true)[0]);
                }
            }
        }

        void buttonItemPrint_Click(object sender, System.EventArgs e)
        {
            if (_grid == null)
            {
                System.Windows.Forms.MessageBox.Show("Code 2: Set Printer Grid!");
            }
            else
            {
                this._gridPrintDocument = new Janus.Windows.GridEX.GridEXPrintDocument();
                this._gridPrintDocument.GridEX = this._grid;
                new Forms.MSSPrintPreview_frm().Show(_gridPrintDocument);
            }

        }

        void buttonItemPrintWithDesign_Click(object sender, System.EventArgs e)
        {
            if (_grid == null)
            {
                System.Windows.Forms.MessageBox.Show("Code 2: Set Print Grid!");
            }
            else
            {
                MKH.Library.Forms.MSSReportDesignList_frm ctrl = new MKH.Library.Forms.MSSReportDesignList_frm(this._grid.Parent.Name);
                System.Data.DataTable DataRel = new System.Data.DataTable();
                try
                {
                    foreach (Janus.Windows.GridEX.GridEXColumn item in _grid.RootTable.Columns)
                        if (item.Tag == "" || item.Tag == null)
                            DataRel.Columns.Add(item.Caption);

                    for (int i = 0; i < _grid.RowCount; i++)
                    {
                        System.Data.DataRow dr = DataRel.NewRow();
                        _grid.Row = i;
                        foreach (Janus.Windows.GridEX.GridEXColumn item in _grid.RootTable.Columns)
                            if (item.Tag == "" || item.Tag == null)
                                dr[item.Caption] = (_grid.CurrentRow.Cells[item.Key].Value ?? "").ToString();

                        DataRel.Rows.Add(dr);
                    }

                    ctrl.DataRelationNew = DataRel;
                    ctrl.NameForDB = this._grid.Parent.Tag.ToString();
                    ctrl.ShowDialog();
                }
                catch { }

                //buttonItemPrint.Checked = !buttonItemPrint.Checked;

                //if (buttonItemPrint.Checked)
                //{
                //    try
                //    {
                //        Forms.MSSReportDesignList_frm ctrl = new Forms.MSSReportDesignList_frm(this._grid.Parent.Name);
                //        ctrl.DataRelationNew = ((System.Collections.IList)_grid.DataSource).OfType<object>().ToList();
                //        ctrl.NameForDB = this._grid.Parent.Name;
                //        ctrl.Name = "MSSReportDesignList_UC";
                //        ctrl.Dock = DockStyle.Top;
                //        this.Parent.Controls.Add(ctrl);

                //        MKH.Library.Control.MSSExpandableSplitter ctrl1 = new MKH.Library.Control.MSSExpandableSplitter();
                //        ctrl1.Name = "MSSExpandableSplitter3";
                //        ctrl1.Dock = DockStyle.Top;
                //        this.Parent.Controls.Add(ctrl1);

                //        ctrl1.SendToBack();
                //        ctrl.SendToBack();
                //        this.SendToBack();
                //    }
                //    catch { }
                //}
                //else
                //{
                //    this.Parent.Controls.Remove(this.Parent.Controls.Find("MSSReportDesignList_UC", true)[0]);
                //    this.Parent.Controls.Remove(this.Parent.Controls.Find("MSSExpandableSplitter3", true)[0]);
                //}
            }

        }

        void buttonItemExcelExport_Click(object sender, System.EventArgs e)
        {
            if (_grid == null)
            {
                System.Windows.Forms.MessageBox.Show("Code 2: Set Exporter Grid!");
            }
            else
            {
                // objSaveFileDialog
                this._saveFileDialog = new System.Windows.Forms.SaveFileDialog();
                this._saveFileDialog.FileName = "Export.xls";
                this._saveFileDialog.Filter = "Excel 2003|*.xls|All files|*.*";
                if (this._saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    System.IO.FileStream fs = new System.IO.FileStream(_saveFileDialog.FileName,
                    System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.Write);

                    // objGridEXExporter
                    this._gridEXExporter = new Janus.Windows.GridEX.Export.GridEXExporter();
                    this._gridEXExporter.GridEX = this._grid;
                    this._gridEXExporter.IncludeChildTables = true;

                    _gridEXExporter.Export(fs);

                    fs.Close();

                    try
                    {
                        System.Diagnostics.Process oProcess = new System.Diagnostics.Process();
                        oProcess.StartInfo.Arguments = "";
                        oProcess.StartInfo.FileName = _saveFileDialog.FileName;
                        oProcess.StartInfo.WorkingDirectory = "";
                        oProcess.Start();
                    }
                    catch (System.Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.Message);
                    }
                }

            }
        }

        void buttonItemFieldSelector_Click(object sender, EventArgs e)
        {
            if (_grid == null)
            {
                System.Windows.Forms.MessageBox.Show("Code 2: Set FieldSelector Grid!");
            }
            else
            {
                buttonItemFieldSelector.Checked = !buttonItemFieldSelector.Checked;

                if (buttonItemFieldSelector.Checked)
                {
                    System.Windows.Forms.Control ctrl = new UserControls.MSSColumnSelector_UC(this._grid);
                    ctrl.Name ="MSSColumnSelector_UC";
                    ctrl.Dock = DockStyle.Top;
                    this.Parent.Controls.Add(ctrl);


                    MKH.Library.Control.MSSExpandableSplitter ctrl1 = new MKH.Library.Control.MSSExpandableSplitter();
                    ctrl1.Name = "MSSExpandableSplitter2";
                    ctrl1.Dock = DockStyle.Top;
                    this.Parent.Controls.Add(ctrl1);

                    ctrl1.SendToBack();
                    ctrl.SendToBack();
                    this.SendToBack();
                }
                else
                {
                    this.Parent.Controls.Remove(this.Parent.Controls.Find("MSSColumnSelector_UC",true)[0]);
                    this.Parent.Controls.Remove(this.Parent.Controls.Find("MSSExpandableSplitter2", true)[0]);
                    try { System.IO.Directory.Delete(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\PhysiotherapyCare", true); }
                    catch { }
                }
            }
        }


        #region Property Event
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

        //public System.Windows.Forms.Form OwnerForm
        //{
        //    get
        //    {
        //        if (_frmOwner == null) return null; 
        //        return _frmOwner;
        //    }
        //    set
        //    {
        //        _frmOwner = value;
        //    }
        //}

        public bool ButtonInsertVisible
        {
            get
            {
                return buttonItemInsert.Visible;
            }
            set
            {
                buttonItemInsert.Visible = value;
            }
        }

        public bool ButtonEditVisible
        {
            get
            {
                return buttonItemEdit.Visible;
            }
            set
            {
                buttonItemEdit.Visible = value;
            }
        }

        public bool ButtonDeleteVisible
        {
            get
            {
                return buttonItemDelete.Visible;
            }
            set
            {
                buttonItemDelete.Visible = value;
            }
        }

        public bool ButtonSearchVisible
        {
            get
            {
                return buttonItemSearch.Visible;
            }
            set
            {
                buttonItemSearch.Visible = value;
            }
        }

        public bool ButtonSearchExpertVisible
        {
            get
            {
                return buttonItemSearchExpert.Visible;
            }
            set
            {
                buttonItemSearchExpert.Visible = value;
            }
        }

        public bool ButtonPrintVisible
        {
            get
            {
                return buttonItemPrint.Visible;
            }
            set
            {
                buttonItemPrint.Visible = value;
            }
        }
        
        public bool ButtonPrintWithDesignVisible
        {
            get
            {
                return buttonItemPrintWithDesign.Visible;
            }
            set
            {
                buttonItemPrintWithDesign.Visible = value;
            }
        }

        public bool ButtonPrintExpertVisible
        {
            get
            {
                return buttonItemPrintExpert.Visible;
            }
            set
            {
                buttonItemPrintExpert.Visible = value;
            }
        }

        public bool ButtonExcelExportVisible
        {
            get
            {
                return buttonItemExcelExport.Visible;
            }
            set
            {
                buttonItemExcelExport.Visible = value;
            }
        }

        public bool ButtonSelectorVisible
        {
            get
            {
                return buttonItemFieldSelector.Visible;
            }
            set
            {
                buttonItemFieldSelector.Visible = value;
            }
        }

        public bool ButtonRefreshVisible
        {
            get
            {
                return buttonItemRefresh.Visible;
            }
            set
            {
                buttonItemRefresh.Visible = value;
            }
        }






        public int ButtonInsertPermissionCode
        {
            get
            {
                return buttonItemInsert.Tag.ToString().ToInt();
            }
            set
            {
                buttonItemInsert.Tag = value;
            }
        }

        public int ButtonEditPermissionCode
        {
            get
            {
                return buttonItemEdit.Tag.ToString().ToInt();
            }
            set
            {
                buttonItemEdit.Tag = value;
            }
        }

        public int ButtonDeletePermissionCode
        {
            get
            {
                return buttonItemDelete.Tag.ToString().ToInt();
            }
            set
            {
                buttonItemDelete.Tag = value;
            }
        }


        public int ButtonPrintPermissionCode
        {
            get
            {
                return buttonItemPrint.Tag.ToString().ToInt();
            }
            set
            {
                buttonItemPrint.Tag = value;
            }
        }

        public int ButtonPrintWithDesignPermissionCode
        {
            get
            {
                return buttonItemPrintWithDesign.Tag.ToString().ToInt();
            }
            set
            {
                buttonItemPrintWithDesign.Tag = value;
            }
        }

        public int ButtonPrintExpertPermissionCode
        {
            get
            {
                return buttonItemPrintExpert.Tag.ToString().ToInt();
            }
            set
            {
                buttonItemPrintExpert.Tag = value;
            }
        }

        public int ButtonExcelPermissionCode
        {
            get
            {
                return buttonItemExcelExport.Tag.ToString().ToInt();
            }
            set
            {
                buttonItemExcelExport.Tag = value;
            }
        }

        #endregion

    }
}
