using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace hongbao.privileges
{
    /// <summary>
    /// 实体查询属性;
    /// 注意，不是所有的实体类都可以查询，
    /// 带有本属性描述的将会自动产生 实体查询的 Vue组件, 包含有 CheckBoxGroup, SingleSelect  
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class EntityQueryAttribute : AbstractAllowAttribute
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="privilege">是否有权限创建此对象</param>
        /// <param name="labelField"></param>
        /// <param name="valueField"></param>
        public EntityQueryAttribute(string privilege,  string labelField = "Name", string valueField = "Xid"): base(privilege)
        {
            this.LabelField = labelField;
            this.ValueField = valueField;
        }

        /// <summary>
        /// 实体的 Label 字段, 默认为 Name
        /// </summary>
        public string LabelField { get;  private set; }

        /// <summary>
        /// 实体的值字段，默认为 Xid
        /// </summary>
        public string ValueField { get; private set; }

        /// <summary>
        /// 是否允许创建新的实体
        /// </summary>
        public bool AllowCreate { get; set; }
    }
}