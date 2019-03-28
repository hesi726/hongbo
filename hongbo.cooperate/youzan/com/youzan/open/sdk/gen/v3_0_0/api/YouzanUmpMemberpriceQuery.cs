using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanUmpMemberpriceQueryResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanUmpMemberpriceQueryResult;
    using YouzanUmpMemberpriceQueryParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanUmpMemberpriceQueryParams;

    public class YouzanUmpMemberpriceQuery : AbstractAPI <YouzanUmpMemberpriceQueryParams, YouzanUmpMemberpriceQueryResult>
	{

		public YouzanUmpMemberpriceQuery()
		{
		}

		public YouzanUmpMemberpriceQuery(YouzanUmpMemberpriceQueryParams apiParams)
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
				return "youzan.ump.memberprice.query";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanUmpMemberpriceQueryResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanUmpMemberpriceQueryParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}