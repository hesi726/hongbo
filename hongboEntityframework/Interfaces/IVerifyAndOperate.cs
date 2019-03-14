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
    /// 验证和操作数据的接口
    /// 1. 使用  DbContext 调用 Verify 方法
    /// 2. 调用 BeforeOperateDatabase 方法 ( 无 DbContext )
    /// 3. 启动事物
    /// 3.1. 使用  DbContext 调用 OperateDatabase 方法
    /// 4.2. 使用  DbContext 调用 AfterOperateDatabase 方法 
    /// 4. 提交事物
    /// 5. 调用 BeforeOperateDatabase 方法 ( 无 DbContext )
    /// 6. 返回 3.1 不中返回的结果;
    /// </summary>
    public interface IVerifyAndOperate<TDbContext>
        where TDbContext : DbContext
    {
        /// <summary>
        /// 数据验证,注意数据验证和后面的数据库不是使用同一个 DbContext
        /// </summary>
        /// <param name="context"></param>
        void Verify(TDbContext context);

        /// <summary>
        /// 操作数据之前的接口，在运行 OperateDatabase 之前调用;
        /// </summary>
        void BeforeOperateDatabase();

        /// <summary>
        /// 操作数据库,将在事物中执行;
        /// </summary>
        /// <param name="context"></param>
        (bool success, string tipOrErrors, object createdOrEditedEntity) OperateDatabase(TDbContext context);

        /// <summary>
        /// 在运行 OperateDatabase 之后调用;
        /// 和 OperateDatabase 方法同一个 事物中 执行; 
        /// </summary>
        /// <param name="context"></param>
        void AfterOperateDatabase(TDbContext context);

        /// <summary>
        /// 操作数据之后的接口，在数据库操作完成之后调用;
        /// </summary>
        void AfterOperateDatabase();
    }
}


