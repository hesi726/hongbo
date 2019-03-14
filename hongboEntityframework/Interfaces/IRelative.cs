using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#if NETCOREAPP2_2
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
#else
using System.Data.Entity;
using EntityEntry=System.Data.Entity.Infrastructure.DbEntityEntry;
#endif

namespace hongbao.EntityExtension
{
    /// <summary>
    /// 操作某1个实体时，可能会对相应的实体进行修改;
    /// </summary>
    public interface IRelative
    {
        /// <summary>
        /// 实体变更时候可能会需要处理关联实体;
        /// </summary>
        /// <param name="dbContext"></param>
        /// <param name="entity"></param>
        void OperateRelative(DbContext dbContext, EntityEntry entity);
    }

}
