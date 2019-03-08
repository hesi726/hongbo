using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hongbao.CollectionExtension;
using Jint;
using Jint.Native;
using Jint.Parser;
using Jint.Parser.Ast;

namespace hongbao.ScriptExtension
{
    /// <summary>
    /// 利用 IronJs 解析 javascript 脚本并运行函数的类;
    /// http://www.cnblogs.com/comsokey/archive/2013/01/24/IrconJS.html
    /// http://www.cnblogs.com/kklldog/p/3417219.html
    /// </summary>
    public class JavaScriptParce : IDisposable
    {
        ///// <summary>
        ///// 
        ///// </summary>
        //public CSharp.Context Context { get; private set; }

        private Engine engine = null;
        //private JavaScriptParser parser = null;
        //private Program jsProgram = null;
        //private string content = null;
        /// <summary>
        /// 构造函数;
        /// https://github.com/sebastienros/jint
        /// </summary>
        /// <param name="content"></param>
        public JavaScriptParce(string content)
        {
            engine = new Engine().Execute(content);
        }

       
        /// <summary>
        /// 注意, 返回结果 只能使用在javascript中定义的类型，例如：
        /// double, array, string, bool
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <typeparam name="TParA"></typeparam>
        /// <param name="methodName"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public object RunFunction(string methodName, params object[] a)
        {
            var add = engine.GetValue(methodName);
            JsValue[] par = a == null ? new JsValue[] { } : a.Select(x =>
               {
                   if (x == null) return null;
                   else if (x.GetType() == typeof(string)) return (JsValue)(string)x;
                   else if (x.GetType() == typeof(double)) return (JsValue)(double)x;
                   else if (x.GetType() == typeof(int)) return (JsValue)(int)x;
                   else if (x.GetType() == typeof(long)) return (JsValue)(long)x;
                   else if (x.GetType() == typeof(float)) return (JsValue)(float)x;
                   else if (x.GetType() == typeof(decimal)) return (JsValue)(double)x;
                   else if (x.GetType() == typeof(bool)) return (JsValue)(bool)x;
                   else
                   {
                       throw new Exception("不支持传入对象");
                   }
               }).ToArray();
            var xresult = add.Invoke(par);
            if (xresult.IsNull() || xresult.IsUndefined()) return null;
            else if (xresult.IsString()) return xresult.AsString();
            else if (xresult.IsNumber()) return xresult.AsNumber();
            else if (xresult.IsBoolean()) return xresult.AsBoolean();
            else if (xresult.IsRegExp()) return xresult.AsRegExp().Value;
            else if (xresult.IsArray()) return xresult.AsArray();
            else return xresult.AsObject();

            //return engine.
            //var func = jsProgram.FunctionDeclarations.First(a => a.Id.Name == methodName);
            //func.
            //Func<TParA, TResult> func = Context.GetFunctionAs<Func<TParA, TResult>>(methodName);
            //return func(a);
        }

        ///// <summary>
        ///// 注意,TResult, TParA 只能使用在javascript中定义的类型，例如：
        ///// double, array, string (没有 int)
        ///// </summary>
        ///// <typeparam name="TResult"></typeparam>
        ///// <typeparam name="TParA"></typeparam>
        ///// <typeparam name="TParB"></typeparam>
        ///// <param name="methodName"></param>
        ///// <param name="a"></param>
        ///// <param name="c"></param>
        ///// <returns></returns>
        //public TResult RunFunction<TResult, TParA, TParB>(string methodName, TParA a, TParB c)
        //{
        //    Func<TParA, TParB, TResult> func = Context.GetFunctionAs<Func<TParA, TParB, TResult>>(methodName);
        //    return func(a, c);
        //}

        ///// <summary>
        ///// 注意,TResult, TParA 只能使用在javascript中定义的类型，例如：
        ///// double, array, string (没有 int)
        ///// </summary>
        ///// <typeparam name="TResult"></typeparam>
        ///// <typeparam name="TParA"></typeparam>
        ///// <typeparam name="TParB"></typeparam>
        ///// <typeparam name="TParC"></typeparam>
        ///// <param name="methodName"></param>
        ///// <param name="a"></param>
        ///// <param name="b"></param>
        ///// <param name="c"></param>
        ///// <returns></returns>
        //public TResult RunFunction<TResult, TParA, TParB, TParC>(string methodName, TParA a, TParB b, TParC c)
        //{
        //    Func<TParA, TParB, TParC, TResult> func =
        //        Context.GetFunctionAs<Func<TParA, TParB, TParC, TResult>>(methodName);
        //    return func(a, b, c);
        //}

        ///// <summary>
        ///// 注意,TResult, TParA 只能使用在javascript中定义的类型，例如：
        ///// double, array, string (没有 int)
        ///// </summary>
        ///// <typeparam name="TResult"></typeparam>
        ///// <typeparam name="TParA"></typeparam>
        ///// <typeparam name="TParB"></typeparam>
        ///// <typeparam name="TParC"></typeparam>
        ///// <typeparam name="TParD"></typeparam>
        ///// <param name="methodName"></param>
        ///// <param name="a"></param>
        ///// <param name="b"></param>
        ///// <param name="c"></param>
        ///// <param name="d"></param>
        ///// <returns></returns>
        //public TResult RunFunction<TResult, TParA, TParB, TParC, TParD>(string methodName, TParA a, TParB b, TParC c, TParD d)
        //{
        //    Func<TParA, TParB, TParC, TParD, TResult> func =
        //        Context.GetFunctionAs<Func<TParA, TParB, TParC, TParD, TResult>>(methodName);
        //    return func(a, b, c,d );
        //}

        ///// <summary>
        ///// 注意,TResult, TParA 只能使用在javascript中定义的类型，例如：
        ///// double, array, string (没有 int)
        ///// </summary>
        ///// <typeparam name="TResult"></typeparam>
        ///// <typeparam name="TParA"></typeparam>
        ///// <typeparam name="TParB"></typeparam>
        ///// <typeparam name="TParC"></typeparam>
        ///// <typeparam name="TParD"></typeparam>
        ///// <typeparam name="TParE"></typeparam>
        ///// <param name="methodName"></param>
        ///// <param name="a"></param>
        ///// <param name="b"></param>
        ///// <param name="c"></param>
        ///// <param name="d"></param>
        ///// <param name="e"></param>
        ///// <returns></returns>
        //public TResult RunFunction<TResult, TParA, TParB, TParC, TParD,TParE>(string methodName, TParA a, TParB b, TParC c, TParD d, TParE e)
        //{
        //    Func<TParA, TParB, TParC, TParD, TParE, TResult> func =
        //        Context.GetFunctionAs<Func<TParA, TParB, TParC, TParD, TParE, TResult>>(methodName);
        //    return func(a, b, c, d, e);
        //}


        /*
        /// <summary>
        /// 获取js方法
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name=""></param>
        /// <returns></returns>
         public T GetFunction<T>(string methodName)
             where T:System.Delegate
         {
             return context.GetFunctionAs<T>(methodName);

             var fun = context.GetFunctionAs<Func<double, double, double>>(methodName);
             return fun;
           
        double a = Double.Parse(this.tbxA.Text);
        double b = Double.Parse(this.tbxB.Text);
        var result = fun.Invoke(a, b);
        this.tbxResult.Text = result.ToString();
        */

            /// <summary>
            /// 
            /// </summary>
        public void Dispose()
        {
            this.engine = null;
        }
    }
}
