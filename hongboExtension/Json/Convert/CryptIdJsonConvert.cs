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
    /// CryptIdAttribute标记的属性，使用 CryptIdConvert 将传入值进行转换;
    /// </summary>
    public class CryptIdJsonConvert : JsonConverter
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="allowNull"></param>
        /// <param name="cryptType"></param>
        public CryptIdJsonConvert(bool allowNull, Type cryptType)
        {
            this.allowNull = allowNull;
            this.cryptType = cryptType;
        }

        internal Type cryptType;
        private bool allowNull = false;

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
            var value = (string)reader.Value;
            return Decode(targetType, cryptType, value);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="targetType"></param>
        /// <param name="cryptType"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static object Decode(Type targetType, Type cryptType, string value)
        {
            if (value == null || value == "") return null;
            if (value.IndexOf(",") >= 0) return SecurityUtil.DecryptIdsInGuid(value, cryptType);
            var result = SecurityUtil.DecryptIdInGuid(value, cryptType);
            if (targetType == typeof(string)) return result.ToString();
            return result;
        }

        /// <summary>
        /// 从字符串转换会 int? 或者 int, 加密成id
        /// </summary>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value == null) { writer.WriteValue(value); return; }
            if (value.GetType() == typeof(string))
            {
                var values = SecurityUtil.CryptIdsInGuid(value as string, cryptType);
                writer.WriteValue(values);
                return;
            }
            string val = "";
            if (allowNull)
            {
                var id = (int?)(value);
                if (id.HasValue) val = SecurityUtil.CryptIdInGuid(id, cryptType);
                else
                {
                    writer.WriteValue((object)null);
                    return;
                }
            }
            else
            {
                var id = (int)(value);
                val = SecurityUtil.CryptIdInGuid(id, cryptType);
            }
            writer.WriteValue(val);
        }
    }
}
