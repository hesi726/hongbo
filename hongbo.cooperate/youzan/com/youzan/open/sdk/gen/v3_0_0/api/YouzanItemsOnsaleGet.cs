using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanItemsOnsaleGetResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanItemsOnsaleGetResult;
    using YouzanItemsOnsaleGetParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanItemsOnsaleGetParams;

    public class YouzanItemsOnsaleGet : AbstractAPI <YouzanItemsOnsaleGetParams, YouzanItemsOnsaleGetResult>
	{

		public YouzanItemsOnsaleGet()
		{
		}

		public YouzanItemsOnsaleGet(YouzanItemsOnsaleGetParams apiParams)
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
				return "youzan.items.onsale.get";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanItemsOnsaleGetResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanItemsOnsaleGetParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}