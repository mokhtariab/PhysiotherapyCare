using System;

namespace MKH.Library.Forms
{
	public partial class MSSPrintPreview_frm : System.Windows.Forms.Form
	{

		private System.Windows.Forms.Form mOwnerForm;

        protected void OnLoad(MKH.Library.Control.MSSGridexView gridExPrint)
		{
			
		}

		protected override void OnClosed(System.EventArgs e)
		{
            //mOwnerForm.WindowState = this.WindowState;

            //if (this.WindowState == System.Windows.Forms.FormWindowState.Normal)
            //{
            //    mOwnerForm.Bounds = this.Bounds;
            //}
            //mOwnerForm.Show();
		}

		public void Show(System.Drawing.Printing.PrintDocument printDocument)//, System.Windows.Forms.Form ownerForm)
		{
            Janus.Windows.Common.Office2007ControlRenderer ctlRender = Janus.Windows.Common.Office2007SchemeInformation.GetControlRenderer(Janus.Windows.Common.Office2007ColorScheme.Default, System.Drawing.Color.Empty);
            this.PrintPreviewControl1.BackColor = ctlRender.ControlColor;

            this.ribbon1.DocumentName = "PrintPreview";
            this.TopMost = true;
            try { this.ribbon1.ApplicationName = printDocument.DocumentName; }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Print Document Check!!");
            }
            //mOwnerForm = ownerForm;
            //if (mOwnerForm.WindowState == System.Windows.Forms.FormWindowState.Normal)
            //{
            //    Bounds = mOwnerForm.Bounds;
            //}
            //else
            //{
            //    this.WindowState = mOwnerForm.WindowState;
            //}
			//mOwnerForm.Hide();
			this.Show();
			this.Update();
			this.PrintPreviewControl1.Document = printDocument;
			this.PrintPreviewControl1.AutoZoom = true;

		}

		


		private void PrintPreviewControl1_StartPageChanged(object sender, System.EventArgs e)
		{
            this.rcmdPreviousPage.Enabled = (this.PrintPreviewControl1.StartPage > 0);
		}

        private void ribbon1_CommandClick(object sender, Janus.Windows.Ribbon.CommandEventArgs e)
        {
            switch (e.Command.Key)
            {
                case "rcmdPreviousPage":
                    this.PrintPreviewControl1.StartPage = this.PrintPreviewControl1.StartPage - 1;
                    break;
                case "rcmdNextPage":
                    this.PrintPreviewControl1.StartPage = this.PrintPreviewControl1.StartPage + 1;
                    break;
                case "rcmdActualSize":
                    this.rcmdOnePage.Checked = false;
                    rcmdTwoPages.Checked = false;
                    this.PrintPreviewControl1.AutoZoom = false;
                    this.PrintPreviewControl1.Zoom = 1;
                    break;
                case "rcmdOnePage":
                    rcmdActualSize.Checked = false;
                    rcmdTwoPages.Checked = false;
                    this.PrintPreviewControl1.AutoZoom = true;
                    this.PrintPreviewControl1.Rows = 1;
                    this.PrintPreviewControl1.Columns = 1;
                    break;
                case "rcmdTwoPages":
                    this.rcmdActualSize.Checked = false;
                    this.rcmdOnePage.Checked = false;
                    this.PrintPreviewControl1.AutoZoom = true;
                    this.PrintPreviewControl1.Rows = 1;
                    this.PrintPreviewControl1.Columns = 2;
                    break;
                case "rcmdPageSetup":
                    this.PageSetupDialog1.Document = this.PrintPreviewControl1.Document;
                    if (this.PageSetupDialog1.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                    {
                        System.Drawing.Printing.PrintDocument doc = null;
                        doc = this.PrintPreviewControl1.Document;
                        this.PrintPreviewControl1.Document = doc;
                    }
                    break;
                case "rcmdPrint":
                    this.PrintPreviewControl1.Document.Print();
                    this.Close();
                    break;
                case "rcmdClose":
                    this.Close();
                    break;
            }
        }
	}

} //end of root namespace