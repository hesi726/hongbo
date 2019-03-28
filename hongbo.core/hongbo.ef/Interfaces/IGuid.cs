using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.EntityExtension
{
    /// <summary>
    /// 获取或者设置 Guid 字段的接口；
    /// </summary>
    public interface IGuid // : IId
    {
        /// <summary>
        /// GUID 字段；
        /// </summary>
        [NotNull]
        string Guid { get; set;  }
    }
}
