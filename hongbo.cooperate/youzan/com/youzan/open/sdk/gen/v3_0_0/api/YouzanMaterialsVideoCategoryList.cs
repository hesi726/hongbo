using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanMaterialsVideoCategoryListResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanMaterialsVideoCategoryListResult;
    using YouzanMaterialsVideoCategoryListParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanMaterialsVideoCategoryListParams;

    public class YouzanMaterialsVideoCategoryList : AbstractAPI <YouzanMaterialsVideoCategoryListParams, YouzanMaterialsVideoCategoryListResult>
	{

		public YouzanMaterialsVideoCategoryList()
		{
		}

		public YouzanMaterialsVideoCategoryList(YouzanMaterialsVideoCategoryListParams apiParams)
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
				return "youzan.materials.video.category.list";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanMaterialsVideoCategoryListResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanMaterialsVideoCategoryListParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}