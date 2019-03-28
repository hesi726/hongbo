using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanMaterialsVideoUploadTokenGetResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanMaterialsVideoUploadTokenGetResult;
    using YouzanMaterialsVideoUploadTokenGetParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanMaterialsVideoUploadTokenGetParams;

    public class YouzanMaterialsVideoUploadTokenGet : AbstractAPI <YouzanMaterialsVideoUploadTokenGetParams, YouzanMaterialsVideoUploadTokenGetResult>
	{

		public YouzanMaterialsVideoUploadTokenGet()
		{
		}

		public YouzanMaterialsVideoUploadTokenGet(YouzanMaterialsVideoUploadTokenGetParams apiParams)
		{
			this.@params = apiParams;
		}

		public override string HttpMethod
		{
			get
			{
				return "GET";
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
				return "youzan.materials.video.upload.token.get";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanMaterialsVideoUploadTokenGetResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanMaterialsVideoUploadTokenGetParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}