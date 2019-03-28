using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.Vue.Enums
{
    /// <summary>
    /// 点击时的处理方式
    /// </summary>
    public enum EnumListCellClickOperate
    {
        /// <summary>
        /// 什么都不做
        /// </summary>
        None = 0,
        /// <summary>
        /// 弹出模态窗口
        /// </summary>
        Dialog = 1,
        /// <summary>
        /// 弹出编辑窗口,类似预编辑按钮;
        /// </summary>
        DialogForEdit = 2,
        /// <summary>
        /// 弹出修改某一个字段的选项；
        /// </summary>
        DialogForChange = 3,
    }
}
