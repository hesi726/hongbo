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
    /// 实体变动时还记录历史变动信息;
    /// </summary>
    public interface IRecordHistory
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        List<object> HistoryRecord(DbContext context);
    }
}
