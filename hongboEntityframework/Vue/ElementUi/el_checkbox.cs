using hongbao.Vue.Attributes;
using hongbao.Vue.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.Vue.ElementUi
{
    /// <summary>
    /// el_checkbox 
    /// </summary>
    public class el_checkbox  : AbstractPropertyComponentAttribute
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public el_checkbox(EnumComponentSchema schema) : base(schema, Enums.EnumComponentType.el_checkbox)
        {

        }
        

        ///// <summary>
        ///// 选中状态的值（只有在checkbox-group或者绑定对象类型为array时有效）
        ///// </summary>
        //public string label { get; set; }
        //    /// <summary>
        //    /// 选中时的值
        //    /// </summary>
        //    public string true-label { get; set; }
        ///// <summary>
        ///// 没有选中时的值
        ///// </summary>
        //public string false-label { get; set; }
        ///// <summary>
        ///// 是否禁用
        ///// </summary>
        //public bool disabled { get; set; }
        /// <summary>
        /// 是否显示边框
        /// </summary>
        public bool border { get; set; }
        ///// <summary>
        ///// Checkbox 的尺寸，仅在 border 为真时有效
        ///// </summary>
        //public string size { get; set; }
        /// <summary>
        /// 原生 name 属性
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 当前是否勾选
        /// </summary>
        public bool @checked { get; set; }

        /// <summary>
        /// 设置 indeterminate 状态，只负责样式控制
        /// </summary>
        public bool indeterminate { get; set; }

        /// <summary>
        /// 转换;
        /// </summary>
        /// <param name="label"></param>
        public static implicit operator el_checkbox(string label)
        {
            return new el_checkbox(EnumComponentSchema.Edit) { label = label };
        }
    }
}
