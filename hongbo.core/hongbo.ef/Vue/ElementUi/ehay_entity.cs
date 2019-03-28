using hongbao.Vue.Attributes;
using hongbao.Vue.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.Vue.ElementUi
{
    /// <summary>
    /// 实体类型对应的组件，
    /// </summary>
    public abstract class ehay_entity : AbstractPropertyComponentAttribute
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="componentSchema"></param>
        /// <param name="componentType"></param>
        public ehay_entity(EnumComponentSchema componentSchema,
            EnumComponentType componentType
        ): base(componentSchema, componentType)
        {
           
        }
        /// <summary>
        /// 实体类型;
        /// </summary>
        [JsonIgnore]
        public Type entityType
        {
            get;
            set;
        }

        /// <summary>
        /// 实体类型名称，不要删除，客户端Vue组件有用;
        /// </summary>
        public string entityTypeName
        {
            get { return this.entityType.Name; }
        }

        /// <summary>
        /// 过滤条件的 Json 字符串;例如, { IsDeviceOwner: true }
        /// </summary>
        public string entityFilterConditionJson { get; set; }
    }



    /** MultiCheckboxConfig 的 value 如何产生 */
    public enum EnumCheckboxConfigValueOption
    {
        /** 当没有指定 valueArray时， 使用 label 的索引作为值 */
        Index,

        /** 当没有指定 valueArray时，使用 label 作为值 */
        Label,

        /** 无论是否指定 valueArray时，总是使用 label 作为值 */
        AlwaysUseLabel
    }
}
