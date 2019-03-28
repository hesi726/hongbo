using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.Vue.Attributes
{
    /// <summary>
    ///  Property 禁止在 List 中显示 的标注;
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class PropertyDenyListAttribute : Attribute
    {
    }
}
