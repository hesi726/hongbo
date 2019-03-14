using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.Vue.Enums
{
    /// <summary>
    /// ElementUi 的组件枚举;
    /// </summary>
    public enum EnumComponentType
    {
        /// <summary>
        /// 自动，根据字段名称和字段类型(暂时支持 DateTime、bool、string、Date、自动产生;
        /// </summary>
        auto ,
        /// <summary>
        /// boolean 类型的 checkbox
        /// </summary>
        ehay_boolean_checkboxgroup ,
        /// <summary>
        /// 互斥的 boolean 类型的 checkbox
        /// </summary>
        ehay_boolean_conflict_checkboxgroup,
        /// <summary>
        /// boolean 类型的 radiogroup
        /// </summary>
        ehay_boolean_radiogroup,
        /// <summary>
        /// bool 类型的显示
        /// </summary>
        ehay_boolean_show,

        /// <summary>
        /// 层叠选择,
        /// </summary>
        ehay_cascade_select,
        /// <summary>
        /// 子实体的管理(例如，客户联系人)
        /// </summary>
        ehay_childentity_admin,
        /// <summary>
        /// 城市和地区选择
        /// </summary>
        ehay_cityanddistrict,
        /// <summary>
        /// 行业多选
        /// </summary>
        ehay_companytypeMultiSelect,
        /// <summary>
        /// 日期范围选择
        /// </summary>
        ehay_daterange_picker,
        ///// <summary>
        ///// 开始日期和结束日期
        ///// </summary>
        //ehay_date_begin_end,
        /// <summary>
        /// 开始时间和结束时间
        /// </summary>
        ehay_datetime_begin_end,
        /// <summary>
        /// 使用模态窗口显示其他组件,
        /// </summary>
        ehay_dialog_forcomponent,
        /// <summary>
        /// 实体Checkbox多选
        /// </summary>
        ehay_entity_checkboxGroup,
        /// <summary>
        /// 可折叠的实体Checkbox多选（
        /// </summary>
        ehay_entity_checkboxGroup_collapse,
        /// <summary>
        /// 实体解码(将Id解码成字符串)
        /// </summary>
        ehay_entity_decode,
        /// <summary>
        /// 实体单选
        /// </summary>
        ehay_entity_singleselect,
        /// <summary>
        /// 枚举类型的 checkbox group
        /// </summary>
        ehay_enum_checkboxGroup,
        /// <summary>
        /// 互斥的 枚举 类型的 checkbox group
        /// </summary>
        ehay_enum_conflictCheckboxGroup,
        /// <summary>
        /// 枚举类型的 radiogroup
        /// </summary>
        ehay_enum_radiogroup,
        /// <summary>
        /// 枚举类型的 显示
        /// </summary>
        ehay_enum_show,
        /// <summary>
        /// 选择本地文件并上传
        /// </summary>

        ehay_file_chooselocal_upload,
        /// <summary>
        /// 选择服务器文件或者上传新的文件
        /// </summary>
        ehay_file_chooseserverfile_orupload,
        /// <summary>
        /// 素材预览
        /// </summary>
        ehay_media_preview,
        /// <summary>
        /// 权限显示（包含有权限设置)
        /// </summary>
        ehay_privilege_show,
        /// <summary>
        /// 二维码显示
        /// </summary>
        ehay_qrcode_show,

        /// <summary>
        /// span元素
        /// </summary>
        ehay_span,
        /// <summary>
        /// 文本-货币展示
        /// </summary>
        ehay_text_money_show,
        /// <summary>
        /// 文本-缩短文本显示
        /// </summary>
        ehay_text_short,
        /// <summary>
        /// 文本-缩短的地址显示
        /// </summary>
        ehay_text_shortaddress,
        /// <summary>
        /// 文本-URL,在新窗口中打开链接;
        /// </summary>
        ehay_text_url,
        /// <summary>
        /// 日期选择
        /// </summary>
        el_date_picker,
        /// <summary>
        /// TextBox 组件
        /// </summary>
        el_input,
        /// <summary>
        /// 自动完成的组件
        /// </summary>
        el_autocomplete,
        /// <summary>
        /// el_button组件
        /// </summary>
        el_button,
        /// <summary>
        /// 单独的 checkbox
        /// </summary>
        el_checkbox,
        /// <summary>
        /// el_radio_group组件
        /// </summary>
        el_radio_group,
        /// <summary>
        /// el_checkbox_group组件
        /// </summary>
        el_checkbox_group,
        ehay_wechat_selectimage,
        /// <summary>
        /// 
        /// </summary>
        ehay_wechat_selectimagebytype,
        /// <summary>
        /// 通过微信扫描设备二维码获取设备名称;
        /// </summary>
        ehay_wechat_scandevicename,
    }
}
