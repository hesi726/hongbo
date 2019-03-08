using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace hongbao.LinqExtension
{
    ///// <summary>
    ///// 
    ///// </summary>
    //public interface IDataContextGetter
    //{
    //    /// <summary>
    //    /// 
    //    /// </summary>
    //    /// <returns></returns>
    //    DataContext GetDataContext();
    //}

    ///// <summary>
    ///// 
    ///// </summary>
    //public static class DataContextExtension
    //{
    //    /// <summary>
    //    /// 从数据库加载实体，并将实体的键和实体对象加载到一个映射中；
    //    /// </summary>
    //    /// <typeparam name="TKey">键类型</typeparam>
    //    /// <typeparam name="TValue">对象类型</typeparam>
    //    /// <param name="context"></param>
    //    /// <param name="func">获得对象的键的方法</param>
    //    /// <returns></returns>
    //    public static Dictionary<TKey, TValue> MapEntity<TKey, TValue>(this DataContext context, Func<TValue, TKey> func)
    //        where TValue : class
    //    {
    //        return context.GetTable<TValue>().ToDictionary(func);
    //    }

    //    /// <summary>
    //    /// 从数据库加载实体，并将实体的键和实体对象加载到一个映射中；
    //    /// </summary>
    //    /// <typeparam name="TKey">键类型</typeparam>
    //    /// <typeparam name="TValue">对象类型</typeparam>
    //    /// <param name="contextAccess">获得对象的键的方法</param>
    //    /// <param name="func">获得对象的键的方法</param>
    //    /// <returns></returns>
    //    public static Dictionary<TKey, TValue> MapEntity<TKey, TValue>(this IDataContextGetter contextAccess, Func<TValue, TKey> func)
    //        where TValue : class
    //    {
    //        using (var context = contextAccess.GetDataContext())
    //        {
    //            return context.GetTable<TValue>().ToDictionary(func);
    //        }
    //    }

    //    /// <summary>
    //    /// 执行查询,并返回查询结果表；
    //    /// </summary>
    //    /// <param name="context"></param>
    //    /// <param name="sql"></param>
    //    /// <returns></returns>
    //    public static DataTable ExecuteQuery(this DataContext context, string sql)
    //    {
    //        return ExecuteQuery(context, sql, (cmd) =>
    //         {
    //             return new System.Data.SqlClient.SqlDataAdapter((SqlCommand) cmd);
    //         });
    //    }

    //    /// <summary>
    //    /// 执行查询,并返回查询结果表；
    //    /// </summary>
    //    /// <param name="contextAccess"></param>
    //    /// <param name="sql"></param>
    //    /// <returns></returns>
    //    public static DataTable ExecuteQuery(this IDataContextGetter contextAccess, string sql)
    //    {
    //         using (var context = contextAccess.GetDataContext())
    //         {
    //            return context.ExecuteQuery(sql);
    //         }
    //    }

    //    /// <summary>
    //    /// 执行查询,并返回查询结果对象列表；
    //    /// </summary>
    //    /// <param name="contextAccess"></param>
    //    /// <param name="sql"></param>
    //    /// <param name="par"></param>
    //    /// <returns></returns>
    //    public static List<T> ExecuteQuery<T>(this IDataContextGetter contextAccess, string sql, object[] par = null)
    //    {
    //        if (par == null) par = new object[] { };
    //        using (var context = contextAccess.GetDataContext())
    //        {
    //            return context.ExecuteQuery<T>(sql, par).ToList();
    //        }
    //    }
    //    /// <summary>
    //    /// 执行更新；
    //    /// </summary>
    //    /// <param name="contextAccess"></param>
    //    /// <param name="sql"></param>
    //    ///  <param name="par"></param>
    //    /// <returns></returns>
    //    public static int ExecuteCommand(this IDataContextGetter contextAccess, string sql, object[] par = null)
    //    {
    //        using (var context = contextAccess.GetDataContext())
    //        {
    //            return context.ExecuteCommand(sql, par);
    //        }
    //    }

    //    /// <summary>
    //    /// 执行查询,并返回查询结果的第一条对象； 
    //    /// </summary>
    //    /// <param name="contextAccess"></param>
    //    /// <param name="sql"></param>
    //    ///  <param name="par"></param>
    //    /// <returns></returns>
    //    public static T ExecuteScala<T>(this IDataContextGetter contextAccess, string sql, object[] par = null)
    //    {
    //        using (var context = contextAccess.GetDataContext())
    //        {
    //            return context.ExecuteQuery<T>(sql, par).FirstOrDefault();
    //        }
    //    }

    //    /// <summary>
    //    /// 执行查询
    //    /// </summary>
    //    /// <param name="contextAccess"></param>
    //    /// <param name="sql"></param>
    //    /// <param name="adapterFunc"></param>
    //    /// <returns></returns>
    //    public static DataTable ExecuteQuery(this IDataContextGetter contextAccess, string sql, Func<IDbCommand, IDbDataAdapter> adapterFunc)
    //    {
    //        using (var context = contextAccess.GetDataContext())
    //        {
    //            return context.ExecuteQuery(sql, adapterFunc);
    //        }
    //    }

    //    /// <summary>
    //    /// 执行查询,并返回查询结果表；
    //    /// </summary>
    //    /// <param name="context"></param>
    //    /// <param name="sql"></param>
    //    /// <param name="adapterFunc"></param>
    //    /// <returns></returns>
    //    public static DataTable ExecuteQuery(this DataContext context, string sql, Func<IDbCommand, IDbDataAdapter> adapterFunc)
    //    {
    //        try
    //         {
    //             var conn = context.Connection;
                 
    //             var cmd = conn.CreateCommand();
    //             cmd.CommandTimeout = 0;
    //             cmd.CommandText = sql;
    //             cmd.Connection = conn;
    //             LogUtil.FileLog.FILE_LOG.Log(sql);
    //             IDbDataAdapter adap = adapterFunc(cmd);
    //             DataSet ds = new DataSet();
    //             adap.Fill(ds);
    //             return ds.Tables[0];
    //         }
    //         finally
    //         {
    //         }
    //    }

    //    /// <summary>
    //    /// 执行查询,并返回查询的一个Raader,因为表可能很大,使得无法Fill到DataTable中；
    //    /// </summary>
    //    /// <param name="contextAccess"></param>
    //    /// <param name="sql"></param>
    //    /// <param name="adapterFunc"></param>
    //    /// <returns></returns>
    //    public static IDataReader ExecuteReader(this IDataContextGetter contextAccess, string sql, Func<IDbCommand, IDbDataAdapter> adapterFunc)
    //    {
    //        using (var context = contextAccess.GetDataContext())
    //        {
    //            return context.ExecuteReader(sql, adapterFunc);
    //        }
    //    }

    //    /// <summary>
    //    /// 执行查询,并返回查询的一个Raader,因为表可能很大,使得无法Fill到DataTable中；
    //    /// </summary>
    //    /// <param name="context"></param>
    //    /// <param name="sql"></param>
    //    /// <param name="adapterFunc"></param>
    //    /// <returns></returns>
    //    public static IDataReader ExecuteReader(this DataContext context, string sql, Func<IDbCommand, IDbDataAdapter> adapterFunc)
    //    {
    //        try
    //        {
    //            var conn = context.Connection;
    //            var cmd = conn.CreateCommand();
    //            cmd.CommandText = sql;
    //            cmd.Connection = conn;
    //            LogUtil.FileLog.FILE_LOG.Log(sql);
    //            IDbDataAdapter adap = adapterFunc(cmd);
    //            return cmd.ExecuteReader(CommandBehavior.CloseConnection);
    //        }
    //        finally
    //        {
    //        }
    //    }

    //    /// <summary>
    //    /// 对实体进行给定的操作；并返回操作结果；
    //    /// </summary>
    //    /// <typeparam name="T"></typeparam>
    //    /// <typeparam name="K"></typeparam>
    //    /// <param name="contextAccess"></param>
    //    /// <param name="func"></param>
    //    /// <returns></returns>
    //    public static K FunctionContext<T, K>(this IDataContextGetter contextAccess, Func<DataContext, K> func)
    //    {
    //        using (var context = contextAccess.GetDataContext())
    //        {
    //            return context.FunctionContext<T,K>(func);
    //        } 
    //    }

    //    /// <summary>
    //    /// 对实体进行给定的操作；并返回操作结果；
    //    /// </summary>
    //    /// <typeparam name="T"></typeparam>
    //    /// <typeparam name="K"></typeparam>
    //    /// <param name="context"></param>
    //    /// <param name="func"></param>
    //    /// <returns></returns>
    //    public static K FunctionContext<T,K>(this DataContext context, Func<DataContext, K> func)
    //    {
    //         return func(context);
           
    //    }

    //    /// <summary>
    //    /// 对实体进行给定的操作；并返回操作结果；
    //    /// </summary>
    //    /// <typeparam name="T"></typeparam>
    //    /// <typeparam name="K"></typeparam>
    //    /// <param name="contextAccess"></param>
    //    /// <param name="action"></param>
    //    public static void ActionContext<T, K>(this IDataContextGetter contextAccess, Action<DataContext> action)
    //    {
    //        using (var context = contextAccess.GetDataContext())
    //        {
    //            context.ActionContext(action);
    //        }
    //    }

    //    /// <summary>
    //    /// 对实体进行给定的操作；并返回操作结果；
    //    /// </summary>
    //    /// <param name="context"></param>
    //    /// <param name="action"></param>
    //    public static void ActionContext(this DataContext context, Action<DataContext> action)
    //    {
    //        action(context);
    //    }
    //}
}
