using System;
using System.Collections.Generic;

#if NETCOREAPP2_2
using Microsoft.EntityFrameworkCore;
#else
using System.Data.Entity;
#endif

namespace hongbao.EntityExtension
{
    /// <summary>
    /// 关联到子对象的标注，
    /// 当2个类并没有关联关系或者关联关系无法满足需求时，使用此标注强制给两个类标注父-子 关系;
    /// 例如 省份、城市、区域;
    /// 当需要级联查询所有 父-子-孙-曾孙。。 的关系时，此对象有用;
    /// 注意，根据父查询子，而不是根据子查询父；
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class RelateToChildAttribute: OwnerAndTypeAttribute
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="childType"></param>
        /// <param name="propertyName"></param>
        public RelateToChildAttribute(Type childType, string propertyName)
        {
            this.ChildType = childType;
            this.ParentIdPropertyName = propertyName;
        }

        /// <summary>
        /// 子类，应该继承 IId 接口
        /// </summary>
        public Type ChildType;

        /// <summary>
        /// 子类中指向父实例Id的字段的关联属性;
        /// </summary>
        public string ParentIdPropertyName { get; private set; }
    }

    /// <summary>
    /// 带有子节点的类型;
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IChildren<T>
    {
        /// <summary>
        /// 子节点;
        /// </summary>
        List<T> children { get; set; }
    }

    
}
