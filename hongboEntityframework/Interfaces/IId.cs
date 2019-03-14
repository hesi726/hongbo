using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.EntityExtension
{
    /// <summary>
    /// 获取或者设置 id 的接口； 
    /// </summary>
    public interface IId
    {
        /// <summary>
        /// 实体的唯一Id; 
        /// </summary>
        int Id { get; set; }
    }
}
