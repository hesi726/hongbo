using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.Expressions
{
    /// <summary>
    /// 表达式扩展; 
    /// 部分代码复制自: https://blog.csdn.net/yl2isoft/article/details/53196092?utm_source=copy 
    /// </summary>
    public static class ExpressionUtil
    {
        /// <summary>
        /// 创建lambda表达式：p=>true
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static Expression<Func<T, bool>> True<T>()
        {
            return p => true;
        }

        /// <summary>
        /// 创建lambda表达式：p=>false
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static Expression<Func<T, bool>> False<T>()
        {
            return p => false;
        }

        #region 根据属性产生表达式
        /// <summary>
        /// 创建lambda表达式：p=>p.propertyName
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TKey"></typeparam>
        /// <param name="propertyName"></param>
        /// <returns></returns>
        public static Expression<Func<T, TKey>> GetChoisePropertyExpression<T, TKey>(string propertyName)
        {
            ParameterExpression parameter = Expression.Parameter(typeof(T), "p");
            return Expression.Lambda<Func<T, TKey>>(Expression.Property(parameter, propertyName), parameter);
        }

        #region CreatePropertyExpression
        /// <summary>
        /// 创建对于类属性的访问表达式; 类似于 t=> t.Name 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="K"></typeparam>
        /// <returns></returns>
        public static Expression<Func<T, K>> CreatePropertyExpression<T, K>(string propertyName)
        {
            ParameterExpression parameter = Expression.Parameter(typeof(T), "p");//按照Id排倒序;
            MemberExpression member = Expression.PropertyOrField(parameter, propertyName);
            if (member.Member.ReflectedType != typeof(K))
            {
                var exp = Expression.Convert(member, typeof(K)).Reduce();
                var sort = Expression.Lambda<Func<T, K>>(exp, parameter);
                return sort;
            }
            else
            {
                var sort = Expression.Lambda<Func<T, K>>(member, parameter);
                return sort;
            }
        }
        #endregion

        #region CreateEqualLambda 或者  CreateNotEqualLambda
        /// <summary>
        /// 创建lambda表达式：p=>p.propertyName == propertyValue
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="K">属性值类型，应该为 字符串 或者 整数 或者 日期等数据库可以识别的类型; </typeparam>
        /// <param name="propertyName"></param>
        /// <param name="propertyValue"></param>
        /// <returns></returns>
        public static Expression<Func<T, bool>> CreateEqualLambda<T, K>(string propertyName, K propertyValue)
        {
            ParameterExpression parameter = Expression.Parameter(typeof(T), "p");//创建参数p
            MemberExpression member = Expression.PropertyOrField(parameter, propertyName);
            ConstantExpression constant = Expression.Constant(propertyValue);//创建常数
            return Expression.Lambda<Func<T, bool>>(Expression.Equal(member, constant), parameter);
        }

        /// <summary>
        /// 创建lambda表达式：p=>p.propertyName == propertyValue
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="K">属性值类型，应该为 字符串 或者 整数 或者 日期等数据库可以识别的类型; </typeparam>
        /// <param name="propertyName"></param>
        /// <param name="propertyValue"></param>
        /// <returns></returns>
        public static Expression<Func<T, bool>> CreateEqualLambda<T>(string propertyName, object propertyValue)
        {
            ParameterExpression parameter = Expression.Parameter(typeof(T), "p");//创建参数p
            var expression = CreateEqualExpression<T>(propertyName, propertyValue, parameter);
            return Expression.Lambda<Func<T, bool>>(expression, parameter);
        }

        /// <summary>
        /// 创建 Expression，注意不是 lambda ：p=>  p.Name == "abc"  或者 p=> p.Age!=null && p.Age.Value == 1
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="propertyName"></param>
        /// <param name="propertyValue"></param>
        /// <param name="parameter">外部传入的参数表达式，如果为null,则构建一个新的参数表达式; 参数名称为 p</param>
        /// <returns></returns>
        private static Expression CreateEqualExpression<T>(string propertyName, object propertyValue, ParameterExpression parameter)
        {
            // parameter = parameter??Expression.Parameter(typeof(T), "p");//创建参数p
            MemberExpression member = Expression.PropertyOrField(parameter, propertyName);
            var correctValue = propertyValue;
            if (propertyValue != null)
            {
                if (member.Type.IsGenericType)
                {
                    correctValue = Convert.ChangeType(propertyValue, member.Type.GenericTypeArguments[0]);
                }
                else
                {
                    correctValue = Convert.ChangeType(propertyValue, member.Type);
                }
            }
            ConstantExpression constant = Expression.Constant(correctValue);//创建常数
            if (member.Type.IsGenericType &&   // int?  之类的可空类型; 
                ( (member.Type.GenericTypeArguments[0].IsPrimitive) || (member.Type.GenericTypeArguments[0].IsEnum)))  //允许为 null;
            {
                if (propertyValue != null)
                {
                    ConstantExpression nullConstant = Expression.Constant(null, member.Type);
                    BinaryExpression innerIsTrue = Expression.NotEqual(member, nullConstant);

                    MemberExpression innerValueMember = Expression.PropertyOrField(member, "Value");
                    BinaryExpression innerEquals = Expression.Equal(innerValueMember, constant);

                    return Expression.AndAlso(innerIsTrue, innerEquals);
                }
                else
                {
                    ConstantExpression nullConstant = Expression.Constant(null, member.Type);
                    return Expression.Equal(member, nullConstant);
                }
            }
            //return Expression.Lambda<Func<T, bool>>(Expression.Equal(member, constant), parameter);
            return Expression.Equal(member, constant);
        }

        /// <summary>
        /// 创建lambda表达式：p=>p.propertyName != propertyValue
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="propertyName"></param>
        /// <param name="propertyValue"></param>
        /// <returns></returns>
        public static Expression<Func<T, bool>> CreateNotEqualLambda<T>(string propertyName, string propertyValue)
        {
            ParameterExpression parameter = Expression.Parameter(typeof(T), "p");//创建参数p
            MemberExpression member = Expression.PropertyOrField(parameter, propertyName);
            ConstantExpression constant = Expression.Constant(propertyValue);//创建常数
            return Expression.Lambda<Func<T, bool>>(Expression.NotEqual(member, constant), parameter);
        }
        #endregion

        /// <summary>
        /// 创建lambda表达式：p=>p.propertyName > propertyValue
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="propertyName"></param>
        /// <param name="propertyValue"></param>
        /// <returns></returns>
        public static Expression<Func<T, bool>> CreateGreaterThanLambda<T>(string propertyName, string propertyValue)
        {
            ParameterExpression parameter = Expression.Parameter(typeof(T), "p");//创建参数p
            MemberExpression member = Expression.PropertyOrField(parameter, propertyName);
            ConstantExpression constant = Expression.Constant(propertyValue);//创建常数
            return Expression.Lambda<Func<T, bool>>(Expression.GreaterThan(member, constant), parameter);
        }

        /// <summary>
        /// 创建lambda表达式：p=&gt;> p.Property between 1 and 3
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="propertyName"></param>
        /// <param name="minValue"></param>
        /// <param name="maxValue"></param>
        /// <returns></returns>
        public static Expression<Func<T, bool>> CreateBetweenLambda<T>(string propertyName, object minValue, object maxValue)
        {
            if (minValue == null && maxValue == null) return True<T>();
            ParameterExpression parameter = Expression.Parameter(typeof(T), "p");//创建参数p
            MemberExpression member = Expression.PropertyOrField(parameter, propertyName);

            BinaryExpression minExp = null, maxExp = null;
            if (minValue!=null && !"".Equals(minValue))
            {
                var value = Convert.ChangeType(minValue, member.Type);
                ConstantExpression minConst = Expression.Constant(value);//创建常数
                minExp = Expression.GreaterThanOrEqual(member, minConst);
            }
            if (maxValue!= null && !"".Equals(maxValue))
            {
                var value = Convert.ChangeType(maxValue, member.Type);
                ConstantExpression maxConst = Expression.Constant(value, member.Type);//创建常数
                maxExp = Expression.LessThanOrEqual(member, maxConst);
            }
            if (minExp == null) return Expression.Lambda<Func<T, bool>>(maxExp, parameter);
            else if (maxExp == null) return Expression.Lambda<Func<T, bool>>(minExp, parameter);
            else if (minExp == null && maxExp == null) return True<T>(); //
            else
            {
                return And(Expression.Lambda<Func<T, bool>>(maxExp, parameter), Expression.Lambda<Func<T, bool>>(minExp, parameter));
            }
        }

        /// <summary>
        /// 创建lambda表达式：p=>p.propertyName 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="propertyName"></param>
        /// <param name="propertyValue"></param>
        /// <returns></returns>
        public static Expression<Func<T, bool>> CreateLessThanLambda<T>(string propertyName, string propertyValue)
        {
            ParameterExpression parameter = Expression.Parameter(typeof(T), "p");//创建参数p
            MemberExpression member = Expression.PropertyOrField(parameter, propertyName);
            ConstantExpression constant = Expression.Constant(propertyValue);//创建常数
            return Expression.Lambda<Func<T, bool>>(Expression.LessThan(member, constant), parameter);
        }

        /// <summary>
        /// 创建lambda表达式：p=>p.propertyName >= propertyValue
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="propertyName"></param>
        /// <param name="propertyValue"></param>
        /// <returns></returns>
        public static Expression<Func<T, bool>> CreateGreaterThanOrEqualLambda<T>(string propertyName, string propertyValue)
        {
            ParameterExpression parameter = Expression.Parameter(typeof(T), "p");//创建参数p
            MemberExpression member = Expression.PropertyOrField(parameter, propertyName);
            ConstantExpression constant = Expression.Constant(propertyValue);//创建常数
            return Expression.Lambda<Func<T, bool>>(Expression.GreaterThanOrEqual(member, constant), parameter);
        }

        /// <summary>
        /// 创建lambda表达式：p=>p.propertyName
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="propertyName"></param>
        /// <param name="propertyValue"></param>
        /// <returns></returns>
        public static Expression<Func<T, bool>> CreateLessThanOrEqual<T>(string propertyName, string propertyValue)
        {
            ParameterExpression parameter = Expression.Parameter(typeof(T), "p");//创建参数p
            MemberExpression member = Expression.PropertyOrField(parameter, propertyName);
            ConstantExpression constant = Expression.Constant(propertyValue);//创建常数
            return Expression.Lambda<Func<T, bool>>(Expression.LessThanOrEqual(member, constant), parameter);
        }

        /// <summary>
        /// 创建lambda表达式：p=>p.propertyName.Contains(propertyValue)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="propertyName"></param>
        /// <param name="propertyValue"></param>
        /// <returns></returns>
        public static Expression<Func<T, bool>> CreatePropertyContains<T>(string propertyName, string propertyValue)
        {
            ParameterExpression parameter = Expression.Parameter(typeof(T), "p");
            MemberExpression member = Expression.PropertyOrField(parameter, propertyName);
            MethodInfo method = typeof(string).GetMethod("Contains", new[] { typeof(string) });
            ConstantExpression constant = Expression.Constant(propertyValue, typeof(string));
            var contains = Expression.Lambda<Func<T, bool>>(Expression.Call(member, method, constant), parameter);
            var notnull = CreateNotEqualLambda<T>(propertyName, null);
            return And(contains, notnull);
        }

        /// <summary>
        /// 创建lambda表达式：!(p=>p.propertyName.Contains(propertyValue))
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="propertyName"></param>
        /// <param name="propertyValue"></param>
        /// <returns></returns>
        private static Expression<Func<T, bool>> CreatePropertyNotContains<T>(string propertyName, string propertyValue)
        {
            ParameterExpression parameter = Expression.Parameter(typeof(T), "p");
            MemberExpression member = Expression.PropertyOrField(parameter, propertyName);
            MethodInfo method = typeof(string).GetMethod("Contains", new[] { typeof(string) });
            ConstantExpression constant = Expression.Constant(propertyValue, typeof(string));
            return Expression.Lambda<Func<T, bool>>(Expression.Not(Expression.Call(member, method, constant)), parameter);
        }
        #endregion

        #region 表达式And_Or操作   https://stackoverflow.com/questions/8289836/the-dreaded-parameter-was-not-bound-in-the-specified-linq-to-entities-query-exp
        // 错误 https://blog.csdn.net/nabila/article/details/8137169

            /// <summary>
            /// 合并连个表达式
            /// </summary>
            /// <typeparam name="T"></typeparam>
            /// <param name="first"></param>
            /// <param name="second"></param>
            /// <param name="merge"></param>
            /// <returns></returns>
        private static Expression<T> Compose<T>(this Expression<T> first,
            Expression<T> second, Func<Expression, Expression, Expression> merge)
        {
            var map = first.Parameters.Select((f, i) => new { f, s = second.Parameters[i] }).ToDictionary(p => p.s, p => p.f);

            var secondRebound = ParameterRebinder.ReplaceParameters(map, second) as LambdaExpression;

            return Expression.Lambda<T>(merge(first.Body, secondRebound.Body), first.Parameters);
        }

        /// <summary>
        /// 对表达式进行 And 操作
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public static Expression<Func<T, bool>> And<T>(this Expression<Func<T, bool>> first, Expression<Func<T, bool>> second)
        {
            return first.Compose(second, Expression.And);
        }

        /// <summary>
        /// 对表达式进行 Or 操作
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public static Expression<Func<T, bool>> Or<T>(this Expression<Func<T, bool>> first, Expression<Func<T, bool>> second)
        {
            return first.Compose(second, Expression.Or);
        }


        #endregion

        #region 产生someList.where(c=>c.Name.contains("someName")||c.Name.Contains("someName")类似表达式
        /// <summary>
        /// 扩展方法; 
        /// http://www.soaspx.com/dotnet/csharp/csharp_20120223_8643.html
        /// 产生形如的表达式 c=> c.Name=='123' || c.Name=='456'; 或者
        ///                  c=> c.Age == 18 || c.Age == 19 或者 
        ///                  c=> ((c.Sex!=null &amp;&amp; c.Sex.Value==0) || (c.Sex!=null &amp;&amp; c.Sex.Value==1)) 之类的代码
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="options"></param>
        /// <param name="fieldName"></param>
        /// <returns></returns>
        public static Expression<Func<T, bool>> GetMultiOrConditionExpression<T>(object[] options, string fieldName)
        {
            if (options.Length == 0) throw new Exception("options must not be a empty array");
            ParameterExpression left = Expression.Parameter(typeof(T), "c");//c=>  左表达式
            var expression = CreateEqualExpression<T>(fieldName, options[0], left);
            for (var index=1; index<options.Length; index++)
            {
                var secondExpression = CreateEqualExpression<T>(fieldName, options[index], left);
                expression = Expression.OrElse(expression, secondExpression);
            }
            return Expression.Lambda<Func<T,bool>>(expression, left);
        }

        /// <summary>
        /// 扩展方法; 
        /// http://www.soaspx.com/dotnet/csharp/csharp_20120223_8643.html
        /// 产生形如的表达式 someList.where(c=>c.Name.contains("someName")||c.Name.Contains("someName")
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="options"></param>
        /// <param name="fieldName"></param>
        /// <returns></returns>
        public static Expression<Func<T, bool>> GetMultiContainsOrExpression<T>(string[] options, string fieldName)
        {
            ParameterExpression left = Expression.Parameter(typeof(T), "c");//c=>  左表达式
            Expression expression = Expression.Constant(false);   // c=> false || 
            foreach (var optionName in options)
            {
                var expActionField = Expression.Property(left, typeof(T).GetProperty(fieldName));
                Expression right = Expression.Call
                       (
                          expActionField,  //c.DataSourceName
                          typeof(string).GetMethod("Contains", new Type[] { typeof(string) }),// 反射使用.Contains()方法                         
                          Expression.Constant(optionName)           // .Contains(optionName)
                       );

                expression = Expression.Or(right, expression);//c.DataSourceName.contain("") || c.DataSourceName.contain("") 
            }
            Expression<Func<T, bool>> finalExpression
                = Expression.Lambda<Func<T, bool>>(expression, new ParameterExpression[] { left });
            return finalExpression;
        }

        /// <summary>
        /// 扩展方法; 
        /// http://www.soaspx.com/dotnet/csharp/csharp_20120223_8643.html
        /// 产生形如如下形式的表达式， 例如， 
        /// someList.Where(c=> c.fieldName.secondFiledName.contains(options[0]) || c.fieldName.secondFiledName.contains(options[1])
        /// someList.where(c=>c.Name.contains("someName")||c.Name.Contains("someName")
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="KFirstFieldType"></typeparam>
        /// <param name="options"></param>
        /// <param name="firstFieldName"></param>
        /// <param name="secondFieldName"></param>
        /// <returns></returns>
        public static Expression<Func<T, bool>> GetMultiContainsOrExpression<T, KFirstFieldType>(string[] options, string firstFieldName, string secondFieldName = null)
        {
            ParameterExpression left = Expression.Parameter(typeof(T), "c");//c=>  左表达式
            Expression expression = Expression.Constant(false);   // c=> false || 
            foreach (var optionName in options)
            {
                var expActionField = Expression.Property(left, typeof(T).GetProperty(firstFieldName));
                if (!string.IsNullOrEmpty(secondFieldName))
                {
                    expActionField = Expression.Property(expActionField, typeof(KFirstFieldType).GetProperty(secondFieldName));
                }
                Expression right = Expression.Call
                       (
                          expActionField,  //c.DataSourceName
                          typeof(string).GetMethod("Contains", new Type[] { typeof(string) }),// 反射使用.Contains()方法                         
                          Expression.Constant(optionName)           // .Contains(optionName)
                       );

                expression = Expression.Or(right, expression);//c.DataSourceName.contain("") || c.DataSourceName.contain("") 
            }
            Expression<Func<T, bool>> finalExpression
                = Expression.Lambda<Func<T, bool>>(expression, new ParameterExpression[] { left });
            return finalExpression;
        }


        /// <summary>
        /// 扩展方法; 
        /// http://www.soaspx.com/dotnet/csharp/csharp_20120223_8643.html
        /// 产生形如如下形式的表达式， 例如， 
        /// someList.Where(c=> c.fieldName.secondFiledName.contains(options[0]) || c.fieldName.secondFiledName.contains(options[1])
        /// someList.where(c=>c.Name.contains("someName")||c.Name.Contains("someName")
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="options"></param>
        /// <param name="firstFieldName"></param>
        /// <param name="secondFieldName"></param>
        /// <returns></returns>
        public static Expression<Func<T, bool>> GetMultiContainsOrExpression<T>(string[] options, string firstFieldName, string secondFieldName = null)
        {
            ParameterExpression left = Expression.Parameter(typeof(T), "c");//c=>  左表达式
            Expression expression = Expression.Constant(false);   // c=> false || 
            foreach (var optionName in options)
            {
                var expActionField = Expression.Property(left, typeof(T).GetProperty(firstFieldName));
                if (!string.IsNullOrEmpty(secondFieldName))
                {
                    var firstFildType = typeof(T).GetProperty(firstFieldName).PropertyType;
                    expActionField = Expression.Property(expActionField, firstFildType.GetProperty(secondFieldName));
                }
                Expression right = Expression.Call
                       (
                          expActionField,  //c.DataSourceName
                          typeof(string).GetMethod("Contains", new Type[] { typeof(string) }),// 反射使用.Contains()方法                         
                          Expression.Constant(optionName)           // .Contains(optionName)
                       );

                expression = Expression.Or(right, expression);//c.DataSourceName.contain("") || c.DataSourceName.contain("") 
            }
            Expression<Func<T, bool>> finalExpression
                = Expression.Lambda<Func<T, bool>>(expression, new ParameterExpression[] { left });
            return finalExpression;
        }


        /// <summary>
        /// 扩展方法; 
        /// http://www.soaspx.com/dotnet/csharp/csharp_20120223_8643.html
        /// 产生形如的表达式 someList.where(c=>c.Name.contains("someName")||c.Name.Contains("someName")
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="K"></typeparam>
        /// <typeparam name="X"></typeparam>
        /// <param name="options"></param>
        /// <param name="fieldName"></param>
        /// <param name="secondFieldName"></param>
        /// <param name="thirdFiledName"></param>
        /// <returns></returns>
        public static Expression<Func<T, bool>> GetConditionExpression<T, K, X>(string[] options, string fieldName, string secondFieldName = null,
              string thirdFiledName = null)
        {
            if (string.IsNullOrEmpty(thirdFiledName)) return GetMultiContainsOrExpression<T, K>(options, fieldName, secondFieldName);
            ParameterExpression left = Expression.Parameter(typeof(T), "c");//c=>  左表达式
            Expression expression = Expression.Constant(false);   // c=> false || 
            foreach (var optionName in options)
            {
                var expActionField = Expression.Property(left, typeof(T).GetProperty(fieldName));
                    expActionField = Expression.Property(expActionField, typeof(K).GetProperty(secondFieldName));
                expActionField = Expression.Property(expActionField, typeof(X).GetProperty(thirdFiledName));
                Expression right = Expression.Call
                       (
                          expActionField,  //c.DataSourceName
                          typeof(string).GetMethod("Contains", new Type[] { typeof(string) }),// 反射使用.Contains()方法                         
                          Expression.Constant(optionName)           // .Contains(optionName)
                       );

                expression = Expression.Or(right, expression);//c.DataSourceName.contain("") || c.DataSourceName.contain("") 
            }
            Expression<Func<T, bool>> finalExpression
                = Expression.Lambda<Func<T, bool>>(expression, new ParameterExpression[] { left });
            return finalExpression;
        }

        // <summary>
        // 扩展方法; 
        // http://www.soaspx.com/dotnet/csharp/csharp_20120223_8643.html
        // 产生形如的表达式 someList.where(c=>c.Name.contains("someName")||c.Name.Contains("someName")
        // </summary>
        // <typeparam name="T"></typeparam>
        // <param name="options"></param>
        // <param name="fieldName"></param>
        // <returns></returns>
        /*public static Expression<Func<T, bool>> GetConditionExpression<T>(string[] options, Expression<Func<T,string,bool>> express)
        {
            ParameterExpression left = Expression.Parameter(typeof(T), "c");//c=>
            Expression expression = Expression.Constant(false);
            foreach (var optionName in options)
            {
                //Expression<Func<T, bool>> right = (t) => func(t, optionName);
                //Expression <Func<T, bool>> right = new Expression < Func<T, bool> >( tfunc); // func;
                //Expression<Func<T, bool>> right = Expression.Call(tfunc); // func;
                expression = Expression.Or(express, expression);//c.DataSourceName.contain("") || c.DataSourceName.contain("") 
            }
            Expression<Func<T, bool>> finalExpression
                = Expression.Lambda<Func<T, bool>>(expression, new ParameterExpression[] { left });
            return finalExpression;
        }*/
        #endregion
    }
}
