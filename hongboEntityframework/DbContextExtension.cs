using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Collections;
using System.Collections.Concurrent;
using System.Globalization;
using System.Linq.Expressions;
using hongbao.SystemExtension;
#if NETCOREAPP2_2
using Microsoft.EntityFrameworkCore;
#else
using System.Data.Entity;
#endif

namespace hongbao.EntityExtension
{
    /// <summary>
    /// 获取 DbContext 对象的接口； 
    /// </summary>
    public interface IDbContextGetter
    {
        /// <summary>
        /// 获取 DbContext 对象；
        /// </summary>
        /// <returns></returns>
         DbContext GetDbContext();
    }

    /// <summary>
    ///  DbContext 的扩充类； 
    /// </summary>
    public static class DbContextExtension
    {
        #region 映射实体
        /// <summary>
        /// 从数据库加载实体，并将实体的键和实体对象加载到一个映射中；
        /// </summary>
        /// <typeparam name="TKey">键类型</typeparam>
        /// <typeparam name="TValue">对象类型</typeparam>
        /// <param name="context"></param>
        /// <param name="func">获得对象的键的方法</param>
        /// <returns></returns>
        public static Dictionary<TKey, TValue> MapEntity<TKey, TValue>(this DbContext context, Func<TValue, TKey> func)
            where TValue : class
        {
            return context.Set<TValue>().ToDictionary(func);
        }

        /// <summary>
        /// 从数据库加载实体，并将实体的键和实体对象加载到一个映射中；
        /// </summary>
        /// <typeparam name="TKey">键类型</typeparam>
        /// <typeparam name="TValue">对象类型</typeparam>
        /// <param name="contextAccess"></param>
        /// <param name="func">获得对象的键的方法</param>
        /// <returns></returns>
        public static Dictionary<TKey, TValue> MapEntity<TKey, TValue>(this IDbContextGetter contextAccess, Func<TValue, TKey> func)
            where TValue : class
        {
           // using (var context = contextAccess.GetDbContext())
            {
                return contextAccess.GetDbContext().Set<TValue>().ToDictionary(func);
            }
        }
        #endregion

        #region 批量方法
        /// <summary>
        /// 批量异步插入实体；注意，修改了 context.Configuration 中的属性； 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="context"></param>
        /// <param name="entities"></param>
        /// <param name="dt">目的表对象;假如不为SQLSERVER数据库，则可以为 null; </param>
        /// <param name="destTableName">目的表名称，如果为null,则去 entities中第一个元素的类型；</param>
        /// <param name="transaction">外部的事物对象，如果为空，则使用本地事物； </param>
        /// <returns></returns>
        public static Task<int> BatchInsertAsync<T>(this DbContext context, IList<T> entities,
            DataTable dt = null,
            string destTableName = null,
            System.Data.Common.DbTransaction transaction = null)
            where T : class
        {
            List<T> tList = entities.ToList(); 
            if (tList.Count == 0) return Task.Factory.StartNew<int>(() => 0);
            var conn = context.Database.GetDbConnection();
            if (conn is SqlConnection)
            {
                SqlBulkCopyOptions options = SqlBulkCopyOptions.Default;
                var trans = transaction as SqlTransaction;
                //if (transaction != null) options = SqlBulkCopyOptions.;
                SqlBulkCopy bulkCopy = new SqlBulkCopy(conn as SqlConnection, options, trans);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                bulkCopy.BatchSize = 100000;
                List<DataRow> rows = new List<DataRow>();
                tList.ForEach((a, index) =>
                {                    
                    if (destTableName == null)
                    {
                        destTableName = a.GetType().Name;
                    }
                    if (dt == null)
                    {
                        dt = context.ExecuteQuery("select * from " + destTableName + " where 1=0");
                    }
                    var row = dt.NewRow();
                    for (var col = 0; col < dt.Columns.Count; col++)
                    {
                        var colName = dt.Columns[col].ColumnName;
                        var field = a.GetProperty(colName);
                        if (field != null)
                            row[col] = field;
                    }
                    rows.Add(row);
                });
                bulkCopy.DestinationTableName = destTableName;
                Task<int> task = bulkCopy.WriteToServerAsync(rows.ToArray()).ContinueWith((atask) => tList.Count);
                return task;                 
            }
            else
            {
                //好慢， 改用那个 BulkInsertCopy 试试看 ；
                if (transaction!=null)
                     context.Database.UseTransaction(transaction);
                context.Configuration.ValidateOnSaveEnabled = false;
                context.Configuration.AutoDetectChangesEnabled = false;
                DbSet<T> set = context.Set<T>();
                set.AddRange(entities);
                return context.SaveChangesAsync();
            }
        }

        /// <summary>
        /// 批量异步插入实体；注意，修改了 context.Configuration 中的属性； 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="context"></param>
        /// <param name="tList"></param>
        /// <param name="dt">目的表对象;假如不为SQLSERVER数据库，则可以为 null; </param>
        /// <param name="destTableName">目的表名称，如果为null,则为 entities中第一个元素的类型；</param>
        /// <param name="transaction">外部的事物对象，如果为空，则使用本地事物； </param>
        /// <returns></returns>
        public static int BatchInsert<T>(this DbContext context, IList<T> tList,
            DataTable dt = null,
            string destTableName = null,
            System.Data.Common.DbTransaction transaction = null)
            where T : class
        {
            if (tList.Count == 0) return 0;
            var conn = context.Database.Connection;
            if (conn is SqlConnection)
            {
                SqlBulkCopyOptions options = SqlBulkCopyOptions.Default;
                var trans = transaction as SqlTransaction;
                //if (transaction != null) options = SqlBulkCopyOptions.;
                SqlBulkCopy bulkCopy = new SqlBulkCopy(conn as SqlConnection, options, trans);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                bulkCopy.BatchSize = 100000;
                List<DataRow> rows = new List<DataRow>();
                tList.ForEach((a, index) =>
                {
                    if (destTableName == null)
                    {
                        destTableName = a.GetType().Name;
                    }
                    if (dt == null)
                    {
                        dt = context.ExecuteQuery("select * from " + destTableName + " where 1=0");
                    }
                    var row = dt.NewRow();
                    for (var col = 0; col < dt.Columns.Count; col++)
                    {
                        var colName = dt.Columns[col].ColumnName;
                        var field = a.GetProperty(colName);
                        if (field != null)
                            row[col] = field;
                    }
                    rows.Add(row);
                });
                bulkCopy.DestinationTableName = destTableName;
                bulkCopy.WriteToServer(rows.ToArray());
                return tList.Count;
            }
            else
            {
                //好慢， 改用那个 BulkInsertCopy 试试看 ；
                if (transaction != null)
                    context.Database.UseTransaction(transaction);
                context.Configuration.ValidateOnSaveEnabled = false;
                context.Configuration.AutoDetectChangesEnabled = false;
                DbSet<T> set = context.Set<T>();
                set.AddRange(tList);
                return context.SaveChanges();
            }
        }

