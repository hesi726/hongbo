using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanItemcategoriesTagDeleteResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanItemcategoriesTagDeleteResult;
    using YouzanItemcategoriesTagDeleteParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanItemcategoriesTagDeleteParams;

    public class YouzanItemcategoriesTagDelete : AbstractAPI <YouzanItemcategoriesTagDeleteParams, YouzanItemcategoriesTagDeleteResult>
	{

		public YouzanItemcategoriesTagDelete()
		{
		}

		public YouzanItemcategoriesTagDelete(YouzanItemcategoriesTagDeleteParams apiParams)
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
				return "youzan.itemcategories.tag.delete";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanItemcategoriesTagDeleteResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanItemcategoriesTagDeleteParams);
			}
		}

		public override bool hasFiles()
		{
			return true;
		}

	}
}