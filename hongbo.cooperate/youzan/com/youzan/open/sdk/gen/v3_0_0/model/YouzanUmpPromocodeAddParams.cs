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

    public class YouzanUmpPromocodeAddParams : APIParams, FileParams
	{

		/// <summary>
		/// 如果 is_at_least 为 1，该字段表示订单必须满这个价格，优惠码才可用。单位：元，精确到分
		/// </summary>
		private float? atLeast;
		/// <summary>
		/// 通用优惠码必须为6至12个字符数字组合
		/// </summary>
		private string code;
		/// <summary>
		/// 优惠码类型
		/// </summary>
		private string codeType;
		/// <summary>
		/// 使用说明
		/// </summary>
		private string description;
		/// <summary>
		/// 优惠码结束时间，时间格式：yyyy-MM-dd HH:mm:ss
		/// </summary>
		private DateTime endAt;
		/// <summary>
		/// 是否到期前4天发送提醒，0 表示不发送，1 表示发送
		/// </summary>
		private long? expireNotice;
		/// <summary>
		/// 是否设置满多少元可用，0 表示不限制，1 表示限制
		/// </summary>
		private long? isAtLeast;
		/// <summary>
		/// 是否仅原价购买商品时可用，0 表示否，1 表示是
		/// </summary>
		private long? isForbidPreference;
		/// <summary>
		/// 是否可分享领取链接，0 表示否，1 表示是
		/// </summary>
		private long? isShare;
		/// <summary>
		/// 是否同步微信卡券，0 表示否，1 表示是
		/// </summary>
		private long? isSyncWeixin;
		/// <summary>
		/// 领取优惠码要给用户打上的标签的ID，多个用半角逗号分隔
		/// </summary>
		private string markTagIds;
		/// <summary>
		/// 每人限领个数，取值范围是1-10
		/// </summary>
		private long? quota;
		/// <summary>
		/// 可用范围的类型，可选值：PART（部分商品可用，或指定商品可用）ALL（全部商品可用）
		/// </summary>
		private string rangeType;
		/// <summary>
		/// 同步微信卡券时填写，微信卡券的手机号
		/// </summary>
		private string servicePhone;
		/// <summary>
		/// 如果 range_type 为 PART，需要指定可用商品ID，多个用半角逗号分隔
		/// </summary>
		private string specifyItemIds;
		/// <summary>
		/// 优惠码生效时间，时间格式：yyyy-MM-dd HH:mm:ss
		/// </summary>
		private DateTime startAt;
		/// <summary>
		/// 优惠码标题
		/// </summary>
		private string title;
		/// <summary>
		/// 总库存
		/// </summary>
		private long? total;
		/// <summary>
		/// 优惠码面额。单位：元，精确到分
		/// </summary>
		private float? value;
		/// <summary>
		/// 同步微信卡券时，选择的卡券颜色的值。例如：Color010
		/// </summary>
		private string weixinColor;
		/// <summary>
		/// 同步微信卡券时，选择的卡券颜色的RGB值。例如：	#55bd47
		/// </summary>
		private string weixinColorRgb;
		/// <summary>
		/// 同步微信卡券时，卡券的副标题，长度：18个字
		/// </summary>
		private string weixinSubTitle;
		/// <summary>
		/// 同步微信卡券时，卡券的标题，长度：9个字
		/// </summary>
		private string weixinTitle;

		public virtual float? AtLeast
		{
			set
			{
				this.atLeast = value;
			}
			get
			{
				return this.atLeast;
			}
		}


		public virtual string Code
		{
			set
			{
				this.code = value;
			}
			get
			{
				return this.code;
			}
		}


		public virtual string CodeType
		{
			set
			{
				this.codeType = value;
			}
			get
			{
				return this.codeType;
			}
		}


		public virtual string Description
		{
			set
			{
				this.description = value;
			}
			get
			{
				return this.description;
			}
		}


		public virtual DateTime EndAt
		{
			set
			{
				this.endAt = value;
			}
			get
			{
				return this.endAt;
			}
		}


		public virtual long? ExpireNotice
		{
			set
			{
				this.expireNotice = value;
			}
			get
			{
				return this.expireNotice;
			}
		}


		public virtual long? IsAtLeast
		{
			set
			{
				this.isAtLeast = value;
			}
			get
			{
				return this.isAtLeast;
			}
		}


		public virtual long? IsForbidPreference
		{
			set
			{
				this.isForbidPreference = value;
			}
			get
			{
				return this.isForbidPreference;
			}
		}


		public virtual long? IsShare
		{
			set
			{
				this.isShare = value;
			}
			get
			{
				return this.isShare;
			}
		}


		public virtual long? IsSyncWeixin
		{
			set
			{
				this.isSyncWeixin = value;
			}
			get
			{
				return this.isSyncWeixin;
			}
		}


		public virtual string MarkTagIds
		{
			set
			{
				this.markTagIds = value;
			}
			get
			{
				return this.markTagIds;
			}
		}


		public virtual long? Quota
		{
			set
			{
				this.quota = value;
			}
			get
			{
				return this.quota;
			}
		}


		public virtual string RangeType
		{
			set
			{
				this.rangeType = value;
			}
			get
			{
				return this.rangeType;
			}
		}


		public virtual string ServicePhone
		{
			set
			{
				this.servicePhone = value;
			}
			get
			{
				return this.servicePhone;
			}
		}


		public virtual string SpecifyItemIds
		{
			set
			{
				this.specifyItemIds = value;
			}
			get
			{
				return this.specifyItemIds;
			}
		}


		public virtual DateTime StartAt
		{
			set
			{
				this.startAt = value;
			}
			get
			{
				return this.startAt;
			}
		}


		public virtual string Title
		{
			set
			{
				this.title = value;
			}
			get
			{
				return this.title;
			}
		}


		public virtual long? Total
		{
			set
			{
				this.total = value;
			}
			get
			{
				return this.total;
			}
		}


		public virtual float? Value
		{
			set
			{
				this.value = value;
			}
			get
			{
				return this.value;
			}
		}


		public virtual string WeixinColor
		{
			set
			{
				this.weixinColor = value;
			}
			get
			{
				return this.weixinColor;
			}
		}


		public virtual string WeixinColorRgb
		{
			set
			{
				this.weixinColorRgb = value;
			}
			get
			{
				return this.weixinColorRgb;
			}
		}


		public virtual string WeixinSubTitle
		{
			set
			{
				this.weixinSubTitle = value;
			}
			get
			{
				return this.weixinSubTitle;
			}
		}


		public virtual string WeixinTitle
		{
			set
			{
				this.weixinTitle = value;
			}
			get
			{
				return this.weixinTitle;
			}
		}



		public virtual IDictionary<string, object> toParams()
		{
			IDictionary<string, object> @params = Maps.newHashMap();
			if (atLeast != null)
			{
				@params["at_least"] = atLeast;
			}
			if (!string.ReferenceEquals(code, null))
			{
				@params["code"] = code;
			}
			if (!string.ReferenceEquals(codeType, null))
			{
				@params["code_type"] = codeType;
			}
			if (!string.ReferenceEquals(description, null))
			{
				@params["description"] = description;
			}
			if (endAt != null)
			{
				@params["end_at"] = endAt;
			}
			if (expireNotice != null)
			{
				@params["expire_notice"] = expireNotice;
			}
			if (isAtLeast != null)
			{
				@params["is_at_least"] = isAtLeast;
			}
			if (isForbidPreference != null)
			{
				@params["is_forbid_preference"] = isForbidPreference;
			}
			if (isShare != null)
			{
				@params["is_share"] = isShare;
			}
			if (isSyncWeixin != null)
			{
				@params["is_sync_weixin"] = isSyncWeixin;
			}
			if (!string.ReferenceEquals(markTagIds, null))
			{
				@params["mark_tag_ids"] = markTagIds;
			}
			if (quota != null)
			{
				@params["quota"] = quota;
			}
			if (!string.ReferenceEquals(rangeType, null))
			{
				@params["range_type"] = rangeType;
			}
			if (!string.ReferenceEquals(servicePhone, null))
			{
				@params["service_phone"] = servicePhone;
			}
			if (!string.ReferenceEquals(specifyItemIds, null))
			{
				@params["specify_item_ids"] = specifyItemIds;
			}
			if (startAt != null)
			{
				@params["start_at"] = startAt;
			}
			if (!string.ReferenceEquals(title, null))
			{
				@params["title"] = title;
			}
			if (total != null)
			{
				@params["total"] = total;
			}
			if (value != null)
			{
				@params["value"] = value;
			}
			if (!string.ReferenceEquals(weixinColor, null))
			{
				@params["weixin_color"] = weixinColor;
			}
			if (!string.ReferenceEquals(weixinColorRgb, null))
			{
				@params["weixin_color_rgb"] = weixinColorRgb;
			}
			if (!string.ReferenceEquals(weixinSubTitle, null))
			{
				@params["weixin_sub_title"] = weixinSubTitle;
			}
			if (!string.ReferenceEquals(weixinTitle, null))
			{
				@params["weixin_title"] = weixinTitle;
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