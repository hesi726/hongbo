using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hongbao.Vue.Enums;

namespace hongbao.Vue.ElementUi
{
    /// <summary>
    /// 日期选择
    /// </summary>
    public class el_date_picker : AbstractFormElementAttribute
    {
        /// <summary>
        /// 
        /// </summary>
        public el_date_picker(EnumComponentSchema schema) : base(schema, Enums.EnumComponentType.el_date_picker)
        {
            this.valueFormat = "yyyy-MM-dd";
        }

        /// <summary>
        /// 值格式;
        /// </summary>
        public string valueFormat { get; set; }
    }
}
