using hongbao.CollectionExtension;
using hongbao.EntityExtension;
using hongbao.Expressions;
using hongbao.SystemExtension;
using hongbaoStandardExtension.CollectionExtension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
#if NETCOREAPP2_2
using Microsoft.EntityFrameworkCore;
#else
using System.Data.Entity;
#endif

namespace hongbao.Vue.Attributes
{

    /// <summary>
    /// IAllowDelete 接口，方便  GenericAllowDelete 被调用;
    /// </summary>
    public interface IAllowDelete
    {
        /// <summary>
        /// 根据 DbContext 初始化 PropertyName 对应的字段列表;
        /// </summary>
        /// <param name="context"></param>
         void InitiateContext(DbContext context);
        /// <summary>
        /// 判断是否允许删除，判断之前应该已经调用了 InitiateContext 方法;
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool AllowDelete(int id);
        /// <summary>
        /// 是否允许删除;主要用于测试;
        /// </summary>
        /// <param name="queryable"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        bool AllowDelete(IQueryable queryable, int id);
    }

    /// <summary>
    /// IAllowDelete接口，方便  GenericAllowDelete 被调用;
    /// </summary>
    public abstract class AbstractAllowDeleteAttribute : Attribute, IAllowDelete
    {
        /// <summary>
        /// 根据 DbContext 初始化 PropertyName 对应的字段列表;
        /// </summary>
        /// <param name="context"></param>
        public abstract void InitiateContext(DbContext context);
        /// <summary>
        /// 判断是否允许删除，判断之前应该已经调用了 InitiateContext 方法;
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public abstract bool AllowDelete(int id);
        /// <summary>
        /// 是否允许删除;主要用于测试;
        /// </summary>
        /// <param name="queryable"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public abstract bool AllowDelete(IQueryable queryable, int id);

        /// <summary>
        /// 是否允许删除;
        /// </summary>
        /// <param name="context"></param>
        /// <param name="type"></param>
        /// <param name="rows"></param>
        public static void JudgeAllowDelete(DbContext context, Type type, IEnumerable<object> rows)
        {
            typeof(AbstractAllowDeleteAttribute).GetMethods(BindingFlags.Static | BindingFlags.Public)
                .Where(a => a.Name == "JudgeAllowDelete" && a.IsGenericMethod)
                .FirstOrDefault()
                .MakeGenericMethod(type)
                .Invoke(null, new object[] { context, rows });
        }
        /// <summary>
        /// 判断是否允许删除给定的实体;
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="context"></param>
        /// <param name="rows"></param>
        public static void JudgeAllowDelete<T>(DbContext context, IEnumerable<object> rows)
        where T : IdEntity
        {
            var allowDeletes = typeof(T).GetCustomAttributes<AbstractAllowDeleteAttribute>().ToList();
            if (typeof(IRelateToUpper).IsAssignableFrom(typeof(T))) //关联到自身的父团队
            {
                string upperIdField = "UpperId";
                var newAllowDelete = new AllowDeleteAttribute(typeof(T), upperIdField);
                if (!allowDeletes.Any(a => a.Equals(newAllowDelete))) 
                {
                    allowDeletes.Add(newAllowDelete);
                }
            }
            allowDeletes.ForEach(allowDelete => allowDelete.InitiateContext(context));
            if (allowDeletes.Count > 0)
            {
                rows.ForEach((b) =>
                {
                    T a = b as T;
                    a.AllowDelete = true;
                    allowDeletes.ForEach(allowDelete =>
                    {
                        if (a.AllowDelete && !allowDelete.AllowDelete(a.Id))
                        {
                            a.AllowDelete = false;
                        }
                    });
                });
            }
        }
    }

