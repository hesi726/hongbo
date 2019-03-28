using hongbao.IOExtension;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.Drawing.Utils
{
    /// <summary>
    /// 图像工具;
    /// </summary>
    public static class ImageUtil
    {

        #region GetPicThumbnail

        /// <summary>
        /// 压缩图片到给定尺寸以下； 
        /// 每次图片尺寸尺寸减半（默认)，直到图片尺寸小于给定尺寸;
        /// </summary>
        /// <param name="sFile">文件路径</param>
        /// <param name="size">压缩后的文件大小;</param>
        /// <param name="compressStep">默认为 1/2</param>
        /// <returns></returns>
        public static bool CompressImageToLowerSize(string sFile, int size, decimal compressStep = 0.5m)
        {
            if (size < 5000) return true;
            FileInfo fi = new FileInfo(sFile);
            if (fi.Length < size) return true;          
            byte[] fileContent = FileUtil.readFileBinaryContent(sFile);
            MemoryStream ms = new MemoryStream(fileContent);
            System.Drawing.Image iSource = System.Drawing.Image.FromStream(ms);
            ImageFormat tFormat = iSource.RawFormat;
            //按比例缩放
            Size tem_size = new Size(iSource.Width, iSource.Height);
            int dHeight = iSource.Height, dWidth = iSource.Width;
            bool result = GetPicThumbnail(sFile, sFile, (int) (dHeight * compressStep), (int) ( dWidth * compressStep), 100);
            fi = new FileInfo(sFile);
            if (fi.Length < size) return true;
            else return CompressImageToLowerSize(sFile, size); 
            //return true; 
        }

        /// <summary>
        /// 无损压缩图片
        /// </summary>
        /// <param name="sFile">原图片</param>
        /// <param name="dFile">压缩后保存位置</param>
        /// <param name="dHeight">高度</param>
        /// <param name="dWidth">宽度</param>
        /// <param name="flag">压缩质量 1-100,100最好,默认是75</param>
        /// <returns></returns>

        public static bool GetPicThumbnail(Stream sFile, string dFile, int dHeight, int dWidth, 
            int flag=75)
        {
            System.Drawing.Image iSource = System.Drawing.Image.FromStream(sFile);
            return GetPicThumbnail(iSource, dFile, dHeight, dWidth, flag);
        }

        /// <summary>
        /// 无损压缩图片,可以写入到相同文件；
        /// </summary>
        /// <param name="sFile">原图片</param>
        /// <param name="dFile">压缩后保存位置</param>
        /// <param name="dHeight">高度</param>
        /// <param name="dWidth"></param>
        /// <param name="flag">压缩质量 1-100</param>
        /// <returns></returns>

        public static bool GetPicThumbnail(string sFile, string dFile, int dHeight,
            int dWidth, int flag=75)
        {
            byte[] content = FileUtil.readFileBinaryContent(sFile);
            using (var stream = new MemoryStream(content))
            {
                System.Drawing.Image iSource = System.Drawing.Image.FromStream(stream); ;
                return GetPicThumbnail(iSource, dFile, dHeight, dWidth, flag);
            }
        }
        /// <summary>
        /// 无损压缩图片
        /// </summary>
        /// <param name="iSource">原图片</param>
        /// <param name="dFile">压缩后保存位置</param>
        /// <param name="dHeight">高度</param>
        /// <param name="dWidth"></param>
        /// <param name="flag">压缩质量 1-100</param>
        /// <returns></returns>

        public static bool GetPicThumbnail(Image iSource, string dFile, int dHeight, int dWidth, int flag)
        {
            ImageFormat tFormat = iSource.RawFormat;
            int sW = 0, sH = 0;
            //按比例缩放
            Size tem_size = new Size(iSource.Width, iSource.Height);            
            if (tem_size.Width > dHeight || tem_size.Width > dWidth) 
            {
                if ((tem_size.Width * dHeight) > (tem_size.Height * dWidth))
                {
                    sW = dWidth;
                    sH = (dWidth * tem_size.Height) / tem_size.Width;
                }
                else
                {
                    sH = dHeight;
                    sW = (tem_size.Width * dHeight) / tem_size.Height;
                }
            }
            else
            {
                sW = tem_size.Width;
                sH = tem_size.Height;
            }
            Bitmap ob = new Bitmap(sW, sH);
            Graphics g = Graphics.FromImage(ob);
            g.Clear(Color.WhiteSmoke);
            g.CompositingQuality = CompositingQuality.HighQuality;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.DrawImage(iSource, new Rectangle(0, 0, sW, sH), 0, 0, iSource.Width, iSource.Height, GraphicsUnit.Pixel);
            //g.DrawImage(iSource, new Rectangle((dWidth - sW) / 2, (dHeight - sH) / 2, sW, sH), 0, 0, iSource.Width, iSource.Height, GraphicsUnit.Pixel);
            g.Dispose();
            //以下代码为保存图片时，设置压缩质量
            EncoderParameters ep = new EncoderParameters();
            long[] qy = new long[1];
            qy[0] = flag;//设置压缩的比例1-100
            EncoderParameter eParam = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, qy);
            ep.Param[0] = eParam;
            try
            {
                ImageCodecInfo[] arrayICI = ImageCodecInfo.GetImageEncoders();
                ImageCodecInfo jpegICIinfo = null;
                for (int x = 0; x < arrayICI.Length; x++)
                {
                    if (arrayICI[x].FormatDescription.Equals("JPEG"))
                    {
                        jpegICIinfo = arrayICI[x];
                        break;
                    }
                }
                if (jpegICIinfo != null)
                {
                    ob.Save(dFile, jpegICIinfo, ep);//dFile是压缩后的新路径
                }
                else
                {
                    ob.Save(dFile, tFormat);
                }
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                iSource.Dispose();
                ob.Dispose();
            }
        }
        #endregion
    }
}
