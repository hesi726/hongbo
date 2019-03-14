using hongbao.Json;
using hongbao.SecurityExtension;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.EntityExtension
{

    /// <summary>
    /// 
    /// </summary>
    public class INullbaleIdAndXid
    {

        /// <summary>
        /// 实体的唯一Id; 
        /// </summary>
        [TypeScriptIgnore]
        public int? Id { get; set; }

        private string _xid;
        private int? _id;
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
                    _xid = SecurityUtil.CryptIdInGuid(Id, ObjectContext.GetObjectType(this.GetType()));
                }
                return _xid;
            }
            set
            {
                if (string.IsNullOrEmpty(value)) return;
                var innerId = SecurityUtil.DecryptIdInGuid(value, ObjectContext.GetObjectType(this.GetType()));
                if (innerId >= 0) this.Id = innerId;
            }
        }

    }
}
