using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.Json.ValueProvider
{
    /// <summary>
    /// 固定值的 ValueProvider
    /// </summary>
    public class FixedValueProvider : IValueProvider
    {
        Object val;
        PropertyInfo prop;
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="val"></param>
        /// <param name="prop"></param>
        public FixedValueProvider(object val, PropertyInfo prop)
        {
            this.val = val;
            this.prop = prop;
        }
        /// <summary>
        /// 返回固定值;
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
        public object GetValue(object target)
        {
            return val;
        }
        /// <summary>
        /// 不设置,
        /// </summary>
        /// <param name="target"></param>
        /// <param name="value"></param>
        public void SetValue(object target, object value)
        {
            if (target == null) return;
            if (prop == null) return;
            if (!prop.CanWrite) return;
            prop.SetValue(target, this.val);
        }
    }
}
