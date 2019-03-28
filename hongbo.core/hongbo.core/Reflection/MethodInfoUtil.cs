using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.Reflection
{
    /// <summary>
    /// MethodInfo 的工具类;
    /// </summary>
    public static class MethodInfoUtil
    {
        /// <summary>
        /// 判断2个方法是否具有相同的参数;
        /// </summary>
        /// <param name="amethod"></param>
        /// <param name="bmethod"></param>
        /// <returns></returns>
        public static bool HasSameMethodParameter(MethodInfo amethod, MethodInfo bmethod)
        {
            var parameters = amethod.GetParameters().Union(new[] { amethod.ReturnParameter })
                    .Zip(bmethod.GetParameters().Union(new[] { bmethod.ReturnParameter }), (a, b) => new {
                        PassedIn = a.ParameterType,
                        Reflected = b.ParameterType
                    }).ToList();
            if (parameters.All(p => p.PassedIn == p.Reflected)) return true;
            return false;
        }
    }
}
