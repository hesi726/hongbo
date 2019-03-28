using System.Collections.Generic;

namespace youzan.com.youzan.open.sdk.model
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="K"></typeparam>
    /// <typeparam name="T"></typeparam>
    public class Multimap<T, K> : System.Collections.Generic.Dictionary<T,K>,
        IDictionary<T, K>
    {

    }
}
