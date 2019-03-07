
using System;
using System.Collections.Generic;
using System.Linq;
////https://docs.microsoft.com/en-us/dotnet/core/tutorials/libraries#how-to-multitarget
#if NET45
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Filters;
using System.Web.Routing;

namespace hongbao.privileges
{
    /// <summary>
    /// MVC 执行， 
    /// 对  AuthorizationContext 或者  ActionExecutedContext 进行权限的类
    /// </summary>
    public partial class ExecuteContextAuthen
    {
        #region 构造函数和初始化
        /// <summary>
        /// 执行上下文的构造函数
        /// </summary>
        /// <param name="filterContext"></param>
        /// <param name="user"></param>
        public ExecuteContextAuthen(AuthorizationContext filterContext, IPrivilegeJudge user)
        {
            actionDescriptor = filterContext.ActionDescriptor;
            controllerDescriptor = actionDescriptor.ControllerDescriptor;
            this.privilegeJudge = user;
            Initiate(filterContext.RouteData, filterContext.RequestContext.HttpContext.Request);
        }

        /// <summary>
        /// 执行上下文的构造函数
        /// </summary>
        /// <param name="filterContext"></param>
        /// <param name="user"></param>
        public ExecuteContextAuthen(AuthenticationContext filterContext, IPrivilegeJudge user)
        {
            actionDescriptor = filterContext.ActionDescriptor;
            controllerDescriptor = actionDescriptor.ControllerDescriptor;
            this.privilegeJudge = user;
            Initiate(filterContext.RouteData, filterContext.RequestContext.HttpContext.Request);
        }

        /// <summary>
        /// 执行上下文的构造函数
        /// </summary>
        /// <param name="filterContext"></param>
        /// <param name="user"></param>
        public ExecuteContextAuthen(ActionExecutedContext filterContext, IPrivilegeJudge user)
        {
            actionDescriptor = filterContext.ActionDescriptor;
            controllerDescriptor = actionDescriptor.ControllerDescriptor;
            this.privilegeJudge = user;
            Initiate(filterContext.RouteData, filterContext.RequestContext.HttpContext.Request);
        }

        /// <summary>
        /// 执行上下文的构造函数
        /// </summary>
        /// <param name="filterContext"></param>
        /// <param name="user"></param>
        public ExecuteContextAuthen(ActionExecutingContext filterContext, IPrivilegeJudge user)
        {
            actionDescriptor = filterContext.ActionDescriptor;
            controllerDescriptor = actionDescriptor.ControllerDescriptor;
            this.privilegeJudge = user;
            Initiate(filterContext.RouteData, filterContext.RequestContext.HttpContext.Request);
        }
        #endregion

        /// <summary>
        /// Action的描述对象
        /// </summary>
        ActionDescriptor actionDescriptor;
        /// <summary>
        /// Controller的描述对象
        /// </summary>
        ControllerDescriptor controllerDescriptor;

        /// <summary>
        /// 初始化;
        /// </summary>
        private void Initiate(RouteData routeData, HttpRequestBase request)
        {
            //routeData = filterContext.RouteData;
            //request = filterContext.RequestContext.HttpContext.Request;
            //controlName = routeData.Values["controller"] + "";
            //actionName  = routeData.Values["action"] + "";
        }

       


        /// <summary>
        /// 对 Action 进行授权;
        /// 获取Action所有的 PrivilegeDescAttribute或者AuthenQueryAttribute或者AuthenModifyAttribute的定义,
        /// 并判断用户是否有权限访问;
        /// </summary>
        /// <returns>null-未定义任何权限Attribute, true-定义了权限Attribute且用户有权限访问, false-定义了权限Attribute且用户无权限访问,</returns>
        private bool? AuthenAcion(IParceAuthenTypeAccordParameterName authenTypeParcer)
        {
            var attributes = actionDescriptor.GetCustomAttributes(true)
                .Where(a => a is AbstractAllowAttribute || a is AuthenQueryAttribute || a is AuthenModifyAttribute)
                .ToArray();
            return AuthenAttributes(attributes, authenTypeParcer);
        }

        /// <summary>
        /// 对 Controller 进行授权;
        /// 获取Action所有的 PrivilegeDescAttribute或者AuthenQueryAttribute或者AuthenModifyAttribute的定义,
        /// 并判断用户是否有权限访问;
        /// </summary>
        private bool? AuthenConroller(IParceAuthenTypeAccordParameterName authenTypeParcer)
        {
            var attributes = controllerDescriptor.GetCustomAttributes(true)
                .Where(a => a is AbstractAllowAttribute || a is AuthenQueryAttribute || a is AuthenModifyAttribute)
                .OrderBy(a =>  //排一下序，当同时定义有多个时，先处理 允许修改，
                {
                    if (a is AuthenModifyAttribute) return 1;
                    else if (a is AuthenQueryAttribute) return 2;
                    else return 3;
                })
                .ToArray();
            return AuthenAttributes(attributes, authenTypeParcer);
        }

        /// <summary>
        /// 根据给定参数获取枚举类型
        /// </summary>
        /// <param name="inParameterName"></param>
        /// <returns></returns>
        private Type GetEnumTypeAccordParameterName(string inParameterName)
        {
            if (this.actionDescriptor != null)
            {
                var parameter = this.actionDescriptor.GetParameters().FirstOrDefault(a => a.ParameterName == inParameterName);
                if (parameter != null)
                {
                    if (parameter.ParameterType.IsEnum)
                    {
                        return parameter.ParameterType;
                    }
                }
            }
            return null;
        }

    }
}
#endif