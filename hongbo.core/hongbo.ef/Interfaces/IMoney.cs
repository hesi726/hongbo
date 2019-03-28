using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#if NETCOREAPP2_2
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DbModelBuilder = Microsoft.EntityFrameworkCore.ModelBuilder;
#else
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
#endif

namespace hongbao.EntityExtension
{
    /// <summary>
    /// 
    /// </summary>
    public interface IMoney
    {
        /// <summary>
        /// 实际支付的金额 或者 折后金额
        /// </summary>
        decimal Money { get; set;  }

        /// <summary>
        /// 商品金额 或者 折扣前金额
        /// </summary>
        decimal FullMoney { get; set; }
    }

    /// <summary>
    /// 货币的精度设置；
    /// </summary>
    public class MoneyConfiguration<T> :  AbstractEntityConfiguration<T>
        where T : class, IMoney
    {
        /// <summary>
        /// 
        /// </summary>
        public MoneyConfiguration()
        {
            AddConfigurationAction((builder) =>
            {
                HasPrecision(builder.Property((x) => x.Money), 14, 2);
                HasPrecision(builder.Property((x) => x.FullMoney), 14, 2);
            });
        }

    }
}
