using System;
using System.Collections.Generic;
using System.Linq;
#if NETCOREAPP2_2
using Microsoft.EntityFrameworkCore;
#else
using System.Data.Entity;
#endif
namespace hongbao.EntityExtension
{
    /// <summary>
    /// 当前上下文的DbContext;
    /// </summary>
    public interface ICurrent
    {
        /// <summary>
        /// 当前DbContext;
        /// </summary>
        DbContext Current { get; set;  }
    }
    /// <summary>
    /// 
    /// </summary>
    public static class DbContextUtil
    {
        /// <summary>
        /// 创建一个新的DbContext,并执行给定的动作;
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="action"></param>
        /// <param name="currentContext"></param>
        public static void ActionContext<T>(Action<T> action, T currentContext=null)
            where T : DbContext, new()
        {
            if (currentContext == null)
            {
                using (var context = new T())
                {
                    action(context);
                }
            }
            else
            {
                action(currentContext);
            }
        }


        /// <summary>
        /// 创建一个临时的 EhayContext,操作后释放,返回结果;        
        /// </summary>
        /// <param name="contextAction"></param>
        /// <param name="currentContext"></param>
        public static K ActionContext<T,K>(Func<T, K> contextAction, T currentContext = null)
            where T : DbContext, new()
        {
            if (currentContext == null)
            {
                using (var context = new T())
                {
                    return contextAction(context);
                }
            }
            else
            {
                return contextAction(currentContext);
            }
        }

        /// <summary>
        /// 判断是否存在符合某一个条件的实体;
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <param name="p"></param>
        /// <param name="currentContext"></param>
        /// <returns></returns>
        public static bool ExistsEntity<T1, T2>(System.Func<T2, bool> p, T1 currentContext=null)
            where T1 : DbContext, new()
            where T2 : class
        {            
                return FindFirstEntity<T1, T2>(p, currentContext) != null;
         
        }

        /// <summary>
        /// 判断是否存在符合某一个条件的实体;
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <param name="p"></param>
        /// <param name="currentContext"></param>
        /// <returns></returns>
        public static T2 FindFirstEntity<T1, T2>(System.Func<T2, bool> p, T1 currentContext = null)
            where T1 : DbContext, new()
            where T2 : class
        {
            if (currentContext == null)
            {
                using (var context = new T1())
                {
                    return context.Set<T2>().Where(p).FirstOrDefault();
                }
            }
            else
            {
                return currentContext.Set<T2>().Where(p).FirstOrDefault();
            }
        }

        /// <summary>
        /// 根据Id查询实体列表;
        /// </summary>
        /// <typeparam name="TContext"></typeparam>
        /// <typeparam name="T"></typeparam>
        /// <param name="context"></param>
        /// <param name="idAry"> id数组，为 null 时返回全部数据; </param>
        /// <returns></returns>
        public static List<T> GetEntityListAccordIds<TContext, T>(int[] idAry, TContext context = null)
            where TContext: DbContext, new()
            where T: class, IId, IName
        {
            if (idAry == null)
            {
                return DbContextExtension.FuncContext(tcontext => tcontext.Set<T>().ToList(), null, context);
            }
            return DbContextExtension.FuncContext(tcontext=> tcontext.Set<T>().Where(b => idAry.Contains(b.Id)).ToList(), null, context);
        }

        /// <summary>
        /// 获取实体类型
        /// </summary>
        /// <param name="maybeProxyType">可能是实体的代理类型或者实体类型</param>
        /// <returns></returns>
        public static Type GetEntityType(Type maybeProxyType)
        {
            var result = maybeProxyType;
            var typeNs = maybeProxyType.Namespace;
            var typeName = maybeProxyType.Name;
            if (typeNs == "System.Data.Entity.DynamicProxies") //代理类型
            {
                result = maybeProxyType.BaseType;
            }
            return result;
        }
    }
}