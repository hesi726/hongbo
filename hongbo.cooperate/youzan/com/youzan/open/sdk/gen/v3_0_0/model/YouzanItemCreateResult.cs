namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;

    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanItemCreateResult : APIResult
	{



		/// <summary>
		/// 创建成功后的商品详情
		/// </summary>
[Newtonsoft.Json.JsonProperty("item")]//) private ItemDetailOpenModel item;
		private ItemDetailOpenModel item;

		public virtual ItemDetailOpenModel Item
		{
			set
			{
				this.item = value;
			}
			get
			{
				return this.item;
			}
		}


		public class FenxiaoExtendOpenModel
		{


			/// <summary>
			/// 供货店铺Id
			/// </summary>
[Newtonsoft.Json.JsonProperty("supplier_kdt_id")]//) private Nullable<long> supplierKdtId;
				internal long? supplierKdtId;


			/// <summary>
			/// 供货商品Id
			/// </summary>
[Newtonsoft.Json.JsonProperty("supplier_goods_id")]//) private Nullable<long> supplierGoodsId;
				internal long? supplierGoodsId;

				public virtual long? SupplierKdtId
				{
					set
					{
					this.supplierKdtId = value;
					}
					get
					{
					return this.supplierKdtId;
					}
				}


				public virtual long? SupplierGoodsId
				{
					set
					{
					this.supplierGoodsId = value;
					}
					get
					{
					return this.supplierGoodsId;
					}
				}


		}

		public class ItemHotelOpenModel
		{


			/// <summary>
			/// 客服电话区号
			/// </summary>
[Newtonsoft.Json.JsonProperty("service_tel_code")]//) private String serviceTelCode;
				internal string serviceTelCode;


			/// <summary>
			/// 客服电话
			/// </summary>
[Newtonsoft.Json.JsonProperty("service_tel")]//) private String serviceTel;
				internal string serviceTel;

				public virtual string ServiceTelCode
				{
					set
					{
					this.serviceTelCode = value;
					}
					get
					{
					return this.serviceTelCode;
					}
				}


				public virtual string ServiceTel
				{
					set
					{
					this.serviceTel = value;
					}
					get
					{
					return this.serviceTel;
					}
				}


		}

		public class DeliveryTemplateOpenModel
		{


			/// <summary>
			/// 运费模板ID
			/// </summary>
[Newtonsoft.Json.JsonProperty("delivery_template_id")]//) private Nullable<long> deliveryTemplateId;
				internal long? deliveryTemplateId;


			/// <summary>
			/// 运费的范围
			/// </summary>
[Newtonsoft.Json.JsonProperty("delivery_template_fee")]//) private String deliveryTemplateFee;
				internal string deliveryTemplateFee;


			/// <summary>
			/// 运费模板名称
			/// </summary>
[Newtonsoft.Json.JsonProperty("delivery_template_name")]//) private String deliveryTemplateName;
				internal string deliveryTemplateName;


			/// <summary>
			/// 运费模版的计算类型，1 按件 2 按重量 3 按体积
			/// </summary>
[Newtonsoft.Json.JsonProperty("delivery_template_valuationType")]//) private Nullable<long> deliveryTemplateValuationtype;
				internal long? deliveryTemplateValuationtype;

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


				public virtual string DeliveryTemplateFee
				{
					set
					{
					this.deliveryTemplateFee = value;
					}
					get
					{
					return this.deliveryTemplateFee;
					}
				}


				public virtual string DeliveryTemplateName
				{
					set
					{
					this.deliveryTemplateName = value;
					}
					get
					{
					return this.deliveryTemplateName;
					}
				}


				public virtual long? DeliveryTemplateValuationtype
				{
					set
					{
					this.deliveryTemplateValuationtype = value;
					}
					get
					{
					return this.deliveryTemplateValuationtype;
					}
				}


		}

		public class SkuImageOpenModel
		{


			/// <summary>
			/// 规格值ID
			/// </summary>
[Newtonsoft.Json.JsonProperty("v_id")]//) private Nullable<long> vId;
				internal long? vId;


			/// <summary>
			/// 规格项ID，第一级规格项
			/// </summary>
[Newtonsoft.Json.JsonProperty("k_id")]//) private Nullable<long> kId;
				internal long? kId;


			/// <summary>
			/// SKU图片链接
			/// </summary>
[Newtonsoft.Json.JsonProperty("img_url")]//) private String imgUrl;
				internal string imgUrl;

				public virtual long? VId
				{
					set
					{
					this.vId = value;
					}
					get
					{
					return this.vId;
					}
				}


				public virtual long? KId
				{
					set
					{
					this.kId = value;
					}
					get
					{
					return this.kId;
					}
				}


				public virtual string ImgUrl
				{
					set
					{
					this.imgUrl = value;
					}
					get
					{
					return this.imgUrl;
					}
				}


		}

		public class ItemDetailOpenModel
		{


			/// <summary>
			/// 商品id
			/// </summary>
[Newtonsoft.Json.JsonProperty("item_id")]//) private Nullable<long> itemId;
				internal long? itemId;


			/// <summary>
			/// 店铺id
			/// </summary>
[Newtonsoft.Json.JsonProperty("kdt_id")]//) private Nullable<long> kdtId;
				internal long? kdtId;


			/// <summary>
			/// 标题
			/// </summary>
[Newtonsoft.Json.JsonProperty("title")]//) private String title;
				internal string title;


			/// <summary>
			/// 商品内容
			/// </summary>
[Newtonsoft.Json.JsonProperty("desc")]//) private String desc;
				internal string desc;


			/// <summary>
			/// 商品划线价格，可以自定义。例如 促销价：888
			/// </summary>
[Newtonsoft.Json.JsonProperty("origin_price")]//) private String originPrice;
				internal string originPrice;


			/// <summary>
			/// 每人限购多少件。0代表无限购，默认为0
			/// </summary>
[Newtonsoft.Json.JsonProperty("buy_quota")]//) private Nullable<long> buyQuota;
				internal long? buyQuota;


			/// <summary>
			/// 创建时间
			/// </summary>
[Newtonsoft.Json.JsonProperty("created")]//) private String created;
				internal string created;


			/// <summary>
			/// 短地址
			/// </summary>
[Newtonsoft.Json.JsonProperty("alias")]//) private String alias;
				internal string alias;


			/// <summary>
			/// 商品分类的叶子类目id
			/// </summary>
[Newtonsoft.Json.JsonProperty("cid")]//) private Nullable<long> cid;
				internal long? cid;


			/// <summary>
			/// 商品标签id列表
			/// </summary>
[Newtonsoft.Json.JsonProperty("tag_ids")]//) private string[] tagIds;
				internal string[] tagIds;


			/// <summary>
			/// 适合wap应用的商品详情url
			/// </summary>
[Newtonsoft.Json.JsonProperty("detail_url")]//) private String detailUrl;
				internal string detailUrl;


			/// <summary>
			/// 分享出去的商品详情url
			/// </summary>
[Newtonsoft.Json.JsonProperty("share_url")]//) private String shareUrl;
				internal string shareUrl;


			/// <summary>
			/// 商品主图片地址
			/// </summary>
[Newtonsoft.Json.JsonProperty("pic_url")]//) private String picUrl;
				internal string picUrl;


			/// <summary>
			/// 商品主图片缩略图地址
			/// </summary>
[Newtonsoft.Json.JsonProperty("pic_thumb_url")]//) private String picThumbUrl;
				internal string picThumbUrl;


			/// <summary>
			/// 总库存
			/// </summary>
[Newtonsoft.Json.JsonProperty("quantity")]//) private Nullable<long> quantity;
				internal long? quantity;


			/// <summary>
			/// 总销量
			/// </summary>
[Newtonsoft.Json.JsonProperty("sold_num")]//) private Nullable<long> soldNum;
				internal long? soldNum;


			/// <summary>
			/// 价格(分)
			/// </summary>
[Newtonsoft.Json.JsonProperty("price")]//) private Nullable<long> price;
				internal long? price;


			/// <summary>
			/// 商品类型
			/// 0：普通商品
			/// 3：UMP降价拍
			/// 5：外卖商品
			/// 10：分销商品
			/// 20：会员卡商品
			/// 21：礼品卡商品
			/// 22：团购券
			/// 25：批发商品
			/// 30：收银台商品
			/// 31：知识付费商品
			/// 35：酒店商品
			/// 40：美业商品
			/// 60：虚拟商品
			/// 61：电子卡券
			/// </summary>
[Newtonsoft.Json.JsonProperty("item_type")]//) private Nullable<long> itemType;
				internal long? itemType;


			/// <summary>
			/// 商品上架状态。true 为已上架，false 为已下架
			/// </summary>
[Newtonsoft.Json.JsonProperty("is_listing")]//) private Nullable<bool> isListing;
				internal bool? isListing;


			/// <summary>
			/// 商品是否锁定。true 为已锁定，false 为未锁定
			/// </summary>
[Newtonsoft.Json.JsonProperty("is_lock")]//) private Nullable<bool> isLock;
				internal bool? isLock;


			/// <summary>
			/// 商品定时上架（定时开售）的时间。没设置则为空
			/// </summary>
[Newtonsoft.Json.JsonProperty("auto_listing_time")]//) private String autoListingTime;
				internal string autoListingTime;


			/// <summary>
			/// 是否参加会员折扣
			/// </summary>
[Newtonsoft.Json.JsonProperty("join_level_discount")]//) private Nullable<bool> joinLevelDiscount;
				internal bool? joinLevelDiscount;


			/// <summary>
			/// 是否设置商品购买权限
			/// </summary>
[Newtonsoft.Json.JsonProperty("purchase_right")]//) private Nullable<bool> purchaseRight;
				internal bool? purchaseRight;


			/// <summary>
			/// 运费类型
			/// </summary>
[Newtonsoft.Json.JsonProperty("post_type")]//) private Nullable<long> postType;
				internal long? postType;


			/// <summary>
			/// 运费
			/// </summary>
[Newtonsoft.Json.JsonProperty("post_fee")]//) private Nullable<long> postFee;
				internal long? postFee;


			/// <summary>
			/// 商品货号（商家为商品设置的外部编号，可与商家外部系统对接）
			/// </summary>
[Newtonsoft.Json.JsonProperty("item_no")]//) private String itemNo;
				internal string itemNo;


			/// <summary>
			/// 商品预售信息
			/// </summary>
[Newtonsoft.Json.JsonProperty("presale_extend")]//) private ItemPreSaleOpenModel presaleExtend;
				internal ItemPreSaleOpenModel presaleExtend;


			/// <summary>
			/// 商品分销信息
			/// </summary>
[Newtonsoft.Json.JsonProperty("fenxiao_extend")]//) private FenxiaoExtendOpenModel fenxiaoExtend;
				internal FenxiaoExtendOpenModel fenxiaoExtend;


			/// <summary>
			/// 商品酒店扩展信息
			/// </summary>
[Newtonsoft.Json.JsonProperty("hotel_extend")]//) private ItemHotelOpenModel hotelExtend;
				internal ItemHotelOpenModel hotelExtend;


			/// <summary>
			/// 虚拟商品扩展信息
			/// </summary>
[Newtonsoft.Json.JsonProperty("virtual_extend")]//) private ItemVirtualOpenModel virtualExtend;
				internal ItemVirtualOpenModel virtualExtend;


			/// <summary>
			/// 运费模板信息
			/// </summary>
[Newtonsoft.Json.JsonProperty("delivery_template_info")]//) private DeliveryTemplateOpenModel deliveryTemplateInfo;
				internal DeliveryTemplateOpenModel deliveryTemplateInfo;


			/// <summary>
			/// 商品规格库存信息
			/// </summary>
[Newtonsoft.Json.JsonProperty("skus")]//) private ItemSkuOpenModel[] skus;
				internal ItemSkuOpenModel[] skus;


			/// <summary>
			/// 图片信息
			/// </summary>
[Newtonsoft.Json.JsonProperty("item_imgs")]//) private ItemImageOpenModel[] itemImgs;
				internal ItemImageOpenModel[] itemImgs;


			/// <summary>
			/// 分组信息返回信息
			/// </summary>
[Newtonsoft.Json.JsonProperty("item_tags")]//) private GroupOpenModel[] itemTags;
				internal GroupOpenModel[] itemTags;


			/// <summary>
			/// 商品留言
			/// </summary>
[Newtonsoft.Json.JsonProperty("messages")]//) private String messages;
				internal string messages;


			/// <summary>
			/// 商品详情模板信息
			/// </summary>
[Newtonsoft.Json.JsonProperty("template")]//) private TemplateOpenModel template;
				internal TemplateOpenModel template;


			/// <summary>
			/// 购买权限信息
			/// </summary>
[Newtonsoft.Json.JsonProperty("purchase_rightList")]//) private PurchaseRightOpenModel purchaseRightlist;
				internal PurchaseRightOpenModel purchaseRightlist;


			/// <summary>
			/// open api商品SKU图片模型
			/// </summary>
[Newtonsoft.Json.JsonProperty("sku_images")]//) private SkuImageOpenModel[] skuImages;
				internal SkuImageOpenModel[] skuImages;


			/// <summary>
			/// 商家排序字段
			/// </summary>
[Newtonsoft.Json.JsonProperty("num")]//) private Nullable<long> num;
				internal long? num;


			/// <summary>
			/// 商品卖点
			/// </summary>
[Newtonsoft.Json.JsonProperty("sell_point")]//) private String sellPoint;
				internal string sellPoint;

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


				public virtual string Desc
				{
					set
					{
					this.desc = value;
					}
					get
					{
					return this.desc;
					}
				}


				public virtual string OriginPrice
				{
					set
					{
					this.originPrice = value;
					}
					get
					{
					return this.originPrice;
					}
				}


				public virtual long? BuyQuota
				{
					set
					{
					this.buyQuota = value;
					}
					get
					{
					return this.buyQuota;
					}
				}


				public virtual string Created
				{
					set
					{
					this.created = value;
					}
					get
					{
					return this.created;
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


				public virtual long? Cid
				{
					set
					{
					this.cid = value;
					}
					get
					{
					return this.cid;
					}
				}


				public virtual string[] TagIds
				{
					set
					{
					this.tagIds = value;
					}
					get
					{
					return this.tagIds;
					}
				}


				public virtual string DetailUrl
				{
					set
					{
					this.detailUrl = value;
					}
					get
					{
					return this.detailUrl;
					}
				}


				public virtual string ShareUrl
				{
					set
					{
					this.shareUrl = value;
					}
					get
					{
					return this.shareUrl;
					}
				}


				public virtual string PicUrl
				{
					set
					{
					this.picUrl = value;
					}
					get
					{
					return this.picUrl;
					}
				}


				public virtual string PicThumbUrl
				{
					set
					{
					this.picThumbUrl = value;
					}
					get
					{
					return this.picThumbUrl;
					}
				}


				public virtual long? Quantity
				{
					set
					{
					this.quantity = value;
					}
					get
					{
					return this.quantity;
					}
				}


				public virtual long? SoldNum
				{
					set
					{
					this.soldNum = value;
					}
					get
					{
					return this.soldNum;
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


				public virtual long? ItemType
				{
					set
					{
					this.itemType = value;
					}
					get
					{
					return this.itemType;
					}
				}


				public virtual bool? IsListing
				{
					set
					{
					this.isListing = value;
					}
					get
					{
					return this.isListing;
					}
				}


				public virtual bool? IsLock
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


				public virtual string AutoListingTime
				{
					set
					{
					this.autoListingTime = value;
					}
					get
					{
					return this.autoListingTime;
					}
				}


				public virtual bool? JoinLevelDiscount
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


				public virtual long? PostType
				{
					set
					{
					this.postType = value;
					}
					get
					{
					return this.postType;
					}
				}


				public virtual long? PostFee
				{
					set
					{
					this.postFee = value;
					}
					get
					{
					return this.postFee;
					}
				}


				public virtual string ItemNo
				{
					set
					{
					this.itemNo = value;
					}
					get
					{
					return this.itemNo;
					}
				}


				public virtual ItemPreSaleOpenModel PresaleExtend
				{
					set
					{
					this.presaleExtend = value;
					}
					get
					{
					return this.presaleExtend;
					}
				}


				public virtual FenxiaoExtendOpenModel FenxiaoExtend
				{
					set
					{
					this.fenxiaoExtend = value;
					}
					get
					{
					return this.fenxiaoExtend;
					}
				}


				public virtual ItemHotelOpenModel HotelExtend
				{
					set
					{
					this.hotelExtend = value;
					}
					get
					{
					return this.hotelExtend;
					}
				}


				public virtual ItemVirtualOpenModel VirtualExtend
				{
					set
					{
					this.virtualExtend = value;
					}
					get
					{
					return this.virtualExtend;
					}
				}


				public virtual DeliveryTemplateOpenModel DeliveryTemplateInfo
				{
					set
					{
					this.deliveryTemplateInfo = value;
					}
					get
					{
					return this.deliveryTemplateInfo;
					}
				}


				public virtual ItemSkuOpenModel[] Skus
				{
					set
					{
					this.skus = value;
					}
					get
					{
					return this.skus;
					}
				}


				public virtual ItemImageOpenModel[] ItemImgs
				{
					set
					{
					this.itemImgs = value;
					}
					get
					{
					return this.itemImgs;
					}
				}


				public virtual GroupOpenModel[] ItemTags
				{
					set
					{
					this.itemTags = value;
					}
					get
					{
					return this.itemTags;
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


				public virtual TemplateOpenModel Template
				{
					set
					{
					this.template = value;
					}
					get
					{
					return this.template;
					}
				}


				public virtual PurchaseRightOpenModel PurchaseRightlist
				{
					set
					{
					this.purchaseRightlist = value;
					}
					get
					{
					return this.purchaseRightlist;
					}
				}


				public virtual SkuImageOpenModel[] SkuImages
				{
					set
					{
					this.skuImages = value;
					}
					get
					{
					return this.skuImages;
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


				public virtual string SellPoint
				{
					set
					{
					this.sellPoint = value;
					}
					get
					{
					return this.sellPoint;
					}
				}


		}

		public class GroupOpenModel
		{


			/// <summary>
			/// Id
			/// </summary>
[Newtonsoft.Json.JsonProperty("id")]//) private Nullable<long> id;
				internal long? id;


			/// <summary>
			/// 分组类型
			/// </summary>
[Newtonsoft.Json.JsonProperty("type")]//) private Nullable<long> type;
				internal long? type;


			/// <summary>
			/// 别名
			/// </summary>
[Newtonsoft.Json.JsonProperty("alias")]//) private String alias;
				internal string alias;


			/// <summary>
			/// 分组链接
			/// </summary>
[Newtonsoft.Json.JsonProperty("tag_url")]//) private String tagUrl;
				internal string tagUrl;


			/// <summary>
			/// 分享链接
			/// </summary>
[Newtonsoft.Json.JsonProperty("share_url")]//) private String shareUrl;
				internal string shareUrl;


			/// <summary>
			/// 商品数量
			/// </summary>
[Newtonsoft.Json.JsonProperty("item_num")]//) private Nullable<long> itemNum;
				internal long? itemNum;


			/// <summary>
			/// 创建时间
			/// </summary>
[Newtonsoft.Json.JsonProperty("created")]//) private String created;
				internal string created;


			/// <summary>
			/// 描述
			/// </summary>
[Newtonsoft.Json.JsonProperty("desc")]//) private String desc;
				internal string desc;


			/// <summary>
			/// 分组名称
			/// </summary>
[Newtonsoft.Json.JsonProperty("name")]//) private String name;
				internal string name;

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


				public virtual long? Type
				{
					set
					{
					this.type = value;
					}
					get
					{
					return this.type;
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


				public virtual string TagUrl
				{
					set
					{
					this.tagUrl = value;
					}
					get
					{
					return this.tagUrl;
					}
				}


				public virtual string ShareUrl
				{
					set
					{
					this.shareUrl = value;
					}
					get
					{
					return this.shareUrl;
					}
				}


				public virtual long? ItemNum
				{
					set
					{
					this.itemNum = value;
					}
					get
					{
					return this.itemNum;
					}
				}


				public virtual string Created
				{
					set
					{
					this.created = value;
					}
					get
					{
					return this.created;
					}
				}


				public virtual string Desc
				{
					set
					{
					this.desc = value;
					}
					get
					{
					return this.desc;
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

		public class ItemSkuOpenModel
		{


			/// <summary>
			/// 商品ID
			/// </summary>
[Newtonsoft.Json.JsonProperty("item_id")]//) private Nullable<long> itemId;
				internal long? itemId;


			/// <summary>
			/// 规格ID
			/// </summary>
[Newtonsoft.Json.JsonProperty("sku_id")]//) private Nullable<long> skuId;
				internal long? skuId;


			/// <summary>
			/// 唯一编码，店铺Id和商品Id组合
			/// </summary>
[Newtonsoft.Json.JsonProperty("sku_unique_code")]//) private String skuUniqueCode;
				internal string skuUniqueCode;


			/// <summary>
			/// Sku所对应的销售属性的Json字符串（需另行解析）。
			/// 格式定义：
			/// [
			/// {
			/// "kid": "20000",
			/// "vid": "3275069",
			/// "k": "品牌",
			/// "v": "盈讯"
			/// },
			/// {
			/// "kid": "1753146",
			/// "vid": "3485013",
			/// "k": "型号",
			/// "v": "F908"
			/// }
			/// </summary>
[Newtonsoft.Json.JsonProperty("properties_name_json")]//) private String propertiesNameJson;
				internal string propertiesNameJson;


			/// <summary>
			/// 商品在付款减库存的状态下，该Sku上未付款的订单数量
			/// </summary>
[Newtonsoft.Json.JsonProperty("with_hold_quantity")]//) private Nullable<long> withHoldQuantity;
				internal long? withHoldQuantity;


			/// <summary>
			/// 商品的这个Sku的价格，单位 分
			/// </summary>
[Newtonsoft.Json.JsonProperty("price")]//) private Nullable<long> price;
				internal long? price;


			/// <summary>
			/// Sku创建日期，时间格式：yyyy-MM-dd HH:mm:ss
			/// </summary>
[Newtonsoft.Json.JsonProperty("created")]//) private String created;
				internal string created;


			/// <summary>
			/// Sku最后修改日期，时间格式：yyyy-MM-dd HH:mm:ss
			/// </summary>
[Newtonsoft.Json.JsonProperty("modified")]//) private String modified;
				internal string modified;


			/// <summary>
			/// 属于这个Sku的商品的数量
			/// </summary>
[Newtonsoft.Json.JsonProperty("quantity")]//) private Nullable<long> quantity;
				internal long? quantity;


			/// <summary>
			/// 商家编码（商家为Sku设置的外部编号）
			/// </summary>
[Newtonsoft.Json.JsonProperty("item_no")]//) private String itemNo;
				internal string itemNo;


			/// <summary>
			/// 属于这个Sku的销量
			/// </summary>
[Newtonsoft.Json.JsonProperty("sold_num")]//) private Nullable<long> soldNum;
				internal long? soldNum;


			/// <summary>
			/// 属于这个Sku的成本价
			/// </summary>
[Newtonsoft.Json.JsonProperty("cost_price")]//) private Nullable<long> costPrice;
				internal long? costPrice;

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


				public virtual long? SkuId
				{
					set
					{
					this.skuId = value;
					}
					get
					{
					return this.skuId;
					}
				}


				public virtual string SkuUniqueCode
				{
					set
					{
					this.skuUniqueCode = value;
					}
					get
					{
					return this.skuUniqueCode;
					}
				}


				public virtual string PropertiesNameJson
				{
					set
					{
					this.propertiesNameJson = value;
					}
					get
					{
					return this.propertiesNameJson;
					}
				}


				public virtual long? WithHoldQuantity
				{
					set
					{
					this.withHoldQuantity = value;
					}
					get
					{
					return this.withHoldQuantity;
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


				public virtual string Created
				{
					set
					{
					this.created = value;
					}
					get
					{
					return this.created;
					}
				}


				public virtual string Modified
				{
					set
					{
					this.modified = value;
					}
					get
					{
					return this.modified;
					}
				}


				public virtual long? Quantity
				{
					set
					{
					this.quantity = value;
					}
					get
					{
					return this.quantity;
					}
				}


				public virtual string ItemNo
				{
					set
					{
					this.itemNo = value;
					}
					get
					{
					return this.itemNo;
					}
				}


				public virtual long? SoldNum
				{
					set
					{
					this.soldNum = value;
					}
					get
					{
					return this.soldNum;
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

		public class TemplateOpenModel
		{


			/// <summary>
			/// 模板ID
			/// </summary>
[Newtonsoft.Json.JsonProperty("template_id")]//) private Nullable<long> templateId;
				internal long? templateId;


			/// <summary>
			/// 模板名称
			/// </summary>
[Newtonsoft.Json.JsonProperty("template_title")]//) private String templateTitle;
				internal string templateTitle;

				public virtual long? TemplateId
				{
					set
					{
					this.templateId = value;
					}
					get
					{
					return this.templateId;
					}
				}


				public virtual string TemplateTitle
				{
					set
					{
					this.templateTitle = value;
					}
					get
					{
					return this.templateTitle;
					}
				}


		}

		public class ItemImageOpenModel
		{


			/// <summary>
			/// 图片链接地址
			/// </summary>
[Newtonsoft.Json.JsonProperty("url")]//) private String url;
				internal string url;


			/// <summary>
			/// 图片缩略图链接地址
			/// </summary>
[Newtonsoft.Json.JsonProperty("thumbnail")]//) private String thumbnail;
				internal string thumbnail;


			/// <summary>
			/// 中号大小图片链接地址
			/// </summary>
[Newtonsoft.Json.JsonProperty("medium")]//) private String medium;
				internal string medium;


			/// <summary>
			/// 组合图片链接地址
			/// </summary>
[Newtonsoft.Json.JsonProperty("combine")]//) private String combine;
				internal string combine;


			/// <summary>
			/// 图片创建时间，时间格式：yyyy-MM-dd HH:mm:ss
			/// </summary>
[Newtonsoft.Json.JsonProperty("created")]//) private String created;
				internal string created;


			/// <summary>
			/// 图片ID
			/// </summary>
[Newtonsoft.Json.JsonProperty("id")]//) private Nullable<long> id;
				internal long? id;

				public virtual string Url
				{
					set
					{
					this.url = value;
					}
					get
					{
					return this.url;
					}
				}


				public virtual string Thumbnail
				{
					set
					{
					this.thumbnail = value;
					}
					get
					{
					return this.thumbnail;
					}
				}


				public virtual string Medium
				{
					set
					{
					this.medium = value;
					}
					get
					{
					return this.medium;
					}
				}


				public virtual string Combine
				{
					set
					{
					this.combine = value;
					}
					get
					{
					return this.combine;
					}
				}


				public virtual string Created
				{
					set
					{
					this.created = value;
					}
					get
					{
					return this.created;
					}
				}


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


		}

		public class PurchaseRightOpenModel
		{


			/// <summary>
			/// 可购买该商品的用户标签id列表
			/// </summary>
[Newtonsoft.Json.JsonProperty("ump_tags")]//) private String umpTags;
				internal string umpTags;


			/// <summary>
			/// 可购买该商品的会员等级id列表
			/// </summary>
[Newtonsoft.Json.JsonProperty("ump_levels")]//) private String umpLevels;
				internal string umpLevels;


			/// <summary>
			/// 可购买该商品的用户标签名称列表
			/// </summary>
[Newtonsoft.Json.JsonProperty("ump_tags_text")]//) private String umpTagsText;
				internal string umpTagsText;


			/// <summary>
			/// 可购买该商品的会员等级名称列表
			/// </summary>
[Newtonsoft.Json.JsonProperty("ump_level_text")]//) private String umpLevelText;
				internal string umpLevelText;

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


				public virtual string UmpLevels
				{
					set
					{
					this.umpLevels = value;
					}
					get
					{
					return this.umpLevels;
					}
				}


				public virtual string UmpTagsText
				{
					set
					{
					this.umpTagsText = value;
					}
					get
					{
					return this.umpTagsText;
					}
				}


				public virtual string UmpLevelText
				{
					set
					{
					this.umpLevelText = value;
					}
					get
					{
					return this.umpLevelText;
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