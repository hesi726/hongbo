using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.EntityExtension
{
    /// <summary>
    /// 带有创建时间和Name的 Id实体类； 
    /// 如果子类实现 ICacheable, ICacheRelatable 两个接口;
    /// 保存到缓存时，还将一并序列化名称到换成中，例如, [EH_City:广州市=1]
    /// </summary>
    public class IdAndNameAndCreateDatetimeAndModifyDateTimeEntity : IdAndNameAndCreateDatetimeEntity, IModifyDatetimeEntity
    {
        /// <summary>
        /// 构造函数，设置 创建时间 为当前时间； 
        /// </summary>
        public IdAndNameAndCreateDatetimeAndModifyDateTimeEntity() : base()
        {
            LastModifyDateTime = DateTime.Now;
        }

        /// <summary>
        /// 最后修改时间，注意，允许为空， 这个最后修改时间并不会自动设定，所以，你需要手工设定；或者和AbstractController 结合起来调用起 SaveChanges方法；
        /// </summary>
        public DateTime LastModifyDateTime { get; set; }

        #region 
        /// <summary>
        /// 复制对象属性到另外一个对象; 
        /// </summary>
        /// <param name="dest"></param>
        protected void Copy(IdAndNameAndCreateDatetimeAndModifyDateTimeEntity dest)
        {
            base.Copy( dest);
            dest.LastModifyDateTime = LastModifyDateTime;
        }
        #endregion 
    }
}
