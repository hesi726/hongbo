using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.Json
{
    /// <summary>
    /// 
    /// </summary>
    public static class JTokenUtil
    {
        /// <summary>
        /// 将 jToken 的值转换为数组;
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="jtoken"></param>
        /// <returns></returns>
        public static T[] ToArray<T>(JToken jtoken)
        {
            if (jtoken == null) return null;
            if (jtoken.Type == JTokenType.Array)
            {
                var jarray = (JArray)jtoken;
                return jarray.Select(a => a.Value<T>()).ToArray();
            }
            else 
            {
                return new T[] { jtoken.Value<T>() };
            }
        }
    }
}
