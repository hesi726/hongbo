namespace com.youzan.open.sdk.gen.v3_0_0.model
{

    ////using ArrayListMultimap = com.google.common.collect.ArrayListMultimap;


    //////using Maps = com.google.common.collect.Maps;


    ////using Multimap = com.google.common.collect.Multimap;


    using APIResult = com.youzan.open.sdk.model.APIResult;
    //using JsonProperty = com.fasterxml.jackson.annotation.JsonProperty;


    public class YouzanMaterialsVideoUploadTokenGetResult : APIResult
	{



		/// <summary>
		/// 上传的远端视频文件路径
		/// </summary>
[Newtonsoft.Json.JsonProperty("video_path")]//) private String videoPath;
		private string videoPath;


		/// <summary>
		/// 视频上传所需的授权签名
		/// </summary>
[Newtonsoft.Json.JsonProperty("token")]//) private String token;
		private string token;


		/// <summary>
		/// 视频上传所需的bucket信息
		/// </summary>
[Newtonsoft.Json.JsonProperty("bucket")]//) private String bucket;
		private string bucket;


		/// <summary>
		/// 视频上传所需的app_id信息
		/// </summary>
[Newtonsoft.Json.JsonProperty("app_id")]//) private String appId;
		private string appId;


		/// <summary>
		/// 视频上传所需的region信息
		/// </summary>
[Newtonsoft.Json.JsonProperty("region")]//) private String region;
		private string region;

		public virtual string VideoPath
		{
			set
			{
				this.videoPath = value;
			}
			get
			{
				return this.videoPath;
			}
		}

		public virtual string Token
		{
			set
			{
				this.token = value;
			}
			get
			{
				return this.token;
			}
		}

		public virtual string Bucket
		{
			set
			{
				this.bucket = value;
			}
			get
			{
				return this.bucket;
			}
		}

		public virtual string AppId
		{
			set
			{
				this.appId = value;
			}
			get
			{
				return this.appId;
			}
		}

		public virtual string Region
		{
			set
			{
				this.region = value;
			}
			get
			{
				return this.region;
			}
		}



	}
}