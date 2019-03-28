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

    public class YouzanRetailStockStockcheckUpdateParams : APIParams, FileParams
	{

		/// <summary>
		/// 盘点单单号
		/// </summary>
		private string businessOrderNo;
		/// <summary>
		/// 是否完成盘点
		/// </summary>
		private bool? isFinish;
		/// <summary>
		/// 备注
		/// </summary>
		private string remark;
		/// <summary>
		/// 请求来源（需调用方自定义标识：OPEN_XXXX）
		/// </summary>
		private string source;
		/// <summary>
		/// 列表
		/// </summary>
		private string updateItems;

		public virtual string BusinessOrderNo
		{
			set
			{
				this.businessOrderNo = value;
			}
			get
			{
				return this.businessOrderNo;
			}
		}


		public virtual bool? IsFinish
		{
			set
			{
				this.isFinish = value;
			}
			get
			{
				return this.isFinish;
			}
		}


		public virtual string Remark
		{
			set
			{
				this.remark = value;
			}
			get
			{
				return this.remark;
			}
		}


		public virtual string Source
		{
			set
			{
				this.source = value;
			}
			get
			{
				return this.source;
			}
		}


		public virtual string UpdateItems
		{
			set
			{
				this.updateItems = value;
			}
			get
			{
				return this.updateItems;
			}
		}



		public virtual IDictionary<string, object> toParams()
		{
			IDictionary<string, object> @params = Maps.newHashMap();
			if (!string.ReferenceEquals(businessOrderNo, null))
			{
				@params["business_order_no"] = businessOrderNo;
			}
			if (isFinish != null)
			{
				@params["is_finish"] = isFinish;
			}
			if (!string.ReferenceEquals(remark, null))
			{
				@params["remark"] = remark;
			}
			if (!string.ReferenceEquals(source, null))
			{
				@params["source"] = source;
			}
			if (!string.ReferenceEquals(updateItems, null))
			{
				@params["update_items"] = updateItems;
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