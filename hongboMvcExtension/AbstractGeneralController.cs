using hongbao.EntityExtension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
#if NET472
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Filters;
using System.Web.Routing;
using System.Data.Entity;
#else
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
#endif

namespace hongbao.MvcExtension
{
   
    /// <summary>
    /// 带 DbContext 功能的控制器； 抽象类； 
    /// 注意，会自动创建 和 释放 DbContext;
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class AbstractMvcControllerWithDbContext<T> : AbstractMvcController, IDbContextGetter
        where T : DbContext
    {
        /// <summary>
        /// 
        /// </summary>
        public static ThreadLocal<T> ThreadLocal = new ThreadLocal<T>();

        /// <summary>
        /// 构造函数； 
        /// </summary>
        public AbstractMvcControllerWithDbContext() : base()
        {
            if (ThreadLocal.Value != null)
            {
                this.DbContext = ThreadLocal.Value; 
            }
        }
        

        #region EntityFramework的相关方法

        private T _dbContext = null; 

        /// <summary>
        /// 设置 DbContext 之后的回调事件，子类可能根据需要覆盖此事件； 
        /// 覆盖时记得调用 base.OnSetDbContext 方法； 
        /// </summary>
        protected virtual void OnSetDbContext()
        {

        }
        /// <summary>
        /// DbContext 对象； 
        /// </summary>
        public T DbContext
        {
            get { return this._dbContext; }
            set
            {
                this._dbContext = value;
                this.OnSetDbContext();
            }
        }

       

        /// <summary>
        /// 调用 DbConteext的 SaveChanges 方法，注意，如果存在变化的 Entity 且 该 Entity 为  IdAndModifyDatetimeEntity 类的子类，
        /// 则设置 该 Entity的 LastModifyDateTime 为当前时间；
        /// </summary>
        public virtual int SaveChanges()
        {
            //已经在 hongbaoDbContext 中处理
            //if (!(this.DbContext is hongbaoDbContext))
            //{
            //    var entityEnum = this.DbContext.ChangeTracker.Entries();
            //    foreach (var aEntity in entityEnum)
            //    {
            //        if (aEntity.State == EntityState.Modified && aEntity.Entity is IdAndModifyDatetimeEntity)
            //        {
            //            ((IdAndModifyDatetimeEntity)aEntity.Entity).LastModifyDateTime = DateTime.Now;
            //        }
            //    }
            //}
            return this.DbContext.SaveChanges();
        }

        /// <summary>
        /// 实现接口；　
        /// </summary>
        /// <returns></returns>
        public DbContext GetDbContext()
        {
            return this.DbContext;
        }
        #endregion

        /// <summary>
        /// 覆盖父类的失活处理函数;
        /// </summary>
        protected internal override void Deactivate()
        {
            ThreadLocal.Value = null;   //设置线程变量为 null; 
            base.Deactivate();
        }           
    }

    
}
