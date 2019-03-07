using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
//using System.Threading.Tasks;

namespace hongbao.privileges
{
    /// <summary>
    /// Enum的工具类
    /// </summary>
     internal static class EnumUtil
    {
        #region GetValue
        /// <summary>
        /// 根据整数数字获取枚举类型的值
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="val"></param>
        /// <returns></returns>
        public static T GetValue<T>(int val)
            where T : struct
        {
            return (T) GetValue(typeof(T), val);
        }
        /// <summary>
        /// 根据整数数字获取枚举类型的值;
        /// </summary>
        /// <param name="type"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        public static object GetValue(Type type, int val)
        {
            var array = Enum.GetValues(type);
            for (var xindex = 0; xindex < array.Length; xindex++)
            {
                var obj = array.GetValue(xindex);
                var it = Convert.ToInt32(obj);
                if (it == val)
                    return obj;
            }
            return 0;
        }
        /// <summary>
        /// 根据整数数字获取枚举类型的值;
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public static TEnumType GetValue<TEnumType>(string val)
        {
            var xval = GetValue(typeof(TEnumType), val);
            if (xval == null) return default(TEnumType);
            return (TEnumType)xval;
        }
        /// <summary>
        /// 根据整数数字获取枚举类型的值;
        /// </summary>
        /// <param name="enumType"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        public static object GetValue(Type enumType, string val)
        {
            int ot;
            if (Int32.TryParse(val, out ot)) return GetValue(enumType, ot);
            var values = Enum.GetValues(enumType);
            return Find(values, value => value.ToString() == val);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static object Find(Array array, Func<object, bool> func)
        {
            int count = array.Length;
            for (var index = 0; index < count; index++)
            {
                var ele = array.GetValue(index);
                if (func(ele)) return ele;
            }
            return null;
        }
        /// <summary>
        /// 根据整数数字获取枚举类型的值;
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public static TEnumType GetValue<TEnumType>(object val)
        {
            if (val == null) return default(TEnumType);
            return GetValue<TEnumType>(val.ToString());
        }
        /// <summary>
        /// 根据整数数字获取枚举类型的值;
        /// </summary>
        /// <param name="enumType"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        public static object GetValue(Type enumType, object val)
        {
            if (val == null) return null;
            return GetValue(enumType, val.ToString());
        }
        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="val"></param>
        /// <returns></returns>
        public static bool ExistsValue<T>(T val)
        {
            var array = Enum.GetValues(typeof(T));
            for (var xindex = 0; xindex < array.Length; xindex++)
            {
                var obj = (T) array.GetValue(xindex);
                if (obj.Equals(val))
                    return true;
            }
            return false;
        }

        /// <summary>
        /// 获取枚举类型的 int 值
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static int GetIntValue<T>(T value)
        {
            return GetIntValue(typeof(T), value);
        }

        /// <summary>
        /// 获取枚举类型的 int 值
        /// </summary>
        /// <returns></returns>
        public static int GetIntValue(Type enumType, object value)
        {
            var array = Enum.GetValues(enumType);
            for (var xindex = 0; xindex < array.Length; xindex++)
            {
                var obj = array.GetValue(xindex);
                var it = Convert.ToInt32(obj);
                if (obj.Equals(value))
                    return it;
            }
            throw new Exception("异常");
        }
       

        /// <summary>
        /// 获取枚举类型上的所有标注;
        /// </summary>
        /// <param name="enumType"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static List<Attribute> GetAttribute(Type enumType, object value)
        {
            object val = GetValue(enumType, value);
            FieldInfo fieldInfo = enumType.GetField(val.ToString());
            return fieldInfo.GetCustomAttributes(false).Select(a=> (Attribute) a).ToList();
        }        

        /// <summary>
        /// 获取枚举的描述
        /// </summary>
        /// <param name="enumValue">枚举的值</param>
        /// <returns>返回枚举的描述</returns>
        public static T GetAttribute<T>(Enum enumValue)
            where T: Attribute
        {
            Type type = enumValue.GetType();   //获取类型
            MemberInfo[] memberInfos = type.GetMember(enumValue.ToString());   //获取成员
            if (memberInfos != null && memberInfos.Length > 0)
            {
                T[] attrs = memberInfos[0].GetCustomAttributes(typeof(T), false) as T[];   //获取描述特性
                if (attrs != null && attrs.Length > 0)
                {
                    return attrs[0];    //返回当前描述
                }
            }
            return null;
            
       }
    }
}
