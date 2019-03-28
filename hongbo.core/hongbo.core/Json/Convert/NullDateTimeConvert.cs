using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace hongbao.Json
{
    /// <summary>
    /// 允许为null的日期转换;即 空字符串 将认为是 null;
    /// </summary>
    public class NullDateConvert : JsonConverter
    {
        /// <summary>
        /// 
        /// </summary>
        protected string format = "yyyy-MM-dd";
        /// <summary>
        /// 
        /// </summary>
        public NullDateConvert()
        {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="format"></param>
        protected NullDateConvert(string format)
        {
            this.format = format;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="objectType"></param>
        /// <returns></returns>
        public override bool CanConvert(Type objectType)
        {
            if (objectType == typeof (DateTime?))
                return true;
            return false;
        }

        /// <summary>
        /// 读取对象;
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="objectType"></param>
        /// <param name="existingValue"></param>
        /// <param name="serializer"></param>
        /// <returns></returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue,
            JsonSerializer serializer)
        {
            object obj = reader.Value;
            var objType = reader.ValueType;
            if (obj == null) return null;
            else if (objType == typeof(DateTime)) return (DateTime)obj;
            if (string.IsNullOrEmpty((string)obj))
                return null;
            return DateTime.Parse((string)obj);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="value"></param>
        /// <param name="serializer"></param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value == null) writer.WriteNull();
            var val = (DateTime?) value;
            if (!val.HasValue) writer.WriteNull();
            else writer.WriteValue(val.Value.ToString(format));
        }
    }
    /// <summary>
    /// 
    /// </summary>
    public class NullDatetimeConvert : NullDateConvert
    {/// <summary>
    /// 
    /// </summary>
        public NullDatetimeConvert() :  base("yyyy-MM-dd HH:mm:ss")
        {
            
        }
    }
}
