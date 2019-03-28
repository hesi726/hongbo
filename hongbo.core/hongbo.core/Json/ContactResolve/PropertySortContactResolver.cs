using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace hongbao.Json
{
    /// <summary>
    /// 输出到json字符串时，属性名称按照字典顺序排序输出
    /// </summary>
    public class PropertySortContactResolver : DefaultContractResolver
    {
        /// <summary>
        /// 属性名称按照字典顺序排序输出
        /// </summary>
        /// <param name="type"></param>
        /// <param name="memberSerialization"></param>
        /// <returns></returns>
        protected override IList<JsonProperty> CreateProperties(Type type,
                MemberSerialization memberSerialization)
        {
            IList<JsonProperty> list = base.CreateProperties(type, memberSerialization);
            return list.OrderBy(a => a.PropertyName).ToList();
        }
    }

}