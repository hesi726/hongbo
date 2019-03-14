using hongbao.SystemExtension;
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
    /// 带有GUID字段 和 创建时间 和 最后修改时间的 Id实体类；
    ///  说明，为节省空间， guid 字段将替换中间的 - 字符，
    /// 最后修改时间并不会自动设定，所以，你需要手工设定；或者和AbstractController 结合起来调用起 SaveChanges方法；
    /// </summary>
    public class IdAndGuidAndCreateDatetimeAndModifyDatetimeEntity : IdAndGuidAndCreateDatetimeEntity, IModifyDatetimeEntity
    {
        /// <summary>
        /// 构造函数，设置 创建时间 为当前时间； 设置 Guid 为一个新的Guid； 
        /// </summary>
        public IdAndGuidAndCreateDatetimeAndModifyDatetimeEntity() : base()
        {
           // CreateDateTime = DateTime.Now;
            LastModifyDateTime = DateTime.Now;
           // Guid = GuidUtil.NewGuid(); //   System.Guid.NewGuid().ToString().Replace("-", "");
        }

        /// <summary>
        /// 最后修改时间，注意，不允许为空， 这个最后修改时间并不会自动设定，所以，你需要手工设定；或者和AbstractController 结合起来调用起 SaveChanges方法；
        /// </summary>
        public DateTime LastModifyDateTime { get; set; }

        #region 
        /// <summary>
        /// 复制对象属性到另外一个对象; 
        /// </summary>
        /// <param name="dest"></param>
        public void Copy(IdAndGuidAndCreateDatetimeAndModifyDatetimeEntity dest)
        {
            base.Copy(dest);
            dest.LastModifyDateTime = LastModifyDateTime;
        }

        #endregion 
    }

    /// <summary>
    /// 
    /// </summary>
    public class IdAndGuidAndCreateDatetimeAndModifyDatetimeAndDeleteEntity : IdAndGuidAndCreateDatetimeAndModifyDatetimeEntity, IDelete
    {
        /// <summary>
        /// 
        /// </summary>
        public bool DeleteState { get; set ; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? DeleteDateTime { get ; set ; }
        /// <summary>
        /// 
        /// </summary>
        public int? DeleteUserId { get ; set; }

        #region 
        /// <summary>
        /// 复制对象属性到另外一个对象; 
        /// </summary>
        /// <param name="dest"></param>
        public virtual void Copy(IdAndGuidAndCreateDatetimeAndModifyDatetimeAndDeleteEntity dest)
        {
            base.Copy(dest);
            IDeleteExtension.CopyDelete(this, dest);
        }

        #endregion 
    }
}
