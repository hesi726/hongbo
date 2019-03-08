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
    /// 对于 CryptIdAttribute 标记的属性，使用 CryptIdJsonProperty 进行处理
    /// </summary>
    public class CryptIdJsonProperty : JsonProperty
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="property"></param>
        /// <param name="cryptType"></param>
        public CryptIdJsonProperty(PropertyInfo property, Type cryptType)
        {
            this.PropertyName = property.Name;
            this.ValueProvider = new ReflectionValueProvider(property); 
            this.Converter = new CryptIdJsonConvert(false, cryptType);  //必须提供;
            this.Writable = true;
            this.Readable = true;
            this.PropertyType = property.PropertyType;
            
            this.ShouldSerialize = new Predicate<object>((xx) => true);
            this.GetIsSpecified = null; // new Predicate<object>((xx) => true);
            this.SetIsSpecified = null; // new Predicate<object, object>((xx, yy) => true);
        }
    }
}
