using hongbao.CollectionExtension;
using hongbao.Json.ContactResolve;
using hongbao.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.Json
{
    /// <summary>
    /// 输出到json字符串时，进行如下处理:
    /// a. 包含有TypeScriptIgnore标记的属性不进行序列化
    /// b. 包含有 CryptIdAttribute 标记的属性进行加密/解密;
    /// c. 包含有 DecodeIdAttribute 标记的属性进行解码/解密处理；
    /// </summary>
    //public class IgnoreTypeScriptContactResolver<TDbContext> : DefaultContractResolver, ISerializingObject
    //    where TDbContext: DbContext, new()
    public class IgnoreTypeScriptContactResolver : DefaultContractResolver, ISerializingObject
    {
        /// <summary>
        /// 可能在编码或者解码时所需要的上下文;
        /// </summary>
        /// <param name="context"></param>
        public IgnoreTypeScriptContactResolver()
        {

        }
        /// <summary>
        /// TypeScriptIgnoreAttribute 标记类;
        /// </summary>
        static Type TypeSciptIgnoreType = typeof(TypeScriptIgnoreAttribute);

        /// <summary>
        /// CryptIdAttribute 标记类;
        /// </summary>
        static Type CryptIdAttributeType = typeof(CryptIdAttribute);

        /// <summary>
        /// CryptIdAttribute 标记类;
        /// </summary>
        static Type CombineAndSplitAttributeType = typeof(CombineAndSplitAttribute);

        //static Type DecodeIdAttributeType = typeof(DecodeIdAttribute);

        /// <summary>
        /// 需要忽略的 Property
        /// </summary>
        [ThreadStatic]
        PropertyInfo[] ignoreProperty;

        /// <summary>
        /// 带有 CryptIdAttribute 标注的 Property
        /// </summary>
        [ThreadStatic]
        Tuple<PropertyInfo,CryptIdAttribute>[] cryptIdPropertyTupleList;

        /// <summary>
        /// 带有 CryptIdAttribute 标注的 Property
        /// </summary>
        [ThreadStatic]
        Tuple<PropertyInfo, CombineAndSplitAttribute>[] combineAndSplitPropertyTupleList;

        ///// <summary>
        ///// 带有 DecodeIdAttribute 标注的 Property，貌似不支持;
        ///// 需要从字符串转换为整数，
        ///// </summary>
        //[ThreadStatic]
        //Tuple<PropertyInfo,DecodeIdAttribute>[] decodeIdAttributePropertyTupleList;

        /// <summary>
        /// Json序列化时，将传入 type, 以解决数据协议; 
        /// 此处查询所有包含有 TypeSciptIgnoreType 标注 的属性出来;
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public override JsonContract ResolveContract(Type type)
        {
             //cryptIdProperty = new Tuple<PropertyInfo, CryptIdAttribute>[] { }; 
             cryptIdPropertyTupleList = type.GetProperties() 
                 .Select(a => new { Prop = a, Attr = a.GetCustomAttributes(CryptIdAttributeType, true).FirstOrDefault() as CryptIdAttribute })
                 .Where(b => b.Attr != null)                 
                 .Select(c => Tuple.Create(c.Prop, c.Attr))
                 .ToArray();
            cryptIdPropertyTupleList.Where(a => a.Item2.CryptType == null).ForEach((item) =>
             {
                 var foreignKey = TypeUtil.GetFirstPropertyWithAttribute<ForeignKeyAttribute>(type, 
                        (foreign) => foreign.Name == item.Item1.Name);
                 if (foreignKey.Attr != null)
                 {
                     item.Item2.CryptType = foreignKey.Property.PropertyType;
                 }
             });
            var firstNullCryptid = cryptIdPropertyTupleList.FirstOrDefault(a => a.Item2.CryptType == null);
            if (firstNullCryptid != null)
            {
                throw new Exception(string.Format("{0}--{1} 指定 CryptIdAttribyte 属性，但未指定 CryptType参数 且无法从外键中推算出此参数",
                    type.Name, firstNullCryptid.Item1.Name));
            }

            combineAndSplitPropertyTupleList = type.GetProperties()
                 .Select(a => new { Prop = a, Attr = a.GetCustomAttributes(CombineAndSplitAttributeType, true).FirstOrDefault() as CombineAndSplitAttribute })
                 .Where(b => b.Attr != null)
                 .Select(c => Tuple.Create(c.Prop, c.Attr))
                 .ToArray();

            //decodeIdAttributePropertyTupleList = type.GetProperties()
            //     .Select(a => new { Prop = a, Attr = a.GetCustomAttributes(DecodeIdAttributeType, true).FirstOrDefault() as DecodeIdAttribute })
            //     .Where(b => b.Attr != null)
            //     .Select(c => Tuple.Create(c.Prop, c.Attr))
            //     .ToArray();

            ignoreProperty = type.GetProperties().Where(a => a.GetCustomAttributes(TypeSciptIgnoreType, true).Length > 0).ToArray();
            var result = base.ResolveContract(type);

            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        public object SerializingObject { get; private set; }


        ///// <summary>
        ///// 根据成员获取值的提供类;悲催的是后面还是会调用一个 [InvalidCastException: 指定的转换无效。]
        /////   Newtonsoft.Json.JsonWriter.WriteValue(JsonWriter writer, PrimitiveTypeCode typeCode, Object value) +1165
        ///// 会将其重写写成到客户端，这时候会有一个字符串到 int 类型的转换，而导致转换无效;
        ///// </summary>
        ///// <param name="member"></param>
        ///// <returns></returns>
        //protected override IValueProvider CreateMemberValueProvider(MemberInfo member)
        //{  
        //    if (member.MemberType == MemberTypes.Property)
        //    {
        //        var memberAttr = member.GetCustomAttribute(typeof(CryptIdAttribute)) as CryptIdAttribute;
        //        if (memberAttr != null)
        //        {
        //            PropertyInfo propertyInfo = member as PropertyInfo;
        //            return new CryptIdValueProvider(propertyInfo, memberAttr.Type);
        //        }
        //    }
        //    return base.CreateMemberValueProvider(member);
        //}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="member"></param>
        /// <param name="memberSerialization"></param>
        /// <returns></returns>
        //protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
        //{
        //    if (member.MemberType == MemberTypes.Property)
        //    {
        //        var memberAttr = member.GetCustomAttribute(typeof(CryptIdAttribute)) as CryptIdAttribute;
        //        if (memberAttr != null)
        //        {
        //            PropertyInfo propertyInfo = member as PropertyInfo;
        //            return new CryptIdJsonProperty(propertyInfo, memberAttr.Type);
        //        }
        //    }
        //    return base.CreateProperty(member, memberSerialization);
        //}

        /// <summary>
        /// Json序列化时，将传入 type 以获取需要序列化的属性;
        /// 获取需要序列化的属性, 但是忽略掉 包含有  TypeSciptIgnoreType 标注 的属性
        /// </summary>
        /// <param name="type"></param>
        /// <param name="memberSerialization"></param>
        /// <returns></returns>
        protected override IList<JsonProperty> CreateProperties(Type type,
                MemberSerialization memberSerialization)
        {
            //Dictionary<Type, Dictionary<int, string>> map = new Dictionary<Type, Dictionary<int, string>>();
            //if (this.decodeIdAttributePropertyTupleList.Length > 0)
            //{
            //    using (var context = new TDbContext())
            //    {
            //        this.decodeIdAttributePropertyTupleList.Select(a=> a.Item2.SourceType).Distinct().ForEach<Type>((item) =>
            //        {
            //            var objMap = context.Set(item).ToListAsync().Result.Select(a => a as dynamic).ToDictionary((it) => (int) it.Id , it => (string) it.Name);
            //            map[item] = objMap;
            //        });                   
            //    }
            //}
            IList<JsonProperty> list = base.CreateProperties(type, memberSerialization);            
            if (ignoreProperty == null || list==null || list.Count==0) return list;
            var result = list.Where(jsonProperty => 
                    !ignoreProperty.Any(c => c.Name == jsonProperty.PropertyName) && 
                    !cryptIdPropertyTupleList.Any(a=> a.Item1.Name == jsonProperty.PropertyName) && 
                    !combineAndSplitPropertyTupleList.Any(a => a.Item1.Name == jsonProperty.PropertyName)
                //  &&  !decodeIdAttributePropertyTupleList.Any(a => a.Item1.Name == jsonProperty.PropertyName)
            )
                .Union(cryptIdPropertyTupleList.Select(a => new CryptIdJsonProperty(a.Item1, a.Item2.CryptType)))
                .Union(combineAndSplitPropertyTupleList.Select(a => new CombineAndSplitJsonProperty(this, a.Item1)))
               // .Union(decodeIdAttributePropertyTupleList.Select(a => new DecodeIdJsonProperty(a.Item1, a.Item2.SourceType, map[a.Item2.SourceType])))
                .Union(new JsonProperty[] {  new TypeNameJsonProperty(type.Name) })
                .ToList();
            return result;
        }
    }
}
