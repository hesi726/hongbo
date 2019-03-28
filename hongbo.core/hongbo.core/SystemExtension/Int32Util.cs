using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.SystemExtension
{
    /// <summary>
    /// 
    /// </summary>
    public static class Int32Util
    {
        /// <summary>
        /// 为null或者0;
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public static bool IsNullOrZero(this int? val)
        {
            return !val.HasValue || val.Value == 0;
        }
    }
}
