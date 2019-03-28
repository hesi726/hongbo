using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.AsyncMessage
{
    /// <summary>
    /// 消息的字段;
    /// 使用时应该继承此类，继承子类的类应该对应到真实数据库的一个表;    
    /// </summary>
    public abstract class AbstractAsyncMessage
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
        /// 
        /// </summary>
        public virtual int MessageType { get; set; }

        /// <summary>
        /// 消息内容,最大 32K;
        /// </summary>
        [StringLength(32000)]
        public virtual string MessageContent { get; set; }

        /// <summary>
        /// 消息生效时间，认为此时间后才处理此消息；
        /// </summary>
        DateTime ValidDateTime { get; set; }

        /// <summary>
        /// 消息失效时间,此时间过后不再处理此消息;
        /// </summary>
        DateTime? ExpireDateTime { get; set; }

        /// <summary>
        /// 处理次数
        /// </summary>
        public int HandleTimes { get; set; }

        /// <summary>
        /// 是否已经处理过了..
        /// </summary>
        public bool Handled { get; set; }
    }
}
