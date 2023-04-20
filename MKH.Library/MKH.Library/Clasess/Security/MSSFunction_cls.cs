using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
using System.Xml.Linq;
using System.Collections.Specialized;
using System.Threading;
using System.Management;

namespace MKH.Library.Clasess.Security
{
    public class MSSFunction_Cls
    {

        public enum EncDecryption
        {
            PublicEncDec = 0,
            PrivateEncDec = 1
        }

        #region Security

       
        public static string ExtractCodeOfKey(string PathFile)
        {
            string text = System.IO.File.ReadAllText(PathFile);

            RSaEncryptionLib.BaseCom BS = new RSaEncryptionLib.BaseCom();
            BS.LoadPublicKey();
            BS.LoadPrivateKey();


            string Result = "";
            try
            {
                Result = BS.PrivateDecryption(text);
            }
            catch (Exception ex)
            {
                global::System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            return Result;
        }
        

        public static string DecriptionText(string TextStr, EncDecryption ED)
        {
            RSaEncryptionLib.BaseCom BS = new RSaEncryptionLib.BaseCom();
            BS.LoadPublicKey();
            BS.LoadPrivateKey();


            string Result = "";
            try
            {
                //if (ED == EncDecryption.PrivateEncDec)
                    Result = BS.PrivateDecryption(TextStr);
                //else
                 //   Result = BS.PublicDecryption(TextStr);
            }
            catch (Exception ex)
            {
                global::System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            return Result;
        }

        public static string EncriptionText(string TextStr, EncDecryption ED)
        {
            RSaEncryptionLib.BaseCom BS = new RSaEncryptionLib.BaseCom();
            BS.LoadPublicKey();
            BS.LoadPrivateKey();


            string Result = "";
            try
            {
                //if (ED == EncDecryption.PrivateEncDec)
                    Result = BS.PublicEncrypt(TextStr);
                //else
                //Result = BS.PrivateEncrypt(TextStr);
            }
            catch (Exception ex)
            {
                global::System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            return Result;
        }

        #endregion





 
    }
}



