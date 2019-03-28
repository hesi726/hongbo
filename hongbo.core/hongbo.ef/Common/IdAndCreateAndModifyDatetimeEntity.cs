using System;
using System.ComponentModel;

namespace hongbao.EntityExtension
{
    /// <summary>>
    /// 带有创建时间和 最后修改时间的 Id实体类；
    /// 注意，这个最后修改时间并不会自动设定，所以，你需要手工设定； 
    /// </summary>
    public class IdAndCreateAndModifyDatetimeEntity : IdAndModifyDatetimeEntity, ICreateDateTime
    {
        /// <summary>
        /// 构造函数，设置 创建时间 为当前时间； 
        /// </summary>
        public IdAndCreateAndModifyDatetimeEntity()
        {
            CreateDateTime = DateTime.Now;
            //LastModifyDateTime = DateTime.Now; 
        }
        /// <summary>
        /// 创建时间
        /// </summary>
        [DisplayName("创建时间")]
        public DateTime CreateDateTime { get; set; }

        #region 
        /// <summary>
        /// 复制对象属性到另外一个对象; 
        /// </summary>
        /// <param name="dest"></param>
        public void Copy(IdAndCreateAndModifyDatetimeEntity dest)
        {
            base.Copy(dest);
            dest.CreateDateTime = CreateDateTime;
        }
        #endregion 
    }
}
