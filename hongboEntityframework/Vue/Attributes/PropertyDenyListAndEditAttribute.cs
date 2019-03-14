using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.Vue.Attributes
{
    /// <summary>
    /// 某个属性禁止 在列表中显示以及进行编辑 的标注;
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class PropertyDenyListAndEditAttribute : Attribute
    {
    }
}
