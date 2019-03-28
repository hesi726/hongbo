using hongbao.Reflection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.SystemExtension
{
    /// <summary>
    /// 委托的工具类;
    /// </summary>
    public static class DelegateUtil
    {
        /// <summary>
        /// 将一个方法转换为 给定的 委托类型，注意，
        /// 1. 如果具有相同的参数和参数类型和返回类型， 将直接转换为委托的实例;
        /// 2. 如果具有相同的参数格式但是参数类型不一致，但可以使用  Expression.Convert 进行转换为目的类型，则依旧返回委托的实例;
        /// </summary>
        /// <typeparam name="TDelegate"></typeparam>
        /// <param name="foundMethod">MethodInfo对象;</param>
        /// <param name="bindingObject">不为null时表示调用此方法所需要绑定的实例; 为 null 时 foundMethod 应该是静态方法</param>
        /// <returns></returns>
        public static TDelegate ConvertTo<TDelegate>(MethodInfo foundMethod, object bindingObject = null)
                where TDelegate : class
        {
            return ConvertTo(typeof(TDelegate), foundMethod, bindingObject) as TDelegate;
        }

        /// <summary>
        /// 将一个方法转换为 给定的 委托类型，注意，
        /// 1. 如果具有相同的参数和参数类型和返回类型， 将直接转换为委托的实例;
        /// 2. 如果具有相同的参数格式但是参数类型不一致，但可以使用  Expression.Convert 进行转换为目的类型，则依旧返回委托的实例;
        /// </summary>
        /// <param name="delegateType">委托类型</param>
        /// <param name="foundMethod">MethodInfo对象;</param>
        /// <param name="bindingObject">不为null时表示调用此方法所需要绑定的实例; 为 null 时 foundMethod 应该是静态方法</param>
        /// <returns></returns>
        public static Object ConvertTo(Type delegateType, MethodInfo foundMethod, object bindingObject = null)
        {
            return ConvertToDelegateInstance(delegateType, foundMethod, bindingObject);
        }

        /// <summary>
        /// 判断方法和给定泛型委托类型是否具有相同的参数;
        /// </summary>
        /// <param name="bmethod"></param>
        /// <returns></returns>
        public static bool HasCompatiableMethodParameter<TDelegate>( MethodInfo bmethod)
        {
            return HasCompatiableMethodParameter(typeof(TDelegate), bmethod);
        }

        /// <summary>
        /// 判断方法和给定泛型委托类型是否具有相同的参数;
        /// </summary>
        /// <param name="delegateType"></param>
        /// <param name="bmethod"></param>
        /// <returns></returns>
        public static bool HasCompatiableMethodParameter(Type delegateType, MethodInfo bmethod)
        {
            if (!delegateType.IsSubclassOf(typeof(Delegate))) throw new ApplicationException("delegateType must return a delegate!");
            var inv = delegateType.GetMethod("Invoke");

            var parameters = inv.GetParameters().Union(new[] { inv.ReturnParameter })
                   .Zip(bmethod.GetParameters().Union(new[] { bmethod.ReturnParameter }), (a, b) => new {
                       PassedIn = a.ParameterType,
                       Reflected = b.ParameterType,
                       Parameter = Expression.Parameter(a.ParameterType)
                   }).ToList();
            if (parameters.All(p => p.PassedIn == p.Reflected))
            {
                // Bind directly
                return true;
            }
            parameters.RemoveAt(parameters.Count - 1); //移走最后一个输出参数;

            try
            {
                var xx = parameters.Where(a => a.PassedIn != a.Reflected)
                        .Select(p => Expression.Convert(p.Parameter, p.Reflected))
                        .ToList();
               //var call = Expression.Call(bmethod, parameters.Select(
               //    p => p.PassedIn == p.Reflected? (Expression)p.Parameter : Expression.Convert(p.Parameter, p.Reflected)
               //));
               return true;
            }
            catch //(Exception exp)
            {
                return false;
            }
        }


        /// <summary>
        ///  将一个方法转换为 给定的 委托类型 的实例，注意，
        /// 1. 如果具有相同的参数和参数类型和返回类型， 将直接转换为委托的实例;
        /// 2. 如果具有相同的参数格式但是参数类型不一致，但可以使用  Expression.Convert 进行转换为目的类型，则依旧返回委托的实例;
        /// </summary>
        /// <param name="delegateType">委托类型</param>
        /// <param name="bmethod"></param>
        /// <param name="bindingObject"></param>
        /// <returns></returns>
        private static object ConvertToDelegateInstance(Type delegateType, MethodInfo bmethod, object bindingObject = null)
        {
            try
            {
                if (!delegateType.IsSubclassOf(typeof(Delegate))) throw new ApplicationException(string.Format("{0} 不是 Delegate 的子类", delegateType.Name));
                var inv = delegateType.GetMethod("Invoke");

                var parameters = inv.GetParameters().Union(new[] { inv.ReturnParameter })
                       .Zip(bmethod.GetParameters().Union(new[] { bmethod.ReturnParameter }), (a, b) => new
                       {
                           PassedIn = a.ParameterType,
                           Reflected = b.ParameterType,
                           Parameter = Expression.Parameter(a.ParameterType)
                       }).ToList();
                if (bmethod.IsStatic && bindingObject != null)
                    throw new Exception(string.Format("{0}--{1}--静态方法不能传入 BindingObject 参数", bmethod.DeclaringType.Name, bmethod.Name));
                if (!bmethod.IsStatic && bindingObject == null)
                    throw new Exception(string.Format("{0}--{1}--实例方法不能传入 BindingObject 参数", bmethod.DeclaringType.Name, bmethod.Name));
                if (parameters.All(p => p.PassedIn == p.Reflected))
                {
                    // Bind directly
                    return Delegate.CreateDelegate(delegateType, bindingObject, bmethod);
                }
                parameters.RemoveAt(parameters.Count - 1); //移走最后一个输出参数;

                if (bindingObject != null)
                {
                    Expression exp = Expression.Constant(bindingObject);
                    var call = Expression.Call(exp, bmethod, parameters.Select(
                        p => p.PassedIn == p.Reflected
                    ? (Expression)p.Parameter
                    : Expression.Convert(p.Parameter, p.Reflected)
                    ));
                    return Expression.Lambda(delegateType, call, parameters.Select(p => p.Parameter)).Compile();
                }
                else
                {
                    var call = Expression.Call(bmethod, parameters.Select(
                            p => p.PassedIn == p.Reflected
                        ? (Expression)p.Parameter
                        : Expression.Convert(p.Parameter, p.Reflected)
                        ));
                    return Expression.Lambda(delegateType, call, parameters.Select(p => p.Parameter)).Compile();
                }
            }
            catch //(Exception e)
            {
                return null;
            }
        }
    }
}
