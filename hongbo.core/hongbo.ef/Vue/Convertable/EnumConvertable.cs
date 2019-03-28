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
    /// 将 Enum 类型自动转换为一个Vue客户端组件（AbstractPropertyComponentAttribute）
    /// </summary>
    public class EnumConvertable : AbstractConvertable
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="type"></param>
        /// <param name="property"></param>
        public EnumConvertable(Type type, PropertyInfo property) : base(type, property)
        {
        }

        /// <summary>
        /// 转换成为 Vue客户端 编辑组件
        /// </summary>
        /// <param name="type"></param>
        /// <param name="property"></param>
        /// <returns></returns>
        public override AbstractPropertyComponentAttribute ConvertToClientEditVueComponentAttribute(Type type, PropertyInfo property)
        {
            var propType = property.PropertyType;
            if (propType.IsGenericType)  //运行为空时，使用 checkbox 互斥;
            {
                if (propType.GetCustomAttribute<FlagsAttribute>() != null) //flags , 可以多选;
                {
                    return new AbstractPropertyComponentAttribute(EnumComponentSchema.Edit, EnumComponentType.ehay_enum_checkboxGroup) { property = property };
                }
                else //flags , 可以多选;
                {   
                    return new AbstractPropertyComponentAttribute(EnumComponentSchema.Edit, EnumComponentType.ehay_enum_checkboxGroup) { property = property };
                }
            }
            else if (propType.GetCustomAttribute<FlagsAttribute>() != null)
            {
                return new AbstractPropertyComponentAttribute(EnumComponentSchema.Edit, EnumComponentType.ehay_enum_checkboxGroup) { property = property };
            }
            else return new ehay_enum_radiogroup(EnumComponentSchema.Edit) { property = property };
        }

        /// <summary>
        /// 转换成为 Vue客户端 展示组件
        /// </summary>
        /// <param name="type"></param>
        /// <param name="property"></param>
        /// <returns></returns>
        public override AbstractPropertyComponentAttribute ConvertToClientTableColumnVueComponentAttribute(Type type, PropertyInfo property)
        {
            return new ehay_enum(EnumComponentSchema.List,EnumComponentType.ehay_enum_show) { property = property };
        }

        /// <summary>
        /// 转换成为 Vue客户端 过滤组件
        /// </summary>
        /// <param name="type"></param>
        /// <param name="property"></param>
        /// <returns></returns>
        public override AbstractPropertyComponentAttribute ConvertToFilterVueComponentAttribute(Type type, PropertyInfo property)
        {
            return new ehay_enum(EnumComponentSchema.Filter, EnumComponentType.ehay_enum_checkboxGroup) { property = property }; //过滤时可以多选,
        }
    }
}
