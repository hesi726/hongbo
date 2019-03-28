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
    /// ehay_bool_show 元素
    /// </summary>
    public class ehay_media_preview : AbstractPropertyComponentAttribute
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public ehay_media_preview(EnumComponentSchema schema) : base(schema, Enums.EnumComponentType.ehay_media_preview)
        {
            
        }

        ///// <summary>
        ///// 是否在单元格中嵌入素材，而不是显示显示素材Url
        ///// </summary>
        //public override bool inline { get; set; }
        
    }
}
