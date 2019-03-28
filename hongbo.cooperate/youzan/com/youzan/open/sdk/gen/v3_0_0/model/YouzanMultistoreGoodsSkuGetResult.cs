using System;

namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanMultistoreGoodsSkuGetResult : APIResult
	{



		/// <summary>
		/// 接口仅返回 商品独立库存、价格、商家编码和独立SKU等字段，具体 和 响应示例 的字段一致
		/// </summary>
[Newtonsoft.Json.JsonProperty("item")]//) private GoodsDetail item;
		private GoodsDetail item;

		public virtual GoodsDetail Item
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


		public class GoodsSku
		{


			/// <summary>
			/// 商家编码（商家为Sku设置的外部编号）
			/// </summary>
[Newtonsoft.Json.JsonProperty("outer_id")]//) private String outerId;
				internal string outerId;


			/// <summary>
			/// Sku的ID，sku_id 在系统里<span style="color: #ff0000;">并不是唯一的</span>，结合商品ID一起使用才是唯一的。
			/// </summary>
[Newtonsoft.Json.JsonProperty("sku_id")]//) private Nullable<long> skuId;
				internal long? skuId;


			/// <summary>
			/// Sku在系统中的唯一编号，可以在开发者的系统中用作 Sku 的唯一ID，但不能用于调用接口
			/// </summary>
[Newtonsoft.Json.JsonProperty("sku_unique_code")]//) private String skuUniqueCode;
				internal string skuUniqueCode;


			/// <summary>
			/// Sku所属商品的数字编号
			/// </summary>
[Newtonsoft.Json.JsonProperty("num_iid")]//) private Nullable<long> numIid;
				internal long? numIid;


			/// <summary>
			/// 属于这个Sku的商品的数量
			/// </summary>
[Newtonsoft.Json.JsonProperty("quantity")]//) private Nullable<long> quantity;
				internal long? quantity;


			/// <summary>
			/// Sku所对应的销售属性的中文名字串，格式如：pid1:vid1:pid_name1:vid_name1;pid2:vid2:pid_name2:vid_name2……
			/// </summary>
[Newtonsoft.Json.JsonProperty("properties_name")]//) private String propertiesName;
				internal string propertiesName;


			/// <summary>
			/// Sku所对应的销售属性的Json字符串（需另行解析），
			/// 该字段内容与properties_name字段除了格式不一样，内容完全一致。
			/// 由于产品规格信息难以避免涉及到‘:’、‘,’、‘;’这些与解析规则冲突的字符，所以增加该字段。
			/// </br>格式定义：
			/// <pre>
			/// 
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
			/// .....
			/// </summary>
[Newtonsoft.Json.JsonProperty("properties_name_json")]//) private String propertiesNameJson;
				internal string propertiesNameJson;


			/// <summary>
			/// 商品在付款减库存的状态下，该Sku上未付款的订单数量
			/// </summary>
[Newtonsoft.Json.JsonProperty("with_hold_quantity")]//) private Nullable<long> withHoldQuantity;
				internal long? withHoldQuantity;


			/// <summary>
			/// 商品的这个Sku的价格；精确到2位小数；单位：元
			/// </summary>
[Newtonsoft.Json.JsonProperty("price")]//) private Nullable<float> price;
				internal float? price;


			/// <summary>
			/// Sku创建日期，时间格式：yyyy-MM-dd HH:mm:ss
			/// </summary>
[Newtonsoft.Json.JsonProperty("created")]//) private java.util.Date created;
				internal DateTime created;


			/// <summary>
			/// Sku最后修改日期，时间格式：yyyy-MM-dd HH:mm:ss
			/// </summary>
[Newtonsoft.Json.JsonProperty("modified")]//) private java.util.Date modified;
				internal DateTime modified;


			/// <summary>
			/// Sku库存是否锁定 0:未锁定 1:锁定
			/// </summary>
[Newtonsoft.Json.JsonProperty("stock_locked")]//) private Nullable<long> stockLocked;
				internal long? stockLocked;

				public virtual string OuterId
				{
					set
					{
					this.outerId = value;
					}
					get
					{
					return this.outerId;
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


				public virtual long? NumIid
				{
					set
					{
					this.numIid = value;
					}
					get
					{
					return this.numIid;
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


				public virtual string PropertiesName
				{
					set
					{
					this.propertiesName = value;
					}
					get
					{
					return this.propertiesName;
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


				public virtual float? Price
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


				public virtual DateTime Created
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


				public virtual DateTime Modified
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


				public virtual long? StockLocked
				{
					set
					{
					this.stockLocked = value;
					}
					get
					{
					return this.stockLocked;
					}
				}


		}

		public class GoodsTag
		{


			/// <summary>
			/// 商品标签的ID
			/// </summary>
[Newtonsoft.Json.JsonProperty("id")]//) private Nullable<long> id;
				internal long? id;


			/// <summary>
			/// 商品标签的名称
			/// </summary>
[Newtonsoft.Json.JsonProperty("name")]//) private String name;
				internal string name;


			/// <summary>
			/// 商品标签类型，0 自定义，1 未分类，2 最新，3 最热，4 隐藏
			/// </summary>
[Newtonsoft.Json.JsonProperty("type")]//) private Nullable<long> type;
				internal long? type;


			/// <summary>
			/// 商品标签创建时间
			/// </summary>
[Newtonsoft.Json.JsonProperty("created")]//) private String created;
				internal string created;


			/// <summary>
			/// 商品标签内的商品数量
			/// </summary>
[Newtonsoft.Json.JsonProperty("item_num")]//) private Nullable<long> itemNum;
				internal long? itemNum;


			/// <summary>
			/// 商品标签的展示的URL地址
			/// </summary>
[Newtonsoft.Json.JsonProperty("tag_url")]//) private String tagUrl;
				internal string tagUrl;


			/// <summary>
			/// 分享出去的商品标签展示地址
			/// </summary>
[Newtonsoft.Json.JsonProperty("share_url")]//) private String shareUrl;
				internal string shareUrl;


			/// <summary>
			/// 商品标签描述
			/// </summary>
[Newtonsoft.Json.JsonProperty("desc")]//) private String desc;
				internal string desc;

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


		}

		public class GoodsImage
		{


			/// <summary>
			/// 商品图片的ID
			/// </summary>
[Newtonsoft.Json.JsonProperty("id")]//) private Nullable<long> id;
				internal long? id;


			/// <summary>
			/// 图片创建时间，时间格式：yyyy-MM-dd HH:mm:ss
			/// </summary>
[Newtonsoft.Json.JsonProperty("created")]//) private java.util.Date created;
				internal DateTime created;


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


				public virtual DateTime Created
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


		}

		public class GoodsQrcode
		{


			/// <summary>
			/// 商品二维码的ID
			/// </summary>
[Newtonsoft.Json.JsonProperty("id")]//) private Nullable<long> id;
				internal long? id;


			/// <summary>
			/// 二维码的名称
			/// </summary>
[Newtonsoft.Json.JsonProperty("name")]//) private String name;
				internal string name;


			/// <summary>
			/// 二维码的描述
			/// </summary>
[Newtonsoft.Json.JsonProperty("desc")]//) private String desc;
				internal string desc;


			/// <summary>
			/// 商品二维码创建时间，时间格式：yyyy-MM-dd HH:mm:ss
			/// </summary>
[Newtonsoft.Json.JsonProperty("created")]//) private java.util.Date created;
				internal DateTime created;


			/// <summary>
			/// 商品二维码类型。可选值：<br>
			/// GOODS_SCAN_FOLLOW(扫码关注后购买商品) <br>
			/// GOODS_SCAN_FOLLOW_DECREASE(扫码关注后减优惠额) <br>
			/// GOODS_SCAN_FOLLOW_DISCOUNT(扫码关注后折扣) <br>
			/// GOODS_SCAN_DECREASE(扫码直接减优惠额) <br>
			/// GOODS_SCAN_DISCOUNT(扫码直接折扣) <br>
			/// </summary>
[Newtonsoft.Json.JsonProperty("type")]//) private String type;
				internal string type;


			/// <summary>
			/// 折扣，格式：9.0；单位：折，精确到小数点后 1 位。如果没有折扣，则为 0
			/// </summary>
[Newtonsoft.Json.JsonProperty("discount")]//) private String discount;
				internal string discount;


			/// <summary>
			/// 减金额优惠，格式：5.00；单位：元；精确到：分。如果没有减额优惠，则为 0
			/// </summary>
[Newtonsoft.Json.JsonProperty("decrease")]//) private Nullable<float> decrease;
				internal float? decrease;


			/// <summary>
			/// 扫码直接购买的二维码基于这个url生成。如果不是扫码直接购买的类型，则为空
			/// </summary>
[Newtonsoft.Json.JsonProperty("link_url")]//) private String linkUrl;
				internal string linkUrl;


			/// <summary>
			/// 扫码关注购买的二维码图片地址。如果不是扫码关注购买的类型，则为空
			/// </summary>
[Newtonsoft.Json.JsonProperty("weixin_qrcode_url")]//) private String weixinQrcodeUrl;
				internal string weixinQrcodeUrl;

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


				public virtual DateTime Created
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


				public virtual string Type
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


				public virtual string Discount
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


				public virtual float? Decrease
				{
					set
					{
					this.decrease = value;
					}
					get
					{
					return this.decrease;
					}
				}


				public virtual string LinkUrl
				{
					set
					{
					this.linkUrl = value;
					}
					get
					{
					return this.linkUrl;
					}
				}


				public virtual string WeixinQrcodeUrl
				{
					set
					{
					this.weixinQrcodeUrl = value;
					}
					get
					{
					return this.weixinQrcodeUrl;
					}
				}


		}

		public class GoodsDetail
		{


			/// <summary>
			/// 商品数字编号
			/// </summary>
[Newtonsoft.Json.JsonProperty("num_iid")]//) private Nullable<long> numIid;
				internal long? numIid;


			/// <summary>
			/// 商品别称
			/// </summary>
[Newtonsoft.Json.JsonProperty("alias")]//) private String alias;
				internal string alias;


			/// <summary>
			/// 商品标题
			/// </summary>
[Newtonsoft.Json.JsonProperty("title")]//) private String title;
				internal string title;


			/// <summary>
			/// 商品分类的叶子类目id，可参考API：kdt.itemcategories.get
			/// </summary>
[Newtonsoft.Json.JsonProperty("cid")]//) private Nullable<long> cid;
				internal long? cid;


			/// <summary>
			/// 商品推广栏目id，可参考API：kdt.itemcategories.promotions.get
			/// </summary>
[Newtonsoft.Json.JsonProperty("promotion_cid")]//) private Nullable<long> promotionCid;
				internal long? promotionCid;


			/// <summary>
			/// 商品标签id串，结构如：1234,1342,...，可参考API：kdt.itemcategories.tags.get
			/// </summary>
[Newtonsoft.Json.JsonProperty("tag_ids")]//) private String tagIds;
				internal string tagIds;


			/// <summary>
			/// 商品描述
			/// </summary>
[Newtonsoft.Json.JsonProperty("desc")]//) private String desc;
				internal string desc;


			/// <summary>
			/// 显示在"原价"一栏中的信息
			/// </summary>
[Newtonsoft.Json.JsonProperty("origin_price")]//) private String originPrice;
				internal string originPrice;


			/// <summary>
			/// 商品货号（商家为商品设置的外部编号，可与商家外部系统对接）
			/// </summary>
[Newtonsoft.Json.JsonProperty("outer_id")]//) private String outerId;
				internal string outerId;


			/// <summary>
			/// 商品外部购买链接
			/// </summary>
[Newtonsoft.Json.JsonProperty("outer_buy_url")]//) private String outerBuyUrl;
				internal string outerBuyUrl;


			/// <summary>
			/// 每人限购多少件。0代表无限购，默认为0
			/// </summary>
[Newtonsoft.Json.JsonProperty("buy_quota")]//) private Nullable<long> buyQuota;
				internal long? buyQuota;


			/// <summary>
			/// 商品的发布时间
			/// </summary>
[Newtonsoft.Json.JsonProperty("created")]//) private java.util.Date created;
				internal DateTime created;


			/// <summary>
			/// 是否为虚拟商品
			/// </summary>
[Newtonsoft.Json.JsonProperty("is_virtual")]//) private Nullable<bool> isVirtual;
				internal bool? isVirtual;


			/// <summary>
			/// 普通商品0，电子卡券3
			/// </summary>
[Newtonsoft.Json.JsonProperty("virtual_type")]//) private Nullable<long> virtualType;
				internal long? virtualType;


			/// <summary>
			/// 长期有效，留空；非空表示自定义有效期的开始时间
			/// </summary>
[Newtonsoft.Json.JsonProperty("item_validity_start")]//) private Nullable<long> itemValidityStart;
				internal long? itemValidityStart;


			/// <summary>
			/// 长期有效，留空；非空表示自定义有效期的开始时间
			/// </summary>
[Newtonsoft.Json.JsonProperty("item_validity_end")]//) private Nullable<long> itemValidityEnd;
				internal long? itemValidityEnd;


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
[Newtonsoft.Json.JsonProperty("holidays_available")]//) private Nullable<long> holidaysAvailable;
				internal long? holidaysAvailable;


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
			/// 是否为二手商品
			/// </summary>
[Newtonsoft.Json.JsonProperty("is_used")]//) private Nullable<bool> isUsed;
				internal bool? isUsed;


			/// <summary>
			/// 是否为二手商品
			/// </summary>
[Newtonsoft.Json.JsonProperty("product_type")]//) private String productType;
				internal string productType;


			/// <summary>
			/// 商品定时上架（定时开售）的时间。没设置则为空
			/// </summary>
[Newtonsoft.Json.JsonProperty("auto_listing_time")]//) private java.util.Date autoListingTime;
				internal DateTime autoListingTime;


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
			/// 商品数量
			/// </summary>
[Newtonsoft.Json.JsonProperty("num")]//) private Nullable<long> num;
				internal long? num;


			/// <summary>
			/// 商品销量
			/// </summary>
[Newtonsoft.Json.JsonProperty("sold_num")]//) private Nullable<long> soldNum;
				internal long? soldNum;


			/// <summary>
			/// 商品价格，格式：5.00；单位：元；精确到：分
			/// </summary>
[Newtonsoft.Json.JsonProperty("price")]//) private Nullable<float> price;
				internal float? price;


			/// <summary>
			/// 运费类型。<br>1：统一邮费；<br>2：运费模版;
			/// </summary>
[Newtonsoft.Json.JsonProperty("post_type")]//) private Nullable<long> postType;
				internal long? postType;


			/// <summary>
			/// 运费（针对"统一运费"），格式：5.00；单位：元；精确到：分
			/// </summary>
[Newtonsoft.Json.JsonProperty("post_fee")]//) private Nullable<float> postFee;
				internal float? postFee;


			/// <summary>
			/// 运费（针对"运费模版"），格式：5.00；单位：元；精确到：分<br>若存在运费区间，中间用逗号隔开，如 "5.00,9.00"
			/// </summary>
[Newtonsoft.Json.JsonProperty("delivery_template_fee")]//) private String deliveryTemplateFee;
				internal string deliveryTemplateFee;


			/// <summary>
			/// 运费模版id
			/// </summary>
[Newtonsoft.Json.JsonProperty("delivery_template_id")]//) private Nullable<long> deliveryTemplateId;
				internal long? deliveryTemplateId;


			/// <summary>
			/// 运费模版名称
			/// </summary>
[Newtonsoft.Json.JsonProperty("delivery_template_name")]//) private String deliveryTemplateName;
				internal string deliveryTemplateName;


			/// <summary>
			/// Sku数据结构
			/// </summary>
[Newtonsoft.Json.JsonProperty("skus")]//) private GoodsSku[] skus;
				internal GoodsSku[] skus;


			/// <summary>
			/// 商品图片数据结构
			/// </summary>
[Newtonsoft.Json.JsonProperty("item_imgs")]//) private GoodsImage[] itemImgs;
				internal GoodsImage[] itemImgs;


			/// <summary>
			/// 商品二维码数据结构
			/// </summary>
[Newtonsoft.Json.JsonProperty("item_qrcodes")]//) private GoodsQrcode[] itemQrcodes;
				internal GoodsQrcode[] itemQrcodes;


			/// <summary>
			/// 商品标签数据结构
			/// </summary>
[Newtonsoft.Json.JsonProperty("item_tags")]//) private GoodsTag[] itemTags;
				internal GoodsTag[] itemTags;


			/// <summary>
			/// 商品类型。<br>0：普通商品；<br>10：分销商品;
			/// </summary>
[Newtonsoft.Json.JsonProperty("item_type")]//) private Nullable<long> itemType;
				internal long? itemType;


			/// <summary>
			/// 是否是供货商商品。
			/// </summary>
[Newtonsoft.Json.JsonProperty("is_supplier_item")]//) private Nullable<bool> isSupplierItem;
				internal bool? isSupplierItem;


			/// <summary>
			/// 商品点赞数
			/// </summary>
[Newtonsoft.Json.JsonProperty("like_count")]//) private Nullable<long> likeCount;
				internal long? likeCount;


			/// <summary>
			/// 模板id
			/// </summary>
[Newtonsoft.Json.JsonProperty("template_id")]//) private Nullable<long> templateId;
				internal long? templateId;


			/// <summary>
			/// 模板名称
			/// </summary>
[Newtonsoft.Json.JsonProperty("template_title")]//) private String templateTitle;
				internal string templateTitle;


			/// <summary>
			/// 是否参加会员折扣
			/// </summary>
[Newtonsoft.Json.JsonProperty("join_level_discount")]//) private Nullable<bool> joinLevelDiscount;
				internal bool? joinLevelDiscount;


			/// <summary>
			/// 商品留言
			/// </summary>
[Newtonsoft.Json.JsonProperty("messages")]//) private Object messages;
				internal object messages;


			/// <summary>
			/// 商品序号
			/// </summary>
[Newtonsoft.Json.JsonProperty("order")]//) private Nullable<long> order;
				internal long? order;


			/// <summary>
			/// 是否设置商品购买权限
			/// </summary>
[Newtonsoft.Json.JsonProperty("purchase_right")]//) private Nullable<long> purchaseRight;
				internal long? purchaseRight;


			/// <summary>
			/// 可购买该商品的用户标签id列表
			/// </summary>
[Newtonsoft.Json.JsonProperty("ump_tags")]//) private Object umpTags;
				internal object umpTags;


			/// <summary>
			/// 可购买该商品的会员等级id列表
			/// </summary>
[Newtonsoft.Json.JsonProperty("ump_level")]//) private Object umpLevel;
				internal object umpLevel;


			/// <summary>
			/// 可购买该商品的用户标签名称列表
			/// </summary>
[Newtonsoft.Json.JsonProperty("ump_tags_text")]//) private Object umpTagsText;
				internal object umpTagsText;


			/// <summary>
			/// 可购买该商品的会员等级名称列表
			/// </summary>
[Newtonsoft.Json.JsonProperty("ump_level_text")]//) private Object umpLevelText;
				internal object umpLevelText;


			/// <summary>
			/// 商品库存是否锁定 0:未锁定 1:锁定，如果商品有SKU该字段恒为0
			/// </summary>
[Newtonsoft.Json.JsonProperty("stock_locked")]//) private Nullable<long> stockLocked;
				internal long? stockLocked;

				public virtual long? NumIid
				{
					set
					{
					this.numIid = value;
					}
					get
					{
					return this.numIid;
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


				public virtual long? PromotionCid
				{
					set
					{
					this.promotionCid = value;
					}
					get
					{
					return this.promotionCid;
					}
				}


				public virtual string TagIds
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


				public virtual string OuterId
				{
					set
					{
					this.outerId = value;
					}
					get
					{
					return this.outerId;
					}
				}


				public virtual string OuterBuyUrl
				{
					set
					{
					this.outerBuyUrl = value;
					}
					get
					{
					return this.outerBuyUrl;
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


				public virtual DateTime Created
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


				public virtual bool? IsVirtual
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


				public virtual long? VirtualType
				{
					set
					{
					this.virtualType = value;
					}
					get
					{
					return this.virtualType;
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


				public virtual long? HolidaysAvailable
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


				public virtual bool? IsUsed
				{
					set
					{
					this.isUsed = value;
					}
					get
					{
					return this.isUsed;
					}
				}


				public virtual string ProductType
				{
					set
					{
					this.productType = value;
					}
					get
					{
					return this.productType;
					}
				}


				public virtual DateTime AutoListingTime
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


				public virtual float? Price
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


				public virtual float? PostFee
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


				public virtual GoodsSku[] Skus
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


				public virtual GoodsImage[] ItemImgs
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


				public virtual GoodsQrcode[] ItemQrcodes
				{
					set
					{
					this.itemQrcodes = value;
					}
					get
					{
					return this.itemQrcodes;
					}
				}


				public virtual GoodsTag[] ItemTags
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


				public virtual bool? IsSupplierItem
				{
					set
					{
					this.isSupplierItem = value;
					}
					get
					{
					return this.isSupplierItem;
					}
				}


				public virtual long? LikeCount
				{
					set
					{
					this.likeCount = value;
					}
					get
					{
					return this.likeCount;
					}
				}


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


				public virtual object Messages
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


				public virtual long? Order
				{
					set
					{
					this.order = value;
					}
					get
					{
					return this.order;
					}
				}


				public virtual long? PurchaseRight
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


				public virtual object UmpTags
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


				public virtual object UmpLevel
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


				public virtual object UmpTagsText
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


				public virtual object UmpLevelText
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


				public virtual long? StockLocked
				{
					set
					{
					this.stockLocked = value;
					}
					get
					{
					return this.stockLocked;
					}
				}


		}


	}
}