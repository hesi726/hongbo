using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using hongbao.CollectionExtension;
using hongbao.MvcExtension;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
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
using MvcHtmlString = Microsoft.AspNetCore.Html.IHtmlContent;
#endif

namespace hongbao.MvcExtension
{
    /// <summary>
    /// MVC HtmlHelper扩展接口； 
    /// </summary>
    public static class HTMLHelperExtensions
    {
        /// <summary>
        /// 判断当前页面是否是给定控制器的给定Action
        /// </summary>
        /// <param name="html"></param>
        /// <param name="controller"></param>
        /// <param name="action"></param>
        /// <returns></returns>
        public static string IsActive(this HtmlHelper html, string controller = null, string action = null)
        {
            string activeClass = "active"; // change here if you another name to activate sidebar items
            // detect current app state
            string actualAction = (string) html.ViewContext.RouteData.Values["action"];
            string actualController = (string) html.ViewContext.RouteData.Values["controller"];

            if (String.IsNullOrEmpty(controller))
                controller = actualController;

            if (String.IsNullOrEmpty(action))
                action = actualAction;

            return (controller == actualController && action == actualAction) ? activeClass : String.Empty;
        }

        #region 扩展BeginForm方法;
        /// <summary>
        /// 扩展 BeginForm 方法，只需要 一个 htmlAttributes 属性参数即可； 
        /// </summary>
        /// <param name="html"></param>
        /// <param name="htmlAttributes">必须为 IDictionary&lt;string, Object&gt; 类型, </param>
        /// <param name="method">默认为Post;</param>
        /// <returns></returns>
        public static MvcForm BeginForm(this HtmlHelper html, IDictionary<string, Object> htmlAttributes,
            FormMethod method = FormMethod.Post)
        {
            string actualAction = (string) html.ViewContext.RouteData.Values["action"];
            string actualController = (string) html.ViewContext.RouteData.Values["controller"];
            return html.BeginForm(actualAction, actualController, method, htmlAttributes);
        }

        /// <summary>
        /// 扩展 BeginForm 方法，只需要 一个 htmlAttributes 属性参数即可； 
        /// </summary>
        /// <param name="html"></param>
        /// <param name="htmlAttributes">普通的对象</param>
        /// <param name="method"></param>
        /// <returns></returns>
        public static MvcForm BeginForm(this HtmlHelper html, object htmlAttributes,
            FormMethod method = FormMethod.Post)
        {
            string actualAction = (string)html.ViewContext.RouteData.Values["action"];
            string actualController = (string)html.ViewContext.RouteData.Values["controller"];
            var htmlAttributesMap = new RouteValueDictionary(htmlAttributes);
            var form = html.BeginForm(actualAction, actualController, method, htmlAttributesMap);
            return form; 
        }
        #endregion 

        #region 枚举类的扩展方法
        /// <summary>
        /// 将枚举变量转换成 DropDownList的形式； 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="html"></param>
        /// <param name="name"></param>
        /// <param name="htmlAttributes"></param>
        /// <param name="optionLabel"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static MvcHtmlString EnumDropDown<T>(this HtmlHelper html, string name, object htmlAttributes = null,
            string optionLabel = null, T? value = null)
            where T : struct
        {
            var type = typeof (T);
            if (!type.IsEnum) throw new NotSupportedException("必须为枚举类型");
            var names = Enum.GetValues(type).ToArray((a) =>
            {
                T at = (T) a;
                var result = new SelectListItem
                {
                    Text = Enum.GetName(type, a),
                    Value = a.ToString()
                };
                if (value.HasValue && at.Equals(value.Value))
                {
                    result.Selected = true;
                }
                return result;
            });
            return html.DropDownList(name, names, optionLabel, htmlAttributes);

        }

        /// <summary>
        /// 将枚举变量转换成 Json形式的字符串;
        /// Json格式为如下形式 ： [{ Name : "照明", Value:1}  ] 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="html"></param>
        /// <returns></returns>
        public static string EnumToJson<T>(this HtmlHelper html)
            where T : struct
        {
            var type = typeof (T);
            if (!type.IsEnum) throw new NotSupportedException("必须为枚举类型");
            var names = Enum.GetValues(type).ToArray((a) =>
            {
                return new
                {
                    Name = a.ToString(),
                    Value = Convert.ToInt32(a)
                };
            });
            return new System.Web.Script.Serialization.JavaScriptSerializer().Serialize(names);
        }
        #endregion

        #region 获取控制器名称;
        /// <summary>
        /// 获取控制器的名称,注意,不包含之后的Controller部分;并且总是转换为小写;
        /// </summary>
        /// <param name="html"></param>
        /// <returns></returns>
        public static string GetControllerName(this HtmlHelper html)
        {
            return GetControllerName(html.ViewContext);
        }

        ///// <summary>
        ///// 获取控制器的名称,注意,不包含之后的Controller部分;并且总是转换为小写;
        ///// </summary>
        ///// <param name="html"></param>
        ///// <returns></returns>
        //public static string GetControllerName(this WebViewPage html)
        //{
        //    return GetControllerName(html.ViewContext); 
        //}

