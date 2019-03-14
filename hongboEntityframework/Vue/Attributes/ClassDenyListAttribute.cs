using hongbao.Vue.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.Vue.Attributes
{
    /// <summary>
    /// Property 禁止过滤的标注，
    /// 一个过滤字段对应到一个过滤组件，所以过滤字段必须指定过滤组件的类型
    /// 对应到 vue，
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class ClassDenyListAttribute : Attribute
    {
       
    }
}
