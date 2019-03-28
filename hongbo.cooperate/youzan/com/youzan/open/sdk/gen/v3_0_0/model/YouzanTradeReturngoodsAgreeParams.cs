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

    public class YouzanTradeReturngoodsAgreeParams : APIParams, FileParams
	{

		/// <summary>
		/// 收货地址
		/// </summary>
		private string address;
		/// <summary>
		/// 收货手机号
		/// </summary>
		private string mobile;
		/// <summary>
		/// 收货人
		/// </summary>
		private string name;
		/// <summary>
		/// 邮编
		/// </summary>
		private long? post;
		/// <summary>
		/// 退款ID
		/// </summary>
		private string refundId;
		/// <summary>
		/// 说明
		/// </summary>
		private string remark;
		/// <summary>
		/// 收货电话
		/// </summary>
		private string tel;
		/// <summary>
		/// 退款版本号
		/// </summary>
		private long? version;

		public virtual string Address
		{
			set
			{
				this.address = value;
			}
			get
			{
				return this.address;
			}
		}


		public virtual string Mobile
		{
			set
			{
				this.mobile = value;
			}
			get
			{
				return this.mobile;
			}
		}


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


		public virtual long? Post
		{
			set
			{
				this.post = value;
			}
			get
			{
				return this.post;
			}
		}


		public virtual string RefundId
		{
			set
			{
				this.refundId = value;
			}
			get
			{
				return this.refundId;
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


		public virtual string Tel
		{
			set
			{
				this.tel = value;
			}
			get
			{
				return this.tel;
			}
		}


		public virtual long? Version
		{
			set
			{
				this.version = value;
			}
			get
			{
				return this.version;
			}
		}



		public virtual IDictionary<string, object> toParams()
		{
			IDictionary<string, object> @params = Maps.newHashMap();
			if (!string.ReferenceEquals(address, null))
			{
				@params["address"] = address;
			}
			if (!string.ReferenceEquals(mobile, null))
			{
				@params["mobile"] = mobile;
			}
			if (!string.ReferenceEquals(name, null))
			{
				@params["name"] = name;
			}
			if (post != null)
			{
				@params["post"] = post;
			}
			if (!string.ReferenceEquals(refundId, null))
			{
				@params["refund_id"] = refundId;
			}
			if (!string.ReferenceEquals(remark, null))
			{
				@params["remark"] = remark;
			}
			if (!string.ReferenceEquals(tel, null))
			{
				@params["tel"] = tel;
			}
			if (version != null)
			{
				@params["version"] = version;
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