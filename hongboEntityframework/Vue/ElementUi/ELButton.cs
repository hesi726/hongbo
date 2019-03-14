using hongbao.Vue.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.Vue.ElementUi
{
    /// <summary>
    /// EL-Button组件;
    /// </summary>
    public class ELButton : AbstractFormElementAttribute
    {
        public ELButton(EnumComponentSchema schema) : base(schema, EnumComponentType.el_button)
        {

        }

        /// <summary>
        /// 是否是朴素按钮
        /// </summary>
        public bool plain { get; set; }
        /// <summary>
        /// 是否圆角按钮
        /// </summary>
        public bool round { get; set; }
        /// <summary>
        /// 是否圆形按钮
        /// </summary>
        public bool circle { get; set; }
        /// <summary>
        /// 是否加载中状态
        /// </summary>
        public bool loading { get; set; }
       
        /// <summary>
        /// 图标类名
        /// </summary>
        public string icon { get; set; }
        /// <summary>
        /// 是否默认聚焦
        /// </summary>
        public bool autofocus { get; set; }
        /// <summary>
        /// 原生 type 属性
        /// </summary>
        public string native_type { get; set; }

}
}
