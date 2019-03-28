namespace com.youzan.open.sdk.gen.v1_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanItemStandardGetResult : APIResult
	{



		/// <summary>
		/// 商品标准详情信息
		/// </summary>
[Newtonsoft.Json.JsonProperty("item_standard")]//) private ItemStandardOpenModel itemStandard;
		private ItemStandardOpenModel itemStandard;

		public virtual ItemStandardOpenModel ItemStandard
		{
			set
			{
				this.itemStandard = value;
			}
			get
			{
				return this.itemStandard;
			}
		}


		public class ItemStandardSpuOpenModel
		{


			/// <summary>
			/// 厂商
			/// </summary>
[Newtonsoft.Json.JsonProperty("manu_name")]//) private String manuName;
				internal string manuName;


			/// <summary>
			/// 商品名称
			/// </summary>
[Newtonsoft.Json.JsonProperty("item_name")]//) private String itemName;
				internal string itemName;


			/// <summary>
			/// 商标/品牌
			/// </summary>
[Newtonsoft.Json.JsonProperty("brand")]//) private String brand;
				internal string brand;


			/// <summary>
			/// 有效期
			/// </summary>
[Newtonsoft.Json.JsonProperty("valid_period")]//) private String validPeriod;
				internal string validPeriod;

				public virtual string ManuName
				{
					set
					{
					this.manuName = value;
					}
					get
					{
					return this.manuName;
					}
				}


				public virtual string ItemName
				{
					set
					{
					this.itemName = value;
					}
					get
					{
					return this.itemName;
					}
				}


				public virtual string Brand
				{
					set
					{
					this.brand = value;
					}
					get
					{
					return this.brand;
					}
				}


				public virtual string ValidPeriod
				{
					set
					{
					this.validPeriod = value;
					}
					get
					{
					return this.validPeriod;
					}
				}


		}

		public class ItemStandardExtraOpenModel
		{


			/// <summary>
			/// 扩展信息键ID
			/// </summary>
[Newtonsoft.Json.JsonProperty("kid")]//) private Nullable<long> kid;
				internal long? kid;


			/// <summary>
			/// 扩展信息键名称
			/// </summary>
[Newtonsoft.Json.JsonProperty("attr_key")]//) private String attrKey;
				internal string attrKey;


			/// <summary>
			/// 扩展信息值
			/// </summary>
[Newtonsoft.Json.JsonProperty("attr_value")]//) private String attrValue;
				internal string attrValue;

				public virtual long? Kid
				{
					set
					{
					this.kid = value;
					}
					get
					{
					return this.kid;
					}
				}


				public virtual string AttrKey
				{
					set
					{
					this.attrKey = value;
					}
					get
					{
					return this.attrKey;
					}
				}


				public virtual string AttrValue
				{
					set
					{
					this.attrValue = value;
					}
					get
					{
					return this.attrValue;
					}
				}


		}

		public class ItemStandardOpenModel
		{


			/// <summary>
			/// 条形码编码
			/// </summary>
[Newtonsoft.Json.JsonProperty("code")]//) private String code;
				internal string code;


			/// <summary>
			/// 商品类型
			/// </summary>
[Newtonsoft.Json.JsonProperty("item_type")]//) private String itemType;
				internal string itemType;


			/// <summary>
			/// 价格, 单位为分
			/// </summary>
[Newtonsoft.Json.JsonProperty("price")]//) private Nullable<long> price;
				internal long? price;


			/// <summary>
			/// 图片，格式为JSON，如下
			/// [{"width":320,"id":"20177","url":"http://img.yzcdn.cn/upload_files/2017/07/11/FjM2RwUUXEvcEr6lEyyeH9E_C8rZ.jpg","height":320},{"width":790,"id":"20178","url":"http://img.yzcdn.cn/upload_files/2017/07/11/FlkOmdespJXZg70D40LDODCw51Um.jpg","height":955},{"width":790,"id":"20179","url":"ht
			/// </summary>
[Newtonsoft.Json.JsonProperty("imgs")]//) private String imgs;
				internal string imgs;


			/// <summary>
			/// 商品SPU标准模型
			/// </summary>
[Newtonsoft.Json.JsonProperty("spu")]//) private ItemStandardSpuOpenModel spu;
				internal ItemStandardSpuOpenModel spu;


			/// <summary>
			/// 商品标准扩展信息模型
			/// </summary>
[Newtonsoft.Json.JsonProperty("extra_info")]//) private ItemStandardExtraOpenModel[] extraInfo;
				internal ItemStandardExtraOpenModel[] extraInfo;

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


				public virtual string ItemType
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


				public virtual string Imgs
				{
					set
					{
					this.imgs = value;
					}
					get
					{
					return this.imgs;
					}
				}


				public virtual ItemStandardSpuOpenModel Spu
				{
					set
					{
					this.spu = value;
					}
					get
					{
					return this.spu;
					}
				}


				public virtual ItemStandardExtraOpenModel[] ExtraInfo
				{
					set
					{
					this.extraInfo = value;
					}
					get
					{
					return this.extraInfo;
					}
				}


		}


	}
}