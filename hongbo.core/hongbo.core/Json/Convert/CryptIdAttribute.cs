using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.Json
{
    /// <summary>
    /// 加密的Id或者Id数组标注，带有此标注的 属性 将在使用 IgnoreTypeScriptResolver 进行 Json 序列/反序列话时，被加密/解密传输;
    /// </summary>
    public class CryptIdAttribute : Attribute
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public CryptIdAttribute(): base() { }
        
        /// <summary>
        /// 加密的类型,为null时将从属性所归属类型中外键指向此属性的属性的类型;
        /// </summary>
        public Type CryptType { get; set; }    
    }

    
}
