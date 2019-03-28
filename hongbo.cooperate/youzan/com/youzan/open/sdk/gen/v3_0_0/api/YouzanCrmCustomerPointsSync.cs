using System;

namespace com.youzan.open.sdk.gen.v3_0_0.api
{

    using com.youzan.open.sdk.api;
    using YouzanCrmCustomerPointsSyncResult = com.youzan.open.sdk.gen.v3_0_0.model.YouzanCrmCustomerPointsSyncResult;
    using YouzanCrmCustomerPointsSyncParams = com.youzan.open.sdk.gen.v3_0_0.model.YouzanCrmCustomerPointsSyncParams;

    public class YouzanCrmCustomerPointsSync : AbstractAPI <YouzanCrmCustomerPointsSyncParams, YouzanCrmCustomerPointsSyncResult>
	{

		public YouzanCrmCustomerPointsSync()
		{
		}

		public YouzanCrmCustomerPointsSync(YouzanCrmCustomerPointsSyncParams apiParams)
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
				return "youzan.crm.customer.points.sync";
			}
		}

		public override Type ResultModelClass
		{
			get
			{
				return typeof(YouzanCrmCustomerPointsSyncResult);
			}
		}

		public override Type ParamModelClass
		{
			get
			{
				return typeof(YouzanCrmCustomerPointsSyncParams);
			}
		}

		public override bool hasFiles()
		{
			return false;
		}

	}
}