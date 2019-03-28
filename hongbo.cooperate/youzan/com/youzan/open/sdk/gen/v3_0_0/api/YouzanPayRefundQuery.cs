using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanPayRefundQueryResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanPayRefundQueryResult;
    using YouzanPayRefundQueryParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanPayRefundQueryParams;

    public class YouzanPayRefundQuery : AbstractAPI <YouzanPayRefundQueryParams, YouzanPayRefundQueryResult>
	{

		public YouzanPayRefundQuery()
		{
		}

		public YouzanPayRefundQuery(YouzanPayRefundQueryParams apiParams)
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
				return "youzan.pay.refund.query";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanPayRefundQueryResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanPayRefundQueryParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}