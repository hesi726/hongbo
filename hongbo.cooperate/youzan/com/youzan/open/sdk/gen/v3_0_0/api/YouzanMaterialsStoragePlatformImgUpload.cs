using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanMaterialsStoragePlatformImgUploadResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanMaterialsStoragePlatformImgUploadResult;
    using YouzanMaterialsStoragePlatformImgUploadParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanMaterialsStoragePlatformImgUploadParams;

    public class YouzanMaterialsStoragePlatformImgUpload : AbstractAPI <YouzanMaterialsStoragePlatformImgUploadParams, YouzanMaterialsStoragePlatformImgUploadResult>
	{

		public YouzanMaterialsStoragePlatformImgUpload()
		{
		}

		public YouzanMaterialsStoragePlatformImgUpload(YouzanMaterialsStoragePlatformImgUploadParams apiParams)
		{
			this.@params = apiParams;
		}

		public override string HttpMethod
		{
			get
			{
				return "POST";
			}
		}

		public override string Version
		{
			get
			{
				return "3.0.0";
			}
		}

		public override string Name
		{
			get
			{
				return "youzan.materials.storage.platform.img.upload";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanMaterialsStoragePlatformImgUploadResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanMaterialsStoragePlatformImgUploadParams);
			}
		}

		public override bool hasFiles()
		{
			return true;
		}

	}
}