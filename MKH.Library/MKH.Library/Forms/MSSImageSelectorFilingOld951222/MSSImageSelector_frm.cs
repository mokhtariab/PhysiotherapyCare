using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Data.SqlClient;
using System.IO;
using Microsoft.VisualBasic.FileIO;
using MKH.Library.Clasess;
using MKH.Library.Clasess.Filing;

namespace MKH.Library.Forms
{
    public partial class MSSImageSelector_frm : MKH.Library.Forms.MSSBaseNew_frm
    {
        int _persCode = 0;
        string _addressPhysicPic = "", _addressPhysicFilm = "";
        string _addressPhysic = MKH.Library.Clasess.PublicParam.AddressFile;

        public List<Clasess.Filing.FileTableList> FTList;
        public List<Clasess.Filing.PermissionButtonList> PBList;
        public MSSImageSelector_frm(List<Clasess.Filing.FileTableList> FileTableListValue)
        {
            InitializeComponent();
            FTList = FileTableListValue;
        }
        public MSSImageSelector_frm(List<Clasess.Filing.FileTableList> FileTableListValue, List<Clasess.Filing.PermissionButtonList> PermissionButtonListValue)
        {
            InitializeComponent();
            FTList = FileTableListValue;

            bubbleButton_FilmNew.Enabled = PermissionButtonListValue[0].PermissionFileNew;
            bubbleButton_FilmDel.Enabled = PermissionButtonListValue[0].PermissionFileDel;
            bubbleButton_PicNew.Enabled = PermissionButtonListValue[0].PermissionPicNew;
            bubbleButton_PicDel.Enabled = PermissionButtonListValue[0].PermissionPicDel;
        }

        private void MSSImageSelector_frm_Load(object sender, EventArgs e)
        {
            if (FTList != null)
                LoadPics_Films(FTList);
            else
                FTList = new List<FileTableList>();
        }











        #region OK Data
        private void buttonItem_OK_Click(object sender, EventArgs e)
        {
            if (OkFunction())
            {
                this.DialogResult = DialogResult.OK;
                Close();
            }
        }

        private bool OkFunction()
        {
            //try
            //{
            //    SavePics_Films();
            //}
            //catch (Exception ex)
            //{
            //    return false;
            //}


            return true;
        }

        #endregion



        #region Pics & Films New

        private int PicCounter = 0;
        private int FilmCounter = 0;
        private PictureBox ImgPic = null;

        private void LoadPics_Films(List<Clasess.Filing.FileTableList> FileTableList)
        {
            foreach (var PicFilm in FileTableList)
            {
                //pics
                if (PicFilm.file_type == FileTypeForImageSelector.PicFile)
                {
                    AddToListViewPic(PicFilm.FileName, PicFilm.file_stream, PicCounter);
                    PicCounter++;
                }

                //films
                if (PicFilm.file_type == FileTypeForImageSelector.FilmFile)
                {
                    AddToListViewFilm(PicFilm.FileName, PicFilm.file_stream, FilmCounter);
                    FilmCounter++;
                }
            }
            ShowPicFilmListCounter(listView_Pic.Items.Count, listView_Film.Items.Count);
        }

        private void ShowPicFilmListCounter(int listViewPicCount, int listViewFilmCount)
        {
            LabelPicCount.Text = "تعداد: " + listViewPicCount + "  ";
            LabelFilmCount.Text = "تعداد: " + listViewFilmCount + "  ";
        }


        private List<Clasess.Filing.FileTableList> SavePics_Films()
        {
            //List<Clasess.Filing.FileTableList> ANDC = new List<Clasess.Filing.FileTableList>();
            //Clasess.Filing.FileTableList ACCC;

            //for (int i = 0; i < imageList_LargePic.Images.Count; i++)
            //{
            //    ACCC = new Clasess.Filing.FileTableList();


            //    imageList_LargePic.Images[i].Save(listView_Pic.Items[i].Name);
            //    ACCC.file_stream = new FileStream(listView_Pic.Items[i].Name, FileMode.Open);

            //    ACCC.file_type = "Jpg";
            //    ACCC.name = listView_Pic.Items[i].Name;
            //    ACCC.file_stream = new System.IO.FileStream(listView_Pic.Items[i].Name, System.IO.FileMode.Open);

            //    ANDC.Add(ACCC);
            //}

            return FTList;
        }

        //pics

