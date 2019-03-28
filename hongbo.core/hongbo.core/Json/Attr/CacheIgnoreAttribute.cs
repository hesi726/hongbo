using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.Json
{
    /// <summary>
    /// 序列化到 Cache 时忽略此对象， 配合 IgnoreCacheContractResolver 类使用;
    /// </summary>
    public class CacheIgnoreAttribute: Attribute 
    {
    }
}
