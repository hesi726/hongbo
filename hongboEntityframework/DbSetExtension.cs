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
    /// 
    /// </summary>
    public class DbSetExtension
    {
        /// <summary>
        /// 移走符合条件的项;
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="set"></param>
        /// <param name="func"></param>
        public void RemoveRange<T>(DbSet<T> set, Func<T,bool> func)
            where T : class
        {
            var ienum = set.Where(func).ToList();
            set.RemoveRange(ienum);
        }
    }
}
