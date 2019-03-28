using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.EntityExtension
{
    /// <summary>
    /// State 接口 
    /// </summary>
    /// <typeparam name="K">状态，一般会是枚举类;</typeparam>
    public interface IState<K>
        where K : struct
    {
        /// <summary>
        /// 获取状态
        /// </summary>
        K State { get; set; }       
    }
}
