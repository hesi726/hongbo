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
    /// ELCheckboxButton，按钮形式的 Checkbox;多个按钮并排排列在一起，可以同时选择多个;
    /// </summary>
    public class ELCheckboxButton : el_checkbox
    {
        public ELCheckboxButton(EnumComponentSchema schema) : base(schema)
        {
        }

        /// <summary>
        /// 转换;
        /// </summary>
        /// <param name="label"></param>
        public static implicit operator ELCheckboxButton(string label)
        {
            return new ELCheckboxButton(EnumComponentSchema.Edit) { label = label };
        }

    }
}