        private void AddToListViewPic(string PicFileName, byte[] ItemName, int PicCnt)
        {
            ImgPic = new PictureBox();
            ImgPic.Image = Image.FromStream(new System.IO.MemoryStream(ItemName.ToArray()));

            //ImgPic.Image = PublicClass.resizeImage(ImgPic.Image);
            imageList_LargePic.Images.Add(ImgPic.Image);
            imageList_SmallPic.Images.Add(ImgPic.Image);
            listView_Pic.Items.Add(PicFileName, PicFileName, PicCnt);
        }

        private void AddToListViewPic(string PicFileName, string ItemName, int PicCnt)
        {
            ImgPic = new PictureBox();
            ImgPic.Load(ItemName);
            //ImgPic.Image = PublicClass.resizeImage(ItemName);
            imageList_LargePic.Images.Add(ImgPic.Image);
            imageList_SmallPic.Images.Add(ImgPic.Image);
            listView_Pic.Items.Add(ItemName, PicFileName, PicCnt);
        }


        private void AddToListViewFilm(string FilmFileName, byte[] ItemName, int FilmCnt)
        {
            ImgPic = new PictureBox();
            //ImgPic.Image = Properties.Resources.Templete;
            ImgPic.Image = Properties.Resources.File;
            imageList_LargeFilm.Images.Add(ImgPic.Image);
            imageList_SmallFilm.Images.Add(ImgPic.Image);
            listView_Film.Items.Add(FilmFileName, FilmFileName, FilmCnt);

        }


        private static FileTableList AddClassList(string PicFileName, byte[] ItemName, FileTypeForImageSelector FTImage, FileViewForImageSelector FVImage)
        {
            Clasess.Filing.FileTableList f = new Clasess.Filing.FileTableList();
            f.file_stream = ItemName;
            f.FileName = PicFileName;
            f.file_type = FTImage;
            f.File_View = FVImage;

            return f;
        }

