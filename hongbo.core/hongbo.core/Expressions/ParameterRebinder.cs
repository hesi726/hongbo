using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.Expressions
{
    /// <summary>
    /// 表达式参数重新绑定的类;
    /// </summary>
    public class ParameterRebinder : ExpressionVisitor
    {
        private readonly Dictionary<ParameterExpression, ParameterExpression> map;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="map"></param>
        public ParameterRebinder(Dictionary<ParameterExpression, ParameterExpression> map)
        {
            this.map = map ?? new Dictionary<ParameterExpression, ParameterExpression>();
        }

        /// <summary>
        /// 替换表达式中的参数
        /// </summary>
        /// <param name="map"></param>
        /// <param name="exp"></param>
        /// <returns></returns>
        public static Expression ReplaceParameters(Dictionary<ParameterExpression, ParameterExpression> map, Expression exp)
        {
            return new ParameterRebinder(map).Visit(exp);
        }

        /// <summary>
        /// 访问表达中的参数
        /// </summary>
        /// <param name="parmEx"></param>
        /// <returns></returns>
        protected override Expression VisitParameter(ParameterExpression parmEx)
        {
            ParameterExpression replacement;
            if (map.TryGetValue(parmEx, out replacement))
            {
                parmEx = replacement;
            }

            return base.VisitParameter(parmEx);
        }
    }
}
