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
    /// ELButtonGroup
    /// </summary>
    public class ELRadioGroup : AbstractFormElementAttribute
    {
        public ELRadioGroup(EnumComponentSchema schema) : base(schema, EnumComponentType.el_radio_group)
        {

        }

        /// <summary>
        /// 单选框组尺寸，仅对按钮形式的 Radio 或带有边框的 Radio 有效
        /// </summary>
        public override EnumSize? size { get; set; }

        ///// <summary>
        ///// 按钮形式的 Radio 激活时的文本颜色
        ///// </summary>
        //[JsonProperty("text-color",)]
        //public string text_color { get; set; }

        /// <summary>
        /// 按钮形式的 Radio 激活时的填充色和边框色
        /// </summary>
        public string fill { get; set; }

        /// <summary>
        /// 组件内容列表
        /// </summary>
        public List<ELRadio> RadioList { get; set; }

        /// <summary>
        /// 转换;
        /// </summary>
        /// <param name="labelList"></param>
        public static implicit operator ELRadioGroup(List<string> labelList)
        {
            var result = new ELRadioGroup(EnumComponentSchema.Edit) { RadioList =  labelList.Select(a=> (ELRadio) a).ToList()  };
            return result;
        }
    }
}
