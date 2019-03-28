
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#if NET472
using System.Web.Mvc;

#else
using Microsoft.AspNetCore.Mvc;
#endif

namespace hongbao.MvcExtension
{
    /// <summary>
    /// System.Web.Mvc.Controller 的扩展类
    /// </summary>
    public static class ControllerUtil
    {
        /// <summary>
        /// 获得当前 Controller的名称； 
        /// </summary>
        public static string ControllerName(this Controller controller)
        {
            return (controller.RouteData.Values["controller"] as string).ToLower();
        }

        /// <summary>
        /// 获得当前 Action 的名称；
        /// </summary>
        public static string ActionName(this Controller controller)
        {

            return (controller.RouteData.Values["action"] as string).ToLower();
        }

        /// <summary>
        /// 获取模型验证的第一个错误信息；；
        /// </summary>
        /// <returns></returns>
        public static string GetFirstModelError(this Controller controller, string[] ignoreProp = null)
        {
            if (!controller.ModelState.IsValid)
            {
                foreach (var xx in controller.ModelState)
                {
                    if (ignoreProp != null && ignoreProp.Any(x => x.ToLower() == xx.Key.ToLower()))
                        continue;
                    if (xx.Value.Errors.Count > 0)
                    {
                        return xx.Value.Errors[0].ErrorMessage;
                    }
                }
            }
            return null;
        }


        /// <summary>
        /// 清理
        /// </summary>
        /// <param name="controller"></param>
        public static void ClearHeader(this Controller controller)
        {
            if (controller.Response != null)
            {
#if NET472
                controller.Response.ClearHeaders();
                controller.Response.ClearContent();
#else
                if (!controller.Response.HasStarted)
                {
                    controller.Response.Headers.Clear();
                }

#endif
                /*
                var keys = controller.Response.Headers.AllKeys;
                foreach (var key in keys)
                {
                    controller.Response.Headers.Remove(key as string);
                }*/
            }
        }

        /// <summary>
        /// 添加关闭的Header
        /// </summary>
        public static void AddConnectionCloseHeader(this Controller controller)
        {
            if (controller.Response != null)
            {
#if NET472
                controller.Response.AddHeader("Connection", "close"); //使客户端断开连接;
#else
                controller.Response.Headers.Add("Connection", "close"); //使客户端断开连接;
#endif
            }
        }

        /// <summary>
        /// 创建一个JsonResult对象,对其执行一个委托Action方法，返回该JsonResult对象；
        /// </summary>
        /// <param name="action">需要在JsonResult对象上执行的一个委托Action操作</param>
        /// <returns></returns>
        public static ActionResult JsonResult(this Controller controller, Action<JsonResult> action)
        {
            JsonResult result = JsonResultExtension.BuildJsonResult(null);
            action(result);
            return result;
        }

        /// <summary>
        /// 创建一个JsonResult对象,对其执行一个委托Function方法,设置该方法的返回为 JsonResult的Data字段，返回该JsonResult对象；
        /// </summary>
        /// <param name="function">需要在JsonResult对象上执行的一个委托Func方法方法</param>
        /// <returns></returns>
        public static ActionResult JsonResult(Func<object> function)
        {
            JsonResult result = JsonResultExtension.BuildJsonResult(function());
            return result;
        }
    }
}

