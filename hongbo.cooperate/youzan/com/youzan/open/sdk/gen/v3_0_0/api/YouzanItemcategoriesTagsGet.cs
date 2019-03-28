using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanItemcategoriesTagsGetResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanItemcategoriesTagsGetResult;
    using YouzanItemcategoriesTagsGetParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanItemcategoriesTagsGetParams;

    public class YouzanItemcategoriesTagsGet : AbstractAPI <YouzanItemcategoriesTagsGetParams, YouzanItemcategoriesTagsGetResult>
	{

		public YouzanItemcategoriesTagsGet()
		{
		}

		public YouzanItemcategoriesTagsGet(YouzanItemcategoriesTagsGetParams apiParams)
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
				return "youzan.itemcategories.tags.get";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanItemcategoriesTagsGetResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanItemcategoriesTagsGetParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}