using hongbao.EntityExtension;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Web;
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
using IController = Microsoft.AspNetCore.Mvc.Controller;
#endif

namespace hongbao.MvcExtension
{

    /// <summary>
    /// 控制器的构造工厂类，注入到所有控制器中； 
    /// 简单来说，其在创建一个控制器时，如果控制器是一个 AbstractController类型的控制器，则会自动创建一个 DbContext子类的实例对象，并注入到 AbstractController 控制器的 DbContext中； 
    /// 在控制器释放时，如果控制器是一个 AbstractController类型的控制器，则会自动调用 AbstractController 控制器的 DbContext 的 Dispose 方法；
    /// </summary>
    public class ControlFactory<K> : DefaultControllerFactory        
        where K : DbContext
    {        
        /// <summary>
        /// 带有 DbContext子类 接口工厂方法的 构造函数；
        /// </summary>
        /// <param name="t"></param>
        public ControlFactory(IDbContextFactory<K> t) : this( ()=> { return t.GetDbContext(); })
        {
           
        }

        /// <summary>
        /// 带有 返回DbContext子类的委托Func方法的 构造函数；
        /// </summary>
        /// <param name="t">返回DbContext子类的委托Func方法</param>
        public ControlFactory(Func<K> t)
        {
            this.dbContextFactory = t;
        }

        /// <summary>
        /// 带有 返回DbContext子类的委托Func方法,并在控制器创建之后，返回之前对控制器进行指定操作的委托方法的 构造函数；
        /// </summary>
        /// <param name="t">返回DbContext子类的委托Func方法</param>
        /// <param name="controlAction">在控制器创建之后，返回之前对控制器进行指定操作的委托方法</param>
        public ControlFactory(Func<K> t, Action<IController> controlAction) : this(t)
        {
            this.controlAction = controlAction;
        }

        private Func<K> dbContextFactory;
        private Action<IController> controlAction;

        /// <summary>
        /// 控制器创建的钩子方法；
        /// </summary>
        /// <param name="requestContext"></param>
        /// <param name="controllerName"></param>
        /// <returns></returns>
        public override IController CreateController(RequestContext requestContext, string controllerName)
        {
            var result =  base.CreateController(requestContext, controllerName);           
            if (result is AbstractMvcControllerWithDbContext<K>)
            {                
                var bc = ((AbstractMvcControllerWithDbContext<K>)result);                
                //允许对控制器进行跨域的调用； 
                var Response = requestContext.HttpContext.Response;
                Response.ClearContent();
              //  Response.AddHeader("Access-Control-Allow-Origin", "*");
              //  Response.AddHeader("Access-Control-Allow-Methods", "POST, GET, OPTIONS");
              //  Response.AddHeader("Access-Control-Allow-Headers", "*");

                if (AbstractMvcControllerWithDbContext<K>.ThreadLocal.Value == null)
                {
                    bc.DbContext = dbContextFactory();
                    AbstractMvcControllerWithDbContext<K>.ThreadLocal.Value = bc.DbContext;
                }
                else
                {
                    bc.DbContext = AbstractMvcControllerWithDbContext<K>.ThreadLocal.Value;
                }
                if (System.Configuration.ConfigurationManager.AppSettings["debug"] != null
                    && System.Configuration.ConfigurationManager.AppSettings["debug"] == "1")
                {
                    bc.DbContext.Database.Log = (msg) => { Debug.WriteLine(msg); };
                }
                
                bc.Activate();
            }
            if (this.controlAction != null) controlAction(result);
            return result; 
        }

        /// <summary>
        /// 控制器释放时候的钩子方法；
        /// </summary>
        /// <param name="controller"></param>
        public override void ReleaseController(IController controller)
        {
            if (controller is AbstractMvcControllerWithDbContext<K>)
            {
                var bc = ((AbstractMvcControllerWithDbContext<K>)controller);
                bc.Deactivate();
                if (bc.DbContext != null)
                {
                    bc.DbContext.Dispose();
                    bc.DbContext = null; 
                }
            }
            base.ReleaseController(controller);
        }        
    }
}