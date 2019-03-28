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
    ///// 对于DecodeIdAttribute 标记的属性，使用 DecodeIdJsonProperty 进行处理
    ///// </summary>
    //public class DecodeIdJsonProperty : JsonProperty
    //{
    //    /// <summary>
    //    /// 
    //    /// </summary>
    //    /// <param name="property"></param>
    //    /// <param name="cryptType"></param>
    //    /// <param name="objMap"></param>
    //    public DecodeIdJsonProperty(PropertyInfo property, Type cryptType, Dictionary<int, string> objMap)
    //    {
    //        this.PropertyName = property.Name;
    //        this.ValueProvider = new ReflectionValueProvider(property); 
    //        this.Converter = new DecodeIdJsonConvert(false, cryptType, objMap);  //必须提供;
    //        this.Writable = true;
    //        this.Readable = true;
    //        this.PropertyType = property.PropertyType;
            
    //        this.ShouldSerialize = new Predicate<object>((xx) => true);
    //        this.GetIsSpecified = null; // new Predicate<object>((xx) => true);
    //        this.SetIsSpecified = null; // new Predicate<object, object>((xx, yy) => true);
    //    }
    //}
}
