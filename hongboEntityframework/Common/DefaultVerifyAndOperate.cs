using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#if NETCOREAPP2_2
using Microsoft.EntityFrameworkCore;
#else
using System.Data.Entity;
#endif

namespace hongbao.EntityExtension
{
    /// <summary>
    /// 抽象的类,实现 IVerifyAndOperate 接口
    /// </summary>
    public class DefaultVerifyAndOperate<TDbContext> : IVerifyAndOperate<TDbContext>
        where TDbContext : DbContext, new()
    {
        /// <summary>
        /// 构造函数,
        /// </summary>
        protected DefaultVerifyAndOperate()
        {

        }

        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public virtual void Verify(TDbContext context)
        {
        }
        /// <summary>
        /// 操作数据之前的接口，在运行 OperateDatabase 之前调用;
        /// </summary>
        public virtual void BeforeOperateDatabase()
        {
        }

        /// <summary>
        /// 操作数据库,将在事物中执行;
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public virtual (bool success, string tipOrErrors, object createdOrEditedEntity) OperateDatabase(TDbContext context)
        {
            return (true, null, null);
        }
        /// <summary>
        /// 操作数据之后的接口，在数据库操作完成之后调用;
        /// </summary>
        /// <param name="context"></param>
        public virtual void AfterOperateDatabase(TDbContext context)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public virtual void AfterOperateDatabase()
        {
        }


        /// <summary>
        /// 验证和操作数据的模板方法
        /// 1. 使用  DbContext 调用 Verify 方法
        /// 2. 调用 BeforeOperateDatabase 方法 ( 无 DbContext )
        /// 3. 启动事物
        /// 3.1. 使用  DbContext 调用 OperateDatabase 方法
        /// 4.2. 使用  DbContext 调用 AfterOperateDatabase 方法 
        /// 4. 提交事物
        /// 5. 调用 BeforeOperateDatabase 方法 ( 无 DbContext )
        /// 6. 返回 3.1 不中返回的结果;
        /// </summary>
        /// <param name="verify">IVerifyAndOperate 的实例</param>
        /// <param name="inputContextFunc">传入的构建inputContext 的Func, 不应该为 null; </param>
        public static (bool success, string tipOrError, object createdOrEditedEntity)  VerifyAndOperate(IVerifyAndOperate<TDbContext> verify, Func<TDbContext> inputContextFunc)
        {
            using (var xcontext = inputContextFunc())
            {
                DbContextExtension.ActionContext((context) =>
                {
                    verify.Verify(context);  // 验证;
                }, null, xcontext);
            }
            verify.BeforeOperateDatabase();
            (bool success, string tipOrError, object createdOrEditedEntity) result = (true, null, null);
            using (var xcontext = inputContextFunc())
            {
                DbContextExtension.ActionContextWithTransaction((context) =>
                {
                    result = verify.OperateDatabase(context);
                    context.SaveChanges();

                    verify.AfterOperateDatabase(context);
                    context.SaveChanges();
                }, null, xcontext);
            }
            verify.AfterOperateDatabase();
            return result;
        }
    }
}
