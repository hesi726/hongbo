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

    public class YouzanUmpPromocardAddParams : APIParams, FileParams
	{

		/// <summary>
		/// 如果 is_at_least 为 1，该字段表示订单必须满这个价格，优惠券才可用。单位：元，精确到分
		/// </summary>
		private float? atLeast;
		/// <summary>
		/// 同步微信卡券时，设置是否可以转赠，1 为可转赠，0 为不可转赠
		/// </summary>
		private long? canGiveFriend;
		/// <summary>
		/// 优惠使用时间类型，1 表示固定活动时间（配合start_at和end_at 这两个字段使用）；2 表示延迟类型，几天后几天内有效（配合fixed_term和fixed_begin_term 这两个字段使用）
		/// </summary>
		private long? dateType;
		/// <summary>
		/// 使用说明
		/// </summary>
		private string description;
		/// <summary>
		/// 折扣（示例：88 8.8折）
		/// </summary>
		private long? discount;
		/// <summary>
		/// 优惠券结束时间，时间格式：yyyy-MM-dd HH:mm:ss
		/// </summary>
		private DateTime endAt;
		/// <summary>
		/// 是否到期前4天发送提醒，0 表示不发送，1 表示发送
		/// </summary>
		private long? expireNotice;
		/// <summary>
		/// 延迟开始的时间，如传入1，表示优惠券延迟1天生效；date_type=2时使用。
		/// </summary>
		private long? fixedBeginTerm;
		/// <summary>
		/// 固定时长，如传入1，表示优惠券1天内有效；date_type=2时使用。
		/// </summary>
		private long? fixedTerm;
		/// <summary>
		/// 是否设置满多少元可用，0 表示不限制，1 表示限制
		/// </summary>
		private long? isAtLeast;
		/// <summary>
		/// 是否仅原价购买商品时可用，0 表示否，1 表示是
		/// </summary>
		private long? isForbidPreference;
		/// <summary>
		/// 是否是随机优惠券，0 表示不随机，1 表示随机
		/// </summary>
		private long? isRandom;
		/// <summary>
		/// 是否可分享领取链接，0 表示否，1 表示是
		/// </summary>
		private long? isShare;
		/// <summary>
		/// 是否同步微信卡券，0 表示否，1 表示是
		/// </summary>
		private long? isSyncWeixin;
		/// <summary>
		/// 领取优惠券要给用户打上的标签的ID，多个用半角逗号分隔
		/// </summary>
		private string markTagIds;
		/// <summary>
		/// 是否限制领用者的等级，0 表示不限制，大于 0 表示领用者必须是这个等级ID
		/// </summary>
		private long? needUserLevel;
		/// <summary>
		/// 优惠属性，1表示优惠，2表示折扣
		/// </summary>
		private long? preferentialType;
		/// <summary>
		/// 每人限领个数，为 0 则表示不限制
		/// </summary>
		private long? quota;
		/// <summary>
		/// 可用范围的类型，可选值：PART（部分商品可用，或指定商品可用）ALL（全部商品可用）
		/// </summary>
		private string rangeType;
		/// <summary>
		/// 同步微信卡券时，卡券的客服电话
		/// </summary>
		private string servicePhone;
		/// <summary>
		/// 如果 range_type 为 PART，需要指定可用商品ID，多个用半角逗号分隔
		/// </summary>
		private string specifyItemIds;
		/// <summary>
		/// 优惠券生效时间，时间格式：yyyy-MM-dd HH:mm:ss
		/// </summary>
		private DateTime startAt;
		/// <summary>
		/// 优惠券标题
		/// </summary>
		private string title;
		/// <summary>
		/// 总库存
		/// </summary>
		private long? total;
		/// <summary>
		/// 优惠券面额。如果 is_random 为 1，则该字段表示随机金额的下限。单位：元，精确到分
		/// </summary>
		private float? value;
		/// <summary>
		/// 如果 is_random 为 1，则该字段表示随机金额的上限。单位：元，精确到分
		/// </summary>
		private float? valueRandomTo;
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


		public virtual long? CanGiveFriend
		{
			set
			{
				this.canGiveFriend = value;
			}
			get
			{
				return this.canGiveFriend;
			}
		}


		public virtual long? DateType
		{
			set
			{
				this.dateType = value;
			}
			get
			{
				return this.dateType;
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


		public virtual long? Discount
		{
			set
			{
				this.discount = value;
			}
			get
			{
				return this.discount;
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


		public virtual long? FixedBeginTerm
		{
			set
			{
				this.fixedBeginTerm = value;
			}
			get
			{
				return this.fixedBeginTerm;
			}
		}


		public virtual long? FixedTerm
		{
			set
			{
				this.fixedTerm = value;
			}
			get
			{
				return this.fixedTerm;
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


		public virtual long? IsRandom
		{
			set
			{
				this.isRandom = value;
			}
			get
			{
				return this.isRandom;
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


		public virtual long? NeedUserLevel
		{
			set
			{
				this.needUserLevel = value;
			}
			get
			{
				return this.needUserLevel;
			}
		}


		public virtual long? PreferentialType
		{
			set
			{
				this.preferentialType = value;
			}
			get
			{
				return this.preferentialType;
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


		public virtual float? ValueRandomTo
		{
			set
			{
				this.valueRandomTo = value;
			}
			get
			{
				return this.valueRandomTo;
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
			if (canGiveFriend != null)
			{
				@params["can_give_friend"] = canGiveFriend;
			}
			if (dateType != null)
			{
				@params["date_type"] = dateType;
			}
			if (!string.ReferenceEquals(description, null))
			{
				@params["description"] = description;
			}
			if (discount != null)
			{
				@params["discount"] = discount;
			}
			if (endAt != null)
			{
				@params["end_at"] = endAt;
			}
			if (expireNotice != null)
			{
				@params["expire_notice"] = expireNotice;
			}
			if (fixedBeginTerm != null)
			{
				@params["fixed_begin_term"] = fixedBeginTerm;
			}
			if (fixedTerm != null)
			{
				@params["fixed_term"] = fixedTerm;
			}
			if (isAtLeast != null)
			{
				@params["is_at_least"] = isAtLeast;
			}
			if (isForbidPreference != null)
			{
				@params["is_forbid_preference"] = isForbidPreference;
			}
			if (isRandom != null)
			{
				@params["is_random"] = isRandom;
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
			if (needUserLevel != null)
			{
				@params["need_user_level"] = needUserLevel;
			}
			if (preferentialType != null)
			{
				@params["preferential_type"] = preferentialType;
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
			if (valueRandomTo != null)
			{
				@params["value_random_to"] = valueRandomTo;
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