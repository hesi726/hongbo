namespace com.youzan.open.sdk.gen.v3_0_0.model
{
    using APIResult = com.youzan.open.sdk.model.APIResult;

    public class YouzanMaterialsStoragePlatformImgUploadResult : APIResult
	{



        		/// <summary>
		/// 图片链接
		/// </summary>
[Newtonsoft.Json.JsonProperty("image_url")] //private String imageUrl;
        
		private string imageUrl;


		/// <summary>
		/// 店铺id
		/// </summary>
[Newtonsoft.Json.JsonProperty("kdt_id")]//) private Nullable<long> kdtId;
		private long? kdtId;


		/// <summary>
		/// 图片id
		/// </summary>
[Newtonsoft.Json.JsonProperty("image_id")]//) private Nullable<long> imageId;
		private long? imageId;

		public virtual string ImageUrl
		{
			set
			{
				this.imageUrl = value;
			}
			get
			{
				return this.imageUrl;
			}
		}

		public virtual long? KdtId
		{
			set
			{
				this.kdtId = value;
			}
			get
			{
				return this.kdtId;
			}
		}

		public virtual long? ImageId
		{
			set
			{
				this.imageId = value;
			}
			get
			{
				return this.imageId;
			}
		}



	}
}