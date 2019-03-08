using hongbao.Json.ContactResolve;
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
    /// 对于 CombineAndSplitAttribute 标记的属性，使用 CombineAndSplitJsonProperty 进行处理
    /// </summary>
    internal class CombineAndSplitJsonProperty : JsonProperty
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="serializingObject"></param>
        /// <param name="property"></param>
        public CombineAndSplitJsonProperty(ISerializingObject serializingObject, PropertyInfo property)
        {
            this.PropertyName = property.Name;
            this.ValueProvider = new ReflectionValueProvider(property); 
            this.Converter = new CombineAndSplitJsonConvert(serializingObject);  //必须提供;
            this.Writable = true;
            this.Readable = true;
            this.PropertyType = property.PropertyType;
            
            this.ShouldSerialize = new Predicate<object>((xx) => true);
            this.GetIsSpecified = null; // new Predicate<object>((xx) => true);
            this.SetIsSpecified = null; // new Predicate<object, object>((xx, yy) => true);
        }
    }
}
