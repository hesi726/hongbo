using System;
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

    public class YouzanUmpCouponConsumeFetchlogsGetParams : APIParams, FileParams
	{

		/// <summary>
		/// 优惠券/优惠码id
		/// </summary>
		private long? couponGroupId;
		/// <summary>
		/// 按照领取时间筛选（结束时间）格式：'2017-09-09 17:12:41'
		/// </summary>
		private DateTime endTaked;
		/// <summary>
		/// 页码
		/// </summary>
		private long? pageNo;
		/// <summary>
		/// 每页数量，最大值500
		/// </summary>
		private long? pageSize;
		/// <summary>
		/// 按照领取时间筛选（开始时间）格式：'2017-09-09 17:12:41'
		/// </summary>
		private DateTime startTaked;

		public virtual long? CouponGroupId
		{
			set
			{
				this.couponGroupId = value;
			}
			get
			{
				return this.couponGroupId;
			}
		}


		public virtual DateTime EndTaked
		{
			set
			{
				this.endTaked = value;
			}
			get
			{
				return this.endTaked;
			}
		}


		public virtual long? PageNo
		{
			set
			{
				this.pageNo = value;
			}
			get
			{
				return this.pageNo;
			}
		}


		public virtual long? PageSize
		{
			set
			{
				this.pageSize = value;
			}
			get
			{
				return this.pageSize;
			}
		}


		public virtual DateTime StartTaked
		{
			set
			{
				this.startTaked = value;
			}
			get
			{
				return this.startTaked;
			}
		}



		public virtual IDictionary<string, object> toParams()
		{
			IDictionary<string, object> @params = Maps.newHashMap();
			if (couponGroupId != null)
			{
				@params["coupon_group_id"] = couponGroupId;
			}
			if (endTaked != null)
			{
				@params["end_taked"] = endTaked;
			}
			if (pageNo != null)
			{
				@params["page_no"] = pageNo;
			}
			if (pageSize != null)
			{
				@params["page_size"] = pageSize;
			}
			if (startTaked != null)
			{
				@params["start_taked"] = startTaked;
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