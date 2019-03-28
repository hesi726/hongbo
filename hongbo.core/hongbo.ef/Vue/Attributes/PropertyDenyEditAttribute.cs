using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.Vue.Attributes
{
    /// <summary>
    ///  Property 禁止 进行编辑操作 的标注;
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class PropertyDenyEditAttribute : Attribute
    {
    }
}
