using System.Collections.Generic;

namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////	using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;
    using global::youzan.com.youzan.open.sdk.model;

    ////	using Maps = com.google.common.collect.Maps;


    ////	using Multimap = com.google.common.collect.Multimap;


    using APIParams = com.youzan.open.sdk.model.APIParams;
    using ByteWrapper = com.youzan.open.sdk.model.ByteWrapper;
    using FileParams = com.youzan.open.sdk.model.FileParams;

    public class YouzanLogisticsTemplateCreateParams : APIParams, FileParams
	{

		/// <summary>
		/// 模板名称
		/// </summary>
		private string name;
		/// <summary>
		/// 付费类型
		/// </summary>
		private long? payType;
		/// <summary>
		/// 运费规则 json格式，转换成 List<ValuationRule>
		/// </summary>
		private string valuationRules;
		/// <summary>
		/// 计算类型
		/// </summary>
		private long? valuationType;

		public virtual string Name
		{
			set
			{
				this.name = value;
			}
			get
			{
				return this.name;
			}
		}


		public virtual long? PayType
		{
			set
			{
				this.payType = value;
			}
			get
			{
				return this.payType;
			}
		}


		public virtual string ValuationRules
		{
			set
			{
				this.valuationRules = value;
			}
			get
			{
				return this.valuationRules;
			}
		}


		public virtual long? ValuationType
		{
			set
			{
				this.valuationType = value;
			}
			get
			{
				return this.valuationType;
			}
		}



		public virtual IDictionary<string, object> toParams()
		{
			IDictionary<string, object> @params = Maps.newHashMap();
			if (!string.ReferenceEquals(name, null))
			{
				@params["name"] = name;
			}
			if (payType != null)
			{
				@params["pay_type"] = payType;
			}
			if (!string.ReferenceEquals(valuationRules, null))
			{
				@params["valuation_rules"] = valuationRules;
			}
			if (valuationType != null)
			{
				@params["valuation_type"] = valuationType;
			}
			return @params;
		}

		public virtual IDictionary<string,ByteWrapper> toFileParams()
		{
			Multimap<string, ByteWrapper> @params = ArrayListMultimap.create<string, ByteWrapper>();

				return @params;
		}


	}
}