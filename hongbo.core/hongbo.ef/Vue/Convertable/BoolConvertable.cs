using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using hongbao.Vue.Attributes;
using hongbao.Vue.ElementUi;
using hongbao.Vue.Enums;

namespace hongbao.Vue.Convertable
{
    /// <summary>
    /// 根据 type，以及 property，
    /// 将 bool 类型自动转换为一个Vue客户端编辑组件（AbstractPropertyComponentAttribute）
    /// </summary>
    public class BoolConvertable : AbstractConvertable
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="type"></param>
        /// <param name="property"></param>
        public BoolConvertable(Type type, PropertyInfo property) : base(type, property)
        {
        }

        /// <summary>
        /// 转换成为 可编辑 元素;
        /// </summary>
        /// <param name="type"></param>
        /// <param name="property"></param>
        /// <returns></returns>
        public override AbstractPropertyComponentAttribute ConvertToClientEditVueComponentAttribute(Type type, PropertyInfo property)
        {
            //可以为空的 boolean; 互斥的 checkbox group
            if (IsNullable) return new AbstractPropertyComponentAttribute(EnumComponentSchema.List, EnumComponentType.ehay_boolean_conflict_checkboxgroup) { property = property };
            //不允许空的boolean;
            else return new AbstractPropertyComponentAttribute(EnumComponentSchema.List, EnumComponentType.ehay_boolean_radiogroup) { property = property };
        }

        /// <summary>
        /// 转换成为 ehay_bool_show 元素;
        /// </summary>
        /// <param name="type"></param>
        /// <param name="property"></param>
        /// <returns></returns>
        public override AbstractPropertyComponentAttribute ConvertToClientTableColumnVueComponentAttribute(Type type, PropertyInfo property)
        {
            return new AbstractPropertyComponentAttribute(EnumComponentSchema.List, EnumComponentType.ehay_boolean_show) { property = property };
        }

        /// <summary>
        /// 转换为过滤组件
        /// </summary>
        /// <param name="type"></param>
        /// <param name="property"></param>
        /// <returns></returns>
        public override AbstractPropertyComponentAttribute ConvertToFilterVueComponentAttribute(Type type, PropertyInfo property)
        {
            return new AbstractPropertyComponentAttribute(EnumComponentSchema.Filter, EnumComponentType.ehay_boolean_checkboxgroup) { property = property };
        }
    }
}
