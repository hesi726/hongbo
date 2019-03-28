using hongbao.Expressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
#if NETCOREAPP2_2
using Microsoft.EntityFrameworkCore;
using DbModelBuilder = Microsoft.EntityFrameworkCore.ModelBuilder;
#else
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
#endif

namespace hongbao.EntityExtension
{
    /// <summary>
    /// 和上级对象关联的接口,上级对象只能是和自身一样的对象;
    /// </summary>
    public interface IRelateToUpper : IId
    {
        /// <summary>
        /// 上级对象Id,可能为 null;
        /// </summary>
        int? UpperId { get; set; }

        /// <summary>
        /// 所有上级对象的Id字符串，包含前后的逗号; 不包含自身的实体id;
        /// </summary>
        string UpperIds { get; set; }

        /// <summary>
        /// 直接子数量
        /// </summary>
        int DirectChildCount { get; set; }

        /// <summary>
        /// 所有的子数量
        /// </summary>
        int TotalChildCount { get; set; }
    }


    /// <summary>
    /// IRelateToUpper有关联的父实体的接口的工具类
    /// </summary>
    public static class IRelateToUpperUtil
    {
        /// <summary>
        /// 判断是否循环为彼此的上级;
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="context"></param>
        /// <param name="entity"></param>
        /// <param name="upEntity"></param>
        public static bool JudgeLoopUpper<T>(DbContext context, T entity, T upEntity)
            where T : class, IId, IRelateToUpper
        {
            if (entity.Id > 0 && upEntity.UpperIds != null && upEntity.UpperIds.IndexOf("," + entity.Id.ToString() + ",") >= 0) //新的父团队的父团队字符串包含本团队，死循环，禁止;
                return true;
            return false;
        }
        /// <summary>
        /// 将一个列表转换为树型结构,注意，只有一个根节点;
        /// </summary>
        /// <param name="nodeList"></param>
        /// <param name="rootNode"></param>
        /// <param name="mapFunc"></param>
        /// <param name="skipNodeId">如果大于0，则此Id对应的节点以及其所有子节点不列举出来</param>
        /// <returns></returns>
        public static T ConvertToTree_WithSingleRoot<T, K>(List<K> nodeList, K rootNode, Func<K,T> mapFunc, int skipNodeId = 0)
            where K: IRelateToUpper
            where T: IChildren<T>
        {
            var result = mapFunc(rootNode);
            result.children = nodeList.Where(a => a.UpperId == rootNode.Id && a.Id != skipNodeId)
                .Select(a => ConvertToTree_WithSingleRoot(nodeList,  a,  mapFunc,  skipNodeId)).ToList();
            return result;
        }

        /// <summary>
        /// 根据上级实体Id获取子实体的查询表达式,
        /// 如果上级实体Id为null,则返回 true 的表达式,
        /// 如果 T 没有实现  IRelateToUpper 接口，则返回恒定的 True 表达式;
        /// </summary>
        /// <returns></returns>
        public static Expression<Func<T, bool>> GetChildEntityExpression<T>(int? upperId)
                    where T : class, IId //, IRelateToUpper
        {
            if (!upperId.HasValue) return ExpressionUtil.True<T>();
            if (!typeof(IRelateToUpper).IsAssignableFrom(typeof(T))) return ExpressionUtil.True<T>();
            string xid = "," + upperId.Value.ToString() + ",";
            return ExpressionUtil.CreatePropertyContains<T>("UpperIds", xid);
        }

        

        private static Dictionary<Type, MethodInfo> typeGenericMethodMap = new Dictionary<Type, MethodInfo>();
        private static MethodInfo GenericMaintainUpperidsWhenCreate = null;
        /// <summary>
        /// 维护实体 UpperIds 字段;
        /// </summary>
        /// <param name="context"></param>
        /// <param name="entityType"></param>
        /// <param name="state"></param>
        /// <param name="entity"></param>
        public static void MaintainUpperids(DbContext context, Type entityType, EntityState state, object entity)
        {
            entityType = DbContextUtil.GetEntityType(entityType);
            if (!typeof(IdEntity).IsAssignableFrom(entityType) || !typeof(IRelateToUpper).IsAssignableFrom(entityType))
            {
                throw new Exception(entityType.Name + " 未实现 IId 和 IRelateToUpper 接口,不可以调用此方法");
            }
            MethodInfo methodInfo = null;
            if (!typeGenericMethodMap.TryGetValue(entityType, out methodInfo))
            {
                methodInfo =   GenericMaintainUpperidsWhenCreate = typeof(IRelateToUpperUtil)
                    .GetMethods(BindingFlags.Static | BindingFlags.Public)
                    .First(a => a.Name == "MaintainUpperids" && a.IsGenericMethod)
                    .MakeGenericMethod(new Type[] { entityType });
                typeGenericMethodMap[entityType] = methodInfo;
            }
           // GenericMaintainUpperidsWhenCreate.Invoke(null, new object[] {  context, state, entity });  每个类型都会定义不同的泛型方法中;
            methodInfo.Invoke(null, new object[] { context, state, entity });
        }

        /// <summary>
        /// 维护实体 UpperIds 字段;
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="context"></param>
        /// <param name="state"></param>
        /// <param name="entity"></param>
        public static void MaintainUpperids<T>(DbContext context, EntityState state, T entity)
            where T : class, IId, IRelateToUpper
        {
            if (state == EntityState.Added)
            {
                MaintainUpperidsWhenCreate<T>(context, entity);
            }
            else if (state == EntityState.Modified)
            {
                MaintainUpperidsWhenModify(context, entity);
            }
        }
        /// <summary>
        /// 新建某一个实体时, 维护 UpperIds 字段;
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        private static void MaintainUpperidsWhenCreate<T>(DbContext context, T entity)
            where T : class, IId, IRelateToUpper
        {
            if (!entity.UpperId.HasValue)
            {
                entity.UpperIds = null;
                return; //新建时未指定上级实体Id,不需要设置;
            }
            var upperEntity = context.Set<T>().Find(entity.UpperId.Value);
            entity.UpperIds = (upperEntity.UpperIds?? ",") + entity.UpperId.Value + ",";
        }

        /// <summary>
        /// 修改某一个实体时, 维护 UpperIds 字段;
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        private static void MaintainUpperidsWhenModify<T>(DbContext context,  T entity)
            where T : class, IId, IRelateToUpper
        {
            MaintainUpperidsWhenCreate(context, entity);
            var express = GetChildEntityExpression<T>(entity.Id);  //查询所有子实体的表达式
            List<T> childList = context.Set<T>().Where(express).ToList();
            var entityUpperIds = (entity.UpperIds ?? ",") + entity.Id + ",";
            StringBuilder sb = new StringBuilder();
            foreach (var child in childList)
            {
                sb.Clear();
                if (child.UpperId != entity.Id)
                {
                    T upper = childList.First(a => a.Id == child.UpperId.Value);
                    sb.Insert(0, upper.Id + ",");
                    while (upper.UpperId.Value != entity.Id)
                    {
                        upper = childList.First(a => a.Id == upper.UpperId.Value);
                        sb.Insert(0, upper.Id + ",");
                    }
                }
                sb.Insert(0, entityUpperIds);
                child.UpperIds = sb.ToString();
            }
        }
    }
}
