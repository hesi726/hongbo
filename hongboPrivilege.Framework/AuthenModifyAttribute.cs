using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.privileges
{
    /// <summary>
    /// 授权更新, 
    /// 判断类是否定义有 PrivilegeModifyAttribute 属性，如果定义有此属性，
    /// 则判断调用 PrivilegeModifyAttribute 对 当前用户进行授权操作 ;
    ///  如果未定义 PrivilegeModifyAttribute 属性, 通知用户未授权;
    /// </summary>
    public class AuthenModifyAttribute : AuthenQueryAttribute, IAuthenTypeAccordParameter
    {
        /// <summary>
        /// 授权查询, 
        /// 根据 inputParameterName 从 WEB 请求中获取给定参数，并根据给定的参数类型判断，
        /// 判断类是否定义有 PrivilegeQueryAttribute 属性，如果定义有此属性，
        ///  则判断调用 PrivilegeQueryAttribute 对 当前用户进行授权操作 ;
        ///  如果未定义 PrivilegeQueryAttribute 属性, 通知用户未授权;
        /// </summary>
        /// <param name="inputParameterName"></param>
        public AuthenModifyAttribute(string inputParameterName): base(inputParameterName)
        {
        }
    }
}
