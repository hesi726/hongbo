using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.Json.ContactResolve
{
    /// <summary>
    /// 
    /// </summary>
    internal interface ISerializingObject
    {
        /// <summary>
        /// 正在序列化的对象;
        /// </summary>
        object SerializingObject { get;  }
    }
}