        #endregion

        #region 执行原生查询
        /// <summary>
        /// 创建  Command 对象； 
        /// </summary>
        /// <param name="context"></param>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        private static DbCommand CreateCommand(this DbContext context, string sql, object[] parameters = null)
        {
            var conn = context.Database.Connection;
            var command = conn.CreateCommand();
            command.Connection = conn;
            command.CommandTimeout = 0;
            command.CommandText = sql; 

            if (parameters != null && parameters.Length > 0)
            {
                var dbParameters = new DbParameter[parameters.Length];
                var parameterNames = new string[parameters.Length];
                var parameterSql = new string[parameters.Length];
                for (var i = 0; i < parameters.Length; i++)
                {
                    parameterNames[i] = string.Format(CultureInfo.InvariantCulture, "p{0}", i);
                    dbParameters[i] = command.CreateParameter();
                    dbParameters[i].ParameterName = parameterNames[i];
                    dbParameters[i].Value = parameters[i] ?? DBNull.Value;

                    // By default, we attempt to swap in a SQL Server friendly representation of the parameter.
                    // For other providers, users may write:
                    //
                    //      ExecuteStoreQuery("select * from xyz f where f.X = ?", 1);
                    //
                    // rather than:
                    //
                    //      ExecuteStoreQuery("select * from xyz f where f.X = {0}", 1);
                    parameterSql[i] = "@" + parameterNames[i];
                }                
                command.CommandText = string.Format(CultureInfo.InvariantCulture, command.CommandText, parameterSql);
                command.Parameters.AddRange(dbParameters); 
            }
            if (context.Database.CurrentTransaction != null)
            {
                command.Transaction = context.Database.CurrentTransaction.UnderlyingTransaction;
            }
            return command;
        }
        /// <summary>
        /// 执行查询,并返回查询结果表；
        /// </summary>
        /// <param name="context"></param>
        /// <param name="sql"></param>
        /// <param name="pars">查询参数；</param>
        /// <returns></returns>
        public static DataTable ExecuteQuery(this DbContext context, string sql ,params object[] pars)
        {
            return ExecuteQuery(context, sql, (cmd) =>
             {
                 return new System.Data.SqlClient.SqlDataAdapter((SqlCommand) cmd);
             }, pars);
        }


        /// <summary>
        /// 执行查询,并返回查询结果表；
        /// </summary>
        /// <param name="contextAccess"></param>
        /// <param name="sql"></param>
        /// <param name="pars">查询参数；</param>
        /// <returns></returns>
        public static DataTable ExecuteQuery(this IDbContextGetter contextAccess, string sql, object[] pars = null)
        {             
                return contextAccess.GetDbContext().ExecuteQuery(sql,pars);
        }



