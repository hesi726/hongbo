namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanMaterialsVideoCategoryListResult : APIResult
	{



		/// <summary>
		/// 视频分组数量
		/// </summary>
[Newtonsoft.Json.JsonProperty("count")]//) private Nullable<long> count;
		private long? count;


		/// <summary>
		/// 分组名称
		/// </summary>
[Newtonsoft.Json.JsonProperty("category_name")]//) private String categoryName;
		private string categoryName;


		/// <summary>
		/// 分组id
		/// </summary>
[Newtonsoft.Json.JsonProperty("category_id")]//) private Nullable<long> categoryId;
		private long? categoryId;


		/// <summary>
		/// 该分组下的视频数量
		/// </summary>
[Newtonsoft.Json.JsonProperty("video_count")]//) private Nullable<long> videoCount;
		private long? videoCount;

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

		public virtual string CategoryName
		{
			set
			{
				this.categoryName = value;
			}
			get
			{
				return this.categoryName;
			}
		}

		public virtual long? CategoryId
		{
			set
			{
				this.categoryId = value;
			}
			get
			{
				return this.categoryId;
			}
		}

		public virtual long? VideoCount
		{
			set
			{
				this.videoCount = value;
			}
			get
			{
				return this.videoCount;
			}
		}



	}
}