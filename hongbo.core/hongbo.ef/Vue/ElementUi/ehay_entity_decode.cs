using hongbao.Vue.Attributes;
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
    /// 实体字符串解码的组件，即将 Id 转码成对应的字符串;
    /// </summary>
    public class ehay_entity_decode : ehay_entity
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="componentSchema"></param>
        public ehay_entity_decode(EnumComponentSchema componentSchema
        ): base(componentSchema, EnumComponentType.ehay_entity_decode)
        {
           
        }
        
    }

    
}
