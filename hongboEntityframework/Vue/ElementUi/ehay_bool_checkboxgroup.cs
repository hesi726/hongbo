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
    /// ehay_bool_checkboxgroup 元素
    /// </summary>
    public class ehay_bool_checkboxgroup : AbstractPropertyComponentAttribute
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public ehay_bool_checkboxgroup(EnumComponentSchema schema) :base(schema, Enums.EnumComponentType.ehay_boolean_checkboxgroup)
        {

        }
        
    }
}
