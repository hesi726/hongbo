using hongbao.privileges;
using System;
using System.Collections.Generic;
using System.Text;

namespace hongboPrivilege.Test
{
    /// <summary>
    /// 默认的根据参数名称解析类型的类：总是返回 typeof(User);
    /// </summary>
    public class DefaultParceAuthenTypeAccordParameterName : IParceAuthenTypeAccordParameterName
    {
        public Type ParceAuthenTypeAccordParameterName(string parameterName)
        {
            return typeof(User);
        }
    }
}
