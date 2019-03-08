using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.SystemExtension
{
    /// <summary>
    /// 一个结构的持有器,因为结构在作为参数传递时，是传值传递，使用此类型转换为传引用传递；
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class StructHolder<T>
        where T : struct
    {
        /// <summary>
        /// 
        /// </summary>
        public static StructHolder<bool>  TRUE = true;

        /// <summary>
        /// 
        /// </summary>
        public T Data { get; set; }

        /// <summary>
        /// 一个结构对象的持有器;
        /// </summary>
        public StructHolder()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="t"></param>
        public StructHolder(T t)
        {
            this.Data = t;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tt"></param>
        public static implicit operator  T(StructHolder<T> tt)
        {
            return tt.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tt"></param>
        public static implicit operator StructHolder<T>(T tt)
        {
            return new StructHolder<T>(tt);
        }
    }
}
