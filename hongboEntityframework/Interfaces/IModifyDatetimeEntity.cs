using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.EntityExtension
{
    /// <summary>
    /// 带有最后修改时间的 Id实体 接口； 
    /// 注意，这个最后修改时间并不会自动设定，所以，你需要手工设定；
    /// </summary>
    public interface IModifyDatetimeEntity
    {
        /// <summary>
        /// 最后修改时间，数据库修改记录时，需要手工修改此字段数据才会同步到缓存中;
        /// 其他情况下，需要手工设定；
        /// </summary>
        DateTime LastModifyDateTime { get; set; }
        
       
    }
}
