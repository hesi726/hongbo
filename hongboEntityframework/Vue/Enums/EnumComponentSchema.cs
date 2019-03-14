using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.Vue.Enums
{
    /// <summary>
    /// 组件属性分类
    /// 此组件用于 列表、过滤还是编辑；
    /// </summary>
    [Flags]
    public enum EnumComponentSchema
    {
        /// <summary>
        /// 列表
        /// </summary>
        List = 1,

        /// <summary>
        /// 编辑
        /// </summary>
        Edit = 2,

        /// <summary>
        /// 过滤
        /// </summary>
        Filter = 4,

        /// <summary>
        /// 导出到 Excel
        /// </summary>
        Export = 8,

        /// <summary>
        /// 
        /// </summary>

        EditAndList = 1 | 2,

        /// <summary>
        /// 全部
        /// </summary>
        FilterAndEditAndList = 1 | 2 | 4,

    }
}
