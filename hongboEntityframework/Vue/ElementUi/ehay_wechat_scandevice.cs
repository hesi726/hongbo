using hongbao.Vue.Attributes;
using hongbao.Vue.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.Vue.ElementUi
{
    /// <summary>
    /// 通过微信扫描设备二维码获取设备名称;
    /// 通过微信选择并上传素材微信的服务器,返回微信的服务器Id;
    /// 可以选择多张图片,但只有一个按钮;
    /// </summary>
    public class ehay_wechat_scandevicename : AbstractPropertyComponentAttribute
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public ehay_wechat_scandevicename(EnumComponentSchema schema) : base(schema, Enums.EnumComponentType.ehay_wechat_scandevicename)
        {
            
        }
        
    }
}
