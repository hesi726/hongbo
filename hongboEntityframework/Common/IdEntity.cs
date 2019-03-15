using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using hongbao.SecurityExtension;
using hongbao.Json;
using StackExchange.Redis;
using Newtonsoft.Json;
using hongbao.Vue.Attributes;
using hongbao.CollectionExtension;
using hongbo.EntityExtension;
#if NETCOREAPP2_2
using Toolbelt.ComponentModel.DataAnnotations.Schema;
#endif
namespace hongbao.EntityExtension
{
   
    /// <summary>
    /// 带有 id 字段主键的 实体，基本上所有EF实体均为此类或者此类的继承类 ； 
    /// </summary>
    public class IdEntity : IIdAndXid
    {
        #region Id和Xid
        /// <summary>
        /// 实体的唯一Id; 
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //不会导出到客户端，但需要序列化时使用  IgnoreTypeScriptIgnoreResolver  解析类
        [TypeScriptIgnoreAttribute]
        public virtual int Id { get; set; }

        private string _xid = null;
        private int _id = -1;
        /// <summary>
        /// 根据本实例的Guid和 Id 计算而来,
        /// 对于相同的Id和Guid,总是产生相同的 CryptId;
        /// </summary>
        [NotMapped]
        [NotNull]
        public string Xid
        {
            get
            {
                if (!string.IsNullOrEmpty(_xid) && (_id == Id || Id == 0)) return _xid;
                if (Id == 0) return null;
                if (string.IsNullOrEmpty(_xid) || (_id != Id && Id > 0))
                {
                    _id = Id;
                    _xid = SecurityUtil.CryptIdInGuid(Id, EFUtil.GetObjectType(this.GetType()));
                }
                return _xid;
            }
            set
            {
                if (string.IsNullOrEmpty(value)) return;
                var innerId = SecurityUtil.DecryptIdInGuid(value, EFUtil.GetObjectType(this.GetType()));
                if (innerId >= 0) this.Id = innerId;
            }
        }
        #endregion

        #region ICachable  接口的默认实现方法,但本类不实现  ICachable 接口，主要是为了当子类实现了ICachable时，能够简化ICachable的实现代码;

        /// <summary>
        /// 获取缓存对象的键,返回诸如 EH_DeviceInfo:7335 之类的字符串;
        /// </summary>
        /// <returns></returns>
        public virtual string GetKey()
        {
            return EFUtil.GetCacheKey(this.GetType(), this.Id.ToString());
        }

        private static JsonSerializerSettings setting = new JsonSerializerSettings
        {
            ContractResolver = new IgnoreCacheContractResolver(),    //忽略不需要的缓存属性            
        };
        /// <summary>
        /// 获取对象序列化后的缓存内容
        /// </summary>
        /// <returns></returns>
        public virtual string Serialize()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, setting);
        }
        #endregion

        #region ICacheRelatable  接口的默认实现方法,但本类不实现  ICacheRelatable 接口，主要是为了当子类实现了ICacheRelatable时，能够简化ICacheRelatable的实现代码;
        ///// <summary>
        ///// 获取相关联的缓存对象,默认下返回null;
        ///// </summary>
        ///// <param name="cache"></param>
        ///// <returns></returns>
        //public virtual IEnumerable<ICacheable> GetRelateCacheObject(ICache cache)
        //{
        //    return null;
        //}

        /// <summary>
        /// 缓存对象时,可能还需要同时缓存其他的键和值;本方法获取可能需要同时缓存其他的键和值;
        /// 默认下返回 null
        /// </summary>
        /// <returns></returns>
        public virtual List<(string key, RedisValue value)> GetOtherKeyAndValue()
        {
            return null;
        }

        /// <summary>
        /// 添加键和id到 GetOtherKeyAndValue 函数返回的列表中,如果 GetOtherKeyAndValue 返回空，则创建新的列表;
        /// 例如，传入 00016，对于 EH_DeviceInfo, id=3303 类的实例，会把 
        /// (EH_DeviceInfo:00016, 3303) 记录到缓存;
        /// 并返回列表
        /// </summary>
        /// <param name="list">已有的键值列表</param>
        /// <param name="appenx">后缀列表，对于每一个后缀，都将添加 OA_User:Appenx[0]=Id,  OA_User:Appenx[1]=Id 形式的键值对;</param>
        /// <returns></returns>
        protected virtual List<(string key, RedisValue value)> AddAppenxKeyAndIdPair(List<(string key, RedisValue value)> list, 
            params string[] appenx)
        {
            var result = list ?? new List<(string key, RedisValue value)>();
            if (appenx != null)
            {
                appenx.ForEach((ap) =>
                {
                    result.Add((EFUtil.GetCacheKey(this.GetType(), ap), this.Id));
                });
            }
            return result;
        }

        ///// <summary>
        ///// 反序列化时,可能还需要反序列化关联的对象;本方法用于反序列化关联的对象,
        ///// 默认时不需要反序列化关联对象;
        ///// </summary>
        ///// <param name="cache"></param>
        //public virtual void DeserializeRelateCacheObject(ICache cache)
        //{
            
        //}
        #endregion

        

        //#region 为IRelateToUpper接口的 ParentIdFieldName 提供默认实现;
        ///// <summary>
        ///// 上级对象字段的 属性名称; 默认为 UpperId, 但是有可能不同;
        ///// 用于判断属性是否发生改变;
        ///// </summary>
        //[NotMapped]
        //public virtual string ParentIdFieldName => "UpperId";

        //#endregion

        #region Copy
        /// <summary>
        /// 复制对象属性到另外一个对象; 
        /// </summary>
        /// <param name="dest"></param>
        public virtual  void Copy(IId dest)
        {
            dest.Id = this.Id; 
        }

        #endregion

        #region  IJs接口的默认实现,但是本类不实现IJs接口;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="contentList"></param>
        public virtual void WriteWebClient(List<string> contentList)
        {
            contentList.Add("Id");
            contentList.Add(Id.ToString());
        }
        #endregion   
        
        /// <summary>
        /// 是否允许删除，默认下为 false; 即禁止删除;
        /// 表示此记录是否允许物理或者逻辑删除;
        /// </summary>
        [NotMapped]
        [PropertyDenyListAndEdit]
        public bool AllowDelete { get; set; }
    }
}
