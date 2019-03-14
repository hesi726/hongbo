using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.EntityExtension
{
    /// <summary>
    /// 标记类，表示 Id 不会返回到客户端;
    /// 默认下 Id 将返回到客户端，所以你还需要手工修改类的定义,
    /// 重载 Id 属性 并添加 JsonIgnore 标记;
    /// 或者,对于一些常量的实体（例如，城市，地区 等等）可以标记此属性；
    /// </summary>
    public interface IIdJsonIgnore
    {
    }
}
