using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.Vue.Enums
{
    /// <summary>
    /// 按钮类型
    /// </summary>
    public enum EnumButtonType
    {
        /// <summary>
        /// 主要，背景为蓝色;
        /// </summary>
        primary,
        /// <summary>
        /// 成功，背景为绿色;
        /// </summary>
        success,
        /// <summary>
        /// 警告,背景为橙色;
        /// </summary>
        warning,
        /// <summary>
        /// 危险,背景为红色
        /// </summary>
        danger,
        /// <summary>
        /// 提示,背景为灰色
        /// </summary>
        info,
        /// <summary>
        /// 纯文本
        /// </summary>
        text
    }
}
