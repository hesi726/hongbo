using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.privileges
{
    /// <summary>
    /// 需要验证传入参数的接口
    /// </summary>
    public interface IAuthenTypeAccordParameter
    {
        /// <summary>
        /// 输入参数名称(如果不为null,则根据HTTP请求获取此参数的值,并根据此值获取对应的类型,
        /// 并根据类型判断当前用户是否有权限访问;
        /// </summary>
        string InputParameterName { get;   }

        ///// <summary>
        ///// 输入参数类型(如果不为null,将优先使用此类型进行权限判断) 并根据此类型,并根据类型判断
        ///// 当前用户是否有权限访问;
        ///// </summary>
        //Type InputParameterType { get;  }

        /// <summary>
        /// 根据 InputParameterName 解析得到的类型应和此参数一致，不一致时，授权失败：权限验证失败;        
        /// </summary>
        Type InputParameterTypeMustBe { get;  }
    }
}
