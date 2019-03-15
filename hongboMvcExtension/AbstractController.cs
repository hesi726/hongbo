using hongbao.EntityExtension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
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
    /// 
    /// </summary>
    public abstract class AbstractMvcController : Controller
    {
        /// <summary>
        /// 
        /// </summary>
        public AbstractMvcController()
        {
           
        }

#if NET472
        /// <summary>
        /// 
        /// </summary>
        /// <param name="requestContext"></param>
        /// <param name="callback"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        protected override IAsyncResult BeginExecute(RequestContext requestContext, AsyncCallback callback, object state)
        {
            return base.BeginExecute(requestContext, callback, state);
        }

        protected override void Initialize(RequestContext requestContext)
        {
            base.Initialize(requestContext);
            if (this.Response != null)
            {
                this.Response.Buffer = true;
                this.Response.BufferOutput = true;
            }
        }
#endif
#region 辅助方法
        /// <summary>
        /// 获得当前 Controller的名称； 
        /// </summary>
        public string ControllerName
        {
            get
            {
                return (this.RouteData.Values["controller"] as string).ToLower();
            }
        }

        /// <summary>
        /// 获得当前 Action 的名称；
        /// </summary>
        public string ActionName
        {
            get
            {
                return (this.RouteData.Values["action"] as string).ToLower();
            }
        }

        /// <summary>
        /// 获取模型验证的第一个错误信息；；
        /// </summary>
        /// <returns></returns>
        public string GetFirstModelError(string[] ignoreProp=null)
        {
            if (!this.ModelState.IsValid)
            {
                Trace(null, " 数据模型无效</br>");
                foreach (var xx in this.ModelState)
                {
                    if (ignoreProp != null && ignoreProp.Any(x=>x.ToLower()==xx.Key.ToLower()))
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
        /// Trace方法，子类可以覆盖此方法； 
        /// </summary>
        /// <param name="traceType"></param>
        /// <param name="traceMessage"></param>
        public virtual void Trace(object traceType, string traceMessage)
        {
        }

        List<string> partialList = new List<string>(); 
        /// <summary>
        /// 
        /// </summary>
        /// <param name="partialViewName"></param>
        public bool AddPartialViewName(string partialViewName)
        {
            if (partialList.IndexOf(partialViewName) < 0)
            {
                partialList.Add(partialViewName);
                return true;
            }
            return false;
        }


#endregion

#region 控制器激活和失活的事件;

        /// <summary>
        /// 激活的事件;
        /// </summary>
        public EventHandler<ControllerEventArgs> OnActivateEventHandler;

        /// <summary>
        /// Controller激活时的的回调方法, 默认下什么都不做，子类可以覆盖此方法；
        /// 注意，和 ControlFactory 结合起来一起使用；
        /// </summary>
        internal virtual void Activate()
        {
            OnActivateEventHandler?.Invoke(this, new ControllerEventArgs { EventType = EnumControlEvent.Activate });
        }



        /// <summary>
        /// 失活的事件;
        /// </summary>
        public EventHandler<ControllerEventArgs> OnDeactiveEventHandler;

        /// <summary>
        /// Controller失活时的回调方法，默认下什么都不做， 子类可以覆盖此方法；
        /// 注意，和 ControlFactory 结合起来一起使用；
        /// </summary>
        protected internal virtual void Deactivate()
        {
            OnDeactiveEventHandler?.Invoke(this, new ControllerEventArgs { EventType = EnumControlEvent.Activate });
        }
#endregion

#region JsonResult方法
        /// <summary>
        /// 创建一个JsonResult对象,对其执行一个委托Action方法，返回该JsonResult对象；
        /// </summary>
        /// <param name="action">需要在JsonResult对象上执行的一个委托Action操作</param>
        /// <returns></returns>
        public ActionResult JsonResult(Action<JsonResult> action)
        {
            JsonResult result = new JsonResult(null); // { JsonRequestBehavior = JsonRequestBehavior.AllowGet };
            SetJsonResultValue(result, null);
            action(result);
            return result;
        }

        /// <summary>
        /// 创建一个JsonResult对象,对其执行一个委托Function方法,设置该方法的返回为 JsonResult的Data字段，返回该JsonResult对象；
        /// </summary>
        /// <param name="function">需要在JsonResult对象上执行的一个委托Func方法方法</param>
        /// <returns></returns>
        public ActionResult JsonResult(Func<JsonResult, object> function)
        {
            JsonResult result = new JsonResult(null); // { JsonRequestBehavior = JsonRequestBehavior.AllowGet };
            SetJsonResultValue(result, function(result));
            return result;
        }

        /// <summary>
        /// 设置 JsonResult 的 Data 或者 value;
        /// </summary>
        /// <param name="jsonResult"></param>
        /// <param name="obj"></param>
        public static void SetJsonResultValue(JsonResult jsonResult, object obj)
        {

#if NET472
             jsonResult.Data = obj;
             jsonResult.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
#else
            jsonResult.Value = obj;
#endif
        }
#endregion
    }
   

    /// <summary>
    /// 控制器事件;
    /// </summary>
    public class ControllerEventArgs  : EventArgs
    {     
        /// <summary>
        /// 
        /// </summary>
        public EnumControlEvent EventType { get; set;  }

    }

    /// <summary>
    /// 控制器事件枚举类;
    /// </summary>
    public enum EnumControlEvent
    {
        /// <summary>
        /// 激活;
        /// </summary>
        Activate,

        /// <summary>
        /// 失活;
        /// </summary>
        Deactive
    }
}
