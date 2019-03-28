using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanItemcategoriesTaglistSearchResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanItemcategoriesTaglistSearchResult;
    using YouzanItemcategoriesTaglistSearchParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanItemcategoriesTaglistSearchParams;

    public class YouzanItemcategoriesTaglistSearch : AbstractAPI <YouzanItemcategoriesTaglistSearchParams, YouzanItemcategoriesTaglistSearchResult>
	{

		public YouzanItemcategoriesTaglistSearch()
		{
		}

		public YouzanItemcategoriesTaglistSearch(YouzanItemcategoriesTaglistSearchParams apiParams)
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
				return "youzan.itemcategories.taglist.search";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanItemcategoriesTaglistSearchResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanItemcategoriesTaglistSearchParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}