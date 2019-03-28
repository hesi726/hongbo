using System.Collections.Generic;

namespace com.youzan.open.sdk.gen.v1_0_0.model
{

    ////	using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;
    using global::youzan.com.youzan.open.sdk.model;

    ////	using Maps = com.google.common.collect.Maps;


    ////	using Multimap = com.google.common.collect.Multimap;


    using APIParams = com.youzan.open.sdk.model.APIParams;
    using ByteWrapper = com.youzan.open.sdk.model.ByteWrapper;
    using FileParams = com.youzan.open.sdk.model.FileParams;

    public class KdtUsersWeixinFollowerGetsParams : APIParams, FileParams
	{

		/// <summary>
		/// 需要返回的微信粉丝对象字段，如nick,avatar等。可选值：CrmWeixinFans微信粉丝结构体中所有字段均可返回；多个字段用","分隔。如果为空则返回所有
		/// </summary>
		private string fields;
		/// <summary>
		/// 页码
		/// </summary>
		private long? pageNo;
		/// <summary>
		/// 每页条数，默认值：40，最大值：500
		/// </summary>
		private long? pageSize;
		/// <summary>
		/// 微信粉丝用户ID，多个用逗号分隔。调用时，参数 weixin_openids 和 user_ids 选其一即可
		/// </summary>
		private string userIds;
		/// <summary>
		/// 微信粉丝用户的openid，多个用逗号分隔
		/// </summary>
		private string weixinOpenids;

		public virtual string Fields
		{
			set
			{
				this.fields = value;
			}
			get
			{
				return this.fields;
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


		public virtual string UserIds
		{
			set
			{
				this.userIds = value;
			}
			get
			{
				return this.userIds;
			}
		}


		public virtual string WeixinOpenids
		{
			set
			{
				this.weixinOpenids = value;
			}
			get
			{
				return this.weixinOpenids;
			}
		}



		public virtual IDictionary<string, object> toParams()
		{
			IDictionary<string, object> @params = Maps.newHashMap();
			if (!string.ReferenceEquals(fields, null))
			{
				@params["fields"] = fields;
			}
			if (pageNo != null)
			{
				@params["page_no"] = pageNo;
			}
			if (pageSize != null)
			{
				@params["page_size"] = pageSize;
			}
			if (!string.ReferenceEquals(userIds, null))
			{
				@params["user_ids"] = userIds;
			}
			if (!string.ReferenceEquals(weixinOpenids, null))
			{
				@params["weixin_openids"] = weixinOpenids;
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