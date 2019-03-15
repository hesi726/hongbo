using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
#if NET472
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Filters;
using System.Web.Routing;
using System.Data.Entity;
#else
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using ControllerContext = Microsoft.AspNetCore.Mvc.ActionContext;
using HttpResponseBase = Microsoft.AspNetCore.Http.HttpResponse;
#endif

namespace hongbao.MvcExtension
{
    /// <summary>
    /// 泛型的类； 只是为了方便，并没有真正利用泛型的有效性； 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class JsonResult<T> : JsonResult
    {
        static JsonResult()
        {
            JsonConvert.DefaultSettings = () =>
            {
                var setting = new JsonSerializerSettings();
                setting.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                return setting; 
            };
        }
        
        public JsonResult(): base(null)
        {

        }

        /// <summary>
        /// 泛型数据； 
        /// </summary>
        public T TData
        {
            get { return (T) this.GetJsonResultValue(); }
            set { this.SetJsonResultValue(value); }
        }

        /// <summary>
        /// 覆盖 JsonResult 的方法； 
        /// </summary>
        /// <param name="context"></param>
        public override void ExecuteResult(ControllerContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException("context");
            }
            //if ((this.JsonRequestBehavior == JsonRequestBehavior.DenyGet) && string.Equals(context.HttpContext.Request.HttpMethod, 
            //    "GET", StringComparison.OrdinalIgnoreCase))
            //{
            //    throw new InvalidOperationException("不允许进行GET操作");
            //}
            HttpResponseBase response = context.HttpContext.Response;
            if (!string.IsNullOrEmpty(this.ContentType))
            {
                response.ContentType = this.ContentType;
            }
            else
            {
                response.ContentType = "application/json";
            }
            //if (this.ContentEncoding != null)
            //{
            //    response.ContentEncoding = this.ContentEncoding;
            //}
            var data = this.GetJsonResultValue();
            if (data != null)
            {
                //JavaScriptSerializer serializer = new JavaScriptSerializer();
                //response.Write(serializer.Serialize(this.Data));
                IsoDateTimeConverter timeConvert = new IsoDateTimeConverter();
                timeConvert.DateTimeFormat = "yyyy-MM-dd HH:mm:ss";
                string content = "";
                if (data is SerializeToJson)
                {
                    content  = ((SerializeToJson)data).SerializeToJson();
                }
                else content = JsonConvert.SerializeObject(content, Newtonsoft.Json.Formatting.None, timeConvert);
                

                response.Write(content);
            }
        }
    }

    
}
