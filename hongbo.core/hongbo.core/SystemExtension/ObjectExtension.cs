using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using hongbao.CollectionExtension;
using System.Dynamic;
using System.IO;
using System.ComponentModel;

namespace hongbao.SystemExtension
{
    /// <summary>
    /// 利用反射 Property属性的访问类；
    /// </summary>
    public static class ObjectExtension
    {
        private static Dictionary<string, PropertyInfo> propMap = new Dictionary<string, PropertyInfo>();
        private static Dictionary<string, MethodInfo> methodMap = new Dictionary<string, MethodInfo>();

        private static Dictionary<string, Tuple<Dictionary<string, PropertyInfo>, Dictionary<string, MethodInfo>, Dictionary<string, MethodInfo>>> typePropAndMethodMap 
            = new Dictionary<string, Tuple<Dictionary<string, PropertyInfo>, Dictionary<string, MethodInfo>, Dictionary<string, MethodInfo>>>();

        /// <summary>
        /// 初始化类的方法或者属性；
        /// </summary>
        /// <param name="type"></param>
        private static void InitiateType(Type type)
        {
            string typeName = type.Namespace + "#" + type.Name;
            if (typePropAndMethodMap.ContainsKey(typeName)) return;
            var propMap = new Dictionary<string, PropertyInfo>();
            var methodMap = new Dictionary<string, MethodInfo>();
            var ignorecaseMethodMap = new Dictionary<string, MethodInfo>();
            var propertys = type.GetProperties();
            var methods = type.GetMethods();
            propertys.ForEach((aprop) => propMap[aprop.Name] = aprop);
            methods.ForEach((amethod) => methodMap[amethod.Name] = amethod);
            methods.ForEach((amethod) => ignorecaseMethodMap[amethod.Name.ToLower()] = amethod);
            typePropAndMethodMap[typeName] = Tuple.Create(propMap, methodMap, ignorecaseMethodMap);
        }

        /// <summary>
        /// 获得给定类型的属性；注意，如果属性不存在，则返回null;
        /// 如果给定的 propertyName 为null或者空字符串，抛出 ArgumentNullException 异常；
        /// </summary>
        /// <param name="type"></param>
        /// <param name="propertyName"></param>
        /// <returns></returns>
        private static PropertyInfo GetPropertyInfo(Type type, string propertyName)
        {
            if (string.IsNullOrEmpty(propertyName)) throw new ArgumentNullException();
            string typeName = type.Namespace + "#" + type.Name;
            if (!typePropAndMethodMap.ContainsKey(typeName)) InitiateType(type);
            var propMap = typePropAndMethodMap[typeName].Item1;
            if (propMap.ContainsKey(propertyName)) return propMap[propertyName];
            return null; 
        }

        /// <summary>
        /// 获得给定名称的方法；注意，如果方法不存在，则返回null;
        /// 如果给定的 propertyName 为null或者空字符串，抛出 ArgumentNullException 异常；
        /// </summary>
        /// <param name="type"></param>
        /// <param name="methodName"></param>
        /// <param name="ignoreCase">忽略方法大小写；</param>
        /// <returns></returns>
        private static MethodInfo GetMethodInfo(Type type, string methodName, bool ignoreCase=false)
        {
            if (string.IsNullOrEmpty(methodName)) throw new ArgumentNullException();
            string typeName = type.Namespace + "#" + type.Name;
            if (!typePropAndMethodMap.ContainsKey(typeName)) InitiateType(type);
            if (ignoreCase)
            {
                var propMap = typePropAndMethodMap[typeName].Item3;
                methodName = methodName.ToLower();
                if (propMap.ContainsKey(methodName)) return propMap[methodName];
            }
            else {
                var propMap = typePropAndMethodMap[typeName].Item2;
                if (propMap.ContainsKey(methodName)) return propMap[methodName];
            }
            return null;
        }

        #region 获取或者设置属性的值；
        /// <summary>
        /// 设置对象属性的值，如果属性原来的值和新值相等，则不会设置； 
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="prop"></param>
        /// <param name="propertyValue"></param>
        public static void SetProperty(this object obj, PropertyInfo prop, object propertyValue)
        {
            var oldValue = prop.GetValue(obj);
            
            if (oldValue == null && propertyValue == null) return; //都是null; 
            if (prop.PropertyType.IsValueType && propertyValue == null)  //值类型传入 null; 时设置为0； 
                propertyValue = 0;
            if (prop.PropertyType.BaseType == typeof(Enum))
            {
                prop.SetValue(obj, EnumUtil.GetValue(prop.PropertyType, System.Convert.ToInt32(propertyValue)));
                return;
            }
            object newValue = null;
            if (prop.PropertyType.IsGenericType)
                newValue = Convert.ChangeType(propertyValue, prop.PropertyType.GetGenericArguments()[0]);
            else
                newValue = Convert.ChangeType(propertyValue, prop.PropertyType);
            if (oldValue == null && newValue == null) return;
            if (oldValue != null && oldValue.Equals(newValue)) return;
            prop.SetValue(obj, newValue, null);
            /*if (prop.PropertyType.IsValueType)  //值类型； 
            {
                if (prop.PropertyType == typeof(System.DateTime))
                {
                    try
                    {
                        DateTime newValue = Convert.ToDateTime(propertyValue);
                        DateTime nowValue = Convert.ToDateTime(prop.GetValue(obj, null));
                        if (newValue == nowValue)
                            return;
                    }
                    catch (Exception expp)
                    {
                        Console.Write(expp.StackTrace);
                    }
                }
                try
                {
                    double newValue = Convert.ToDouble(propertyValue);
                    var nowValue = Convert.ToDouble(prop.GetValue(obj, null));
                    if (Math.Abs(newValue - nowValue) < 0.01)
                        return;
                }
                catch (Exception expp)
                {
                    Console.Write(expp.StackTrace);
                }
            }
            if (prop.PropertyType.IsValueType && propertyValue == null)
                prop.SetValue(obj, Convert.ChangeType(0, prop.PropertyType), null);
            else if (prop.PropertyType.IsGenericType)
                prop.SetValue(obj, Convert.ChangeType(propertyValue, prop.PropertyType.GetGenericArguments()[0]), null);
            else
                prop.SetValue(obj, Convert.ChangeType(propertyValue, prop.PropertyType), null);*/
        }

