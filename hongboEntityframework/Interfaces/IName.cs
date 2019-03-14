using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.EntityExtension
{
    /// <summary>
    /// 获取Name属性的接口； 
    /// </summary>
    public interface IName
    {
        /// <summary>
        /// 实体名称
        /// </summary>
        string Name { get; set; }
    }

    /// <summary>
    /// 删除接口的扩展方法;
    /// </summary>
    public static class INameExtension
    {
        /// <summary>
        /// 将IDelete接口的属性复制到另外一个项目中;
        /// </summary>
        /// <param name="src"></param>
        /// <param name="dest"></param>
        public static void Copy(this IName src, IName dest)
        {
            dest.Name = src.Name;
        }
    }
}
