using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.privileges
{
    /// <summary>
    /// 根据参数名称解析待判断授权的类型的接口;
    /// </summary>
    public interface IParceAuthenTypeAccordParameterName
    {
        /// <summary>
        /// 根据参数名称解析待判断授权的类型
        /// </summary>
        /// <param name="parameterName"></param>
        /// <returns></returns>
        Type ParceAuthenTypeAccordParameterName(string parameterName);
    }
}
