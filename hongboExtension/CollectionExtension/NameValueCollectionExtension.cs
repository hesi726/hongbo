using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace hongbao.CollectionExtension
{
    /// <summary>
    /// 对 NameValueCollection 进行扩展的工具类；
    /// </summary>
    public static class NameValueCollectionExtension
    {
        /// <summary>
        /// 根据键获得给定的值，如果该键不存在，则返回给定的默认值；
        /// </summary>
        /// <param name="coll"></param>
        /// <param name="key"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public static string Get(this NameValueCollection coll, string key, string defaultValue)
        {
            var result = coll[key];
            if (result == null) return defaultValue;
            else return result;
        }

         /// <summary>
        /// 根据键获得给定的值并将该键转换为给定的类型，如果该键不存在，
        /// 则返回给定类型的默认值(null或者0或者0所代表的枚举量)；
        /// </summary>
        /// <param name="coll"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static T Get<T>(this NameValueCollection coll, string key)
        {
            return Get<T>(coll, key, default(T));
        }

        /// <summary>
        /// 根据键获得给定的值并将该键转换为给定的类型，如果该键不存在，
        /// 则返回参数中给定类型的默认值；
        /// </summary>
        /// <param name="coll"></param>
        /// <param name="key"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public static T Get<T>(this NameValueCollection coll, string key, T defaultValue)
        {
            var result = Get(coll, key,null);
            if (result == null) return defaultValue;
            else
            {
                var tType = typeof(T);
                if (tType.IsEnum)   //枚举类型，返回枚举类型的值；
                {
                    if (Enum.IsDefined(tType, result))//   tType.IsEnumDefined(result))
                        return (T)(Enum.Parse(tType, result));
                    else
                    {
                       int tryInt = 0;
                       if (Int32.TryParse(result, out tryInt))
                       {
                           return (T)(Enum.ToObject(tType, tryInt));
                       }
                       else
                       {
                           throw new ArgumentException(result + "不是一个有效整数，无法转换为枚举类型量");
                       }
                    }
                }
                else
                {
                    return (T)Convert.ChangeType(result, tType);
                }
            }
        }
    }
}
