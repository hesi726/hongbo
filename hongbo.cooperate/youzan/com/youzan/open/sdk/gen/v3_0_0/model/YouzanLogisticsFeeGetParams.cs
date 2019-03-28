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

    public class YouzanLogisticsFeeGetParams : APIParams, FileParams
	{

		/// <summary>
		/// 城市名称
		/// </summary>
		private string cityName;
		/// <summary>
		/// 区县名称
		/// </summary>
		private string countyName;
		/// <summary>
		/// 交易商品列表
		/// </summary>
		private string itemParamList;
		/// <summary>
		/// 订单号
		/// </summary>
		private string orderNo;
		/// <summary>
		/// 省份名称
		/// </summary>
		private string provinceName;

		public virtual string CityName
		{
			set
			{
				this.cityName = value;
			}
			get
			{
				return this.cityName;
			}
		}


		public virtual string CountyName
		{
			set
			{
				this.countyName = value;
			}
			get
			{
				return this.countyName;
			}
		}


		public virtual string ItemParamList
		{
			set
			{
				this.itemParamList = value;
			}
			get
			{
				return this.itemParamList;
			}
		}


		public virtual string OrderNo
		{
			set
			{
				this.orderNo = value;
			}
			get
			{
				return this.orderNo;
			}
		}


		public virtual string ProvinceName
		{
			set
			{
				this.provinceName = value;
			}
			get
			{
				return this.provinceName;
			}
		}



		public virtual IDictionary<string, object> toParams()
		{
			IDictionary<string, object> @params = Maps.newHashMap();
			if (!string.ReferenceEquals(cityName, null))
			{
				@params["city_name"] = cityName;
			}
			if (!string.ReferenceEquals(countyName, null))
			{
				@params["county_name"] = countyName;
			}
			if (!string.ReferenceEquals(itemParamList, null))
			{
				@params["item_param_list"] = itemParamList;
			}
			if (!string.ReferenceEquals(orderNo, null))
			{
				@params["order_no"] = orderNo;
			}
			if (!string.ReferenceEquals(provinceName, null))
			{
				@params["province_name"] = provinceName;
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