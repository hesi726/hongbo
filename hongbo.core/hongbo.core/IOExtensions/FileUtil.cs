using hongbao.SecurityExtension;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace hongbao.IOExtension
{
    /// <summary>
    /// 对文件进行操作的类;
    /// </summary>
    public class FileUtil
    {
        /// <summary>
        /// 追加文件内容到给定的流中
        /// </summary>
        /// <param name="destFilePath">目的文件</param>
        /// <param name="srcFilePath">原文件，该文件内容追加到目的文件中</param>
        public static void AppendFile(string destFilePath, string srcFilePath)
        {
            FileStream fs = File.Open(destFilePath, FileMode.Append);
            AppendFile(fs, srcFilePath);
            fs.Close();
        }

        /// <summary>
        /// 追加文件内容到给定的流中
        /// </summary>
        /// <param name="fs">目的文件流</param>
        /// <param name="srcFilePath">原文件，该文件内容追加到目的文件流中</param>
        public static void AppendFile(FileStream fs, string srcFilePath)
        {
            FileStream srcfs = File.Open(srcFilePath, FileMode.Open);
            StreamUtil.WriteStream(fs, srcfs);
            srcfs.Close();
        }

        /// <summary>
        /// 复制文件,可以设定 是否允许覆盖；
        /// </summary>
        /// <param name="sourceFilePath"></param>
        /// <param name="targetFileName"></param>
        /// <param name="overrite"></param>
        static public void CopyAbsoluteFile(string sourceFilePath, string targetFileName, bool overrite)
        {
            if (!File.Exists(sourceFilePath)) return;
            string filename = sourceFilePath.Substring(sourceFilePath.LastIndexOf("\\"));
            if (File.Exists(targetFileName))
            {
                if (overrite)
                    File.Delete(targetFileName);
                else
                    return;
            }
            File.Copy(sourceFilePath, targetFileName, true);
        }

        /// <summary>
        /// 复制文件到给定目录,可以设定 是否允许覆盖；
        /// </summary>
        /// <param name="sourceFilePath"></param>
        /// <param name="targetDirectory"></param>
        /// <param name="overrite"></param>
        static public void CopyFile(string sourceFilePath, string targetDirectory, bool overrite)
        {
            if (!File.Exists(sourceFilePath)) return;
            string filename = sourceFilePath.Substring(sourceFilePath.LastIndexOf("\\"));
            DirectoryInfo target = new DirectoryInfo(targetDirectory);
            string targetfile = target + filename;
            if (File.Exists(targetfile))
            {
                if (overrite)
                    File.Delete(targetfile);
                else
                    return;
            }
            File.Copy(sourceFilePath, target.FullName + filename, true);
        }

        /// <summary>
        /// 读取GZIP格式的文件内容，并以UTF8方式转码，以字符串格式返回； 
        /// </summary>
        /// <param name="logFilePath">压缩文件的路径；</param>
        /// <param name="trimNullspace">截断前后的空格；</param>
        /// <returns></returns>
        public static string ReadGzipUtf8FileContent(string logFilePath, bool trimNullspace=true)
        {
            using (FileStream fs = new FileStream(logFilePath, FileMode.Open, FileAccess.Read))
            {
                using (GZipStream gzipstream = new GZipStream(fs, CompressionMode.Decompress, false))
                {
                    StreamReader sr = new StreamReader(gzipstream, System.Text.Encoding.UTF8);
                    var result = sr.ReadToEnd();
                    if (trimNullspace) result = result.Trim();
                    return result; 
                }
            }
        }

        /// <summary>
        /// 将字符串用GZIP形式压缩后写入到测试文件中； 
        /// </summary>
        /// <param name="file">文件路径</param>
        /// <param name="content">要写入的内容；</param>
        /// <param name="deleteOldFile">删除旧文件，</param>
        public static void WriteGZipUtf8File(string file, string content,bool deleteOldFile=true)
        {
            if (deleteOldFile && File.Exists(file)) File.Delete(file);
            using (FileStream fs = new FileStream(file, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                using (GZipStream gzipstream = new GZipStream(fs, CompressionMode.Compress, false))
                {
                    byte[] bytes = System.Text.UTF8Encoding.UTF8.GetBytes(content);
                    gzipstream.Write(bytes, 0, bytes.Length); 
                }
            }
        }

        /// <summary>
        /// 复制目录
        /// </summary>
        /// <param name="sourceDirectory"></param>
        /// <param name="targetDirectory"></param>
        /// <param name="overrite"></param>
        static public void CopyDirectory(string sourceDirectory, string targetDirectory, bool overrite)
        {
            DirectoryInfo source = new DirectoryInfo(sourceDirectory);
            DirectoryInfo target = new DirectoryInfo(targetDirectory);

            if (!source.Exists) return;
            if (!target.Exists)
            {
                target.Create();
                target.CreationTime = source.CreationTime;
                target.LastWriteTime = source.LastWriteTime;
            }

            //Copy   Files   
            FileInfo[] sourceFiles = source.GetFiles();
            for (int i = 0; i < sourceFiles.Length; ++i)
                File.Copy(sourceFiles[i].FullName, target.FullName + "\\" + sourceFiles[i].Name, overrite);

            //Copy   directories   
            DirectoryInfo[] sourceDirectories = source.GetDirectories();
            for (int j = 0; j < sourceDirectories.Length; ++j)
                CopyDirectory(sourceDirectories[j].FullName, target.FullName + "\\" + sourceDirectories[j].Name, overrite);
        }

        /// <summary>
        /// 创建一个给定了初始大小的文件，并返回该新创建的文件; 
        /// 如果文件已经存在，则不进行任何处理；
        /// </summary>
        /// <param name="filePath">文件路径</param>
        /// <param name="filsSize">文件大小</param>
        public static void CreateFile(string filePath, int filsSize)
        {
            CreateFile(filePath, filsSize, false);
        }

        /// <summary>
        /// 创建一个给定了初始大小的文件，如果文件已经存在，则根据参数对文件进行处理
        /// </summary>
        /// <param name="filePath">文件路径</param>
        /// <param name="filsSize">文件大小</param>
        /// <param name="deleteIfExists">true:文件存在时先删除文件；false:文件存在时不进行任何处理</param>
        /// <returns></returns>
        public static void CreateFile(string filePath, int filsSize, bool deleteIfExists)
        {
            CreateFile(filePath, filsSize, false, new DLFileStreamWriter(StreamUtil.WriteBytes));
        }

        /// <summary>
        /// 创建一个给定了初始大小的文件，如果文件已经存在且指定了先删除文件,则先删除文件然后再创建文件;
        /// 并在创建文件之后，对新创建的文件流进行处理；
        /// </summary>
        /// <param name="filePath">文件路径</param>
        /// <param name="fileSize">文件大小</param>
        /// <param name="deleteIfExists">true:文件存在时先删除文件；false:文件存在时不进行任何处理</param>
        /// <param name="fsHandle">对新创建的文件流进行处理的委托定义接口</param>
        public static void CreateFile(string filePath, int fileSize, bool deleteIfExists, DLFileStreamWriter fsHandle)
        {
            if (File.Exists(filePath))
            {
                if (deleteIfExists)
                    File.Delete(filePath);
                else
                    return;
            }
            string dirname = filePath.Substring(0, filePath.LastIndexOf("\\"));
            if (!Directory.Exists(dirname))
                Directory.CreateDirectory(dirname);
            FileStream fs = File.Create(filePath);
            if (fsHandle != null)
                fsHandle(fs, fileSize);
            fs.Close();
        }

        /// <summary>
        /// 获得文件大小
        /// </summary>
        /// <param name="filePath">文件路径</param>
        /// <returns>返回文件大小</returns>
        public static int FileSize(string filePath)
        {
            FileInfo fi = new FileInfo(filePath);
            return (int)fi.Length;
        }

        /// <summary>
        /// 合并多个文件到一个文件中,如果原来的文件已经存在，不进行任何处理;
        /// </summary>
        /// <param name="filePath">合并后的文件</param>
        /// <param name="filePathes">待合并的文件</param>
        public static void MergeFiles(string filePath, string[] filePathes)
        {
            MergeFiles(filePath, filePathes, false);
        }

        /// <summary>
        /// 合并多个文件到一个文件中,如果原来的文件已经存在，可能先删除原来的文件;也可能不进行任何处理;
        /// </summary>
        /// <param name="filePath">合并后的文件</param>
        /// <param name="filePathes">待合并的文件</param>
        /// <param name="deleteIfExists">true-原始文件存在时先删除文件;false-原始文件存在时不进行任何处理</param>
        public static void MergeFiles(string filePath, string[] filePathes, bool deleteIfExists)
        {
            if (File.Exists(filePath))
            {
                if (deleteIfExists)
                    File.Delete(filePath);
                else return;
            }
            CreateFile(filePath, 0);
            for (int i = 0; i < filePathes.Length; i++)
            {
                AppendFile(filePath, filePathes[i]);
            }
        }

        /// <summary>
        /// 移动文件到给定目录下; 
        /// </summary>
        /// <param name="sourceFilePath"></param>
        /// <param name="targetDirectory"></param>
        /// <param name="overrite"></param>
        static public void MoveFileToDirectory(string sourceFilePath, string targetDirectory, bool overrite)
        {
            if (!File.Exists(sourceFilePath)) return;
            string filename = sourceFilePath.Substring(sourceFilePath.LastIndexOf("\\"));
            DirectoryInfo target = new DirectoryInfo(targetDirectory);
            string targetfile = target + filename;
            if (File.Exists(targetfile))
            {
                if (overrite)
                    File.Delete(targetfile);
                else
                    return;
            }
            File.Move(sourceFilePath, target.FullName + filename);
        }

        /// <summary>
        /// 读取文件内容到一个字符串
        /// </summary>
        /// <returns></returns>
        public static string ReadFile(string filePath)
        {
            string result = "";
            try
            {
                if (!System.IO.File.Exists(filePath))
                {
                    return result;
                }
                StreamReader aRead = new StreamReader(filePath, System.Text.UnicodeEncoding.Default);
                result = aRead.ReadToEnd();
                aRead.Close();
            }
            catch (System.Exception ee)
            {
                string xx = ee.Message;
            }
            return result;
        }

        /// <summary>
        /// 读取文件内容到一个字符串
        /// </summary>
        /// <returns></returns>
        public static string ReadFile(string filePath, Encoding enc)
        {
            string result = "";
            try
            {
                if (!System.IO.File.Exists(filePath))
                {
                    return result;
                }
                StreamReader aRead = new StreamReader(filePath, enc);
                result = aRead.ReadToEnd();
                aRead.Close();
            }
            catch (System.Exception ee)
            {
                string xx = ee.Message;
            }
            return result;
        }


        /// <summary>
        /// 将字节写入到文件中
        /// </summary>
        /// <param name="path"></param>
        /// <param name="contents"></param>
        /// <param name="append"></param>
        public static void writeFileBinaryContent(string path, byte[] contents, bool append)
        {
            FileStream xfile = null;
            System.IO.FileStream da = null;
            try
            {
                string dirpath = path.Substring(0, path.LastIndexOf("\\"));
                if (!Directory.Exists(dirpath))
                    Directory.CreateDirectory(dirpath);
                if (!System.IO.File.Exists(path))
                {
                    xfile = File.Create(path);
                    xfile.Close();

                }
                da = null;
                if (append) da = new FileStream(path, FileMode.Append);
                else da = new FileStream(path, FileMode.Truncate);

                da.Write(contents, 0, contents.Length);
                da.Close();
            }
            finally
            {
                try { da.Close(); da.Dispose(); }
                catch 
                {
                    
                }
            }
        }

        /// <summary>
        /// 将字节写入到文件中
        /// </summary>
        /// <param name="path"></param>
        /// <param name="contents"></param>
        public static void writeFileBinaryContent(string path, byte[] contents)
        {
            writeFileBinaryContent(path, contents, true);
        }

        /// <summary>
        /// 读取文件内容到给定的缓冲区；返回读取到的文件大小；
        /// </summary>
        /// <param name="path"></param>
        /// <param name="buffer"></param>
        /// <returns></returns>
        public static int readFileBinaryContent(string path, ref byte[] buffer)
        {
            try
            {
                FileInfo fi = new FileInfo(path);
                if (!fi.Exists)
                {
                    return 0;
                }
                int fileSize = (int)fi.Length;
                System.IO.FileStream da = new FileStream(path, FileMode.Open);
                if (buffer.Length < fileSize)
                {
                    buffer = new byte[fileSize];
                }
                da.Read(buffer, 0, fileSize);
                da.Close();
                return fileSize;
            }
            catch (System.Exception ee)
            {
                string xx = ee.Message;
            }
            return 0;
        }

        /// <summary>
        /// 读取文件内容
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static byte[] readFileBinaryContent(string path)
        {
            try
            {
                if (!System.IO.File.Exists(path))
                {
                    return null;
                }
                System.IO.FileStream da = new FileStream(path, FileMode.Open);
                byte[] bytes = new byte[FileUtil.getFileSize(path)];
                da.Read(bytes, 0, bytes.Length);
                da.Close();
                da.Dispose();
                return bytes;
            }
            catch (System.Exception ee)
            {
                string xx = ee.Message;
                throw ee; 
            }
        }

        /// <summary>
        /// 读取文件内容
        /// </summary>
        /// <param name="path"></param>
        /// <param name="beginPos"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public static byte[] readFileBinaryContent(string path, int beginPos, int length)
        {
            try
            {
                if (!System.IO.File.Exists(path))
                {
                    return null;
                }
                System.IO.FileStream da = new FileStream(path, FileMode.Open);
                da.Seek(beginPos, SeekOrigin.Begin);
                byte[] bytes = new byte[length];
                int read = da.Read(bytes, 0, bytes.Length);
                da.Close();
                if (read == length) return bytes;
                Array.Resize<byte>(ref bytes, read); //这样效率应该会高一些；
                return bytes;
                //return bytes.CopyTo(
                //return bytes;
            }
            catch (System.Exception ee)
            {
                string xx = ee.Message;
            }
            return null;
        }

        /// <summary>
        /// 获得文件长度
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static int getFileSize(string path)
        {
            FileInfo fi = new FileInfo(path);
            return (int)fi.Length;
        }

        /// <summary>
        /// 获得文件长度
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static DateTime GetFileCreateTime(string path)
        {
            FileInfo fi = new FileInfo(path);
            return fi.CreationTime;
        }

        /// <summary>
        /// 读取文件内容
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static string ReadUTFFileContent(string filePath)
        {
            string result = "";
            try
            {
                if (!System.IO.File.Exists(filePath))
                {
                    return result;
                }
                StreamReader aRead = new StreamReader(filePath, System.Text.UnicodeEncoding.UTF8);
                result = aRead.ReadToEnd();
                aRead.Close();
            }
            catch (System.Exception ee)
            {
                string xx = ee.Message;
            }
            return result;
        }

        /// <summary>
        /// 重新命名文件或者目录
        /// </summary>
        /// <param name="sourcepath"></param>
        /// <param name="targetpath"></param>
        /// <param name="forceOverrite"></param>
        public static void RenameFile(string sourcepath, string targetpath, bool forceOverrite)
        {
            if (System.IO.Directory.Exists(sourcepath))
                System.IO.Directory.Move(sourcepath, targetpath);
            else if (System.IO.File.Exists(sourcepath))
                System.IO.File.Move(sourcepath, targetpath);
        }



        /// <summary>
        /// 拆分文件成各个片段文件流
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="splitCount"></param>
        public static IStreamWriter[] SplitFile(string filePath, int splitCount)
        {
            IStreamWriter[] result = new IStreamWriter[splitCount];
            int fileSize = FileUtil.FileSize(filePath);
            int pieceLen = fileSize / splitCount;

            for (int i = 0; i < splitCount; i++)
            {
                FileStream fs = File.Open(filePath, FileMode.Open);
                int startPos = pieceLen * i;
                if (i == splitCount) pieceLen = fileSize - pieceLen * i;
                result[i] = new StreamPieceWriter(startPos, pieceLen, fs);
            }
            return result;
        }


        /// <summary>
        /// 将文本写入文件
        /// </summary>
        /// <param name="path">文件路泾</param>
        /// <param name="content">写入内容</param>
        /// <returns></returns>
        public static void WriteFile(string path, string content)
        {
            WriteFile(path, content, true);
        }

        /// <summary>
        /// 将文本写入文件
        /// </summary>
        /// <param name="path">文件路泾</param>
        /// <param name="content">写入内容</param>
        /// <param name="append">覆盖还是追加?true:追加;false:覆盖</param>
        public static void WriteFile(string path, string content, bool append)
        {
            try
            {
                if (!File.Exists(path)) File.Create(path).Close();

                StreamWriter sw = new StreamWriter(path, append);
                sw.Write(content);
                sw.Close();
            }
            catch (System.Exception ee)
            {
                string xx = ee.Message;
            }
        }

        /// <summary>
        /// 将文本写入文件,追加
        /// </summary>
        /// <param name="path">文件路泾</param>
        /// <param name="content">写入内容</param>
        public static void WriteUTF8File(string path, string content)
        {
            WriteUTF8File(path, content, true);
        }

        /// <summary>
        /// 将文本写入文件
        /// </summary>
        /// <param name="path">文件路泾</param>
        /// <param name="content">写入内容</param>
        /// <param name="append">覆盖还是追加?true:追加;false:覆盖</param>
        public static void WriteUTF8File(string path, string content, bool append)
        {
            try
            {
                var fileinfo = new FileInfo(path);
                if (!fileinfo.Directory.Exists) fileinfo.Directory.Create();
                if (!File.Exists(path)) File.Create(path).Close();

                StreamWriter sw = new StreamWriter(path, append, Encoding.UTF8);
                sw.Write(content);
                sw.Close();
            }
            catch (System.Exception ee)
            {
                string xx = ee.Message;
            }
        }

        /// <summary>
        /// 将文本写入文件
        /// </summary>
        /// <param name="path">文件路泾</param>
        /// <param name="content">写入内容</param>
        /// <param name="append">覆盖还是追加?true:追加;false:覆盖</param>
        /// <param name="enc"></param>
        public static void WriteFile(string path, string content, bool append, Encoding enc)
        {
            try
            {
                if (!File.Exists(path)) File.Create(path).Close();

                StreamWriter sw = new StreamWriter(path, append, enc);
                sw.Write(content);
                sw.Close();
            }
            catch (System.Exception ee)
            {
                string xx = ee.Message;
            }
        }

        /// <summary>
        /// 将文本写入文件
        /// </summary>
        /// <param name="path">文件路泾</param>
        /// <param name="content">写入内容</param>
        /// <param name="par"></param>
        /// <param name="append">覆盖还是追加?true:追加;false:覆盖</param>
        public static void WriteFile(string path, bool append, string content, object[] par)
        {
            try
            {
                StreamWriter sw = new StreamWriter(path, append);
                sw.Write(content, par);
                sw.Close();
            }
            catch (System.Exception ee)
            {
                string xx = ee.Message;
            }
        }

        /// <summary>
        /// 生成指定文件的MD5Code
        /// </summary>
        /// <param name="path">文件地址</param>
        /// <returns>MD5码</returns>
        public static string GETFileMD5Code(string path)
        {
            return SecurityUtil.PhpMD5File(path);/*
            var content = readFileBinaryContent(path);
            return SecurityUtil.PhpMD5File(path)
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            FileStream fst = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);
            md5.ComputeHash(fst);
            fst.Close();
            byte[] hash = md5.Hash;
            md5.Clear();
            StringBuilder sb = new StringBuilder();
            foreach (byte byt in hash)
                sb.Append(String.Format("{0:X1}", byt));
            return sb.ToString();*/
        }
    }

    /// <summary>
    /// 对流进行数据写入处理的委托定义；
    /// </summary>
    /// <param name="fs">流</param>
    /// <param name="otherPar">要写入流的字节数量</param>
    public delegate void DLFileStreamWriter(Stream fs, int otherPar);

    /// <summary>
    /// 写入的字节流的通知
    /// </summary>
    /// <param name="writeBytes">已经写入的字节数目</param>
    public delegate void DLStreamWriteNotify(int writeBytes);

    /// <summary>
    /// 流写出接口
    /// </summary>
    public interface IStreamWriter
    {
        /// <summary>
        /// 写数据岛到给定流中
        /// </summary>
        /// <param name="destStream">给定要写入数据的流</param>
        /// <returns>返回成功写出的字节数量，</returns>
        int write(Stream destStream);

        /// <summary>
        /// 关闭流
        /// </summary>
        void close();

    }
}
