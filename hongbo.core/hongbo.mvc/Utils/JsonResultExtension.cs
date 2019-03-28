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
        /// 设置 JsonResult 的 Data 或者 value;
        /// </summary>
        /// <param name="jsonResult"></param>
        /// <param name="obj"></param>
        public static JsonResult BuildJsonResult(object data)
        {

#if NET472
            var jsonResult = new JsonResult();
             jsonResult.Data = data;
             jsonResult.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            return jsonResult;
#else
            var jsonResult = new JsonResult(data);
            return jsonResult;
#endif
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
