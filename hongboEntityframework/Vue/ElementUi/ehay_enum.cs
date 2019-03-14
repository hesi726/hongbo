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
    /// 枚举类型对应的组件，说明：枚举类型可能对应有很多组件;
    /// </summary>
    public class ehay_enum : AbstractPropertyComponentAttribute
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="componentSchema"></param>
        /// <param name="componentType"></param>
        public ehay_enum(EnumComponentSchema componentSchema,
            EnumComponentType componentType
        ): base(componentSchema, componentType)
        {
          
        }

        /// <summary>
        /// 枚举类型名称，不要删除，客户端Vue组件有用;
        /// </summary>
        public string entityTypeName
        {
            get
            {
                return this.property.PropertyType.Name;
            }
        }
    }
}
