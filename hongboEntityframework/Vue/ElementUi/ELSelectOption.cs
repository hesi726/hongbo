using hongbao.EntityExtension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.Vue.ElementUi
{
    /// <summary>
    /// ElementUI 的 SelectOption 的选项类;
    /// </summary>
    public class ELSelectOption
    {
        /// <summary>
        /// 标签
        /// </summary>
        [NotNull]
        public string label { get; set; }

        /// <summary>
        /// 值，可能是 int， 也可能是 string, 还有可能是其他;
        /// </summary>
        [NotNull]
        public object value { get; set; }
    }
}
