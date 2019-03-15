#if NET472
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Filters;
using System.Web.Routing;
using System.Data.Entity;
using System.Web.Mvc.Html;
#else
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Html;
using MvcHtmlString = Microsoft.AspNetCore.Html.IHtmlContent;
using IController = Microsoft.AspNetCore.Mvc.Controller;
using HttpResponseBase = Microsoft.AspNetCore.Http.HttpResponse;
#endif

namespace hongbao.MvcExtension
{
    /// <summary>
    /// JsonResultExtension的扩展类； 
    /// </summary>
    public static class HttpResponseUtil
    {
#if NETCOREAPP2_2
        /// <summary>
        /// 写给定字符串到 响应端;
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static void Write(this HttpResponseBase response, string content)
        {
            var contents = System.Text.Encoding.UTF8.GetBytes(content);
            response.Body.Write(contents, 0, contents.Length);
        }
#endif

    }


}
