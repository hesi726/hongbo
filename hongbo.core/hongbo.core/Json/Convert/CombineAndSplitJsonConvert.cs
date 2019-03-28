using hongbao.CollectionExtension;
using hongbao.Json.ContactResolve;
using hongbao.SecurityExtension;
using hongbao.SystemExtension;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.Json
{
    /// <summary>
    ///拆分和合并,将值根据逗号拆分成字符串数组(输出Json时)或者将数组合并成字符串(解析)
    /// </summary>
    internal class CombineAndSplitJsonConvert : JsonConverter
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="serializingObject"></param>
        public CombineAndSplitJsonConvert(ISerializingObject serializingObject)
        {
            this.serializingObject = serializingObject;
        }

        private ISerializingObject serializingObject;

        /// <summary>
        /// 能否转换
        /// </summary>
        /// <param name="objectType">对象的类型;</param>
        public override bool CanConvert(Type objectType)
        {
            return true;
        }

        /// <summary>
        /// 从字符串转换会 int? 或者 int, 解密成id
        /// 或者如果字符串包含有 逗号，则拆分逗号解密再拼接成字符串传输;
        /// </summary>
        public override object ReadJson(JsonReader reader, Type targetType, object existingValue, JsonSerializer serializer)
        {            
            var value = reader.Value; //此处无法读取到数据,总是读取到 null;
            if (value == null) return null;
            JValue val = value as JValue;
            if ( val.Type == JTokenType.Array )
            {
                return (val.Value as JArray).Select(b => b.ToString()).Join(","); //拼接成字符串;
            }
            return val.Value.ToString();
        }

        /// <summary>
        /// 从字符串转换会 int? 或者 int, 加密成id
        /// </summary>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value == null) writer.WriteValue(new string[] { });
            else
            {
                var vals = value.ToString();
                if (vals == "") writer.WriteValue(new string[] { });
                else writer.WriteValue(vals.Trim(new char[] { ',' }).Split(new char[] { ',' }));
            }
        }
    }
}
