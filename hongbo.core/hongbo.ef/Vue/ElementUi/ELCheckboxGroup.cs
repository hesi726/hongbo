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
    public class ELCheckboxGroup : AbstractFormElementAttribute
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="schema"></param>
        public ELCheckboxGroup(EnumComponentSchema schema) : base(schema, EnumComponentType.el_checkbox_group)
        {

        }

        /// <summary>
        /// 多选框组尺寸，仅对按钮形式的 Checkbox 或带有边框的 Checkbox 有效
        /// </summary>
        public override EnumSize? size { get; set; }

        /// <summary>
        /// 可被勾选的 checkbox 的最小数量
        /// </summary>
        public int min { get; set; }
        /// <summary>
        /// 可被勾选的 checkbox 的最大数量
        /// </summary>
        public int max { get; set; }
        ///// <summary>
        ///// 按钮形式的 Checkbox 激活时的文本颜色
        ///// </summary>
        //public string text-color { get; set; }
        /// <summary>
        /// 按钮形式的 Checkbox 激活时的填充色和边框色
        /// </summary>
        public string fill { get; set; }


        /// <summary>
        /// 组件内容列表
        /// </summary>
        public List<el_checkbox> CheckboxList { get; set; }

        /// <summary>
        /// 转换;
        /// </summary>
        /// <param name="labelList"></param>
        public static implicit operator ELCheckboxGroup(List<string> labelList)
        {
            var result = new ELCheckboxGroup(EnumComponentSchema.Edit) { CheckboxList = labelList.Select(a => (el_checkbox)a).ToList() };
            return result;
        }
    }
}
