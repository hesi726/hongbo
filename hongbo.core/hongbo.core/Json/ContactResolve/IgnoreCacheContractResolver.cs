using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.Json
{
    /// <summary>
    /// 输出到json字符串时，进行如下处理:
    /// a. 包含有 CacheIgnoreAttribute 标记的属性不进行序列化
    /// </summary>
    public class IgnoreCacheContractResolver : DefaultContractResolver
    {
        /// <summary>
        /// TypeScriptIgnoreAttribute 标记类;
        /// </summary>
        static Type CacheIgnoreType = typeof(CacheIgnoreAttribute);

        /// <summary>
        /// 需要忽略的属性;
        /// </summary>
        PropertyInfo[] ignoreProperty = null;

        /// <summary>
        /// Json序列化时，将传入 type, 以解决数据协议; 
        /// 此处查询所有包含有 TypeSciptIgnoreType 标注 的属性出来;
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public override JsonContract ResolveContract(Type type)
        {
            ignoreProperty = type.GetProperties().Where(a => a.GetCustomAttributes(CacheIgnoreType).FirstOrDefault()!=null).ToArray();
            return base.ResolveContract(type);
        }

        /// <summary>
        /// Json序列化时，将传入 type 以获取需要序列化的属性;
        /// 获取需要序列化的属性, 但是忽略掉 包含有  TypeSciptIgnoreType 标注 的属性
        /// </summary>
        /// <param name="type"></param>
        /// <param name="memberSerialization"></param>
        /// <returns></returns>
        protected override IList<JsonProperty> CreateProperties(Type type,
                MemberSerialization memberSerialization)
        {
            IList<JsonProperty> list = base.CreateProperties(type, memberSerialization);
            if (ignoreProperty == null) return list;
            return list.Where(jsonProperty => !ignoreProperty.Any(c => c.Name == jsonProperty.PropertyName)).ToList();
        }
    }
}
