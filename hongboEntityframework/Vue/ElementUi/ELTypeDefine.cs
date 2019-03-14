using hongbao.EntityExtension;
using hongbao.Vue.Attributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.Vue.ElementUi
{
    /// <summary>
    /// 根据实体类型上的标注所抽离出来的实体的对应Vue组件定义;
    /// </summary>
    public class ELTypeDefine
    {
        /// <summary>
        /// 根据 Type 标注获取到的 可编辑属性 对应的Vue组件
        /// </summary>
        public List<AbstractPropertyComponentAttribute> EditPropertyComponentAttribute
        { get; set; }

        /// <summary>
        /// 根据 Type 标注获取到的 在列表中 对应的Vue组件
        /// </summary>
        public List<AbstractPropertyComponentAttribute> TablePropertyComponentAttribute
        { get; set; }

        /// <summary>
        /// 根据 Type 标注获取到的 过滤条件 对应的Vue组件
        /// </summary>
        public List<AbstractPropertyComponentAttribute> FilterPropertyComponentAttribute
        { get; set; }
    }
}
