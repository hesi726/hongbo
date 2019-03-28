using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanItemReviewsQueryResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanItemReviewsQueryResult;
    using YouzanItemReviewsQueryParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanItemReviewsQueryParams;

    public class YouzanItemReviewsQuery : AbstractAPI <YouzanItemReviewsQueryParams, YouzanItemReviewsQueryResult>
	{

		public YouzanItemReviewsQuery()
		{
		}

		public YouzanItemReviewsQuery(YouzanItemReviewsQueryParams apiParams)
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
				return "youzan.item.reviews.query";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanItemReviewsQueryResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanItemReviewsQueryParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}