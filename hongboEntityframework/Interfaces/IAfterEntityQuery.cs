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
    /// 在实体查询之后的操作接口
    /// </summary>
    public interface IAfterEntityQuery
    {
        /// <summary>
        /// 实体查询之后，可能需要到序列化成Json时才访问某些字段，访问这些字段时，可能需要访问 DbContext,
        /// 但是这个时候可能 Context 已经释放，
        /// 此接口在 EntityQueryController 之中使用;
        /// </summary>
        void AfterEntityQuery(DbContext context);
    }
}
