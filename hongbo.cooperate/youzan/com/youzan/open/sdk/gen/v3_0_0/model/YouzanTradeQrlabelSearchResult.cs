namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanTradeQrlabelSearchResult : APIResult
	{



		/// <summary>
		/// 返回记录总数
		/// </summary>
[Newtonsoft.Json.JsonProperty("total_results")]//) private QrTotalResult totalResults;
		private QrTotalResult totalResults;


		/// <summary>
		/// 二维码标签列表
		/// </summary>
[Newtonsoft.Json.JsonProperty("qrlabels")]//) private TradeCashierQrLabel[] qrlabels;
		private TradeCashierQrLabel[] qrlabels;

		public virtual QrTotalResult TotalResults
		{
			set
			{
				this.totalResults = value;
			}
			get
			{
				return this.totalResults;
			}
		}

		public virtual TradeCashierQrLabel[] Qrlabels
		{
			set
			{
				this.qrlabels = value;
			}
			get
			{
				return this.qrlabels;
			}
		}


		public class TradeCashierQrLabel
		{


			/// <summary>
			/// 关联的自助二维码数量
			/// </summary>
[Newtonsoft.Json.JsonProperty("nou_quota_count")]//) private Nullable<long> nouQuotaCount;
				internal long? nouQuotaCount;


			/// <summary>
			/// 标签名称
			/// </summary>
[Newtonsoft.Json.JsonProperty("label_name")]//) private String labelName;
				internal string labelName;


			/// <summary>
			/// 标签创建日期
			/// </summary>
[Newtonsoft.Json.JsonProperty("create_time")]//) private String createTime;
				internal string createTime;


			/// <summary>
			/// 标签修改日期
			/// </summary>
[Newtonsoft.Json.JsonProperty("modify_time")]//) private String modifyTime;
				internal string modifyTime;


			/// <summary>
			/// 关联的定额二维码数量
			/// </summary>
[Newtonsoft.Json.JsonProperty("quota_count")]//) private Nullable<long> quotaCount;
				internal long? quotaCount;


			/// <summary>
			/// 标签编号
			/// </summary>
[Newtonsoft.Json.JsonProperty("id")]//) private String id;
				internal string id;

				public virtual long? NouQuotaCount
				{
					set
					{
					this.nouQuotaCount = value;
					}
					get
					{
					return this.nouQuotaCount;
					}
				}


				public virtual string LabelName
				{
					set
					{
					this.labelName = value;
					}
					get
					{
					return this.labelName;
					}
				}


				public virtual string CreateTime
				{
					set
					{
					this.createTime = value;
					}
					get
					{
					return this.createTime;
					}
				}


				public virtual string ModifyTime
				{
					set
					{
					this.modifyTime = value;
					}
					get
					{
					return this.modifyTime;
					}
				}


				public virtual long? QuotaCount
				{
					set
					{
					this.quotaCount = value;
					}
					get
					{
					return this.quotaCount;
					}
				}


				public virtual string Id
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

		public class QrTotalResult
		{


			/// <summary>
			/// 结果总数
			/// </summary>
[Newtonsoft.Json.JsonProperty("total")]//) private Nullable<int> total;
				internal int? total;

				public virtual int? Total
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


		}


	}
}