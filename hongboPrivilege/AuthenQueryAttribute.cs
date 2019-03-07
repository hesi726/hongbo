using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.privileges
{
    /// <summary>
    /// 授权查询, 
    /// 判断类是否定义有 PrivilegeQueryAttribute 属性，如果定义有此属性，
    ///                 则判断调用 PrivilegeQueryAttribute 对 当前用户进行授权操作 ;
    ///  如果未定义 PrivilegeQueryAttribute 属性, 通知用户未授权;
    /// </summary>
    public class AuthenQueryAttribute: Attribute, IAuthenTypeAccordParameter
    {
        /// <summary>
        /// 授权查询, 
        /// 根据 inputParameterName 从 WEB 请求中获取给定参数，并根据给定的参数类型判断，
        /// 判断类是否定义有 PrivilegeQueryAttribute 属性，如果定义有此属性，
        ///                 则判断调用 PrivilegeQueryAttribute 对 当前用户进行授权操作 ;
        ///  如果未定义 PrivilegeQueryAttribute 属性, 通知用户未授权;
        /// </summary>
        /// <param name="inputParameterName"></param>
        /// <param name="parameterMustBeType">根据 inputParameterName 解析而来的类型必须是 此参数的子类型或者实现;</param>
        public AuthenQueryAttribute(string inputParameterName, Type parameterMustBeType = null)
        {
            this.InputParameterName = inputParameterName;
            this.InputParameterTypeMustBe = parameterMustBeType;
        }


        ///// <summary>
        ///// 授权查询, 
        ///// 根据 inputParameterName 从 WEB 请求中获取给定参数，并根据给定的参数类型判断，
        ///// 判断类是否定义有 PrivilegeQueryAttribute 属性，如果定义有此属性，
        /////                 则判断调用 PrivilegeQueryAttribute 对 当前用户进行授权操作 ;
        /////  如果未定义 PrivilegeQueryAttribute 属性, 通知用户未授权;
        ///// </summary>
        ///// <param name="type"></param>
        //public AuthenQueryAttribute(Type type)
        //{
        //}

        /// <summary>
        /// 输入参数名称
        /// </summary>
        public string InputParameterName { get; private set; }

        ///// <summary>
        ///// 输入参数类型;
        ///// </summary>
        //public  Type InputParameterType { get; private set; }

        /// <summary>
        /// InputParameterType 必须是给定的类型;
        /// </summary>
        public Type InputParameterTypeMustBe { get;  set; }
    }
    
}
