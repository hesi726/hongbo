using hongbao.WebExtension;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThoughtWorks.QRCode.Codec;
using ThoughtWorks.QRCode.Codec.Data;

namespace hongbao.DrawingExtension
{
    /// <summary>
    /// 识别二维码;
    /// </summary>
    public static class QrcodeUtil
    {
        /// <summary>
        /// 根据二维码链接扫码获取二维码图片中的URL;
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public static string Scan(string url)
        {

            var bytes = HttpUtil.ReadBinary(url);
            using (var ms = new MemoryStream(bytes))
            {
                Bitmap map = new Bitmap(ms);
                if (map == null)
                {
                    return null;
                }
                QRCodeDecoder decoder = new QRCodeDecoder();//实例化QRCodeDecoder  
                //通过.decoder方法把颜色信息转换成字符串信息  
                var decoderStr = decoder.decode(new ThoughtWorks.QRCode.Codec.Data.QRCodeBitmapImage(map), System.Text.Encoding.UTF8);
                return decoderStr; 
                /*
                //LuminanceSource source = new RGBLuminanceSource(bytes, map.Width, map.Height);
                //BinaryBitmap bitmap = new BinaryBitmap(new HybridBinarizer(source));
                //Result result;
                //result = new MultiFormatReader().decode(bitmap);
                return result.Text;
                */
            }
        }
    }
}
