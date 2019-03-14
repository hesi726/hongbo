using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.Vue.Attributes
{
    /// <summary>
    /// 类禁止 进行编辑的标注;
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class ClassDenyEditAttribut : Attribute
    {
    }
}
