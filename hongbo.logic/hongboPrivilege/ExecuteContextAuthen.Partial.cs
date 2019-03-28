
using System;
using System.Collections.Generic;
using System.Linq;


namespace hongbao.privileges
{
    /// <summary>
    /// MVC 执行， 
    /// 对  AuthorizationContext 或者  ActionExecutedContext 进行权限的类
    /// </summary>
    public partial class ExecuteContextAuthen
    {
       

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
        IPrivilegeJudge privilegeJudge = null;

        /// <summary>
        /// 验证用户是否有权限;
        /// 1. 按照如下步骤验证 Action:
        /// 获取 Action 上的方法所定义的如下类型的 Attribute (AbstractAllowAttribute、AuthenQueryAttribute、AuthenModifyAttribute）,
        /// 如果未定义任何 Attribute, 跳到第2步；
        /// 1.1 判断当前传入的 权限判断对象 判断能否访问 其中的某一个 Attribute, 如果能够访问，返回授权；
        /// 1.1.1  对于 AbstractAllowAttribute， 调用 AbstractAllowAttribute 的 AllowAccess 方法 
        /// 1.1.2  对于 AuthenQueryAttribute ， 根据其  InputParameterName 属性从 Request 或者 RouteData 中获取参数类型和参数值，
        /// 并根据参数值 和 传入的 authenTypeParcer实例 解析成类型        
        /// 1.1.2.1 如果能够解析到类型，则如果类型上定义有 ClassAllowQuery 标注，则如果 当前权限对象 允许访问 ClassAllowQuery，返回授权;        
        /// 1.1.2.2 如果不能解析为类型，但是  参数类型 为 Enum 类型,
        ///         根据参数值解析成 Enum值，并判断此值上是否定义有 ClassAllowQuery标注，判断 当前权限对象  允许访问 ClassAllowQuery，返回授权;   
        /// 1.1.2  对于 AuthenModifyAttribute ， 根据其  InputParameterName 属性从 Request 或者 RouteData 中获取参数类型和参数值，
        /// 并根据参数值 和 传入的 authenTypeParcer实例 解析成类型        
        /// 1.1.2.1 如果能够解析到类型，则如果类型上定义有 ClassAllowModify 标注，则如果 当前权限对象 允许访问 ClassAllowModify，返回授权;        
        /// 1.1.2.2 如果不能解析为类型，但是  参数类型 为 Enum 类型,
        ///         根据参数值解析成 Enum值，并判断此值上是否定义有 ClassAllowQuery标注，判断 当前权限对象  允许访问 ClassAllowQuery，返回授权;          
        /// 1.2 如果不能访问，返回未授权 或者 未登录
        /// 
        /// 2. 按照如上步骤判断 Action 所归属的 Controller, 
        /// 获取 Controller 上的方法所定义的如下类型的 Attribute (AbstractAllowAttribute、AuthenQueryAttribute、AuthenModifyAttribute）
        /// </summary>
        /// <returns></returns>
        public EnumAuthenResult Authen(IParceAuthenTypeAccordParameterName authenTypeParcer)
        {
            if (privilegeJudge != null && privilegeJudge.IsAdministrator()) return EnumAuthenResult.Authened;
            var authenResult = AuthenAction(authenTypeParcer);
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
        /// 验证 Action上定义的属性或者Controller上定义的属性
        /// </summary>
        /// <param name="attributes">属性，先是 AuthenModifyAttribute ， 然后是 AuthenQueryAttribute， 最后是其他属性;
        /// </param>
        /// <param name="authenTypeParcer"></param>
        /// <returns>null, 没有满足条件的 验证属性定义; </returns>
        private bool? AuthenAttributes(object[] attributes, IParceAuthenTypeAccordParameterName authenTypeParcer)
        {
            if (attributes==null || attributes.Length == 0)
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
                    parameterType = GetEnumTypeAccordParameterName(inParameterName);
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
