using hongbao.Vue.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.Vue.ElementUi
{
    /// <summary>
    /// element-ui的标注
    /// </summary>
    public class el_inputAttribute : AbstractFormElementAttribute
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="schema"></param>
        public el_inputAttribute(EnumComponentSchema schema) 
            : base(schema, EnumComponentType.el_input)
        {
            this.type = "text";
            this.clearable = false;
            this.disabled = false;
            this.rows = 2;
            this.autosize = false;            
        }

        ///<summary>
        ///类型, password, textarea, text 默认为 text
        /// </summary>
        [JsonProperty("type")]
        public string type { get; set; }
        ///<summary>
        ///绑定值
        /// </summary>
        [JsonProperty("value")]
        public string value { get; set; }

        ///<summary>
        ///原生属性，最大输入长度
        /// </summary>
        [JsonProperty("maxlength")]
        public int? maxlength { get; set; }
        ///<summary>
        ///原生属性，最小输入长度
        /// </summary>
        [JsonProperty("minlength")]
        public int? minlength { get; set; }
        ///<summary>
        ///输入框占位文本
        /// </summary>
        [JsonProperty("placeholder")]
        public string placeholder { get; set; }
        ///<summary>
        ///是否可清空
        /// </summary>
        [JsonProperty("clearable")]
        public bool clearable { get; set; }
       
        ///<summary>
        ///输入框尺寸，只在 type!="textarea"时有效
        /// </summary>
        [JsonProperty("size")]
        public override EnumSize? size { get; set; }
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

        /// <summary>
        /// 输入框头部文本
        /// 产生形如 <templage slot="prepand">http://</templage> 的标记文本;
        /// </summary>
        public string prepend { get; set; }
        /// <summary>
        /// 输入框尾部文本
        /// </summary>
        public string append { get; set; }
        ///<summary>
        ///输入框行数，只对 type="textarea"有效
        /// </summary>
        [JsonProperty("rows")]
        public int rows { get; set; }
        ///<summary>
        ///自适应内容高度，只对 type="textarea" 有效，可传入对象，如，{ minRows: 2, maxRows: 6 }
        ///bool 或者对象 { minRows: 2, maxRows: 6 }
        /// </summary>
        [JsonProperty("autosize")]
        public object autosize { get; set; }
        ///<summary>
        ///原生属性，自动补全
        /// </summary>
        [JsonProperty("autocomplete")]
        public string autocomplete { get; set; }
        ///<summary>
        ///原生属性
        /// </summary>
        [JsonProperty("name")]
        public string name { get; set; }
        ///<summary>
        ///原生属性，是否只读
        /// </summary>
        [JsonProperty("readonly")]
        public bool @readonly { get; set; }
        ///<summary>
        ///原生属性，设置最大值
        /// </summary>
        [JsonProperty("max")]
        public int max { get; set; }
        ///<summary>
        ///原生属性，设置最小值
        /// </summary>
        [JsonProperty("min")]
        public int min { get; set; }
        ///<summary>
        ///原生属性，设置输入字段的合法数字间隔
        /// </summary>
        [JsonProperty("step")]
        public int step { get; set; }
        ///<summary>
        ///控制是否能被用户缩放
        /// </summary>
        [JsonProperty("resize")]
        public string resize { get; set; }
        ///<summary>
        ///原生属性，自动获取焦点
        /// </summary>
        [JsonProperty("autofocus")]
        public bool autofocus { get; set; }
        ///<summary>
        ///原生属性
        /// </summary>
        [JsonProperty("form")]
        public string form { get; set; }
        ///<summary>
        ///输入框的tabindex
        /// </summary>
        [JsonProperty("tabindex")]
        public string tabindex { get; set; }
    }


}
