using hongbao.Vue.Attributes;
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
    /// ehay_chooselocalfile_upload 元素
    /// 选择客户端的本地文件并上传到服务器;（但是文件将上传到服务器的临时目录,
    /// 所以我们需要指定对于临时目录下文件URL的处理方式;
    /// 因为属性只能使用固定字符串或者 type, 所以我们通过枚举来指定处理方法;
    /// </summary>
    public class ehay_chooselocalfile_upload : AbstractPropertyComponentAttribute
    {

        /// <summary>
        /// 构造函数
        /// </summary>
        public ehay_chooselocalfile_upload(EnumComponentSchema schema)
              : this(schema, null)
        {
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        public ehay_chooselocalfile_upload(EnumComponentSchema schema, object tempUrlHandleType) 
              :base(schema, EnumComponentType.ehay_file_chooselocal_upload)
        {
            this.TempUrlHandleType = tempUrlHandleType;
            this.listType = "text";
        }

        /// <summary>
        /// 临时Url的处理方式;应该是一个枚举值;
        /// </summary>
        [JsonIgnore]
        public Object TempUrlHandleType { get; set; }

        /// <summary>
        /// 可选的文件类型
        /// </summary>
        public string accept { get; set; }

        /// <summary>
        /// 保留上传时候的文件名称,有时候会用到这个文件名称进行一些判断;
        /// </summary>
        public bool reserseFilename { get; set; }

        /// <summary>
        /// text/picture/picture-card
        /// </summary>
        public string listType { get; set; }

        /// <summary>
        /// 枚举的值类型;
        /// </summary>
        public EnumValueTypeForChoolseLocalFile valueMode { get; set; }

    }

    /// <summary>
    /// 选择文件后的值类型;
    /// </summary>
    public enum EnumValueTypeForChoolseLocalFile
    {
        /// <summary>
        /// 为 上传控制器的 Upload 接口返回的原始形式,
        /// </summary>
        UploadFileResult = 0,
        /// <summary>
        /// 上传上来临时的url拼接成的字符串
        /// </summary>
        @string = 1,

        /// <summary>
        /// 上传上来临时的url 数组;
        /// </summary>
        stringArray = 2,


    }
}
