#if NET472
using System.Web.Mvc;
#else
using Microsoft.AspNetCore.Mvc;
#endif
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.MvcExtension
{
    /// <summary>
    /// 操作结果类； 
    /// </summary>
    public class JsonOperateResult<T>  
    {
        /// <summary>
        /// 私有构造函数； 
        /// </summary>
        internal JsonOperateResult()
        {            
        }        



        /// <summary>
        /// 操作结果状态， 0-表示操作成功，&gt;0 表示操作失败； 
        /// </summary>
        public int Status { get; protected set; }

        /// <summary>
        /// 操作结果描述； 如果 Status=0, 则此字段为 null; 
        /// </summary>
        public string Desc { get; protected set; }

        /// <summary>
        /// 操作结果数据类； 
        /// </summary>
        public T Data { get; protected set; }

        /// <summary>
        /// 将 JsonOperateResult 隐式 转换为 JsonResult类； 
        /// </summary>
        /// <param name="operResult"></param>
        public static implicit operator JsonResult(JsonOperateResult<T> operResult)
        {
            var result = new JsonResult<T>(operResult);
            return result;
        }

        /// <summary>
        /// 将对象转换为 一个成功的  JsonOperateResult 对象； 
        /// </summary>
        /// <param name="Data"></param>
        /// <returns></returns>
        public static implicit operator JsonOperateResult<T> (T Data)
        {
            return new JsonOperateResult<T> { Data = Data };
        }

        /// <summary>
        /// 隐式转换回来； 
        /// </summary>
        /// <param name="operResult"></param>
        public static implicit operator T(JsonOperateResult<T> operResult)
        {
            return operResult.Data;
        }
    }

    /// <summary>
    /// JsonOperateResult 类； 
    /// </summary>
    public class JsonOperateResult : JsonOperateResult<object>
    {

    }
}
