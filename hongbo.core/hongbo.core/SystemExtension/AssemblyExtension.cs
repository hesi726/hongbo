using hongbao.CollectionExtension;
using hongbaoStandardExtension.CollectionExtension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.SystemExtension
{
    /// <summary>
    /// Assembly 的扩展类和工具类;
    /// </summary>
    public class AssemblyExtension
    {
        /// <summary>
        /// 枚举带有给定标注的类
        /// </summary>
        /// <param name="assembly"></param>
        /// <returns></returns>
        public static IEnumerable<AssemblyClass> EnumClassWithAttribute<TAttribute>(Assembly assembly)
            where TAttribute : Attribute
        {
            List<AssemblyClassMethodAndAttribute<TAttribute>> result = new List<AssemblyClassMethodAndAttribute<TAttribute>>();
            return assembly.GetTypes().Where(a => a.GetCustomAttribute<TAttribute>() != null)
                .Select(a => new AssemblyClass
                {
                    Assembly = assembly,
                    Type = a
                });
        }

        /// <summary>
        /// 枚举带有给定属性的方法
        /// </summary>
        /// <param name="assembly"></param>
        /// <returns></returns>
        public static IEnumerable<AssemblyClassMethodAndAttribute<TAttribute>> EnumMethodWithAttribute<TAttribute>(Assembly assembly)
            where TAttribute: Attribute
        {
            List<AssemblyClassMethodAndAttribute<TAttribute>> result = new List<AssemblyClassMethodAndAttribute<TAttribute>>();
            Func<Assembly, Type, MethodInfo, Attribute, bool> AssemblyClassMethodAttributeFunc =
                 (assemb, type, method, attribute) =>
                 {
                     string typename = type.Name;
                     string methodname = method.Name;
                     if (typeof(TAttribute).IsAssignableFrom(attribute.GetType()))
                     {
                         result.Add(new AssemblyClassMethodAndAttribute<TAttribute>
                         {
                             Assembly = assemb,
                             Type = type,
                             Method = method,
                             Attribute = attribute as TAttribute
                         });
                     }
                     return true;
                 };
            EnumAssembly(assembly, new DefaultAssemblyHandle
            {
                AssemblyClassMethodAttributeFunc = AssemblyClassMethodAttributeFunc
            });
            return result;
        }


        /// <summary>
        /// 枚举带有给定属性的方法
        /// </summary>
        /// <param name="assembly"></param>
        /// <param name="attributeType"></param>
        /// <returns></returns>
        public static IEnumerable<AssemblyClassMethodAndAttribute> EnumMethodWithAttribute(Assembly assembly, Type attributeType)
        {
            List<AssemblyClassMethodAndAttribute> result = new List<AssemblyClassMethodAndAttribute>();
            Func<Assembly, Type, MethodInfo, Attribute, bool> AssemblyClassMethodAttributeFunc =
                 (assemb, type, method, attribute) =>
                 {
                     if (attribute.GetType() == attributeType)
                     {
                         result.Add(new AssemblyClassMethodAndAttribute
                         {
                             Assembly = assemb,
                             Type = type,
                             Method = method,
                             Attribute = attribute
                         });
                     }
                     return true;
                 };
            EnumAssembly(assembly, new DefaultAssemblyHandle
            {
                AssemblyClassMethodAttributeFunc = AssemblyClassMethodAttributeFunc
            });
            return result;
        }

        /// <summary>
        /// 遍历枚举程序集里面的每一个类和方法并进行处理
        /// </summary>
        /// <param name="assembly"></param>
        /// <param name="handle"></param>
        public static void EnumAssembly(Assembly assembly, DefaultAssemblyHandle handle)
        {
            foreach (Type controlType in assembly.GetTypes())
            {
                var typeName = controlType.Name;
                if (handle.AssemblyClassFunc != null && !handle.AssemblyClassFunc(assembly, controlType))
                {
                    return;
                }
                var attributes = Attribute.GetCustomAttributes(controlType);
                if (ArrayUtil.IsNullOrEmpty(attributes))
                {
                    foreach (var attribute in attributes)
                    {
                        if (handle.AssemblyClassAttributeFunc != null
                            && !handle.AssemblyClassAttributeFunc(assembly, controlType, attribute))
                        {
                            return;
                        }
                    }
                }

                var methods = controlType.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static);
                foreach (var method in methods)
                {
                    if (handle.AssemblyClassMethodFunc != null
                        && !handle.AssemblyClassMethodFunc(assembly, controlType, method))
                    {
                        return;
                    }

                    var methodAttributes = Attribute.GetCustomAttributes(method, true);
                    foreach (var methodAttribute in methodAttributes)
                    {
                        if (handle.AssemblyClassMethodAttributeFunc != null
                        && !handle.AssemblyClassMethodAttributeFunc(assembly, controlType, method, methodAttribute))
                        {
                            return;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 默认的程序集处理类
        /// </summary>
        public class DefaultAssemblyHandle
        {
            /// <summary>
            /// 对程序集每一个类的处理函数,如果本函数返回 false, 则退出处理
            /// </summary>
            public Func<Assembly, Type, bool> AssemblyClassFunc { get; set; }

            /// <summary>
            /// 对程序集每一个类上定义的Attribute的处理函数,如果本函数返回 false, 则退出处理
            /// </summary>
            public Func<Assembly, Type, Attribute, bool> AssemblyClassAttributeFunc { get; set; }

            /// <summary>
            /// 对程序集每一个类内每一个方法的处理函数,如果本函数返回 false, 则退出处理
            /// </summary>
            public Func<Assembly, Type, MethodInfo, bool> AssemblyClassMethodFunc { get; set; }

            /// <summary>
            /// 对程序集每一个类内每一个方法上定义的Attribute的处理函数,如果本函数返回 false, 则退出处理
            /// </summary>
            public Func<Assembly, Type, MethodInfo, Attribute, bool> AssemblyClassMethodAttributeFunc { get; set; }

        }
        /// <summary>
        /// 程序集类和属性
        /// </summary>
        public class AssemblyClass
        {
            /// <summary>
            /// 程序集
            /// </summary>
            public Assembly Assembly { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public Type Type { get; set; }
        }

        /// <summary>
        /// 程序集类以及类里面的每一个属性
        /// </summary>
        public class AssemblyClassAndAttribute : AssemblyClass
        {
            /// <summary>
            /// 
            /// </summary>
            public Attribute Attribute { get; set; }
        }

        /// <summary>
        /// 程序集类以及类里面的每一个方法
        /// </summary>
        public class AssemblyClassMethod : AssemblyClass
        {
            /// <summary>
            /// 
            /// </summary>
            public MethodInfo Method { get; set; }

            private object instance;

            /// <summary>
            /// 调用给定的方法
            /// </summary>
            /// <param name="param"></param>
            /// <returns></returns>
            public object Invoke(params object[] param)
            {
                if (!Method.IsStatic)
                {
                    if (instance == null)
                    {
                        var constructor = Type.GetConstructor(Type.EmptyTypes); //获取空构造函数
                        this.instance = constructor.Invoke(null);
                    }
                    object result = Method.Invoke(instance, param);
                    return result;
                }
                else if (Method.IsStatic)  //静态方法
                {
                    object result = Method.Invoke(null, param);
                    return result;
                }
                return null;

            }
        }

        /// <summary>
        /// 程序集类内的每一个方法的每一个属性
        /// </summary>
        public class AssemblyClassMethodAndAttribute : AssemblyClassMethod
        {
            /// <summary>
            /// 
            /// </summary>
            public Attribute Attribute { get; set; }


        }

        /// <summary>
        /// 程序集类内的每一个方法的每一个属性
        /// </summary>
        public class AssemblyClassMethodAndAttribute<TAttribute> : AssemblyClassMethod
            where TAttribute : Attribute
        {
            /// <summary>
            /// 
            /// </summary>
            public TAttribute Attribute { get; set; }


        }
    }
}
