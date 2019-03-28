using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanItemUpdateListingResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanItemUpdateListingResult;
    using YouzanItemUpdateListingParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanItemUpdateListingParams;

    public class YouzanItemUpdateListing : AbstractAPI <YouzanItemUpdateListingParams, YouzanItemUpdateListingResult>
	{

		public YouzanItemUpdateListing()
		{
		}

		public YouzanItemUpdateListing(YouzanItemUpdateListingParams apiParams)
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
				return "youzan.item.update.listing";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanItemUpdateListingResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanItemUpdateListingParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}