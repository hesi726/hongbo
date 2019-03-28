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
    /// 实体单选的组件
    /// </summary>
    public class ehay_entity_singleselect : ehay_entity
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="componentSchema"></param>
        public ehay_entity_singleselect(EnumComponentSchema componentSchema
        ): base(componentSchema, EnumComponentType.ehay_entity_singleselect)
        {
           
        }
        /// <summary>
        /// 是否可清除;
        /// </summary>
        public bool clearable { get; internal set; }

        /// <summary>
        /// 是否显示查询条件;(关键字,默认为 false);页面将显示一个关键字输入文本框和查询文本框;
        /// </summary>
        public bool showQueryCondition { get; set; }
    }

    
}
