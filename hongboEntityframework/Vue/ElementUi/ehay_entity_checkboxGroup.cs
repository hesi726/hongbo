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
    /// 实体类型对应的 checkboxGroup 组件，
    /// </summary>
    public class ehay_entity_checkboxGroup : ehay_entity, ICheckboxOption
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="componentSchema"></param>
        public ehay_entity_checkboxGroup(EnumComponentSchema componentSchema
        ) : base(componentSchema, EnumComponentType.ehay_entity_checkboxGroup)
        {

        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="componentSchema"></param>
        /// <param name="enumComponentType"></param>
        protected ehay_entity_checkboxGroup(EnumComponentSchema componentSchema,
            EnumComponentType enumComponentType
        ) : base(componentSchema, enumComponentType)
        {

        }
        /// <summary>
        /// 是否互斥
        /// </summary>
        public bool conflictEachOther { get; set; }
        /// <summary>
        /// 所选项是否拼接成字符串返回;
        /// </summary>
        public bool concatValue { get; set; }

        /// <summary>
        /// 值如何产生;
        /// </summary>
        public EnumCheckboxConfigValueOption valueOption { get; set; }
    }

    /// <summary>
    /// 实体类型对应带可折叠 的 checkboxGroup 组件
    /// </summary>
    public class ehay_entity_checkboxGroup_collapse: ehay_entity_checkboxGroup
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="componentSchema"></param>
        public ehay_entity_checkboxGroup_collapse(EnumComponentSchema componentSchema
        ) : base(componentSchema, EnumComponentType.ehay_entity_checkboxGroup_collapse)
        {

        }
    }
}
