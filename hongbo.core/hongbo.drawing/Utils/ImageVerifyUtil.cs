using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace hongbao.WebExtension
{
    /// <summary>
    /// http://www.CodeHighlighter.com/
    /// 图形验证器的类
    /// </summary>
    public static class ImageVerifyUtil
    {
        /// <summary>
        /// 生成随机码
        /// </summary>
        /// <param name="length">随机码个数</param>
        /// <returns></returns>
        public static string CreateRandomCode(int length)
        {
            int rand;
            char code;
            string randomcode = String.Empty;

            //生成一定长度的验证码
            System.Random random = new Random();
            for (int i = 0; i < length; i++)
            {
                rand = random.Next();

                if (rand % 3 == 0)
                {
                    code = (char)('A' + (char)(rand % 26));
                }
                else
                {
                    code = (char)('0' + (char)(rand % 10));
                }

                randomcode += code.ToString();
            }
            return randomcode;
        }

        /// <summary>
        /// 创建随机码图片
        /// </summary>
        /// <param name="response"></param>
        /// <param name="randomcode">随机码</param>
        /// <param name="withLittleDot"></param>
        /// <param name="rotate"></param>
        public static byte[] CreateImage(string randomcode, bool withLittleDot = true, bool rotate = true)
        {
            // response.Clear(); //清除之前的内容
            int ConstRandAngle = 45; //随机转动角度
            int mapwidth = (int)(randomcode.Length * 14);
            using (Bitmap map = new Bitmap(mapwidth, 22))//创建图片背景
            {
                using (Graphics graph = Graphics.FromImage(map))
                {
                    graph.Clear(Color.AliceBlue);//清除画面，填充背景
                    graph.DrawRectangle(new Pen(Color.Black, 0), 0, 0, map.Width - 1, map.Height - 1);//画一个边框
                                                                                                      //graph.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;//模式

                    Random rand = new Random();

                    Color[] colors = new Color[] {
                        Color.Linen,        Color.LightBlue,    Color.LightCyan,    Color.LightCoral,
                        Color.LightGreen,   Color.LightGray,    Color.LightPink,    Color.LightSalmon,
                        Color.LightSkyBlue
                    };

                    //验证码旋转，防止机器识别
                    char[] chars = randomcode.ToCharArray();//拆散字符串成单字符数组

                    //文字距中
                    StringFormat format = new StringFormat(StringFormatFlags.NoClip);
                    format.Alignment = StringAlignment.Center;
                    format.LineAlignment = StringAlignment.Center;

                    //定义文字的颜色
                    Color[] c = {
                        Color.Black, Color.Red, Color.DarkBlue, Color.Green,
                        Color.Orange, Color.Brown, Color.DarkCyan, Color.Purple,
                        Color.SaddleBrown, Color.Gray
                    };
                    //定义字体
                    string[] font = { "Verdana", "Microsoft Sans Serif", "Comic Sans MS", "Arial", "宋体" };
                    int[] fontSize = new int[] { 12, 13, 14, 15, 16, 17 };

                    if (withLittleDot)
                    {
                        //背景噪点生成
                        var random = new Random();
                        for (int i = 0; i < 80; i++)
                        {
                            //Pen blackPen = new Pen(colors[rand.Next(colors.Length)], 0);
                            int x = rand.Next(0, map.Width);
                            int y = rand.Next(0, map.Height);
                            //graph.DrawRectangle(blackPen, x, y, 2, 2);
                            //var ran = rand.Next(10);
                            //graph.DrawString(chars[i].ToString(), f, b, 1, 1, format);
                            int cindex = rand.Next(c.Length);
                            int findex = rand.Next(5);
                            Font f = new System.Drawing.Font(font[findex], (rand.Next(2) + 1), System.Drawing.FontStyle.Italic);//字体样式(参数2为字体大小)
                            Brush b = new System.Drawing.SolidBrush(c[cindex]);
                            var ran = rand.Next(10);
                            graph.DrawString(ran.ToString(), f, b, x, y);
                        }
                    }

                    for (int i = 0; i < chars.Length; i++)
                    {
                        int cindex = rand.Next(c.Length);
                        int findex = rand.Next(5);

                        Font f = new System.Drawing.Font(font[findex], fontSize[rand.Next(fontSize.Length)], System.Drawing.FontStyle.Bold);//字体样式(参数2为字体大小)
                        Brush b = new System.Drawing.SolidBrush(c[cindex]);

                        Point dot = new Point(14, 14);
                        var randAngle = ConstRandAngle + rand.Next(20);
                        //graph.DrawString(dot.X.ToString(),fontstyle,new SolidBrush(Color.Black),10,150);//测试X坐标显示间距的
                        float angle = rand.Next(-randAngle, randAngle);//转动的度数
                        if (!rotate) angle = 0;

                        graph.TranslateTransform(dot.X, dot.Y);//移动光标到指定位置
                        graph.RotateTransform(angle);
                        graph.DrawString(chars[i].ToString(), f, b, 1, 1, format);
                        //graph.DrawString(chars[i].ToString(),fontstyle,new SolidBrush(Color.Blue),1,1,format);
                        graph.RotateTransform(-angle);//转回去
                        graph.TranslateTransform(-4, -dot.Y);//移动光标到指定位置，每个字符紧凑显示，避免被软件识别
                    }
                    //生成图片
                    using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
                    {
                        map.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        //response.Clear(); //.ClearContent();
                        //response.ContentType = "image/jpeg";
                        //response.Body.Write(ms.ToArray(), 0, (int) ms.Length);
                        // graph.Dispose();
                        // map.Dispose();
                        return ms.ToArray();
                    }
                }
            }
        }
    }
}
