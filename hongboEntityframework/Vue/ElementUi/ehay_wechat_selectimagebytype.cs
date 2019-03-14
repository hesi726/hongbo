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
    /// ehay_media_preview 元素
    /// 通过微信选择并上传素材微信的服务器,返回微信的服务器Id;
    /// 可以选择多张图片,有多个按钮;
    /// </summary>
    public class ehay_wechat_selectimagebytype : AbstractPropertyComponentAttribute
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public ehay_wechat_selectimagebytype(EnumComponentSchema schema) : base(schema, Enums.EnumComponentType.ehay_wechat_selectimagebytype)
        {
            
        }

        /// <summary>
        /// 分类的按钮文本,使用逗号间隔;
        /// </summary>
        public override string label { get; set; }

    }
}
