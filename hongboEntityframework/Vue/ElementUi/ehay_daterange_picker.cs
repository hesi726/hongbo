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
    /// ehay_daterange 元素,日期范围选择;
    /// </summary>
    public class ehay_daterange_picker : AbstractPropertyComponentAttribute
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public ehay_daterange_picker(EnumComponentSchema schema) : base(schema, Enums.EnumComponentType.ehay_daterange_picker)
        {

        }
    }
}
