using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanPayQueryResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanPayQueryResult;
    using YouzanPayQueryParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanPayQueryParams;

    public class YouzanPayQuery : AbstractAPI <YouzanPayQueryParams, YouzanPayQueryResult>
	{

		public YouzanPayQuery()
		{
		}

		public YouzanPayQuery(YouzanPayQueryParams apiParams)
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
				return "youzan.pay.query";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanPayQueryResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanPayQueryParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}