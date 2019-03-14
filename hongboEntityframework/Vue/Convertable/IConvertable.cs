using hongbao.Vue.Attributes;
using hongbao.Vue.ElementUi;
using hongbao.Vue.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.Vue.Convertable
{
    /// <summary>
    /// 抽象的转换类，
    /// 用于将某一个属性转换为 Vue的组件类型;
    /// </summary>
    public abstract class AbstractConvertable
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="type"></param>
        /// <param name="property"></param>
        public AbstractConvertable(Type type, PropertyInfo property)
        {
            this.EntityType = type;
            this.Property = property;
            this.PropertyName = property.Name;
        }

        /// <summary>
        /// 待转换的类型
        /// </summary>
        public Type EntityType { get; private set; }

        /// <summary>
        /// 待转换的属性;
        /// </summary>
        public PropertyInfo Property { get; private set; }

        /// <summary>
        /// 是否允许为空;
        /// </summary>
        /// <returns></returns>
        public bool IsNullable
        {
            get
            {
                if (Property.PropertyType.IsByRef || Property.PropertyType.IsGenericType)
                    return true;
                return false;
            }
        }

        /// <summary>
        /// 属性名称
        /// </summary>
        public string PropertyName { get; private set; }

        /// <summary>
        /// 转换为可编辑的Vue组件;
        /// </summary>
        /// <param name="type"></param>
        /// <param name="property"></param>
        /// <returns></returns>
        public abstract AbstractPropertyComponentAttribute ConvertToClientEditVueComponentAttribute(Type type,
                PropertyInfo property);

        /// <summary>
        /// 转换为在 el-table 中显示的 el-table-column 的Vue组件;
        /// </summary>
        /// <param name="type"></param>
        /// <param name="property"></param>
        /// <returns></returns>
        public virtual AbstractPropertyComponentAttribute ConvertToClientTableColumnVueComponentAttribute(Type type,
                PropertyInfo property)
        {
            return new ehay_span(EnumComponentSchema.List) { property = property };
        }

        /// <summary>
        /// 转换为在过滤条件中的 vue组件
        /// </summary>
        /// <param name="type"></param>
        /// <param name="property"></param>
        /// <returns></returns>
        public abstract AbstractPropertyComponentAttribute ConvertToFilterVueComponentAttribute(Type type,
                PropertyInfo property);
    }
}
