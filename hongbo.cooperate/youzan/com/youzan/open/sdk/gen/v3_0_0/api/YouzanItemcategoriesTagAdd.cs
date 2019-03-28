using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanItemcategoriesTagAddResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanItemcategoriesTagAddResult;
    using YouzanItemcategoriesTagAddParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanItemcategoriesTagAddParams;

    public class YouzanItemcategoriesTagAdd : AbstractAPI <YouzanItemcategoriesTagAddParams, YouzanItemcategoriesTagAddResult>
	{

		public YouzanItemcategoriesTagAdd()
		{
		}

		public YouzanItemcategoriesTagAdd(YouzanItemcategoriesTagAddParams apiParams)
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
				return "youzan.itemcategories.tag.add";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanItemcategoriesTagAddResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanItemcategoriesTagAddParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}