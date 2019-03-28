using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.SystemExtension
{
    /// <summary>
    /// 时间，之前和当前;
    /// </summary>
    /// <summary>
    /// 
    /// </summary>
    public class PriorAndCurrent<T>
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="datetime"></param>
        /// <param name="now"></param>
        public PriorAndCurrent(T datetime, T now)
        {
            this.Prior = datetime;
            this.Current = now;
        }

        /// <summary>
        /// 之前操作时间
        /// </summary>
        public T Prior { get; set; }

        /// <summary>
        /// 当前操作时间
        /// </summary>
        public T Current { get; set; }

    }
}
