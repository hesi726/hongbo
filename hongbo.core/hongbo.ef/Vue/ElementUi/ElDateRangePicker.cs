using hongbao.Vue.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.Vue.ElementUi
{
    /// <summary>
    /// 日期范围选择
    /// </summary>
    public class ElDateRangePicker : AbstractFormElementAttribute
    {
        public ElDateRangePicker(EnumComponentSchema schema) : base(schema, Enums.EnumComponentType.auto)
        {

        }
    }
}
