using hongbao.CollectionExtension;
using hongbao.SystemExtension;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using hongbo.EntityExtension;
#if NETCOREAPP2_2
using Microsoft.EntityFrameworkCore;
using DbModelBuilder = Microsoft.EntityFrameworkCore.ModelBuilder;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.Extensions.Logging;
#else
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using EntityEntry = System.Data.Entity.Infrastructure.DbEntityEntry;
#endif
namespace hongbao.EntityExtension
{
    /// <summary>
    /// hongbaoDbContext
    /// </summary>
    public class hongbaoDbContext : DbContext
    {
        bool debug = false; 
        #region 构造函数
        /// <summary>
        /// 空构造函数；
        /// </summary>
        public hongbaoDbContext() : base()
        {
            _Initiate();           
        }

        private void _Initiate()
        {
            BeforeSaveChangesEvent += HandleTraceEntityListBeforeSaveChanges;
            debug = (System.Configuration.ConfigurationManager.AppSettings["debug_dbcontext"] != null
                            && System.Configuration.ConfigurationManager.AppSettings["debug_dbcontext"] == "1");
            if (debug)
            {
                SetDebug(null);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void SetDebug(Action<string> str)
        {
#if NET472
            this.Database.Log = (msg) =>
            {
                if (str != null) str(msg);
                Debug.WriteLine(msg);
                Console.WriteLine(msg);
            };
#endif
        }


#if NET472
        /// <summary>
        /// 构造函数；
        /// </summary>
        public hongbaoDbContext(string nameOrConnectionString) : base(nameOrConnectionString)
        {
            _Initiate();
        }

        /// <summary>
        /// 构造函数；
        /// </summary>
        public hongbaoDbContext(string nameOrConnectionString, DbCompiledModel model) : base(nameOrConnectionString, model)
        {
            _Initiate();
        }

        /// <summary>
        /// 构造函数；
        /// </summary>
        public hongbaoDbContext(DbCompiledModel model) : base( model)
        {
            _Initiate();
        }

        /// <summary>
        /// 构造函数；
        /// </summary>
        public hongbaoDbContext(DbConnection existingConnection, bool contextOwnsConnection) : base(existingConnection,contextOwnsConnection)
        {
            _Initiate();
        }

#endif

        protected DbModelBuilder modelBuilder;
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
            base.OnModelCreating(modelBuilder);
        }

       
#endregion


        private DateTime? now;

        /// <summary>
        /// 数据库中的当前时间,但是是第一次访问此字段时的数据库时间, 如果长时间使用同一个 EhayContext,可能会有问题;,此时间是第一次访问此字段的数据库时间;
        /// </summary>
        public DateTime Now
        {
            get
            {
                if (!now.HasValue)
                {
                    now = this.Database.SqlQuery<AdvancedTuple<DateTime>>("select getdate() Item1").First().Item1;
                }
                return now.Value;
            }
        }
#region SaveChanges和事件处理

        /// <summary>
        /// 保存完成时的事件处理委托;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public delegate void SaveChangesEventHandle(object sender, SaveChangesEventArgs args);

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <returns></returns>
        //public Delegate[] GetAfterSaveChangesInvocationList()
        //{
        //    return AfterSaveChangesEvent.GetInvocationList();
        //}
        ///// <summary>
        ///// 
        ///// </summary>
        ///// <returns></returns>
        //public Delegate[] GetBeforeSaveChangesInvocationList()
        //{
        //    return BeforeSaveChangesEvent.GetInvocationList();
        //}
        /// <summary>
        /// 调用SaveChanges保存后的通知事件;注意,
        /// </summary>
        public event SaveChangesEventHandle AfterSaveChangesEvent;

        /// <summary>
        /// SaveChanges保存之前的通知事件;注意,
        /// </summary>
        public event SaveChangesEventHandle BeforeSaveChangesEvent;
        /// <summary>
        /// 清除变更前的保存事件;
        /// 但是默认的事件处理不会清除;
        /// </summary>
        /// <param name="eventHandle"></param>
        public void ClearBeforeSaveChangesEvent(SaveChangesEventHandle eventHandle)
        {
            ClearSaveChangesEvent(BeforeSaveChangesEvent);
            BeforeSaveChangesEvent += HandleTraceEntityListBeforeSaveChanges;
        }
        /// <summary>
        /// 清除变更后的保存时间;
        /// </summary>
        /// <param name="eventHandle"></param>
        public void ClearAfterSaveChangesEvent(SaveChangesEventHandle eventHandle)
        {
            ClearSaveChangesEvent(AfterSaveChangesEvent);
        }
        private void ClearSaveChangesEvent(SaveChangesEventHandle eventHandle)
        {
            var eventHandleList = eventHandle.GetInvocationList();
            //foreach (var handle in eventHandleList)
            eventHandleList.ReverseForEach((handle, index) =>
            {
                eventHandle -= (SaveChangesEventHandle)handle;
            });
        }

        /// <summary>
        /// 调用 DbConteext的 SaveChanges 方法，注意，如果存在变化的 Entity 且 该 Entity 为  IdAndModifyDatetimeEntity 类的子类，
        /// 则设置 该 Entity的 LastModifyDateTime 为当前时间；
        /// </summary>
        public override int SaveChanges()
        {
            BeforeSaveChangesEvent?.Invoke(this, new SaveChangesEventArgs { DbContext = this });
            var result = base.SaveChanges();
            AfterSaveChangesEvent?.Invoke(this, new SaveChangesEventArgs { DbContext = this });            
            return result;
        }

        /// <summary>
        /// 移走符合条件的数据记录;
        /// 可能调用 SaveChanges 对数据库进行变更;
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="func"></param>
        /// <param name="saveChange"></param>
        /// <returns></returns>
        public int RemoveRange<T>(Func<T,bool> func, bool saveChange=true)
            where T : class
        {
            this.Set<T>().RemoveRange(this.Set<T>().Where(func));
            if (saveChange) return this.SaveChanges();
            else return 0;
        }

        /// <summary>
        /// 在调用 SaveChanges 方法之前，处理DbContext跟踪的实体列表，
        /// 1. 对于实现了 IModifyDateTime 接口的实体，更新其 LastModifyDateTime
        /// 2. 调用 HandleEveryTrackerEntryBeforeSaveChange 方法，子类可以覆盖此方法;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="eventArgs"></param>
        protected virtual void HandleTraceEntityListBeforeSaveChanges(object sender, SaveChangesEventArgs eventArgs)
        {
            if (eventArgs.DbContext.ChangeTracker.HasChanges())
            {
                var entityEnum = this.ChangeTracker.Entries().ToList();
                for (var index = 0; index < entityEnum.Count; index++)
                {                    
                    var aEntity = entityEnum[index];
                    if (aEntity.State == EntityState.Unchanged) continue; 
                    var entity = aEntity.Entity;
                    if (aEntity.State == EntityState.Added)
                    {
                        if (aEntity is ICreateDateTime)
                        {
                            ((ICreateDateTime)entity).CreateDateTime = this.Now;
                        }
                        if (aEntity is IModifyDatetimeEntity)
                        {
                            ((IModifyDatetimeEntity)entity).LastModifyDateTime = this.Now;
                        }
                    }
                    //if (aEntity.State == EntityState.Modified && entity is IModifyDatetimeEntity)
                    //{
                    //    ((IModifyDatetimeEntity)aEntity.Entity).LastModifyDateTime = DateTime.Now;
                    //}
                    if (entity is IRelative)
                    {
                        ((IRelative)entity).OperateRelative(this, aEntity);
                    }                    
                    if (entity is IRelateToUpper)  //有关联的父实体字段;
                    {
                        IRelateToUpperUtil.MaintainUpperids(this,
                             entity.GetType(), aEntity.State, entity);                        
                    }                    
                    HandleOneTrackerEntityBeforeSaveChange(aEntity);
                    //if (aEntity.State != EntityState.Unchanged && aEntity.State != EntityState.Detached)
                    //{
                    //    var obj = aEntity.Entity;
                    //    if (obj is IRelative)
                    //    {
                    //        ((IRelative)obj).OperateRelative(this, entityEnum, aEntity);
                    //    }
                    //}
                }
            }
        }

        /// <summary>
        /// 在保存之前处理每一个Entry;默认不进行任何处理;
        /// </summary>
        public virtual void HandleOneTrackerEntityBeforeSaveChange(EntityEntry aEntity)
        {
            
        }
#endregion

#region 其他方法 

        /// <summary>
        /// 查询对象；如果查询不到，则插入对象；  
        /// </summary>
        /// <typeparam name="T">实体类型，必须是引用类型且实现IName接口</typeparam>
        /// <param name="id">实体的名称</param>
        /// <returns></returns>
        public virtual T CreateOrFind<T>(int id)
            where T : class, IId, new()
        {
            var set = this.Set<T>();
            var obj = set.Find(id);
            if (obj == null)
            {
                obj = new T();
                set.Add(obj);
            }
            return obj;
        }

        /// <summary>
        /// 查询对象；如果查询不到，则插入对象；  
        /// </summary>
        /// <typeparam name="T">实体类型，必须是引用类型且实现IName接口</typeparam>
        /// <param name="tname">实体的名称</param>
        /// <param name="beforeInsert">在插入数据库之前进行的操作；</param>
        /// <returns></returns>
        protected T CreateOrFind<T>(string tname, Action<T> beforeInsert = null)
            where T : class, IName, new()
        {
            var set = this.Set<T>();
            var obj = set.Where((a) => a.Name == tname).FirstOrDefault();
            if (obj == null)
            {
                obj = new T();
                obj.Name = tname;
                if (beforeInsert != null) beforeInsert(obj);
                set.Add(obj);
            }
            return obj;
        }

        /// <summary>
        /// 附加对象到上下文;如果已经有此实体对象，则不会进行 Attach 操作;
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        public void SafeAttach<T>(T entity)
            where T : IdEntity
        {
            if (!this.ChangeTracker.Entries<T>().Any(a => a.Entity.Id == entity.Id))
            {
                this.Set<T>().Attach(entity); //
            }
        }

        /// <summary>
        /// 附加对象到上下文;如果已经有此实体对象，则不会进行 Attach 操作;
        /// </summary>
        public void SafeAttach(Type entityType, IId entity)
        {
            if (!this.ChangeTracker.Entries().Any(a => DbContextUtil.GetEntityType(a.Entity.GetType()) == entityType && ((IId) a.Entity).Id == entity.Id))
            {
#if NETCOREAPP2_2
    this.Attach(entity);
#else
                this.Set(entityType).Attach(entity);
#endif

                // this.Set(entityType).Attach(entity); //
            }
        }
#endregion
    }


    /// <summary>
    /// SaveChanges的事件通知参数类;
    /// </summary>
    public class SaveChangesEventArgs : EventArgs
    {
        /// <summary>
        /// 数据库上下文
        /// </summary>
        public hongbaoDbContext DbContext { get; set; }
    }
}