        #region Pic Button
        private void bubbleButton_PicNew_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "All image file|*.bmp;*.jpg;*.jpeg;*.gif;*.png;*.ico";
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string[] selectedFiles = ofd.SafeFileNames;
                string[] filePaths = ofd.FileNames;
                for (int i = 0; i < ofd.FileNames.Count(); i++)
                {
                    try
                    {
                        if (listView_Pic.FindItemWithText(selectedFiles[i]).Index != null)
                        {
                            Clasess.MSSMessage.MSSMessage_View("فایل " + selectedFiles[i] + " تکراری است", MKH.Library.Clasess.MSSMessage.MessageType.SWarning);
                            continue;
                        }
                    }
                    catch { }

                    try
                    {
                        //FileStream fs = new System.IO.FileStream(filePaths[i], System.IO.FileMode.Open, FileAccess.Read);
                        // fs = PublicClass.resizeImageStream(fs);
                        FileTableList f = AddClassList(selectedFiles[i], File.ReadAllBytes(filePaths[i]), FileTypeForImageSelector.PicFile, FileViewForImageSelector.InsertFile);
                        FTList.Add(f);
                        AddToListViewPic(selectedFiles[i], filePaths[i], PicCounter);
                        PicCounter++;
                    }
                    catch { }
                }
            }
            ShowPicFilmListCounter(listView_Pic.Items.Count, listView_Film.Items.Count);
        }


        private void bubbleButton_PicDel_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            if (listView_Pic.SelectedItems.Count != 0)
                if (Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation, true, "فایل مورد نظر حذف شود؟"))
                {
                    foreach (Clasess.Filing.FileTableList mc in FTList)
                    {
                        if (mc.FileName == listView_Pic.SelectedItems[0].Name)
                            mc.File_View = FileViewForImageSelector.DeleteFile;
                    }
                    listView_Pic.SelectedItems[0].Remove();
                }
            ShowPicFilmListCounter(listView_Pic.Items.Count, listView_Film.Items.Count);
        }

        private void bubbleButton_PicView_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            if (listView_Pic.SelectedItems.Count != 0)
            {
                if (File.Exists(Path.GetTempPath() + listView_Pic.SelectedItems[0].Name))
                    File.Delete(Path.GetTempPath() + listView_Pic.SelectedItems[0].Name);
                foreach (Clasess.Filing.FileTableList mc in FTList)
                {
                    if (mc.FileName == listView_Pic.SelectedItems[0].Name)
                    {
                        FileStream file_stream = new FileStream(Path.GetTempPath() + listView_Pic.SelectedItems[0].Name, FileMode.Create);

                        file_stream.Write(mc.file_stream.ToArray(), 0, mc.file_stream.Length);
                        //mc.file_stream.Save(Path.GetTempPath() + listView_Pic.SelectedItems[0].Name);
                        Process.Start(Path.GetTempPath() + listView_Pic.SelectedItems[0].Name);
                        file_stream.Close();
                    }
                }
            }
        }
        private void bubbleButton_IconPic_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            if (listView_Pic.View == View.LargeIcon)
                listView_Pic.View = View.Tile;
            else if (listView_Pic.View == View.Tile)
                listView_Pic.View = View.SmallIcon;
            else if (listView_Pic.View == View.SmallIcon)
                listView_Pic.View = View.List;
            else listView_Pic.View = View.LargeIcon;
        }

        private void listView_Pic_DoubleClick(object sender, EventArgs e)
        {
            bubbleButton_PicView_Click(this, null);
        }

        #endregion



        #region Film Button
        private void bubbleButton_FilmNew_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "All file|*.wmv;*.avi;*.mpeg;*.3gp;*.mp4;*.mp3;*.dat;*.mov;*.divx;*.doc;*.docx;*.xls;*.xlsx;*.ppt;*.pptx;*.pdf";
            ofd.Multiselect = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string[] selectedFiles = ofd.SafeFileNames;
                string[] filePaths = ofd.FileNames;

                for (int i = 0; i < ofd.FileNames.Count(); i++)
                {
                    try
                    {
                        if (listView_Film.FindItemWithText(selectedFiles[i]).Index != null)
                        {
                            Clasess.MSSMessage.MSSMessage_View("فایل " + selectedFiles[i] + " تکراری است", MKH.Library.Clasess.MSSMessage.MessageType.SWarning);
                            continue;
                        }
                    }
                    catch { }
                    try
                    {
                        //FileStream fs = new System.IO.FileStream(filePaths[i], System.IO.FileMode.Open, FileAccess.Read);
                        FileTableList f = AddClassList(selectedFiles[i], File.ReadAllBytes(filePaths[i]), FileTypeForImageSelector.FilmFile, FileViewForImageSelector.InsertFile);
                        FTList.Add(f);
                        AddToListViewFilm(selectedFiles[i], File.ReadAllBytes(filePaths[i]), FilmCounter);
                        FilmCounter++;
                    }
                    catch
                    {
                    }
                }

            }

            ShowPicFilmListCounter(listView_Pic.Items.Count, listView_Film.Items.Count);
        }

        private void bubbleButton_FilmDel_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            if (listView_Film.SelectedItems.Count != 0)
                if (Clasess.MSSMessage.MSSMessage_View(0, Clasess.MSSMessage.MessageType.SConfirmation, true, "فایل مورد نظر حذف شود؟"))
                {
                    listView_Film.SelectedItems[0].Remove();
                    foreach (Clasess.Filing.FileTableList mc in FTList)
                    {
                        if (mc.FileName == listView_Film.SelectedItems[0].Name)
                            mc.File_View = FileViewForImageSelector.DeleteFile;
                    }
                }
            ShowPicFilmListCounter(listView_Pic.Items.Count, listView_Film.Items.Count);
        }

        private void bubbleButton_FilmView_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            //try
            //{
            //    if (listView_Film.SelectedItems.Count != 0) Process.Start(listView_Film.SelectedItems[0].Name);
            //}
            //catch { }

            if (listView_Pic.SelectedItems.Count != 0)
            {
                if (File.Exists(Path.GetTempPath() + listView_Film.SelectedItems[0].Name))
                    File.Delete(Path.GetTempPath() + listView_Film.SelectedItems[0].Name);
                foreach (Clasess.Filing.FileTableList mc in FTList)
                {
                    if (mc.FileName == listView_Film.SelectedItems[0].Name)
                    {
                        FileStream file_stream = new FileStream(Path.GetTempPath() + listView_Film.SelectedItems[0].Name, FileMode.Create);

                        file_stream.Write(mc.file_stream.ToArray(), 0, mc.file_stream.Length);
                        //mc.file_stream.Save(Path.GetTempPath() + listView_Film.SelectedItems[0].Name);
                        Process.Start(Path.GetTempPath() + listView_Film.SelectedItems[0].Name);
                        file_stream.Close();
                    }
                }
            }

        }

        private void bubbleButton_FilmIcon_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            if (listView_Film.View == View.LargeIcon)
                listView_Film.View = View.Tile;
            else if (listView_Film.View == View.Tile)
                listView_Film.View = View.SmallIcon;
            else if (listView_Film.View == View.SmallIcon)
                listView_Film.View = View.List;
            else listView_Film.View = View.LargeIcon;
        }

        private void listView_Film_DoubleClick(object sender, EventArgs e)
        {
            bubbleButton_FilmView_Click(this, null);
        }

        #endregion

        private void MSSImageSelector_frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                Directory.Delete(Path.GetTempPath(), true);
            }
            catch { }
        }

        #endregion



    }

}
