using hongbao.SystemExtension;
using hongbaoStandardExtension.CollectionExtension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace hongbao.CollectionExtension
{
    /// <summary>
    /// IList 的扩展类； 
    /// </summary>
    public static class IListExtension
    {
       /// <summary>
       /// 按照格式添加;
       /// </summary>
       /// <param name="srcList"></param>
       /// <param name="message"></param>
       /// <param name="pars"></param>
        public static void AddFormat(this List<string> srcList, string message, params object[] pars)
        {
            srcList.Add(string.Format(message, pars));
        }

        

        /// <summary>
        /// IEnumerable 也有 Find 方法，但该方法不支持修改;
        /// IListUtil 的 支持在 Find 时进行修改;
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static object Find(System.Collections.IList array, Func<object, bool> func)
        {
            for (var index = 0; index < array.Count; index++)
            {
                var ele = array[index];
                if (func(ele)) return ele;
            }
            return null;
        }

        /// <summary>
        /// 是否具有逻辑上的不同项;
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="srcList"></param>
        /// <param name="destList"></param>
        /// <param name="compare"></param>
        /// <returns></returns>
        public static bool HaveDifferent<T>(this List<T> srcList, List<T> destList, Func<T, T, bool> compare=null)
        {
            if (IsNullOrEmpty(srcList) && IsNullOrEmpty(destList))
                return false;
            else if (IsNullOrEmpty(srcList)) return true;
            Different<T> result = new Different<T>();
            if (srcList.Any(a => !destList.Any(b => compare(a, b)))) return true;
            if (destList.Any(a => !srcList.Any(b => compare(a, b))))  return true;
            return false;
        }
        /// <summary>
        /// 用列表1 和  列表2 比较，获取不同部分:
        ///   Removed - 在列表1 但不在列表 2中的部分;
        ///   Added   - 在列表2 但不在列表 1中的部分;
        ///   Unmodified - 在列表1也在列表2中的部分;
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="srcList"></param>
        /// <param name="destList"></param>
        /// <param name="compare"></param>
        /// <returns>
        ///   Removed - 在列表1 但不在列表 2中的部分;
        ///   Added   - 在列表2 但不在列表 1中的部分;
        ///   Unmodified - 在列表1也在列表2中的部分;
        /// </returns>
        public static Different<T> Different<T>(this List<T> srcList, List<T> destList, Func<T, T, bool> compare)
        {
            Different<T> result = new Different<T>();
            if (IsNullOrEmpty(srcList) && IsNullOrEmpty(destList))
                return result;
            result.Removed = srcList.Where(a =>
            {
                var existsInDest = destList.Any(b => compare(a, b));
                if (existsInDest) return false;
                else return true;
            }).ToList();

            //result.Removed = srcList.Where(a => !destList.Any(b => compare(a, b))).ToList();
            //result.Added = destList.Where(a => !srcList.Any(b => compare(a, b))).ToList();
            result.Added = destList.Where(a =>
            {
                var existsInSrc = srcList.Any(b => compare(a, b));
                if (existsInSrc) return false;
                else return true;
            }).ToList();
            result.Unmodified = destList.Where(a =>
            {
                var existsInSrc = srcList.Any(b => compare(a, b));
                return existsInSrc;
            }).ToList();
            return result;
        }

        /// <summary>
        /// 用列表1 和  列表2 比较，获取不同部分:
        ///   Removed - 在列表1 但不在列表 2中的部分;
        ///   Added   - 在列表2 但不在列表 1中的部分;
        ///   Unmodified - 在列表1也在列表2中的部分;
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="K"></typeparam>
        /// <param name="srcList"></param>
        /// <param name="destList"></param>
        /// <param name="compare"></param>
        /// <returns>
        ///   Removed - 在列表1 但不在列表 2中的部分;
        ///   Added   - 在列表2 但不在列表 1中的部分;
        ///   Unmodified - 在列表1也在列表2中的部分;
        /// </returns>
        public static Different<T,K> Different<T,K>(this List<T> srcList, List<K> destList, Func<T, K, bool> compare)
        {
            Different<T,K> result = new Different<T,K>();
            if (IsNullOrEmpty(srcList) && IsNullOrEmpty(destList))
                return result;
            result.Removed = srcList.Where(a => !destList.Any(b => compare(a, b))).ToList();
            result.Added = destList.Where(a => !srcList.Any(b => compare(b, a))).ToList();
            result.Unmodified = srcList.Where(a => destList.Any(b => compare(a, b))).ToList();
            return result;
        }

        /// <summary>
        /// 用列表1 和  列表2 比较，获取不同部分:
        ///   Removed - 在列表1 但不在列表 2中的部分;
        ///   Added   - 在列表2 但不在列表 1中的部分;
        ///   Unmodified - 在列表1也在列表2中的部分;
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="K"></typeparam>
        /// <param name="srcList"></param>
        /// <param name="destList"></param>
        /// <param name="compare"></param>
        /// <param name="destNotExitsAction">如果项在列表1中但不在列表2中时</param>
        /// <param name="destExistsAction">如果项在列表1中且在列表2中时的处理方法</param>
        /// <param name="srcNotExitsAction">如果项在列表2中但不在列表1中时</param>
        /// <returns>
        ///   Removed - 在列表1 但不在列表 2中的部分;
        ///   Added   - 在列表2 但不在列表 1中的部分;
        ///   Unmodified - 在列表1也在列表2中的部分;
        ///   
        /// </returns>
        public static Different<T, K> DifferentHandle<T, K>(this List<T> srcList, List<K> destList, Func<T, K, bool> compare,
            Action<T> destNotExitsAction,
            Action<T> destExistsAction,
            Action<K> srcNotExitsAction)
        {
            Different<T, K> result = new Different<T, K>();
            if (IsNullOrEmpty(srcList) && IsNullOrEmpty(destList))
                return result;
            result.Removed = srcList.Where(a => !destList.Any(b => compare(a, b))).ToList();
            result.Added = destList.Where(a => !srcList.Any(b => compare(b, a))).ToList();
            result.Unmodified = srcList.Where(a => destList.Any(b => compare(a, b))).ToList();
            if (destNotExitsAction != null && result.Removed!=null)
            {
                result.Removed.ForEach(item => destNotExitsAction(item));
            }
            if (srcNotExitsAction != null && result.Added != null)
            {
                result.Added.ForEach(item => srcNotExitsAction(item));
            }
            if (destExistsAction != null && result.Unmodified != null)
            {
                result.Unmodified.ForEach(item => destExistsAction(item));
            }
            return result;
        }

        /// <summary>
        /// 用列表1 和  列表2 比较，获取不同部分:
        ///   Removed - 在列表1 但不在列表 2中的部分;
        ///   Added   - 在列表2 但不在列表 1中的部分;
        ///   Unmodified - 在列表1也在列表2中的部分;
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="K"></typeparam>
        /// <param name="srcList"></param>
        /// <param name="destList"></param>
        /// <param name="compare"></param>
        /// <param name="destNotExitsAction">如果项在列表1中但不在列表2中时</param>
        /// <param name="notChangeElementAction">如果项在列表1中且在列表2中时的处理方法</param>
        /// <param name="srcNotExitsAction">如果项在列表2中但不在列表1中时</param>
        /// <returns>
        ///   Removed - 在列表1 但不在列表 2中的部分;
        ///   Added   - 在列表2 但不在列表 1中的部分;
        ///   Unmodified - 在列表1也在列表2中的部分;
        ///   
        /// </returns>
        public static Different<T, K> DifferentHandle<T, K>(this List<T> srcList, List<K> destList, Func<T, K, bool> compare,
            Action<T> destNotExitsAction,
            Action<T, K> notChangeElementAction,
            Action<K> srcNotExitsAction)
        {
            Different<T, K> result = new Different<T, K>();
            if (IsNullOrEmpty(srcList) && IsNullOrEmpty(destList))
                return result;
            result.Removed = srcList.Where(a => !destList.Any(b => compare(a, b))).ToList();
            result.Added = destList.Where(a => !srcList.Any(b => compare(b, a))).ToList();
            result.Unmodified = srcList.Where(a => destList.Any(b => compare(a, b))).ToList();
            if (destNotExitsAction != null && result.Removed != null)
            {
                result.Removed.ForEach(item => destNotExitsAction(item));
            }
            if (srcNotExitsAction != null && result.Added != null)
            {
                result.Added.ForEach(item => srcNotExitsAction(item));
            }
            if (notChangeElementAction != null && result.Unmodified != null)
            {
                result.Unmodified.ForEach(srcItem =>
                {
                    var destItem = destList.FirstOrDefault(a => compare(srcItem, a));
                    notChangeElementAction(srcItem, destItem);
                });
            }
            return result;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static bool IsNullOrEmpty<T>(IList<T> array)
        {
            return array == null || array.Count == 0;
        }

        /// <summary>
        /// 交换两个索引处的项； 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="coll"></param>
        /// <param name="pos1"></param>
        /// <param name="pos2"></param>
        public static void Swap<T>(this IList<T> coll, int pos1, int pos2)
        {
            T element = coll[pos1];
            coll[pos1] = coll[pos2];
            coll[pos2] = element;
        }

        /// <summary>
        /// 将列表里面的元素随机重排；
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <param name="loopCount">随机重排次数，默认为2，越多越随机； </param>
        public static void RandomRearrange<T>(this IList<T> list, int loopCount = 2)
        {
            var random = new Random(); //
            while (loopCount-- > 0)
            {
                int length = list.Count;
                while (length > 1)
                {
                    list.Swap(random.Next(0, length), length - 1);
                    length--;
                }
            }
        }

        #region 利用ReverseForEach方法对于进行逆序处理
        /// <summary>
        /// 对于 IList 里面的每一个元素，倒叙执行给定的操作，
        /// 但如果该操作返回 false,则不处理后续元素，
        /// 注意：本函数总会处理第0个元素；
        /// </summary>
        /// <param name="iEnum"></param>
        /// <param name="continueFunc"></param>
        public static void ReverseForEach<T>(this IList<T> iEnum, Func<T, int, bool> continueFunc)
        {
            int cnt = iEnum.Count;
            for (var index = cnt - 1; index >= 0; index--)
            {
                var aT = iEnum[index];
                bool result = continueFunc(aT, index);
                if (!result) return;
            }
        }

        /// <summary>
        /// 对于 IList 里面的每一个元素，倒叙执行给定的操作，
        /// 但如果该操作返回 false,则不处理后续元素，
        /// 注意：本函数总会处理第0个元素；
        /// </summary>
        /// <param name="iEnum"></param>
        /// <param name="continueFunc"></param>
        public static void ReverseForEach<T>(this IList<T> iEnum, Action<T, int> continueFunc)
        {
            ReverseForEach(iEnum, (a, index) => { continueFunc(a, index); return true; });
        }

        /// <summary>
        /// 对于 IList 里面的每一个元素，根据判断进行移除操作
        /// 但如果该操作返回 false,则不处理后续元素，
        /// 注意：本函数总会处理第0个元素；
        /// </summary>
        /// <param name="iEnum"></param>
        /// <param name="removeFunc"></param>
        public static void Except<T>(this IList<T> iEnum, Func<T, bool> removeFunc)
        {
            ReverseForEach(iEnum, (a, index) => { if (removeFunc(a)) iEnum.RemoveAt(index); return true; });
        }



        // <summary>
        // 对于 IList<T> 里面的每一个元素，顺序执行给定的操作，
        // 但如果该操作返回 false,则不处理后续元素，
        // 注意：本函数总会处理第0个元素；
        // </summary>
        // <param name="iEnum"></param>
        // <param name="continueFunc"></param>
        /*public static void ForEach<T>(this IList<T> iEnum, Func<T, int, bool> continueFunc)
        {
            int cnt = iEnum.Count;
            for (var index = 0; index< cnt ; index++)
            {
                var aT = iEnum[index];
                bool result = continueFunc(aT, index);
                if (!result) return;
            }
        }

        /// <summary>
        /// 对于 ForEach  里面的每一个元素，倒叙执行给定的操作，
        /// 但如果该操作返回 false,则不处理后续元素，
        /// 注意：本函数总会处理第0个元素；
        /// </summary>
        /// <param name="iEnum"></param>
        /// <param name="continueFunc"></param>
        public static void ForEach<T>(this IList<T> iEnum, Action<T, int> continueFunc)
        {
            ReverseForEach(iEnum, (a, index) => { continueFunc(a, index); return true; });
        }*/
        #endregion


        /// <summary>
        /// 对列表进行排序； 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <param name="compareFunc"></param>
        public static void Sort<T>(this List<T> list, Func<T, T, int> compareFunc)
        {
            Compare<T> compare = new Compare<T>(compareFunc);
            list.Sort(compare);
        }

        /// <summary>
        /// 移除元素；
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="iEnum"></param>
        /// <param name="objEnum"></param>
        public static void RemoveRange<T>(this IList<T> iEnum, Func<T, bool> objEnum)
        {
            for(int index= iEnum.Count-1; index>=0; index--)
            {
                if (objEnum(iEnum[index]))
                {
                    iEnum.RemoveAt(index);
                }
            }
            
        }

        /// <summary>
        /// 获取子数组； 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <param name="beginPos"></param>
        /// <param name="size"></param>
        /// <returns></returns>
        public static T[] SubArray<T>(this List<T> list, int beginPos, int size)
        {
            int count = (list.Count > beginPos + size) ? size : (list.Count - beginPos);
            if (count == 0) return new T[] { };
            var result = new T[count];
            for (var index=0; index<count; index++) 
            {
                result[index] = list[beginPos + index];
            }
            return result; 
        }

        /// <summary>
        /// 获取子数组
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <param name="beginPos"></param>
        /// <param name="size"></param>
        /// <returns></returns>
        public static T[] SubArray<T>(this List<T> list, ref int beginPos, int size)
        {
            int count = (list.Count > beginPos + size) ? size : (list.Count - beginPos);
            if (count == 0) return new T[] { };
            var result = new T[count];
            for (var index = 0; index < count; index++)
            {
                result[index] = list[beginPos + index];
            }
            beginPos += size;
            return result;
        }

        /// <summary>  
        /// 笛卡尔积,递归实现，对于大的列表将可能会有堆栈溢出;暂时不考虑堆栈溢出的问题;          
        /// </summary>  
        /// <param name="arrayList"></param> 
        public static List<T[]> Dicarl<T>(this List<T[]> arrayList)
        {
            return Dicarl(arrayList, null, 0, null);
        }
        
        /// <summary>  
        /// 笛卡尔积,递归实现，对于大的列表将可能会有堆栈溢出;暂时不考虑堆栈溢出的问题;          
        /// </summary>  
        /// <param name="arrayList"></param>  
        /// <param name="result">输出,如果为null,则构建一个作为返回;</param>  
        /// <param name="currentLoopIndex">递归调用时前一轮递归调用的索引;</param>  
        /// <param name="preList">开始传入null;递归调用时，传入currentLoopIndex之前已经拼好的列表;</param>  
        private static List<T[]> Dicarl<T>(this List<T[]> arrayList,
            List<T[]> result , 
            int currentLoopIndex, 
            List<T> preList )
        {            
            if (result==null) result = new List<T[]>();
            if (currentLoopIndex < arrayList.Count - 1)
            {
                
                for (int i = 0; i < arrayList[currentLoopIndex].Length; i++)
                {
                    List<T> currentPreList = new List<T>();
                    if (preList != null)
                    {
                        currentPreList.AddRange(preList);
                    }
                    currentPreList.Add(arrayList[currentLoopIndex][i]);
                    Dicarl(arrayList, result, currentLoopIndex + 1, currentPreList);
                }
            }
            else if (currentLoopIndex == arrayList.Count - 1)
            {
                for (int i = 0; i < arrayList[currentLoopIndex].Length; i++)
                {
                    var items = new List<T>();
                    if (preList!=null) items.AddRange(preList);
                    items.Add(arrayList[currentLoopIndex][i]);
                    result.Add(items.ToArray());
                }
            }
            return result;
        }

        /// <summary>
        /// 扩展一个 forAll 方法
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="query"></param>
        /// <param name="action"></param>
        public static void ForAll<T>(this ParallelQuery<T> query, Action<T, int> action)
        {
            var index = 0;
            query.ForAll((item) =>
            {
                var inner = Interlocked.Increment(ref index);
                action(item, inner);
            });
        }

        /// <summary>
        /// 扩展一个 forAll 方法
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="query"></param>
        /// <param name="options"></param>
        /// <param name="action"></param>
        public static void ParallelForEach<T>(this IEnumerable<T> query, ParallelOptions options, Action<T, int> action)
        {
            var index = 0;
            Parallel.ForEach(query, options, (item) =>
            {
                var inner = Interlocked.Increment(ref index);
                action(item, inner);
            });
        }
        /// <summary>
        /// 过滤并进行处理
        /// </summary>
        public static void FilerAndAction<T>(this IList<T> list
            ,Func<T,bool> compareFunc
            ,Action<T> action)
        {
            list.Where(compareFunc).ForEach(action);
        }

        /// <summary>
        /// 查找直接或者间接子级;
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="parentItem">父元素</param>
        /// <param name="allItemList">待查找的元素列表</param>
        /// <param name="isChildFunc">
        ///   判断是否子元素，例如, (parent,child)=> return true; 
        /// </param>
        /// <returns></returns>
        public static IList<TLevel<T>> FindAllChild<T>(this T parentItem, IList<T> allItemList, Func<T,T,bool> isChildFunc)
        {
            List<TLevel<T>> result = new List<TLevel<T>>();
            FindAllChild(parentItem, allItemList, isChildFunc, result, 1);
            return result; 
        }

        /// <summary>
        /// 查找直接或者间接子级
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="parent">父元素</param>
        /// <param name="allList">待查找的元素列表</param>
        /// <param name="isChild">判断两个元素是否直接父字关系的函数，例如, (parent,child)=> return true;</param>
        /// <param name="resultList">存储符合条件的元素的列表</param>
        /// <param name="level">当前查找的层，查找下一层时，此 level将加1;</param>
        private static void FindAllChild<T>(this T parent, 
            IList<T> allList, 
            Func<T, T, bool> isChild,
            List<TLevel<T>> resultList,
            int level )
        {
            var directChildList = allList.Where(child => isChild(parent, child));
            resultList.AddRange(directChildList.Select(a=>new TLevel<T> { Item = a, Level = level }));
            foreach(var directChild in directChildList)
            {
                FindAllChild(directChild, allList, isChild, resultList, level + 1);
            }
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public class TLevel<T>
    {
        /// <summary>
        /// 
        /// </summary>
          public T Item { get; set;  }

            /// <summary>
            /// 从 1开始，
            /// </summary>
          public int Level { get; set;  }
        
    }

    /// <summary>
    /// 比较不同的结果;
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Different<T>
    {/// <summary>
    /// 
    /// </summary>
        public Different()
        {
            Removed = new List<T>();
            Added = new List<T>();
            Unmodified = new List<T>(); 
        }
        /// <summary>
        /// 
        /// </summary>
        public List<T> Removed { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<T> Added { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<T> Unmodified { get; set; }
    }

    /// <summary>
    /// 比较不同的结果
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="K"></typeparam>
    public class Different<T,K>
    {
        /// <summary>
        /// 
        /// </summary>
        public Different()
        {
            Removed = new List<T>();
            Added = new List<K>();
            Unmodified = new List<T>();
        }
        /// <summary>
        /// 
        /// </summary>
        public List<T> Removed { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<K> Added { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<T> Unmodified { get; set; }
    }
}




