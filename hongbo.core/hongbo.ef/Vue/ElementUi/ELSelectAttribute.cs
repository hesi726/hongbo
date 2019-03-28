using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.Vue.ElementUi
{
    /// <summary>
    /// 标记类，实现此接口的实体类，将自动产生一个 Select 组件;
    /// 例如  EH_Owner, 将产生 EH_OwnerSelect 组件, 
    /// 去掉第一个前缀;
    /// 此组件继承自 ElementUI.Select 组件，
    /// 但是在 created 方法中，根据 SelectAttribute 属性的定义，覆盖了其一些属性;
    /// </summary>
    public class ELSelectAttribute : Attribute
    {
        ///// <summary>
        ///// 是否允许多选;
        ///// 去掉此属性，因为可能存在这样的情况，查询时需要多选，但注册时只能够单选;
        ///// 这样，组件就不能定义 Multiple 这个属性;
        ///// </summary>
        //public bool Multiple { get; set; }

        /// <summary>
        /// 远程加载数据，否则，一次性加载数据
        /// </summary>
        public bool Remote { get; set; }
    }
}
