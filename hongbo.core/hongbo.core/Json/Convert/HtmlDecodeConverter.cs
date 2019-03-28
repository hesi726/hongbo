using hongbao.WebExtension;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace hongbao.Json
{
    /// <summary>
    /// Html字符串进行解码的字符串
    /// </summary>
    public class HtmlDecodeConverter :  JsonConverter
    {
        /// <summary>
        /// 能否转换
        /// </summary>
        /// <param name="objectType"></param>
        /// <returns></returns>
        public override bool CanConvert(Type objectType)
        {
            if (objectType == typeof(string)) return true;
            return false;
        }

        /// <summary>
        /// 读取 Json , 转换为目的字符串;
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="objectType"></param>
        /// <param name="existingValue"></param>
        /// <param name="serializer"></param>
        /// <returns></returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            string content = (string) reader.Value;
            if (string.IsNullOrEmpty(content)) return null;
            else return HttpUtility.UrlDecode(content);
        }

        /// <summary>
        /// 写入 Json 
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="value"></param>
        /// <param name="serializer"></param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value == null) writer.WriteNull();
            var val = (string) value;
            writer.WriteValue(HttpUtility.UrlEncode(val));
        }
    }
}
