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
    /// 将 string 类型自动转换为一个Vue客户端编辑组件（AbstractPropertyComponentAttribute）
    /// </summary>
    public class StringConvertable : AbstractConvertable
    {
        StringLengthAttribute stringLength;
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="type"></param>
        /// <param name="property"></param>
        public StringConvertable(Type type, PropertyInfo property):base(type, property)
        {
            stringLength = property.GetCustomAttribute<StringLengthAttribute>();
        }

        /// <summary>
        /// 转换成为 el_input 元素;
        /// </summary>
        /// <param name="type"></param>
        /// <param name="property"></param>
        /// <returns></returns>
        public override AbstractPropertyComponentAttribute ConvertToClientEditVueComponentAttribute(Type type,
            PropertyInfo property)
        {
            if (PropertyName == "CreateDateTime" || PropertyName == "LastModifyDateTime"   //创建日期、最后修改日期，不可编辑
                || PropertyName == "Privileges")    //权限只可以在列表中编辑;
            {
                return null;
            }
            if (stringLength != null && stringLength.MaximumLength > 180)
            {
                return new el_inputAttribute(EnumComponentSchema.Edit) { type = "textarea" };
            }
            return new el_inputAttribute(EnumComponentSchema.Edit);
        }
        

        /// <summary>
        /// 转换成为 ehay_span 元素; 单纯的文本显示;
        /// </summary>
        /// <param name="type"></param>
        /// <param name="property"></param>
        /// <returns></returns>
        public override AbstractPropertyComponentAttribute ConvertToClientTableColumnVueComponentAttribute(Type type, 
            PropertyInfo property)
        {
            if (PropertyName == "Privileges")
            {
                return new ehay_privilege_show(EnumComponentSchema.List) { width = "450px", label="权限" };
            }
            if (PropertyName == "Password")
            {
                return new el_inputAttribute(EnumComponentSchema.List)
                {
                    label = "密码",
                    type = "password"
                };
            }
            return new ehay_span(EnumComponentSchema.List) { property = property };
        }

        /// <summary>
        /// 过滤列，单纯的 ELInputAttribute 属性;
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
