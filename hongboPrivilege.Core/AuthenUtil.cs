using hongbao.SystemExtension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.privileges
{
    /// <summary>
    /// 授权的工具类;
    /// </summary>
    public static class AuthenUtil
    {
        /// <summary>
        /// 匿名用户的权限常量定义,即不登录也可以进行操作;
        /// </summary>
        public const string PRIVILEGE_ANANYMOUS = "XXXX_ANANYMOUS";

        /// <summary>
        /// 任意用户的权限常量定义,但还需要判断Usertype,如果用户的 usertype 和 权限中指定的 usertype 不一致,也认为没有授权;
        /// </summary>
        public const string PRIVILEGE_ANYONE = "XXXX_ANYONE";

        /// <summary>
        /// 管理员权限字符串,使用一个没有定义的权限字符串即可;
        /// 管理员时不会判断权限,所以我们指定一个任何都无法使用的权限即可;
        /// </summary>
        public const string PRIVILEGE_ADMIN = "XXXX_ADMIN";


        /// <summary>
        /// 查找 类的 Attribute 属性判断是否有权限访问此类;
        /// </summary>
        /// <typeparam name="T">泛型类,</typeparam>
        /// <param name="user"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public static bool AllowAccessType<T>(IPrivilegeJudge user, Type type)
             where T : AbstractAllowAttribute
        {
            if (type == null) return false;
            return type.GetCustomAttributes(typeof(T), true)
                    .Select(a => (IAllowAccess)a)
                    .Any(a => a.AllowAccess(user));
        }

        /// <summary>
        /// 查找 类的 Attribute 属性判断是否有权限访问此类;
        /// </summary>
        /// <param name="user"></param>
        /// <param name="enumType"></param>
        /// <param name="enumValue"></param>
        /// <returns></returns>
        public static bool AllowAccessEnumValue(IPrivilegeJudge user, Type enumType, object enumValue)
        {
            if (enumType == null) return false;
            return EnumUtil.GetAttribute(enumType, enumValue)
                    .Where(a => a is IAllowAccess)
                    .Select(a => a as IAllowAccess)
                    .Any(a => a.AllowAccess(user));
        }

        /// <summary>
        /// 查找 类的 Attribute 属性判断是否有权限访问此类;
        /// </summary>
        /// <param name="user"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public static bool AllowAccessType(IPrivilegeJudge user, Type type)
        {
            return AllowAccessType<AbstractAllowAttribute>(user, type);
        }

        /// <summary>
        /// 根据对象的类的 Attribute 属性判断是否有权限访问此类的实例;
        /// </summary> 
        /// <typeparam name="T">泛型类,</typeparam>
        /// <param name="user"></param>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static bool AllowAccessObject<T>(IPrivilegeJudge user, object obj)
            where T : AbstractAllowAttribute
        {
            if (obj == null) return false;
            return AllowAccessType<T>(user, obj.GetType());
        }

        /// <summary>
        /// 根据传入对象，获取对象的 Type, 
        /// 根据 Type 上的 Attribute 判断是否有权限访问此类;
        /// </summary>
        /// <param name="user"></param>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static bool AllowAccessObject(IPrivilegeJudge user, object obj)
        {
            if (obj == null) return false;
            return AllowAccessType(user, obj.GetType());
        }
    }
}
