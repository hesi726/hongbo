using System.Data.Common;
using System.Collections.Generic;
#if NETCOREAPP2_2
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using DbRawSqlQuery = System.Linq.IQueryable;
#else
using System.Data.Entity;
using DatabaseFacade = System.Data.Entity.Database;
using System.Data.Entity.Infrastructure;
#endif

namespace hongbo.EntityExtension
{
    /// <summary>
    /// DatabaseFascade 的扩展类
    /// </summary>
    public static class DatabaseUtil
    {
#if NET472
        /// <summary>
        /// 秒数;
        /// </summary>
        /// <param name="databaseFacade"></param>
        /// <param name="commandTimeout">秒为单位;</param>
        public static void SetCommandTimeout(this DatabaseFacade databaseFacade, int commandTimeout)
        {
            databaseFacade.CommandTimeout = commandTimeout;
        }

        /// <summary>
        /// 获取数据库连接;
        /// </summary>
        /// <param name="databaseFacade"></param>
        /// <returns></returns>
        public static DbConnection GetDbConnection(this DatabaseFacade databaseFacade)
        {
            return databaseFacade.Connection;
        }
#endif

#if NETCOREAPP2_2
        /// <summary>
        /// 使用给定的参数执行给定的查询;
        /// .Net472 下类型为 DbRawSqlQuery
        /// .coreapp 下类型为 IQueryable, 
        /// 使用2者向上的公共类型 IEnumerable
        /// </summary>
        public static IEnumerable<T> SqlQuery<T>(this DatabaseFacade database, string sql, params object[] parameters) 
            where T : class
        {
            using (var db2 = new ContextForQueryType<T>(database.GetDbConnection()))
            {
                return db2.Query<T>().FromSql(sql, parameters);
            }

        }

        /// <summary>
        /// 内部类，继承子 DbContext 并且封装 DbConnection， 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        private class ContextForQueryType<T> : DbContext where T : class
        {
            private readonly DbConnection connection;

            /// <summary>
            /// 构造函数
            /// </summary>
            /// <param name="connection"></param>
            public ContextForQueryType(DbConnection connection)
            {
                this.connection = connection;
            }

            /// <summary>
            /// 覆盖 DbContext 的 OnConfiguring 函数;
            /// </summary>
            /// <param name="optionsBuilder"></param>
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                // switch on the connection type name to enable support multiple providers
                // var name = con.GetType().Name;
                optionsBuilder.UseSqlServer(connection, options => options.EnableRetryOnFailure());

                base.OnConfiguring(optionsBuilder);
            }

            /// <summary>
            /// 覆盖 DbContext 的 OnModelCreating 函数， 增加 Query
            /// https://docs.microsoft.com/en-us/ef/core/modeling/query-types
            /// </summary>
            /// <param name="modelBuilder"></param>
            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Query<T>();  //增加 QueryType
                base.OnModelCreating(modelBuilder);
            }
        }
#endif
    }
}
