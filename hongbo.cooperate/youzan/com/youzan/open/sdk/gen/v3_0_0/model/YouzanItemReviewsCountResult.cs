namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanItemReviewsCountResult : APIResult
	{



		/// <summary>
		/// 差评数量
		/// </summary>
[Newtonsoft.Json.JsonProperty("bad_num")]//) private Nullable<long> badNum;
		private long? badNum;


		/// <summary>
		/// 中评数量
		/// </summary>
[Newtonsoft.Json.JsonProperty("common_num")]//) private Nullable<long> commonNum;
		private long? commonNum;


		/// <summary>
		/// 好评数量
		/// </summary>
[Newtonsoft.Json.JsonProperty("best_num")]//) private Nullable<long> bestNum;
		private long? bestNum;

		public virtual long? BadNum
		{
			set
			{
				this.badNum = value;
			}
			get
			{
				return this.badNum;
			}
		}

		public virtual long? CommonNum
		{
			set
			{
				this.commonNum = value;
			}
			get
			{
				return this.commonNum;
			}
		}

		public virtual long? BestNum
		{
			set
			{
				this.bestNum = value;
			}
			get
			{
				return this.bestNum;
			}
		}



	}
}