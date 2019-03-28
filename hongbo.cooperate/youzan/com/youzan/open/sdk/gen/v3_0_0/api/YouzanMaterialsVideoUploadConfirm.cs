using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanMaterialsVideoUploadConfirmResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanMaterialsVideoUploadConfirmResult;
    using YouzanMaterialsVideoUploadConfirmParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanMaterialsVideoUploadConfirmParams;

    public class YouzanMaterialsVideoUploadConfirm : AbstractAPI <YouzanMaterialsVideoUploadConfirmParams, YouzanMaterialsVideoUploadConfirmResult>
	{

		public YouzanMaterialsVideoUploadConfirm()
		{
		}

		public YouzanMaterialsVideoUploadConfirm(YouzanMaterialsVideoUploadConfirmParams apiParams)
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
				return "youzan.materials.video.upload.confirm";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanMaterialsVideoUploadConfirmResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanMaterialsVideoUploadConfirmParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}