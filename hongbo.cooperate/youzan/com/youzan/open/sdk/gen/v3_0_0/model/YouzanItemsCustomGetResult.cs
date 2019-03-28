namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanItemsCustomGetResult : APIResult
	{



		/// <summary>
		/// 搜索到的商品列表
		/// </summary>
[Newtonsoft.Json.JsonProperty("items")]//) private ItemListOpenModel[] items;
		private ItemListOpenModel[] items;


		/// <summary>
		/// 商品总数量
		/// </summary>
[Newtonsoft.Json.JsonProperty("count")]//) private Nullable<long> count;
		private long? count;

		public virtual ItemListOpenModel[] Items
		{
			set
			{
				this.items = value;
			}
			get
			{
				return this.items;
			}
		}

		public virtual long? Count
		{
			set
			{
				this.count = value;
			}
			get
			{
				return this.count;
			}
		}


		public class ItemListOpenModel
		{


			/// <summary>
			/// 商品的数字id
			/// </summary>
[Newtonsoft.Json.JsonProperty("item_id")]//) private Nullable<long> itemId;
				internal long? itemId;


			/// <summary>
			/// 商品别名，是一串字符
			/// </summary>
[Newtonsoft.Json.JsonProperty("alias")]//) private String alias;
				internal string alias;


			/// <summary>
			/// 商品标题
			/// </summary>
[Newtonsoft.Json.JsonProperty("title")]//) private String title;
				internal string title;


			/// <summary>
			/// 价格，单位分
			/// </summary>
[Newtonsoft.Json.JsonProperty("price")]//) private Nullable<long> price;
				internal long? price;


			/// <summary>
			/// 商品类型
			/// </summary>
[Newtonsoft.Json.JsonProperty("item_type")]//) private Nullable<long> itemType;
				internal long? itemType;


			/// <summary>
			/// 商家编码，商家给商品设置的商家编码。
			/// </summary>
[Newtonsoft.Json.JsonProperty("item_no")]//) private String itemNo;
				internal string itemNo;


			/// <summary>
			/// 总库存
			/// </summary>
[Newtonsoft.Json.JsonProperty("quantity")]//) private Nullable<long> quantity;
				internal long? quantity;


			/// <summary>
			/// 运费类型，1 是统一运费，2是运费模板
			/// </summary>
[Newtonsoft.Json.JsonProperty("post_type")]//) private Nullable<long> postType;
				internal long? postType;


			/// <summary>
			/// 运费，单位分。当post_type为1时的运费
			/// </summary>
[Newtonsoft.Json.JsonProperty("post_fee")]//) private Nullable<long> postFee;
				internal long? postFee;


			/// <summary>
			/// 创建时间
			/// </summary>
[Newtonsoft.Json.JsonProperty("created_time")]//) private String createdTime;
				internal string createdTime;


			/// <summary>
			/// 更新时间
			/// </summary>
[Newtonsoft.Json.JsonProperty("update_time")]//) private String updateTime;
				internal string updateTime;


			/// <summary>
			/// 商品详情链接
			/// </summary>
[Newtonsoft.Json.JsonProperty("detail_url")]//) private String detailUrl;
				internal string detailUrl;


			/// <summary>
			/// 运费模板信息
			/// </summary>
[Newtonsoft.Json.JsonProperty("delivery_template")]//) private DeliveryTemplateOpenModel deliveryTemplate;
				internal DeliveryTemplateOpenModel deliveryTemplate;


			/// <summary>
			/// 商家排序字段
			/// </summary>
[Newtonsoft.Json.JsonProperty("num")]//) private Nullable<long> num;
				internal long? num;


			/// <summary>
			/// 图片信息
			/// </summary>
[Newtonsoft.Json.JsonProperty("item_imgs")]//) private ItemImageOpenModel[] itemImgs;
				internal ItemImageOpenModel[] itemImgs;


			/// <summary>
			/// 商品划线价
			/// </summary>
[Newtonsoft.Json.JsonProperty("origin")]//) private String origin;
				internal string origin;


			/// <summary>
			/// 默认为"youzan_goods_selling"
			/// </summary>
[Newtonsoft.Json.JsonProperty("classId")]//) private String classId;
				internal string classId;


			/// <summary>
			/// 图片链接
			/// </summary>
[Newtonsoft.Json.JsonProperty("image")]//) private String image;
				internal string image;


			/// <summary>
			/// 同image
			/// </summary>
[Newtonsoft.Json.JsonProperty("shareIcon")]//) private String shareIcon;
				internal string shareIcon;


			/// <summary>
			/// 商品标题
			/// </summary>
[Newtonsoft.Json.JsonProperty("shareTitle")]//) private String shareTitle;
				internal string shareTitle;


			/// <summary>
			/// 同price
			/// </summary>
[Newtonsoft.Json.JsonProperty("shareDetail")]//) private Nullable<long> shareDetail;
				internal long? shareDetail;

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


				public virtual string CreatedTime
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


				public virtual string UpdateTime
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


				public virtual DeliveryTemplateOpenModel DeliveryTemplate
				{
					set
					{
					this.deliveryTemplate = value;
					}
					get
					{
					return this.deliveryTemplate;
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


				public virtual string ClassId
				{
					set
					{
					this.classId = value;
					}
					get
					{
					return this.classId;
					}
				}


				public virtual string Image
				{
					set
					{
					this.image = value;
					}
					get
					{
					return this.image;
					}
				}


				public virtual string ShareIcon
				{
					set
					{
					this.shareIcon = value;
					}
					get
					{
					return this.shareIcon;
					}
				}


				public virtual string ShareTitle
				{
					set
					{
					this.shareTitle = value;
					}
					get
					{
					return this.shareTitle;
					}
				}


				public virtual long? ShareDetail
				{
					set
					{
					this.shareDetail = value;
					}
					get
					{
					return this.shareDetail;
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


	}
}