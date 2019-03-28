using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.SystemExtension
{
    /// <summary>
    /// 对象缓存； 
    /// </summary>
    /// <typeparam name="T">泛型参数，必须为对象类型</typeparam>
    public class Cache<T>
        where T : class
    {
        /// <summary>
        /// 对象缓存的构造函数； 
        /// </summary>
        /// <param name="expireTime">失效时间，分钟为单位； </param>
        /// <param name="tFunc"></param>
        public Cache(int expireTime, Func<T> tFunc)
        {
            this.expireTime = expireTime; 
            this.ExpireDateTime = DateTime.Now.AddSeconds(-1);
            this.loadDataFunc = tFunc;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="maxValue"></param>
        public void AddExpireDateTime(int maxValue)
        {
            this.ExpireDateTime = ExpireDateTime.AddSeconds(maxValue);
        }

        private int expireTime = 0;
        /// <summary>
        /// 
        /// </summary>
        public void SetExpire()
        {
            this.ExpireDateTime = DateTime.Now.AddSeconds(-1);
        }
        /// <summary>
        /// 缓存的对象； 
        /// </summary>
        private Func<T> loadDataFunc { get; set; }

        private object obj = new object();

        private T _data;
        /// <summary>
        /// 缓存的对象； 
        /// </summary>
        public T Data
        {
            get
            {
                if (_data == null || IsExpired)
                {
                    //利用双重锁定来加载数据；                                        
                    lock (obj)
                    {
                        if (_data == null || IsExpired)
                        {
                            _data = loadDataFunc();
                            this.ExpireDateTime = DateTime.Now.AddSeconds(expireTime);
                        }
                    }
                }
                return _data;
            }
            private set
            {
                _data = value;
            }
        }

        /// <summary>
        /// 缓存失效时间； 
        /// </summary>
        public DateTime ExpireDateTime { get; private set; }

        /// <summary>
        /// 是否已经失效； 
        /// </summary>
        public bool IsExpired
        {
            get
            {
                return ExpireDateTime < DateTime.Now;
            }
        }

        /// <summary>
        /// 隐式转换函数； 
        /// </summary>
        /// <param name="t"></param>
        public static implicit operator T(Cache<T> t)
        {
            return t.Data;
        }
    }


    /// <summary>
    /// 对象缓存； 
    /// </summary>
    /// <typeparam name="T">泛型参数，必须为对象类型</typeparam>
    /// <typeparam name="K">泛型参数，必须为对象类型</typeparam>
    public class Cache<T, K> : Cache<Tuple<T,K>>
        where T : class
        where K : class
    {
        /// <summary>
        /// 对象缓存的构造函数； 
        /// </summary>
        /// <param name="expireTime">失效时间，分钟为单位； </param>
        /// <param name="tFunc"></param>
        public Cache(int expireTime, Func<Tuple<T, K>> tFunc) : base(expireTime, tFunc) 
        {
        }

        /// <summary>
        /// 缓存的对象； 
        /// </summary>
        public T TData
        {
            get
            {
                return Data.Item1;
            }
        }

        /// <summary>
        /// 缓存的对象； 
        /// </summary>
        public K KData
        {
            get
            {
                return Data.Item2;
            }
        }


        /// <summary>
        /// 隐式转换函数； 
        /// </summary>
        /// <param name="t"></param>
        public static implicit operator T(Cache<T,K> t)
        {
            return t.TData;
        }

        /// <summary>
        /// 隐式转换函数； 
        /// </summary>
        /// <param name="t"></param>
        public static implicit operator K(Cache<T,K> t)
        {
            return t.KData;
        }
    }
}
