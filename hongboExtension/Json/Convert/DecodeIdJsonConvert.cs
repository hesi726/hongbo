using hongbao.CollectionExtension;
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
    ///// <summary>
    ///// Id解码标注，带有此标注的 属性 
    ///// 将在使用 IgnoreTypeScriptResolver 进行 Json 序列/反序列时，将 Id 解码成响应的字符串;一般为Id数组解码;
    ///// 使用  DecodeIdConvert 将传入值进行转换;
    ///// 但是稀奇的是 Newtonsoft 不支持此种转换：
    ///// </summary>
    //public class DecodeIdJsonConvert : JsonConverter
    //{
    //    /// <summary>
    //    /// 构造函数
    //    /// </summary>
    //    /// <param name="allowNull"></param>
    //    /// <param name="cryptType"></param>
    //    /// <param name="objMap"></param>
    //    public DecodeIdJsonConvert(bool allowNull, Type cryptType, Dictionary<int, string> objMap)
    //    {
    //        this.allowNull = allowNull;
    //        this.cryptType = cryptType;
    //        this.objMap = objMap ?? new Dictionary<int, string>();
    //    }

    //    Dictionary<int, string> objMap = null;
    //    internal Type cryptType;
    //    private bool allowNull = false;

    //    /// <summary>
    //    /// 能否转换
    //    /// </summary>
    //    /// <param name="objectType">对象的类型;</param>
    //    public override bool CanConvert(Type objectType)
    //    {
    //        return true;
    //    }

    //    /// <summary>
    //    /// 从 Json字符串转换回来,调用父类的方法即可;
    //    /// </summary>
    //    public override object ReadJson(JsonReader reader, Type targetType, object existingValue, JsonSerializer serializer)
    //    {
    //        var value = (string)reader.Value;
    //        return Decode(targetType, cryptType, value);
    //    }
    //    /// <summary>
    //    /// 
    //    /// </summary>
    //    /// <param name="targetType"></param>
    //    /// <param name="cryptType"></param>
    //    /// <param name="value"></param>
    //    /// <returns></returns>
    //    public static object Decode(Type targetType, Type cryptType, string value)
    //    {
    //        if (value == null || value == "") return null;
    //        if (value.IndexOf(",") >= 0) return SecurityUtil.DecryptIdsInGuid(value, cryptType);
    //        var result = SecurityUtil.DecryptIdInGuid(value, cryptType);
    //        if (targetType == typeof(string)) return result.ToString();
    //        return result;
    //    }

    //    /// <summary>
    //    /// 从字符串转换成 int? 或者 int, 再转换成对应实体的 Name;
    //    /// </summary>
    //    public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
    //    {
    //        if (value == null) { writer.WriteValue(value); return; }
    //        if (value.Equals("")) { writer.WriteNull(); return; }
    //        if (value.GetType() == typeof(string))
    //        {
    //            var values = value.ToString().Split(new char[] { ',' }).Where(a=> a.Trim()!="")
    //                    .Select(a=> this.objMap[Convert.ToInt32(a)])
    //                    .Join(","); //  SecurityUtil.CryptIdsInGuid(value as string, cryptType);  
    //            writer.WriteValue(values); return;
    //        }
    //        string val = "";
    //        if (allowNull)
    //        {
    //            var id = (int?)(value);
    //            if (id.HasValue) val = this.objMap[id.Value]; // SecurityUtil.CryptIdInGuid(id, cryptType);
    //            else
    //            {
    //                writer.WriteValue((object)null);
    //                return;
    //            }
    //        }
    //        else
    //        {
    //            var id = (int)(value);
    //            val = this.objMap[id]; //
    //        }
    //        writer.WriteValue(val);
    //    }
    //}
}
