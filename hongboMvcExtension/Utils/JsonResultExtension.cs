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
#endif

namespace hongbao.MvcExtension
{
    /// <summary>
    /// JsonResultExtension的扩展类； 
    /// </summary>
    public static class JsonResultExtension
    {
        /// <summary>
        /// 根据给定对象，产生 JsonResult 对象；
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static JsonResult Data(object data)
        {
            var result = new JsonResult(null);
            result.SetJsonResultValue(data);
            return result;
            // return new JsonResult<object> { JsonRequestBehavior = JsonRequestBehavior.AllowGet, Data = data };
        }

        /// <summary>
        /// 根据给定对象，产生 JsonResult&lt;T&gt; 对象；
        /// </summary>
        /// <typeparam name="T">泛型类型；</typeparam>
        /// <param name="data"></param>
        /// <returns></returns>
        public static JsonResult<T> Data<T>(T data)
        {
            var result = new JsonResult<T>();
            result.SetJsonResultValue(data);
            return result;
        }

        /// <summary>
        /// 设置 JsonResult 的 Data 或者 value;
        /// </summary>
        /// <param name="jsonResult"></param>
        /// <param name="obj"></param>
        public static void SetJsonResultValue(this JsonResult jsonResult, object obj)
        {

#if NET472
             jsonResult.Data = obj;
             jsonResult.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
#else
            jsonResult.Value = obj;
#endif
        }

        /// <summary>
        /// 设置 JsonResult 的 Data 或者 value;
        /// </summary>
        /// <param name="jsonResult"></param>
        /// <param name="obj"></param>
        public static object GetJsonResultValue(this JsonResult jsonResult)
        {

#if NET472
             return jsonResult.Data;
#else
            return jsonResult.Value;
#endif
        }
    }


}
