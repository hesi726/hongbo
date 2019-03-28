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

    public class YouzanRetailProductOnlineUpdateParams : APIParams, FileParams
	{

		/// <summary>
		/// 商品详情额外组件(固定值：-1)
		/// </summary>
		private long? componentsExtraId;
		/// <summary>
		/// 运费模板id（统一运费传0）
		/// </summary>
		private long? deliveryTemplateId;
		/// <summary>
		/// 电子卡券-电子凭证自定义推迟时间
		/// </summary>
		private long? effectiveDelayHours;
		/// <summary>
		/// 电子卡券-电子凭证生效类型，0 立即生效， 1 自定义推迟时间， 2 隔天生
		/// </summary>
		private long? effectiveType;
		/// <summary>
		/// 付款成功 后发货天数, 默认0。
		/// </summary>
		private long? etdDays;
		/// <summary>
		/// 预计发货开始时间, 字符串格式的时间
		/// </summary>
		private string etdStart;
		/// <summary>
		/// 发货类型: 0, xxx 时间开始发货(默认), 1, 付款 n 天后发货
		/// </summary>
		private long? etdType;
		/// <summary>
		/// 活动冻结结束时间, 时间戳, 单位毫秒
		/// </summary>
		private long? freezingEndtime;
		/// <summary>
		/// 商品编号
		/// </summary>
		private string goodsNo;
		/// <summary>
		/// 商品参与平台 0：普通商品。仅支持普通商品
		/// </summary>
		private long? goodsPlatform;
		/// <summary>
		/// 商品类型：0：普通商品，1: 拍卖商品, 3：ump降价拍，10:分销商品；20：会员卡商品；25：批发商品；30：收银台商品；35：酒店商品。仅支持普通商品
		/// </summary>
		private long? goodsType;
		/// <summary>
		/// 页面不显示商品库存: 0, 显示; 1, 不显示
		/// </summary>
		private long? hideStock;
		/// <summary>
		/// 电子卡券-节假日是否可用
		/// </summary>
		private bool? holidaysAvailable;
		/// <summary>
		/// 是否删除
		/// </summary>
		private long? isDelete;
		/// <summary>
		/// 是否上架
		/// 0：未发布，草稿状态（wap看不到） 1：发布 （正常状态）
		/// </summary>
		private long? isDisplay;
		/// <summary>
		/// 是否虚拟商品，0否, 2 虚拟商品， 3 电子卡券
		/// </summary>
		private long? isVirtual;
		/// <summary>
		/// 网店商品id
		/// </summary>
		private long? itemId;
		/// <summary>
		/// 商品重量信息
		/// </summary>
		private string itemSkuExtendParamList;
		/// <summary>
		/// 有sku规格情况下，
		/// 商品的计量属性
		/// </summary>
		private string itemSkuMeasProps;
		/// <summary>
		/// 虚拟商品有效期结束时间,1970-01-01 开始的秒数,留空表示长期有效
		/// </summary>
		private long? itemValidityEnd;
		/// <summary>
		/// 虚拟商品有效期开始时间,1970-01-01 开始的秒数,留空表示长期有效
		/// </summary>
		private long? itemValidityStart;
		/// <summary>
		/// 商品重量, 没有sku规格情况下
		/// </summary>
		private long? itemWeight;
		/// <summary>
		/// 是否参加会员折扣，默认：0 不参加
		/// </summary>
		private long? joinLevelDiscount;
		/// <summary>
		/// 标记
		/// </summary>
		private long? mark;
		/// <summary>
		/// 留言信息，json
		/// </summary>
		private string messages;
		/// <summary>
		/// 序号
		/// </summary>
		private long? num;
		/// <summary>
		/// 显示在原价那里的信息
		/// </summary>
		private string origin;
		/// <summary>
		/// 图片地址,注意 图片地址必须是符合以下规则的json，且必须已https开头。
		/// （例如：[{"url":"https://img.youzan.com/upload_files/2016/05/16/FjvGju7UwGfol_yAXK3RzxOGelt0.png","id":"642430978","width":"300","height":"299"},{"url":"https://img.youzan.com/upload_files/2016/05/20/FgNkCcgqoGd_fMDPPCas1UIX3aCM.jpg","id":"644360875","width":"640","height":"379"}]）
		/// </summary>
		private string picture;
		/// <summary>
		/// 照片高度
		/// </summary>
		private long? pictureHeight;
		/// <summary>
		/// 运费，单位：分（运费模版不为0的情况下、使用该字段计算运费）
		/// </summary>
		private long? postage;
		/// <summary>
		/// 是否预售
		/// </summary>
		private bool? preSale;
		/// <summary>
		/// 价格（多规格商品，商品价格不得小于各个规格价格），单位：分
		/// </summary>
		private long? price;
		/// <summary>
		/// 是否限购
		/// </summary>
		private bool? purchaseRight;
		/// <summary>
		/// 用户购买限额
		/// </summary>
		private long? quota;
		/// <summary>
		/// 无规格商品关联商品库商品
		/// </summary>
		private long? relateSkuId;
		/// <summary>
		/// 备注
		/// </summary>
		private string remark;
		/// <summary>
		/// 销售类型：1单个销售，2组合销售
		/// </summary>
		private long? sellType;
		/// <summary>
		/// 规格图片所属规格项id
		/// </summary>
		private long? skuImgDictId;
		/// <summary>
		/// 规格图片所属规格项名称
		/// </summary>
		private string skuImgDictValue;
		/// <summary>
		/// 规格图片是否展示
		/// </summary>
		private bool? skuImgIsShow;
		/// <summary>
		/// 规格图片父级id
		/// </summary>
		private long? skuImgParentId;
		/// <summary>
		/// sku图片信息
		/// </summary>
		private string skuImgUrls;
		/// <summary>
		/// 当前商品镜像的key
		/// </summary>
		private string snapKey;
		/// <summary>
		/// 开卖时间: 0 立即开售, 1 定时开售
		/// </summary>
		private long? soldTime;
		/// <summary>
		/// 请求来源（例：OPEN_XXXXX）
		/// </summary>
		private string source;
		/// <summary>
		/// 加星
		/// </summary>
		private long? star;
		/// <summary>
		/// 定时上架时间
		/// </summary>
		private long? startSoldTime;
		/// <summary>
		/// 多规格商品库存信息
		/// 注意：
		/// 实物商品至少关联一个商品库商品
		/// 当实物商品存在部分规格不关联的情况时，sku售价传0.01元，库存值传0。
		/// 例如：[{"sku_id":0,"related_sku_id":2250523,"price":100,"sell_stock_count":0,"sold_num":0,"cost_price":null,"sku_no":"P171011010602432","name":"测绘0333","skus":[{"k":"颜色","v":"粉色","kid":1,"vid":40172}],"k1":"颜色","v1":"粉色"},{"sku_id":0,"related_sku_id":2250523,"price":100,"sell_stock_count":12,"sold_num":0,"cost_price":null,"sku_no":"P171010025662807","name":"测试删除2","skus":[{"k":"颜色","v":"红色","kid":1,"vid":1215}],"k1":"颜色","v1":"红色"}]
		/// </summary>
		private string stocks;
		/// <summary>
		/// 子标题	
		/// </summary>
		private string subTitle;
		/// <summary>
		/// 商品分类，tagIds 的json 格式
		/// </summary>
		private string tag;
		/// <summary>
		/// 商品名称
		/// </summary>
		private string title;
		/// <summary>
		/// 总库存	
		/// </summary>
		private long? totalStock;
		/// <summary>
		/// 允许购买的粉丝等级
		/// </summary>
		private string umpLevel;
		/// <summary>
		/// 允许购买的粉丝标签
		/// </summary>
		private string umpTags;
		/// <summary>
		/// 视频id
		/// </summary>
		private long? videoId;

		public virtual long? ComponentsExtraId
		{
			set
			{
				this.componentsExtraId = value;
			}
			get
			{
				return this.componentsExtraId;
			}
		}


		public virtual long? DeliveryTemplateId
		{
			set
			{
				this.deliveryTemplateId = value;
			}
			get
			{
				return this.deliveryTemplateId;
			}
		}


		public virtual long? EffectiveDelayHours
		{
			set
			{
				this.effectiveDelayHours = value;
			}
			get
			{
				return this.effectiveDelayHours;
			}
		}


		public virtual long? EffectiveType
		{
			set
			{
				this.effectiveType = value;
			}
			get
			{
				return this.effectiveType;
			}
		}


		public virtual long? EtdDays
		{
			set
			{
				this.etdDays = value;
			}
			get
			{
				return this.etdDays;
			}
		}


		public virtual string EtdStart
		{
			set
			{
				this.etdStart = value;
			}
			get
			{
				return this.etdStart;
			}
		}


		public virtual long? EtdType
		{
			set
			{
				this.etdType = value;
			}
			get
			{
				return this.etdType;
			}
		}


		public virtual long? FreezingEndtime
		{
			set
			{
				this.freezingEndtime = value;
			}
			get
			{
				return this.freezingEndtime;
			}
		}


		public virtual string GoodsNo
		{
			set
			{
				this.goodsNo = value;
			}
			get
			{
				return this.goodsNo;
			}
		}


		public virtual long? GoodsPlatform
		{
			set
			{
				this.goodsPlatform = value;
			}
			get
			{
				return this.goodsPlatform;
			}
		}


		public virtual long? GoodsType
		{
			set
			{
				this.goodsType = value;
			}
			get
			{
				return this.goodsType;
			}
		}


		public virtual long? HideStock
		{
			set
			{
				this.hideStock = value;
			}
			get
			{
				return this.hideStock;
			}
		}


		public virtual bool? HolidaysAvailable
		{
			set
			{
				this.holidaysAvailable = value;
			}
			get
			{
				return this.holidaysAvailable;
			}
		}


		public virtual long? IsDelete
		{
			set
			{
				this.isDelete = value;
			}
			get
			{
				return this.isDelete;
			}
		}


		public virtual long? IsDisplay
		{
			set
			{
				this.isDisplay = value;
			}
			get
			{
				return this.isDisplay;
			}
		}


		public virtual long? IsVirtual
		{
			set
			{
				this.isVirtual = value;
			}
			get
			{
				return this.isVirtual;
			}
		}


		public virtual long? ItemId
		{
			set
			{
				this.itemId = value;
			}
			get
			{
				return this.itemId;
			}
		}


		public virtual string ItemSkuExtendParamList
		{
			set
			{
				this.itemSkuExtendParamList = value;
			}
			get
			{
				return this.itemSkuExtendParamList;
			}
		}


		public virtual string ItemSkuMeasProps
		{
			set
			{
				this.itemSkuMeasProps = value;
			}
			get
			{
				return this.itemSkuMeasProps;
			}
		}


		public virtual long? ItemValidityEnd
		{
			set
			{
				this.itemValidityEnd = value;
			}
			get
			{
				return this.itemValidityEnd;
			}
		}


		public virtual long? ItemValidityStart
		{
			set
			{
				this.itemValidityStart = value;
			}
			get
			{
				return this.itemValidityStart;
			}
		}


		public virtual long? ItemWeight
		{
			set
			{
				this.itemWeight = value;
			}
			get
			{
				return this.itemWeight;
			}
		}


		public virtual long? JoinLevelDiscount
		{
			set
			{
				this.joinLevelDiscount = value;
			}
			get
			{
				return this.joinLevelDiscount;
			}
		}


		public virtual long? Mark
		{
			set
			{
				this.mark = value;
			}
			get
			{
				return this.mark;
			}
		}


		public virtual string Messages
		{
			set
			{
				this.messages = value;
			}
			get
			{
				return this.messages;
			}
		}


		public virtual long? Num
		{
			set
			{
				this.num = value;
			}
			get
			{
				return this.num;
			}
		}


		public virtual string Origin
		{
			set
			{
				this.origin = value;
			}
			get
			{
				return this.origin;
			}
		}


		public virtual string Picture
		{
			set
			{
				this.picture = value;
			}
			get
			{
				return this.picture;
			}
		}


		public virtual long? PictureHeight
		{
			set
			{
				this.pictureHeight = value;
			}
			get
			{
				return this.pictureHeight;
			}
		}


		public virtual long? Postage
		{
			set
			{
				this.postage = value;
			}
			get
			{
				return this.postage;
			}
		}


		public virtual bool? PreSale
		{
			set
			{
				this.preSale = value;
			}
			get
			{
				return this.preSale;
			}
		}


		public virtual long? Price
		{
			set
			{
				this.price = value;
			}
			get
			{
				return this.price;
			}
		}


		public virtual bool? PurchaseRight
		{
			set
			{
				this.purchaseRight = value;
			}
			get
			{
				return this.purchaseRight;
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


		public virtual long? RelateSkuId
		{
			set
			{
				this.relateSkuId = value;
			}
			get
			{
				return this.relateSkuId;
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


		public virtual long? SellType
		{
			set
			{
				this.sellType = value;
			}
			get
			{
				return this.sellType;
			}
		}


		public virtual long? SkuImgDictId
		{
			set
			{
				this.skuImgDictId = value;
			}
			get
			{
				return this.skuImgDictId;
			}
		}


		public virtual string SkuImgDictValue
		{
			set
			{
				this.skuImgDictValue = value;
			}
			get
			{
				return this.skuImgDictValue;
			}
		}


		public virtual bool? SkuImgIsShow
		{
			set
			{
				this.skuImgIsShow = value;
			}
			get
			{
				return this.skuImgIsShow;
			}
		}


		public virtual long? SkuImgParentId
		{
			set
			{
				this.skuImgParentId = value;
			}
			get
			{
				return this.skuImgParentId;
			}
		}


		public virtual string SkuImgUrls
		{
			set
			{
				this.skuImgUrls = value;
			}
			get
			{
				return this.skuImgUrls;
			}
		}


		public virtual string SnapKey
		{
			set
			{
				this.snapKey = value;
			}
			get
			{
				return this.snapKey;
			}
		}


		public virtual long? SoldTime
		{
			set
			{
				this.soldTime = value;
			}
			get
			{
				return this.soldTime;
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


		public virtual long? Star
		{
			set
			{
				this.star = value;
			}
			get
			{
				return this.star;
			}
		}


		public virtual long? StartSoldTime
		{
			set
			{
				this.startSoldTime = value;
			}
			get
			{
				return this.startSoldTime;
			}
		}


		public virtual string Stocks
		{
			set
			{
				this.stocks = value;
			}
			get
			{
				return this.stocks;
			}
		}


		public virtual string SubTitle
		{
			set
			{
				this.subTitle = value;
			}
			get
			{
				return this.subTitle;
			}
		}


		public virtual string Tag
		{
			set
			{
				this.tag = value;
			}
			get
			{
				return this.tag;
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


		public virtual long? TotalStock
		{
			set
			{
				this.totalStock = value;
			}
			get
			{
				return this.totalStock;
			}
		}


		public virtual string UmpLevel
		{
			set
			{
				this.umpLevel = value;
			}
			get
			{
				return this.umpLevel;
			}
		}


		public virtual string UmpTags
		{
			set
			{
				this.umpTags = value;
			}
			get
			{
				return this.umpTags;
			}
		}


		public virtual long? VideoId
		{
			set
			{
				this.videoId = value;
			}
			get
			{
				return this.videoId;
			}
		}



		public virtual IDictionary<string, object> toParams()
		{
			IDictionary<string, object> @params = Maps.newHashMap();
			if (componentsExtraId != null)
			{
				@params["components_extra_id"] = componentsExtraId;
			}
			if (deliveryTemplateId != null)
			{
				@params["delivery_template_id"] = deliveryTemplateId;
			}
			if (effectiveDelayHours != null)
			{
				@params["effective_delay_hours"] = effectiveDelayHours;
			}
			if (effectiveType != null)
			{
				@params["effective_type"] = effectiveType;
			}
			if (etdDays != null)
			{
				@params["etd_days"] = etdDays;
			}
			if (!string.ReferenceEquals(etdStart, null))
			{
				@params["etd_start"] = etdStart;
			}
			if (etdType != null)
			{
				@params["etd_type"] = etdType;
			}
			if (freezingEndtime != null)
			{
				@params["freezing_endtime"] = freezingEndtime;
			}
			if (!string.ReferenceEquals(goodsNo, null))
			{
				@params["goods_no"] = goodsNo;
			}
			if (goodsPlatform != null)
			{
				@params["goods_platform"] = goodsPlatform;
			}
			if (goodsType != null)
			{
				@params["goods_type"] = goodsType;
			}
			if (hideStock != null)
			{
				@params["hide_stock"] = hideStock;
			}
			if (holidaysAvailable != null)
			{
				@params["holidays_available"] = holidaysAvailable;
			}
			if (isDelete != null)
			{
				@params["is_delete"] = isDelete;
			}
			if (isDisplay != null)
			{
				@params["is_display"] = isDisplay;
			}
			if (isVirtual != null)
			{
				@params["is_virtual"] = isVirtual;
			}
			if (itemId != null)
			{
				@params["item_id"] = itemId;
			}
			if (!string.ReferenceEquals(itemSkuExtendParamList, null))
			{
				@params["item_sku_extend_param_list"] = itemSkuExtendParamList;
			}
			if (!string.ReferenceEquals(itemSkuMeasProps, null))
			{
				@params["item_sku_meas_props"] = itemSkuMeasProps;
			}
			if (itemValidityEnd != null)
			{
				@params["item_validity_end"] = itemValidityEnd;
			}
			if (itemValidityStart != null)
			{
				@params["item_validity_start"] = itemValidityStart;
			}
			if (itemWeight != null)
			{
				@params["item_weight"] = itemWeight;
			}
			if (joinLevelDiscount != null)
			{
				@params["join_level_discount"] = joinLevelDiscount;
			}
			if (mark != null)
			{
				@params["mark"] = mark;
			}
			if (!string.ReferenceEquals(messages, null))
			{
				@params["messages"] = messages;
			}
			if (num != null)
			{
				@params["num"] = num;
			}
			if (!string.ReferenceEquals(origin, null))
			{
				@params["origin"] = origin;
			}
			if (!string.ReferenceEquals(picture, null))
			{
				@params["picture"] = picture;
			}
			if (pictureHeight != null)
			{
				@params["picture_height"] = pictureHeight;
			}
			if (postage != null)
			{
				@params["postage"] = postage;
			}
			if (preSale != null)
			{
				@params["pre_sale"] = preSale;
			}
			if (price != null)
			{
				@params["price"] = price;
			}
			if (purchaseRight != null)
			{
				@params["purchase_right"] = purchaseRight;
			}
			if (quota != null)
			{
				@params["quota"] = quota;
			}
			if (relateSkuId != null)
			{
				@params["relate_sku_id"] = relateSkuId;
			}
			if (!string.ReferenceEquals(remark, null))
			{
				@params["remark"] = remark;
			}
			if (sellType != null)
			{
				@params["sell_type"] = sellType;
			}
			if (skuImgDictId != null)
			{
				@params["sku_img_dict_id"] = skuImgDictId;
			}
			if (!string.ReferenceEquals(skuImgDictValue, null))
			{
				@params["sku_img_dict_value"] = skuImgDictValue;
			}
			if (skuImgIsShow != null)
			{
				@params["sku_img_is_show"] = skuImgIsShow;
			}
			if (skuImgParentId != null)
			{
				@params["sku_img_parent_id"] = skuImgParentId;
			}
			if (!string.ReferenceEquals(skuImgUrls, null))
			{
				@params["sku_img_urls"] = skuImgUrls;
			}
			if (!string.ReferenceEquals(snapKey, null))
			{
				@params["snap_key"] = snapKey;
			}
			if (soldTime != null)
			{
				@params["sold_time"] = soldTime;
			}
			if (!string.ReferenceEquals(source, null))
			{
				@params["source"] = source;
			}
			if (star != null)
			{
				@params["star"] = star;
			}
			if (startSoldTime != null)
			{
				@params["start_sold_time"] = startSoldTime;
			}
			if (!string.ReferenceEquals(stocks, null))
			{
				@params["stocks"] = stocks;
			}
			if (!string.ReferenceEquals(subTitle, null))
			{
				@params["sub_title"] = subTitle;
			}
			if (!string.ReferenceEquals(tag, null))
			{
				@params["tag"] = tag;
			}
			if (!string.ReferenceEquals(title, null))
			{
				@params["title"] = title;
			}
			if (totalStock != null)
			{
				@params["total_stock"] = totalStock;
			}
			if (!string.ReferenceEquals(umpLevel, null))
			{
				@params["ump_level"] = umpLevel;
			}
			if (!string.ReferenceEquals(umpTags, null))
			{
				@params["ump_tags"] = umpTags;
			}
			if (videoId != null)
			{
				@params["video_id"] = videoId;
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