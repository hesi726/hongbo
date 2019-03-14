using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hongbao.EntityExtension;
using hongbao.Vue.Attributes;
using hongbao.Vue.Enums;

namespace hongbao.Vue.ElementUi
{

    /// <summary>
    /// 实体类型获取有关 Vue组件定义
    /// </summary>
    public class EntityTypeVueDefine
    {
        /// <summary>
        /// 默认的
        /// </summary>
        public static string FilterPrefix = ""; // "filter_";

        /// <summary>
        /// 构造函数
        /// </summary>
        public EntityTypeVueDefine()
        {
            this.filterPrefix = EntityTypeVueDefine.FilterPrefix;
            this.FilterableComponentAttributeList = new List<AbstractPropertyComponentAttribute>();
            this.EditableComponentAttributeList = new List<AbstractPropertyComponentAttribute>();
            this.ColumnableComponentAttributeList = new List<AbstractPropertyComponentAttribute>();
            this.OperateDefines = new List<AbstractEntitysOperateDefineAttribute>();
        }

        /// <summary>
        /// 实体类型名称
        /// </summary>
        public string EntityTypeName { get; set; }
        /// <summary>
        /// 是否允许编辑
        /// </summary>
        public bool AllowEdit { get; set; }
        /// <summary>
        /// 是否允许新建;
        /// </summary>
        public bool AllowCreate { get; set; }
        /// <summary>
        /// 允许删除;无用,只为保持页面兼容性;
        /// </summary>
        public bool AllowDelete { get; set; }

        /// <summary>
        /// 是否支持导出
        /// </summary>
        public bool AllowExport { get; set; }

        /// <summary>
        /// 是否允许分页;
        /// </summary>
        public bool AllowPaging { get; set; }

        /// <summary>
        /// 过滤参数的前缀,主要是避免过滤参数无法直接绑定的问题，
        /// 例如，对于 CreateDateTime 字段，过滤参数将上传2个，分别是 BeginDate 和 EndDate, 
        /// 这2个参数肯定无法绑定到 CreateDateTime 中，所以增加此过滤前缀,这样客户端的传入参数名称为 filter_CreateDateTime
        /// 就不会有自动绑定到 CreateDateTime 字段中而导致绑定出错;
        /// </summary>
        public string filterPrefix { get; set; }

        /// <summary>
        /// 默认的 editspan 的大小;
        /// 如果某1列内联显示时，默认下其占据的 el-col 中的 span;
        /// 此数据可能被组件的 editspan 所覆盖;
        /// </summary>
        public int defaultEditspan { get; set; }
        /// <summary>
        /// 默认是否使用树型列表
        /// </summary>
        public bool supportTreelist { get; set; }

        /// <summary>
        /// 默认下是否使用树型列表显示数据，总是 false; 客户端有用;
        /// </summary>
        public bool useTreeList { get; set; }

        /// <summary>
        /// 如果不为null,则表示支持树型列表显示，并且上级字段为 upperId 字段;
        /// </summary>
        public string upperIdField { get; set; }

        /// <summary>
        /// 可过滤的列定义
        /// </summary>
        [NotNull]
        public List<AbstractPropertyComponentAttribute> FilterableComponentAttributeList { get; set; }

        /// <summary>
        /// 可编辑的列定义
        /// </summary>

        [NotNull]
        public List<AbstractPropertyComponentAttribute> EditableComponentAttributeList { get; set; }

        /// <summary>
        /// 可显示在表格中的列定义
        /// </summary>

        [NotNull]
        public List<AbstractPropertyComponentAttribute> ColumnableComponentAttributeList { get; set; }

        /// <summary>
        /// 可导出到 Excel 表格中的列定义
        /// </summary>
        public List<AbstractPropertyComponentAttribute> ExportComponentAttributeList { get; set; }

        /// <summary>
        /// 在列表中选择实体后(可以选择多个实体)上进行的操作定义;
        /// </summary>
        [NotNull]
        public List<AbstractEntitysOperateDefineAttribute>  OperateDefines { get; set; }

        /// <summary>
        /// 给定类型存在空的构造函数时,使用该构造函数创建一个新的实例并返回给客户端;
        /// </summary>
        public string NewEditObjectJson { get; set; }
    }

}