        /// <summary>
        /// 设置对象某一个属性的值；   
        /// 1. 如果给定值类型和属性类型不一致，将尽量将属性的值转换为属性类型；
        /// 2. 另外，如果给定属性值为null,则不会改变属性原来的值； 
        /// </summary>
        /// <param name="obj">对象</param>
        /// <param name="propertyName">属性名称</param>
        /// <param name="propertyValue">属性的值，说明，如果此值类型和属性类型不一致，将尽量将属性的值转换为属性类型；</param>
        /// <param name="emptyStringAsNull">是否将空字符串当作null?</param>
        public static void SetProperty(this object obj, string propertyName, object propertyValue, bool emptyStringAsNull = true)
        {
            try
            {
                var prop = GetPropertyInfo(obj.GetType(), propertyName);
                if (prop != null)
                {
                    if (emptyStringAsNull && propertyValue != null && propertyValue.Equals(""))
                    {
                        propertyValue = null;
                    }
                    if (propertyValue == null) return;
                    SetProperty(obj, prop, propertyValue); 
                }
            }
            catch (Exception expp)
            {
                throw expp;
            }
        
        }

        /// <summary>
        /// 设置属性的值；
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="propertyName"></param>
        /// <param name="propertyValue"></param>
        /// <param name="emptyStringAsNull"></param>
        public static void SetProperties(this object obj, string[] propertyName, object[] propertyValue, bool emptyStringAsNull = true)
        {
            for (int index=0; index<propertyName.Length; index++)
            {
                var propName = propertyName[index].Trim();
                if (propName.Length > 0)
                {
                  
                        SetProperty(obj, propName, propertyValue[index], emptyStringAsNull);
                 
                }
            }
        }

        /// <summary>
        /// 获取属性的值；
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="propertyName"></param>
        public static object GetProperty(this object obj, string propertyName)
        {
            var prop = GetPropertyInfo(obj.GetType(), propertyName);
            return obj.GetProperty(prop);
        }

        /// <summary>
        /// 获取属性的值；
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="property"></param>
        public static object GetProperty(this object obj, PropertyInfo property)
        {
            var val = property.GetValue(obj, null);
            return val;
        }

        #endregion

        #region 调用方法
        /// <summary>
        /// 调用方法；  @hongboExtensions.System
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="methodName"></param>
        /// <param name="methodPar"></param>
        /// <param name="ignoreCase"></param>
        /// <returns></returns>
        public static object CallMethod(this object obj, string methodName, object[] methodPar, bool ignoreCase = false)
        {
            MethodInfo method = GetMethodInfo(obj.GetType(), methodName, ignoreCase);
            if (method == null) return null;
            return method.Invoke(obj, methodPar);
        }

        #endregion
        /// <summary>
        /// 将匿名对象转换成为 ExpandoObject 对象； 
        /// </summary>
        /// <param name="anonymousObject"></param>
        /// <returns></returns>
        public static ExpandoObject ToExpando(this object anonymousObject)
        {
            IDictionary<string, object> anonymousDictionary = new ExpandoObject();
            foreach (PropertyDescriptor pro in TypeDescriptor.GetProperties(anonymousObject.GetType()))
            {
                anonymousDictionary.Add(pro.Name, pro.GetValue(anonymousDictionary));
            }
            //            IDictionary<string, object> expando = new ExpandoObject();
            //foreach (var item in anonymousDictionary)
            //    expando.Add(item);
            return (ExpandoObject)anonymousDictionary;
        }

        /// <summary>
        /// 转换一个 Action 为 Function
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        public static Func<T, object> ToFunc<T>(Action<T> action)
        {
            if (action == null) return null;
            Func<T, object> func = (context) =>
            {
                action(context);
                return null;
            };
            return func;
        }


        #region 序列化方法
        //[ThreadStatic]
        //private static MemoryStream memoryStream = null;

        //[ThreadStatic]
        //private static BinaryFormatter binaryFormatter = null; 

        /// <summary>
        /// 序列化对象,@hongbao.SystemExtension, 注意 ，这个序列化方法将会一直序列化所有子对象和子对象的子对象； 
        /// 也因此，不适宜于用到 Redis 中 ， 因为这样会造成大量浪费； 
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public static byte[] Serialize(this object o)
        {
            if (o == null)
            {
                return null;
            }

            System.Runtime.Serialization.Formatters.Binary.BinaryFormatter binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            using (MemoryStream memoryStream = new MemoryStream())
            {
                binaryFormatter.Serialize(memoryStream, o);
                byte[] objectDataAsStream = memoryStream.ToArray();              
                return objectDataAsStream;
            }
        }

        /// <summary>
        /// 反序列化对象, @hongbao.SystemExtension
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="stream"></param>
        /// <returns></returns>
        public static T Deserialize<T>(this byte[] stream)
        {
            if (stream == null)
            {
                return default(T);
            }

            System.Runtime.Serialization.Formatters.Binary.BinaryFormatter binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            using (MemoryStream memoryStream = new MemoryStream(stream))
            {
                T result = (T)binaryFormatter.Deserialize(memoryStream);           
                return result;
            }
        }

        #endregion
    }
}
