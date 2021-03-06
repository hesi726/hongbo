﻿using System;
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
    /// 将 Datetime 类型自动转换为一个Vue客户端编辑组件（AbstractPropertyComponentAttribute）
    /// </summary>
    public class DatetimeConvertable : AbstractConvertable
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="type"></param>
        /// <param name="property"></param>
        public DatetimeConvertable(Type type, PropertyInfo property) : base(type, property)
        {
        }

        /// <summary>
        /// 转换成为 el_input 元素;
        /// </summary>
        /// <param name="type"></param>
        /// <param name="property"></param>
        /// <returns></returns>
        public override AbstractPropertyComponentAttribute ConvertToClientEditVueComponentAttribute(Type type, PropertyInfo property)
        {
            return new el_date_picker(EnumComponentSchema.Edit);
        }

        /// <summary>
        /// 转换成为 ehay_span 元素;
        /// </summary>
        /// <param name="type"></param>
        /// <param name="property"></param>
        /// <returns></returns>
        public override AbstractPropertyComponentAttribute ConvertToClientTableColumnVueComponentAttribute(Type type, PropertyInfo property)
        {
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
            return new ehay_daterange_picker(EnumComponentSchema.Filter);
        }
    }
}
