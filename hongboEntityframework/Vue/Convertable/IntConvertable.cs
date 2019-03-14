using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using hongbao.EntityExtension;
using hongbao.Reflection;
using hongbao.SystemExtension;
using hongbao.Vue.Attributes;
using hongbao.Vue.ElementUi;
using hongbao.Vue.Enums;

namespace hongbao.Vue.Convertable
{
    /// <summary>
    /// 根据 type，以及 property，
    /// 将 int 类型自动转换为一个Vue客户端编辑组件（AbstractPropertyComponentAttribute）
    /// </summary>
    public class IntConvertable : AbstractConvertable
    {
        PropertyInfo foreignProperty = null;
        bool isRelateToUpper;
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="entityType"></param>
        /// <param name="property"></param>
        public IntConvertable(Type entityType, PropertyInfo property) : base(entityType, property)
        {
            var foreignKey = TypeUtil.GetFirstPropertyWithAttribute<ForeignKeyAttribute>(this.EntityType, (foreign) => foreign.Name == property.Name);
            if (foreignKey.Attr != null)  //有外键;
            {
                foreignProperty = foreignKey.Property;                
            }
            else if (typeof(IRelateToUpper).IsAssignableFrom(entityType) && property.Name == "UpperId")
            {
                foreignProperty = property;
                this.isRelateToUpper = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private Type getEntityType()
        {
            if (this.isRelateToUpper)
            {
                return this.EntityType;
            }
            else if (foreignProperty != null)
            {
                return foreignProperty.PropertyType;
            }
            return null;
        }

        
        /// <summary>
        /// 转换成为 el_input 元素;
        /// </summary>
        /// <param name="type"></param>
        /// <param name="property"></param>
        /// <returns></returns>
        public override AbstractPropertyComponentAttribute ConvertToClientEditVueComponentAttribute(Type type, PropertyInfo property)
        {
            if (foreignProperty != null)  //有外键;
            {
                var result = new ehay_entity_singleselect(EnumComponentSchema.Edit)
                {
                    entityType = getEntityType()
                };
                result.clearable = property.PropertyType.IsGenericType;  //是否可以清除可为null
                if (!result.clearable && (this.isRelateToUpper || this.foreignProperty != null))
                {
                    result.verifyInput += (value) =>
                    {
                        if (value == null) return $"需要指定{result.label}";
                        int ivalue;
                        if (!Int32.TryParse(value.ToString(), out ivalue))
                        {
                            return $"需要指定{result.label}";
                        }
                        if (ivalue == 0)
                        {
                            return $"需要指定{result.label}";
                        }
                        return null;
                    };
                }
                return result;
            }
            return new el_inputAttribute(EnumComponentSchema.Edit);
        }

        

        /// <summary>
        /// 转换成为 ehay_span 元素;
        /// </summary>
        /// <param name="type"></param>
        /// <param name="property"></param>
        /// <returns></returns>
        public override AbstractPropertyComponentAttribute ConvertToClientTableColumnVueComponentAttribute(Type type, PropertyInfo property)
        {
            if (foreignProperty != null) //有外键;
            {
                var result = new ehay_entity_decode(EnumComponentSchema.List)
                {
                    entityType = getEntityType()
                };
                return result;
            }
            return new ehay_span(EnumComponentSchema.List);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <param name="property"></param>
        /// <returns></returns>
        public override AbstractPropertyComponentAttribute ConvertToFilterVueComponentAttribute(Type type, PropertyInfo property)
        {
            var stringLength = property.GetCustomAttribute<StringLengthAttribute>();
            return new el_inputAttribute(EnumComponentSchema.Filter);
        }
    }
}
