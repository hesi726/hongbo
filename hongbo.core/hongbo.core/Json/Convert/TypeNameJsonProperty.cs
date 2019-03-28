using hongbao.Json.ValueProvider;
using hongbao.SecurityExtension;
using Newtonsoft.Json;
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
    /// 给所有的输出产生 TypeName 属性, 用于表示其原始类型;
    /// </summary>
    public class TypeNameJsonProperty : JsonProperty
    {
        /// <summary>
        /// 静态变量
        /// </summary>
        ///private  static PropertyInfo TypeNameProp = typeof(TypeNameJsonProperty).GetProperty("TypeName");
        /// <summary>
        /// 不要删除，上面这行用到这个代码;
        /// </summary>
        ///public string TypeName { get; }

        /// <summary>
        /// 给所有的输出产生 TypeName 属性;
        /// </summary>
        /// <param name="typename"></param>
        public TypeNameJsonProperty(string typename)
        {
            this.PropertyName = "TypeName"; // property.Name;
            this.ValueProvider = new FixedValueProvider(typename, null); //   new ReflectionValueProvider(TypeNameProp); 
            this.Converter = new TypeNameJsonConverter(typename);  //必须提供;
            this.Writable = false;
            this.Readable = true;
            this.PropertyType = typeof(string); // TypeNameProp.PropertyType;
            
            this.ShouldSerialize = new Predicate<object>((xx) => true);
            this.GetIsSpecified = null; // new Predicate<object>((xx) => true);
            this.SetIsSpecified = null; // new Predicate<object, object>((xx, yy) => true);
        }
    }


    /// <summary>
    ///  给所有的输出产生 TypeName 属性, 用于表示其原始类型;
    /// </summary>
    public class TypeNameJsonConverter : JsonConverter
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="typename"></param>
        public TypeNameJsonConverter(string typename)
        {
            this.typename = typename;
        }

        internal string typename;

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
            throw new Exception("不支持 ReadJson 方法"); /*
            var value = (string)reader.Value;
            return Decode(targetType, cryptType, value); */
        }
        /// <summary>
        /// 从字符串转换会 int? 或者 int, 加密成id
        /// </summary>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteValue(typename);
        }
    }
}
