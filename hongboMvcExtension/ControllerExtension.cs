using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

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
        public static string ControllerName(this System.Web.Mvc.Controller controller)
        {
            return (controller.RouteData.Values["controller"] as string).ToLower();
        }

        /// <summary>
        /// 获得当前 Action 的名称；
        /// </summary>
        public static string ActionName(this System.Web.Mvc.Controller controller)
        {

            return (controller.RouteData.Values["action"] as string).ToLower();
        }

        /// <summary>
        /// 获取模型验证的第一个错误信息；；
        /// </summary>
        /// <returns></returns>
        public static string GetFirstModelError(this System.Web.Mvc.Controller controller, string[] ignoreProp = null)
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
                controller.Response.ClearHeaders();
                controller.Response.ClearContent();
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
                controller.Response.AddHeader("Connection", "close"); //使客户端断开连接;
            }
        }
    }
}

