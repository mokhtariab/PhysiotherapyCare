using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;

namespace MKH.Library.Clasess
{
    public class PublicParam
    {
        static public Forms.MSSMainForm MainForm = null;
        static public string AddressPic = @"\\MKH.Server\MKH.SoftWares\PIC\";
        static public string AddressFile = @"\\MKH.Server\MKH.SoftWares\File\";
        static public string AddressFolder = @"\\MKH.Server\MKH.SoftWares\Folder\";
        static public string AddressReportDesign = @".\";

        static public int PublicCode = 0;

        static public string UserLoginCode = "";
        static public string UserLoginName = "";

        static public string SoftwareCode = "N2+S";


        static public bool MSSReportDesignListbuttonAddPermission = false;
        static public bool MSSReportDesignListbuttonEditPermission = false;
        static public bool MSSReportDesignListbuttonDelPermission = false;

        //For Image
        static public int MAX_WIDTH = 700, MAX_HEIGHT = 1200, MAX_SIZE = 400000;
    }

    public enum LogActionType
    {
        InsertLog = 1,
        UpdateLog = 2,
        DeleteLog = 3
    }

    public class PublicClass
    {
        public class AllPersonForSMS
        {
            public string PersonNameFamily { get; set; }
            public string JobType { get; set; }
            public string MobileNo1 { get; set; }
            public string MobileNo2 { get; set; }
        }

        public static List<AllPersonForSMS> ListAllPersonForSMS;
        
