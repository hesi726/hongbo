using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanMaterialsVideoUploadPublishResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanMaterialsVideoUploadPublishResult;
    using YouzanMaterialsVideoUploadPublishParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanMaterialsVideoUploadPublishParams;

    public class YouzanMaterialsVideoUploadPublish : AbstractAPI <YouzanMaterialsVideoUploadPublishParams, YouzanMaterialsVideoUploadPublishResult>
	{

		public YouzanMaterialsVideoUploadPublish()
		{
		}

		public YouzanMaterialsVideoUploadPublish(YouzanMaterialsVideoUploadPublishParams apiParams)
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
				return "youzan.materials.video.upload.publish";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanMaterialsVideoUploadPublishResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanMaterialsVideoUploadPublishParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}