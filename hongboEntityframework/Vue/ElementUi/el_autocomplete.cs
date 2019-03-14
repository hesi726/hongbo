using hongbao.Vue.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace hongbao.Vue.ElementUi
{
    /// <summary>
    /// 自动完成的文本组件
    /// </summary>
    public class ELAutocomplete : AbstractFormElementAttribute
    {
        public ELAutocomplete(EnumComponentSchema schema) : base(schema, EnumComponentType.el_autocomplete)
        {

        }
        ///<summary>
        ///输入框占位文本
        /// </summary>
        [JsonProperty("placeholder")]
        public string placeholder { get; set; }
        ///<summary>
        ///禁用
        /// </summary>
        [JsonProperty("disabled")]
        public override bool disabled { get; set; }
        ///<summary>
        ///输入建议对象中用于显示的键名
        /// </summary>
        [JsonProperty("value-key")]
        public string valuekey { get; set; }
        ///<summary>
        ///必填值，输入绑定值
        /// </summary>
        [JsonProperty("value")]
        public string value { get; set; }
        ///<summary>
        ///获取输入建议的去抖延时
        /// </summary>
        [JsonProperty("debounce")]
        public int debounce { get; set; }
        ///<summary>
        ///菜单弹出位置
        /// </summary>
        [JsonProperty("placement")]
        public string placement { get; set; }
        ///<summary>
        ///返回输入建议的方法，仅当你的输入建议数据 resolve 时，通过调用 callback(data:[]) 来返回它
        /// </summary>
        [JsonProperty("fetch-suggestions")]
        public string fetchsuggestions { get; set; }
        ///<summary>
        ///Autocomplete 下拉列表的类名
        /// </summary>
        [JsonProperty("popper-class")]
        public string popperclass { get; set; }
        ///<summary>
        ///是否在输入框 focus 时显示建议列表
        /// </summary>
        [JsonProperty("trigger-on-focus")]
        public bool triggeronfocus { get; set; }
        ///<summary>
        ///原生属性
        /// </summary>
        [JsonProperty("name")]
        public string name { get; set; }
        ///<summary>
        ///在输入没有任何匹配建议的情况下，按下回车是否触发 select事件
        /// </summary>
        [JsonProperty("select-when-unmatched")]
        public bool selectwhenunmatched { get; set; }
        ///<summary>
        ///输入框关联的label文字
        /// </summary>
        [JsonProperty("label")]
        public string label { get; set; }
        ///<summary>
        ///输入框头部图标
        /// </summary>
        [JsonProperty("prefix-icon")]
        public string prefixicon { get; set; }
        ///<summary>
        ///输入框尾部图标
        /// </summary>
        [JsonProperty("suffix-icon")]
        public string suffixicon { get; set; }
        ///<summary>
        ///是否隐藏远程加载时的加载图标
        /// </summary>
        [JsonProperty("hide-loading")]
        public bool hideloading { get; set; }
        ///<summary>
        ///是否将下拉列表插入至 body 元素。在下拉列表的定位出现问题时，可将该属性设置为 false
        /// </summary>
        [JsonProperty("popper-append-to-body")]
        public bool popperappendtobody { get; set; }

    }
}
