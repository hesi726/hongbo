using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.Vue.ElementUi
{
    /// <summary>
    /// 列类型
    /// </summary>
    public enum ELTableColumnType
    {
        /// <summary>
        /// 文本编辑
        /// </summary>
        Text = 0, 
        /// <summary>
        /// CheckBox
        /// </summary>
        CheckBox = 1,
        /// <summary>
        /// 日期时间
        /// </summary>
        Datetime = 2,
        /// <summary>
        /// 日期
        /// </summary>
        Date = 3,
        /// <summary>
        /// 时间
        /// </summary>
        Time = 4,
        /// <summary>
        /// 枚举,不用;
        /// </summary>
        Enum = 5,
        /// <summary>
        /// 备注
        /// </summary>
        Remark = 6,
        /// <summary>
        /// 口令
        /// </summary>
        Password = 7,
        /// <summary>
        /// 权限编辑列;
        /// </summary>
        PrivilegeEdit = 8,
        /// <summary>
        /// 公司行业类型
        /// </summary>
        CompanyType = 9,
        /// <summary>
        /// APK文件上传组件;
        /// </summary>
        FileUpload = 10,
        /// <summary>
        /// 钱
        /// </summary>
        Money = 11,
        /// <summary>
        /// 打开对话窗口
        /// </summary>
        Button = 12,
        /// <summary>
        /// 枚举类型的下拉选择
        /// </summary>
        EnumSingleSelect = 13,		
        /// <summary>
        /// Label，显示文本
        /// </summary>
        Span = 14,
        /// <summary>
        /// 微信选择图片
        /// </summary>
        WechatSelectImage = 15,
        /// <summary>
        /// 水机运维后续操作
        /// </summary>
        NextDeviceOperate = 16,
        /// <summary>
        /// 微信扫码获取设备号的选项
        /// </summary>
        WechatScanDeviceName = 17,
        /// <summary>
        /// 城市和地区选择
        /// </summary>
        CityAndDistrictSelect = 18,
        /// <summary>
        /// 登录账号所归属角色选择
        /// </summary>
        RoleSelect = 19,
        /// <summary>
        /// 微信选择图片然后按照类型分类
        /// </summary>
        WechatSelectImageByType = 20,
        /// <summary>
        /// 输入数字
        /// </summary>
        Number = 21,

        /// <summary>
        /// 二维码组件
        /// </summary>
        Srcode = 10001,

        /// <summary>
        /// 此列不显示在列表或者编辑中，而只在服务器端进行过滤的设置或者接收传入的值;
        /// 客户端也可以接收此值;
        /// </summary>
        None = 10000,
    }
}