    /// <summary>
    /// 是否允许删除某一个数据库记录的标注;
    /// 根据在某一个类型中的某一个字段是否包含或者等于 给定的Id  来判断是否允许删除;
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public class AllowDeleteAttribute : AbstractAllowDeleteAttribute
    {
        /// <summary>
        /// 允许删除的判断标注;
        /// </summary>
        /// <param name="relateType"></param>
        /// <param name="propertyName"></param>
        public AllowDeleteAttribute(Type relateType, string propertyName)
        {
            this.relateType = relateType;
            this.propertyName = propertyName;
            if (propertyName == null)
            {
            }
            allowDelete = ClassUtil.BuildGenericTypeInstance(typeof(GenericAllowDelete<>),
                new Type[] { relateType }, propertyName) as IAllowDelete;
        }

        IAllowDelete allowDelete = null;
        private Type relateType;
        private string propertyName;

        /// <summary>
        /// 根据 DbContext 初始化 PropertyName 对应的字段列表;
        /// </summary>
        /// <param name="context"></param>
        public override void InitiateContext(DbContext context)
        {
            this.allowDelete.InitiateContext(context);
        }

        /// <summary>
        /// 判断是否允许删除，判断之前应该已经调用了 InitiateContext 方法;
        /// </summary>
        /// <returns></returns>
        public override bool AllowDelete(int id)
        {
            if (id == 0) return true;
            return allowDelete.AllowDelete(id);
        }

        /// <summary>
        /// 是否允许删除;主要用于测试;
        /// </summary>
        /// <param name="queryable"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public override bool AllowDelete(IQueryable queryable, int id)
        {
            if (id == 0) return true;
            return allowDelete.AllowDelete(queryable, id);
        }

        /// <summary>
        /// 判断是否相等;
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
           if (obj is AllowDeleteAttribute)
            {
                var allow = obj as AllowDeleteAttribute;
                if (allow.relateType == this.relateType && allow.propertyName == this.propertyName)
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }


    /// <summary>
    /// 总是禁止导出;
    /// </summary>
    public class DisableExportAttribute : Attribute
    {
     

    }
    /// <summary>
    /// 总是禁止删除;
    /// </summary>
    public class DisableDeleteAttribute : AbstractAllowDeleteAttribute
    {
        public override bool AllowDelete(int id)
        {
            return false;
        }

        public override bool AllowDelete(IQueryable queryable, int id)
        {
            return false;
        }

        public override void InitiateContext(DbContext context)
        {
        }
    }
    /// <summary>
    /// 泛型的 AllowDeleteAttribute类;
    /// </summary>
    /// <typeparam name="T"></typeparam>
    internal class GenericAllowDelete<T> : IAllowDelete
        where  T: IdEntity
    {
        /// <summary>
        /// 允许删除的判断标注;
        /// </summary>
        /// <param name="propertyName"></param>
        public GenericAllowDelete(string propertyName)
        {
            this.PropertyName = propertyName;
            var property = typeof(T).GetProperty(propertyName);
            this.isContains = property.PropertyType == typeof(string);
            if (!isContains && property.PropertyType.IsGenericType)
            {
                this.isNullable = true;
            }
            this.Initiate();
        }
       
        /// <summary>
        /// 
        /// </summary>
        bool isContains = false;
        /// <summary>
        /// 
        /// </summary>
        bool isNullable = false;
        /// <summary>
        /// 关联的字段;
        /// </summary>
        public string PropertyName { get; private set; }
        /// <summary>
        /// 选择属性的表达式
        /// </summary>
        Expression choiseExpression = null;
        /// <summary>
        /// 过滤已经删除的内容的表达式
        /// </summary>
        Expression filterExpressWhenIsDelete = null;
        private List<string> stringList;
        private List<int?> nullIdList;
        private List<int> idList;

        /// <summary>
        /// 初始化,不要删除和重命名，通过反射调用;
        /// </summary>
        private void Initiate()
        {
            if (this.isContains)
            {
                choiseExpression = ExpressionUtil.GetChoisePropertyExpression<T, string>(this.PropertyName);
            }
            else if (this.isNullable)
            {
                choiseExpression = ExpressionUtil.GetChoisePropertyExpression<T, int?>(this.PropertyName);
            }
            else
            {
                choiseExpression = ExpressionUtil.GetChoisePropertyExpression<T, int>(this.PropertyName);
            }

            if (typeof(IDelete).IsAssignableFrom(typeof(T)))
            {
                filterExpressWhenIsDelete = ExpressionUtil.CreateEqualLambda<T>("DeleteState", false);
            }
            else filterExpressWhenIsDelete = ExpressionUtil.True<T>();
        }

        /// <summary>
        /// 根据 DbContext 初始化 PropertyName 对应的字段列表;
        /// </summary>
        /// <param name="context"></param>
        public void InitiateContext(DbContext context)
        {
            if (this.isContains)
            {
                Expression<Func<T, string>> expression = choiseExpression as Expression<Func<T, string>>;
                stringList = context.Set<T>().Select(expression).Distinct().ToList();
            }
            else if (isNullable)
            {
                Expression<Func<T, int?>> expression = choiseExpression as Expression<Func<T, int?>>;
                nullIdList = context.Set<T>().Select(expression).Distinct().ToList();
            }
            else
            {
                Expression<Func<T, int>> expression = choiseExpression as Expression<Func<T, int>>;
                idList = context.Set<T>().Select(expression).Distinct().ToList();
            }
        }

        /// <summary>
        /// 是否允许删除;主要用于测试;
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool AllowDelete(int id)
        {
            if (id == 0) return true;
            if (stringList == null && nullIdList == null && idList == null)
            {
                throw new Exception("必须先调用 方法 InitiateContext 方法初始化数据");
            }
            return InnerAllowDelete(id);
        }

        /// <summary>
        /// 是否允许删除;主要用于测试;
        /// </summary>
        /// <param name="xqueryable"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool AllowDelete(IQueryable xqueryable, int id)
        {
            if (id == 0) return true;
            IQueryable<T> queryable = xqueryable as IQueryable<T>;
            if (this.isContains)
            {
                Expression<Func<T, string>> expression = choiseExpression as Expression<Func<T, string>>;
                stringList = queryable.Select(expression).Distinct().ToList();
            }
            else if (isNullable)
            {
                Expression<Func<T, int?>> expression = choiseExpression as Expression<Func<T, int?>>;
                nullIdList = queryable.Select(expression).Distinct().ToList();
            }
            else
            {
                Expression<Func<T, int>> expression = choiseExpression as Expression<Func<T, int>>;
                idList = queryable.Select(expression).Distinct().ToList();
            }
            return InnerAllowDelete(id);
        }
        #region 
        /// <summary>
        /// 内部的允许删除方法
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private bool InnerAllowDelete(int id)
        {
            if (this.isContains)
            {
                return XAllowDelete(stringList, id);
            }
            else if (isNullable)
            {
                return XAllowDelete(nullIdList, id);
            }
            else
            {
                return XAllowDelete(idList, id);
            }
        }
        /// <summary>
        /// 是否包含
        /// </summary>
        /// <param name="objectList"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        protected bool XAllowDelete(List<string> objectList, int id)
        {
            var idString = "," + id.ToString() + ",";
            if (objectList.Any(a => a != null && (a as string).IndexOf(idString) >= 0))
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// 是否包含
        /// </summary>
        /// <param name="objList"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        protected bool XAllowDelete(List<int?> objList, int id)
        {
            if (objList.Any(a => a != null && a == id)) return false;
            return true;
        }

        /// <summary>
        /// 是否包含
        /// </summary>
        /// <param name="objList"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        protected bool XAllowDelete(IEnumerable<int> objList, int id)
        {
            if (objList.Any(a => a == id)) return false;
            return true;
        }
        #endregion
    }

    /// <summary>
    /// 是否应该包含在查询中;(EntityQuery 使用此类)
    /// </summary>
    public class IncludeInQueryAttribute: Attribute
    {

    }
}
