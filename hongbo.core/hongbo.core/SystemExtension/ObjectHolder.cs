using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.SystemExtension
{
    /// <summary>
    /// 一个对象的持有器,主要用于 Tuple, 匿名对象的属性中
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ObjectHolder<T>
    {
        /// <summary>
        /// 
        /// </summary>

        /// <summary>
        /// 
        /// </summary>
        public T Data { get; set; }

        /// <summary>
        /// 一个结构对象的持有器;
        /// </summary>
        public ObjectHolder()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="t"></param>
        public ObjectHolder(T t)
        {
            this.Data = t;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tt"></param>
        public static implicit operator  T(ObjectHolder<T> tt)
        {
            return tt.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tt"></param>
        public static implicit operator ObjectHolder<T>(T tt)
        {
            return new ObjectHolder<T>(tt);
        }
    }
}
