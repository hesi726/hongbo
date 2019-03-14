using hongbao.Json;
using hongbao.SecurityExtension;
using hongbao.SystemExtension;
using Newtonsoft.Json;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
#if NETCOREAPP2_2
using Toolbelt.ComponentModel.DataAnnotations.Schema;
#endif

namespace hongbao.EntityExtension
{
    /// <summary>
    /// 带有GUID字段的 Id实体类； 说明，为节省空间， guid 字段将替换中间的 - 字符，
    /// </summary>
    public class IdAndGuidEntity : IdEntity, IGuid
    {
        /// <summary>
        /// 构造函数，设置 Guid 为一个新的Guid； 
        /// </summary>
        public IdAndGuidEntity() : base()
        {
            Guid = GuidUtil.NewGuid(); //   System.Guid.NewGuid().ToString().Replace("-", "");
        }

        /// <summary>
        /// 
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //不会导出到客户端，但需要序列化时使用  IgnoreTypeScriptIgnoreResolver  解析类
        [TypeScriptIgnore]  
        //[JsonIgnore]
        public override int Id { get; set; }

        

        /// <summary>
        /// GUID 字段，本字段将由机器随机产生，长度为32个字符，且具有唯一索引；
        /// </summary>
        [StringLength(46)]
        [Column(TypeName = "varchar")]
        [Index(IsUnique = true)]
        public virtual string Guid { get; set; }

#region 覆盖ISerializeCache的接口下的GetOtherKeyAndValue方法
        /// <summary>
        /// 会将如下类型的key 和 value 对写入到 redis 缓存
        /// EH_DeviceInfo:agasdgasdgasdgasdg=13312    
        /// 到缓存中，
        /// </summary>
        /// <returns></returns>
        public override List<(string key, RedisValue value)> GetOtherKeyAndValue()
        {
            return AddAppenxKeyAndIdPair(base.GetOtherKeyAndValue(), this.Guid);
        }
#endregion


#region 
        /// <summary>
        /// 复制对象属性到另外一个对象; 
        /// </summary>
        /// <param name="dest"></param>
        public  void Copy(IdAndGuidEntity dest)
        {
            base.Copy( dest);
            dest.Guid = Guid;
        }

#endregion

    }
}
