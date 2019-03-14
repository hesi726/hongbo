using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.EntityExtension
{
    /// <summary>
    /// 记录删除信息的字段;
    /// </summary>
    public interface IDelete
    {
        /// <summary>
        /// 删除状态; true-表示已经删除,false-表示未删除;
        /// </summary>
        bool DeleteState { get; set; }

        /// <summary>
        /// 删除日期;
        /// </summary>
        DateTime? DeleteDateTime { get; set; }

        /// <summary>
        /// 删除用户;
        /// </summary>
        int? DeleteUserId { get; set; }

    }

    /// <summary>
    /// 记录审核信息的字段;
    /// </summary>
    public interface IAudit
    {
        /// <summary>
        /// 审核日期;
        /// </summary>
        DateTime? AuditDateTime { get; set; }

        /// <summary>
        /// 审核用户;
        /// </summary>
        int? AuditUserId { get; set; }

    }
    /// <summary>
    /// 删除接口的扩展方法;
    /// </summary>
    public static class IDeleteExtension
    {
        /// <summary>
        /// 实体是否已经删除了
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static bool IsDeleted(IId obj)
        {
            if (obj==null || !(obj is IDelete)) return false;
            return ((IDelete)obj).DeleteState;
        }

        /// <summary>
        /// 删除的字段;
        /// </summary>
        /// <param name="delete"></param>
        /// <param name="user"></param>
        public static void SetDeleteState(IDelete delete, IId user)
        {
            if (!delete.DeleteState)
            {
                delete.DeleteState = true;
                delete.DeleteUserId = user?.Id;
                delete.DeleteDateTime = DateTime.Now;
            }
        }

        /// <summary>
        /// 将IDelete接口的属性复制到另外一个项目中;
        /// </summary>
        /// <param name="src"></param>
        /// <param name="dest"></param>
        public static void CopyDelete<T>(this T src, T dest)
            where T : IDelete
        {
            dest.DeleteState = src.DeleteState;
            dest.DeleteUserId = src.DeleteUserId;
            dest.DeleteDateTime = dest.DeleteDateTime;
        }
    }

    /// <summary>
    /// 删除接口的扩展方法;
    /// </summary>
    public static class IAuditExtension
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="audit"></param>
        /// <param name="user"></param>
        public static void SetAuditState(this IAudit audit, IId user)
        {
            audit.AuditUserId = user?.Id;
            audit.AuditDateTime = DateTime.Now;
        }

        /// <summary>
        /// 将IDelete接口的属性复制到另外一个项目中;
        /// </summary>
        /// <param name="src"></param>
        /// <param name="dest"></param>
        public static void CopyAudit<T>(this T src, T dest)
            where T : IAudit
        {
            dest.AuditUserId = src.AuditUserId;
            dest.AuditDateTime = src.AuditDateTime;
        }
    }
}
