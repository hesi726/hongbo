
using System;
using System.Collections.Generic;
using System.Linq;
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
    public class ExecuteContextAuthen
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
        ///// <summary>
        ///// Controller的请求对象;
        ///// </summary>
        //HttpRequestBase request;
        ///// <summary>
        ///// 路由对象
        ///// </summary>
        //RouteData routeData;
        ///// <summary>
        ///// 路由对象中的控制器名称
        ///// </summary>
        //string controlName;
        ///// <summary>
        ///// 路由对象中的Action名称
        ///// </summary>
        //string actionName;
        /// <summary>
        /// 当前会话中的权限判断对象;
        /// </summary>
        IPrivilegeJudge privilegeJudge;

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
        /// 验证用户是否有权限;
        /// </summary>
        /// <returns></returns>
        public EnumAuthenResult Authen(IParceAuthenTypeAccordParameterName authenTypeParcer)
        {
            if (privilegeJudge!=null && privilegeJudge.IsAdministrator()) return EnumAuthenResult.Authened;
            var authenResult = AuthenAcion(authenTypeParcer);
            if (authenResult.HasValue)
            {                
                return ConvertAuthenResult(authenResult.Value);
            }
            authenResult = AuthenConroller(authenTypeParcer);
            if (authenResult.HasValue)
            {
                return ConvertAuthenResult(authenResult.Value);
            }
            return ConvertAuthenResult(false);
        }

        /// <summary>
        /// 转换一下授权结果,允许时返回 null, 否则返回 未授权 或者 未登录;
        /// </summary>
        /// <param name="authen">true-允许授权访问， false-不允许授权访问;</param>
        /// <returns></returns>
        private EnumAuthenResult ConvertAuthenResult(bool authen)
        {
            if (authen == true) return EnumAuthenResult.Authened; 
            else if (privilegeJudge == null) return EnumAuthenResult.Unlogin;
            else return EnumAuthenResult.NotAuthened; 
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
                .OrderBy(a=>  //排一下序，当同时定义有多个时，先处理 允许修改，
                {
                    if (a is AuthenModifyAttribute) return 1;
                    else if (a is AuthenQueryAttribute) return 2;
                    else return 3;
                })
                .ToArray();
            return AuthenAttributes(attributes, authenTypeParcer);
        }

        /// <summary>
        /// 验证 Action上定义的属性或者Controller上定义的属性
        /// </summary>
        /// <param name="attributes">属性，先是 AuthenModifyAttribute ， 然后是 AuthenQueryAttribute， 最后是其他属性;
        /// </param>
        /// <param name="authenTypeParcer"></param>
        /// <returns>null, 没有满足条件的 验证属性定义; </returns>
        private bool? AuthenAttributes(object[] attributes, IParceAuthenTypeAccordParameterName authenTypeParcer)
        {
            if (attributes == null || attributes.Length == 0)
                return null;
            return attributes.Any((attribute) =>
            {
                if (attribute is AbstractAllowAttribute)
                {
                    return AuthenPrivilegeDescAttribute(attribute as AbstractAllowAttribute, authenTypeParcer);
                }
                if (attribute is AuthenModifyAttribute)
                {
                    return AuthenAuthenQueryAttributes<AuthenModifyAttribute, ClassAllowModifyAttribute>(attribute as AuthenModifyAttribute, authenTypeParcer);
                }
                if (attribute is AuthenQueryAttribute)
                {
                    return AuthenAuthenQueryAttributes<AuthenQueryAttribute, ClassAllowQueryAttribute>(attribute as AuthenQueryAttribute, authenTypeParcer);
                }
                return false;
            });
        }
        
        /// <summary>
        /// 验证 PrivilegeDescAttribute 属性;
        /// </summary>
        /// <param name="privilegeDesc"></param>
        /// <returns></returns>
        private bool AuthenPrivilegeDescAttribute(AbstractAllowAttribute privilegeDesc, IParceAuthenTypeAccordParameterName authenTypeParcer)
        {
            if (privilegeDesc.AllowAccess(privilegeJudge)) return true;
            return false;
        }

        /// <summary>
        /// 判断用户是否有权对传入参数进行类型转换后的类进行查询操作，
        /// 例如，传入字符串EH_Media, 根据 EH_Media类上定义的属性判断用户是否有权进行查询操作;
        /// </summary>
        /// <typeparam name="KAuthenTypeAccordParameter">根据输入参数判断对输入参数对应类型是否有授权的接口, 
        ///             例如 AuthenQueryAttribute</typeparam>
        /// <typeparam name="TAllowAccessAttribute">判断对于给定类型，当前用户有授权的接口</typeparam>
        /// <param name="attribute"></param>
        /// <returns></returns>
        private bool AuthenAuthenQueryAttributes<KAuthenTypeAccordParameter, TAllowAccessAttribute>(KAuthenTypeAccordParameter attribute, IParceAuthenTypeAccordParameterName authenTypeParcer)
            where KAuthenTypeAccordParameter : IAuthenTypeAccordParameter
            where TAllowAccessAttribute : AbstractAllowAttribute
        {
            Type parameterType = null; // attribute.InputParameterType;
            if (parameterType == null)
            {               
                var inParameterName = attribute.InputParameterName;
                if (parameterType == null)  // 根据输入参数名称去查找类型;
                {
                    parameterType = authenTypeParcer.ParceAuthenTypeAccordParameterName(inParameterName); // WebUtil.GetEntityTypeInRouteOrRequest(routeData, request, inParameterName);
                }
                if (parameterType == null) // 无法查找到类型，根据方法的参数类型去查找枚举方法的类型; 
                {
                    if (this.actionDescriptor != null)
                    {
                        var parameter = this.actionDescriptor.GetParameters().FirstOrDefault(a => a.ParameterName == inParameterName);
                        if (parameter != null)
                        {
                            if (parameter.ParameterType.IsEnum)
                            {
                                parameterType = parameter.ParameterType;
                            }
                        }
                    }
                }
            }
            if (parameterType == null) return false; //未获取到类型，无效参数，返回 false;
            //指定了 parameterType 的父类型或者接口，如果 parameterType 不符合此限制，返回 false;
            if (attribute.InputParameterTypeMustBe != null && !attribute.InputParameterTypeMustBe.IsAssignableFrom(parameterType))
            {
                return false;
            }
            if (parameterType.IsEnum)
            {
                var inParameterName = attribute.InputParameterName;
                var value = authenTypeParcer.ParceAuthenTypeAccordParameterName(inParameterName); // WebUtil.GetParameterValueInRouteOrRequest(routeData, request, inParameterName);
                return AuthenUtil.AllowAccessEnumValue(this.privilegeJudge, parameterType, value);
            }
            return AuthenUtil.AllowAccessType<TAllowAccessAttribute>(privilegeJudge, parameterType);
        }
    }
}