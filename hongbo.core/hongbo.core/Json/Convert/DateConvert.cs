using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace hongbao.Json
{
    /// <summary>
    /// 日期转换成 yyyy-MM-dd的Json转换类：
    /// 默认使用日期格式，在构造函数中指定 yyyy-MM-dd可以使用
    /// </summary>
    public class DateConvert : JsonConverter
    {
        /// <summary>
        /// 
        /// </summary>
        protected string format = "yyyy-MM-dd";
        /// <summary>
        /// 
        /// </summary>
        public DateConvert()
        {
        }
        /// <summary>
        /// 
        /// </summary>
        protected DateConvert(string format)
        {
            this.format = format;
        }
        /// <summary>
        /// 
        /// </summary>
        public override bool CanConvert(Type objectType)
        {
            if (objectType == typeof(DateTime))
                return true;
            return false; 
        }

        /// <summary>
        /// 
        /// </summary>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            return DateTime.Parse((string) reader.Value);
        }

        /// <summary>
        /// 
        /// </summary>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteValue(((DateTime) value).ToString(format));
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public class DateTimeConvert : DateConvert
    {
        /// <summary>
        /// 
        /// </summary>
        public DateTimeConvert() : base("yyyy-MM-dd HH:mm:ss")
        {

        }
    }
}
