using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace hongbao.CollectionExtension
{
    /// <summary>
    /// 扩展 Dictionary的类； 
    /// </summary>
    public static class DictionaryUtil
    {
        /// <summary>
        /// 在 Dictionary中寻找某一个键的值，如果找到该键，则返回该键的值，
        /// 否则，将键和值插入到 Dictonary中，并返回键的值；
        /// 注意，不保证线程安全；
        /// 注意，如果键为null,则本函数抛出ArgumentNullException异常；
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="dictionary"></param>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public static TValue FindOrInsert<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, TValue value)
        {
            if (key == null) throw new ArgumentNullException();
            if (dictionary.ContainsKey(key)) return dictionary[key];
            else
            {
                dictionary[key] = value;
                return value;
            }

            
        }

        /// <summary>
        /// 在 Dictionary中寻找某一个键的值，如果找到该键，则返回该键的值，
        /// 否则，将键和值插入到 Dictonary中，并返回键的值；
        /// 注意，不保证线程安全；
        /// 注意，如果键为null,则本函数抛出ArgumentNullException异常；
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="dictionary"></param>
        /// <param name="key"></param>
        /// <param name="valueFunc"></param>
        public static TValue FindOrInsert<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, Func<TValue> valueFunc)
        {
            if (key == null) throw new ArgumentNullException();
            if (dictionary.ContainsKey(key)) return dictionary[key];
            else
            {
                var value = valueFunc();
                dictionary[key] = value;
                return value;
            }
        }

        /// <summary>
        /// 在 Dictionary中寻找某一个键的值，如果找到该键，则返回该键的值，
        /// 否则，将键和值插入到 Dictonary中，并返回键的值；
        /// 注意，不保证线程安全；
        /// 注意，如果键为null,则本函数抛出ArgumentNullException异常；
        /// </summary>
        /// <typeparam name="TKey">产生键的函数，注意，如果返回null,则本函数返回null 或者 0;</typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="dictionary"></param>
        /// <param name="keyFunc"></param>
        /// <param name="valueFunc"></param>
        public static TValue FindOrInsert<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, Func<TKey> keyFunc, Func<TValue> valueFunc)
        {
            return FindOrInsert(dictionary, keyFunc(), valueFunc);
        }

        

        

       
    }
}
