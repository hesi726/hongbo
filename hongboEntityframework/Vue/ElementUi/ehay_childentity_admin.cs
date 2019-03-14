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
    /// ehay_childentity_admin 元素
    /// 子实体管理;
    /// </summary>
    public class ehay_childentity_admin : AbstractPropertyComponentAttribute
    {
        private Type childEntityType { get; set; }

        /// <summary>
        /// 构造函数
        /// </summary>
        public ehay_childentity_admin(EnumComponentSchema schema, Type childEntityType):base(schema, Enums.EnumComponentType.ehay_childentity_admin)
        {
            this.childEntityType = childEntityType;
        }

        /// <summary>
        /// 子实体的类型;
        /// </summary>
        public string entityTypeName
        {
            get { return this.childEntityType.Name; }
        }

        /// <summary>
        /// 文本提示
        /// </summary>
        public string text { get; set; }
    }
}
