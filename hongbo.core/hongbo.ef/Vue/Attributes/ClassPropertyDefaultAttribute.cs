using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.Vue.Attributes
{
    /// <summary>
    /// 用于说明默认下， 类的属性是否允许 列表、编辑 和编辑
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class ClassPropertyDefaultAttribute : Attribute
    {
        /// <summary>
        /// 构造函数，默认下为安全考虑，默认下所有属性都不允许进行编辑、显示和过滤;
        /// </summary>
        public ClassPropertyDefaultAttribute(EnumClassPropertyEntityOperate defaultPropertyEntityOperate)
        {
            this.DefaultPropertyEntityOperate = defaultPropertyEntityOperate;
        }

        /// <summary>
        /// 属性是否默认允许编辑,为安全考虑，默认下所有属性都不允许进行编辑;
        /// </summary>
        public EnumClassPropertyEntityOperate DefaultPropertyEntityOperate { get; set; }
    }

    ///// <summary>
    ///// 默认下， 类的属性禁止允许 列表、编辑 和编辑
    ///// </summary>
    //public class ClassPropertyDenyAccessAttribute: ClassPropertyDefaultAttribute 
    //{
    //    /// <summary>
    //    /// 构造函数
    //    /// </summary>
    //    public ClassPropertyDenyAccessAttribute(): base(EnumClassPropertyEntityOperate.DenyShowProperty)
    //    {

    //    }
    //}

    ///// <summary>
    ///// 默认下， 类的属性禁止允许 列表、编辑 和编辑
    ///// </summary>
    //public class ClassPropertyAllowAccessAttribute : ClassPropertyDefaultAttribute
    //{
    //    /// <summary>
    //    /// 构造函数
    //    /// </summary>
    //    public ClassPropertyAllowAccessAttribute() : base(EnumClassPropertyEntityOperate.AllowShowProperty)
    //    {

    //    }
    //}

    /// <summary>
    /// 类的属性未声明对应编辑标注时，是否允许编辑此列;
    /// </summary>
    public enum EnumClassPropertyEntityOperate
    {
        /// <summary>
        /// 类的属性未声明属性对应编辑组件时，
        /// 属性将显示在实体的操作列中;
        /// </summary>
        AllowEditAndList,

        /// <summary>
        /// 类的属性未声明属性对应编辑组件时，
        /// 属性将不显示在实体的操作列中;
        /// </summary>
        DenyEditAndList
    }
}
