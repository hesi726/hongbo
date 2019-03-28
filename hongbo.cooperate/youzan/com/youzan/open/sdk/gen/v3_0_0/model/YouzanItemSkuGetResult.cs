namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanItemSkuGetResult : APIResult
	{



		/// <summary>
		/// 返回sku对象
		/// </summary>
[Newtonsoft.Json.JsonProperty("sku")]//) private ItemSku sku;
		private ItemSku sku;

		public virtual ItemSku Sku
		{
			set
			{
				this.sku = value;
			}
			get
			{
				return this.sku;
			}
		}


		public class ItemSku
		{


			/// <summary>
			/// 库存唯一编码
			/// </summary>
[Newtonsoft.Json.JsonProperty("sku_unique_code")]//) private String skuUniqueCode;
				internal string skuUniqueCode;


			/// <summary>
			/// 商品ID
			/// </summary>
[Newtonsoft.Json.JsonProperty("item_id")]//) private Nullable<long> itemId;
				internal long? itemId;


			/// <summary>
			/// SKU ID
			/// </summary>
[Newtonsoft.Json.JsonProperty("sku_id")]//) private Nullable<long> skuId;
				internal long? skuId;


			/// <summary>
			/// 规格属性
			/// </summary>
[Newtonsoft.Json.JsonProperty("properties_name")]//) private String propertiesName;
				internal string propertiesName;


			/// <summary>
			/// 规格属性json串
			/// </summary>
[Newtonsoft.Json.JsonProperty("properties_name_json")]//) private String propertiesNameJson;
				internal string propertiesNameJson;


			/// <summary>
			/// 下单数量 - 销售数量
			/// </summary>
[Newtonsoft.Json.JsonProperty("with_hold_quantity")]//) private Nullable<long> withHoldQuantity;
				internal long? withHoldQuantity;


			/// <summary>
			/// 价格, 单位元,精确到小数点后两位
			/// </summary>
[Newtonsoft.Json.JsonProperty("price")]//) private String price;
				internal string price;


			/// <summary>
			/// 创建时间, 格式:yyyy-MM-dd HH:mm:ss
			/// </summary>
[Newtonsoft.Json.JsonProperty("created")]//) private String created;
				internal string created;


			/// <summary>
			/// 修改时间,格式:yyyy-MM-dd HH:mm:ss
			/// </summary>
[Newtonsoft.Json.JsonProperty("modified")]//) private String modified;
				internal string modified;


			/// <summary>
			/// 库存数量
			/// </summary>
[Newtonsoft.Json.JsonProperty("quantity")]//) private Nullable<long> quantity;
				internal long? quantity;


			/// <summary>
			/// 商品编码
			/// </summary>
[Newtonsoft.Json.JsonProperty("item_no")]//) private String itemNo;
				internal string itemNo;


			/// <summary>
			/// 重量
			/// </summary>
[Newtonsoft.Json.JsonProperty("weight")]//) private String weight;
				internal string weight;

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


				public virtual string Price
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


				public virtual string Weight
				{
					set
					{
					this.weight = value;
					}
					get
					{
					return this.weight;
					}
				}


		}


	}
}