using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.Json
{
    /// <summary>
    /// 拆分和合并,将值根据逗号拆分成字符串数组(输出Json时)或者将数组合并成字符串(解析)
    /// 稀奇，会产生异常; 
    /// </summary>
    public class CombineAndSplitAttribute : Attribute
    {
        /// <summary>
        /// 
        /// </summary>
        public CombineAndSplitAttribute()
        {
        }

    }
}
