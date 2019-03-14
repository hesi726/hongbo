using hongbao.Vue.Attributes;
using hongbao.Vue.ElementUi;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#if NETCOREAPP2_2
using Toolbelt.ComponentModel.DataAnnotations.Schema;
#endif
namespace hongbao.EntityExtension
{
    /// <summary>
    /// 带有创建时间和Name(StringLength(50))的 Id实体类；
    /// 如果子类实现 ICacheable, ICacheRelatable 两个接口;
    /// 保存到缓存时，还将一并序列化名称到换成中，例如, [EH_City:广州市=1]
    /// </summary>
    public class IdAndNameAndCreateDatetimeEntity : IdAndCreateDatetimeEntity, IName
    {       
        /// <summary>
        /// 实体名称； 
        /// </summary>
        
        [StringLength(50)]
        [Required]
        [Index(IsUnique = true)]
        [Display(Name="名称")]
        [PropertyAutoAll(label = "名称")]
        public virtual string Name { get; set; }

        /// <summary>
        /// 获取还需要缓存的其他键，说明：此处会将 name 增加到 缓存，例如 : (EH_DeviceInfo:00016,3303)
        /// </summary>
        /// <returns></returns>
        public override List<(string key, RedisValue value)> GetOtherKeyAndValue()
        {
            return AddAppenxKeyAndIdPair(base.GetOtherKeyAndValue(), this.Name);
        }

#region 
        /// <summary>
        /// 复制对象属性到另外一个对象; 
        /// </summary>
        /// <param name="dest"></param>
        public void Copy(IdAndNameAndCreateDatetimeEntity dest)
        {
            base.Copy(dest);
            dest.Name = Name;
        }
#endregion

#region  IJs接口的默认实现,但是本类不实现IJs接口;
        /// <summary>
        /// 有Guid字段时，肯定使用的是Guid字段，而不是使用Id字段; 
        /// </summary>
        /// <param name="contentList"></param>
        public override void WriteWebClient(List<string> contentList)
        {
            base.WriteWebClient(contentList);
            contentList.Add("Name");
            contentList.Add(Name);
        }
#endregion
    }

   
}
