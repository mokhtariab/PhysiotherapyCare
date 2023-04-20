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
    public partial class MSSImageSelectorFiling_frm : MKH.Library.Forms.MSSBaseNew_frm
    {

        #region For Filing


        #region Load Data

        int _persCode = 0;

        string _addressPhysicPic = "", _addressPhysicFilm = "", _addressPhysicFolder = "";//950808
        string _addressPhysic = MKH.Library.Clasess.PublicParam.AddressFile;


        public MSSImageSelectorFiling_frm(int PersCode, string AddressPhysic = "")
        {
            InitializeComponent();
            _persCode = PersCode;
            _addressPhysic = AddressPhysic == "" ? (_addressPhysic + _persCode + @"\") : (AddressPhysic + _persCode + @"\");
            if (!File.Exists(_addressPhysic))
                Directory.CreateDirectory(_addressPhysic);

            _addressPhysicPic = _addressPhysic + @"PIC\";
            if (!File.Exists(_addressPhysicPic))
                Directory.CreateDirectory(_addressPhysicPic);

            _addressPhysicFilm = _addressPhysic + @"Film\";
            if (!File.Exists(_addressPhysicFilm))
                Directory.CreateDirectory(_addressPhysicFilm);
            //950808
            _addressPhysicFolder = _addressPhysic + @"Folder\";
            if (!File.Exists(_addressPhysicFolder))
                Directory.CreateDirectory(_addressPhysicFolder);
            //950808
        }


        public MSSImageSelectorFiling_frm(int PersCode, List<Clasess.Filing.PermissionButtonList> PermissionButtonListValue, string AddressPhysic = "")
        {
            InitializeComponent();
            _persCode = PersCode;
            _addressPhysic = AddressPhysic == "" ? (_addressPhysic + _persCode + @"\") : (AddressPhysic + _persCode + @"\");
            if (!File.Exists(_addressPhysic))
                Directory.CreateDirectory(_addressPhysic);

            _addressPhysicPic = _addressPhysic + @"PIC\";
            if (!File.Exists(_addressPhysicPic))
                Directory.CreateDirectory(_addressPhysicPic);

            _addressPhysicFilm = _addressPhysic + @"Film\";
            if (!File.Exists(_addressPhysicFilm))
                Directory.CreateDirectory(_addressPhysicFilm);
            //950808
            _addressPhysicFolder = _addressPhysic + @"Folder\";
            if (!File.Exists(_addressPhysicFolder))
                Directory.CreateDirectory(_addressPhysicFolder);
            //950808

            bubbleButton_FilmNew.Enabled = PermissionButtonListValue[0].PermissionFileNew;
            bubbleButton_FilmDel.Enabled = PermissionButtonListValue[0].PermissionFileDel;
            bubbleButton_PicNew.Enabled = PermissionButtonListValue[0].PermissionPicNew;
            bubbleButton_PicDel.Enabled = PermissionButtonListValue[0].PermissionPicDel;
            bubbleButtonFoldersNew.Enabled = PermissionButtonListValue[0].PermissionFolderNew;
            bubbleButtonFoldersDel.Enabled = PermissionButtonListValue[0].PermissionFolderDel;
        }


        private void ShowPicFilmListCounter(int listViewPicCount, int listViewFilmCount, int listViewFolderCount)
        {
            LabelPicCount.Text = "تعداد: " + listViewPicCount + "  ";
            LabelFilmCount.Text = "تعداد: " + listViewFilmCount + "  ";
            LabelFolderCount.Text = "تعداد: " + listViewFolderCount + "  ";
        }

        private void MSSImageSelector_frm_Load(object sender, EventArgs e)
        {
            LoadPics_Films(_persCode);
        }

        #endregion

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
            try
            {
                //pics & films
                SavePics_Films(_persCode);
            }
            catch (Exception ex)
            {
                MSSMessage.MSSMessage_View(0, MSSMessage.MessageType.SError, false, "ثبت نشد!", ex.Message);
                return false;
            }
            return true;
        }        

        #endregion

        #region Pics & Films

        private int PicCounter = 0;
        private int FilmCounter = 0;
        private int FolderCounter = 0;//950808
        
        //private PictureBox ImgPic = null;

        private void LoadPics_Films(int CarFaceID)
        {
            ReadOnlyCollection<string> ROCPIC = new ReadOnlyCollection<string>(FileSystem.GetFiles(_addressPhysicPic));
            foreach (string PicRoot in ROCPIC)
            {
                string FileNameExist = Path.GetFileName(PicRoot);
                if (new FileInfo(FileNameExist).Extension == ".db") continue;
                try
                {
                    AddToListViewPic(FileNameExist, PicRoot, PicCounter);
                    PicCounter++;
                }
                catch { }
            }

            //films
            ReadOnlyCollection<string> ROC = new ReadOnlyCollection<string>(FileSystem.GetFiles(_addressPhysicFilm));
            foreach (string PicFilmRoot in ROC)
            {
                string FileNameExist = Path.GetFileName(PicFilmRoot);
                if (new FileInfo(FileNameExist).Extension == ".db") continue;
                AddToListViewFilm(FileNameExist, PicFilmRoot, FilmCounter);
                FilmCounter++;
            }

            //950808
            //folders
            ReadOnlyCollection<string> ROCFolder = new ReadOnlyCollection<string>(FileSystem.GetDirectories(_addressPhysicFolder));
            foreach (string FolderRoot in ROCFolder)
            {
                AddToListViewFolders(FolderRoot, FolderCounter);
                FolderCounter++;
            }
            //950808

            ROC = null; ROCPIC = null; ROCFolder = null;

            ShowPicFilmListCounter(listView_Pic.Items.Count, listView_Film.Items.Count, listViewFolders.Items.Count);
        }


        private void SavePics_Films(int CarFaceID)
        {
            int i;

            for (i = 0; i < listView_Pic.Items.Count; i++)
            {
                Application.DoEvents();
                if (FileSystem.FileExists(_addressPhysicPic + listView_Pic.Items[i].Text)) continue;
                else
                    FileSystem.CopyFile(listView_Pic.Items[i].Name, _addressPhysicPic + listView_Pic.Items[i].Text);
                Application.DoEvents();
            }

            Application.DoEvents();

            for (i = 0; i < FileDel.Count; i++)
            {
                //System.Threading.Thread.Sleep(1000);
                //File.Delete(FileDel[i]);
                //FileSystem.DeleteFile(FileDel[i]);

                try
                {
                    Application.DoEvents();
                    System.Threading.Thread.Sleep(1000);
                    FileSystem.RenameFile(FileDel[i], "-1delF000.jpg");
                }
                catch { }
                try
                {
                    Application.DoEvents();
                    System.Threading.Thread.Sleep(1000);
                    FileSystem.DeleteFile(_addressPhysicPic + "-1delF000.jpg");
                    Application.DoEvents();
                }
                catch { }
            }


           // listView_Pic.Items.Clear();
           // imageList_LargePic.Images.Clear();
           // imageList_SmallPic.Images.Clear();

           //// ImgPic = null;
            
           // listView_Pic.Dispose();
           // imageList_LargePic.Dispose();
           // imageList_SmallPic.Dispose();

           // for (i = 0; i < FileDel.Count; i++)
           // {
           //     try
           //     {
           //         File.Delete(FileDel[i]);
           //         //FileSystem.RenameFile(FileDel[i], "-1delF000.jpg");
           //         //FileSystem.DeleteFile(_addressPhysicPic + "-1delF000.jpg");
           //     }
           //     catch {
           //         //FileInfo file = new FileInfo(FileDel[i]);
           //         //while (IsFileLocked(file))
           //         //    System.Threading.Thread.Sleep(1000);
           //         //file.Delete();
           //     }
           // }


            for (i = 0; i < listView_Film.Items.Count; i++)
            {
                Application.DoEvents();
                if (FileSystem.FileExists(_addressPhysicFilm + listView_Film.Items[i].Text)) continue;
                else
                    FileSystem.CopyFile(listView_Film.Items[i].Name, _addressPhysicFilm + listView_Film.Items[i].Text);
                Application.DoEvents();
            }

            for (i = 0; i < FileDelFilm.Count; i++)
            {
                Application.DoEvents();
                FileSystem.RenameFile(FileDelFilm[i], "-1delF000.jpg");
                Application.DoEvents();
                FileSystem.DeleteFile(_addressPhysicFilm + "-1delF000.jpg");
                Application.DoEvents();
            }

            //950808
            for (i = 0; i < FolderDel.Count; i++)
                FileSystem.DeleteDirectory(FolderDel[i], DeleteDirectoryOption.DeleteAllContents);

            for (i = 0; i < listViewFolders.Items.Count; i++)
            {
                Application.DoEvents();
                if (FileSystem.DirectoryExists(_addressPhysicFolder + listViewFolders.Items[i].Text)) continue;
                else
                    FileSystem.CopyDirectory(listViewFolders.Items[i].Name, _addressPhysicFolder + listViewFolders.Items[i].Text);
                Application.DoEvents();
            }
            //950808
        }

        //pics


        protected virtual bool IsFileLocked(FileInfo file)
        {
            FileStream stream = null;

            try
            {
                stream = file.Open(FileMode.Open, FileAccess.ReadWrite, FileShare.None);
            }
            catch (IOException)
            {
                return true;
            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }

            //file is not locked
            return false;
        }

        #endregion

        #region Other

       
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
                    AddToListViewPic(selectedFiles[i], filePaths[i], PicCounter);

                    PicCounter++;
                }
            }
            ShowPicFilmListCounter(listView_Pic.Items.Count, listView_Film.Items.Count, listViewFolders.Items.Count);
        }

        List<string> FileDel= new List<string>();
        private void bubbleButton_PicDel_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            if (listView_Pic.SelectedItems.Count != 0)
                if (MSSMessage.MSSMessage_View(0, MSSMessage.MessageType.SConfirmation, true, "آیا مایلید فایل (های) مورد نظر حذف شوند؟"))
                {
                    //string _addressPhysicPicDel = _addressPhysicPic + @"Del\";
                    //if (!Directory.Exists(_addressPhysicPicDel))
                    //    Directory.CreateDirectory(_addressPhysicPicDel);

                    int SelCount = listView_Pic.SelectedItems.Count;
                    for (int i = 0; i < SelCount; i++)
                    {
                        string str = _addressPhysicPic + listView_Pic.SelectedItems[0].Text;

                        if (File.Exists(str))
                        {
                            FileDel.Add(str);
                            //bool tkrr = true; int M = 0;
                            //while (tkrr)
                            //{
                              //  try
                              //  {
                                //    FileSystem.CopyFile(listView_Pic.SelectedItems[i].Name, _addressPhysicPicDel + listView_Pic.SelectedItems[i].Text);
                                 //   tkrr = false;
                                //}
                                //catch
                               // {
                                 //   try
                                   // {
                                     //   FileSystem.CopyFile(listView_Pic.SelectedItems[i].Name, _addressPhysicPicDel + listView_Pic.SelectedItems[i].Text + M++.ToString());
                                       // tkrr = false;
                                   // }
                                   // catch { }
                               // }
                            //}
                        }
                        listView_Pic.Items.Remove(listView_Pic.SelectedItems[0]);
                    }

                }
            ShowPicFilmListCounter(listView_Pic.Items.Count, listView_Film.Items.Count, listViewFolders.Items.Count);
        }

        private void AddToListViewPic(string PicFileName, string ItemName, int PicCnt)
        {
            PictureBox ImgPic = new PictureBox();
            ImgPic.Load(ItemName);
            //ImgPic.Image = PublicClass.resizeImage(ItemName);
            imageList_LargePic.Images.Add(ImgPic.Image);
            imageList_SmallPic.Images.Add(ImgPic.Image);
            listView_Pic.Items.Add(ItemName, PicFileName, PicCnt);
            ImgPic = null;

        }

        private void bubbleButton_PicView_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            if (listView_Pic.SelectedItems.Count != 0) Process.Start(listView_Pic.SelectedItems[0].Name);
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


        private void bubbleButton_Print_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            if (listView_Pic.SelectedItems.Count != 0)
                if (MSSMessage.MSSMessage_View(0, MSSMessage.MessageType.SConfirmation, true, "آیا مایلید فایل (های) مورد نظر چاپ شوند؟"))
                {
                    for (int i = 0; i < listView_Pic.SelectedItems.Count; i++)
                    {
                        string str = _addressPhysicPic + listView_Pic.SelectedItems[i].Text;
                        if (File.Exists(str))
                        {
                            Process p = new Process();
                            p.StartInfo.FileName = str;
                            p.StartInfo.Verb = "Print";
                            p.Start();
                        }
                    }
                }
        }







        //films

        private void AddToListViewFilm(string FilmFileName, string ItemName, int FilmCnt)
        {
            PictureBox ImgPic = new PictureBox();
            ImgPic.Image = Properties.Resources.Templete;
            imageList_LargeFilm.Images.Add(ImgPic.Image);
            imageList_SmallFilm.Images.Add(ImgPic.Image);
            listView_Film.Items.Add(ItemName, FilmFileName, FilmCnt);
            ImgPic = null;
        }


        private void bubbleButton_FilmNew_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "All file|*.wmv;*.avi;*.mpeg;*.3gp;*.mp4;*.mp3;*.dat;*.mov;*.divx;*.doc;*.docx;*.xls;*.xlsx;*.ppt;*.pptx;*.pdf";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                AddToListViewFilm(ofd.SafeFileName, ofd.FileName, FilmCounter);

                FilmCounter++;
            }

            ShowPicFilmListCounter(listView_Pic.Items.Count, listView_Film.Items.Count, listViewFolders.Items.Count);
        }

        List<string> FileDelFilm = new List<string>();
        private void bubbleButton_FilmDel_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            if (listView_Film.SelectedItems.Count != 0)
                if (MSSMessage.MSSMessage_View(0, MSSMessage.MessageType.SConfirmation, true, "آیا مایلید فیلم مورد نظر حذف شود؟"))
                {
                    //string _addressPhysicFilmDel = _addressPhysicFilm + @"Del\";
                    //if (!Directory.Exists(_addressPhysicFilmDel))
                    //    Directory.CreateDirectory(_addressPhysicFilmDel);

                    int SelCount = listView_Film.SelectedItems.Count;
                    for (int i = 0; i < SelCount; i++)
                    {
                        string str = _addressPhysicFilm + listView_Film.SelectedItems[0].Text;

                        if (File.Exists(str))
                        {
                            FileDelFilm.Add(str);
                            //bool tkrr = true; int M = 0;
                            //while (tkrr)
                            //{
                            //    try
                            //    {
                            //        FileSystem.CopyFile(listView_Film.SelectedItems[0].Name, _addressPhysicFilmDel + listView_Film.SelectedItems[0].Text);
                            //        tkrr = false;
                            //    }
                            //    catch
                            //    {
                            //        try
                            //        {
                            //            FileSystem.CopyFile(listView_Film.SelectedItems[0].Name, _addressPhysicFilmDel + listView_Film.SelectedItems[0].Text + M++.ToString());
                            //            tkrr = false;
                            //        }
                            //        catch { }
                            //    }
                            //}
                        }
                    }

                    listView_Film.Items.Remove(listView_Film.SelectedItems[0]);

                }
            ShowPicFilmListCounter(listView_Pic.Items.Count, listView_Film.Items.Count, listViewFolders.Items.Count);
        }

        private void bubbleButton_FilmView_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            try
            {
                if (listView_Film.SelectedItems.Count != 0) Process.Start(listView_Film.SelectedItems[0].Name);
            }
            catch { }
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


        //950808
        #region Folders Button
        private void bubbleButtonFoldersNew_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            FolderBrowserDialog ofd = new FolderBrowserDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string selectedFolder = ofd.SelectedPath;// RootFolder.ToString();
                AddToListViewFolders(selectedFolder, FolderCounter);

                FolderCounter++;
            }

            ShowPicFilmListCounter(listView_Pic.Items.Count, listView_Film.Items.Count, listViewFolders.Items.Count);
        }

        private void AddToListViewFolders(string FolderName, int FolderCnt)
        {
            PictureBox ImgPic = new PictureBox();
            ImgPic.Image = Properties.Resources.File;
            imageListLargeFolders.Images.Add(ImgPic.Image);
            imageListSmallFolders.Images.Add(ImgPic.Image);
            listViewFolders.Items.Add(FolderName, FolderName.Remove(0,FolderName.LastIndexOf("\\") + 1), FolderCnt);
            ImgPic = null;
        }

        List<string> FolderDel = new List<string>();
        private void bubbleButtonFoldersDel_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            if (listViewFolders.SelectedItems.Count != 0)
                if (MSSMessage.MSSMessage_View(0, MSSMessage.MessageType.SConfirmation, true, "آیا مایلید فولدر مورد نظر حذف شود؟"))
                {
                    string str = _addressPhysicFolder + listViewFolders.SelectedItems[0].Text;
                    if (Directory.Exists(str))
                        FolderDel.Add(str);
                    listViewFolders.Items.Remove(listViewFolders.SelectedItems[0]);
                }
            ShowPicFilmListCounter(listView_Pic.Items.Count, listView_Film.Items.Count, listViewFolders.Items.Count);
        }

        private void bubbleButtonFoldersView_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            try
            {
                if (listViewFolders.SelectedItems.Count != 0) Process.Start(listViewFolders.SelectedItems[0].Name);
            }
            catch { }
        }

        private void bubbleButtonFoldersIcon_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            if (listViewFolders.View == View.LargeIcon)
                listViewFolders.View = View.Tile;
            else if (listViewFolders.View == View.Tile)
                listViewFolders.View = View.SmallIcon;
            else if (listViewFolders.View == View.SmallIcon)
                listViewFolders.View = View.List;
            else listViewFolders.View = View.LargeIcon;
        }

        private void listViewFolders_DoubleClick(object sender, EventArgs e)
        {
            bubbleButtonFoldersView_Click(this, null);
        }

        #endregion


       
        //950808


        #endregion


    }

}
