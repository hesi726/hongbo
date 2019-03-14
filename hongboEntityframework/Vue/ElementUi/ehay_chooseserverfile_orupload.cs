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
    /// 选择服务器的文件或者从本地选择文件并上传到服务器;
    /// （但是文件将上传到服务器的临时目录,
    /// 所以我们需要指定对于临时目录下文件URL的处理方式;
    /// 因为属性只能使用固定字符串或者 type, 所以我们通过枚举来指定处理方法;
    /// </summary>
    public class ehay_chooseserverimage_orupload : AbstractPropertyComponentAttribute
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public ehay_chooseserverimage_orupload(EnumComponentSchema schema)
            :this(schema, null)
        {
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        public ehay_chooseserverimage_orupload(EnumComponentSchema schema, object howToGetServerFile) 
            :base(schema, EnumComponentType.ehay_file_chooseserverfile_orupload)
        {
            this.howToGetServerFile = howToGetServerFile;
            
        }

        /// <summary>
        /// 如何获取服务器的图像?
        /// 一般应该为枚举类型,
        /// 服务器根据此参数去获取查询数据;
        /// </summary>
        public object howToGetServerFile { get; set;  }
      

        /// <summary>
        /// 临时Url的处理方式;应该是一个枚举值;
        /// </summary>
        [JsonIgnore]
        public Object TempUrlHandleType { get; set; }
    }
}
