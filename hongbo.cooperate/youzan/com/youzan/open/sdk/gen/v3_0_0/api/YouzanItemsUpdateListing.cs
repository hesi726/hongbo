using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanItemsUpdateListingResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanItemsUpdateListingResult;
    using YouzanItemsUpdateListingParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanItemsUpdateListingParams;

    public class YouzanItemsUpdateListing : AbstractAPI <YouzanItemsUpdateListingParams, YouzanItemsUpdateListingResult>
	{

		public YouzanItemsUpdateListing()
		{
		}

		public YouzanItemsUpdateListing(YouzanItemsUpdateListingParams apiParams)
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
				return "youzan.items.update.listing";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanItemsUpdateListingResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanItemsUpdateListingParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}