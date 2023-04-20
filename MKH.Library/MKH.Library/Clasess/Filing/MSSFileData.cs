using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Transactions;


namespace MKH.Library.Clasess.Filing
{
    public enum FileTypeForImageSelector: int
    {
        PicFile = 0,
        FilmFile = 1,
        OtherFile = 2
    }

    public enum FileViewForImageSelector : int
    {
        SelectFile = 0,
        InsertFile = 1,
        UpdateFile = 2,
        DeleteFile = 3
    }

    public class FileTableList
    {
        public byte[] file_stream { get; set; }
        public string FileName { get; set; }
        public int FileId { get; set; }
        public FileTypeForImageSelector file_type { get; set; }
        public FileViewForImageSelector File_View { get; set; }
    }
    
    public class PermissionButtonList
    {
        public bool PermissionPicNew { get; set; }
        public bool PermissionPicDel { get; set; }
        public bool PermissionFileNew { get; set; }
        public bool PermissionFileDel { get; set; }
        public bool PermissionFolderNew { get; set; }
        public bool PermissionFolderDel { get; set; }
    }


//    public class MSSFileData
//    {
//        private const string ConnStr =
//          "Data Source=.\\MSSHafez; Initial Catalog=[MKH.Software];";

//        public static void InsertPhoto
//          (int Id, int PersCode, string filename)
//        {
//            const string InsertTSql = @"
//                                INSERT INTO SoftwareData(Id, PersCode)
//                                    VALUES(@Id, @PersCode);
//                                SELECT Photo.PathName(), GET_FILESTREAM_TRANSACTION_CONTEXT()
//                                FROM SoftwareData
//                                WHERE Id = @Id";


//            string serverPath;
//            byte[] serverTxn;

//            using (TransactionScope ts = new TransactionScope())
//            {
//                using (SqlConnection conn = new SqlConnection(ConnStr))
//                {
//                    conn.Open();

//                    using (SqlCommand cmd = new SqlCommand(InsertTSql, conn))
//                    {
//                        cmd.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
//                        cmd.Parameters.Add("@PersCode", SqlDbType.Int).Value = PersCode;
//                        using (SqlDataReader rdr = cmd.ExecuteReader())
//                        {
//                            rdr.Read();
//                            serverPath = rdr.GetSqlString(0).Value;
//                            serverTxn = rdr.GetSqlBinary(1).Value;
//                            rdr.Close();
//                        }
//                    }
//                    SavePhotoFile(filename, serverPath, serverTxn);
//                }
//                ts.Complete();
//            }
//        }

//        private static void SavePhotoFile(string clientPath, string serverPath, byte[] serverTxn)
//        {
//            const int BlockSize = 1024 * 512;

//            using (FileStream source =
//              new FileStream(clientPath, FileMode.Open, FileAccess.Read))
//            {
//                using (SqlFileStream dest =
//                  new SqlFileStream(serverPath, serverTxn, FileAccess.Write))
//                {
//                    byte[] buffer = new byte[BlockSize];
//                    int bytesRead;
//                    while ((bytesRead = source.Read(buffer, 0, buffer.Length)) > 0)
//                    {
//                        dest.Write(buffer, 0, bytesRead);
//                        dest.Flush();
//                    }
//                    dest.Close();
//                }
//                source.Close();
//            }
//        }

//        public static Image SelectPhoto(int Id, out int PersCode)
//        {
//            const string SelectTSql = @"
//                          SELECT PersCode,
//                            Photo.PathName(),
//                            GET_FILESTREAM_TRANSACTION_CONTEXT()
//                          FROM SoftwareData
//                          WHERE Id = @Id";

//            Image photo;
//            string serverPath;
//            byte[] serverTxn;

//            using (TransactionScope ts = new TransactionScope())
//            {
//                using (SqlConnection conn = new SqlConnection(ConnStr))
//                {
//                    conn.Open();

//                    using (SqlCommand cmd = new SqlCommand(SelectTSql, conn))
//                    {
//                        cmd.Parameters.Add("@Id", SqlDbType.Int).Value = Id;

//                        using (SqlDataReader rdr = cmd.ExecuteReader())
//                        {
//                            rdr.Read();
//                            PersCode = Convert.ToInt32(rdr.GetSqlString(0).Value);
//                            serverPath = rdr.GetSqlString(1).Value;
//                            serverTxn = rdr.GetSqlBinary(2).Value;
//                            rdr.Close();
//                        }
//                    }
//                    photo = LoadPhotoImage(serverPath, serverTxn);
//                }
//                ts.Complete();
//            }
//            return photo;
//        }

//        private static Image LoadPhotoImage(string filePath, byte[] txnToken)
//        {
//            Image photo;

//            using (SqlFileStream sfs =
//              new SqlFileStream(filePath, txnToken, FileAccess.Read))
//            {
//                photo = Image.FromStream(sfs);
//                sfs.Close();
//            }

//            return photo;
//        }


//    }

}
