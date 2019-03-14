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
    /// 实体类型对应的组件，
    /// </summary>
    public class ehay_dialog_forcomponent : AbstractPropertyComponentAttribute
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="componentSchema"></param>
        /// <param name="componentId">一个用来表示组件的Id，客户端必须注册此Id对应的组件</param>
        public ehay_dialog_forcomponent(EnumComponentSchema componentSchema,
                int componentId
        ) : base(componentSchema, EnumComponentType.ehay_dialog_forcomponent)
        {
            this.componentId = componentId;
        }
        /// <summary>
        /// 实体类型;
        /// </summary>
        public int componentId
        {
            get;
            set;
        }
        /// <summary>
        /// 按钮的前缀
        /// </summary>
        public string prefix { get; set; }
        /// <summary>
        /// 按钮可以点击时的最小值;
        /// </summary>
        public object minvalue { get; set; }
    }
}
