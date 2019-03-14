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
    /// ElRadio 
    /// </summary>
    public class ELRadio 
    {
        /// <summary>
        /// Radio 的 value，选中时的值，未选中时肯定为null;
        /// </summary>
        public string label { get; set; }
        
        /// <summary>
        /// 是否显示边框
        /// </summary>
        public bool border { get; set; }

        /// <summary>
        /// 原生 name 属性
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 转换;
        /// </summary>
        /// <param name="label"></param>
        public static implicit operator ELRadio(string label)
        {
            return new ELRadio { label = label };
        }
    }
}
