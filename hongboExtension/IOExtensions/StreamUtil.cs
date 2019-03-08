using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;

namespace hongbao.IOExtension
{
    /// <summary>
    /// 流处理类;
    /// </summary>
    public class StreamUtil
    {
        /// <summary>
        /// 读取指定长度或者一直读取到结尾流内容到字节数组;
        /// </summary>
        /// <param name="fs"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public static byte[] ReadStream(Stream fs,int length=Int32.MaxValue)
        {
            MemoryStream ms = new MemoryStream();
            StreamUtil.WriteStream(fs, ms, 0, length);
            return ms.GetBuffer();
        }

        /// <summary>
        /// 往指定流里面写上指定数量的字节；
        /// </summary>
        /// <param name="fs">指定流</param>
        /// <param name="fileSize">要写入的字节数量</param>
        public static void WriteBytes(Stream fs, int fileSize)
        {
            int leftCount = (int)fileSize;
            int bufSize = 100000;
            byte[] buffers = new byte[bufSize]; //10K大小            
            while (leftCount > 0)
            {
                fs.Write(buffers, 0, leftCount > bufSize ? bufSize : leftCount);
                leftCount -= bufSize;
            }
        }

        /// <summary>
        /// 将文件的内容写出到目的流中
        /// </summary>
        /// <param name="destStream">目的流</param>
        /// <param name="filepath">文件路径</param>
        /// <returns>成功写出的字节长度</returns>
        public static int WriteFileToStream(Stream destStream, string filepath)
        {
            return WriteFileToStream(destStream, filepath, 0);
        }

        /// <summary>
        /// 将文件的内容写出到目的流中
        /// </summary>
        /// <param name="destStream">目的流</param>
        /// <param name="filepath">文件路径</param>
        /// <param name="startPos">文件内容的起始读取位置</param>
        /// <returns>成功写出的字节长度</returns>
        public static int WriteFileToStream(Stream destStream, string filepath, int startPos)
        {
            return WriteFileToStream(destStream, filepath, startPos, -1);
        }

        /// <summary>
        /// 将文件的内容写出到目的流中
        /// </summary>
        /// <param name="destStream">目的流</param>
        /// <param name="filepath">文件路径</param>
        /// <param name="startPos">文件内容的起始读取位置</param>
        /// <param name="len">文件内容的读取字节长度</param>
        /// <returns>成功写出的字节长度</returns>
        public static int WriteFileToStream(Stream destStream, string filepath, int startPos, int len)
        {
            return WriteFileToStream(destStream, filepath, startPos, len, null);
        }

        /// <summary>
        ///  将文件的内容写出到目的流中
        /// </summary>
        /// <param name="destStream">目的流</param>
        /// <param name="filepath">文件路径</param>
        /// <param name="start">文件内容的起始读取位置</param>
        /// <param name="len">文件内容的读取字节长度</param>
        /// <param name="aWriteNotify">写内容进度通知委托处理机</param>
        /// <returns>成功写出的字节长度</returns>
        public static int WriteFileToStream(Stream destStream, string filepath, int start, int len, DLStreamWriteNotify aWriteNotify)
        {
            FileStream fs = null;
            try
            {
                fs = File.Open(filepath, FileMode.Open, FileAccess.Read, FileShare.Read);
                return WriteStream(destStream, fs, start, len, aWriteNotify);
            }
            finally
            {
                try { if (fs != null) fs.Close(); }
                catch  { }
            }
        }

        /// <summary>
        ///  将字节流的内容写入到文件中
        /// </summary>
        /// <param name="desfilepath">目的文件路径</param>        
        /// <param name="srcStream">源字节流</param> 
        /// <returns>成功写到文件中的字节长度</returns>
        public static int WriteStreamToFile(string desfilepath, Stream srcStream)
        {
            return WriteStreamToFile(desfilepath, srcStream, 0);
        }

        /// <summary>
        ///  将字节流的内容写入到文件中
        /// </summary>
        /// <param name="desfilepath">目的文件路径</param>        
        /// <param name="srcStream">源字节流</param> 
        /// <param name="start">文件内容的起始写位置</param>
        /// <returns>成功写到文件中的字节长度</returns>
        public static int WriteStreamToFile(string desfilepath, Stream srcStream, int start)
        {
            return WriteStreamToFile(desfilepath, srcStream, start, -1);
        }

        /// <summary>
        ///  将字节流的内容写入到文件中
        /// </summary>
        /// <param name="desfilepath">目的文件路径</param>        
        /// <param name="srcStream">源字节流</param> 
        /// <param name="start">文件内容的起始写位置</param>
        /// <param name="len">文件内容的写字节长度</param>
        /// <returns>成功写到文件中的字节长度</returns>
        public static int WriteStreamToFile(string desfilepath, Stream srcStream, int start, int len)
        {
            return WriteStreamToFile(desfilepath, srcStream, start, len, null);
        }


