using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanItemcategoriesGetResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanItemcategoriesGetResult;
    using YouzanItemcategoriesGetParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanItemcategoriesGetParams;

    public class YouzanItemcategoriesGet : AbstractAPI <YouzanItemcategoriesGetParams, YouzanItemcategoriesGetResult>
	{

		public YouzanItemcategoriesGet()
		{
		}

		public YouzanItemcategoriesGet(YouzanItemcategoriesGetParams apiParams)
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
				return "youzan.itemcategories.get";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanItemcategoriesGetResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanItemcategoriesGetParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}