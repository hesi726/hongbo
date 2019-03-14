using hongbao.EntityExtension;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.Vue.ElementUi
{
    /// <summary>
    /// 根据实体类型上的标注所抽离出来的实体的对应Vue组件定义;
    /// </summary>
    public class ELTableAttribute : Attribute
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public ELTableAttribute()
        {
            this.ColumnList = new List<ELTableColumnAttribute>();
            this.EditableColumnList = new List<ELTableColumnAttribute>();
            this.FilterableColumnList = new List<ELTableColumnAttribute>();

            this.AllowPage = true;
        }

        /// <summary>
        /// 允许分页查询数据，默认为 true;
        /// </summary>
        public bool AllowPage { get; set; }

        /// <summary>
        /// 允许编辑现有实体，强行指定不允许编辑
        /// </summary>
        public bool AllowEdit { get; set; }

        /// <summary>
        /// 允许创建新的实体
        /// </summary>
        public bool AllowCreate { get; set; }

        /// <summary>
        /// 创建新实体时的客户端事件;
        /// </summary>
        public string CreateClick { get; set;  }


        /// <summary>
        /// 编辑新实体时所需要的权限(含编辑删除);
        /// </summary>
        [JsonIgnore]
        public string EditPriv { get; set; }

        /// <summary>
        /// 可编辑的列列表
        /// </summary>
        [NotNull]
        public List<ELTableColumnAttribute> EditableColumnList { get; set; }

        /// <summary>
        /// 编辑时的 Label的宽度,不指定时默认为 100px;
        /// </summary>
        public int EditFormLabelWidth { get; set; }


        /// <summary>
        /// 创建新实体时所需要的权限(含新建);
        /// </summary>
        [JsonIgnore]
        public string CreatePriv { get; set; }       

        /// <summary>
        /// 将在表格中显示的列列表;
        /// </summary>
        [NotNull]
        public List<ELTableColumnAttribute> ColumnList { get; set; }


        /// <summary>
        /// 可过滤的列列表
        /// </summary>
        [NotNull]
        public List<ELTableColumnAttribute> FilterableColumnList { get; set; }

        /// <summary>
        /// 父实体属性;
        /// 逗号间隔,定义为 属性名称，父实体中的属性名称；
        /// 例如， 联系人中父Id字段为 ClientId,
        /// 客户的Id字段为 Id,
        /// 则 ParentId 为 ClientId,Id
        /// </summary>
        public string ParentId { get; set; }

        /// <summary>
        /// 当属性变化时触发服务器的事件，由服务器的事件来变化数据对客户端数据进行变更？
        /// 总是触发服务器端的 EntityController 的 TriggerEntity 事件;
        /// </summary>
        public string TriggerProperty { get; set;  }       
    }

    ///// <summary>
    ///// 父属性Id以及父实体字段的对应：
    ///// 例如 客户联系人 和 客户， 
    ///// 
    ///// </summary>
    //public class TriggerProperty
    //{
    //    /// <summary>
    //    /// 本实体中定义的父Id字段的名称;
    //    /// </summary>
    //    public string PropertyName { get; set; }
    //}
}