        /// <summary>
        ///  将字节流的内容写入到文件中
        /// </summary>
        /// <param name="desfilepath">目的文件路径</param>        
        /// <param name="srcStream">源字节流</param>        
        /// <param name="start">文件内容的起始写位置</param>
        /// <param name="len">文件内容的写字节长度</param>
        /// <param name="aWriteNotify">写内容进度通知委托处理机</param>
        /// <returns>成功写到文件中的字节长度</returns>
        public static int WriteStreamToFile(string desfilepath, Stream srcStream, int start, int len, DLStreamWriteNotify aWriteNotify)
        {
            FileStream fs = null;
            try
            {
                if (!File.Exists(desfilepath)) fs = File.Create(desfilepath);
                else fs = File.Open(desfilepath, FileMode.Open, FileAccess.Write, FileShare.Write);
                fs.Seek(start, SeekOrigin.Begin);  //注意，此处进行偏移；下面参数穿入了　０

                return WriteStream(fs, srcStream, 0, len, aWriteNotify);
            }
            finally
            {
                try { if (fs != null) fs.Close(); }
                catch  { }
            }
        }

        /// <summary>
        /// 读取流的内容，并将其写入到某个字符串中；返回整个字符串 
        /// </summary>
        /// <param name="destStream"></param>
        /// <returns></returns>
        public static string WriteStreamToString(Stream destStream)
        {
            System.IO.StreamReader sr = new StreamReader(destStream);
            StringWriter sw = new StringWriter();
            string aline = sr.ReadLine();
            while (aline != null)
            {
                sw.WriteLine(aline);
                aline = sr.ReadLine();
            }
            return sw.ToString();
        }


        /// <summary>
        /// 将原始流的数据写出到目的流中
        /// </summary>
        /// <param name="destStream">目的流</param>
        /// <param name="srcStream">原始流</param>
        /// <returns>返回成功写出的字节数量</returns>
        public static int WriteStream(Stream destStream, Stream srcStream)
        {
            return WriteStream(destStream, srcStream, 0);
        }

        /// <summary>
        /// 将原始流的数据写出到目的流中
        /// </summary>
        /// <param name="destStream">目的流</param>
        /// <param name="srcStream">原始流</param>
        /// <param name="start"></param>
        /// <returns>返回成功写出的字节数量</returns>/// 
        public static int WriteStream(Stream destStream, Stream srcStream, int start)
        {
            return WriteStream(destStream, srcStream, 0, -1);
        }

        /// <summary>
        /// 将原始流的数据写出到目的流中
        /// </summary>
        /// <param name="destStream">目的流</param>
        /// <param name="srcStream">原始流</param>
        /// <param name="start">从原字节流读数据的开始位置</param>
        /// <param name="len">从原字节流读数据的长度</param>
        /// <returns>返回成功写出的字节数量</returns>
        public static int WriteStream(Stream destStream, Stream srcStream, int start, int len)
        {
            return WriteStream(destStream, srcStream, start, len, null);
        }



        /// <summary>
        /// 将原始流的数据写出到目的流中
        /// </summary>
        /// <param name="destStream">目的流</param>
        /// <param name="srcStream">原始流</param>
        /// <param name="start">从原字节流读数据的开始位置</param>
        /// <param name="len">从原字节流读数据的长度</param>
        /// <param name="aWriteNotify"></param>
        /// <returns>返回成功写出的字节数量</returns>
        public static int WriteStream(Stream destStream, Stream srcStream, int start, int len, DLStreamWriteNotify aWriteNotify)
        {
            return WriteStream(destStream, srcStream, 2048, start, len, aWriteNotify);
        }

