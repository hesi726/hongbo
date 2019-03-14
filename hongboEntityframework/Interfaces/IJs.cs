using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace hongbao.EntityExtension
{
    /// <summary>
    /// 是否需要产生客户端的js内容：
    /// </summary>
    public interface IJs
    {
        /// <summary>
        /// 产生js内容;
        /// </summary>
        /// <param name="sb"></param>
        void WriteWebClient(List<string> sb);
    }
}