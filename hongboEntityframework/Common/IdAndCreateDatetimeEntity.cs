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
    /// 带有创建时间的 Id实体类； 
    /// </summary>
    public class IdAndCreateDatetimeEntity : IdEntity, ICreateDateTime
    {
        /// <summary>
        /// 构造函数，设置 创建时间 为当前时间； 
        /// </summary>
        public IdAndCreateDatetimeEntity()
        {
            CreateDateTime = DateTime.Now;
        }

        /// <summary>
        /// 操作时间
        /// </summary>
        [Display(Name = "创建日期")]
        public DateTime CreateDateTime { get; set; }

        #region 
        /// <summary>
        /// 复制对象属性到另外一个对象; 
        /// </summary>
        /// <param name="dest"></param>
        public virtual void Copy(IdAndCreateDatetimeEntity dest)
        {
            base.Copy( dest);
            dest.CreateDateTime = CreateDateTime;
        }
        #endregion 
    }
}
