using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#if NETCOREAPP2_2
using Microsoft.EntityFrameworkCore;
#else
using System.Data.Entity;
#endif
namespace hongbao.AsyncMessage
{
    /// <summary>
    /// 异步消息处理定义表，
    /// 使用时应该继承此类，继承子类的类应该对应到真实数据库的一个表;  
    /// 
    /// 例如你需要动态指定某一类型的消息需要使用哪一个程序集里面哪一个类的哪一个方法时有用；
    /// 消息可能会转码为给定的参数类型 或者 直接使用字符串类型；
    /// 如果定义有消息类型，则寻找具有相同参数类型的方法；
    /// 如果未指定消息类型，则寻找处理字符串的方法；
    /// </summary>
    public abstract class AbstractAsyncMessageHandleDefine
    {
        /// <summary>
     /// 记录 Id
     /// </summary>
        public virtual int Id { get; set; }

        /// <summary>
        /// 消息创建时间
        /// </summary>
        public virtual DateTime CreateDateTime { get; set; }

        /// <summary>
        /// 异步消息类型
        /// </summary>
        public int MessageType { get; set; }

        /// <summary>
        /// 程序集名称
        /// </summary>
        [StringLength(50)]
        public string AssemblyName { get; set; }

        /// <summary>
        /// 类名称
        /// </summary>
        [StringLength(50)]
        public string ClassName { get; set; }

        /// <summary>
        /// 方法名称
        /// </summary>
        [StringLength(50)]
        public string MethodName { get; set; }
        /// <summary>
        /// 处理方法的参数类型,如果为null,则使用查找具有字符串的方法;
        /// </summary>
        [StringLength(50)]
        public string ParameterType { get; set; }

        /// <summary>
        /// 是否线程安全，即消息处理无优先级： (例如，根据坐标解析地址时可以设为 true)
        /// </summary>
        public bool IsThreadSafe { get; set; }

       
    }


}