        /// <summary>
        /// 获取控制器的名称,注意,不包含之后的Controller部分;并且总是转换为小写;
        /// </summary>
        /// <param name="viewContext"></param>
        /// <returns></returns>
        public static string GetControllerName(this ViewContext viewContext)
        {
            var controllerName = viewContext.RouteData.Values["controller"] as string;
            if (controllerName == null) return null;
            return controllerName.ToLower();
        }
        #endregion

        #region 获取Action名称;
        /// <summary>
        /// 获取Action的名称,注意,总是转换为小写;
        /// </summary>
        /// <param name="html"></param>
        /// <returns></returns>
        public static string GetActionName(this HtmlHelper html)
        {
             return GetActionName(html.ViewContext); ;
        }

        ///// <summary>
        ///// 获取当前页面的Action名称;注意,总是转换为小写;这个用在PartialView中;
        ///// </summary>
        ///// <param name="html"></param>
        ///// <returns></returns>
        //public static string GetActionName(this WebViewPage html)
        //{
        //    return GetActionName(html.ViewContext);
        //}

        /// <summary>
        /// 获取当前ViewContext的Action名称;注意,总是转换为小写;这个用在PartialView中;
        /// </summary>
        /// <param name="viewContext"></param>
        /// <returns></returns>
        public static string GetActionName(this ViewContext viewContext)
        {
            var actionName = viewContext.RouteData.Values["action"] as string;
            if (actionName == null) return null;
            return actionName.ToLower();
        }
        #endregion

        #region 输出Bundle的名称;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="html"></param>
        /// <param name="bundle"></param>
        /// <returns></returns>
        public static IHtmlString RenderBundle(this HtmlHelper html, EnumBundle bundle)
        {
            return bundle.RenderHtmlString();
        }
        #endregion

        #region 输出子页面
        ///// <summary>
        ///// 必须和ControlFactory 以及 AbstractController 一起使用,
        ///// 在一个视图中，无论调用此方法多少次,对于同一个partialViewName,总只会输出一次;
        ///// </summary>
        ///// <param name="html"></param>
        ///// <param name="partialViewName"></param>
        //public static MvcHtmlString PartialOnlyOne(this HtmlHelper html, string partialViewName)
        //{
        //    AbstractMvcController controller = html.ViewContext.Controller as AbstractMvcController;
        //    if (controller != null)
        //    {
        //        if (controller.AddPartialViewName(partialViewName))
        //        {
        //            return html.Partial(partialViewName);
        //        }
        //    }
        //    return new MvcHtmlString("");
        //}

        ///// <summary>
        ///// 必须和ControlFactory 以及 AbstractController 一起使用,
        ///// 在一个视图中，无论调用此方法多少次,对于同一个partialViewName,总只会输出一次;
        ///// </summary>
        ///// <param name="html"></param>
        ///// <param name="partialViewName"></param>
        //public static void RenderPartialOnlyOne(this HtmlHelper html, string partialViewName)
        //{
        //    AbstractMvcController controller = html.ViewContext.Controller as AbstractMvcController;
        //    if (controller != null)
        //    {
        //        if (controller.AddPartialViewName(partialViewName))
        //        {
        //             html.RenderPartial(partialViewName);
        //        }
        //    }
        //}
        #endregion

        #region Json格式化

        /// <summary>
        /// Json格式化，属性使用日期格式;
        /// </summary>
        ///  <param name="html"></param>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static MvcHtmlString RawJsonWithDateFormat(this HtmlHelper html, object obj)
        {
            IsoDateTimeConverter timeConvert = new IsoDateTimeConverter();
            timeConvert.DateTimeFormat = "yyyy-MM-dd";
            return html.Raw(JsonConvert.SerializeObject(obj, Newtonsoft.Json.Formatting.None, timeConvert));
        }
        /// <summary>
        /// Json格式化，属性使用日期格式;
        /// </summary>
        ///  <param name="html"></param>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string JsonWithDateFormat(this HtmlHelper html, object obj)
        {
            IsoDateTimeConverter timeConvert = new IsoDateTimeConverter();
            timeConvert.DateTimeFormat = "yyyy-MM-dd";
            return JsonConvert.SerializeObject(obj, Newtonsoft.Json.Formatting.None, timeConvert);
        }

        /// <summary>
        /// Json格式化，属性使用日期时间格式;
        /// </summary>
        ///  <param name="html"></param>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string JsonWithDatetimeFormat(this HtmlHelper html, object obj)
        {
            IsoDateTimeConverter timeConvert = new IsoDateTimeConverter();
            timeConvert.DateTimeFormat = "yyyy-MM-dd HH:mm:ss";
            return JsonConvert.SerializeObject(obj, Newtonsoft.Json.Formatting.None, timeConvert);
        }
        #endregion
    }
}
