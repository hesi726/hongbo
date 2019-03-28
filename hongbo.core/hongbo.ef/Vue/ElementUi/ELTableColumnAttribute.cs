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
    /// 映射到 el-table-column 行为 
    /// </summary>
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    public class ELTableColumnAttribute : Attribute
    {
        /// <summary>
        /// Name 字段 Serial 默认为 1000；        
        /// CreateDateTime 默认 Serial 为 Int32.MaxValue
        /// </summary>
        /// <param name="columnProp"></param>
        public ELTableColumnAttribute(EnumELTableColumnProp columnProp = EnumELTableColumnProp.All)
        {
            this.ColumnProp = columnProp;
            this.Serial = 1000; 
        }

        /// <summary>
        /// 列排序,默认为 1000， 必须大于 1000 排在后面;
        /// </summary>
        [JsonIgnore]
        public int Serial { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonIgnore]
        public override object TypeId { get { return base.TypeId; } }

        /// <summary>
        /// 本字段的使用方式（显示在列表、编辑 或者 列表编辑都显示)
        /// </summary>
        EnumELTableColumnProp ColumnProp
        {
            get; set;
        }

        /// <summary>
        /// 列名称;
        /// </summary>
        public string Label
        {
            get; set; 
        }

        /// <summary>
        /// 详细说明
        /// </summary>
        public string DetailDesc { get; set;  }

        /// <summary>
        /// 列需要绑定的字段,对应到表格的 prop;
        /// </summary>
        [NotNull]
        public string Prop
        {
            get; set; 
        }

        /// <summary>
        /// 列宽;字符串,例如 180，注意，不包含 px;
        /// </summary>
        public int Width
        {
            get; set; 
        }

        /// <summary>
        /// 允许编辑,默认为 false;
        /// 注意，允许编辑表示 此属性将出现在 编辑的 Form 表单中，
        /// </summary>
        public bool AllowEdit
        {
            get; set;
        }

        /// <summary>
        /// 编辑时所需要的权限
        /// </summary>
        [JsonIgnore]
        public string EditPrivilege
        {
            get; set;
        }

        /// <summary>
        /// 允许过滤,默认为 false;
        /// </summary>
        public bool AllowFilter
        {
            get; set;
        }

        /// <summary>
        /// 禁止输入，例如 安装时禁止直接输入设备号，而只允许使用扫码来获取设备号，
        /// 但是有权限的人员又可以直接输入设备号
        /// 默认下为 false , 表示不需要禁止;
        /// </summary>
        public bool DisableInput
        {
            get; set;
        }
        
        /// <summary>
        /// 禁止输入的权限，控制 DisableInpu 字段；
        /// </summary>
        public string DisableInputPrivilege
        {
            get; set;
        }

        /// <summary>
        /// 列类型;
        /// </summary>
        public ELTableColumnType ColumnType { get; set; }

        /// <summary>
        /// 默认值,
        /// </summary>
        public object DefaultValue { get; set;  }

        /// <summary>
        /// 默认值模板;
        /// </summary>
        public string DefaultFormat { get; set;  }

        /// <summary>
        /// 按钮的点击事件
        /// </summary>
        public string Click { get; set; }

		/// <summary>
        /// 文件上传时的文件类型
        /// </summary>
		public string AcceptFileType { get; set; }

        /// <summary>
        /// 枚举的枚举类型,当 ColumnType == ELTableColumnType.Enum 或者 ColumnType==ELTableColumnType.EnumSingleSelect 时有用;
        /// 根据此值设置 EnumTypeString 字段的值;
        /// </summary>
        [JsonIgnore]
		public Type EnumType { get; set; }

        /// <summary>
        /// 枚举的枚举类型字符串, ColumnType == ELTableColumnType.Enum 或者 ColumnType==ELTableColumnType.EnumSingleSelect
        ///  客户端根据 枚举类型名称 查找 EhayModels.allEnums 产生枚举的下拉选择控件;
        /// </summary>
        public string EnumTypeString 
		{ 
			get
			{
				if (this.EnumType==null) return null;
				return this.EnumType.Name;
			}
		}

        /// <summary>
        /// 允许在列表中显示此列;
        /// </summary>
        /// <returns></returns>
        public bool IsAllowList()
        {
            return this.ColumnProp == EnumELTableColumnProp.All || this.ColumnProp == EnumELTableColumnProp.List;
        }

        /// <summary>
        /// 根据传入进来的权限，是否允许用户编辑本列
        /// </summary>
        /// <param name="userFullPrivilege">传入进来的权限</param>
        public bool IsDisableInput(string userFullPrivilege)
        {
            if (string.IsNullOrEmpty(this.DisableInputPrivilege)) return false;
            if (string.IsNullOrEmpty(userFullPrivilege)) return true;
            userFullPrivilege = "," + userFullPrivilege + ",";
            if (userFullPrivilege.IndexOf(",admin,") >= 0) return false;
            if (DisableInputPrivilege.Split(new char[] { ',' }).Any((priv) =>
                    userFullPrivilege.IndexOf("," + priv + ",") >= 0))
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// 根据传入进来的权限，是否允许用户编辑本列
        /// </summary>
        /// <param name="userFullPrivilege">传入进来的权限</param>
        public bool IsAllowEdit(string userFullPrivilege)
        {
            if (this.ColumnProp == EnumELTableColumnProp.List) return false;
            if (this.AllowEdit) return true;

            if (string.IsNullOrEmpty(userFullPrivilege)) return false;
            userFullPrivilege = "," + userFullPrivilege + ",";
            if (!string.IsNullOrEmpty(EditPrivilege))
            {
                if (EditPrivilege.Split(new char[] { ',' }).Any((priv) =>
                    userFullPrivilege.IndexOf("," + priv + ",") >= 0))
                {
                    return true;
                }
                return true;
            }
            return false;
        }

        /// <summary>
        /// 允许过滤本列
        /// </summary>
        /// <returns></returns>
        public bool IsAllowFilter()
        {
            return this.AllowFilter;
        }
    }

    /// <summary>
    /// 列编辑属性
    /// </summary>
    public enum EnumELTableColumnProp
    {
        /// <summary>
        /// 全部
        /// </summary>
        All = 0,

        /// <summary>
        /// 列表时使用此属性
        /// </summary>
        List = 1,

        /// <summary>
        /// 编辑时使用此属性
        /// </summary>
        Edit = 2
    }
}
