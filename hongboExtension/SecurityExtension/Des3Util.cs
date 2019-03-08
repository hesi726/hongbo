using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace hongbao.Security
{
    /// <summary>
    /// 构造一个对称算法,使用3Des加密
    ///如果当前的 Key 属性为 NULL，可调用 GenerateKey 方法以创建新的随机 Key。 
    ///如果当前的 IV 属性为 NULL，可调用 GenerateIV 方法以创建新的随机 IV
    /// </summary>
    public class Des3Util
    {

        #region CBC模式,CBC模式下IV加密矢量有效
        /// <summary>  
        /// DES3 CBC模式加密 , 此时 IV 加密矢量有用； 
        /// </summary>  
        /// <param name="key">密钥</param>  
        /// <param name="iv">IV</param>  
        /// <param name="data">明文的byte数组</param>  
        /// <returns>密文的byte数组</returns>  
        public static byte[] Des3EncodeCBC(byte[] key, byte[] iv, byte[] data)
        {
            //复制于MSDN  
            try
            {
                // Create a MemoryStream.  
                MemoryStream mStream = new MemoryStream();
                TripleDESCryptoServiceProvider tdsp = new TripleDESCryptoServiceProvider();
                tdsp.Mode = CipherMode.CBC;             //默认值  
                tdsp.Padding = PaddingMode.PKCS7;       //默认值  
                                                        // Create a CryptoStream using the MemoryStream   
                                                        // and the passed key and initialization vector (IV).  
                CryptoStream cStream = new CryptoStream(mStream,
                    tdsp.CreateEncryptor(key, iv),
                    CryptoStreamMode.Write);
                // Write the byte array to the crypto stream and flush it.  
                cStream.Write(data, 0, data.Length);
                cStream.FlushFinalBlock();
                // Get an array of bytes from the   
                // MemoryStream that holds the   
                // encrypted data.  
                byte[] ret = mStream.ToArray();
                // Close the streams.  
                cStream.Close();
                mStream.Close();
                // Return the encrypted buffer.  
                return ret;
            }
            catch (CryptographicException e)
            {
                Console.WriteLine("A Cryptographic error occurred: {0}", e.Message);
                return null;
            }
        }
        /// <summary>  
        /// DES3 CBC模式解密  , 此时 IV 加密矢量有用；
        /// </summary>  
        /// <param name="key">密钥</param>  
        /// <param name="iv">IV</param>  
        /// <param name="data">密文的byte数组</param>  
        /// <returns>明文的byte数组</returns>  
        public static byte[] Des3DecodeCBC(byte[] key, byte[] iv, byte[] data)
        {
            try
            {
                // Create a new MemoryStream using the passed   
                // array of encrypted data.  
                MemoryStream msDecrypt = new MemoryStream(data);
                TripleDESCryptoServiceProvider tdsp = new TripleDESCryptoServiceProvider();
                tdsp.Mode = CipherMode.CBC;
                tdsp.Padding = PaddingMode.PKCS7;
                // Create a CryptoStream using the MemoryStream   
                // and the passed key and initialization vector (IV).  
                CryptoStream csDecrypt = new CryptoStream(msDecrypt,
                    tdsp.CreateDecryptor(key, iv),
                    CryptoStreamMode.Read);
                // Create buffer to hold the decrypted data.  
                byte[] fromEncrypt = new byte[data.Length];
                // Read the decrypted data out of the crypto stream  
                // and place it into the temporary buffer.  
                csDecrypt.Read(fromEncrypt, 0, fromEncrypt.Length);
                //Convert the buffer into a string and return it.  
                return fromEncrypt;
            }
            catch (CryptographicException e)
            {
                Console.WriteLine("A Cryptographic error occurred: {0}", e.Message);
                return null;
            }
        }
        #endregion

        #region ECB模式,ECB模式下IV加密矢量无用  
        /// <summary>  
        /// DES3 ECB模式加密   , 此时 IV 加密矢量无用；
        /// </summary>  
        /// <param name="key">密钥</param>  
        /// <param name="iv">IV(当模式为ECB时，IV无用)</param>  
        /// <param name="data">明文的byte数组</param>  
        /// <returns>密文的byte数组</returns>  
        public static byte[] Des3EncodeECB(byte[] key, byte[] iv, byte[] data)
        {
            try
            {
                if (iv == null || iv.Length == 0) iv = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 };
                // Create a MemoryStream.  
                MemoryStream mStream = new MemoryStream();
                TripleDESCryptoServiceProvider tdsp = new TripleDESCryptoServiceProvider();
                tdsp.Mode = CipherMode.ECB;
                tdsp.Padding = PaddingMode.PKCS7;
                // Create a CryptoStream using the MemoryStream   
                // and the passed key and initialization vector (IV).  
                CryptoStream cStream = new CryptoStream(mStream,
                    tdsp.CreateEncryptor(key, iv),
                    CryptoStreamMode.Write);
                // Write the byte array to the crypto stream and flush it.  
                cStream.Write(data, 0, data.Length);
                cStream.FlushFinalBlock();
                // Get an array of bytes from the   
                // MemoryStream that holds the   
                // encrypted data.  
                byte[] ret = mStream.ToArray();
                // Close the streams.  
                cStream.Close();
                mStream.Close();
                // Return the encrypted buffer.  
                return ret;
            }
            catch (CryptographicException e)
            {               
                Console.WriteLine("A Cryptographic error occurred: {0}", e.Message);
                throw e;
            }
        }
        /// <summary>  
        /// DES3 ECB模式解密  
        /// </summary>  
        /// <param name="key">密钥</param>  
        /// <param name="iv">IV(当模式为ECB时，IV无用)</param>  
        /// <param name="data">密文的byte数组</param>  
        /// <returns>明文的byte数组</returns>  
        public static byte[] Des3DecodeECB(byte[] key, byte[] iv, byte[] data)
        {
            try
            {
                if (iv == null || iv.Length == 0) iv = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 };
                // Create a new MemoryStream using the passed   
                // array of encrypted data.  
                MemoryStream msDecrypt = new MemoryStream(data);
                TripleDESCryptoServiceProvider tdsp = new TripleDESCryptoServiceProvider();
                tdsp.Mode = CipherMode.ECB;
                tdsp.Padding = PaddingMode.PKCS7;
                // Create a CryptoStream using the MemoryStream   
                // and the passed key and initialization vector (IV).  
                CryptoStream csDecrypt = new CryptoStream(msDecrypt,
                    tdsp.CreateDecryptor(key, iv),
                    CryptoStreamMode.Read);
                // Create buffer to hold the decrypted data.  
                byte[] fromEncrypt = new byte[data.Length];
                // Read the decrypted data out of the crypto stream  
                // and place it into the temporary buffer.  
                csDecrypt.Read(fromEncrypt, 0, fromEncrypt.Length);
                //Convert the buffer into a string and return it.  
                return fromEncrypt;
            }
            catch (CryptographicException e)
            {
                Console.WriteLine("A Cryptographic error occurred: {0}", e.Message);
                throw e;
            }
        }
        #endregion
       
        /// <summary>  
        /// 类测试  
        /// </summary>  
        public static void Test()
        {
            System.Text.Encoding utf8 = System.Text.Encoding.UTF8;
            //key为abcdefghijklmnopqrstuvwx的Base64编码  
            byte[] key = Convert.FromBase64String("YWJjZGVmZ2hpamtsbW5vcHFyc3R1dnd4");
            byte[] iv = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };      //当模式为ECB时，IV无用  
            byte[] data = utf8.GetBytes("中国ABCabc123");
            System.Console.WriteLine("ECB模式:");
            byte[] str1 = Des3Util.Des3EncodeECB(key, iv, data);
            byte[] str2 = Des3Util.Des3DecodeECB(key, iv, str1);
            System.Console.WriteLine(Convert.ToBase64String(str1));
            System.Console.WriteLine(System.Text.Encoding.UTF8.GetString(str2));
            System.Console.WriteLine();
            System.Console.WriteLine("CBC模式:");
            byte[] str3 = Des3Util.Des3EncodeCBC(key, iv, data);
            byte[] str4 = Des3Util.Des3DecodeCBC(key, iv, str3);
            System.Console.WriteLine(Convert.ToBase64String(str3));
            System.Console.WriteLine(utf8.GetString(str4));
            System.Console.WriteLine();
        }
    }
}
