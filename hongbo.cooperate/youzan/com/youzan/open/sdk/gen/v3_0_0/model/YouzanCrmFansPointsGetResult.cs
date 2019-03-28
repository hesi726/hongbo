namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanCrmFansPointsGetResult : APIResult
	{



		/// <summary>
		/// 积分具体数值
		/// </summary>
[Newtonsoft.Json.JsonProperty("point")]//) private Nullable<long> point;
		private long? point;

		public virtual long? Point
		{
			set
			{
				this.point = value;
			}
			get
			{
				return this.point;
			}
		}



	}
}