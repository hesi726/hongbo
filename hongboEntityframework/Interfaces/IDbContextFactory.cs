using System;
using System.Collections.Generic;

#if NETCOREAPP2_2
using Microsoft.EntityFrameworkCore;
#else
using System.Data.Entity;
#endif
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.EntityExtension
{
    /// <summary>
    /// 获取 DbContext对象的工厂接口；
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IDbContextFactory<T>
          where T : DbContext
    {       
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
            T GetDbContext();     
    }
}
