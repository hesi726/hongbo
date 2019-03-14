using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.EntityExtension
{


    /// <summary>
    /// 获取或者设置 id 的接口；
    /// 一个 Xid 作为 加密后的Id对象;
    /// Xid 将 根据实际类型的不同 以及 Id的不同 而变化;
    /// 但对于相同的 类型和Id,总是产生相同的 Xid;
    /// </summary>
    public interface IIdAndXid : IId
    {
        /// <summary>
        /// 加密后的Xid
        /// </summary>
        string Xid { get; set; }
    }
}
