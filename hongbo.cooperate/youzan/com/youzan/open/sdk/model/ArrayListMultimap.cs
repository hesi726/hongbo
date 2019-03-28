namespace youzan.com.youzan.open.sdk.model
{
    /// <summary>
    /// 
    /// </summary>
    public class ArrayListMultimap
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static Multimap<K, T> create<K,T>()
        {
            return new Multimap<K, T>();
        }
    }
}
