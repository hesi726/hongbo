using hongbao.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.EntityExtension
{
    /// <summary>
    /// LabelAndValue -- 
    /// 有2个属性， label 和 value; label 和 value 都是字符串类型;
    /// 用于客户端的绑定
    /// </summary>
    public class LabelAndValue
    {
        /// <summary>
        /// label
        /// </summary>
        [NotNull]
        public string label { get; set; }

        /// <summary>
        /// value
        /// </summary>
        [NotNull]
        public string value { get; set; }

        /// <summary>
        /// 字段详细说明;
        /// </summary>
        public string desc { get; set; }
    }

    /// <summary>
    /// 有2个属性， label 和 value; value 为数值类型;传输到客户端时不加密;
    /// 用于客户端的绑定
    /// </summary>
    public class LabelAndIntValue
    {
        /// <summary>
        /// label
        /// </summary>
        [NotNull]
        public string label { get; set; }

        /// <summary>
        /// value
        /// </summary>
        [NotNull]
        public int value { get; set; }

        /// <summary>
        /// 字段详细说明;
        /// </summary>
        public string desc { get; set; }
    }

    ///// <summary>
    ///// LabelAndValue -- 
    ///// 有2个属性， label 和 value;
    ///// 用于客户端的绑定
    ///// </summary>
    //public class LabelAndValue<T>        
    //{
    //    /// <summary>
    //    /// label
    //    /// </summary>
    //    public string label { get; set; }

    //    /// <summary>
    //    /// value
    //    /// </summary>
    //    [CryptId()]
    //    public string value { get; set; }
    //}
}
