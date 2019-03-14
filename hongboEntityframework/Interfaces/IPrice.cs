using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.EntityExtension
{
    /// <summary>
    /// 
    /// </summary>
    public interface IPrice
    {
        /// <summary>
        /// 全价 
        /// </summary>
        decimal FullPrice { get; set; }

        /// <summary>
        /// 折后价格
        /// </summary>
        decimal Price { get; set; }
    }

    /// <summary>
    /// 货币的精度设置；
    /// </summary>
    public class PriceConfiguration<T> : AbstractEntityConfiguration<T>
        where T : class, IPrice
    {
        /// <summary>
        /// 
        /// </summary>
        public PriceConfiguration()
        {
            AddConfigurationAction((builder) =>
            {
                HasPrecision(builder.Property((x) => x.Price), 14, 2);
                HasPrecision(builder.Property((x) => x.FullPrice), 14, 2);
            });
        }

       
    }

    /// <summary>
    /// 货币的精度设置；
    /// </summary>
    public class PriceMoneyConfiguration<T> : AbstractEntityConfiguration<T>
        where T : class, IPrice, IMoney
    {
        /// <summary>
        /// 
        /// </summary>
        public PriceMoneyConfiguration()
        {
            AddConfigurationAction((builder) =>
            {
                HasPrecision(builder.Property((x) => x.Price), 14, 2);
                HasPrecision(builder.Property((x) => x.Money), 14, 2);
                HasPrecision(builder.Property((x) => x.FullPrice), 14, 2);
                HasPrecision(builder.Property((x) => x.FullMoney), 14, 2);
            });
            //    Property((x) => x.Price).HasPrecision(14, 2);
            //Property((x) => x.Price).HasPrecision(14, 2);
            //Property((x) => x.Money).HasPrecision(14, 2);
            //Property((x) => x.Money).HasPrecision(14, 2);
        }
    }
}
