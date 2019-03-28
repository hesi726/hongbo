using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using hongbao.SecurityExtension;
using hongbao.Json;
using StackExchange.Redis;
using Newtonsoft.Json;
using hongbao.Vue.Attributes;
using hongbao.CollectionExtension;
#if NETCOREAPP2_2
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
#else
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Configuration;
#endif
namespace hongbao.EntityExtension
{
#if NETCOREAPP2_2
    /// <summary>
    /// 货币的精度设置；
    /// </summary>
    public abstract class AbstractEntityConfiguration<T> : IEntityTypeConfiguration<T>
        where T : class
    {
        

        /// <summary>
        /// 
        /// </summary>
        public AbstractEntityConfiguration()
        {
            
        }

        Action<EntityTypeBuilder<T>> actions = null;

        public void AddConfigurationAction(Action<EntityTypeBuilder<T>> action)
        {
            actions += action;
        }

        public void Configure(EntityTypeBuilder<T> builder)
        {
           if (actions != null)
            {
                actions(builder);
            }
        }

        public PropertyBuilder<decimal> HasPrecision(PropertyBuilder<decimal> propertyBuilder, byte size, byte precision)
        {
            HasPrecision(((IInfrastructure<InternalPropertyBuilder>)propertyBuilder).Instance, size, precision);
            return propertyBuilder;
        }

        private InternalPropertyBuilder HasPrecision(InternalPropertyBuilder propertyBuilder, byte precision, byte scale)
        {
            propertyBuilder.Relational(ConfigurationSource.Explicit).HasColumnType($"decimal({precision},{scale})");
            return propertyBuilder;
        }
    }
#else
    /// <summary>
    /// 货币的精度设置；
    /// </summary>
    public class AbstractEntityConfiguration<T> : EntityTypeConfiguration<T>
        where T : class
    {
        /// <summary>
        /// 
        /// </summary>
        public AbstractEntityConfiguration()
        {
            
        }

        public void AddConfigurationAction(Action<EntityTypeConfiguration<T>> action)
        {
            action(this);
        }

        public DecimalPropertyConfiguration HasPrecision(DecimalPropertyConfiguration propertyBuilder, byte size, byte precision)
        {
            propertyBuilder.HasPrecision(size, precision);
            return propertyBuilder;
        }
    }
#endif
}
