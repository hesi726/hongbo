using hongbao.Vue.Attributes;
using hongbao.Vue.ElementUi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.EntityExtension
{
    /// <summary>
    /// 带有GUID字段 和 创建时间的 Id实体类； 说明，为节省空间， guid 字段将替换中间的 - 字符，
    /// </summary>
    public class IdAndGuidAndCreateDatetimeEntity : IdAndGuidEntity, ICreateDateTime
    {
        /// <summary>
        /// 构造函数，设置 创建时间 为当前时间； 设置 Guid 为一个新的Guid； 
        /// </summary>
        public IdAndGuidAndCreateDatetimeEntity() : base()
        {
            CreateDateTime = DateTime.Now;
        }

        /// <summary>
        /// 实体创建时间；
        /// </summary>
        [DisplayName("创建时间")]
        [PropertyAutoFilter(label = "创建时间")]
        [PropertyAutoList(label = "创建时间")]
        public DateTime CreateDateTime { get; set; }

        #region 
        /// <summary>
        /// 复制对象属性到另外一个对象; 
        /// </summary>
        /// <param name="dest"></param>
        public void Copy(IdAndGuidAndCreateDatetimeEntity dest)
        {
            base.Copy( dest);
            dest.CreateDateTime = CreateDateTime;
        }

        #endregion 
    }
}
