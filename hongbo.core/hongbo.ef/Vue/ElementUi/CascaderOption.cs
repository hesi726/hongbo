using hongbao.Vue.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using hongbao.EntityExtension;

namespace hongbao.Vue.ElementUi
{
    /// <summary>
    /// element-ui 的选项类，value为 string 类型，
    /// 注意，带有 children 可以用于 Cascader 组件;
    /// </summary>
    public class elmentui_option_stringvalue
    {

        /// <summary>
        /// label
        /// </summary>
        [NotNull]
        public string label { get; set; }

        /// <summary>
        /// 是否禁用;
        /// </summary>

        [NotNull]
        public bool disabled { get; set; }

        /// <summary>
        /// 值;
        /// </summary>
        [NotNull]
        public string value { get; set; }

        /// <summary>
        /// 值;
        /// </summary>
        public string desc { get; set; }

        /// <summary>
        /// 子项列表
        /// </summary>
        [NotNull]
        public List<elmentui_option_stringvalue> children { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonIgnore]
        public int id { get; set; }

        /// <summary>
        /// 父元素的Id;
        /// </summary>
        [JsonIgnore]
        public int upperId { get; set; }
    }

    /// <summary>
    ///  element-ui 的选项类，value为 int 类型
    ///  注意，带有 children 可以用于 Cascader 组件;
    /// </summary>
    public class elmentui_option_intvalue
    {
        /// <summary>
        /// label
        /// </summary>
        [NotNull]
        public string label { get; set; }

        /// <summary>
        /// 是否禁用;
        /// </summary>

        [NotNull]
        public bool disabled { get; set; }

        /// <summary>
        /// 值;
        /// </summary>
        public string desc { get; set; }

        /// <summary>
        /// 值;
        /// </summary>
        [NotNull]
        public string value { get; set; }
        /// <summary>
        /// 子项列表
        /// </summary>
        [NotNull]
        public List<elmentui_option_intvalue> children { get; set; }
    }

    ///// <summary>
    ///// 字符串类型的值的下拉数据项
    ///// </summary>
    //public class CascaderStringValueOption : elmentui_option_intvalue
    //{
    //    /// <summary>
    //    /// label
    //    /// </summary>
    //    [NotNull]
    //    public string label { get; set; }

    //    /// <summary>
    //    /// 是否禁用;
    //    /// </summary>

    //    [NotNull]
    //    public bool disabled { get; set; }

    //    /// <summary>
    //    /// 值;
    //    /// </summary>
    //    [NotNull]
    //    public string value { get; set; }
    //    /// <summary>
    //    /// 子项列表
    //    /// </summary>
    //    [NotNull]
    //    public List<CascaderStringValueOption> children { get; set; }
    //}
}
