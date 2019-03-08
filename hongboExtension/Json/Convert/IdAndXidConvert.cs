using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace hongbao.Json
{
    ///// <summary>
    ///// IdAndXid 只输出 Xid , 用处不大， 已经被 CryptId 替代;
    ///// </summary>
    //public class IdAndXidConvert : JsonConverter
    //{
    //    /// <summary>
    //    /// 
    //    /// </summary>
    //    public IdAndXidConvert()
    //    {
    //    }
        
    //    /// <summary>
    //    /// 
    //    /// </summary>
    //    public override bool CanConvert(Type objectType)
    //    {
    //        if (objectType == typeof(INullbaleIdAndXid))
    //            return true;
    //        return false; 
    //    }

    //    /// <summary>
    //    /// 
    //    /// </summary>
    //    public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
    //    {
    //        return new INullbaleIdAndXid { Xid = ((string)reader.Value) };
    //    }

    //    /// <summary>
    //    /// 
    //    /// </summary>
    //    public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
    //    {
    //        writer.WriteValue(((INullbaleIdAndXid) value).Xid);
    //    }
    //}

   
}
