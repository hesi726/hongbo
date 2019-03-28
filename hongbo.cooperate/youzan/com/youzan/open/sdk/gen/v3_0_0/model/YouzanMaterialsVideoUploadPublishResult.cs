namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanMaterialsVideoUploadPublishResult : APIResult
	{



		/// <summary>
		/// 视频video_id
		/// </summary>
[Newtonsoft.Json.JsonProperty("video_id")]//) private Nullable<long> videoId;
		private long? videoId;

		public virtual long? VideoId
		{
			set
			{
				this.videoId = value;
			}
			get
			{
				return this.videoId;
			}
		}



	}
}