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
    /// ElRadioButton按钮
    /// </summary>
    public class ELRadioButton : ELRadio
    {
        
        /// <summary>
        /// 转换;
        /// </summary>
        /// <param name="label"></param>
        public static implicit operator ELRadioButton(string label)
        {
            return new ELRadioButton { label = label };
        }

    }
}
