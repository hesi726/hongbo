using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace hongbao.LinqExtract
{
    ///// <summary>
    ///// 和局部线程相关的 DataContext 工具类，
    ///// 为啥要有这样的一个类？
    ///// 不好用； 
    ///// 在一个处理中，可能要调用一系列的方法，最后再进行一次性的提交，
    ///// 此时，如果不用此类中的方法，你必须
    ///// 1. 在最先的处理中创建一个 DataContext,然后将此 DataContext 作为参数传递给以后一系列的方法；
    /////    并在最后一个处理中对 DataContext 进行 Submit 和 Dispose 操作；
    /////    任何处理中出现异常，你都必须手工对 DataContext进行 Dispose;
    /////    
    ///// 2. 在最先的处理中创建一个 DataContext,将此 DataContext 存储为一个 变量，在此后的一系列方法中调用此变量；
    /////    并在最后一个处理中对 DataContext 进行 Submit 和 Dispose 操作；
    /////    任何处理中出现异常，你都必须手工对 DataContext进行 Dispose;
    ///// </summary>
    //public class ThreadContextUtil<T>
    //    where T : DataContext
    //{
    //    /// <summary>
    //    /// 这个在多个线程中有不同定义，因此可以保证在同一个线程中只有一个DataContext实例；
    //    /// </summary>
    //    [ThreadStatic]
    //    private static T threadContext = null;
        
    //    /// <summary>
    //    /// 局部线程中DataContext的引用计数；
    //    /// 每 Dispose 一次，引用计数 - 1，
    //    /// 当减到0的时候，DataContext进行提交操作；
    //    /// </summary>MapEntity
    //    [ThreadStatic]
    //    private static int contextReference = 0;

    //    /// <summary>
    //    /// 局部线程中DataContext的引用计数；
    //    /// 每 Dispose 一次，引用计数 - 1，
    //    /// 当减到0的时候，DataContext进行提交操作；
    //    /// </summary>
    //    //[ThreadStatic]
    //    //private static Func<T> contextBuilder = null;

    //    private static Func<T> globalContextBuilder = null;

        
    //    /// <summary>
    //    /// 设置局部线程中如何构建一个DataContext对象；
    //    /// 注意，如果局部线程中已经有一个构建好的 DataContext对象，则本方法将抛出异常；
    //    /// 因为该对象正在活动中，如果允许设置，则引用计数将无法保证正确；
    //    /// </summary>
    //    /// <param name="contextFunc"></param>
    //    public static void NonSetGlobalContextBuilder(Func<T> contextFunc)
    //    {
    //        if (globalContextBuilder != null && globalContextBuilder!= contextFunc)
    //        {
    //            throw new Exception("globalContextBuilder 只允许设置一次!");
    //        }
    //        globalContextBuilder = contextFunc;
    //    }


    //    /// <summary>
    //    /// 构建一个StockDataContext对象，注意，将linq 的LOG设置标准输出；
    //    /// </summary>
    //    /// <returns></returns>
    //    public static T NonBuildDataContext()
    //    {
    //        contextReference++;
    //        if (threadContext != null)
    //        {
    //            return threadContext;
    //        }
    //        if (globalContextBuilder == null)
    //        {
    //            throw new Exception("请先调用 SetContextBuilder 方法设置如何构建一个有效的 DataContext");
    //        }
    //        threadContext = globalContextBuilder();
    //        threadContext.Log = System.Console.Out;
    //        return threadContext;
    //    }

    //    /// <summary>
    //    /// 对实体进行给定的动作；
    //    /// </summary>
    //    /// <param name="action"></param>
    //    public static void NonActionContext(Action<T> action)
    //    {
    //        try
    //        {
    //           // action(BuildDataContext());
    //        }
    //        finally
    //        {
    //            subContextReference();
    //        }
    //    }

    //    /// <summary>
    //    /// 减少Context的引用计数；如果引用计数变为0,
    //    /// 因此，在外部，你不能够进行数据提交的操作；
    //    /// 进行数据提交,释放对象；
    //    /// </summary>
    //    private static void subContextReference()
    //    {
    //        contextReference--;
    //        if (contextReference == 0)
    //        {
    //            var changeSet = threadContext.GetChangeSet();
    //            if (changeSet.Inserts.Count > 0 || changeSet.Deletes.Count > 0 || changeSet.Updates.Count > 0)
    //            {
    //                try
    //                {
    //                    threadContext.SubmitChanges();
    //                }
    //                finally
    //                {
    //                    threadContext.Dispose();
    //                    threadContext = null;
    //                }
    //            }
    //        }
    //    }

    //    /// <summary>
    //    /// 执行查询,并返回查询结果表；
    //    /// </summary>
    //    /// <param name="sql"></param>
    //    /// <returns></returns>
    //    public static DataTable NonExecuteQuery(string sql)
    //    {
    //        return null; 
    //       /* return ExecuteQuery(sql, (cmd) =>
    //        {
    //            return new System.Data.SqlClient.SqlDataAdapter( (SqlCommand) cmd);
    //        });*/
    //    }

    //    /// <summary>
    //    ///  执行查询,并返回查询结果表；
    //    /// </summary>
    //    /// <param name="sql"></param>
    //    /// <param name="adapterFunc"></param>
    //    /// <returns></returns>
    //    public static DataTable NonExecuteQuery(string sql, Func<IDbCommand,IDbDataAdapter> adapterFunc)
    //    {
    //        return null;
    //       /* try
    //        {
    //            var context = BuildDataContext();
    //            var conn = context.Connection;
    //            var cmd = conn.CreateCommand();
    //            cmd.CommandText = sql;
    //            cmd.Connection = conn;
    //            LogUtil.FileLog.FILE_LOG.Log(sql);
    //            IDbDataAdapter adap = adapterFunc(cmd);
    //            DataSet ds = new DataSet();
    //            adap.Fill(ds);
    //            return ds.Tables[0];
    //        }
    //        finally
    //        {
    //            subContextReference();
    //        }*/
    //    }

    //    /// <summary>
    //    /// 对实体进行给定的操作；并返回操作结果；
    //    /// </summary>
    //    /// <typeparam name="K"></typeparam>
    //    /// <param name="func"></param>
    //    /// <returns></returns>
    //    public static K NonFunctionContext<K>(Func<T, K> func)
    //    {
    //        return default(K);
    //       /* try
    //        {
    //            return func(BuildDataContext());
    //        }
    //        finally
    //        {
    //            subContextReference();
    //        }*/
    //    }

       
       

    //    /// <summary>
    //    /// 执行给定的SQL 数据库更改命令，返回该命令影响的记录行数；
    //    /// </summary>
    //    /// <param name="sql"></param>
    //    /// <param name="p"></param>
    //    /// <returns></returns>
    //    public static int NonExecuteCommand(string sql, object[] p)
    //    {
    //        return 0;
    //      /*  int result = 0;
    //        ActionContext((context) =>
    //        {
    //            LogUtil.FileLog.FILE_LOG.Log(sql);
    //            result = context.ExecuteCommand(sql, p);
    //        });
    //        return result;*/
    //    }

    //    /// <summary>
    //    /// 执行查询，并返回查询结果所转换的对象列表；
    //    /// </summary>
    //    /// <typeparam name="K"></typeparam>
    //    /// <param name="sql"></param>
    //    /// <param name="par"></param>
    //    /// <returns></returns>
    //    public static List<K> NonExecuteQuery<K>(string sql, object[] par)
    //    {
    //        return null; 
    //       /* return FunctionContext<List<K>>((context) =>
    //        {
    //            return context.ExecuteQuery<K>(sql, par).ToList();
    //        });*/
    //    }

    //    /// <summary>
    //    /// 执行查询，并返回查询结果所转换的第一个对象；
    //    /// </summary>
    //    /// <typeparam name="K"></typeparam>
    //    /// <param name="sql"></param>
    //    /// <param name="par"></param>
    //    /// <returns></returns>
    //    public static K NonExecuteQueryScala<K>(string sql, object[] par)
    //    {
    //        return default(K);
    //     /*   var result = FunctionContext<K>((context) =>
    //        {
    //            return context.ExecuteQuery<K>(sql, par).ElementAtOrDefault<K>(0);
    //        });
    //        return result;*/
    //    }
    //}
}
