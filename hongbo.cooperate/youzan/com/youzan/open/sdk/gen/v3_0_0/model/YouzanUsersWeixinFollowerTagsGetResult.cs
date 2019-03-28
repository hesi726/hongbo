namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;

    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanUsersWeixinFollowerTagsGetResult : APIResult
	{



		/// <summary>
		/// 该粉丝的标签集合
		/// </summary>
[Newtonsoft.Json.JsonProperty("tags")]//) private CrmFansTag[] tags;
		private CrmFansTag[] tags;

		public virtual CrmFansTag[] Tags
		{
			set
			{
				this.tags = value;
			}
			get
			{
				return this.tags;
			}
		}


		public class CrmFansTag
		{


			/// <summary>
			/// 标签ID
			/// </summary>
[Newtonsoft.Json.JsonProperty("tag_id")]//) private Nullable<long> tagId;
				internal long? tagId;


			/// <summary>
			/// 标签名
			/// </summary>
[Newtonsoft.Json.JsonProperty("tag_name")]//) private String tagName;
				internal string tagName;

				public virtual long? TagId
				{
					set
					{
					this.tagId = value;
					}
					get
					{
					return this.tagId;
					}
				}


				public virtual string TagName
				{
					set
					{
					this.tagName = value;
					}
					get
					{
					return this.tagName;
					}
				}


		}


	}
}