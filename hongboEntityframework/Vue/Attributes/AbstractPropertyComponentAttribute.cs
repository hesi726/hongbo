using hongbao.EntityExtension;
using hongbao.Vue.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.Vue.Attributes
{
    /// <summary>
    /// 属性-组件 标注    
    /// 每一个可操作（列表、过滤、编辑）的属性 通过此标注 对应到一个 Vue组件，
    /// 并在此标注的子类中定义对应 Vue组件的属性;
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
    public class AbstractPropertyComponentAttribute : Attribute, ILimitAttribute
    {
        /// <summary>
        /// 对输入的检验方法;返回 null 表示校验通过了;
        /// </summary>
        [JsonIgnore]
        public Func<object, string> verifyInput { get; set; }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="componentSchema"></param>
        /// <param name="componentType"></param>
        public AbstractPropertyComponentAttribute(EnumComponentSchema componentSchema,
            EnumComponentType componentType
        ) {
            this.componentSchema = componentSchema;
            this.componentType = componentType;
            this.serial = Int32.MaxValue - 100;
            this.showConditionValue = true;
            this.allowEdit = true;
        }

        /// <summary>
        /// 显示此组件的关联字段,
        /// 例如 EH_Partner 的 企业微信设置只有在  IsDeviceOwner = true 时才需要显示;        
        /// </summary>
        public string showCondition { get; set; }

        /// <summary>
        /// 显示此组件的关联字段的值，默认为 true,
        /// 例如 EH_Partner 的 企业微信设置只有在  IsDeviceOwner = true 时才需要显示;
        /// </summary>
        public object showConditionValue { get; set; }

        /// <summary>
        /// 序列号,默认为 Int32.MaxValue - 100
        /// </summary>
        public int serial { get; set; }

        /// <summary>
        /// 是否内联显示;
        /// </summary>
        public virtual bool inline { get; set; }

        /// <summary>
        /// 分组，不为空时，具有同一个组名称的定义将显示在同一个单元格中;
        /// </summary>
        public string listgroup { get; set; }

        /// <summary>
        /// 如果大于0，此字段在编辑时将inline显示,
        /// 其 :span=给定的 span
        /// 并且所有具有 span 的字段将优先显示;
        /// </summary>
        public int editspan { get; set; }

        /// <summary>
        /// 在列表中的显示宽度;
        /// 默认下， CreateDateTime 为 120
        ///          Name = 180
        /// </summary>
        public string width { get; set; }

        /// <summary>
        /// 属性的说明字段
        /// </summary>
        public virtual string label { get; set; }

        /// <summary>
        /// 编辑时是否隐藏 label;
        /// </summary>
        public virtual bool hideLabel { get; set; }

        /// <summary>
        /// 此组件用于 列表、过滤还是编辑,
        /// </summary>
        [JsonIgnore]
        public EnumComponentSchema componentSchema { get; private set; }
        
        /// <summary>
        /// 组件类型
        /// </summary>
        [NotNull]
        public EnumComponentType componentType { get; private set; }


        /// <summary>
        /// 本对象在某个模型元数据返回时中所需要的userType;
        /// 过滤的用户类型; 0--表示不进行任何过滤，因为不能在属性中定义 int? 类型;
        /// </summary>
        [JsonIgnore]
        public int userType { get;  set; }

        /// <summary>
        /// 本对象在某个模型元数据返回时中所需要的权限;
        /// </summary>
        [JsonIgnore]
        public string privilege { get; set; }
        /// <summary>
        /// 本对象在某个模型元数据返回时中所需要的权限;
        /// 需要任意一个权限时即显示此组件;
        /// 此为权限字符串;
        /// </summary>
        [JsonIgnore]
        public string[] anyPrivilege { get; set; }

        /// <summary>
        /// 本对象在某个模型元数据返回时中所需要的权限;
        /// 需要所有权限时即显示此组件;
        /// 此为权限字符串;
        /// </summary>
        [JsonIgnore]
        public string[] allPrivilege { get; set; }

        /// <summary>
        /// 组件对应的PropertyInfo 
        /// </summary>        
        [JsonIgnore]
        public PropertyInfo property { get; set; }

        ///// <summary>
        ///// 默认值,传送给前端;在创建新的待编辑对象时有用:
        ///// </summary>
        //public object defaultValue { get; set; }

        /// <summary>
        /// 是否支持排序;
        /// </summary>
        public bool sortable { get; set; }

        /// <summary>
        /// 是否是编辑列;编辑列时点击进行编辑而不是点击编辑按钮
        /// </summary>
        public bool isEditColumn { get; set; }

        /// <summary>
        /// 支持排序时此列所对应的属性,默认下为 null,此时将使用 propertyName 进行排序,
        /// 但因为列可能为另外一个属性的别名, 所以可能使用其他属性名称进行排序;
        /// </summary>
        public string sortableProperty { get; set; }

        /// <summary>
        /// 组件对应的显示数据的属性 的名称
        /// 默认为 property.Name，但如果指定 propertyPath, 则指定为 propertyPath, 例如  HardInfo.AppVersion;
        /// </summary>
        [NotNull]
        public string propertyName
        {
            get
            {
                if (!string.IsNullOrEmpty(propertyPath) && property == null) return null;
                if (property == null) return propertyPath;
                if (string.IsNullOrEmpty(propertyPath)) return property.Name;
                return property.Name + "." + propertyPath;
            }
        }

        /// <summary>
        /// 编辑时某些组件可能需要向服务器请求数据，此时可能需要其他属性的值一起作为参数来向服务器发送请求,
        /// 此属性用来表示相关的组件;无论是否可见,
        /// </summary>
        public string relatePropertys
        {
            get;
            set;
        }
        /// <summary>
        /// 编辑时某些组件可能需要向服务器请求数据，此时可能需要其他属性的值一起作为参数来向服务器发送请求,
        /// 此用来表示可见的组件的属性;
        /// </summary>
        public string relateConditionPropertys
        {
            get;
            set;
        }
        /// <summary>
        /// 组件对应的子属性的路径属性路径，例如 在 MachineOrBoardQueryResponse 中定义了, propertyPath=HardInfo.AppVersion 
        /// </summary>
        [JsonIgnore]
        public string propertyPath
        {
            get; set;
        }

        /// <summary>
        /// 组件的属性的 Json 字符串;
        /// </summary>
        public string componetPropertyJson { get; set; }
        
        /// <summary>
        /// 列表中的单元格点击传送的操作数据;
        /// </summary>
        public object listCellClickParameter { get; set; }

        /// <summary>
        /// 限制类型，当不为null时，此定义只对给定 limitType 产生 EntityTypeVueDefine 时才有效；
        /// 例如， MachineOrBoardQueryResponse 
        /// 对于 MachineOrBoardQueryParameter_Machine 和 MachineOrBoardQueryParameter_Machine
        /// 会产生不同的结果;
        /// </summary>
        [JsonIgnore]
        public Type limitRequestEntityType { get; set; }

        /// <summary>
        /// 是否允许编辑
        /// </summary>
        public bool allowEdit { get; set; }

        /// <summary>
        /// 允许编辑时候所需要的权限;
        /// </summary>
        [JsonIgnore]
        public string allowEditPrivilege { get; set; }

        /// <summary>
        /// 是否是固定列;用在 列表中;
        /// </summary>
        public bool isFixed { get; set; }
    }


    /// <summary>
    /// 根据实体类型自动构建的编辑和列举组件
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
    public class PropertyAutoEditAndListAttribute : AbstractPropertyComponentAttribute
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public PropertyAutoEditAndListAttribute(bool inline = false, int editspan = 0) : base(EnumComponentSchema.EditAndList, EnumComponentType.auto)
        {
            this.inline = inline;
            this.editspan = editspan;
        }
    }

    /// <summary>
    /// 根据实体类型自动构建的编辑组件
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
    public class PropertyAutoEditAttribute : AbstractPropertyComponentAttribute
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public PropertyAutoEditAttribute(bool inline = false, int editspan = 0) : base(EnumComponentSchema.Edit, EnumComponentType.auto)
        {
            this.inline = inline;
            this.editspan = editspan;
        }
    }

    /// <summary>
    /// 根据实体类型自动构建的过滤组件
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
    public class PropertyAutoFilterAttribute : AbstractPropertyComponentAttribute
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public PropertyAutoFilterAttribute() : base(EnumComponentSchema.Filter, EnumComponentType.auto)
        {
        }
    }
    /// <summary>
    /// 根据实体类型自动构建的列表组件
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
    public class PropertyAutoListAttribute : AbstractPropertyComponentAttribute
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public PropertyAutoListAttribute() : base(EnumComponentSchema.List, EnumComponentType.auto)
        {
        }
    }

    /// <summary>
    /// 根据实体类型自动构建的列表组件
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
    public class PropertyAutoExportAttribute : AbstractPropertyComponentAttribute
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public PropertyAutoExportAttribute() : base(EnumComponentSchema.Export, EnumComponentType.auto)
        {
        }
    }

    /// <summary>
    /// 根据实体类型自动构建的过滤、编辑和列表组件
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
    public class PropertyAutoAllAttribute : AbstractPropertyComponentAttribute
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public PropertyAutoAllAttribute(bool inline = false, int editspan = 0) : base(EnumComponentSchema.FilterAndEditAndList, EnumComponentType.auto)
        {
            this.inline = inline;
            this.editspan = editspan;
        }
    }
}
