using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hongbao.Vue.Attributes;
using StackExchange.Redis;
#if NETCOREAPP2_2
using Toolbelt.ComponentModel.DataAnnotations.Schema;
#endif

namespace hongbao.EntityExtension
{

    /// <summary>
    /// 带有GUID字段 和 创建时间 和 最后修改时间的 Id实体类；
    /// 如果子类实现 ICacheable, ICacheRelatable 两个接口;
    /// 保存到缓存时，还将序列化名称\Guid到换成中，例如, [EH_City:广州市=1,EH_City:agasdgasdg=1]
    /// 注意， Name 为唯一索引,默认下序列化时将写入 [EH_DeviceInfo:Name:1234124] 之类到 Cache;
    /// 最后修改时间并不会自动设定，所以，你需要手工设定；或者和AbstractController 结合起来调用起 SaveChanges方法；
    /// </summary>
    public class IdAndGuidAndNameAndCreateDatetimeAndModifyDatetimeEntity : IdAndGuidAndCreateDatetimeAndModifyDatetimeEntity,
         IName
    {       
        /// <summary>
        /// 名称，默认为 varchar(250) 长度;
        /// 或者和AbstractController 结合起来调用起 SaveChanges方法;
        /// </summary>
        [StringLength(250)]
        [Required]
        [Index(IsUnique = true)]
        [PropertyAutoAll(label ="名称", serial = 0)]
        public virtual string Name { get; set; }

        #region 
        /// <summary>
        /// 复制对象属性到另外一个对象; 
        /// </summary>
        /// <param name="dest"></param>
        public void Copy(IdAndGuidAndNameAndCreateDatetimeAndModifyDatetimeEntity dest)
        {
            base.Copy( dest);
            dest.Name = Name;
        }

        #endregion 
        
        /// <summary>
        /// 获取需要缓存的其他键以及Value;添加 Name - Id  的 KeyValue
        /// </summary>
        /// <returns></returns>
        public override List<(string key, RedisValue value)> GetOtherKeyAndValue()
        {
            return AddAppenxKeyAndIdPair(base.GetOtherKeyAndValue(), this.Name);
        }


    }
}
