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
    public abstract class AbstractFormElementAttribute: AbstractPropertyComponentAttribute
    {       
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="componentType"></param>
        public AbstractFormElementAttribute(EnumComponentSchema schema, EnumComponentType componentType):base(schema, componentType)
        {
        }

        

        /// <summary>
        /// 尺寸
        /// </summary>
        public virtual EnumSize? size { get; set; }

        /// <summary>
        /// 是否禁用状态
        /// </summary>
        public virtual bool disabled { get; set; }

        /// <summary>
        /// 对于 ELAutocomplete 有效;
        /// </summary>
        public string select { get; set; }

        /// <summary>
        /// 对于 ELAutocomplete,ELInput 有效;
        /// </summary>
        public string focus { get; set; }

        /// <summary>
        /// 对于 ELInput 有效;
        /// </summary>
        public string blur { get; set; }
    }
}
