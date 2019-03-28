using System;

namespace com.youzan.open.sdk.gen.v1_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanUmpGrouponOrdergroupdetailsGetResult = com.youzan.open.sdk.gen.v1_0_0.model.YouzanUmpGrouponOrdergroupdetailsGetResult;
    using YouzanUmpGrouponOrdergroupdetailsGetParams = com.youzan.open.sdk.gen.v1_0_0.model.YouzanUmpGrouponOrdergroupdetailsGetParams;

    public class YouzanUmpGrouponOrdergroupdetailsGet : AbstractAPI <YouzanUmpGrouponOrdergroupdetailsGetParams, YouzanUmpGrouponOrdergroupdetailsGetResult>
	{

		public YouzanUmpGrouponOrdergroupdetailsGet()
		{
		}

		public YouzanUmpGrouponOrdergroupdetailsGet(YouzanUmpGrouponOrdergroupdetailsGetParams apiParams)
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
				return "1.0.0";
			}
		}

		public override string Name
		{
			get
			{
				return "youzan.ump.groupon.ordergroupdetails.get";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanUmpGrouponOrdergroupdetailsGetResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanUmpGrouponOrdergroupdetailsGetParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}