        /// <summary>
        /// 将原始流的数据写出到目的流中
        /// </summary>
        /// <param name="destStream">目的流</param>
        /// <param name="srcStream">原始流</param>
        /// <param name="blockSize">块大小</param>
        /// <param name="start">从原字节流读数据的开始位置</param>
        /// <param name="len">从原字节流读数据的长度</param>
        /// <param name="aWriteNotify"></param>
        /// <returns>返回成功写出的字节数量</returns>
        public static int WriteStream(Stream destStream, Stream srcStream, int blockSize, int start, int len, DLStreamWriteNotify aWriteNotify)
        {
            byte[] bufs = null;
            if (blockSize < 0) bufs = new byte[len];
            else bufs = new byte[blockSize];
            int totalWriteCount = 0; //总共已经写的字节数量
            int leftCount = len;  //剩余字节数量
           // System.Console.WriteLine(DateTime.Now.ToString() + "想要读取: " + len + "字节, 分块:" + blockSize + "字节");
            try
            {
                if (start != 0)
                {
                    if (!(srcStream is NetworkStream))   //网络流不支持定位功能；

                        srcStream.Seek(start, SeekOrigin.Begin); //对流进行定位
                }
                int oneReadBytes = (leftCount > blockSize || len <= 0) ? blockSize : leftCount;  //本次应该读取的字节数量

                if (blockSize < 0) oneReadBytes = len;
                int readCount = srcStream.Read(bufs, 0, oneReadBytes);
                while (readCount > 0)
                {
                    destStream.Write(bufs, 0, readCount);
                    destStream.Flush();
                    totalWriteCount += readCount;


                    if (aWriteNotify != null)
                        aWriteNotify(totalWriteCount);
                    if (totalWriteCount >= len && len > 0)
                        break;
                    leftCount = len - totalWriteCount;
                    //System.Console.WriteLine(DateTime.Now.ToString() + " 本次想读: " + readCount + ",实际读:" + readCount + ", 总共已读:" + totalWriteCount + ",剩余"
                    //      + leftCount + " 字节"
                    //   );
                    oneReadBytes = (leftCount > blockSize || len <= 0) ? (blockSize < 0 ? len : blockSize) : leftCount;  //本次应该读取的字节数量

                    if (blockSize < 0)
                    {
                        oneReadBytes = leftCount;
                    }
                    else
                    {
                        oneReadBytes = (leftCount > blockSize || len <= 0) ? blockSize : leftCount;  //本次应该读取的字节数量

                    }
                    readCount = srcStream.Read(bufs, 0, oneReadBytes);
                    //System.Console.WriteLine(totalWriteCount);
                }
                // System.Console.WriteLine(totalWriteCount);
            }
            catch (Exception ee)
            {
                System.Console.Write(ee.Message);
                System.Console.Write(ee.StackTrace);
            }
            //System.Console.WriteLine("总共读取字节" + totalWriteCount);
            //System.Console.WriteLine(DateTime.Now.ToString());
            return totalWriteCount;
        }

        /// <summary>
        /// 将原始流的数据写出到目的流中(含验证)
        /// </summary>
        /// <param name="destStream">目的流</param>
        /// <param name="srcStream">原始流</param>
        /// <param name="blockSize">块大小</param>
        /// <param name="start">从原字节流读数据的开始位置</param>
        /// <param name="len">从原字节流读数据的长度</param>
        /// <param name="aWriteNotify"></param>
        /// <param name="checkSum">验证码</param>
        /// <returns>返回成功写出的字节数量</returns>
        public static int WriteStream(Stream destStream, Stream srcStream, int blockSize, int start, int len, DLStreamWriteNotify aWriteNotify, int checkSum)
        {
            byte[] bufs = null;

            if (blockSize < 0) bufs = new byte[len];
            else bufs = new byte[blockSize];
            int totalWriteCount = 0; //总共已经写的字节数量
            int leftCount = len;  //剩余字节数量
            //System.Console.WriteLine(DateTime.Now.ToString() + "想要读取: " + len + "字节, 分块:" + blockSize + "字节");
            try
            {
                if (start != 0)
                {
                    if (!(srcStream is NetworkStream))   //网络流不支持定位功能；


                        srcStream.Seek(start, SeekOrigin.Begin); //对流进行定位
                }
                int oneReadBytes = (leftCount > blockSize || len <= 0) ? blockSize : leftCount;  //本次应该读取的字节数量


                if (blockSize < 0) oneReadBytes = len;
                int readCount = srcStream.Read(bufs, 0, oneReadBytes);
                if (getCheckSum(bufs) != checkSum)
                    return 0;
                while (readCount > 0)
                {
                    destStream.Write(bufs, 0, readCount);
                    destStream.Flush();
                    totalWriteCount += readCount;


                    if (aWriteNotify != null)
                        aWriteNotify(totalWriteCount);
                    if (totalWriteCount >= len && len > 0)
                        break;
                    leftCount = len - totalWriteCount;
                   // System.Console.WriteLine(DateTime.Now.ToString() + " 本次想读: " + readCount + ",实际读:" + readCount + ", 总共已读:" + totalWriteCount + ",剩余"
                  // //       + leftCount + " 字节"
                   //    );
                    oneReadBytes = (leftCount > blockSize || len <= 0) ? (blockSize < 0 ? len : blockSize) : leftCount;  //本次应该读取的字节数量


                    if (blockSize < 0)
                    {
                        oneReadBytes = leftCount;
                    }
                    else
                    {
                        oneReadBytes = (leftCount > blockSize || len <= 0) ? blockSize : leftCount;  //本次应该读取的字节数量


                    }
                    readCount = srcStream.Read(bufs, 0, oneReadBytes);
                    System.Console.WriteLine(totalWriteCount);
                }
                // System.Console.WriteLine(totalWriteCount);
            }
            catch (Exception ee)
            {
                System.Console.Write(ee.Message);
                System.Console.Write(ee.StackTrace);
            }
           // System.Console.WriteLine("总共读取字节" + totalWriteCount);
           // System.Console.WriteLine(DateTime.Now.ToString());
            return totalWriteCount;

        }
        private static int getCheckSum(byte[] buffer)
        {
            int length = buffer.Length >= 0 ? 10 : buffer.Length;
            int result = 0;
            for (int i = 0; i < length; i++)
            {
                result += buffer[i];
            }
            return result;
        }
    }
}
