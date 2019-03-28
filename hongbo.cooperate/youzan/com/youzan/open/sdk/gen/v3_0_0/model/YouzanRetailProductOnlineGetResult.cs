namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanRetailProductOnlineGetResult : APIResult
	{



		/// <summary>
		/// 网店商品实体信息
		/// </summary>
[Newtonsoft.Json.JsonProperty("online_vo")]//) private OnlineProductVO onlineVo;
		private OnlineProductVO onlineVo;

		public virtual OnlineProductVO OnlineVo
		{
			set
			{
				this.onlineVo = value;
			}
			get
			{
				return this.onlineVo;
			}
		}


		public class OnlineProductVO
		{


			/// <summary>
			/// 网店商品id
			/// </summary>
[Newtonsoft.Json.JsonProperty("id")]//) private Nullable<long> id;
				internal long? id;


			/// <summary>
			/// 店铺id
			/// </summary>
[Newtonsoft.Json.JsonProperty("kdt_id")]//) private Nullable<long> kdtId;
				internal long? kdtId;


			/// <summary>
			/// 商品别名
			/// </summary>
[Newtonsoft.Json.JsonProperty("alias")]//) private String alias;
				internal string alias;


			/// <summary>
			/// 标题
			/// </summary>
[Newtonsoft.Json.JsonProperty("title")]//) private String title;
				internal string title;


			/// <summary>
			/// 价格 单位：分
			/// </summary>
[Newtonsoft.Json.JsonProperty("price")]//) private Nullable<long> price;
				internal long? price;


			/// <summary>
			/// 原价
			/// </summary>
[Newtonsoft.Json.JsonProperty("origin")]//) private String origin;
				internal string origin;


			/// <summary>
			/// 运费 单位：分
			/// </summary>
[Newtonsoft.Json.JsonProperty("postage")]//) private Nullable<long> postage;
				internal long? postage;


			/// <summary>
			/// 商品模版详情内容
			/// </summary>
[Newtonsoft.Json.JsonProperty("content")]//) private String content;
				internal string content;


			/// <summary>
			/// 商品模版json串
			/// </summary>
[Newtonsoft.Json.JsonProperty("components")]//) private String components;
				internal string components;


			/// <summary>
			/// 商品模版id
			/// </summary>
[Newtonsoft.Json.JsonProperty("components_extra_id")]//) private Nullable<long> componentsExtraId;
				internal long? componentsExtraId;


			/// <summary>
			/// 创建时间
			/// </summary>
[Newtonsoft.Json.JsonProperty("created_time")]//) private Nullable<long> createdTime;
				internal long? createdTime;


			/// <summary>
			/// 更新时间
			/// </summary>
[Newtonsoft.Json.JsonProperty("update_time")]//) private Nullable<long> updateTime;
				internal long? updateTime;


			/// <summary>
			/// 是否上架（1上架 0下架）
			/// </summary>
[Newtonsoft.Json.JsonProperty("is_display")]//) private Nullable<long> isDisplay;
				internal long? isDisplay;


			/// <summary>
			/// 商品类型 0：普通商品
			/// </summary>
[Newtonsoft.Json.JsonProperty("goods_type")]//) private Nullable<long> goodsType;
				internal long? goodsType;


			/// <summary>
			/// 商品编码
			/// </summary>
[Newtonsoft.Json.JsonProperty("goods_no")]//) private String goodsNo;
				internal string goodsNo;


			/// <summary>
			/// 是否虚拟商品，0否, 2 虚拟商品， 3 电子卡券
			/// </summary>
[Newtonsoft.Json.JsonProperty("is_virtual")]//) private Nullable<long> isVirtual;
				internal long? isVirtual;


			/// <summary>
			/// 每人限购多少件。0代表无限购，默认为0
			/// </summary>
[Newtonsoft.Json.JsonProperty("quota")]//) private Nullable<long> quota;
				internal long? quota;


			/// <summary>
			/// 商品留言
			/// </summary>
[Newtonsoft.Json.JsonProperty("messages")]//) private String messages;
				internal string messages;


			/// <summary>
			/// 是否锁定 1:是;0:否; 2,活动冻结
			/// </summary>
[Newtonsoft.Json.JsonProperty("is_lock")]//) private Nullable<long> isLock;
				internal long? isLock;


			/// <summary>
			/// 定时上架时间
			/// </summary>
[Newtonsoft.Json.JsonProperty("start_sold_time")]//) private Nullable<long> startSoldTime;
				internal long? startSoldTime;


			/// <summary>
			/// 是否参加会员折扣 1参加；0不参加 ，默认：0 不参加
			/// </summary>
[Newtonsoft.Json.JsonProperty("join_level_discount")]//) private Nullable<long> joinLevelDiscount;
				internal long? joinLevelDiscount;


			/// <summary>
			/// 运费模版id
			/// </summary>
[Newtonsoft.Json.JsonProperty("delivery_template_id")]//) private Nullable<long> deliveryTemplateId;
				internal long? deliveryTemplateId;


			/// <summary>
			/// 商品参与平台 0：普通商品
			/// </summary>
[Newtonsoft.Json.JsonProperty("goods_platform")]//) private Nullable<long> goodsPlatform;
				internal long? goodsPlatform;


			/// <summary>
			/// 分组信息
			/// </summary>
[Newtonsoft.Json.JsonProperty("tag")]//) private String tag;
				internal string tag;


			/// <summary>
			/// 库存总量
			/// </summary>
[Newtonsoft.Json.JsonProperty("total_stock")]//) private Nullable<long> totalStock;
				internal long? totalStock;


			/// <summary>
			/// 商品主图片地址
			/// </summary>
[Newtonsoft.Json.JsonProperty("picture")]//) private String picture;
				internal string picture;


			/// <summary>
			/// 开卖时间: 0 立即开售, 1 定时开售
			/// </summary>
[Newtonsoft.Json.JsonProperty("sold_time")]//) private Nullable<long> soldTime;
				internal long? soldTime;


			/// <summary>
			/// 商品子标题
			/// </summary>
[Newtonsoft.Json.JsonProperty("sub_title")]//) private Nullable<long> subTitle;
				internal long? subTitle;


			/// <summary>
			/// 是否设置商品购买权限
			/// </summary>
[Newtonsoft.Json.JsonProperty("purchase_right")]//) private Nullable<bool> purchaseRight;
				internal bool? purchaseRight;


			/// <summary>
			/// 是否预售
			/// </summary>
[Newtonsoft.Json.JsonProperty("pre_sale")]//) private Nullable<bool> preSale;
				internal bool? preSale;


			/// <summary>
			/// 商品销量
			/// </summary>
[Newtonsoft.Json.JsonProperty("total_sold_num")]//) private Nullable<long> totalSoldNum;
				internal long? totalSoldNum;


			/// <summary>
			/// 商品预售信息
			/// </summary>
[Newtonsoft.Json.JsonProperty("pre_sale_info")]//) private ItemPreSaleOpenModel preSaleInfo;
				internal ItemPreSaleOpenModel preSaleInfo;


			/// <summary>
			/// 可购买该商品的用户标签id列表
			/// </summary>
[Newtonsoft.Json.JsonProperty("ump_tags")]//) private string[] umpTags;
				internal string[] umpTags;


			/// <summary>
			/// 虚拟商品扩展信息
			/// </summary>
[Newtonsoft.Json.JsonProperty("virtual_extral")]//) private ItemVirtualOpenModel virtualExtral;
				internal ItemVirtualOpenModel virtualExtral;


			/// <summary>
			/// 可购买该商品的会员等级id列表
			/// </summary>
[Newtonsoft.Json.JsonProperty("ump_level")]//) private string[] umpLevel;
				internal string[] umpLevel;


			/// <summary>
			/// 无规格商品关联的商品库商品
			/// </summary>
[Newtonsoft.Json.JsonProperty("sku_center_id")]//) private Nullable<long> skuCenterId;
				internal long? skuCenterId;


			/// <summary>
			/// 规格图片信息
			/// </summary>
[Newtonsoft.Json.JsonProperty("item_sku_image_model")]//) private ItemSkuImageModel[] itemSkuImageModel;
				internal ItemSkuImageModel[] itemSkuImageModel;


			/// <summary>
			/// 商品规格信息
			/// </summary>
[Newtonsoft.Json.JsonProperty("stocks")]//) private ItemSkuModel[] stocks;
				internal ItemSkuModel[] stocks;

				public virtual long? Id
				{
					set
					{
					this.id = value;
					}
					get
					{
					return this.id;
					}
				}


				public virtual long? KdtId
				{
					set
					{
					this.kdtId = value;
					}
					get
					{
					return this.kdtId;
					}
				}


				public virtual string Alias
				{
					set
					{
					this.alias = value;
					}
					get
					{
					return this.alias;
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


				public virtual string Content
				{
					set
					{
					this.content = value;
					}
					get
					{
					return this.content;
					}
				}


				public virtual string Components
				{
					set
					{
					this.components = value;
					}
					get
					{
					return this.components;
					}
				}


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


				public virtual long? CreatedTime
				{
					set
					{
					this.createdTime = value;
					}
					get
					{
					return this.createdTime;
					}
				}


				public virtual long? UpdateTime
				{
					set
					{
					this.updateTime = value;
					}
					get
					{
					return this.updateTime;
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


				public virtual long? IsLock
				{
					set
					{
					this.isLock = value;
					}
					get
					{
					return this.isLock;
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


				public virtual long? SubTitle
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


				public virtual long? TotalSoldNum
				{
					set
					{
					this.totalSoldNum = value;
					}
					get
					{
					return this.totalSoldNum;
					}
				}


				public virtual ItemPreSaleOpenModel PreSaleInfo
				{
					set
					{
					this.preSaleInfo = value;
					}
					get
					{
					return this.preSaleInfo;
					}
				}


				public virtual string[] UmpTags
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


				public virtual ItemVirtualOpenModel VirtualExtral
				{
					set
					{
					this.virtualExtral = value;
					}
					get
					{
					return this.virtualExtral;
					}
				}


				public virtual string[] UmpLevel
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


				public virtual long? SkuCenterId
				{
					set
					{
					this.skuCenterId = value;
					}
					get
					{
					return this.skuCenterId;
					}
				}


				public virtual ItemSkuImageModel[] ItemSkuImageModel
				{
					set
					{
					this.itemSkuImageModel = value;
					}
					get
					{
					return this.itemSkuImageModel;
					}
				}


				public virtual ItemSkuModel[] Stocks
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


		}

		public class ItemSkuImageModel
		{


			/// <summary>
			/// 店铺id
			/// </summary>
[Newtonsoft.Json.JsonProperty("kdt_id")]//) private Nullable<long> kdtId;
				internal long? kdtId;


			/// <summary>
			/// 商品id
			/// </summary>
[Newtonsoft.Json.JsonProperty("item_id")]//) private Nullable<long> itemId;
				internal long? itemId;


			/// <summary>
			/// 规格项ID，第一级规格项
			/// </summary>
[Newtonsoft.Json.JsonProperty("dict_id")]//) private Nullable<long> dictId;
				internal long? dictId;


			/// <summary>
			/// 规格项名称，第一级规格项
			/// </summary>
[Newtonsoft.Json.JsonProperty("dict_value")]//) private String dictValue;
				internal string dictValue;


			/// <summary>
			/// 规格值ID
			/// </summary>
[Newtonsoft.Json.JsonProperty("node_value_id")]//) private Nullable<long> nodeValueId;
				internal long? nodeValueId;


			/// <summary>
			/// 图片
			/// </summary>
[Newtonsoft.Json.JsonProperty("image_url")]//) private String imageUrl;
				internal string imageUrl;

				public virtual long? KdtId
				{
					set
					{
					this.kdtId = value;
					}
					get
					{
					return this.kdtId;
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


				public virtual long? DictId
				{
					set
					{
					this.dictId = value;
					}
					get
					{
					return this.dictId;
					}
				}


				public virtual string DictValue
				{
					set
					{
					this.dictValue = value;
					}
					get
					{
					return this.dictValue;
					}
				}


				public virtual long? NodeValueId
				{
					set
					{
					this.nodeValueId = value;
					}
					get
					{
					return this.nodeValueId;
					}
				}


				public virtual string ImageUrl
				{
					set
					{
					this.imageUrl = value;
					}
					get
					{
					return this.imageUrl;
					}
				}


		}

		public class ItemSkuModel
		{


			/// <summary>
			/// 店铺Id
			/// </summary>
[Newtonsoft.Json.JsonProperty("kdt_id")]//) private Nullable<long> kdtId;
				internal long? kdtId;


			/// <summary>
			/// 网店商品Id
			/// </summary>
[Newtonsoft.Json.JsonProperty("item_id")]//) private Nullable<long> itemId;
				internal long? itemId;


			/// <summary>
			/// 售价，单位：分
			/// </summary>
[Newtonsoft.Json.JsonProperty("price")]//) private Nullable<long> price;
				internal long? price;


			/// <summary>
			/// 库存数量
			/// </summary>
[Newtonsoft.Json.JsonProperty("stock_num")]//) private Nullable<long> stockNum;
				internal long? stockNum;


			/// <summary>
			/// 商品规格编码
			/// </summary>
[Newtonsoft.Json.JsonProperty("sku_no")]//) private String skuNo;
				internal string skuNo;


			/// <summary>
			/// 第一个规格值id
			/// </summary>
[Newtonsoft.Json.JsonProperty("s1")]//) private Nullable<long> s1;
				internal long? s1;


			/// <summary>
			/// 第二个规格值id
			/// </summary>
[Newtonsoft.Json.JsonProperty("s2")]//) private Nullable<long> s2;
				internal long? s2;


			/// <summary>
			/// 第三个规格值id
			/// </summary>
[Newtonsoft.Json.JsonProperty("s3")]//) private Nullable<long> s3;
				internal long? s3;


			/// <summary>
			/// 第四个规格值id
			/// </summary>
[Newtonsoft.Json.JsonProperty("s4")]//) private Nullable<long> s4;
				internal long? s4;


			/// <summary>
			/// 第五个规格值id
			/// </summary>
[Newtonsoft.Json.JsonProperty("s5")]//) private Nullable<long> s5;
				internal long? s5;


			/// <summary>
			/// 创建时间
			/// </summary>
[Newtonsoft.Json.JsonProperty("created_time")]//) private Nullable<long> createdTime;
				internal long? createdTime;


			/// <summary>
			/// 更新时间
			/// </summary>
[Newtonsoft.Json.JsonProperty("updateTime")]//) private Nullable<long> updateTime;
				internal long? updateTime;


			/// <summary>
			/// 规格名称
			/// </summary>
[Newtonsoft.Json.JsonProperty("name")]//) private Nullable<long> name;
				internal long? name;


			/// <summary>
			/// 规格关联的商品库商品
			/// </summary>
[Newtonsoft.Json.JsonProperty("sku_center_id")]//) private Nullable<long> skuCenterId;
				internal long? skuCenterId;


			/// <summary>
			/// 成本价
			/// </summary>
[Newtonsoft.Json.JsonProperty("cost_price")]//) private Nullable<long> costPrice;
				internal long? costPrice;

				public virtual long? KdtId
				{
					set
					{
					this.kdtId = value;
					}
					get
					{
					return this.kdtId;
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


				public virtual long? StockNum
				{
					set
					{
					this.stockNum = value;
					}
					get
					{
					return this.stockNum;
					}
				}


				public virtual string SkuNo
				{
					set
					{
					this.skuNo = value;
					}
					get
					{
					return this.skuNo;
					}
				}


				public virtual long? S1
				{
					set
					{
					this.s1 = value;
					}
					get
					{
					return this.s1;
					}
				}


				public virtual long? S2
				{
					set
					{
					this.s2 = value;
					}
					get
					{
					return this.s2;
					}
				}


				public virtual long? S3
				{
					set
					{
					this.s3 = value;
					}
					get
					{
					return this.s3;
					}
				}


				public virtual long? S4
				{
					set
					{
					this.s4 = value;
					}
					get
					{
					return this.s4;
					}
				}


				public virtual long? S5
				{
					set
					{
					this.s5 = value;
					}
					get
					{
					return this.s5;
					}
				}


				public virtual long? CreatedTime
				{
					set
					{
					this.createdTime = value;
					}
					get
					{
					return this.createdTime;
					}
				}


				public virtual long? UpdateTime
				{
					set
					{
					this.updateTime = value;
					}
					get
					{
					return this.updateTime;
					}
				}


				public virtual long? Name
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


				public virtual long? SkuCenterId
				{
					set
					{
					this.skuCenterId = value;
					}
					get
					{
					return this.skuCenterId;
					}
				}


				public virtual long? CostPrice
				{
					set
					{
					this.costPrice = value;
					}
					get
					{
					return this.costPrice;
					}
				}


		}

		public class ItemVirtualOpenModel
		{


			/// <summary>
			/// 虚拟商品有效期开始时间
			/// </summary>
[Newtonsoft.Json.JsonProperty("item_validity_start")]//) private String itemValidityStart;
				internal string itemValidityStart;


			/// <summary>
			/// 虚拟商品有效期结束时间
			/// </summary>
[Newtonsoft.Json.JsonProperty("item_validity_end")]//) private String itemValidityEnd;
				internal string itemValidityEnd;


			/// <summary>
			/// 电子凭证生效类型，0 立即生效， 1 自定义推迟时间， 2 隔天生效
			/// </summary>
[Newtonsoft.Json.JsonProperty("effective_type")]//) private Nullable<long> effectiveType;
				internal long? effectiveType;


			/// <summary>
			/// 电子凭证自定义推迟时间
			/// </summary>
[Newtonsoft.Json.JsonProperty("effective_delay_hours")]//) private Nullable<long> effectiveDelayHours;
				internal long? effectiveDelayHours;


			/// <summary>
			/// 节假日是否可用
			/// </summary>
[Newtonsoft.Json.JsonProperty("holidays_available")]//) private Nullable<bool> holidaysAvailable;
				internal bool? holidaysAvailable;

				public virtual string ItemValidityStart
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


				public virtual string ItemValidityEnd
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


		}

		public class ItemPreSaleOpenModel
		{


			/// <summary>
			/// 预售结束时间
			/// </summary>
[Newtonsoft.Json.JsonProperty("presale_end")]//) private String presaleEnd;
				internal string presaleEnd;


			/// <summary>
			/// 发货开始时间
			/// </summary>
[Newtonsoft.Json.JsonProperty("etd_start")]//) private String etdStart;
				internal string etdStart;


			/// <summary>
			/// 发货结束时间
			/// </summary>
[Newtonsoft.Json.JsonProperty("etd_end")]//) private String etdEnd;
				internal string etdEnd;


			/// <summary>
			/// 发货类型: 0, xxx 时间开始发货, 1, 付款 n 天后发货。
			/// </summary>
[Newtonsoft.Json.JsonProperty("etd_type")]//) private Nullable<long> etdType;
				internal long? etdType;


			/// <summary>
			/// 付款成功 后发货天数。
			/// </summary>
[Newtonsoft.Json.JsonProperty("etd_days")]//) private Nullable<long> etdDays;
				internal long? etdDays;

				public virtual string PresaleEnd
				{
					set
					{
					this.presaleEnd = value;
					}
					get
					{
					return this.presaleEnd;
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


				public virtual string EtdEnd
				{
					set
					{
					this.etdEnd = value;
					}
					get
					{
					return this.etdEnd;
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


		}


	}
}