        public static System.Data.DataTable ToDataTable<T>(IList<T> list)
        {
            System.ComponentModel.PropertyDescriptorCollection properties = System.ComponentModel.TypeDescriptor.GetProperties(typeof(T));
            System.Data.DataTable table = new System.Data.DataTable();
            for (int i = 0; i < properties.Count; i++)
            {
                System.ComponentModel.PropertyDescriptor prop = properties[i];
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            }
            object[] values = new object[properties.Count];
            foreach (T item in list)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = properties[i].GetValue(item) ?? DBNull.Value;

                    //try 
                    //{ 
                    //    values[i].ToString().ToInt();
                    //    values[i] = values[i].ToString().ToInt().ToString("#,##0");
                    //}
                    //catch { }
                }
                table.Rows.Add(values);
            }
            return table;
        }

        static public bool IsAnyInstanceExist(string SoftExecute)
        {
            System.Diagnostics.Process[] processes = System.Diagnostics.Process.GetProcessesByName(SoftExecute);

            if (processes.Length != 1)
                return false; /*false no instance exist*/
            else
                return true; /*true mean instance exist*/
        }

        public static bool ImageSizeChecker(string FileName)
        {
            FileInfo file = new FileInfo(FileName);
            var sizeInBytes = file.Length;
            Bitmap img = new Bitmap(FileName);


            if (img.Width < PublicParam.MAX_WIDTH &&
                img.Height < PublicParam.MAX_HEIGHT &&
                file.Length < PublicParam.MAX_SIZE)
                return true;
            return false;
        }

        public static Image resizeImage(string FileName)
        {
            long Len = (new System.IO.FileInfo(FileName)).Length;

            double Percent = 600000.00 / Len;
            Image Img = Image.FromFile(FileName); 
            if (Percent >= 1) return Img;

            System.Drawing.Image ResizedImage = resizeImageFromFile(FileName, Convert.ToInt32(Img.Height * Percent), Convert.ToInt32(Img.Width * Percent), false, false);

            FileStream FS = new FileStream("001.jpg", FileMode.Create, FileAccess.ReadWrite);
            ResizedImage.Save(FS, System.Drawing.Imaging.ImageFormat.Jpeg);
            Image Img1 = Image.FromStream(FS, true, true);
            FS.Dispose();
            File.Delete("001.jpg");
            return Img1;
        }

        public static Image resizeImage(FileStream FileStream)
        {
            long Len = FileStream.Length;

            double Percent = 600000.00 / Len;
            Image Img = null;
            Img.Save(FileStream, System.Drawing.Imaging.ImageFormat.Jpeg);
            if (Percent >= 1) return Img;

            Bitmap imgToResize = new Bitmap(Img);
            imgToResize.Size.Height.Equals(Convert.ToInt32(imgToResize.Size.Height * Percent));
            imgToResize.Size.Width.Equals(Convert.ToInt32(imgToResize.Size.Width * Percent));

            imgToResize.Save("C:\\001.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);

            Image Img1 = Image.FromFile("C:\\001.jpg");
            File.Delete("C:\\001.jpg");

            return Img1;
        }
        public static FileStream resizeImageStream(FileStream FStream)
        {
            long Len = FStream.Length;

            double Percent = 600000.00 / Len;
            if (Percent >= 1) return FStream;


            //FileStream fs = new FileStream("2435401000000000000.jpg", FileMode.Create);
            
            using (var image = Image.FromStream(FStream))
            using (var bmp = new Bitmap(Convert.ToInt32(image.Size.Width * Percent), Convert.ToInt32(image.Size.Height * Percent)))
            using (var gr = Graphics.FromImage(bmp))
            {
                gr.CompositingQuality = CompositingQuality.HighSpeed;
                gr.SmoothingMode = SmoothingMode.HighSpeed;
                gr.InterpolationMode = InterpolationMode.HighQualityBicubic;
                gr.DrawImage(image, new Rectangle(0, 0, Convert.ToInt32(image.Size.Width * Percent), Convert.ToInt32(image.Size.Height * Percent)));
                bmp.Save(FStream, ImageFormat.Jpeg);
            }

            
            //FStream.SetLength(Convert.ToInt64(FStream.Length * Percent));

            return FStream;
        }
        public static Image resizeImage(Image FileImage)
        {
            int LenHeight = FileImage.Height;
            int LenWidth = FileImage.Width;
            double Percent = 0;
            if (LenHeight > LenWidth)
                Percent = 500.00 / LenHeight;
            else
                Percent = 500.00 / LenWidth;

            Image Img = FileImage;
            if (Percent >= 1) return Img;

            Bitmap imgToResize = new Bitmap(Img);
            imgToResize.Size.Height.Equals(Convert.ToInt32(imgToResize.Size.Height * Percent));
            imgToResize.Size.Width.Equals(Convert.ToInt32(imgToResize.Size.Width * Percent));

            imgToResize.Save("C:\\001.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            
            Image Img1 = Image.FromFile("C:\\001.jpg");
            File.Delete("C:\\001.jpg");

            return Img1;
        }

        public static Image resizeImageFromFile(String OriginalFileLocation, int heigth, int width, Boolean keepAspectRatio, Boolean getCenter)
        {
            int newheigth = heigth;
            System.Drawing.Image FullsizeImage = System.Drawing.Image.FromFile(OriginalFileLocation);

            // Prevent using images internal thumbnail
            FullsizeImage.RotateFlip(System.Drawing.RotateFlipType.Rotate180FlipNone);
            FullsizeImage.RotateFlip(System.Drawing.RotateFlipType.Rotate180FlipNone);

            if (keepAspectRatio || getCenter)
            {
                int bmpY = 0;
                double resize = (double)FullsizeImage.Width / (double)width;//get the resize vector
                if (getCenter)
                {
                    bmpY = (int)((FullsizeImage.Height - (heigth * resize)) / 2);// gives the Y value of the part that will be cut off, to show only the part in the center
                    Rectangle section = new Rectangle(new Point(0, bmpY), new Size(FullsizeImage.Width, (int)(heigth * resize)));// create the section to cut of the original image
                    //System.Console.WriteLine("the section that will be cut off: " + section.Size.ToString() + " the Y value is minimized by: " + bmpY);
                    Bitmap orImg = new Bitmap((Bitmap)FullsizeImage);//for the correct effect convert image to bitmap.
                    FullsizeImage.Dispose();//clear the original image
                    using (Bitmap tempImg = new Bitmap(section.Width, section.Height))
                    {
                        Graphics cutImg = Graphics.FromImage(tempImg);//              set the file to save the new image to.
                        cutImg.DrawImage(orImg, 0, 0, section, GraphicsUnit.Pixel);// cut the image and save it to tempImg
                        FullsizeImage = tempImg;//save the tempImg as FullsizeImage for resizing later
                        orImg.Dispose();
                        cutImg.Dispose();
                        return FullsizeImage.GetThumbnailImage(width, heigth, null, IntPtr.Zero);
                    }
                }
                else newheigth = (int)(FullsizeImage.Height / resize);//  set the new heigth of the current image
            }//return the image resized to the given heigth and width
            return FullsizeImage.GetThumbnailImage(width, newheigth, null, IntPtr.Zero);
        }

        public void saveJpeg(string path, Bitmap img, long quality)
        {
            EncoderParameter qualityParam =
               new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, (long)quality);

            ImageCodecInfo jpegCodec =
               this.getEncoderInfo("image/jpeg");

            if (jpegCodec == null)
                return;

            EncoderParameters encoderParams = new EncoderParameters(1);
            encoderParams.Param[0] = qualityParam;

            img.Save(path, jpegCodec, encoderParams);
        }

        private ImageCodecInfo getEncoderInfo(string mimeType)
        {
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();

            for (int i = 0; i < codecs.Length; i++)
                if (codecs[i].MimeType == mimeType)
                    return codecs[i];
            return null;
        }
    }
}
