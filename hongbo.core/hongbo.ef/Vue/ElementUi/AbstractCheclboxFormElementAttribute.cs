using hongbao.Vue.Attributes;
using hongbao.Vue.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.Vue.ElementUi
{
    /// <summary>
    /// 抽象的表单组件标注;
    /// </summary>
    public interface ICheckboxOption
    {
        /// <summary>
        /// 是否互斥
        /// </summary>
        bool conflictEachOther { get; set; }
        /// <summary>
        /// 所选项是否拼接成字符串返回;
        /// </summary>
        bool concatValue { get; set; }

        /// <summary>
        /// 值如何产生;
        /// </summary>
        EnumCheckboxConfigValueOption valueOption { get; set; }

        /// <summary>
        /// 过滤条件的 Json 字符串;例如, { IsDeviceOwner: true }
        /// </summary>
        string entityFilterConditionJson { get; set; }

    }
}