        /// <summary>
        /// 执行查询,并返回查询结果表；
        /// </summary>
        /// <param name="contextAccess"></param>
        /// <param name="sql"></param>
        /// <param name="adapterFunc">返回数据库适配器的函数；</param>
        ///  <param name="pars">查询参数；</param>
        /// <returns></returns>
        public static DataTable ExecuteQuery(this IDbContextGetter contextAccess, string sql, Func<IDbCommand, IDbDataAdapter> adapterFunc, object[] pars=null)
        {
          
                return contextAccess.GetDbContext().ExecuteQuery(sql, adapterFunc, pars);
            
        }
        /// <summary>
        /// 执行查询,并返回查询结果表；
        /// </summary>
        /// <param name="context"></param>
        /// <param name="sql"></param>
        /// <param name="adapterFunc">返回数据库适配器的函数；</param>
        /// <param name="pars">查询参数； </param>
        /// <returns></returns>
        public static DataTable ExecuteQuery(this DbContext context, string sql, Func<IDbCommand, IDbDataAdapter> adapterFunc, object[] pars = null)
        {
            try
            {
                var cmd = CreateCommand(context, sql, pars);                                
                IDbDataAdapter adap = adapterFunc(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                return ds.Tables[0];
            }
            finally
            {
            }
        }
        #endregion
        
        #region 执行更新
        /// <summary>
        /// 执行更新；
        /// </summary>
        /// <param name="contextAccess"></param>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static int ExecuteCommand(this DbContext contextAccess, string sql)
        {
             return contextAccess.Database.ExecuteSqlCommand(sql);            
        }
        /// <summary>
        /// 执行更新；
        /// </summary>
        /// <param name="contextAccess"></param>
        /// <param name="sql"></param>
        /// <param name="par">更新参数；</param>
        /// <returns></returns>
        public static int ExecuteCommand(this DbContext contextAccess, string sql, params object[] par)
        {
           return contextAccess.Database.ExecuteSqlCommand(sql, par);
        }

        /// <summary>
        /// 执行更新；
        /// </summary>
        /// <param name="contextAccess"></param>
        /// <param name="sql"></param>
        /// <param name="par">更新参数；</param>
        /// <returns></returns>
        public static int ExecuteCommand(this IDbContextGetter contextAccess, string sql, object[] par = null)
        {
                return contextAccess.GetDbContext().Database.ExecuteSqlCommand(sql, par);
        }
        #endregion

        #region 执行SQL实体查询
        /// <summary>
        /// 执行查询,并返回查询结果的第一条对象； 
        /// </summary>
        /// <param name="context"></param>
        /// <param name="sql"></param>
        /// <param name="par">查询参数；</param>
        /// <returns></returns>
        public static T ExecuteScala<T>(this DbContext context, string sql, object[] par = null)
        {
                return context.Database.SqlQuery<T>(sql, par).FirstOrDefault();
        }

        /// <summary>
        /// 执行查询,并返回查询结果的第一条对象； 
        /// </summary>
        /// <param name="contextAccess"></param>
        /// <param name="sql"></param>
        /// <param name="par">查询参数；</param>
        /// <returns></returns>
        public static T ExecuteScala<T>(this IDbContextGetter contextAccess, string sql, object[] par = null)
        {
              return contextAccess.GetDbContext().Database.SqlQuery<T>(sql, par).FirstOrDefault();
        }

        /// <summary>
        /// 执行查询,并返回查询结果对象列表；
        /// </summary>
        /// <param name="contextAccess"></param>
        /// <param name="sql"></param>
        /// <param name="par">查询参数；</param>
        /// <returns></returns>
        public static List<T> ExecuteQuery<T>(this IDbContextGetter contextAccess, string sql, object[] par = null)
        {
            if (par == null) par = new object[] { };
            return contextAccess.GetDbContext().Database.SqlQuery<T>(sql, par).ToList();
        }
        #endregion

        
        #region 执行原生查询并返回Reader
        /// <summary>
        /// 执行查询,并返回查询的一个Raader,因为表可能很大,使得无法Fill到DataTable中；
        /// </summary>
        /// <param name="contextAccess"></param>
        /// <param name="sql"></param>
        /// <param name="adapterFunc">返回数据库适配器的函数；</param>
        /// <returns></returns>
        public static IDataReader ExecuteReader(this IDbContextGetter contextAccess, string sql, Func<IDbCommand, IDbDataAdapter> adapterFunc)
        {
           // using (var context = contextAccess.GetDbContext())
            {
                return contextAccess.GetDbContext().ExecuteReader(sql, adapterFunc);
            }
        }
        /// <summary>
        /// 执行查询,并返回查询的一个Raader,因为表可能很大,使得无法Fill到DataTable中；
        /// </summary>
        /// <param name="context"></param>
        /// <param name="sql"></param>
        /// <param name="adapterFunc">返回数据库适配器的函数； </param>
        /// <param name="pars"></param>
        /// <returns></returns>
        public static IDataReader ExecuteReader(this DbContext context, string sql, Func<IDbCommand, IDbDataAdapter> adapterFunc, object[] pars=null)
        {
            try
            {
                var cmd = CreateCommand(context,sql, pars);
                cmd.CommandText = sql;                             
                IDbDataAdapter adap = adapterFunc(cmd);
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            finally
            {
            }
        }
        #endregion

        #region 对 DbContext 进行操作的方法

        /// <summary>
        /// 对实体进行给定的操作；并返回操作结果；
        /// </summary>
        /// <typeparam name="K"></typeparam>
        /// <param name="contextAccess"></param>        
        /// <param name="func"></param>
        public static K FunctionContext<K>(this IDbContextGetter contextAccess, Func<DbContext, K> func)
        {
          //  using (var context = contextAccess.GetDbContext())
            {
                return contextAccess.GetDbContext().FunctionContext<K>(func);
            } 
        }

        /// <summary>
        /// 对实体进行给定的操作；并返回操作结果；
        /// </summary>
        /// <typeparam name="K"></typeparam>
        /// <param name="context"></param>
        /// <param name="func"></param>
        public static K FunctionContext<K>(this DbContext context, Func<DbContext, K> func)
        {
             return func(context);
           
        }

        /// <summary>
        /// 对实体进行给定的操作；并返回操作结果；
        /// </summary>
        /// <param name="context"></param>
        /// <param name="action"></param>
        public static void ActionContext<T, K>(this IDbContextGetter context, Action<DbContext> action)
        {
           // using (var context = contextAccess.GetDbContext())
            {
                context.GetDbContext().ActionContext(action);
            }
        }

        /// <summary>
        /// 对实体进行给定的操作；并返回操作结果；
        /// </summary>
        /// <param name="context"></param> 
        /// <param name="action"></param>
        public static void ActionContext(this DbContext context, Action<DbContext> action)
        {
            action(context);
        }

        /// <summary>
        /// 对实体进行给定的操作；并返回操作结果；
        /// </summary>
        /// <param name="context"></param> 
        /// <param name="entity"></param>
        public static void AttachAndRemove<T>(this DbContext context, T entity)
            where T : class
        {
            if (entity == null) return; 
            var set = context.Set<T>();
            if (!context.ChangeTracker.Entries<T>().Any(a => a == entity))
            {
                set.Attach(entity);
            }
            set.Remove(entity);
        }
        #endregion


        /// <summary>
        /// 根据 id 拼凑的字符串对象，执行查询，查找到实体后，用给定函数进行操作得到字符串，最后合并字符串；
        /// </summary>
        /// <param name="context"></param>        
        /// <param name="ids"></param>
        /// <param name="combineFunc"></param>
        /// <param name="split"></param>
        /// <returns></returns>
        public static string SplitAndFindAndCombine<T>(this DbContext context, string ids, Func<T, string> combineFunc, char split = ',')
            where T : class
        {           
            if (String.IsNullOrEmpty(ids)) return null;
            var fieldArray = ids.Split(split);
            string result = "";
            DbSet<T> set = context.Set<T>();
            fieldArray.ForEach((afield) => result += "," + combineFunc(set.Find(new object[] { Convert.ToInt32(afield) })));
            return result.Substring(1);
        }

        /// <summary>
        /// 根据Id构建已经存在的实体，避免需要从数据库中查找，
        /// 注意，实体肯定是未改变的； 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="context"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public static T BuildExistsEntity<T>(this DbContext context, int id)
            where T : class, IId, new()
        {
            var exists = context.ChangeTracker.Entries<T>().FirstOrDefault((a) => a.Entity.Id == id);
            if (exists != null) return exists.Entity;
            var result = new T();
            result.Id = id;
            context.Entry<T>(result).State = EntityState.Unchanged;
            return result;
        }

        /// <summary>
        /// 批量移除满足条件的实体;
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="context"></param>
        /// <param name="func"></param>
        public static void RemoveRange<T>(this DbContext context, Func<T,bool> func)
            where T : class
        {
            var enumT = context.Set<T>().Where(func);
            context.Set<T>().RemoveRange(enumT);
        }

        // <summary>
        // 批量移除满足条件的实体;
        // </summary>
        // <typeparam name="T"></typeparam>
        // <param name="context"></param>
        // <param name="func"></param>
        /*public static void RemoveRange<T>(this DbSet<T> set, Func<T, bool> func)
            where T : class
        {
            var objectList = set.Where(func).ToList();
            set.RemoveRange(objectList);
        }*/

        /// <summary>
        /// 批量移除满足条件的实体;
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="set"></param>
        /// <param name="func"></param>
        public static void RemoveRange<T>(this DbSet<T> set, Expression<Func<T, bool>> func)
            where T : class
        {
            var objectList = set.Where(func).ToList();
            set.RemoveRange(objectList);
        }

        #region 用DbContext自带方法进行查找的方法

        /// <summary>
        /// 查找对象； 
        /// </summary>
        /// <typeparam name="K"></typeparam>
        /// <param name="context"></param>
        /// <param name="name">对象的名称；</param>
        /// <param name="createNew">如果没有查找到对象，是否创建新的对象， true-创建, false-不创建 ； </param>
        /// <param name="addToEntity">如果创建对象，是否将对象增加新创建的实体到DbContext中, true-增加, false-不增加; 
        ///     说明，只是增加到了 DbContext中，并不会真正保存到数据库直到调用 SaveChange才可能保存到数据库； 
        /// </param>
        /// <param name="onCreateAction">如果创建新对象，创建新对象后对对象进行的操作</param>
        /// <returns>数据库中的旧对象或者新创建的对象；</returns>
        public static K Where<K>(this DbContext context, string name, bool createNew = false, bool addToEntity = false,
            Action<K> onCreateAction = null)
            where K : class, IName, new()
        {
            return context.Where<K>((x) => x.Name == name, createNew, addToEntity, (y) =>
            {
                y.Name = name;
                if (onCreateAction != null) onCreateAction(y);
            });
        }

        /// <summary>
        /// 查找对象； 
        /// </summary>
        /// <typeparam name="K"></typeparam>
        /// <param name="context"></param>
        /// <param name="name">对象的名称；</param>
        /// <param name="createNew">如果没有查找到对象，是否创建新的对象， true-创建, false-不创建 ； </param>
        /// <param name="addToEntity">如果创建对象，是否将对象增加新创建的实体到DbContext中, true-增加, false-不增加; 
        ///     说明，只是增加到了 DbContext中，并不会真正保存到数据库直到调用 SaveChange才可能保存到数据库； 
        /// </param>
        /// <param name="onCreateAction">如果创建新对象，创建新对象后对对象进行的操作</param>
        /// <returns>数据库中的旧对象或者新创建的对象；</returns>
        public static K Where<K>(this IDbContextGetter context, string name, bool createNew = false, bool addToEntity = false,
            Action<K> onCreateAction = null)
            where K : class, IName, new()
        {
            return context.GetDbContext().Where<K>((x) => x.Name == name, createNew, addToEntity, (y) =>
            {
                y.Name = name;
                if (onCreateAction != null) onCreateAction(y);
            });
        }

        /// <summary>
        /// 查找对象； 
        /// </summary>
        /// <typeparam name="K"></typeparam>
        /// <param name="context"></param>
        /// <param name="predicate"></param>
        /// <param name="createNew">如果没有查找到对象，是否创建新的对象， true-创建, false-不创建 ； </param>
        /// <param name="addToEntity">如果创建对象，是否将对象增加新创建的实体到DbContext中, true-增加, false-不增加; 
        ///     说明，只是增加到了 DbContext中，并不会真正保存到数据库直到调用 SaveChange才可能保存到数据库； 
        /// </param>
        /// <param name="onCreateAction">如果创建新对象，创建新对象后对对象进行的操作</param>
        /// <returns>数据库中的旧对象或者新创建的对象；</returns>
        public static K Where<K>(this DbContext context, System.Linq.Expressions.Expression<Func<K, bool>> predicate, bool createNew = false, bool addToEntity = false,
            Action<K> onCreateAction = null)
            where K : class, new()
        {
            DbSet<K> set = context.Set<K>();
            var result = set.Where(predicate).FirstOrDefault();
            if (result == null && createNew)
            {
                result = new K();
                if (onCreateAction != null) onCreateAction(result);
                if (addToEntity) set.Add(result);
            }
            return result;
        }

        /// <summary>
        /// 查找对象； 
        /// </summary>
        /// <typeparam name="K"></typeparam>
        /// <param name="context"></param>
        /// <param name="predicate"></param>
        /// <param name="createNew">如果没有查找到对象，是否创建新的对象， true-创建, false-不创建 ； </param>
        /// <param name="addToEntity">如果创建对象，是否将对象增加新创建的实体到DbContext中, true-增加, false-不增加; 
        ///     说明，只是增加到了 DbContext中，并不会真正保存到数据库直到调用 SaveChange才可能保存到数据库； 
        /// </param>
        /// <param name="onCreateAction">如果创建新对象，创建新对象后对对象进行的操作</param>
        /// <returns>数据库中的旧对象或者新创建的对象；</returns>
        public static K Where<K>(this IDbContextGetter context, System.Linq.Expressions.Expression<Func<K, bool>> predicate, bool createNew = false, bool addToEntity = false,
            Action<K> onCreateAction = null)
            where K : class, new()
        {
            return context.GetDbContext().Where<K>(predicate, createNew, addToEntity);
        }

        /// <summary>
        /// 根据Guid查找对象； 
        /// </summary>
        /// <typeparam name="K"></typeparam>
        /// <param name="context"></param>
        /// <param name="guid"></param>
        /// <param name="createNew">如果没有查找到对象，是否创建新的对象， true-创建, false-不创建 ； </param>
        /// <param name="addToEntity">如果创建对象，是否将对象增加新创建的实体到DbContext中, true-增加, false-不增加; 
        ///     说明，只是增加到了 DbContext中，并不会真正保存到数据库直到调用 SaveChange才可能保存到数据库； 
        /// </param>
        /// <param name="onCreateAction">如果创建新对象，创建新对象后对对象进行的操作</param>
        /// <returns>数据库中的旧对象或者新创建的对象；</returns>
        public static K WhereGuid<K>(this DbContext context, string guid, bool createNew = false, bool addToEntity = false, Action<K> onCreateAction = null)
            where K : class, IGuid, new()
        {
            return context.Where<K>((x) => x.Guid == guid, createNew, addToEntity, onCreateAction);
        }

        /// <summary>
        /// 根据Guid查找对象； 
        /// </summary>
        /// <typeparam name="K"></typeparam>
        /// <param name="context"></param>
        /// <param name="guid"></param>
        /// <param name="createNew">如果没有查找到对象，是否创建新的对象， true-创建, false-不创建 ； </param>
        /// <param name="addToEntity">如果创建对象，是否将对象增加新创建的实体到DbContext中, true-增加, false-不增加; 
        ///     说明，只是增加到了 DbContext中，并不会真正保存到数据库直到调用 SaveChange才可能保存到数据库； 
        /// </param>
        /// <param name="onCreateAction">如果创建新对象，创建新对象后对对象进行的操作</param>
        /// <returns>数据库中的旧对象或者新创建的对象；</returns>
        public static K WhereGuid<K>(this IDbContextGetter context, string guid, bool createNew = false, bool addToEntity = false, Action<K> onCreateAction = null)
            where K : class, IGuid, new()
        {
            return context.GetDbContext().Where<K>((x) => x.Guid == guid, createNew, addToEntity, onCreateAction);
        }

        /// <summary>
        /// 根据Guid查找对象； 
        /// </summary>
        /// <typeparam name="K"></typeparam>
        /// <param name="context"></param>
        /// <param name="name"></param>
        /// <param name="createNew">如果没有查找到对象，是否创建新的对象， true-创建, false-不创建 ； </param>
        /// <param name="addToEntity">如果创建对象，是否将对象增加新创建的实体到DbContext中, true-增加, false-不增加; 
        ///     说明，只是增加到了 DbContext中，并不会真正保存到数据库直到调用 SaveChange才可能保存到数据库； 
        /// </param>
        /// <param name="onCreateAction">如果创建新对象，创建新对象后对对象进行的操作</param>
        /// <returns>数据库中的旧对象或者新创建的对象；</returns>
        public static K WhereName<K>(this IDbContextGetter context, string name, bool createNew = false, bool addToEntity = false, Action<K> onCreateAction = null)
            where K : class, IName, new()
        {
            return context.GetDbContext().Where<K>((x) => x.Name == name, createNew, addToEntity, onCreateAction);
        }

        /// <summary>
        /// 根据Guid查找对象； 
        /// </summary>
        /// <typeparam name="K"></typeparam>
        /// <param name="context"></param>
        /// <param name="id"></param>
        /// <param name="createNew">如果没有查找到对象，是否创建新的对象， true-创建, false-不创建 ； </param>
        /// <param name="addToEntity">如果创建对象，是否将对象增加新创建的实体到DbContext中, true-增加, false-不增加; 
        ///     说明，只是增加到了 DbContext中，并不会真正保存到数据库直到调用 SaveChange才可能保存到数据库； 
        /// </param>
        /// <param name="onCreateAction">如果创建新对象，创建新对象后对对象进行的操作</param>
        /// <returns>数据库中的旧对象或者新创建的对象；</returns>
        public static K WhereId<K>(this DbContext context, int id, bool createNew = false, bool addToEntity = false, 
            Action<K> onCreateAction = null)
            where K : class, IId, new()
        {
            return context.Where<K>((x) => x.Id == id, createNew, addToEntity);
        }

        /// <summary>
        /// 根据Guid查找对象； 
        /// </summary>
        /// <typeparam name="K"></typeparam>
        /// <param name="context"></param>
        /// <param name="id"></param>
        /// <param name="createNew">如果没有查找到对象，是否创建新的对象， true-创建, false-不创建 ； </param>
        /// <param name="addToEntity">如果创建对象，是否将对象增加新创建的实体到DbContext中, true-增加, false-不增加; 
        ///     说明，只是增加到了 DbContext中，并不会真正保存到数据库直到调用 SaveChange才可能保存到数据库； 
        /// </param>
        /// <param name="onCreateAction">如果创建新对象，创建新对象后对对象进行的操作</param>
        /// <returns>数据库中的旧对象或者新创建的对象；</returns>
        public static K WhereId<K>(this IDbContextGetter context, int id, bool createNew = false, bool addToEntity = false, Action<K> onCreateAction = null)
            where K : IdEntity, new()
        {
            return context.Where<K>((x) => x.Id == id, createNew, addToEntity);
        }

        /// <summary>
        /// 根据 id 查找对象； 
        /// </summary>
        /// <typeparam name="K"></typeparam>
        /// <param name="context"></param>
        /// <param name="ids"></param>        
        /// <returns>数据库中的旧对象或者新创建的对象；</returns>
        public static K[] WhereId<K>(this IDbContextGetter context, int[] ids)
            where K : IdEntity, new()
        {
            return context.GetDbContext().Set<K>().Where((k) => ids.Contains(k.Id)).ToArray();
        }

        private static IDictionary<Type, TypeEntityWithLastModifyDateTime> CacheObjectDict = 
                 new ConcurrentDictionary<Type, TypeEntityWithLastModifyDateTime>();

        class TypeEntityWithLastModifyDateTime             
        {
            public TypeEntityWithLastModifyDateTime()
            {

            }

            public DateTime? LastDateTime { get; set; }

            IDictionary<int, IdEntity> entityMap = new Dictionary<int, IdEntity>(); 

            public void AddRange<K>(IEnumerable<K> entityEnum)
                 where K : IdEntity, IModifyDatetimeEntity
            {
                foreach(var one in entityEnum)
                {
                    if (!LastDateTime.HasValue || LastDateTime < one.LastModifyDateTime)
                        LastDateTime = one.LastModifyDateTime;
                    entityMap[one.Id] = one;
                }
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="id"></param>
            /// <returns></returns>
            public IdEntity GetEntity(int id)
            {
                IdEntity value = null; 
                entityMap.TryGetValue(id, out value);
                return value;
            }
            
        }    
             
        /// <summary>
        /// 根据Id查找对象； 但请注意，对象将加载到内存的Cache中，因为此对象应该较少变动； 
        /// </summary>
        /// <typeparam name="K"></typeparam>
        /// <param name="context"></param>
        /// <param name="id"></param>
        /// <param name="createNew">如果没有查找到对象，是否创建新的对象， true-创建, false-不创建 ； </param>
        /// <param name="addToEntity">如果创建对象，是否将对象增加新创建的实体到DbContext中, true-增加, false-不增加; 
        ///     说明，只是增加到了 DbContext中，并不会真正保存到数据库直到调用 SaveChange才可能保存到数据库； 
        /// </param>
        /// <param name="onCreateAction">如果创建新对象，创建新对象后对对象进行的操作</param>
        /// <returns>数据库中的旧对象或者新创建的对象；</returns>
        public static K WhereCacheId<K>(this IDbContextGetter context, int id, bool createNew = false, bool addToEntity = false, Action<K> onCreateAction = null)
            where K : IdEntity, IModifyDatetimeEntity,  new()
        {
            var typeK =  typeof(K);
            TypeEntityWithLastModifyDateTime cache = null;
            if (CacheObjectDict.ContainsKey(typeK)) cache = CacheObjectDict[typeK];
            else
            {
                lock (CacheObjectDict)
                {
                    if (!CacheObjectDict.ContainsKey(typeK))
                    {
                        cache = new TypeEntityWithLastModifyDateTime();
                        CacheObjectDict[typeK] = cache; 
                    }
                }
            }
            var entity = cache.GetEntity(id);
            if (entity != null) return entity as K;
            else
            {
                lock (typeK)
                {
                    var entityList = context.GetDbContext().Set<K>().Where((a) =>  !cache.LastDateTime.HasValue || a.LastModifyDateTime > cache.LastDateTime.Value );
                    cache.AddRange(entityList);
                }
                return cache.GetEntity(id) as K;
            }            
        }

        /// <summary>
        /// 根据给定的 Guid字符串 寻找对应的 实体对象列表；
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="context"></param>
        /// <param name="guidArray"></param>
        /// <param name="notExistsGuid">guid 如果不存在于系统中，返回 不存在的 guid 拼接字符串; </param>
        /// <returns>实体对象列表</returns>
        public static List<T> FindAccordGuidArray<T>(this DbContext context, string[] guidArray, ref string notExistsGuid)
            where T : class, IGuid, new()
        {
            List<T> deviceList = new List<T>();
            StringBuilder nullGuid = new StringBuilder();
            guidArray.Any((guid) =>
            {
                T device = context.WhereGuid<T>(guid);
                if (device == null) nullGuid.Append(",").Append(guid);
                else deviceList.Add(device);
                return false;
            });
            if (nullGuid.Length > 0)
                notExistsGuid = nullGuid.ToString().Substring(1);
            return deviceList;
        }
        
        /// <summary>
        /// 根据给定的 Guid字符串 寻找对应的 实体对象列表；
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="context"></param>        
        /// <param name="guidArray"></param>
        /// <param name="notExistsGuid">guid 如果不存在于系统中，返回 不存在的 guid 拼接字符串; </param>
        /// <returns>实体对象列表</returns>
        public static List<T> FindAccordGuidArray<T>(this IDbContextGetter context,  string[] guidArray, ref string notExistsGuid)
            where T : class, IGuid, new()
        {
            return context.GetDbContext().FindAccordGuidArray<T>(guidArray, ref notExistsGuid);
        }

        /// <summary>
        /// 根据给定的 Guid字符串 寻找对应的 实体对象列表；
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="context"></param>        
        /// <param name="IdArray"></param>
        /// <returns>实体对象列表</returns>
        public static List<T> FindAccordIdArray<T>(this IDbContextGetter context, int[] IdArray)
            where T : class, IId, new()
        {
            return context.GetDbContext().FindAccordIdArray<T>(IdArray);
        }

        /// <summary>
        /// 根据给定的 Id 数组 寻找对应的 实体对象列表；
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="context"></param>
        /// <param name="IdArray"></param>
        /// <returns>IdArray</returns>
        public static List<T> FindAccordIdArray<T>(this DbContext context, int[] IdArray)
            where T : class, IId, new()
        {            
            List<T> deviceList = new List<T>();
            if (IdArray == null || IdArray.Length == 0) return deviceList;
            return context.Set<T>().Where((a) => IdArray.Contains(a.Id)).ToList(); ;           
        }

        /// <summary>
        /// 根据名称查询对象；如果查询不到，则插入对象；  
        /// 注意不会调用 SaveChanges 方法;
        /// </summary>
        /// <typeparam name="T">实体类型，必须是引用类型且实现IName接口</typeparam>
        /// <param name="context"></param>        
        /// <param name="tname">实体的名称</param>
        /// <param name="beforeInsert">在插入数据库之前进行的操作；</param>
        /// <returns></returns>
        public static T GetOrInsert<T>(this DbContext context, string tname, Action<T> beforeInsert = null)
            where T : class, IName, new()
        {
            var set = context.Set<T>();
            var obj = set.Where((a) => a.Name == tname).FirstOrDefault();
            if (obj == null)
            {
                obj = new T();
                obj.Name = tname;
                if (beforeInsert != null) beforeInsert(obj);
                set.Add(obj);
            }
            return obj;
        }

        /// <summary>
        /// 根据名称查询对象；如果查询不到，则插入对象；  
        /// </summary>
        /// <typeparam name="T">实体类型，必须是引用类型且实现IName接口</typeparam>
        /// <param name="context"></param>        
        /// <param name="tname">实体的名称</param>
        /// <param name="beforeInsert">在插入数据库之前进行的操作；</param>
        /// <returns></returns>
        public static T GetOrInsert<T>(this IDbContextGetter context, string tname, Action<T> beforeInsert = null)
            where T : class, IName, new()
        {
            return context.GetDbContext().GetOrInsert<T>(tname, beforeInsert); 
        }
        #endregion

        #region 

        /// <summary>
        /// 创建新的Context 或者使用给定的 Context,执行操作; 
        /// 如果需要创建新的 Context 时，会调用 initiateAction 对 新创建的Context进行初始化操作, 会在操作完成后释放新创建的Context
        /// </summary>
        /// <param name="contextAction"></param>
        /// <param name="inputContext"></param>
        /// <param name="initiateAction">创建 Context 的实例后的初始化动作, 注意，只有在创建时才会进行初始化动作;</param>
        public static void ActionContext<T>(Action<T> contextAction, Action<T> initiateAction, T inputContext = null)
            where T : DbContext, new()
        {
            FuncContext(ObjectExtension.ToFunc(contextAction), null, inputContext);
        }

        /// <summary>
        /// 不锁定任何表进行数据库操作;
        /// 创建新的Context 或者使用给定的 Context,执行操作; 
        /// 如果需要创建新的 Context 时，会调用 initiateAction 对 新创建的Context进行初始化操作, 会在操作完成后释放新创建的Context
        /// </summary>
        /// <param name="contextAction"></param>
        /// <param name="inputContext"></param>
        /// <param name="initiateAction">创建 Context 的实例后的初始化动作, 注意，只有在创建时才会进行初始化动作;</param>
        public static void ActionContextWithoutLock<T>(Action<T> contextAction, Action<T> initiateAction, T inputContext = null)
            where T : DbContext, new()
        {
            FuncContextWithoutLock(ObjectExtension.ToFunc(contextAction), null, inputContext);
        }

        /// <summary>
        /// 创建新的Context 或者使用给定的 Context,带事物执行操作; 
        /// 如果需要创建新的 Context 时，会调用 initiateAction 对 新创建的Context进行初始化操作, 会在操作完成后释放新创建的Context
        /// </summary>
        /// <param name="contextAction"></param>
        /// <param name="initiateAction"></param>
        /// <param name="inputContext">创建 Context 的实例后的初始化动作, 注意，只有在创建时才会进行初始化动作;</param>
        public static void ActionContextWithTransaction<T>(Action<T> contextAction, Action<T> initiateAction, T inputContext)
            where T : DbContext, new()
        {
            FuncContextWithTransaction(ObjectExtension.ToFunc(contextAction), null, inputContext);
        }

        /// <summary>
        /// 不锁定任何表，利用  IsolationLevel.ReadUncommitted 事物
        /// https://www.cnblogs.com/littlewrong/p/8953481.html
        /// 创建新的Context 或者使用给定的 Context, 执行操作;  
        /// 如果需要创建新的 Context 时，会调用 initiateAction 对 新创建的Context进行初始化操作, 会在操作完成后释放新创建的Context
        /// </summary>
        /// <param name="contextAction"></param>
        /// <param name="initiateAction">创建 Context 的实例后的初始化动作, 注意，只有在创建时才会进行初始化动作;</param>
        /// <param name="inputContext"></param>
        public static T FuncContextWithoutLock<K, T>(Func<K, T> contextAction, Action<K> initiateAction, K inputContext = null)
            where K : DbContext, new()
        {
            Func<K, T> cFunc = (context) =>
            {
                if (context.Database.CurrentTransaction == null)  //未有事务，在事物中执行;
                {
                    context.Database.SetCommandTimeout(120); //两分钟;
                    using (var trans = context.Database.BeginTransaction(IsolationLevel.ReadUncommitted))
                    {
                        try
                        {
                            var result = contextAction(context);
                            trans.Commit();
                            return result;
                        }
                        catch (Exception exp)
                        {
                            trans.Rollback();
                            throw exp;
                        }
                    }
                }
                else
                {
                    return contextAction(context);
                }
            };
            return FuncContext(cFunc, initiateAction, inputContext);
        }

        /// <summary>
        /// 创建新的Context 或者使用给定的 Context, 执行操作;  
        /// 如果需要创建新的 Context 时，会调用 initiateAction 对 新创建的Context进行初始化操作, 会在操作完成后释放新创建的Context
        /// </summary>
        /// <param name="contextFunc"></param>
        /// <param name="initiateAction">创建 Context 的实例后的初始化动作, 注意，只有在创建时才会进行初始化动作;</param>
        /// <param name="inputContext"></param>
        public static TResult FuncContext<KContext,TResult>(Func<KContext, TResult> contextFunc, Action<KContext> initiateAction, KContext inputContext = null)
            where KContext : DbContext, new()
        {
            if (inputContext == null)
            {
                using (var context = new KContext())
                {
                    context.Database.CommandTimeout = 120; //两分钟;
                    initiateAction?.Invoke(context);
                    if (contextFunc != null)
                        return contextFunc(context);
                    return default(TResult);
                }
            }
            else return contextFunc(inputContext);
        }

        /// <summary>
        /// 创建新的Context 或者使用给定的 Context,带事物执行操作后释放;  
        /// 如果需要创建新的 Context 时，会调用 initiateAction 对 新创建的Context进行初始化操作, 会在操作完成后释放新创建的Context
        /// </summary>
        /// <param name="contextAction"></param>
        /// <param name="inputContext">传入的EhayContext</param>
        /// <param name="initiateAction">创建 T 的实例后的初始化动作, 注意，只有在创建时才会进行此操作;</param>
        public static T FuncContextWithTransaction<K, T>(Func<K, T> contextAction, Action<K> initiateAction, K inputContext)
             where K : DbContext, new()
        {
            Func<K, T> cFunc = (context) =>
            {
                if (context.Database.CurrentTransaction == null)  //未有事务，在事物中执行;
                {
                    context.Database.CommandTimeout = 120; //两分钟;
                    using (var trans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            var result = contextAction(context);
                            trans.Commit();
                            return result;
                        }
                        catch (Exception exp)
                        {
                            trans.Rollback();
                            throw exp;
                        }
                    }
                }
                else
                {
                    return contextAction(context);
                }
            };
            return FuncContext(cFunc, initiateAction, inputContext);
        }

        #endregion


        #region 

        /// <summary>
        /// 创建新的Context 或者使用给定的 Context,执行操作; 
        /// 如果需要创建新的 Context 时，会调用 initiateAction 对 新创建的Context进行初始化操作, 会在操作完成后释放新创建的Context
        /// </summary>
        /// <param name="contextAction"></param>
        /// <param name="inputContext"></param>
        /// <param name="initiateAction">创建 Context 的实例后的初始化动作, 注意，只有在创建时才会进行初始化动作;</param>
        public static async void AsyncActionContext<T>(Action<T> contextAction, Action<T> initiateAction, T inputContext = null)
            where T : DbContext, new()
        {
            await AsyncFuncContext(ObjectExtension.ToFunc(contextAction), null, inputContext);
        }

        /// <summary>
        /// 创建新的Context 或者使用给定的 Context,带事物执行操作; 
        /// 如果需要创建新的 Context 时，会调用 initiateAction 对 新创建的Context进行初始化操作, 会在操作完成后释放新创建的Context
        /// </summary>
        /// <param name="contextAction"></param>
        /// <param name="initiateAction"></param>
        /// <param name="inputContext">创建 Context 的实例后的初始化动作, 注意，只有在创建时才会进行初始化动作;</param>
        public static async void AsyncActionContextWithTransaction<T>(Action<T> contextAction, Action<T> initiateAction, T inputContext)
            where T : DbContext, new()
        {
           await AsyncFuncContextWithTransaction(ObjectExtension.ToFunc(contextAction), null, inputContext);
        }

        /// <summary>
        /// 创建新的Context 或者使用给定的 Context, 执行操作;  
        /// 如果需要创建新的 Context 时，会调用 initiateAction 对 新创建的Context进行初始化操作, 会在操作完成后释放新创建的Context
        /// </summary>
        /// <param name="contextFunc"></param>
        /// <param name="initiateAction">创建 Context 的实例后的初始化动作, 注意，只有在创建时才会进行初始化动作;</param>
        /// <param name="inputContext"></param>
        public static async Task<T> AsyncFuncContext<K, T>(Func<K, T> contextFunc, Action<K> initiateAction, K inputContext = null)
            where K : DbContext, new()
        {
            if (inputContext == null)
            {
                return await Task.Run<T>(() =>
                {
                    using (var context = new K())
                    {
                        context.Database.CommandTimeout = 120; //两分钟;
                        initiateAction?.Invoke(context);
                        return contextFunc(context);
                    };
                });
            }
            else return await Task.Run<T>(() =>  contextFunc(inputContext));
        }

        /// <summary>
        /// 创建新的Context 或者使用给定的 Context,带事物执行操作后释放;  
        /// 如果需要创建新的 Context 时，会调用 initiateAction 对 新创建的Context进行初始化操作, 会在操作完成后释放新创建的Context
        /// </summary>
        /// <param name="contextAction"></param>
        /// <param name="inputContext">传入的EhayContext</param>
        /// <param name="initiateAction">创建 T 的实例后的初始化动作, 注意，只有在创建时才会进行此操作;</param>
        public static async Task<T> AsyncFuncContextWithTransaction<K, T>(Func<K, T> contextAction, Action<K> initiateAction, K inputContext)
             where K : DbContext, new()
        {
            Func<K, T> cFunc = (context) =>
            {
                if (context.Database.CurrentTransaction == null)  //未有事务，在事物中执行;
                {
                    context.Database.CommandTimeout = 120; //两分钟;
                    using (var trans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            var result = contextAction(context);
                            trans.Commit();
                            return result;
                        }
                        catch (Exception exp)
                        {
                            trans.Rollback();
                            throw exp;
                        }
                    }
                }
                else
                {
                    return contextAction(context);
                }
            };
            return await AsyncFuncContext(cFunc, initiateAction, inputContext);
        }

        #endregion
    }
}
