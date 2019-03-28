using System;

namespace hongbao.EntityExtension
{
    /// <summary>
    /// 标注某一个字段关联到父实例,
    /// 当指定关联到父实例时，进行查询时如果指定了父id参数，则将查询父Id下的关联子实体;
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class RelateToParentAttribute : OwnerAndTypeAttribute
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="type"></param>
        public RelateToParentAttribute(Type type)
        {
            this.ParentType = type;
        }

        /// <summary>
        /// 类型
        /// </summary>
        public Type ParentType { get; private set; }
    }
}
