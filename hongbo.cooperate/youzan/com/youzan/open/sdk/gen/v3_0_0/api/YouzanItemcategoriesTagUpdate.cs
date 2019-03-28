using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanItemcategoriesTagUpdateResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanItemcategoriesTagUpdateResult;
    using YouzanItemcategoriesTagUpdateParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanItemcategoriesTagUpdateParams;

    public class YouzanItemcategoriesTagUpdate : AbstractAPI <YouzanItemcategoriesTagUpdateParams, YouzanItemcategoriesTagUpdateResult>
	{

		public YouzanItemcategoriesTagUpdate()
		{
		}

		public YouzanItemcategoriesTagUpdate(YouzanItemcategoriesTagUpdateParams apiParams)
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
				return "youzan.itemcategories.tag.update";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanItemcategoriesTagUpdateResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanItemcategoriesTagUpdateParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}