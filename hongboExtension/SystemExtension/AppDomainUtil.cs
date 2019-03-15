using hongbao.IOExtension;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;

namespace hongbao.SystemExtension
{
    /// <summary>
    /// 
    /// </summary>
    public static class AppDomainUtil
    {
        private static string _appDomainAppPath;

        /// <summary>
        /// 获取 AppDomainAppPath 目录;
        /// 如果是 WebApp， 则返回 WebApp 的根目录，例如 E:\TotalDevelop\Ehay\Ehay\
        /// 如果是 EXE, 则返回 exe的执行目录;例如, e:\totaldevelop\ehay\ehaydatahandle\bin\debug 
        /// </summary>
        public static string AppDomainAppPath
        {
            get
            {
                if (_appDomainAppPath == null)
                {
                    /* if (HttpRuntime..AppDomainAppPath != null)
                     {
                         _appDomainAppPath = HttpRuntime.AppDomainAppPath;
                     }
                     else*/
                    {
                        _appDomainAppPath = AppDomain.CurrentDomain.BaseDirectory;
                    }
                }
                return _appDomainAppPath;
            }
            set
            {
                _appDomainAppPath = value;
            }
        }

        /// <summary>
        /// 映射目录, 例如 /bin 到 
        /// </summary>
        /// <param name="virtualPath"></param>
        /// <returns></returns>
        public static string GetMapPath(string virtualPath)
        {
            if (virtualPath == null)
            {
                return "";
            }
            else if (virtualPath.StartsWith("~/"))
            {
                return virtualPath.Replace("~/", AppDomainAppPath).Replace("/", "\\");
            }
            else
            {
                return Path.Combine(AppDomainAppPath, virtualPath.Replace("/", "\\"));
            }
        }

        /// <summary>
        /// 获得文件和最后修改时间; 
        /// </summary>
        /// <param name="virtualPath"></param>
        /// <returns></returns>
        public static ContentAndModifyDatetime GetMapPathContentAndLastModifyTime(string virtualPath)
        {
            var nameFile = AppDomainUtil.GetMapPath(virtualPath);
            if (File.Exists(nameFile))
            {
                string val = FileUtil.ReadFile(nameFile);
                return new ContentAndModifyDatetime { Content = val, LastModifyDatetime = new FileInfo(nameFile).LastWriteTime };
            }
            return null;
        }

#if NET472
        /// <summary>
        /// 当前的 HttpContext; 
        /// </summary>
        public static HttpContext HttpContext
        {
            get
            {
                HttpContext context = HttpContext.Current;
                if (context == null)
                {
                    HttpRequest request = new HttpRequest("Default.aspx", "http://sdk.weixin.senparc.com/default.aspx", null);
                    StringWriter sw = new StringWriter();
                    HttpResponse response = new HttpResponse(sw);
                    context = new HttpContext(request, response);
                }
                return context;
            }
        }
#else
        ///// <summary>
        ///// 当前的 HttpContext; 
        ///// </summary>
        //public static HttpContext HttpContextx
        //{
        //    get
        //    {
        //        HttpContext context = HttpContext.;
        //        if (context == null)
        //        {
        //            HttpRequest request = new HttpRequest("Default.aspx", "http://sdk.weixin.senparc.com/default.aspx", null);
        //            StringWriter sw = new StringWriter();
        //            HttpResponse response = new HttpResponse(sw);
        //            context = new HttpContext(request, response);
        //        }
        //        return context;
        //    }
        //}
#endif

        /// <summary>
        /// 内容和修改时间； 
        /// </summary>
        public class ContentAndModifyDatetime
        {
            /// <summary>
            /// 
            /// </summary>
            public string Content { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public DateTime LastModifyDatetime { get; set; }
        }
    }
}
