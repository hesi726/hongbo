using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanItemReviewsCountResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanItemReviewsCountResult;
    using YouzanItemReviewsCountParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanItemReviewsCountParams;

    public class YouzanItemReviewsCount : AbstractAPI <YouzanItemReviewsCountParams, YouzanItemReviewsCountResult>
	{

		public YouzanItemReviewsCount()
		{
		}

		public YouzanItemReviewsCount(YouzanItemReviewsCountParams apiParams)
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
				return "youzan.item.reviews.count";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanItemReviewsCountResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanItemReviewsCountParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}