namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanItemReviewsQueryResult : APIResult
	{



		/// <summary>
		/// data里包含的是list对象，即多条商品评价记录，可以参考正确结果里面的例子，里面有评价模型的各个字段
		/// </summary>
[Newtonsoft.Json.JsonProperty("itemReviewsModels")]//) private ItemReviewsOpenVOPaginatorResult itemReviewsModels;
		private ItemReviewsOpenVOPaginatorResult itemReviewsModels;


		/// <summary>
		/// 评价用户头像url
		/// </summary>
[Newtonsoft.Json.JsonProperty("withAvatarList")]//) private withAvatarList withAvatarList;
		private withAvatarList _withAvatarList;

		public virtual ItemReviewsOpenVOPaginatorResult ItemReviewsModels
		{
			set
			{
				this.itemReviewsModels = value;
			}
			get
			{
				return this.itemReviewsModels;
			}
		}

		public virtual withAvatarList WithAvatarList
		{
			set
			{
				this._withAvatarList = value;
			}
			get
			{
				return this._withAvatarList;
			}
		}


		public class ItemReviewsModelExtListWithPaginatorVOPaginator
		{


			/// <summary>
			/// 页数
			/// </summary>
[Newtonsoft.Json.JsonProperty("page")]//) private Nullable<long> page;
				internal long? page;


			/// <summary>
			/// 是否成功
			/// </summary>
[Newtonsoft.Json.JsonProperty("success")]//) private Nullable<bool> success;
				internal bool? success;


			/// <summary>
			/// 总数
			/// </summary>
[Newtonsoft.Json.JsonProperty("totalCount")]//) private Nullable<long> totalCount;
				internal long? totalCount;

				public virtual long? Page
				{
					set
					{
					this.page = value;
					}
					get
					{
					return this.page;
					}
				}


				public virtual bool? Success
				{
					set
					{
					this.success = value;
					}
					get
					{
					return this.success;
					}
				}


				public virtual long? TotalCount
				{
					set
					{
					this.totalCount = value;
					}
					get
					{
					return this.totalCount;
					}
				}


		}

		public class withAvatarList
		{


			/// <summary>
			/// 评价用户的头像url
			/// </summary>
[Newtonsoft.Json.JsonProperty("fans_picture")]//) private String fansPicture;
				internal string fansPicture;

				public virtual string FansPicture
				{
					set
					{
					this.fansPicture = value;
					}
					get
					{
					return this.fansPicture;
					}
				}


		}

		public class ItemReviewsOpenVOPaginatorResult
		{


			/// <summary>
			/// code
			/// </summary>
[Newtonsoft.Json.JsonProperty("code")]//) private Nullable<long> code;
				internal long? code;


			/// <summary>
			/// 是否成功
			/// </summary>
[Newtonsoft.Json.JsonProperty("success")]//) private Nullable<bool> success;
				internal bool? success;


			/// <summary>
			/// 错误msg
			/// </summary>
[Newtonsoft.Json.JsonProperty("message")]//) private String message;
				internal string message;


[Newtonsoft.Json.JsonProperty("data")]//) private ItemReviewsModelExtListWithPaginatorVOPaginator data;
				internal ItemReviewsModelExtListWithPaginatorVOPaginator data;
			/// 

				public virtual long? Code
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


				public virtual bool? Success
				{
					set
					{
					this.success = value;
					}
					get
					{
					return this.success;
					}
				}


				public virtual string Message
				{
					set
					{
					this.message = value;
					}
					get
					{
					return this.message;
					}
				}


				public virtual ItemReviewsModelExtListWithPaginatorVOPaginator Data
				{
					set
					{
					this.data = value;
					}
					get
					{
					return this.data;
					}
				}


		}


	}
}